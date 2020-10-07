<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.categoryReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserADataSet4 = New ThesisCapstonePre1.UserADataSet4()
        Me.CategoryReportBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserADataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.categoryReportTableAdapter = New ThesisCapstonePre1.UserADataSet4TableAdapters.categoryReportTableAdapter()
        Me.category = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.categoryReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserADataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryReportBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserADataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryReportBindingSource
        '
        Me.categoryReportBindingSource.DataMember = "categoryReport"
        Me.categoryReportBindingSource.DataSource = Me.UserADataSet4
        '
        'UserADataSet4
        '
        Me.UserADataSet4.DataSetName = "UserADataSet4"
        Me.UserADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryReportBindingSource1
        '
        Me.CategoryReportBindingSource1.DataMember = "categoryReport"
        Me.CategoryReportBindingSource1.DataSource = Me.UserADataSet4BindingSource
        '
        'UserADataSet4BindingSource
        '
        Me.UserADataSet4BindingSource.DataSource = Me.UserADataSet4
        Me.UserADataSet4BindingSource.Position = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.categoryReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ThesisCapstonePre1.catRep.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(690, 483)
        Me.ReportViewer1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'categoryReportTableAdapter
        '
        Me.categoryReportTableAdapter.ClearBeforeFill = True
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.Location = New System.Drawing.Point(493, 242)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(39, 13)
        Me.category.TabIndex = 6
        Me.category.Text = "Label1"
        Me.category.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'viewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 483)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "viewReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Report"
        CType(Me.categoryReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserADataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryReportBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserADataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents categoryReportTableAdapter As ThesisCapstonePre1.UserADataSet4TableAdapters.categoryReportTableAdapter
    Friend WithEvents categoryReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserADataSet4 As ThesisCapstonePre1.UserADataSet4
    Friend WithEvents CategoryReportBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UserADataSet4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents category As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    'Friend WithEvents categorySet As ThesisCapstonePre1.categorySet
    'Friend WithEvents categoryReportTableAdapter As ThesisCapstonePre1.categorySetTableAdapters.categoryReportTableAdapter
End Class
