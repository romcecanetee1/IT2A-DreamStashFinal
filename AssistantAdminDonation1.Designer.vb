<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssistantAdminDonation1
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlDonationEntries = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAssistantDonation = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAssistantDonationSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.dtpAssistantDonationDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAssistantSaveDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssistantCancelDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDonorInformation = New System.Windows.Forms.Label()
        Me.txtpnlAssistantDonorInformation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpnlAssistantDonationAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpnlAssistantDonationCampaignID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDonationAmount = New System.Windows.Forms.Label()
        Me.lblpnlCampaignID = New System.Windows.Forms.Label()
        Me.txtAssistantDonationCampaignID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAssistantDonationCampaignTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDonationCampaignTitle = New System.Windows.Forms.Label()
        Me.lblDonationCampaignID = New System.Windows.Forms.Label()
        Me.lblDonationSearchCampaign = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDonationEntries.SuspendLayout()
        CType(Me.dgvAssistantDonation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlDonationEntries
        '
        Me.pnlDonationEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlDonationEntries.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlDonationEntries.Controls.Add(Me.ControlBoxMin)
        Me.pnlDonationEntries.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlDonationEntries.Controls.Add(Me.ControlBoxClose)
        Me.pnlDonationEntries.Controls.Add(Me.Label1)
        Me.pnlDonationEntries.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDonationEntries.Location = New System.Drawing.Point(0, 0)
        Me.pnlDonationEntries.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDonationEntries.Name = "pnlDonationEntries"
        Me.pnlDonationEntries.Size = New System.Drawing.Size(1087, 42)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(967, 4)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(51, 31)
        Me.Guna2ControlBox1.TabIndex = 25
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(1708, 4)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxMin.TabIndex = 4
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1024, 4)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(51, 31)
        Me.Guna2ControlBox2.TabIndex = 24
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1767, 4)
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
        Me.Label1.Size = New System.Drawing.Size(225, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assistant Donation Entries"
        '
        'dgvAssistantDonation
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAssistantDonation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAssistantDonation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAssistantDonation.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAssistantDonation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssistantDonation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAssistantDonation.ColumnHeadersHeight = 17
        Me.dgvAssistantDonation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssistantDonation.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAssistantDonation.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantDonation.Location = New System.Drawing.Point(7, 357)
        Me.dgvAssistantDonation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAssistantDonation.MultiSelect = False
        Me.dgvAssistantDonation.Name = "dgvAssistantDonation"
        Me.dgvAssistantDonation.ReadOnly = True
        Me.dgvAssistantDonation.RowHeadersVisible = False
        Me.dgvAssistantDonation.RowHeadersWidth = 51
        Me.dgvAssistantDonation.RowTemplate.Height = 25
        Me.dgvAssistantDonation.Size = New System.Drawing.Size(1065, 266)
        Me.dgvAssistantDonation.TabIndex = 23
        Me.dgvAssistantDonation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssistantDonation.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAssistantDonation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAssistantDonation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAssistantDonation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAssistantDonation.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvAssistantDonation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantDonation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantDonation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAssistantDonation.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAssistantDonation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAssistantDonation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAssistantDonation.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvAssistantDonation.ThemeStyle.ReadOnly = True
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.Height = 25
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantDonation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAssistantDonationSearch
        '
        Me.btnAssistantDonationSearch.AutoRoundedCorners = True
        Me.btnAssistantDonationSearch.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantDonationSearch.BorderRadius = 14
        Me.btnAssistantDonationSearch.BorderThickness = 1
        Me.btnAssistantDonationSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantDonationSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantDonationSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAssistantDonationSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAssistantDonationSearch.FillColor = System.Drawing.Color.White
        Me.btnAssistantDonationSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAssistantDonationSearch.ForeColor = System.Drawing.Color.Black
        Me.btnAssistantDonationSearch.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantDonationSearch.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantDonationSearch.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAssistantDonationSearch.Location = New System.Drawing.Point(931, 320)
        Me.btnAssistantDonationSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAssistantDonationSearch.Name = "btnAssistantDonationSearch"
        Me.btnAssistantDonationSearch.Size = New System.Drawing.Size(141, 30)
        Me.btnAssistantDonationSearch.TabIndex = 22
        Me.btnAssistantDonationSearch.Text = "Search/Filter"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.lblTitle)
        Me.Guna2Panel1.Controls.Add(Me.lblUserName)
        Me.Guna2Panel1.Controls.Add(Me.lblID)
        Me.Guna2Panel1.Controls.Add(Me.dtpAssistantDonationDate)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.btnAssistantSaveDonation)
        Me.Guna2Panel1.Controls.Add(Me.btnAssistantCancelDonation)
        Me.Guna2Panel1.Controls.Add(Me.lblDonorInformation)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAssistantDonorInformation)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAssistantDonationAmount)
        Me.Guna2Panel1.Controls.Add(Me.txtpnlAssistantDonationCampaignID)
        Me.Guna2Panel1.Controls.Add(Me.lblDonationAmount)
        Me.Guna2Panel1.Controls.Add(Me.lblpnlCampaignID)
        Me.Guna2Panel1.Location = New System.Drawing.Point(13, 95)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1059, 187)
        Me.Guna2Panel1.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(13, 102)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(46, 20)
        Me.lblTitle.TabIndex = 36
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblUserName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUserName.Location = New System.Drawing.Point(925, 154)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(121, 20)
        Me.lblUserName.TabIndex = 35
        Me.lblUserName.Text = "                            "
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(829, 154)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(85, 20)
        Me.lblID.TabIndex = 34
        Me.lblID.Text = "                   "
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpAssistantDonationDate
        '
        Me.dtpAssistantDonationDate.Checked = True
        Me.dtpAssistantDonationDate.FillColor = System.Drawing.Color.Purple
        Me.dtpAssistantDonationDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpAssistantDonationDate.ForeColor = System.Drawing.Color.White
        Me.dtpAssistantDonationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpAssistantDonationDate.Location = New System.Drawing.Point(725, 81)
        Me.dtpAssistantDonationDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpAssistantDonationDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAssistantDonationDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAssistantDonationDate.Name = "dtpAssistantDonationDate"
        Me.dtpAssistantDonationDate.Size = New System.Drawing.Size(268, 39)
        Me.dtpAssistantDonationDate.TabIndex = 33
        Me.dtpAssistantDonationDate.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(564, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Donation Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAssistantSaveDonation
        '
        Me.btnAssistantSaveDonation.AutoRoundedCorners = True
        Me.btnAssistantSaveDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantSaveDonation.BorderRadius = 14
        Me.btnAssistantSaveDonation.BorderThickness = 1
        Me.btnAssistantSaveDonation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantSaveDonation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantSaveDonation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAssistantSaveDonation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAssistantSaveDonation.FillColor = System.Drawing.Color.White
        Me.btnAssistantSaveDonation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAssistantSaveDonation.ForeColor = System.Drawing.Color.Black
        Me.btnAssistantSaveDonation.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantSaveDonation.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantSaveDonation.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAssistantSaveDonation.Location = New System.Drawing.Point(376, 154)
        Me.btnAssistantSaveDonation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAssistantSaveDonation.Name = "btnAssistantSaveDonation"
        Me.btnAssistantSaveDonation.Size = New System.Drawing.Size(105, 30)
        Me.btnAssistantSaveDonation.TabIndex = 13
        Me.btnAssistantSaveDonation.Text = "Save"
        '
        'btnAssistantCancelDonation
        '
        Me.btnAssistantCancelDonation.AutoRoundedCorners = True
        Me.btnAssistantCancelDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantCancelDonation.BorderRadius = 14
        Me.btnAssistantCancelDonation.BorderThickness = 1
        Me.btnAssistantCancelDonation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantCancelDonation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantCancelDonation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAssistantCancelDonation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAssistantCancelDonation.FillColor = System.Drawing.Color.White
        Me.btnAssistantCancelDonation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAssistantCancelDonation.ForeColor = System.Drawing.Color.Black
        Me.btnAssistantCancelDonation.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantCancelDonation.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantCancelDonation.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAssistantCancelDonation.Location = New System.Drawing.Point(509, 154)
        Me.btnAssistantCancelDonation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAssistantCancelDonation.Name = "btnAssistantCancelDonation"
        Me.btnAssistantCancelDonation.Size = New System.Drawing.Size(105, 30)
        Me.btnAssistantCancelDonation.TabIndex = 13
        Me.btnAssistantCancelDonation.Text = "Clear"
        '
        'lblDonorInformation
        '
        Me.lblDonorInformation.AutoSize = True
        Me.lblDonorInformation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonorInformation.Location = New System.Drawing.Point(564, 49)
        Me.lblDonorInformation.Name = "lblDonorInformation"
        Me.lblDonorInformation.Size = New System.Drawing.Size(147, 20)
        Me.lblDonorInformation.TabIndex = 4
        Me.lblDonorInformation.Text = "Donor Username"
        Me.lblDonorInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpnlAssistantDonorInformation
        '
        Me.txtpnlAssistantDonorInformation.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAssistantDonorInformation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAssistantDonorInformation.DefaultText = ""
        Me.txtpnlAssistantDonorInformation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAssistantDonorInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAssistantDonorInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAssistantDonorInformation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAssistantDonorInformation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAssistantDonorInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAssistantDonorInformation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAssistantDonorInformation.Location = New System.Drawing.Point(725, 49)
        Me.txtpnlAssistantDonorInformation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpnlAssistantDonorInformation.Name = "txtpnlAssistantDonorInformation"
        Me.txtpnlAssistantDonorInformation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAssistantDonorInformation.PlaceholderText = ""
        Me.txtpnlAssistantDonorInformation.SelectedText = ""
        Me.txtpnlAssistantDonorInformation.Size = New System.Drawing.Size(247, 26)
        Me.txtpnlAssistantDonorInformation.TabIndex = 4
        '
        'txtpnlAssistantDonationAmount
        '
        Me.txtpnlAssistantDonationAmount.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAssistantDonationAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAssistantDonationAmount.DefaultText = ""
        Me.txtpnlAssistantDonationAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAssistantDonationAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAssistantDonationAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAssistantDonationAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAssistantDonationAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAssistantDonationAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAssistantDonationAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAssistantDonationAmount.Location = New System.Drawing.Point(204, 81)
        Me.txtpnlAssistantDonationAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpnlAssistantDonationAmount.Name = "txtpnlAssistantDonationAmount"
        Me.txtpnlAssistantDonationAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAssistantDonationAmount.PlaceholderText = ""
        Me.txtpnlAssistantDonationAmount.SelectedText = ""
        Me.txtpnlAssistantDonationAmount.Size = New System.Drawing.Size(247, 26)
        Me.txtpnlAssistantDonationAmount.TabIndex = 4
        '
        'txtpnlAssistantDonationCampaignID
        '
        Me.txtpnlAssistantDonationCampaignID.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtpnlAssistantDonationCampaignID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpnlAssistantDonationCampaignID.DefaultText = ""
        Me.txtpnlAssistantDonationCampaignID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpnlAssistantDonationCampaignID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpnlAssistantDonationCampaignID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAssistantDonationCampaignID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpnlAssistantDonationCampaignID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAssistantDonationCampaignID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpnlAssistantDonationCampaignID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpnlAssistantDonationCampaignID.Location = New System.Drawing.Point(204, 42)
        Me.txtpnlAssistantDonationCampaignID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpnlAssistantDonationCampaignID.Name = "txtpnlAssistantDonationCampaignID"
        Me.txtpnlAssistantDonationCampaignID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpnlAssistantDonationCampaignID.PlaceholderText = ""
        Me.txtpnlAssistantDonationCampaignID.SelectedText = ""
        Me.txtpnlAssistantDonationCampaignID.Size = New System.Drawing.Size(247, 26)
        Me.txtpnlAssistantDonationCampaignID.TabIndex = 4
        '
        'lblDonationAmount
        '
        Me.lblDonationAmount.AutoSize = True
        Me.lblDonationAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationAmount.Location = New System.Drawing.Point(40, 81)
        Me.lblDonationAmount.Name = "lblDonationAmount"
        Me.lblDonationAmount.Size = New System.Drawing.Size(150, 20)
        Me.lblDonationAmount.TabIndex = 4
        Me.lblDonationAmount.Text = "Donation Amount"
        Me.lblDonationAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpnlCampaignID
        '
        Me.lblpnlCampaignID.AutoSize = True
        Me.lblpnlCampaignID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblpnlCampaignID.Location = New System.Drawing.Point(40, 42)
        Me.lblpnlCampaignID.Name = "lblpnlCampaignID"
        Me.lblpnlCampaignID.Size = New System.Drawing.Size(116, 20)
        Me.lblpnlCampaignID.TabIndex = 4
        Me.lblpnlCampaignID.Text = "Campaign ID"
        Me.lblpnlCampaignID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAssistantDonationCampaignID
        '
        Me.txtAssistantDonationCampaignID.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAssistantDonationCampaignID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssistantDonationCampaignID.DefaultText = ""
        Me.txtAssistantDonationCampaignID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAssistantDonationCampaignID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAssistantDonationCampaignID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssistantDonationCampaignID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssistantDonationCampaignID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssistantDonationCampaignID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAssistantDonationCampaignID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssistantDonationCampaignID.Location = New System.Drawing.Point(140, 324)
        Me.txtAssistantDonationCampaignID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAssistantDonationCampaignID.Name = "txtAssistantDonationCampaignID"
        Me.txtAssistantDonationCampaignID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssistantDonationCampaignID.PlaceholderText = ""
        Me.txtAssistantDonationCampaignID.SelectedText = ""
        Me.txtAssistantDonationCampaignID.Size = New System.Drawing.Size(217, 26)
        Me.txtAssistantDonationCampaignID.TabIndex = 19
        '
        'txtAssistantDonationCampaignTitle
        '
        Me.txtAssistantDonationCampaignTitle.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAssistantDonationCampaignTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssistantDonationCampaignTitle.DefaultText = ""
        Me.txtAssistantDonationCampaignTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAssistantDonationCampaignTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAssistantDonationCampaignTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssistantDonationCampaignTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssistantDonationCampaignTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssistantDonationCampaignTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAssistantDonationCampaignTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssistantDonationCampaignTitle.Location = New System.Drawing.Point(581, 324)
        Me.txtAssistantDonationCampaignTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAssistantDonationCampaignTitle.Name = "txtAssistantDonationCampaignTitle"
        Me.txtAssistantDonationCampaignTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssistantDonationCampaignTitle.PlaceholderText = ""
        Me.txtAssistantDonationCampaignTitle.SelectedText = ""
        Me.txtAssistantDonationCampaignTitle.Size = New System.Drawing.Size(245, 26)
        Me.txtAssistantDonationCampaignTitle.TabIndex = 20
        '
        'lblDonationCampaignTitle
        '
        Me.lblDonationCampaignTitle.AutoSize = True
        Me.lblDonationCampaignTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationCampaignTitle.Location = New System.Drawing.Point(436, 324)
        Me.lblDonationCampaignTitle.Name = "lblDonationCampaignTitle"
        Me.lblDonationCampaignTitle.Size = New System.Drawing.Size(135, 20)
        Me.lblDonationCampaignTitle.TabIndex = 16
        Me.lblDonationCampaignTitle.Text = "Campaign Title"
        Me.lblDonationCampaignTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDonationCampaignID
        '
        Me.lblDonationCampaignID.AutoSize = True
        Me.lblDonationCampaignID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationCampaignID.Location = New System.Drawing.Point(15, 324)
        Me.lblDonationCampaignID.Name = "lblDonationCampaignID"
        Me.lblDonationCampaignID.Size = New System.Drawing.Size(116, 20)
        Me.lblDonationCampaignID.TabIndex = 17
        Me.lblDonationCampaignID.Text = "Campaign ID"
        Me.lblDonationCampaignID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDonationSearchCampaign
        '
        Me.lblDonationSearchCampaign.AutoSize = True
        Me.lblDonationSearchCampaign.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationSearchCampaign.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblDonationSearchCampaign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDonationSearchCampaign.Location = New System.Drawing.Point(21, 286)
        Me.lblDonationSearchCampaign.Name = "lblDonationSearchCampaign"
        Me.lblDonationSearchCampaign.Size = New System.Drawing.Size(156, 20)
        Me.lblDonationSearchCampaign.TabIndex = 18
        Me.lblDonationSearchCampaign.Text = "Search Campaign"
        Me.lblDonationSearchCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DONATION ENTRY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AssistantAdminDonation1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 638)
        Me.Controls.Add(Me.dgvAssistantDonation)
        Me.Controls.Add(Me.btnAssistantDonationSearch)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.txtAssistantDonationCampaignID)
        Me.Controls.Add(Me.txtAssistantDonationCampaignTitle)
        Me.Controls.Add(Me.lblDonationCampaignTitle)
        Me.Controls.Add(Me.lblDonationCampaignID)
        Me.Controls.Add(Me.lblDonationSearchCampaign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlDonationEntries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AssistantAdminDonation1"
        Me.Text = "AssistantAdminDonation1"
        Me.pnlDonationEntries.ResumeLayout(False)
        Me.pnlDonationEntries.PerformLayout()
        CType(Me.dgvAssistantDonation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlDonationEntries As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAssistantDonation As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAssistantDonationSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents dtpAssistantDonationDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAssistantSaveDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssistantCancelDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDonorInformation As Label
    Friend WithEvents txtpnlAssistantDonorInformation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpnlAssistantDonationAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpnlAssistantDonationCampaignID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDonationAmount As Label
    Friend WithEvents lblpnlCampaignID As Label
    Friend WithEvents txtAssistantDonationCampaignID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAssistantDonationCampaignTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDonationCampaignTitle As Label
    Friend WithEvents lblDonationCampaignID As Label
    Friend WithEvents lblDonationSearchCampaign As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
End Class
