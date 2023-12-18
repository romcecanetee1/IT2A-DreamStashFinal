Public Class AdminUpdateUsers

    Dim editPass As Integer = 0
    Private Sub btnAdminUpdateCancel_Click(sender As Object, e As EventArgs) Handles btnAdminUpdateUserCancel.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Cancel changes?", "Cancel Changes", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' If the user clicks Yes in the message box, cancel changes and show the AdminUsers form
            'AdminUsers.Show()
            'Me.Hide()
            'AdminUpdateUsersClear()
            ' Perform any necessary actions for canceling changes here

            If String.IsNullOrWhiteSpace(txtAdminUpdateUserPasswordConfirm.Text) Then
                MsgBox("Password cannot be empty!")
                txtAdminUpdateUserPassword.Clear()
                txtAdminUpdateUserPasswordConfirm.Clear()
                txtAdminUpdateUserPassword.Focus()

            Else
                Dim UserID As String = lblUserID.Text
                ChangeUpdateAdminUsers(UserID)

            End If

        Else
            ' If the user clicks No in the message box, do not cancel changes
            ' You may want to handle different scenarios based on the user's choice
            ' For example, do nothing or perform other actions
            AdminUsers.Show()
            Me.Hide()
            SearchAdminUsers()

        End If
    End Sub

    Private Sub btnAdminUpdateUserSave_Click(sender As Object, e As EventArgs) Handles btnAdminUpdateUserSave.Click
        If String.IsNullOrWhiteSpace(txtAdminUpdateUserPassword.Text) Or String.IsNullOrWhiteSpace(txtAdminUpdateUserPasswordConfirm.Text) Then
            MsgBox("Password cannot be empty!")
            AdminUpdateUsersClear()

        Else
            Dim pass As String = txtAdminUpdateUserPassword.Text
            Dim newpass As String = txtAdminUpdateUserPasswordConfirm.Text

            If pass = newpass Then

                If pass = lblOldPass.Text And editPass = 1 Then
                    MsgBox("Password must be different from the existing!")
                    AdminUpdateUsersClear()

                Else
                    Dim UserID As String = lblUserID.Text
                    ChangeUpdateAdminUsers(UserID)
                    editPass = 0

                End If

            Else
                MsgBox("Password didn't match!")
                AdminUpdateUsersClear()

            End If

        End If

    End Sub


    Private Sub txtAdminUpdateUserPassword_Click(sender As Object, e As EventArgs) Handles txtAdminUpdateUserPassword.Click

        editPass = 1

        txtAdminUpdateUserPassword.Clear()
        txtAdminUpdateUserPasswordConfirm.Clear()
    End Sub

    Private Sub AdminUpdateUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdminUpdateUserPassword.UseSystemPasswordChar = True
        txtAdminUpdateUserPasswordConfirm.UseSystemPasswordChar = True

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        AdminUsers.Show()
        Me.Hide()
        SearchAdminUsers()

    End Sub

End Class