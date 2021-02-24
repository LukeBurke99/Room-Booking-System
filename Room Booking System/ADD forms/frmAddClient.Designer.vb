<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddClient))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.ttClient = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Client Requirements"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(678, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Client ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.txtEmailAddress)
        Me.GroupBox1.Controls.Add(Me.txtTelephoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtPostcode)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 400)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Details"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(150, 280)
        Me.txtNotes.MaxLength = 300
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(331, 93)
        Me.txtNotes.TabIndex = 13
        Me.ttClient.SetToolTip(Me.txtNotes, "Enter any notes about the client.")
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(150, 250)
        Me.txtEmailAddress.MaxLength = 254
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(331, 21)
        Me.txtEmailAddress.TabIndex = 12
        Me.ttClient.SetToolTip(Me.txtEmailAddress, "Enter the client's email address.")
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(150, 220)
        Me.txtTelephoneNumber.MaxLength = 11
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(239, 21)
        Me.txtTelephoneNumber.TabIndex = 11
        Me.ttClient.SetToolTip(Me.txtTelephoneNumber, "Enter the client's telephone number.")
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(150, 190)
        Me.txtPostcode.MaxLength = 10
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(130, 21)
        Me.txtPostcode.TabIndex = 10
        Me.ttClient.SetToolTip(Me.txtPostcode, "Enter the client's postcode.")
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(150, 100)
        Me.txtAddress.MaxLength = 60
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(331, 84)
        Me.txtAddress.TabIndex = 9
        Me.ttClient.SetToolTip(Me.txtAddress, "Enter the client's address.")
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(150, 70)
        Me.txtSurname.MaxLength = 40
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(239, 21)
        Me.txtSurname.TabIndex = 8
        Me.ttClient.SetToolTip(Me.txtSurname, "Enter the surname of the client.")
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(150, 40)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(239, 21)
        Me.txtFirstName.TabIndex = 7
        Me.ttClient.SetToolTip(Me.txtFirstName, "Enter the first name of the client.")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Notes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Email Address"
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
        Me.btnCancel.Location = New System.Drawing.Point(286, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 27)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddClient
        '
        Me.btnAddClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.Location = New System.Drawing.Point(20, 520)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(110, 27)
        Me.btnAddClient.TabIndex = 33
        Me.btnAddClient.Text = "Add Client"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'ttClient
        '
        Me.ttClient.AutomaticDelay = 100
        Me.ttClient.AutoPopDelay = 10000
        Me.ttClient.InitialDelay = 100
        Me.ttClient.ReshowDelay = 20
        '
        'lblClientID
        '
        Me.lblClientID.BackColor = System.Drawing.Color.White
        Me.lblClientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientID.Location = New System.Drawing.Point(170, 70)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(100, 20)
        Me.lblClientID.TabIndex = 35
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(141, 520)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(129, 27)
        Me.btnSaveChanges.TabIndex = 36
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'frmAddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 552)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.lblClientID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddClient)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Client"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddClient As System.Windows.Forms.Button
    Friend WithEvents ttClient As System.Windows.Forms.ToolTip
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
End Class
