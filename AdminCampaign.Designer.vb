<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCampaign
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
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAdminNewCampaign = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblpnlNewCampaignTitle = New System.Windows.Forms.Label()
        Me.txtpnlAdminNewCampaignTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblpnlNewCampaignStatus = New System.Windows.Forms.Label()
        Me.btnAdminSearchNewCampaign = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxAdminNewCampaignStatus = New System.Windows.Forms.ComboBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblNewCampaignTitle = New System.Windows.Forms.Label()
        Me.lblNewDonationGoal = New System.Windows.Forms.Label()
        Me.lblNewOrgnizerInformation = New System.Windows.Forms.Label()
        Me.lblNewStartDate = New System.Windows.Forms.Label()
        Me.lblNewEndDate = New System.Windows.Forms.Label()
        Me.lblNewCampaignDescription = New System.Windows.Forms.Label()
        Me.txtAdminCampaignBeneName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminNewCampaignDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminNewDonationGoal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminNewCampaignTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdminSaveNewCampaign = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpAdminStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpAdminEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnAdminEditNewCampaign = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCampaignID = New System.Windows.Forms.Label()
        Me.pnlDonationEntries.SuspendLayout()
        CType(Me.dgvAdminNewCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'pnlDonationEntries
        '
        Me.pnlDonationEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlDonationEntries.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlDonationEntries.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlDonationEntries.Controls.Add(Me.ControlBoxMin)
        Me.pnlDonationEntries.Controls.Add(Me.ControlBoxClose)
        Me.pnlDonationEntries.Controls.Add(Me.Label1)
        Me.pnlDonationEntries.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDonationEntries.Location = New System.Drawing.Point(0, 0)
        Me.pnlDonationEntries.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDonationEntries.Name = "pnlDonationEntries"
        Me.pnlDonationEntries.Size = New System.Drawing.Size(1087, 49)
        Me.pnlDonationEntries.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(977, 4)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(51, 31)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1035, 4)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(51, 31)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(1681, 4)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxMin.TabIndex = 4
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1739, 4)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Campaign Entries"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CREATE NEW CAMPAIGN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvAdminNewCampaign
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAdminNewCampaign.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdminNewCampaign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAdminNewCampaign.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAdminNewCampaign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdminNewCampaign.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAdminNewCampaign.ColumnHeadersHeight = 17
        Me.dgvAdminNewCampaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdminNewCampaign.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdminNewCampaign.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminNewCampaign.Location = New System.Drawing.Point(16, 404)
        Me.dgvAdminNewCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAdminNewCampaign.MultiSelect = False
        Me.dgvAdminNewCampaign.Name = "dgvAdminNewCampaign"
        Me.dgvAdminNewCampaign.ReadOnly = True
        Me.dgvAdminNewCampaign.RowHeadersVisible = False
        Me.dgvAdminNewCampaign.RowHeadersWidth = 51
        Me.dgvAdminNewCampaign.RowTemplate.Height = 25
        Me.dgvAdminNewCampaign.Size = New System.Drawing.Size(1055, 233)
        Me.dgvAdminNewCampaign.TabIndex = 16
        Me.dgvAdminNewCampaign.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminNewCampaign.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAdminNewCampaign.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAdminNewCampaign.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAdminNewCampaign.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAdminNewCampaign.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvAdminNewCampaign.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminNewCampaign.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminNewCampaign.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAdminNewCampaign.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminNewCampaign.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAdminNewCampaign.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAdminNewCampaign.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvAdminNewCampaign.ThemeStyle.ReadOnly = True
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.Height = 25
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminNewCampaign.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lblpnlNewCampaignTitle
        '
        Me.lblpnlNewCampaignTitle.AutoSize = True
        Me.lblpnlNewCampaignTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblpnlNewCampaignTitle.Location = New System.Drawing.Point(5, 38)
        Me.lblpnlNewCampaignTitle.Name = "lblpnlNewCampaignTitle"
        Me.lblpnlNewCampaignTitle.Size = New System.Drawing.Size(156, 20)
        Me.lblpnlNewCampaignTitle.TabIndex = 4
        Me.lblpnlNewCampaignTitle.Text = "Search Campaign"
        Me.lblpnlNewCampaignTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpnlAdminNewCampaignTitle
        '
        Me.txtpnlAdminNewCampaignTitle.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAdminNewCampaignTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAdminNewCampaignTitle.DefaultText = ""
        Me.txtpnlAdminNewCampaignTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAdminNewCampaignTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAdminNewCampaignTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminNewCampaignTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAdminNewCampaignTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminNewCampaignTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAdminNewCampaignTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAdminNewCampaignTitle.Location = New System.Drawing.Point(167, 38)
        Me.txtpnlAdminNewCampaignTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpnlAdminNewCampaignTitle.Name = "txtpnlAdminNewCampaignTitle"
        Me.txtpnlAdminNewCampaignTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAdminNewCampaignTitle.PlaceholderText = ""
        Me.txtpnlAdminNewCampaignTitle.SelectedText = ""
        Me.txtpnlAdminNewCampaignTitle.Size = New System.Drawing.Size(252, 26)
        Me.txtpnlAdminNewCampaignTitle.TabIndex = 4
        '
        'lblpnlNewCampaignStatus
        '
        Me.lblpnlNewCampaignStatus.AutoSize = True
        Me.lblpnlNewCampaignStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblpnlNewCampaignStatus.Location = New System.Drawing.Point(5, 70)
        Me.lblpnlNewCampaignStatus.Name = "lblpnlNewCampaignStatus"
        Me.lblpnlNewCampaignStatus.Size = New System.Drawing.Size(150, 20)
        Me.lblpnlNewCampaignStatus.TabIndex = 4
        Me.lblpnlNewCampaignStatus.Text = "Campaign Status"
        Me.lblpnlNewCampaignStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdminSearchNewCampaign
        '
        Me.btnAdminSearchNewCampaign.AutoRoundedCorners = True
        Me.btnAdminSearchNewCampaign.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchNewCampaign.BorderRadius = 14
        Me.btnAdminSearchNewCampaign.BorderThickness = 1
        Me.btnAdminSearchNewCampaign.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchNewCampaign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchNewCampaign.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSearchNewCampaign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSearchNewCampaign.FillColor = System.Drawing.Color.White
        Me.btnAdminSearchNewCampaign.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSearchNewCampaign.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSearchNewCampaign.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchNewCampaign.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchNewCampaign.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSearchNewCampaign.Location = New System.Drawing.Point(271, 132)
        Me.btnAdminSearchNewCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminSearchNewCampaign.Name = "btnAdminSearchNewCampaign"
        Me.btnAdminSearchNewCampaign.Size = New System.Drawing.Size(120, 30)
        Me.btnAdminSearchNewCampaign.TabIndex = 13
        Me.btnAdminSearchNewCampaign.Text = "Search"
        '
        'cbxAdminNewCampaignStatus
        '
        Me.cbxAdminNewCampaignStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAdminNewCampaignStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAdminNewCampaignStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxAdminNewCampaignStatus.FormattingEnabled = True
        Me.cbxAdminNewCampaignStatus.Items.AddRange(New Object() {"Active", "Archived"})
        Me.cbxAdminNewCampaignStatus.Location = New System.Drawing.Point(167, 70)
        Me.cbxAdminNewCampaignStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxAdminNewCampaignStatus.Name = "cbxAdminNewCampaignStatus"
        Me.cbxAdminNewCampaignStatus.Size = New System.Drawing.Size(251, 25)
        Me.cbxAdminNewCampaignStatus.TabIndex = 37
        Me.cbxAdminNewCampaignStatus.Text = "Active"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.cbxAdminNewCampaignStatus)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminSearchNewCampaign)
        Me.Guna2Panel1.Controls.Add(Me.lblpnlNewCampaignStatus)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAdminNewCampaignTitle)
        Me.Guna2Panel1.Controls.Add(Me.lblpnlNewCampaignTitle)
        Me.Guna2Panel1.Location = New System.Drawing.Point(637, 183)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(433, 174)
        Me.Guna2Panel1.TabIndex = 18
        '
        'lblNewCampaignTitle
        '
        Me.lblNewCampaignTitle.AutoSize = True
        Me.lblNewCampaignTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblNewCampaignTitle.ForeColor = System.Drawing.Color.Black
        Me.lblNewCampaignTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNewCampaignTitle.Location = New System.Drawing.Point(20, 94)
        Me.lblNewCampaignTitle.Name = "lblNewCampaignTitle"
        Me.lblNewCampaignTitle.Size = New System.Drawing.Size(135, 20)
        Me.lblNewCampaignTitle.TabIndex = 26
        Me.lblNewCampaignTitle.Text = "Campaign Title"
        Me.lblNewCampaignTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewDonationGoal
        '
        Me.lblNewDonationGoal.AutoSize = True
        Me.lblNewDonationGoal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblNewDonationGoal.Location = New System.Drawing.Point(28, 311)
        Me.lblNewDonationGoal.Name = "lblNewDonationGoal"
        Me.lblNewDonationGoal.Size = New System.Drawing.Size(125, 20)
        Me.lblNewDonationGoal.TabIndex = 25
        Me.lblNewDonationGoal.Text = "Donation Goal"
        Me.lblNewDonationGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewOrgnizerInformation
        '
        Me.lblNewOrgnizerInformation.AutoSize = True
        Me.lblNewOrgnizerInformation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblNewOrgnizerInformation.Location = New System.Drawing.Point(25, 348)
        Me.lblNewOrgnizerInformation.Name = "lblNewOrgnizerInformation"
        Me.lblNewOrgnizerInformation.Size = New System.Drawing.Size(125, 20)
        Me.lblNewOrgnizerInformation.TabIndex = 24
        Me.lblNewOrgnizerInformation.Text = "Beneficiary ID"
        Me.lblNewOrgnizerInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewStartDate
        '
        Me.lblNewStartDate.AutoSize = True
        Me.lblNewStartDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblNewStartDate.Location = New System.Drawing.Point(28, 238)
        Me.lblNewStartDate.Name = "lblNewStartDate"
        Me.lblNewStartDate.Size = New System.Drawing.Size(92, 20)
        Me.lblNewStartDate.TabIndex = 23
        Me.lblNewStartDate.Text = "Start Date"
        Me.lblNewStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewEndDate
        '
        Me.lblNewEndDate.AutoSize = True
        Me.lblNewEndDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblNewEndDate.Location = New System.Drawing.Point(28, 273)
        Me.lblNewEndDate.Name = "lblNewEndDate"
        Me.lblNewEndDate.Size = New System.Drawing.Size(84, 20)
        Me.lblNewEndDate.TabIndex = 22
        Me.lblNewEndDate.Text = "End Date"
        Me.lblNewEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewCampaignDescription
        '
        Me.lblNewCampaignDescription.AutoSize = True
        Me.lblNewCampaignDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblNewCampaignDescription.Location = New System.Drawing.Point(49, 124)
        Me.lblNewCampaignDescription.Name = "lblNewCampaignDescription"
        Me.lblNewCampaignDescription.Size = New System.Drawing.Size(105, 20)
        Me.lblNewCampaignDescription.TabIndex = 21
        Me.lblNewCampaignDescription.Text = "Description"
        Me.lblNewCampaignDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdminCampaignBeneName
        '
        Me.txtAdminCampaignBeneName.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminCampaignBeneName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminCampaignBeneName.DefaultText = ""
        Me.txtAdminCampaignBeneName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminCampaignBeneName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminCampaignBeneName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminCampaignBeneName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminCampaignBeneName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminCampaignBeneName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminCampaignBeneName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminCampaignBeneName.Location = New System.Drawing.Point(193, 348)
        Me.txtAdminCampaignBeneName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminCampaignBeneName.Name = "txtAdminCampaignBeneName"
        Me.txtAdminCampaignBeneName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminCampaignBeneName.PlaceholderText = ""
        Me.txtAdminCampaignBeneName.SelectedText = ""
        Me.txtAdminCampaignBeneName.Size = New System.Drawing.Size(251, 26)
        Me.txtAdminCampaignBeneName.TabIndex = 30
        '
        'txtAdminNewCampaignDescription
        '
        Me.txtAdminNewCampaignDescription.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminNewCampaignDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminNewCampaignDescription.DefaultText = ""
        Me.txtAdminNewCampaignDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminNewCampaignDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminNewCampaignDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminNewCampaignDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminNewCampaignDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminNewCampaignDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminNewCampaignDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminNewCampaignDescription.Location = New System.Drawing.Point(185, 124)
        Me.txtAdminNewCampaignDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminNewCampaignDescription.Multiline = True
        Me.txtAdminNewCampaignDescription.Name = "txtAdminNewCampaignDescription"
        Me.txtAdminNewCampaignDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminNewCampaignDescription.PlaceholderText = ""
        Me.txtAdminNewCampaignDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdminNewCampaignDescription.SelectedText = ""
        Me.txtAdminNewCampaignDescription.Size = New System.Drawing.Size(429, 103)
        Me.txtAdminNewCampaignDescription.TabIndex = 29
        '
        'txtAdminNewDonationGoal
        '
        Me.txtAdminNewDonationGoal.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminNewDonationGoal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminNewDonationGoal.DefaultText = ""
        Me.txtAdminNewDonationGoal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminNewDonationGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminNewDonationGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminNewDonationGoal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminNewDonationGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminNewDonationGoal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminNewDonationGoal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminNewDonationGoal.Location = New System.Drawing.Point(193, 311)
        Me.txtAdminNewDonationGoal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminNewDonationGoal.Name = "txtAdminNewDonationGoal"
        Me.txtAdminNewDonationGoal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminNewDonationGoal.PlaceholderText = ""
        Me.txtAdminNewDonationGoal.SelectedText = ""
        Me.txtAdminNewDonationGoal.Size = New System.Drawing.Size(251, 26)
        Me.txtAdminNewDonationGoal.TabIndex = 28
        '
        'txtAdminNewCampaignTitle
        '
        Me.txtAdminNewCampaignTitle.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminNewCampaignTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminNewCampaignTitle.DefaultText = ""
        Me.txtAdminNewCampaignTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminNewCampaignTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminNewCampaignTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminNewCampaignTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminNewCampaignTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminNewCampaignTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminNewCampaignTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminNewCampaignTitle.Location = New System.Drawing.Point(185, 94)
        Me.txtAdminNewCampaignTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdminNewCampaignTitle.Name = "txtAdminNewCampaignTitle"
        Me.txtAdminNewCampaignTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminNewCampaignTitle.PlaceholderText = ""
        Me.txtAdminNewCampaignTitle.SelectedText = ""
        Me.txtAdminNewCampaignTitle.Size = New System.Drawing.Size(345, 23)
        Me.txtAdminNewCampaignTitle.TabIndex = 27
        '
        'btnAdminSaveNewCampaign
        '
        Me.btnAdminSaveNewCampaign.AutoRoundedCorners = True
        Me.btnAdminSaveNewCampaign.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveNewCampaign.BorderRadius = 14
        Me.btnAdminSaveNewCampaign.BorderThickness = 1
        Me.btnAdminSaveNewCampaign.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSaveNewCampaign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSaveNewCampaign.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSaveNewCampaign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSaveNewCampaign.FillColor = System.Drawing.Color.White
        Me.btnAdminSaveNewCampaign.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSaveNewCampaign.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSaveNewCampaign.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveNewCampaign.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveNewCampaign.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSaveNewCampaign.Location = New System.Drawing.Point(449, 367)
        Me.btnAdminSaveNewCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminSaveNewCampaign.Name = "btnAdminSaveNewCampaign"
        Me.btnAdminSaveNewCampaign.Size = New System.Drawing.Size(165, 30)
        Me.btnAdminSaveNewCampaign.TabIndex = 31
        Me.btnAdminSaveNewCampaign.Text = "Create New"
        '
        'dtpAdminStartDate
        '
        Me.dtpAdminStartDate.Checked = True
        Me.dtpAdminStartDate.FillColor = System.Drawing.Color.Purple
        Me.dtpAdminStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpAdminStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpAdminStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpAdminStartDate.Location = New System.Drawing.Point(193, 234)
        Me.dtpAdminStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpAdminStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAdminStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAdminStartDate.Name = "dtpAdminStartDate"
        Me.dtpAdminStartDate.Size = New System.Drawing.Size(280, 36)
        Me.dtpAdminStartDate.TabIndex = 32
        Me.dtpAdminStartDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'dtpAdminEndDate
        '
        Me.dtpAdminEndDate.Checked = True
        Me.dtpAdminEndDate.FillColor = System.Drawing.Color.Purple
        Me.dtpAdminEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpAdminEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpAdminEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpAdminEndDate.Location = New System.Drawing.Point(193, 273)
        Me.dtpAdminEndDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpAdminEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAdminEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAdminEndDate.Name = "dtpAdminEndDate"
        Me.dtpAdminEndDate.Size = New System.Drawing.Size(280, 36)
        Me.dtpAdminEndDate.TabIndex = 33
        Me.dtpAdminEndDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'btnAdminEditNewCampaign
        '
        Me.btnAdminEditNewCampaign.AutoRoundedCorners = True
        Me.btnAdminEditNewCampaign.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminEditNewCampaign.BorderRadius = 14
        Me.btnAdminEditNewCampaign.BorderThickness = 1
        Me.btnAdminEditNewCampaign.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminEditNewCampaign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminEditNewCampaign.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminEditNewCampaign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminEditNewCampaign.Enabled = False
        Me.btnAdminEditNewCampaign.FillColor = System.Drawing.Color.White
        Me.btnAdminEditNewCampaign.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminEditNewCampaign.ForeColor = System.Drawing.Color.Black
        Me.btnAdminEditNewCampaign.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminEditNewCampaign.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminEditNewCampaign.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminEditNewCampaign.Location = New System.Drawing.Point(951, 367)
        Me.btnAdminEditNewCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminEditNewCampaign.Name = "btnAdminEditNewCampaign"
        Me.btnAdminEditNewCampaign.Size = New System.Drawing.Size(120, 30)
        Me.btnAdminEditNewCampaign.TabIndex = 13
        Me.btnAdminEditNewCampaign.Text = "Edit"
        '
        'lblCampaignID
        '
        Me.lblCampaignID.AutoSize = True
        Me.lblCampaignID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.lblCampaignID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCampaignID.Location = New System.Drawing.Point(859, 89)
        Me.lblCampaignID.Name = "lblCampaignID"
        Me.lblCampaignID.Size = New System.Drawing.Size(57, 20)
        Me.lblCampaignID.TabIndex = 34
        Me.lblCampaignID.Text = "Users"
        '
        'AdminCampaign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 651)
        Me.Controls.Add(Me.lblCampaignID)
        Me.Controls.Add(Me.btnAdminEditNewCampaign)
        Me.Controls.Add(Me.dtpAdminEndDate)
        Me.Controls.Add(Me.dtpAdminStartDate)
        Me.Controls.Add(Me.btnAdminSaveNewCampaign)
        Me.Controls.Add(Me.txtAdminNewCampaignTitle)
        Me.Controls.Add(Me.txtAdminNewDonationGoal)
        Me.Controls.Add(Me.txtAdminNewCampaignDescription)
        Me.Controls.Add(Me.txtAdminCampaignBeneName)
        Me.Controls.Add(Me.lblNewCampaignDescription)
        Me.Controls.Add(Me.lblNewEndDate)
        Me.Controls.Add(Me.lblNewStartDate)
        Me.Controls.Add(Me.lblNewOrgnizerInformation)
        Me.Controls.Add(Me.lblNewDonationGoal)
        Me.Controls.Add(Me.lblNewCampaignTitle)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.dgvAdminNewCampaign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlDonationEntries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AdminCampaign"
        Me.Text = "AdminCampaign"
        Me.pnlDonationEntries.ResumeLayout(False)
        Me.pnlDonationEntries.PerformLayout()
        CType(Me.dgvAdminNewCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlDonationEntries As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblCampaignID As Label
    Friend WithEvents btnAdminEditNewCampaign As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpAdminEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpAdminStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnAdminSaveNewCampaign As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAdminNewCampaignTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdminNewDonationGoal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdminNewCampaignDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdminCampaignBeneName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblNewCampaignDescription As Label
    Friend WithEvents lblNewEndDate As Label
    Friend WithEvents lblNewStartDate As Label
    Friend WithEvents lblNewOrgnizerInformation As Label
    Friend WithEvents lblNewDonationGoal As Label
    Friend WithEvents lblNewCampaignTitle As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbxAdminNewCampaignStatus As ComboBox
    Friend WithEvents btnAdminSearchNewCampaign As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblpnlNewCampaignStatus As Label
    Friend WithEvents txtpnlAdminNewCampaignTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblpnlNewCampaignTitle As Label
    Friend WithEvents dgvAdminNewCampaign As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
End Class
