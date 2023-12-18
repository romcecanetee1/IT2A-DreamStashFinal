Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class AdminUsers
    Private Sub btnEditUsers_Click(sender As Object, e As EventArgs) Handles btnAdminEditUsers.Click

        Try
            Dim i, id As Integer
            i = dgvAdminUsers.CurrentRow.Index
            id = dgvAdminUsers.Item(0, i).Value
            PopulateUsers(id)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        AdminAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminSearchUsers_Click(sender As Object, e As EventArgs) Handles btnAdminSearchUsers.Click
        SearchAdminUsers()
    End Sub

    Private Sub AdminUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub dgvAdminUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdminUsers.CellClick

        btnAdminEditUsers.Enabled = True
        btndelete.Enabled = True

        Dim i, id As Integer
        i = dgvAdminUsers.CurrentRow.Index
        id = dgvAdminUsers.Item(0, i).Value

        lblID.Text = id.ToString

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim i, id As Integer
            i = dgvAdminUsers.CurrentRow.Index
            id = dgvAdminUsers.Item(0, i).Value
            AdminDeleteUser(id)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
End Class