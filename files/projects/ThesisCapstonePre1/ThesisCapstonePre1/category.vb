Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class category
    Dim cat
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Try
            'clear all data onlistbox
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            'to determine datagrid view at cell 1 is empty or not
            Dim grid3 As String = ""
            For i As Integer = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Rows(i).Cells(1).Value = Nothing Then
                    'empty
                    grid3 = "empty"
                End If
            Next
            If grid3 = "empty" Then
                MsgBox("Unable to proceed due to empty Max value on criteria", vbExclamation, "Error")
            Else
                'use to display column 0
                For i As Integer = 0 To DataGridView3.Rows.Count - 1
                    If Not DataGridView3.Rows(i).Cells(0).Value Is DBNull.Value Then
                        'data to add content
                        ListBox2.Items.Add(DataGridView3.Rows(i).Cells(0).Value)
                        'end
                    End If
                Next

                'use to display ccolumn 1
                For i As Integer = 0 To DataGridView3.Rows.Count - 1
                    If Not DataGridView3.Rows(i).Cells(1).Value Is DBNull.Value Then
                        'data to add content
                        ListBox1.Items.Add(DataGridView3.Rows(i).Cells(1).Value)
                        'end
                    End If
                Next

                'addition using datagridview
                'to compute datagridview content.
                Dim total As Integer = 0
                For i As Integer = 0 To DataGridView3.RowCount - 1
                    total += DataGridView3.Rows(i).Cells(1).Value
                Next
                txtotal.Text = total

                If txtotal.Text < 100 Then
                    MsgBox("The total maximum value less than 100", vbExclamation, "ERROR")
                    grcategory.Enabled = True
                ElseIf txtotal.Text > 100 Then
                    MsgBox("The total maximum value greater than 100", vbExclamation, "ERROR")
                    grcategory.Enabled = True
                Else
                    MsgBox("You got the right value.", vbOKOnly, "OK")


                    If cat_id.Text = Nothing Or cbocategory.Text = Nothing Or cbocriteria.Text = Nothing Then
                        MsgBox("Can't add data again because it is already saved on your database", vbExclamation, "Can't Add Again!")
                    Else
                        'to open table category and insert data
                        cnn.Open()
                        sqlcommand.Connection = cnn
                        sqlcommand.CommandText = "INSERT INTO category VALUES('" & cat_id.Text & "','" & cbocategory.Text & "')"
                        sqlcommand.ExecuteNonQuery()
                        cnn.Close()
                        'a code use to populate and save to database
                        For rightVal = 0 To DataGridView3.RowCount - 1
                            ListBox1.SelectedIndex = rightVal
                            ListBox2.SelectedIndex = rightVal
                            'to open table criteria and insert data
                            cnn.Open()
                            sqlcommand.Connection = cnn
                            sqlcommand.CommandText = "INSERT INTO criteria VALUES('" & cat_id.Text & "','" & ListBox2.Text & "','" & ListBox1.Text & "',0)"
                            sqlcommand.ExecuteNonQuery()
                            cnn.Close()
                        Next

                        ComboBox1.Items.Clear()
                        editCategorypo.Items.Clear()
                        DataGridView3.Rows.Clear()

                        cnn.Open()
                        Dim daa1x As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
                        Dim dttx As New DataTable
                        'fill data to datatable
                        daa1x.Fill(dttx)
                        For i = 0 To dttx.Rows.Count - 1

                            editCategorypo.Items.Add(dttx.Rows(i)("category_name"))
                            ComboBox1.Items.Add(dttx.Rows(i)("category_name"))

                        Next
                        cnn.Close()


                        'to clear all data on the textbox/combobox and even on the datagridview window
                        cat_id.Text = Nothing
                        cbocategory.Text = Nothing
                        cbocriteria.Items.Clear()
                        Dim cbocritInc As Integer = 1
                        For cbocrit As Integer = 1 To 10
                            cbocritInc += cbocritInc
                            cbocriteria.Items.Add(cbocrit)
                        Next

                    End If
                    


                    'cnn.Close()
                    cnn.Open()
                    Dim daa1 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
                    Dim dtt1 As New DataTable
                    'fill data to datatable
                    daa1.Fill(dtt1)
                    DataGridView2.DataSource = dtt1
                    cnn.Close()
                    'to view entered data criteria table
                    'cnn.Close()
                    cnn.Open()
                    Dim daa As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
                    Dim dtt As New DataTable
                    'fill data to datatable
                    daa.Fill(dtt)
                    DataGridView1.DataSource = dtt
                    cnn.Close()

                    editCategorypo.Items.Clear()
                    cnn.Open()
                    Dim daa2 As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
                    Dim dtt2 As New DataTable
                    'fill data to datatable
                    daa2.Fill(dtt2)
                    For i2 = 0 To dtt2.Rows.Count - 1

                        editCategorypo.Items.Add(dtt2.Rows(i2)("category_name"))

                    Next
                    cnn.Close()

                    '
                End If
            End If
            'to split data in datagridview
            'dgv.Rows(rowindex).Cells(columnindex).value
            'Dim x As String = DataGridView3.Rows(0).Cells(0).Value
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub btnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategory.Click

        Try
        If cbocategory.SelectedIndex = 0 Then
            If cbocategory.Text = Nothing Or cat_id.Text = Nothing Then
                MsgBox("Please fill your category id/ category name!", vbExclamation, "Empty Field")
            Else
                If MsgBox("Are you sure you want to add SMS Poll?", MsgBoxStyle.YesNo, "Yes | No") = MsgBoxResult.Yes Then
                    grclimit.Enabled = True
                    grcvalue.Enabled = True
                    'to identify the existing category_id
                    'first thing to do is to identify the content in database
                    'by creating such query
                    Dim catidxx As String
                    Dim catidxx1 As String


                    'get the value of category id
                    cnn.Open()
                    Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM category WHERE category_id='" & cat_id.Text & "'", cnn)
                    Dim dtt As New DataTable
                    'fill data to datatable
                    daa.Fill(dtt)
                    For i = 0 To dtt.Rows.Count - 1

                        catidxx = dtt.Rows(i)("category_id")
                        If cat_id.Text = catidxx Then
                            txcatid.Text = dtt.Rows(i)("category_id")
                        End If

                    Next
                    cnn.Close()


                    'to get data on txcatid and compared whether it is existed or not in the database
                    If cbocategory.Text = txCatidname.Text Then
                            MsgBox("The category id/name you entered is already existing.", vbExclamation, "Warning!")
                            grcategory.Enabled = True
                            grclimit.Enabled = False
                            grcvalue.Enabled = False
                    Else
                            grcategory.Enabled = False
                            grclimit.Enabled = True
                            grcvalue.Enabled = True
                        'to get the value of category name
                        cnn.Open()
                        Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM category WHERE category_name='" & cbocategory.Text & "'", cnn)
                        Dim dtt1 As New DataTable
                        'fill data to datatable
                        daa1.Fill(dtt1)
                        For i1 = 0 To dtt.Rows.Count - 1

                            catidxx1 = dtt.Rows(i1)("category_name")
                            If cbocategory.Text = catidxx1 Then
                                txCatidname.Text = dtt.Rows(i1)("category_name")
                            End If

                        Next
                        cnn.Close()


                        If txCatidname.Text = cbocategory.Text Then
                                MsgBox("The category id/name you entered is already existing.", vbExclamation, "Warning!")
                                grcategory.Enabled = True
                                grclimit.Enabled = False
                                grcvalue.Enabled = False
                            Else
                                grcategory.Enabled = False
                                grclimit.Enabled = True
                                grcvalue.Enabled = True
                                MsgBox("The category id is " & cat_id.Text & "", vbOKOnly, "Ok!")
                                grcvalue.Enabled = True
                                grclimit.Enabled = True
                                cat = cbocategory.Text

                                'insert data to specific tables to category
                                cnn.Open()
                                sqlcommand.Connection = cnn
                                sqlcommand.CommandText = "INSERT INTO category VALUES('" & cat_id.Text & "','" & cbocategory.Text & "')"
                                sqlcommand.ExecuteNonQuery()
                                cnn.Close()

                                'insert data to specific tables to criteria
                                cnn.Open()
                                sqlcommand.Connection = cnn
                                sqlcommand.CommandText = "INSERT INTO criteria VALUES('" & cat_id.Text & "','SMS-Enabled','100','0')"
                                sqlcommand.ExecuteNonQuery()
                                cnn.Close()
                                ' sqCmd.CommandText = "' VALUES('" & cat_id.Text & "','" & ListBox2.Text & "','" & ListBox1.Text & "',0)"

                                'to view entered data criteria table
                                cnn.Close()
                                cnn.Open()
                                Dim daa2 As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
                                Dim dtt2 As New DataTable
                                'fill data to datatable
                                daa2.Fill(dtt2)
                                DataGridView1.DataSource = dtt2
                                cnn.Close()

                                'to view data on category table
                                cnn.Close()
                                cnn.Open()
                                Dim daa3 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
                                Dim dtt3 As New DataTable
                                'fill data to datatable
                                daa3.Fill(dtt3)
                                DataGridView3.DataSource = dtt3
                                cnn.Close()

                                cbocategory.Items.Clear()
                                cbocategory.Items.Add("SMS Poll")
                                cbocategory.Text = Nothing


                                '''
                                '''
                                '''
                                'to test some codes
                                'to search for data whether it exist in the judgescoreboard
                                cnn.Open()
                                Dim cat_i As String
                                Dim daa4 As New OleDb.OleDbDataAdapter("SELECT * FROM category WHERE category_id='" & cat_id.Text & "'", cnn)
                                Dim dtt4 As New DataTable
                                'fill data to datatable
                                daa4.Fill(dtt4)
                                For i4 = 0 To dtt4.Rows.Count - 1

                                    cat_i = dtt.Rows(i4)("category_id")
                                    If cat_id.Text = cat_i Then
                                        txCatidKo.Text = dtt.Rows(i4)("category_id")
                                    End If
                                Next
                                cnn.Close()

                                If txCatidKo.Text = cat_id.Text Then
                                Else
                                    'to insert candidate name into judgescoreboard
                                    For listA As Integer = 0 To candidateList.Items.Count - 1
                                        cnn.Open()
                                        sqlcommand.Connection = cnn
                                        sqlcommand.CommandText = "INSERT INTO judgescoreboard VALUES('" & cat_id.Text & "','" & candidateList.Items.Item(listA) & "','" & candidateListName.Items.Item(listA) & "','Anyone',0)"
                                        sqlcommand.ExecuteNonQuery()
                                        cnn.Close()
                                    Next
                                End If
                                '''
                                '''
                                '''
                        End If
                    End If
                    'end of comparing data
                Else
                    MsgBox("Retry adding category again!", vbInformation, "Fill data")
                End If
            End If
        Else
            If cbocategory.Text = Nothing Or cat_id.Text = Nothing Then
                MsgBox("Please fill your category id/ category name!", vbExclamation, "Empty Field")
            Else
                'msgbox to specify confirmation on adding category
                If MsgBox("Are sure with this category data?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    'to identify the existing category_id
                    'first thing to do is to identify the content in database
                    'by creating such query
                    Dim catid As String
                    cnn.Open()
                    Dim daa5 As New OleDb.OleDbDataAdapter("SELECT * FROM category WHERE category_id='" & cat_id.Text & "'", cnn)
                    Dim dtt5 As New DataTable
                    'fill data to datatable
                    daa5.Fill(dtt5)
                    For i5 = 0 To dtt5.Rows.Count - 1

                        catid = dtt5.Rows(i5)("category_id")
                        If cat_id.Text = catid Then
                            txcatid.Text = dtt5.Rows(i5)("category_id")
                        End If
                    Next
                    cnn.Close()

                    'end of query
                    'to get data on txcatid and compared whether it is existed or not in the database
                    If txcatid.Text = cat_id.Text Then
                        MsgBox("The category id you entered is already existing.", vbExclamation, "Warning!")
                    Else
                        MsgBox("The category id is " & cat_id.Text & "", vbOKOnly, "Ok!")
                        grcategory.Enabled = True
                        grclimit.Enabled = True
                        cat = cbocategory.Text
                    End If
                    'end of comparing data
                Else
                    MsgBox("Retry adding category again!", vbInformation, "Fill data")
                End If
            End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub


    Private Sub btnClearna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearna.Click
        grcategory.Enabled = True
        grclimit.Enabled = False
        grcvalue.Enabled = False
        cbocategory.Text = Nothing
        cbocriteria.Text = Nothing
        DataGridView3.Rows.Clear()
    End Sub

    Private Sub cat_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cat_id.KeyPress
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Then

        Else
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbocategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbocategory.KeyPress
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then

        Else
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbocategory.Items.Clear()
            editCategorypo.Items.Clear()
            ComboBox1.Items.Clear()

            cnn.Open()
            Dim daa2 As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
            Dim dtt2 As New DataTable
            'fill data to datatable
            daa2.Fill(dtt2)
            For i2 = 0 To dtt2.Rows.Count - 1

                editCategorypo.Items.Add(dtt2.Rows(i2)("category_name"))
                ComboBox1.Items.Add(dtt2.Rows(i2)("category_name"))
            Next
            cnn.Close()

            '''
            '''
            'to put candidate name into the candidateList
            candidateList.Items.Clear()
            candidateListName.Items.Clear()

            cnn.Open()
            Dim daa3 As New OleDb.OleDbDataAdapter("SELECT * FROM candidate", cnn)
            Dim dtt3 As New DataTable
            'fill data to datatable
            daa3.Fill(dtt3)
            For i3 = 0 To dtt3.Rows.Count - 1

                candidateList.Items.Add(dtt3.Rows(i3)("candidateno"))
                candidateListName.Items.Add(dtt3.Rows(i3)("name"))
            Next
            cnn.Close()
            '''
            '''
            '''


            'to view entered data criteria table

            cnn.Close()
            cnn.Open()
            Dim daa4 As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
            Dim dtt4 As New DataTable
            'fill data to datatable
            daa4.Fill(dtt4)
            DataGridView1.DataSource = dtt4
            cnn.Close()

            'to view data on category table

            cnn.Close()
            cnn.Open()
            Dim daa5 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
            Dim dtt5 As New DataTable
            'fill data to datatable
            daa5.Fill(dtt5)
            DataGridView2.DataSource = dtt5
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
    'Happy coding by haxxor


    'this code is used to detect selected value of datagrid view
    'Private Sub DataGridView3_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
    '   Label1.Text = DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    'End Sub

    'code to add columns in the datagridview
    'datagridviewname.columns.add("columnname","columnname")

    'code to add rows in the datagridview
    'datagridviewname.rows.add("rowsname","rowsname")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelEditCat.Click

    End Sub

    Private Sub editCategorypo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editCategorypo.SelectedIndexChanged
        Try
            Label4.Text = editCategorypo.SelectedIndex + 1
            If editCategorypo.Text = "SMS Poll" Then
                MsgBox("You are not allowed to modify SMS Poll category due to it's static data.", vbExclamation, "Retry!")
                btnSelEditCat.Enabled = False
            Else
                btnSelEditCat.Enabled = True

                lcCrit.Items.Clear()

                cnn.Open()
                Dim daa As New OleDb.OleDbDataAdapter("SELECT * FROM category where category_name='" & editCategorypo.Text & "'", cnn)
                Dim dtt As New DataTable
                'fill data to datatable
                daa.Fill(dtt)
                For i = 0 To dtt.Rows.Count - 1

                    TextBox1.Text = dtt.Rows(i)("category_name")
                    Label4.Text = dtt.Rows(i)("category_id")
                Next
                cnn.Close()

                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("SELECT * FROM criteria where category_id='" & Label4.Text & "'", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                For i1 = 0 To dtt1.Rows.Count - 1

                    lcCrit.Items.Add(dtt1.Rows(i1)("criteria_name"))
                Next
                cnn.Close()
                'GroupBox3.Enabled = False
                editCategorypo.Enabled = True
                TextBox1.Enabled = True
                GroupBox4.Enabled = True
                DataGridView4.Visible = True
                'to view data on category table

                cnn.Open()
                Dim daa2 As New OleDb.OleDbDataAdapter("Select criteria_name,max_points from criteria where category_id='" & Label4.Text & "'", cnn)
                Dim dtt2 As New DataTable
                'fill data to datatable
                daa2.Fill(dtt2)
                DataGridView4.DataSource = dtt2
                cnn.Close()
                DataGridView4.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'addition using datagridview
            'to compute datagridview content.
            Dim totala As Integer = 0
            For ia As Integer = 0 To DataGridView4.RowCount - 1
                totala += DataGridView4.Rows(ia).Cells(1).Value
            Next
            txttutal.Text = totala
            Dim contutal As Integer
            contutal = Convert.ToInt64(txttutal.Text)

            If contutal < 100 Then
                MsgBox("The total maximum value less than 100", vbExclamation, "ERROR")
            ElseIf contutal > 100 Then
                MsgBox("The total maximum value greater than 100", vbExclamation, "ERROR")
            Else


                ''''''
                'code to update category table

                'a code use to populate and save to database
                For rightVal = 0 To DataGridView4.RowCount - 1
                    'to open table criteria and insert data
                    Dim jo
                    jo = lcCrit.Items.Item(rightVal)

                    cnn.Open()
                    sqlcommand.Connection = cnn
                    sqlcommand.CommandText = "UPDATE criteria SET criteria_name='" & DataGridView4.Rows(rightVal).Cells(0).Value & "',max_points='" & DataGridView4.Rows(rightVal).Cells(1).Value & "' WHERE criteria_name='" & jo & "' and category_id='" & Label4.Text & "'"
                    sqlcommand.ExecuteNonQuery()
                    cnn.Close()
                Next

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "UPDATE category SET category_name='" & TextBox1.Text & "' WHERE category_id='" & Label4.Text & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "UPDATE categoryReport SET category_name='" & TextBox1.Text & "' WHERE category_id='" & Label4.Text & "'"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()



                MsgBox("You got the right value.", vbOKOnly, "OK")

                'to view entered data criteria table

                cnn.Open()
                Dim daa1 As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
                Dim dtt1 As New DataTable
                'fill data to datatable
                daa1.Fill(dtt1)
                DataGridView1.DataSource = dtt1
                cnn.Close()

                'to view data on category table

                cnn.Open()
                Dim daa2 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
                Dim dtt2 As New DataTable
                'fill data to datatable
                daa2.Fill(dtt2)
                DataGridView2.DataSource = dtt2
                cnn.Close()

                editCategorypo.Text = Nothing
                TextBox1.Text = Nothing
                editCategorypo.Enabled = True
                DataGridView4.Visible = False
                GroupBox4.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub


    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Label10.Text = ComboBox1.SelectedIndex + 1

        'Dim sqCona2 As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;initial catalog=UserA;Integrated Security=True;User Instance=True")
        'Dim sqCmda2 As New SqlClient.SqlCommand
        'lcCrit.Items.Clear()
        'sqCona2.Open()
        'sqCmda2.Connection = sqCona2
        'sqCmda2.CommandText = "SELECT * FROM category where category_name='" & ComboBox1.Text & "'"
        'Dim ilrd2 As SqlDataReader = sqCmda2.ExecuteReader()
        'If ilrd2.HasRows Then
        ' While ilrd2.Read()
        'TextBox1.Text = ilrd2.Item("category_name")
        'Label10.Text = ilrd2.Item("category_id")
        'End While
        'End If
        'sqCona2.Close()
        'If editCategorypo.Text = "SMS Poll" Then
        'MsgBox("You are not allowed to modify SMS Poll category due to it's static data.", vbExclamation, "Retry!")
        'btnSelEditCat.Enabled = False
        'Else
        'btnSelEditCat.Enabled = True
        'Label10.Text = ComboBox1.SelectedIndex + 1
        'End If
    End Sub



    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub lcCrit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lcCrit.SelectedIndexChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
    Dim makkel
    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        makkel = DataGridView2.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView2_CellMouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellMouseLeave

    End Sub

    Private Sub DataGridView2_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView2, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM category where category_id='" & makkel & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM categoryReport where category_id='" & makkel & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM criteria where category_id='" & makkel & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM judgescoreboard where category_id='" & makkel & "'"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            cnn.Open()
            sqlcommand.Connection = cnn
            sqlcommand.CommandText = "DELETE FROM totalReport"
            sqlcommand.ExecuteNonQuery()
            cnn.Close()

            editCategorypo.Items.Clear()

            cnn.Open()
            Dim daa1x As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
            Dim dttx As New DataTable
            'fill data to datatable
            daa1x.Fill(dttx)
            For i = 0 To dttx.Rows.Count - 1

                editCategorypo.Items.Add(dttx.Rows(i)("category_name"))

            Next
            cnn.Close()

            'to view entered data criteria table

            cnn.Close()
            cnn.Open()
            Dim daa4 As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
            Dim dtt4 As New DataTable
            'fill data to datatable
            daa4.Fill(dtt4)
            DataGridView1.DataSource = dtt4
            cnn.Close()

            'to view data on category table

            cnn.Close()
            cnn.Open()
            Dim daa5 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
            Dim dtt5 As New DataTable
            'fill data to datatable
            daa5.Fill(dtt5)
            DataGridView2.DataSource = dtt5
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllToolStripMenuItem.Click
        Try
            If MsgBox("Are you sure you want to delete all?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM category"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM categoryReport"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM criteria"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM judgescoreboard"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                cnn.Open()
                sqlcommand.Connection = cnn
                sqlcommand.CommandText = "DELETE FROM totalReport"
                sqlcommand.ExecuteNonQuery()
                cnn.Close()

                editCategorypo.Items.Clear()

                cnn.Open()
                Dim daa1x As New OleDb.OleDbDataAdapter("SELECT * FROM category", cnn)
                Dim dttx As New DataTable
                'fill data to datatable
                daa1x.Fill(dttx)
                For i = 0 To dttx.Rows.Count - 1

                    editCategorypo.Items.Add(dttx.Rows(i)("category_name"))

                Next
                cnn.Close()
                'to view entered data criteria table

                cnn.Close()
                cnn.Open()
                Dim daa4 As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
                Dim dtt4 As New DataTable
                'fill data to datatable
                daa4.Fill(dtt4)
                DataGridView1.DataSource = dtt4
                cnn.Close()

                'to view data on category table

                cnn.Close()
                cnn.Open()
                Dim daa5 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
                Dim dtt5 As New DataTable
                'fill data to datatable
                daa5.Fill(dtt5)
                DataGridView2.DataSource = dtt5
                cnn.Close()

                MsgBox("Deleted!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub cbocriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocriteria.SelectedIndexChanged
        Try
            'declare string for the datagridview
            Dim a() As String = {"Edit Criteria 1", ""}
            Dim b() As String = {"Edit Criteria 2", ""}
            Dim c() As String = {"Edit Criteria 3", ""}
            Dim d() As String = {"Edit Criteria 4", ""}
            Dim x() As String = {"Edit Criteria 5", ""}
            Dim f() As String = {"Edit Criteria 6", ""}
            Dim g() As String = {"Edit Criteria 7", ""}
            Dim h() As String = {"Edit Criteria 8", ""}
            Dim ia() As String = {"Edit Criteria 9", ""}
            Dim j() As String = {"Edit Criteria 10", ""}

            'add string as an object of the datagridview
            Dim rows1 As Object = {a}
            Dim rows2 As Object = {a, b}
            Dim rows3 As Object = {a, b, c}
            Dim rows4 As Object = {a, b, c, d}
            Dim rows5 As Object = {a, b, c, d, x}
            Dim rows6 As Object = {a, b, c, d, x, f}
            Dim rows7 As Object = {a, b, c, d, x, f, g}
            Dim rows8 As Object = {a, b, c, d, x, f, g, h}
            Dim rows9 As Object = {a, b, c, d, x, f, g, h, ia}
            Dim rows10 As Object = {a, b, c, d, x, f, g, h, ia, j}
            Dim rowArray1 As String()
            Dim rowArray2 As String()
            Dim rowArray3 As String()
            Dim rowArray4 As String()
            Dim rowArray5 As String()
            Dim rowArray6 As String()
            Dim rowArray7 As String()
            Dim rowArray8 As String()
            Dim rowArray9 As String()
            Dim rowArray10 As String()
            'to confirm adding criteria
            If MsgBox("Are you sure you want to add " & cbocriteria.Text & " criteria", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                'lstbox selection
                If cbocriteria.SelectedIndex = 0 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray1 In rows1
                        DataGridView3.Rows.Add(rowArray1)
                    Next
                ElseIf cbocriteria.SelectedIndex = 1 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray2 In rows2
                        DataGridView3.Rows.Add(rowArray2)
                    Next
                ElseIf cbocriteria.SelectedIndex = 2 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray3 In rows3
                        DataGridView3.Rows.Add(rowArray3)
                    Next
                ElseIf cbocriteria.SelectedIndex = 3 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray4 In rows4
                        DataGridView3.Rows.Add(rowArray4)
                    Next
                ElseIf cbocriteria.SelectedIndex = 4 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray5 In rows5
                        DataGridView3.Rows.Add(rowArray5)
                    Next
                ElseIf cbocriteria.SelectedIndex = 5 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray6 In rows6
                        DataGridView3.Rows.Add(rowArray6)
                    Next
                ElseIf cbocriteria.SelectedIndex = 6 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray7 In rows7
                        DataGridView3.Rows.Add(rowArray7)
                    Next
                ElseIf cbocriteria.SelectedIndex = 7 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray8 In rows8
                        DataGridView3.Rows.Add(rowArray8)
                    Next
                ElseIf cbocriteria.SelectedIndex = 8 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray9 In rows9
                        DataGridView3.Rows.Add(rowArray9)
                    Next
                ElseIf cbocriteria.SelectedIndex = 9 Then
                    DataGridView3.Rows.Clear()
                    For Each rowArray10 In rows10
                        DataGridView3.Rows.Add(rowArray10)
                    Next
                End If
                grclimit.Enabled = True
                grcvalue.Enabled = True
                btnDone.Enabled = True
            Else
                MsgBox("Please select another criteria limit!", vbExclamation, "Select Again!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Retry")
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        'to view entered data criteria table

        cnn.Close()
        cnn.Open()
        Dim daa4 As New OleDb.OleDbDataAdapter("Select * from criteria", cnn)
        Dim dtt4 As New DataTable
        'fill data to datatable
        daa4.Fill(dtt4)
        DataGridView1.DataSource = dtt4
        cnn.Close()

        'to view data on category table

        cnn.Close()
        cnn.Open()
        Dim daa5 As New OleDb.OleDbDataAdapter("Select * from category", cnn)
        Dim dtt5 As New DataTable
        'fill data to datatable
        daa5.Fill(dtt5)
        DataGridView2.DataSource = dtt5
        cnn.Close()
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class