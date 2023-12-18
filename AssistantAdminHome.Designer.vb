<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssistantAdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssistantAdminHome))
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAsstHome = New System.Windows.Forms.Panel()
        Me.btnAdminCampaigns = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminDonationHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminBene = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdminRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAdminHome3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAdminHome2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminHome1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlHome.SuspendLayout()
        Me.pnlAsstHome.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlHome.Controls.Add(Me.ControlBoxMin)
        Me.pnlHome.Controls.Add(Me.ControlBoxClose)
        Me.pnlHome.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.pnlHome, "pnlHome")
        Me.pnlHome.Name = "pnlHome"
        '
        'Guna2ControlBox1
        '
        resources.ApplyResources(Me.Guna2ControlBox1, "Guna2ControlBox1")
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        '
        'Guna2ControlBox2
        '
        resources.ApplyResources(Me.Guna2ControlBox2, "Guna2ControlBox2")
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        '
        'ControlBoxMin
        '
        resources.ApplyResources(Me.ControlBoxMin, "ControlBoxMin")
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Name = "ControlBoxMin"
        '
        'ControlBoxClose
        '
        resources.ApplyResources(Me.ControlBoxClose, "ControlBoxClose")
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Name = "ControlBoxClose"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'pnlAsstHome
        '
        Me.pnlAsstHome.BackColor = System.Drawing.Color.PowderBlue
        Me.pnlAsstHome.Controls.Add(Me.Guna2Panel1)
        Me.pnlAsstHome.Controls.Add(Me.btnAdminRefresh)
        Me.pnlAsstHome.Controls.Add(Me.Panel3)
        Me.pnlAsstHome.Controls.Add(Me.Panel2)
        Me.pnlAsstHome.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.pnlAsstHome, "pnlAsstHome")
        Me.pnlAsstHome.Name = "pnlAsstHome"
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
        resources.ApplyResources(Me.btnAdminCampaigns, "btnAdminCampaigns")
        Me.btnAdminCampaigns.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampaigns.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampaigns.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminCampaigns.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminCampaigns.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminCampaigns.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminCampaigns.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminCampaigns.Name = "btnAdminCampaigns"
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
        resources.ApplyResources(Me.btnAdminDonationHistory, "btnAdminDonationHistory")
        Me.btnAdminDonationHistory.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationHistory.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationHistory.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminDonationHistory.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminDonationHistory.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminDonationHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminDonationHistory.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminDonationHistory.Name = "btnAdminDonationHistory"
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
        resources.ApplyResources(Me.btnAdminBene, "btnAdminBene")
        Me.btnAdminBene.ForeColor = System.Drawing.Color.White
        Me.btnAdminBene.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBene.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBene.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminBene.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminBene.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminBene.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminBene.Name = "btnAdminBene"
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
        resources.ApplyResources(Me.btnAdminUsers, "btnAdminUsers")
        Me.btnAdminUsers.ForeColor = System.Drawing.Color.White
        Me.btnAdminUsers.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUsers.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUsers.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminUsers.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.group
        Me.btnAdminUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdminUsers.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdminUsers.Name = "btnAdminUsers"
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
        resources.ApplyResources(Me.btnAdminRefresh, "btnAdminRefresh")
        Me.btnAdminRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnAdminRefresh.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminRefresh.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminRefresh.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminRefresh.Name = "btnAdminRefresh"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblAdminHome3)
        Me.Panel3.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'lblAdminHome3
        '
        resources.ApplyResources(Me.lblAdminHome3, "lblAdminHome3")
        Me.lblAdminHome3.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAdminHome3.Name = "lblAdminHome3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Indigo
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Name = "Label4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblAdminHome2)
        Me.Panel2.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'lblAdminHome2
        '
        resources.ApplyResources(Me.lblAdminHome2, "lblAdminHome2")
        Me.lblAdminHome2.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAdminHome2.Name = "lblAdminHome2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Indigo
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Name = "Label3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAdminHome1)
        Me.Panel1.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'lblAdminHome1
        '
        resources.ApplyResources(Me.lblAdminHome1, "lblAdminHome1")
        Me.lblAdminHome1.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAdminHome1.Name = "lblAdminHome1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Indigo
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Name = "Label2"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminCampaigns)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminDonationHistory)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminUsers)
        Me.Guna2Panel1.Controls.Add(Me.btnAdminBene)
        resources.ApplyResources(Me.Guna2Panel1, "Guna2Panel1")
        Me.Guna2Panel1.Name = "Guna2Panel1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'AssistantAdminHome
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAsstHome)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AssistantAdminHome"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.pnlAsstHome.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlAsstHome As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdminRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblAdminHome1 As Label
    Friend WithEvents lblAdminHome2 As Label
    Friend WithEvents lblAdminHome3 As Label
    Friend WithEvents btnAdminCampaigns As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminDonationHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminBene As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdminUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
End Class
