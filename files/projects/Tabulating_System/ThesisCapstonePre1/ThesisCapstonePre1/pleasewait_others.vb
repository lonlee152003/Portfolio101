Imports System.Data
Imports System.Data.SqlClient

Public Class pleasewait_others


    Private Sub pleasewait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\found.000\Documents\Visual Studio 2010\Projects\ThesisCapstonePre1\ThesisCapstonePre1\dbase\UserA.mdf; Database=UserA; Trusted_Connection=Yes;Integrated Security=True;User Instance=True"
        Dim con As New SqlConnection(str)
        con.Open()
        Dim com As String = "Select * from categoryReport_others"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "categoryReport_others")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        Timer1.Interval = 100
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Dim login As New viewReport
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class