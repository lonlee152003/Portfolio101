Imports System.Data.SqlClient

Public Class printPo
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Private Sub printPo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim det As New Date
        det = Now
        Label3.Text = det

        sqCon.Open()
        sqCmd.Connection = sqCon
        sqCmd.CommandText = "SELECT * FROM tempx"
        Dim lrd As SqlDataReader = sqCmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                'TextBox2.Text = lrd.Item("Item_Name")
                Z1.Items.Add(lrd.Item("qty"))
                Z2.Items.Add(lrd.Item("product"))
                Z3.Items.Add(lrd.Item("price"))
            End While
        End If
        sqCon.Close()
        Dim qty As Double
        Dim tot As Double

        For xtra As Integer = 0 To Z1.Items.Count - 1
            Dim app As Double
            app = Convert.ToDouble(Z1.Items.Item(xtra))
            qty += app

            Dim app1 As Double
            app1 = Convert.ToDouble(Z3.Items.Item(xtra))
            tot += app1
        Next
        Label8.Text = qty
        Label10.Text = tot

        Dim vata As Double
        Dim vatam As Double

        'vatamount
        vata = tot * 0.12
        Label17.Text = vata

        'vat sales
        vatam = tot - vata
        Label15.Text = vatam

        sqCon.Open()
        sqCmd.Connection = sqCon
        sqCmd.CommandText = "DELETE tempx"
        sqCmd.ExecuteNonQuery()
        sqCon.Close()
    End Sub

    Private Sub Z1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Z1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        PrintForm1.Print()
    End Sub
End Class