Public Class frmMainMenu

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToLongDateString()
    End Sub

    Private Sub btnBookingMenu_Click(sender As Object, e As EventArgs) Handles btnBookingMenu.Click
        frmScheduledBookings.Show()
        Me.Hide()
    End Sub

    Private Sub btnCateringDetails_Click(sender As Object, e As EventArgs) Handles btnCateringDetails.Click
        frmCateringDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnClientDetails_Click(sender As Object, e As EventArgs) Handles btnClientDetails.Click
        frmClientDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoomDetails_Click(sender As Object, e As EventArgs) Handles btnRoomDetails.Click
        frmRoomDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmployeeDetails_Click(sender As Object, e As EventArgs) Handles btnEmployeeDetails.Click
        frmEmployeeDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnEquipmentDetails_Click(sender As Object, e As EventArgs) Handles btnEquipmentDetails.Click
        frmEquipmentDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
