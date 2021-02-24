Imports MySql.Data.MySqlClient

Public Class clsRoom

    Private ID As String
    Private Name As String
    Private Description As String
    Private Floor As Integer
    Private HourlyRate As Single
    Private FullDayPriceWD As Single
    Private FullDayPriceWE As Single
    Private MaxCapacity As Integer
    Private ScreenSize As Char
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

    Public Property RoomID() As String
        Get
            Return ID
        End Get
        Set(value As String)
            ID = value
        End Set
    End Property

    Public Property RoomName() As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property RoomDescription() As String
        Get
            Return Description
        End Get
        Set(value As String)
            Description = value
        End Set
    End Property

    Public Property RoomFloor() As Integer
        Get
            Return Floor
        End Get
        Set(value As Integer)
            Floor = value
        End Set
    End Property

    Public Property RoomHourlyRate() As Single
        Get
            Return HourlyRate
        End Get
        Set(value As Single)
            HourlyRate = value
        End Set
    End Property

    Public Property RoomFullDayPriceWD() As Single
        Get
            Return FullDayPriceWD
        End Get
        Set(value As Single)
            FullDayPriceWD = value
        End Set
    End Property

    Public Property RoomFullDayPriceWE() As Single
        Get
            Return FullDayPriceWE
        End Get
        Set(value As Single)
            FullDayPriceWE = value
        End Set
    End Property

    Public Property RoomMaxCapacity() As Integer
        Get
            Return MaxCapacity
        End Get
        Set(value As Integer)
            MaxCapacity = value
        End Set
    End Property

    Public Property RoomScreenSize() As Char
        Get
            Return ScreenSize
        End Get
        Set(value As Char)
            ScreenSize = value
        End Set
    End Property

    Public Property RoomNotes() As String
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

            Dim CmdString As String = "INSERT INTO Room(RoomID, Name, Description, Floor, HourlyRate, FullDayPriceWD, FullDayPriceWE, MaxCapacity, ScreenSize, Notes) VALUES(@RoomID, @Name, @Description, @Floor, @HourlyRate, @FullDayPriceWD, @FullDayPriceWE, @MaxCapacity, @ScreenSize, @Notes);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
            With Cmd
                .Parameters.AddWithValue("@RoomID", Me.RoomID)
                .Parameters.AddWithValue("@Name", Me.RoomName)
                .Parameters.AddWithValue("@Description", Me.RoomDescription)
                .Parameters.AddWithValue("@Floor", Me.RoomFloor)
                .Parameters.AddWithValue("@HourlyRate", Me.RoomHourlyRate)
                .Parameters.AddWithValue("@FullDayPriceWD", Me.RoomFullDayPriceWD)
                .Parameters.AddWithValue("@FullDayPriceWE", Me.RoomFullDayPriceWE)
                .Parameters.AddWithValue("@MaxCapacity", Me.RoomMaxCapacity)
                .Parameters.AddWithValue("@ScreenSize", Me.RoomScreenSize)
                .Parameters.AddWithValue("@Notes", Me.RoomNotes)

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
            Dim Query As String = "SELECT * FROM Room WHERE RoomID != '1RTEST';"
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

    Public Sub GetRoomDetails()
        Dim DatabaseConnection As New MySqlConnection
        Me.RoomID = GlobalID
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT Name, Description, Floor, HourlyRate, FullDayPriceWD, FullDayPriceWE, MaxCapacity, ScreenSize, Notes FROM Room WHERE RoomID = '" & Me.RoomID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Me
                    .RoomName = Reader.GetString(0)
                    .RoomDescription = Reader.GetString(1)
                    .RoomFloor = Reader.GetInt16(2)
                    .RoomHourlyRate = Reader.GetFloat(3)
                    .RoomFullDayPriceWD = Reader.GetFloat(4)
                    .RoomFullDayPriceWE = Reader.GetFloat(5)
                    .RoomMaxCapacity = Reader.GetInt16(6)
                    .RoomScreenSize = Reader.GetString(7)
                    .RoomNotes = Reader.GetString(8)
                End With
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function SaveChanges() As Boolean

        Dim DatabaseConnection As New MySqlConnection
        Me.RoomID = GlobalID

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            ' "UPDATE Food SET Name = @Name, Description = @Description, Price = @Price, Notes = @Notes WHERE FoodID = '" & Me.FoodID & "';"
            Dim cmdstring As String = "UPDATE Room SET Name = @Name, Description = @Description, Floor = @Floor, HourlyRate = @HourlyRate, FullDayPriceWD = @FullDayPriceWD, FullDayPriceWE= @FullDayPriceWE, MaxCapacity = @MaxCapacity, ScreenSize = @ScreenSize, Notes = @Notes WHERE RoomID = '" & Me.RoomID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@Name", Me.RoomName)
                .Parameters.AddWithValue("@Description", Me.RoomDescription)
                .Parameters.AddWithValue("@Floor", Me.RoomFloor)
                .Parameters.AddWithValue("@HourlyRate", Me.RoomHourlyRate)
                .Parameters.AddWithValue("@FullDayPriceWD", Me.RoomFullDayPriceWD)
                .Parameters.AddWithValue("@FullDayPriceWE", Me.RoomFullDayPriceWE)
                .Parameters.AddWithValue("@MaxCapacity", Me.RoomMaxCapacity)
                .Parameters.AddWithValue("@ScreenSize", Me.RoomScreenSize)
                .Parameters.AddWithValue("@Notes", Me.RoomNotes)

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
        Me.RoomID = GlobalID
        Dim Delete As Boolean

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            '''''''''''''''             CHECK IF room ID IS PART OF A RECORD IN booking TABLE             '''''''''''''''
            Dim cmdstring As String = "SELECT * FROM Room WHERE EXISTS (SELECT * FROM Booking WHERE RoomID = '" & Me.RoomID & "');"
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
            cmdstring = "DELETE FROM Room WHERE RoomID = '" & Me.RoomID & "';"
            Dim Cmd2 As New MySqlCommand(cmdstring, DatabaseConnection)

            If Delete = True Then ' it is not part of a record in the booking table
                Cmd2.ExecuteNonQuery()
                Return True
            Else
                Me.ErrorDescription = "Room cannot be removed because it is part of another table."
                Return False
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.ErrorDescription = ex.Message.ToString
            Return False
        End Try
    End Function


End Class
