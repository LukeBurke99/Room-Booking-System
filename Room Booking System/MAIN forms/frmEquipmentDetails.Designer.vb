<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipmentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquipmentDetails))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridEquipment = New System.Windows.Forms.DataGridView()
        Me.btnAddEquipment = New System.Windows.Forms.Button()
        Me.btnRemoveEquipment = New System.Windows.Forms.Button()
        Me.btnEditEquipment = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(812, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Equipment Database"
        '
        'gridEquipment
        '
        Me.gridEquipment.AllowUserToAddRows = False
        Me.gridEquipment.AllowUserToDeleteRows = False
        Me.gridEquipment.AllowUserToResizeColumns = False
        Me.gridEquipment.AllowUserToResizeRows = False
        Me.gridEquipment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridEquipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEquipment.Location = New System.Drawing.Point(20, 120)
        Me.gridEquipment.MultiSelect = False
        Me.gridEquipment.Name = "gridEquipment"
        Me.gridEquipment.ReadOnly = True
        Me.gridEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEquipment.Size = New System.Drawing.Size(644, 440)
        Me.gridEquipment.TabIndex = 2
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipment.Location = New System.Drawing.Point(20, 575)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.Size = New System.Drawing.Size(170, 30)
        Me.btnAddEquipment.TabIndex = 5
        Me.btnAddEquipment.Text = "Add Equipment"
        Me.btnAddEquipment.UseVisualStyleBackColor = True
        '
        'btnRemoveEquipment
        '
        Me.btnRemoveEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveEquipment.Location = New System.Drawing.Point(20, 606)
        Me.btnRemoveEquipment.Name = "btnRemoveEquipment"
        Me.btnRemoveEquipment.Size = New System.Drawing.Size(170, 30)
        Me.btnRemoveEquipment.TabIndex = 6
        Me.btnRemoveEquipment.Text = "Remove Equipment"
        Me.btnRemoveEquipment.UseVisualStyleBackColor = True
        '
        'btnEditEquipment
        '
        Me.btnEditEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEquipment.Location = New System.Drawing.Point(190, 575)
        Me.btnEditEquipment.Name = "btnEditEquipment"
        Me.btnEditEquipment.Size = New System.Drawing.Size(170, 30)
        Me.btnEditEquipment.TabIndex = 7
        Me.btnEditEquipment.Text = "Edit Equipment"
        Me.btnEditEquipment.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(190, 606)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(947, 620)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(18, 20)
        Me.lblRecords.TabIndex = 10
        Me.lblRecords.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(780, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number of Records:"
        '
        'frmEquipmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditEquipment)
        Me.Controls.Add(Me.btnRemoveEquipment)
        Me.Controls.Add(Me.btnAddEquipment)
        Me.Controls.Add(Me.gridEquipment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEquipmentDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipment Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridEquipment As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddEquipment As System.Windows.Forms.Button
    Friend WithEvents btnRemoveEquipment As System.Windows.Forms.Button
    Friend WithEvents btnEditEquipment As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
