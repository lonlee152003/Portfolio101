Imports System.Windows.Forms
Imports System.Diagnostics
Imports mCore
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class sampleSMSApp

    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private WithEvents objSMS As New mCore.SMS
    Private strMyAppName As String = "Powered by mCore™ SMS"
    Private blnFormLoaded As Boolean = False

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        objSMS.Dispose()
        objSMS = Nothing
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            
            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("Select candidate_no,keyword from keyword_sms", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            DataGridView2.DataSource = dtt
            cnn.Close()


            Dim i As Integer

            '=====================================================================
            ' If you have purchased mCore .NET Library license, then enter license
            ' information in the following three lines of code
            '=====================================================================
            'licensed Here!!!
            Dim objSMS As mCore.SMS, objLicense As Object
            objSMS = New mCore.SMS
            objLicense = objSMS.License
            objSMS.License.Company = "Logix Mobile"
            objSMS.License.LicenseType = "PRO-DISTRIBUTION"
            objSMS.License.Key = "AE1K-X12R-GHEK-JEWS"
            '=====================================================================

            '------------------------------------
            'Initialize COM Port DropDown List
            '------------------------------------
            cboPort.Items.Add("Select Port")
            For i = 1 To 256
                cboPort.Items.Add("COM" & i.ToString)
            Next
            cboPort.SelectedIndex = 0

            '------------------------------------
            'Initialize BaudRate DropDown List
            '------------------------------------
            With cboBaudRate
                .Items.Add("110")
                .Items.Add("300")
                .Items.Add("1200")
                .Items.Add("2400")
                .Items.Add("4800")
                .Items.Add("9600")
                .Items.Add("14400")
                .Items.Add("19200")
                .Items.Add("38400")
                .Items.Add("57600")
                .Items.Add("115200")
                .Items.Add("230400")
                .Items.Add("460800")
                .Items.Add("921600")
            End With
            cboBaudRate.SelectedIndex = cboBaudRate.FindString(CType(objSMS.BaudRate, Integer).ToString)

            '------------------------------------
            'Initialize DataBits DropDown List
            '------------------------------------
            With cboDataBits
                .Items.Add("4")
                .Items.Add("5")
                .Items.Add("6")
                .Items.Add("7")
                .Items.Add("8")
            End With
            cboDataBits.SelectedIndex = cboDataBits.FindString(CType(objSMS.DataBits, Integer).ToString)

            '------------------------------------
            'Initialize Parity DropDown List
            '------------------------------------
            With cboParity
                .Items.Add("None")
                .Items.Add("Odd")
                .Items.Add("Even")
                .Items.Add("Mark")
                .Items.Add("Space")
            End With
            cboParity.SelectedIndex = CType(objSMS.Parity, Integer)

            '------------------------------------
            'Initialize StopBits DropDown List
            '------------------------------------
            With cboStopBits
                .Items.Add("1")
                .Items.Add("2")
                .Items.Add("1.5")
            End With
            cboStopBits.SelectedIndex = CType(objSMS.StopBits, Integer) - 1

            '------------------------------------
            'Initialize FlowControl DropDown List
            '------------------------------------
            With cboFlowControl
                .Items.Add("None")
                .Items.Add("Hardware")
                .Items.Add("Xon/Xoff")
            End With
            cboFlowControl.SelectedIndex = CType(objSMS.FlowControl, Integer)

            '-------------------------------------------------
            'Initialize Send Delay, Send Retry & Timeout
            '-------------------------------------------------
            txtSendDelay.Text = (objSMS.SendDelay / 1000).ToString
            txtSendRetry.Text = objSMS.SendRetry.ToString
            txtTimeout.Text = (objSMS.Timeout / 1000).ToString

            chkDisableCheckPIN.Checked = objSMS.DisableCheckPIN

            objSMS.ReadIntervalTimeout = 100
            objSMS.DelayAfterPIN = 20000

            chkIncomingCall.Checked = objSMS.IncomingCallIndication
            objSMS.Queue.Enabled = True
            chkQueue.Checked = objSMS.Queue.Enabled

            '----------------------------------------
            'Initialize Message Memory DropDown List
            '----------------------------------------
            With cboMsgMemory
                .Items.Add("SIM")
                .Items.Add("Phone")
                .Items.Add("SIM+Phone")
            End With
            'cboMsgMemory.SelectedIndex = 0

            '-------------------------------------------------
            'Initialize incoming message concatenate setting
            '-------------------------------------------------
            If objSMS.Inbox.Concatenate Then
                chkInConcatenate.Checked = True
                objSMS.NewMessageConcatenate = True
            End If

            '---------------------------------------------------
            'Initialize new incoming message indication setting
            '---------------------------------------------------
            If objSMS.NewMessageIndication Then chkNewMsgIndication.Checked = True

            If objSMS.AutoDeleteNewMessage Then chkAutoDelete.Checked = True

            If chkNewMsgIndication.Checked Then
                chkRefreshInbox.Enabled = True
                chkAutoDelete.Enabled = True
            Else
                chkRefreshInbox.Enabled = False
                chkAutoDelete.Enabled = False
            End If

            If objSMS.DeliveryReport Then chkDeliveryReport.Checked = True

            '----------------------------------------
            'Initialize Long Message DropDown List
            '----------------------------------------
            With cboLongMsg
                .Items.Add("Truncate")
                .Items.Add("Simple Split")
                .Items.Add("Formatted Split")
                .Items.Add("Concatenate")
            End With
            cboLongMsg.SelectedIndex = CType(objSMS.LongMessage, Integer)

            '----------------------------------------
            'Initialize Encoding Type DropDown List
            '----------------------------------------
            With cboEncoding
                .Items.Add("Default Alphabet")
                .Items.Add("ANSI (8-Bit)")
                .Items.Add("Unicode (16-Bit)")
            End With
            cboEncoding.SelectedIndex = CType(objSMS.Encoding, Integer)

            lblNoteSMS.Text = "NOTE: For non-english language messages you must select encoding type as Unicode (16-Bit)." & vbCrLf & "Use a suitable keyboard/IME to type non-english messages."
            '------------------------------------
            'Initialize message validity setting
            '------------------------------------
            txtValidity.Text = "24"
            With cboValidity
                .Items.Add("Min")
                .Items.Add("Hour")
                .Items.Add("Day")
                .Items.Add("Week")
            End With
            cboValidity.SelectedIndex = 1

            With cboSMSQPriority
                .Items.Add("High")
                .Items.Add("Normal")
                .Items.Add("Low")
            End With
            cboSMSQPriority.SelectedIndex = 1

            chkSMSQueue.Checked = False
            cboSMSQPriority.Enabled = False
            lblSMSQPriority.Enabled = False

            '------------------------------------
            'Initialize WAP Push Settings
            '------------------------------------


            'lblAbout.Text = objSMS.About 
            lblAbout.Text = "mCore .NET SMS Library 1.2 (Version 1.2.17.0) " & vbCrLf & vbCrLf & "Copyright © IG Logix Softech Pvt Ltd " & vbCrLf & vbCrLf & vbCrLf & "[LICENSED PRO DISTRIBUTION]"

            lblQueueCount.Text = "Messages in queue: 0"
            lblQueueStatus.Text = ""

            objSMS.NewUSSDIndication = True
        Catch ex As Exception
            'MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub
    Dim portcbosel

    Dim portcbo
    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click

        portcbo = cboPort.Text
        portcbosel = cboPort.SelectedIndex
        '
        'Connect is optional.
        'The Connect method is called automatically inside
        'mCore object whenever any property is read
        'or a method is called, that requires connection
        'with GSM modem
        '

        Try
            If cboPort.SelectedIndex = 0 Then
                MsgBox("Select a serial port", MsgBoxStyle.Critical, strMyAppName)
                Exit Sub
            End If

            cmdConnect.Text = "Please Wait..."
            cmdConnect.Enabled = False
            cmdDisconnect.Enabled = False

            SetCommParameters()

            If objSMS.Connect() Then
                cmdConnect.Enabled = False
                cmdDisconnect.Enabled = True

                ' Retrieve SMSC setting from SIM card
                txtSMSC.Text = objSMS.SMSC

                Select Case objSMS.MessageMemory
                    Case mCore.MessageMemory.SM : cboMsgMemory.SelectedIndex = 0
                    Case mCore.MessageMemory.ME : cboMsgMemory.SelectedIndex = 1
                    Case mCore.MessageMemory.MT : cboMsgMemory.SelectedIndex = 2
                End Select

                chkCleanUp.CheckState = CheckState.Checked
                chkNewMsgIndication.CheckState = CheckState.Checked
                'chkRefreshInbox.CheckState = CheckState.Checked
                chkAutoDelete.CheckState = CheckState.Checked
                MsgBox("Connection successful", MsgBoxStyle.Information, strMyAppName)

            Else
                MsgBox("Connection error", MsgBoxStyle.Critical, strMyAppName)

                cmdConnect.Enabled = True
                cmdDisconnect.Enabled = False
            End If

            'THE FOLLOWING GIVES SAME RESULT AS ABOVE
            'Note that connect method is not called explicitly in the following lines

            'txtSMSC.Text = objSMS.SMSC
            'MsgBox("Connection successfull", MsgBoxStyle.Information, gstrMyAppName)

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

        Try
            cmdConnect.Text = "Connect"
            If objSMS.IsConnected Then
                cmdConnect.Enabled = False
                cmdDisconnect.Enabled = True
            Else
                cmdConnect.Enabled = True
                cmdDisconnect.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisconnect.Click
        'It is not mandatory to call Disconnect method.
        'Closing mCore object will automatically call Disconnect

        cmdDisconnect.Text = "Please Wait..."
        cmdDisconnect.Enabled = False
        cmdConnect.Enabled = False

        Try
            objSMS.Disconnect()
            cmdConnect.Enabled = True
            cmdDisconnect.Enabled = False

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

        cmdDisconnect.Text = "Disconnect"

    End Sub

    Private Sub cmdRefreshSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshSettings.Click

        Try
            If cboPort.SelectedIndex = 0 Then
                MsgBox("Select a serial port", MsgBoxStyle.Critical, strMyAppName)
                Exit Sub
            End If

            cmdRefreshSettings.Text = "Please Wait..."
            cmdRefreshSettings.Enabled = False
            cmdApplySettings.Enabled = False

            'Retrieve SendRetry, SendDelay and Timeout
            'PIN is not retrieved (it is a write only property)
            'However to retrieve SMSC value, the PIN maybe required,
            'if the SIM is still waiting for PIN

            objSMS.PIN = txtPIN.Text.Trim
            chkDisableCheckPIN.Checked = objSMS.DisableCheckPIN
            txtSendRetry.Text = objSMS.SendRetry.ToString
            txtSendDelay.Text = (objSMS.SendDelay / 1000).ToString
            txtTimeout.Text = (objSMS.Timeout / 1000).ToString
            System.Windows.Forms.Application.DoEvents()

            SetCommParameters()

            'Retrieve SMSC information
            txtSMSC.Text = objSMS.SMSC

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

        cmdRefreshSettings.Text = "Refresh"
        cmdRefreshSettings.Enabled = True
        cmdApplySettings.Enabled = True

    End Sub

    Private Sub cmdApplySettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplySettings.Click

        Try
            If cboPort.SelectedIndex = 0 Then
                MsgBox("Select a serial port", MsgBoxStyle.Critical, strMyAppName)
                Exit Sub
            End If

            cmdApplySettings.Text = "Please Wait..."
            cmdApplySettings.Enabled = False
            cmdRefreshSettings.Enabled = False

            'Set PIN
            objSMS.PIN = txtPIN.Text.Trim

            'Set SendDelay (min delay between sending two messages) in milliseconds
            objSMS.SendDelay = CInt(CDbl(txtSendDelay.Text) * 1000)

            'Send number of retries if error is encountered when sending message
            objSMS.SendRetry = CInt(txtSendRetry.Text)

            'Set modem timeout (in milliseconds)
            objSMS.Timeout = CLng(CDbl(txtTimeout.Text) * 1000)

            SetCommParameters()

            'Set SMSC number
            objSMS.SMSC = txtSMSC.Text

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

        cmdApplySettings.Text = "Apply"
        cmdApplySettings.Enabled = True
        cmdRefreshSettings.Enabled = True

    End Sub

    Private Sub chkInConcatenate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInConcatenate.CheckedChanged
        objSMS.Inbox.Concatenate = chkInConcatenate.Checked
    End Sub

    Private Sub chkNewMsgIndication_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNewMsgIndication.CheckedChanged

        Try
            chkNewMsgIndication.Enabled = False

            SetCommParameters()

            objSMS.NewMessageIndication = chkNewMsgIndication.Checked

            If chkInConcatenate.Checked Then
                objSMS.NewMessageConcatenate = True
            Else
                objSMS.NewMessageConcatenate = False
            End If

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            chkNewMsgIndication.Checked = objSMS.NewMessageIndication
            chkInConcatenate.Checked = objSMS.NewMessageConcatenate
            Exit Try

        Catch ex As Exception
            Exit Try

        End Try

        chkNewMsgIndication.Enabled = True

        If chkNewMsgIndication.Checked Then
            chkRefreshInbox.Enabled = True
            chkAutoDelete.Enabled = True
        Else
            chkRefreshInbox.Enabled = False
            chkAutoDelete.Enabled = False
        End If

    End Sub

    Private Sub chkAutoDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoDelete.CheckedChanged

        Try
            objSMS.AutoDeleteNewMessage = chkAutoDelete.Checked

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            chkAutoDelete.Checked = objSMS.AutoDeleteNewMessage
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            chkAutoDelete.Checked = objSMS.AutoDeleteNewMessage
            Exit Try

        End Try

    End Sub

    Private Sub cboMsgMemory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMsgMemory.SelectedIndexChanged

        If cboPort.SelectedIndex = 0 Then
            tabMessaging.SelectedIndex = 0
            Exit Sub
        End If

        Try
            cboMsgMemory.Enabled = False

            'Define message memory type
            'message memory type will define the memory from where
            'messages will be read/deleted

            lblMsgCount.Text = "Setting message memory... Please wait..."
            System.Windows.Forms.Application.DoEvents()

            SetCommParameters()

            Select Case cboMsgMemory.SelectedIndex
                Case 0 : objSMS.MessageMemory = mCore.MessageMemory.SM
                Case 1 : objSMS.MessageMemory = mCore.MessageMemory.ME
                Case 2 : objSMS.MessageMemory = mCore.MessageMemory.MT
            End Select

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

        lblMsgCount.Text = vbNullString
        cboMsgMemory.Enabled = True

    End Sub

    Private Sub cmdInboxRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInboxRefresh.Click
        RefreshInbox()
    End Sub

    Private Sub lstInbox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstInbox.DoubleClick
        Dim i As Integer, objInbox As mCore.Inbox = objSMS.Inbox
        Dim Msg As mCore.Message

        Try
            'Read properties of selected message index from Inbox
            For i = 1 To lstInbox.Items.Count
                Msg = objInbox.Message(i)
                If lstInbox.Items.Item(i - 1).Selected Then
                    MsgBox(Msg.TimeStampRFC & vbCrLf & vbCrLf & Msg.Text, , "From: " & Msg.Phone)
                    Exit For
                End If
            Next

            If lstInbox.Items.Item(i - 1).Checked Then
                lstInbox.Items.Item(i - 1).Checked = False
            End If

        Catch ex As mCore.SMSReadException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

    End Sub

    Private Sub cmdMsgDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMsgDelete.Click
        Dim i As Integer

        Try
            cmdMsgDelete.Enabled = False

            'Delete selected message(s)
            If MsgBox("Delete selected message(s)?", MsgBoxStyle.YesNo, strMyAppName) = MsgBoxResult.Yes Then
                lblMsgCount.Text = "Deleting selected messages..."
                For i = lstInbox.Items.Count To 1 Step -1
                    If lstInbox.Items.Item(i - 1).Checked Then
                        objSMS.Inbox.Message(i).Delete()
                    End If
                Next
                lstInbox.Items.Clear()
                FillInboxList()
            End If

            lblMsgCount.Text = "Total Messages: " & objSMS.Inbox.Count
            If objSMS.Inbox.Count > 0 Then lblMsgCount.Text = lblMsgCount.Text & vbCrLf & "(double click on a message to view)"

        Catch ex As mCore.SMSDeleteException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            Exit Try

        End Try

        cmdMsgDelete.Enabled = True

    End Sub

    Private Sub RefreshInbox()
        Try
            Dim objInbox As mCore.Inbox = objSMS.Inbox()

            SetCommParameters()

            lblMsgCount.Text = "Reading messages... Please wait..."
            System.Windows.Forms.Application.DoEvents()

            Try
                cmdInboxRefresh.Enabled = False
                cmdMsgDelete.Enabled = False
                cboMsgMemory.Enabled = False
                chkInConcatenate.Enabled = False

                'Retrieve all messages from inbox
                'Also try:
                'objInbox.Refresh(mCore.Inbox.EnumMessageType.ReceivedUnreadMessages)
                'objInbox.Refresh(mCore.Inbox.EnumMessageType.ReceivedReadMessages)

                If chkCleanUp.Checked Then
                    objInbox.Refresh(mCore.MessageType.ReceivedAllMessages, True)
                Else
                    objInbox.Refresh()
                End If

                lstInbox.Items.Clear()
                FillInboxList()

            Catch ex As mCore.SMSReadException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            End Try

            lblMsgCount.Text = "Total Messages: " & objSMS.Inbox.Count
            If objSMS.Inbox.Count > 0 Then
                lblMsgCount.Text = lblMsgCount.Text & vbCrLf & "(double click on a message to view)"
            End If

            cmdMsgDelete.Enabled = True
            cmdInboxRefresh.Enabled = True
            cboMsgMemory.Enabled = True
            chkInConcatenate.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub FillInboxList()
        Try
            Dim i As Integer
            Dim Msg As mCore.Message, objInbox As mCore.Inbox = objSMS.Inbox

            Try
                'Read properties of each message read from modem
                'and fill the listview collumns
                i = 0
                For Each Msg In objInbox
                    With lstInbox
                        .Items.Add(Msg.Phone)
                        .Items.Item(i).SubItems.Add(Msg.Text)
                        .Items.Item(i).SubItems.Add(Msg.TimeStamp.ToString)
                        i += 1
                    End With
                Next

                'Folowing code will also generate same result as above

                'For i = 1 To objInbox.Count
                '    With lstInbox
                '        .Items.Add(objInbox.Message(i).Phone)
                '        .Items.Item(i - 1).SubItems.Add(objInbox.Message(i).Text)
                '        .Items.Item(i - 1).SubItems.Add(objInbox.Message(i).TimeStamp.ToString)
                '    End With
                'Next

            Catch ex As mCore.SMSReadException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            End Try
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try

    End Sub


    Private Sub objSMS_NewDeliveryReport(ByVal sender As Object, ByVal e As mCore.NewDeliveryReportEventArgs) Handles objSMS.NewDeliveryReport
        Try
            'New Delivery Report Event

            'Display delivery report
            If e.Status Then
                MsgBox("MESSAGE DELIVERED" & vbCrLf & vbCrLf & "TO: " & e.Phone & vbCrLf & vbCrLf & "SENT DATE/TIME: " & e.SentTimeStamp.ToString & vbCrLf & vbCrLf & "DELIVERY DATE/TIME: " & e.DeliveryTimeStamp & vbCrLf & vbCrLf & "[Message Ref.: " & e.MessageReference.ToString & "]", MsgBoxStyle.Information, "DELIVERY REPORT...")
            Else
                MsgBox("MESSAGE DELIVERY FAILED" & vbCrLf & vbCrLf & "TO: " & e.Phone & vbCrLf & vbCrLf & "SENT DATE/TIME: " & e.SentTimeStamp.ToString & vbCrLf & vbCrLf & "REPORT DATE/TIME: " & e.DeliveryTimeStamp & vbCrLf & vbCrLf & "[Message Ref.: " & e.MessageReference.ToString & "]", MsgBoxStyle.Critical, "DELIVERY REPORT...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub objSMS_NewIncomingCall(ByVal sender As Object, ByVal e As mCore.NewIncomingCallEventArgs) Handles objSMS.NewIncomingCall
        Try
            'New Incoming Call Event

            'Display the incoming call information
            MsgBox("Incoming call from: " & e.CallerID, MsgBoxStyle.Information, "INCOMING CALL...")
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub chkDeliveryReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDeliveryReport.CheckedChanged

        Try
            chkDeliveryReport.Enabled = False

            SetCommParameters()

            'Set delivery report for outgoing SMS
            objSMS.DeliveryReport = chkDeliveryReport.Checked

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            chkDeliveryReport.Checked = objSMS.DeliveryReport

        End Try

        chkDeliveryReport.Enabled = True

    End Sub

    Private Sub cboLongMsg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLongMsg.SelectedIndexChanged

        Try
            'Set long message treatment (LongMessage propety)
            objSMS.LongMessage = CType(cboLongMsg.SelectedIndex, mCore.LongMessage)

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboEncoding_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEncoding.SelectedIndexChanged

        Try
            'Set message encoding type
            objSMS.Encoding = CType(cboEncoding.SelectedIndex, mCore.Encoding)

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)

        End Try

    End Sub

    Private Sub cmdSendMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendMsg.Click
        Try
            Dim strSendResult As String, strKey As String

            If txtPhone.Text.Trim.Length = 0 Then
                MsgBox("Destination phone number is required!", vbExclamation, strMyAppName)
                Exit Sub
            End If

            cmdSendMsg.Text = "Sending SMS...Please Wait..."
            cmdSendMsg.Enabled = False

            System.Windows.Forms.Application.DoEvents()

            Try
                SetCommParameters()

                'Set message validity period
                objSMS.Validity = txtValidity.Text & cboValidity.Text.Substring(0, 1)

                If chkSMSQueue.Checked Then
                    'Send the text message to message queue
                    strKey = objSMS.SendSMSToQueue(txtPhone.Text, txtMessage.Text, CType(cboSMSQPriority.SelectedIndex + 1, mCore.QueuePriority), chkAlert.Checked)
                    lblQueueCount.Text = "Messages in queue: " & objSMS.Queue.Count.ToString
                    MsgBox("Message sent to queue!" & vbCrLf & vbCrLf & "[Message Queue Key: " & strKey & "]", MsgBoxStyle.Information, strMyAppName)
                Else
                    'Send the text message
                    strSendResult = objSMS.SendSMS(txtPhone.Text, txtMessage.Text, chkAlert.Checked)
                    MsgBox("Message sent!" & vbCrLf & vbCrLf & "[Message Ref.: " & strSendResult & "]", MsgBoxStyle.Information, strMyAppName)
                End If
            Catch ex As mCore.SMSSendException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            End Try

            cmdSendMsg.Text = "Send Message"
            cmdSendMsg.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub


    Private Sub cmdNetRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNetRefresh.Click
        Try
            Dim strNetwork As String = ""

            cmdNetRefresh.Text = "Please wait..."
            cmdNetRefresh.Enabled = False
            lblNetwork.Text = "Reading... Please wait..."
            prbSignal.Value = 0
            lblNetwork.Enabled = False
            prbSignal.Enabled = False

            System.Windows.Forms.Application.DoEvents()

            Try
                SetCommParameters()

                'Retrieve GSM network signal strength
                prbSignal.Value = objSMS.SignalStrength

                System.Windows.Forms.Application.DoEvents()

                'Read service provider network identification
                'Depending on the modem and the network, this process may take some time
                strNetwork = objSMS.Network

            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try

            Catch ex As Exception

            End Try

            If strNetwork = "" Then
                strNetwork = "Read timeout"
            End If

            lblNetwork.Text = strNetwork

            cmdNetRefresh.Text = "Refresh"
            cmdNetRefresh.Enabled = True
            lblNetwork.Enabled = True
            prbSignal.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub cmdMdmRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMdmRefresh.Click
        Try
            Dim BattLevel As Integer, OwnNumber As String = ""

            cmdMdmRefresh.Text = "Please wait..."
            cmdMdmRefresh.Enabled = False

            lblManufacturer.Enabled = False
            lblModel.Enabled = False
            lblRevision.Enabled = False
            lblIMEI.Enabled = False
            lblIMSI.Enabled = False
            lblBattery.Enabled = False
            lblOwnNum.Enabled = False

            lblManufacturer.Text = "Reading... Please wait..."
            lblModel.Text = "Reading... Please wait..."
            lblRevision.Text = "Reading... Please wait..."
            lblIMEI.Text = "Reading... Please wait..."
            lblIMSI.Text = "Reading... Please wait..."
            lblBattery.Text = "Reading... Please wait..."
            lblOwnNum.Text = "Reading... Please wait..."

            System.Windows.Forms.Application.DoEvents()

            SetCommParameters()

            Try
                'Retrieve modem Manufacturer information
                lblManufacturer.Text = objSMS.Manufacturer
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            lblManufacturer.Enabled = True
            System.Windows.Forms.Application.DoEvents()

            Try
                'Retrieve modem Model information
                lblModel.Text = objSMS.Model
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            lblModel.Enabled = True
            System.Windows.Forms.Application.DoEvents()

            Try
                'Retrieve firmware Revision information
                lblRevision.Text = objSMS.Revision
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            lblRevision.Enabled = True
            System.Windows.Forms.Application.DoEvents()

            Try
                'Retrieve modem IMEI information
                lblIMEI.Text = objSMS.IMEI
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            lblIMEI.Enabled = True
            System.Windows.Forms.Application.DoEvents()

            Try
                'Retrieve IMSI information
                lblIMSI.Text = objSMS.IMSI
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            lblIMSI.Enabled = True
            System.Windows.Forms.Application.DoEvents()

            Try
                'Retrieve battery charge level
                'If battery charge level reading is not supported,
                'the property will return -1
                BattLevel = objSMS.BatteryLevel
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            If BattLevel >= 0 Then
                lblBattery.Text = BattLevel.ToString & "%"
            Else
                lblBattery.Text = "Unknown"
            End If
            lblBattery.Enabled = True
            System.Windows.Forms.Application.DoEvents()

            Try
                'Retrieve MSISDN of the SIM card used
                'If MSISDN reading is not supported,
                'the property will return blank string
                OwnNumber = objSMS.OwnNumber
            Catch ex As mCore.GeneralException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
            End Try

            If OwnNumber.Length > 0 Then
                lblOwnNum.Text = OwnNumber
            Else
                lblOwnNum.Text = "Unknown"
            End If
            lblOwnNum.Enabled = True

            cmdMdmRefresh.Text = "Refresh"
            cmdMdmRefresh.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Public Sub SetCommParameters()
        Try
            'Set communication parameters
            'check if port is already connected

            Try
                If Not objSMS.IsConnected And portcbosel > 0 Then
                    'objSMS.Port = cboPort.Text
                    objSMS.Port = portcbo
                    objSMS.BaudRate = CType(CInt(cboBaudRate.Text), mCore.BaudRate)
                    objSMS.DataBits = CType(CInt(cboDataBits.Text), mCore.DataBits)
                    objSMS.Parity = CType(cboParity.SelectedIndex, mCore.Parity)
                    objSMS.StopBits = CType(cboStopBits.SelectedIndex + 1, mCore.StopBits)
                    objSMS.FlowControl = CType(cboFlowControl.SelectedIndex, mCore.FlowControl)
                    objSMS.PIN = txtPIN.Text
                    objSMS.DisableCheckPIN = chkDisableCheckPIN.Checked
                End If

            Catch ex As mCore.GeneralException
                'MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                'Dim smap As New sampleSMSApp
                'smap.Show()
                'Me.Hide()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub lblEmail_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblEmail.LinkClicked
        Process.Start("mailto:" & lblEmail.Text)
    End Sub

    Private Sub lblWebsite_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblWebsite.LinkClicked
        Process.Start(lblWebsite.Text)
    End Sub



    Private Sub cmdViewLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Process.Start(objSMS.LogFolderPath & "mCoreLib.log")
        Catch ex As Exception
            MsgBox("Log file not found")
        End Try
    End Sub

    Private Sub cmdClearLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Clear log file
            'Try using objSMS.ClearLog(LinesToKeep)
            'LinesToKeep is a integer value
            objSMS.ClearLog()

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)

        End Try
    End Sub

    Private Sub txtCommand_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCommand.KeyUp
        Try
            Dim CommandString As String = "", TerminalLines As String(), strModemResponse As String = ""
            Dim blnUpdateResponse As Boolean = False

            SetCommParameters()

            'Send the typed command to the modem when Enter key is pressed
            If e.KeyCode = Keys.Enter Then
                lblTerminalStatus.Text = "Please wait..."
                TerminalLines = Split(txtCommand.Text.Replace(vbLf, vbNullString), vbCr)
                CommandString = TerminalLines(TerminalLines.GetUpperBound(0) - 1).Trim

                If CommandString = Nothing Then CommandString = ""

                If CommandString.Length > 0 Then

                    'Read modem response
                    Try
                        strModemResponse = objSMS.Command(CommandString)
                    Catch ex As mCore.GeneralException
                        MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                    End Try

                    If strModemResponse.Length > 0 Then
                        blnUpdateResponse = True
                    Else
                        strModemResponse = "NO RESPONSE FROM MODEM"
                        blnUpdateResponse = True
                    End If
                End If

                If blnUpdateResponse Then
                    txtCommand.Text = txtCommand.Text & strModemResponse & vbCrLf
                    strModemResponse = ""
                End If

                txtCommand.SelectionStart = txtCommand.Text.Length
                txtCommand.ScrollToCaret()

                lblTerminalStatus.Text = "Type a command and press Enter key"

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub chkIncomingCall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIncomingCall.CheckedChanged
        Try
            chkIncomingCall.Enabled = False
            Try
                objSMS.IncomingCallIndication = chkIncomingCall.Checked
            Catch ex As Exception
                Exit Try
            End Try
            chkIncomingCall.Checked = objSMS.IncomingCallIndication
            chkIncomingCall.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub chkQueue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkQueue.CheckedChanged
        Try
            chkQueue.Enabled = False
            Try
                objSMS.Queue.Enabled = chkQueue.Checked
            Catch ex As Exception
                Exit Try
            End Try
            chkQueue.Checked = objSMS.Queue.Enabled
            chkQueue.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub cmdBrowseVCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSendVCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objVCAL As mCore.vCalendar = objSMS.vCalendar
            Try
                MsgBox("vCalendar Sent!", MsgBoxStyle.Information, strMyAppName)
            Catch ex As mCore.vCalendarException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try
            Catch ex As Exception
                Exit Try
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub cmdBrowseVCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSendVCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objVCARD As mCore.vCard = objSMS.vCard
            Try

                MsgBox("vCard Sent!", MsgBoxStyle.Information, strMyAppName)
            Catch ex As mCore.vCardException
                MsgBox(ex.Message, MsgBoxStyle.Critical, strMyAppName)
                Exit Try
            Catch ex As Exception
                Exit Try
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub chkSMSQueue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSMSQueue.CheckedChanged
        Try
            If chkSMSQueue.Checked Then
                cboSMSQPriority.Enabled = True
                lblSMSQPriority.Enabled = True
            Else
                cboSMSQPriority.Enabled = False
                lblSMSQPriority.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub objSMS_QueueSMSSent(ByVal sender As Object, ByVal e As mCore.QueueSMSSentEventArgs) Handles objSMS.QueueSMSSent
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            lblQueueStatus.Text = ""
            lblQueueCount.Text = "Messages in queue: " & objSMS.Queue.Count.ToString
            Control.CheckForIllegalCrossThreadCalls = True
            Windows.Forms.Application.DoEvents()
            If e.ErrorCode > 0 Then
                MsgBox("Message sending from queue failed to " & e.DestinationNumber & vbCrLf & "[Queue Message Key: " & e.QueueMessageKey & "]" & vbCrLf & "ERROR " & e.ErrorCode.ToString & ": " & e.ErrorDescription, MsgBoxStyle.Critical, "Message Sending FAILED")
            Else
                MsgBox("Message from queue sent to: " & e.DestinationNumber & vbCrLf & "[Queue Message Key: " & e.QueueMessageKey & "]", MsgBoxStyle.Information, "Message SENT")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub objSMS_QueueSMSSending(ByVal sender As Object, ByVal e As mCore.QueueSMSSendingEventArgs) Handles objSMS.QueueSMSSending
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            lblQueueStatus.Text = "Sending to:" & e.DestinationNumber & vbCrLf & "[Key:" & e.QueueMessageKey & "]"
            Control.CheckForIllegalCrossThreadCalls = True
            Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub cmdClearQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearQueue.Click
        Try
            objSMS.Queue.Clear()
            Control.CheckForIllegalCrossThreadCalls = False
            lblQueueCount.Text = "Messages in queue: " & objSMS.Queue.Count.ToString
            Control.CheckForIllegalCrossThreadCalls = True
            Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub chkDisableCheckPIN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisableCheckPIN.CheckedChanged
        objSMS.DisableCheckPIN = chkDisableCheckPIN.Checked
    End Sub
    Private Sub objSMS_NewUSSDReceived(ByVal sender As Object, ByVal e As mCore.NewUSSDReceivedEventArgs) Handles objSMS.NewUSSDReceived
        Try
            MsgBox("MESSAGE:" & vbCrLf & e.Message.Replace(vbLf, vbCrLf).Replace(vbCr & vbCr, vbCr) & vbCrLf & vbCrLf & "STATUS: " & e.Status.ToString, MsgBoxStyle.Information, "NEW USSD RECEIVED...")
            Control.CheckForIllegalCrossThreadCalls = False
            Control.CheckForIllegalCrossThreadCalls = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub



    Private Sub cmdBitmapFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Label18.Text = "Start Receiving"
            Timer1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub


    Dim agrew As String
    Dim agrew1 As String
    Dim agrew2 As String
    Private Sub objSMS_NewMessageReceived(ByVal sender As Object, ByVal e As mCore.NewMessageReceivedEventArgs) Handles objSMS.NewMessageReceived
        Try
            'New Message Indication Event
            'Display the new message
            'MsgBox("FROM: " & e.Phone & vbCrLf & vbCrLf & "DATE/TIME: " & e.TimeStampRFC & vbCrLf & vbCrLf & "MESSAGE:" & vbCrLf & e.TextMessage, MsgBoxStyle.Information, "NEW MESSAGE RECEIVED...")
            agrew = e.Phone
            agrew1 = e.TimeStampRFC
            agrew2 = e.TextMessage
            'Refresh Inbox
            'Disable illegal cross thread calls to form controls
            '(because NewMessageReceived event is on a secondary thread)
            'Please note this is not the best way if other threads may simultaneously
            'access the form controls in your application

            Control.CheckForIllegalCrossThreadCalls = False

            If chkRefreshInbox.Checked Then
                RefreshInbox()
            End If

            Control.CheckForIllegalCrossThreadCalls = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Dim time As Integer = 0
    Dim no As Integer = 0
   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try

            time = time + 1
            If time = 1 Then
                If agrew = Nothing And agrew1 = Nothing And agrew2 = Nothing Then
                    time = 0
                    'Label18.Text = "no text message receive"
                Else

                    no = no + 1
                    Label18.Text = no & " text message receive"

                    'to query existing number
                    'get the value of category id

                    cnn.Open()
                    Dim daa As New OleDb.OleDbDataAdapter("SELECT cellphone_no FROM receiver_sms WHERE cellphone_no= '" & agrew & "' ", cnn)
                    Dim dtt As New DataTable
                    'fill data to datatable
                    daa.Fill(dtt)
                    For i = 0 To dtt.Rows.Count - 1
                        'dtt.Rows(i)
                        lblCellno.Text = dtt.Rows(i)("cellphone_no")
                    Next
                    cnn.Close()
                    'end of query

                    'validate recorded contact number
                    If lblCellno.Text = agrew Then
                        'send Text that he/she has already sent a vote entry
                        'Dim strSendResult As String
                        'strSendResult = objSMS.SendSMS(agrew, "You have already sent your entry.", chkAlert.Checked)
                        'MsgBox("Message sent!" & vbCrLf & vbCrLf & "[Message Ref.: " & strSendResult & "]", MsgBoxStyle.Information, strMyAppName)
                    Else
                        'search for valid keyword

                        cnn.Open()
                        Dim daa1 As New OleDb.OleDbDataAdapter("SELECT keyword,score FROM keyword_sms WHERE keyword= '" & agrew2 & "' ", cnn)
                        Dim dtt1 As New DataTable
                        'fill data to datatable
                        daa1.Fill(dtt1)
                        For i1 = 0 To dtt1.Rows.Count - 1
                            'dtt1.Rows(i1)
                            lblMess.Text = dtt1.Rows(i1)("keyword")
                            lblScore.Text = dtt1.Rows(i1)("score")
                        Next
                        cnn.Close()

                        'to get valid keyword
                        If lblMess.Text = agrew2 Then
                            'add to database
                            'clear all receive data
                            'MsgBox("Valid keyword")
                            cnn.Open()
                            sqlcommand.Connection = cnn
                            sqlcommand.CommandText = "INSERT INTO  receiver_sms VALUES('" & agrew & "','" & agrew2 & "','" & agrew1 & "')"
                            sqlcommand.ExecuteNonQuery()
                            cnn.Close()

                            'update keyword sms
                            Dim scoor As Integer = 0
                            scoor = Val(lblScore.Text + 1)
                            cnn.Open()
                            sqlcommand.Connection = cnn
                            sqlcommand.CommandText = "UPDATE keyword_sms SET score='" & scoor & "' WHERE keyword='" & agrew2 & "'"
                            sqlcommand.ExecuteNonQuery()
                            cnn.Close()
                            scoor = 0


                        End If
                    End If
                    agrew = Nothing
                    agrew1 = Nothing
                    agrew2 = Nothing
                    time = 0
                End If
            End If


            'get valid keyword
            'add to database

            'ListBox1.Items.Add(agrew)
            'ListBox2.Items.Add(agrew1)
            'ListBox3.Items.Add(agrew2)

            'ListBox1.Items.Clear()
            'ListBox2.Items.Clear()
            'ListBox3.Items.Clear()
            'Label19.Text = time
            ''Else
            ''time = 0
            ''  If agrew = Nothing And agrew1 = Nothing And agrew2 = Nothing Then
            ''Else
            ''no = no + 1
            ''Label18.Text = no & " text message receive"
            'ListBox1.Items.Add(agrew)
            'ListBox2.Items.Add(agrew1)
            'ListBox3.Items.Add(agrew2)
            ''agrew = Nothing
            ''agrew1 = Nothing
            ''agrew2 = Nothing
            'ListBox1.Items.Clear()
            'ListBox2.Items.Clear()
            'ListBox3.Items.Clear()
            'End If
            'Label19.Text = time
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub


    Private Sub btnRePortx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRePortx.Click
        Try
            cboPort.Items.Clear()
            Dim myPort As Array
            myPort = IO.Ports.SerialPort.GetPortNames()
            For i = 0 To UBound(myPort)
                cboPort.Items.Add(myPort(i))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label18.Text = "Stop Receiving"
        Timer1.Stop()
    End Sub

    Private Sub btnAddCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCateg.Click
        Try
            lsKeywordko.Items.Clear()
            'to select all keyword_sms, add to listbox

            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("SELECT keyword FROM keyword_sms", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'dtt.Rows(i)
                lsKeywordko.Items.Add(dtt.Rows(i)("keyword"))
            Next
            cnn.Close()

            'get listbox count
            'for loop
            For countKo As Integer = 0 To lsKeywordko.Items.Count - 1

                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("SELECT category_name,category_id FROM category where category_name='SMS Poll'", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                For i1 = 0 To dtt1.Rows.Count - 1
                    'dtt1.Rows(i1)
                    lblSmsPollExist.Text = dtt1.Rows(i1)("category_name")
                    lblCatid.Text = dtt1.Rows(i1)("category_id")
                Next
                cnn.Close()
            Next

            'validate existing SMS Poll
            If lblSmsPollExist.Text = "SMS Poll" Then
                'existing sms poll
                'insert data to categoryReport

                'note:
                'task:

                'clear lsScore data
                lsScore.Items.Clear()

                'add keyword sms score to listbox

                cnn.Open()
                Dim daa2 As New OleDb.OleDbDataAdapter("SELECT score FROM keyword_sms", cnn)
                Dim dtt2 As New DataTable
                'fill data to datatable
                daa2.Fill(dtt2)
                For i2 = 0 To dtt2.Rows.Count - 1
                    'dtt2.Rows(i2)
                    lsScore.Items.Add(dtt2.Rows(i2)("score"))
                Next
                cnn.Close()

                'get the highest array value
                Dim a0 As Integer
                Dim a1 As Integer
                a0 = Convert.ToInt64(lsScore.Items.Item(0))

                For ix As Integer = 0 To lsScore.Items.Count - 1
                    a1 = Convert.ToInt64(lsScore.Items.Item(ix))


                    If a0 < a1 Then
                        a0 = a1
                    End If

                Next
                lblHighestval.Text = a0

                lsCandidatePay.Items.Clear()
                lsCandino.Items.Clear()

                'add candidate Data

                cnn.Open()
                Dim daa3 As New OleDb.OleDbDataAdapter("SELECT name,candidateno FROM candidate", cnn)
                Dim dtt3 As New DataTable
                'fill data to datatable
                daa3.Fill(dtt3)
                For i3 = 0 To dtt3.Rows.Count - 1
                    'dtt3.Rows(i3)
                    lsCandidatePay.Items.Add(dtt3.Rows(i3)("name"))
                    lsCandino.Items.Add(dtt3.Rows(i3)("candidateno"))
                Next
                cnn.Close()
                'for loop
                For lsCand As Integer = 0 To lsCandidatePay.Items.Count() - 1
                    'query candidate and keyword_sms

                    cnn.Open()
                    Dim daa4 As New OleDb.OleDbDataAdapter("SELECT candidate.candidateno,candidate.name,keyword_sms.score FROM candidate LEFT JOIN keyword_sms ON candidate.candidateno=keyword_sms.candidate_no WHERE candidate.candidateno='" & lsCandino.Items.Item(lsCand) & "'", cnn)
                    Dim dtt4 As New DataTable
                    'fill data to datatable
                    daa4.Fill(dtt4)
                    For i4 = 0 To dtt4.Rows.Count - 1
                        'dtt4.Rows(i4)
                        lblCandidatoMet.Text = dtt4.Rows(i4)("name")
                        lblScoremet.Text = dtt4.Rows(i4)("score")
                        lblCandidatono.Text = dtt4.Rows(i4)("candidateno")
                    Next
                    cnn.Close()



                    'to compute the percentage
                    Dim percentScore As Double
                    Dim answer As Double
                    answer = Val(lblScoremet.Text / lblHighestval.Text * 1)
                    percentScore = Val(answer * 100)
                    'Label21.Text = percentScore

                    'query existing data in the caTegoryReport
                   
                    cnn.Open()
                    Dim daa5 As New OleDb.OleDbDataAdapter("SELECT category_id, candidate_name FROM judgescoreboard where candidate_name='" & lblCandidatoMet.Text & "' and category_id='" & lblCatid.Text & "'", cnn)
                    Dim dtt5 As New DataTable
                    'fill data to datatable
                    daa5.Fill(dtt5)
                    For i5 = 0 To dtt5.Rows.Count - 1
                        'dtt5.Rows(i5)
                        lblExiscandidata.Text = dtt5.Rows(i5)("candidate_name")
                        lblExisCatid.Text = dtt5.Rows(i5)("category_id")
                    Next
                    cnn.Close()


                    If lblExiscandidata.Text = lsCandidatePay.Items.Item(lsCand) And lblExisCatid.Text = lblCatid.Text Then
                        'if exist update
                        'Label20.Text = lblCandidatoMet.Text
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE judgescoreboard SET score='" & percentScore & "' WHERE category_id='" & lblCatid.Text & "' And candidate_name='" & lblCandidatoMet.Text & "'"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        MsgBox("existing")
                    Else
                        'if not exist insert
                        'Label20.Text = lblCandidatoMet.Text
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "INSERT INTO  judgescoreboard VALUES('" & lblCatid.Text & "','" & lblCandidatono.Text & "','" & lblCandidatoMet.Text & "','SMSPOLLX','" & percentScore & "')"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        MsgBox("not existing")
                    End If
                Next

                'formula
                '# of sms votes/hisghest votes= answer * 100 = percentage score
                'compute percentage each candidate
                'search existing data on the categoryReport
                'insert to database categoryReport



                MsgBox("Generating report is successful", vbInformation, "Success")
            Else
                'existing sms poll
                'no need to add data to categorReport
                MsgBox("Generating Report is not allowed. No SMS-Poll in the category ", vbExclamation, "Retry")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim a0 As Integer
            Dim a1 As Integer
            a0 = Convert.ToInt64(ListBox4.Items.Item(0))

            For ix As Integer = 0 To ListBox4.Items.Count - 1
                a1 = Convert.ToInt64(ListBox4.Items.Item(ix))


                If a0 < a1 Then
                    a0 = a1
                End If

            Next
            Label20.Text = a0
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btnfresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfresh.Click
        Try
            'add category to the combobox
            txCandidato.Items.Clear()

            cnn.Open()
            Dim prodo As String
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM candidate", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'dtt.Rows(i)
                prodo = dtt.Rows(i)("name")
                txCandidato.Items.Add(prodo)
            Next
            cnn.Close()


            btnfresh.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btnKeyword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyword.Click
        Try
            'validate fields
            If txCandidato.Text = Nothing Or txKeyword.Text = Nothing Then
                MsgBox("PLEASE SELECT CANDIDATE(S) AND ENTER YOUR SMS KEYWORD!", vbExclamation, "ERROR")
            Else
                If MsgBox("ARE YOU SURE YOU WANT TO INSERT " & txKeyword.Text & "", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    'GET THE VALUE OF KEYWORD WITH SPECIFIC CANDIDATE ID
                    Dim catidxx As String
                    Dim catidxx1 As String

                    cnn.Open()
                    Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM keyword_sms WHERE candidate_no='" & txcatkey.Text & "'", cnn)
                    Dim dtt As New DataTable
                    'fill data to datatable
                    daa.Fill(dtt)
                    For i = 0 To dtt.Rows.Count - 1
                        'dtt.Rows(i)
                        catidxx = dtt.Rows(i)("candidate_no").ToString()
                        If txcatkey.Text = catidxx Then
                            txnana.Text = dtt.Rows(i)("candidate_no")
                        End If
                    Next
                    cnn.Close()


                    'compare if candidate_no is existing in the database
                    If txcatkey.Text = txnana.Text Then
                        MsgBox("The candidate is already on the database!", vbExclamation, "Retry")
                    Else
                        'COMPARE IF THE KEYWORD OF THE CANDIDATE IS ALREADY EXISTING
                        'get the keyword data on the database

                        cnn.Open()
                        Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM keyword_sms WHERE keyword='" & txKeyword.Text & "'", cnn)
                        Dim dtt1 As New DataTable
                        'fill data to datatable
                        daa1.Fill(dtt1)
                        For i1 = 0 To dtt1.Rows.Count - 1
                            'dtt1.Rows(i1)
                            catidxx1 = dtt1.Rows(i1)("keyword")
                            If txKeyword.Text = catidxx1 Then
                                txkeyt.Text = dtt1.Rows(i1)("keyword")
                            End If
                        Next
                        cnn.Close()



                        If txkeyt.Text = txKeyword.Text Then
                            MsgBox("The keyword is already on the database/currently used by the previous user!", vbExclamation, "Retry")
                        Else
                            'insert data to the database
                            cnn.Open()
                            sqlcommand.Connection = cnn
                            sqlcommand.CommandText = "INSERT INTO keyword_sms VALUES('" & txcatkey.Text & "','" & txKeyword.Text & "',0)"
                            sqlcommand.ExecuteNonQuery()
                            cnn.Close()

                            cnn.Open()
                            Dim daa2 As New OleDb.OleDbDataAdapter("Select candidate_no,keyword from keyword_sms", cnn)
                            Dim dtt2 As New DataTable
                            'fill data to datatable
                            daa2.Fill(dtt2)
                            DataGridView2.DataSource = dtt2
                            cnn.Close()

                            MsgBox("KEYWORDS SUCCESSFULLY ADDED TO THE DATABASE", vbInformation, "Success")
                        End If
                    End If
                Else
                    MsgBox("PLEASE RETRY", vbExclamation, "RETRY")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btneditkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditkey.Click
        Try
            If MsgBox("Are you sure you want to edit the keyword of " & txCandidato.Text & " into " & txKeyword.Text & "", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "UPDATE keyword_sms SET keyword='" & txKeyword.Text & "' WHERE candidate_no='" & txcatkey.Text & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("Select candidate_no, keyword from keyword_sms", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                DataGridView2.DataSource = dtt
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub txCandidato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txCandidato.SelectedIndexChanged
        Try
            cnn.Open()
            Dim prodo As String
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM candidate", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'dtt.Rows(i)
                prodo = dtt.Rows(i)("name")
                If prodo = txCandidato.Text Then
                    txcatkey.Text = dtt.Rows(i)("candidateno")
                    Label27.Text = dtt.Rows(i)("candidateno")
                End If
            Next
            cnn.Close()
            Label24.Visible = True
            Label27.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim view As New viewSMSReport
        view.ShowDialog()
    End Sub

End Class
