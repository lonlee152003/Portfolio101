Imports System.Data
Imports System.Security
Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Data.SqlClient

Public Class createuser

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Refresh()
        'verify textbox if empty
        If txname.Text = Nothing Or txusername.Text = Nothing Or txpassword.Text = Nothing Or txconfirmpassword.Text = Nothing Then
            'prompt empty textbox
            MsgBox("Textfield can't be empty!", vbExclamation, "Warning!")
        Else
            'textbox has a value
            If txpassword.Text = txconfirmpassword.Text Then
                'call function to encrypt data
                Encrypt(txpassword.Text)



                Dim sqCon As New SqlClient.SqlConnection("Data Source=.\SQLExpress;AttachDBFilename=|DataDirectory|\dbase\UserA.mdf;Integrated Security=True;User Instance=True")
                Dim sqCmd As New SqlClient.SqlCommand
                'get the value of candidate id
                sqCon.Open()
                sqCmd.Connection = sqCon
                sqCmd.CommandText = "SELECT * FROM userAdmin WHERE username='" & txusername.Text & "'"
                Dim lrdxx As SqlDataReader = sqCmd.ExecuteReader()
                Dim candiNo As String
                If lrdxx.HasRows Then
                    While lrdxx.Read()
                        'Do something here
                        candiNo = lrdxx.Item("username")
                    End While
                End If
                sqCon.Close()
                'end of query

                If candiNo = txusername.Text Then
                    MsgBox("Sorry your username is already used by other user.", vbExclamation, "Retry")
                Else
                    sqCon.Open()
                    sqCmd.Connection = sqCon
                    sqCmd.CommandText = "INSERT INTO userAdmin VALUES('" & txusername.Text & "','" & encryptedna.Text & "','" & txname.Text & "','" & cbousrtype.Text & "','inactive')"
                    sqCmd.ExecuteNonQuery()
                    sqCon.Close()
                    MsgBox("Successfully added new account.", vbInformation, "Success")
                End If
            Else
                MsgBox("Password didn't match!", vbExclamation, "Verify password")
            End If
        End If
    End Sub

    Private Sub chkPshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPshow.CheckedChanged
        If chkPshow.Checked Then
            txpassword.PasswordChar = Nothing
            txconfirmpassword.PasswordChar = Nothing
        Else
            txpassword.PasswordChar = ChrW(9676)
            txconfirmpassword.PasswordChar = ChrW(9676)
        End If
    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        txname.Text = ""
        txusername.Text = ""
        txpassword.Text = ""
        txconfirmpassword.Text = ""
        chkPshow.Checked = False
    End Sub

    'function to encrypt data
    Public Function Encrypt(ByVal plainText As String) As String

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
    End Function
    'end of function

    Private Sub createuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbousrtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbousrtype.SelectedIndexChanged

    End Sub
End Class