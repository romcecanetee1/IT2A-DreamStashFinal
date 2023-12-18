Public Class AdminUsersPrint1
    Private Sub btnAdminUserLoadReport_Click(sender As Object, e As EventArgs) Handles btnAdminUserLoadReport.Click

        Dim StringFormula As String
        Dim DateReg As Date = Me.dtpUsersDateRegistered.Value ' Use the Value property of DateTimePicker
        Dim DateReg1 As Date = Me.dtpUsersDateRegisteredEnd.Value



        Dim cr As New CR_Users
        CrystalReportViewerUsers.ReportSource = cr

        If cbxUsersSearch.Checked = True Then

            If Not String.IsNullOrWhiteSpace(txtCRAdminUserReport.Text) Then
                StringFormula = "{users1.UserRole} LIKE '*" & txtCRAdminUserReport.Text.ToString() & "*' "
                StringFormula &= "OR {users1.FirstName} LIKE '*" & txtCRAdminUserReport.Text.ToString() & "*' "
                StringFormula &= "OR {users1.LastName} LIKE '*" & txtCRAdminUserReport.Text.ToString() & "*' "
                StringFormula &= "OR {users1.AccountStatus} LIKE '*" & txtCRAdminUserReport.Text.ToString() & "*' "
            Else
                StringFormula = ""
            End If

        Else
            StringFormula = "{users1.DataRegistered} >= #" & DateReg & "# "
            StringFormula = "{users1.DataRegistered} <= #" & DateReg1 & "# "


            'MsgBox(DateReg.ToString)
        End If

        CrystalReportViewerUsers.SelectionFormula = StringFormula

        ' CrystalReportViewerUsers.Refresh()
        CrystalReportViewerUsers.RefreshReport()

        ' cr.Close()
        'cr.Dispose()


    End Sub
End Class