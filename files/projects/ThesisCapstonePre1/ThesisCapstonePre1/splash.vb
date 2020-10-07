Public Class splash

    Private Sub splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Dim login As New login
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub lo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lo.Click

    End Sub
End Class