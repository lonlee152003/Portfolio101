Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb

Public Class tallyTable
    Dim cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false")
    Dim sqlcommand As New OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    
    Private Sub tallyTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Total Score")

        cnn.Open()
        Dim daa As New OleDb.OleDbDataAdapter("SELECT totalReport.candidate_name,totalReport.score,candidate.candidateno,candidate.name FROM totalReport INNER JOIN candidate ON totalReport.candidate_name=candidate.name", cnn)
        Dim dtt As New DataTable
        'fill data to datatable
        daa.Fill(dtt)
        For i = 0 To dtt.Rows.Count - 1
            'candiNo = dtt.Rows(i)("username")
             Chart1.Series("Total Score").Points.AddXY(dtt.Rows(i)("candidateno").ToString, dtt.Rows(i)("score").ToString)
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

End Class