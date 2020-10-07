Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO

Public Class addCandidate_others
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Public Sub viewDel()
        Try
            cnn.Close()
            cnn.Open()
            Dim daa1x As New OleDb.OleDbDataAdapter("Select candidate_others.group_number, candidate_others.group_name, candidate_others.address, candidate_others.department FROM candidate_others", cnn)
            Dim dttx As New DataTable
            'fill data to datatable
            daa1x.Fill(dttx)
            DataGridView1.DataSource = dttx
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub addCandidate_others_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewDel()
    End Sub

    Dim cac
    Dim nooh
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            DataGridView1.CurrentRow.Cells(0).ReadOnly = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Try
            nooh = DataGridView1.CurrentRow.Cells(0).Value

            cnn.Close()
            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate_others WHERE group_number='" & nooh & "'", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa1.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1

                cac = dtt.Rows(i)("group_name")


            Next
            cnn.Close()

            Dim Stream As New MemoryStream()
            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "SELECT photo FROM Information_others WHERE candidate_id='" & nooh & "'"
            Dim image As Byte() = DirectCast(sqlcommand.ExecuteScalar(), Byte())
            Stream.Write(image, 0, image.Length)
            cnn.Close()
            Dim bitmap As New Drawing.Bitmap(Stream)

            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Image = bitmap
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Try

            'txbirtd.Text = cb14.Text & Chr(32) & cb24.Text & Chr(32) & cb34.Text
            'Dim yearx As Date
            'yearx = Now
            'txage4.Text = Val(yearx.Year - cb34.Text)
            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE candidate_others SET group_name='" & DataGridView1.CurrentRow.Cells(1).Value & "',address='" & DataGridView1.CurrentRow.Cells(2).Value & "',department='" & DataGridView1.CurrentRow.Cells(3).Value & "' WHERE group_number='" & nooh & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE judgescoreboard_others SET candidate_name='" & DataGridView1.CurrentRow.Cells(1).Value & "' WHERE candidate_name='" & cac & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE categoryReport_others SET candidate_name='" & DataGridView1.CurrentRow.Cells(1).Value & "' WHERE candidate_name='" & cac & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE totalReport_others SET candidate_name='" & DataGridView1.CurrentRow.Cells(1).Value & "' WHERE candidate_name='" & cac & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Success", vbOKOnly, "Done")
            'to view updated data
            viewDel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteAllRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllRecordToolStripMenuItem.Click
        Try
            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM candidate_others"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM Information_others"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM judgescoreboard_others"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM categoryReport_others"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM totalReport_others"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM keyword_sms_others"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()
            MsgBox("Successfully Deleted!", vbOKOnly, "Deleted!")
            viewDel()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            cnn.Close()
            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate_others WHERE group_number='" & nooh & "'", cnn)
            Dim dtt As New DataTable
            Dim nonono
            'fill data to datatable
            daa1.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1

                nonono = dtt.Rows(i)("group_number")

            Next
            cnn.Close()

            If nonono <> nooh Then
                MsgBox("No existing data", vbCritical, "Retry")
            Else
                'delete candidate data by 1
                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM candidate_others WHERE group_number='" & nooh & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE  FROM Information_others WHERE candidate_id='" & nooh & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE  FROM judgescoreboard_others WHERE candidate_name='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM categoryReport_others WHERE candidate_name='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM totalReport_others WHERE candidate_name='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM  keyword_sms_others WHERE candidate_no='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                MsgBox("Successfully Deleted!", vbOKOnly, "Deleted!")
                viewDel()
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChangePhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePhotoToolStripMenuItem.Click
        Dim acc As New addCandidateChange_others
        acc.Label2.Text = nooh
        acc.ShowDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        viewDel()
    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRecordToolStripMenuItem.Click
        Dim ads As New addCandidateRecord_others
        ads.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class