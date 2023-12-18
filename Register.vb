Public Class Register
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Get_Started.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        AccRegister()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ControlBoxClose_Click(sender As Object, e As EventArgs) Handles ControlBoxClose.Click

    End Sub
End Class