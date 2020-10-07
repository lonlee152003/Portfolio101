<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminPage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CandidateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryAndCriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCandidateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditExistingCandidateNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCandidateDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertCategoryAndCriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserAdminAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CandidatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallyBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txusr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CandidateToolStripMenuItem, Me.CategoryAndCriteriaToolStripMenuItem, Me.SetupToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.SmsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.TallyBoardToolStripMenuItem, Me.ResetToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(22, 202)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(212, 246)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CandidateToolStripMenuItem
        '
        Me.CandidateToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CandidateToolStripMenuItem.Name = "CandidateToolStripMenuItem"
        Me.CandidateToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.CandidateToolStripMenuItem.Text = "Candidate"
        '
        'CategoryAndCriteriaToolStripMenuItem
        '
        Me.CategoryAndCriteriaToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.CategoryAndCriteriaToolStripMenuItem.Name = "CategoryAndCriteriaToolStripMenuItem"
        Me.CategoryAndCriteriaToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.CategoryAndCriteriaToolStripMenuItem.Text = "Category And Criteria"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCandidateToolStripMenuItem, Me.EditExistingCandidateNameToolStripMenuItem, Me.DeleteCandidateDataToolStripMenuItem, Me.InsertCategoryAndCriteriaToolStripMenuItem})
        Me.SetupToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.SetupToolStripMenuItem.Text = "Setup"
        Me.SetupToolStripMenuItem.Visible = False
        '
        'AddNewCandidateToolStripMenuItem
        '
        Me.AddNewCandidateToolStripMenuItem.Name = "AddNewCandidateToolStripMenuItem"
        Me.AddNewCandidateToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.AddNewCandidateToolStripMenuItem.Text = "Candidate"
        '
        'EditExistingCandidateNameToolStripMenuItem
        '
        Me.EditExistingCandidateNameToolStripMenuItem.Name = "EditExistingCandidateNameToolStripMenuItem"
        Me.EditExistingCandidateNameToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.EditExistingCandidateNameToolStripMenuItem.Text = "Edit Candidate Data"
        Me.EditExistingCandidateNameToolStripMenuItem.Visible = False
        '
        'DeleteCandidateDataToolStripMenuItem
        '
        Me.DeleteCandidateDataToolStripMenuItem.Name = "DeleteCandidateDataToolStripMenuItem"
        Me.DeleteCandidateDataToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.DeleteCandidateDataToolStripMenuItem.Text = "Delete Candidate Data"
        Me.DeleteCandidateDataToolStripMenuItem.Visible = False
        '
        'InsertCategoryAndCriteriaToolStripMenuItem
        '
        Me.InsertCategoryAndCriteriaToolStripMenuItem.Name = "InsertCategoryAndCriteriaToolStripMenuItem"
        Me.InsertCategoryAndCriteriaToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.InsertCategoryAndCriteriaToolStripMenuItem.Text = "Category And Criteria"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAccountToolStripMenuItem, Me.EditUserAdminAccountToolStripMenuItem})
        Me.AccountsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'AddNewAccountToolStripMenuItem
        '
        Me.AddNewAccountToolStripMenuItem.Name = "AddNewAccountToolStripMenuItem"
        Me.AddNewAccountToolStripMenuItem.Size = New System.Drawing.Size(298, 30)
        Me.AddNewAccountToolStripMenuItem.Text = "Add New Account"
        Me.AddNewAccountToolStripMenuItem.Visible = False
        '
        'EditUserAdminAccountToolStripMenuItem
        '
        Me.EditUserAdminAccountToolStripMenuItem.Name = "EditUserAdminAccountToolStripMenuItem"
        Me.EditUserAdminAccountToolStripMenuItem.Size = New System.Drawing.Size(298, 30)
        Me.EditUserAdminAccountToolStripMenuItem.Text = "Edit User/Admin Account"
        Me.EditUserAdminAccountToolStripMenuItem.Visible = False
        '
        'SmsToolStripMenuItem
        '
        Me.SmsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.SmsToolStripMenuItem.Name = "SmsToolStripMenuItem"
        Me.SmsToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.SmsToolStripMenuItem.Text = "Sms"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CandidatesToolStripMenuItem})
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'CandidatesToolStripMenuItem
        '
        Me.CandidatesToolStripMenuItem.Name = "CandidatesToolStripMenuItem"
        Me.CandidatesToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.CandidatesToolStripMenuItem.Text = "Generate Report"
        '
        'TallyBoardToolStripMenuItem
        '
        Me.TallyBoardToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.TallyBoardToolStripMenuItem.Name = "TallyBoardToolStripMenuItem"
        Me.TallyBoardToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.TallyBoardToolStripMenuItem.Text = "Tally Graph"
        '
        'ResetToolStripMenuItem1
        '
        Me.ResetToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue
        Me.ResetToolStripMenuItem1.Name = "ResetToolStripMenuItem1"
        Me.ResetToolStripMenuItem1.Size = New System.Drawing.Size(205, 30)
        Me.ResetToolStripMenuItem1.Text = "Reset"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'txusr
        '
        Me.txusr.AutoSize = True
        Me.txusr.BackColor = System.Drawing.SystemColors.Control
        Me.txusr.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txusr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txusr.Location = New System.Drawing.Point(17, 595)
        Me.txusr.Name = "txusr"
        Me.txusr.Size = New System.Drawing.Size(146, 26)
        Me.txusr.TabIndex = 2
        Me.txusr.Text = "username here!"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(270, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 435)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Users"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(3, 29)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 15.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(533, 403)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(812, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 435)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Judges Scoreboard"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 15.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(3, 29)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 15.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(500, 403)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Chart1)
        Me.GroupBox3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox3.Location = New System.Drawing.Point(785, 381)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(529, 245)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tally Graph"
        Me.GroupBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "0"
        Me.Label1.Visible = False
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineWidth = 0
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Inclination = 5
        ChartArea1.Area3DStyle.IsClustered = True
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.Rotation = 5
        ChartArea1.Area3DStyle.WallWidth = 10
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.Transparent
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Font = New System.Drawing.Font("Rockwell", 14.25!)
        Legend1.ForeColor = System.Drawing.Color.DarkGreen
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.ShadowColor = System.Drawing.Color.Transparent
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 70)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100
        Series1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LabelForeColor = System.Drawing.Color.DarkGreen
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.ShadowColor = System.Drawing.Color.Transparent
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(529, 476)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(146, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 22)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "TAYUG CAMPUS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(144, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(646, 34)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "PANPACIFIC UNIVERSITY NORTH PHILIPPINES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.ThesisCapstonePre1.My.Resources.Resources.PUNP_LOGO_2010_WH1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-2, -4)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1329, 116)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1326, 630)
        Me.ShapeContainer1.TabIndex = 44
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.Control
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(-1, 113)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(265, 519)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(280, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 36)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ADMIN PAGE"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'adminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1326, 630)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txusr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adminPage"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN PAGE                                                                       " & _
            "                                "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TallyBoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CandidatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditUserAdminAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewCandidateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditExistingCandidateNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertCategoryAndCriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txusr As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeleteCandidateDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CandidateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryAndCriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
