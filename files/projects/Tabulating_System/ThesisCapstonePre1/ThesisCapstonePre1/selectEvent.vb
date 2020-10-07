Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class selectEvent
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Try
            If ComboBox1.Text = Nothing Then
                MsgBox("Select Event First!", vbExclamation, "No valid event")
            Else
                Dim catid As String

                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM contestType WHERE status='Active'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    'candiNo = dtt.Rows(i)("username")
                    catid = dtt.Rows(i)("status").ToString()
                Next
                cnn.Close()
                'end of query

                If catid = "Active" Then
                    MsgBox("Deactivate First", vbInformation, "information")
                    If ComboBox1.SelectedIndex = 0 And CheckBox2.CheckState = Windows.Forms.CheckState.Checked Then
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE contestType SET status='Inactive' WHERE gameCategory='pageant'"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        MsgBox("Pageant Event has been deactivated.", vbInformation, "Information")
                        catid = "Inactive"
                    ElseIf ComboBox1.SelectedIndex = 1 And CheckBox2.CheckState = Windows.Forms.CheckState.Checked Then
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE contestType SET status='Inactive' WHERE gameCategory='other'"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        MsgBox("Other Event has been deactivated.", vbInformation, "Information")
                        catid = "Inactive"
                    Else
                    End If
                Else
                    If ComboBox1.SelectedIndex = 0 And CheckBox1.CheckState = Windows.Forms.CheckState.Checked Then
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE contestType SET status='Active' WHERE gameCategory='pageant'"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        If MsgBox("Pageant Event has been activated.", MsgBoxStyle.Information, "Information") = MsgBoxResult.Ok Then
                            Dim adminPages As New adminPage
                            adminPages.txusr.Text = Label2.Text
                            adminPages.ShowDialog()
                            Me.Hide()
                        End If
                    ElseIf ComboBox1.SelectedIndex = 1 And CheckBox1.CheckState = Windows.Forms.CheckState.Checked Then
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE contestType SET status='Active' WHERE gameCategory='other'"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        If MsgBox("Other Event has been activated.", MsgBoxStyle.Information, "Information") = MsgBoxResult.Ok Then
                            Dim adminPage_otherss As New adminPage_others
                            adminPage_otherss.txusr.Text = Label2.Text
                            adminPage_otherss.ShowDialog()
                            Me.Hide()
                        End If
                    Else
                    End If
                End If

                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("Select * from contestType", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                DataGridView1.DataSource = dtt1
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.CheckState = Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.CheckState = Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    Private Sub selectEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.Items.Clear()
            Dim catid As String

            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM contestType", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'candiNo = dtt.Rows(i)("username")
                catid = dtt.Rows(i)("gameCategory")
                ComboBox1.Items.Add(catid)
            Next
            cnn.Close()

            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("Select * from contestType", cnn)
            Dim dtt1 As New DataTable
            'fill data to datatable
            daa1.Fill(dtt1)
            DataGridView1.DataSource = dtt1
            cnn.Close()
            'end of query
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
End Class