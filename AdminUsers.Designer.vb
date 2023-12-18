<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsers
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlUsers = New Guna.UI2.WinForms.Guna2Panel()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdminSearchUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAdminSearchUsers = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdminEditUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvAdminUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlUsers.SuspendLayout()
        CType(Me.dgvAdminUsers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Elipse1.BorderRadius = 20
        '
        'pnlUsers
        '
        Me.pnlUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlUsers.Controls.Add(Me.ControlBoxMin)
        Me.pnlUsers.Controls.Add(Me.ControlBoxClose)
        Me.pnlUsers.Controls.Add(Me.Label1)
        Me.pnlUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(1087, 49)
        Me.pnlUsers.TabIndex = 1
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(971, 10)
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
        Me.ControlBoxClose.Location = New System.Drawing.Point(1031, 10)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(52, 31)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Users"
        '
        'btnAdminSearchUsers
        '
        Me.btnAdminSearchUsers.AutoRoundedCorners = True
        Me.btnAdminSearchUsers.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchUsers.BorderRadius = 14
        Me.btnAdminSearchUsers.BorderThickness = 1
        Me.btnAdminSearchUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSearchUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSearchUsers.FillColor = System.Drawing.Color.White
        Me.btnAdminSearchUsers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSearchUsers.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSearchUsers.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchUsers.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchUsers.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSearchUsers.Location = New System.Drawing.Point(264, 132)
        Me.btnAdminSearchUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdminSearchUsers.Name = "btnAdminSearchUsers"
        Me.btnAdminSearchUsers.Size = New System.Drawing.Size(172, 30)
        Me.btnAdminSearchUsers.TabIndex = 14
        Me.btnAdminSearchUsers.Text = "Search/Filter"
        '
        'txtAdminSearchUsers
        '
        Me.txtAdminSearchUsers.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminSearchUsers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminSearchUsers.DefaultText = ""
        Me.txtAdminSearchUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminSearchUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminSearchUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminSearchUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminSearchUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminSearchUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminSearchUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminSearchUsers.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtAdminSearchUsers.Location = New System.Drawing.Point(16, 132)
        Me.txtAdminSearchUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdminSearchUsers.Name = "txtAdminSearchUsers"
        Me.txtAdminSearchUsers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminSearchUsers.PlaceholderText = "Search"
        Me.txtAdminSearchUsers.SelectedText = ""
        Me.txtAdminSearchUsers.Size = New System.Drawing.Size(240, 30)
        Me.txtAdminSearchUsers.TabIndex = 13
        '
        'btnAdminEditUsers
        '
        Me.btnAdminEditUsers.AutoRoundedCorners = True
        Me.btnAdminEditUsers.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminEditUsers.BorderRadius = 14
        Me.btnAdminEditUsers.BorderThickness = 1
        Me.btnAdminEditUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminEditUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminEditUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminEditUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminEditUsers.Enabled = False
        Me.btnAdminEditUsers.FillColor = System.Drawing.Color.White
        Me.btnAdminEditUsers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminEditUsers.ForeColor = System.Drawing.Color.Black
        Me.btnAdminEditUsers.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminEditUsers.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminEditUsers.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminEditUsers.Location = New System.Drawing.Point(783, 132)
        Me.btnAdminEditUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdminEditUsers.Name = "btnAdminEditUsers"
        Me.btnAdminEditUsers.Size = New System.Drawing.Size(140, 30)
        Me.btnAdminEditUsers.TabIndex = 14
        Me.btnAdminEditUsers.Text = "Edit"
        '
        'dgvAdminUsers
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAdminUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdminUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvAdminUsers.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAdminUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdminUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAdminUsers.ColumnHeadersHeight = 17
        Me.dgvAdminUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdminUsers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdminUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminUsers.Location = New System.Drawing.Point(16, 169)
        Me.dgvAdminUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvAdminUsers.MultiSelect = False
        Me.dgvAdminUsers.Name = "dgvAdminUsers"
        Me.dgvAdminUsers.ReadOnly = True
        Me.dgvAdminUsers.RowHeadersVisible = False
        Me.dgvAdminUsers.RowHeadersWidth = 51
        Me.dgvAdminUsers.RowTemplate.Height = 25
        Me.dgvAdminUsers.Size = New System.Drawing.Size(1055, 468)
        Me.dgvAdminUsers.TabIndex = 15
        Me.dgvAdminUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAdminUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAdminUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAdminUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAdminUsers.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvAdminUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAdminUsers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAdminUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAdminUsers.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvAdminUsers.ThemeStyle.ReadOnly = True
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.Height = 25
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAdminUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAddUser
        '
        Me.btnAddUser.AutoRoundedCorners = True
        Me.btnAddUser.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAddUser.BorderRadius = 14
        Me.btnAddUser.BorderThickness = 1
        Me.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddUser.FillColor = System.Drawing.Color.White
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddUser.ForeColor = System.Drawing.Color.Black
        Me.btnAddUser.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAddUser.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAddUser.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(635, 132)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(140, 30)
        Me.btnAddUser.TabIndex = 16
        Me.btnAddUser.Text = "Add User"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(13, 87)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(57, 20)
        Me.lblID.TabIndex = 5
        Me.lblID.Text = "Users"
        '
        'btndelete
        '
        Me.btndelete.AutoRoundedCorners = True
        Me.btndelete.BorderColor = System.Drawing.Color.DarkViolet
        Me.btndelete.BorderRadius = 14
        Me.btndelete.BorderThickness = 1
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.Enabled = False
        Me.btndelete.FillColor = System.Drawing.Color.White
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btndelete.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btndelete.HoverState.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(931, 132)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(140, 30)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "Delete"
        '
        'AdminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 651)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.dgvAdminUsers)
        Me.Controls.Add(Me.btnAdminEditUsers)
        Me.Controls.Add(Me.btnAdminSearchUsers)
        Me.Controls.Add(Me.txtAdminSearchUsers)
        Me.Controls.Add(Me.pnlUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminUsers"
        Me.Text = "AdminUsers"
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsers.PerformLayout()
        CType(Me.dgvAdminUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlUsers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdminSearchUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAdminSearchUsers As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdminEditUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvAdminUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnAddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblID As Label
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
End Class
