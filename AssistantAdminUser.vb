Public Class AssistantAdminUser


    Private Sub AssistantAdminUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        SearchAssistantUsers()
    End Sub

    Private Sub btnAssistantAdminSearchUsers_Click(sender As Object, e As EventArgs) Handles btnAssistantAdminSearchUsers.Click
        SearchAssistantUsers()
    End Sub
End Class