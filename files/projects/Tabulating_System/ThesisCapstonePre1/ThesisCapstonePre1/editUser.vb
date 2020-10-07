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

Public Class editUser
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand

    Private Sub editUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            viewAllData()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btneditname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditname.Click
        Try
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE userAdmin SET name='" & txname.Text & "' WHERE username='" & txsearch.Text & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()
            MsgBox("New Name: " & txname.Text & "", vbOKOnly, "Done")
            viewAllData()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btneditusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditusername.Click
        Try
            If txname.Text = Nothing Or txpassword.Text = "Password here!" Or txpassword.Text = Nothing Or txusername.Text = Nothing Then
                MsgBox("Blank field", vbExclamation, "Retry")
            Else
                Encrypt(txpassword.Text)

                cnn.Open()
                Dim candiNo As String
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE username='" & txusername.Text & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    candiNo = dtt.Rows(i)("username")
                Next
                cnn.Close()

                If candiNo = txusername.Text Then
                    MsgBox("Sorry your username is already used by other user.", vbExclamation, "Retry")
                Else
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE userAdmin SET name='" & txname.Text & "',password='" & ecrypt.Text & "',username='" & txusername.Text & "' WHERE username='" & txsearch.Text & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()

                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE judgescoreboard SET judge_name='" & txusername.Text & "' WHERE judge_name='" & txnamepo.Text & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()

                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE judgescoreboard_others SET judge_name='" & txusername.Text & "' WHERE judge_name='" & txnamepo.Text & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()

                    MsgBox("New name: " & txname.Text & vbCrLf & " New username: " & txusername.Text & vbCrLf & " New password: " & txpassword.Text & vbCrLf & "", vbOKOnly, "Done")
                    txsearch.Text = txusername.Text
                    viewAllData()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btneditpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditpassword.Click
        'call function of encrypt
        'Encrypt(txpassword.Text)
        'sqCon.Open()
        'sqCmd.Connection = sqCon
        'sqCmd.CommandText = "UPDATE userAdmin SET password='" & ecrypt.Text & "' WHERE username='" & txsearch.Text & "'"
        'sqCmd.ExecuteNonQuery()
        'sqCon.Close()
        'MsgBox("New Password: " & txpassword.Text & "", vbOKOnly, "Done")
        'viewAllData()
    End Sub
    Private Sub viewAllData()
        Try
            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("Select userId,username,password,name,usertype from userAdmin", cnn)
            Dim dtt1 As New DataTable
            'fill data to datatable
            daa1.Fill(dtt1)
            DataGridView1.DataSource = dtt1
            cnn.Close()
            'to view data on 3 textbox
            'Dim usern As String
        Catch ex As Exception
            cnn.Close()
        End Try
    End Sub

    Private Sub txsearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txsearch.GotFocus
        txsearch.Text = Nothing
    End Sub


    Private Sub txsearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txsearch.TextChanged
       
        cnn.Open()
        Dim daa1 As New OleDb.OleDbDataAdapter("Select * from userAdmin Where username LIKE  '" & "%" & txsearch.Text & "%" & "'", cnn)
        Dim dtt1 As New DataTable
        'fill data to datatable
        daa1.Fill(dtt1)
        DataGridView1.DataSource = dtt1
        cnn.Close()
        'to view data on 3 textbox
         'Dim usern As String
        cnn.Open()
        Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE username='" & txsearch.Text & "'", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1
            'candiNo = dtt.Rows(i)("username")
            If txsearch.Text = dtt.Rows(i)("username") Then
                txname.Text = dtt.Rows(i)("name")
                txusername.Text = dtt.Rows(i)("username")
                TextBox1.Text = dtt.Rows(i)("password")
                txnamepo.Text = dtt.Rows(i)("username")
            End If
        Next
        cnn.Close()

        If TextBox1.Text = Nothing Then
        Else
            Decrypt(TextBox1.Text)
        End If
    End Sub

    Private Sub btnDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If CheckBox1.Checked = True Then

        Else
            If MsgBox("Warning! Removing all user account's will deleted all the record that was created by the judges such as their score and any related record of the user in the database", MsgBoxStyle.YesNo, "Deleted!") = MsgBoxResult.Yes Then


            End If
        End If
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
        ecrypt.Text = cipherText
        Return 0
    End Function

    Private Sub txdelinput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txdelinput.GotFocus
        txdelinput.Text = Nothing
    End Sub
    'end of function

    Private Sub txpassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txpassword.GotFocus
        txpassword.Text = Nothing
    End Sub

    Private Sub txpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txpassword.TextChanged

    End Sub

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
        txpassword.Text = plainText
        Return 0
    End Function
    'end of function


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.CheckState = Windows.Forms.CheckState.Unchecked
            txdelinput.Visible = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.CheckState = Windows.Forms.CheckState.Unchecked
            txdelinput.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.MouseHover
        CheckBox1.BackColor = Drawing.Color.DarkGreen
        CheckBox1.ForeColor = Drawing.Color.White
    End Sub

    Private Sub CheckBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.MouseLeave
        CheckBox1.BackColor = Drawing.Color.White
        CheckBox1.ForeColor = Drawing.Color.DarkGreen
    End Sub

    Private Sub CheckBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.MouseHover
        CheckBox2.BackColor = Drawing.Color.DarkGreen
        CheckBox2.ForeColor = Drawing.Color.White
    End Sub

    Private Sub CheckBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.MouseLeave
        CheckBox2.BackColor = Drawing.Color.White
        CheckBox2.ForeColor = Drawing.Color.DarkGreen
    End Sub

    Private Sub chkPshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPshow.CheckedChanged
        If chkPshow.Checked Then
            TextBox4.PasswordChar = Nothing
            txconfirmpassword.PasswordChar = Nothing
        Else
            TextBox4.PasswordChar = ChrW(9676)
            txconfirmpassword.PasswordChar = ChrW(9676)
        End If
    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        txconfirmpassword.Text = ""
        chkPshow.Checked = False
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Refresh()
        'verify textbox if empty
        If TextBox3.Text = Nothing Or TextBox2.Text = Nothing Or TextBox4.Text = Nothing Or txconfirmpassword.Text = Nothing Then
            'prompt empty textbox
            MsgBox("Textfield can't be empty!", vbExclamation, "Warning!")
        Else
            'textbox has a value
            If TextBox4.Text = txconfirmpassword.Text Then
                'call function to encrypt data
                Encrypt1(TextBox4.Text)

                'get the value of candidate id
                cnn.Open()
                Dim candiNo As String
                Dim un As String
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE username='" & TextBox2.Text & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    candiNo = dtt.Rows(i)("username")
                Next
                cnn.Close()
                'end of query

                If candiNo = TextBox2.Text Then
                    MsgBox("Sorry your username is already used by other user.", vbExclamation, "Retry")
                Else
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "INSERT INTO userAdmin VALUES('" & TextBox2.Text & "','" & encryptedna.Text & "','" & TextBox3.Text & "','" & cbousrtype.Text & "','inactive')"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                    MsgBox("Successfully added new account.", vbInformation, "Success")
                    viewAllData()
                End If
            Else
                MsgBox("Password didn't match!", vbExclamation, "Verify password")
            End If
        End If
    End Sub

    Public Function Encrypt1(ByVal plainText As String) As String

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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            DataGridView1.CurrentRow.Cells(0).ReadOnly = True
            DataGridView1.CurrentRow.Cells(4).ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim idname
    Dim makkel
    Dim pws
    Dim namexx
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Try

            idname = DataGridView1.CurrentRow.Cells(0).Value
            makkel = DataGridView1.CurrentRow.Cells(1).Value
            pws = DataGridView1.CurrentRow.Cells(2).Value
            namexx = DataGridView1.CurrentRow.Cells(3).Value

        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub EditJudgesAdministratorAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditJudgesAdministratorAccountToolStripMenuItem.Click
       
        cnn.Open()
        Dim un As String
        Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE userId='" & idname & "'", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1
            'editCategorypo.Items.Add(dtt.Rows(i)("category_name"))
            un = dtt.Rows(i)("username")
        Next
        cnn.Close()

        Encrypt(pws)

        'get the value of candidate id
        cnn.Open()
        Dim candiNo As String
        Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE username='" & makkel & "'", cnn)
        Dim dtt1 As New DataTable
        'fill data to datatable
        daa1.Fill(dtt1)
        For i1 = 0 To dtt1.Rows.Count - 1
            'un = dtt1.Rows(i1)("username")
            candiNo = dtt1.Rows(i1)("username")
        Next
        cnn.Close()
        'idname = DataGridView1.CurrentRow.Cells(0).Value            id
        'makkel = DataGridView1.CurrentRow.Cells(1).Value            un
        'pws = DataGridView1.CurrentRow.Cells(2).Value               pw
        'namexx = DataGridView1.CurrentRow.Cells(3).Value            name

        If candiNo = makkel Then
            MsgBox("Sorry your username is already used by other user.", vbExclamation, "Retry")
        Else
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE userAdmin SET name='" & namexx & "',password='" & ecrypt.Text & "',username='" & makkel & "' WHERE username='" & un & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE judgescoreboard SET judge_name='" & makkel & "' WHERE judge_name='" & un & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE judgescoreboard_others SET judge_name='" & makkel & "' WHERE judge_name='" & un & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            MsgBox("New name: " & namexx & vbCrLf & " New username: " & makkel & vbCrLf & " New password: " & pws & vbCrLf & "", vbOKOnly, "Done")
            txsearch.Text = txusername.Text
            viewAllData()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        viewAllData()
    End Sub

    Private Sub AddJudgesAdministratorAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddJudgesAdministratorAccountToolStripMenuItem.Click
        Dim aa As New Add_Record
        aa.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'Dim usern As String
        Dim usea
        Dim usea1

        cnn.Open()
        Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin WHERE username='" & makkel & "'", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1
            'editCategorypo.Items.Add(dtt.Rows(i)("category_name"))
            usea = dtt.Rows(i)("userType")
            usea1 = dtt.Rows(i)("username")
        Next
        cnn.Close()

        If usea1 = makkel And usea = "admin" Then
            MsgBox("Unable to delete e.i. username is not existing or user is administrator", vbExclamation, "Retry")
        ElseIf usea1 = makkel And usea = "judge" Then
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM userAdmin WHERE username='" & makkel & "' and userType='judge'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()



            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM judgescoreboard where judge_name='" & makkel & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM judgescoreboard_others where judge_name='" & makkel & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Successfully Deleted!", vbOKOnly, "Deleted!")
            viewAllData()
        Else
            MsgBox("Unable to delete e.i. username is not existing", vbExclamation, "Retry")
        End If
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllToolStripMenuItem.Click
        cnn.Open()
        sqlcommand.Connection = cnn
        sqlcommand.CommandText = "DELETE FROM userAdmin WHERE userType='judge'"
        sqlcommand.ExecuteNonQuery()
        cnn.Close()

        cnn.Open()
        sqlcommand.Connection = cnn
        sqlcommand.CommandText = "DELETE FROM judgescoreboard"
        sqlcommand.ExecuteNonQuery()
        cnn.Close()

        cnn.Open()
        sqlcommand.Connection = cnn
        sqlcommand.CommandText = "DELETE FROM judgescoreboard_others"
        sqlcommand.ExecuteNonQuery()
        cnn.Close()

        MsgBox("Successfully Deleted!", vbOKOnly, "Deleted!")
        viewAllData()
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellToolTipTextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellToolTipTextChanged

    End Sub
End Class