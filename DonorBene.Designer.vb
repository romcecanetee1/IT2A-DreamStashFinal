<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DonorBene
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDonorSearchBene = New Guna.UI2.WinForms.Guna2Button()
        Me.txtDonorSearchBene = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvDonorBene = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlHome.SuspendLayout()
        CType(Me.dgvDonorBene, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHome.Controls.Add(Me.ControlBoxMin)
        Me.pnlHome.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlHome.Controls.Add(Me.ControlBoxClose)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1087, 42)
        Me.pnlHome.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(977, 0)
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
        Me.ControlBoxMin.Location = New System.Drawing.Point(1679, 4)
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1036, 0)
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
        Me.ControlBoxClose.Location = New System.Drawing.Point(1737, 4)
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
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beneficiaries"
        '
        'btnDonorSearchBene
        '
        Me.btnDonorSearchBene.AutoRoundedCorners = True
        Me.btnDonorSearchBene.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnDonorSearchBene.BorderRadius = 14
        Me.btnDonorSearchBene.BorderThickness = 1
        Me.btnDonorSearchBene.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDonorSearchBene.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDonorSearchBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDonorSearchBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDonorSearchBene.FillColor = System.Drawing.Color.White
        Me.btnDonorSearchBene.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDonorSearchBene.ForeColor = System.Drawing.Color.Black
        Me.btnDonorSearchBene.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnDonorSearchBene.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnDonorSearchBene.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnDonorSearchBene.Location = New System.Drawing.Point(265, 157)
        Me.btnDonorSearchBene.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonorSearchBene.Name = "btnDonorSearchBene"
        Me.btnDonorSearchBene.Size = New System.Drawing.Size(172, 30)
        Me.btnDonorSearchBene.TabIndex = 22
        Me.btnDonorSearchBene.Text = "Search/Filter"
        '
        'txtDonorSearchBene
        '
        Me.txtDonorSearchBene.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtDonorSearchBene.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDonorSearchBene.DefaultText = ""
        Me.txtDonorSearchBene.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDonorSearchBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDonorSearchBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDonorSearchBene.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDonorSearchBene.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDonorSearchBene.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDonorSearchBene.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDonorSearchBene.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtDonorSearchBene.Location = New System.Drawing.Point(17, 157)
        Me.txtDonorSearchBene.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDonorSearchBene.Name = "txtDonorSearchBene"
        Me.txtDonorSearchBene.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDonorSearchBene.PlaceholderText = "Search"
        Me.txtDonorSearchBene.SelectedText = ""
        Me.txtDonorSearchBene.Size = New System.Drawing.Size(240, 30)
        Me.txtDonorSearchBene.TabIndex = 21
        '
        'dgvDonorBene
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvDonorBene.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDonorBene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvDonorBene.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvDonorBene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDonorBene.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDonorBene.ColumnHeadersHeight = 17
        Me.dgvDonorBene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDonorBene.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDonorBene.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorBene.Location = New System.Drawing.Point(12, 196)
        Me.dgvDonorBene.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvDonorBene.MultiSelect = False
        Me.dgvDonorBene.Name = "dgvDonorBene"
        Me.dgvDonorBene.ReadOnly = True
        Me.dgvDonorBene.RowHeadersVisible = False
        Me.dgvDonorBene.RowHeadersWidth = 51
        Me.dgvDonorBene.RowTemplate.Height = 25
        Me.dgvDonorBene.Size = New System.Drawing.Size(1055, 429)
        Me.dgvDonorBene.TabIndex = 20
        Me.dgvDonorBene.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDonorBene.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDonorBene.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDonorBene.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDonorBene.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDonorBene.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvDonorBene.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorBene.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorBene.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDonorBene.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvDonorBene.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDonorBene.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDonorBene.ThemeStyle.HeaderStyle.Height = 17
        Me.dgvDonorBene.ThemeStyle.ReadOnly = True
        Me.dgvDonorBene.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDonorBene.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDonorBene.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvDonorBene.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvDonorBene.ThemeStyle.RowsStyle.Height = 25
        Me.dgvDonorBene.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDonorBene.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DonorBene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 638)
        Me.Controls.Add(Me.btnDonorSearchBene)
        Me.Controls.Add(Me.txtDonorSearchBene)
        Me.Controls.Add(Me.dgvDonorBene)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DonorBene"
        Me.Text = "DonorBene"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        CType(Me.dgvDonorBene, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDonorSearchBene As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtDonorSearchBene As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvDonorBene As Guna.UI2.WinForms.Guna2DataGridView
End Class
