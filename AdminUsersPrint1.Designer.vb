<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsersPrint1
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewerUsers = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnAdminUserLoadReport = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCRAdminUserReport = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxUsersSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpUsersDateRegistered = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpUsersDateRegisteredEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.pnlHome.SuspendLayout()
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
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlHome.Controls.Add(Me.ControlBoxMin)
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlHome.Controls.Add(Me.ControlBoxClose)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1168, 42)
        Me.pnlHome.TabIndex = 66
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1059, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(51, 31)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(1760, 4)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1117, 0)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(51, 31)
        Me.Guna2ControlBox2.TabIndex = 17
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1819, 4)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Users Report"
        '
        'CrystalReportViewerUsers
        '
        Me.CrystalReportViewerUsers.ActiveViewIndex = -1
        Me.CrystalReportViewerUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerUsers.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerUsers.Location = New System.Drawing.Point(17, 170)
        Me.CrystalReportViewerUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CrystalReportViewerUsers.Name = "CrystalReportViewerUsers"
        Me.CrystalReportViewerUsers.Size = New System.Drawing.Size(1135, 557)
        Me.CrystalReportViewerUsers.TabIndex = 67
        Me.CrystalReportViewerUsers.ToolPanelWidth = 267
        '
        'btnAdminUserLoadReport
        '
        Me.btnAdminUserLoadReport.AutoRoundedCorners = True
        Me.btnAdminUserLoadReport.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminUserLoadReport.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUserLoadReport.BorderRadius = 18
        Me.btnAdminUserLoadReport.BorderThickness = 1
        Me.btnAdminUserLoadReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUserLoadReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminUserLoadReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminUserLoadReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminUserLoadReport.FillColor = System.Drawing.Color.White
        Me.btnAdminUserLoadReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminUserLoadReport.ForeColor = System.Drawing.Color.Black
        Me.btnAdminUserLoadReport.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUserLoadReport.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminUserLoadReport.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminUserLoadReport.Location = New System.Drawing.Point(881, 102)
        Me.btnAdminUserLoadReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminUserLoadReport.Name = "btnAdminUserLoadReport"
        Me.btnAdminUserLoadReport.Size = New System.Drawing.Size(147, 38)
        Me.btnAdminUserLoadReport.TabIndex = 72
        Me.btnAdminUserLoadReport.Text = "Load Report"
        '
        'txtCRAdminUserReport
        '
        Me.txtCRAdminUserReport.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtCRAdminUserReport.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCRAdminUserReport.DefaultText = ""
        Me.txtCRAdminUserReport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCRAdminUserReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCRAdminUserReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminUserReport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminUserReport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminUserReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCRAdminUserReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminUserReport.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtCRAdminUserReport.Location = New System.Drawing.Point(581, 102)
        Me.txtCRAdminUserReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCRAdminUserReport.Name = "txtCRAdminUserReport"
        Me.txtCRAdminUserReport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCRAdminUserReport.PlaceholderText = "Search"
        Me.txtCRAdminUserReport.SelectedText = ""
        Me.txtCRAdminUserReport.Size = New System.Drawing.Size(293, 30)
        Me.txtCRAdminUserReport.TabIndex = 71
        '
        'cbxUsersSearch
        '
        Me.cbxUsersSearch.AutoSize = True
        Me.cbxUsersSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxUsersSearch.CheckedState.BorderRadius = 0
        Me.cbxUsersSearch.CheckedState.BorderThickness = 0
        Me.cbxUsersSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxUsersSearch.Location = New System.Drawing.Point(581, 73)
        Me.cbxUsersSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxUsersSearch.Name = "cbxUsersSearch"
        Me.cbxUsersSearch.Size = New System.Drawing.Size(163, 21)
        Me.cbxUsersSearch.TabIndex = 81
        Me.cbxUsersSearch.Text = "Use Advance Search"
        Me.cbxUsersSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxUsersSearch.UncheckedState.BorderRadius = 0
        Me.cbxUsersSearch.UncheckedState.BorderThickness = 0
        Me.cbxUsersSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Date Registered:"
        '
        'dtpUsersDateRegistered
        '
        Me.dtpUsersDateRegistered.Checked = True
        Me.dtpUsersDateRegistered.FillColor = System.Drawing.Color.Purple
        Me.dtpUsersDateRegistered.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpUsersDateRegistered.ForeColor = System.Drawing.Color.White
        Me.dtpUsersDateRegistered.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpUsersDateRegistered.Location = New System.Drawing.Point(141, 85)
        Me.dtpUsersDateRegistered.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpUsersDateRegistered.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpUsersDateRegistered.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpUsersDateRegistered.Name = "dtpUsersDateRegistered"
        Me.dtpUsersDateRegistered.Size = New System.Drawing.Size(293, 31)
        Me.dtpUsersDateRegistered.TabIndex = 77
        Me.dtpUsersDateRegistered.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'dtpUsersDateRegisteredEnd
        '
        Me.dtpUsersDateRegisteredEnd.Checked = True
        Me.dtpUsersDateRegisteredEnd.FillColor = System.Drawing.Color.Purple
        Me.dtpUsersDateRegisteredEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpUsersDateRegisteredEnd.ForeColor = System.Drawing.Color.White
        Me.dtpUsersDateRegisteredEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpUsersDateRegisteredEnd.Location = New System.Drawing.Point(141, 120)
        Me.dtpUsersDateRegisteredEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpUsersDateRegisteredEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpUsersDateRegisteredEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpUsersDateRegisteredEnd.Name = "dtpUsersDateRegisteredEnd"
        Me.dtpUsersDateRegisteredEnd.Size = New System.Drawing.Size(293, 31)
        Me.dtpUsersDateRegisteredEnd.TabIndex = 77
        Me.dtpUsersDateRegisteredEnd.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        '
        'AdminUsersPrint1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 768)
        Me.Controls.Add(Me.cbxUsersSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpUsersDateRegisteredEnd)
        Me.Controls.Add(Me.dtpUsersDateRegistered)
        Me.Controls.Add(Me.btnAdminUserLoadReport)
        Me.Controls.Add(Me.txtCRAdminUserReport)
        Me.Controls.Add(Me.CrystalReportViewerUsers)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminUsersPrint1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminUsersPrint1"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CrystalReportViewerUsers As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnAdminUserLoadReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCRAdminUserReport As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxUsersSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpUsersDateRegistered As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpUsersDateRegisteredEnd As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
