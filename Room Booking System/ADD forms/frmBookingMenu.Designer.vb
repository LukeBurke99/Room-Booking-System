<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcBooking = New System.Windows.Forms.TabControl()
        Me.BookingDetails = New System.Windows.Forms.TabPage()
        Me.btnCalculatePrice = New System.Windows.Forms.Button()
        Me.radPayFullDay = New System.Windows.Forms.RadioButton()
        Me.radPayHourly = New System.Windows.Forms.RadioButton()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpDateConfirmed = New System.Windows.Forms.DateTimePicker()
        Me.cmbxConfirmed = New System.Windows.Forms.ComboBox()
        Me.btnAddCatering = New System.Windows.Forms.Button()
        Me.btnAddEquipment = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lstCatering = New System.Windows.Forms.ListBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lstEquipment = New System.Windows.Forms.ListBox()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.lblBookingClient = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PanelRoom = New System.Windows.Forms.Panel()
        Me.lblRoomCapacity = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lblFullDayCostWE = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSelectRoom = New System.Windows.Forms.Button()
        Me.lblRoomNotes = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblScreenSize = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFullDayCostWD = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblHourlyCost = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbxRoomName = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelDateTime = New System.Windows.Forms.Panel()
        Me.cmbxEndTime = New System.Windows.Forms.ComboBox()
        Me.cmbxStartTime = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cbScreenRequired = New System.Windows.Forms.CheckBox()
        Me.cbSecurity = New System.Windows.Forms.CheckBox()
        Me.txtCars = New System.Windows.Forms.TextBox()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLecturerName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMeetingTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Clients = New System.Windows.Forms.TabPage()
        Me.radSearchViaClientID = New System.Windows.Forms.RadioButton()
        Me.radSearchViaClientName = New System.Windows.Forms.RadioButton()
        Me.btnAddClientToBooking = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtClientTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtSearchClientSurname = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblClientNotes2 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblClientEmailAddress2 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblClientPostcode2 = New System.Windows.Forms.Label()
        Me.lblClientAddress2 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnFindClientName = New System.Windows.Forms.Button()
        Me.txtSearchClientFirstName = New System.Windows.Forms.TextBox()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblClientNotes1 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblClientEmailAddress1 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblClientTelephoneNo1 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblClientPostcode1 = New System.Windows.Forms.Label()
        Me.lblClientAddress1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnFindClientID = New System.Windows.Forms.Button()
        Me.txtSearchClientID = New System.Windows.Forms.TextBox()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.Equipment = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAddEquipmentQuantity = New System.Windows.Forms.Button()
        Me.btnAddEquipmentItemToBooking = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblEquipmentPrice = New System.Windows.Forms.Label()
        Me.txtEquipmentQuantity = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.gridSelectedEquipment = New System.Windows.Forms.DataGridView()
        Me.ColumnEquipmentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEquipmentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEquipmentQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEquipmentPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblHiddenID1 = New System.Windows.Forms.Label()
        Me.btnSelectEquipmentItem = New System.Windows.Forms.Button()
        Me.lblEquipmentNotes = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblEquipmentName = New System.Windows.Forms.Label()
        Me.gridAllEquipment = New System.Windows.Forms.DataGridView()
        Me.Catering = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnAddFoodQuantity = New System.Windows.Forms.Button()
        Me.btnAddFoodItemToBooking = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lblFoodPrice = New System.Windows.Forms.Label()
        Me.txtFoodQuantity = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.gridSelectedFood = New System.Windows.Forms.DataGridView()
        Me.ColumnFoodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFoodQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFoodPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblHiddenID2 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lblFoodDescription = New System.Windows.Forms.Label()
        Me.btnSelectFoodItem = New System.Windows.Forms.Button()
        Me.lblFoodNotes = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.gridAllFood = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.tcBooking.SuspendLayout()
        Me.BookingDetails.SuspendLayout()
        Me.PanelRoom.SuspendLayout()
        Me.PanelDateTime.SuspendLayout()
        Me.Clients.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Equipment.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gridSelectedEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridAllEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Catering.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.gridSelectedFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.gridAllFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(720, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'tcBooking
        '
        Me.tcBooking.Controls.Add(Me.BookingDetails)
        Me.tcBooking.Controls.Add(Me.Clients)
        Me.tcBooking.Controls.Add(Me.Equipment)
        Me.tcBooking.Controls.Add(Me.Catering)
        Me.tcBooking.Location = New System.Drawing.Point(15, 50)
        Me.tcBooking.Name = "tcBooking"
        Me.tcBooking.SelectedIndex = 0
        Me.tcBooking.Size = New System.Drawing.Size(955, 542)
        Me.tcBooking.TabIndex = 4
        '
        'BookingDetails
        '
        Me.BookingDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BookingDetails.Controls.Add(Me.btnCalculatePrice)
        Me.BookingDetails.Controls.Add(Me.radPayFullDay)
        Me.BookingDetails.Controls.Add(Me.radPayHourly)
        Me.BookingDetails.Controls.Add(Me.lblTotalPrice)
        Me.BookingDetails.Controls.Add(Me.Label21)
        Me.BookingDetails.Controls.Add(Me.Label25)
        Me.BookingDetails.Controls.Add(Me.Label24)
        Me.BookingDetails.Controls.Add(Me.dtpDateConfirmed)
        Me.BookingDetails.Controls.Add(Me.cmbxConfirmed)
        Me.BookingDetails.Controls.Add(Me.btnAddCatering)
        Me.BookingDetails.Controls.Add(Me.btnAddEquipment)
        Me.BookingDetails.Controls.Add(Me.Label23)
        Me.BookingDetails.Controls.Add(Me.lstCatering)
        Me.BookingDetails.Controls.Add(Me.Label22)
        Me.BookingDetails.Controls.Add(Me.lstEquipment)
        Me.BookingDetails.Controls.Add(Me.btnAddClient)
        Me.BookingDetails.Controls.Add(Me.lblBookingClient)
        Me.BookingDetails.Controls.Add(Me.Label20)
        Me.BookingDetails.Controls.Add(Me.txtNotes)
        Me.BookingDetails.Controls.Add(Me.Label19)
        Me.BookingDetails.Controls.Add(Me.PanelRoom)
        Me.BookingDetails.Controls.Add(Me.PanelDateTime)
        Me.BookingDetails.Controls.Add(Me.cbScreenRequired)
        Me.BookingDetails.Controls.Add(Me.cbSecurity)
        Me.BookingDetails.Controls.Add(Me.txtCars)
        Me.BookingDetails.Controls.Add(Me.txtPeople)
        Me.BookingDetails.Controls.Add(Me.Label8)
        Me.BookingDetails.Controls.Add(Me.Label7)
        Me.BookingDetails.Controls.Add(Me.txtTelephoneNumber)
        Me.BookingDetails.Controls.Add(Me.Label6)
        Me.BookingDetails.Controls.Add(Me.txtLecturerName)
        Me.BookingDetails.Controls.Add(Me.Label5)
        Me.BookingDetails.Controls.Add(Me.txtGroupName)
        Me.BookingDetails.Controls.Add(Me.Label4)
        Me.BookingDetails.Controls.Add(Me.txtMeetingTitle)
        Me.BookingDetails.Controls.Add(Me.Label3)
        Me.BookingDetails.Location = New System.Drawing.Point(4, 22)
        Me.BookingDetails.Name = "BookingDetails"
        Me.BookingDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.BookingDetails.Size = New System.Drawing.Size(947, 516)
        Me.BookingDetails.TabIndex = 0
        Me.BookingDetails.Text = "Booking Details"
        '
        'btnCalculatePrice
        '
        Me.btnCalculatePrice.Enabled = False
        Me.btnCalculatePrice.Location = New System.Drawing.Point(629, 462)
        Me.btnCalculatePrice.Name = "btnCalculatePrice"
        Me.btnCalculatePrice.Size = New System.Drawing.Size(95, 40)
        Me.btnCalculatePrice.TabIndex = 34
        Me.btnCalculatePrice.Text = "Calculate Price"
        Me.btnCalculatePrice.UseVisualStyleBackColor = True
        '
        'radPayFullDay
        '
        Me.radPayFullDay.AutoSize = True
        Me.radPayFullDay.Location = New System.Drawing.Point(503, 481)
        Me.radPayFullDay.Name = "radPayFullDay"
        Me.radPayFullDay.Size = New System.Drawing.Size(105, 17)
        Me.radPayFullDay.TabIndex = 33
        Me.radPayFullDay.TabStop = True
        Me.radPayFullDay.Text = "Pay full day price"
        Me.radPayFullDay.UseVisualStyleBackColor = True
        '
        'radPayHourly
        '
        Me.radPayHourly.AutoSize = True
        Me.radPayHourly.Location = New System.Drawing.Point(503, 459)
        Me.radPayHourly.Name = "radPayHourly"
        Me.radPayHourly.Size = New System.Drawing.Size(99, 17)
        Me.radPayHourly.TabIndex = 32
        Me.radPayHourly.TabStop = True
        Me.radPayHourly.Text = "Pay by the hour"
        Me.radPayHourly.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.White
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(818, 462)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(110, 30)
        Me.lblTotalPrice.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(731, 468)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 18)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Total Price"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(760, 399)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 13)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Date Confirmed"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(530, 401)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 13)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Booking Status"
        '
        'dtpDateConfirmed
        '
        Me.dtpDateConfirmed.Location = New System.Drawing.Point(704, 421)
        Me.dtpDateConfirmed.Name = "dtpDateConfirmed"
        Me.dtpDateConfirmed.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateConfirmed.TabIndex = 27
        Me.dtpDateConfirmed.Visible = False
        '
        'cmbxConfirmed
        '
        Me.cmbxConfirmed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxConfirmed.FormattingEnabled = True
        Me.cmbxConfirmed.Items.AddRange(New Object() {"Confirmed", "Unconfirmed"})
        Me.cmbxConfirmed.Location = New System.Drawing.Point(503, 421)
        Me.cmbxConfirmed.Name = "cmbxConfirmed"
        Me.cmbxConfirmed.Size = New System.Drawing.Size(138, 21)
        Me.cmbxConfirmed.TabIndex = 26
        '
        'btnAddCatering
        '
        Me.btnAddCatering.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCatering.Location = New System.Drawing.Point(787, 361)
        Me.btnAddCatering.Name = "btnAddCatering"
        Me.btnAddCatering.Size = New System.Drawing.Size(119, 23)
        Me.btnAddCatering.TabIndex = 25
        Me.btnAddCatering.Text = "Add Catering"
        Me.btnAddCatering.UseVisualStyleBackColor = True
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipment.Location = New System.Drawing.Point(787, 306)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.Size = New System.Drawing.Size(119, 23)
        Me.btnAddEquipment.TabIndex = 24
        Me.btnAddEquipment.Text = "Add Equipment"
        Me.btnAddEquipment.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(490, 351)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 15)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Catering"
        '
        'lstCatering
        '
        Me.lstCatering.FormattingEnabled = True
        Me.lstCatering.Location = New System.Drawing.Point(600, 351)
        Me.lstCatering.Name = "lstCatering"
        Me.lstCatering.Size = New System.Drawing.Size(140, 43)
        Me.lstCatering.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(490, 295)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 15)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Equipment"
        '
        'lstEquipment
        '
        Me.lstEquipment.FormattingEnabled = True
        Me.lstEquipment.Location = New System.Drawing.Point(600, 295)
        Me.lstEquipment.Name = "lstEquipment"
        Me.lstEquipment.Size = New System.Drawing.Size(140, 43)
        Me.lstEquipment.TabIndex = 20
        '
        'btnAddClient
        '
        Me.btnAddClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.Location = New System.Drawing.Point(787, 257)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(119, 23)
        Me.btnAddClient.TabIndex = 19
        Me.btnAddClient.Text = "Select Client"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'lblBookingClient
        '
        Me.lblBookingClient.BackColor = System.Drawing.SystemColors.Control
        Me.lblBookingClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBookingClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingClient.Location = New System.Drawing.Point(600, 260)
        Me.lblBookingClient.Name = "lblBookingClient"
        Me.lblBookingClient.Size = New System.Drawing.Size(140, 20)
        Me.lblBookingClient.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(490, 260)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 15)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Booking Client"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(23, 415)
        Me.txtNotes.MaxLength = 300
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(447, 72)
        Me.txtNotes.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 393)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 15)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Booking Notes"
        '
        'PanelRoom
        '
        Me.PanelRoom.BackColor = System.Drawing.SystemColors.Control
        Me.PanelRoom.Controls.Add(Me.lblRoomCapacity)
        Me.PanelRoom.Controls.Add(Me.Label51)
        Me.PanelRoom.Controls.Add(Me.lblFullDayCostWE)
        Me.PanelRoom.Controls.Add(Me.Label38)
        Me.PanelRoom.Controls.Add(Me.lblFloor)
        Me.PanelRoom.Controls.Add(Me.Label18)
        Me.PanelRoom.Controls.Add(Me.btnSelectRoom)
        Me.PanelRoom.Controls.Add(Me.lblRoomNotes)
        Me.PanelRoom.Controls.Add(Me.Label17)
        Me.PanelRoom.Controls.Add(Me.lblDescription)
        Me.PanelRoom.Controls.Add(Me.lblScreenSize)
        Me.PanelRoom.Controls.Add(Me.Label15)
        Me.PanelRoom.Controls.Add(Me.lblFullDayCostWD)
        Me.PanelRoom.Controls.Add(Me.Label16)
        Me.PanelRoom.Controls.Add(Me.lblHourlyCost)
        Me.PanelRoom.Controls.Add(Me.Label14)
        Me.PanelRoom.Controls.Add(Me.cmbxRoomName)
        Me.PanelRoom.Controls.Add(Me.Label13)
        Me.PanelRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRoom.Location = New System.Drawing.Point(20, 110)
        Me.PanelRoom.Name = "PanelRoom"
        Me.PanelRoom.Size = New System.Drawing.Size(450, 271)
        Me.PanelRoom.TabIndex = 15
        '
        'lblRoomCapacity
        '
        Me.lblRoomCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRoomCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCapacity.Location = New System.Drawing.Point(245, 154)
        Me.lblRoomCapacity.Name = "lblRoomCapacity"
        Me.lblRoomCapacity.Size = New System.Drawing.Size(35, 20)
        Me.lblRoomCapacity.TabIndex = 18
        Me.lblRoomCapacity.Text = "0"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(153, 154)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(90, 15)
        Me.Label51.TabIndex = 17
        Me.Label51.Text = "Room Capacity"
        '
        'lblFullDayCostWE
        '
        Me.lblFullDayCostWE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFullDayCostWE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullDayCostWE.Location = New System.Drawing.Point(340, 117)
        Me.lblFullDayCostWE.Name = "lblFullDayCostWE"
        Me.lblFullDayCostWE.Size = New System.Drawing.Size(80, 20)
        Me.lblFullDayCostWE.TabIndex = 16
        Me.lblFullDayCostWE.Text = "0.00"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(230, 117)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(101, 15)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "Full-Day Cost WE"
        '
        'lblFloor
        '
        Me.lblFloor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFloor.Location = New System.Drawing.Point(100, 117)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(94, 20)
        Me.lblFloor.TabIndex = 14
        Me.lblFloor.Text = "N / A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Floor"
        '
        'btnSelectRoom
        '
        Me.btnSelectRoom.Location = New System.Drawing.Point(263, 242)
        Me.btnSelectRoom.Name = "btnSelectRoom"
        Me.btnSelectRoom.Size = New System.Drawing.Size(146, 23)
        Me.btnSelectRoom.TabIndex = 12
        Me.btnSelectRoom.Text = "Select Optimised Room"
        Me.btnSelectRoom.UseVisualStyleBackColor = True
        '
        'lblRoomNotes
        '
        Me.lblRoomNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRoomNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomNotes.Location = New System.Drawing.Point(20, 184)
        Me.lblRoomNotes.Name = "lblRoomNotes"
        Me.lblRoomNotes.Size = New System.Drawing.Size(389, 51)
        Me.lblRoomNotes.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 15)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Room Notes"
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(20, 53)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(389, 20)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description"
        '
        'lblScreenSize
        '
        Me.lblScreenSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblScreenSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScreenSize.Location = New System.Drawing.Point(100, 89)
        Me.lblScreenSize.Name = "lblScreenSize"
        Me.lblScreenSize.Size = New System.Drawing.Size(94, 20)
        Me.lblScreenSize.TabIndex = 7
        Me.lblScreenSize.Text = "N / A"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 15)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Screen Size"
        '
        'lblFullDayCostWD
        '
        Me.lblFullDayCostWD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFullDayCostWD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullDayCostWD.Location = New System.Drawing.Point(340, 89)
        Me.lblFullDayCostWD.Name = "lblFullDayCostWD"
        Me.lblFullDayCostWD.Size = New System.Drawing.Size(80, 20)
        Me.lblFullDayCostWD.TabIndex = 5
        Me.lblFullDayCostWD.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(230, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Full-Day Cost WD"
        '
        'lblHourlyCost
        '
        Me.lblHourlyCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblHourlyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHourlyCost.Location = New System.Drawing.Point(340, 15)
        Me.lblHourlyCost.Name = "lblHourlyCost"
        Me.lblHourlyCost.Size = New System.Drawing.Size(80, 20)
        Me.lblHourlyCost.TabIndex = 3
        Me.lblHourlyCost.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(250, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Hourly Cost"
        '
        'cmbxRoomName
        '
        Me.cmbxRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRoomName.FormattingEnabled = True
        Me.cmbxRoomName.Location = New System.Drawing.Point(100, 15)
        Me.cmbxRoomName.Name = "cmbxRoomName"
        Me.cmbxRoomName.Size = New System.Drawing.Size(121, 23)
        Me.cmbxRoomName.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Room Name"
        '
        'PanelDateTime
        '
        Me.PanelDateTime.BackColor = System.Drawing.SystemColors.Control
        Me.PanelDateTime.Controls.Add(Me.cmbxEndTime)
        Me.PanelDateTime.Controls.Add(Me.cmbxStartTime)
        Me.PanelDateTime.Controls.Add(Me.Label12)
        Me.PanelDateTime.Controls.Add(Me.Label11)
        Me.PanelDateTime.Controls.Add(Me.Label10)
        Me.PanelDateTime.Controls.Add(Me.Label9)
        Me.PanelDateTime.Controls.Add(Me.dtpDate)
        Me.PanelDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDateTime.Location = New System.Drawing.Point(480, 110)
        Me.PanelDateTime.Name = "PanelDateTime"
        Me.PanelDateTime.Size = New System.Drawing.Size(450, 140)
        Me.PanelDateTime.TabIndex = 14
        '
        'cmbxEndTime
        '
        Me.cmbxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEndTime.FormattingEnabled = True
        Me.cmbxEndTime.Items.AddRange(New Object() {"08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00"})
        Me.cmbxEndTime.Location = New System.Drawing.Point(335, 85)
        Me.cmbxEndTime.Name = "cmbxEndTime"
        Me.cmbxEndTime.Size = New System.Drawing.Size(91, 23)
        Me.cmbxEndTime.TabIndex = 6
        '
        'cmbxStartTime
        '
        Me.cmbxStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStartTime.FormattingEnabled = True
        Me.cmbxStartTime.Items.AddRange(New Object() {"08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00"})
        Me.cmbxStartTime.Location = New System.Drawing.Point(70, 85)
        Me.cmbxStartTime.Name = "cmbxStartTime"
        Me.cmbxStartTime.Size = New System.Drawing.Size(91, 23)
        Me.cmbxStartTime.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(280, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Finish"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Start"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(200, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Times:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(149, 20)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(180, 21)
        Me.dtpDate.TabIndex = 0
        '
        'cbScreenRequired
        '
        Me.cbScreenRequired.AutoSize = True
        Me.cbScreenRequired.Location = New System.Drawing.Point(360, 70)
        Me.cbScreenRequired.Name = "cbScreenRequired"
        Me.cbScreenRequired.Size = New System.Drawing.Size(136, 17)
        Me.cbScreenRequired.TabIndex = 13
        Me.cbScreenRequired.Text = "Smart Screen Required"
        Me.cbScreenRequired.UseVisualStyleBackColor = True
        '
        'cbSecurity
        '
        Me.cbSecurity.AutoSize = True
        Me.cbSecurity.Location = New System.Drawing.Point(360, 50)
        Me.cbSecurity.Name = "cbSecurity"
        Me.cbSecurity.Size = New System.Drawing.Size(110, 17)
        Me.cbSecurity.TabIndex = 12
        Me.cbSecurity.Text = "Security Required"
        Me.cbSecurity.UseVisualStyleBackColor = True
        '
        'txtCars
        '
        Me.txtCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCars.Location = New System.Drawing.Point(720, 80)
        Me.txtCars.Name = "txtCars"
        Me.txtCars.Size = New System.Drawing.Size(46, 21)
        Me.txtCars.TabIndex = 11
        '
        'txtPeople
        '
        Me.txtPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeople.Location = New System.Drawing.Point(720, 55)
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(46, 21)
        Me.txtPeople.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(530, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "No. of Car Spaces Req."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(530, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "No. of People Attending"
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(720, 30)
        Me.txtTelephoneNumber.MaxLength = 11
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(200, 21)
        Me.txtTelephoneNumber.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(530, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Alternative Telephone Number"
        '
        'txtLecturerName
        '
        Me.txtLecturerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecturerName.Location = New System.Drawing.Point(120, 80)
        Me.txtLecturerName.MaxLength = 80
        Me.txtLecturerName.Name = "txtLecturerName"
        Me.txtLecturerName.Size = New System.Drawing.Size(200, 21)
        Me.txtLecturerName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lecturer Name"
        '
        'txtGroupName
        '
        Me.txtGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.Location = New System.Drawing.Point(120, 55)
        Me.txtGroupName.MaxLength = 30
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(200, 21)
        Me.txtGroupName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Group Name"
        '
        'txtMeetingTitle
        '
        Me.txtMeetingTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeetingTitle.Location = New System.Drawing.Point(120, 30)
        Me.txtMeetingTitle.MaxLength = 30
        Me.txtMeetingTitle.Name = "txtMeetingTitle"
        Me.txtMeetingTitle.Size = New System.Drawing.Size(200, 21)
        Me.txtMeetingTitle.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Meeting Title"
        '
        'Clients
        '
        Me.Clients.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Clients.Controls.Add(Me.radSearchViaClientID)
        Me.Clients.Controls.Add(Me.radSearchViaClientName)
        Me.Clients.Controls.Add(Me.btnAddClientToBooking)
        Me.Clients.Controls.Add(Me.GroupBox2)
        Me.Clients.Controls.Add(Me.GroupBox1)
        Me.Clients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clients.Location = New System.Drawing.Point(4, 22)
        Me.Clients.Name = "Clients"
        Me.Clients.Padding = New System.Windows.Forms.Padding(3)
        Me.Clients.Size = New System.Drawing.Size(947, 516)
        Me.Clients.TabIndex = 1
        Me.Clients.Text = "Client Details"
        '
        'radSearchViaClientID
        '
        Me.radSearchViaClientID.AutoSize = True
        Me.radSearchViaClientID.Enabled = False
        Me.radSearchViaClientID.Location = New System.Drawing.Point(205, 450)
        Me.radSearchViaClientID.Name = "radSearchViaClientID"
        Me.radSearchViaClientID.Size = New System.Drawing.Size(131, 19)
        Me.radSearchViaClientID.TabIndex = 22
        Me.radSearchViaClientID.Text = "Search via Client ID"
        Me.radSearchViaClientID.UseVisualStyleBackColor = True
        '
        'radSearchViaClientName
        '
        Me.radSearchViaClientName.AutoSize = True
        Me.radSearchViaClientName.Enabled = False
        Me.radSearchViaClientName.Location = New System.Drawing.Point(205, 479)
        Me.radSearchViaClientName.Name = "radSearchViaClientName"
        Me.radSearchViaClientName.Size = New System.Drawing.Size(153, 19)
        Me.radSearchViaClientName.TabIndex = 21
        Me.radSearchViaClientName.Text = "Search via Client Name"
        Me.radSearchViaClientName.UseVisualStyleBackColor = True
        '
        'btnAddClientToBooking
        '
        Me.btnAddClientToBooking.Enabled = False
        Me.btnAddClientToBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClientToBooking.Location = New System.Drawing.Point(20, 462)
        Me.btnAddClientToBooking.Name = "btnAddClientToBooking"
        Me.btnAddClientToBooking.Size = New System.Drawing.Size(170, 30)
        Me.btnAddClientToBooking.TabIndex = 20
        Me.btnAddClientToBooking.Text = "Add Client to Booking"
        Me.btnAddClientToBooking.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtClientTelephoneNumber)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtSearchClientSurname)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.lblClientNotes2)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.lblClientEmailAddress2)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.lblClientPostcode2)
        Me.GroupBox2.Controls.Add(Me.lblClientAddress2)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.btnFindClientName)
        Me.GroupBox2.Controls.Add(Me.txtSearchClientFirstName)
        Me.GroupBox2.Controls.Add(Me.lblClientID)
        Me.GroupBox2.Location = New System.Drawing.Point(490, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 429)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search via client name"
        '
        'txtClientTelephoneNumber
        '
        Me.txtClientTelephoneNumber.Location = New System.Drawing.Point(134, 90)
        Me.txtClientTelephoneNumber.MaxLength = 11
        Me.txtClientTelephoneNumber.Name = "txtClientTelephoneNumber"
        Me.txtClientTelephoneNumber.Size = New System.Drawing.Size(281, 21)
        Me.txtClientTelephoneNumber.TabIndex = 38
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(26, 63)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(92, 15)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "Client Surname"
        '
        'txtSearchClientSurname
        '
        Me.txtSearchClientSurname.Location = New System.Drawing.Point(134, 60)
        Me.txtSearchClientSurname.MaxLength = 40
        Me.txtSearchClientSurname.Name = "txtSearchClientSurname"
        Me.txtSearchClientSurname.Size = New System.Drawing.Size(281, 21)
        Me.txtSearchClientSurname.TabIndex = 36
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(26, 287)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 15)
        Me.Label33.TabIndex = 35
        Me.Label33.Text = "Notes"
        '
        'lblClientNotes2
        '
        Me.lblClientNotes2.BackColor = System.Drawing.Color.White
        Me.lblClientNotes2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientNotes2.Location = New System.Drawing.Point(131, 287)
        Me.lblClientNotes2.Name = "lblClientNotes2"
        Me.lblClientNotes2.Size = New System.Drawing.Size(284, 130)
        Me.lblClientNotes2.TabIndex = 34
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(26, 252)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 15)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Email Address"
        '
        'lblClientEmailAddress2
        '
        Me.lblClientEmailAddress2.BackColor = System.Drawing.Color.White
        Me.lblClientEmailAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientEmailAddress2.Location = New System.Drawing.Point(131, 252)
        Me.lblClientEmailAddress2.Name = "lblClientEmailAddress2"
        Me.lblClientEmailAddress2.Size = New System.Drawing.Size(185, 20)
        Me.lblClientEmailAddress2.TabIndex = 32
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(26, 90)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 15)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = "Telephone No."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(26, 218)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(58, 15)
        Me.Label39.TabIndex = 29
        Me.Label39.Text = "Postcode"
        '
        'lblClientPostcode2
        '
        Me.lblClientPostcode2.BackColor = System.Drawing.Color.White
        Me.lblClientPostcode2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientPostcode2.Location = New System.Drawing.Point(131, 218)
        Me.lblClientPostcode2.Name = "lblClientPostcode2"
        Me.lblClientPostcode2.Size = New System.Drawing.Size(185, 20)
        Me.lblClientPostcode2.TabIndex = 28
        '
        'lblClientAddress2
        '
        Me.lblClientAddress2.BackColor = System.Drawing.Color.White
        Me.lblClientAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientAddress2.Location = New System.Drawing.Point(131, 183)
        Me.lblClientAddress2.Name = "lblClientAddress2"
        Me.lblClientAddress2.Size = New System.Drawing.Size(284, 20)
        Me.lblClientAddress2.TabIndex = 27
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(26, 183)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(51, 15)
        Me.Label42.TabIndex = 26
        Me.Label42.Text = "Address"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(26, 151)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 15)
        Me.Label43.TabIndex = 24
        Me.Label43.Text = "Client ID"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(26, 35)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(101, 15)
        Me.Label44.TabIndex = 25
        Me.Label44.Text = "Client First Name"
        '
        'btnFindClientName
        '
        Me.btnFindClientName.Location = New System.Drawing.Point(234, 118)
        Me.btnFindClientName.Name = "btnFindClientName"
        Me.btnFindClientName.Size = New System.Drawing.Size(89, 24)
        Me.btnFindClientName.TabIndex = 21
        Me.btnFindClientName.Text = "Find Client"
        Me.btnFindClientName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFindClientName.UseVisualStyleBackColor = True
        '
        'txtSearchClientFirstName
        '
        Me.txtSearchClientFirstName.Location = New System.Drawing.Point(134, 32)
        Me.txtSearchClientFirstName.MaxLength = 30
        Me.txtSearchClientFirstName.Name = "txtSearchClientFirstName"
        Me.txtSearchClientFirstName.Size = New System.Drawing.Size(281, 21)
        Me.txtSearchClientFirstName.TabIndex = 22
        '
        'lblClientID
        '
        Me.lblClientID.BackColor = System.Drawing.Color.White
        Me.lblClientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientID.Location = New System.Drawing.Point(131, 148)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(89, 20)
        Me.lblClientID.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.lblClientNotes1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.lblClientEmailAddress1)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.lblClientTelephoneNo1)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.lblClientPostcode1)
        Me.GroupBox1.Controls.Add(Me.lblClientAddress1)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.btnFindClientID)
        Me.GroupBox1.Controls.Add(Me.txtSearchClientID)
        Me.GroupBox1.Controls.Add(Me.lblClientName)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 429)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search via client ID"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(15, 285)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 15)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Notes"
        '
        'lblClientNotes1
        '
        Me.lblClientNotes1.BackColor = System.Drawing.Color.White
        Me.lblClientNotes1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientNotes1.Location = New System.Drawing.Point(120, 285)
        Me.lblClientNotes1.Name = "lblClientNotes1"
        Me.lblClientNotes1.Size = New System.Drawing.Size(284, 130)
        Me.lblClientNotes1.TabIndex = 13
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(15, 250)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 15)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Email Address"
        '
        'lblClientEmailAddress1
        '
        Me.lblClientEmailAddress1.BackColor = System.Drawing.Color.White
        Me.lblClientEmailAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientEmailAddress1.Location = New System.Drawing.Point(120, 250)
        Me.lblClientEmailAddress1.Name = "lblClientEmailAddress1"
        Me.lblClientEmailAddress1.Size = New System.Drawing.Size(185, 20)
        Me.lblClientEmailAddress1.TabIndex = 11
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(15, 215)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 15)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Telephone No."
        '
        'lblClientTelephoneNo1
        '
        Me.lblClientTelephoneNo1.BackColor = System.Drawing.Color.White
        Me.lblClientTelephoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientTelephoneNo1.Location = New System.Drawing.Point(120, 215)
        Me.lblClientTelephoneNo1.Name = "lblClientTelephoneNo1"
        Me.lblClientTelephoneNo1.Size = New System.Drawing.Size(185, 20)
        Me.lblClientTelephoneNo1.TabIndex = 9
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(15, 180)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 15)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Postcode"
        '
        'lblClientPostcode1
        '
        Me.lblClientPostcode1.BackColor = System.Drawing.Color.White
        Me.lblClientPostcode1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientPostcode1.Location = New System.Drawing.Point(120, 180)
        Me.lblClientPostcode1.Name = "lblClientPostcode1"
        Me.lblClientPostcode1.Size = New System.Drawing.Size(185, 20)
        Me.lblClientPostcode1.TabIndex = 7
        '
        'lblClientAddress1
        '
        Me.lblClientAddress1.BackColor = System.Drawing.Color.White
        Me.lblClientAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientAddress1.Location = New System.Drawing.Point(120, 145)
        Me.lblClientAddress1.Name = "lblClientAddress1"
        Me.lblClientAddress1.Size = New System.Drawing.Size(284, 20)
        Me.lblClientAddress1.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(15, 145)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 15)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Address"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(17, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 15)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Client ID"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(15, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 15)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Client Name"
        '
        'btnFindClientID
        '
        Me.btnFindClientID.Location = New System.Drawing.Point(262, 40)
        Me.btnFindClientID.Name = "btnFindClientID"
        Me.btnFindClientID.Size = New System.Drawing.Size(89, 21)
        Me.btnFindClientID.TabIndex = 0
        Me.btnFindClientID.Text = "Find Client"
        Me.btnFindClientID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFindClientID.UseVisualStyleBackColor = True
        '
        'txtSearchClientID
        '
        Me.txtSearchClientID.Location = New System.Drawing.Point(120, 40)
        Me.txtSearchClientID.MaxLength = 6
        Me.txtSearchClientID.Name = "txtSearchClientID"
        Me.txtSearchClientID.Size = New System.Drawing.Size(100, 21)
        Me.txtSearchClientID.TabIndex = 1
        '
        'lblClientName
        '
        Me.lblClientName.BackColor = System.Drawing.Color.White
        Me.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientName.Location = New System.Drawing.Point(120, 110)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(185, 20)
        Me.lblClientName.TabIndex = 2
        '
        'Equipment
        '
        Me.Equipment.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Equipment.Controls.Add(Me.GroupBox4)
        Me.Equipment.Controls.Add(Me.GroupBox3)
        Me.Equipment.Location = New System.Drawing.Point(4, 22)
        Me.Equipment.Name = "Equipment"
        Me.Equipment.Padding = New System.Windows.Forms.Padding(3)
        Me.Equipment.Size = New System.Drawing.Size(947, 516)
        Me.Equipment.TabIndex = 2
        Me.Equipment.Text = "Equipment Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAddEquipmentQuantity)
        Me.GroupBox4.Controls.Add(Me.btnAddEquipmentItemToBooking)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.lblEquipmentPrice)
        Me.GroupBox4.Controls.Add(Me.txtEquipmentQuantity)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.gridSelectedEquipment)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(475, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(466, 500)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected Equipment Information"
        '
        'btnAddEquipmentQuantity
        '
        Me.btnAddEquipmentQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipmentQuantity.Location = New System.Drawing.Point(354, 184)
        Me.btnAddEquipmentQuantity.Name = "btnAddEquipmentQuantity"
        Me.btnAddEquipmentQuantity.Size = New System.Drawing.Size(22, 30)
        Me.btnAddEquipmentQuantity.TabIndex = 14
        Me.btnAddEquipmentQuantity.Text = "+"
        Me.btnAddEquipmentQuantity.UseVisualStyleBackColor = True
        '
        'btnAddEquipmentItemToBooking
        '
        Me.btnAddEquipmentItemToBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipmentItemToBooking.Location = New System.Drawing.Point(142, 408)
        Me.btnAddEquipmentItemToBooking.Name = "btnAddEquipmentItemToBooking"
        Me.btnAddEquipmentItemToBooking.Size = New System.Drawing.Size(187, 33)
        Me.btnAddEquipmentItemToBooking.TabIndex = 11
        Me.btnAddEquipmentItemToBooking.Text = "Add Items to Booking"
        Me.btnAddEquipmentItemToBooking.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(48, 275)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(165, 17)
        Me.Label45.TabIndex = 13
        Me.Label45.Text = "Total price of equipment "
        '
        'lblEquipmentPrice
        '
        Me.lblEquipmentPrice.BackColor = System.Drawing.Color.White
        Me.lblEquipmentPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquipmentPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentPrice.Location = New System.Drawing.Point(252, 261)
        Me.lblEquipmentPrice.Name = "lblEquipmentPrice"
        Me.lblEquipmentPrice.Size = New System.Drawing.Size(89, 38)
        Me.lblEquipmentPrice.TabIndex = 11
        Me.lblEquipmentPrice.Text = "0.00"
        Me.lblEquipmentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEquipmentQuantity
        '
        Me.txtEquipmentQuantity.Location = New System.Drawing.Point(248, 188)
        Me.txtEquipmentQuantity.Name = "txtEquipmentQuantity"
        Me.txtEquipmentQuantity.Size = New System.Drawing.Size(100, 23)
        Me.txtEquipmentQuantity.TabIndex = 12
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(19, 190)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(208, 17)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "State the amount you would like"
        '
        'gridSelectedEquipment
        '
        Me.gridSelectedEquipment.AllowUserToAddRows = False
        Me.gridSelectedEquipment.AllowUserToDeleteRows = False
        Me.gridSelectedEquipment.AllowUserToResizeColumns = False
        Me.gridSelectedEquipment.AllowUserToResizeRows = False
        Me.gridSelectedEquipment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridSelectedEquipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridSelectedEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gridSelectedEquipment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnEquipmentID, Me.ColumnEquipmentName, Me.ColumnEquipmentQuantity, Me.ColumnEquipmentPrice})
        Me.gridSelectedEquipment.Location = New System.Drawing.Point(22, 28)
        Me.gridSelectedEquipment.MultiSelect = False
        Me.gridSelectedEquipment.Name = "gridSelectedEquipment"
        Me.gridSelectedEquipment.ReadOnly = True
        Me.gridSelectedEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSelectedEquipment.Size = New System.Drawing.Size(420, 142)
        Me.gridSelectedEquipment.TabIndex = 11
        '
        'ColumnEquipmentID
        '
        Me.ColumnEquipmentID.HeaderText = "Equipment ID"
        Me.ColumnEquipmentID.Name = "ColumnEquipmentID"
        Me.ColumnEquipmentID.ReadOnly = True
        '
        'ColumnEquipmentName
        '
        Me.ColumnEquipmentName.HeaderText = "Name"
        Me.ColumnEquipmentName.Name = "ColumnEquipmentName"
        Me.ColumnEquipmentName.ReadOnly = True
        '
        'ColumnEquipmentQuantity
        '
        Me.ColumnEquipmentQuantity.HeaderText = "Quantity"
        Me.ColumnEquipmentQuantity.Name = "ColumnEquipmentQuantity"
        Me.ColumnEquipmentQuantity.ReadOnly = True
        '
        'ColumnEquipmentPrice
        '
        Me.ColumnEquipmentPrice.HeaderText = "Price"
        Me.ColumnEquipmentPrice.Name = "ColumnEquipmentPrice"
        Me.ColumnEquipmentPrice.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblHiddenID1)
        Me.GroupBox3.Controls.Add(Me.btnSelectEquipmentItem)
        Me.GroupBox3.Controls.Add(Me.lblEquipmentNotes)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.lblPrice1)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.lblQuantity)
        Me.GroupBox3.Controls.Add(Me.lblEquipmentName)
        Me.GroupBox3.Controls.Add(Me.gridAllEquipment)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 500)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "All Equipment Information"
        '
        'lblHiddenID1
        '
        Me.lblHiddenID1.AutoSize = True
        Me.lblHiddenID1.Location = New System.Drawing.Point(291, 28)
        Me.lblHiddenID1.Name = "lblHiddenID1"
        Me.lblHiddenID1.Size = New System.Drawing.Size(92, 17)
        Me.lblHiddenID1.TabIndex = 11
        Me.lblHiddenID1.Text = "Equipment ID"
        Me.lblHiddenID1.Visible = False
        '
        'btnSelectEquipmentItem
        '
        Me.btnSelectEquipmentItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEquipmentItem.Location = New System.Drawing.Point(276, 447)
        Me.btnSelectEquipmentItem.Name = "btnSelectEquipmentItem"
        Me.btnSelectEquipmentItem.Size = New System.Drawing.Size(126, 33)
        Me.btnSelectEquipmentItem.TabIndex = 10
        Me.btnSelectEquipmentItem.Text = "Select Item"
        Me.btnSelectEquipmentItem.UseVisualStyleBackColor = True
        '
        'lblEquipmentNotes
        '
        Me.lblEquipmentNotes.BackColor = System.Drawing.Color.White
        Me.lblEquipmentNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquipmentNotes.Location = New System.Drawing.Point(240, 216)
        Me.lblEquipmentNotes.Name = "lblEquipmentNotes"
        Me.lblEquipmentNotes.Size = New System.Drawing.Size(193, 215)
        Me.lblEquipmentNotes.TabIndex = 9
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(249, 174)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 17)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "Price"
        '
        'lblPrice1
        '
        Me.lblPrice1.BackColor = System.Drawing.Color.White
        Me.lblPrice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice1.Location = New System.Drawing.Point(327, 171)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(89, 23)
        Me.lblPrice1.TabIndex = 7
        Me.lblPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(249, 124)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(61, 17)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Quantity"
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.White
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.Location = New System.Drawing.Point(327, 121)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(89, 23)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEquipmentName
        '
        Me.lblEquipmentName.BackColor = System.Drawing.Color.White
        Me.lblEquipmentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquipmentName.Location = New System.Drawing.Point(240, 78)
        Me.lblEquipmentName.Name = "lblEquipmentName"
        Me.lblEquipmentName.Size = New System.Drawing.Size(193, 23)
        Me.lblEquipmentName.TabIndex = 4
        Me.lblEquipmentName.Text = "Name"
        Me.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridAllEquipment
        '
        Me.gridAllEquipment.AllowUserToAddRows = False
        Me.gridAllEquipment.AllowUserToDeleteRows = False
        Me.gridAllEquipment.AllowUserToResizeColumns = False
        Me.gridAllEquipment.AllowUserToResizeRows = False
        Me.gridAllEquipment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridAllEquipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridAllEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAllEquipment.Location = New System.Drawing.Point(6, 28)
        Me.gridAllEquipment.MultiSelect = False
        Me.gridAllEquipment.Name = "gridAllEquipment"
        Me.gridAllEquipment.ReadOnly = True
        Me.gridAllEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAllEquipment.Size = New System.Drawing.Size(208, 466)
        Me.gridAllEquipment.TabIndex = 3
        '
        'Catering
        '
        Me.Catering.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Catering.Controls.Add(Me.GroupBox6)
        Me.Catering.Controls.Add(Me.GroupBox5)
        Me.Catering.Location = New System.Drawing.Point(4, 22)
        Me.Catering.Name = "Catering"
        Me.Catering.Size = New System.Drawing.Size(947, 516)
        Me.Catering.TabIndex = 3
        Me.Catering.Text = "Catering Details"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnAddFoodQuantity)
        Me.GroupBox6.Controls.Add(Me.btnAddFoodItemToBooking)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.lblFoodPrice)
        Me.GroupBox6.Controls.Add(Me.txtFoodQuantity)
        Me.GroupBox6.Controls.Add(Me.Label50)
        Me.GroupBox6.Controls.Add(Me.gridSelectedFood)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(475, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(466, 500)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Selected Food Information"
        '
        'btnAddFoodQuantity
        '
        Me.btnAddFoodQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFoodQuantity.Location = New System.Drawing.Point(354, 184)
        Me.btnAddFoodQuantity.Name = "btnAddFoodQuantity"
        Me.btnAddFoodQuantity.Size = New System.Drawing.Size(22, 30)
        Me.btnAddFoodQuantity.TabIndex = 34
        Me.btnAddFoodQuantity.Text = "+"
        Me.btnAddFoodQuantity.UseVisualStyleBackColor = True
        '
        'btnAddFoodItemToBooking
        '
        Me.btnAddFoodItemToBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFoodItemToBooking.Location = New System.Drawing.Point(142, 408)
        Me.btnAddFoodItemToBooking.Name = "btnAddFoodItemToBooking"
        Me.btnAddFoodItemToBooking.Size = New System.Drawing.Size(183, 33)
        Me.btnAddFoodItemToBooking.TabIndex = 11
        Me.btnAddFoodItemToBooking.Text = "Add Item to Booking"
        Me.btnAddFoodItemToBooking.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(48, 275)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(123, 17)
        Me.Label46.TabIndex = 13
        Me.Label46.Text = "Total price of food"
        '
        'lblFoodPrice
        '
        Me.lblFoodPrice.BackColor = System.Drawing.Color.White
        Me.lblFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoodPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPrice.Location = New System.Drawing.Point(252, 261)
        Me.lblFoodPrice.Name = "lblFoodPrice"
        Me.lblFoodPrice.Size = New System.Drawing.Size(89, 38)
        Me.lblFoodPrice.TabIndex = 11
        Me.lblFoodPrice.Text = "0.00"
        Me.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFoodQuantity
        '
        Me.txtFoodQuantity.Location = New System.Drawing.Point(248, 188)
        Me.txtFoodQuantity.Name = "txtFoodQuantity"
        Me.txtFoodQuantity.Size = New System.Drawing.Size(100, 23)
        Me.txtFoodQuantity.TabIndex = 12
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(19, 191)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(208, 17)
        Me.Label50.TabIndex = 11
        Me.Label50.Text = "State the amount you would like"
        '
        'gridSelectedFood
        '
        Me.gridSelectedFood.AllowUserToAddRows = False
        Me.gridSelectedFood.AllowUserToDeleteRows = False
        Me.gridSelectedFood.AllowUserToResizeColumns = False
        Me.gridSelectedFood.AllowUserToResizeRows = False
        Me.gridSelectedFood.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridSelectedFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridSelectedFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSelectedFood.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFoodID, Me.ColumnFoodName, Me.ColumnFoodQuantity, Me.ColumnFoodPrice})
        Me.gridSelectedFood.Location = New System.Drawing.Point(22, 28)
        Me.gridSelectedFood.MultiSelect = False
        Me.gridSelectedFood.Name = "gridSelectedFood"
        Me.gridSelectedFood.ReadOnly = True
        Me.gridSelectedFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSelectedFood.Size = New System.Drawing.Size(420, 142)
        Me.gridSelectedFood.TabIndex = 11
        '
        'ColumnFoodID
        '
        Me.ColumnFoodID.HeaderText = "Food ID"
        Me.ColumnFoodID.Name = "ColumnFoodID"
        Me.ColumnFoodID.ReadOnly = True
        '
        'ColumnFoodName
        '
        Me.ColumnFoodName.HeaderText = "Name"
        Me.ColumnFoodName.Name = "ColumnFoodName"
        Me.ColumnFoodName.ReadOnly = True
        '
        'ColumnFoodQuantity
        '
        Me.ColumnFoodQuantity.HeaderText = "Quantity"
        Me.ColumnFoodQuantity.Name = "ColumnFoodQuantity"
        Me.ColumnFoodQuantity.ReadOnly = True
        '
        'ColumnFoodPrice
        '
        Me.ColumnFoodPrice.HeaderText = "Price"
        Me.ColumnFoodPrice.Name = "ColumnFoodPrice"
        Me.ColumnFoodPrice.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblHiddenID2)
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Controls.Add(Me.lblFoodDescription)
        Me.GroupBox5.Controls.Add(Me.btnSelectFoodItem)
        Me.GroupBox5.Controls.Add(Me.lblFoodNotes)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.lblPrice2)
        Me.GroupBox5.Controls.Add(Me.lblFoodName)
        Me.GroupBox5.Controls.Add(Me.gridAllFood)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(463, 500)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "All Food Information"
        '
        'lblHiddenID2
        '
        Me.lblHiddenID2.AutoSize = True
        Me.lblHiddenID2.Location = New System.Drawing.Point(310, 28)
        Me.lblHiddenID2.Name = "lblHiddenID2"
        Me.lblHiddenID2.Size = New System.Drawing.Size(57, 17)
        Me.lblHiddenID2.TabIndex = 12
        Me.lblHiddenID2.Text = "Food ID"
        Me.lblHiddenID2.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(295, 98)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(79, 17)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Description"
        '
        'lblFoodDescription
        '
        Me.lblFoodDescription.BackColor = System.Drawing.Color.White
        Me.lblFoodDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoodDescription.Location = New System.Drawing.Point(240, 126)
        Me.lblFoodDescription.Name = "lblFoodDescription"
        Me.lblFoodDescription.Size = New System.Drawing.Size(193, 92)
        Me.lblFoodDescription.TabIndex = 11
        '
        'btnSelectFoodItem
        '
        Me.btnSelectFoodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFoodItem.Location = New System.Drawing.Point(276, 447)
        Me.btnSelectFoodItem.Name = "btnSelectFoodItem"
        Me.btnSelectFoodItem.Size = New System.Drawing.Size(126, 33)
        Me.btnSelectFoodItem.TabIndex = 10
        Me.btnSelectFoodItem.Text = "Select Item"
        Me.btnSelectFoodItem.UseVisualStyleBackColor = True
        '
        'lblFoodNotes
        '
        Me.lblFoodNotes.BackColor = System.Drawing.Color.White
        Me.lblFoodNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoodNotes.Location = New System.Drawing.Point(240, 286)
        Me.lblFoodNotes.Name = "lblFoodNotes"
        Me.lblFoodNotes.Size = New System.Drawing.Size(193, 145)
        Me.lblFoodNotes.TabIndex = 9
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(249, 251)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(40, 17)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Price"
        '
        'lblPrice2
        '
        Me.lblPrice2.BackColor = System.Drawing.Color.White
        Me.lblPrice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice2.Location = New System.Drawing.Point(327, 248)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(89, 23)
        Me.lblPrice2.TabIndex = 7
        Me.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFoodName
        '
        Me.lblFoodName.BackColor = System.Drawing.Color.White
        Me.lblFoodName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoodName.Location = New System.Drawing.Point(240, 63)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(193, 23)
        Me.lblFoodName.TabIndex = 4
        Me.lblFoodName.Text = "Name"
        Me.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridAllFood
        '
        Me.gridAllFood.AllowUserToAddRows = False
        Me.gridAllFood.AllowUserToDeleteRows = False
        Me.gridAllFood.AllowUserToResizeColumns = False
        Me.gridAllFood.AllowUserToResizeRows = False
        Me.gridAllFood.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridAllFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridAllFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAllFood.Location = New System.Drawing.Point(6, 28)
        Me.gridAllFood.MultiSelect = False
        Me.gridAllFood.Name = "gridAllFood"
        Me.gridAllFood.ReadOnly = True
        Me.gridAllFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAllFood.Size = New System.Drawing.Size(208, 466)
        Me.gridAllFood.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(190, 628)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBookingID
        '
        Me.lblBookingID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBookingID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBookingID.Location = New System.Drawing.Point(103, 18)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(94, 20)
        Me.lblBookingID.TabIndex = 15
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Location = New System.Drawing.Point(806, 18)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(94, 20)
        Me.lblUsername.TabIndex = 18
        '
        'btnAddBooking
        '
        Me.btnAddBooking.Enabled = False
        Me.btnAddBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBooking.Location = New System.Drawing.Point(15, 598)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(175, 30)
        Me.btnAddBooking.TabIndex = 19
        Me.btnAddBooking.Text = "Make Booking"
        Me.btnAddBooking.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Enabled = False
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(15, 628)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(175, 30)
        Me.btnSaveChanges.TabIndex = 37
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'frmBookingMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnAddBooking)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblBookingID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tcBooking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBookingMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Menu"
        Me.tcBooking.ResumeLayout(False)
        Me.BookingDetails.ResumeLayout(False)
        Me.BookingDetails.PerformLayout()
        Me.PanelRoom.ResumeLayout(False)
        Me.PanelRoom.PerformLayout()
        Me.PanelDateTime.ResumeLayout(False)
        Me.PanelDateTime.PerformLayout()
        Me.Clients.ResumeLayout(False)
        Me.Clients.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Equipment.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.gridSelectedEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gridAllEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Catering.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.gridSelectedFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.gridAllFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tcBooking As System.Windows.Forms.TabControl
    Friend WithEvents BookingDetails As System.Windows.Forms.TabPage
    Friend WithEvents Clients As System.Windows.Forms.TabPage
    Friend WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLecturerName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMeetingTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelDateTime As System.Windows.Forms.Panel
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbScreenRequired As System.Windows.Forms.CheckBox
    Friend WithEvents cbSecurity As System.Windows.Forms.CheckBox
    Friend WithEvents txtCars As System.Windows.Forms.TextBox
    Friend WithEvents txtPeople As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbxEndTime As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxStartTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PanelRoom As System.Windows.Forms.Panel
    Friend WithEvents lblFullDayCostWD As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblHourlyCost As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbxRoomName As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblScreenSize As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblRoomNotes As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSelectRoom As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtpDateConfirmed As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbxConfirmed As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddCatering As System.Windows.Forms.Button
    Friend WithEvents btnAddEquipment As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lstCatering As System.Windows.Forms.ListBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lstEquipment As System.Windows.Forms.ListBox
    Friend WithEvents btnAddClient As System.Windows.Forms.Button
    Friend WithEvents lblBookingClient As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblBookingID As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Equipment As System.Windows.Forms.TabPage
    Friend WithEvents Catering As System.Windows.Forms.TabPage
    Friend WithEvents btnAddBooking As System.Windows.Forms.Button
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents txtSearchClientID As System.Windows.Forms.TextBox
    Friend WithEvents btnFindClientID As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblClientAddress1 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblClientTelephoneNo1 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblClientPostcode1 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblClientNotes1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblClientEmailAddress1 As System.Windows.Forms.Label
    Friend WithEvents btnAddClientToBooking As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lblClientNotes2 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblClientEmailAddress2 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblClientPostcode2 As System.Windows.Forms.Label
    Friend WithEvents lblClientAddress2 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnFindClientName As System.Windows.Forms.Button
    Friend WithEvents txtSearchClientFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents radSearchViaClientID As System.Windows.Forms.RadioButton
    Friend WithEvents radSearchViaClientName As System.Windows.Forms.RadioButton
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtSearchClientSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblFullDayCostWE As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gridAllEquipment As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddEquipmentItemToBooking As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents lblEquipmentPrice As System.Windows.Forms.Label
    Friend WithEvents txtEquipmentQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents gridSelectedEquipment As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelectEquipmentItem As System.Windows.Forms.Button
    Friend WithEvents lblEquipmentNotes As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblPrice1 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblEquipmentName As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelectFoodItem As System.Windows.Forms.Button
    Friend WithEvents lblFoodNotes As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents lblPrice2 As System.Windows.Forms.Label
    Friend WithEvents lblFoodName As System.Windows.Forms.Label
    Friend WithEvents gridAllFood As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddFoodItemToBooking As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents lblFoodPrice As System.Windows.Forms.Label
    Friend WithEvents txtFoodQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents gridSelectedFood As System.Windows.Forms.DataGridView
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents lblFoodDescription As System.Windows.Forms.Label
    Friend WithEvents radPayFullDay As System.Windows.Forms.RadioButton
    Friend WithEvents radPayHourly As System.Windows.Forms.RadioButton
    Friend WithEvents txtClientTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnAddEquipmentQuantity As System.Windows.Forms.Button
    Friend WithEvents btnAddFoodQuantity As System.Windows.Forms.Button
    Friend WithEvents ColumnEquipmentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnEquipmentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnEquipmentQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnEquipmentPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblHiddenID1 As System.Windows.Forms.Label
    Friend WithEvents lblHiddenID2 As System.Windows.Forms.Label
    Friend WithEvents ColumnFoodID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnFoodName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnFoodQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnFoodPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCalculatePrice As System.Windows.Forms.Button
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents lblRoomCapacity As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
End Class
