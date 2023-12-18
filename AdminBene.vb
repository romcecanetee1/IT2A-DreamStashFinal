Public Class AdminBene
    Private Sub btnAdminSearchUsers_Click(sender As Object, e As EventArgs) Handles btnAdminSearchBene.Click
        AdminSearchBene()
    End Sub

    Private Sub AdminBene_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdminSaveDonation_Click(sender As Object, e As EventArgs) Handles btnAdminSaveDonation.Click
        AdminAddBene()
    End Sub

    Private Sub btnAdminCancelDonation_Click(sender As Object, e As EventArgs) Handles btnAdminCancelDonation.Click
        txtBeneName.Clear()
        txtBeneInfo.Clear()
    End Sub
End Class