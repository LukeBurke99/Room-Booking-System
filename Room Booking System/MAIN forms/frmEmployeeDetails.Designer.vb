<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gridEmployee = New System.Windows.Forms.DataGridView()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEditEmployee = New System.Windows.Forms.Button()
        Me.btnRemoveEmployee = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee Database"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(863, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'gridEmployee
        '
        Me.gridEmployee.AllowUserToAddRows = False
        Me.gridEmployee.AllowUserToDeleteRows = False
        Me.gridEmployee.AllowUserToResizeColumns = False
        Me.gridEmployee.AllowUserToResizeRows = False
        Me.gridEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEmployee.Location = New System.Drawing.Point(20, 120)
        Me.gridEmployee.MultiSelect = False
        Me.gridEmployee.Name = "gridEmployee"
        Me.gridEmployee.ReadOnly = True
        Me.gridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEmployee.Size = New System.Drawing.Size(942, 440)
        Me.gridEmployee.TabIndex = 4
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(947, 620)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(18, 20)
        Me.lblRecords.TabIndex = 12
        Me.lblRecords.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(780, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Number of Records:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(190, 606)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEditEmployee
        '
        Me.btnEditEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEmployee.Location = New System.Drawing.Point(190, 575)
        Me.btnEditEmployee.Name = "btnEditEmployee"
        Me.btnEditEmployee.Size = New System.Drawing.Size(170, 30)
        Me.btnEditEmployee.TabIndex = 15
        Me.btnEditEmployee.Text = "Edit Employee"
        Me.btnEditEmployee.UseVisualStyleBackColor = True
        '
        'btnRemoveEmployee
        '
        Me.btnRemoveEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveEmployee.Location = New System.Drawing.Point(20, 606)
        Me.btnRemoveEmployee.Name = "btnRemoveEmployee"
        Me.btnRemoveEmployee.Size = New System.Drawing.Size(170, 30)
        Me.btnRemoveEmployee.TabIndex = 14
        Me.btnRemoveEmployee.Text = "Remove Employee"
        Me.btnRemoveEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.Location = New System.Drawing.Point(20, 575)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(170, 30)
        Me.btnAddEmployee.TabIndex = 13
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'frmEmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditEmployee)
        Me.Controls.Add(Me.btnRemoveEmployee)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridEmployee)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEmployeeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gridEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEditEmployee As System.Windows.Forms.Button
    Friend WithEvents btnRemoveEmployee As System.Windows.Forms.Button
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
End Class
