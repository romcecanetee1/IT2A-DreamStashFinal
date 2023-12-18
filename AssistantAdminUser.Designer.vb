<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssistantAdminUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssistantAdminUser))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlUsers = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAssistantAdminUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAssistantAdminSearchUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAssistantAdminSearchUsers = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlUsers.SuspendLayout()
        CType(Me.dgvAssistantAdminUsers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlUsers
        '
        Me.pnlUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlUsers.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlUsers.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlUsers.Controls.Add(Me.ControlBoxMin)
        Me.pnlUsers.Controls.Add(Me.ControlBoxClose)
        Me.pnlUsers.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.pnlUsers, "pnlUsers")
        Me.pnlUsers.Name = "pnlUsers"
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
        'dgvAssistantAdminUsers
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAssistantAdminUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAssistantAdminUsers.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAssistantAdminUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssistantAdminUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.dgvAssistantAdminUsers, "dgvAssistantAdminUsers")
        Me.dgvAssistantAdminUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssistantAdminUsers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAssistantAdminUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantAdminUsers.Name = "dgvAssistantAdminUsers"
        Me.dgvAssistantAdminUsers.RowHeadersVisible = False
        Me.dgvAssistantAdminUsers.RowTemplate.Height = 25
        Me.dgvAssistantAdminUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssistantAdminUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAssistantAdminUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAssistantAdminUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAssistantAdminUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAssistantAdminUsers.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvAssistantAdminUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantAdminUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantAdminUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAssistantAdminUsers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAssistantAdminUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAssistantAdminUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAssistantAdminUsers.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvAssistantAdminUsers.ThemeStyle.ReadOnly = False
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.Height = 25
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAssistantAdminUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAssistantAdminSearchUsers
        '
        Me.btnAssistantAdminSearchUsers.AutoRoundedCorners = True
        Me.btnAssistantAdminSearchUsers.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantAdminSearchUsers.BorderRadius = 14
        Me.btnAssistantAdminSearchUsers.BorderThickness = 1
        Me.btnAssistantAdminSearchUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantAdminSearchUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAssistantAdminSearchUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAssistantAdminSearchUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAssistantAdminSearchUsers.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnAssistantAdminSearchUsers, "btnAssistantAdminSearchUsers")
        Me.btnAssistantAdminSearchUsers.ForeColor = System.Drawing.Color.Black
        Me.btnAssistantAdminSearchUsers.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantAdminSearchUsers.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAssistantAdminSearchUsers.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAssistantAdminSearchUsers.Name = "btnAssistantAdminSearchUsers"
        '
        'txtAssistantAdminSearchUsers
        '
        Me.txtAssistantAdminSearchUsers.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAssistantAdminSearchUsers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssistantAdminSearchUsers.DefaultText = ""
        Me.txtAssistantAdminSearchUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAssistantAdminSearchUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAssistantAdminSearchUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssistantAdminSearchUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssistantAdminSearchUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.txtAssistantAdminSearchUsers, "txtAssistantAdminSearchUsers")
        Me.txtAssistantAdminSearchUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssistantAdminSearchUsers.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtAssistantAdminSearchUsers.Name = "txtAssistantAdminSearchUsers"
        Me.txtAssistantAdminSearchUsers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssistantAdminSearchUsers.PlaceholderText = "Search"
        Me.txtAssistantAdminSearchUsers.SelectedText = ""
        '
        'AssistantAdminUser
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvAssistantAdminUsers)
        Me.Controls.Add(Me.btnAssistantAdminSearchUsers)
        Me.Controls.Add(Me.txtAssistantAdminSearchUsers)
        Me.Controls.Add(Me.pnlUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AssistantAdminUser"
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsers.PerformLayout()
        CType(Me.dgvAssistantAdminUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlUsers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAssistantAdminUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAssistantAdminSearchUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAssistantAdminSearchUsers As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
End Class
