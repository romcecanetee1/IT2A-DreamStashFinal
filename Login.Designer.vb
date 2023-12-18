<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLoginMessage = New System.Windows.Forms.Label()
        Me.BtnForgotPass = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.CheckBoxPass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
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
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1056, -1)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxClose.TabIndex = 1
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(997, -1)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(51, 31)
        Me.ControlBoxMin.TabIndex = 2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.lblLoginMessage)
        Me.Guna2Panel1.Controls.Add(Me.BtnForgotPass)
        Me.Guna2Panel1.Controls.Add(Me.BtnBack)
        Me.Guna2Panel1.Controls.Add(Me.btnLogin)
        Me.Guna2Panel1.Controls.Add(Me.CheckBoxPass)
        Me.Guna2Panel1.Controls.Add(Me.txtPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtUsername)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(353, 55)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(445, 522)
        Me.Guna2Panel1.TabIndex = 3
        '
        'lblLoginMessage
        '
        Me.lblLoginMessage.AutoSize = True
        Me.lblLoginMessage.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoginMessage.ForeColor = System.Drawing.Color.Red
        Me.lblLoginMessage.Location = New System.Drawing.Point(163, 396)
        Me.lblLoginMessage.Name = "lblLoginMessage"
        Me.lblLoginMessage.Size = New System.Drawing.Size(67, 19)
        Me.lblLoginMessage.TabIndex = 15
        Me.lblLoginMessage.Text = "Message"
        '
        'BtnForgotPass
        '
        Me.BtnForgotPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnForgotPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnForgotPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnForgotPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnForgotPass.FillColor = System.Drawing.Color.Transparent
        Me.BtnForgotPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.BtnForgotPass.ForeColor = System.Drawing.Color.Gray
        Me.BtnForgotPass.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BtnForgotPass.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.BtnForgotPass.HoverState.ForeColor = System.Drawing.Color.DarkViolet
        Me.BtnForgotPass.Location = New System.Drawing.Point(99, 345)
        Me.BtnForgotPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnForgotPass.Name = "BtnForgotPass"
        Me.BtnForgotPass.Size = New System.Drawing.Size(205, 22)
        Me.BtnForgotPass.TabIndex = 5
        Me.BtnForgotPass.Text = "Forgot Password?"
        '
        'BtnBack
        '
        Me.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBack.FillColor = System.Drawing.Color.Transparent
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.BtnBack.ForeColor = System.Drawing.Color.Black
        Me.BtnBack.Image = Global.IT2A_DreamStashTest.My.Resources.Resources.previous_svgrepo_com
        Me.BtnBack.Location = New System.Drawing.Point(3, 482)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(83, 36)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Back"
        '
        'btnLogin
        '
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnLogin.BorderRadius = 23
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(99, 289)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(231, 48)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.CheckedState.BorderColor = System.Drawing.Color.Purple
        Me.CheckBoxPass.CheckedState.BorderRadius = 0
        Me.CheckBoxPass.CheckedState.BorderThickness = 0
        Me.CheckBoxPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.CheckBoxPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxPass.Location = New System.Drawing.Point(99, 252)
        Me.CheckBoxPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(143, 24)
        Me.CheckBoxPass.TabIndex = 3
        Me.CheckBoxPass.Text = "Check Password"
        Me.CheckBoxPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBoxPass.UncheckedState.BorderRadius = 0
        Me.CheckBoxPass.UncheckedState.BorderThickness = 0
        Me.CheckBoxPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Purple
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtPassword.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtPassword.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.password_minimalistic_svgrepo_com
        Me.txtPassword.Location = New System.Drawing.Point(80, 199)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(267, 33)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Purple
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtUsername.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtUsername.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.user_svgrepo_com__4_
        Me.txtUsername.Location = New System.Drawing.Point(80, 159)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(267, 33)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(91, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Welcome back"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1105, 651)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.ControlBoxMin)
        Me.Controls.Add(Me.ControlBoxClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnForgotPass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheckBoxPass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLoginMessage As Label
End Class
