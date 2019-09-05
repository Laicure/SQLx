Imports System.ComponentModel

Public Class MainX
	Dim errx() As String = {}
	Friend selectedDatabase As String = ""
	Friend selectedTable As String = ""
	Dim ExecuteData As New DataTable
	Private ReadOnly ExecuteBSData As New BindingSource
	Dim DatabaseList() As String = {}
	Dim TableList() As String = {}
	Dim ColumnList() As String = {}
	Dim WithTruncate As Boolean = False
	Dim pendingRefresh As Boolean = False
	Dim Connected As Boolean = False

	Private ReadOnly QuerySessionCache As New HashSet(Of QuerySessionCache)

	Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Icon = My.Resources.art
		Me.Text = "SQLx - SQLClient v" & My.Computer.FileSystem.GetFileInfo(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName).LastWriteTimeUtc.ToString("yyyy.MM.dd_HH.mm.ss")

		ApplyDataGridViewProperties(DgData)
		DgData.DataSource = ExecuteBSData

		'set strings
		Username = Environment.UserName
		Domain = Environment.UserDomainName

		CbAuthentication.SelectedIndex = 0
	End Sub

	Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If BgTryConnect.IsBusy Then
			e.Cancel = True
			MessageBox.Show("The app is still trying to connect, do you still want to close the app?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		End If
	End Sub

	Private Sub CbAuthentication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAuthentication.SelectedIndexChanged
		If CbAuthentication.SelectedIndex = 0 Then
			With TxUsername
				.Text = Domain & "\" & Username
				.Enabled = False
			End With
			With TxPassword
				.Clear()
				.Enabled = False
			End With
			TxServerName.Focus()
		Else
			With TxUsername
				.Clear()
				.Enabled = True
				.Focus()
			End With
			With TxPassword
				.Clear()
				.Enabled = True
			End With
		End If
	End Sub

	Private Sub TxUsername_TextChanged(sender As Object, e As EventArgs) Handles TxUsername.TextChanged, TxPassword.TextChanged, TxServerName.TextChanged
		With LbConnect
			If TxServerName.Text.Trim.Length < 4 Then
				.Enabled = False
				Exit Sub
			End If
			If TxUsername.Text.Trim.Length > 1 And TxPassword.Text.Trim.Length > 2 And CbAuthentication.SelectedIndex = 1 Then
				.Enabled = True
			ElseIf CbAuthentication.SelectedIndex = 0 Then
				.Enabled = True
			Else
				.Enabled = False
			End If
		End With
	End Sub

	Private Sub TxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxUsername.KeyDown, TxServerName.KeyDown, TxPassword.KeyDown, CbAuthentication.KeyDown
		If e.KeyCode = Keys.Enter Then LbConnect_Click(sender, Nothing)
	End Sub

	Private Sub LbConnect_Click(sender As Object, e As EventArgs) Handles LbConnect.Click
		If BgImport.IsBusy Or BgTryConnect.IsBusy Or BgExecute.IsBusy Or BGgetDetails.IsBusy Then Exit Sub

		LbConnect.Text = "Connecting..."
		TxServerName.ReadOnly = True
		TxUsername.ReadOnly = True
		TxPassword.ReadOnly = True
		CbAuthentication.Enabled = False

		If CbAuthentication.SelectedIndex = 0 Then
			SQLConn = "Data Source=" & TxServerName.Text.Trim & "; Integrated Security=SSPI"
		Else
			SQLConn = "Data Source=" & TxServerName.Text.Trim & "; Integrated Security=false; User ID=" & TxUsername.Text.Trim & "; Password=" & TxPassword.Text & ";"
		End If
		BgTryConnect.RunWorkerAsync(SQLConn)
	End Sub

	Private Sub BgTryConnect_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgTryConnect.DoWork
		Threading.Thread.Sleep(222)
		Try
			Using tryCon As New SqlClient.SqlConnection(e.Argument.ToString)
				tryCon.Open()
				tryCon.Close()
			End Using
			errx = {}
		Catch ex As Exception
			errx = {Err.Description, Err.Source}
		End Try
	End Sub

	Private Sub BgTryConnect_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgTryConnect.RunWorkerCompleted
		If errx.Count = 2 Then
			With LbStatus
				.Text = ">> Disconnected <<"
				Connected = False
				.ForeColor = Color.Red
			End With
			With LBoxDatabase
				.BeginUpdate()
				.Items.Clear()
				.EndUpdate()
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
				With LBoxDatabase
					.BeginUpdate()
					.Items.Clear()
					.EndUpdate()
				End With
				With LBoxTable
					.BeginUpdate()
					.Items.Clear()
					.EndUpdate()
				End With
				BGgetDetails.RunWorkerAsync("")
			Else
				pendingRefresh = True
				With LBoxDatabase
					.BeginUpdate()
					.Items.Clear()
					.EndUpdate()
				End With
				With LBoxTable
					.BeginUpdate()
					.Items.Clear()
					.EndUpdate()
				End With
			End If
		End If

		LbConnect.Text = "Reconnect"
		TxServerName.ReadOnly = False
		TxUsername.ReadOnly = False
		TxPassword.ReadOnly = False
		CbAuthentication.Enabled = True
	End Sub

	Private Sub BGgetDetails_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGgetDetails.DoWork
		Threading.Thread.Sleep(222)
		If Not String.IsNullOrEmpty(e.Argument.ToString) Then
			TableList = SQLReadQuery("select Table_Name from INFORMATION_SCHEMA.COLUMNS with (NoLock) where Table_Catalog='" & selectedDatabase.Replace("[", "").Replace("]", "") & "'", 60, SQLConn, selectedDatabase.Replace("[", "").Replace("]", "")).AsEnumerable().Select(Function(x) x.Field(Of String)("Table_Name")).Distinct.ToArray
		Else
			DatabaseList = SQLReadQuery("SELECT name FROM master.sys.databases with (NoLock) where name not in ('master', 'tempdb', 'model', 'msdb')", 60, SQLConn).AsEnumerable().Select(Function(x) x.Field(Of String)("name")).ToArray
			TableList = {}
		End If
	End Sub

	Private Sub BGgetDetails_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGgetDetails.RunWorkerCompleted
		If pendingRefresh Then
			pendingRefresh = False
			BGgetDetails.RunWorkerAsync("")
			LbTableRefresh.Text = "Refresh"
			Exit Sub
		End If

		If DatabaseList.Count > 0 And LBoxDatabase.SelectedIndices.Count = 0 Then
			With LBoxDatabase
				.BeginUpdate()
				.Items.Clear()
				.Items.AddRange(DatabaseList.Select(Function(x) "[" & x & "]").ToArray)
				.EndUpdate()
				.SelectedIndex = 0
			End With
		End If

		If TableList.Count > 0 Then
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.Items.AddRange(TableList.Select(Function(x) "[" & x & "]").ToArray)
				.EndUpdate()
			End With
		End If

		LbTableRefresh.Text = "Refresh"
	End Sub

	Private Sub LBoxDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxDatabase.SelectedIndexChanged
		If LBoxDatabase.SelectedIndex >= 0 Then
			selectedDatabase = LBoxDatabase.GetItemText(LBoxDatabase.SelectedItem)
			If Not BGgetDetails.IsBusy Then
				BGgetDetails.RunWorkerAsync(selectedDatabase)
			Else
				pendingRefresh = True
			End If
		Else
			selectedDatabase = ""
		End If
	End Sub

	Private Sub LBoxTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxTable.SelectedIndexChanged
		If LBoxTable.SelectedIndex >= 0 Then
			selectedTable = LBoxTable.GetItemText(LBoxTable.SelectedItem)

			With TxQuery
				Dim selStart As Integer = .SelectionStart
				TxQuery.Text = .Text.Insert(selStart, selectedTable)
				TxQuery.SelectionStart = selStart
			End With
		Else
			selectedTable = ""
		End If
	End Sub

	Private Sub LbCollapse_Click(sender As Object, e As EventArgs) Handles LbCollapse.Click
		If Not Connected Then Exit Sub

		If panMenu.Width = 200 Then
			If LbStatus.ForeColor = Color.Red Then Exit Sub
			panMenu.Width = 26
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
				.Height = 26
				.Top = 126
				.Left = 174
			End With
		End If
	End Sub

	Private Sub LbExecute_Click(sender As Object, e As EventArgs) Handles LbExecute.Click
		If String.IsNullOrEmpty(TxQuery.Text.Trim) Or BgExecute.IsBusy Or BgTryConnect.IsBusy Or Not Connected Then Exit Sub
		If LBoxDatabase.SelectedIndices.Count = 0 Then
			MessageBox.Show("Select a Database to proceed!", "Database?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Exit Sub
		End If
		LbExecute.Text = "Executing..."
		LbExecute.Enabled = False
		TxQuery.ReadOnly = True
		LbDataCount.Text = "Loading..."
		BgExecute.RunWorkerAsync({TxQuery.Text.Trim, selectedDatabase.Replace("[", "").Replace("]", "")})

		If TxQuery.Text.ToLower.Contains("create") Or TxQuery.Text.ToLower.Contains("drop") Then LbTableRefresh_Click(sender, Nothing)
	End Sub

	Private Sub BgExecute_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgExecute.DoWork
		Dim args() As String = CType(e.Argument, String())
		Dim getdata As New DataTable
		Try
			getdata = SQLReadQuery(args(0), 300, SQLConn, args(1)).Copy
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
			DgData.Columns.Clear()
			ExecuteBSData.DataSource = ExecuteData
			ExecuteBSData.EndEdit()
		End If
		LbDataCount.Text = ExecuteData.Rows.Count.ToString("#,0")

		LbExecute.Text = "Execute"
		LbExecute.Enabled = True
		TxQuery.ReadOnly = False

		If Not QuerySessionCache.Where(Function(x) x.Query = TxQuery.Text.Trim).Count >= 1 Then
			QuerySessionCache.Add(New QuerySessionCache With {.ExecDate = Now.ToString("yyyy-MM-dd hh:mm:ss tt", Globalization.CultureInfo.InvariantCulture), .Query = TxQuery.Text.Trim})
			If QuerySessionCache.Count > 0 Then
				With LBoxQueries
					.BeginUpdate()
					.Items.Clear()
					.Items.AddRange(QuerySessionCache.Select(Function(x) x.ExecDate).OrderByDescending(Function(y) CDate(y)).ToArray)
					.EndUpdate()
				End With
			End If
		End If
	End Sub

	Private Sub LbExport_Click(sender As Object, e As EventArgs) Handles LbExport.Click
		If ExecuteData.Rows.Count = 0 Or BgExport.IsBusy Or BgExecute.IsBusy Then Exit Sub
		If FdBrowse.ShowDialog = DialogResult.OK Then
			Dim path As String = FdBrowse.SelectedPath & "\" & Now.ToString("yyyy.MM.dd_HH.mm.ss.fff", Globalization.CultureInfo.InvariantCulture)
			LbExport.Text = "Exporting..."
			BgExport.RunWorkerAsync(path)
		End If
	End Sub

	Private Sub BgExport_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgExport.DoWork
		Dim path As String = e.Argument.ToString
		Exporter(path, ExecuteData)
		Process.Start("explorer", "/select, " & path & ".xlsb")
	End Sub

	Private Sub BgExport_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgExport.RunWorkerCompleted
		LbExport.Text = "Export"
	End Sub

	Private Sub LbImport_MouseDown(sender As Object, e As MouseEventArgs) Handles LbImport.MouseDown
		If BGgetDetails.IsBusy Or BgImport.IsBusy Or BgTryConnect.IsBusy Or Not Connected Then Exit Sub
		If LBoxTable.SelectedIndices.Count = 0 Then
			MessageBox.Show("Please select a table for import!", "Select first!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Exit Sub
		End If

		If e.Button = System.Windows.Forms.MouseButtons.Right Then
			If MessageBox.Show("Are you sure to truncate the table before import?" & vbCrLf & "This will delete all data before importing!", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
				WithTruncate = True
			Else
				Exit Sub
			End If
		Else
			WithTruncate = False
		End If

		If opDialog.ShowDialog = DialogResult.OK Then
			LbImport.Text = "Reading..."
			BgImport.RunWorkerAsync(opDialog.FileName)
		End If
	End Sub

	Private Sub BgImport_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgImport.DoWork
		Dim selectedTabled As String = selectedTable
		ColumnList = SQLReadQuery("select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS with (NoLock) where COLUMNPROPERTY(object_id(TABLE_SCHEMA+'.'+TABLE_NAME), COLUMN_NAME, 'IsIdentity')=0 and Table_Catalog='" & selectedDatabase & "' and Table_Name='" & selectedTabled & "' order by ORDINAL_POSITION", 60, SQLConn, selectedDatabase).AsEnumerable().Select(Function(x) x.Field(Of String)("COLUMN_NAME")).Distinct.ToArray

		Dim excelData As New DataTable
		excelData = ReadExcel(e.Argument.ToString, ColumnList).Copy

		If excelData.Rows.Count > 0 Then
			LbImport.Invoke(DirectCast(Sub() LbImport.Text = "Importing...", MethodInvoker))
			Try
				If WithTruncate Then
					SQLWriteQuery("delete from " & selectedTabled, 60, SQLConn)
				End If
				Using conX As New SqlClient.SqlConnection(SQLConn), comX As New SqlClient.SqlCommand
					If conX.State = ConnectionState.Closed Then conX.Open()
					If Not String.IsNullOrEmpty(selectedDatabase.Trim) Then conX.ChangeDatabase(selectedDatabase.Trim)
					With comX
						.Connection = conX
						.CommandTimeout = 0
						Dim insertCount As Integer = 0
						Dim transacQuery As String = ""
						For Each dr As DataRow In excelData.Rows
							insertCount += 1
							If insertCount = 1 Then transacQuery = "begin;" & vbCrLf
							Dim valuez As New List(Of String)
							For Each dc As DataColumn In excelData.Columns
								valuez.Add(dr.Item(dc).ToString)
							Next
							transacQuery = transacQuery & Trim("insert into " & selectedTabled & " ([" & String.Join("], [", ColumnList) & "]) values ('" & String.Join("', '", valuez.ToArray) & "')") & ";" & vbCrLf
							If insertCount = 999 Then
								transacQuery &= "commit;"
								.CommandText = transacQuery
								.ExecuteNonQuery()
								insertCount = 0
							End If
						Next
						If insertCount < 999 Then
							transacQuery &= "commit;"
							.CommandText = transacQuery
							.ExecuteNonQuery()
						End If
					End With
				End Using
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
		ElseIf errx.Count = 2 Then
			MessageBox.Show(errx(0), errx(1), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			MessageBox.Show("Data uploaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

		LbImport.Text = "Import"
	End Sub

	Private Sub LbTableRefresh_Click(sender As Object, e As EventArgs) Handles LbTableRefresh.Click
		If Not Connected Then Exit Sub

		If Not BGgetDetails.IsBusy Then
			LbTableRefresh.Text = "Refreshing..."
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.EndUpdate()
			End With
			BGgetDetails.RunWorkerAsync(selectedDatabase)
		Else
			pendingRefresh = True
			With LBoxTable
				.BeginUpdate()
				.Items.Clear()
				.EndUpdate()
			End With
		End If
	End Sub

	Private Sub LBoxQueries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxQueries.SelectedIndexChanged
		With LBoxQueries
			If .SelectedIndex >= 0 Then
				TxQuery.Text = QuerySessionCache.Where(Function(x) x.ExecDate = .GetItemText(.SelectedItem)).Select(Function(x) x.Query).FirstOrDefault
			End If
		End With
	End Sub

End Class

Friend Class QuerySessionCache
	Friend Property ExecDate As String
	Friend Property Query As String
End Class