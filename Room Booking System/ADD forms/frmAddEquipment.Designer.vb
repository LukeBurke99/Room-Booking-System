<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEquipment))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAddEquipment = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ttEquipment = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEquipmentID = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(330, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Equipment Requirements"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Equipment ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.btnAddEquipment)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 287)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipment Details"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(290, 213)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(100, 23)
        Me.btnSaveChanges.TabIndex = 36
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(290, 242)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(135, 211)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(85, 21)
        Me.txtPrice.TabIndex = 8
        Me.ttEquipment.SetToolTip(Me.txtPrice, "Enter the price of the food.")
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.Location = New System.Drawing.Point(290, 184)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.Size = New System.Drawing.Size(100, 23)
        Me.btnAddEquipment.TabIndex = 31
        Me.btnAddEquipment.Text = "Add Equipment"
        Me.btnAddEquipment.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 41)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(290, 21)
        Me.txtName.TabIndex = 6
        Me.ttEquipment.SetToolTip(Me.txtName, "Enter the name of the equipment.")
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(135, 183)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(85, 21)
        Me.txtQuantity.TabIndex = 7
        Me.ttEquipment.SetToolTip(Me.txtQuantity, "Enter the quantity of the food you have.")
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(135, 70)
        Me.txtNotes.MaxLength = 300
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(290, 106)
        Me.txtNotes.TabIndex = 9
        Me.ttEquipment.SetToolTip(Me.txtNotes, "Enter any notes about the equipment.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Equipment Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Notes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantity"
        '
        'ttEquipment
        '
        Me.ttEquipment.AutomaticDelay = 100
        Me.ttEquipment.AutoPopDelay = 10000
        Me.ttEquipment.InitialDelay = 100
        Me.ttEquipment.ReshowDelay = 20
        '
        'lblEquipmentID
        '
        Me.lblEquipmentID.BackColor = System.Drawing.Color.White
        Me.lblEquipmentID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentID.Location = New System.Drawing.Point(150, 62)
        Me.lblEquipmentID.Name = "lblEquipmentID"
        Me.lblEquipmentID.Size = New System.Drawing.Size(100, 20)
        Me.lblEquipmentID.TabIndex = 7
        '
        'frmAddEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 422)
        Me.Controls.Add(Me.lblEquipmentID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddEquipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Equipment"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddEquipment As System.Windows.Forms.Button
    Friend WithEvents ttEquipment As System.Windows.Forms.ToolTip
    Friend WithEvents lblEquipmentID As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
End Class
