Imports Microsoft.Reporting.WinForms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class viewReport_others
    Private Sub viewReport_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'catRep_others.categoryReport_others' table. You can move, or remove it, as needed.
        Me.categoryReport_othersTableAdapter.Fill(Me.catRep_others.categoryReport_others)
        Dim dsCustomers As catRep_others = GetData()
        Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Function GetData() As catRep_others
        Dim constr As String = "Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false"
        Using con As New OleDbConnection(constr)
            Using cmd As New OleDb.OleDbCommand("Select * from categoryReport_others where category_name='" & category.Text & "'")
                Using sda As New OleDbDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New catRep_others()
                        sda.Fill(dsCustomers, "categoryReport_others")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function

End Class
