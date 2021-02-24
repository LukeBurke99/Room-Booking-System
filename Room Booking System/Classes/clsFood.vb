Imports MySql.Data.MySqlClient

Public Class clsFood

    Private ID As String
    Private Name As String
    Private Description As String
    Private Price As Single
    Private Notes As String
    Private ErrorDesc As String
    Private Record As Boolean

    Public Property ErrorDescription() As String
        Get
            Return ErrorDesc
        End Get
        Set(value As String)
            ErrorDesc = value
        End Set
    End Property

    Public Property FoodID() As String
        Get
            Return ID
        End Get
        Set(value As String)
            ID = value
        End Set
    End Property

    Public Property FoodName() As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property FoodDescription() As String
        Get
            Return Description
        End Get
        Set(value As String)
            Description = value
        End Set
    End Property

    Public Property FoodPrice() As Single
        Get
            Return Price
        End Get
        Set(value As Single)
            Price = value
        End Set
    End Property

    Public Property FoodNotes() As String
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

    Public Function Update() As Boolean
        ' connecting to the BookingFormY6701 database and adding things to the Customer table
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "INSERT INTO Food(FoodID, Name, Description, Price, Notes) VALUES(@FoodID, @Name, @Description, @Price, @Notes);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@FoodID", Me.FoodID)
                .Parameters.AddWithValue("@Name", Me.FoodName)
                .Parameters.AddWithValue("@Description", Me.FoodDescription)
                .Parameters.AddWithValue("@Price", Me.FoodPrice)
                .Parameters.AddWithValue("@Notes", Me.FoodNotes)

                .ExecuteNonQuery()
            End With
            Return True

            DatabaseConnection.Close()
        Catch Ex As MySqlException
            Me.ErrorDescription = Ex.Message.ToString
            Return False
        End Try
    End Function

    Public Sub SetUpDataGridView(ByRef Grid As Object)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource
            Dim Query As String = "SELECT * FROM Food WHERE FoodID != '1FTEST';"
            Dim Cmd As New MySqlCommand(Query, DatabaseConnection)

            SDA.SelectCommand = Cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Grid.DataSource = bSource
            SDA.Update(dbDataSet)

            DatabaseConnection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetFoodDetails()
        Dim DatabaseConnection As New MySqlConnection
        'If GlobalID(0) <> "B" Then
        '    Me.FoodID = GlobalID
        'End If
        If GlobalID(0) = "F" Then
            Me.FoodID = GlobalID
        End If


        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT Name, Description, Price, Notes FROM Food WHERE FoodID = '" & Me.FoodID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Me
                    .FoodName = Reader.GetString(0)
                    .FoodDescription = Reader.GetString(1)
                    .FoodPrice = Reader.GetFloat(2)
                    .FoodNotes = Reader.GetString(3)
                End With
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function SaveChanges() As Boolean

        Dim DatabaseConnection As New MySqlConnection
        Me.FoodID = GlobalID

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "UPDATE Food SET Name = @Name, Description = @Description, Price = @Price, Notes = @Notes WHERE FoodID = '" & Me.FoodID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@Name", Me.FoodName)
                .Parameters.AddWithValue("@Description", Me.FoodDescription)
                .Parameters.AddWithValue("@Price", Me.FoodPrice)
                .Parameters.AddWithValue("@Notes", Me.FoodNotes)

                .ExecuteNonQuery()
            End With
            Return True
            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.ErrorDescription = ex.Message.ToString
            Return False
        End Try
    End Function

    Public Function DeleteRecord() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Me.FoodID = GlobalID
        Dim Delete As Boolean

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            '''''''''''''''             CHECK IF FOOD ID IS PART OF A RECORD IN FOODOPTION TABLE             '''''''''''''''
            Dim cmdstring As String = "SELECT * FROM Food WHERE EXISTS (SELECT * FROM FoodOption WHERE FoodID = '" & Me.FoodID & "');"
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
            cmdstring = "DELETE FROM Food WHERE FoodID = '" & Me.FoodID & "';"
            Dim Cmd2 As New MySqlCommand(cmdstring, DatabaseConnection)


            If Delete = True Then ' it is not part of a record in the FoodOption table
                Cmd2.ExecuteNonQuery()
                Return True
            Else
                Me.ErrorDescription = "Food Item cannot be removed because it is part of another table."
                Return False
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.ErrorDescription = ex.Message.ToString
            Return False
        End Try
    End Function


End Class
