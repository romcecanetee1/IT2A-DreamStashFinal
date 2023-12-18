Public Class DonorAccountSetting
    Private Sub btnAccountSettingUpdate_Click(sender As Object, e As EventArgs) Handles btnAccountSettingUpdate.Click
        Dim UserID As Integer = DonorDashb.lblUserID.Text
        ChangeUpdateDonorAccountSettings(UserID)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class