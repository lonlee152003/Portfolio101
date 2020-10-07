Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb

Public Class addCandidateChange_others


    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM information_others WHERE candidate_id='" & Label2.Text & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO Information_others VALUES(@name,@photo,'" & Label2.Text & "')", cnn)
            cmd.Parameters.AddWithValue("@name", Label2.Text)
            Dim ms As New MemoryStream()
            PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@photo", OleDbType.Binary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            cnn.Close()
            MsgBox("Image successfully change", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub addCandidateChange_others_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class