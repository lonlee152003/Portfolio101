Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb

Public Class reportRegen
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub reportRegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'UserADataSet5.category_others' table. You can move, or remove it, as needed.
            Me.Category_othersTableAdapter1.Fill(Me.UserADataSet5.category_others)
            'TODO: This line of code loads data into the 'Categ.category_others' table. You can move, or remove it, as needed.
            Me.Category_othersTableAdapter.Fill(Me.Categ.category_others)
            'TODO: This line of code loads data into the 'CategoryKo.category' table. You can move, or remove it, as needed.
            Me.CategoryTableAdapter1.Fill(Me.CategoryKo.category)
            'TODO: This line of code loads data into the 'UserADataSet4.categoryReport' table. You can move, or remove it, as needed.
            'Me.categoryReportTableAdapter.Fill(Me.UserADataSet4.categoryReport)
            Timer1.Enabled = False
            Timer1.Stop()
            lscandidate.Items.Clear()
            'TODO: This line of code loads data into the 'UserADataSet3.category' table. You can move, or remove it, as needed.
            Me.CategoryTableAdapter.Fill(Me.UserADataSet3.category)
            'get the value of category id

            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM candidate", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'dtt.Rows(i)
                lscandidate.Items.Add(dtt.Rows(i)("name"))
            Next
            cnn.Close()

            selCAt.Items.Clear()

            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
            Dim dtt1 As New DataTable
            'fill data to datatable
            daa1.Fill(dtt1)
            For i1 = 0 To dtt1.Rows.Count - 1
                'dtt1.Rows(i1)
                selCAt.Items.Add(dtt1.Rows(i1)("category_name"))
            Next
            cnn.Close()

            ComboBox1.Items.Clear()

            cnn.Open()
            Dim daa2 As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
            Dim dtt2 As New DataTable
            'fill data to datatable
            daa2.Fill(dtt2)
            For i2 = 0 To dtt2.Rows.Count - 1
                'dtt2.Rows(i2)
                ComboBox1.Items.Add(dtt2.Rows(i2)("category_name"))
            Next
            cnn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btnSelCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelCat.Click
        Try
            'Dim selCat1 As Integer = selCAt.SelectedIndex() + 1
            Dim selCat1 As Integer
            selCat1 = Convert.ToInt64(selCat13.Text)
            DataGridView1.Rows.Clear()
            For xx As Integer = 0 To lscandidate.Items.Count - 1
                Dim name
                name = lscandidate.Items.Item(xx)
                'get the value of category id

                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM judgescoreboard WHERE category_id= '" & selCat1 & "' AND candidate_name LIKE '" & "%" & name & "%" & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    'dtt.Rows(i)
                    DataGridView1.Rows.Add(dtt.Rows(i)("candidate_name"), dtt.Rows(i)("score"), dtt.Rows(i)("judge_name"))
                Next
                cnn.Close()
                'end of query
            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'Label1.Text = selCAt.SelectedIndex() + 1
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'Label1.Text = lscandidate.Items.Item(2)
    'End Sub
    Dim a As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            a = a + 1
            Dim selCat1 As Integer
            selCat1 = Convert.ToInt64(selCat13.Text)
            If a = a Then
                Label1.Text &= " " & a
                Label7.Text = "Generating Report.."
                'start to query data
                
                DataGridView1.Rows.Clear()
                
                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM judgescoreboard WHERE category_id= '" & selCat1 & "' AND candidate_name='" & lscandidate.Items.Item(a - 1) & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    'dtt.Rows(i)
                    DataGridView1.Rows.Add(dtt.Rows(i)("candidate_name"), dtt.Rows(i)("score"), dtt.Rows(i)("judge_name"))
                Next
                cnn.Close()
                'to compute data of candidate
                REM category result will be computed in averaging
                REM formula:   categoryResult=summation/number of judges
                Dim total As Double = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    total += DataGridView1.Rows(i).Cells(1).Value
                Next

                Label2.Text = total
                Dim lab2 As Double
                lab2 = Convert.ToDouble(Label2.Text)
                Label3.Text = Val(lab2 / DataGridView1.RowCount)

                REM TO DETECT EXISTING DATA
                'get the value of category id
                
                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM categoryReport WHERE category_id='" & selCat1 & "' And candidate_name='" & lscandidate.Items.Item(a - 1) & "'", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                For i1 = 0 To dtt1.Rows.Count - 1
                    'dtt1.Rows(i1)
                    Label5.Text = dtt1.Rows(i1)("category_id")
                    Label6.Text = dtt1.Rows(i1)("candidate_name")
                Next
                cnn.Close()
                'end of query

                If Label5.Text = selCat1 And Label6.Text = lscandidate.Items.Item(a - 1) Then
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE categoryReport SET score='" & Label3.Text & "' WHERE category_id='" & selCat1 & "' And candidate_name='" & lscandidate.Items.Item(a - 1) & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                Else
                    REM TO ADD DATA TO DATABASE
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "INSERT INTO  categoryReport VALUES('" & selCat1 & "','" & selCAt.Text & "','" & lscandidate.Items.Item(a - 1) & "','" & Label3.Text & "')"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                End If
                If a = lscandidate.Items.Count Then
                    Label7.Text = "Finished"
                    Timer1.Stop()
                    a = 0

                    cnn.Open()
                    Dim daa2 As New OleDb.OleDbDataAdapter("Select * from categoryReport", cnn)
                    Dim dtt2 As New DataTable
                    'fill data to datatable
                    daa2.Fill(dtt2)
                    DataGridView2.DataSource = dtt2
                    cnn.Close()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If selCAt.Text = Nothing Then
            MsgBox("Please select category before generating report", vbExclamation, "Retry")
        Else
            If MsgBox("Are You sure you want to generate your report?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                Label1.Text = Nothing
                Timer1.Enabled = True
                Timer1.Start()
                Timer2.Enabled = True
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If lsView.Text = Nothing Then
                MsgBox("No report viewer", vbExclamation, "Retry")
            Else
                If lsView.SelectedIndex = 0 Then
                    'Dim pwait As New pleasewait
                    'pwait.Label1.Text = "category"
                    'pwait.category.Text = ComboBox2.Text
                    'Dim selCat1 As Integer = selCAt.SelectedIndex() + 1
                    'pwait.Show()
                    'Me.Hide()
                    'a.ShowDialog()
                    Dim viewCa As New viewReport
                    viewCa.category.Text = ComboBox1.Text
                    viewCa.ShowDialog()
                ElseIf lsView.SelectedIndex = 1 Then
                    'Dim pwait As New pleasewait
                    ''pwait.Label1.Text = "total"
                    'Dim selCat1 As Integer = selCAt.SelectedIndex() + 1
                    'Dim b As New viewReport1
                    'b.ShowDialog()
                    Dim viewCa1 As New viewReport1
                    viewCa1.ShowDialog()
                Else
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub lsView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsView.SelectedIndexChanged
        Try
            If lsView.SelectedIndex = 0 Then
                ComboBox1.Visible = True
                ComboBox2.Visible = True
            Else
                ComboBox1.Visible = False
                ComboBox2.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Dim b As Integer = 0
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            b = b + 1
            'Dim selCat1 As Integer = selCAt.SelectedIndex() + 1
            Dim selCat1 As Integer
            selCat1 = Convert.ToInt64(selCat13.Text)
            If b = b Then
                Label1.Text &= " " & b
                Label7x.Text = "Generating total report..."
                'start to query data
                
                DataGridView1.Rows.Clear()

                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM categoryReport WHERE candidate_name='" & lscandidate.Items.Item(b - 1) & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    'dtt.Rows(i)
                    DataGridView1.Rows.Add(dtt.Rows(i)("candidate_name"), dtt.Rows(i)("score"))
                Next
                cnn.Close()

                'to compute data of candidate
                REM category result will be computed in averaging
                REM formula:   categoryResult=summation/number of judges
                Dim total As Double = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    total += DataGridView1.Rows(i).Cells(1).Value
                Next

                Label2.Text = total
                Dim lab2 As Double
                lab2 = Convert.ToDouble(Label2.Text)
                Label3.Text = Val(lab2 / DataGridView1.RowCount)

                REM TO DETECT EXISTING DATA
                'get the value of category id

                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM totalReport WHERE candidate_name='" & lscandidate.Items.Item(b - 1) & "'", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                For i1 = 0 To dtt1.Rows.Count - 1
                    'dtt1.Rows(i1)
                    Label6.Text = dtt1.Rows(i1)("candidate_name")
                Next
                cnn.Close()

                If Label6.Text = lscandidate.Items.Item(b - 1) Then
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE totalReport SET score='" & Label3.Text & "' WHERE candidate_name='" & lscandidate.Items.Item(b - 1) & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                Else
                    REM TO ADD DATA TO DATABASE
                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "INSERT INTO  totalReport VALUES('" & lscandidate.Items.Item(b - 1) & "','" & Label3.Text & "')"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                End If

                If b = lscandidate.Items.Count Then
                    Label7x.Text = Nothing
                    'Timer2.Stop()
                    b = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If MsgBox("Are You sure you want to generate your total tally Report?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                Label1.Text = Nothing
                Timer2.Enabled = True
                Timer2.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub


    Private Sub selCAt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCAt.SelectedIndexChanged
        Try
            'ComboBox2.Items.Clear()
            
            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM category where category_name='" & selCAt.Text & "'", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'dtt.Rows(i)
                selCat13.Text = dtt.Rows(i)("category_id")
            Next
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

End Class