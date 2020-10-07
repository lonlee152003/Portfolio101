Imports System.Data.SqlClient
Imports System.Data

Public Class remItem
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to delete all items in the database. Note: All data that was deleted cannot be undo.", MsgBoxStyle.YesNo, "Reminder") = MsgBoxResult.Yes Then
            sqCon.Open()
            sqCmd.Connection = sqCon
            sqCmd.CommandText = "DELETE Items"
            sqCmd.ExecuteNonQuery()
            sqCon.Close()
            MsgBox("All records has been successfully deleted", vbInformation, "Success")
        End If
    End Sub

    Private Sub cmdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdel.Click
        If bcode.Text = Nothing Then
            MsgBox("Please enter barcode to delete one item at a time", vbCritical, "Retry")
        Else
            If MsgBox("Are you sure you want to delete this " & bcode.Text & " item in the database.", MsgBoxStyle.YesNo, "Reminder") = MsgBoxResult.Yes Then
                sqCmd.Connection = sqCon
                sqCon.Open()
                sqCmd.CommandText = "SELECT * FROM Items where Barcode='" & bcode.Text & "'"
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

                If barcod <> bcodtx Then
                    MsgBox("You are trying to delete an item that never exist on the database", vbCritical, "Retry")
                Else
                    sqCon.Open()
                    sqCmd.Connection = sqCon
                    sqCmd.CommandText = "DELETE Items where Barcode='" & bcode.Text & "'"
                    sqCmd.ExecuteNonQuery()
                    sqCon.Close()
                    MsgBox("Successfully deleted", vbInformation, "Success")
                    bcode.Text = Nothing
                End If
            End If
        End If

    End Sub

    Private Sub remItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class