Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb

Public Class sampletabulate
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand
    Private Sub sampletabulate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'to put candidate name into the candidateList
            candidateList.Items.Clear()
            candidateListName.Items.Clear()

            Dim prodo2 As String
            Dim prodo3 As String

            cnn.Open()
            Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM candidate", cnn)
            Dim dtt As New DataTable
            'fill data to datatable
            daa.Fill(dtt)
            For i = 0 To dtt.Rows.Count - 1
                'dtt.Rows(i)
                prodo2 = dtt.Rows(i)("candidateno")
                candidateList.Items.Add(prodo2)
                prodo3 = dtt.Rows(i)("name")
                candidateListName.Items.Add(prodo3)
            Next
            cnn.Close()
            'add category to the combobox
            ComboBox2.Items.Clear()

            Dim prodo As String

            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
            Dim dtt1 As New DataTable
            'fill data to datatable
            daa1.Fill(dtt1)
            For i1 = 0 To dtt1.Rows.Count - 1
                'dtt1.Rows(i1)

                prodo = dtt1.Rows(i1)("category_id")
                'ComboBox1.Items.Add(prodo)
                ComboBox2.Items.Add(dtt1.Rows(i1)("category_name"))

            Next
            cnn.Close()
            'Timer1.Enabled = True
            'Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub btnTabulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTabulate.Click
        Try
            If ComboBox1.Text = "Select Category" Then
                MsgBox("Select your category first before proceed to tabulation", vbExclamation, "Selection first")
            Else

                'to check specific max length to the entered data by the user
                ListBox2.Items.Clear()
                For i As Integer = 0 To ListBox1.Items.Count - 1
                    If DataGridView2.Rows(i).Cells(2).RowIndex = i Then
                        'If DataGridView2.Rows(i).Cells(2).Value > ListBox1.Items.Item(i) Then
                        Dim agConvert As Integer 'listbox1
                        Dim agConvert1 As Integer 'dataGridView2
                        agConvert = Convert.ToInt64(ListBox1.Items.Item(i))
                        agConvert1 = Convert.ToInt64(DataGridView2.Rows(i).Cells(2).Value)
                        If agConvert >= agConvert1 Then
                            ListBox2.Items.Add("ok")
                        Else
                            ListBox2.Items.Add("error")
                        End If
                    End If
                Next

                'validate for error listbox result
                Dim errorRes
                For ie As Integer = 0 To ListBox2.Items.Count - 1
                    If ListBox2.Items.Item(ie) = "error" Then
                        errorRes = "error"
                    Else
                        'check for name click on the scoreboard
                        ''line of codes here

                    End If
                Next

                'to get the value of error from the for loop
                If errorRes = "error" Then
                    MsgBox("Unable to proceed check your given score!", vbExclamation, "Error")
                Else
                    'correct | perform addition process and update specific records
                    Dim JKo As Integer = 0
                    For JKo1 As Integer = 0 To DataGridView2.RowCount - 1
                        JKo += DataGridView2.Rows(JKo1).Cells(2).Value
                    Next
                    Label4.Text = JKo
                    Label12.Text = JKo
                    If canName.Text = Nothing Then
                        MsgBox("Please select your candidate to update your data!", vbExclamation, "Error!")
                    Else
                        '''add if else
                        'search and update to 
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "UPDATE judgescoreboard SET score='" & Label4.Text & "' WHERE candidate_name='" & canName.Text & "' And category_id='" & ComboBox1.Text & "' And judge_name='" & Label1.Text & "'"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()

                        cnn.Open()
                        Dim daa As New OleDb.OleDbDataAdapter("Select candidate_id,candidate_name,score from judgescoreboard Where category_id='" & ComboBox1.Text & "' and judge_name='" & Label1.Text & "'", cnn)
                        Dim dtt As New DataTable
                        'fill data to datatable
                        daa.Fill(dtt)
                        DataGridView1.DataSource = dtt
                        cnn.Close()

                        Label7.Text = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'SelectionForeColor = System.Drawing.SystemColors.HighlightText
        canName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        canNamex.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        judName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        GroupBox2.Visible = True
        Label7.Text = canName.Text

        Try
            PictureBox2.Visible = True
            Label13.Visible = False
           
            Dim Stream As New MemoryStream()
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "SELECT photo FROM Information WHERE candidate_id='" & canNamex.Text & "'"
            Dim image As Byte() = DirectCast(sqlcommand.ExecuteScalar(), Byte())
            Stream.Write(image, 0, image.Length)

            cnn.Close()
            Dim bitmap As New Drawing.Bitmap(Stream)

            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Image = bitmap
            'end of query
        Catch ex As Exception
            'MsgBox(ex.Message, vbExclamation, "Retry")
            PictureBox2.Visible = False
            Label13.Visible = True
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text
    End Sub

    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Try
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "UPDATE userAdmin SET loginStat='inactive' WHERE username='" & Label1.Text & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            Dim logingin As New login
            logingin.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            DataGridView2.CurrentRow.Cells(0).ReadOnly = True
            DataGridView2.CurrentRow.Cells(1).ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'ComboBox2.Items.Clear()
        
        cnn.Open()
        Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM category where category_name='" & ComboBox2.Text & "'", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1
            'dtt.Rows(i)
            ComboBox1.Text = dtt.Rows(i)("category_id")
        Next
        cnn.Close()
        'Try
        'FROM (primary table) LEFT JOIN (secondary table) ON    
        '(primary table).(field) = (secondary table).(field)

        'If ComboBox1.Text = "SELECT CATEGORY" Then
        If ComboBox1.Text = Nothing Then
            MsgBox("Select your Category!", vbExclamation, "Selection First")
        Else

            cnn.Open()
            Dim daa1 As New OleDb.OleDbDataAdapter("SELECT criteria.criteria_name,criteria.max_points,criteria.score FROM category INNER JOIN criteria ON category.category_id=criteria.category_id WHERE category.category_id='" & ComboBox1.Text & "'", cnn)
            Dim dtt1 As New DataTable
            'fill data to datatable
            daa1.Fill(dtt1)
            DataGridView2.DataSource = dtt1
            cnn.Close()


            'to select category name if the combobox is selected

            cnn.Open()
            Dim daa2 As New OleDb.OleDbDataAdapter("SELECT * FROM category WHERE category_id='" & ComboBox1.Text & "'", cnn)
            Dim dtt2 As New DataTable
            'fill data to datatable
            daa2.Fill(dtt2)
            For i2 = 0 To dtt2.Rows.Count - 1
                'dtt2.Rows(i2)
                lblSelectedcat.Text = dtt2.Rows(i2)("category_name")
                lblSelectedcat.Text = "Category you selected is: " + lblSelectedcat.Text
            Next
            cnn.Close()

            If lblSelectedcat.Text = "xCategory you selected is: SMS Poll" Then
                ''do nothing
                grTab.Enabled = False
            Else
                grTab.Enabled = True
                'to populate max score length into listbox to make max score validation
                ListBox1.Items.Clear()
                Dim catid As String

                cnn.Open()
                Dim daa3 As New OleDb.OleDbDataAdapter("SELECT * FROM criteria WHERE category_id='" & ComboBox1.Text & "'", cnn)
                Dim dtt3 As New DataTable
                'fill data to datatable
                daa3.Fill(dtt3)
                For i3 = 0 To dtt3.Rows.Count - 1
                    'dtt3.Rows(i3)
                    catid = dtt3.Rows(i3)("max_points")
                    ListBox1.Items.Add(catid)
                Next
                cnn.Close()
                'to search for data whether it exist in the judgescoreboard
                Dim catid1 As String
                Dim nameju As String

                cnn.Open()
                Dim daa4 As New OleDb.OleDbDataAdapter("SELECT * FROM judgescoreboard WHERE category_id='" & ComboBox1.Text & "' and judge_name='" & Label1.Text & "'", cnn)
                Dim dtt4 As New DataTable
                'fill data to datatable
                daa4.Fill(dtt4)
                For i4 = 0 To dtt4.Rows.Count - 1
                    'dtt4.Rows(i4)
                    catid1 = dtt4.Rows(i4)("category_id")
                    If ComboBox1.Text = catid1 Then
                        txCatidKo.Text = dtt4.Rows(i4)("category_id")
                        nameju = dtt4.Rows(i4)("judge_name")
                    End If
                Next
                cnn.Close()
                If txCatidKo.Text = ComboBox1.Text And nameju = Label1.Text Then
                Else
                    'to insert candidate name into judgescoreboard
                    For listA As Integer = 0 To candidateList.Items.Count - 1
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "INSERT INTO judgescoreboard VALUES('" & ComboBox1.Text & "','" & candidateList.Items.Item(listA) & "','" & candidateListName.Items.Item(listA) & "','" & Label1.Text & "',0)"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                    Next
                End If

                cnn.Open()
                Dim daa5 As New OleDb.OleDbDataAdapter("Select candidate_id,candidate_name,score from judgescoreboard WHERE category_id='" & ComboBox1.Text & "' and  judge_name='" & Label1.Text & "'", cnn)
                Dim dtt5 As New DataTable
                'fill data to datatable
                daa5.Fill(dtt5)
                DataGridView1.DataSource = dtt5
                cnn.Close()

            End If
        End If
        'used to count listbox element
        'Label1.Text = ComboBox1.Items.Count
        ' Catch ex As Exception
        'MsgBox(ex.Message, vbExclamation, "Retry")
        ' End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Dim timx As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try


            timx = timx + 1
            If timx = 1 Then
                Dim usename As String
                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM userAdmin where username='" & Label1.Text & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1
                    'dtt.Rows(i)
                    usename = dtt.Rows(i)("username")
                Next
                cnn.Close()

                If usename = Label1.Text Then
                    'existing account
                    
                    Dim usename1 As String
                    
                    cnn.Open()
                    Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM contestType where gameCategory='pageant'", cnn)
                    Dim dtt1 As New DataTable
                    'fill data to datatable
                    daa1.Fill(dtt1)
                    For i1 = 0 To dtt1.Rows.Count - 1
                        'dtt1.Rows(i1)
                        usename1 = dtt1.Rows(i1)("status")
                    Next
                    cnn.Close()

                    If usename1 = "Active" Then
                        'continue tabulation
                    Else
                        MsgBox("There's an error on the event e.i. the event is not set or inactive", vbExclamation, "Retry Later")
                        Dim loot As login
                        loot.Show()
                        Me.Hide()
                    End If

                Else
                    'not existing then log out
                    MsgBox("This account is not existing", vbExclamation, "Stranger Attack!")
                    Dim lout As login
                    lout.Show()
                    Me.Hide()
                End If

                timx = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

'Dim total As Integer = 0
' For i As Integer = 0 To DataGridView3.RowCount - 1
'     total += DataGridView3.Rows(i).Cells(1).Value
' Next
' txtotal.Text = total
