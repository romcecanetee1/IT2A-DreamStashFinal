Imports Microsoft.VisualBasic.ApplicationServices

Public Class AdminUpdateCampaign
    Private Sub btnAdminUpdateCancel_Click_1(sender As Object, e As EventArgs) Handles btnAdminUpdateCampaignCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Cancel Changes", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' If the user clicks Yes in the message box, go back to previous page 
            AdminCampaign.Show()
            Me.Hide()
            ' Perform the search for campaigns
            SearchCampaigns()
        Else
            ' If the user clicks No in the message box, do nothing 
        End If

    End Sub

    Private Sub btnAdminUpdateSave_Click(sender As Object, e As EventArgs) Handles btnAdminUpdateSave.Click
        Dim NewDonationGoal As String = txtAdminUpdateCampaignDonationGoal.Text
        'Dim asDecimal As Decimal = Decimal.Parse(NewDonationGoal)

        If Not String.IsNullOrWhiteSpace(NewDonationGoal) Then
            Try
                Dim asDecimal As Decimal = Decimal.Parse(NewDonationGoal).ToString("##,###0.00")
                'MsgBox("Campaign created successfully!" & vbCrLf & "Donation Goal: Php " & asDecimal.ToString)
                txtAdminUpdateCampaignDonationGoal.Text = asDecimal.ToString
                ' Hide the current form and show the Admin Search Campaigns form
                'Me.Hide()
                'AdminSearchCampaigns()
                Dim CampaignID As Integer = CInt(lblCampaignID.Text)
                ChangeUpdateAdminCampaigns(CampaignID)

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                txtAdminUpdateCampaignDonationGoal.Clear()
                txtAdminUpdateCampaignDonationGoal.Focus()
            End Try
        Else
            MsgBox("Input a value!")
            ' Show the Admin Campaign form and hide the current form
            txtAdminUpdateCampaignDonationGoal.Focus()

        End If
    End Sub


End Class