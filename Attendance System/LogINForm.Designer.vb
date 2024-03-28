<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cancelLogIN_btn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.UserNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.Login_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.DodgerBlue
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(803, 450)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.cancelLogIN_btn)
        Me.Panel1.Controls.Add(Me.ShowPassword)
        Me.Panel1.Controls.Add(Me.UserNameTextBox)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.UserNameLabel)
        Me.Panel1.Controls.Add(Me.Login_btn)
        Me.Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(401, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 450)
        Me.Panel1.TabIndex = 0
        '
        'cancelLogIN_btn
        '
        Me.cancelLogIN_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelLogIN_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelLogIN_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelLogIN_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelLogIN_btn.FillColor = System.Drawing.Color.White
        Me.cancelLogIN_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cancelLogIN_btn.ForeColor = System.Drawing.Color.Salmon
        Me.cancelLogIN_btn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cancelLogIN_btn.Location = New System.Drawing.Point(369, -1)
        Me.cancelLogIN_btn.Name = "cancelLogIN_btn"
        Me.cancelLogIN_btn.PressedColor = System.Drawing.Color.BlanchedAlmond
        Me.cancelLogIN_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cancelLogIN_btn.Size = New System.Drawing.Size(32, 29)
        Me.cancelLogIN_btn.TabIndex = 15
        Me.cancelLogIN_btn.Text = "x"
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ShowPassword.Location = New System.Drawing.Point(282, 330)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(15, 14)
        Me.ShowPassword.TabIndex = 9
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BorderRadius = 20
        Me.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameTextBox.DefaultText = ""
        Me.UserNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameTextBox.Location = New System.Drawing.Point(102, 226)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTextBox.PlaceholderText = ""
        Me.UserNameTextBox.SelectedText = ""
        Me.UserNameTextBox.Size = New System.Drawing.Size(208, 37)
        Me.UserNameTextBox.TabIndex = 8
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.AutoRoundedCorners = True
        Me.PasswordTextBox.BorderRadius = 17
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Location = New System.Drawing.Point(102, 317)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextBox.PlaceholderText = ""
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(208, 37)
        Me.PasswordTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.DimGray
        Me.PasswordLabel.Location = New System.Drawing.Point(99, 285)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(64, 17)
        Me.PasswordLabel.TabIndex = 7
        Me.PasswordLabel.Text = "Password"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.ForeColor = System.Drawing.Color.DimGray
        Me.UserNameLabel.Location = New System.Drawing.Point(99, 199)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(67, 17)
        Me.UserNameLabel.TabIndex = 6
        Me.UserNameLabel.Text = "Username"
        '
        'Login_btn
        '
        Me.Login_btn.BorderRadius = 20
        Me.Login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Login_btn.FillColor = System.Drawing.Color.DodgerBlue
        Me.Login_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Login_btn.ForeColor = System.Drawing.Color.White
        Me.Login_btn.Location = New System.Drawing.Point(137, 364)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(140, 37)
        Me.Login_btn.TabIndex = 5
        Me.Login_btn.Text = "Login"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(137, 71)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(140, 109)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Login Here !"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox

    Friend WithEvents Login_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UserNameLabel As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles UserNameLabel.Click

    End Sub

    Friend WithEvents PasswordLabel As Label

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Friend WithEvents UserNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents cancelLogIN_btn As Guna.UI2.WinForms.Guna2CircleButton
End Class
