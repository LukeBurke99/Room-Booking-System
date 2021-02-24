Imports MySql.Data.MySqlClient
Public Class clsEmployee
    Inherits clsCustomer
    Private StartDate As String
    Private EndDate As String
    Private UserCanLogon As Boolean
    Private Username As String
    Private Password As String


    Public Property EmployeeStartDate() As String
        Get
            Return StartDate
        End Get
        Set(value As String)
            StartDate = value
        End Set
    End Property

    Public Property EmployeeEndDate() As String
        Get
            Return EndDate
        End Get
        Set(value As String)
            EndDate = value
        End Set
    End Property

    Public Property EmployeeUserCanLogon() As Boolean
        Get
            Return UserCanLogon
        End Get
        Set(value As Boolean)
            UserCanLogon = value
        End Set
    End Property

    Public Property EmployeeUsername() As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property EmployeePassword() As String
        Get
            Return Password
        End Get
        Set(value As String)
            Password = value
        End Set
    End Property

    Public Function Login(ByVal _user As String, ByVal _pass As String) As Boolean
        ' Select the Employee database for me.usercode and me.password and AllowtoLogon field = true
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "SELECT Password FROM Employee WHERE UserLogon = TRUE AND Username = '" & _user & "';"
            Dim cmd As New MySqlCommand(CmdString, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = cmd.ExecuteReader()
            If Reader.Read() Then
                If _pass = Reader.GetString(0) Then
                    Return True
                End If
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try

        Return False
    End Function

    Public Function GetEmployeeID(ByVal _user As String) As String
        Dim DatabaseConnection As New MySqlConnection
        Dim _ID_ As String = ""
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "SELECT EmployeeID FROM Employee WHERE Username = '" & _user & "';"
            Dim cmd As New MySqlCommand(CmdString, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = cmd.ExecuteReader()
            If Reader.Read() Then
                _ID_ = Reader.GetString(0)
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try
        Return _ID_
    End Function

    Public Overrides Function PersonUpdate() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "INSERT INTO Employee(EmployeeID, FirstName, Surname, Address, Postcode, TelephoneNumber, EmailAddress, StartDate, EndDate, Notes, UserLogon, Username, Password) VALUES(@EmployeeID, @FirstName, @Surname, @Address, @Postcode, @TelephoneNumber, @EmailAddress, @StartDate, @EndDate, @Notes, @UserLogon, @Username, @Password);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
            With Cmd
                .Parameters.AddWithValue("@EmployeeID", Me.PersonID)
                .Parameters.AddWithValue("@FirstName", Me.PersonFirstName)
                .Parameters.AddWithValue("@Surname", Me.PersonSurname)
                .Parameters.AddWithValue("@Address", Me.PersonAddress)
                .Parameters.AddWithValue("@Postcode", Me.PersonPostcode)
                .Parameters.AddWithValue("@TelephoneNumber", Me.PersonTelephoneNumber)
                .Parameters.AddWithValue("@EmailAddress", Me.PersonAddress)
                .Parameters.AddWithValue("@StartDate", Me.EmployeeStartDate)
                .Parameters.AddWithValue("@EndDate", Me.EmployeeEndDate)
                .Parameters.AddWithValue("@Notes", Me.PersonNotes)
                .Parameters.AddWithValue("@UserLogon", Me.EmployeeUserCanLogon)
                .Parameters.AddWithValue("@Username", Me.EmployeeUsername)
                .Parameters.AddWithValue("@Password", Me.EmployeePassword)
                .ExecuteNonQuery()
            End With
            Return True

            DatabaseConnection.Close()
        Catch Ex As MySqlException
            Me.PersonErrorDescription = Ex.Message.ToString
            Return False
        Finally
            DatabaseConnection.Dispose()
        End Try
    End Function

    Public Overrides Sub PersonSetUpDataGridView(ByRef Grid As Object)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource
            Dim Query As String = "SELECT * FROM Employee WHERE EmployeeID != '1ETEST';"
            Dim Cmd As New MySqlCommand(Query, DatabaseConnection)

            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Grid.DataSource = bSource
            SDA.Update(dbDataSet)

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            DatabaseConnection.Dispose()
        End Try
    End Sub

    Public Sub GetEmployeeDetails()
        Dim DatabaseConnection As New MySqlConnection
        Me.PersonID = GlobalID
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT FirstName, Surname, Address, Postcode, TelephoneNumber, EmailAddress, StartDate, EndDate, Notes, UserLogon, Username, Password FROM Employee WHERE EmployeeID = '" & Me.PersonID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Me
                    .PersonFirstName = Reader.GetString(0)
                    .PersonSurname = Reader.GetString(1)
                    .PersonAddress = Reader.GetString(2)
                    .PersonPostcode = Reader.GetString(3)
                    .PersonTelephoneNumber = Reader.GetString(4)
                    .PersonEmailAddress = Reader.GetString(5)
                    .EmployeeStartDate = Reader.GetDateTime(6)
                    .PersonNotes = Reader.GetString(8)
                    .EmployeeUserCanLogon = Reader.GetBoolean(9)
                    .EmployeeUsername = Reader.GetString(10)
                    .EmployeePassword = Reader.GetString(11)
                End With
                Try
                    Me.EmployeeEndDate = Reader.GetDateTime(7)
                Catch ex As Exception

                End Try
            End While

            Reader.Dispose()
            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            DatabaseConnection.Dispose()
        End Try

    End Sub
    Public Overrides Function SaveChanges() As Boolean

        Dim DatabaseConnection As New MySqlConnection
        Me.PersonID = GlobalID

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "UPDATE Employee SET FirstName = @FirstName, Surname = @Surname, Address = @Address, Postcode = @Postcode, TelephoneNumber = @TelephoneNumber, EmailAddress = @EmailAddress, StartDate = @StartDate, EndDate = @EndDate, Notes = @Notes, UserLogon = @UserLogon, Username = @Username, Password = @Password WHERE EmployeeID = '" & Me.PersonID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@FirstName", Me.PersonFirstName)
                .Parameters.AddWithValue("@Surname", Me.PersonSurname)
                .Parameters.AddWithValue("@Address", Me.PersonAddress)
                .Parameters.AddWithValue("@Postcode", Me.PersonPostcode)
                .Parameters.AddWithValue("@TelephoneNumber", Me.PersonTelephoneNumber)
                .Parameters.AddWithValue("@EmailAddress", Me.PersonEmailAddress)
                .Parameters.AddWithValue("@StartDate", Me.EmployeeStartDate)
                .Parameters.AddWithValue("@EndDate", Me.EmployeeEndDate)
                .Parameters.AddWithValue("@Notes", Me.PersonNotes)
                .Parameters.AddWithValue("@UserLogon", Me.EmployeeUserCanLogon)
                .Parameters.AddWithValue("@Username", Me.EmployeeUsername)
                .Parameters.AddWithValue("@Password", Me.EmployeePassword)

                .ExecuteNonQuery()
            End With
            Return True

            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.PersonErrorDescription = ex.Message.ToString
            Return False
        End Try
    End Function
    Public Overrides Function DeleteRecord() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Me.PersonID = GlobalID
        Dim Delete As Boolean

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            '''''''''''''''             CHECK IF employee is part of a record in Booking TABLE             '''''''''''''''
            Dim cmdstring As String = "SELECT * FROM Employee WHERE EXISTS (SELECT * FROM Booking WHERE EmployeeID = '" & Me.PersonID & "');"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            If Reader.Read() = True Then
                Delete = False
            Else
                Delete = True
            End If

            DatabaseConnection.Close()
            DatabaseConnection.Dispose()

            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            cmdstring = "DELETE FROM Employee WHERE EmployeeID = '" & Me.PersonID & "';"
            Dim Cmd2 As New MySqlCommand(cmdstring, DatabaseConnection)

            If Delete = True Then ' it is not part of a record in the booking table
                Cmd2.ExecuteNonQuery()
                Return True
            Else
                Me.PersonErrorDescription = "Employee cannot be removed because they are part of another table."
                Return False
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.PersonErrorDescription = ex.Message.ToString
            Return False
        End Try

    End Function
End Class
