Public Class AssistantAdminDashboard
    Private Sub btnAsstAdminHome_Click(sender As Object, e As EventArgs) Handles btnAdminHome.Click
        With AssistantAdminHome
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AssistantAdminHome)
            AssistantAdminHome.BringToFront()
            AssistantAdminHome.Show()
        End With
    End Sub

    Private Sub btnAdminUsers_Click(sender As Object, e As EventArgs) Handles btnAdminUsers.Click
        'Users
        With AssistantAdminUser
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AssistantAdminUser)
            AssistantAdminUser.BringToFront()
            AssistantAdminUser.Show()
        End With
    End Sub

    Private Sub btnAdminDonation_Click(sender As Object, e As EventArgs) Handles btnAdminDonation.Click
        'Donation Entries
        With AdminDonation
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminDonation)
            AdminDonation.BringToFront()
            AdminDonation.Show()
            DonationSearchCampaigns()
        End With
    End Sub

    Private Sub btnAdminCampaign_Click(sender As Object, e As EventArgs) Handles btnAdminCampaign.Click
        'Campaign Entries
        With AdminCampaign
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminCampaign)
            AdminCampaign.BringToFront()
            AdminCampaign.Show()
            SearchCampaigns()
        End With
    End Sub

    Private Sub btnAsstAdminLogout_Click(sender As Object, e As EventArgs) Handles btnAsstAdminLogout.Click
        Me.Close()
        LogOut()

    End Sub

    Private Sub btnAssistBene_Click(sender As Object, e As EventArgs) Handles btnAssistBene.Click
        With AdminBene
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminBene)
            AdminBene.BringToFront()
            AdminBene.Show()
            AdminSearchBene()
        End With
    End Sub

    Private Sub btnAdminDonationHisto_Click(sender As Object, e As EventArgs) Handles btnAdminDonationHisto.Click
        'Donation History

        Dim username As String = DonorDashb.lblUsername.Text

        With DonorHistory
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(DonorHistory)
            DonorHistory.BringToFront()
            DonorHistory.Show()
            AdminDonationHistory()
        End With
    End Sub
End Class