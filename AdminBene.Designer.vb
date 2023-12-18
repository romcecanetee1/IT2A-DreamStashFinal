<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBene
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
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAdminBene = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAdminSearchBene = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAdminSearchBene = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnAdminSaveDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminCancelDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBeneInfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBeneName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDonationAmount = New System.Windows.Forms.Label()
        Me.lblpnlCampaignID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBeneCampaign = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlDonationEntries.SuspendLayout()
        CType(Me.dgvAdminBene, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(977, 4)
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
        Me.ControlBoxClose.Location = New System.Drawing.Point(1035, 4)
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
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beneficiaries"
        '
        'dgvAdminBene
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAdminBene.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdminBene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAdminBene.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAdminBene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdminBene.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAdminBene.ColumnHeadersHeight = 17
        Me.dgvAdminBene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdminBene.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdminBene.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminBene.Location = New System.Drawing.Point(12, 346)
        Me.dgvAdminBene.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAdminBene.MultiSelect = False
        Me.dgvAdminBene.Name = "dgvAdminBene"
        Me.dgvAdminBene.ReadOnly = True
        Me.dgvAdminBene.RowHeadersVisible = False
        Me.dgvAdminBene.RowHeadersWidth = 51
        Me.dgvAdminBene.RowTemplate.Height = 25
        Me.dgvAdminBene.Size = New System.Drawing.Size(1055, 292)
        Me.dgvAdminBene.TabIndex = 17
        Me.dgvAdminBene.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminBene.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAdminBene.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAdminBene.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAdminBene.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAdminBene.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvAdminBene.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminBene.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminBene.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAdminBene.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminBene.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAdminBene.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAdminBene.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvAdminBene.ThemeStyle.ReadOnly = True
        Me.dgvAdminBene.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminBene.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAdminBene.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminBene.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAdminBene.ThemeStyle.RowsStyle.Height = 25
        Me.dgvAdminBene.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminBene.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAdminSearchBene
        '
        Me.btnAdminSearchBene.AutoRoundedCorners = True
        Me.btnAdminSearchBene.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchBene.BorderRadius = 14
        Me.btnAdminSearchBene.BorderThickness = 1
        Me.btnAdminSearchBene.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchBene.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSearchBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSearchBene.FillColor = System.Drawing.Color.White
        Me.btnAdminSearchBene.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSearchBene.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSearchBene.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchBene.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchBene.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSearchBene.Location = New System.Drawing.Point(260, 307)
        Me.btnAdminSearchBene.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminSearchBene.Name = "btnAdminSearchBene"
        Me.btnAdminSearchBene.Size = New System.Drawing.Size(172, 30)
        Me.btnAdminSearchBene.TabIndex = 19
        Me.btnAdminSearchBene.Text = "Search/Filter"
        '
        'txtAdminSearchBene
        '
        Me.txtAdminSearchBene.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminSearchBene.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminSearchBene.DefaultText = ""
        Me.txtAdminSearchBene.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminSearchBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminSearchBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminSearchBene.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminSearchBene.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminSearchBene.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminSearchBene.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminSearchBene.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtAdminSearchBene.Location = New System.Drawing.Point(12, 307)
        Me.txtAdminSearchBene.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdminSearchBene.Name = "txtAdminSearchBene"
        Me.txtAdminSearchBene.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminSearchBene.PlaceholderText = "Search"
        Me.txtAdminSearchBene.SelectedText = ""
        Me.txtAdminSearchBene.Size = New System.Drawing.Size(240, 30)
        Me.txtAdminSearchBene.TabIndex = 18
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.txtBeneCampaign)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.lblTitle)
        Me.Guna2Panel1.Controls.Add(Me.lblUserName)
        Me.Guna2Panel1.Controls.Add(Me.lblID)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminSaveDonation)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminCancelDonation)
        Me.Guna2Panel1.Controls.Add(Me.txtBeneInfo)
        Me.Guna2Panel1.Controls.Add(Me.txtBeneName)
        Me.Guna2Panel1.Controls.Add(Me.lblDonationAmount)
        Me.Guna2Panel1.Controls.Add(Me.lblpnlCampaignID)
        Me.Guna2Panel1.Location = New System.Drawing.Point(17, 105)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(553, 193)
        Me.Guna2Panel1.TabIndex = 20
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(13, 150)
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
        Me.lblUserName.Location = New System.Drawing.Point(804, 150)
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
        Me.lblID.Location = New System.Drawing.Point(960, 150)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(85, 20)
        Me.lblID.TabIndex = 34
        Me.lblID.Text = "                   "
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdminSaveDonation
        '
        Me.btnAdminSaveDonation.AutoRoundedCorners = True
        Me.btnAdminSaveDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSaveDonation.BorderRadius = 16
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
        Me.btnAdminSaveDonation.Location = New System.Drawing.Point(287, 150)
        Me.btnAdminSaveDonation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminSaveDonation.Name = "btnAdminSaveDonation"
        Me.btnAdminSaveDonation.Size = New System.Drawing.Size(96, 34)
        Me.btnAdminSaveDonation.TabIndex = 13
        Me.btnAdminSaveDonation.Text = "Save"
        '
        'btnAdminCancelDonation
        '
        Me.btnAdminCancelDonation.AutoRoundedCorners = True
        Me.btnAdminCancelDonation.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCancelDonation.BorderRadius = 16
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
        Me.btnAdminCancelDonation.Location = New System.Drawing.Point(389, 150)
        Me.btnAdminCancelDonation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminCancelDonation.Name = "btnAdminCancelDonation"
        Me.btnAdminCancelDonation.Size = New System.Drawing.Size(96, 34)
        Me.btnAdminCancelDonation.TabIndex = 13
        Me.btnAdminCancelDonation.Text = "Clear"
        '
        'txtBeneInfo
        '
        Me.txtBeneInfo.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtBeneInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBeneInfo.DefaultText = ""
        Me.txtBeneInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBeneInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBeneInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBeneInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBeneInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBeneInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBeneInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBeneInfo.Location = New System.Drawing.Point(243, 60)
        Me.txtBeneInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBeneInfo.Name = "txtBeneInfo"
        Me.txtBeneInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBeneInfo.PlaceholderText = ""
        Me.txtBeneInfo.SelectedText = ""
        Me.txtBeneInfo.Size = New System.Drawing.Size(288, 31)
        Me.txtBeneInfo.TabIndex = 4
        '
        'txtBeneName
        '
        Me.txtBeneName.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtBeneName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBeneName.DefaultText = ""
        Me.txtBeneName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBeneName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBeneName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBeneName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBeneName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBeneName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBeneName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBeneName.Location = New System.Drawing.Point(243, 21)
        Me.txtBeneName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBeneName.Name = "txtBeneName"
        Me.txtBeneName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBeneName.PlaceholderText = ""
        Me.txtBeneName.SelectedText = ""
        Me.txtBeneName.Size = New System.Drawing.Size(288, 31)
        Me.txtBeneName.TabIndex = 4
        '
        'lblDonationAmount
        '
        Me.lblDonationAmount.AutoSize = True
        Me.lblDonationAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblDonationAmount.Location = New System.Drawing.Point(17, 71)
        Me.lblDonationAmount.Name = "lblDonationAmount"
        Me.lblDonationAmount.Size = New System.Drawing.Size(201, 20)
        Me.lblDonationAmount.TabIndex = 4
        Me.lblDonationAmount.Text = "Beneficiary Information"
        Me.lblDonationAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpnlCampaignID
        '
        Me.lblpnlCampaignID.AutoSize = True
        Me.lblpnlCampaignID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblpnlCampaignID.Location = New System.Drawing.Point(17, 32)
        Me.lblpnlCampaignID.Name = "lblpnlCampaignID"
        Me.lblpnlCampaignID.Size = New System.Drawing.Size(155, 20)
        Me.lblpnlCampaignID.TabIndex = 4
        Me.lblpnlCampaignID.Text = "Beneficiary Name"
        Me.lblpnlCampaignID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 39)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ADD BENEFICIARY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBeneCampaign
        '
        Me.txtBeneCampaign.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtBeneCampaign.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBeneCampaign.DefaultText = ""
        Me.txtBeneCampaign.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBeneCampaign.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBeneCampaign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBeneCampaign.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBeneCampaign.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBeneCampaign.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBeneCampaign.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBeneCampaign.Location = New System.Drawing.Point(243, 99)
        Me.txtBeneCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBeneCampaign.Name = "txtBeneCampaign"
        Me.txtBeneCampaign.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBeneCampaign.PlaceholderText = ""
        Me.txtBeneCampaign.SelectedText = ""
        Me.txtBeneCampaign.Size = New System.Drawing.Size(288, 31)
        Me.txtBeneCampaign.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(20, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Campaign"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminBene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 651)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnAdminSearchBene)
        Me.Controls.Add(Me.txtAdminSearchBene)
        Me.Controls.Add(Me.dgvAdminBene)
        Me.Controls.Add(Me.pnlDonationEntries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminBene"
        Me.Text = "AdminBene"
        Me.pnlDonationEntries.ResumeLayout(False)
        Me.pnlDonationEntries.PerformLayout()
        CType(Me.dgvAdminBene, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvAdminBene As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAdminSearchBene As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAdminSearchBene As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnAdminSaveDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminCancelDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBeneInfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBeneName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDonationAmount As Label
    Friend WithEvents lblpnlCampaignID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBeneCampaign As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
End Class
