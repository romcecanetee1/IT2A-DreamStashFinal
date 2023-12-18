<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUsersBenePrint3
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewerBene = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnAdminBeneLoadReport = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCRAdminSearchBene = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxBeneSearch = New Guna.UI2.WinForms.Guna2CheckBox()
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
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(876, 34)
        Me.pnlHome.TabIndex = 67
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(794, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(38, 25)
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
        Me.ControlBoxMin.Location = New System.Drawing.Point(1320, 3)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlBoxMin.Name = "ControlBoxMin"
        Me.ControlBoxMin.Size = New System.Drawing.Size(38, 25)
        Me.ControlBoxMin.TabIndex = 4
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DarkViolet
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(838, 0)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(38, 25)
        Me.Guna2ControlBox2.TabIndex = 17
        '
        'ControlBoxClose
        '
        Me.ControlBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxClose.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxClose.Location = New System.Drawing.Point(1364, 3)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(38, 25)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Beneficiary Report"
        '
        'CrystalReportViewerBene
        '
        Me.CrystalReportViewerBene.ActiveViewIndex = -1
        Me.CrystalReportViewerBene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerBene.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerBene.Location = New System.Drawing.Point(12, 118)
        Me.CrystalReportViewerBene.Name = "CrystalReportViewerBene"
        Me.CrystalReportViewerBene.Size = New System.Drawing.Size(852, 440)
        Me.CrystalReportViewerBene.TabIndex = 68
        '
        'btnAdminBeneLoadReport
        '
        Me.btnAdminBeneLoadReport.AutoRoundedCorners = True
        Me.btnAdminBeneLoadReport.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminBeneLoadReport.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBeneLoadReport.BorderRadius = 14
        Me.btnAdminBeneLoadReport.BorderThickness = 1
        Me.btnAdminBeneLoadReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminBeneLoadReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdminBeneLoadReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdminBeneLoadReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdminBeneLoadReport.FillColor = System.Drawing.Color.White
        Me.btnAdminBeneLoadReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdminBeneLoadReport.ForeColor = System.Drawing.Color.Black
        Me.btnAdminBeneLoadReport.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBeneLoadReport.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnAdminBeneLoadReport.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdminBeneLoadReport.Location = New System.Drawing.Point(593, 73)
        Me.btnAdminBeneLoadReport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdminBeneLoadReport.Name = "btnAdminBeneLoadReport"
        Me.btnAdminBeneLoadReport.Size = New System.Drawing.Size(116, 31)
        Me.btnAdminBeneLoadReport.TabIndex = 72
        Me.btnAdminBeneLoadReport.Text = "Load Report"
        '
        'txtCRAdminSearchBene
        '
        Me.txtCRAdminSearchBene.BorderColor = System.Drawing.Color.DarkViolet
        Me.txtCRAdminSearchBene.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCRAdminSearchBene.DefaultText = ""
        Me.txtCRAdminSearchBene.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCRAdminSearchBene.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCRAdminSearchBene.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminSearchBene.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCRAdminSearchBene.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminSearchBene.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCRAdminSearchBene.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCRAdminSearchBene.IconLeft = Global.IT2A_DreamStashTest.My.Resources.Resources.search_alt_svgrepo_com
        Me.txtCRAdminSearchBene.Location = New System.Drawing.Point(304, 80)
        Me.txtCRAdminSearchBene.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCRAdminSearchBene.Name = "txtCRAdminSearchBene"
        Me.txtCRAdminSearchBene.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCRAdminSearchBene.PlaceholderText = "Search"
        Me.txtCRAdminSearchBene.SelectedText = ""
        Me.txtCRAdminSearchBene.Size = New System.Drawing.Size(274, 24)
        Me.txtCRAdminSearchBene.TabIndex = 71
        '
        'cbxBeneSearch
        '
        Me.cbxBeneSearch.AutoSize = True
        Me.cbxBeneSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxBeneSearch.CheckedState.BorderRadius = 0
        Me.cbxBeneSearch.CheckedState.BorderThickness = 0
        Me.cbxBeneSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxBeneSearch.Location = New System.Drawing.Point(385, 56)
        Me.cbxBeneSearch.Name = "cbxBeneSearch"
        Me.cbxBeneSearch.Size = New System.Drawing.Size(128, 17)
        Me.cbxBeneSearch.TabIndex = 76
        Me.cbxBeneSearch.Text = "Use Advance Search"
        Me.cbxBeneSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxBeneSearch.UncheckedState.BorderRadius = 0
        Me.cbxBeneSearch.UncheckedState.BorderThickness = 0
        Me.cbxBeneSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'AdminUsersBenePrint3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 624)
        Me.Controls.Add(Me.cbxBeneSearch)
        Me.Controls.Add(Me.btnAdminBeneLoadReport)
        Me.Controls.Add(Me.txtCRAdminSearchBene)
        Me.Controls.Add(Me.CrystalReportViewerBene)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminUsersBenePrint3"
        Me.Text = "AdminUsersBenePrint3"
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
    Friend WithEvents CrystalReportViewerBene As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnAdminBeneLoadReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCRAdminSearchBene As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxBeneSearch As Guna.UI2.WinForms.Guna2CheckBox
End Class
