<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsersDonationHistoryPaint2
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
        Me.CrystalReportViewerDonation = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnAdminDonationReport = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCRAdminDonationReport = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxDonationSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDonationEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpDonationStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
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
        Me.Label1.Size = New System.Drawing.Size(211, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Donation History Report "
        '
        'CrystalReportViewerDonation
        '
        Me.CrystalReportViewerDonation.ActiveViewIndex = -1
        Me.CrystalReportViewerDonation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerDonation.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerDonation.Location = New System.Drawing.Point(13, 125)
        Me.CrystalReportViewerDonation.Name = "CrystalReportViewerDonation"
        Me.CrystalReportViewerDonation.Size = New System.Drawing.Size(852, 442)
        Me.CrystalReportViewerDonation.TabIndex = 68
        '
        'btnAdminDonationReport
        '
        Me.btnAdminDonationReport.AutoRoundedCorners = True
        Me.btnAdminDonationReport.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminDonationReport.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationReport.BorderRadius = 14
        Me.btnAdminDonationReport.BorderThickness = 1
        Me.btnAdminDonationReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonationReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonationReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminDonationReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminDonationReport.FillColor = System.Drawing.Color.White
        Me.btnAdminDonationReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminDonationReport.ForeColor = System.Drawing.Color.Black
        Me.btnAdminDonationReport.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationReport.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationReport.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationReport.Location = New System.Drawing.Point(672, 76)
        Me.btnAdminDonationReport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminDonationReport.Name = "btnAdminDonationReport"
        Me.btnAdminDonationReport.Size = New System.Drawing.Size(110, 31)
        Me.btnAdminDonationReport.TabIndex = 72
        Me.btnAdminDonationReport.Text = "Load Report"
        '
        'txtCRAdminDonationReport
        '
        Me.txtCRAdminDonationReport.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtCRAdminDonationReport.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCRAdminDonationReport.DefaultText = ""
        Me.txtCRAdminDonationReport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCRAdminDonationReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCRAdminDonationReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminDonationReport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminDonationReport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminDonationReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCRAdminDonationReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminDonationReport.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtCRAdminDonationReport.Location = New System.Drawing.Point(426, 76)
        Me.txtCRAdminDonationReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCRAdminDonationReport.Name = "txtCRAdminDonationReport"
        Me.txtCRAdminDonationReport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCRAdminDonationReport.PlaceholderText = "Search"
        Me.txtCRAdminDonationReport.SelectedText = ""
        Me.txtCRAdminDonationReport.Size = New System.Drawing.Size(220, 24)
        Me.txtCRAdminDonationReport.TabIndex = 71
        '
        'cbxDonationSearch
        '
        Me.cbxDonationSearch.AutoSize = True
        Me.cbxDonationSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxDonationSearch.CheckedState.BorderRadius = 0
        Me.cbxDonationSearch.CheckedState.BorderThickness = 0
        Me.cbxDonationSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxDonationSearch.Location = New System.Drawing.Point(434, 51)
        Me.cbxDonationSearch.Name = "cbxDonationSearch"
        Me.cbxDonationSearch.Size = New System.Drawing.Size(128, 17)
        Me.cbxDonationSearch.TabIndex = 80
        Me.cbxDonationSearch.Text = "Use Advance Search"
        Me.cbxDonationSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxDonationSearch.UncheckedState.BorderRadius = 0
        Me.cbxDonationSearch.UncheckedState.BorderThickness = 0
        Me.cbxDonationSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "End Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Start Date"
        '
        'dtpDonationEndDate
        '
        Me.dtpDonationEndDate.Checked = True
        Me.dtpDonationEndDate.FillColor = System.Drawing.Color.Purple
        Me.dtpDonationEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDonationEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpDonationEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDonationEndDate.Location = New System.Drawing.Point(88, 86)
        Me.dtpDonationEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDonationEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDonationEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDonationEndDate.Name = "dtpDonationEndDate"
        Me.dtpDonationEndDate.Size = New System.Drawing.Size(220, 25)
        Me.dtpDonationEndDate.TabIndex = 77
        Me.dtpDonationEndDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'dtpDonationStartDate
        '
        Me.dtpDonationStartDate.Checked = True
        Me.dtpDonationStartDate.FillColor = System.Drawing.Color.Purple
        Me.dtpDonationStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDonationStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpDonationStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDonationStartDate.Location = New System.Drawing.Point(88, 57)
        Me.dtpDonationStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDonationStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDonationStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDonationStartDate.Name = "dtpDonationStartDate"
        Me.dtpDonationStartDate.Size = New System.Drawing.Size(220, 25)
        Me.dtpDonationStartDate.TabIndex = 76
        Me.dtpDonationStartDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'AdminUsersDonationHistoryPaint2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 624)
        Me.Controls.Add(Me.cbxDonationSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDonationEndDate)
        Me.Controls.Add(Me.dtpDonationStartDate)
        Me.Controls.Add(Me.btnAdminDonationReport)
        Me.Controls.Add(Me.txtCRAdminDonationReport)
        Me.Controls.Add(Me.CrystalReportViewerDonation)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminUsersDonationHistoryPaint2"
        Me.Text = "AdminUsersDonationHistoryPaint2"
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
    Friend WithEvents CrystalReportViewerDonation As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnAdminDonationReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCRAdminDonationReport As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxDonationSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDonationEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpDonationStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
