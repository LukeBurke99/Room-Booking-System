Public Class frmAddEmployee
    Dim Employee As New clsEmployee
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        With Employee
            .PersonID = lblEmployeeID.Text
            .PersonFirstName = txtFirstName.Text
            .PersonSurname = txtSurname.Text
            .PersonAddress = txtAddress.Text
            .PersonPostcode = txtPostcode.Text
            .PersonTelephoneNumber = txtTelephoneNumber.Text
            .PersonEmailAddress = txtEmailAddress.Text
            .EmployeeStartDate = Format(dtpStarted.Value, "yyyy-MM-dd")
            .PersonNotes = txtNotes.Text
            .EmployeeUserCanLogon = cbAllowLogon.Checked
            .EmployeeUsername = lblUsername.Text
            .EmployeePassword = txtPassword.Text
        End With

        If cbEmployeeLeft.Checked Then
            Employee.EmployeeEndDate = Format(dtpEnded.Value, "yyyy-MM-dd")
        End If

        If Employee.PersonUpdate() = True Then
            ' Display an update label.
            MsgBox("Employee has been added to the system.")
            lblEmployeeID.Text = GetNextEmployeeID()
            txtFirstName.Text = ""
            txtSurname.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""
            txtTelephoneNumber.Text = ""
            txtEmailAddress.Text = ""
            dtpStarted.Value = Date.Today
            dtpEnded.Value = Date.Today
            txtNotes.Text = ""
        Else
            ' Display an error
            MsgBox(Employee.PersonErrorDescription)
        End If

    End Sub

    Private Sub frmAddEmployee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmEmployeeDetails.Show()
        Employee.PersonSetUpDataGridView(frmEmployeeDetails.gridEmployee)
    End Sub

    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NewRecord Then
            lblEmployeeID.Text = GetNextEmployeeID()
            btnSaveChanges.Enabled = False
            btnAddEmployee.Enabled = True
        Else
            Employee.GetEmployeeDetails()
            btnSaveChanges.Enabled = True
            btnAddEmployee.Enabled = False

            lblEmployeeID.Text = Employee.PersonID
            txtFirstName.Text = Employee.PersonFirstName
            txtSurname.Text = Employee.PersonSurname
            txtAddress.Text = Employee.PersonAddress
            txtPostcode.Text = Employee.PersonPostcode
            txtTelephoneNumber.Text = Employee.PersonTelephoneNumber
            txtEmailAddress.Text = Employee.PersonEmailAddress
            txtNotes.Text = Employee.PersonNotes
            dtpStarted.Value = Employee.EmployeeStartDate
            Try
                dtpEnded.Value = Employee.EmployeeEndDate
                cbEmployeeLeft.Checked = True
            Catch ex As Exception
            End Try
            cbAllowLogon.Checked = Employee.EmployeeUserCanLogon
            txtPassword.Text = Employee.EmployeePassword
        End If

    End Sub

    Private Function GetNextEmployeeID() As String
        Dim table As String = "Employee"
        Dim EmployeeID As String = "E"
        Dim LastID As Integer
        LastID = CInt(GetMaxID(table))
        EmployeeID = EmployeeID & ((LastID + 1).ToString("D5"))
        Return EmployeeID
    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        With Employee
            .PersonFirstName = txtFirstName.Text
            .PersonSurname = txtSurname.Text
            .PersonAddress = txtAddress.Text
            .PersonPostcode = txtPostcode.Text
            .PersonTelephoneNumber = txtTelephoneNumber.Text
            .PersonEmailAddress = txtEmailAddress.Text
            .EmployeeStartDate = Format(dtpStarted.Value, "yyyy-MM-dd")
            .EmployeeEndDate = Format(dtpEnded.Value, "yyyy-MM-dd")
            .PersonNotes = txtNotes.Text
            .EmployeeUserCanLogon = cbAllowLogon.Checked
            .EmployeeUsername = lblUsername.Text
            .EmployeePassword = txtPassword.Text
        End With

        If Employee.SaveChanges() = True Then
            MsgBox("Changes have been made to the record.")
            GlobalID = "000000"
            Me.Close()
        Else
            MsgBox(Employee.PersonErrorDescription)
        End If

    End Sub

    Private Sub cbAllowLogon_CheckedChanged(sender As Object, e As EventArgs) Handles cbAllowLogon.CheckedChanged
        Dim username As String = ""
        If cbAllowLogon.Checked Then
            For i = 1 To lblEmployeeID.Text.Length - 1
                username += lblEmployeeID.Text(i)
            Next
            gbLoginDetails.Visible = True
            lblUsername.Text = txtFirstName.Text + username
        Else
            gbLoginDetails.Visible = False
            lblUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If txtFirstName.Text <> "" Then
            cbAllowLogon.Visible = True
        Else
            cbAllowLogon.Visible = False
            cbAllowLogon.Checked = False
            lblUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub cbEmployeeLeft_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmployeeLeft.CheckedChanged
        Label9.Visible = cbEmployeeLeft.Checked
        dtpEnded.Visible = cbEmployeeLeft.Checked
    End Sub
End Class