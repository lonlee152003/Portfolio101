<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class judgeContestantUserLang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txjudgeuser = New System.Windows.Forms.Label()
        Me.grpcandidate = New System.Windows.Forms.GroupBox()
        Me.cbocandidate = New System.Windows.Forms.ComboBox()
        Me.btncandidate = New System.Windows.Forms.Button()
        Me.grpcategory = New System.Windows.Forms.GroupBox()
        Me.datagridcriteria = New System.Windows.Forms.DataGridView()
        Me.cbocategory = New System.Windows.Forms.ComboBox()
        Me.btncategory = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbllogout = New System.Windows.Forms.Label()
        Me.lblrefresh = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpcandidate.SuspendLayout()
        Me.grpcategory.SuspendLayout()
        CType(Me.datagridcriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You are login as,"
        '
        'txjudgeuser
        '
        Me.txjudgeuser.AutoSize = True
        Me.txjudgeuser.Location = New System.Drawing.Point(102, 17)
        Me.txjudgeuser.Name = "txjudgeuser"
        Me.txjudgeuser.Size = New System.Drawing.Size(36, 13)
        Me.txjudgeuser.TabIndex = 1
        Me.txjudgeuser.Text = "Judge"
        '
        'grpcandidate
        '
        Me.grpcandidate.Controls.Add(Me.cbocandidate)
        Me.grpcandidate.Controls.Add(Me.btncandidate)
        Me.grpcandidate.Location = New System.Drawing.Point(6, 42)
        Me.grpcandidate.Name = "grpcandidate"
        Me.grpcandidate.Size = New System.Drawing.Size(273, 82)
        Me.grpcandidate.TabIndex = 3
        Me.grpcandidate.TabStop = False
        Me.grpcandidate.Text = "Select Candidate"
        '
        'cbocandidate
        '
        Me.cbocandidate.BackColor = System.Drawing.SystemColors.Window
        Me.cbocandidate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbocandidate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocandidate.ForeColor = System.Drawing.SystemColors.Window
        Me.cbocandidate.FormattingEnabled = True
        Me.cbocandidate.Location = New System.Drawing.Point(17, 32)
        Me.cbocandidate.Name = "cbocandidate"
        Me.cbocandidate.Size = New System.Drawing.Size(161, 21)
        Me.cbocandidate.TabIndex = 6
        '
        'btncandidate
        '
        Me.btncandidate.Location = New System.Drawing.Point(184, 30)
        Me.btncandidate.Name = "btncandidate"
        Me.btncandidate.Size = New System.Drawing.Size(75, 23)
        Me.btncandidate.TabIndex = 5
        Me.btncandidate.Text = "Select"
        Me.btncandidate.UseVisualStyleBackColor = True
        '
        'grpcategory
        '
        Me.grpcategory.Controls.Add(Me.Button3)
        Me.grpcategory.Controls.Add(Me.Label2)
        Me.grpcategory.Controls.Add(Me.datagridcriteria)
        Me.grpcategory.Controls.Add(Me.cbocategory)
        Me.grpcategory.Controls.Add(Me.btncategory)
        Me.grpcategory.Location = New System.Drawing.Point(6, 126)
        Me.grpcategory.Name = "grpcategory"
        Me.grpcategory.Size = New System.Drawing.Size(273, 391)
        Me.grpcategory.TabIndex = 4
        Me.grpcategory.TabStop = False
        Me.grpcategory.Text = "Select Category"
        '
        'datagridcriteria
        '
        Me.datagridcriteria.AllowUserToAddRows = False
        Me.datagridcriteria.AllowUserToDeleteRows = False
        Me.datagridcriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridcriteria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridcriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridcriteria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        Me.datagridcriteria.EnableHeadersVisualStyles = False
        Me.datagridcriteria.Location = New System.Drawing.Point(17, 96)
        Me.datagridcriteria.Name = "datagridcriteria"
        Me.datagridcriteria.Size = New System.Drawing.Size(242, 242)
        Me.datagridcriteria.TabIndex = 7
        '
        'cbocategory
        '
        Me.cbocategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocategory.FormattingEnabled = True
        Me.cbocategory.Location = New System.Drawing.Point(17, 32)
        Me.cbocategory.Name = "cbocategory"
        Me.cbocategory.Size = New System.Drawing.Size(161, 21)
        Me.cbocategory.TabIndex = 6
        '
        'btncategory
        '
        Me.btncategory.Location = New System.Drawing.Point(184, 30)
        Me.btncategory.Name = "btncategory"
        Me.btncategory.Size = New System.Drawing.Size(75, 23)
        Me.btncategory.TabIndex = 5
        Me.btncategory.Text = "Select"
        Me.btncategory.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(285, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 174)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Candidate Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(548, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 174)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Video Conference"
        '
        'lbllogout
        '
        Me.lbllogout.AutoSize = True
        Me.lbllogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbllogout.Location = New System.Drawing.Point(144, 17)
        Me.lbllogout.Name = "lbllogout"
        Me.lbllogout.Size = New System.Drawing.Size(40, 13)
        Me.lbllogout.TabIndex = 7
        Me.lbllogout.Text = "Logout"
        '
        'lblrefresh
        '
        Me.lblrefresh.AutoSize = True
        Me.lblrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblrefresh.Location = New System.Drawing.Point(195, 17)
        Me.lblrefresh.Name = "lblrefresh"
        Me.lblrefresh.Size = New System.Drawing.Size(84, 13)
        Me.lblrefresh.TabIndex = 12
        Me.lblrefresh.Text = "Refresh All Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(285, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 332)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Scoreboard"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Criteria"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Score"
        Me.Column6.Name = "Column6"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(463, 304)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Category Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Criteria"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Max. Value"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Score"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Criteria"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(99, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Tabulate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'judgeContestantUserLang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 524)
        Me.Controls.Add(Me.lblrefresh)
        Me.Controls.Add(Me.lbllogout)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpcategory)
        Me.Controls.Add(Me.grpcandidate)
        Me.Controls.Add(Me.txjudgeuser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "judgeContestantUserLang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabulation Screen"
        Me.grpcandidate.ResumeLayout(False)
        Me.grpcategory.ResumeLayout(False)
        Me.grpcategory.PerformLayout()
        CType(Me.datagridcriteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txjudgeuser As System.Windows.Forms.Label
    Friend WithEvents grpcandidate As System.Windows.Forms.GroupBox
    Friend WithEvents grpcategory As System.Windows.Forms.GroupBox
    Friend WithEvents cbocandidate As System.Windows.Forms.ComboBox
    Friend WithEvents btncandidate As System.Windows.Forms.Button
    Friend WithEvents cbocategory As System.Windows.Forms.ComboBox
    Friend WithEvents btncategory As System.Windows.Forms.Button
    Friend WithEvents datagridcriteria As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbllogout As System.Windows.Forms.Label
    Friend WithEvents lblrefresh As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
