Public Class AdminDonation
    Private Sub btnAdminDonationSearch_Click(sender As Object, e As EventArgs)
        DonationSearchCampaignsFilter()
    End Sub

    Private Sub btnAdminSaveDonation_Click(sender As Object, e As EventArgs) Handles btnAdminSaveDonation.Click
        AdminDonationEntry()
    End Sub

    Private Sub btnAdminCancelDonation_Click(sender As Object, e As EventArgs) Handles btnAdminCancelDonation.Click

    End Sub

    Private Sub AdminDonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdminSearchDonation_Click(sender As Object, e As EventArgs) Handles btnAdminSearchDonation.Click
        AdminSearchDonation2()
    End Sub

End Class