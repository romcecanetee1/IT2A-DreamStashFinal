<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Get_Started
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
        Me.ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnGetLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ControlBoxMin
        '
        Me.ControlBoxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBoxMin.BackColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ControlBoxMin.FillColor = System.Drawing.Color.Transparent
        Me.ControlBoxMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ControlBoxMin.IconColor = System.Drawing.Color.DarkViolet
        Me.ControlBoxMin.Location = New System.Drawing.Point(996, -1)
        Me.ControlBoxMin.Margin = New System.Windows.Forms.Padding(4)
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
        Me.ControlBoxClose.Location = New System.Drawing.Point(1055, -1)
        Me.ControlBoxClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ControlBoxClose.Name = "ControlBoxClose"
        Me.ControlBoxClose.Size = New System.Drawing.Size(52, 31)
        Me.ControlBoxClose.TabIndex = 3
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btnGetLogin)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(612, 603)
        Me.Guna2Panel1.TabIndex = 5
        '
        'btnGetLogin
        '
        Me.btnGetLogin.AutoRoundedCorners = True
        Me.btnGetLogin.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnGetLogin.BorderRadius = 23
        Me.btnGetLogin.BorderThickness = 1
        Me.btnGetLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGetLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGetLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGetLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGetLogin.FillColor = System.Drawing.Color.White
        Me.btnGetLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnGetLogin.ForeColor = System.Drawing.Color.Black
        Me.btnGetLogin.HoverState.BorderColor = System.Drawing.Color.DarkViolet
        Me.btnGetLogin.HoverState.FillColor = System.Drawing.Color.DarkViolet
        Me.btnGetLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnGetLogin.Location = New System.Drawing.Point(175, 279)
        Me.btnGetLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetLogin.Name = "btnGetLogin"
        Me.btnGetLogin.Size = New System.Drawing.Size(228, 48)
        Me.btnGetLogin.TabIndex = 5
        Me.btnGetLogin.Text = "&Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(132, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Welcome!"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources._3_ctcS1Diu0_transformed
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.ErrorImage = Nothing
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.InitialImage = Nothing
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(676, 138)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(351, 321)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Get_Started
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IT2A_DreamStashTest.My.Resources.Resources.hexagons_patterns_violet_background_violet_blocks_black_3840x2160_2277
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1099, 598)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.ControlBoxMin)
        Me.Controls.Add(Me.ControlBoxClose)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Get_Started"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get_Started"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnGetLogin As Guna.UI2.WinForms.Guna2Button
End Class
