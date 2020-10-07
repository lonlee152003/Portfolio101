<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashcredit
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ee = New System.Windows.Forms.Label()
        Me.f = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.g = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ee
        '
        Me.ee.AutoSize = True
        Me.ee.BackColor = System.Drawing.Color.Transparent
        Me.ee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ee.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ee.ForeColor = System.Drawing.Color.White
        Me.ee.Location = New System.Drawing.Point(12, 4)
        Me.ee.Name = "ee"
        Me.ee.Size = New System.Drawing.Size(785, 75)
        Me.ee.TabIndex = 42
        Me.ee.Text = "Researcher: R-Jay De Leon Balmores"
        Me.ee.Visible = False
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.BackColor = System.Drawing.Color.Transparent
        Me.f.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.f.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f.ForeColor = System.Drawing.Color.White
        Me.f.Location = New System.Drawing.Point(124, 5)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(561, 75)
        Me.f.TabIndex = 43
        Me.f.Text = "Writer: Dexter John Ebreo"
        Me.f.Visible = False
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.BackColor = System.Drawing.Color.Transparent
        Me.d.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.d.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.White
        Me.d.Location = New System.Drawing.Point(83, 5)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(643, 75)
        Me.d.TabIndex = 44
        Me.d.Text = "System Analyst: Jonelle Yapit"
        Me.d.Visible = False
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.BackColor = System.Drawing.Color.Transparent
        Me.c.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.c.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.ForeColor = System.Drawing.Color.White
        Me.c.Location = New System.Drawing.Point(100, 4)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(608, 75)
        Me.c.TabIndex = 45
        Me.c.Text = "Programmer: BlueHaxxor_15"
        Me.c.Visible = False
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.BackColor = System.Drawing.Color.Transparent
        Me.b.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.ForeColor = System.Drawing.Color.White
        Me.b.Location = New System.Drawing.Point(72, 2)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(665, 75)
        Me.b.TabIndex = 46
        Me.b.Text = "Design by Amateur Developers"
        Me.b.Visible = False
        '
        'g
        '
        Me.g.AutoSize = True
        Me.g.BackColor = System.Drawing.Color.Transparent
        Me.g.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.g.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g.ForeColor = System.Drawing.Color.White
        Me.g.Location = New System.Drawing.Point(270, 4)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(268, 75)
        Me.g.TabIndex = 47
        Me.g.Text = "Mark Ebreo"
        Me.g.Visible = False
        '
        'splashcredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ThesisCapstonePre1.My.Resources.Resources._11713923_836761046392259_7687087614864504782_o
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 82)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.ee)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.g)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "splashcredit"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splashcredit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ee As System.Windows.Forms.Label
    Friend WithEvents f As System.Windows.Forms.Label
    Friend WithEvents d As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.Label
    Friend WithEvents g As System.Windows.Forms.Label
End Class
