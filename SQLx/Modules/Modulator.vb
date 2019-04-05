Module Modulator
	Friend Username As String = ""
	Friend Domain As String = ""
	Friend SQLConn As String = ""

#Region "SQL Query"

	Friend Function SQLReadQuery(ByVal queryX As String, ByVal timeXout As Integer, ByVal connection As String, Optional ByVal DatabaseName As String = "") As DataTable
		Using conX As New SqlClient.SqlConnection(connection), comX As New SqlClient.SqlCommand, dataTableX As New DataTable
			If conX.State = Data.ConnectionState.Closed Then conX.Open()
			If Not String.IsNullOrEmpty(DatabaseName.Trim) Then conX.ChangeDatabase(DatabaseName.Trim)
			With comX
				.Connection = conX
				.CommandTimeout = timeXout
				.CommandText = "set nocount on " & vbCrLf & queryX.Trim
			End With
			Using readerX As SqlClient.SqlDataReader = comX.ExecuteReader()
				dataTableX.Load(readerX)
			End Using
			comX.Cancel()
			If conX.State = ConnectionState.Open Then conX.Close()
			Return dataTableX
		End Using
	End Function

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
			.MultiSelect = False
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

End Module