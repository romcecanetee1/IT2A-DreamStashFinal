<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAddUser
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAdminPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxAdminSection = New System.Windows.Forms.ComboBox()
        Me.cbxAdminYearLevel = New System.Windows.Forms.ComboBox()
        Me.CbxAdminCourse = New System.Windows.Forms.ComboBox()
        Me.cbxAdminDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdminLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DarkViolet
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.btnAddAdmin)
        Me.Guna2Panel1.Controls.Add(Me.BtnBack)
        Me.Guna2Panel1.Controls.Add(Me.txtAdminPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtAdminUsername)
        Me.Guna2Panel1.Controls.Add(Me.cbxAdminSection)
        Me.Guna2Panel1.Controls.Add(Me.cbxAdminYearLevel)
        Me.Guna2Panel1.Controls.Add(Me.CbxAdminCourse)
        Me.Guna2Panel1.Controls.Add(Me.cbxAdminDepartment)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtAdminLastName)
        Me.Guna2Panel1.Controls.Add(Me.txtAdminFirstName)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(118, 34)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(566, 436)
        Me.Guna2Panel1.TabIndex = 2
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.AutoRoundedCorners = True
        Me.btnAddAdmin.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAddAdmin.BorderRadius = 11
        Me.btnAddAdmin.BorderThickness = 1
        Me.btnAddAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddAdmin.FillColor = System.Drawing.Color.White
        Me.btnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.Black
        Me.btnAddAdmin.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAddAdmin.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAddAdmin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAddAdmin.Location = New System.Drawing.Point(197, 285)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(62, 24)
        Me.btnAddAdmin.TabIndex = 61
        Me.btnAddAdmin.Text = "Add"
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
        Me.BtnBack.Location = New System.Drawing.Point(3, 346)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(63, 29)
        Me.BtnBack.TabIndex = 60
        Me.BtnBack.Text = "Back"
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.BorderColor = System.Drawing.Color.Purple
        Me.txtAdminPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminPassword.DefaultText = ""
        Me.txtAdminPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminPassword.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminPassword.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtAdminPassword.Location = New System.Drawing.Point(249, 191)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtAdminPassword.PlaceholderText = "Password"
        Me.txtAdminPassword.SelectedText = ""
        Me.txtAdminPassword.Size = New System.Drawing.Size(171, 23)
        Me.txtAdminPassword.TabIndex = 58
        Me.txtAdminPassword.UseSystemPasswordChar = True
        '
        'txtAdminUsername
        '
        Me.txtAdminUsername.BorderColor = System.Drawing.Color.Purple
        Me.txtAdminUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminUsername.DefaultText = ""
        Me.txtAdminUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminUsername.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminUsername.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtAdminUsername.Location = New System.Drawing.Point(43, 191)
        Me.txtAdminUsername.Name = "txtAdminUsername"
        Me.txtAdminUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminUsername.PlaceholderText = "Username"
        Me.txtAdminUsername.SelectedText = ""
        Me.txtAdminUsername.Size = New System.Drawing.Size(171, 23)
        Me.txtAdminUsername.TabIndex = 59
        '
        'cbxAdminSection
        '
        Me.cbxAdminSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAdminSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAdminSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxAdminSection.FormattingEnabled = True
        Me.cbxAdminSection.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "PACED"})
        Me.cbxAdminSection.Location = New System.Drawing.Point(355, 101)
        Me.cbxAdminSection.Name = "cbxAdminSection"
        Me.cbxAdminSection.Size = New System.Drawing.Size(102, 22)
        Me.cbxAdminSection.TabIndex = 53
        '
        'cbxAdminYearLevel
        '
        Me.cbxAdminYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAdminYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAdminYearLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxAdminYearLevel.FormattingEnabled = True
        Me.cbxAdminYearLevel.Items.AddRange(New Object() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR", "5TH YEAR", "6TH YEAR"})
        Me.cbxAdminYearLevel.Location = New System.Drawing.Point(249, 101)
        Me.cbxAdminYearLevel.Name = "cbxAdminYearLevel"
        Me.cbxAdminYearLevel.Size = New System.Drawing.Size(102, 22)
        Me.cbxAdminYearLevel.TabIndex = 54
        '
        'CbxAdminCourse
        '
        Me.CbxAdminCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxAdminCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxAdminCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.CbxAdminCourse.FormattingEnabled = True
        Me.CbxAdminCourse.ItemHeight = 12
        Me.CbxAdminCourse.Items.AddRange(New Object() {"PSYCHOLOGY", "POLITICAL SCIENCE", "ACCOUNTANCY", "BUSINESS ADMINISTRATION", "COMPUTER ENGINEERING", "COMPUTER SCIENCE", "INFORMATION TECHNOLOGY", "ELEMENTARY EDUCATION", "SECONDARY EDUCATION", "NURSING", "HOTEL AND RESTAURANT MANAGEMENT", "TOURISM", "MARINE TRANSPORTATION", "MARINE ENGINEERING", "MECHANICAL ENGINEERING"})
        Me.CbxAdminCourse.Location = New System.Drawing.Point(51, 146)
        Me.CbxAdminCourse.Name = "CbxAdminCourse"
        Me.CbxAdminCourse.Size = New System.Drawing.Size(199, 20)
        Me.CbxAdminCourse.TabIndex = 55
        '
        'cbxAdminDepartment
        '
        Me.cbxAdminDepartment.AccessibleName = ""
        Me.cbxAdminDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAdminDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAdminDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.cbxAdminDepartment.FormattingEnabled = True
        Me.cbxAdminDepartment.IntegralHeight = False
        Me.cbxAdminDepartment.Items.AddRange(New Object() {"CAS", "COA", "CBA", "CCS", "COED", "CHS", "CHMT", "CME", "SME", "SOP", "COD"})
        Me.cbxAdminDepartment.Location = New System.Drawing.Point(51, 101)
        Me.cbxAdminDepartment.Name = "cbxAdminDepartment"
        Me.cbxAdminDepartment.Size = New System.Drawing.Size(104, 22)
        Me.cbxAdminDepartment.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(355, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 14)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(249, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Year Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(51, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(51, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 14)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Department"
        '
        'txtAdminLastName
        '
        Me.txtAdminLastName.BorderColor = System.Drawing.Color.Purple
        Me.txtAdminLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminLastName.DefaultText = ""
        Me.txtAdminLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminLastName.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminLastName.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtAdminLastName.Location = New System.Drawing.Point(249, 55)
        Me.txtAdminLastName.Name = "txtAdminLastName"
        Me.txtAdminLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminLastName.PlaceholderText = "Last Name"
        Me.txtAdminLastName.SelectedText = ""
        Me.txtAdminLastName.Size = New System.Drawing.Size(171, 23)
        Me.txtAdminLastName.TabIndex = 47
        '
        'txtAdminFirstName
        '
        Me.txtAdminFirstName.BorderColor = System.Drawing.Color.Purple
        Me.txtAdminFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminFirstName.DefaultText = ""
        Me.txtAdminFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminFirstName.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminFirstName.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.txtAdminFirstName.Location = New System.Drawing.Point(51, 55)
        Me.txtAdminFirstName.Name = "txtAdminFirstName"
        Me.txtAdminFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminFirstName.PlaceholderText = "First Name"
        Me.txtAdminFirstName.SelectedText = ""
        Me.txtAdminFirstName.Size = New System.Drawing.Size(171, 23)
        Me.txtAdminFirstName.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(189, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 32)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Add User"
        '
        'AdminAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 504)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminAddUser"
        Me.Text = "AdminUserAdd"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAdminPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdminUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxAdminSection As ComboBox
    Friend WithEvents cbxAdminYearLevel As ComboBox
    Friend WithEvents CbxAdminCourse As ComboBox
    Friend WithEvents cbxAdminDepartment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdminLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdminFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
