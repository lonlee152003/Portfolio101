Imports Microsoft.Reporting.WinForms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class viewReport
    Private Sub viewReport_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsCustomers As UserADataSet4 = GetData()
        Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Function GetData() As UserADataSet4
        Dim constr As String = "Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false"
        Using con As New OleDbConnection(constr)
            Using cmd As New OleDb.OleDbCommand("Select * from categoryReport where category_name='" & category.Text & "'")
                Using sda As New OleDbDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New UserADataSet4()
                        sda.Fill(dsCustomers, "categoryReport")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
