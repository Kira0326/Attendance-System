<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateQRCode
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.closeQRCreation_btn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SaveQRCodeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.QRCodePictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDNumberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.GenerateQRCodeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.FirstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.QRCodePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Controls.Add(Me.closeQRCreation_btn)
        Me.Guna2GradientPanel1.Controls.Add(Me.SaveQRCodeButton)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Turquoise
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(709, 417)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'closeQRCreation_btn
        '
        Me.closeQRCreation_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.closeQRCreation_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.closeQRCreation_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.closeQRCreation_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.closeQRCreation_btn.FillColor = System.Drawing.Color.Transparent
        Me.closeQRCreation_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.closeQRCreation_btn.ForeColor = System.Drawing.Color.Salmon
        Me.closeQRCreation_btn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.closeQRCreation_btn.Location = New System.Drawing.Point(678, 3)
        Me.closeQRCreation_btn.Name = "closeQRCreation_btn"
        Me.closeQRCreation_btn.PressedColor = System.Drawing.Color.BlanchedAlmond
        Me.closeQRCreation_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.closeQRCreation_btn.Size = New System.Drawing.Size(28, 26)
        Me.closeQRCreation_btn.TabIndex = 18
        Me.closeQRCreation_btn.Text = "x"
        '
        'SaveQRCodeButton
        '
        Me.SaveQRCodeButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveQRCodeButton.BorderRadius = 20
        Me.SaveQRCodeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SaveQRCodeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SaveQRCodeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SaveQRCodeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SaveQRCodeButton.FillColor = System.Drawing.Color.AliceBlue
        Me.SaveQRCodeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveQRCodeButton.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SaveQRCodeButton.Location = New System.Drawing.Point(283, 363)
        Me.SaveQRCodeButton.Name = "SaveQRCodeButton"
        Me.SaveQRCodeButton.Size = New System.Drawing.Size(156, 37)
        Me.SaveQRCodeButton.TabIndex = 15
        Me.SaveQRCodeButton.Text = "Save to Folder"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderRadius = 20
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.QRCodePictureBox)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.LastNameTextBox)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.IDNumberTextBox)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.UserNameLabel)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GenerateQRCodeButton)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.FirstNameTextBox)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(26, 34)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(651, 315)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'QRCodePictureBox
        '
        Me.QRCodePictureBox.ImageRotate = 0!
        Me.QRCodePictureBox.Location = New System.Drawing.Point(370, 36)
        Me.QRCodePictureBox.Name = "QRCodePictureBox"
        Me.QRCodePictureBox.Size = New System.Drawing.Size(211, 182)
        Me.QRCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.QRCodePictureBox.TabIndex = 17
        Me.QRCodePictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(35, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Last Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BorderRadius = 20
        Me.LastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTextBox.DefaultText = ""
        Me.LastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTextBox.Location = New System.Drawing.Point(38, 130)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTextBox.PlaceholderText = ""
        Me.LastNameTextBox.SelectedText = ""
        Me.LastNameTextBox.Size = New System.Drawing.Size(206, 33)
        Me.LastNameTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(35, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ID Number"
        '
        'IDNumberTextBox
        '
        Me.IDNumberTextBox.BorderRadius = 20
        Me.IDNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDNumberTextBox.DefaultText = ""
        Me.IDNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDNumberTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDNumberTextBox.Location = New System.Drawing.Point(38, 208)
        Me.IDNumberTextBox.Name = "IDNumberTextBox"
        Me.IDNumberTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDNumberTextBox.PlaceholderText = ""
        Me.IDNumberTextBox.SelectedText = ""
        Me.IDNumberTextBox.Size = New System.Drawing.Size(206, 33)
        Me.IDNumberTextBox.TabIndex = 12
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.ForeColor = System.Drawing.Color.DimGray
        Me.UserNameLabel.Location = New System.Drawing.Point(35, 36)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(71, 17)
        Me.UserNameLabel.TabIndex = 11
        Me.UserNameLabel.Text = "First Name"
        '
        'GenerateQRCodeButton
        '
        Me.GenerateQRCodeButton.BorderRadius = 20
        Me.GenerateQRCodeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GenerateQRCodeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GenerateQRCodeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GenerateQRCodeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GenerateQRCodeButton.FillColor = System.Drawing.Color.DodgerBlue
        Me.GenerateQRCodeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GenerateQRCodeButton.ForeColor = System.Drawing.Color.White
        Me.GenerateQRCodeButton.Location = New System.Drawing.Point(419, 236)
        Me.GenerateQRCodeButton.Name = "GenerateQRCodeButton"
        Me.GenerateQRCodeButton.Size = New System.Drawing.Size(124, 37)
        Me.GenerateQRCodeButton.TabIndex = 10
        Me.GenerateQRCodeButton.Text = "Generate QR"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BorderRadius = 20
        Me.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTextBox.DefaultText = ""
        Me.FirstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FirstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(38, 59)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTextBox.PlaceholderText = ""
        Me.FirstNameTextBox.SelectedText = ""
        Me.FirstNameTextBox.Size = New System.Drawing.Size(206, 33)
        Me.FirstNameTextBox.TabIndex = 9
        '
        'CreateQRCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 412)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateQRCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateQRCode"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.QRCodePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents FirstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GenerateQRCodeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IDNumberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SaveQRCodeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LastNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents QRCodePictureBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents closeQRCreation_btn As Guna.UI2.WinForms.Guna2CircleButton
End Class
