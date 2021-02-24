Public Class frmLogin
    Dim Employee As New clsEmployee

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.TextLength > 0 And txtPassword.TextLength > 0 Then
            If txtUsername.Text = "Admin" Then
                If txtPassword.Text = "Admin" Then
                    GetEmployee_Username = txtUsername.Text
                    GetEmployee_ID = "Admin1"
                    frmMainMenu.Show()
                    Me.Close()
                Else
                    txtPassword.Text = ""
                    MsgBox("Incorrect password for user: " & txtUsername.Text)
                End If
            Else
                ' check Employee table in database to see if they have a username
                If Employee.Login(txtUsername.Text.ToString, txtPassword.Text.ToString) Then
                    GetEmployee_Username = txtUsername.Text
                    GetEmployee_ID = Employee.GetEmployeeID(txtUsername.Text.ToString)
                    frmMainMenu.Show()
                    Me.Close()
                Else
                    MsgBox("Incorrect username or password.")
                End If
            End If
        Else
            lblError.Visible = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class