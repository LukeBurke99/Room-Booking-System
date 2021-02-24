Public Class frmAddEquipment
    Dim Equipment As New clsEquipment
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddEquipment_Click(sender As Object, e As EventArgs) Handles btnAddEquipment.Click
        Try
            With Equipment
                .EquipmentID = lblEquipmentID.Text
                .EquipmentName = txtName.Text
                .EquipmentQuantity = CInt(txtQuantity.Text)
                .EquipmentPrice = CDec(txtPrice.Text)
                .EquipmentNotes = txtNotes.Text
            End With

            If Equipment.Update() = True Then
                ' Display an update label.
                MsgBox("Equipment has been added to the system.")
                lblEquipmentID.Text = GetNextEquipmentID()
                txtName.Text = ""
                txtQuantity.Text = ""
                txtPrice.Text = ""
                txtNotes.Text = ""
            Else
                ' Display an error
                MsgBox(Equipment.ErrorDescription)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        

    End Sub

    Private Sub frmAddEquipment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmEquipmentDetails.Show()
        Equipment.SetUpDataGridView(frmEquipmentDetails.gridEquipment)
    End Sub

    Private Sub frmAddEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NewRecord Then
            lblEquipmentID.Text = GetNextEquipmentID()
            btnSaveChanges.Enabled = False
            btnAddEquipment.Enabled = True
        Else
            Equipment.GetEquipmentDetails()
            btnSaveChanges.Enabled = True
            btnAddEquipment.Enabled = False

            lblEquipmentID.Text = Equipment.EquipmentID
            txtName.Text = Equipment.EquipmentName
            txtNotes.Text = Equipment.EquipmentNotes
            txtQuantity.Text = Equipment.EquipmentQuantity
            txtPrice.Text = Equipment.EquipmentPrice
        End If

    End Sub

    Private Function GetNextEquipmentID() As String
        Dim table As String = "Equipment"
        Dim EquipmentID As String = "P"
        Dim LastID As Integer
        LastID = CInt(GetMaxID(table))
        EquipmentID = EquipmentID & ((LastID + 1).ToString("D5"))
        Return EquipmentID
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            With Equipment
                .EquipmentName = txtName.Text
                .EquipmentQuantity = CInt(txtQuantity.Text)
                .EquipmentPrice = CDec(txtPrice.Text)
                .EquipmentNotes = txtNotes.Text
            End With

            If Equipment.SaveChanges() = True Then
                MsgBox("Changes have been made to the record.")
            Else
                MsgBox(Equipment.ErrorDescription)
            End If
            GlobalID = "000000"
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub


End Class