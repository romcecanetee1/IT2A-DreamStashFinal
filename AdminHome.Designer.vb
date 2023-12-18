<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlAdminCampaign = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAdminHome1 = New System.Windows.Forms.Label()
        Me.pnlAdminDonors = New System.Windows.Forms.Panel()
        Me.lblAdminHome2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlAdminDonated = New System.Windows.Forms.Panel()
        Me.lblAdminHome3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdminRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminBene = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminDonationHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminCampaigns = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlHome.SuspendLayout()
        Me.pnlAdminCampaign.SuspendLayout()
        Me.pnlAdminDonors.SuspendLayout()
        Me.pnlAdminDonated.SuspendLayout()
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
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.ControlBoxMin)
        Me.pnlHome.Controls.Add(Me.ControlBoxClose)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(815, 40)
        Me.pnlHome.TabIndex = 0
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(731, 3)
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
        Me.ControlBoxClose.Location = New System.Drawing.Point(775, 3)
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
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlAdminCampaign
        '
        Me.pnlAdminCampaign.BackColor = System.Drawing.Color.DarkMagenta
        Me.pnlAdminCampaign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdminCampaign.Controls.Add(Me.Label2)
        Me.pnlAdminCampaign.Controls.Add(Me.lblAdminHome1)
        Me.pnlAdminCampaign.Location = New System.Drawing.Point(13, 160)
        Me.pnlAdminCampaign.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlAdminCampaign.Name = "pnlAdminCampaign"
        Me.pnlAdminCampaign.Size = New System.Drawing.Size(222, 147)
        Me.pnlAdminCampaign.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Active Campaigns"
        '
        'lblAdminHome1
        '
        Me.lblAdminHome1.AutoSize = True
        Me.lblAdminHome1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblAdminHome1.ForeColor = System.Drawing.Color.White
        Me.lblAdminHome1.Location = New System.Drawing.Point(2, 94)
        Me.lblAdminHome1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdminHome1.Name = "lblAdminHome1"
        Me.lblAdminHome1.Size = New System.Drawing.Size(19, 30)
        Me.lblAdminHome1.TabIndex = 0
        Me.lblAdminHome1.Text = "."
        '
        'pnlAdminDonors
        '
        Me.pnlAdminDonors.BackColor = System.Drawing.Color.MediumVioletRed
        Me.pnlAdminDonors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdminDonors.Controls.Add(Me.lblAdminHome2)
        Me.pnlAdminDonors.Controls.Add(Me.Label3)
        Me.pnlAdminDonors.Location = New System.Drawing.Point(297, 160)
        Me.pnlAdminDonors.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlAdminDonors.Name = "pnlAdminDonors"
        Me.pnlAdminDonors.Size = New System.Drawing.Size(222, 147)
        Me.pnlAdminDonors.TabIndex = 2
        '
        'lblAdminHome2
        '
        Me.lblAdminHome2.AutoSize = True
        Me.lblAdminHome2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblAdminHome2.ForeColor = System.Drawing.Color.White
        Me.lblAdminHome2.Location = New System.Drawing.Point(2, 94)
        Me.lblAdminHome2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdminHome2.Name = "lblAdminHome2"
        Me.lblAdminHome2.Size = New System.Drawing.Size(19, 30)
        Me.lblAdminHome2.TabIndex = 4
        Me.lblAdminHome2.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Donors"
        '
        'pnlAdminDonated
        '
        Me.pnlAdminDonated.BackColor = System.Drawing.Color.MediumOrchid
        Me.pnlAdminDonated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdminDonated.Controls.Add(Me.lblAdminHome3)
        Me.pnlAdminDonated.Controls.Add(Me.Label4)
        Me.pnlAdminDonated.Location = New System.Drawing.Point(582, 160)
        Me.pnlAdminDonated.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlAdminDonated.Name = "pnlAdminDonated"
        Me.pnlAdminDonated.Size = New System.Drawing.Size(222, 147)
        Me.pnlAdminDonated.TabIndex = 3
        '
        'lblAdminHome3
        '
        Me.lblAdminHome3.AutoSize = True
        Me.lblAdminHome3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblAdminHome3.ForeColor = System.Drawing.Color.White
        Me.lblAdminHome3.Location = New System.Drawing.Point(2, 94)
        Me.lblAdminHome3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdminHome3.Name = "lblAdminHome3"
        Me.lblAdminHome3.Size = New System.Drawing.Size(19, 30)
        Me.lblAdminHome3.TabIndex = 5
        Me.lblAdminHome3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Amount Donated"
        '
        'btnAdminRefresh
        '
        Me.btnAdminRefresh.AutoRoundedCorners = True
        Me.btnAdminRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminRefresh.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminRefresh.BorderRadius = 14
        Me.btnAdminRefresh.BorderThickness = 1
        Me.btnAdminRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminRefresh.FillColor = System.Drawing.Color.White
        Me.btnAdminRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnAdminRefresh.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminRefresh.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminRefresh.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminRefresh.Location = New System.Drawing.Point(370, 343)
        Me.btnAdminRefresh.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminRefresh.Name = "btnAdminRefresh"
        Me.btnAdminRefresh.Size = New System.Drawing.Size(93, 31)
        Me.btnAdminRefresh.TabIndex = 15
        Me.btnAdminRefresh.Text = "Refresh"
        '
        'btnAdminUsers
        '
        Me.btnAdminUsers.AutoRoundedCorners = True
        Me.btnAdminUsers.BackColor = System.Drawing.Color.Silver
        Me.btnAdminUsers.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminUsers.BorderRadius = 18
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
        Me.btnAdminUsers.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminUsers.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminUsers.Location = New System.Drawing.Point(20, 479)
        Me.btnAdminUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdminUsers.Name = "btnAdminUsers"
        Me.btnAdminUsers.Size = New System.Drawing.Size(215, 39)
        Me.btnAdminUsers.TabIndex = 16
        Me.btnAdminUsers.Text = "     View Users"
        '
        'btnAdminBene
        '
        Me.btnAdminBene.AutoRoundedCorners = True
        Me.btnAdminBene.BackColor = System.Drawing.Color.Silver
        Me.btnAdminBene.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminBene.BorderRadius = 18
        Me.btnAdminBene.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminBene.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminBene.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminBene.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminBene.ForeColor = System.Drawing.Color.White
        Me.btnAdminBene.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBene.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBene.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminBene.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminBene.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminBene.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminBene.Location = New System.Drawing.Point(319, 479)
        Me.btnAdminBene.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdminBene.Name = "btnAdminBene"
        Me.btnAdminBene.Size = New System.Drawing.Size(200, 39)
        Me.btnAdminBene.TabIndex = 17
        Me.btnAdminBene.Text = "     View Beneficiary"
        '
        'btnAdminDonationHistory
        '
        Me.btnAdminDonationHistory.AutoRoundedCorners = True
        Me.btnAdminDonationHistory.BackColor = System.Drawing.Color.Silver
        Me.btnAdminDonationHistory.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminDonationHistory.BorderRadius = 18
        Me.btnAdminDonationHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonationHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminDonationHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminDonationHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminDonationHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminDonationHistory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminDonationHistory.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationHistory.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationHistory.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationHistory.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationHistory.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminDonationHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminDonationHistory.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminDonationHistory.Location = New System.Drawing.Point(590, 479)
        Me.btnAdminDonationHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdminDonationHistory.Name = "btnAdminDonationHistory"
        Me.btnAdminDonationHistory.Size = New System.Drawing.Size(214, 39)
        Me.btnAdminDonationHistory.TabIndex = 18
        Me.btnAdminDonationHistory.Text = "     View Donation Histoty"
        '
        'btnAdminCampaigns
        '
        Me.btnAdminCampaigns.AutoRoundedCorners = True
        Me.btnAdminCampaigns.BackColor = System.Drawing.Color.Silver
        Me.btnAdminCampaigns.BorderColor = System.Drawing.Color.Transparent
        Me.btnAdminCampaigns.BorderRadius = 18
        Me.btnAdminCampaigns.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCampaigns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminCampaigns.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminCampaigns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminCampaigns.FillColor = System.Drawing.Color.Transparent
        Me.btnAdminCampaigns.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnAdminCampaigns.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampaigns.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampaigns.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampaigns.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampaigns.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminCampaigns.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminCampaigns.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminCampaigns.Location = New System.Drawing.Point(319, 436)
        Me.btnAdminCampaigns.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdminCampaigns.Name = "btnAdminCampaigns"
        Me.btnAdminCampaigns.Size = New System.Drawing.Size(200, 39)
        Me.btnAdminCampaigns.TabIndex = 19
        Me.btnAdminCampaigns.Text = "     View Campaigns"
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(815, 529)
        Me.Controls.Add(Me.btnAdminCampaigns)
        Me.Controls.Add(Me.btnAdminDonationHistory)
        Me.Controls.Add(Me.btnAdminBene)
        Me.Controls.Add(Me.btnAdminUsers)
        Me.Controls.Add(Me.btnAdminRefresh)
        Me.Controls.Add(Me.pnlAdminDonated)
        Me.Controls.Add(Me.pnlAdminDonors)
        Me.Controls.Add(Me.pnlAdminCampaign)
        Me.Controls.Add(Me.pnlHome)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.pnlAdminCampaign.ResumeLayout(False)
        Me.pnlAdminCampaign.PerformLayout()
        Me.pnlAdminDonors.ResumeLayout(False)
        Me.pnlAdminDonors.PerformLayout()
        Me.pnlAdminDonated.ResumeLayout(False)
        Me.pnlAdminDonated.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlAdminDonated As Panel
    Friend WithEvents pnlAdminDonors As Panel
    Friend WithEvents pnlAdminCampaign As Panel
    Friend WithEvents lblAdminHome1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdminHome2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAdminHome3 As Label
    Friend WithEvents btnAdminRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminCampaigns As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminDonationHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminBene As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminUsers As Guna.UI2.WinForms.Guna2Button
End Class
