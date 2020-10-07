<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCandidateRecord_others
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnregis = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txAddimg = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txno4 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txdepartment3 = New System.Windows.Forms.TextBox()
        Me.txname3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txaddress3 = New System.Windows.Forms.TextBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(12, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(352, 39)
        Me.Label23.TabIndex = 132
        Me.Label23.Text = "ADD CANDIDATE RECORD"
        '
        'btnregis
        '
        Me.btnregis.Location = New System.Drawing.Point(273, 230)
        Me.btnregis.Name = "btnregis"
        Me.btnregis.Size = New System.Drawing.Size(97, 30)
        Me.btnregis.TabIndex = 131
        Me.btnregis.Text = "Add Record"
        Me.btnregis.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Photo"
        '
        'txAddimg
        '
        Me.txAddimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txAddimg.Location = New System.Drawing.Point(140, 65)
        Me.txAddimg.Name = "txAddimg"
        Me.txAddimg.Size = New System.Drawing.Size(152, 27)
        Me.txAddimg.TabIndex = 128
        Me.txAddimg.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 30)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txno4
        '
        Me.txno4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txno4.Location = New System.Drawing.Point(140, 98)
        Me.txno4.Name = "txno4"
        Me.txno4.Size = New System.Drawing.Size(229, 27)
        Me.txno4.TabIndex = 123
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 19)
        Me.Label21.TabIndex = 124
        Me.Label21.Text = "Group number"
        '
        'txdepartment3
        '
        Me.txdepartment3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txdepartment3.Location = New System.Drawing.Point(140, 197)
        Me.txdepartment3.Name = "txdepartment3"
        Me.txdepartment3.Size = New System.Drawing.Size(230, 27)
        Me.txdepartment3.TabIndex = 116
        '
        'txname3
        '
        Me.txname3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txname3.Location = New System.Drawing.Point(140, 131)
        Me.txname3.Name = "txname3"
        Me.txname3.Size = New System.Drawing.Size(229, 27)
        Me.txname3.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Group name"
        '
        'txaddress3
        '
        Me.txaddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txaddress3.Location = New System.Drawing.Point(139, 164)
        Me.txaddress3.Name = "txaddress3"
        Me.txaddress3.Size = New System.Drawing.Size(230, 27)
        Me.txaddress3.TabIndex = 114
        '
        'RectangleShape1
        '
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-3, -2)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(385, 59)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(380, 268)
        Me.ShapeContainer1.TabIndex = 133
        Me.ShapeContainer1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(317, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 130
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'addCandidateRecord_others
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 268)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnregis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txAddimg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txno4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txdepartment3)
        Me.Controls.Add(Me.txname3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txaddress3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "addCandidateRecord_others"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "addCandidateRecord_others"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnregis As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txAddimg As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txno4 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txdepartment3 As System.Windows.Forms.TextBox
    Friend WithEvents txname3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txaddress3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
