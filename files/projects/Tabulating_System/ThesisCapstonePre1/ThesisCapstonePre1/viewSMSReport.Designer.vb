<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSMSReport
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
        Me.keyword_smsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.keyword_SMS = New ThesisCapstonePre1.keyword_SMS()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.keyword_smsTableAdapter = New ThesisCapstonePre1.keyword_SMSTableAdapters.keyword_smsTableAdapter()
        CType(Me.keyword_smsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyword_SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'keyword_smsBindingSource
        '
        Me.keyword_smsBindingSource.DataMember = "keyword_sms"
        Me.keyword_smsBindingSource.DataSource = Me.keyword_SMS
        '
        'keyword_SMS
        '
        Me.keyword_SMS.DataSetName = "keyword_SMS"
        Me.keyword_SMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.keyword_smsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ThesisCapstonePre1.smsReport.rdlc"
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
        'keyword_smsTableAdapter
        '
        Me.keyword_smsTableAdapter.ClearBeforeFill = True
        '
        'viewSMSReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 483)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "viewSMSReport"
        Me.Text = "SMS Report"
        CType(Me.keyword_smsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyword_SMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents keyword_smsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents keyword_SMS As ThesisCapstonePre1.keyword_SMS
    Friend WithEvents keyword_smsTableAdapter As ThesisCapstonePre1.keyword_SMSTableAdapters.keyword_smsTableAdapter
End Class
