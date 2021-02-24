<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptimisedRoom
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
        Me.cbScreenRequired = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelScreenSize = New System.Windows.Forms.Panel()
        Me.cmbxScreenSize = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMaxHourPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMinHourPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelRoomDetails = New System.Windows.Forms.Panel()
        Me.txtRoomCapacityNeeded = New System.Windows.Forms.TextBox()
        Me.btnSearchRooms = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtMaxDayPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMinDayPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbxStartTime = New System.Windows.Forms.ComboBox()
        Me.cmbxEndTime = New System.Windows.Forms.ComboBox()
        Me.PanelSelectedRoom = New System.Windows.Forms.Panel()
        Me.lblRoomName = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblRoomNotes = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblScreenSize = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFullDayCostWD = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblHourlyCost = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnUseRoom = New System.Windows.Forms.Button()
        Me.lstRoomName = New System.Windows.Forms.ListBox()
        Me.lstRoomID = New System.Windows.Forms.ListBox()
        Me.PanelScreenSize.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelRoomDetails.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelSelectedRoom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number Of People Attending"
        '
        'cbScreenRequired
        '
        Me.cbScreenRequired.AutoSize = True
        Me.cbScreenRequired.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbScreenRequired.Location = New System.Drawing.Point(5, 40)
        Me.cbScreenRequired.Name = "cbScreenRequired"
        Me.cbScreenRequired.Size = New System.Drawing.Size(175, 21)
        Me.cbScreenRequired.TabIndex = 14
        Me.cbScreenRequired.Text = "Smart Screen Required"
        Me.cbScreenRequired.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Screen Size"
        '
        'PanelScreenSize
        '
        Me.PanelScreenSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelScreenSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelScreenSize.Controls.Add(Me.cmbxScreenSize)
        Me.PanelScreenSize.Controls.Add(Me.Label2)
        Me.PanelScreenSize.Location = New System.Drawing.Point(5, 70)
        Me.PanelScreenSize.Name = "PanelScreenSize"
        Me.PanelScreenSize.Size = New System.Drawing.Size(187, 31)
        Me.PanelScreenSize.TabIndex = 16
        '
        'cmbxScreenSize
        '
        Me.cmbxScreenSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxScreenSize.Enabled = False
        Me.cmbxScreenSize.FormattingEnabled = True
        Me.cmbxScreenSize.Items.AddRange(New Object() {"S", "M", "L"})
        Me.cmbxScreenSize.Location = New System.Drawing.Point(102, 3)
        Me.cmbxScreenSize.Name = "cmbxScreenSize"
        Me.cmbxScreenSize.Size = New System.Drawing.Size(71, 21)
        Me.cmbxScreenSize.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hourly Price Range"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtMaxHourPrice)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtMinHourPrice)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(8, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 36)
        Me.Panel2.TabIndex = 18
        '
        'txtMaxHourPrice
        '
        Me.txtMaxHourPrice.Location = New System.Drawing.Point(220, 7)
        Me.txtMaxHourPrice.Name = "txtMaxHourPrice"
        Me.txtMaxHourPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtMaxHourPrice.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(165, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "and    £"
        '
        'txtMinHourPrice
        '
        Me.txtMinHourPrice.Location = New System.Drawing.Point(90, 7)
        Me.txtMinHourPrice.Name = "txtMinHourPrice"
        Me.txtMinHourPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtMinHourPrice.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Between    £"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Select a Date"
        '
        'PanelRoomDetails
        '
        Me.PanelRoomDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelRoomDetails.Controls.Add(Me.txtRoomCapacityNeeded)
        Me.PanelRoomDetails.Controls.Add(Me.btnSearchRooms)
        Me.PanelRoomDetails.Controls.Add(Me.Panel4)
        Me.PanelRoomDetails.Controls.Add(Me.Label6)
        Me.PanelRoomDetails.Controls.Add(Me.Label1)
        Me.PanelRoomDetails.Controls.Add(Me.cbScreenRequired)
        Me.PanelRoomDetails.Controls.Add(Me.Panel2)
        Me.PanelRoomDetails.Controls.Add(Me.PanelScreenSize)
        Me.PanelRoomDetails.Controls.Add(Me.Label3)
        Me.PanelRoomDetails.Location = New System.Drawing.Point(12, 60)
        Me.PanelRoomDetails.Name = "PanelRoomDetails"
        Me.PanelRoomDetails.Size = New System.Drawing.Size(329, 329)
        Me.PanelRoomDetails.TabIndex = 20
        '
        'txtRoomCapacityNeeded
        '
        Me.txtRoomCapacityNeeded.Location = New System.Drawing.Point(200, 10)
        Me.txtRoomCapacityNeeded.Name = "txtRoomCapacityNeeded"
        Me.txtRoomCapacityNeeded.Size = New System.Drawing.Size(75, 20)
        Me.txtRoomCapacityNeeded.TabIndex = 23
        '
        'btnSearchRooms
        '
        Me.btnSearchRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRooms.Location = New System.Drawing.Point(8, 299)
        Me.btnSearchRooms.Name = "btnSearchRooms"
        Me.btnSearchRooms.Size = New System.Drawing.Size(145, 23)
        Me.btnSearchRooms.TabIndex = 24
        Me.btnSearchRooms.Text = "Search Rooms"
        Me.btnSearchRooms.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtMaxDayPrice)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtMinDayPrice)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(8, 221)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 36)
        Me.Panel4.TabIndex = 23
        '
        'txtMaxDayPrice
        '
        Me.txtMaxDayPrice.Location = New System.Drawing.Point(220, 7)
        Me.txtMaxDayPrice.Name = "txtMaxDayPrice"
        Me.txtMaxDayPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtMaxDayPrice.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "and    £"
        '
        'txtMinDayPrice
        '
        Me.txtMinDayPrice.Location = New System.Drawing.Point(90, 7)
        Me.txtMinDayPrice.Name = "txtMinDayPrice"
        Me.txtMinDayPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtMinDayPrice.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Between    £"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Full Day Price Range"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(123, 15)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 21
        Me.dtpDate.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Select a Start Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(590, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Select an End Time"
        '
        'cmbxStartTime
        '
        Me.cmbxStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxStartTime.FormattingEnabled = True
        Me.cmbxStartTime.Items.AddRange(New Object() {"08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00"})
        Me.cmbxStartTime.Location = New System.Drawing.Point(490, 16)
        Me.cmbxStartTime.Name = "cmbxStartTime"
        Me.cmbxStartTime.Size = New System.Drawing.Size(91, 21)
        Me.cmbxStartTime.TabIndex = 24
        '
        'cmbxEndTime
        '
        Me.cmbxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEndTime.FormattingEnabled = True
        Me.cmbxEndTime.Items.AddRange(New Object() {"08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00"})
        Me.cmbxEndTime.Location = New System.Drawing.Point(730, 16)
        Me.cmbxEndTime.Name = "cmbxEndTime"
        Me.cmbxEndTime.Size = New System.Drawing.Size(91, 21)
        Me.cmbxEndTime.TabIndex = 25
        '
        'PanelSelectedRoom
        '
        Me.PanelSelectedRoom.BackColor = System.Drawing.Color.Transparent
        Me.PanelSelectedRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSelectedRoom.Controls.Add(Me.lblRoomName)
        Me.PanelSelectedRoom.Controls.Add(Me.lblFloor)
        Me.PanelSelectedRoom.Controls.Add(Me.Label18)
        Me.PanelSelectedRoom.Controls.Add(Me.lblRoomNotes)
        Me.PanelSelectedRoom.Controls.Add(Me.Label17)
        Me.PanelSelectedRoom.Controls.Add(Me.lblDescription)
        Me.PanelSelectedRoom.Controls.Add(Me.lblScreenSize)
        Me.PanelSelectedRoom.Controls.Add(Me.Label15)
        Me.PanelSelectedRoom.Controls.Add(Me.lblFullDayCostWD)
        Me.PanelSelectedRoom.Controls.Add(Me.Label16)
        Me.PanelSelectedRoom.Controls.Add(Me.lblHourlyCost)
        Me.PanelSelectedRoom.Controls.Add(Me.Label14)
        Me.PanelSelectedRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSelectedRoom.Location = New System.Drawing.Point(605, 60)
        Me.PanelSelectedRoom.Name = "PanelSelectedRoom"
        Me.PanelSelectedRoom.Size = New System.Drawing.Size(374, 328)
        Me.PanelSelectedRoom.TabIndex = 27
        '
        'lblRoomName
        '
        Me.lblRoomName.BackColor = System.Drawing.Color.White
        Me.lblRoomName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomName.Location = New System.Drawing.Point(67, 20)
        Me.lblRoomName.Name = "lblRoomName"
        Me.lblRoomName.Size = New System.Drawing.Size(207, 26)
        Me.lblRoomName.TabIndex = 15
        Me.lblRoomName.Text = "RoomName"
        Me.lblRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFloor
        '
        Me.lblFloor.BackColor = System.Drawing.Color.White
        Me.lblFloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFloor.Location = New System.Drawing.Point(74, 140)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(85, 20)
        Me.lblFloor.TabIndex = 14
        Me.lblFloor.Text = "N / A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 17)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Floor"
        '
        'lblRoomNotes
        '
        Me.lblRoomNotes.BackColor = System.Drawing.Color.White
        Me.lblRoomNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomNotes.Location = New System.Drawing.Point(14, 239)
        Me.lblRoomNotes.Name = "lblRoomNotes"
        Me.lblRoomNotes.Size = New System.Drawing.Size(345, 75)
        Me.lblRoomNotes.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(142, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 17)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Room Notes"
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.White
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(14, 75)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(345, 35)
        Me.lblDescription.TabIndex = 8
        '
        'lblScreenSize
        '
        Me.lblScreenSize.BackColor = System.Drawing.Color.White
        Me.lblScreenSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScreenSize.Location = New System.Drawing.Point(271, 140)
        Me.lblScreenSize.Name = "lblScreenSize"
        Me.lblScreenSize.Size = New System.Drawing.Size(76, 20)
        Me.lblScreenSize.TabIndex = 7
        Me.lblScreenSize.Text = "N / A"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(181, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 17)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Screen Size"
        '
        'lblFullDayCostWD
        '
        Me.lblFullDayCostWD.BackColor = System.Drawing.Color.White
        Me.lblFullDayCostWD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullDayCostWD.Location = New System.Drawing.Point(110, 185)
        Me.lblFullDayCostWD.Name = "lblFullDayCostWD"
        Me.lblFullDayCostWD.Size = New System.Drawing.Size(69, 20)
        Me.lblFullDayCostWD.TabIndex = 5
        Me.lblFullDayCostWD.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Full Day Cost"
        '
        'lblHourlyCost
        '
        Me.lblHourlyCost.BackColor = System.Drawing.Color.White
        Me.lblHourlyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHourlyCost.Location = New System.Drawing.Point(287, 185)
        Me.lblHourlyCost.Name = "lblHourlyCost"
        Me.lblHourlyCost.Size = New System.Drawing.Size(67, 20)
        Me.lblHourlyCost.TabIndex = 3
        Me.lblHourlyCost.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(197, 185)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Hourly Cost"
        '
        'btnUseRoom
        '
        Me.btnUseRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseRoom.Location = New System.Drawing.Point(401, 337)
        Me.btnUseRoom.Name = "btnUseRoom"
        Me.btnUseRoom.Size = New System.Drawing.Size(139, 52)
        Me.btnUseRoom.TabIndex = 28
        Me.btnUseRoom.Text = "Add Room to Booking"
        Me.btnUseRoom.UseVisualStyleBackColor = True
        '
        'lstRoomName
        '
        Me.lstRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRoomName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRoomName.FormattingEnabled = True
        Me.lstRoomName.ItemHeight = 18
        Me.lstRoomName.Location = New System.Drawing.Point(474, 60)
        Me.lstRoomName.MultiColumn = True
        Me.lstRoomName.Name = "lstRoomName"
        Me.lstRoomName.Size = New System.Drawing.Size(125, 254)
        Me.lstRoomName.TabIndex = 29
        '
        'lstRoomID
        '
        Me.lstRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRoomID.FormattingEnabled = True
        Me.lstRoomID.ItemHeight = 18
        Me.lstRoomID.Location = New System.Drawing.Point(347, 60)
        Me.lstRoomID.MultiColumn = True
        Me.lstRoomID.Name = "lstRoomID"
        Me.lstRoomID.Size = New System.Drawing.Size(125, 254)
        Me.lstRoomID.TabIndex = 30
        '
        'frmOptimisedRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 402)
        Me.Controls.Add(Me.lstRoomID)
        Me.Controls.Add(Me.lstRoomName)
        Me.Controls.Add(Me.btnUseRoom)
        Me.Controls.Add(Me.PanelSelectedRoom)
        Me.Controls.Add(Me.cmbxEndTime)
        Me.Controls.Add(Me.cmbxStartTime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.PanelRoomDetails)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.Name = "frmOptimisedRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search for optimum room"
        Me.PanelScreenSize.ResumeLayout(False)
        Me.PanelScreenSize.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelRoomDetails.ResumeLayout(False)
        Me.PanelRoomDetails.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelSelectedRoom.ResumeLayout(False)
        Me.PanelSelectedRoom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbScreenRequired As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelScreenSize As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelRoomDetails As System.Windows.Forms.Panel
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbxStartTime As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxScreenSize As System.Windows.Forms.ComboBox
    Friend WithEvents txtMaxHourPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMinHourPrice As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtMaxDayPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMinDayPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbxEndTime As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchRooms As System.Windows.Forms.Button
    Friend WithEvents PanelSelectedRoom As System.Windows.Forms.Panel
    Friend WithEvents lblRoomName As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblRoomNotes As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblScreenSize As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblFullDayCostWD As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblHourlyCost As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnUseRoom As System.Windows.Forms.Button
    Friend WithEvents lstRoomName As System.Windows.Forms.ListBox
    Friend WithEvents lstRoomID As System.Windows.Forms.ListBox
    Friend WithEvents txtRoomCapacityNeeded As System.Windows.Forms.TextBox
End Class
