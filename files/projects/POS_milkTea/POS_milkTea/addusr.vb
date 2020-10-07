Imports System.Data.SqlClient 
Imports System.Windows.Forms
Imports System.Data
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms.DataVisualization.Charting
Public Class addusr
    Dim sqCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\POS_milkTea\POS_milkTea\postea.mdf;Integrated Security=True;User Instance=True")
    Dim sqCmd As New SqlCommand
    Private Sub addusr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btncpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncpass.Click
        If op.Text = Nothing Or np.Text = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("Empty field", vbCritical, "Retry")
        Else
            sqCon.Open()
            sqCmd.Connection = sqCon
            sqCmd.CommandText = "Select * from Login WHERE username='" & op.Text & "'"
            Dim lrdx As SqlDataReader = sqCmd.ExecuteReader()
            Dim barcod
            If lrdx.HasRows Then
                While lrdx.Read()
                    barcod = lrdx.Item("username")
                End While
            End If
            sqCon.Close()

            If barcod = op.Text Then
                MsgBox("Existing username", vbCritical, "Retry")
            Else
                sqCon.Open()
                sqCmd.Connection = sqCon
                sqCmd.CommandText = "INSERT INTO Login VALUES('" & op.Text & "','" & np.Text & "','" & ComboBox1.Text & "')"
                sqCmd.ExecuteNonQuery()
                sqCon.Close()
                MsgBox("Success")
                op.Text = Nothing
                np.Text = Nothing
                ComboBox1.Text = Nothing
            End If
        End If
    End Sub
End Class