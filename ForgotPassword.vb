Public Class ForgotPassword
    Private Sub BtnFPBack_Click(sender As Object, e As EventArgs) Handles BtnFPBack.Click
        txtFPUsername.Clear()
        txtFPCurrentPassword.Clear()
        txtFPNewPassword.Clear()
        txtFPRetypeNewPass.Clear()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Me.Hide()
        forgotpass()
    End Sub
End Class