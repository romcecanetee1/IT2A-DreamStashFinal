Public Class AssistantAdminDonation1
    Private Sub btnAssistantDonationSearch_Click(sender As Object, e As EventArgs) Handles btnAssistantDonationSearch.Click
        AssistantDonationSearchCampaignsFilter()
    End Sub

    Private Sub btnAssistantSaveDonation_Click(sender As Object, e As EventArgs) Handles btnAssistantSaveDonation.Click
        AssistantDonationEntry()
    End Sub

    Private Sub AssistantAdminDonation1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AssistantDonationSearchCampaignsFilter()
    End Sub
End Class