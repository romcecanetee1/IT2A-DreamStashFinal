Public Class AdminHome
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAdminHome1()
        pnlAdminHome2()
        pnlAdminHome3()
    End Sub

    Private Sub btnAdminRefresh_Click(sender As Object, e As EventArgs) Handles btnAdminRefresh.Click
        RefreshLabels()
    End Sub
End Class