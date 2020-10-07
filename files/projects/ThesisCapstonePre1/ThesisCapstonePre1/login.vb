Imports System.Data.SqlClient
Imports System.Data
Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Data.OleDb

Public Class login
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            '  Dim sqConUpdate As New SqlConnection("Data Source=.\SQLExpress;AttachDBFilename=|DataDirectory|\dbase\UserA.mdf;Integrated Security=True;User Instance=True")      

            If txusername.Text = Nothing Or txpassword.Text = Nothing Or txpassword1.Text = Nothing Then
                MsgBox("Please make sure your account is existing!", vbExclamation, "Try Again")
            Else
                'call function to encrypt
                Decrypt(txpassword1.Text)
                'start of verifying correct data
                If txusername.Text = txusername1.Text And txpassword.Text = decryptedna.Text And txuser.Text = "admin" Then
                    MsgBox("You are using an admin account!", vbInformation, "Administrator")

                    'query to update a user is active
                    cnn.Close()
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE userAdmin SET loginStat='active' WHERE username='" & txusername.Text & "' And password='" & txpassword1.Text & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()

                    'code to select specific event
                    Dim selPa As New selectEvent
                    selPa.Label2.Text = txusername1.Text
                    selPa.Show()
                    Me.Hide()

                ElseIf txusername.Text = txusername1.Text And txpassword.Text = decryptedna.Text And txuser.Text = "judge" Then
                    MsgBox("You are using user account!", vbInformation, "User")

                    'query to update a user is active     
                    cnn.Close()
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE userAdmin SET loginStat='active' WHERE username='" & txusername.Text & "' And password='" & txpassword1.Text & "'"        
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                    'task:
                    'code to validate active event
                    'use select
                    'use if else
                    'map everything                

                    cnn.Close()
                    cnn.Open()
                    Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM contestType WHERE status='Active'", cnn)
                    Dim dtt As New DataTable
                    Dim prodo2 As String
                    Dim prodo3 As String
                    'fill data to datatable
                    daa1.Fill(dtt)
                    For i = 0 To dtt.Rows.Count - 1

                        prodo2 = dtt.Rows(i)("status")
                        prodo3 = dtt.Rows(i)("gameCategory")

                    Next
                    cnn.Close()

                    If prodo2 = "Active" And prodo3 = "other" Then
                        MsgBox("Custom event", vbInformation, "Event Type")
                        Dim pag1 As New sampletabulate_others
                        pag1.Label1.Text = txusername1.Text
                        pag1.Show()
                        Me.Hide()
                    ElseIf prodo2 = "Active" And prodo3 = "pageant" Then
                        MsgBox("Pageant event", vbInformation, "Event Type")
                        Dim pag11 As New sampletabulate
                        pag11.Label1.Text = txusername1.Text
                        pag11.Show()
                        Me.Hide()
                    Else
                        MsgBox("Event is not set from the administrator, try again later", vbExclamation, "Retry Later")
                        cnn.Close()
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE userAdmin SET loginStat='inactive' WHERE username='" & txusername1.Text & "'"               
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()

                        Dim loin As New login
                        loin.Show()
                        Me.Hide()
                    End If

                Else
                    MsgBox("User is not existing!", vbExclamation, "Retry")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub txusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txusername.TextChanged
        Try
            ' to search data on database
            ''''''''''''''''''
            cnn.Close()
            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin where username='" & txusername.Text & "'", cnn)
            Dim dtt As New DataTable
            Dim usrname As String
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1

                usrname = dtt.Rows(i)("username")
                If txusername.Text = usrname Then
                    txusername1.Text = dtt.Rows(i)("username")
                    txpassword1.Text = dtt.Rows(i)("password")
                    txuser.Text = dtt.Rows(i)("userType")
                    txStat.Text = dtt.Rows(i)("loginStat")
                End If
            Next
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSPass.CheckedChanged
        If chkSPass.Checked Then
            txpassword.PasswordChar = Nothing
        Else
            txpassword.PasswordChar = ChrW(9676)
        End If
    End Sub

    'function to decrypt
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "passwordEn"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        ' Convert our ciphertext into a byte array.
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        ' First, we must create a password, from which the key will be 
        ' derived. This password will be generated from the specified 
        ' passphrase and salt value. The password will be created using
        ' the specified hash algorithm. Password creation can be done in
        ' several iterations.
        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        ' Use the password to generate pseudo-random bytes for the encryption
        ' key. Specify the size of the key in bytes (instead of bits).
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        ' Create uninitialized Rijndael encryption object.
        Dim symmetricKey As New RijndaelManaged()

        ' It is reasonable to set encryption mode to Cipher Block Chaining
        ' (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC

        ' Generate decryptor from the existing key bytes and initialization 
        ' vector. Key size will be defined based on the number of the key 
        ' bytes.
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        ' Define memory stream which will be used to hold encrypted data.
        Dim memoryStream As New IO.MemoryStream(cipherTextBytes)

        ' Define cryptographic stream (always use Read mode for encryption).
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        ' Since at this point we don't know what the size of decrypted data
        ' will be, allocate the buffer long enough to hold ciphertext;
        ' plaintext is never longer than ciphertext.
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

        ' Start decrypting.
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        ' Close both streams.
        memoryStream.Close()
        cryptoStream.Close()

        ' Convert decrypted data into a string. 
        ' Let us assume that the original plaintext string was UTF8-encoded.
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        ' Return decrypted string.   
        decryptedna.Text = plainText
        Return 0
    End Function
    'end of function

    Private Sub btnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class