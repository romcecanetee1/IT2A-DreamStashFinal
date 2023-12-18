Public Class DonorHistory
    Private Sub btnDonorPrint_Click(sender As Object, e As EventArgs) 
        DonorPrintShow.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminSearchHistory_Click(sender As Object, e As EventArgs) Handles btnAdminSearchHistory.Click
        AdminSearchHisto2()
    End Sub
End Class