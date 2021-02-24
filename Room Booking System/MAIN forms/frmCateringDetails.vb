Public Class frmCateringDetails
    Dim Food As New clsFood
    Private Sub frmCateringDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMainMenu.Show()
    End Sub

    Private Sub frmCateringDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Food.SetUpDataGridView(gridCatering)

        lblRecords.Text = gridCatering.RowCount()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddCateringItem_Click(sender As Object, e As EventArgs) Handles btnAddCateringItem.Click
        NewRecord = True
        frmAddCatering.Show()
        Me.Hide()
    End Sub

    Private Sub lblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click

    End Sub

    Private Sub btnEditCateringItem_Click(sender As Object, e As EventArgs) Handles btnEditCateringItem.Click
        Try
            Dim FoodID As String = gridCatering.SelectedRows(0).Cells(0).Value.ToString
            NewRecord = False
            GlobalID = FoodID
            frmAddCatering.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Choose a record to edit.")
        End Try
        
    End Sub

    Private Sub btnRemoveCateringItem_Click(sender As Object, e As EventArgs) Handles btnRemoveCateringItem.Click
        Dim FoodID As String = gridCatering.SelectedRows(0).Cells(0).Value.ToString
        GlobalID = FoodID

        If Food.DeleteRecord() Then
            MsgBox("Food item has been removed from the table.")
            Food.SetUpDataGridView(gridCatering)
        Else
            MsgBox(Food.ErrorDescription)
        End If
    End Sub
End Class