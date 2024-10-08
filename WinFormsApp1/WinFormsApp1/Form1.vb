Public Class Form1

    Dim adminUsername As String = "admin"
    Dim adminPassword As String = "admin123"
    Private lblError As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim enteredUsername As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text

        ' Check if the entered credentials match the hardcoded ones
        If enteredUsername = adminUsername AndAlso enteredPassword = adminPassword Then
            ' If login is successful, show a success message or redirect to another form
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Open the admin dashboard or main form
            Dim adminDashboard As New adminDashboard()
            adminDashboard.Show()
            Me.Hide() ' Hide the login form
        Else
            ' Show the error in a MessageBox instead of a label
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub Student_Click(sender As Object, e As EventArgs) Handles Student.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class
