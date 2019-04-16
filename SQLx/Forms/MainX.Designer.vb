<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainX
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.panMenu = New System.Windows.Forms.Panel()
		Me.LbImport = New System.Windows.Forms.Label()
		Me.LbCollapse = New System.Windows.Forms.Label()
		Me.LbStatus = New System.Windows.Forms.Label()
		Me.LBoxTable = New System.Windows.Forms.ListBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.LBoxDatabase = New System.Windows.Forms.ListBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.LbConnect = New System.Windows.Forms.Label()
		Me.TxPassword = New System.Windows.Forms.TextBox()
		Me.TxUsername = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CbAuthentication = New System.Windows.Forms.ComboBox()
		Me.TxServerName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.BgTryConnect = New System.ComponentModel.BackgroundWorker()
		Me.BGgetDetails = New System.ComponentModel.BackgroundWorker()
		Me.SplitCon = New System.Windows.Forms.SplitContainer()
		Me.TxQuery = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.LbExecute = New System.Windows.Forms.Label()
		Me.DgData = New System.Windows.Forms.DataGridView()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.LbDataCount = New System.Windows.Forms.Label()
		Me.LbExport = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.BgExecute = New System.ComponentModel.BackgroundWorker()
		Me.BgExport = New System.ComponentModel.BackgroundWorker()
		Me.FdBrowse = New System.Windows.Forms.FolderBrowserDialog()
		Me.opDialog = New System.Windows.Forms.OpenFileDialog()
		Me.BgImport = New System.ComponentModel.BackgroundWorker()
		Me.panMenu.SuspendLayout()
		Me.SplitCon.Panel1.SuspendLayout()
		Me.SplitCon.Panel2.SuspendLayout()
		Me.SplitCon.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.DgData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'panMenu
		'
		Me.panMenu.Controls.Add(Me.LbCollapse)
		Me.panMenu.Controls.Add(Me.LbImport)
		Me.panMenu.Controls.Add(Me.LbStatus)
		Me.panMenu.Controls.Add(Me.LBoxTable)
		Me.panMenu.Controls.Add(Me.Label7)
		Me.panMenu.Controls.Add(Me.LBoxDatabase)
		Me.panMenu.Controls.Add(Me.Label8)
		Me.panMenu.Controls.Add(Me.LbConnect)
		Me.panMenu.Controls.Add(Me.TxPassword)
		Me.panMenu.Controls.Add(Me.TxUsername)
		Me.panMenu.Controls.Add(Me.Label5)
		Me.panMenu.Controls.Add(Me.Label6)
		Me.panMenu.Controls.Add(Me.CbAuthentication)
		Me.panMenu.Controls.Add(Me.TxServerName)
		Me.panMenu.Controls.Add(Me.Label3)
		Me.panMenu.Controls.Add(Me.Label2)
		Me.panMenu.Controls.Add(Me.Label1)
		Me.panMenu.Controls.Add(Me.Label4)
		Me.panMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.panMenu.Location = New System.Drawing.Point(1, 1)
		Me.panMenu.Margin = New System.Windows.Forms.Padding(0)
		Me.panMenu.Name = "panMenu"
		Me.panMenu.Size = New System.Drawing.Size(150, 452)
		Me.panMenu.TabIndex = 0
		'
		'LbImport
		'
		Me.LbImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbImport.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbImport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbImport.ForeColor = System.Drawing.Color.Blue
		Me.LbImport.Location = New System.Drawing.Point(75, 299)
		Me.LbImport.Margin = New System.Windows.Forms.Padding(0)
		Me.LbImport.Name = "LbImport"
		Me.LbImport.Size = New System.Drawing.Size(75, 22)
		Me.LbImport.TabIndex = 17
		Me.LbImport.Text = "Import"
		Me.LbImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbCollapse
		'
		Me.LbCollapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbCollapse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbCollapse.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbCollapse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbCollapse.ForeColor = System.Drawing.Color.Blue
		Me.LbCollapse.Location = New System.Drawing.Point(128, 126)
		Me.LbCollapse.Margin = New System.Windows.Forms.Padding(0)
		Me.LbCollapse.Name = "LbCollapse"
		Me.LbCollapse.Size = New System.Drawing.Size(22, 22)
		Me.LbCollapse.TabIndex = 16
		Me.LbCollapse.Text = "<"
		Me.LbCollapse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbStatus
		'
		Me.LbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbStatus.ForeColor = System.Drawing.Color.Red
		Me.LbStatus.Location = New System.Drawing.Point(0, 126)
		Me.LbStatus.Margin = New System.Windows.Forms.Padding(0)
		Me.LbStatus.Name = "LbStatus"
		Me.LbStatus.Size = New System.Drawing.Size(129, 22)
		Me.LbStatus.TabIndex = 15
		Me.LbStatus.Text = ">> Stand-by <<"
		Me.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LBoxTable
		'
		Me.LBoxTable.BackColor = System.Drawing.Color.White
		Me.LBoxTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LBoxTable.ForeColor = System.Drawing.Color.Black
		Me.LBoxTable.FormattingEnabled = True
		Me.LBoxTable.Location = New System.Drawing.Point(0, 320)
		Me.LBoxTable.Margin = New System.Windows.Forms.Padding(0)
		Me.LBoxTable.Name = "LBoxTable"
		Me.LBoxTable.Size = New System.Drawing.Size(150, 132)
		Me.LBoxTable.TabIndex = 13
		Me.LBoxTable.TabStop = False
		'
		'Label7
		'
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Location = New System.Drawing.Point(0, 299)
		Me.Label7.Margin = New System.Windows.Forms.Padding(0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(76, 22)
		Me.Label7.TabIndex = 14
		Me.Label7.Text = "Table List"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LBoxDatabase
		'
		Me.LBoxDatabase.BackColor = System.Drawing.Color.White
		Me.LBoxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LBoxDatabase.ForeColor = System.Drawing.Color.Black
		Me.LBoxDatabase.FormattingEnabled = True
		Me.LBoxDatabase.Location = New System.Drawing.Point(0, 168)
		Me.LBoxDatabase.Margin = New System.Windows.Forms.Padding(0)
		Me.LBoxDatabase.Name = "LBoxDatabase"
		Me.LBoxDatabase.Size = New System.Drawing.Size(150, 132)
		Me.LBoxDatabase.TabIndex = 1
		Me.LBoxDatabase.TabStop = False
		'
		'Label8
		'
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label8.Location = New System.Drawing.Point(0, 147)
		Me.Label8.Margin = New System.Windows.Forms.Padding(0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(150, 22)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "Database List"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbConnect
		'
		Me.LbConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbConnect.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbConnect.Enabled = False
		Me.LbConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbConnect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbConnect.ForeColor = System.Drawing.Color.Blue
		Me.LbConnect.Location = New System.Drawing.Point(0, 105)
		Me.LbConnect.Margin = New System.Windows.Forms.Padding(0)
		Me.LbConnect.Name = "LbConnect"
		Me.LbConnect.Size = New System.Drawing.Size(150, 22)
		Me.LbConnect.TabIndex = 10
		Me.LbConnect.Text = "Connect"
		Me.LbConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxPassword
		'
		Me.TxPassword.BackColor = System.Drawing.Color.White
		Me.TxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxPassword.ForeColor = System.Drawing.Color.Black
		Me.TxPassword.Location = New System.Drawing.Point(49, 84)
		Me.TxPassword.Margin = New System.Windows.Forms.Padding(0)
		Me.TxPassword.Name = "TxPassword"
		Me.TxPassword.Size = New System.Drawing.Size(101, 22)
		Me.TxPassword.TabIndex = 3
		Me.TxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxPassword.UseSystemPasswordChar = True
		Me.TxPassword.WordWrap = False
		'
		'TxUsername
		'
		Me.TxUsername.BackColor = System.Drawing.Color.White
		Me.TxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxUsername.ForeColor = System.Drawing.Color.Black
		Me.TxUsername.Location = New System.Drawing.Point(49, 63)
		Me.TxUsername.Margin = New System.Windows.Forms.Padding(0)
		Me.TxUsername.Name = "TxUsername"
		Me.TxUsername.Size = New System.Drawing.Size(101, 22)
		Me.TxUsername.TabIndex = 2
		Me.TxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxUsername.WordWrap = False
		'
		'Label5
		'
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label5.Location = New System.Drawing.Point(0, 84)
		Me.Label5.Margin = New System.Windows.Forms.Padding(0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(50, 22)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Pass:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(0, 63)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(50, 22)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "User:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CbAuthentication
		'
		Me.CbAuthentication.BackColor = System.Drawing.Color.White
		Me.CbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbAuthentication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CbAuthentication.ForeColor = System.Drawing.Color.Black
		Me.CbAuthentication.FormattingEnabled = True
		Me.CbAuthentication.Items.AddRange(New Object() {"Windows", "SQL Server"})
		Me.CbAuthentication.Location = New System.Drawing.Point(50, 43)
		Me.CbAuthentication.Margin = New System.Windows.Forms.Padding(0)
		Me.CbAuthentication.Name = "CbAuthentication"
		Me.CbAuthentication.Size = New System.Drawing.Size(100, 21)
		Me.CbAuthentication.TabIndex = 1
		'
		'TxServerName
		'
		Me.TxServerName.BackColor = System.Drawing.Color.White
		Me.TxServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxServerName.ForeColor = System.Drawing.Color.Black
		Me.TxServerName.Location = New System.Drawing.Point(49, 21)
		Me.TxServerName.Margin = New System.Windows.Forms.Padding(0)
		Me.TxServerName.Name = "TxServerName"
		Me.TxServerName.Size = New System.Drawing.Size(101, 22)
		Me.TxServerName.TabIndex = 0
		Me.TxServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxServerName.WordWrap = False
		'
		'Label3
		'
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Location = New System.Drawing.Point(0, 21)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(50, 22)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Name:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(49, 0)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(101, 22)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Database Engine"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(50, 22)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Type:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Location = New System.Drawing.Point(0, 42)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 22)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Auth:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'BgTryConnect
		'
		'
		'BGgetDetails
		'
		'
		'SplitCon
		'
		Me.SplitCon.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitCon.Location = New System.Drawing.Point(151, 1)
		Me.SplitCon.Margin = New System.Windows.Forms.Padding(0)
		Me.SplitCon.Name = "SplitCon"
		Me.SplitCon.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitCon.Panel1
		'
		Me.SplitCon.Panel1.Controls.Add(Me.TxQuery)
		Me.SplitCon.Panel1.Controls.Add(Me.Panel1)
		Me.SplitCon.Panel1MinSize = 50
		'
		'SplitCon.Panel2
		'
		Me.SplitCon.Panel2.Controls.Add(Me.DgData)
		Me.SplitCon.Panel2.Controls.Add(Me.Panel2)
		Me.SplitCon.Panel2MinSize = 50
		Me.SplitCon.Size = New System.Drawing.Size(632, 452)
		Me.SplitCon.SplitterDistance = 169
		Me.SplitCon.SplitterWidth = 5
		Me.SplitCon.TabIndex = 15
		Me.SplitCon.TabStop = False
		'
		'TxQuery
		'
		Me.TxQuery.BackColor = System.Drawing.Color.White
		Me.TxQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxQuery.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxQuery.ForeColor = System.Drawing.Color.Black
		Me.TxQuery.Location = New System.Drawing.Point(0, 21)
		Me.TxQuery.Margin = New System.Windows.Forms.Padding(0)
		Me.TxQuery.Multiline = True
		Me.TxQuery.Name = "TxQuery"
		Me.TxQuery.Size = New System.Drawing.Size(632, 148)
		Me.TxQuery.TabIndex = 7
		Me.TxQuery.WordWrap = False
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Label9)
		Me.Panel1.Controls.Add(Me.LbExecute)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(632, 21)
		Me.Panel1.TabIndex = 10
		'
		'Label9
		'
		Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label9.Location = New System.Drawing.Point(0, 0)
		Me.Label9.Margin = New System.Windows.Forms.Padding(0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(558, 21)
		Me.Label9.TabIndex = 6
		Me.Label9.Text = "Query ⤵"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbExecute
		'
		Me.LbExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbExecute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbExecute.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbExecute.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbExecute.ForeColor = System.Drawing.Color.Blue
		Me.LbExecute.Location = New System.Drawing.Point(557, 0)
		Me.LbExecute.Margin = New System.Windows.Forms.Padding(0)
		Me.LbExecute.Name = "LbExecute"
		Me.LbExecute.Size = New System.Drawing.Size(75, 21)
		Me.LbExecute.TabIndex = 9
		Me.LbExecute.Text = "Execute"
		Me.LbExecute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DgData
		'
		Me.DgData.BackgroundColor = System.Drawing.Color.White
		Me.DgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DgData.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DgData.Location = New System.Drawing.Point(0, 22)
		Me.DgData.Margin = New System.Windows.Forms.Padding(0)
		Me.DgData.Name = "DgData"
		Me.DgData.Size = New System.Drawing.Size(632, 256)
		Me.DgData.TabIndex = 10
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.LbDataCount)
		Me.Panel2.Controls.Add(Me.LbExport)
		Me.Panel2.Controls.Add(Me.Label10)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(632, 22)
		Me.Panel2.TabIndex = 12
		'
		'LbDataCount
		'
		Me.LbDataCount.AutoEllipsis = True
		Me.LbDataCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbDataCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbDataCount.Location = New System.Drawing.Point(0, 0)
		Me.LbDataCount.Margin = New System.Windows.Forms.Padding(0)
		Me.LbDataCount.Name = "LbDataCount"
		Me.LbDataCount.Size = New System.Drawing.Size(100, 22)
		Me.LbDataCount.TabIndex = 11
		Me.LbDataCount.Text = "-"
		Me.LbDataCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbExport
		'
		Me.LbExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbExport.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbExport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbExport.ForeColor = System.Drawing.Color.Blue
		Me.LbExport.Location = New System.Drawing.Point(557, 0)
		Me.LbExport.Margin = New System.Windows.Forms.Padding(0)
		Me.LbExport.Name = "LbExport"
		Me.LbExport.Size = New System.Drawing.Size(75, 22)
		Me.LbExport.TabIndex = 12
		Me.LbExport.Text = "Export"
		Me.LbExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label10
		'
		Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label10.Location = New System.Drawing.Point(99, 0)
		Me.Label10.Margin = New System.Windows.Forms.Padding(0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(459, 22)
		Me.Label10.TabIndex = 8
		Me.Label10.Text = "Data ⤵"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'BgExecute
		'
		'
		'BgExport
		'
		'
		'FdBrowse
		'
		Me.FdBrowse.Description = "Select a folder for Export"
		'
		'opDialog
		'
		Me.opDialog.Filter = "Excel files|*.xlsx; *.xlsb; *.xlsm; *.xls"
		'
		'BgImport
		'
		'
		'MainX
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(784, 454)
		Me.Controls.Add(Me.SplitCon)
		Me.Controls.Add(Me.panMenu)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
		Me.ForeColor = System.Drawing.Color.Black
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "MainX"
		Me.Padding = New System.Windows.Forms.Padding(1)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SQLx"
		Me.panMenu.ResumeLayout(False)
		Me.panMenu.PerformLayout()
		Me.SplitCon.Panel1.ResumeLayout(False)
		Me.SplitCon.Panel1.PerformLayout()
		Me.SplitCon.Panel2.ResumeLayout(False)
		Me.SplitCon.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		CType(Me.DgData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents panMenu As Panel
	Friend WithEvents LbConnect As Label
	Friend WithEvents TxPassword As TextBox
	Friend WithEvents TxUsername As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents CbAuthentication As ComboBox
	Friend WithEvents TxServerName As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents BgTryConnect As System.ComponentModel.BackgroundWorker
	Friend WithEvents LBoxDatabase As ListBox
	Friend WithEvents Label8 As Label
	Friend WithEvents LBoxTable As ListBox
	Friend WithEvents Label7 As Label
	Friend WithEvents BGgetDetails As System.ComponentModel.BackgroundWorker
	Friend WithEvents LbStatus As Label
	Friend WithEvents LbCollapse As Label
	Friend WithEvents SplitCon As SplitContainer
	Friend WithEvents Label9 As Label
	Friend WithEvents TxQuery As TextBox
	Friend WithEvents LbExecute As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents LbDataCount As Label
	Friend WithEvents DgData As DataGridView
	Friend WithEvents BgExecute As System.ComponentModel.BackgroundWorker
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents LbExport As Label
	Friend WithEvents BgExport As System.ComponentModel.BackgroundWorker
	Friend WithEvents FdBrowse As FolderBrowserDialog
	Friend WithEvents LbImport As Label
	Friend WithEvents opDialog As OpenFileDialog
	Friend WithEvents BgImport As System.ComponentModel.BackgroundWorker
End Class
