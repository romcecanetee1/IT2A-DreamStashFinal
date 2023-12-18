<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnFPBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFPCurrentPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFPRetypeNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFPNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFPUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.BtnFPBack)
        Me.Guna2Panel1.Controls.Add(Me.btnResetPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtFPCurrentPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtFPRetypeNewPass)
        Me.Guna2Panel1.Controls.Add(Me.txtFPNewPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtFPUsername)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(319, 41)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(445, 522)
        Me.Guna2Panel1.TabIndex = 4
        '
        'BtnFPBack
        '
        Me.BtnFPBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFPBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFPBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFPBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFPBack.FillColor = System.Drawing.Color.Transparent
        Me.BtnFPBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.BtnFPBack.ForeColor = System.Drawing.Color.Black
        Me.BtnFPBack.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.previous_svgrepo_com
        Me.BtnFPBack.Location = New System.Drawing.Point(0, 482)
        Me.BtnFPBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFPBack.Name = "BtnFPBack"
        Me.BtnFPBack.Size = New System.Drawing.Size(84, 36)
        Me.BtnFPBack.TabIndex = 12
        Me.BtnFPBack.Text = "Back"
        '
        'btnResetPassword
        '
        Me.btnResetPassword.AutoRoundedCorners = True
        Me.btnResetPassword.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnResetPassword.BorderRadius = 23
        Me.btnResetPassword.BorderThickness = 1
        Me.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResetPassword.FillColor = System.Drawing.Color.White
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnResetPassword.ForeColor = System.Drawing.Color.Black
        Me.btnResetPassword.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnResetPassword.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnResetPassword.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnResetPassword.Location = New System.Drawing.Point(100, 377)
        Me.btnResetPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(228, 48)
        Me.btnResetPassword.TabIndex = 11
        Me.btnResetPassword.Text = "Reset my Password"
        '
        'txtFPCurrentPassword
        '
        Me.txtFPCurrentPassword.BorderColor = System.Drawing.Color.Purple
        Me.txtFPCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFPCurrentPassword.DefaultText = ""
        Me.txtFPCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFPCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFPCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFPCurrentPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFPCurrentPassword.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtFPCurrentPassword.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtFPCurrentPassword.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.password_minimalistic_svgrepo_com
        Me.txtFPCurrentPassword.Location = New System.Drawing.Point(88, 203)
        Me.txtFPCurrentPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFPCurrentPassword.Name = "txtFPCurrentPassword"
        Me.txtFPCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtFPCurrentPassword.PlaceholderText = "Current Password"
        Me.txtFPCurrentPassword.SelectedText = ""
        Me.txtFPCurrentPassword.Size = New System.Drawing.Size(267, 33)
        Me.txtFPCurrentPassword.TabIndex = 8
        Me.txtFPCurrentPassword.UseSystemPasswordChar = True
        '
        'txtFPRetypeNewPass
        '
        Me.txtFPRetypeNewPass.BorderColor = System.Drawing.Color.Purple
        Me.txtFPRetypeNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFPRetypeNewPass.DefaultText = ""
        Me.txtFPRetypeNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFPRetypeNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFPRetypeNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPRetypeNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPRetypeNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFPRetypeNewPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFPRetypeNewPass.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtFPRetypeNewPass.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtFPRetypeNewPass.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.password_minimalistic_svgrepo_com
        Me.txtFPRetypeNewPass.Location = New System.Drawing.Point(88, 284)
        Me.txtFPRetypeNewPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFPRetypeNewPass.Name = "txtFPRetypeNewPass"
        Me.txtFPRetypeNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtFPRetypeNewPass.PlaceholderText = "Re-type New Password"
        Me.txtFPRetypeNewPass.SelectedText = ""
        Me.txtFPRetypeNewPass.Size = New System.Drawing.Size(267, 33)
        Me.txtFPRetypeNewPass.TabIndex = 8
        Me.txtFPRetypeNewPass.UseSystemPasswordChar = True
        '
        'txtFPNewPassword
        '
        Me.txtFPNewPassword.BorderColor = System.Drawing.Color.Purple
        Me.txtFPNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFPNewPassword.DefaultText = ""
        Me.txtFPNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFPNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFPNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFPNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFPNewPassword.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtFPNewPassword.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtFPNewPassword.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.password_minimalistic_svgrepo_com
        Me.txtFPNewPassword.Location = New System.Drawing.Point(88, 244)
        Me.txtFPNewPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFPNewPassword.Name = "txtFPNewPassword"
        Me.txtFPNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtFPNewPassword.PlaceholderText = "New Password"
        Me.txtFPNewPassword.SelectedText = ""
        Me.txtFPNewPassword.Size = New System.Drawing.Size(267, 33)
        Me.txtFPNewPassword.TabIndex = 8
        Me.txtFPNewPassword.UseSystemPasswordChar = True
        '
        'txtFPUsername
        '
        Me.txtFPUsername.BorderColor = System.Drawing.Color.Purple
        Me.txtFPUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFPUsername.DefaultText = ""
        Me.txtFPUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFPUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFPUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFPUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFPUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFPUsername.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtFPUsername.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtFPUsername.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.user_svgrepo_com__4_
        Me.txtFPUsername.Location = New System.Drawing.Point(88, 162)
        Me.txtFPUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFPUsername.Name = "txtFPUsername"
        Me.txtFPUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFPUsername.PlaceholderText = "Username"
        Me.txtFPUsername.SelectedText = ""
        Me.txtFPUsername.Size = New System.Drawing.Size(267, 33)
        Me.txtFPUsername.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(88, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 43)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Change Password"
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 603)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassword"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnForgotPass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnFPBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheckBoxPass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtFPNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFPUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFPCurrentPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFPRetypeNewPass As Guna.UI2.WinForms.Guna2TextBox
End Class
