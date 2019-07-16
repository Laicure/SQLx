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
		Me.LbCollapse = New System.Windows.Forms.Label()
		Me.LBoxColumn = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LbImport = New System.Windows.Forms.Label()
		Me.LbSQLiteBrowse = New System.Windows.Forms.Label()
		Me.LbTableRefresh = New System.Windows.Forms.Label()
		Me.LbStatus = New System.Windows.Forms.Label()
		Me.LBoxTable = New System.Windows.Forms.ListBox()
		Me.LbConnect = New System.Windows.Forms.Label()
		Me.TxServerName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.LbCreateConnect = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.LBoxQueries = New System.Windows.Forms.ListBox()
		Me.BgTryConnect = New System.ComponentModel.BackgroundWorker()
		Me.BGgetDetails = New System.ComponentModel.BackgroundWorker()
		Me.SplitCon = New System.Windows.Forms.SplitContainer()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.LbExecute = New System.Windows.Forms.Label()
		Me.TxQuery = New System.Windows.Forms.TextBox()
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
		Me.panMenu.Controls.Add(Me.LBoxColumn)
		Me.panMenu.Controls.Add(Me.Label1)
		Me.panMenu.Controls.Add(Me.LbImport)
		Me.panMenu.Controls.Add(Me.LbSQLiteBrowse)
		Me.panMenu.Controls.Add(Me.LbTableRefresh)
		Me.panMenu.Controls.Add(Me.LbStatus)
		Me.panMenu.Controls.Add(Me.LBoxTable)
		Me.panMenu.Controls.Add(Me.LbConnect)
		Me.panMenu.Controls.Add(Me.TxServerName)
		Me.panMenu.Controls.Add(Me.Label3)
		Me.panMenu.Controls.Add(Me.LbCreateConnect)
		Me.panMenu.Controls.Add(Me.Label7)
		Me.panMenu.Controls.Add(Me.LBoxQueries)
		Me.panMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.panMenu.Location = New System.Drawing.Point(1, 1)
		Me.panMenu.Margin = New System.Windows.Forms.Padding(0)
		Me.panMenu.Name = "panMenu"
		Me.panMenu.Size = New System.Drawing.Size(200, 452)
		Me.panMenu.TabIndex = 0
		'
		'LbCollapse
		'
		Me.LbCollapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbCollapse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbCollapse.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbCollapse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbCollapse.ForeColor = System.Drawing.Color.Blue
		Me.LbCollapse.Location = New System.Drawing.Point(177, 63)
		Me.LbCollapse.Margin = New System.Windows.Forms.Padding(0)
		Me.LbCollapse.Name = "LbCollapse"
		Me.LbCollapse.Size = New System.Drawing.Size(23, 23)
		Me.LbCollapse.TabIndex = 16
		Me.LbCollapse.Text = "<"
		Me.LbCollapse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LBoxColumn
		'
		Me.LBoxColumn.BackColor = System.Drawing.Color.White
		Me.LBoxColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LBoxColumn.ForeColor = System.Drawing.Color.Black
		Me.LBoxColumn.FormattingEnabled = True
		Me.LBoxColumn.Location = New System.Drawing.Point(0, 333)
		Me.LBoxColumn.Margin = New System.Windows.Forms.Padding(0)
		Me.LBoxColumn.Name = "LBoxColumn"
		Me.LBoxColumn.Size = New System.Drawing.Size(200, 119)
		Me.LBoxColumn.TabIndex = 22
		Me.LBoxColumn.TabStop = False
		'
		'Label1
		'
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Location = New System.Drawing.Point(0, 314)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(200, 20)
		Me.Label1.TabIndex = 21
		Me.Label1.Text = "Columns"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbImport
		'
		Me.LbImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbImport.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbImport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbImport.ForeColor = System.Drawing.Color.Blue
		Me.LbImport.Location = New System.Drawing.Point(125, 177)
		Me.LbImport.Margin = New System.Windows.Forms.Padding(0)
		Me.LbImport.Name = "LbImport"
		Me.LbImport.Size = New System.Drawing.Size(75, 20)
		Me.LbImport.TabIndex = 17
		Me.LbImport.Text = "Import"
		Me.LbImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbSQLiteBrowse
		'
		Me.LbSQLiteBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbSQLiteBrowse.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbSQLiteBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbSQLiteBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbSQLiteBrowse.ForeColor = System.Drawing.Color.Blue
		Me.LbSQLiteBrowse.Location = New System.Drawing.Point(178, 0)
		Me.LbSQLiteBrowse.Margin = New System.Windows.Forms.Padding(0)
		Me.LbSQLiteBrowse.Name = "LbSQLiteBrowse"
		Me.LbSQLiteBrowse.Size = New System.Drawing.Size(22, 22)
		Me.LbSQLiteBrowse.TabIndex = 18
		Me.LbSQLiteBrowse.Text = "..."
		Me.LbSQLiteBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbTableRefresh
		'
		Me.LbTableRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbTableRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbTableRefresh.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbTableRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbTableRefresh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbTableRefresh.ForeColor = System.Drawing.Color.Blue
		Me.LbTableRefresh.Location = New System.Drawing.Point(0, 177)
		Me.LbTableRefresh.Margin = New System.Windows.Forms.Padding(0)
		Me.LbTableRefresh.Name = "LbTableRefresh"
		Me.LbTableRefresh.Size = New System.Drawing.Size(75, 20)
		Me.LbTableRefresh.TabIndex = 20
		Me.LbTableRefresh.Text = "Refresh"
		Me.LbTableRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbStatus
		'
		Me.LbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbStatus.ForeColor = System.Drawing.Color.Red
		Me.LbStatus.Location = New System.Drawing.Point(0, 63)
		Me.LbStatus.Margin = New System.Windows.Forms.Padding(0)
		Me.LbStatus.Name = "LbStatus"
		Me.LbStatus.Size = New System.Drawing.Size(178, 23)
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
		Me.LBoxTable.Location = New System.Drawing.Point(0, 196)
		Me.LBoxTable.Margin = New System.Windows.Forms.Padding(0)
		Me.LBoxTable.Name = "LBoxTable"
		Me.LBoxTable.Size = New System.Drawing.Size(200, 119)
		Me.LBoxTable.TabIndex = 13
		Me.LBoxTable.TabStop = False
		'
		'LbConnect
		'
		Me.LbConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbConnect.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbConnect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbConnect.ForeColor = System.Drawing.Color.Blue
		Me.LbConnect.Location = New System.Drawing.Point(0, 21)
		Me.LbConnect.Margin = New System.Windows.Forms.Padding(0)
		Me.LbConnect.Name = "LbConnect"
		Me.LbConnect.Size = New System.Drawing.Size(200, 22)
		Me.LbConnect.TabIndex = 10
		Me.LbConnect.Text = "Connect"
		Me.LbConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxServerName
		'
		Me.TxServerName.BackColor = System.Drawing.Color.White
		Me.TxServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxServerName.ForeColor = System.Drawing.Color.Black
		Me.TxServerName.Location = New System.Drawing.Point(49, 0)
		Me.TxServerName.Margin = New System.Windows.Forms.Padding(0)
		Me.TxServerName.Name = "TxServerName"
		Me.TxServerName.ReadOnly = True
		Me.TxServerName.Size = New System.Drawing.Size(130, 22)
		Me.TxServerName.TabIndex = 0
		Me.TxServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxServerName.WordWrap = False
		'
		'Label3
		'
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(50, 22)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "File:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LbCreateConnect
		'
		Me.LbCreateConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbCreateConnect.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbCreateConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbCreateConnect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LbCreateConnect.ForeColor = System.Drawing.Color.Blue
		Me.LbCreateConnect.Location = New System.Drawing.Point(0, 42)
		Me.LbCreateConnect.Margin = New System.Windows.Forms.Padding(0)
		Me.LbCreateConnect.Name = "LbCreateConnect"
		Me.LbCreateConnect.Size = New System.Drawing.Size(200, 22)
		Me.LbCreateConnect.TabIndex = 19
		Me.LbCreateConnect.Text = "Create New Database then Connect"
		Me.LbCreateConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label7.Location = New System.Drawing.Point(0, 177)
		Me.Label7.Margin = New System.Windows.Forms.Padding(0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(200, 20)
		Me.Label7.TabIndex = 14
		Me.Label7.Text = "Tables"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LBoxQueries
		'
		Me.LBoxQueries.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LBoxQueries.BackColor = System.Drawing.Color.White
		Me.LBoxQueries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LBoxQueries.ForeColor = System.Drawing.Color.Black
		Me.LBoxQueries.FormattingEnabled = True
		Me.LBoxQueries.Location = New System.Drawing.Point(0, 85)
		Me.LBoxQueries.Margin = New System.Windows.Forms.Padding(0)
		Me.LBoxQueries.Name = "LBoxQueries"
		Me.LBoxQueries.Size = New System.Drawing.Size(200, 93)
		Me.LBoxQueries.TabIndex = 14
		Me.LBoxQueries.TabStop = False
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
		Me.SplitCon.Location = New System.Drawing.Point(201, 1)
		Me.SplitCon.Margin = New System.Windows.Forms.Padding(0)
		Me.SplitCon.Name = "SplitCon"
		Me.SplitCon.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitCon.Panel1
		'
		Me.SplitCon.Panel1.Controls.Add(Me.Panel1)
		Me.SplitCon.Panel1.Controls.Add(Me.TxQuery)
		Me.SplitCon.Panel1MinSize = 50
		'
		'SplitCon.Panel2
		'
		Me.SplitCon.Panel2.Controls.Add(Me.DgData)
		Me.SplitCon.Panel2.Controls.Add(Me.Panel2)
		Me.SplitCon.Panel2MinSize = 50
		Me.SplitCon.Size = New System.Drawing.Size(582, 452)
		Me.SplitCon.SplitterDistance = 179
		Me.SplitCon.SplitterWidth = 5
		Me.SplitCon.TabIndex = 15
		Me.SplitCon.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Label9)
		Me.Panel1.Controls.Add(Me.LbExecute)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(582, 22)
		Me.Panel1.TabIndex = 10
		'
		'Label9
		'
		Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label9.Location = New System.Drawing.Point(-1, 0)
		Me.Label9.Margin = New System.Windows.Forms.Padding(0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(509, 22)
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
		Me.LbExecute.Location = New System.Drawing.Point(507, 0)
		Me.LbExecute.Margin = New System.Windows.Forms.Padding(0)
		Me.LbExecute.Name = "LbExecute"
		Me.LbExecute.Size = New System.Drawing.Size(75, 22)
		Me.LbExecute.TabIndex = 9
		Me.LbExecute.Text = "Execute"
		Me.LbExecute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxQuery
		'
		Me.TxQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TxQuery.BackColor = System.Drawing.Color.White
		Me.TxQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxQuery.ForeColor = System.Drawing.Color.Black
		Me.TxQuery.Location = New System.Drawing.Point(-1, 21)
		Me.TxQuery.Margin = New System.Windows.Forms.Padding(0)
		Me.TxQuery.MaxLength = 2147483647
		Me.TxQuery.Multiline = True
		Me.TxQuery.Name = "TxQuery"
		Me.TxQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxQuery.Size = New System.Drawing.Size(583, 158)
		Me.TxQuery.TabIndex = 7
		Me.TxQuery.WordWrap = False
		'
		'DgData
		'
		Me.DgData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DgData.BackgroundColor = System.Drawing.Color.White
		Me.DgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DgData.Location = New System.Drawing.Point(-1, 21)
		Me.DgData.Margin = New System.Windows.Forms.Padding(0)
		Me.DgData.Name = "DgData"
		Me.DgData.Size = New System.Drawing.Size(583, 247)
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
		Me.Panel2.Size = New System.Drawing.Size(582, 22)
		Me.Panel2.TabIndex = 12
		'
		'LbDataCount
		'
		Me.LbDataCount.AutoEllipsis = True
		Me.LbDataCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbDataCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbDataCount.Location = New System.Drawing.Point(-1, 0)
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
		Me.LbExport.Location = New System.Drawing.Point(507, 0)
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
		Me.Label10.Location = New System.Drawing.Point(98, 0)
		Me.Label10.Margin = New System.Windows.Forms.Padding(0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(410, 22)
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
	Friend WithEvents TxServerName As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents BgTryConnect As System.ComponentModel.BackgroundWorker
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
	Friend WithEvents LbCreateConnect As Label
	Friend WithEvents LbSQLiteBrowse As Label
	Friend WithEvents LbTableRefresh As Label
	Friend WithEvents LBoxColumn As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents LBoxTable As ListBox
	Friend WithEvents LBoxQueries As ListBox
End Class
