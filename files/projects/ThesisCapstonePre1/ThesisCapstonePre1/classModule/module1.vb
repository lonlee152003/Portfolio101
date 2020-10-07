Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.IO
Imports System.Data

Module module1
    Public strConn As String = "Data Source=.;Initial Catalog=SMSInquiry20120123;User=sa;Password=sql123$%^" '"Dsn=MySQL;database=examSchedule;port=3306;server=127.0.0.1;uid=root;password=password"
    Public strConnFoxPro As String = ""
    Public Const strFoxProFile As String = "TEMP.DBF"
    Public timer As Boolean = False
    Public act As Boolean = False
    Public allowAllNum As Boolean = False
    Public userType As String
    Public userName As String
    Public userPassword As String
    Public comPort As String
    Public totalRequest As Integer
    Public penalty As Double
    Public configFile As String = ".\smsConfig.smsConfig"
    Public numTry As Integer = 0
    Public numVal As Integer = 0
    Public numInv As Integer = 0
    Public totProc As Integer = 0
    Public replyCount As Integer = 0
    Public mDatabase As clsDatabase
End Module

Module fileObjects
    Public objStreamReader As StreamReader
    Public objStreamWriter As StreamWriter
End Module

Module odbcObjects
    'Public objCommand As OdbcCommand
    'Public objConn As OdbcConnection
    'Public objDataReader As OdbcDataReader
    'Public objDataAdapter As OdbcDataAdapter
    Public objDataTable As DataTable
End Module

Module oledbObjects
    Public objCommandF As OleDbCommand
    Public objConnF As OleDbConnection
    Public objDataReaderF As OleDbDataReader

End Module

Module smsObjects
    Public objSMS As mCore.SMS
End Module

Module forms
    Public frm1 As New sampleSMSAPP
End Module

Module del
    Public s As String
End Module