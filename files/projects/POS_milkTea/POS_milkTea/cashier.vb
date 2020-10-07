Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class cashier
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Dim xbprice As String
    Dim xbtotal As String
    Dim xbtotal1 As String
    Dim ja
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            sqCon.Open()
            sqCmd.Connection = sqCon
            sqCmd.CommandText = "SELECT * FROM Items where Barcode='" & TextBox1.Text & "'"
            Dim lrd As SqlDataReader = sqCmd.ExecuteReader()

            If lrd.HasRows Then
                While lrd.Read()
                    TextBox2.Text = lrd.Item("Item_Name")
                    TextBox3.Text = lrd.Item("Sell_Price")
                    xbtotal = lrd.Item("Sell_Price")
                    xbtotal1 = lrd.Item("Buy_Price")
                    xbprice = lrd.Item("Barcode")
                End While
            End If
            sqCon.Close()
            If TextBox2.Text <> Nothing Or TextBox3.Text <> Nothing Or TextBox4.Text <> Nothing Or TextBox1.Text <> Nothing Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sqCon.Open()
            sqCmd.Connection = sqCon
            sqCmd.CommandText = "SELECT * FROM Items where Barcode='" & TextBox1.Text & "'"
            Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
            Dim bilang As Integer
            If lrd.HasRows Then
                While lrd.Read()
                    bilang = lrd.Item("Stocks")
                End While
            End If
            sqCon.Close()

            Dim cx As Integer
            Dim cx1 As Integer
            cx = Convert.ToInt64(bilang)
            cx1 = Convert.ToInt64(TextBox9.Text)

            If cx <= 0 Then
                MsgBox("Selected items is out of stock", vbCritical, "Try another product")
            ElseIf cx1 > cx Then
                MsgBox("Stocks is greater than the requested item", vbCritical, "Try another product")
            ElseIf cx1 = 0 Then
                MsgBox("No # of item(s)", vbCritical, "Retry")
            ElseIf cx1 < 0 Then
                MsgBox("You are not allowed to assign negative value", vbCritical, "Retry")
            Else
                Dim dd As Integer
                Dim ddsum As Integer
                dd = Convert.ToInt64(TextBox9.Text)
                ddsum = cx - dd
                sqCon.Open()
                sqCmd.Connection = sqCon
                sqCmd.CommandText = "UPDATE Items SET Stocks='" & ddsum & "' WHERE Barcode='" & TextBox1.Text & "'"
                sqCmd.ExecuteNonQuery()
                sqCon.Close()

                Dim sum As Double
                Dim tb9 As Double
                tb9 = Convert.ToDouble(TextBox9.Text)
                sum = Val(xbtotal * TextBox9.Text)
                TextBox4.Text = sum
                DataGridView2.Rows.Add(xbprice, TextBox2.Text, xbtotal1, xbtotal, TextBox9.Text, sum)

                Dim total As Double = 0
                For i As Double = 0 To DataGridView2.RowCount - 1
                    total += DataGridView2.Rows(i).Cells(5).Value
                Next
                Label12.Text = total


                'no items
                Dim totalx As Double = 0
                For ix As Double = 0 To DataGridView2.RowCount - 1
                    totalx += DataGridView2.Rows(ix).Cells(4).Value
                Next

                item.Text = totalx

                Dim vata As Double
                Dim vatam As Double

                'vatamount
                vata = total * 0.12
                vatAmt.Text = vata

                'vat sales
                vatam = total - vata
                vat.Text = vatam

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If DataGridView2.Rows.Count <= 0 Then
                MsgBox("Add some item to remove")
            Else
                sqCon.Open()
                sqCmd.Connection = sqCon
                sqCmd.CommandText = "SELECT * FROM Items where Barcode='" & TextBox1.Text & "'"
                Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
                Dim bilang As Integer
                If lrd.HasRows Then
                    While lrd.Read()
                        bilang = lrd.Item("Stocks")
                    End While
                End If
                sqCon.Close()

                Dim oso As Integer
                Dim pa As Integer
                Dim ang As Integer
                oso = Convert.ToInt64(bilang)
                pa = Convert.ToInt64(it)
                ang = oso + pa

                sqCon.Open()
                sqCmd.Connection = sqCon
                sqCmd.CommandText = "UPDATE Items SET Stocks='" & ang & "' WHERE Barcode='" & TextBox1.Text & "'"
                sqCmd.ExecuteNonQuery()
                sqCon.Close()

                Dim sama As Double
                Dim sama1 As Double
                sama1 = Convert.ToDouble(Label12.Text)
                sama = sama1 - ja
                Label12.Text = sama

                Dim vata As Double
                Dim vataAmt As Double

                'vat amnt
                vataAmt = ja * 0.12

                'vat sale
                vata = Val(ja - vataAmt)

                Dim v As Double
                Dim v1 As Double
                Dim vv As Double
                Dim vv1 As Double
                v = Convert.ToDouble(vat.Text)
                vv = Convert.ToDouble(vatAmt.Text)
                'deduct vat sales
                v1 = v - vata

                'deduct vat amount
                vv1 = vv - vataAmt

                'passing values
                vat.Text = v1
                vatAmt.Text = vv1

                Dim iit As Double
                iit = Convert.ToDouble(item.Text)
                Dim iits As Double
                iits = Val(iit - it)
                item.Text = iits

                For Each row As DataGridViewRow In DataGridView2.SelectedRows
                    DataGridView2.Rows.Remove(row)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If DataGridView2.Rows.Count <= 0 Then
                MsgBox("Please add some items to print", MsgBoxStyle.Critical)
                Exit Sub
            Else
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox9.Text = Nothing
        item.Text = "0"
        vat.Text = "0"
        vatAmt.Text = "0"
        Label12.Text = "0"
        Label9.Text = "0"
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim teme As Date = Now
            Dim tem As String
            tem = teme.Month & " " & teme.Day & " " & teme.Year
            TextBox10.Text = tem
            If DataGridView2.Rows.Count <= 0 Then
                MsgBox("Please some item to print", vbCritical, "Retry")
                Exit Sub
            Else

                'to insert items
                If MsgBox("Are you sure you want to save this receipt?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim ch As Double
                    Dim ch1 As Double
                    Dim ch2 As Double
                    ch = Convert.ToDouble(Label12.Text)
                    ch1 = Convert.ToDouble(Label9.Text)
                    ch2 = Convert.ToDouble(TextBox5.Text)
                    If ch2 < ch Then
                        MsgBox("Your cash is not enough!", vbCritical, "Retry")
                    Else
                        ch1 = ch2 - ch
                        Label9.Text = ch1
                        'insert data from to reciptdetails
                        Dim araw As Date = Now
                        Dim arawconka As String
                        arawconka = araw.Month & " " & araw.Day & " " & araw.Year

                        sqCon.Open()
                        sqCmd.Connection = sqCon
                        sqCmd.CommandText = "INSERT INTO Recipts VALUES('" & arawconka & "','" & Label12.Text & "','" & araw.Month & "','" & araw.Year & "')"
                        sqCmd.ExecuteNonQuery()
                        sqCon.Close()


                        sqCon.Open()
                        sqCmd.Connection = sqCon
                        sqCmd.CommandText = "Select * from Recipts"
                        Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
                        Dim reID As Integer
                        If lrd.HasRows Then
                            While lrd.Read()
                                reID = lrd.Item("ReciptID")
                            End While
                        End If
                        sqCon.Close()

                        Dim i As Integer
                        For i = 0 To DataGridView2.Rows.Count - 1
                            Dim Barcode As String = DataGridView2.Rows(i).Cells(0).Value
                            Dim BuyPrice As String = DataGridView2.Rows(i).Cells(2).Value
                            Dim SellPrice As String = DataGridView2.Rows(i).Cells(3).Value
                            Dim ItemCount As Integer = DataGridView2.Rows(i).Cells(4).Value

                            sqCon.Open()
                            sqCmd.Connection = sqCon
                            sqCmd.CommandText = "INSERT INTO ReciptDetails VALUES('" & reID & "','" & Barcode & "','" & ItemCount & "','" & BuyPrice & "','" & SellPrice & "','" & TextBox10.Text & "','" & araw.Month & "','" & araw.Year & "')"
                            sqCmd.ExecuteNonQuery()
                            sqCon.Close()

                            sqCon.Open()
                            sqCmd.Connection = sqCon
                            sqCmd.CommandText = "INSERT INTO tempx VALUES('" & DataGridView2.Rows(i).Cells(4).Value & "','" & DataGridView2.Rows(i).Cells(1).Value & "','" & DataGridView2.Rows(i).Cells(5).Value & "')"
                            sqCmd.ExecuteNonQuery()
                            sqCon.Close()
                            If i = DataGridView2.Rows.Count - 1 Then
                                MsgBox("Saved", vbInformation, "Success")
                                'PrintDocument1.Print()
                                'open printPo
                                Dim pp As New printPo
                                pp.ShowDialog()
                            End If
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
    Dim it
    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        'ja = DataGridView2.Rows(e.RowIndex)
        ja = DataGridView2.Rows(e.RowIndex).Cells(5).Value
        it = DataGridView2.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vat.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item.Click

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then

        Else
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a As New PasswordPicker
        a.Show()
        Me.Hide()
    End Sub
End Class