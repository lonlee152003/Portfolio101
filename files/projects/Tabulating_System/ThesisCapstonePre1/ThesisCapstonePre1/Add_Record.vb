Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Security
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class Add_Record
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Public Function Encrypt1(ByVal plainText As String) As String
        Try
            Dim passPhrase As String = "passwordEn"
            Dim saltValue As String = "mySaltValue"
            Dim hashAlgorithm As String = "SHA1"

            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256

            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
            Dim symmetricKey As New RijndaelManaged()

            symmetricKey.Mode = CipherMode.CBC

            Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

            Dim memoryStream As New IO.MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
            cryptoStream.FlushFinalBlock()
            Dim cipherTextBytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            cryptoStream.Close()
            Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
            encryptedna.Text = cipherText
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Function

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Try
            If TextBox3.Text = Nothing Or TextBox2.Text = Nothing Or TextBox4.Text = Nothing Or txconfirmpassword.Text = Nothing Then
                'prompt empty textbox
                MsgBox("Textfield can't be empty!", vbExclamation, "Warning!")
            Else
                'textbox has a value
                If TextBox4.Text = txconfirmpassword.Text Then
                    'call function to encrypt data
                    Encrypt1(TextBox4.Text)
                    cnn.Close()
                    cnn.Open()
                    Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE username='" & TextBox2.Text & "'", cnn)
                    Dim dtt As New DataTable
                    Dim candiNo As String
                    'fill data to datatable
                    daa1.Fill(dtt)
                    For i = 0 To dtt.Rows.Count - 1

                        candiNo = dtt.Rows(i)("username")

                    Next
                    cnn.Close()

                    If candiNo = TextBox2.Text Then
                        MsgBox("Sorry your username is already used by other user.", vbExclamation, "Retry")
                    Else
                        cnn.Close()
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "INSERT INTO userAdmin([username],[password],[name],[userType],[loginStat]) VALUES('" & TextBox2.Text & "','" & encryptedna.Text & "','" & TextBox3.Text & "','" & cbousrtype.Text & "','inactive')"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()

                        MsgBox("Successfully added new account.", vbInformation, "Success")

                    End If
                Else
                    MsgBox("Password didn't match!", vbExclamation, "Verify password")
                End If
            End If
            '''''''''''''''''
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            txconfirmpassword.Text = ""
            chkPshow.Checked = False
            cbousrtype.Text = Nothing
        Catch ex As Exception
            'MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub cbousrtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbousrtype.SelectedIndexChanged

    End Sub

    Private Sub chkPshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPshow.CheckedChanged
        Try
            If chkPshow.Checked Then
                TextBox4.PasswordChar = Nothing
                txconfirmpassword.PasswordChar = Nothing
            Else
                TextBox4.PasswordChar = ChrW(9676)
                txconfirmpassword.PasswordChar = ChrW(9676)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Add_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class