Imports MySql.Data.MySqlClient
Public Class clsCustomer
    Protected ID As String
    Protected FirstName As String
    Protected Surname As String
    Protected Address As String
    Protected Postcode As String
    Protected TelephoneNumber As String
    Protected EmailAddress As String
    Protected Notes As String
    Protected ErrorDesc As String
    Protected Record As Boolean

    Public Property PersonErrorDescription() As String
        Get
            Return ErrorDesc
        End Get
        Set(value As String)
            ErrorDesc = value
        End Set
    End Property

    Public Property PersonID() As String
        Get
            Return ID
        End Get
        Set(value As String)
            ID = value
        End Set
    End Property

    Public Property PersonFirstName() As String
        Get
            Return FirstName
        End Get
        Set(value As String)
            FirstName = value
        End Set
    End Property

    Public Property PersonSurname() As String
        Get
            Return Surname
        End Get
        Set(value As String)
            Surname = value
        End Set
    End Property

    Public Property PersonAddress() As String
        Get
            Return Address
        End Get
        Set(value As String)
            Address = value
        End Set
    End Property

    Public Property PersonPostcode() As String
        Get
            Return Postcode
        End Get
        Set(value As String)
            Postcode = value
        End Set
    End Property

    Public Property PersonTelephoneNumber() As String
        Get
            Return TelephoneNumber
        End Get
        Set(value As String)
            TelephoneNumber = value
        End Set
    End Property

    Public Property PersonEmailAddress() As String
        Get
            Return EmailAddress
        End Get
        Set(value As String)
            EmailAddress = value
        End Set
    End Property

    Public Property PersonNotes() As String
        Get
            Return Notes
        End Get
        Set(value As String)
            Notes = value
        End Set
    End Property

    Public Property NewRecord() As Boolean
        Get
            Return Record
        End Get
        Set(value As Boolean)
            Record = value
        End Set
    End Property

    Public Overridable Function PersonUpdate() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "INSERT INTO Customer(CustomerID, FirstName, Surname, Address, Postcode, TelephoneNumber, EmailAddress, Notes) VALUES(@CustomerID, @FirstName, @Surname, @Address, @Postcode, @TelephoneNumber, @EmailAddress, @Notes);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@CustomerID", Me.PersonID)
                .Parameters.AddWithValue("@FirstName", Me.PersonFirstName)
                .Parameters.AddWithValue("@Surname", Me.PersonSurname)
                .Parameters.AddWithValue("@Address", Me.PersonAddress)
                .Parameters.AddWithValue("@Postcode", Me.PersonPostcode)
                .Parameters.AddWithValue("@TelephoneNumber", Me.PersonTelephoneNumber)
                .Parameters.AddWithValue("@EmailAddress", Me.PersonEmailAddress)
                .Parameters.AddWithValue("@Notes", Me.PersonNotes)

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

    Public Overridable Sub PersonSetUpDataGridView(ByRef Grid As Object)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource
            Dim Query As String = "SELECT * FROM Customer WHERE CustomerID != '1CTEST';"
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

    Public Sub GetClientDetails()
        Dim DatabaseConnection As New MySqlConnection
        Me.PersonID = GlobalID
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            Dim cmdString As String = "SELECT FirstName, Surname, Address, Postcode, TelephoneNumber, EmailAddress, Notes FROM Customer WHERE CustomerID = '" & Me.PersonID & "';"
            Dim Cmd As New MySqlCommand(cmdString, DatabaseConnection)
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
                    .PersonNotes = Reader.GetString(6)
                End With
            End While

            Reader.Dispose()
            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally

            DatabaseConnection.Dispose()
        End Try
    End Sub

    Public Overridable Function SaveChanges() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Me.PersonID = GlobalID

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            ' "UPDATE Food SET Name = @Name, Description = @Description, Price = @Price, Notes = @Notes WHERE FoodID = '" & Me.FoodID & "';"
            Dim cmdstring As String = "UPDATE Customer SET FirstName = @FirstName, Surname = @Surname, Address = @Address, Postcode = @Postcode, TelephoneNumber = @TelephoneNumber, EmailAddress = @EmailAddress, Notes = @Notes WHERE CustomerID = '" & Me.PersonID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@FirstName", Me.PersonFirstName)
                .Parameters.AddWithValue("@Surname", Me.PersonSurname)
                .Parameters.AddWithValue("@Address", Me.PersonAddress)
                .Parameters.AddWithValue("@Postcode", Me.PersonPostcode)
                .Parameters.AddWithValue("@TelephoneNumber", Me.PersonTelephoneNumber)
                .Parameters.AddWithValue("@EmailAddress", Me.PersonEmailAddress)
                .Parameters.AddWithValue("@Notes", Me.PersonNotes)

                .ExecuteNonQuery()
            End With
            Return True
            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.PersonErrorDescription = ex.Message.ToString
            Return False
        End Try
    End Function

    Public Overridable Function DeleteRecord() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Me.PersonID = GlobalID
        Dim Delete As Boolean

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            '''''''''''''''             CHECK IF client is part of a record in Booking TABLE             '''''''''''''''
            Dim cmdstring As String = "SELECT * FROM Customer WHERE EXISTS (SELECT * FROM Booking WHERE CustomerID = '" & Me.PersonID & "');"
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
            cmdstring = "DELETE FROM Customer WHERE CustomerID = '" & Me.PersonID & "';"
            Dim Cmd2 As New MySqlCommand(cmdstring, DatabaseConnection)

            If Delete = True Then ' it is not part of a record in the booking table
                Cmd2.ExecuteNonQuery()
                Return True
            Else
                Me.PersonErrorDescription = "Customer cannot be removed because they are part of another table."
                Return False
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.PersonErrorDescription = ex.Message.ToString
            Return False
        End Try

    End Function
End Class
