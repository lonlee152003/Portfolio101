<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class remItem
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdel = New System.Windows.Forms.Button()
        Me.bcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(85, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 33)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Delete All Items"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdel
        '
        Me.cmdel.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cmdel.Location = New System.Drawing.Point(85, 61)
        Me.cmdel.Name = "cmdel"
        Me.cmdel.Size = New System.Drawing.Size(136, 33)
        Me.cmdel.TabIndex = 48
        Me.cmdel.Text = "Delete Item"
        Me.cmdel.UseVisualStyleBackColor = True
        '
        'bcode
        '
        Me.bcode.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.bcode.Location = New System.Drawing.Point(92, 23)
        Me.bcode.Name = "bcode"
        Me.bcode.Size = New System.Drawing.Size(187, 24)
        Me.bcode.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Barcode "
        '
        'remItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 144)
        Me.Controls.Add(Me.bcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdel)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "remItem"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdel As System.Windows.Forms.Button
    Friend WithEvents bcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
