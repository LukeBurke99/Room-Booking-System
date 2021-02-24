Imports MySql.Data.MySqlClient

Public Class clsBooking

    Private ID As String
    Private CustomerID As String
    Private EmployeeID As String
    Private RoomID As String
    Private Title As String
    Private GroupName As String
    Private LecturerName As String
    Private TelephoneNumber As String
    Private RequestedDate As Date
    Private StartTime As String
    Private EndTime As String
    Private NumberOfPeople As Integer
    Private NumberOfCars As Integer
    Private TotalPrice As Single
    Private SecurityRequired As Boolean
    Private SmartScreenRequired As Boolean
    Private Confirmed As Boolean
    Private ConfirmationDate As Date
    Private Notes As String
    Private ErrorDesc As String
    Private Record As Boolean
    Private PaymentChoice As Char

    Public Property ErrorDescription() As String
        Get
            Return ErrorDesc
        End Get
        Set(value As String)
            ErrorDesc = value
        End Set
    End Property

    Public Property BookingID() As String
        Get
            Return ID
        End Get
        Set(value As String)
            ID = value
        End Set
    End Property

    Public Property BookingCustomerID() As String
        Get
            Return CustomerID
        End Get
        Set(value As String)
            CustomerID = value
        End Set
    End Property

    Public Property BookingEmployeeID() As String
        Get
            Return EmployeeID
        End Get
        Set(value As String)
            EmployeeID = value
        End Set
    End Property

    Public Property BookingRoomID() As String
        Get
            Return RoomID
        End Get
        Set(value As String)
            RoomID = value
        End Set
    End Property

    Public Property BookingTitle() As String
        Get
            Return Title
        End Get
        Set(value As String)
            Title = value
        End Set
    End Property

    Public Property BookingGroupName() As String
        Get
            Return GroupName
        End Get
        Set(value As String)
            GroupName = value
        End Set
    End Property

    Public Property BookingLecturerName() As String
        Get
            Return LecturerName
        End Get
        Set(value As String)
            LecturerName = value
        End Set
    End Property

    Public Property BookingTelephoneNumber() As String
        Get
            Return TelephoneNumber
        End Get
        Set(value As String)
            TelephoneNumber = value
        End Set
    End Property

    Public Property BookingRequestedDate() As Date
        Get
            Return RequestedDate
        End Get
        Set(value As Date)
            RequestedDate = value
        End Set
    End Property

    Public Property BookingStartTime() As String
        Get
            Return StartTime
        End Get
        Set(value As String)
            StartTime = value
        End Set
    End Property

    Public Property BookingEndTime() As String
        Get
            Return EndTime
        End Get
        Set(value As String)
            EndTime = value
        End Set
    End Property

    Public Property BookingNumberOfPeople() As Integer
        Get
            Return NumberOfPeople
        End Get
        Set(value As Integer)
            NumberOfPeople = value
        End Set
    End Property

    Public Property BookingNumberOfCars() As Integer
        Get
            Return NumberOfCars
        End Get
        Set(value As Integer)
            NumberOfCars = value
        End Set
    End Property

    Public Property BookingTotalPrice() As Single
        Get
            Return TotalPrice
        End Get
        Set(value As Single)
            TotalPrice = value
        End Set
    End Property

    Public Property BookingSecurityRequired() As Boolean
        Get
            Return SecurityRequired
        End Get
        Set(value As Boolean)
            SecurityRequired = value
        End Set
    End Property

    Public Property BookingSmartScreenRequired() As Boolean
        Get
            Return SmartScreenRequired
        End Get
        Set(value As Boolean)
            SmartScreenRequired = value
        End Set
    End Property

    Public Property BookingConfirmed() As Boolean
        Get
            Return Confirmed
        End Get
        Set(value As Boolean)
            Confirmed = value
        End Set
    End Property

    Public Property BookingConfirmationDate() As Date
        Get
            Return ConfirmationDate
        End Get
        Set(value As Date)
            ConfirmationDate = value
        End Set
    End Property

    Public Property BookingNotes() As String
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

    Public Property BookingPaymentChoice() As Char
        Get
            Return PaymentChoice
        End Get
        Set(value As Char)
            PaymentChoice = value
        End Set
    End Property


    Public Function Update() As Boolean
        ' connecting to the BookingFormY6701 database and adding things to the Customer table
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "INSERT INTO Booking(BookingID, CustomerID, EmployeeID, RoomID, BookingTitle, GroupName, TelephoneNumber, Date, StartTime, EndTime, NumberOfPeople, NumberOfCars, TotalPrice, Confirmed, ConfirmationDate, Notes, LecturerName, SecurityRequired, SmartScreenRequired, PaymentChoice) "
            CmdString += "VALUES(@BookingID, @CustomerID, @EmployeeID, @RoomID, @BookingTitle, @GroupName, @TelephoneNumber ,@Date, @StartTime, @EndTime, @NumberOfPeople, @NumberOfCars, @TotalPrice, @Confirmed, @ConfirmationDate, @Notes, @LecturerName, @SecurityRequired, @SmartScreenRequired, @PaymentChoice);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@BookingID", Me.BookingID)
                .Parameters.AddWithValue("@CustomerID", Me.BookingCustomerID)
                .Parameters.AddWithValue("@EmployeeID", Me.BookingEmployeeID)
                .Parameters.AddWithValue("@RoomID", Me.BookingRoomID)
                .Parameters.AddWithValue("@BookingTitle", Me.BookingTitle)
                .Parameters.AddWithValue("@GroupName", Me.BookingGroupName)
                .Parameters.AddWithValue("@LecturerName", Me.BookingLecturerName)
                .Parameters.AddWithValue("@TelephoneNumber", Me.BookingTelephoneNumber)
                .Parameters.AddWithValue("@Date", Me.BookingRequestedDate)
                .Parameters.AddWithValue("@StartTime", Me.BookingStartTime)
                .Parameters.AddWithValue("@EndTime", Me.BookingEndTime)
                .Parameters.AddWithValue("@NumberOfPeople", Me.BookingNumberOfPeople)
                .Parameters.AddWithValue("@NumberOfCars", Me.BookingNumberOfCars)
                .Parameters.AddWithValue("@TotalPrice", Me.BookingTotalPrice)
                .Parameters.AddWithValue("@SecurityRequired", Me.BookingSecurityRequired)
                .Parameters.AddWithValue("@SmartScreenRequired", Me.BookingSmartScreenRequired)
                .Parameters.AddWithValue("@Confirmed", Me.BookingConfirmed)
                .Parameters.AddWithValue("@ConfirmationDate", Me.BookingConfirmationDate)
                .Parameters.AddWithValue("@Notes", Me.BookingNotes)
                .Parameters.AddWithValue("@PaymentChoice", Me.BookingPaymentChoice)

                .ExecuteNonQuery()
            End With
            Return True

            DatabaseConnection.Close()
        Catch Ex As MySqlException
            Me.ErrorDescription = Ex.Message.ToString
            Return False
        End Try

    End Function

    Public Sub BookingSetUpDataGridView(ByRef Grid As Object, ByVal GridOption As Integer, ByVal Date1 As Date, ByVal Date2 As Date)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource
            Dim Query As String

            If GridOption = 0 Then
                Query = "SELECT * FROM Booking WHERE DATE >= '" & Format(Date1, "yyyy-MM-dd") & "' AND DATE <= '" & Format(Date2, "yyyy-MM-dd") & "' AND BookingID != '1BTEST';"
                Dim cmd As New MySqlCommand(Query, DatabaseConnection)
                SDA.SelectCommand = cmd
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                Grid.DataSource = bSource
                SDA.Update(dbDataSet)
            Else
                Query = "SELECT * FROM Booking WHERE Confirmed = FALSE AND DATE >= '" & Format(Date1, "yyyy-MM-dd") & "' AND DATE <= '" & Format(Date2, "yyyy-MM-dd") & "' AND BookingID != '1BTEST';"
                Dim Cmd As New MySqlCommand(Query, DatabaseConnection)
                SDA.SelectCommand = Cmd
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                Grid.DataSource = bSource
                SDA.Update(dbDataSet)
            End If
            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub GetClientName(ByVal RequestedID As String, ByRef Client As clsCustomer)
        Dim DatabaseConnection As New MySqlConnection

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "SELECT FirstName, Surname, Address, Postcode, TelephoneNumber, EmailAddress, Notes FROM Customer WHERE CustomerID = '" & RequestedID & "';"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
            Dim Reader As MySqlDataReader

            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Client
                    .PersonFirstName = (Reader.GetString(0))
                    .PersonSurname = (Reader.GetString(1))
                    .PersonAddress = (Reader.GetString(2))
                    .PersonPostcode = (Reader.GetString(3))
                    .PersonTelephoneNumber = (Reader.GetString(4))
                    .PersonEmailAddress = (Reader.GetString(5))
                    .PersonNotes = (Reader.GetString(6))
                End With
            End While
            DatabaseConnection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub GetClientID(ByVal RequestedFirstName As String, ByVal RequestedSurname As String, ByVal RequestedTelephoneNumber As String, ByRef Client As clsCustomer)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "SELECT CustomerID, Address, Postcode, TelephoneNumber, EmailAddress, Notes FROM Customer WHERE FirstName = '" & RequestedFirstName & "' AND Surname = '" & RequestedSurname & "' AND TelephoneNumber = '" & RequestedTelephoneNumber & "';"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
            Dim Reader As MySqlDataReader

            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Client
                    .PersonID = (Reader.GetString(0))
                    .PersonAddress = (Reader.GetString(1))
                    .PersonPostcode = (Reader.GetString(2))
                    .PersonEmailAddress = (Reader.GetString(4))
                    .PersonNotes = (Reader.GetString(5))
                End With
            End While
            DatabaseConnection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub GetRoomType(ByRef RoomDictionary As Dictionary(Of String, String)) ' ByRef RoomType As Object)
        Dim DatabaseConnection As New MySqlConnection


        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            '''' select id but dont show
            Dim CmdString As String = "SELECT RoomID, Name FROM Room WHERE RoomID != '1RTEST';"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
            Dim Reader As MySqlDataReader

            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                RoomDictionary.Add(Reader.GetString(0), Reader.GetString(1))
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        'Dim DatabaseConnection As New MySqlConnection
        'Dim Reader As MySqlDataReader

        'Try
        '    DatabaseConnection.ConnectionString = ConnString
        '    DatabaseConnection.Open()
        '    '''' select id but dont show
        '    Dim CmdString As String = "SELECT Name FROM Room;"
        '    Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)
        '    Dim Reader As MySqlDataReader

        '    Reader = Cmd.ExecuteReader()
        '    While Reader.Read()
        '        RoomType.Items.Add(Reader.GetString(0))
        '    End While

        '    DatabaseConnection.Close()
        'Catch ex As MySqlException
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Public Sub GetRoomDetails(ByVal RequestedRoomID As String, ByRef Room As clsRoom)
        Dim DatabaseConnection As New MySqlConnection
        Me.RoomID = RequestedRoomID
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT Description, Floor, HourlyRate, FullDayPriceWD, FullDayPriceWE, MaxCapacity, ScreenSize, Notes FROM Room WHERE RoomID = '" & Me.RoomID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader

            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Room
                    .RoomDescription = (Reader.GetString(0))
                    .RoomFloor = (Reader.GetString(1))
                    .RoomHourlyRate = (Reader.GetString(2))
                    .RoomFullDayPriceWD = (Reader.GetString(3))
                    .RoomFullDayPriceWE = (Reader.GetString(4))
                    .RoomMaxCapacity = (Reader.GetString(5))
                    .RoomScreenSize = (Reader.GetChar(6))
                    .RoomNotes = (Reader.GetString(7))
                End With
            End While

            DatabaseConnection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetBookingDetails() '(ByVal BookingID As String)
        Dim DatabaseConnection As New MySqlConnection
        Me.BookingID = GlobalID
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT CustomerID, EmployeeID, RoomID, BookingTitle, GroupName, TelephoneNumber, Date, StartTime, EndTime, NumberOfPeople, NumberOfCars, TotalPrice, Confirmed, ConfirmationDate, Notes, LecturerName, SecurityRequired, SmartScreenRequired, PaymentChoice FROM Booking WHERE BookingID = '" & Me.BookingID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Me
                    .BookingCustomerID = Reader.GetString(0)
                    .BookingEmployeeID = Reader.GetString(1)
                    .BookingRoomID = Reader.GetString(2)
                    .BookingTitle = Reader.GetString(3)
                    .BookingGroupName = Reader.GetString(4)
                    .BookingTelephoneNumber = Reader.GetString(5)
                    .BookingRequestedDate = Reader.GetDateTime(6)
                    .BookingStartTime = Reader.GetString(7)
                    .BookingEndTime = Reader.GetString(8)
                    .BookingNumberOfPeople = Reader.GetInt16(9)
                    .BookingNumberOfCars = Reader.GetInt16(10)
                    .BookingTotalPrice = Reader.GetDecimal(11)
                    .BookingConfirmed = Reader.GetBoolean(12)
                    .BookingConfirmationDate = Reader.GetDateTime(13)
                    .BookingNotes = Reader.GetString(14)
                    .BookingLecturerName = Reader.GetString(15)
                    .BookingSecurityRequired = Reader.GetBoolean(16)
                    .BookingSmartScreenRequired = Reader.GetBoolean(17)
                    .BookingPaymentChoice = Reader.GetString(18)
                End With
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub SetUpEquipmentGrid(ByRef Grid As Object)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource
            Dim Query As String = "SELECT EquipmentID, Name FROM Equipment WHERE EquipmentID != '1PTEST';"

            Dim cmd As New MySqlCommand(Query, DatabaseConnection)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Grid.DataSource = bSource
            SDA.Update(dbDataSet)

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub SetUpFoodGrid(ByRef Grid As Object)
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource
            Dim Query As String = "SELECT FoodID, Name FROM Food WHERE FoodID != '1FTEST';"

            Dim cmd As New MySqlCommand(Query, DatabaseConnection)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Grid.DataSource = bSource
            SDA.Update(dbDataSet)

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetAllStartTimes(ByVal RequestedDate As Date, ByVal RequestedRoom As String) As List(Of String)
        Dim StartTimes As New List(Of String)
        Dim DatabaseConnection As New MySqlConnection

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT StartTime FROM Booking WHERE Date = '" & RequestedDate & "' AND Room = '" & RequestedRoom & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()

            While Reader.Read()
                StartTimes.Add(Reader.GetString(0))
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try

        Return StartTimes
    End Function

    Public Function GetAllEndTimes(ByVal RequestedDate As Date, ByVal RequestedRoom As String) As List(Of String)
        Dim EndTimes As New List(Of String)
        Dim DatabaseConnection As New MySqlConnection

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT EndTime FROM Booking WHERE Date = '" & RequestedDate & "' AND Room = '" & RequestedRoom & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()

            While Reader.Read()
                EndTimes.Add(Reader.GetString(0))
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try

        Return EndTimes
    End Function



    Public Function CheckRoomAvailability(ByRef TryCatchSuccessful As Boolean, ByVal RequestedDate As Date, ByVal RequestedStartTime As String, ByVal RequestedEndTime As String, ByVal RequestedRoom As String) As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Dim LiesBetween As Boolean = False
        Dim StartTimeList As New List(Of String)
        Dim EndTimeList As New List(Of String)
        Dim TempST As String
        Dim TempET As String
        RequestedDate = Format(RequestedDate, "yyyy-MM-dd")

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdDateRecord As String = "SELECT * FROM Booking WHERE Date = '" & RequestedDate & "';"
            Dim Cmd1 As New MySqlCommand(cmdDateRecord, DatabaseConnection)
            Dim Reader1 As MySqlDataReader
            Reader1 = Cmd1.ExecuteReader()

            If Reader1.Read() Then
                Dim cmdRoomRecord As String = "SELECT * FROM Booking WHERE Date = '" & RequestedDate & "' AND Room = '" & RequestedRoom & "';"
                Dim Cmd2 As New MySqlCommand(cmdRoomRecord, DatabaseConnection)
                Dim Reader2 As MySqlDataReader
                Reader2 = Cmd2.ExecuteReader()

                If Reader2.Read() Then
                    StartTimeList = Me.GetAllStartTimes(RequestedDate, RequestedRoom)
                    EndTimeList = Me.GetAllEndTimes(RequestedDate, RequestedRoom)

                    Dim count As Integer = 0
                    While Not LiesBetween And count <> StartTimeList.Count
                        TempST = StartTimeList(count)
                        TempET = EndTimeList(count)

                        If RequestedStartTime >= TempST And RequestedStartTime <= TempET Then
                            LiesBetween = True
                        ElseIf RequestedEndTime >= TempST And RequestedEndTime <= TempET Then
                            LiesBetween = True
                        Else
                            count += 1
                        End If
                    End While

                    If LiesBetween Then
                        Return False
                    End If
                End If
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
            TryCatchSuccessful = False
        End Try
        Return True

    End Function

    Public Sub FindOptimisedRoom(ByVal RoomCriteriaArray() As String, ByRef ListOfRooms As Dictionary(Of String, String), ByVal Weekend As Boolean)
        Dim cmdstring As String
        Dim DatabaseConnection As New MySqlConnection

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            cmdstring = "SELECT RoomID, Name FROM Room WHERE MaxCapacity >= " & RoomCriteriaArray(0)

            If RoomCriteriaArray(1) <> "" Then
                cmdstring += " AND ScreenSize = '" & RoomCriteriaArray(1) & "' "
            End If

            ' This accounts for array items 2 and 3
            If RoomCriteriaArray(2) <> "" Then
                cmdstring += " AND HourlyRate >= " & RoomCriteriaArray(2) & " AND HourlyRate <= " & RoomCriteriaArray(3)
            End If

            If Weekend Then
                If RoomCriteriaArray(4) <> "" Then
                    cmdstring += " And FullDayPriceWE >= " & RoomCriteriaArray(4) & " AND FullDayPriceWE <= " & RoomCriteriaArray(5)
                End If
            Else
                If RoomCriteriaArray(4) <> "" Then
                    cmdstring += " And FullDayPriceWD >= " & RoomCriteriaArray(4) & " AND FullDayPriceWD <= " & RoomCriteriaArray(5)
                End If
            End If

            cmdstring += " ;"

            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                ListOfRooms.Add(Reader.GetString(0), Reader.GetString(1))
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

End Class
