Public Class frmClientDetails
    Dim Client As New clsCustomer
    Private Sub frmClientDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMainMenu.Show()
    End Sub

    Private Sub frmClientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Client.PersonSetUpDataGridView(gridClient)

        lblRecords.Text = gridClient.RowCount()
    End Sub

    Private Sub lblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        NewRecord = True
        frmAddClient.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditClient_Click(sender As Object, e As EventArgs) Handles btnEditClient.Click
        Try
            Dim CustomerID As String = gridClient.SelectedRows(0).Cells(0).Value.ToString
            NewRecord = False
            GlobalID = CustomerID
            frmAddClient.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Choose a record to edit.")
        End Try
        
    End Sub

    Private Sub btnRemoveClient_Click(sender As Object, e As EventArgs) Handles btnRemoveClient.Click
        Dim CustomerID As String = gridClient.SelectedRows(0).Cells(0).Value.ToString
        GlobalID = CustomerID

        If Client.DeleteRecord() Then
            MsgBox("Client has been removed from the table.")
            Client.PersonSetUpDataGridView(gridClient)
        Else
            MsgBox(Client.PersonErrorDescription)
        End If
    End Sub
End Class