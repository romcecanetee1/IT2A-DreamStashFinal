Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient
Imports System
Imports System.ComponentModel
Public Class DonorPrintShow
    Private Sub btnDonorPrint_Click(sender As Object, e As EventArgs) Handles btnDonorPrint.Click
        'showing the reports
        Me.Show()
        'getting the crystal report and placing it on the crystal report 
        'viewer using the report documents that represent as a studentInfo.rpt
        ' Me.CrystalReportViewer1.ReportSource = Me.DonorDonationHistoryReport1
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        'showing the reports
        Me.Show()
        'getting the crystal report and placing it on the crystal report 
        'viewer using the report documents that represent as a studentInfo.rpt
        'Me.CrystalReportViewer1.ReportSource = Me.DonorDonationHistory1
    End Sub

    Private Sub DonorDonationHistory2_InitReport(sender As Object, e As EventArgs)
        'showing the reports
        Me.Show()
        'getting the crystal report and placing it on the crystal report 
        'viewer using the report documents that represent as a studentInfo.rpt
        'Me.CrystalReportViewer1.ReportSource = Me.DonorDonationHistory1
    End Sub

    Private Sub DonorPrintShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class