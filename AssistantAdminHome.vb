Public Class AssistantAdminHome
    Private Sub AssistantAdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAdminHome1()
        pnlAdminHome2()
        pnlAdminHome3()
    End Sub

    Private Sub btnAdminRefresh_Click_1(sender As Object, e As EventArgs) Handles btnAdminRefresh.Click
        RefreshLabels()
    End Sub

    Private Sub pnlAsstHome_Paint(sender As Object, e As PaintEventArgs) Handles pnlAsstHome.Paint

    End Sub

    Private Sub btnAdminUsers_Click(sender As Object, e As EventArgs) Handles btnAdminUsers.Click
        AdminUsersPrint1.Show()
    End Sub

    Private Sub btnAdminDonationHistory_Click(sender As Object, e As EventArgs) Handles btnAdminDonationHistory.Click
        AdminUsersDonationHistoryPaint2.Show()
    End Sub

    Private Sub btnAdminBene_Click(sender As Object, e As EventArgs) Handles btnAdminBene.Click
        AdminUsersBenePrint3.Show()
    End Sub

    Private Sub btnAdminCampaigns_Click(sender As Object, e As EventArgs) Handles btnAdminCampaigns.Click
        ' AdminUsersCampaignPrint4.Show()
        Dim CampaignCR As New AdminUsersCampaignPrint4()
        CampaignCR.Show()

    End Sub
End Class