Public Class frmAddClient
    Dim Client As New clsCustomer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click

        ' setting the variables to the text in the text boxes
        With Client
            .PersonID = lblClientID.Text
            .PersonFirstName = txtFirstName.Text
            .PersonSurname = txtSurname.Text
            .PersonAddress = txtAddress.Text
            .PersonPostcode = txtPostcode.Text
            .PersonTelephoneNumber = txtTelephoneNumber.Text
            .PersonEmailAddress = txtEmailAddress.Text
            .PersonNotes = txtNotes.Text
        End With

        If Client.PersonUpdate = True Then
            ' Display an update label.
            MsgBox("Client has been added to the system.")
            lblClientID.Text = GetNextClientID()
            txtFirstName.Text = ""
            txtSurname.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""
            txtTelephoneNumber.Text = ""
            txtEmailAddress.Text = ""
            txtNotes.Text = ""
        Else
            ' Display an error
            MsgBox(Client.PersonErrorDescription)
        End If

    End Sub

    Private Sub frmAddClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmClientDetails.Show()
        Client.PersonSetUpDataGridView(frmClientDetails.gridClient)
    End Sub

    Private Sub frmAddClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NewRecord Then
            lblClientID.Text = GetNextClientID()
            btnSaveChanges.Enabled = False
            btnAddClient.Enabled = True
        Else
            Client.GetClientDetails()
            btnSaveChanges.Enabled = True
            btnAddClient.Enabled = False

            lblClientID.Text = Client.PersonID
            txtFirstName.Text = Client.PersonFirstName
            txtSurname.Text = Client.PersonSurname
            txtAddress.Text = Client.PersonAddress
            txtPostcode.Text = Client.PersonPostcode
            txtTelephoneNumber.Text = Client.PersonTelephoneNumber
            txtEmailAddress.Text = Client.PersonEmailAddress
            txtNotes.Text = Client.PersonNotes
        End If

    End Sub

    Private Function GetNextClientID() As String
        Dim table As String = "Customer"
        Dim CustomerID As String = "C"
        Dim LastID As Integer
        LastID = CInt(GetMaxID(table))
        CustomerID = CustomerID & ((LastID + 1).ToString("D5"))
        Return CustomerID
    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        With Client
            .PersonFirstName = txtFirstName.Text
            .PersonSurname = txtSurname.Text
            .PersonAddress = txtAddress.Text
            .PersonPostcode = txtPostcode.Text
            .PersonTelephoneNumber = txtTelephoneNumber.Text
            .PersonEmailAddress = txtEmailAddress.Text
            .PersonNotes = txtNotes.Text
        End With

        If Client.SaveChanges() = True Then
            MsgBox("Changes have been made to the record.")
        Else
            MsgBox(Client.PersonErrorDescription)
        End If
        GlobalID = "000000"
        Me.Close()
    End Sub

End Class