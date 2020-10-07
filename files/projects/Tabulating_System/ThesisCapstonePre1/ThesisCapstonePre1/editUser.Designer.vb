<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.encryptedna = New System.Windows.Forms.Label()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.cbousrtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkPshow = New System.Windows.Forms.CheckBox()
        Me.txconfirmpassword = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txnamepo = New System.Windows.Forms.Label()
        Me.ecrypt = New System.Windows.Forms.Label()
        Me.txpassword = New System.Windows.Forms.TextBox()
        Me.txusername = New System.Windows.Forms.TextBox()
        Me.txname = New System.Windows.Forms.TextBox()
        Me.txsearch = New System.Windows.Forms.TextBox()
        Me.btneditpassword = New System.Windows.Forms.Button()
        Me.btneditusername = New System.Windows.Forms.Button()
        Me.btneditname = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.N = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.txdelinput = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddJudgesAdministratorAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditJudgesAdministratorAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txnamepo)
        Me.GroupBox1.Controls.Add(Me.ecrypt)
        Me.GroupBox1.Controls.Add(Me.txpassword)
        Me.GroupBox1.Controls.Add(Me.txusername)
        Me.GroupBox1.Controls.Add(Me.txname)
        Me.GroupBox1.Controls.Add(Me.txsearch)
        Me.GroupBox1.Controls.Add(Me.btneditpassword)
        Me.GroupBox1.Controls.Add(Me.btneditusername)
        Me.GroupBox1.Controls.Add(Me.btneditname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.N)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 108)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit User"
        Me.GroupBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.TextBox1.Location = New System.Drawing.Point(418, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 30)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.encryptedna)
        Me.GroupBox4.Controls.Add(Me.btnClr)
        Me.GroupBox4.Controls.Add(Me.btnReg)
        Me.GroupBox4.Controls.Add(Me.cbousrtype)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.chkPshow)
        Me.GroupBox4.Controls.Add(Me.txconfirmpassword)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Rockwell", 15.75!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox4.Location = New System.Drawing.Point(6, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(349, 129)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add admin/ judge"
        Me.GroupBox4.Visible = False
        '
        'encryptedna
        '
        Me.encryptedna.AutoSize = True
        Me.encryptedna.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encryptedna.Location = New System.Drawing.Point(147, 114)
        Me.encryptedna.Name = "encryptedna"
        Me.encryptedna.Size = New System.Drawing.Size(20, 21)
        Me.encryptedna.TabIndex = 20
        Me.encryptedna.Text = "0"
        Me.encryptedna.Visible = False
        '
        'btnClr
        '
        Me.btnClr.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnClr.Location = New System.Drawing.Point(87, 256)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 30)
        Me.btnClr.TabIndex = 19
        Me.btnClr.Text = "Clear Form"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnReg.Location = New System.Drawing.Point(168, 256)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(111, 30)
        Me.btnReg.TabIndex = 18
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'cbousrtype
        '
        Me.cbousrtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbousrtype.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbousrtype.ForeColor = System.Drawing.Color.DarkGreen
        Me.cbousrtype.FormattingEnabled = True
        Me.cbousrtype.Items.AddRange(New Object() {"admin", "judge"})
        Me.cbousrtype.Location = New System.Drawing.Point(183, 214)
        Me.cbousrtype.Name = "cbousrtype"
        Me.cbousrtype.Size = New System.Drawing.Size(160, 29)
        Me.cbousrtype.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "User Type"
        '
        'chkPshow
        '
        Me.chkPshow.AutoSize = True
        Me.chkPshow.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPshow.Location = New System.Drawing.Point(177, 183)
        Me.chkPshow.Name = "chkPshow"
        Me.chkPshow.Size = New System.Drawing.Size(166, 25)
        Me.chkPshow.TabIndex = 15
        Me.chkPshow.Text = "Show Password"
        Me.chkPshow.UseVisualStyleBackColor = True
        '
        'txconfirmpassword
        '
        Me.txconfirmpassword.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txconfirmpassword.Location = New System.Drawing.Point(183, 147)
        Me.txconfirmpassword.Name = "txconfirmpassword"
        Me.txconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9676)
        Me.txconfirmpassword.Size = New System.Drawing.Size(160, 30)
        Me.txconfirmpassword.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(183, 111)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9676)
        Me.TextBox4.Size = New System.Drawing.Size(160, 30)
        Me.TextBox4.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Confirm Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Password"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(183, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(160, 30)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(183, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 30)
        Me.TextBox3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Name"
        '
        'txnamepo
        '
        Me.txnamepo.AutoSize = True
        Me.txnamepo.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txnamepo.Location = New System.Drawing.Point(41, 91)
        Me.txnamepo.Name = "txnamepo"
        Me.txnamepo.Size = New System.Drawing.Size(61, 21)
        Me.txnamepo.TabIndex = 53
        Me.txnamepo.Text = "Name"
        Me.txnamepo.Visible = False
        '
        'ecrypt
        '
        Me.ecrypt.AutoSize = True
        Me.ecrypt.Location = New System.Drawing.Point(586, 162)
        Me.ecrypt.Name = "ecrypt"
        Me.ecrypt.Size = New System.Drawing.Size(85, 23)
        Me.ecrypt.TabIndex = 52
        Me.ecrypt.Text = "encrypt"
        Me.ecrypt.Visible = False
        '
        'txpassword
        '
        Me.txpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txpassword.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txpassword.ForeColor = System.Drawing.Color.DarkGreen
        Me.txpassword.Location = New System.Drawing.Point(129, 177)
        Me.txpassword.Name = "txpassword"
        Me.txpassword.Size = New System.Drawing.Size(230, 30)
        Me.txpassword.TabIndex = 51
        Me.txpassword.Text = "Password here!"
        '
        'txusername
        '
        Me.txusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txusername.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txusername.ForeColor = System.Drawing.Color.DarkGreen
        Me.txusername.Location = New System.Drawing.Point(129, 141)
        Me.txusername.Name = "txusername"
        Me.txusername.Size = New System.Drawing.Size(230, 30)
        Me.txusername.TabIndex = 50
        '
        'txname
        '
        Me.txname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txname.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txname.ForeColor = System.Drawing.Color.DarkGreen
        Me.txname.Location = New System.Drawing.Point(129, 105)
        Me.txname.Name = "txname"
        Me.txname.Size = New System.Drawing.Size(230, 30)
        Me.txname.TabIndex = 49
        '
        'txsearch
        '
        Me.txsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txsearch.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txsearch.ForeColor = System.Drawing.Color.DarkGreen
        Me.txsearch.Location = New System.Drawing.Point(129, 69)
        Me.txsearch.Name = "txsearch"
        Me.txsearch.Size = New System.Drawing.Size(230, 30)
        Me.txsearch.TabIndex = 48
        Me.txsearch.Text = "Enter username to edit"
        '
        'btneditpassword
        '
        Me.btneditpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditpassword.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditpassword.Location = New System.Drawing.Point(477, 172)
        Me.btneditpassword.Name = "btneditpassword"
        Me.btneditpassword.Size = New System.Drawing.Size(163, 30)
        Me.btneditpassword.TabIndex = 46
        Me.btneditpassword.Text = "Edit Password"
        Me.btneditpassword.UseVisualStyleBackColor = True
        Me.btneditpassword.Visible = False
        '
        'btneditusername
        '
        Me.btneditusername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditusername.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditusername.Location = New System.Drawing.Point(152, 228)
        Me.btneditusername.Name = "btneditusername"
        Me.btneditusername.Size = New System.Drawing.Size(84, 30)
        Me.btneditusername.TabIndex = 45
        Me.btneditusername.Text = "Done"
        Me.btneditusername.UseVisualStyleBackColor = True
        '
        'btneditname
        '
        Me.btneditname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditname.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditname.Location = New System.Drawing.Point(477, 113)
        Me.btneditname.Name = "btneditname"
        Me.btneditname.Size = New System.Drawing.Size(163, 30)
        Me.btneditname.TabIndex = 44
        Me.btneditname.Text = "Edit Name"
        Me.btneditname.UseVisualStyleBackColor = True
        Me.btneditname.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Username"
        '
        'N
        '
        Me.N.AutoSize = True
        Me.N.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.Location = New System.Drawing.Point(15, 108)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(61, 21)
        Me.N.TabIndex = 38
        Me.N.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 21)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Search username to edit"
        Me.Label1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 15.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1010, 438)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Rockwell", 15.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Rockwell", 15.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 407)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnDel)
        Me.GroupBox3.Controls.Add(Me.txdelinput)
        Me.GroupBox3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox3.Location = New System.Drawing.Point(917, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(36, 22)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delete User"
        Me.GroupBox3.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(40, 103)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(124, 27)
        Me.CheckBox2.TabIndex = 58
        Me.CheckBox2.Text = "Delete All"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(40, 136)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(170, 27)
        Me.CheckBox1.TabIndex = 57
        Me.CheckBox1.Text = "Delete by user"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Tag = ""
        Me.Label4.Text = "Enter usename to delete"
        Me.Label4.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(90, 228)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(117, 30)
        Me.btnDel.TabIndex = 54
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'txdelinput
        '
        Me.txdelinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txdelinput.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txdelinput.ForeColor = System.Drawing.Color.DarkGreen
        Me.txdelinput.Location = New System.Drawing.Point(40, 172)
        Me.txdelinput.Name = "txdelinput"
        Me.txdelinput.Size = New System.Drawing.Size(223, 30)
        Me.txdelinput.TabIndex = 52
        Me.txdelinput.Text = "Enter usename to delete"
        Me.txdelinput.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.AddJudgesAdministratorAccountToolStripMenuItem, Me.EditJudgesAdministratorAccountToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 114)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'AddJudgesAdministratorAccountToolStripMenuItem
        '
        Me.AddJudgesAdministratorAccountToolStripMenuItem.Name = "AddJudgesAdministratorAccountToolStripMenuItem"
        Me.AddJudgesAdministratorAccountToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddJudgesAdministratorAccountToolStripMenuItem.Text = "Add Account"
        '
        'EditJudgesAdministratorAccountToolStripMenuItem
        '
        Me.EditJudgesAdministratorAccountToolStripMenuItem.Name = "EditJudgesAdministratorAccountToolStripMenuItem"
        Me.EditJudgesAdministratorAccountToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EditJudgesAdministratorAccountToolStripMenuItem.Text = "Update Account"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteAllToolStripMenuItem.Text = "Delete All(judge)"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-8, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1054, 59)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1024, 511)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(12, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(149, 39)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "ACCOUNT"
        '
        'editUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 511)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btneditpassword As System.Windows.Forms.Button
    Friend WithEvents btneditusername As System.Windows.Forms.Button
    Friend WithEvents btneditname As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents N As System.Windows.Forms.Label
    Friend WithEvents txsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txpassword As System.Windows.Forms.TextBox
    Friend WithEvents txusername As System.Windows.Forms.TextBox
    Friend WithEvents txname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents txdelinput As System.Windows.Forms.TextBox
    Friend WithEvents ecrypt As System.Windows.Forms.Label
    Friend WithEvents txnamepo As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txconfirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkPshow As System.Windows.Forms.CheckBox
    Friend WithEvents cbousrtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents encryptedna As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddJudgesAdministratorAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditJudgesAdministratorAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
