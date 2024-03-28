Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the password TextBox to hide the password by default '
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub
    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        PasswordTextBox.UseSystemPasswordChar = Not ShowPassword.Checked
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        Dim username As String = UserNameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        If AuthenticationConnection.AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!")
            Dim form1 As New Form1()
            CreateQRCode.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Sub cancelLogIN_btn_Click(sender As Object, e As EventArgs) Handles cancelLogIN_btn.Click
        Me.Close()
    End Sub

End Class