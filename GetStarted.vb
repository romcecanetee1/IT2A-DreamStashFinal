Public Class Get_Started
    Private Sub btngetlogin_Click(sender As Object, e As EventArgs) Handles btnGetLogin.Click
        'Show Login
        Login.lblLoginMessage.Text = ""
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btngtregister_Click(sender As Object, e As EventArgs)
        'Show Register
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub ControlBoxClose_Click(sender As Object, e As EventArgs) Handles ControlBoxClose.Click
        Me.Close()
    End Sub

    Private Sub Get_Started_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check Connected
        Dbconnection()
    End Sub


End Class