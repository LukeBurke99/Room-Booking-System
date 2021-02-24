Public Class frmRoomDetails
    Dim Room As New clsRoom
    Private Sub frmRoomDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMainMenu.Show()
    End Sub

    Private Sub frmRoomDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Room.SetUpDataGridView(gridRoom)

        lblRecords.Text = gridRoom.RowCount()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridRoom.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        NewRecord = True
        frmAddRoom.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click
        Try
            Dim RoomID As String = gridRoom.SelectedRows(0).Cells(0).Value.ToString
            NewRecord = False
            GlobalID = RoomID
            frmAddRoom.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Choose a record to edit.")
        End Try
       
    End Sub

    Private Sub btnRemoveRoom_Click(sender As Object, e As EventArgs) Handles btnRemoveRoom.Click
        Dim RoomID As String = gridRoom.SelectedRows(0).Cells(0).Value.ToString
        GlobalID = RoomID

        If Room.DeleteRecord() Then
            MsgBox("Room has been removed from the table.")
            Room.SetUpDataGridView(gridRoom)
        Else
            MsgBox(Room.ErrorDescription)
        End If
    End Sub
End Class