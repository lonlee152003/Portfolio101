Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb

Public Class tallytable_others
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim login As New login
        login.Show()
        Me.Hide()
    End Sub

    Private Sub tallyTable_others_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        'chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Total Score")

        REM        sqCmda.CommandText = "SELECT criteria.criteria_name,criteria.max_points,criteria.Score FROM category LEFT JOIN criteria ON category.category_id=criteria.category_id WHERE category.category_id=" & ComboBox1.Text & " "

        cnn.Open()
        Dim daa As New OleDb.OleDbDataAdapter("SELECT totalReport_others.candidate_name,totalReport_others.score,candidate_others.group_number,candidate_others.group_name FROM totalReport_others INNER JOIN candidate_others ON totalReport_others.candidate_name=candidate_others.group_name", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1
            'candiNo = dtt.Rows(i)("username")
            Chart1.Series("Total Score").Points.AddXY(dtt.Rows(i)("group_number").ToString, dtt.Rows(i)("score").ToString)
        Next
        cnn.Close()

        'Chart1.Series("Total Score").Sort(PointSortOrder.Ascending, "Total Score")
        Chart1.DataManipulator.Sort(PointSortOrder.Ascending, "Total Score")
        Chart1.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
        Chart1.ChartAreas("ChartArea1").AxisX.Interval = 1
        Chart1.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

    End Sub
    Dim timex As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timex = timex + 1
        If timex = 1 Then
            'to loop until category


            'to loop again
            timex = 0
        End If
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub
End Class