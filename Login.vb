Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBoxPass_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        'Show Get Started
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
        ReloadDB()
        Get_Started.Show()
        Me.Hide()
    End Sub

    Private Sub ControlBoxClose_Click(sender As Object, e As EventArgs) Handles ControlBoxClose.Click
        'Close
        'Me.Close()
        Application.Exit()
    End Sub

    Private Sub BtnForgotPass_Click(sender As Object, e As EventArgs) Handles BtnForgotPass.Click
        txtUsername.Clear()
        txtPassword.Clear()
        ForgotPassword.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogin_Enter(sender As Object, e As EventArgs) Handles btnLogin.Enter
        AccLogin()
    End Sub

    Private Sub LoginMessage_Click(sender As Object, e As EventArgs) Handles lblLoginMessage.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub
End Class
