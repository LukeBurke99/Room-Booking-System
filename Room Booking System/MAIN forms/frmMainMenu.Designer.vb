<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnBookingMenu = New System.Windows.Forms.Button()
        Me.btnCateringDetails = New System.Windows.Forms.Button()
        Me.btnClientDetails = New System.Windows.Forms.Button()
        Me.btnRoomDetails = New System.Windows.Forms.Button()
        Me.btnEmployeeDetails = New System.Windows.Forms.Button()
        Me.btnEquipmentDetails = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBookingMenu
        '
        Me.btnBookingMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBookingMenu.BackgroundImage = CType(resources.GetObject("btnBookingMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnBookingMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBookingMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookingMenu.ForeColor = System.Drawing.Color.Blue
        Me.btnBookingMenu.Location = New System.Drawing.Point(50, 60)
        Me.btnBookingMenu.Name = "btnBookingMenu"
        Me.btnBookingMenu.Size = New System.Drawing.Size(180, 230)
        Me.btnBookingMenu.TabIndex = 0
        Me.btnBookingMenu.Text = "Booking Menu"
        Me.btnBookingMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBookingMenu.UseVisualStyleBackColor = False
        '
        'btnCateringDetails
        '
        Me.btnCateringDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCateringDetails.BackgroundImage = CType(resources.GetObject("btnCateringDetails.BackgroundImage"), System.Drawing.Image)
        Me.btnCateringDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCateringDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCateringDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnCateringDetails.Location = New System.Drawing.Point(300, 60)
        Me.btnCateringDetails.Name = "btnCateringDetails"
        Me.btnCateringDetails.Size = New System.Drawing.Size(180, 230)
        Me.btnCateringDetails.TabIndex = 1
        Me.btnCateringDetails.Text = "Catering Details"
        Me.btnCateringDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCateringDetails.UseVisualStyleBackColor = False
        '
        'btnClientDetails
        '
        Me.btnClientDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClientDetails.BackgroundImage = CType(resources.GetObject("btnClientDetails.BackgroundImage"), System.Drawing.Image)
        Me.btnClientDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnClientDetails.Location = New System.Drawing.Point(550, 60)
        Me.btnClientDetails.Name = "btnClientDetails"
        Me.btnClientDetails.Size = New System.Drawing.Size(180, 230)
        Me.btnClientDetails.TabIndex = 2
        Me.btnClientDetails.Text = "Client Details"
        Me.btnClientDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientDetails.UseVisualStyleBackColor = False
        '
        'btnRoomDetails
        '
        Me.btnRoomDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRoomDetails.BackgroundImage = CType(resources.GetObject("btnRoomDetails.BackgroundImage"), System.Drawing.Image)
        Me.btnRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRoomDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnRoomDetails.Location = New System.Drawing.Point(50, 350)
        Me.btnRoomDetails.Name = "btnRoomDetails"
        Me.btnRoomDetails.Size = New System.Drawing.Size(180, 230)
        Me.btnRoomDetails.TabIndex = 3
        Me.btnRoomDetails.Text = "Room Details"
        Me.btnRoomDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRoomDetails.UseVisualStyleBackColor = False
        '
        'btnEmployeeDetails
        '
        Me.btnEmployeeDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEmployeeDetails.BackgroundImage = CType(resources.GetObject("btnEmployeeDetails.BackgroundImage"), System.Drawing.Image)
        Me.btnEmployeeDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployeeDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnEmployeeDetails.Location = New System.Drawing.Point(300, 350)
        Me.btnEmployeeDetails.Name = "btnEmployeeDetails"
        Me.btnEmployeeDetails.Size = New System.Drawing.Size(180, 230)
        Me.btnEmployeeDetails.TabIndex = 4
        Me.btnEmployeeDetails.Text = "Employee Details"
        Me.btnEmployeeDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployeeDetails.UseVisualStyleBackColor = False
        '
        'btnEquipmentDetails
        '
        Me.btnEquipmentDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEquipmentDetails.BackgroundImage = CType(resources.GetObject("btnEquipmentDetails.BackgroundImage"), System.Drawing.Image)
        Me.btnEquipmentDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEquipmentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipmentDetails.ForeColor = System.Drawing.Color.Blue
        Me.btnEquipmentDetails.Location = New System.Drawing.Point(550, 350)
        Me.btnEquipmentDetails.Name = "btnEquipmentDetails"
        Me.btnEquipmentDetails.Size = New System.Drawing.Size(180, 230)
        Me.btnEquipmentDetails.TabIndex = 5
        Me.btnEquipmentDetails.Text = "Equipment Details"
        Me.btnEquipmentDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEquipmentDetails.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Blue
        Me.lblDate.Location = New System.Drawing.Point(745, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(225, 35)
        Me.lblDate.TabIndex = 6
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Blue
        Me.btnHelp.Location = New System.Drawing.Point(760, 495)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(200, 35)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Blue
        Me.btnExit.Location = New System.Drawing.Point(760, 545)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnEquipmentDetails)
        Me.Controls.Add(Me.btnEmployeeDetails)
        Me.Controls.Add(Me.btnRoomDetails)
        Me.Controls.Add(Me.btnClientDetails)
        Me.Controls.Add(Me.btnCateringDetails)
        Me.Controls.Add(Me.btnBookingMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBookingMenu As System.Windows.Forms.Button
    Friend WithEvents btnCateringDetails As System.Windows.Forms.Button
    Friend WithEvents btnClientDetails As System.Windows.Forms.Button
    Friend WithEvents btnRoomDetails As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeDetails As System.Windows.Forms.Button
    Friend WithEvents btnEquipmentDetails As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
