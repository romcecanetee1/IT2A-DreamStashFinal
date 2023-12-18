Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AdminDashb
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnAdminHome.Click
        'home
        With AssistantAdminHome
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AssistantAdminHome)
            AssistantAdminHome.BringToFront()
            AssistantAdminHome.Show()
        End With
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnAdminUsers.Click
        'Users
        With AdminUsers
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminUsers)
            AdminUsers.BringToFront()
            AdminUsers.Show()
            SearchAdminUsers()
        End With
    End Sub

    Private Sub btnDonation_Click(sender As Object, e As EventArgs) Handles btnAdminDonation.Click
        'Donation Entries
        With AdminDonation
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminDonation)
            AdminDonation.BringToFront()
            AdminDonation.Show()
            DonationSearchCampaigns()
        End With

    End Sub

    Private Sub btnCampaign_Click(sender As Object, e As EventArgs) Handles btnAdminCampaign.Click
        'Campaign Entries
        With AdminCampaign
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminCampaign)
            AdminCampaign.BringToFront()
            AdminCampaign.Show()
            SearchCampaigns()
        End With
    End Sub

    Private Sub btnAdminLogout_Click(sender As Object, e As EventArgs) Handles btnAdminLogout.Click
        Me.Close()
        LogOut()

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

    Private Sub btnAdminBene_Click(sender As Object, e As EventArgs) Handles btnAdminBene.Click
        'Bene
        With AdminBene
            .TopLevel = False
            pnlAdminDashboard.Controls.Add(AdminBene)
            AdminBene.BringToFront()
            AdminBene.Show()
            AdminSearchBene()
        End With
    End Sub
End Class