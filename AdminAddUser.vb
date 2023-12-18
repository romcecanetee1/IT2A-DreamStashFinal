Public Class AdminAddUser
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        AdminAddUsers()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        AdminUsers.Show()
        Me.Hide()
        SearchAdminUsers()

    End Sub

End Class