<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCatering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCatering))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddCateringItem = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ttCatering = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblFoodID = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(342, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 100)
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
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Catering Requirements"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Food ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnAddCateringItem)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 281)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catering Details"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(23, 199)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(120, 23)
        Me.btnSaveChanges.TabIndex = 35
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(23, 228)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 23)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddCateringItem
        '
        Me.btnAddCateringItem.Location = New System.Drawing.Point(23, 170)
        Me.btnAddCateringItem.Name = "btnAddCateringItem"
        Me.btnAddCateringItem.Size = New System.Drawing.Size(120, 23)
        Me.btnAddCateringItem.TabIndex = 33
        Me.btnAddCateringItem.Text = "Add Catering Item"
        Me.btnAddCateringItem.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(150, 110)
        Me.txtNotes.MaxLength = 300
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(281, 147)
        Me.txtNotes.TabIndex = 7
        Me.ttCatering.SetToolTip(Me.txtNotes, "Enter any notes about the food.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(150, 90)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(78, 21)
        Me.txtPrice.TabIndex = 6
        Me.ttCatering.SetToolTip(Me.txtPrice, "Enter the cost of the food.")
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(150, 65)
        Me.txtDescription.MaxLength = 150
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(281, 21)
        Me.txtDescription.TabIndex = 5
        Me.ttCatering.SetToolTip(Me.txtDescription, "Enter the description of the food.")
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 40)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(281, 21)
        Me.txtName.TabIndex = 4
        Me.ttCatering.SetToolTip(Me.txtName, "Enter the name of the food.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Notes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Cost Per Person"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Description of Food"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name of Food"
        '
        'ttCatering
        '
        Me.ttCatering.AutomaticDelay = 100
        Me.ttCatering.AutoPopDelay = 10000
        Me.ttCatering.InitialDelay = 100
        Me.ttCatering.ReshowDelay = 20
        '
        'lblFoodID
        '
        Me.lblFoodID.BackColor = System.Drawing.Color.White
        Me.lblFoodID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodID.Location = New System.Drawing.Point(165, 60)
        Me.lblFoodID.Name = "lblFoodID"
        Me.lblFoodID.Size = New System.Drawing.Size(100, 20)
        Me.lblFoodID.TabIndex = 36
        '
        'frmAddCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 422)
        Me.Controls.Add(Me.lblFoodID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddCatering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Catering Item"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddCateringItem As System.Windows.Forms.Button
    Friend WithEvents ttCatering As System.Windows.Forms.ToolTip
    Friend WithEvents lblFoodID As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
End Class
