Imports System.ComponentModel

Public Class MainX
	Dim errx() As String = {}
	Friend selectedTable As String = ""
	Dim ExecuteData As New DataTable
	Dim ExecuteBSData As New BindingSource
	Dim TableList() As String = {}
	Dim ColumnList() As String = {}
	Dim pendingRefresh As Boolean = False
	Dim Connected As Boolean = False
	Dim SQLiteFile As String = ""

	Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Icon = My.Resources.database
		Me.Text = "SQLx [Build Date: " & My.Computer.FileSystem.GetFileInfo(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName).LastWriteTimeUtc.ToString("yyyy-MM-dd HH:mm:ss") & " UTC]"

		ApplyDataGridViewProperties(DgData)
		With DgData
			.DataSource = ExecuteBSData
			.MultiSelect = True
		End With

		'set strings
		Username = Environment.UserName
		Domain = Environment.UserDomainName
	End Sub

	Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If BgTryConnect.IsBusy Then
			e.Cancel = True
			MessageBox.Show("The app is still trying to connect, do you still want to close the app?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		End If
	End Sub

	Private Sub TxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxServerName.KeyDown
		If e.KeyCode = Keys.Enter Then LbConnect_Click(sender, Nothing)
	End Sub

	Private Sub LbConnect_Click(sender As Object, e As EventArgs) Handles LbConnect.Click
		If BgImport.IsBusy Or BgTryConnect.IsBusy Or BgExecute.IsBusy Or BGgetDetails.IsBusy Or String.IsNullOrEmpty(TxServerName.Text.Trim) Then Exit Sub

		LbConnect.Text = "Connecting..."

		SQLConn = "Data Source=" & TxServerName.Text & ";Version=3;Compress=True;"
		BgTryConnect.RunWorkerAsync(SQLConn)
	End Sub

	Private Sub bgTryConnect_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgTryConnect.DoWork
		Threading.Thread.Sleep(222)
		Try
			Using tryCon As New SQLite.SQLiteConnection(e.Argument.ToString)
				tryCon.Open()
				tryCon.Close()
			End Using
			errx = {}
		Catch ex As Exception
			errx = {Err.Description, Err.Source}
		End Try
	End Sub

	Private Sub bgTryConnect_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgTryConnect.RunWorkerCompleted
		If errx.Count = 2 Then
			With LbStatus
				.Text = ">> Disconnected <<"
				Connected = False
				.ForeColor = Color.Red
			End With
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.EndUpdate()
			End With
			MessageBox.Show(errx(0), errx(1), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			With LbStatus
				.Text = "<< Connected >>"
				Connected = True
				.ForeColor = Color.Green
			End With

			If Not BGgetDetails.IsBusy Then
				With LBoxTable
					.BeginUpdate()
					.Items.Clear()
					.EndUpdate()
				End With
				BGgetDetails.RunWorkerAsync()
			Else
				pendingRefresh = True
				With LBoxTable
					.BeginUpdate()
					.Items.Clear()
					.EndUpdate()
				End With
			End If
		End If

		LbConnect.Text = "Connect"
		LbCreateConnect.Text = "Create New Database then Connect"
	End Sub

	Private Sub BGgetDetails_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGgetDetails.DoWork
		Threading.Thread.Sleep(222)
		TableList = SQLReadQuery("SELECT tbl_name FROM sqlite_master where type='table';", 60, SQLConn).AsEnumerable().Select(Function(x) x.Field(Of String)("tbl_name")).Distinct.ToArray
	End Sub

	Private Sub BGgetDetails_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGgetDetails.RunWorkerCompleted
		If pendingRefresh Then
			pendingRefresh = False
			LbTableRefresh.Text = "Refreshing..."
			BGgetDetails.RunWorkerAsync()
			Exit Sub
		End If

		If TableList.Count > 0 Then
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.Items.AddRange(TableList)
				.EndUpdate()
			End With
		End If

		LbTableRefresh.Text = "Refresh"
	End Sub

	Private Sub LBoxTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxTable.SelectedIndexChanged
		If LBoxTable.SelectedIndex >= 0 Then
			selectedTable = LBoxTable.GetItemText(LBoxTable.SelectedItem)
		Else
			selectedTable = ""
		End If
	End Sub

	Private Sub LbCollapse_Click(sender As Object, e As EventArgs) Handles LbCollapse.Click
		If Not Connected Then Exit Sub

		If panMenu.Width = 200 Then
			If LbStatus.ForeColor = Color.Red Then Exit Sub
			panMenu.Width = 22
			With LbCollapse
				.Text = ">"
				.Height = 452
				.Top = 0
				.Left = 0
			End With
			TxQuery.Focus()
		Else
			panMenu.Width = 200
			With LbCollapse
				.Text = "<"
				.Height = 22
				.Top = 135
				.Left = 178
			End With
		End If
	End Sub

	Private Sub LbExecute_Click(sender As Object, e As EventArgs) Handles LbExecute.Click
		If String.IsNullOrEmpty(TxQuery.Text.Trim) Or BgExecute.IsBusy Or BgTryConnect.IsBusy Or Not Connected Then Exit Sub

		If Not My.Computer.FileSystem.FileExists(SQLiteFile) Then
			MessageBox.Show("Database file seems to be missing." & vbCrLf & vbCrLf & "File: " & SQLiteFile, "Database file not found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If

		LbExecute.Text = "Executing..."
		LbExecute.Enabled = False
		TxQuery.ReadOnly = True
		LbDataCount.Text = "Loading..."
		BgExecute.RunWorkerAsync({TxQuery.Text.Trim})
	End Sub

	Private Sub BgExecute_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgExecute.DoWork
		Dim args() As String = CType(e.Argument, String())
		Dim getdata As New DataTable
		Try
			getdata = SQLReadQuery(args(0), 300, SQLConn).Copy
			errx = {}
		Catch ex As Exception
			errx = {Err.Description, Err.Source}
		End Try
		If errx.Count <> 2 Then
			ExecuteData = New DataTable
			ExecuteData = getdata.Copy
		End If
	End Sub

	Private Sub BgExecute_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgExecute.RunWorkerCompleted
		If errx.Count = 2 Then
			MessageBox.Show(errx(0), errx(1), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			ExecuteBSData.DataSource = ExecuteData
			ExecuteBSData.EndEdit()
		End If
		LbDataCount.Text = ExecuteData.Rows.Count.ToString("#,0")

		LbExecute.Text = "Execute"
		LbExecute.Enabled = True
		TxQuery.ReadOnly = False
	End Sub

	Private Sub LbExport_Click(sender As Object, e As EventArgs) Handles LbExport.Click
		If ExecuteData.Rows.Count = 0 Or BgExport.IsBusy Or BgExecute.IsBusy Then Exit Sub
		With FdBrowse
			.Description = "Select a folder for Export"
			If .ShowDialog = DialogResult.OK Then
				Dim path As String = .SelectedPath & "\" & Now.ToString("yyyy.MM.dd_HH.mm.ss.fff")
				LbExport.Text = "Exporting..."
				BgExport.RunWorkerAsync(path)
			End If
		End With
	End Sub

	Private Sub BgExport_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgExport.DoWork
		Dim path As String = e.Argument.ToString
		Exporter(path, ExecuteData)
		Process.Start("explorer", "/select, " & path & ".xlsx")
	End Sub

	Private Sub BgExport_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgExport.RunWorkerCompleted
		LbExport.Text = "Export"
	End Sub

	Private Sub LbImport_Click(sender As Object, e As EventArgs) Handles LbImport.Click
		If BGgetDetails.IsBusy Or BgImport.IsBusy Or BgTryConnect.IsBusy Or Not Connected Then Exit Sub

		If Not My.Computer.FileSystem.FileExists(SQLiteFile) Then
			MessageBox.Show("Database file seems to be missing." & vbCrLf & vbCrLf & "File: " & SQLiteFile, "Database file not found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If

		If LBoxTable.SelectedIndices.Count = 0 Then
			MessageBox.Show("Please select a table for import!", "Select first!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Exit Sub
		End If

		With opDialog
			.Title = "Select Excel file for import"
			.Filter = "Excel files|*.xlsx; *.xlsb; *.xlsm; *.xls"
			If .ShowDialog = DialogResult.OK Then
				LbImport.Text = "Importing..."
				BgImport.RunWorkerAsync(.FileName)
			End If
		End With
	End Sub

	Private Sub BgImport_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgImport.DoWork
		ColumnList = SQLReadQuery("PRAGMA table_info(" & selectedTable & ")", 60, SQLConn).AsEnumerable().Select(Function(x) x.Field(Of String)("name")).Distinct.ToArray

		Dim excelData As New DataTable
		excelData = ReadExcel(e.Argument.ToString, ColumnList).Copy
		If excelData.Rows.Count > 0 Then
			Try
				For Each dr As DataRow In excelData.Rows
					Dim valuez As New List(Of String)
					For Each dc As DataColumn In excelData.Columns
						valuez.Add(dr.Item(dc).ToString.Replace("'", ""))
					Next
					SQLWriteQuery("insert into " & selectedTable & " ([" & String.Join("], [", ColumnList) & "]) values ('" & String.Join("', '", valuez.ToArray) & "')", 500, SQLConn)
				Next
				errx = {}
			Catch ex As Exception
				errx = {Err.Description, Err.Source}
			End Try
		Else
			errx = {"No Data!"}
		End If
	End Sub

	Private Sub BgImport_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgImport.RunWorkerCompleted
		If errx.Count = 1 Then
			MessageBox.Show("No data imported." & vbCrLf & vbCrLf & "Column List:" & vbCrLf & "[" & String.Join("], [", ColumnList) & "]", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			LbImport.Text = "Import"
			Exit Sub
		End If

		If errx.Count = 2 Then
			MessageBox.Show(errx(0), errx(1), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			MessageBox.Show("Data uploaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

		LbImport.Text = "Import"
	End Sub

	Private Sub LbSQLiteBrowse_Click(sender As Object, e As EventArgs) Handles LbSQLiteBrowse.Click
		With opDialog
			.Title = "Select SQLite file"
			.Filter = "SQLite files|*.*"
			If .ShowDialog = DialogResult.OK Then
				SQLiteFile = .FileName
				TxServerName.Text = SQLiteFile
				LbConnect_Click(sender, Nothing)
			End If
		End With
	End Sub

	Private Sub LbCreateConnect_Click(sender As Object, e As EventArgs) Handles LbCreateConnect.Click
		If BgImport.IsBusy Or BgTryConnect.IsBusy Or BgExecute.IsBusy Or BGgetDetails.IsBusy Then Exit Sub

		With FdBrowse
			.Description = "Select a folder for creating the database"
			If .ShowDialog = DialogResult.OK Then
				SQLiteFile = .SelectedPath & "\" & Now.ToString("yyyy.MM.dd_HH.mm.ss.fff") & ".SQLite"
				LbCreateConnect.Text = "Creating..."
				Try
					SQLite.SQLiteConnection.CreateFile(SQLiteFile)
				Catch ex As Exception
					LbCreateConnect.Text = "Create New Database then Connect"
					MessageBox.Show(Err.Description, Err.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Exit Sub
				End Try

				TxServerName.Text = SQLiteFile

				LbCreateConnect.Text = "Connecting..."

				SQLConn = "Data Source=" & SQLiteFile & ";Version=3;New=True;Compress=True;"
				BgTryConnect.RunWorkerAsync(SQLConn)
			End If
		End With
	End Sub

	Private Sub LbTableRefresh_Click(sender As Object, e As EventArgs) Handles LbTableRefresh.Click
		If Not Connected Then Exit Sub

		If Not My.Computer.FileSystem.FileExists(SQLiteFile) Then
			MessageBox.Show("Database file seems to be missing." & vbCrLf & vbCrLf & "File: " & SQLiteFile, "Database file not found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If

		If Not BGgetDetails.IsBusy Then
			LbTableRefresh.Text = "Refreshing..."
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.EndUpdate()
			End With
			BGgetDetails.RunWorkerAsync()
		Else
			pendingRefresh = True
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.EndUpdate()
			End With
		End If
	End Sub

End Class