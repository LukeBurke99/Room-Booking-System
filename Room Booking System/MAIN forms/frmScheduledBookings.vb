Public Class frmScheduledBookings
    Dim Booking As New clsBooking
    Private Sub btnSearchUnconfirmed_Click(sender As Object, e As EventArgs) Handles btnSearchUnconfirmed.Click
        Dim SearchReference As Integer = 1

        Booking.BookingSetUpDataGridView(gridBooking, SearchReference, dtpDate1.Value, dtpDate2.Value)

    End Sub

    Private Sub btnSearchAll_Click(sender As Object, e As EventArgs) Handles btnSearchAll.Click
        Dim SearchReference As Integer = 0

        Booking.BookingSetUpDataGridView(gridBooking, SearchReference, dtpDate1.Value, dtpDate2.Value)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmScheduledBookings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMainMenu.Show()
    End Sub

    Private Sub frmScheduledBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SearchReference As Integer = 0

        Booking.BookingSetUpDataGridView(gridBooking, SearchReference, dtpDate1.Value, dtpDate2.Value)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewRecord = True
        frmBookingMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim BookingID As String = gridBooking.SelectedRows(0).Cells(0).Value.ToString
            MsgBox(BookingID)
            NewRecord = False
            GlobalID = BookingID
            frmBookingMenu.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Choose a record to edit.")
        End Try
        
    End Sub

End Class