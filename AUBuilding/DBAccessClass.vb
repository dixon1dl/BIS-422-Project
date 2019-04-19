Imports System.Data.Odbc
Public Class DBAccessClass
    Public DBCommand As OdbcCommand
    Public Const ConnectStr As String = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=141.209.241.44;DATABASE=BIS422_38;USER=machine;PASSWORD=mypass;OPTION=3"
    Public DBConnection As New OdbcConnection(ConnectStr)
    Public DBDataAdapter As OdbcDataAdapter
    Public DBDataTable As DataTable
    Public Params As New List(Of OdbcParameter)
    Public ErrorFlag As Boolean
    Public RecordCount As Integer
    Public ReturnValue As Integer

    Public Sub ExecuteQuery(QueryString As String)
        RecordCount = 0

        Try
            DBConnection.Open()
            ErrorFlag = False

            DBCommand = New OdbcCommand(QueryString, DBConnection)

            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next

            Params.Clear()

            DBDataTable = New DataTable
            DBDataAdapter = New OdbcDataAdapter(DBCommand)

            RecordCount = DBDataAdapter.Fill(DBDataTable)
        Catch ex As Exception
            ErrorFlag = True
            Throw ex
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    Public Sub ExecuteNonQuery(QueryString As String)
        ReturnValue = 0
        ErrorFlag = False

        Try
            DBConnection.Open()

            DBCommand = New OdbcCommand(QueryString, DBConnection)

            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next

            Params.Clear()

            ReturnValue = DBCommand.ExecuteNonQuery
        Catch ex As Exception
            ErrorFlag = True
            Throw ex
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OdbcParameter(Name, Value)

        Params.Add(NewParam)
    End Sub
End Class
