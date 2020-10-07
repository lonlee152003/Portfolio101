﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Data.OleDb
Imports System.Data

Public Class viewReport1_others

    Private Sub viewReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsCustomers As oaReport_others = GetData()
        Dim datasource As New ReportDataSource("DataSet1", dsCustomers.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Function GetData() As oaReport_others
        Dim constr As String = "Provider=Microsoft.ACE.OLEDb.12.0;Data Source=|datadirectory|\dbase\userA.accdb;persist security info = false"
        Using con As New OleDbConnection(constr)
            Using cmd As New OleDb.OleDbCommand("Select * from totalReport_others")
                Using sda As New OleDbDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New oaReport_others()
                        sda.Fill(dsCustomers, "totalReport_others")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function
End Class