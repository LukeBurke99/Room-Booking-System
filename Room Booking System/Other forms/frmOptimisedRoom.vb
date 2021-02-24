Public Class frmOptimisedRoom
    Dim Weekend As Boolean
    Dim Booking As New clsBooking

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        DisplayInformation()
        '    i = 0 (sunday)    i = 6 (saturday)
        ' check the date selected and see If weekend Or Weekday() Then
        Dim i As Integer = dtpDate.Value.DayOfWeek
        If i = 0 Or i = 6 Then
            Weekend = True
        Else
            Weekend = False
        End If


    End Sub

    Private Sub frmOptimisedRoom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmBookingMenu.Show()
    End Sub

    Private Sub frmOptimisedRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbxStartTime.SelectedItem = GetLoadStartTime
        cmbxEndTime.SelectedItem = GetLoadEndTime
        dtpDate.Value = GetLoadDate


        If GetLoadDetails Then
            MsgBox("Enter the criteria you need your room to meet.")



        Else
            If dtpDate.Value = "01/01/1753" Then
                PanelRoomDetails.Visible = False
                PanelSelectedRoom.Visible = False
                lstRoomID.Visible = False
                lstRoomName.Visible = False
                btnUseRoom.Visible = False
            End If
        End If


    End Sub

    Private Sub cmbxStartTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxStartTime.SelectedIndexChanged
        DisplayInformation()
    End Sub

    Private Sub cmbxEndTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxEndTime.SelectedIndexChanged
        DisplayInformation()
    End Sub

    Private Sub DisplayInformation()
        '  if a date, start and end time have been selected then display all information
        If Not (cmbxStartTime.SelectedItem = "" Or cmbxEndTime.SelectedItem = "" Or dtpDate.Value = "01/01/1753") Then
            PanelRoomDetails.Visible = True
            PanelSelectedRoom.Visible = True
            lstRoomID.Visible = True
            lstRoomName.Visible = True
            btnUseRoom.Visible = True
        End If

    End Sub

    
    Private Sub lstRoomName_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUseRoom_Click(sender As Object, e As EventArgs) Handles btnUseRoom.Click

    End Sub

    Private Sub cbScreenRequired_CheckedChanged(sender As Object, e As EventArgs) Handles cbScreenRequired.CheckedChanged
        If cbScreenRequired.Checked = True Then
            cmbxScreenSize.Enabled = True
        End If
    End Sub

    Private Sub btnSearchRooms_Click(sender As Object, e As EventArgs) Handles btnSearchRooms.Click
        Dim MaximumRoomSize As Integer
        Dim ScreenSize As Char = "N"
        Dim MinimumHourPrice, MaximumHourPrice, MinimumDayPrice, MaximumDayPrice As Single
        Dim RoomCriteriaArray(5) As String
        Dim top_of_array As Integer = 5
        Dim ListOfRooms As New Dictionary(Of String, String)
        Dim ListOfRoomsAvailable As New Dictionary(Of String, String)
        Dim RoomID As String
        Dim RoomName As String

        MaximumRoomSize = txtRoomCapacityNeeded.Text

        If cbScreenRequired.Checked Then
            ScreenSize = cmbxScreenSize.SelectedItem
        Else
            ScreenSize = "N"
        End If

        MinimumHourPrice = txtMinHourPrice.Text
        MaximumHourPrice = txtMaxHourPrice.Text
        MinimumDayPrice = txtMinDayPrice.Text
        MaximumDayPrice = txtMaxDayPrice.Text

        RoomCriteriaArray(0) = MaximumRoomSize
        RoomCriteriaArray(1) = ScreenSize
        RoomCriteriaArray(2) = MinimumHourPrice
        RoomCriteriaArray(3) = MaximumHourPrice
        RoomCriteriaArray(4) = MinimumDayPrice
        RoomCriteriaArray(5) = MaximumDayPrice

        Do
            ListOfRoomsAvailable.Clear()
            Booking.FindOptimisedRoom(RoomCriteriaArray, ListOfRooms, Weekend)
            ' check availability of rooms that have been gathered from optimised room search
            For i = 0 To ListOfRooms.Count - 1
                ' setting the key to be the room ID
                RoomID = ListOfRooms.Keys(i)
                RoomName = ListOfRooms.Values(i)
                If Booking.CheckRoomAvailability(True, dtpDate.Value, cmbxStartTime.SelectedItem, cmbxEndTime.SelectedItem, RoomID) Then
                    ListOfRoomsAvailable.Add(RoomID, RoomName)
                End If

            Next

            If ListOfRoomsAvailable.Count = 0 Then
                If top_of_array = 5 Or top_of_array = 3 Then
                    RoomCriteriaArray(top_of_array) = ""
                    RoomCriteriaArray(top_of_array - 1) = ""
                    top_of_array -= 2
                Else
                    RoomCriteriaArray(top_of_array) = ""
                    top_of_array -= 1
                End If
            End If

        Loop Until ListOfRoomsAvailable.Count <> 0 Or top_of_array = 0

    End Sub
End Class