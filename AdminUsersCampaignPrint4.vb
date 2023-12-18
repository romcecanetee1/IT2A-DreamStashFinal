Public Class AdminUsersCampaignPrint4
    Private Sub btnAdminCampLoadReport_Click(sender As Object, e As EventArgs) Handles btnAdminCampLoadReport.Click

        Dim StringFormula As String
        Dim StartDate As Date = Me.dtpCampaignStartDate.Value ' Use the Value property of DateTimePicker
        Dim EndDate As Date = Me.dtpCampaignEndDate.Value ' Use the Value property of DateTimePicker


        Dim cr As New CR_Campaign
        CrystalReportViewerCampaign.ReportSource = cr

        If cbxCampaignSearch.Checked = True Then

            If Not String.IsNullOrWhiteSpace(txtCRAdminSearchCampaign.Text) Then
                StringFormula = "{v_campaign1.CampaignStatus} LIKE '*" & txtCRAdminSearchCampaign.Text.ToString() & "*' "
                StringFormula &= "OR {v_campaign1.CampaignTitle} LIKE '*" & txtCRAdminSearchCampaign.Text.ToString() & "*' "
                StringFormula &= "OR {v_campaign1.CampaignDescription} LIKE '*" & txtCRAdminSearchCampaign.Text.ToString() & "*' "
            Else
                StringFormula = ""
            End If

        Else
            StringFormula = "{v_campaign1.StartDate} >= #" & StartDate & "# "
            StringFormula &= "AND {v_campaign1.EndDate} <= #" & EndDate & "# "

        End If

        CrystalReportViewerCampaign.SelectionFormula = StringFormula

        CrystalReportViewerCampaign.Refresh()
        CrystalReportViewerCampaign.RefreshReport()



    End Sub
End Class