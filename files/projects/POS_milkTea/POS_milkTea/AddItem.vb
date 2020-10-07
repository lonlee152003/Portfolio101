Imports System.Data
Imports System.Data.SqlClient

Public Class AddItem

    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        If bcode.Text = Nothing Or iname.Text = Nothing Or sprice.Text = Nothing Or bprice.Text = Nothing Then
            MsgBox("All field's are required to fill required data", vbCritical, "Retry")
        Else
            If MsgBox("Are you sure you want to add this new item?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                sqCmd.Connection = sqCon
                sqCon.Open()
                sqCmd.CommandText = "SELECT * FROM Items Where Barcode='" & bcode.Text & "'"
                Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
                Dim barcod As Integer
                If lrd.HasRows Then
                    While lrd.Read()
                        barcod = lrd.Item("Barcode")
                    End While
                End If
                sqCon.Close()
                Dim bcodtx As Integer
                bcodtx = Convert.ToInt64(bcode.Text)

                If barcod = bcodtx Then
                    MsgBox("Existing barcode", vbCritical, "Retry")
                Else
                    If Val(bprice.Text) > Val(sprice.Text) Then
                        MsgBox("The selling price is less than the original price", vbCritical, "Retry")
                    Else
                        sqCon.Open()
                        sqCmd.Connection = sqCon
                        sqCmd.CommandText = "INSERT INTO Items VALUES('" & bcode.Text & "','" & iname.Text & "','" & bprice.Text & "','" & sprice.Text & "','0')"
                        sqCmd.ExecuteNonQuery()
                        sqCon.Close()
                        bcode.Text = Nothing
                        iname.Text = Nothing
                        bprice.Text = Nothing
                        sprice.Text = Nothing
                        MsgBox("Success", vbInformation)
                    End If
                    End If
            End If
        End If
    End Sub

    Private Sub bcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bcode.KeyPress
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Then

        Else
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub bcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcode.TextChanged

    End Sub

    Private Sub bprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bprice.KeyPress
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then

        Else
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub bprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprice.TextChanged

    End Sub

    Private Sub sprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sprice.KeyPress
        'to specify specific chars to be inputted
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then

        Else
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprice.TextChanged

    End Sub

    Private Sub AddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class