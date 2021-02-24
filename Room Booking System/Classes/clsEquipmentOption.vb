Imports MySql.Data.MySqlClient

Public Class clsEquipmentOption

    Private BookingID As String
    Private EquipmentID As String
    Private Quantity As Integer
    Private Price As Single
    Private ErrorDesc As String

    Public Property ErrorDescription() As String
        Get
            Return ErrorDesc
        End Get
        Set(value As String)
            ErrorDesc = value
        End Set
    End Property

    Public Property GetSetBookingID() As String
        Get
            Return BookingID
        End Get
        Set(value As String)
            BookingID = value
        End Set
    End Property

    Public Property GetSetEquipmentID() As String
        Get
            Return EquipmentID
        End Get
        Set(value As String)
            EquipmentID = value
        End Set
    End Property

    Public Property GetSetQuantity() As Integer
        Get
            Return Quantity
        End Get
        Set(value As Integer)
            Quantity = value
        End Set
    End Property

    Public Property GetSetPrice() As Single
        Get
            Return Price
        End Get
        Set(value As Single)
            Price = value
        End Set
    End Property

    Public Function Update() As Boolean

        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim CmdString As String = "INSERT INTO EquipmentOption(BookingID, EquipmentID, Quantity, Price) VALUES(@BookingID, @EquipmentID, @Quantity, @Price);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@BookingID", Me.GetSetBookingID)
                .Parameters.AddWithValue("@EquipmentID", Me.GetSetEquipmentID)
                .Parameters.AddWithValue("@Quantity", Me.GetSetQuantity)
                .Parameters.AddWithValue("@Price", Me.GetSetPrice)

                .ExecuteNonQuery()
            End With
            Return True

            DatabaseConnection.Close()
        Catch Ex As MySqlException
            Me.ErrorDescription = Ex.Message.ToString
            Return False
        End Try

    End Function

    Public Sub GetEquipmentOptionDetails(ByRef Grid As Object)
        Me.GetSetBookingID = GlobalID
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT EquipmentID, Quantity, Price FROM EquipmentOption WHERE BookingID = '" & Me.GetSetBookingID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader

            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                Grid.Rows.Add(Reader.GetString(0), Nothing, Reader.GetString(1), Reader.GetString(2))
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function GetEquipmentName(ByVal ID As String) As String
        Dim ReturnEquipmentName As String = ""
        Dim DatabaseConnection As New MySqlConnection
        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT Name FROM Equipment WHERE EquipmentID = '" & ID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader

            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                ReturnEquipmentName = Reader.GetString(0)
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        Return ReturnEquipmentName
    End Function

End Class
