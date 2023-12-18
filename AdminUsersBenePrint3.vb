Public Class AdminUsersBenePrint3
    Private Sub btnAdminBeneLoadReport_Click(sender As Object, e As EventArgs) Handles btnAdminBeneLoadReport.Click
        Dim StringFormula As String

        Dim cr As New CR_Beneficiary
        CrystalReportViewerBene.ReportSource = cr

        If cbxBeneSearch.Checked = True Then

            If Not String.IsNullOrWhiteSpace(txtCRAdminSearchBene.Text) Then
                StringFormula = "{beneficiaries1.CampaignTitle} LIKE '*" & txtCRAdminSearchBene.Text.ToString() & "*' "
                StringFormula &= "OR {beneficiaries1.BeneficiaryName} LIKE '*" & txtCRAdminSearchBene.Text.ToString() & "*' "
            Else
                StringFormula = ""
            End If

        Else
            'StringFormula = "{v_campaign1.StartDate} >= #" & StartDate & "# "
            'StringFormula &= "AND {v_campaign1.EndDate} <= #" & EndDate & "# "

        End If

        CrystalReportViewerBene.SelectionFormula = StringFormula

        CrystalReportViewerBene.Refresh()
        CrystalReportViewerBene.RefreshReport()
    End Sub
End Class