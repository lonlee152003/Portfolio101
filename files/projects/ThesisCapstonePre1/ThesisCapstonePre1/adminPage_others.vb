Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb

Public Class adminPage_others
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

        'Dim editx As New addCandidate_others
        'editx.TabControl1.SelectedTab = editx.TabPage2
        'editx.TabPage2.Select()
        'editx.ShowDialog()
        
    End Sub

    Private Sub AddNewCandidateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCandidateToolStripMenuItem.Click

        'Dim editx As New addCandidate_others
        'editx.TabControl1.SelectedTab = editx.TabPage1
        'editx.TabPage1.Select()
        'editx.ShowDialog()

    End Sub

    Private Sub InsertCategoryAndCriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertCategoryAndCriteriaToolStripMenuItem.Click

        Dim cat As New category_others
        cat.ShowDialog()
      
    End Sub

    Private Sub SmsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmsToolStripMenuItem.Click

        Dim smsApp As New sampleSMSApp_others
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
            sqlcommand.CommandText = "UPDATE contestType SET status='Inactive' WHERE gameCategory='other'"
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

    Private Sub adminPage_others_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

                cnn.Close()
                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("Select name,username,userType,loginStat from userAdmin WHERE userType='judge'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                DataGridView1.DataSource = dtt
                cnn.Close()
                'sqCmda.CommandText = "SELECT criteria.criteria_name,criteria.max_length,criteria.Score FROM category LEFT JOIN criteria ON category.category_id=criteria.category_id WHERE category.category_id=" & ComboBox1.Text & " "

                cnn.Close()
                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("Select category_others.category_name,judgescoreboard_others.candidate_id,judgescoreboard_others.candidate_name,judgescoreboard_others.judge_name,judgescoreboard_others.score FROM category_others INNER JOIN judgescoreboard_others ON category_others.category_id=judgescoreboard_others.category_id", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                DataGridView2.DataSource = dtt1
                cnn.Close()
                'chart
                'Chart1.Series.Clear()
                'Chart1.Series.Add("Total Score")

                'con.Open()
                'sqCmdUpdate.Connection = con
                'Dim prodo2 As String
                'Dim prodo3 As String
                'sqCmdUpdate.CommandText = "SELECT * FROM totalReport_others"
                'Dim lrd2x As SqlDataReader = sqCmdUpdate.ExecuteReader()
                'If lrd2x.HasRows Then
                'While lrd2x.Read()
                'prodo2 = lrd2x.Item("candidate_name")
                'prodo3 = lrd2x.Item("score")
                'Chart1.Series("Total Score").Points.AddXY(lrd2x("candidate_name").ToString, lrd2x("score").ToString)
                'End While
                'End If
                'con.Close()
                'Chart1.Series("Total Score").Sort(PointSortOrder.Ascending, "Total Score")
                'Chart1.DataManipulator.Sort(PointSortOrder.Ascending, "Total Score")



                'return teme to 0
                teme = 0
            End If
        Catch ex As Exception
            cnn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CandidatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidatesToolStripMenuItem.Click

        Dim aa As New reportRegen_others
        aa.ShowDialog()
        
    End Sub

    

    Private Sub DeleteCandidateDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCandidateDataToolStripMenuItem.Click

        'Dim editx As New addCandidate_others
        'editx.TabControl1.SelectedTab = editx.TabPage3
        'editx.TabPage3.Select()
        'editx.ShowDialog()
       
    End Sub

    

    Private Sub TallyBoardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallyBoardToolStripMenuItem.Click

        Dim taltal As New tallytable_others
        taltal.ShowDialog()
        
    End Sub

    

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Try
            If MsgBox("Are you sure you want to Reset?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
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

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM candidate_others"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM category_others"
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
                sqlcommand.CommandText = "DELETE FROM criteria_others"
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
                sqlcommand.CommandText = "DELETE FROM keyword_sms_others"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Close()
                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM receiver_sms_others"
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
                sqlcommand.CommandText = "DELETE FROM Information_others"
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

        'Dim editx As New addCandidate_others
        'editx.TabControl1.SelectedTab = editx.TabPage1
        'editx.TabPage1.Select()
        'editx.ShowDialog()
        Dim cat As New addCandidate_others
        cat.ShowDialog()
       
    End Sub

    Private Sub CategoryCriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryCriteriaToolStripMenuItem.Click

        Dim cat As New category_others
        cat.ShowDialog()
        
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DataGridView2_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView2, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub
End Class