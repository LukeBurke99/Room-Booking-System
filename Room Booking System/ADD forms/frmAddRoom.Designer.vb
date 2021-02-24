<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRoom
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRoom))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.txtScreenSize = New System.Windows.Forms.TextBox()
        Me.txtMaxCapacity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtWeekendRate = New System.Windows.Forms.TextBox()
        Me.txtWeekdayRate = New System.Windows.Forms.TextBox()
        Me.txtHourlyRate = New System.Windows.Forms.TextBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ttRoom = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRoomID = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(323, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room Requirements"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnAddRoom)
        Me.GroupBox1.Controls.Add(Me.txtScreenSize)
        Me.GroupBox1.Controls.Add(Me.txtMaxCapacity)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtWeekendRate)
        Me.GroupBox1.Controls.Add(Me.txtWeekdayRate)
        Me.GroupBox1.Controls.Add(Me.txtHourlyRate)
        Me.GroupBox1.Controls.Add(Me.txtFloor)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 308)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Details"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(314, 247)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(99, 23)
        Me.btnSaveChanges.TabIndex = 36
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(314, 276)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 23)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(314, 218)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(99, 23)
        Me.btnAddRoom.TabIndex = 29
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'txtScreenSize
        '
        Me.txtScreenSize.Location = New System.Drawing.Point(323, 186)
        Me.txtScreenSize.MaxLength = 1
        Me.txtScreenSize.Name = "txtScreenSize"
        Me.txtScreenSize.Size = New System.Drawing.Size(100, 21)
        Me.txtScreenSize.TabIndex = 28
        Me.ttRoom.SetToolTip(Me.txtScreenSize, "Enter the size of the screen in the room. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S- Small" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M - Medium" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L - Large" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N - " & _
        "None")
        '
        'txtMaxCapacity
        '
        Me.txtMaxCapacity.Location = New System.Drawing.Point(323, 161)
        Me.txtMaxCapacity.Name = "txtMaxCapacity"
        Me.txtMaxCapacity.Size = New System.Drawing.Size(100, 21)
        Me.txtMaxCapacity.TabIndex = 27
        Me.ttRoom.SetToolTip(Me.txtMaxCapacity, "Enter the maximum capacity of the room.")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(235, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Screen Size"
        '
        'txtWeekendRate
        '
        Me.txtWeekendRate.Location = New System.Drawing.Point(110, 250)
        Me.txtWeekendRate.Name = "txtWeekendRate"
        Me.txtWeekendRate.Size = New System.Drawing.Size(100, 21)
        Me.txtWeekendRate.TabIndex = 25
        Me.ttRoom.SetToolTip(Me.txtWeekendRate, "Enter the full day cost of the room on a weekend.")
        '
        'txtWeekdayRate
        '
        Me.txtWeekdayRate.Location = New System.Drawing.Point(110, 211)
        Me.txtWeekdayRate.Name = "txtWeekdayRate"
        Me.txtWeekdayRate.Size = New System.Drawing.Size(100, 21)
        Me.txtWeekdayRate.TabIndex = 24
        Me.ttRoom.SetToolTip(Me.txtWeekdayRate, "Enter the full day cost of the room on a week day.")
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.Location = New System.Drawing.Point(110, 186)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(100, 21)
        Me.txtHourlyRate.TabIndex = 23
        Me.ttRoom.SetToolTip(Me.txtHourlyRate, "Enter the hourly cost of the room.")
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(110, 161)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(100, 21)
        Me.txtFloor.TabIndex = 22
        Me.ttRoom.SetToolTip(Me.txtFloor, "Enter the floor number of the room.")
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(110, 82)
        Me.txtNotes.MaxLength = 300
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(320, 70)
        Me.txtNotes.TabIndex = 21
        Me.ttRoom.SetToolTip(Me.txtNotes, "Enter any notes about the room.")
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(110, 57)
        Me.txtDescription.MaxLength = 150
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(320, 21)
        Me.txtDescription.TabIndex = 20
        Me.ttRoom.SetToolTip(Me.txtDescription, "Enter the description of the room.")
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 32)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(320, 21)
        Me.txtName.TabIndex = 19
        Me.ttRoom.SetToolTip(Me.txtName, "Enter the name of the room.")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(235, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Max. Capacity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 30)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Full Day Rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Weekend)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Full Day Rate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Weekday)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Hourly Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Floor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Name"
        '
        'ttRoom
        '
        Me.ttRoom.AutomaticDelay = 100
        Me.ttRoom.AutoPopDelay = 10000
        Me.ttRoom.InitialDelay = 100
        Me.ttRoom.ReshowDelay = 20
        '
        'lblRoomID
        '
        Me.lblRoomID.BackColor = System.Drawing.Color.White
        Me.lblRoomID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomID.Location = New System.Drawing.Point(122, 63)
        Me.lblRoomID.Name = "lblRoomID"
        Me.lblRoomID.Size = New System.Drawing.Size(100, 20)
        Me.lblRoomID.TabIndex = 6
        '
        'frmAddRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 422)
        Me.Controls.Add(Me.lblRoomID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Room"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtScreenSize As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWeekendRate As System.Windows.Forms.TextBox
    Friend WithEvents txtWeekdayRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHourlyRate As System.Windows.Forms.TextBox
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents ttRoom As System.Windows.Forms.ToolTip
    Friend WithEvents lblRoomID As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
End Class
