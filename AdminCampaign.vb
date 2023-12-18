Public Class AdminCampaign
    Private Sub btnEditNewCampaign_Click(sender As Object, e As EventArgs) Handles btnAdminEditNewCampaign.Click
        Try
            Dim i, id As Integer
            i = dgvAdminNewCampaign.CurrentRow.Index
            id = dgvAdminNewCampaign.Item(0, i).Value
            PopulateCampaign(id)

            lblCampaignID.Text = id.ToString

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

    Private Sub btnAdminSaveNewCampaign_Click(sender As Object, e As EventArgs) Handles btnAdminSaveNewCampaign.Click

        Dim NewDonationGoal As String = txtAdminNewDonationGoal.Text
        'Dim asDecimal As Decimal = Decimal.Parse(NewDonationGoal)

        If Not String.IsNullOrWhiteSpace(NewDonationGoal) And Not String.IsNullOrWhiteSpace(txtAdminNewCampaignTitle.Text) Then
            Try
                Dim asDecimal As Decimal = Decimal.Parse(NewDonationGoal).ToString("##,###0.00")
                'MsgBox("Campaign created successfully!" & vbCrLf & "Donation Goal: Php " & asDecimal.ToString)
                AdminCreateCampaign()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                txtAdminNewDonationGoal.Focus()
            End Try
        Else
            MsgBox("Fill all the required fields!")
            txtAdminNewCampaignTitle.Focus()
            ' Show the Admin Campaign form and hide the current form

        End If

    End Sub

    Private Sub btnAdminSearchNewCampaign_Click(sender As Object, e As EventArgs) Handles btnAdminSearchNewCampaign.Click
        AdminSearchCampaigns()
    End Sub

    Private Sub dgvAdminNewCampaign_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdminNewCampaign.CellClick
        btnAdminEditNewCampaign.Enabled = True
    End Sub

    Private Sub AdminCampaign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchCampaigns()
    End Sub

    Private Sub dgvAdminNewCampaign_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdminNewCampaign.CellContentDoubleClick
        Try
            Dim i, id As Integer
            i = dgvAdminNewCampaign.CurrentRow.Index
            id = dgvAdminNewCampaign.Item(0, i).Value
            PopulateCampaign(id)

            lblCampaignID.Text = id.ToString

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try


    End Sub

End Class