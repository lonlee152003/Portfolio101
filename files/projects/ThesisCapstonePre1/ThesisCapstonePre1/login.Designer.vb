<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txusername = New System.Windows.Forms.TextBox()
        Me.txpassword = New System.Windows.Forms.TextBox()
        Me.txuser = New System.Windows.Forms.TextBox()
        Me.txusername1 = New System.Windows.Forms.TextBox()
        Me.txpassword1 = New System.Windows.Forms.TextBox()
        Me.txStat = New System.Windows.Forms.TextBox()
        Me.chkSPass = New System.Windows.Forms.CheckBox()
        Me.decryptedna = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(104, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(102, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Black
        Me.btnlogin.Location = New System.Drawing.Point(363, 172)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(122, 30)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(616, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(38, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txusername
        '
        Me.txusername.BackColor = System.Drawing.Color.White
        Me.txusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txusername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txusername.Location = New System.Drawing.Point(222, 82)
        Me.txusername.Name = "txusername"
        Me.txusername.Size = New System.Drawing.Size(275, 27)
        Me.txusername.TabIndex = 6
        '
        'txpassword
        '
        Me.txpassword.BackColor = System.Drawing.Color.White
        Me.txpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txpassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txpassword.Location = New System.Drawing.Point(222, 113)
        Me.txpassword.Name = "txpassword"
        Me.txpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9676)
        Me.txpassword.Size = New System.Drawing.Size(275, 27)
        Me.txpassword.TabIndex = 7
        '
        'txuser
        '
        Me.txuser.Location = New System.Drawing.Point(516, 200)
        Me.txuser.Name = "txuser"
        Me.txuser.Size = New System.Drawing.Size(100, 20)
        Me.txuser.TabIndex = 8
        Me.txuser.Visible = False
        '
        'txusername1
        '
        Me.txusername1.Location = New System.Drawing.Point(513, 135)
        Me.txusername1.Name = "txusername1"
        Me.txusername1.Size = New System.Drawing.Size(100, 20)
        Me.txusername1.TabIndex = 9
        Me.txusername1.Visible = False
        '
        'txpassword1
        '
        Me.txpassword1.Location = New System.Drawing.Point(513, 161)
        Me.txpassword1.Name = "txpassword1"
        Me.txpassword1.Size = New System.Drawing.Size(100, 20)
        Me.txpassword1.TabIndex = 10
        Me.txpassword1.Visible = False
        '
        'txStat
        '
        Me.txStat.Location = New System.Drawing.Point(516, 226)
        Me.txStat.Name = "txStat"
        Me.txStat.Size = New System.Drawing.Size(100, 20)
        Me.txStat.TabIndex = 11
        Me.txStat.Visible = False
        '
        'chkSPass
        '
        Me.chkSPass.AutoSize = True
        Me.chkSPass.BackColor = System.Drawing.Color.White
        Me.chkSPass.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSPass.ForeColor = System.Drawing.Color.Black
        Me.chkSPass.Location = New System.Drawing.Point(349, 143)
        Me.chkSPass.Name = "chkSPass"
        Me.chkSPass.Size = New System.Drawing.Size(148, 23)
        Me.chkSPass.TabIndex = 12
        Me.chkSPass.Text = "SHOW PASSWORD"
        Me.chkSPass.UseVisualStyleBackColor = False
        '
        'decryptedna
        '
        Me.decryptedna.AutoSize = True
        Me.decryptedna.Location = New System.Drawing.Point(600, 184)
        Me.decryptedna.Name = "decryptedna"
        Me.decryptedna.Size = New System.Drawing.Size(13, 13)
        Me.decryptedna.TabIndex = 13
        Me.decryptedna.Text = "0"
        Me.decryptedna.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(666, 223)
        Me.ShapeContainer1.TabIndex = 38
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RectangleShape1.BackColor = System.Drawing.Color.Black
        Me.RectangleShape1.FillColor = System.Drawing.Color.Black
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.ForestGreen
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-4, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(672, 59)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.Font = New System.Drawing.Font("AR DESTINE", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Ivory
        Me.Label4.Location = New System.Drawing.Point(417, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 32)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "UNIVERSITY"
        Me.Label4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.ForestGreen
        Me.Label8.ForeColor = System.Drawing.Color.Ivory
        Me.Label8.Location = New System.Drawing.Point(378, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "_______________________________________"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.ForestGreen
        Me.Label6.Font = New System.Drawing.Font("AR DESTINE", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Ivory
        Me.Label6.Location = New System.Drawing.Point(405, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 38)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "PHILIPPINES"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.ForestGreen
        Me.Label7.Font = New System.Drawing.Font("AR DESTINE", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Ivory
        Me.Label7.Location = New System.Drawing.Point(21, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 38)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "PANPACIFIC"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.ForestGreen
        Me.Label9.Font = New System.Drawing.Font("AR DESTINE", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Ivory
        Me.Label9.Location = New System.Drawing.Point(55, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 38)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "NORTH"
        Me.Label9.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.ForestGreen
        Me.Label5.ForeColor = System.Drawing.Color.Ivory
        Me.Label5.Location = New System.Drawing.Point(1, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "_______________________________________"
        Me.Label5.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 223)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txpassword)
        Me.Controls.Add(Me.txusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkSPass)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.decryptedna)
        Me.Controls.Add(Me.txStat)
        Me.Controls.Add(Me.txpassword1)
        Me.Controls.Add(Me.txusername1)
        Me.Controls.Add(Me.txuser)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txusername As System.Windows.Forms.TextBox
    Friend WithEvents txpassword As System.Windows.Forms.TextBox
    Friend WithEvents txuser As System.Windows.Forms.TextBox
    Friend WithEvents txusername1 As System.Windows.Forms.TextBox
    Friend WithEvents txpassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txStat As System.Windows.Forms.TextBox
    Friend WithEvents chkSPass As System.Windows.Forms.CheckBox
    Friend WithEvents decryptedna As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
