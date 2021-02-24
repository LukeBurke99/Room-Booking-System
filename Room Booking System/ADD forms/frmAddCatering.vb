Public Class frmAddCatering
    Dim Food As New clsFood
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddCateringItem_Click(sender As Object, e As EventArgs) Handles btnAddCateringItem.Click
        Try

            With Food
                .FoodID = lblFoodID.Text
                .FoodName = txtName.Text
                .FoodDescription = txtDescription.Text
                .FoodPrice = CDec(txtPrice.Text)
                .FoodNotes = txtNotes.Text
            End With

            If Food.Update = True Then
                ' Display an update label.
                MsgBox("Food has been added to the system.")
                lblFoodID.Text = GetNextFoodID()
                txtName.Text = ""
                txtDescription.Text = ""
                txtPrice.Text = ""
                txtNotes.Text = ""
            Else
                ' Display an error
                MsgBox(Food.ErrorDescription)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub frmAddCatering_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmCateringDetails.Show()
        Food.SetUpDataGridView(frmCateringDetails.gridCatering)
    End Sub

    Private Sub frmAddCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NewRecord Then
            lblFoodID.Text = GetNextFoodID()
            btnSaveChanges.Enabled = False
            btnAddCateringItem.Enabled = True
        Else
            Food.GetFoodDetails()
            btnSaveChanges.Enabled = True
            btnAddCateringItem.Enabled = False

            lblFoodID.Text = Food.FoodID
            txtName.Text = Food.FoodName
            txtDescription.Text = Food.FoodDescription
            txtPrice.Text = Food.FoodPrice
            txtNotes.Text = Food.FoodNotes
        End If

    End Sub

    Private Function GetNextFoodID() As String
        Dim table As String = "Food"
        Dim FoodID As String = "F"
        Dim LastID As Integer
        LastID = CInt(GetMaxID(table))
        FoodID = FoodID & ((LastID + 1).ToString("D5"))
        Return FoodID
    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            With Food
                .FoodName = txtName.Text
                .FoodDescription = txtDescription.Text
                .FoodPrice = CDec(txtPrice.Text)
                .FoodNotes = txtNotes.Text
            End With
            If Food.SaveChanges() = True Then
                MsgBox("Changes have been made to record.")
            Else
                MsgBox(Food.ErrorDescription)
            End If
            GlobalID = "000000"
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub
End Class
