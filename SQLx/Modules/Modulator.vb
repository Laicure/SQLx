Module Modulator
	Friend Username As String = ""
	Friend Domain As String = ""
	Friend SQLConn As String = ""

#Region "SQL Query"

	Friend Function SQLReadQuery(ByVal queryX As String, ByVal timeXout As Integer, ByVal connection As String) As DataTable
		Using conX As New SQLite.SQLiteConnection(connection), comX As New SQLite.SQLiteCommand, dataTableX As New DataTable
			If conX.State = Data.ConnectionState.Closed Then conX.Open()
			With comX
				.Connection = conX
				.CommandTimeout = timeXout
				.CommandText = queryX.Trim
			End With
			Using readerX As SQLite.SQLiteDataReader = comX.ExecuteReader()
				dataTableX.Load(readerX)
			End Using
			comX.Cancel()
			If conX.State = ConnectionState.Open Then conX.Close()
			Return dataTableX
		End Using
	End Function

	Friend Sub SQLWriteQuery(ByVal queryX As String, ByVal timeXout As Integer, connection As String)
		Using conX As New SQLite.SQLiteConnection(connection), comX As New SQLite.SQLiteCommand
			If conX.State = ConnectionState.Closed Then conX.Open()
			With comX
				.Connection = conX
				.CommandTimeout = timeXout
				.CommandText = Trim(queryX)
				.ExecuteNonQuery()
			End With
		End Using
	End Sub

#End Region

#Region "DoubleBuffered Buff // Use Buff.DoubleBuff(<Control>)"

	Friend NotInheritable Class Buff

		Friend Shared Sub DoubleBuff(Contt As Control)
			Dim ConttType As Type = Contt.[GetType]()
			Dim propInfo As System.Reflection.PropertyInfo = ConttType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
			propInfo.SetValue(Contt, True, Nothing)
		End Sub

	End Class

#End Region

#Region "Datagrid format"

	Friend Sub ApplyDataGridViewProperties(ByVal datagrid As DataGridView)
		Buff.DoubleBuff(datagrid)
		With datagrid
			.SuspendLayout()
			.AutoGenerateColumns = True
			.BackgroundColor = Color.White
			.BackColor = Color.White
			.ForeColor = Color.Black
			.DefaultCellStyle.BackColor = Color.White
			.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew
			.GridColor = Color.Brown
			.ReadOnly = True
			.TabStop = False
			.SelectionMode = DataGridViewSelectionMode.CellSelect
			.RowHeadersVisible = False
			.MultiSelect = True
			.AllowUserToAddRows = False
			.AllowUserToDeleteRows = False
			.AllowUserToOrderColumns = False
			.AllowUserToResizeColumns = True
			.AllowUserToResizeRows = False
			.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
			.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
			.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			.VirtualMode = True
			'.TabIndex = 0
			.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
			.ResumeLayout()
		End With
	End Sub

#End Region

End Module