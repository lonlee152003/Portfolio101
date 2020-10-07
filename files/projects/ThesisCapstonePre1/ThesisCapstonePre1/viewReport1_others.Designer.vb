<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewReport1_others
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
        Me.totalReport_othersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.oaReport_others = New ThesisCapstonePre1.oaReport_others()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.totalReport_othersTableAdapter = New ThesisCapstonePre1.oaReport_othersTableAdapters.totalReport_othersTableAdapter()
        Me.category = New System.Windows.Forms.Label()
        CType(Me.totalReport_othersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oaReport_others, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totalReport_othersBindingSource
        '
        Me.totalReport_othersBindingSource.DataMember = "totalReport_others"
        Me.totalReport_othersBindingSource.DataSource = Me.oaReport_others
        '
        'oaReport_others
        '
        Me.oaReport_others.DataSetName = "oaReport_others"
        Me.oaReport_others.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.totalReport_othersBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ThesisCapstonePre1.oaReport_others.rdlc"
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
        Me.ReportViewer1.TabIndex = 0
        '
        'totalReport_othersTableAdapter
        '
        Me.totalReport_othersTableAdapter.ClearBeforeFill = True
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.Location = New System.Drawing.Point(493, 242)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(39, 13)
        Me.category.TabIndex = 7
        Me.category.Text = "Label1"
        Me.category.Visible = False
        '
        'viewReport1_others
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 483)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "viewReport1_others"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Report"
        CType(Me.totalReport_othersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oaReport_others, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents totalReport_othersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents oaReport_others As ThesisCapstonePre1.oaReport_others
    Friend WithEvents totalReport_othersTableAdapter As ThesisCapstonePre1.oaReport_othersTableAdapters.totalReport_othersTableAdapter
    Friend WithEvents category As System.Windows.Forms.Label
End Class
