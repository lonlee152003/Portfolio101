Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb

Public Class addCandidateRecord
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
            If txAddimg.Text = Nothing Or txno4.Text = Nothing Or txname3.Text = Nothing Or txaddress3.Text = Nothing Or txdepartment3.Text = Nothing Or txbday3.Text = Nothing Or txhobby3.Text = Nothing Or txfq3.Text = Nothing Or txvs3.Text = Nothing Or txambitions3.Text = Nothing Then
                MsgBox("You should fill the empty fields!", vbExclamation, "Error registration")
            Else
                cnn.Close()
                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate WHERE candidateno='" & txno4.Text & "' or name='" & txname3.Text & "'", cnn)
                Dim dtt As New DataTable
                Dim candiNo As String
                Dim candiTo As String
                'fill data to datatable
                daa1.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1

                    candiNo = dtt.Rows(i)("candidateno")
                    candiTo = dtt.Rows(i)("name")

                Next
                cnn.Close()

                If candiNo = txno4.Text Or candiTo = txname3.Text Then
                    MsgBox("An existing candidate data", vbExclamation, "Retry")
                Else
                    cnn.Close()
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "INSERT INTO candidate([candidateno],[name],[bday],[age],[address],[department],[hobby],[fqoute],[vstat],[ambition]) VALUES('" & txno4.Text & "','" & txname3.Text & "','" & txbday3.Text & "','0','" & txaddress3.Text & "','" & txdepartment3.Text & "','" & txhobby3.Text & "','" & txfq3.Text & "','" & txvs3.Text & "','" & txambitions3.Text & "')"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()

                    cnn.Close()
                    cnn.Open()
                    Dim cmd As New OleDbCommand("INSERT INTO Information VALUES(@name,@photo,'" & txno4.Text & "')", cnn)
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
                    txbday3.Text = Nothing
                    txhobby3.Text = Nothing
                    txfq3.Text = Nothing
                    txvs3.Text = Nothing
                    txambitions3.Text = Nothing
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

    Private Sub txno4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txno4.TextChanged

    End Sub

    Private Sub txvs3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txvs3.KeyPress
        Try
            If Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            Else
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub txvs3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txvs3.TextChanged

    End Sub

    Private Sub addCandidateRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub
End Class