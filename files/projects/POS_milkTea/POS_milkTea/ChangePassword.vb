Imports System.Data.SqlClient

Public Class ChangePassword
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Private Sub btncpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncpass.Click
        If op.Text = Nothing Or np.Text = Nothing Then
            MsgBox("Don't leave empty textbox", vbExclamation, "Retry")
        Else

            'update here
            sqCon.Open()
            sqCmd.Connection = sqCon
            sqCmd.CommandText = "UPDATE Login SET username='" & op.Text & "',pass='" & np.Text & "' WHERE username='" & ux.Text & "'"
            sqCmd.ExecuteNonQuery()
            sqCon.Close()
            MsgBox("Your new password is " & np.Text, vbInformation, "Success")
            op.Text = Nothing
            np.Text = Nothing
        End If
    End Sub

    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class