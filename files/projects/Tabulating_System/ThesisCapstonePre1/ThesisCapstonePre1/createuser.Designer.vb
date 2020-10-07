<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createuser))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txpassword = New System.Windows.Forms.TextBox()
        Me.txconfirmpassword = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbousrtype = New System.Windows.Forms.ComboBox()
        Me.chkPshow = New System.Windows.Forms.CheckBox()
        Me.encryptedna = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txname = New System.Windows.Forms.TextBox()
        Me.txusername = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Confirm Password"
        '
        'txpassword
        '
        Me.txpassword.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txpassword.Location = New System.Drawing.Point(394, 217)
        Me.txpassword.Name = "txpassword"
        Me.txpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9676)
        Me.txpassword.Size = New System.Drawing.Size(402, 30)
        Me.txpassword.TabIndex = 7
        '
        'txconfirmpassword
        '
        Me.txconfirmpassword.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txconfirmpassword.Location = New System.Drawing.Point(394, 264)
        Me.txconfirmpassword.Name = "txconfirmpassword"
        Me.txconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9676)
        Me.txconfirmpassword.Size = New System.Drawing.Size(402, 30)
        Me.txconfirmpassword.TabIndex = 8
        '
        'btnReg
        '
        Me.btnReg.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnReg.Location = New System.Drawing.Point(656, 420)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(140, 30)
        Me.btnReg.TabIndex = 9
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnClr.Location = New System.Drawing.Point(575, 420)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 30)
        Me.btnClr.TabIndex = 10
        Me.btnClr.Text = "Clear Form"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "User Type"
        '
        'cbousrtype
        '
        Me.cbousrtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbousrtype.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbousrtype.ForeColor = System.Drawing.Color.DarkGreen
        Me.cbousrtype.FormattingEnabled = True
        Me.cbousrtype.Items.AddRange(New Object() {"admin", "user"})
        Me.cbousrtype.Location = New System.Drawing.Point(394, 352)
        Me.cbousrtype.Name = "cbousrtype"
        Me.cbousrtype.Size = New System.Drawing.Size(402, 29)
        Me.cbousrtype.TabIndex = 12
        '
        'chkPshow
        '
        Me.chkPshow.AutoSize = True
        Me.chkPshow.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPshow.Location = New System.Drawing.Point(630, 311)
        Me.chkPshow.Name = "chkPshow"
        Me.chkPshow.Size = New System.Drawing.Size(166, 25)
        Me.chkPshow.TabIndex = 13
        Me.chkPshow.Text = "Show Password"
        Me.chkPshow.UseVisualStyleBackColor = True
        '
        'encryptedna
        '
        Me.encryptedna.AutoSize = True
        Me.encryptedna.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encryptedna.Location = New System.Drawing.Point(802, 126)
        Me.encryptedna.Name = "encryptedna"
        Me.encryptedna.Size = New System.Drawing.Size(20, 21)
        Me.encryptedna.TabIndex = 14
        Me.encryptedna.Text = "0"
        Me.encryptedna.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(444, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ThesisCapstonePre1.My.Resources.Resources._3peeps
        Me.PictureBox1.Location = New System.Drawing.Point(879, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'txname
        '
        Me.txname.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txname.Location = New System.Drawing.Point(394, 123)
        Me.txname.Name = "txname"
        Me.txname.Size = New System.Drawing.Size(402, 30)
        Me.txname.TabIndex = 5
        '
        'txusername
        '
        Me.txusername.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txusername.Location = New System.Drawing.Point(394, 169)
        Me.txusername.Name = "txusername"
        Me.txusername.Size = New System.Drawing.Size(402, 30)
        Me.txusername.TabIndex = 6
        '
        'createuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1034, 511)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.encryptedna)
        Me.Controls.Add(Me.chkPshow)
        Me.Controls.Add(Me.cbousrtype)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txconfirmpassword)
        Me.Controls.Add(Me.txpassword)
        Me.Controls.Add(Me.txusername)
        Me.Controls.Add(Me.txname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(700, 1200)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "createuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txpassword As System.Windows.Forms.TextBox
    Friend WithEvents txconfirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbousrtype As System.Windows.Forms.ComboBox
    Friend WithEvents chkPshow As System.Windows.Forms.CheckBox
    Friend WithEvents encryptedna As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txname As System.Windows.Forms.TextBox
    Friend WithEvents txusername As System.Windows.Forms.TextBox
End Class
