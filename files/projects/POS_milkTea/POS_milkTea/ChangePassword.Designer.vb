<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.btncpass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.np = New System.Windows.Forms.TextBox()
        Me.op = New System.Windows.Forms.TextBox()
        Me.ux = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncpass
        '
        Me.btncpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncpass.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncpass.Location = New System.Drawing.Point(253, 85)
        Me.btncpass.Name = "btncpass"
        Me.btncpass.Size = New System.Drawing.Size(97, 34)
        Me.btncpass.TabIndex = 12
        Me.btncpass.Text = "Update"
        Me.btncpass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password"
        '
        'np
        '
        Me.np.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.np.Location = New System.Drawing.Point(142, 52)
        Me.np.Name = "np"
        Me.np.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.np.Size = New System.Drawing.Size(212, 27)
        Me.np.TabIndex = 10
        '
        'op
        '
        Me.op.Enabled = False
        Me.op.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op.Location = New System.Drawing.Point(142, 17)
        Me.op.Name = "op"
        Me.op.Size = New System.Drawing.Size(212, 27)
        Me.op.TabIndex = 9
        '
        'ux
        '
        Me.ux.AutoSize = True
        Me.ux.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ux.Location = New System.Drawing.Point(40, 99)
        Me.ux.Name = "ux"
        Me.ux.Size = New System.Drawing.Size(71, 19)
        Me.ux.TabIndex = 16
        Me.ux.Text = "Password"
        Me.ux.Visible = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 127)
        Me.Controls.Add(Me.ux)
        Me.Controls.Add(Me.op)
        Me.Controls.Add(Me.np)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncpass)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncpass As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents np As System.Windows.Forms.TextBox
    Friend WithEvents op As System.Windows.Forms.TextBox
    Friend WithEvents ux As System.Windows.Forms.Label
End Class
