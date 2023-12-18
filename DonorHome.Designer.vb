<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonorHome
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlDonorHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDonorHomeSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.txtDonorSearchHome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvDonorCampaign = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlAdminCampaign = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAdminHome1 = New System.Windows.Forms.Label()
        Me.pnlDonorHome.SuspendLayout()
        CType(Me.dgvDonorCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdminCampaign.SuspendLayout()
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
        'pnlDonorHome
        '
        Me.pnlDonorHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.pnlDonorHome.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlDonorHome.Controls.Add(Me.ControlBoxMin)
        Me.pnlDonorHome.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlDonorHome.Controls.Add(Me.ControlBoxClose)
        Me.pnlDonorHome.Controls.Add(Me.Label1)
        Me.pnlDonorHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDonorHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlDonorHome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDonorHome.Name = "pnlDonorHome"
        Me.pnlDonorHome.Size = New System.Drawing.Size(1087, 43)
        Me.pnlDonorHome.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(975, 1)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(52, 31)
        Me.Guna2ControlBox1.TabIndex = 17
        '
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(1677, 4)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(52, 31)
        Me.ControlBoxMin.TabIndex = 4
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1032, 1)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(52, 31)
        Me.Guna2ControlBox2.TabIndex = 16
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1735, 4)
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
        Me.Label1.Text = "Home"
        '
        'btnDonorHomeSearch
        '
        Me.btnDonorHomeSearch.AutoRoundedCorners = True
        Me.btnDonorHomeSearch.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnDonorHomeSearch.BorderRadius = 14
        Me.btnDonorHomeSearch.BorderThickness = 1
        Me.btnDonorHomeSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDonorHomeSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDonorHomeSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDonorHomeSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDonorHomeSearch.FillColor = System.Drawing.Color.White
        Me.btnDonorHomeSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDonorHomeSearch.ForeColor = System.Drawing.Color.Black
        Me.btnDonorHomeSearch.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnDonorHomeSearch.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnDonorHomeSearch.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnDonorHomeSearch.Location = New System.Drawing.Point(313, 286)
        Me.btnDonorHomeSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDonorHomeSearch.Name = "btnDonorHomeSearch"
        Me.btnDonorHomeSearch.Size = New System.Drawing.Size(169, 30)
        Me.btnDonorHomeSearch.TabIndex = 14
        Me.btnDonorHomeSearch.Text = "Search/Filter"
        '
        'txtDonorSearchHome
        '
        Me.txtDonorSearchHome.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtDonorSearchHome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDonorSearchHome.DefaultText = ""
        Me.txtDonorSearchHome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDonorSearchHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDonorSearchHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDonorSearchHome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDonorSearchHome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDonorSearchHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDonorSearchHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDonorSearchHome.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtDonorSearchHome.Location = New System.Drawing.Point(17, 286)
        Me.txtDonorSearchHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDonorSearchHome.Name = "txtDonorSearchHome"
        Me.txtDonorSearchHome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDonorSearchHome.PlaceholderText = "Search"
        Me.txtDonorSearchHome.SelectedText = ""
        Me.txtDonorSearchHome.Size = New System.Drawing.Size(269, 30)
        Me.txtDonorSearchHome.TabIndex = 13
        '
        'dgvDonorCampaign
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvDonorCampaign.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDonorCampaign.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvDonorCampaign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDonorCampaign.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDonorCampaign.ColumnHeadersHeight = 17
        Me.dgvDonorCampaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDonorCampaign.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDonorCampaign.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorCampaign.Location = New System.Drawing.Point(17, 325)
        Me.dgvDonorCampaign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDonorCampaign.Name = "dgvDonorCampaign"
        Me.dgvDonorCampaign.RowHeadersVisible = False
        Me.dgvDonorCampaign.RowHeadersWidth = 51
        Me.dgvDonorCampaign.RowTemplate.Height = 25
        Me.dgvDonorCampaign.Size = New System.Drawing.Size(1053, 297)
        Me.dgvDonorCampaign.TabIndex = 15
        Me.dgvDonorCampaign.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDonorCampaign.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDonorCampaign.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDonorCampaign.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDonorCampaign.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDonorCampaign.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvDonorCampaign.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorCampaign.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorCampaign.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDonorCampaign.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvDonorCampaign.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDonorCampaign.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDonorCampaign.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvDonorCampaign.ThemeStyle.ReadOnly = False
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.Height = 25
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorCampaign.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnlAdminCampaign
        '
        Me.pnlAdminCampaign.BackColor = System.Drawing.Color.DarkMagenta
        Me.pnlAdminCampaign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdminCampaign.Controls.Add(Me.Label2)
        Me.pnlAdminCampaign.Controls.Add(Me.lblAdminHome1)
        Me.pnlAdminCampaign.Location = New System.Drawing.Point(17, 66)
        Me.pnlAdminCampaign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlAdminCampaign.Name = "pnlAdminCampaign"
        Me.pnlAdminCampaign.Size = New System.Drawing.Size(295, 180)
        Me.pnlAdminCampaign.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Active Campaigns"
        '
        'lblAdminHome1
        '
        Me.lblAdminHome1.AutoSize = True
        Me.lblAdminHome1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblAdminHome1.ForeColor = System.Drawing.Color.White
        Me.lblAdminHome1.Location = New System.Drawing.Point(3, 116)
        Me.lblAdminHome1.Name = "lblAdminHome1"
        Me.lblAdminHome1.Size = New System.Drawing.Size(25, 38)
        Me.lblAdminHome1.TabIndex = 0
        Me.lblAdminHome1.Text = "."
        '
        'DonorHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 638)
        Me.Controls.Add(Me.pnlAdminCampaign)
        Me.Controls.Add(Me.dgvDonorCampaign)
        Me.Controls.Add(Me.btnDonorHomeSearch)
        Me.Controls.Add(Me.txtDonorSearchHome)
        Me.Controls.Add(Me.pnlDonorHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DonorHome"
        Me.Text = "DonorHome"
        Me.pnlDonorHome.ResumeLayout(False)
        Me.pnlDonorHome.PerformLayout()
        CType(Me.dgvDonorCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdminCampaign.ResumeLayout(False)
        Me.pnlAdminCampaign.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlDonorHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDonorHomeSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtDonorSearchHome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvDonorCampaign As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlAdminCampaign As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdminHome1 As Label
End Class
