Imports System.Data.SqlClient

Public Class PasswordPicker
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pw.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim yun As String
        Dim ypw As String
        Dim tipo As String
        If pw.Text = Nothing Or un.Text = Nothing Then
            MsgBox("Please fill empty field", vbCritical, "Retry")
        Else
            sqCmd.Connection = sqCon
            sqCon.Open()
            sqCmd.CommandText = "SELECT * FROM Login where username='" & un.Text & "' and pass='" & pw.Text & "'"
            Dim lrd As SqlDataReader = sqCmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()
                    yun = lrd.Item("username")
                    ypw = lrd.Item("pass")
                    tipo = lrd.Item("userType")
                End While
            End If
            sqCon.Close()

            If yun <> un.Text And ypw <> pw.Text Then
                MsgBox("user is not existing!", vbCritical, "Retry")
            ElseIf yun = un.Text And ypw = pw.Text And tipo = "admin" Then
                Dim mainx As New MainWindow
                mainx.Show()
                Me.Hide()
            ElseIf yun = un.Text And ypw = pw.Text And tipo = "cashier" Then
                Dim mainx As New cashier
                mainx.Show()
                Me.Hide()
            Else
            End If
        End If
    End Sub

    Private Sub PasswordPicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class