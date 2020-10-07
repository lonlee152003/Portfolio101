Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb

Public Class adminPage
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub AddNewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewAccountToolStripMenuItem.Click

        Dim createuser As New createuser
        createuser.ShowDialog()
       
    End Sub

    Private Sub EditUserAdminAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUserAdminAccountToolStripMenuItem.Click

        Dim edituser As New editUser
        edituser.ShowDialog()
        
    End Sub

    Private Sub EditExistingCandidateNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditExistingCandidateNameToolStripMenuItem.Click

        Dim editx As New addCandidate
        editx.TabControl1.SelectedTab = editx.TabPage2
        editx.TabPage2.Select()
        editx.ShowDialog()
        
    End Sub

    Private Sub AddNewCandidateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCandidateToolStripMenuItem.Click

        Dim editx As New addCandidate
        editx.TabControl1.SelectedTab = editx.TabPage1
        editx.TabPage1.Select()
        editx.ShowDialog()
        
    End Sub

    Private Sub InsertCategoryAndCriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertCategoryAndCriteriaToolStripMenuItem.Click

        Dim cat As New category
        cat.ShowDialog()
        
    End Sub

    Private Sub SmsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsToolStripMenuItem.Click

        Dim smsApp As New sampleSMSApp
        smsApp.ShowDialog()
        
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Try
            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE userAdmin SET loginStat='inactive' WHERE username='" & txusr.Text & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Close()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE contestType SET status='Inactive' WHERE gameCategory='pageant'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()
            Close()

            Dim logingin As New login
            logingin.Show()
            Me.Hide()
        Catch ex As Exception
            cnn.Close()
        End Try
    End Sub

    Private Sub adminPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Dim teme As Integer = 0
    Dim ad As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            teme = teme + 1
            If teme = 5 Then
                'count indicator
                ad = ad + 1
                Label1.Text = ad
                If ad = 60 Then
                    ad = 0
                End If

                cnn.Open()
                Dim daa1x As New OleDb.OleDbDataAdapter("Select name,username,userType,loginStat from userAdmin WHERE userType='judge'", cnn)
                Dim dttx As New DataTable
                'fill data to datatable
                daa1x.Fill(dttx)
                DataGridView1.DataSource = dttx
                cnn.Close()

                'sqCmda.CommandText = "SELECT criteria.criteria_name,criteria.max_length,criteria.Score FROM category LEFT JOIN criteria ON category.category_id=criteria.category_id WHERE category.category_id=" & ComboBox1.Text & " "
                cnn.Open()
                Dim daa1x1 As New OleDb.OleDbDataAdapter("Select category.category_name,judgescoreboard.candidate_id,judgescoreboard.candidate_name,judgescoreboard.judge_name,judgescoreboard.score FROM category INNER JOIN judgescoreboard ON category.category_id=judgescoreboard.category_id", cnn)
                Dim dttx1 As New DataTable
                'fill data to datatable
                daa1x1.Fill(dttx1)
                DataGridView2.DataSource = dttx1
                cnn.Close()

                'return teme to 0
                teme = 0
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message, vbExclamation, "Retry")
            cnn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CandidatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidatesToolStripMenuItem.Click

        Dim aa As New reportRegen
        aa.ShowDialog()
       
    End Sub



    Private Sub DeleteCandidateDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCandidateDataToolStripMenuItem.Click

        Dim editx As New addCandidate
        editx.TabControl1.SelectedTab = editx.TabPage3
        editx.TabPage3.Select()
        editx.ShowDialog()
       
    End Sub

    Private Sub TallyBoardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallyBoardToolStripMenuItem.Click

        Dim tal As New tallyTable
        tal.ShowDialog()
       
    End Sub

    

    Private Sub ResetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem1.Click
        Try
            If MsgBox("Are you sure you want to Reset?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM candidate"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM category"
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
                sqlcommand.CommandText = "DELETE FROM criteria"
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
                sqlcommand.CommandText = "DELETE FROM keyword_sms"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM receiver_sms"
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
                sqlcommand.CommandText = "DELETE FROM Information"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM userAdmin"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "INSERT INTO userAdmin([username],[password],[name],[userType],[loginStat]) VALUES('admin','CVhJO8vrthxSyjdXbBNJJw==','admin','admin','inactive')"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                MsgBox("Default, admin account username: admin and password:admin", vbInformation, "info")
                Dim lo As New login
                lo.Show()
                Me.Hide()
            Else
                MsgBox("No action performed", vbInformation, "No action")
            End If
        Catch ex As Exception
            cnn.Close()
        End Try
    End Sub

    Private Sub SportsScoreboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim sco As New SportScoreBoard
        sco.ShowDialog()
      
    End Sub

    
    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click

        Dim go As New editUser
        go.ShowDialog()
        
    End Sub

    Private Sub CandidateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidateToolStripMenuItem.Click

        Dim editx As New addCandidate
        editx.TabControl1.SelectedTab = editx.TabPage1
        editx.TabPage1.Select()
        editx.ShowDialog()
        
    End Sub

    Private Sub CategoryAndCriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryAndCriteriaToolStripMenuItem.Click

        Dim cat As New category
        cat.ShowDialog()
       
    End Sub

   
    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Try
            ''''''''''
            cnn.Open()
            Dim daa1x As New OleDb.OleDbDataAdapter("Select name,username,userType,loginStat from userAdmin WHERE userType='judge'", cnn)
            Dim dttx As New DataTable
            'fill data to datatable
            daa1x.Fill(dttx)
            DataGridView1.DataSource = dttx
            cnn.Close()

            'sqCmda.CommandText = "SELECT criteria.criteria_name,criteria.max_length,criteria.Score FROM category LEFT JOIN criteria ON category.category_id=criteria.category_id WHERE category.category_id=" & ComboBox1.Text & " "
            cnn.Open()
            Dim daa1x1 As New OleDb.OleDbDataAdapter("Select category.category_name,judgescoreboard.candidate_id,judgescoreboard.candidate_name,judgescoreboard.judge_name,judgescoreboard.score FROM category INNER JOIN judgescoreboard ON category.category_id=judgescoreboard.category_id", cnn)
            Dim dttx1 As New DataTable
            'fill data to datatable
            daa1x1.Fill(dttx1)
            DataGridView2.DataSource = dttx1
            cnn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView2, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub
End Class