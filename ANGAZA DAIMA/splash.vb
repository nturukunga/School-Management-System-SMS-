Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Timer Interval (in case it's not set in the properties)
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Stop the Timer after 3 seconds
        Timer1.Stop()

        ' Hide the splash screen and show the login form
        Me.Hide()

        ' Show the login form
        Dim loginForm As New Loginfrm
        loginForm.Show()
    End Sub

End Class
