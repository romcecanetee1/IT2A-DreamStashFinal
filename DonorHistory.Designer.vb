<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DonorHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgAdminHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAdminSearchHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAdminSearchHistory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlHome.SuspendLayout()
        CType(Me.dgAdminHistory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHome.Size = New System.Drawing.Size(1087, 42)
        Me.pnlHome.TabIndex = 1
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
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donation History"
        '
        'dgAdminHistory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgAdminHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAdminHistory.BackgroundColor = System.Drawing.Color.Silver
        Me.dgAdminHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAdminHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgAdminHistory.ColumnHeadersHeight = 17
        Me.dgAdminHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAdminHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgAdminHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAdminHistory.Location = New System.Drawing.Point(13, 194)
        Me.dgAdminHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgAdminHistory.Name = "dgAdminHistory"
        Me.dgAdminHistory.RowHeadersVisible = False
        Me.dgAdminHistory.RowHeadersWidth = 51
        Me.dgAdminHistory.RowTemplate.Height = 25
        Me.dgAdminHistory.Size = New System.Drawing.Size(1059, 430)
        Me.dgAdminHistory.TabIndex = 16
        Me.dgAdminHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgAdminHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgAdminHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgAdminHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgAdminHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgAdminHistory.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgAdminHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAdminHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAdminHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgAdminHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgAdminHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgAdminHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgAdminHistory.ThemeStyle.HeaderStyle.Height = 17
        Me.dgAdminHistory.ThemeStyle.ReadOnly = False
        Me.dgAdminHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgAdminHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgAdminHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgAdminHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAdminHistory.ThemeStyle.RowsStyle.Height = 25
        Me.dgAdminHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAdminHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAdminSearchHistory
        '
        Me.btnAdminSearchHistory.AutoRoundedCorners = True
        Me.btnAdminSearchHistory.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchHistory.BorderRadius = 14
        Me.btnAdminSearchHistory.BorderThickness = 1
        Me.btnAdminSearchHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminSearchHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminSearchHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminSearchHistory.FillColor = System.Drawing.Color.White
        Me.btnAdminSearchHistory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminSearchHistory.ForeColor = System.Drawing.Color.Black
        Me.btnAdminSearchHistory.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchHistory.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminSearchHistory.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminSearchHistory.Location = New System.Drawing.Point(265, 150)
        Me.btnAdminSearchHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminSearchHistory.Name = "btnAdminSearchHistory"
        Me.btnAdminSearchHistory.Size = New System.Drawing.Size(172, 30)
        Me.btnAdminSearchHistory.TabIndex = 64
        Me.btnAdminSearchHistory.Text = "Search/Filter"
        '
        'txtAdminSearchHistory
        '
        Me.txtAdminSearchHistory.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtAdminSearchHistory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminSearchHistory.DefaultText = ""
        Me.txtAdminSearchHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminSearchHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminSearchHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminSearchHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminSearchHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminSearchHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminSearchHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminSearchHistory.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtAdminSearchHistory.Location = New System.Drawing.Point(17, 150)
        Me.txtAdminSearchHistory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdminSearchHistory.Name = "txtAdminSearchHistory"
        Me.txtAdminSearchHistory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminSearchHistory.PlaceholderText = "Search"
        Me.txtAdminSearchHistory.SelectedText = ""
        Me.txtAdminSearchHistory.Size = New System.Drawing.Size(240, 30)
        Me.txtAdminSearchHistory.TabIndex = 63
        '
        'DonorHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 638)
        Me.Controls.Add(Me.btnAdminSearchHistory)
        Me.Controls.Add(Me.txtAdminSearchHistory)
        Me.Controls.Add(Me.dgAdminHistory)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DonorHistory"
        Me.Text = "DonorHistory"
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        CType(Me.dgAdminHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgAdminHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnAdminSearchHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAdminSearchHistory As Guna.UI2.WinForms.Guna2TextBox
End Class
