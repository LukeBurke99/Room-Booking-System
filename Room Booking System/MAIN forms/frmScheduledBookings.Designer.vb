<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduledBookings
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
        Me.gridBooking = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchUnconfirmed = New System.Windows.Forms.Button()
        Me.btnSearchAll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.gridBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridBooking
        '
        Me.gridBooking.AllowUserToAddRows = False
        Me.gridBooking.AllowUserToDeleteRows = False
        Me.gridBooking.AllowUserToResizeColumns = False
        Me.gridBooking.AllowUserToResizeRows = False
        Me.gridBooking.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.gridBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBooking.Location = New System.Drawing.Point(12, 79)
        Me.gridBooking.MultiSelect = False
        Me.gridBooking.Name = "gridBooking"
        Me.gridBooking.ReadOnly = True
        Me.gridBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridBooking.Size = New System.Drawing.Size(960, 511)
        Me.gridBooking.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scheduled Bookings"
        '
        'btnSearchUnconfirmed
        '
        Me.btnSearchUnconfirmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUnconfirmed.Location = New System.Drawing.Point(15, 596)
        Me.btnSearchUnconfirmed.Name = "btnSearchUnconfirmed"
        Me.btnSearchUnconfirmed.Size = New System.Drawing.Size(210, 30)
        Me.btnSearchUnconfirmed.TabIndex = 20
        Me.btnSearchUnconfirmed.Text = "Show Unconfirmed Bookings"
        Me.btnSearchUnconfirmed.UseVisualStyleBackColor = True
        '
        'btnSearchAll
        '
        Me.btnSearchAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAll.Location = New System.Drawing.Point(231, 596)
        Me.btnSearchAll.Name = "btnSearchAll"
        Me.btnSearchAll.Size = New System.Drawing.Size(210, 30)
        Me.btnSearchAll.TabIndex = 21
        Me.btnSearchAll.Text = "Show All Bookings"
        Me.btnSearchAll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(314, 628)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 30)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(164, 628)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(127, 30)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(15, 628)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(127, 30)
        Me.btnNew.TabIndex = 24
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'dtpDate1
        '
        Me.dtpDate1.Location = New System.Drawing.Point(123, 50)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(153, 20)
        Me.dtpDate1.TabIndex = 25
        '
        'dtpDate2
        '
        Me.dtpDate2.Location = New System.Drawing.Point(354, 50)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(153, 20)
        Me.dtpDate2.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Bookings between"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "and"
        '
        'frmScheduledBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate2)
        Me.Controls.Add(Me.dtpDate1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearchAll)
        Me.Controls.Add(Me.btnSearchUnconfirmed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridBooking)
        Me.MaximizeBox = False
        Me.Name = "frmScheduledBookings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scheduled Bookings"
        CType(Me.gridBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridBooking As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearchUnconfirmed As System.Windows.Forms.Button
    Friend WithEvents btnSearchAll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dtpDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
