<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class smsApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(smsApp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.xrefresh = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateBits = New System.Windows.Forms.ComboBox()
        Me.portName = New System.Windows.Forms.ComboBox()
        Me.baudRate = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CandidatenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeywordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeywordsmsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserADataSet = New ThesisCapstonePre1.UserADataSet()
        Me.txkeyt = New System.Windows.Forms.Label()
        Me.btnfresh = New System.Windows.Forms.Button()
        Me.txnana = New System.Windows.Forms.Label()
        Me.btneditkey = New System.Windows.Forms.Button()
        Me.txcatkey = New System.Windows.Forms.Label()
        Me.btnKeyword = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txKeyword = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txCandidato = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.refREC = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CellphonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiversmsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserADataSet1 = New ThesisCapstonePre1.UserADataSet1()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txcontact1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txCount = New System.Windows.Forms.Label()
        Me.txmess1 = New System.Windows.Forms.Label()
        Me.txmess = New System.Windows.Forms.Label()
        Me.txcontact = New System.Windows.Forms.Label()
        Me.rawSMS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoopIndicator = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.statx = New System.Windows.Forms.Label()
        Me.btnDc = New System.Windows.Forms.Button()
        Me.tes = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Keyword_smsTableAdapter = New ThesisCapstonePre1.UserADataSetTableAdapters.keyword_smsTableAdapter()
        Me.Receiver_smsTableAdapter = New ThesisCapstonePre1.UserADataSet1TableAdapters.receiver_smsTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeywordsmsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiversmsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR HERMANN", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SMS App"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(6, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1154, 251)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.xrefresh)
        Me.TabPage1.Controls.Add(Me.btnConnect)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.dateBits)
        Me.TabPage1.Controls.Add(Me.portName)
        Me.TabPage1.Controls.Add(Me.baudRate)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1146, 225)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PORT PROPERTIES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'xrefresh
        '
        Me.xrefresh.BackColor = System.Drawing.SystemColors.Control
        Me.xrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.xrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.xrefresh.Location = New System.Drawing.Point(355, 4)
        Me.xrefresh.Name = "xrefresh"
        Me.xrefresh.Size = New System.Drawing.Size(126, 39)
        Me.xrefresh.TabIndex = 41
        Me.xrefresh.Text = "REFRESH"
        Me.xrefresh.UseVisualStyleBackColor = False
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.SystemColors.Control
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnConnect.Location = New System.Drawing.Point(245, 180)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(161, 39)
        Me.btnConnect.TabIndex = 40
        Me.btnConnect.Text = "CONNECT"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(21, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "DATA BITS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Coral
        Me.Label5.Location = New System.Drawing.Point(21, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "BAUD RATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Coral
        Me.Label4.Location = New System.Drawing.Point(20, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "PORT NAME"
        '
        'dateBits
        '
        Me.dateBits.BackColor = System.Drawing.SystemColors.Control
        Me.dateBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dateBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dateBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dateBits.FormattingEnabled = True
        Me.dateBits.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
        Me.dateBits.Location = New System.Drawing.Point(227, 146)
        Me.dateBits.Name = "dateBits"
        Me.dateBits.Size = New System.Drawing.Size(254, 21)
        Me.dateBits.TabIndex = 36
        '
        'portName
        '
        Me.portName.BackColor = System.Drawing.SystemColors.Control
        Me.portName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.portName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.portName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.portName.FormattingEnabled = True
        Me.portName.Location = New System.Drawing.Point(227, 49)
        Me.portName.Name = "portName"
        Me.portName.Size = New System.Drawing.Size(254, 21)
        Me.portName.TabIndex = 34
        '
        'baudRate
        '
        Me.baudRate.BackColor = System.Drawing.SystemColors.Control
        Me.baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baudRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.baudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.baudRate.FormattingEnabled = True
        Me.baudRate.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200"})
        Me.baudRate.Location = New System.Drawing.Point(227, 99)
        Me.baudRate.Name = "baudRate"
        Me.baudRate.Size = New System.Drawing.Size(254, 21)
        Me.baudRate.TabIndex = 35
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1146, 225)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CREATE  MESSAGE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 101)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MESSAGE"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 16)
        Me.RichTextBox1.MaxLength = 160
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(362, 81)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 53)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTACT NUMBER"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 19)
        Me.TextBox1.MaxLength = 11
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(362, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Controls.Add(Me.txkeyt)
        Me.TabPage3.Controls.Add(Me.btnfresh)
        Me.TabPage3.Controls.Add(Me.txnana)
        Me.TabPage3.Controls.Add(Me.btneditkey)
        Me.TabPage3.Controls.Add(Me.txcatkey)
        Me.TabPage3.Controls.Add(Me.btnKeyword)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1146, 225)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "SET KEYWORD FOR TEXTERS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CandidatenoDataGridViewTextBoxColumn, Me.KeywordDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.KeywordsmsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(541, 42)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(381, 151)
        Me.DataGridView2.TabIndex = 16
        '
        'CandidatenoDataGridViewTextBoxColumn
        '
        Me.CandidatenoDataGridViewTextBoxColumn.DataPropertyName = "candidate_no"
        Me.CandidatenoDataGridViewTextBoxColumn.HeaderText = "candidate_no"
        Me.CandidatenoDataGridViewTextBoxColumn.Name = "CandidatenoDataGridViewTextBoxColumn"
        Me.CandidatenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeywordDataGridViewTextBoxColumn
        '
        Me.KeywordDataGridViewTextBoxColumn.DataPropertyName = "keyword"
        Me.KeywordDataGridViewTextBoxColumn.HeaderText = "keyword"
        Me.KeywordDataGridViewTextBoxColumn.Name = "KeywordDataGridViewTextBoxColumn"
        Me.KeywordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeywordsmsBindingSource
        '
        Me.KeywordsmsBindingSource.DataMember = "keyword_sms"
        Me.KeywordsmsBindingSource.DataSource = Me.UserADataSet
        '
        'UserADataSet
        '
        Me.UserADataSet.DataSetName = "UserADataSet"
        Me.UserADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txkeyt
        '
        Me.txkeyt.AutoSize = True
        Me.txkeyt.Location = New System.Drawing.Point(9, 85)
        Me.txkeyt.Name = "txkeyt"
        Me.txkeyt.Size = New System.Drawing.Size(24, 13)
        Me.txkeyt.TabIndex = 1
        Me.txkeyt.Text = "key"
        Me.txkeyt.Visible = False
        '
        'btnfresh
        '
        Me.btnfresh.Location = New System.Drawing.Point(123, 9)
        Me.btnfresh.Name = "btnfresh"
        Me.btnfresh.Size = New System.Drawing.Size(136, 23)
        Me.btnfresh.TabIndex = 6
        Me.btnfresh.Text = "REFRESH"
        Me.btnfresh.UseVisualStyleBackColor = True
        '
        'txnana
        '
        Me.txnana.AutoSize = True
        Me.txnana.Location = New System.Drawing.Point(51, 14)
        Me.txnana.Name = "txnana"
        Me.txnana.Size = New System.Drawing.Size(13, 13)
        Me.txnana.TabIndex = 15
        Me.txnana.Text = "0"
        Me.txnana.Visible = False
        '
        'btneditkey
        '
        Me.btneditkey.Location = New System.Drawing.Point(151, 193)
        Me.btneditkey.Name = "btneditkey"
        Me.btneditkey.Size = New System.Drawing.Size(136, 23)
        Me.btneditkey.TabIndex = 14
        Me.btneditkey.Text = "EDIT KEYWORD"
        Me.btneditkey.UseVisualStyleBackColor = True
        '
        'txcatkey
        '
        Me.txcatkey.AutoSize = True
        Me.txcatkey.Location = New System.Drawing.Point(32, 14)
        Me.txcatkey.Name = "txcatkey"
        Me.txcatkey.Size = New System.Drawing.Size(13, 13)
        Me.txcatkey.TabIndex = 13
        Me.txcatkey.Text = "0"
        Me.txcatkey.Visible = False
        '
        'btnKeyword
        '
        Me.btnKeyword.Location = New System.Drawing.Point(35, 193)
        Me.btnKeyword.Name = "btnKeyword"
        Me.btnKeyword.Size = New System.Drawing.Size(110, 23)
        Me.btnKeyword.TabIndex = 12
        Me.btnKeyword.Text = "SET KEYWORD"
        Me.btnKeyword.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txKeyword)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 97)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(495, 83)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "KEYWORD"
        '
        'txKeyword
        '
        Me.txKeyword.Location = New System.Drawing.Point(7, 30)
        Me.txKeyword.Name = "txKeyword"
        Me.txKeyword.Size = New System.Drawing.Size(482, 48)
        Me.txKeyword.TabIndex = 0
        Me.txKeyword.Tag = ""
        Me.txKeyword.Text = "Set unique keyword"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txCandidato)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(495, 50)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CANDIDATE"
        '
        'txCandidato
        '
        Me.txCandidato.FormattingEnabled = True
        Me.txCandidato.Location = New System.Drawing.Point(7, 21)
        Me.txCandidato.Name = "txCandidato"
        Me.txCandidato.Size = New System.Drawing.Size(483, 21)
        Me.txCandidato.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.txcontact1)
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.txmess1)
        Me.TabPage4.Controls.Add(Me.txmess)
        Me.TabPage4.Controls.Add(Me.txcontact)
        Me.TabPage4.Controls.Add(Me.rawSMS)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.LoopIndicator)
        Me.TabPage4.Controls.Add(Me.ListBox1)
        Me.TabPage4.Controls.Add(Me.ListBox2)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1146, 225)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "RECEIVE MESSAGE(s)"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.refREC)
        Me.GroupBox7.Controls.Add(Me.DataGridView1)
        Me.GroupBox7.Controls.Add(Me.btnStop)
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Location = New System.Drawing.Point(492, 30)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(562, 169)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "SMS RECORDS"
        '
        'refREC
        '
        Me.refREC.Location = New System.Drawing.Point(4, 141)
        Me.refREC.Name = "refREC"
        Me.refREC.Size = New System.Drawing.Size(165, 23)
        Me.refREC.TabIndex = 23
        Me.refREC.Text = "REFRESH SMS RECORD"
        Me.refREC.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CellphonenoDataGridViewTextBoxColumn, Me.MessageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReceiversmsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(45, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(498, 118)
        Me.DataGridView1.TabIndex = 22
        '
        'CellphonenoDataGridViewTextBoxColumn
        '
        Me.CellphonenoDataGridViewTextBoxColumn.DataPropertyName = "cellphone_no"
        Me.CellphonenoDataGridViewTextBoxColumn.HeaderText = "cellphone_no"
        Me.CellphonenoDataGridViewTextBoxColumn.Name = "CellphonenoDataGridViewTextBoxColumn"
        Me.CellphonenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MessageDataGridViewTextBoxColumn
        '
        Me.MessageDataGridViewTextBoxColumn.DataPropertyName = "message"
        Me.MessageDataGridViewTextBoxColumn.HeaderText = "message"
        Me.MessageDataGridViewTextBoxColumn.Name = "MessageDataGridViewTextBoxColumn"
        Me.MessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReceiversmsBindingSource
        '
        Me.ReceiversmsBindingSource.DataMember = "receiver_sms"
        Me.ReceiversmsBindingSource.DataSource = Me.UserADataSet1
        '
        'UserADataSet1
        '
        Me.UserADataSet1.DataSetName = "UserADataSet1"
        Me.UserADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(419, 143)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(124, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "STOP RECEIVING"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(295, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "START RECEIVING"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(169, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "TEXT MODE ON"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txcontact1
        '
        Me.txcontact1.AutoSize = True
        Me.txcontact1.Location = New System.Drawing.Point(266, 79)
        Me.txcontact1.Name = "txcontact1"
        Me.txcontact1.Size = New System.Drawing.Size(13, 13)
        Me.txcontact1.TabIndex = 20
        Me.txcontact1.Text = "0"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txCount)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(496, 47)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "MESSAGE RECEIVED COUNT INDICATOR"
        '
        'txCount
        '
        Me.txCount.AutoSize = True
        Me.txCount.Location = New System.Drawing.Point(25, 21)
        Me.txCount.Name = "txCount"
        Me.txCount.Size = New System.Drawing.Size(13, 13)
        Me.txCount.TabIndex = 17
        Me.txCount.Text = "0"
        '
        'txmess1
        '
        Me.txmess1.AutoSize = True
        Me.txmess1.Location = New System.Drawing.Point(266, 105)
        Me.txmess1.Name = "txmess1"
        Me.txmess1.Size = New System.Drawing.Size(13, 13)
        Me.txmess1.TabIndex = 19
        Me.txmess1.Text = "0"
        '
        'txmess
        '
        Me.txmess.AutoSize = True
        Me.txmess.Location = New System.Drawing.Point(3, 105)
        Me.txmess.Name = "txmess"
        Me.txmess.Size = New System.Drawing.Size(31, 13)
        Me.txmess.TabIndex = 13
        Me.txmess.Text = "mess"
        Me.txmess.Visible = False
        '
        'txcontact
        '
        Me.txcontact.AutoSize = True
        Me.txcontact.Location = New System.Drawing.Point(3, 90)
        Me.txcontact.Name = "txcontact"
        Me.txcontact.Size = New System.Drawing.Size(55, 13)
        Me.txcontact.TabIndex = 12
        Me.txcontact.Text = "contactno"
        Me.txcontact.Visible = False
        '
        'rawSMS
        '
        Me.rawSMS.Location = New System.Drawing.Point(132, 202)
        Me.rawSMS.Name = "rawSMS"
        Me.rawSMS.Size = New System.Drawing.Size(114, 20)
        Me.rawSMS.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'LoopIndicator
        '
        Me.LoopIndicator.AutoSize = True
        Me.LoopIndicator.Location = New System.Drawing.Point(3, 143)
        Me.LoopIndicator.Name = "LoopIndicator"
        Me.LoopIndicator.Size = New System.Drawing.Size(13, 13)
        Me.LoopIndicator.TabIndex = 2
        Me.LoopIndicator.Text = "0"
        Me.LoopIndicator.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"OK"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(156, 56)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 130)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.statx)
        Me.GroupBox1.Controls.Add(Me.btnDc)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 47)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STATUS"
        '
        'statx
        '
        Me.statx.AutoSize = True
        Me.statx.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statx.ForeColor = System.Drawing.Color.Red
        Me.statx.Location = New System.Drawing.Point(24, 19)
        Me.statx.Name = "statx"
        Me.statx.Size = New System.Drawing.Size(0, 19)
        Me.statx.TabIndex = 34
        Me.statx.Visible = False
        '
        'btnDc
        '
        Me.btnDc.Enabled = False
        Me.btnDc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDc.Location = New System.Drawing.Point(384, 15)
        Me.btnDc.Name = "btnDc"
        Me.btnDc.Size = New System.Drawing.Size(103, 23)
        Me.btnDc.TabIndex = 1
        Me.btnDc.Text = "DISCONNECT"
        Me.btnDc.UseVisualStyleBackColor = True
        '
        'tes
        '
        Me.tes.AutoSize = True
        Me.tes.Location = New System.Drawing.Point(80, 307)
        Me.tes.Name = "tes"
        Me.tes.Size = New System.Drawing.Size(39, 13)
        Me.tes.TabIndex = 35
        Me.tes.Text = "Label2"
        Me.tes.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM35"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Keyword_smsTableAdapter
        '
        Me.Keyword_smsTableAdapter.ClearBeforeFill = True
        '
        'Receiver_smsTableAdapter
        '
        Me.Receiver_smsTableAdapter.ClearBeforeFill = True
        '
        'smsApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 377)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "smsApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sms app"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeywordsmsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiversmsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents xrefresh As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateBits As System.Windows.Forms.ComboBox
    Friend WithEvents portName As System.Windows.Forms.ComboBox
    Friend WithEvents baudRate As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents statx As System.Windows.Forms.Label
    Friend WithEvents btnDc As System.Windows.Forms.Button
    Friend WithEvents tes As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LoopIndicator As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents rawSMS As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents txmess As System.Windows.Forms.Label
    Friend WithEvents txcontact As System.Windows.Forms.Label

    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox

    Friend WithEvents txCount As System.Windows.Forms.Label
    Friend WithEvents txcontact1 As System.Windows.Forms.Label
    Friend WithEvents txmess1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnfresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txKeyword As System.Windows.Forms.RichTextBox
    Friend WithEvents txCandidato As System.Windows.Forms.ComboBox
    Friend WithEvents btnKeyword As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txcatkey As System.Windows.Forms.Label
    Friend WithEvents btneditkey As System.Windows.Forms.Button
    Friend WithEvents txnana As System.Windows.Forms.Label
    Friend WithEvents txkeyt As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents UserADataSet As ThesisCapstonePre1.UserADataSet
    Friend WithEvents KeywordsmsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Keyword_smsTableAdapter As ThesisCapstonePre1.UserADataSetTableAdapters.keyword_smsTableAdapter
    Friend WithEvents CandidatenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeywordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserADataSet1 As ThesisCapstonePre1.UserADataSet1
    Friend WithEvents ReceiversmsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Receiver_smsTableAdapter As ThesisCapstonePre1.UserADataSet1TableAdapters.receiver_smsTableAdapter
    Friend WithEvents CellphonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents refREC As System.Windows.Forms.Button
End Class
