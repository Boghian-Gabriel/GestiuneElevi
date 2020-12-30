Imports System.Data.SqlClient
Imports System.Data

'clasa pentru conectarea la baza de date si pentru a executa query-uri
Public Class Connection
    'connection to database
    'Static metroh connect to database
    Public connection As New SqlConnection

    'implicit are valoarea TRUE
    Dim result As Boolean
    Dim strConnection As String

    'FOR EXECUTING PROGRAM (.text quey,  .StoredProcedure etc)
    Dim command As SqlCommand

    'GETTING DATA FROM DATABASE
    Dim dataAdapter As SqlDataAdapter

    'For cyrstal reproting 
    Dim dataSet As DataSet
    'to hold the data  from database
    Dim dataTable As DataTable

    ' Query parameters - list of SqlParameter
    Dim params As New List(Of SqlParameter)

    Dim paramsTable As New List(Of SqlDataAdapter)

#Region "Open DataBase"
    Public Function OpenDB() As Boolean

        Try
            If connection.State = ConnectionState.Closed Then

                'connect to database
                strConnection = "Server = DESKTOP-KB381VD\SQLEXPRESS; Database= GestiuneElevi; Integrated Security = TRUE"
                connection.ConnectionString = strConnection

                'database conn open
                connection.Open()
                result = True

            End If
        Catch ex As Exception
            result = False
            MsgBox(ex.Message)

        Finally
            connection.Close()
        End Try

        'return true or false 
        Return result

    End Function

#End Region

#Region "Close DataBase"
    Public Function CloseDB() As Boolean

        Try
            If connection.State = ConnectionState.Closed Then

                'connect to database
                strConnection = "Server = DESKTOP-KB381VD\SQLEXPRESS; Database= GestiuneElevi; Integrated Security = TRUE"
                connection.ConnectionString = strConnection

                'database conn open
                connection.Close()
                result = True

            End If
        Catch ex As Exception
            result = False
            MsgBox(ex.Message)

        Finally
            connection.Close()
        End Try

        'return true or false 
        Return result

    End Function

#End Region

#Region "Execute Query"
    'Execute query
    Public Function ExecuteMySql(ByVal SQL As String) As Boolean

        Try
            'Create DB command
            command = New SqlCommand(SQL, connection)
            connection.Open()

            'Load params into db command
            'pentru fiecare parametru creaza o proprietate Add
            params.ForEach(Sub(p) command.Parameters.Add(p))
            'command.Parameters.Add("@ID", ID)

            'Clear params
            params.Clear()

            result = True
            command.ExecuteNonQuery()
            ' connection.Close()

        Catch ex As Exception
            result = False
            MsgBox(ex.Message)

        Finally
            connection.Close()

        End Try

        'return true or false
        Return result
    End Function
#End Region

#Region "Execute ExistRegister"
    'Execute query
    Public Function ExistRegister(ByVal SQL As String) As Boolean

        Try
            'Create DB command
            dataAdapter = New SqlDataAdapter(SQL, connection)
            dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            connection.Open()
            If (dataTable.Rows.Count >= 1) Then
                MessageBox.Show("Exista deja aceasta inregistrare in baza de date. Te rog sa verifici inca odata campurile pe care le-ai completat!", "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            'Load params into db command
            'pentru fiecare parametru creaza o proprietate Add
            params.ForEach(Sub(p) command.Parameters.Add(p))
            'command.Parameters.Add("@ID", ID)
            'Clear params
            params.Clear()
            result = True

        Catch ex As Exception
            result = False
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        'return true or false
        Return result
    End Function
#End Region

#Region "Add Parameters when using query for insert, update"
    'Add Param
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object)

        Dim NewParam As New SqlParameter(Name, Value)
        params.Add(NewParam)

    End Sub
#End Region


#Region "Fill database in dataGridView"
    'Display datatable
    Public Function GenerateResultSet(ByVal SQL As String) As DataTable

        dataAdapter = New SqlDataAdapter
        dataTable = New DataTable

        Try
            'SQL QUERY FROM DATA TO DATABASE
            'FOR EXECUTING PROGRAM
            command = New SqlCommand(SQL, connection)


            connection.Open()
            dataAdapter.SelectCommand = command

            'fill data in your datatable
            dataAdapter.Fill(dataTable)
            connection.Close()

            'return the value in datatable
            ' Return dataTable
        Catch ex As Exception

            'throw message
            MsgBox(ex.Message)
            dataTable = Nothing
            Return dataTable

        Finally

            'database conn close
            connection.Close()

        End Try

        'return DATATABLE
        Return dataTable
    End Function
#End Region

#Region "Execute query DataSet for CrystalReport "
    'Display datatable
    Public Function CrystalReportGenerateResultSet(ByVal SQL As String, ByVal tableName As String) As DataSet

        dataAdapter = New SqlDataAdapter
        dataSet = New DataSet
        Try
            'SQL QUERY FROM DATA TO DATABASE
            'FOR EXECUTING PROGRAM
            command = New SqlCommand(SQL, connection)
            connection.Open()
            dataAdapter.SelectCommand = command

            'DataSet si tabela
            dataAdapter.Fill(dataSet, tableName)

            'paramsTable.ForEach(Sub(tb) dataAdapter.Fill(tb))

            connection.Close()

            'return the value in DataSet
            ' Return dataSet
        Catch ex As Exception

            'throw message
            MsgBox(ex.Message)
            dataTable = Nothing
            Return dataSet

        Finally

            'database conn close
            connection.Close()

        End Try

        'return DataSet
        Return dataSet
    End Function
#End Region

End Class
