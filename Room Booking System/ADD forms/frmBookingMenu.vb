Imports MySql.Data.MySqlClient
Public Class frmBookingMenu
    Dim BookingClass As New clsBooking
    Dim ClientClass As New clsCustomer
    Dim RoomClass As New clsRoom
    Dim EquipmentClass As New clsEquipment
    Dim EquipmentOptionClass As New clsEquipmentOption
    Dim FoodClass As New clsFood
    Dim FoodOptionClass As New clsFoodOption
    Dim newloaded As Integer
    Dim RoomPrice As Single = 0
    Dim TotalPrice As Single = 0

    Dim EqGridIndex As Integer = -1
    Dim FoGridIndex As Integer = -1
    Dim EquipmentTotal As Single = 0


    Private Sub frmBookingMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmScheduledBookings.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click
        ' loop to check availability of room until a date has been found where the room is free
        Dim Confirmed As Boolean
        Dim Availability As Boolean = False
        Dim TryCatchSuccessful As Boolean = True
        Dim RequestedDate As Date = dtpDate.Value
        Dim RequestedStartTime As String = cmbxStartTime.SelectedItem.ToString
        Dim RequestedEndTime As String = cmbxEndTime.SelectedItem.ToString
        Dim RequestedRoom As String = cmbxRoomName.SelectedValue.ToString
        Dim duration As TimeSpan = (TimeSpan.Parse(RequestedEndTime) - TimeSpan.Parse(RequestedStartTime))
        Dim tsSum As TimeSpan

        ' minus a day from the requested date because 1 is being added at the start of the loop
        Do
            Availability = BookingClass.CheckRoomAvailability(TryCatchSuccessful, RequestedDate, RequestedStartTime, RequestedEndTime, RequestedRoom)
            If Not Availability Then
                If RequestedEndTime <> "18:00:00" Then
                    RequestedStartTime = (TimeSpan.Parse(RequestedStartTime) + TimeSpan.Parse("00:30:00")).ToString
                    RequestedEndTime = (TimeSpan.Parse(RequestedEndTime) + TimeSpan.Parse("00:30:00")).ToString
                Else
                    RequestedDate.AddDays(1)
                    RequestedStartTime = "08:00:00"
                    tsSum = duration + TimeSpan.Parse("08:00:00")
                    RequestedEndTime = tsSum.ToString
                End If
            End If
        Loop Until Availability Or Not TryCatchSuccessful

        ' display to the user that the room is free between the two times they have requested and the date that has been calculated from the loop above
        ' allow them to book the room on that date or pass through to Optimised Room Search

        If TryCatchSuccessful Then
            Dim Result As MsgBoxResult = MsgBox("The room you have selected is free on " & Format(RequestedDate, "yyyy/MM/dd") & " between " & RequestedStartTime & " and " & RequestedEndTime & " Would you like to book it?", MsgBoxStyle.YesNo, "Make Booking")
            If Result = MsgBoxResult.Yes Then
                Try
                    If cmbxConfirmed.Text = "Confirmed" Then
                        Confirmed = True
                    Else
                        Confirmed = False
                    End If

                    ' if customer has chosen to pay hourly then store this, if not then store that they chose full day price (price for the rooms)
                    If radPayFullDay.Checked Then
                        BookingClass.BookingPaymentChoice = "F"
                        ' total price is the price of the room + price of the equipment + price of the food
                    Else
                        BookingClass.BookingPaymentChoice = "H"
                    End If

                    TotalPrice = RoomPrice + lblEquipmentPrice.Text + lblFoodPrice.Text
                    lblTotalPrice.Text = TotalPrice

                    RoomClass.RoomID = cmbxRoomName.SelectedValue.ToString
                    With BookingClass
                        .BookingID = lblBookingID.Text
                        .BookingEmployeeID = GetEmployee_ID
                        .BookingRoomID = RoomClass.RoomID
                        .BookingTitle = txtMeetingTitle.Text
                        .BookingGroupName = txtGroupName.Text
                        .BookingLecturerName = txtLecturerName.Text
                        .BookingTelephoneNumber = txtTelephoneNumber.Text
                        .BookingRequestedDate = Format(dtpDate.Value, "yyyy-MM-dd")
                        .BookingStartTime = cmbxStartTime.SelectedItem
                        .BookingEndTime = cmbxEndTime.SelectedItem
                        .BookingNumberOfPeople = CInt(txtPeople.Text)
                        .BookingNumberOfCars = CInt(txtCars.Text)
                        .BookingConfirmed = Confirmed
                        .BookingTotalPrice = TotalPrice
                        .BookingSecurityRequired = cbSecurity.CheckState
                        .BookingSmartScreenRequired = cbScreenRequired.CheckState
                        
                        .BookingNotes = txtNotes.Text
                    End With

                    If Confirmed Then
                        BookingClass.BookingConfirmationDate = Format(dtpDateConfirmed.Value, "yyyy-MM-dd")
                    End If

                    ' depending on what radio button is chosen, asign the customer ID in the booking table the correct data
                    If radSearchViaClientName.Checked = True Then
                        BookingClass.BookingCustomerID = lblClientID.Text
                    Else
                        BookingClass.BookingCustomerID = txtSearchClientID.Text
                    End If



                    If CheckConnection() Then
                        ' loop through each item in the food grid and add them to FoodOptions table 
                        FoodOptionClass.GetSetBookingID = lblBookingID.Text
                        For i = 0 To (gridSelectedFood.Rows().Count() - 1)
                            FoodOptionClass.GetSetFoodID = gridSelectedFood.Rows(i).Cells(0).Value
                            FoodOptionClass.GetSetQuantity = gridSelectedFood.Rows(i).Cells(2).Value
                            FoodOptionClass.GetSetPrice = gridSelectedFood.Rows(i).Cells(3).Value
                            FoodOptionClass.Update()
                        Next


                        ' loop through each item in the Equipment grid and add them to EquipmentOptions table 
                        EquipmentOptionClass.GetSetBookingID = lblBookingID.Text
                        For i = 0 To (gridSelectedEquipment.Rows().Count() - 1)
                            EquipmentOptionClass.GetSetEquipmentID = gridSelectedEquipment.Rows(i).Cells(0).Value
                            EquipmentOptionClass.GetSetQuantity = gridSelectedEquipment.Rows(i).Cells(2).Value
                            EquipmentOptionClass.GetSetPrice = gridSelectedEquipment.Rows(i).Cells(3).Value
                            EquipmentOptionClass.Update()
                        Next


                        If BookingClass.Update = True Then
                            ' Display an update label.
                            MsgBox("Booking has been added to the system.")
                        Else
                            ' Display an error
                            MsgBox(BookingClass.ErrorDescription)
                        End If
                    Else
                        MsgBox("Can't connect to database at this time. Try again later.")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                
            Else
                ' load details into search optimised room 
                '''''''''''''''''''''''''''''''''''''''''''''''''''''dfdfdfdf(gdfgfgdgdfgdfgdfgdfgdgdfgdfgdgsdgsgfhdfgsa)
                GetLoadDetails = True
                GetLoadDate = dtpDate.Value
                GetLoadStartTime = cmbxStartTime.SelectedItem.ToString
                GetLoadEndTime = cmbxEndTime.SelectedItem.ToString
                frmOptimisedRoom.Show()
                Me.Close()
            End If

        Else
            MsgBox("Booking can not be made at this time. Try again later.")
        End If


    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        tcBooking.SelectedTab = Clients
    End Sub

    Private Sub btnAddEquipment_Click(sender As Object, e As EventArgs) Handles btnAddEquipment.Click
        tcBooking.SelectedTab = Equipment
    End Sub

    Private Sub btnAddCatering_Click(sender As Object, e As EventArgs) Handles btnAddCatering.Click
        tcBooking.SelectedTab = Catering
    End Sub

    Private Sub btnGetClient_Click(sender As Object, e As EventArgs) Handles btnFindClientID.Click
        BookingClass.GetClientName(txtSearchClientID.Text, ClientClass)


        lblClientName.Text = ClientClass.PersonFirstName & " " & ClientClass.PersonSurname
        lblClientAddress1.Text = ClientClass.PersonAddress
        lblClientPostcode1.Text = ClientClass.PersonPostcode
        lblClientTelephoneNo1.Text = ClientClass.PersonTelephoneNumber
        lblClientEmailAddress1.Text = ClientClass.PersonEmailAddress
        lblClientNotes1.Text = ClientClass.PersonNotes

        If lblClientName.Text <> "" Then
            radSearchViaClientID.Enabled = True
        Else
            radSearchViaClientID.Enabled = False
        End If



    End Sub

    Private Sub btnAddClientToBooking_Click(sender As Object, e As EventArgs) Handles btnAddClientToBooking.Click
        tcBooking.SelectedTab = BookingDetails

        If radSearchViaClientID.Checked = True Then
            lblBookingClient.Text = lblClientName.Text
        Else
            lblBookingClient.Text = txtSearchClientFirstName.Text & " " & txtSearchClientSurname.Text
        End If

    End Sub

    Private Sub btnFindClientName_Click(sender As Object, e As EventArgs) Handles btnFindClientName.Click
        BookingClass.GetClientID(txtSearchClientFirstName.Text, txtSearchClientSurname.Text, txtClientTelephoneNumber.Text, ClientClass)

        lblClientID.Text = ClientClass.PersonID
        lblClientAddress2.Text = ClientClass.PersonAddress
        lblClientPostcode2.Text = ClientClass.PersonPostcode
        lblClientEmailAddress2.Text = ClientClass.PersonEmailAddress
        lblClientNotes2.Text = ClientClass.PersonNotes

        If lblClientID.Text <> "" Then
            radSearchViaClientName.Enabled = True
        Else
            radSearchViaClientName.Enabled = False
        End If

    End Sub

    Private Sub radSearchVieClientID_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchViaClientID.CheckedChanged
        btnAddClientToBooking.Enabled = True
    End Sub

    Private Sub radSearchViaClientName_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchViaClientName.CheckedChanged
        btnAddClientToBooking.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxRoomName.SelectedIndexChanged
        If newloaded = 1 Then
            BookingClass.GetRoomDetails(cmbxRoomName.SelectedValue.ToString, RoomClass)

            lblHourlyCost.Text = RoomClass.RoomHourlyRate
            lblDescription.Text = RoomClass.RoomDescription
            lblScreenSize.Text = RoomClass.RoomScreenSize
            lblFloor.Text = RoomClass.RoomFloor
            lblFullDayCostWD.Text = RoomClass.RoomFullDayPriceWD
            lblFullDayCostWE.Text = RoomClass.RoomFullDayPriceWE
            lblRoomCapacity.Text = RoomClass.RoomMaxCapacity
            lblRoomNotes.Text = RoomClass.RoomNotes
        End If
        newloaded = 1

    End Sub

    Private Sub frmBookingMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RoomDictionary As New Dictionary(Of String, String)
        ' set up employee id '''''''''''''''''''''''''''''''''''''''
        lblUsername.Text = GetEmployee_Username


        ''''''''''''''''''''''''''''''''''''
        BookingClass.GetRoomType(RoomDictionary)
        cmbxRoomName.DisplayMember = "Value"
        cmbxRoomName.ValueMember = "Key"
        newloaded = 0
        cmbxRoomName.DataSource = New BindingSource(RoomDictionary, Nothing)

        'set up the dgv for all of the equipment and food items in the database
        BookingClass.SetUpEquipmentGrid(gridAllEquipment)
        BookingClass.SetUpFoodGrid(gridAllFood)

        If NewRecord Then

            'BookingClass.GetRoomType(cmbxRoomName)
            '''''''''''''''''''''''''''''''''''''
            lblBookingID.Text = GetNextBookingID()

        Else
            btnSaveChanges.Enabled = True
            ' get details from Booking table in database where ID = [selected ID from dgv on ScheduledBookings]
            BookingClass.GetBookingDetails()

            ' set up controls on Booking Details tab with data retrieved from previous routine
            lblBookingID.Text = BookingClass.BookingID
            txtMeetingTitle.Text = BookingClass.BookingTitle
            txtGroupName.Text = BookingClass.BookingGroupName
            txtLecturerName.Text = BookingClass.BookingLecturerName
            txtTelephoneNumber.Text = BookingClass.BookingTelephoneNumber
            txtPeople.Text = BookingClass.BookingNumberOfPeople
            txtCars.Text = BookingClass.BookingNumberOfCars
            cbSecurity.Checked = BookingClass.BookingSecurityRequired
            cbScreenRequired.Checked = BookingClass.BookingSmartScreenRequired
            dtpDate.Value = BookingClass.BookingRequestedDate
            cmbxStartTime.SelectedItem = BookingClass.BookingStartTime
            cmbxEndTime.SelectedItem = BookingClass.BookingEndTime

            dtpDateConfirmed.Value = BookingClass.BookingConfirmationDate
            lblTotalPrice.Text = BookingClass.BookingTotalPrice
            txtNotes.Text = BookingClass.BookingNotes

            ' checking if the value of confirmed is true or not and assigning the correct selected item
            If BookingClass.BookingConfirmed Then
                cmbxConfirmed.SelectedItem = "Confirmed"
            Else
                cmbxConfirmed.SelectedItem = "Unconfirmed"
            End If

            ' need to load [pay by hour] or [pay full day] into form
            If BookingClass.BookingPaymentChoice = "F" Then
                radPayFullDay.Checked = True
            Else
                radPayHourly.Checked = True
            End If

            ' after combo box has been populated by dictionary set the selected value to what was retrieved from Booking table
            cmbxRoomName.SelectedValue = BookingClass.BookingRoomID

            ' pass the retrieved customer ID into search text box and get client details then add the name retrieved to the booking details tab
            txtSearchClientID.Text = BookingClass.BookingCustomerID
            BookingClass.GetClientName(txtSearchClientID.Text, ClientClass)
            lblClientName.Text = ClientClass.PersonFirstName & " " & ClientClass.PersonSurname
            lblBookingClient.Text = lblClientName.Text



            ' load all equipment items booked into selected equipment dgv
            EquipmentOptionClass.GetEquipmentOptionDetails(gridSelectedEquipment)
            Dim RowNum As Integer
            RowNum = gridSelectedEquipment.Rows.Count()
            For i = 0 To (RowNum - 1)
                gridSelectedEquipment.Rows(i).Cells(1).Value = EquipmentOptionClass.GetEquipmentName(gridSelectedEquipment.Rows(i).Cells(0).Value)
                lstEquipment.Items.Add(gridSelectedEquipment.Rows(i).Cells(1).Value)
            Next

            ' load all food items booked into selected food dgv
            FoodOptionClass.GetFoodOptionDetails(gridSelectedFood)
            RowNum = gridSelectedFood.Rows.Count()
            For i = 0 To (RowNum - 1)
                gridSelectedFood.Rows(i).Cells(1).Value = FoodOptionClass.GetFoodName(gridSelectedFood.Rows(i).Cells(0).Value)
                lstCatering.Items.Add(gridSelectedFood.Rows(i).Cells(1).Value)
            Next

        End If
    End Sub

    Private Sub btnSelectRoom_Click(sender As Object, e As EventArgs) Handles btnSelectRoom.Click
        frmOptimisedRoom.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddEquipmentItemToBooking.Click
        ' when button clicked 
        ' - add equipment name to the list box of equipment
        ' - make a note of the item selected, quantity and total price 
        ' - DO NOT add to EquipmentOption Table 
        ' - ADD items to selected grid and read from that when adding to booking table
        ' - when 'make booking' button clicked ADD to table along with data that will do in the Booking table

        For i = 0 To EqGridIndex
            lstEquipment.Items.Add(gridSelectedEquipment.Rows(i).Cells(1).Value.ToString)
        Next
    End Sub

    Private Sub btnSelectItem_Click(sender As Object, e As EventArgs) Handles btnSelectEquipmentItem.Click
        ' if an equipment item has been chosen from the left grid view then add to the right grid
        ' once the user has entered the amount and hit the button it will become part of the grid on the right
        gridSelectedEquipment.Rows.Add(lblHiddenID1.Text, lblEquipmentName.Text, "1", lblPrice1.Text)
        EqGridIndex += 1
        btnSelectEquipmentItem.Enabled = False

    End Sub

    Private Sub gridAllEquipment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAllEquipment.CellContentClick
        Dim EquipmentID As String = gridAllEquipment.SelectedRows(0).Cells(0).Value.ToString

        EquipmentClass.EquipmentID = EquipmentID
        EquipmentClass.GetEquipmentDetails()

        lblHiddenID1.Text = EquipmentID
        lblEquipmentName.Text = EquipmentClass.EquipmentName
        lblQuantity.Text = EquipmentClass.EquipmentQuantity
        lblPrice1.Text = EquipmentClass.EquipmentPrice
        lblEquipmentNotes.Text = EquipmentClass.EquipmentNotes

    End Sub

    Private Sub gridAllFoodInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAllFood.CellContentClick
        Dim FoodID As String = gridAllFood.SelectedRows(0).Cells(0).Value.ToString

        FoodClass.FoodID = FoodID
        FoodClass.GetFoodDetails()

        lblHiddenID2.Text = FoodID
        lblFoodName.Text = FoodClass.FoodName
        lblFoodDescription.Text = FoodClass.FoodDescription
        lblPrice2.Text = FoodClass.FoodPrice
        lblFoodNotes.Text = FoodClass.FoodNotes

    End Sub

    Private Sub btnSelectFoodItem_Click(sender As Object, e As EventArgs) Handles btnSelectFoodItem.Click
        ' if a food item has been chosen from the left grid view then add to the right grid
        ' once the user has entered the amount and hit the ' + ' button it will become part of the grid on the right
        gridSelectedFood.Rows.Add(lblHiddenID2.Text, lblFoodName.Text, "1", lblPrice2.Text)
        FoGridIndex += 1
        btnSelectFoodItem.Enabled = False

    End Sub

    Private Sub btnAddEquipmentQuantity_Click(sender As Object, e As EventArgs) Handles btnAddEquipmentQuantity.Click
        gridSelectedEquipment.Rows(EqGridIndex).Cells(2).Value = txtEquipmentQuantity.Text
        gridSelectedEquipment.Rows(EqGridIndex).Cells(3).Value = CInt(txtEquipmentQuantity.Text) * CDec(lblPrice1.Text)
        btnSelectEquipmentItem.Enabled = True
        txtEquipmentQuantity.Text = ""

        For i = 0 To EqGridIndex
            EquipmentTotal += CDec(gridSelectedEquipment.Rows(i).Cells(3).Value)
        Next
        lblEquipmentPrice.Text = EquipmentTotal

    End Sub

    Private Sub btnAddFoodQuantity_Click(sender As Object, e As EventArgs) Handles btnAddFoodQuantity.Click
        Dim FoodTotal As Single = 0
        gridSelectedFood.Rows(FoGridIndex).Cells(2).Value = txtFoodQuantity.Text
        gridSelectedFood.Rows(FoGridIndex).Cells(3).Value = CInt(txtFoodQuantity.Text) * CDec(lblPrice2.Text)
        btnSelectFoodItem.Enabled = True
        txtFoodQuantity.Text = ""

        For i = 0 To FoGridIndex
            FoodTotal += CDec(gridSelectedFood.Rows(i).Cells(3).Value)
        Next
        lblFoodPrice.Text = FoodTotal
    End Sub

    Private Sub btnAddFoodItemToBooking_Click(sender As Object, e As EventArgs) Handles btnAddFoodItemToBooking.Click
        For i = 0 To FoGridIndex
            lstCatering.Items.Add(gridSelectedFood.Rows(i).Cells(1).Value.ToString)
        Next
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        GetLoadDate = dtpDate.Value
    End Sub

    Private Sub cmbxStartTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxStartTime.SelectedIndexChanged
        GetLoadStartTime = cmbxStartTime.SelectedItem.ToString
    End Sub

    Private Sub cmbxEndTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxEndTime.SelectedIndexChanged
        GetLoadEndTime = cmbxEndTime.SelectedItem.ToString
    End Sub

    Private Sub radPayHourly_CheckedChanged(sender As Object, e As EventArgs) Handles radPayHourly.CheckedChanged
        btnCalculatePrice.Enabled = True
        btnAddBooking.Enabled = True
    End Sub

    Private Sub radPayFullDay_CheckedChanged(sender As Object, e As EventArgs) Handles radPayFullDay.CheckedChanged
        btnCalculatePrice.Enabled = True
        btnAddBooking.Enabled = True
    End Sub

    Private Sub btnCalculatePrice_Click(sender As Object, e As EventArgs) Handles btnCalculatePrice.Click
        Dim StartTime As String = cmbxStartTime.SelectedItem
        Dim EndTime As String = cmbxEndTime.SelectedItem
        Dim duration As TimeSpan = (TimeSpan.Parse(EndTime) - TimeSpan.Parse(StartTime))
        If radPayHourly.Checked Then
            RoomPrice = duration.TotalHours * CDec(lblHourlyCost.Text)
        Else
            Dim i As Integer = dtpDate.Value.DayOfWeek
            If i = 0 Or i = 6 Then
                RoomPrice = CDec(lblFullDayCostWE.Text)
            Else
                RoomPrice = CDec(lblFullDayCostWD.Text)
            End If
        End If


        TotalPrice = RoomPrice + CDec(lblEquipmentPrice.Text) + CDec(lblFoodPrice.Text)
        lblTotalPrice.Text = TotalPrice

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

    End Sub


    Private Function GetNextBookingID() As String
        Dim table As String = "Booking"
        Dim BookingID As String = "B"
        Dim LastID As Integer
        LastID = CInt(GetMaxID(table))
        BookingID = BookingID & ((LastID + 1).ToString("D5"))
        Return BookingID
    End Function

    Private Sub cmbxConfirmed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxConfirmed.SelectedIndexChanged
        If cmbxConfirmed.SelectedItem = "Confirmed" Then
            dtpDateConfirmed.Visible = True
        Else
            dtpDateConfirmed.Visible = False
        End If
    End Sub
End Class