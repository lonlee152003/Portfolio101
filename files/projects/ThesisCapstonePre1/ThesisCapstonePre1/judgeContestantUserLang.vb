Imports System.Data

Public Class judgeContestantUserLang
    Private Sub lbllogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogout.Click
        'set user data as inactive from the database
        Dim sqConUpdate As New SqlClient.SqlConnection("Server=.\SQLExpress;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf;Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True")
        Dim sqCmdUpdate As New SqlClient.SqlCommand
        sqConUpdate.Open()
        sqCmdUpdate.Connection = sqConUpdate
        sqCmdUpdate.CommandText = "UPDATE userAdmin SET loginStat='inactive' WHERE username='" & txjudgeuser.Text & "'"
        sqCmdUpdate.ExecuteNonQuery()
        sqConUpdate.Close()
        Dim logi As New login
        logi.Show()
        Me.Hide()
    End Sub

    Private Sub judgeContestantUserLang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all needed data

    End Sub

    Private Sub btncandidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncandidate.Click
        If cbocategory.Text = Nothing Then
            'prompt empty textbox
            MsgBox("Select category first!", vbExclamation, "Error")
        Else
            'promt correct selection if category is not empty
            If cbocandidate.Text = Nothing Then
                MsgBox("Please select your candidate to tabulate!", vbExclamation, "Error")
            Else
                'prompt if candidate combo box is not empty
                'note: enable datagridcriteria
            End If
        End If
    End Sub

    Private Sub btncategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncategory.Click
        If cbocategory.Text = Nothing Then
            'prompt empty textbox
        Else
            'promt correct selection
            'note: select criteria inner join to category
        End If
    End Sub
End Class