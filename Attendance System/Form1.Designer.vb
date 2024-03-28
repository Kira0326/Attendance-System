<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.stdntID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.firstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.stdntAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.studentList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.stdntDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnReload = New Guna.UI2.WinForms.Guna2Button()
        Me.closeStdntInfo_btn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.UploadQRImageButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxQR = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.studentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'stdntID
        '
        Me.stdntID.AutoRoundedCorners = True
        Me.stdntID.BorderRadius = 17
        Me.stdntID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stdntID.DefaultText = ""
        Me.stdntID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stdntID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stdntID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stdntID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stdntID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdntID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.stdntID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stdntID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdntID.Location = New System.Drawing.Point(53, 74)
        Me.stdntID.Name = "stdntID"
        Me.stdntID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stdntID.PlaceholderText = "Student ID"
        Me.stdntID.SelectedText = ""
        Me.stdntID.Size = New System.Drawing.Size(278, 36)
        Me.stdntID.TabIndex = 1
        '
        'firstName
        '
        Me.firstName.AutoRoundedCorners = True
        Me.firstName.BorderRadius = 17
        Me.firstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstName.DefaultText = ""
        Me.firstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.firstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstName.Location = New System.Drawing.Point(53, 130)
        Me.firstName.Name = "firstName"
        Me.firstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstName.PlaceholderText = "First Name"
        Me.firstName.SelectedText = ""
        Me.firstName.Size = New System.Drawing.Size(278, 36)
        Me.firstName.TabIndex = 2
        '
        'lastName
        '
        Me.lastName.AutoRoundedCorners = True
        Me.lastName.BorderRadius = 17
        Me.lastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastName.DefaultText = ""
        Me.lastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastName.Location = New System.Drawing.Point(53, 188)
        Me.lastName.Name = "lastName"
        Me.lastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lastName.PlaceholderText = "Last Name"
        Me.lastName.SelectedText = ""
        Me.lastName.Size = New System.Drawing.Size(278, 36)
        Me.lastName.TabIndex = 3
        '
        'stdntAge
        '
        Me.stdntAge.AutoRoundedCorners = True
        Me.stdntAge.BorderRadius = 17
        Me.stdntAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stdntAge.DefaultText = ""
        Me.stdntAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stdntAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stdntAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stdntAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stdntAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdntAge.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.stdntAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdntAge.Location = New System.Drawing.Point(53, 247)
        Me.stdntAge.Name = "stdntAge"
        Me.stdntAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stdntAge.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.stdntAge.PlaceholderText = "Age"
        Me.stdntAge.SelectedText = ""
        Me.stdntAge.Size = New System.Drawing.Size(278, 36)
        Me.stdntAge.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 19
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(711, 534)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 36)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(654, 23)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(355, 34)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "STUDENT INFORMATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(55, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Department"
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 19
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(605, 534)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 36)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Edit"
        '
        'btnNew
        '
        Me.btnNew.BorderRadius = 19
        Me.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNew.FillColor = System.Drawing.Color.Salmon
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(369, 534)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 36)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "Clear"
        '
        'studentList
        '
        Me.studentList.AllowUserToDeleteRows = False
        Me.studentList.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.studentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.studentList.ColumnHeadersHeight = 15
        Me.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.studentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentList.DefaultCellStyle = DataGridViewCellStyle6
        Me.studentList.GridColor = System.Drawing.Color.White
        Me.studentList.Location = New System.Drawing.Point(369, 63)
        Me.studentList.Name = "studentList"
        Me.studentList.RowHeadersVisible = False
        Me.studentList.Size = New System.Drawing.Size(790, 426)
        Me.studentList.TabIndex = 5
        Me.studentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.studentList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.studentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.studentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.studentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.studentList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.studentList.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.studentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.studentList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.studentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.studentList.ThemeStyle.HeaderStyle.Height = 15
        Me.studentList.ThemeStyle.ReadOnly = False
        Me.studentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.studentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.studentList.ThemeStyle.RowsStyle.Height = 22
        Me.studentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "studentID"
        Me.Column1.FillWeight = 80.0!
        Me.Column1.HeaderText = "STUDENT ID"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "lastName"
        Me.Column3.FillWeight = 90.0!
        Me.Column3.HeaderText = "LAST NAME"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "firstName"
        Me.Column2.FillWeight = 90.0!
        Me.Column2.HeaderText = "FIRST NAME"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "studentAge"
        Me.Column4.FillWeight = 90.0!
        Me.Column4.HeaderText = "AGE"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "stdntDepartment"
        Me.Column5.FillWeight = 110.0!
        Me.Column5.HeaderText = "DEPARTMENT"
        Me.Column5.Name = "Column5"
        '
        'btnCreate
        '
        Me.btnCreate.BorderRadius = 19
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(499, 534)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 36)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Save"
        '
        'stdntDepartment
        '
        Me.stdntDepartment.AutoRoundedCorners = True
        Me.stdntDepartment.BackColor = System.Drawing.Color.Transparent
        Me.stdntDepartment.BorderRadius = 17
        Me.stdntDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.stdntDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stdntDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdntDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdntDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.stdntDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.stdntDepartment.ItemHeight = 30
        Me.stdntDepartment.Items.AddRange(New Object() {"College of Engineering", "College of Business Administration", "College of Information Communication Technology", "College of Nursing", "College.of Hospitality and Tourism Management", "College of Criminal Justice Education", "College of Teacher Education"})
        Me.stdntDepartment.Location = New System.Drawing.Point(53, 322)
        Me.stdntDepartment.Name = "stdntDepartment"
        Me.stdntDepartment.Size = New System.Drawing.Size(278, 36)
        Me.stdntDepartment.TabIndex = 12
        '
        'btnReload
        '
        Me.btnReload.BorderRadius = 19
        Me.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReload.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnReload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.Location = New System.Drawing.Point(1060, 507)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(99, 36)
        Me.btnReload.TabIndex = 10
        Me.btnReload.Text = "Refresh "
        '
        'closeStdntInfo_btn
        '
        Me.closeStdntInfo_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.closeStdntInfo_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.closeStdntInfo_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.closeStdntInfo_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.closeStdntInfo_btn.FillColor = System.Drawing.Color.White
        Me.closeStdntInfo_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.closeStdntInfo_btn.ForeColor = System.Drawing.Color.Salmon
        Me.closeStdntInfo_btn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.closeStdntInfo_btn.Location = New System.Drawing.Point(1127, 3)
        Me.closeStdntInfo_btn.Name = "closeStdntInfo_btn"
        Me.closeStdntInfo_btn.PressedColor = System.Drawing.Color.BlanchedAlmond
        Me.closeStdntInfo_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.closeStdntInfo_btn.Size = New System.Drawing.Size(32, 29)
        Me.closeStdntInfo_btn.TabIndex = 16
        Me.closeStdntInfo_btn.Text = "x"
        '
        'UploadQRImageButton
        '
        Me.UploadQRImageButton.BorderRadius = 19
        Me.UploadQRImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UploadQRImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UploadQRImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UploadQRImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UploadQRImageButton.FillColor = System.Drawing.Color.DodgerBlue
        Me.UploadQRImageButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UploadQRImageButton.ForeColor = System.Drawing.Color.White
        Me.UploadQRImageButton.Location = New System.Drawing.Point(111, 549)
        Me.UploadQRImageButton.Name = "UploadQRImageButton"
        Me.UploadQRImageButton.Size = New System.Drawing.Size(100, 36)
        Me.UploadQRImageButton.TabIndex = 17
        Me.UploadQRImageButton.Text = "Browse "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(55, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Upload QR Code"
        '
        'PictureBoxQR
        '
        Me.PictureBoxQR.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxQR.ImageRotate = 0!
        Me.PictureBoxQR.Location = New System.Drawing.Point(84, 404)
        Me.PictureBoxQR.Name = "PictureBoxQR"
        Me.PictureBoxQR.Size = New System.Drawing.Size(159, 136)
        Me.PictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxQR.TabIndex = 19
        Me.PictureBoxQR.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1177, 597)
        Me.Controls.Add(Me.PictureBoxQR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UploadQRImageButton)
        Me.Controls.Add(Me.closeStdntInfo_btn)
        Me.Controls.Add(Me.stdntDepartment)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.studentList)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.stdntAge)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.stdntID)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.studentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip

    Private Sub studentList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentList.CellContentClick

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles stdntID.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnReload.Click

    End Sub

    Friend WithEvents stdntID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents firstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents stdntAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents studentList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents stdntDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnReload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents closeStdntInfo_btn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents UploadQRImageButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxQR As Guna.UI2.WinForms.Guna2PictureBox
End Class
