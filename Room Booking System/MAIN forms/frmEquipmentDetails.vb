Public Class frmEquipmentDetails
    Dim Equipment As New clsEquipment
    Private Sub frmEquipmentDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMainMenu.Show()
    End Sub

    Private Sub frmEquipmentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Equipment.SetUpDataGridView(gridEquipment)

        lblRecords.Text = gridEquipment.RowCount

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddEquipment_Click(sender As Object, e As EventArgs) Handles btnAddEquipment.Click
        NewRecord = True
        frmAddEquipment.Show()
        Me.Hide()
    End Sub

    Private Sub lblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click

    End Sub

    Private Sub btnEditEquipment_Click(sender As Object, e As EventArgs) Handles btnEditEquipment.Click
        Try
            Dim EquipmentID As String = gridEquipment.SelectedRows(0).Cells(0).Value.ToString
            NewRecord = False
            GlobalID = EquipmentID
            frmAddEquipment.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Choose a record to edit.")
        End Try
        
    End Sub

    Private Sub btnRemoveEquipment_Click(sender As Object, e As EventArgs) Handles btnRemoveEquipment.Click
        Dim EquipmentID As String = gridEquipment.SelectedRows(0).Cells(0).Value.ToString
        GlobalID = EquipmentID

        If Equipment.DeleteRecord() Then
            MsgBox("Equipment item has been removed from the table.")
            Equipment.SetUpDataGridView(gridEquipment)
        Else
            MsgBox(Equipment.ErrorDescription)
        End If
    End Sub
End Class