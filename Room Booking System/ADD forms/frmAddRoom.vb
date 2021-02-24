Public Class frmAddRoom
    Dim Room As New clsRoom
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        ' assign the text boxes to their variables.
        Try
            With Room
                .RoomID = lblRoomID.Text
                .RoomName = txtName.Text
                .RoomDescription = txtDescription.Text
                .RoomFloor = CInt(txtFloor.Text)
                .RoomHourlyRate = CDec(txtHourlyRate.Text)
                .RoomFullDayPriceWD = CDec(txtWeekdayRate.Text)
                .RoomFullDayPriceWE = CDec(txtWeekendRate.Text)
                .RoomMaxCapacity = CInt(txtMaxCapacity.Text)
                .RoomScreenSize = txtScreenSize.Text.ToUpper
                .RoomNotes = txtNotes.Text
            End With

            If Room.Update() = True Then
                ' Display an update label.
                MsgBox("Room has been added to the system.")
                lblRoomID.Text = GetNextRoomID()
                txtName.Text = ""
                txtDescription.Text = ""
                txtFloor.Text = ""
                txtHourlyRate.Text = ""
                txtWeekdayRate.Text = ""
                txtWeekendRate.Text = ""
                txtMaxCapacity.Text = ""
                txtScreenSize.Text = ""
                txtNotes.Text = ""
            Else
                ' Display an error
                MsgBox(Room.ErrorDescription)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        

        

    End Sub

    Private Sub txtScreenSize_TextChanged(sender As Object, e As EventArgs) Handles txtScreenSize.TextChanged
        If txtScreenSize.Text <> "" Then
            If UCase(txtScreenSize.Text) <> "N" And UCase(txtScreenSize.Text) <> "S" And UCase(txtScreenSize.Text) <> "M" And UCase(txtScreenSize.Text) <> "L" Then
                MsgBox("Enter a valid letter. (S, M, L, N)")
                txtScreenSize.Text = ""
            End If
        End If

    End Sub

    Private Sub frmAddRoom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmRoomDetails.Show()
        Room.SetUpDataGridView(frmRoomDetails.gridRoom)
    End Sub

    Private Sub frmAddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NewRecord Then
            lblRoomID.Text = GetNextRoomID()
            btnSaveChanges.Enabled = False
            btnAddRoom.Enabled = True
        Else
            Room.GetRoomDetails()
            btnSaveChanges.Enabled = True
            btnAddRoom.Enabled = False

            lblRoomID.Text = Room.RoomID
            txtName.Text = Room.RoomName
            txtDescription.Text = Room.RoomDescription
            txtNotes.Text = Room.RoomNotes
            txtFloor.Text = Room.RoomFloor
            txtHourlyRate.Text = Room.RoomHourlyRate
            txtWeekdayRate.Text = Room.RoomFullDayPriceWD
            txtWeekendRate.Text = Room.RoomFullDayPriceWE
            txtMaxCapacity.Text = Room.RoomMaxCapacity
            txtScreenSize.Text = Room.RoomScreenSize
        End If

    End Sub

    Private Function GetNextRoomID() As String
        Dim table As String = "Room"
        Dim RoomID As String = "R"
        Dim LastID As Integer
        LastID = CInt(GetMaxID(table))
        RoomID = RoomID & ((LastID + 1).ToString("D5"))
        Return RoomID.ToString
    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            With Room
                .RoomName = txtName.Text
                .RoomDescription = txtDescription.Text
                .RoomFloor = CInt(txtFloor.Text)
                .RoomHourlyRate = CDec(txtHourlyRate.Text)
                .RoomFullDayPriceWD = CDec(txtWeekdayRate.Text)
                .RoomFullDayPriceWE = CDec(txtWeekendRate.Text)
                .RoomMaxCapacity = CInt(txtMaxCapacity.Text)
                .RoomScreenSize = txtScreenSize.Text.ToUpper
                .RoomNotes = txtNotes.Text
            End With

            If Room.SaveChanges() = True Then
                MsgBox("Changes have been made to the record.")
            Else
                MsgBox(Room.ErrorDescription)
            End If
            GlobalID = "000000"
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

End Class