Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb
Imports System.Data

Public Class viewSMSReport
    Private Sub viewReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsCustomers As keyword_SMS = GetData()
        Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Function GetData() As keyword_SMS
        Dim constr As String = "Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false"
        Using con As New OleDbConnection(constr)
            Using cmd As New OleDb.OleDbCommand("Select * from keyword_sms")
                Using sda As New OleDbDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New keyword_SMS()
                        sda.Fill(dsCustomers, "keyword_sms")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class