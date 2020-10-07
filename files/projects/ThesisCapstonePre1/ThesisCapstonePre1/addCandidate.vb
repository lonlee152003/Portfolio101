Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb


Public Class addCandidate
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub addCandidate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        viewDel()
    End Sub

    Private Sub txsearch4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txsearch4.GotFocus
        fals()
    End Sub

    Private Sub txno4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txno4.KeyPress
        'Code use to input numbers only
        'please enable later/asap
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tru()
        txname4.Enabled = True
        cb14.Enabled = True
        cb24.Enabled = True
        cb34.Enabled = True
        txaddress4.Enabled = True
        txdepartment4.Enabled = True
        txhobby4.Enabled = True
        txfq4.Enabled = True
        txvs4.Enabled = True
        txambitions4.Enabled = True
    End Sub

    Private Sub fals()
        txname4.Enabled = False
        cb14.Enabled = False
        cb24.Enabled = False
        cb34.Enabled = False
        txaddress4.Enabled = False
        txdepartment4.Enabled = False
        txhobby4.Enabled = False
        txfq4.Enabled = False
        txvs4.Enabled = False
        txambitions4.Enabled = False
    End Sub

    Private Sub chkcn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcn.CheckedChanged
        If chkcn.Checked = True Then
            chka.CheckState = Windows.Forms.CheckState.Unchecked
            txdel.Visible = True
            txdelall.Visible = False
        End If
    End Sub

    Private Sub chka_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chka.CheckedChanged
        If chka.Checked = True Then
            chkcn.CheckState = Windows.Forms.CheckState.Unchecked
            txdel.Visible = False
            txdelall.Visible = True
        End If
    End Sub
    
    ''''''''''''''''''''''''''34
    Public Sub viewDel()
        cnn.Close()
        cnn.Open()
        Dim daa1x As New OleDb.OleDbDataAdapter("Select candidate.candidateno, candidate.name, candidate.bday, candidate.address, candidate.department, candidate.hobby, candidate.fqoute, candidate.vstat, candidate.ambition FROM candidate LEFT JOIN Information ON candidate.candidateno=Information.candidate_id", cnn)
        Dim dttx As New DataTable
        'fill data to datatable
        daa1x.Fill(dttx)
        DataGridView1.DataSource = dttx
        cnn.Close()
    End Sub
    Dim nooh

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            DataGridView1.CurrentRow.Cells(0).ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Dim path As String = (Microsoft.VisualBasic.Left(Application.StartupPath, Len(Application.StartupPath) - 9))
  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'get the value of candidate id
            
            'end of query
        Catch ex As Exception

            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Dim cac
    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        nooh = DataGridView1.CurrentRow.Cells(0).Value
        'caco.Text = nooh
        cnn.Close()
        cnn.Open()
        Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate WHERE candidateno='" & nooh & "'", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa1.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1

            cac = dtt.Rows(i)("name")


        Next
        cnn.Close()

        Dim Stream As New MemoryStream()
        cnn.Close()
        cnn.Open()
        sqlcommand.Connection = cnn
        sqlcommand.CommandText = "SELECT photo FROM Information WHERE candidate_id='" & nooh & "'"
        Dim image As Byte() = DirectCast(sqlcommand.ExecuteScalar(), Byte())
        Stream.Write(image, 0, image.Length)
        cnn.Close()
        Dim bitmap As New Bitmap(Stream)

        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.Image = bitmap
    End Sub

    Private Sub DataGridView1_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellMouseEnter

    End Sub

    'Private rowIndex As Integer = 0
    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub
    'Private Sub ContextMenuStrip1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    'If Not Me.DataGridView1.Rows(Me.rowIndex).IsNewRow Then
    'Me.DataGridView1.Rows.RemoveAt(Me.rowIndex)
    'End If
    'End Sub


    Private Sub AddRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRecordToolStripMenuItem.Click
        Dim acr As New addCandidateRecord
        acr.ShowDialog()
        'DataGridView1.Rows(e.RowIndex).Cells(0).Value()
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
            sqlcommand.CommandText = "UPDATE candidate SET name='" & DataGridView1.CurrentRow.Cells(1).Value & "',bday='" & DataGridView1.CurrentRow.Cells(2).Value & "',address='" & DataGridView1.CurrentRow.Cells(3).Value & "',department='" & DataGridView1.CurrentRow.Cells(4).Value & "',hobby='" & DataGridView1.CurrentRow.Cells(5).Value & "',fqoute='" & DataGridView1.CurrentRow.Cells(6).Value & "', vstat='" & DataGridView1.CurrentRow.Cells(7).Value & "',ambition='" & DataGridView1.CurrentRow.Cells(8).Value & "' WHERE candidateno='" & nooh & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE categoryReport SET candidate_name='" & DataGridView1.CurrentRow.Cells(1).Value & "' WHERE candidate_name='" & cac & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE judgescoreboard SET candidate_name='" & DataGridView1.CurrentRow.Cells(1).Value & "' WHERE candidate_name='" & cac & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE totalReport SET candidate_name='" & DataGridView1.CurrentRow.Cells(1).Value & "' WHERE candidate_name='" & cac & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            MsgBox("Success", vbOKOnly, "Done")
            'to view updated data
            viewDel()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub DeleteAllRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllRecordToolStripMenuItem.Click
        Try
            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM candidate"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM Information"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM categoryReport"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM judgescoreboard"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM totalReport"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM keyword_sms"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()
            MsgBox("Successfully Deleted!", vbOKOnly, "Deleted!")
            viewDel()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            cnn.Close()
            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate WHERE candidateno='" & nooh & "'", cnn)
            Dim dtt As New DataTable
            Dim nonono
            'fill data to datatable
            daa1.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1

                nonono = dtt.Rows(i)("candidateno")

            Next
            cnn.Close()

            If nonono <> nooh Then
                MsgBox("No existing data", vbCritical, "Retry")
            Else
                'delete candidate data by 1
                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM candidate WHERE candidateno='" & nooh & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM Information WHERE candidate_id='" & nooh & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM categoryReport WHERE candidate_name='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM judgescoreboard WHERE candidate_name='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM totalReport WHERE candidate_name='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM keyword_sms WHERE candidate_no='" & cac & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                MsgBox("Successfully Deleted!", vbOKOnly, "Deleted!")
                viewDel()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        viewDel()
    End Sub

    Private Sub ChangePhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePhotoToolStripMenuItem.Click
        Try
            Dim acc As New addCandidateChange
            acc.Label2.Text = nooh
            acc.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class