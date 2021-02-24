<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCateringDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCateringDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gridCatering = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEditCateringItem = New System.Windows.Forms.Button()
        Me.btnRemoveCateringItem = New System.Windows.Forms.Button()
        Me.btnAddCateringItem = New System.Windows.Forms.Button()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCatering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Catering Database"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(850, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'gridCatering
        '
        Me.gridCatering.AllowUserToAddRows = False
        Me.gridCatering.AllowUserToDeleteRows = False
        Me.gridCatering.AllowUserToResizeColumns = False
        Me.gridCatering.AllowUserToResizeRows = False
        Me.gridCatering.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridCatering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridCatering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCatering.Location = New System.Drawing.Point(20, 120)
        Me.gridCatering.MultiSelect = False
        Me.gridCatering.Name = "gridCatering"
        Me.gridCatering.ReadOnly = True
        Me.gridCatering.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCatering.Size = New System.Drawing.Size(744, 440)
        Me.gridCatering.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(190, 606)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 30)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEditCateringItem
        '
        Me.btnEditCateringItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCateringItem.Location = New System.Drawing.Point(190, 575)
        Me.btnEditCateringItem.Name = "btnEditCateringItem"
        Me.btnEditCateringItem.Size = New System.Drawing.Size(170, 30)
        Me.btnEditCateringItem.TabIndex = 11
        Me.btnEditCateringItem.Text = "Edit Catering Item"
        Me.btnEditCateringItem.UseVisualStyleBackColor = True
        '
        'btnRemoveCateringItem
        '
        Me.btnRemoveCateringItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveCateringItem.Location = New System.Drawing.Point(20, 606)
        Me.btnRemoveCateringItem.Name = "btnRemoveCateringItem"
        Me.btnRemoveCateringItem.Size = New System.Drawing.Size(170, 30)
        Me.btnRemoveCateringItem.TabIndex = 10
        Me.btnRemoveCateringItem.Text = "Remove Catering Item"
        Me.btnRemoveCateringItem.UseVisualStyleBackColor = True
        '
        'btnAddCateringItem
        '
        Me.btnAddCateringItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCateringItem.Location = New System.Drawing.Point(20, 575)
        Me.btnAddCateringItem.Name = "btnAddCateringItem"
        Me.btnAddCateringItem.Size = New System.Drawing.Size(170, 30)
        Me.btnAddCateringItem.TabIndex = 9
        Me.btnAddCateringItem.Text = "Add Catering Item"
        Me.btnAddCateringItem.UseVisualStyleBackColor = True
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(947, 620)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(18, 20)
        Me.lblRecords.TabIndex = 14
        Me.lblRecords.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(780, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Number of Records:"
        '
        'frmCateringDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditCateringItem)
        Me.Controls.Add(Me.btnRemoveCateringItem)
        Me.Controls.Add(Me.btnAddCateringItem)
        Me.Controls.Add(Me.gridCatering)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCateringDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCatering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gridCatering As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEditCateringItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCateringItem As System.Windows.Forms.Button
    Friend WithEvents btnAddCateringItem As System.Windows.Forms.Button
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
