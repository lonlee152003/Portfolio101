Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb

Public Class addCandidateRecord_others
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                txAddimg.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btnregis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregis.Click
        Try
            If txAddimg.Text = Nothing Or txno4.Text = Nothing Or txname3.Text = Nothing Or txaddress3.Text = Nothing Or txdepartment3.Text = Nothing Then
                MsgBox("You should fill the empty fields!", vbExclamation, "Error registration")
            Else
                cnn.Close()
                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate_others WHERE group_number='" & txno4.Text & "' or group_name='" & txname3.Text & "'", cnn)
                Dim dtt As New DataTable
                Dim candiNo As String
                Dim candiTo As String
                'fill data to datatable
                daa1.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1

                    candiNo = dtt.Rows(i)("group_number")
                    candiTo = dtt.Rows(i)("group_name")

                Next
                cnn.Close()

                If candiNo = txno4.Text Or candiTo = txname3.Text Then
                    MsgBox("An existing candidate data", vbExclamation, "Retry")
                Else
                    cnn.Close()
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "INSERT INTO candidate_others([group_number],[group_name],[address],[department]) VALUES('" & txno4.Text & "','" & txname3.Text & "','" & txaddress3.Text & "','" & txdepartment3.Text & "')"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()

                    cnn.Close()
                    cnn.Open()
                    Dim cmd As New OleDbCommand("INSERT INTO Information_others VALUES(@name,@photo,'" & txno4.Text & "')", cnn)
                    cmd.Parameters.AddWithValue("@name", txAddimg.Text)
                    Dim ms As New MemoryStream()
                    PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New OleDbParameter("@photo", OleDbType.Binary)
                    p.Value = data
                    cmd.Parameters.Add(p)
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    MsgBox("Successfully added new account.", vbInformation, "Success")
                    'to view updated data
                    'Dim addc As New addCandidate
                    'Me.Hide()
                    txAddimg.Text = Nothing
                    txno4.Text = Nothing
                    txname3.Text = Nothing
                    txaddress3.Text = Nothing
                    txdepartment3.Text = Nothing
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub txno4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txno4.KeyPress
        Try
            'Code use to input numbers only
            'please enable later/asap
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub
End Class