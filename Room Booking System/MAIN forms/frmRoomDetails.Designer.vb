<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomDetails))
        Me.gridRoom = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.btnRemoveRoom = New System.Windows.Forms.Button()
        Me.btnEditRoom = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.gridRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridRoom
        '
        Me.gridRoom.AllowUserToAddRows = False
        Me.gridRoom.AllowUserToDeleteRows = False
        Me.gridRoom.AllowUserToResizeColumns = False
        Me.gridRoom.AllowUserToResizeRows = False
        Me.gridRoom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRoom.Location = New System.Drawing.Point(20, 120)
        Me.gridRoom.MultiSelect = False
        Me.gridRoom.Name = "gridRoom"
        Me.gridRoom.ReadOnly = True
        Me.gridRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridRoom.Size = New System.Drawing.Size(939, 440)
        Me.gridRoom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(780, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Records:"
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(947, 620)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(18, 20)
        Me.lblRecords.TabIndex = 3
        Me.lblRecords.Text = "0"
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.Location = New System.Drawing.Point(20, 575)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(170, 30)
        Me.btnAddRoom.TabIndex = 4
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'btnRemoveRoom
        '
        Me.btnRemoveRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveRoom.Location = New System.Drawing.Point(20, 606)
        Me.btnRemoveRoom.Name = "btnRemoveRoom"
        Me.btnRemoveRoom.Size = New System.Drawing.Size(170, 30)
        Me.btnRemoveRoom.TabIndex = 5
        Me.btnRemoveRoom.Text = "Remove Room"
        Me.btnRemoveRoom.UseVisualStyleBackColor = True
        '
        'btnEditRoom
        '
        Me.btnEditRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRoom.Location = New System.Drawing.Point(190, 575)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(170, 30)
        Me.btnEditRoom.TabIndex = 6
        Me.btnEditRoom.Text = "Edit Room"
        Me.btnEditRoom.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(190, 606)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(819, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmRoomDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditRoom)
        Me.Controls.Add(Me.btnRemoveRoom)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridRoom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRoomDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Details"
        CType(Me.gridRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridRoom As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents btnRemoveRoom As System.Windows.Forms.Button
    Friend WithEvents btnEditRoom As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
