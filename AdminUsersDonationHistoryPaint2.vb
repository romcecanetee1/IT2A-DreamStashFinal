Public Class AdminUsersDonationHistoryPaint2
    Private Sub btnAdminDonationReport_Click(sender As Object, e As EventArgs) Handles btnAdminDonationReport.Click


        Dim StringFormula As String
        Dim StartDate As Date = Me.dtpDonationStartDate.Value ' Use the Value property of DateTimePicker
        Dim EndDate As Date = Me.dtpDonationEndDate.Value ' Use the Value property of DateTimePicker


        Dim cr As New CR_DonationHistory
        CrystalReportViewerDonation.ReportSource = cr

        If cbxDonationSearch.Checked = True Then

            If Not String.IsNullOrWhiteSpace(txtCRAdminDonationReport.Text) Then
                StringFormula = "{donations1.Donor} LIKE '*" & txtCRAdminDonationReport.Text.ToString() & "*' "
                StringFormula &= "OR {donations1.CampaignTitle} LIKE '*" & txtCRAdminDonationReport.Text.ToString() & "*' "

            Else
                StringFormula = ""
            End If

        Else
            StringFormula = "{donations1.DonationDate} >= #" & StartDate & "# "
            StringFormula &= "AND {donations1.DonationDate} <= #" & EndDate & "# "

        End If

        CrystalReportViewerDonation.SelectionFormula = StringFormula

        CrystalReportViewerDonation.Refresh()
        CrystalReportViewerDonation.RefreshReport()


    End Sub

End Class