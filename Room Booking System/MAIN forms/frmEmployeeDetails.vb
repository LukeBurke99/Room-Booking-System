Public Class frmEmployeeDetails
    Dim Employee As New clsEmployee
    Private Sub frmEmployeeDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMainMenu.Show()
    End Sub

    Private Sub frmEmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employee.PersonSetUpDataGridView(gridEmployee)

        lblRecords.Text = gridEmployee.RowCount()
    End Sub

    Private Sub lblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        NewRecord = True
        frmAddEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click

        Try
            Dim EmployeeID As String = gridEmployee.SelectedRows(0).Cells(0).Value.ToString
            NewRecord = False
            GlobalID = EmployeeID
            frmAddEmployee.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Choose a record to edit.")
        End Try
        
    End Sub

    Private Sub btnRemoveEmployee_Click(sender As Object, e As EventArgs) Handles btnRemoveEmployee.Click
        Dim EmployeeID As String = gridEmployee.SelectedRows(0).Cells(0).Value.ToString
        GlobalID = EmployeeID

        If Employee.DeleteRecord() Then
            MsgBox("Employee has been removed from the table.")
            Employee.PersonSetUpDataGridView(gridEmployee)
        Else
            MsgBox(Employee.PersonErrorDescription)
        End If
    End Sub
End Class