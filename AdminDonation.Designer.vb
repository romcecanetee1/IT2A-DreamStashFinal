<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDonation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlDonationEntries = New Guna.UI2.WinForms.Guna2Panel()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDonationSearchCampaign = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.dtpDonationDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdminSaveDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminCancelDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDonorInformation = New System.Windows.Forms.Label()
        Me.txtpnlAdminDonorInformation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpnlAdminDonationAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpnlAdminDonationCampaignID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDonationAmount = New System.Windows.Forms.Label()
        Me.lblpnlCampaignID = New System.Windows.Forms.Label()
        Me.dgvAdminDonation = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAdminSearchDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAdminDonationSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlDonationEntries.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvAdminDonation, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'pnlDonationEntries
        '
        Me.pnlDonationEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlDonationEntries.Controls.Add(Me.ControlBoxMin)
        Me.pnlDonationEntries.Controls.Add(Me.ControlBoxClose)
        Me.pnlDonationEntries.Controls.Add(Me.Label1)
        Me.pnlDonationEntries.Location = New System.Drawing.Point(0, 0)
        Me.pnlDonationEntries.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlDonationEntries.Name = "pnlDonationEntries"
        Me.pnlDonationEntries.Size = New System.Drawing.Size(815, 40)
        Me.pnlDonationEntries.TabIndex = 1
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(733, 3)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(38, 25)
        Me.ControlBoxMin.TabIndex = 4
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(776, 3)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donation Entries"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DONATION ENTRY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDonationSearchCampaign
        '
        Me.lblDonationSearchCampaign.AutoSize = True
        Me.lblDonationSearchCampaign.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationSearchCampaign.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblDonationSearchCampaign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDonationSearchCampaign.Location = New System.Drawing.Point(7, 237)
        Me.lblDonationSearchCampaign.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDonationSearchCampaign.Name = "lblDonationSearchCampaign"
        Me.lblDonationSearchCampaign.Size = New System.Drawing.Size(123, 15)
        Me.lblDonationSearchCampaign.TabIndex = 3
        Me.lblDonationSearchCampaign.Text = "Search Campaign"
        Me.lblDonationSearchCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.lblTitle)
        Me.Guna2Panel1.Controls.Add(Me.lblUserName)
        Me.Guna2Panel1.Controls.Add(Me.lblID)
        Me.Guna2Panel1.Controls.Add(Me.dtpDonationDate)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminSaveDonation)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminCancelDonation)
        Me.Guna2Panel1.Controls.Add(Me.lblDonorInformation)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAdminDonorInformation)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAdminDonationAmount)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAdminDonationCampaignID)
        Me.Guna2Panel1.Controls.Add(Me.lblDonationAmount)
        Me.Guna2Panel1.Controls.Add(Me.lblpnlCampaignID)
        Me.Guna2Panel1.Location = New System.Drawing.Point(10, 78)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(794, 141)
        Me.Guna2Panel1.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(10, 122)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(36, 15)
        Me.lblTitle.TabIndex = 36
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblUserName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUserName.Location = New System.Drawing.Point(603, 122)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(91, 15)
        Me.lblUserName.TabIndex = 35
        Me.lblUserName.Text = "                            "
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(720, 122)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(64, 15)
        Me.lblID.TabIndex = 34
        Me.lblID.Text = "                   "
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDonationDate
        '
        Me.dtpDonationDate.Checked = True
        Me.dtpDonationDate.FillColor = System.Drawing.Color.Purple
        Me.dtpDonationDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDonationDate.ForeColor = System.Drawing.Color.White
        Me.dtpDonationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDonationDate.Location = New System.Drawing.Point(564, 71)
        Me.dtpDonationDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDonationDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDonationDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDonationDate.Name = "dtpDonationDate"
        Me.dtpDonationDate.Size = New System.Drawing.Size(216, 25)
        Me.dtpDonationDate.TabIndex = 33
        Me.dtpDonationDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(426, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Donation Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdminSaveDonation
        '
        Me.btnAdminSaveDonation.AutoRoundedCorners = True
        Me.btnAdminSaveDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveDonation.BorderRadius = 13
        Me.btnAdminSaveDonation.BorderThickness = 1
        Me.btnAdminSaveDonation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSaveDonation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSaveDonation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSaveDonation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSaveDonation.FillColor = System.Drawing.Color.White
        Me.btnAdminSaveDonation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSaveDonation.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSaveDonation.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveDonation.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveDonation.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSaveDonation.Location = New System.Drawing.Point(324, 109)
        Me.btnAdminSaveDonation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminSaveDonation.Name = "btnAdminSaveDonation"
        Me.btnAdminSaveDonation.Size = New System.Drawing.Size(72, 28)
        Me.btnAdminSaveDonation.TabIndex = 13
        Me.btnAdminSaveDonation.Text = "Save"
        '
        'btnAdminCancelDonation
        '
        Me.btnAdminCancelDonation.AutoRoundedCorners = True
        Me.btnAdminCancelDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCancelDonation.BorderRadius = 13
        Me.btnAdminCancelDonation.BorderThickness = 1
        Me.btnAdminCancelDonation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCancelDonation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCancelDonation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminCancelDonation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminCancelDonation.FillColor = System.Drawing.Color.White
        Me.btnAdminCancelDonation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminCancelDonation.ForeColor = System.Drawing.Color.Black
        Me.btnAdminCancelDonation.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCancelDonation.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCancelDonation.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminCancelDonation.Location = New System.Drawing.Point(400, 109)
        Me.btnAdminCancelDonation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminCancelDonation.Name = "btnAdminCancelDonation"
        Me.btnAdminCancelDonation.Size = New System.Drawing.Size(72, 28)
        Me.btnAdminCancelDonation.TabIndex = 13
        Me.btnAdminCancelDonation.Text = "Clear"
        '
        'lblDonorInformation
        '
        Me.lblDonorInformation.AutoSize = True
        Me.lblDonorInformation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonorInformation.Location = New System.Drawing.Point(426, 40)
        Me.lblDonorInformation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDonorInformation.Name = "lblDonorInformation"
        Me.lblDonorInformation.Size = New System.Drawing.Size(117, 15)
        Me.lblDonorInformation.TabIndex = 4
        Me.lblDonorInformation.Text = "Donor Username"
        Me.lblDonorInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpnlAdminDonorInformation
        '
        Me.txtpnlAdminDonorInformation.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAdminDonorInformation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAdminDonorInformation.DefaultText = ""
        Me.txtpnlAdminDonorInformation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAdminDonorInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAdminDonorInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminDonorInformation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminDonorInformation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminDonorInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAdminDonorInformation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminDonorInformation.Location = New System.Drawing.Point(564, 41)
        Me.txtpnlAdminDonorInformation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtpnlAdminDonorInformation.Name = "txtpnlAdminDonorInformation"
        Me.txtpnlAdminDonorInformation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAdminDonorInformation.PlaceholderText = ""
        Me.txtpnlAdminDonorInformation.SelectedText = ""
        Me.txtpnlAdminDonorInformation.Size = New System.Drawing.Size(216, 25)
        Me.txtpnlAdminDonorInformation.TabIndex = 4
        '
        'txtpnlAdminDonationAmount
        '
        Me.txtpnlAdminDonationAmount.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAdminDonationAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAdminDonationAmount.DefaultText = ""
        Me.txtpnlAdminDonationAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAdminDonationAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAdminDonationAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminDonationAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminDonationAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminDonationAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAdminDonationAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminDonationAmount.Location = New System.Drawing.Point(136, 71)
        Me.txtpnlAdminDonationAmount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtpnlAdminDonationAmount.Name = "txtpnlAdminDonationAmount"
        Me.txtpnlAdminDonationAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAdminDonationAmount.PlaceholderText = ""
        Me.txtpnlAdminDonationAmount.SelectedText = ""
        Me.txtpnlAdminDonationAmount.Size = New System.Drawing.Size(216, 25)
        Me.txtpnlAdminDonationAmount.TabIndex = 4
        '
        'txtpnlAdminDonationCampaignID
        '
        Me.txtpnlAdminDonationCampaignID.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAdminDonationCampaignID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAdminDonationCampaignID.DefaultText = ""
        Me.txtpnlAdminDonationCampaignID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAdminDonationCampaignID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAdminDonationCampaignID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminDonationCampaignID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminDonationCampaignID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminDonationCampaignID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAdminDonationCampaignID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminDonationCampaignID.Location = New System.Drawing.Point(136, 40)
        Me.txtpnlAdminDonationCampaignID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtpnlAdminDonationCampaignID.Name = "txtpnlAdminDonationCampaignID"
        Me.txtpnlAdminDonationCampaignID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAdminDonationCampaignID.PlaceholderText = ""
        Me.txtpnlAdminDonationCampaignID.SelectedText = ""
        Me.txtpnlAdminDonationCampaignID.Size = New System.Drawing.Size(216, 25)
        Me.txtpnlAdminDonationCampaignID.TabIndex = 4
        '
        'lblDonationAmount
        '
        Me.lblDonationAmount.AutoSize = True
        Me.lblDonationAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationAmount.Location = New System.Drawing.Point(13, 71)
        Me.lblDonationAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDonationAmount.Name = "lblDonationAmount"
        Me.lblDonationAmount.Size = New System.Drawing.Size(119, 15)
        Me.lblDonationAmount.TabIndex = 4
        Me.lblDonationAmount.Text = "Donation Amount"
        Me.lblDonationAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpnlCampaignID
        '
        Me.lblpnlCampaignID.AutoSize = True
        Me.lblpnlCampaignID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblpnlCampaignID.Location = New System.Drawing.Point(13, 41)
        Me.lblpnlCampaignID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpnlCampaignID.Name = "lblpnlCampaignID"
        Me.lblpnlCampaignID.Size = New System.Drawing.Size(90, 15)
        Me.lblpnlCampaignID.TabIndex = 4
        Me.lblpnlCampaignID.Text = "Campaign ID"
        Me.lblpnlCampaignID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvAdminDonation
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAdminDonation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdminDonation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAdminDonation.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAdminDonation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdminDonation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAdminDonation.ColumnHeadersHeight = 17
        Me.dgvAdminDonation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdminDonation.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdminDonation.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminDonation.Location = New System.Drawing.Point(5, 291)
        Me.dgvAdminDonation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvAdminDonation.MultiSelect = False
        Me.dgvAdminDonation.Name = "dgvAdminDonation"
        Me.dgvAdminDonation.ReadOnly = True
        Me.dgvAdminDonation.RowHeadersVisible = False
        Me.dgvAdminDonation.RowHeadersWidth = 51
        Me.dgvAdminDonation.RowTemplate.Height = 25
        Me.dgvAdminDonation.Size = New System.Drawing.Size(799, 226)
        Me.dgvAdminDonation.TabIndex = 14
        Me.dgvAdminDonation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminDonation.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAdminDonation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAdminDonation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAdminDonation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAdminDonation.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvAdminDonation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminDonation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminDonation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAdminDonation.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminDonation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAdminDonation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAdminDonation.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvAdminDonation.ThemeStyle.ReadOnly = True
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.Height = 25
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminDonation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAdminSearchDonation
        '
        Me.btnAdminSearchDonation.AutoRoundedCorners = True
        Me.btnAdminSearchDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchDonation.BorderRadius = 11
        Me.btnAdminSearchDonation.BorderThickness = 1
        Me.btnAdminSearchDonation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchDonation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchDonation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSearchDonation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSearchDonation.FillColor = System.Drawing.Color.White
        Me.btnAdminSearchDonation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSearchDonation.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSearchDonation.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchDonation.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchDonation.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSearchDonation.Location = New System.Drawing.Point(212, 254)
        Me.btnAdminSearchDonation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminSearchDonation.Name = "btnAdminSearchDonation"
        Me.btnAdminSearchDonation.Size = New System.Drawing.Size(90, 24)
        Me.btnAdminSearchDonation.TabIndex = 17
        Me.btnAdminSearchDonation.Text = "Search"
        '
        'txtAdminDonationSearch
        '
        Me.txtAdminDonationSearch.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminDonationSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminDonationSearch.DefaultText = ""
        Me.txtAdminDonationSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminDonationSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminDonationSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminDonationSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminDonationSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminDonationSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminDonationSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminDonationSearch.Location = New System.Drawing.Point(9, 258)
        Me.txtAdminDonationSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAdminDonationSearch.Name = "txtAdminDonationSearch"
        Me.txtAdminDonationSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminDonationSearch.PlaceholderText = ""
        Me.txtAdminDonationSearch.SelectedText = ""
        Me.txtAdminDonationSearch.Size = New System.Drawing.Size(189, 21)
        Me.txtAdminDonationSearch.TabIndex = 15
        '
        'AdminDonation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 529)
        Me.Controls.Add(Me.btnAdminSearchDonation)
        Me.Controls.Add(Me.txtAdminDonationSearch)
        Me.Controls.Add(Me.dgvAdminDonation)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.lblDonationSearchCampaign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlDonationEntries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "AdminDonation"
        Me.Text = "AdminDonation"
        Me.pnlDonationEntries.ResumeLayout(False)
        Me.pnlDonationEntries.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgvAdminDonation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlDonationEntries As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDonationSearchCampaign As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblDonorInformation As Label
    Friend WithEvents txtpnlAdminDonorInformation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpnlAdminDonationAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpnlAdminDonationCampaignID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDonationAmount As Label
    Friend WithEvents lblpnlCampaignID As Label
    Friend WithEvents btnAdminSaveDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminCancelDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvAdminDonation As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDonationDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAdminSearchDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAdminDonationSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
