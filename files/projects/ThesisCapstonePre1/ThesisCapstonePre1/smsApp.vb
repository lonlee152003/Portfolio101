Imports System.Threading
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class smsApp

    Dim rcvdata As String = ""
    'Dim SerialPort1 As New System.IO.Ports.SerialPort()

    Private Sub smsApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserADataSet1.receiver_sms' table. You can move, or remove it, as needed.
        Me.Receiver_smsTableAdapter.Fill(Me.UserADataSet1.receiver_sms)
        'TODO: This line of code loads data into the 'UserADataSet.keyword_sms' table. You can move, or remove it, as needed.
        Me.Keyword_smsTableAdapter.Fill(Me.UserADataSet.keyword_sms)
        TabPage2.Enabled = False
        'TabPage3.Enabled = False
        TabPage4.Enabled = True


    End Sub

    Private Sub xrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xrefresh.Click
        Try
            Dim myPort As Array
            myPort = IO.Ports.SerialPort.GetPortNames()
            For i = 0 To UBound(myPort)
                portName.Items.Add(myPort(i))
            Next

            portName.Text = portName.Items.Item(0)
            baudRate.Text = baudRate.Items.Item(0)
            dateBits.Text = dateBits.Items.Item(4)
            xrefresh.Visible = False
        Catch
            MsgBox("Please check your broadband if properly connected!", vbExclamation, "Retry to reconnect")
        End Try

        'Catch ex As Exception
        'MsgBox(ex.Message, vbOKOnly, "")
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If portName.Text = Nothing Or baudRate.Text = Nothing Or dateBits.Text = Nothing Then
            MsgBox("Please fill empty field", vbCritical, "ERROR!")
        Else
            Try
                SerialPort1.PortName = portName.Text
                SerialPort1.BaudRate = baudRate.Text
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.DataBits = dateBits.Text
                SerialPort1.Handshake = Handshake.None
                SerialPort1.DtrEnable = True
                SerialPort1.RtsEnable = True
                SerialPort1.NewLine = vbCrLf
                SerialPort1.Open()
                SerialPort1.Write("AT" & vbCrLf)
                Threading.Thread.Sleep(200)
                Dim te As String
                te = SerialPort1.ReadExisting()
                te = te & ""
                tes.Text = te
                If tes.Text = "" Then
                    statx.Visible = True
                    statx.Text = "No Messages data"
                    btnDc.Enabled = True
                    btnConnect.Enabled = False
                    TabPage1.Enabled = False
                    TabPage2.Enabled = False
                    TabPage3.Enabled = False
                    TabPage4.Enabled = False
                Else
                    btnDc.Enabled = True
                    TabPage1.Enabled = False
                    TabPage2.Enabled = True
                    TabPage3.Enabled = True
                    TabPage4.Enabled = True
                    statx.Visible = True
                    statx.Text = "You are now connected to " & portName.Text
                    Timer1.Enabled = True
                End If
            Catch
                MsgBox("Error using invalid port!", vbExclamation, "ERROR")
            End Try
        End If
    End Sub

    Private Sub btnDc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDc.Click
        statx.Text = "Disconnected from port " & portName.Text
        btnDc.Enabled = False
        btnConnect.Enabled = True
        TabPage1.Enabled = True
        TabPage2.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        SerialPort1.Close()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
        statx.Text = "Stop Receiving SMS"
    End Sub

    Dim a1 As Integer = 0
    Dim receiveCount As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim sqConAxx As New SqlClient.SqlConnection("Server=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True")
        Dim sqCmdAxx As New SqlClient.SqlCommand
        Dim catidcon As Integer
        Dim catidke As String
        Dim catidtxin
        'increment
        a1 = a1 + 1
        'if the time ticks it determines specific data on the conditional statement
        Try
            If a1 = 1 Then
                SerialPort1.WriteLine("AT+CNMI=1,2,0,0,0" & vbCrLf)
                txcontact1.Text = Nothing
                txmess1.Text = Nothing
                'indicates a loop
                LoopIndicator.Text = 1
                If rawSMS.Text = Nothing Then
                Else
                    ListBox1.Items.Add(rawSMS.Text)
                End If

                'trim na this
                'trim start
                Dim text As String = rawSMS.Text

                Dim a As String

                If rawSMS.Text = Nothing Then

                Else
                    Dim strWords() As String = text.Split(Chr(34))
                    Dim intCount As Integer

                    a = strWords.Length - 1
                    For intCount = 0 To a
                        ListBox2.Items.Add(strWords(intCount))
                    Next
                    'trim end
                    If ListBox2.Items.Count = 5 Then
                        'Try
                        txcontact.Text = strWords(1)
                        Dim tes2
                        tes2 = strWords(4)
                        txmess.Text = tes2.Substring(2, strWords(4).Length - 4)
                        'decode contact
                        Dim st As String = txcontact.Text
                        For x = 0 To st.Length - 1 Step 2
                            txcontact1.Text &= ChrW(CInt("&H" & st.Substring(x, 2)))
                            'Label8.Text &= ChrW(CInt("&H" & st.Substring(x, 2)))
                        Next

                        'decode msg
                        Dim st1 As String = txmess.Text
                        For x1 = 0 To st1.Length - 1 Step 2
                            txmess1.Text &= ChrW(CInt("&H" & st1.Substring(x1, 2)))
                            'Label9.Text &= ChrW(CInt("&H" & st1.Substring(x1, 2)))
                        Next

                        receiveCount = receiveCount + 1
                        txCount.Text = receiveCount & " Number of received message(s)"

                        'add data to database
                        'code here!!!
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        'search existing celphone number
                        'GET THE VALUE OF existing cellphone number
                        sqConAxx.Open()
                        sqCmdAxx.Connection = sqConAxx
                        sqCmdAxx.CommandText = "SELECT * FROM keyword_sms WHERE keyword='" & txmess1.Text & "'"
                        Dim lrdcon As SqlDataReader = sqCmdAxx.ExecuteReader()
                        If lrdcon.HasRows Then
                            While lrdcon.Read()
                                'Do something here
                                catidcon = lrdcon("score")
                            End While
                        End If
                        catidke = catidcon + 1
                        sqConAxx.Close()

                        sqConAxx.Open()
                        sqCmdAxx.Connection = sqConAxx
                        sqCmdAxx.CommandText = "SELECT * FROM receiver_sms WHERE cellphone_no='" & txcontact1.Text & "'"
                        Dim lrdcon1 As SqlDataReader = sqCmdAxx.ExecuteReader()
                        If lrdcon1.HasRows Then
                            While lrdcon1.Read()
                                'Do something here
                                catidtxin = lrdcon1("candidate_no")
                            End While
                        End If
                        sqConAxx.Close()
                        If catidtxin <> txcontact1.Text Then
                            sqConAxx.Open()
                            sqCmdAxx.Connection = sqConAxx
                            sqCmdAxx.CommandText = "INSERT INTO receiver_sms VALUES('" & txcontact1.Text & "','" & txmess1.Text & "')"
                            sqCmdAxx.ExecuteNonQuery()
                            sqConAxx.Close()

                            sqConAxx.Open()
                            sqCmdAxx.Connection = sqConAxx
                            sqCmdAxx.CommandText = "UPDATE keyword_sms SET score='" & catidke & "' WHERE keyword='" & txmess1.Text & "'"
                            sqCmdAxx.ExecuteNonQuery()
                            sqConAxx.Close()
                        End If
                        'end of query
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        'Catch

                        'txcontact1.Text = strWords(1)
                        'txmess1.Text = strWords(4)
                        'Dim aa As String
                        'aa = txmess1.Text
                        'txmess1.Text = aa.Substring(0, strWords(4).Length - 3)
                        'receiveCount = receiveCount + 1
                        'txCount.Text = receiveCount & " Number of received message(s) text mode"

                        'search existing celphone number
                        'search valid keyword
                        'add data to database
                        'End Try
                    End If

                End If

                rawSMS.Text = Nothing

                'major else
            Else
                SerialPort1.WriteLine("AT+CNMI=1,2,0,0,0" & vbCrLf)
                txcontact1.Text = Nothing
                txmess1.Text = Nothing
                LoopIndicator.Text = 0
                a1 = 0
                If rawSMS.Text = Nothing Then
                Else
                    ListBox1.Items.Add(rawSMS.Text)
                End If

                'trim na this
                'trim start
                Dim text As String = rawSMS.Text
                Dim a As String
                If rawSMS.Text = Nothing Then

                Else
                    Dim strWords() As String = text.Split(Chr(34))
                    Dim intCount As Integer
                    a = strWords.Length - 1
                    For intCount = 0 To a
                        ListBox2.Items.Add(strWords(intCount))
                    Next
                    'trim end
                    If ListBox2.Items.Count = 5 Then
                        'Try
                        txcontact.Text = strWords(1)
                        Dim tes2
                        tes2 = strWords(4)
                        txmess.Text = tes2.Substring(2, strWords(4).Length - 4)
                        'decode contact
                        Dim st As String = txcontact.Text
                        For x = 0 To st.Length - 1 Step 2
                            txcontact1.Text &= ChrW(CInt("&H" & st.Substring(x, 2)))
                            'Label8.Text &= ChrW(CInt("&H" & st.Substring(x, 2)))
                        Next

                        'decode message
                        Dim st1 As String = txmess.Text
                        For x1 = 0 To st1.Length - 1 Step 2
                            txmess1.Text &= ChrW(CInt("&H" & st1.Substring(x1, 2)))
                            'Label9.Text &= ChrW(CInt("&H" & st1.Substring(x1, 2)))
                        Next

                        receiveCount = receiveCount + 1
                        txCount.Text = receiveCount & " Number of received message(s)"
                        'search existing celphone number
                        'search valid keyword
                        'add data to database
                        'code here!!!
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        'search existing celphone number
                        'GET THE VALUE OF existing cellphone number
                        sqConAxx.Open()
                        sqCmdAxx.Connection = sqConAxx
                        sqCmdAxx.CommandText = "SELECT * FROM keyword_sms WHERE keyword='" & txmess1.Text & "'"
                        Dim lrdcon As SqlDataReader = sqCmdAxx.ExecuteReader()
                        If lrdcon.HasRows Then
                            While lrdcon.Read()
                                'Do something here
                                catidcon = lrdcon("score")
                            End While
                        End If
                        catidke = catidcon + 1
                        sqConAxx.Close()

                        sqConAxx.Open()
                        sqCmdAxx.Connection = sqConAxx
                        sqCmdAxx.CommandText = "SELECT * FROM receiver_sms WHERE cellphone_no='" & txcontact1.Text & "'"
                        Dim lrdcon1 As SqlDataReader = sqCmdAxx.ExecuteReader()
                        If lrdcon1.HasRows Then
                            While lrdcon1.Read()
                                'Do something here
                                catidtxin = lrdcon1("cellphone_no")
                            End While
                        End If
                        sqConAxx.Close()
                        If catidtxin <> txcontact1.Text Then
                            sqConAxx.Open()
                            sqCmdAxx.Connection = sqConAxx
                            sqCmdAxx.CommandText = "INSERT INTO receiver_sms VALUES('" & txcontact1.Text & "','" & txmess1.Text & "')"
                            sqCmdAxx.ExecuteNonQuery()
                            sqConAxx.Close()

                            sqConAxx.Open()
                            sqCmdAxx.Connection = sqConAxx
                            sqCmdAxx.CommandText = "UPDATE keyword_sms SET score='" & catidke & "' WHERE keyword='" & txmess1.Text & "'"
                            sqCmdAxx.ExecuteNonQuery()
                            sqConAxx.Close()
                        End If
                        'end of query
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        'Catch
                        'txcontact1.Text = strWords(1)
                        'txmess1.Text = strWords(4)
                        'Dim aa As String
                        'aa = txmess1.Text
                        'txmess1.Text = aa.Substring(0, strWords(4).Length - 3)
                        'receiveCount = receiveCount + 1
                        'txCount.Text = receiveCount & " Number of received message(s) text mode"

                        'search existing celphone number
                        'search valid keyword
                        'add data to database
                        'code here
                        'End Try
                    End If
                    'trim end
                    rawSMS.Text = Nothing

                    End If

                    'major end if
            End If
        Catch
            'MsgBox("Something error")
        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If statx.Text = "Stop Receiving SMS" Then
        Else
            rawSMS.BeginInvoke(New myDelegate(AddressOf updateTextBox), New Object() {})
        End If
    End Sub


    Public Delegate Sub myDelegate()
    Public Sub updateTextBox()
        '---append the received data into the TextBox control---
        With rawSMS
            .AppendText(SerialPort1.ReadExisting)
            .ScrollToCaret()
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SerialPort1.WriteLine("AT+CMGF = 1" & vbCrLf)
    End Sub

    Private Sub btnfresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfresh.Click
        'add category to the combobox
        txCandidato.Items.Clear()
        Dim sqCona As New SqlClient.SqlConnection("Server=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True")
        Dim sqCmda As New SqlClient.SqlCommand
        sqCona.Open()
        sqCmda.Connection = sqCona
        Dim prodo As String
        sqCmda.CommandText = "SELECT * FROM candidate"
        Dim lrd As SqlDataReader = sqCmda.ExecuteReader()
        If lrd.HasRows Then
            While lrd.Read()
                prodo = lrd.Item("name")
                txCandidato.Items.Add(prodo)
            End While
        End If
        sqCona.Close()
        btnfresh.Visible = False
    End Sub

    Private Sub btnKeyword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyword.Click
        'validate fields
        If txCandidato.Text = Nothing Or txKeyword.Text = Nothing Then
            MsgBox("PLEASE SELECT CANDIDATE(S) AND ENTER YOUR SMS KEYWORD!", vbExclamation, "ERROR")
        Else
            If MsgBox("ARE YOU SURE YOU WANT TO INSERT " & txKeyword.Text & "", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                'GET THE VALUE OF KEYWORD WITH SPECIFIC CANDIDATE ID
                Dim sqConAxx As New SqlClient.SqlConnection("Server=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True")
                Dim sqCmdAxx As New SqlClient.SqlCommand
                Dim catidxx As String
                Dim catidxx1 As String

                'get the value of category id
                sqConAxx.Open()
                sqCmdAxx.Connection = sqConAxx
                sqCmdAxx.CommandText = "SELECT * FROM keyword_sms WHERE candidate_no='" & txcatkey.Text & "'"
                Dim lrdxx As SqlDataReader = sqCmdAxx.ExecuteReader()
                If lrdxx.HasRows Then
                    While lrdxx.Read()
                        'Do something here
                        catidxx = lrdxx("candidate_no").ToString()
                        If txcatkey.Text = catidxx Then
                            txnana.Text = lrdxx.Item("candidate_no")
                        End If
                    End While
                End If
                sqConAxx.Close()
                'end of query

                'compare if candidate_no is existing in the database
                If txcatkey.Text = txnana.Text Then
                    MsgBox("The candidate is already on the database!", vbExclamation, "Retry")
                Else
                    'COMPARE IF THE KEYWORD OF THE CANDIDATE IS ALREADY EXISTING
                    'get the keyword data on the database
                    sqConAxx.Open()
                    sqCmdAxx.Connection = sqConAxx
                    sqCmdAxx.CommandText = "SELECT * FROM keyword_sms WHERE keyword='" & txKeyword.Text & "'"
                    Dim lrdxx1 As SqlDataReader = sqCmdAxx.ExecuteReader()
                    If lrdxx1.HasRows Then
                        While lrdxx1.Read()
                            'Do something here
                            catidxx1 = lrdxx1("keyword").ToString()
                            If txKeyword.Text = catidxx1 Then
                                txkeyt.Text = lrdxx1.Item("keyword")
                            End If
                        End While
                    End If
                    sqConAxx.Close()

                    If txkeyt.Text = txKeyword.Text Then
                        MsgBox("The keyword is already on the database/currently used by the previous user!", vbExclamation, "Retry")
                    Else
                        'insert data to the database
                        Dim sqCon As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Integrated Security=True;User Instance=True")
                        Dim sqCmd As New SqlClient.SqlCommand
                        sqCon.Open()
                        sqCmd.Connection = sqCon
                        sqCmd.CommandText = "INSERT INTO keyword_sms VALUES('" & txcatkey.Text & "','" & txKeyword.Text & "',0)"
                        sqCmd.ExecuteNonQuery()
                        sqCon.Close()
                        MsgBox("KEYWORDS SUCCESSFULLY ADDED TO THE DATABASE", vbInformation, "Success")
                    End If
                End If
            Else
                MsgBox("PLEASE RETRY", vbExclamation, "RETRY")
            End If
        End If
    End Sub

    Private Sub txCandidato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txCandidato.SelectedIndexChanged
        Dim sqCona As New SqlClient.SqlConnection("Server=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True")
        Dim sqCmda As New SqlClient.SqlCommand
        sqCona.Open()
        sqCmda.Connection = sqCona
        Dim prodo As String
        sqCmda.CommandText = "SELECT * FROM candidate"
        Dim lrd As SqlDataReader = sqCmda.ExecuteReader()
        If lrd.HasRows Then
            While lrd.Read()
                prodo = lrd.Item("name")
                If prodo = txCandidato.Text Then
                    txcatkey.Text = lrd.Item("candidateno")
                End If
            End While
        End If
        sqCona.Close()
    End Sub


    Private Sub txKeyword_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txKeyword.MouseClick
        txKeyword.Text = Nothing
    End Sub
     
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        statx.Text = "Start Receiving SMS"
    End Sub

    Private Sub btneditkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditkey.Click
        If MsgBox("Are you sure you want to edit the keyword of " & txCandidato.Text & " into " & txKeyword.Text & "", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Dim sqConAxx As New SqlClient.SqlConnection("Server=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True")
            Dim sqCmdAxx As New SqlClient.SqlCommand
            sqConAxx.Open()
            sqCmdAxx.Connection = sqConAxx
            sqCmdAxx.CommandText = "UPDATE keyword_sms SET keyword='" & txKeyword.Text & "' WHERE candidate_no='" & txcatkey.Text & "'"
            sqCmdAxx.ExecuteNonQuery()
            sqConAxx.Close()


            Dim str As String = "Data Source=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True"
            Dim con As New SqlConnection(str)
            con.Open()
            Dim com As String = "Select candidate_no, keyword from keyword_sms"
            Dim Adpt As New SqlDataAdapter(com, con)
            Dim ds As New DataSet()
            Adpt.Fill(ds, "keyword_sms")
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        End If
    End Sub

    Private Sub refREC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refREC.Click
        Dim str As String = "Data Source=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True"
        Dim con As New SqlConnection(str)
        con.Open()
        Dim com As String = "Select * from receiver_sms"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "receiver_sms")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub txKeyword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txKeyword.TextChanged

    End Sub
End Class


'cp number ni crushmate 09300729645