Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatabase
    Public Property mConnection As SqlConnection
    Private mDataAdapter As SqlDataAdapter
    Private mCommand As SqlCommand

    Public Function QueryTable(ByVal sql As String, Optional ByVal Connection As SqlConnection = Nothing) As DataTable
        mDataAdapter = New SqlDataAdapter
        Dim dt As New DataTable
        Dim conn As SqlConnection
        If Connection IsNot Nothing Then
            conn = Connection
        Else
            conn = mConnection
        End If
        'mDataAdapter.SelectCommand.Connection = conn
        'mDataAdapter.SelectCommand.CommandText = sql
        mDataAdapter.SelectCommand = New SqlCommand(sql, conn)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            mDataAdapter.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        Return dt
    End Function

    Public Function ExecuteNonQuery(ByVal sql As String, Optional ByVal Connection As SqlConnection = Nothing) As Integer
        mCommand = New SqlCommand(sql, CType(IIf(Connection IsNot Nothing, Connection, mConnection), SqlConnection))
        If mCommand.Connection.State <> ConnectionState.Open Then mCommand.Connection.Open()
        Try
            Return mCommand.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return 0
        End Try
    End Function

    Public Function ExecuteScalar(ByVal sql As String, Optional ByVal Connection As SqlConnection = Nothing) As Object
        mCommand = New SqlCommand(sql, CType(IIf(Connection IsNot Nothing, Connection, mConnection), SqlConnection))
        If mCommand.Connection.State <> ConnectionState.Open Then mCommand.Connection.Open()
        Try
            Return mCommand.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return DBNull.Value
        End Try
    End Function

End Class
