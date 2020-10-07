Imports System.Data.SqlClient

Public Class Stocks
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Dim sto As Integer
    Private Sub Stocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        sqCmd.Connection = sqCon
        sqCon.Open()
        sqCmd.CommandText = "SELECT * FROM Items"
        Dim lrd As SqlDataReader = sqCmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                ComboBox1.Items.Add(lrd.Item("Item_Name"))
                sto = lrd.Item("Stocks")
            End While
        End If
        sqCon.Close()
    End Sub

    Private Sub btncpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncpass.Click
        REM sex
        REM iyot
        REM penis
        REM bag ina
        REM coitus interruptus
        REM jonelle carig yapit

        sqCmd.Connection = sqCon
        sqCon.Open()
        sqCmd.CommandText = "SELECT * FROM Items where Item_Name='" & ComboBox1.Text & "'"
        Dim lrd As SqlDataReader = sqCmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                sto = lrd.Item("Stocks")
            End While
        End If
        sqCon.Close()

        Dim tut As Integer
        Dim tut1 As Integer
        Dim tut2 As Integer
        tut = Convert.ToInt64(sto)
        tut1 = Convert.ToInt64(np.Text)
        tut2 = tut + tut1

        sqCon.Open()
        sqCmd.Connection = sqCon
        sqCmd.CommandText = "UPDATE Items SET Stocks='" & tut2 & "' WHERE Item_Name='" & ComboBox1.Text & "'"
        sqCmd.ExecuteNonQuery()
        sqCon.Close()
        MsgBox("Success")

        ComboBox1.Items.Clear()
        sqCmd.Connection = sqCon
        sqCon.Open()
        sqCmd.CommandText = "SELECT * FROM Items"
        Dim lrdx As SqlDataReader = sqCmd.ExecuteReader()

        If lrdx.HasRows Then
            While lrdx.Read()
                ComboBox1.Items.Add(lrdx.Item("Item_Name"))
                REM sto = lrdx.Item("Stocks")
            End While
        End If
        sqCon.Close()

        np.Text = Nothing
    End Sub
End Class