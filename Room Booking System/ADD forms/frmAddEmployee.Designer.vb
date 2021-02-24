<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAllowLogon = New System.Windows.Forms.CheckBox()
        Me.gbLoginDetails = New System.Windows.Forms.GroupBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.dtpEnded = New System.Windows.Forms.DateTimePicker()
        Me.dtpStarted = New System.Windows.Forms.DateTimePicker()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.ttEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.cbEmployeeLeft = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbLoginDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(671, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee Requirements"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbEmployeeLeft)
        Me.GroupBox1.Controls.Add(Me.cbAllowLogon)
        Me.GroupBox1.Controls.Add(Me.gbLoginDetails)
        Me.GroupBox1.Controls.Add(Me.dtpEnded)
        Me.GroupBox1.Controls.Add(Me.dtpStarted)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtEmailAddress)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTelephoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtPostcode)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 400)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Details"
        '
        'cbAllowLogon
        '
        Me.cbAllowLogon.AutoSize = True
        Me.cbAllowLogon.Location = New System.Drawing.Point(505, 157)
        Me.cbAllowLogon.Name = "cbAllowLogon"
        Me.cbAllowLogon.Size = New System.Drawing.Size(132, 19)
        Me.cbAllowLogon.TabIndex = 21
        Me.cbAllowLogon.Text = "Allow user to log on"
        Me.cbAllowLogon.UseVisualStyleBackColor = True
        Me.cbAllowLogon.Visible = False
        '
        'gbLoginDetails
        '
        Me.gbLoginDetails.Controls.Add(Me.lblUsername)
        Me.gbLoginDetails.Controls.Add(Me.Label13)
        Me.gbLoginDetails.Controls.Add(Me.Label12)
        Me.gbLoginDetails.Controls.Add(Me.txtPassword)
        Me.gbLoginDetails.Location = New System.Drawing.Point(505, 189)
        Me.gbLoginDetails.Name = "gbLoginDetails"
        Me.gbLoginDetails.Size = New System.Drawing.Size(229, 193)
        Me.gbLoginDetails.TabIndex = 20
        Me.gbLoginDetails.TabStop = False
        Me.gbLoginDetails.Text = "Login Details"
        Me.gbLoginDetails.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(28, 56)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(174, 20)
        Me.lblUsername.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(82, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Username"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(28, 139)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(174, 21)
        Me.txtPassword.TabIndex = 0
        '
        'dtpEnded
        '
        Me.dtpEnded.CustomFormat = "yyyy-mm-dd"
        Me.dtpEnded.Location = New System.Drawing.Point(575, 93)
        Me.dtpEnded.Name = "dtpEnded"
        Me.dtpEnded.Size = New System.Drawing.Size(160, 21)
        Me.dtpEnded.TabIndex = 19
        Me.dtpEnded.Visible = False
        '
        'dtpStarted
        '
        Me.dtpStarted.CustomFormat = "yyyy-mm-dd"
        Me.dtpStarted.Location = New System.Drawing.Point(575, 40)
        Me.dtpStarted.Name = "dtpStarted"
        Me.dtpStarted.Size = New System.Drawing.Size(160, 21)
        Me.dtpStarted.TabIndex = 18
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(147, 307)
        Me.txtNotes.MaxLength = 300
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(300, 76)
        Me.txtNotes.TabIndex = 17
        Me.ttEmployee.SetToolTip(Me.txtNotes, "Enter any notes about the employee.")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Notes"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(147, 250)
        Me.txtEmailAddress.MaxLength = 254
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(300, 21)
        Me.txtEmailAddress.TabIndex = 15
        Me.ttEmployee.SetToolTip(Me.txtEmailAddress, "Enter the employee's email address.")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Email Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(480, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Date Ended"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Date Started"
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(147, 220)
        Me.txtTelephoneNumber.MaxLength = 11
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(208, 21)
        Me.txtTelephoneNumber.TabIndex = 9
        Me.ttEmployee.SetToolTip(Me.txtTelephoneNumber, "Enter the employee's telephone number.")
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(147, 190)
        Me.txtPostcode.MaxLength = 10
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(139, 21)
        Me.txtPostcode.TabIndex = 8
        Me.ttEmployee.SetToolTip(Me.txtPostcode, "Enter the employee's postcode.")
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(147, 100)
        Me.txtAddress.MaxLength = 60
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(300, 76)
        Me.txtAddress.TabIndex = 7
        Me.ttEmployee.SetToolTip(Me.txtAddress, "Enter the employee's address.")
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(147, 70)
        Me.txtSurname.MaxLength = 40
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(208, 21)
        Me.txtSurname.TabIndex = 6
        Me.ttEmployee.SetToolTip(Me.txtSurname, "Enter the surname of the employee.")
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(147, 40)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(208, 21)
        Me.txtFirstName.TabIndex = 5
        Me.ttEmployee.SetToolTip(Me.txtFirstName, "Enter the first name of the employee.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Telephone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Postcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(287, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 27)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.Location = New System.Drawing.Point(20, 520)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(110, 27)
        Me.btnAddEmployee.TabIndex = 31
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'ttEmployee
        '
        Me.ttEmployee.AutomaticDelay = 100
        Me.ttEmployee.AutoPopDelay = 10000
        Me.ttEmployee.InitialDelay = 100
        Me.ttEmployee.ReshowDelay = 20
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.BackColor = System.Drawing.Color.White
        Me.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.Location = New System.Drawing.Point(167, 68)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(100, 20)
        Me.lblEmployeeID.TabIndex = 33
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(148, 520)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(119, 27)
        Me.btnSaveChanges.TabIndex = 36
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'cbEmployeeLeft
        '
        Me.cbEmployeeLeft.AutoSize = True
        Me.cbEmployeeLeft.Location = New System.Drawing.Point(533, 69)
        Me.cbEmployeeLeft.Name = "cbEmployeeLeft"
        Me.cbEmployeeLeft.Size = New System.Drawing.Size(171, 19)
        Me.cbEmployeeLeft.TabIndex = 22
        Me.cbEmployeeLeft.Text = "Employee no longer works"
        Me.cbEmployeeLeft.UseVisualStyleBackColor = True
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 552)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbLoginDetails.ResumeLayout(False)
        Me.gbLoginDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
    Friend WithEvents ttEmployee As System.Windows.Forms.ToolTip
    Friend WithEvents dtpEnded As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStarted As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents cbAllowLogon As System.Windows.Forms.CheckBox
    Friend WithEvents gbLoginDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cbEmployeeLeft As System.Windows.Forms.CheckBox
End Class
