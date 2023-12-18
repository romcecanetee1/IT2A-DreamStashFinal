Public Class DonorDashb
    Public Property UserID As Integer

    Private Sub btnDonorAccountSetting_Click(sender As Object, e As EventArgs) Handles btnDonorAccountSetting.Click
        'Account Setting
        With DonorAccountSetting
            .TopLevel = False
            pnlDonorDashboard.Controls.Add(DonorAccountSetting)
            DonorAccountSetting.BringToFront()
            DonorAccountSetting.Show()
        End With
    End Sub

    Private Sub btnDonorHome_Click(sender As Object, e As EventArgs) 
        'Home
        With DonorHome
            .TopLevel = False
            pnlDonorDashboard.Controls.Add(DonorHome)
            DonorHome.BringToFront()
            DonorHome.Show()
        End With
    End Sub

    Private Sub btnDonorDonationHistory_Click(sender As Object, e As EventArgs) Handles btnDonorDonationHistory.Click
        'Donation History

        Dim username As String = lblUsername.Text

        With DonorDonationHisto2
            .TopLevel = False
            pnlDonorDashboard.Controls.Add(DonorDonationHisto2)
            DonorDonationHisto2.BringToFront()
            DonorDonationHisto2.Show()
            Connector.DonorDonationHistory2(username)
        End With
    End Sub
    Private Sub btnDonorLogout_Click(sender As Object, e As EventArgs) Handles btnDonorLogout.Click
        Me.Close()
        LogOut()

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub btnDonorCampaign_Click(sender As Object, e As EventArgs) Handles btnDonorCampaign.Click
        'Donor Campaign
        With DonorCampaign
            .TopLevel = False
            pnlDonorDashboard.Controls.Add(DonorCampaign)
            DonorCampaign.BringToFront()
            DonorCampaign.Show()
        End With
    End Sub

    Private Sub DonorDashb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DonorCampaigns
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Bene
        With DonorBene
            .TopLevel = False
            pnlDonorDashboard.Controls.Add(DonorBene)
            DonorBene.BringToFront()
            DonorBene.Show()
            DonorSearchBene()
        End With
    End Sub
End Class