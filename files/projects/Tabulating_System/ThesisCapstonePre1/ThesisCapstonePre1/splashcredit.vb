Public Class splashcredit

    Private Sub splashcredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Dim a As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        a = a + 1
        If a = 2 Then
            b.Visible = True
            c.Visible = False
            d.Visible = False
            ee.Visible = False
            f.Visible = False
            g.Visible = False
        ElseIf a = 4 Then
            b.Visible = False
            c.Visible = True
            d.Visible = False
            ee.Visible = False
            f.Visible = False
            g.Visible = False
        ElseIf a = 6 Then
            b.Visible = False
            c.Visible = False
            d.Visible = True
            ee.Visible = False
            f.Visible = False
            g.Visible = False
        ElseIf a = 8 Then
            b.Visible = False
            c.Visible = False
            d.Visible = False
            ee.Visible = True
            f.Visible = False
            g.Visible = False
        ElseIf a = 10 Then
            b.Visible = False
            c.Visible = False
            d.Visible = False
            ee.Visible = False
            f.Visible = True
            g.Visible = False
        ElseIf a = 12 Then
            b.Visible = False
            c.Visible = False
            d.Visible = False
            ee.Visible = False
            f.Visible = False
            g.Visible = True
        ElseIf a = 14 Then
            Dim s1 As New splash1
            s1.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub g_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class