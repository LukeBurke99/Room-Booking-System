Imports MySql.Data.MySqlClient
Module ModMain

    Public ConnString As String = "server=10.2.1.26;userid=Y6701;password=RAOKVE;database=BookingFormY6701"



    ''''''''''''''''''''''''''''''''''''''''''''''''
    Public GlobalID As String = "000000"
    Public NewRecord As Boolean
    ''''''''''''''''''''''''''''''''''''''''''''''''

    Private Employee_Username As String
    Private Employee_ID As String
    Private LoadDetails As Boolean = False
    Private LoadDate As Date = "01/01/1753"
    Private LoadStartTime As String
    Private LoadEndTime As String

    Public Property GetEmployee_Username() As String
        Get
            Return Employee_Username
        End Get
        Set(value As String)
            Employee_Username = value
        End Set
    End Property

    Public Property GetEmployee_ID() As String
        Get
            Return Employee_ID
        End Get
        Set(value As String)
            Employee_ID = value
        End Set
    End Property

    Public Property GetLoadDetails() As Boolean
        Get
            Return LoadDetails
        End Get
        Set(value As Boolean)
            LoadDetails = value
        End Set
    End Property

    Public Property GetLoadDate() As Date
        Get
            Return LoadDate
        End Get
        Set(value As Date)
            LoadDate = value
        End Set
    End Property

    Public Property GetLoadStartTime() As String
        Get
            Return LoadStartTime
        End Get
        Set(value As String)
            LoadStartTime = value
        End Set
    End Property

    Public Property GetLoadEndTime() As String
        Get
            Return LoadEndTime
        End Get
        Set(value As String)
            LoadEndTime = value
        End Set
    End Property



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function GetMaxID(ByVal Table As String) As String
        Dim LastID As String = "0"
        Dim DatabaseConnection As New MySqlConnection
        Dim CmdString As String
        Dim TableEmpty As Boolean = False
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            CmdString = "SELECT COUNT(*) FROM " & Table
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()

            While Reader.Read()
                If Reader.GetString(0) = "0" Then
                    TableEmpty = True
                    LastID = "00000"

                Else
                    Reader.Dispose()
                    CmdString = "SELECT MAX(" & Table & "ID) FROM " & Table
                    Cmd = New MySqlCommand(CmdString, DatabaseConnection)

                    Reader = Cmd.ExecuteReader()
                    While Reader.Read()
                        LastID = Reader.GetString(0)
                    End While
                End If
            End While
            Reader.Dispose()
            If TableEmpty = False Then
                LastID = LastID(1) + LastID(2) + LastID(3) + LastID(4) + LastID(5)
            End If

            DatabaseConnection.Close()
        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        End Try

        Return CInt(LastID)
    End Function

    Public Function Connect_to_database() As Boolean
        Try
            Dim DatabaseConnection As New MySqlConnection(ConnString)
            DatabaseConnection.Open()
            Return True
            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try
        Return False
    End Function

End Module
