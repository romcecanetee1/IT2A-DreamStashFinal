<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.BtnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPasswordReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsernameReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxSection = New System.Windows.Forms.ComboBox()
        Me.cbxYearLevel = New System.Windows.Forms.ComboBox()
        Me.CbxCourse = New System.Windows.Forms.ComboBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
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
        Me.Guna2Panel1.Controls.Add(Me.BtnBack)
        Me.Guna2Panel1.Controls.Add(Me.btnRegister)
        Me.Guna2Panel1.Controls.Add(Me.txtPasswordReg)
        Me.Guna2Panel1.Controls.Add(Me.txtUsernameReg)
        Me.Guna2Panel1.Controls.Add(Me.cbxSection)
        Me.Guna2Panel1.Controls.Add(Me.cbxYearLevel)
        Me.Guna2Panel1.Controls.Add(Me.CbxCourse)
        Me.Guna2Panel1.Controls.Add(Me.cbxDepartment)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtLastName)
        Me.Guna2Panel1.Controls.Add(Me.txtFirstName)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(133, 47)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(755, 537)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.BtnBack.Location = New System.Drawing.Point(0, 497)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(84, 36)
        Me.BtnBack.TabIndex = 13
        Me.BtnBack.Text = "Back"
        '
        'btnRegister
        '
        Me.btnRegister.AutoRoundedCorners = True
        Me.btnRegister.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnRegister.BorderRadius = 23
        Me.btnRegister.BorderThickness = 1
        Me.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegister.FillColor = System.Drawing.Color.White
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnRegister.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnRegister.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(244, 415)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(228, 48)
        Me.btnRegister.TabIndex = 12
        Me.btnRegister.Text = "Register"
        '
        'txtPasswordReg
        '
        Me.txtPasswordReg.BorderColor = System.Drawing.Color.Purple
        Me.txtPasswordReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordReg.DefaultText = ""
        Me.txtPasswordReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPasswordReg.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtPasswordReg.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtPasswordReg.Location = New System.Drawing.Point(403, 352)
        Me.txtPasswordReg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPasswordReg.Name = "txtPasswordReg"
        Me.txtPasswordReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordReg.PlaceholderText = "Password"
        Me.txtPasswordReg.SelectedText = ""
        Me.txtPasswordReg.Size = New System.Drawing.Size(267, 33)
        Me.txtPasswordReg.TabIndex = 5
        Me.txtPasswordReg.UseSystemPasswordChar = True
        '
        'txtUsernameReg
        '
        Me.txtUsernameReg.BorderColor = System.Drawing.Color.Purple
        Me.txtUsernameReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameReg.DefaultText = ""
        Me.txtUsernameReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsernameReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsernameReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsernameReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsernameReg.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtUsernameReg.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtUsernameReg.Location = New System.Drawing.Point(39, 352)
        Me.txtUsernameReg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsernameReg.Name = "txtUsernameReg"
        Me.txtUsernameReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameReg.PlaceholderText = "Username"
        Me.txtUsernameReg.SelectedText = ""
        Me.txtUsernameReg.Size = New System.Drawing.Size(267, 33)
        Me.txtUsernameReg.TabIndex = 5
        '
        'cbxSection
        '
        Me.cbxSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxSection.FormattingEnabled = True
        Me.cbxSection.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "PACED"})
        Me.cbxSection.Location = New System.Drawing.Point(521, 229)
        Me.cbxSection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSection.Name = "cbxSection"
        Me.cbxSection.Size = New System.Drawing.Size(135, 25)
        Me.cbxSection.TabIndex = 5
        '
        'cbxYearLevel
        '
        Me.cbxYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxYearLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxYearLevel.FormattingEnabled = True
        Me.cbxYearLevel.Items.AddRange(New Object() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR", "6TH YEAR"})
        Me.cbxYearLevel.Location = New System.Drawing.Point(303, 229)
        Me.cbxYearLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxYearLevel.Name = "cbxYearLevel"
        Me.cbxYearLevel.Size = New System.Drawing.Size(135, 25)
        Me.cbxYearLevel.TabIndex = 4
        '
        'CbxCourse
        '
        Me.CbxCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.CbxCourse.FormattingEnabled = True
        Me.CbxCourse.ItemHeight = 16
        Me.CbxCourse.Items.AddRange(New Object() {"PSYCHOLOGY", "POLITICAL SCIENCE", "ACCOUNTANCY", "BUSINESS ADMINISTRATION", "COMPUTER ENGINEERING", "COMPUTER SCIENCE", "INFORMATION TECHNOLOGY", "ELEMENTARY EDUCATION", "SECONDARY EDUCATION", "NURSING", "HOTEL AND RESTAURANT MANAGEMENT", "TOURISM", "MARINE TRANSPORTATION", "MARINE ENGINEERING", "MECHANICAL ENGINEERING"})
        Me.CbxCourse.Location = New System.Drawing.Point(40, 295)
        Me.CbxCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbxCourse.Name = "CbxCourse"
        Me.CbxCourse.Size = New System.Drawing.Size(264, 24)
        Me.CbxCourse.TabIndex = 4
        '
        'cbxDepartment
        '
        Me.cbxDepartment.AccessibleName = ""
        Me.cbxDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.IntegralHeight = False
        Me.cbxDepartment.Items.AddRange(New Object() {"CAS", "COA", "CBA", "CCS", "COED", "CHS", "CHMT", "CME", "SME", "SOP", "COD"})
        Me.cbxDepartment.Location = New System.Drawing.Point(40, 229)
        Me.cbxDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(137, 25)
        Me.cbxDepartment.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(517, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(299, 208)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(36, 274)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(36, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Department"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.Purple
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtLastName.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtLastName.Location = New System.Drawing.Point(403, 138)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = "Last Name"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(267, 33)
        Me.txtLastName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.Purple
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtFirstName.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtFirstName.Location = New System.Drawing.Point(39, 138)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = "First Name"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(267, 33)
        Me.txtFirstName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(160, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Create your account"
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
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(52, 31)
        Me.ControlBoxMin.TabIndex = 4
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1016, 0)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(52, 31)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 622)
        Me.Controls.Add(Me.ControlBoxMin)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.ControlBoxClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxSection As ComboBox
    Friend WithEvents cbxYearLevel As ComboBox
    Friend WithEvents CbxCourse As ComboBox
    Friend WithEvents cbxDepartment As ComboBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtPasswordReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsernameReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2Button
End Class
