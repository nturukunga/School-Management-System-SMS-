Public Class Loginfrm
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
        If TxtUsername.Text = "Username" Then
            TxtUsername.Text = ""
            TxtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        If TxtUsername.Text = "" Then
            TxtUsername.Text = "Username"
            TxtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtPassword.GotFocus
        If TxtPassword.Text = "Password" Then
            TxtPassword.Text = ""
            TxtPassword.PasswordChar = "*"c
            TxtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        If TxtPassword.Text = "" Then
            TxtPassword.PasswordChar = ControlChars.NullChar
            TxtPassword.Text = "Password"
            TxtPassword.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?",
                                     "Exit Confirmation",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        ' Check if the entered username and password are correct
        If TxtUsername.Text = "Admin" And TxtPassword.Text = "Admin1" Then
            ' Hide the login form
            Me.Hide() ' Hides the current form (login form)

            ' Show the dashboard or another form after successful login
            Dim dashboardForm As New Dashboard
            dashboardForm.Show()
        Else
            ' Show an error message if login details are incorrect
            MessageBox.Show("You have entered incorrect login details!",
                            "Login Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If
    End Sub

End Class
