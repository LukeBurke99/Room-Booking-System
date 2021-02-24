<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientDetails))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridClient = New System.Windows.Forms.DataGridView()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEditClient = New System.Windows.Forms.Button()
        Me.btnRemoveClient = New System.Windows.Forms.Button()
        Me.btnAddClient = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(837, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 126)
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
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Client Database"
        '
        'gridClient
        '
        Me.gridClient.AllowUserToAddRows = False
        Me.gridClient.AllowUserToDeleteRows = False
        Me.gridClient.AllowUserToResizeColumns = False
        Me.gridClient.AllowUserToResizeRows = False
        Me.gridClient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClient.Location = New System.Drawing.Point(20, 120)
        Me.gridClient.MultiSelect = False
        Me.gridClient.Name = "gridClient"
        Me.gridClient.ReadOnly = True
        Me.gridClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridClient.Size = New System.Drawing.Size(843, 440)
        Me.gridClient.TabIndex = 4
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
        'btnEditClient
        '
        Me.btnEditClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditClient.Location = New System.Drawing.Point(190, 575)
        Me.btnEditClient.Name = "btnEditClient"
        Me.btnEditClient.Size = New System.Drawing.Size(170, 30)
        Me.btnEditClient.TabIndex = 15
        Me.btnEditClient.Text = "Edit Client"
        Me.btnEditClient.UseVisualStyleBackColor = True
        '
        'btnRemoveClient
        '
        Me.btnRemoveClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveClient.Location = New System.Drawing.Point(20, 606)
        Me.btnRemoveClient.Name = "btnRemoveClient"
        Me.btnRemoveClient.Size = New System.Drawing.Size(170, 30)
        Me.btnRemoveClient.TabIndex = 14
        Me.btnRemoveClient.Text = "Remove Client"
        Me.btnRemoveClient.UseVisualStyleBackColor = True
        '
        'btnAddClient
        '
        Me.btnAddClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.Location = New System.Drawing.Point(20, 575)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(170, 30)
        Me.btnAddClient.TabIndex = 13
        Me.btnAddClient.Text = "Add Client"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'frmClientDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditClient)
        Me.Controls.Add(Me.btnRemoveClient)
        Me.Controls.Add(Me.btnAddClient)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClientDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridClient As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEditClient As System.Windows.Forms.Button
    Friend WithEvents btnRemoveClient As System.Windows.Forms.Button
    Friend WithEvents btnAddClient As System.Windows.Forms.Button
End Class
