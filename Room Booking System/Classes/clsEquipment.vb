Imports MySql.Data.MySqlClient

Public Class clsEquipment

    Private ID As String
    Private Name As String
    Private Quantity As Integer
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

    Public Property EquipmentID() As String
        Get
            Return ID
        End Get
        Set(value As String)
            ID = value
        End Set
    End Property

    Public Property EquipmentName() As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property

    Public Property EquipmentQuantity() As Integer
        Get
            Return Quantity
        End Get
        Set(value As Integer)
            Quantity = value
        End Set
    End Property

    Public Property EquipmentPrice() As Single
        Get
            Return Price
        End Get
        Set(value As Single)
            Price = value
        End Set
    End Property

    Public Property EquipmentNotes() As String
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

            Dim CmdString As String = "INSERT INTO Equipment(EquipmentID, Name, Quantity, Price, Notes) VALUES (@EquipmentID, @Name, @Quantity, @Price, @Notes);"
            Dim Cmd As New MySqlCommand(CmdString, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@EquipmentID", Me.EquipmentID)
                .Parameters.AddWithValue("@Name", Me.EquipmentName)
                .Parameters.AddWithValue("@Quantity", Me.EquipmentQuantity)
                .Parameters.AddWithValue("@Price", Me.EquipmentPrice)
                .Parameters.AddWithValue("@Notes", Me.EquipmentNotes)

                Cmd.ExecuteNonQuery()
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
            Dim Query As String = "SELECT * FROM Equipment WHERE EquipmentID != '1PTEST';"
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

    Public Sub GetEquipmentDetails()
        Dim DatabaseConnection As New MySqlConnection
        'If GlobalID(0) <> "B" Then
        '    Me.EquipmentID = GlobalID
        'End If

        If GlobalID(0) = "P" Then
            Me.EquipmentID = GlobalID
        End If

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "SELECT Name, Quantity, Price, Notes FROM Equipment WHERE EquipmentID = '" & Me.EquipmentID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)
            Dim Reader As MySqlDataReader
            Reader = Cmd.ExecuteReader()
            While Reader.Read()
                With Me
                    .EquipmentName = Reader.GetString(0)
                    .EquipmentQuantity = Reader.GetInt32(1)
                    .EquipmentPrice = Reader.GetFloat(2)
                    .EquipmentNotes = Reader.GetString(3)
                End With
            End While

            DatabaseConnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function SaveChanges() As Boolean
        Dim DatabaseConnection As New MySqlConnection
        Me.EquipmentID = GlobalID

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()

            Dim cmdstring As String = "UPDATE Equipment SET Name = @Name, Quantity = @Quantity, Price = @Price, Notes = @Notes WHERE EquipmentID = '" & Me.EquipmentID & "';"
            Dim Cmd As New MySqlCommand(cmdstring, DatabaseConnection)

            With Cmd
                .Parameters.AddWithValue("@Name", Me.EquipmentName)
                .Parameters.AddWithValue("@Quantity", Me.EquipmentQuantity)
                .Parameters.AddWithValue("@Price", Me.EquipmentPrice)
                .Parameters.AddWithValue("@Notes", Me.EquipmentNotes)

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
        Me.EquipmentID = GlobalID
        Dim Delete As Boolean

        Try
            DatabaseConnection.ConnectionString = ConnString
            DatabaseConnection.Open()
            '''''''''''''''             CHECK IF EQUIPMENT ID IS PART OF A RECORD IN EQUIPMENTOPTION TABLE             '''''''''''''''
            Dim cmdstring As String = "SELECT * FROM Equipment WHERE EXISTS (SELECT * FROM EquipmentOption WHERE EquipmentID = '" & Me.EquipmentID & "');"
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
            cmdstring = "DELETE FROM Equipment WHERE EquipmentID = '" & Me.EquipmentID & "';"
            Dim Cmd2 As New MySqlCommand(cmdstring, DatabaseConnection)

            If Delete = True Then ' it is not part of a record in the EquipmentOption table
                Cmd2.ExecuteNonQuery()
                Return True
            Else
                Me.ErrorDescription = "Equipment Item cannot be removed because it is part of another table."
                Return False
            End If

            DatabaseConnection.Close()
        Catch ex As MySqlException
            Me.ErrorDescription = ex.Message.ToString
            Return False
        End Try

    End Function

End Class
