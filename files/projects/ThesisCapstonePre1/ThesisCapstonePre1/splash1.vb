Public Class splash1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Dim login As New splash2
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub splash1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True
    End Sub
End Class