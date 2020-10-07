Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MainWindow
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Private Sub SwttingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwttingsToolStripMenuItem.Click

    End Sub

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim teme As Date = Now
        Dim tem As String
        tem = teme.Month & " " & teme.Day & " " & teme.Year
        TextBox10.Text = tem
        ListBox1.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        sqCmd.Connection = sqCon
        sqCon.Open()
        sqCmd.Connection = sqCon
        sqCmd.CommandText = "Select * from Items"
        Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
        If lrd.HasRows Then
            While lrd.Read()
                ListBox1.Items.Add(lrd.Item("Barcode"))
                ListBox4.Items.Add(lrd.Item("Buy_Price"))
                ListBox5.Items.Add(lrd.Item("Sell_Price"))
            End While
        End If
        sqCon.Close()
        'TODO: This line of code loads data into the 'posteaDataSet.ReciptDetails' table. You can move, or remove it, as needed.
        Me.ReciptDetailsTableAdapter.Fill(Me.posteaDataSet.ReciptDetails)
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "SELECT * FROM Items"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Items")
        DataGridView1.DataSource = ds.Tables(0)
        Me.ReportViewer1.RefreshReport()

        accko()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim cpass As New ChangePassword
        cpass.ShowDialog()
    End Sub

    Private Sub AddItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemsToolStripMenuItem.Click
        Dim cpass As New AddItem
        cpass.ShowDialog()
    End Sub

    Private Sub EditItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemsToolStripMenuItem.Click
        Dim cpass As New EditItem
        cpass.ShowDialog()
    End Sub

    Private Sub RemoveItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemsToolStripMenuItem.Click
        Dim cpass As New remItem
        cpass.ShowDialog()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Then

        Else
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Dim xbprice As String
    Dim xbtotal As String
    Dim xbtotal1 As String
    Dim ja


    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click
        viewKo()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim totali As Double = 0
        ListBox1.Items.Clear()
        ListBox4.Items.Clear()
        ListBox2.Items.Clear()
        ListBox5.Items.Clear()
        sqCmd.Connection = sqCon
        sqCon.Open()
        sqCmd.Connection = sqCon
        sqCmd.CommandText = "Select * from Items"
        Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
        If lrd.HasRows Then
            While lrd.Read()
                ListBox1.Items.Add(lrd.Item("Barcode"))
                ListBox4.Items.Add(lrd.Item("Buy_Price"))
                ListBox5.Items.Add(lrd.Item("Sell_Price"))
            End While
        End If
        sqCon.Close()

        If ComboBox1.SelectedIndex = 0 Then
            'viewKo1()
            For i As Integer = 0 To ListBox1.Items.Count - 1
                Dim teme As Date = Now
                Dim tem As String
                tem = teme.Month & " " & teme.Day & " " & teme.Year
                TextBox10.Text = tem
                Dim sqCona As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
                Dim sqCmda As New SqlClient.SqlCommand
                sqCona.Open()
                sqCmda.Connection = sqCona
                sqCmda.CommandText = "SELECT ReciptDetails.Barcode,ReciptDetails.ItemCount,ReciptDetails.ItemBuyPrice,ReciptDetails.ItemSellPrice,Recipts.ReciptDate,Recipts.ReciptTotal FROM Recipts inner JOIN ReciptDetails ON Recipts.ReciptID=ReciptDetails.ReciptID WHERE Recipts.ReciptDate='" & tem & "' and Barcode='" & ListBox1.Items.Item(i) & "'"
                Dim Adap As New SqlDataAdapter(sqCmda)
                Dim ds As New DataSet
                Adap.Fill(ds, "Recipts")
                DataGridView4.DataSource = ds.Tables(0)

                Dim subt As Double
                Dim tut As Double
                For ii As Integer = 0 To DataGridView4.RowCount - 1
                    totali += DataGridView4.Rows(ii).Cells(1).Value
                Next

                subt = Val(ListBox5.Items.Item(i) - ListBox4.Items.Item(i))
                tut = Val(subt * totali)
                'Label13.Text = tut
                ListBox2.Items.Add(tut)
                totali = 0
                subt = 0
                tut = 0
                Label6.Text = "Report for today"
            Next
            Dim paasa As Double = 0
            For xx As Integer = 0 To ListBox2.Items.Count - 1
                paasa = paasa + ListBox2.Items.Item(xx)
            Next
            Label13.Text = paasa

            Dim dsCustomers As posteaDataSet = GetData()
            Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
            Me.ReportViewer1.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                Dim teme As Date = Now
                Dim tem As String
                tem = teme.Month & " " & teme.Day & " " & teme.Year
                TextBox10.Text = tem
                Dim sqCona As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
                Dim sqCmda As New SqlClient.SqlCommand
                sqCona.Open()
                sqCmda.Connection = sqCona
                sqCmda.CommandText = "SELECT ReciptDetails.Barcode,ReciptDetails.ItemCount,ReciptDetails.ItemBuyPrice,ReciptDetails.ItemSellPrice,Recipts.ReciptDate,Recipts.ReciptTotal FROM Recipts inner JOIN ReciptDetails ON Recipts.ReciptID=ReciptDetails.ReciptID WHERE Recipts.yeer='" & ComboBox3.Text & "' and Recipts.manth='" & ComboBox2.SelectedIndex + 1 & "' and ReciptDetails.Barcode='" & ListBox1.Items.Item(i) & "'"
                Dim Adap As New SqlDataAdapter(sqCmda)
                Dim ds As New DataSet
                Adap.Fill(ds, "Recipts")
                DataGridView4.DataSource = ds.Tables(0)

                Dim subt As Double
                Dim tut As Double
                For ii As Integer = 0 To DataGridView4.RowCount - 1
                    totali += DataGridView4.Rows(ii).Cells(1).Value
                Next

                subt = Val(ListBox5.Items.Item(i) - ListBox4.Items.Item(i))
                tut = Val(subt * totali)
                'Label13.Text = tut
                ListBox2.Items.Add(tut)
                totali = 0
                subt = 0
                tut = 0
            Next
            Dim paasa As Double = 0
            For xx As Integer = 0 To ListBox2.Items.Count - 1
                paasa = paasa + ListBox2.Items.Item(xx)
            Next
            Label13.Text = paasa

            Dim dsCustomers As posteaDataSet = GetData1()
            Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
            Me.ReportViewer1.RefreshReport()
            Label6.Text = "Report for the month of " & ComboBox2.Text
        ElseIf ComboBox1.SelectedIndex = 2 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                Dim teme As Date = Now
                Dim tem As String
                tem = teme.Month & " " & teme.Day & " " & teme.Year
                TextBox10.Text = tem
                Dim sqCona As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
                Dim sqCmda As New SqlClient.SqlCommand
                sqCona.Open()
                sqCmda.Connection = sqCona
                sqCmda.CommandText = "SELECT ReciptDetails.Barcode,ReciptDetails.ItemCount,ReciptDetails.ItemBuyPrice,ReciptDetails.ItemSellPrice,Recipts.ReciptDate,Recipts.ReciptTotal FROM Recipts inner JOIN ReciptDetails ON Recipts.ReciptID=ReciptDetails.ReciptID WHERE Recipts.yeer='" & ComboBox3.Text & "' and ReciptDetails.Barcode='" & ListBox1.Items.Item(i) & "'"
                Dim Adap As New SqlDataAdapter(sqCmda)
                Dim ds As New DataSet
                Adap.Fill(ds, "Recipts")
                DataGridView4.DataSource = ds.Tables(0)

                Dim subt As Double
                Dim tut As Double
                For ii As Integer = 0 To DataGridView4.RowCount - 1
                    totali += DataGridView4.Rows(ii).Cells(1).Value
                Next

                subt = Val(ListBox5.Items.Item(i) - ListBox4.Items.Item(i))
                tut = Val(subt * totali)
                'Label13.Text = tut
                ListBox2.Items.Add(tut)
                totali = 0
                subt = 0
                tut = 0
            Next
            Dim paasa As Double = 0
            For xx As Integer = 0 To ListBox2.Items.Count - 1
                paasa = paasa + ListBox2.Items.Item(xx)
            Next
            Label13.Text = paasa

            Dim dsCustomers As posteaDataSet = GetData2()
            Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
            Me.ReportViewer1.RefreshReport()
            Label6.Text = "Report for the year " & ComboBox3.Text
        Else
            Label6.Text = "Report"
            MsgBox("No selected index", vbCritical)
        End If
    End Sub

    Public Sub viewKo()
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "SELECT * FROM Items"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Items")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Public Sub viewKo1()
        Dim teme As Date = Now
        Dim tem As String
        tem = teme.Month & " " & teme.Day & " " & teme.Year
        TextBox10.Text = tem
        Dim sqCona As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
        Dim sqCmda As New SqlClient.SqlCommand
        sqCona.Open()
        sqCmda.Connection = sqCona
        sqCmda.CommandText = "SELECT ReciptDetails.Barcode,ReciptDetails.ItemCount,ReciptDetails.ItemBuyPrice,ReciptDetails.ItemSellPrice,Recipts.ReciptDate,Recipts.ReciptTotal FROM Recipts inner JOIN ReciptDetails ON Recipts.ReciptID=ReciptDetails.ReciptID WHERE Recipts.ReciptDate='" & tem & "'"
        Dim Adap As New SqlDataAdapter(sqCmda)
        Dim ds As New DataSet
        Adap.Fill(ds, "Recipts")
        DataGridView4.DataSource = ds.Tables(0)
    End Sub

    

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click       
        Dim Str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Dim con As New SqlConnection(Str)
        Dim sqCmdUpdate As New SqlClient.SqlCommand

        'chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Sales Graph")

        con.Open()
        sqCmdUpdate.Connection = con
        If ComboBox4.Text <> Nothing And ComboBox5.Text <> Nothing Then
            sqCmdUpdate.CommandText = "SELECT * FROM Recipts where manth='" & ComboBox4.SelectedIndex + 1 & "' and yeer='" & ComboBox5.Text & "'"
            q.Visible = True
            w.Visible = True
            q.Text = ComboBox4.Text
            w.Text = ComboBox5.Text
        ElseIf ComboBox5.Text <> Nothing Then
            sqCmdUpdate.CommandText = "SELECT * FROM Recipts where   yeer='" & ComboBox5.Text & "'"
            q.Visible = False
            w.Visible = True
            q.Text = ComboBox4.Text
            w.Text = ComboBox5.Text
        Else
            sqCmdUpdate.CommandText = "SELECT * FROM Recipts where reciptDate='none'"
            q.Visible = False
            w.Visible = False
        End If
        Dim lrd2x As SqlDataReader = sqCmdUpdate.ExecuteReader()
        If lrd2x.HasRows Then
            While lrd2x.Read()
                     Chart1.Series("Sales Graph").Points.AddXY(lrd2x("ReciptID").ToString, lrd2x("ReciptTotal").ToString)
            End While
        End If
        con.Close()

        'Chart1.Series("Total Score").Sort(PointSortOrder.Ascending, "Total Score")
        'Chart1.DataManipulator.Sort(PointSortOrder.Ascending, "Sales Report")
        Chart1.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
        Chart1.ChartAreas("ChartArea1").AxisX.Interval = 1
        Chart1.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

        ComboBox4.Text = Nothing
        ComboBox5.Text = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ComboBox2.Visible = False
            ComboBox3.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ComboBox2.Enabled = True
            ComboBox2.Visible = True
            ComboBox3.Visible = True
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ComboBox2.Visible = True
            ComboBox2.Enabled = False
            ComboBox3.Visible = True
        Else
            ComboBox2.Visible = False
            ComboBox3.Visible = False
        End If
    End Sub

    Private Function GetData() As posteaDataSet
        Dim constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT * FROM ReciptDetails where Date_pass='" & TextBox10.Text & "'")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New posteaDataSet()
                        sda.Fill(dsCustomers, "ReciptDetails")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Function GetData1() As posteaDataSet
        Dim constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT * FROM ReciptDetails where manth='" & ComboBox2.SelectedIndex + 1 & "' and yeer='" & ComboBox3.Text & "'")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New posteaDataSet()
                        sda.Fill(dsCustomers, "ReciptDetails")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Function GetData2() As posteaDataSet
        Dim constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT * FROM ReciptDetails where yeer='" & ComboBox3.Text & "'")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New posteaDataSet()
                        sda.Fill(dsCustomers, "ReciptDetails")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

   
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsToolStripMenuItem.Click

    End Sub

    Private Sub AddUserAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserAdminToolStripMenuItem.Click
        Dim ausr As New addusr
        ausr.ShowDialog()
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub
    Dim uname
    Private Sub DataGridView3_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        uname = DataGridView3.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView3_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(Me.DataGridView3, e.Location)
            ContextMenuStrip1.Show(Windows.Forms.Cursor.Position)
        End If
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        Dim ax As New addusr
        ax.ShowDialog()
    End Sub

    Private Sub accko()
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True"
        Dim con As New SqlConnection(str)
        Dim com As String = "SELECT * FROM Login"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Login")
        DataGridView3.DataSource = ds.Tables(0)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        accko()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUserToolStripMenuItem.Click        
        Dim ss As New ChangePassword
        ss.op.Text = DataGridView3.CurrentRow.Cells(0).Value
        ss.ux.text = uname
        ss.ShowDialog()
    End Sub

    Private Sub DeleteUserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem1.Click
        sqCon.Open()
        sqCmd.Connection = sqCon
        sqCmd.CommandText = "DELETE Login where username='" & uname & "'"
        sqCmd.ExecuteNonQuery()
        sqCon.Close()
        MsgBox("Successfully deleted", vbInformation, "Success")
        accko()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        Dim mo As New PasswordPicker
        mo.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub DataGridView1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip2.Show(Me.DataGridView1, e.Location)
            ContextMenuStrip2.Show(Windows.Forms.Cursor.Position)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub AddStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStocksToolStripMenuItem.Click
        Dim ax As New Stocks
        ax.ShowDialog()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class