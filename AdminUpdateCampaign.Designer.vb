<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUpdateCampaign
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbxAdminUpdateCampaignStatus = New System.Windows.Forms.ComboBox()
        Me.lblCampaignID = New System.Windows.Forms.Label()
        Me.dtpEditAdminEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpEditAdminStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtEditCampaignDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEditCampaignBeneName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminUpdateCampaignDonationGoal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAdminUpdateCampaignDonationGoal = New System.Windows.Forms.Label()
        Me.lblAdminUpdateCampaignEndDate = New System.Windows.Forms.Label()
        Me.lblAdminUpdateCampaignStartDate = New System.Windows.Forms.Label()
        Me.lblAdminUpdateCampaignStatus = New System.Windows.Forms.Label()
        Me.txtpnlAdminUpdateCampaignTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAdminUpdateCampaignTitle = New System.Windows.Forms.Label()
        Me.btnAdminUpdateSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminUpdateCampaignCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.cbxAdminUpdateCampaignStatus)
        Me.Guna2Panel1.Controls.Add(Me.lblCampaignID)
        Me.Guna2Panel1.Controls.Add(Me.dtpEditAdminEndDate)
        Me.Guna2Panel1.Controls.Add(Me.dtpEditAdminStartDate)
        Me.Guna2Panel1.Controls.Add(Me.txtEditCampaignDesc)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.txtEditCampaignBeneName)
        Me.Guna2Panel1.Controls.Add(Me.txtAdminUpdateCampaignDonationGoal)
        Me.Guna2Panel1.Controls.Add(Me.lblAdminUpdateCampaignDonationGoal)
        Me.Guna2Panel1.Controls.Add(Me.lblAdminUpdateCampaignEndDate)
        Me.Guna2Panel1.Controls.Add(Me.lblAdminUpdateCampaignStartDate)
        Me.Guna2Panel1.Controls.Add(Me.lblAdminUpdateCampaignStatus)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAdminUpdateCampaignTitle)
        Me.Guna2Panel1.Controls.Add(Me.lblAdminUpdateCampaignTitle)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminUpdateSave)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminUpdateCampaignCancel)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(155, 33)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(755, 537)
        Me.Guna2Panel1.TabIndex = 2
        '
        'cbxAdminUpdateCampaignStatus
        '
        Me.cbxAdminUpdateCampaignStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAdminUpdateCampaignStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAdminUpdateCampaignStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxAdminUpdateCampaignStatus.FormattingEnabled = True
        Me.cbxAdminUpdateCampaignStatus.Items.AddRange(New Object() {"Active", "Archived"})
        Me.cbxAdminUpdateCampaignStatus.Location = New System.Drawing.Point(203, 130)
        Me.cbxAdminUpdateCampaignStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxAdminUpdateCampaignStatus.Name = "cbxAdminUpdateCampaignStatus"
        Me.cbxAdminUpdateCampaignStatus.Size = New System.Drawing.Size(200, 25)
        Me.cbxAdminUpdateCampaignStatus.TabIndex = 36
        '
        'lblCampaignID
        '
        Me.lblCampaignID.AutoSize = True
        Me.lblCampaignID.BackColor = System.Drawing.SystemColors.Control
        Me.lblCampaignID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.lblCampaignID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCampaignID.Location = New System.Drawing.Point(672, 507)
        Me.lblCampaignID.Name = "lblCampaignID"
        Me.lblCampaignID.Size = New System.Drawing.Size(63, 17)
        Me.lblCampaignID.TabIndex = 35
        Me.lblCampaignID.Text = "User ID"
        '
        'dtpEditAdminEndDate
        '
        Me.dtpEditAdminEndDate.Checked = True
        Me.dtpEditAdminEndDate.FillColor = System.Drawing.Color.Purple
        Me.dtpEditAdminEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpEditAdminEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpEditAdminEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEditAdminEndDate.Location = New System.Drawing.Point(203, 210)
        Me.dtpEditAdminEndDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEditAdminEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEditAdminEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEditAdminEndDate.Name = "dtpEditAdminEndDate"
        Me.dtpEditAdminEndDate.Size = New System.Drawing.Size(292, 42)
        Me.dtpEditAdminEndDate.TabIndex = 34
        Me.dtpEditAdminEndDate.Value = New Date(2023, 11, 28, 14, 23, 50, 15)
        '
        'dtpEditAdminStartDate
        '
        Me.dtpEditAdminStartDate.Checked = True
        Me.dtpEditAdminStartDate.FillColor = System.Drawing.Color.Purple
        Me.dtpEditAdminStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpEditAdminStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpEditAdminStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEditAdminStartDate.Location = New System.Drawing.Point(203, 164)
        Me.dtpEditAdminStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEditAdminStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEditAdminStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEditAdminStartDate.Name = "dtpEditAdminStartDate"
        Me.dtpEditAdminStartDate.Size = New System.Drawing.Size(292, 42)
        Me.dtpEditAdminStartDate.TabIndex = 33
        Me.dtpEditAdminStartDate.Value = New Date(2023, 11, 28, 14, 23, 50, 15)
        '
        'txtEditCampaignDesc
        '
        Me.txtEditCampaignDesc.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtEditCampaignDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditCampaignDesc.DefaultText = ""
        Me.txtEditCampaignDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEditCampaignDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEditCampaignDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditCampaignDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditCampaignDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEditCampaignDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEditCampaignDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEditCampaignDesc.Location = New System.Drawing.Point(203, 332)
        Me.txtEditCampaignDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEditCampaignDesc.Multiline = True
        Me.txtEditCampaignDesc.Name = "txtEditCampaignDesc"
        Me.txtEditCampaignDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEditCampaignDesc.PlaceholderText = ""
        Me.txtEditCampaignDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEditCampaignDesc.SelectedText = ""
        Me.txtEditCampaignDesc.Size = New System.Drawing.Size(461, 150)
        Me.txtEditCampaignDesc.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(35, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Description"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(35, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Beneficiary Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEditCampaignBeneName
        '
        Me.txtEditCampaignBeneName.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtEditCampaignBeneName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditCampaignBeneName.DefaultText = ""
        Me.txtEditCampaignBeneName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEditCampaignBeneName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEditCampaignBeneName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditCampaignBeneName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditCampaignBeneName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEditCampaignBeneName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEditCampaignBeneName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEditCampaignBeneName.Location = New System.Drawing.Point(203, 295)
        Me.txtEditCampaignBeneName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEditCampaignBeneName.Name = "txtEditCampaignBeneName"
        Me.txtEditCampaignBeneName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEditCampaignBeneName.PlaceholderText = ""
        Me.txtEditCampaignBeneName.SelectedText = ""
        Me.txtEditCampaignBeneName.Size = New System.Drawing.Size(461, 30)
        Me.txtEditCampaignBeneName.TabIndex = 28
        '
        'txtAdminUpdateCampaignDonationGoal
        '
        Me.txtAdminUpdateCampaignDonationGoal.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminUpdateCampaignDonationGoal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminUpdateCampaignDonationGoal.DefaultText = ""
        Me.txtAdminUpdateCampaignDonationGoal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminUpdateCampaignDonationGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminUpdateCampaignDonationGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminUpdateCampaignDonationGoal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminUpdateCampaignDonationGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminUpdateCampaignDonationGoal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminUpdateCampaignDonationGoal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminUpdateCampaignDonationGoal.Location = New System.Drawing.Point(203, 258)
        Me.txtAdminUpdateCampaignDonationGoal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminUpdateCampaignDonationGoal.Name = "txtAdminUpdateCampaignDonationGoal"
        Me.txtAdminUpdateCampaignDonationGoal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminUpdateCampaignDonationGoal.PlaceholderText = ""
        Me.txtAdminUpdateCampaignDonationGoal.SelectedText = ""
        Me.txtAdminUpdateCampaignDonationGoal.Size = New System.Drawing.Size(201, 30)
        Me.txtAdminUpdateCampaignDonationGoal.TabIndex = 26
        '
        'lblAdminUpdateCampaignDonationGoal
        '
        Me.lblAdminUpdateCampaignDonationGoal.AutoSize = True
        Me.lblAdminUpdateCampaignDonationGoal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAdminUpdateCampaignDonationGoal.Location = New System.Drawing.Point(35, 258)
        Me.lblAdminUpdateCampaignDonationGoal.Name = "lblAdminUpdateCampaignDonationGoal"
        Me.lblAdminUpdateCampaignDonationGoal.Size = New System.Drawing.Size(125, 20)
        Me.lblAdminUpdateCampaignDonationGoal.TabIndex = 25
        Me.lblAdminUpdateCampaignDonationGoal.Text = "Donation Goal"
        Me.lblAdminUpdateCampaignDonationGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdminUpdateCampaignEndDate
        '
        Me.lblAdminUpdateCampaignEndDate.AutoSize = True
        Me.lblAdminUpdateCampaignEndDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAdminUpdateCampaignEndDate.Location = New System.Drawing.Point(35, 210)
        Me.lblAdminUpdateCampaignEndDate.Name = "lblAdminUpdateCampaignEndDate"
        Me.lblAdminUpdateCampaignEndDate.Size = New System.Drawing.Size(84, 20)
        Me.lblAdminUpdateCampaignEndDate.TabIndex = 21
        Me.lblAdminUpdateCampaignEndDate.Text = "End Date"
        Me.lblAdminUpdateCampaignEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdminUpdateCampaignStartDate
        '
        Me.lblAdminUpdateCampaignStartDate.AutoSize = True
        Me.lblAdminUpdateCampaignStartDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAdminUpdateCampaignStartDate.Location = New System.Drawing.Point(35, 164)
        Me.lblAdminUpdateCampaignStartDate.Name = "lblAdminUpdateCampaignStartDate"
        Me.lblAdminUpdateCampaignStartDate.Size = New System.Drawing.Size(92, 20)
        Me.lblAdminUpdateCampaignStartDate.TabIndex = 22
        Me.lblAdminUpdateCampaignStartDate.Text = "Start Date"
        Me.lblAdminUpdateCampaignStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdminUpdateCampaignStatus
        '
        Me.lblAdminUpdateCampaignStatus.AutoSize = True
        Me.lblAdminUpdateCampaignStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAdminUpdateCampaignStatus.Location = New System.Drawing.Point(35, 130)
        Me.lblAdminUpdateCampaignStatus.Name = "lblAdminUpdateCampaignStatus"
        Me.lblAdminUpdateCampaignStatus.Size = New System.Drawing.Size(150, 20)
        Me.lblAdminUpdateCampaignStatus.TabIndex = 15
        Me.lblAdminUpdateCampaignStatus.Text = "Campaign Status"
        Me.lblAdminUpdateCampaignStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpnlAdminUpdateCampaignTitle
        '
        Me.txtpnlAdminUpdateCampaignTitle.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAdminUpdateCampaignTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAdminUpdateCampaignTitle.DefaultText = ""
        Me.txtpnlAdminUpdateCampaignTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAdminUpdateCampaignTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAdminUpdateCampaignTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminUpdateCampaignTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminUpdateCampaignTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminUpdateCampaignTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAdminUpdateCampaignTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminUpdateCampaignTitle.Location = New System.Drawing.Point(203, 97)
        Me.txtpnlAdminUpdateCampaignTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpnlAdminUpdateCampaignTitle.Name = "txtpnlAdminUpdateCampaignTitle"
        Me.txtpnlAdminUpdateCampaignTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAdminUpdateCampaignTitle.PlaceholderText = ""
        Me.txtpnlAdminUpdateCampaignTitle.SelectedText = ""
        Me.txtpnlAdminUpdateCampaignTitle.Size = New System.Drawing.Size(461, 30)
        Me.txtpnlAdminUpdateCampaignTitle.TabIndex = 17
        '
        'lblAdminUpdateCampaignTitle
        '
        Me.lblAdminUpdateCampaignTitle.AutoSize = True
        Me.lblAdminUpdateCampaignTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAdminUpdateCampaignTitle.Location = New System.Drawing.Point(35, 97)
        Me.lblAdminUpdateCampaignTitle.Name = "lblAdminUpdateCampaignTitle"
        Me.lblAdminUpdateCampaignTitle.Size = New System.Drawing.Size(135, 20)
        Me.lblAdminUpdateCampaignTitle.TabIndex = 19
        Me.lblAdminUpdateCampaignTitle.Text = "Campaign Title"
        Me.lblAdminUpdateCampaignTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdminUpdateSave
        '
        Me.btnAdminUpdateSave.AutoRoundedCorners = True
        Me.btnAdminUpdateSave.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUpdateSave.BorderRadius = 16
        Me.btnAdminUpdateSave.BorderThickness = 1
        Me.btnAdminUpdateSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUpdateSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUpdateSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminUpdateSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminUpdateSave.FillColor = System.Drawing.Color.White
        Me.btnAdminUpdateSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminUpdateSave.ForeColor = System.Drawing.Color.Black
        Me.btnAdminUpdateSave.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUpdateSave.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUpdateSave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminUpdateSave.Location = New System.Drawing.Point(259, 490)
        Me.btnAdminUpdateSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminUpdateSave.Name = "btnAdminUpdateSave"
        Me.btnAdminUpdateSave.Size = New System.Drawing.Size(96, 34)
        Me.btnAdminUpdateSave.TabIndex = 14
        Me.btnAdminUpdateSave.Text = "Save"
        '
        'btnAdminUpdateCampaignCancel
        '
        Me.btnAdminUpdateCampaignCancel.AutoRoundedCorners = True
        Me.btnAdminUpdateCampaignCancel.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUpdateCampaignCancel.BorderRadius = 16
        Me.btnAdminUpdateCampaignCancel.BorderThickness = 1
        Me.btnAdminUpdateCampaignCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUpdateCampaignCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUpdateCampaignCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminUpdateCampaignCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminUpdateCampaignCancel.FillColor = System.Drawing.Color.White
        Me.btnAdminUpdateCampaignCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminUpdateCampaignCancel.ForeColor = System.Drawing.Color.Black
        Me.btnAdminUpdateCampaignCancel.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUpdateCampaignCancel.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUpdateCampaignCancel.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminUpdateCampaignCancel.Location = New System.Drawing.Point(427, 490)
        Me.btnAdminUpdateCampaignCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminUpdateCampaignCancel.Name = "btnAdminUpdateCampaignCancel"
        Me.btnAdminUpdateCampaignCancel.Size = New System.Drawing.Size(96, 34)
        Me.btnAdminUpdateCampaignCancel.TabIndex = 14
        Me.btnAdminUpdateCampaignCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(163, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Campaign"
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1016, 0)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxClose.TabIndex = 6
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(957, 0)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxMin.TabIndex = 7
        '
        'AdminUpdateCampaign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1065, 603)
        Me.Controls.Add(Me.ControlBoxMin)
        Me.Controls.Add(Me.ControlBoxClose)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AdminUpdateCampaign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminUpdateCampaign"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAdminUpdateSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminUpdateCampaignCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAdminUpdateCampaignStatus As Label
    Friend WithEvents txtpnlAdminUpdateCampaignTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAdminUpdateCampaignTitle As Label
    Friend WithEvents lblAdminUpdateCampaignEndDate As Label
    Friend WithEvents lblAdminUpdateCampaignStartDate As Label
    Friend WithEvents txtAdminUpdateCampaignDonationGoal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAdminUpdateCampaignDonationGoal As Label
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtEditCampaignDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEditCampaignBeneName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpEditAdminEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpEditAdminStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblCampaignID As Label
    Friend WithEvents cbxAdminUpdateCampaignStatus As ComboBox
End Class
