<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssistantAdminDashboard
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAdminDonationHisto = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAssistBene = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAsstAdminUsername = New System.Windows.Forms.Label()
        Me.btnAsstAdminLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminCampaign = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminDonation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAdminFirstLastName = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlAdminDashboard = New Guna.UI2.WinForms.Guna2Panel()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdminDashboard.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnAdminDonationHisto)
        Me.Guna2Panel1.Controls.Add(Me.btnAssistBene)
        Me.Guna2Panel1.Controls.Add(Me.lblAsstAdminUsername)
        Me.Guna2Panel1.Controls.Add(Me.btnAsstAdminLogout)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminCampaign)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminDonation)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminUsers)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminHome)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lblAdminFirstLastName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(285, 638)
        Me.Guna2Panel1.TabIndex = 2
        '
        'btnAdminDonationHisto
        '
        Me.btnAdminDonationHisto.AutoRoundedCorners = True
        Me.btnAdminDonationHisto.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminDonationHisto.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminDonationHisto.BorderRadius = 23
        Me.btnAdminDonationHisto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonationHisto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonationHisto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminDonationHisto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminDonationHisto.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminDonationHisto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminDonationHisto.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationHisto.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationHisto.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationHisto.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationHisto.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.receipt_text_svgrepo_com
        Me.btnAdminDonationHisto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminDonationHisto.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminDonationHisto.Location = New System.Drawing.Point(8, 442)
        Me.btnAdminDonationHisto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdminDonationHisto.Name = "btnAdminDonationHisto"
        Me.btnAdminDonationHisto.Size = New System.Drawing.Size(245, 48)
        Me.btnAdminDonationHisto.TabIndex = 12
        Me.btnAdminDonationHisto.Text = "        Donation History"
        '
        'btnAssistBene
        '
        Me.btnAssistBene.AutoRoundedCorners = True
        Me.btnAssistBene.BackColor = System.Drawing.Color.Transparent
        Me.btnAssistBene.BorderColor = System.Drawing.Color.Transparent
        Me.btnAssistBene.BorderRadius = 26
        Me.btnAssistBene.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistBene.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAssistBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAssistBene.FillColor = System.Drawing.Color.Transparent
        Me.btnAssistBene.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAssistBene.ForeColor = System.Drawing.Color.White
        Me.btnAssistBene.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistBene.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAssistBene.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAssistBene.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAssistBene.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAssistBene.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAssistBene.Location = New System.Drawing.Point(8, 496)
        Me.btnAssistBene.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAssistBene.Name = "btnAssistBene"
        Me.btnAssistBene.Size = New System.Drawing.Size(267, 55)
        Me.btnAssistBene.TabIndex = 11
        Me.btnAssistBene.Text = "          View Beneficiaries"
        '
        'lblAsstAdminUsername
        '
        Me.lblAsstAdminUsername.AutoSize = True
        Me.lblAsstAdminUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblAsstAdminUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAsstAdminUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblAsstAdminUsername.Location = New System.Drawing.Point(179, 12)
        Me.lblAsstAdminUsername.Name = "lblAsstAdminUsername"
        Me.lblAsstAdminUsername.Size = New System.Drawing.Size(96, 20)
        Me.lblAsstAdminUsername.TabIndex = 10
        Me.lblAsstAdminUsername.Text = "UserName"
        Me.lblAsstAdminUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAsstAdminLogout
        '
        Me.btnAsstAdminLogout.AutoRoundedCorners = True
        Me.btnAsstAdminLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnAsstAdminLogout.BorderColor = System.Drawing.Color.Transparent
        Me.btnAsstAdminLogout.BorderRadius = 23
        Me.btnAsstAdminLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAsstAdminLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAsstAdminLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAsstAdminLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAsstAdminLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnAsstAdminLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAsstAdminLogout.ForeColor = System.Drawing.Color.White
        Me.btnAsstAdminLogout.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAsstAdminLogout.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAsstAdminLogout.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAsstAdminLogout.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.logout_2_svgrepo_com
        Me.btnAsstAdminLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAsstAdminLogout.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAsstAdminLogout.Location = New System.Drawing.Point(4, 575)
        Me.btnAsstAdminLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAsstAdminLogout.Name = "btnAsstAdminLogout"
        Me.btnAsstAdminLogout.Size = New System.Drawing.Size(276, 48)
        Me.btnAsstAdminLogout.TabIndex = 7
        Me.btnAsstAdminLogout.Text = "Logout"
        '
        'btnAdminCampaign
        '
        Me.btnAdminCampaign.AutoRoundedCorners = True
        Me.btnAdminCampaign.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminCampaign.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminCampaign.BorderRadius = 26
        Me.btnAdminCampaign.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCampaign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCampaign.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminCampaign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminCampaign.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminCampaign.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminCampaign.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampaign.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampaign.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampaign.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampaign.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.crowdfunding__1_
        Me.btnAdminCampaign.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminCampaign.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminCampaign.Location = New System.Drawing.Point(8, 381)
        Me.btnAdminCampaign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminCampaign.Name = "btnAdminCampaign"
        Me.btnAdminCampaign.Size = New System.Drawing.Size(267, 55)
        Me.btnAdminCampaign.TabIndex = 7
        Me.btnAdminCampaign.Text = "      Campaign Entries"
        '
        'btnAdminDonation
        '
        Me.btnAdminDonation.AutoRoundedCorners = True
        Me.btnAdminDonation.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminDonation.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminDonation.BorderRadius = 26
        Me.btnAdminDonation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminDonation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminDonation.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminDonation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminDonation.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonation.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonation.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonation.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonation.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.donation_svgrepo_com
        Me.btnAdminDonation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminDonation.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminDonation.Location = New System.Drawing.Point(8, 327)
        Me.btnAdminDonation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminDonation.Name = "btnAdminDonation"
        Me.btnAdminDonation.Size = New System.Drawing.Size(267, 55)
        Me.btnAdminDonation.TabIndex = 7
        Me.btnAdminDonation.Text = "        Donation Entries"
        '
        'btnAdminUsers
        '
        Me.btnAdminUsers.AutoRoundedCorners = True
        Me.btnAdminUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminUsers.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminUsers.BorderRadius = 26
        Me.btnAdminUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminUsers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminUsers.ForeColor = System.Drawing.Color.White
        Me.btnAdminUsers.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUsers.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUsers.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminUsers.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.user_group_svgrepo_com__1_
        Me.btnAdminUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminUsers.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminUsers.Location = New System.Drawing.Point(13, 273)
        Me.btnAdminUsers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminUsers.Name = "btnAdminUsers"
        Me.btnAdminUsers.Size = New System.Drawing.Size(267, 55)
        Me.btnAdminUsers.TabIndex = 7
        Me.btnAdminUsers.Text = "Users"
        '
        'btnAdminHome
        '
        Me.btnAdminHome.AutoRoundedCorners = True
        Me.btnAdminHome.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminHome.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminHome.BorderRadius = 26
        Me.btnAdminHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminHome.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminHome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminHome.ForeColor = System.Drawing.Color.White
        Me.btnAdminHome.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminHome.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminHome.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminHome.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.dashboard_svgrepo_com__1_1
        Me.btnAdminHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminHome.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnAdminHome.Location = New System.Drawing.Point(8, 227)
        Me.btnAdminHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminHome.Name = "btnAdminHome"
        Me.btnAdminHome.Size = New System.Drawing.Size(267, 55)
        Me.btnAdminHome.TabIndex = 7
        Me.btnAdminHome.Text = "Home"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Assistant Administrator"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdminFirstLastName
        '
        Me.lblAdminFirstLastName.AutoSize = True
        Me.lblAdminFirstLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminFirstLastName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblAdminFirstLastName.ForeColor = System.Drawing.Color.White
        Me.lblAdminFirstLastName.Location = New System.Drawing.Point(36, 166)
        Me.lblAdminFirstLastName.Name = "lblAdminFirstLastName"
        Me.lblAdminFirstLastName.Size = New System.Drawing.Size(195, 20)
        Me.lblAdminFirstLastName.TabIndex = 4
        Me.lblAdminFirstLastName.Text = "FirstName + LastName"
        Me.lblAdminFirstLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources._3_ctcS1Diu0_transformed
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox2.ErrorImage = Nothing
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.InitialImage = Nothing
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(57, 15)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(160, 148)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 3
        Me.Guna2PictureBox2.TabStop = False
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
        'pnlAdminDashboard
        '
        Me.pnlAdminDashboard.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.pnlAdminDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAdminDashboard.Controls.Add(Me.ControlBoxMin)
        Me.pnlAdminDashboard.Controls.Add(Me.ControlBoxClose)
        Me.pnlAdminDashboard.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAdminDashboard.Location = New System.Drawing.Point(285, 0)
        Me.pnlAdminDashboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlAdminDashboard.Name = "pnlAdminDashboard"
        Me.pnlAdminDashboard.Size = New System.Drawing.Size(1087, 638)
        Me.pnlAdminDashboard.TabIndex = 3
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(1681, 2)
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
        Me.ControlBoxClose.Location = New System.Drawing.Point(1739, 2)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources._3_ctcS1Diu0_transformed
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.ErrorImage = Nothing
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.InitialImage = Nothing
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(377, 150)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(351, 321)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'AssistantAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 638)
        Me.Controls.Add(Me.pnlAdminDashboard)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AssistantAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssistantAdmin"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdminDashboard.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnAsstAdminLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminCampaign As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminDonation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAdminHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdminFirstLastName As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlAdminDashboard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAsstAdminUsername As Label
    Friend WithEvents btnAssistBene As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminDonationHisto As Guna.UI2.WinForms.Guna2Button
End Class
