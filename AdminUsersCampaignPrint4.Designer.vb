<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsersCampaignPrint4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewerCampaign = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtCRAdminSearchCampaign = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdminCampLoadReport = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxCampaignSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.dtpCampaignStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpCampaignEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlHome.Controls.Add(Me.ControlBoxMin)
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlHome.Controls.Add(Me.ControlBoxClose)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(876, 34)
        Me.pnlHome.TabIndex = 67
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(794, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(38, 25)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(1320, 3)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(38, 25)
        Me.ControlBoxMin.TabIndex = 4
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(838, 0)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(38, 25)
        Me.Guna2ControlBox2.TabIndex = 17
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1364, 3)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(38, 25)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Report"
        '
        'CrystalReportViewerCampaign
        '
        Me.CrystalReportViewerCampaign.ActiveViewIndex = -1
        Me.CrystalReportViewerCampaign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerCampaign.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerCampaign.Location = New System.Drawing.Point(13, 145)
        Me.CrystalReportViewerCampaign.Name = "CrystalReportViewerCampaign"
        Me.CrystalReportViewerCampaign.Size = New System.Drawing.Size(852, 447)
        Me.CrystalReportViewerCampaign.TabIndex = 68
        '
        'txtCRAdminSearchCampaign
        '
        Me.txtCRAdminSearchCampaign.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtCRAdminSearchCampaign.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCRAdminSearchCampaign.DefaultText = ""
        Me.txtCRAdminSearchCampaign.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCRAdminSearchCampaign.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCRAdminSearchCampaign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminSearchCampaign.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminSearchCampaign.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminSearchCampaign.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCRAdminSearchCampaign.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminSearchCampaign.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtCRAdminSearchCampaign.Location = New System.Drawing.Point(418, 93)
        Me.txtCRAdminSearchCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCRAdminSearchCampaign.Name = "txtCRAdminSearchCampaign"
        Me.txtCRAdminSearchCampaign.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCRAdminSearchCampaign.PlaceholderText = "Search"
        Me.txtCRAdminSearchCampaign.SelectedText = ""
        Me.txtCRAdminSearchCampaign.Size = New System.Drawing.Size(220, 24)
        Me.txtCRAdminSearchCampaign.TabIndex = 69
        '
        'btnAdminCampLoadReport
        '
        Me.btnAdminCampLoadReport.AutoRoundedCorners = True
        Me.btnAdminCampLoadReport.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminCampLoadReport.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampLoadReport.BorderRadius = 14
        Me.btnAdminCampLoadReport.BorderThickness = 1
        Me.btnAdminCampLoadReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCampLoadReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCampLoadReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminCampLoadReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminCampLoadReport.FillColor = System.Drawing.Color.White
        Me.btnAdminCampLoadReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminCampLoadReport.ForeColor = System.Drawing.Color.Black
        Me.btnAdminCampLoadReport.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampLoadReport.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampLoadReport.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampLoadReport.Location = New System.Drawing.Point(657, 93)
        Me.btnAdminCampLoadReport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminCampLoadReport.Name = "btnAdminCampLoadReport"
        Me.btnAdminCampLoadReport.Size = New System.Drawing.Size(110, 31)
        Me.btnAdminCampLoadReport.TabIndex = 70
        Me.btnAdminCampLoadReport.Text = "Load Report"
        '
        'cbxCampaignSearch
        '
        Me.cbxCampaignSearch.AutoSize = True
        Me.cbxCampaignSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCampaignSearch.CheckedState.BorderRadius = 0
        Me.cbxCampaignSearch.CheckedState.BorderThickness = 0
        Me.cbxCampaignSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCampaignSearch.Location = New System.Drawing.Point(418, 69)
        Me.cbxCampaignSearch.Name = "cbxCampaignSearch"
        Me.cbxCampaignSearch.Size = New System.Drawing.Size(128, 17)
        Me.cbxCampaignSearch.TabIndex = 75
        Me.cbxCampaignSearch.Text = "Use Advance Search"
        Me.cbxCampaignSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxCampaignSearch.UncheckedState.BorderRadius = 0
        Me.cbxCampaignSearch.UncheckedState.BorderThickness = 0
        Me.cbxCampaignSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'dtpCampaignStartDate
        '
        Me.dtpCampaignStartDate.Checked = True
        Me.dtpCampaignStartDate.FillColor = System.Drawing.Color.Purple
        Me.dtpCampaignStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpCampaignStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpCampaignStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCampaignStartDate.Location = New System.Drawing.Point(72, 75)
        Me.dtpCampaignStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCampaignStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCampaignStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCampaignStartDate.Name = "dtpCampaignStartDate"
        Me.dtpCampaignStartDate.Size = New System.Drawing.Size(220, 25)
        Me.dtpCampaignStartDate.TabIndex = 71
        Me.dtpCampaignStartDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'dtpCampaignEndDate
        '
        Me.dtpCampaignEndDate.Checked = True
        Me.dtpCampaignEndDate.FillColor = System.Drawing.Color.Purple
        Me.dtpCampaignEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpCampaignEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpCampaignEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCampaignEndDate.Location = New System.Drawing.Point(72, 104)
        Me.dtpCampaignEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCampaignEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCampaignEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCampaignEndDate.Name = "dtpCampaignEndDate"
        Me.dtpCampaignEndDate.Size = New System.Drawing.Size(220, 25)
        Me.dtpCampaignEndDate.TabIndex = 72
        Me.dtpCampaignEndDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "End Date"
        '
        'AdminUsersCampaignPrint4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 624)
        Me.Controls.Add(Me.cbxCampaignSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpCampaignEndDate)
        Me.Controls.Add(Me.dtpCampaignStartDate)
        Me.Controls.Add(Me.btnAdminCampLoadReport)
        Me.Controls.Add(Me.txtCRAdminSearchCampaign)
        Me.Controls.Add(Me.CrystalReportViewerCampaign)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminUsersCampaignPrint4"
        Me.Text = "AdminUsersCampaignPrint4"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CrystalReportViewerCampaign As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtCRAdminSearchCampaign As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdminCampLoadReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbxCampaignSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCampaignEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpCampaignStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
