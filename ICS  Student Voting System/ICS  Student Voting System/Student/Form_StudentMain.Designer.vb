<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_StudentMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StudentMain))
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_studentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_StudentLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.label_info = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(68, 18)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(45, 30)
        Me.Guna2HtmlLabel5.TabIndex = 14
        Me.Guna2HtmlLabel5.Text = "VOTE"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(29, 42)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(136, 24)
        Me.Guna2HtmlLabel3.TabIndex = 13
        Me.Guna2HtmlLabel3.Text = "Management System"
        '
        'btn_exit
        '
        Me.btn_exit.Animated = True
        Me.btn_exit.AnimatedGIF = True
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.BorderRadius = 5
        Me.btn_exit.CheckedState.ForeColor = System.Drawing.Color.Transparent
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_exit.FillColor = System.Drawing.Color.Transparent
        Me.btn_exit.Font = New System.Drawing.Font("Poppins SemiBold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btn_exit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_exit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(856, 29)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(53, 27)
        Me.btn_exit.TabIndex = 18
        Me.btn_exit.Text = "Exit"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.label_info)
        Me.Guna2Panel1.Controls.Add(Me.btn_StudentLogin)
        Me.Guna2Panel1.Controls.Add(Me.txt_studentID)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 82)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(909, 564)
        Me.Guna2Panel1.TabIndex = 78
        '
        'txt_studentID
        '
        Me.txt_studentID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txt_studentID.BorderRadius = 4
        Me.txt_studentID.BorderThickness = 2
        Me.txt_studentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_studentID.DefaultText = ""
        Me.txt_studentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_studentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_studentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_studentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_studentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_studentID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_studentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_studentID.IconLeft = CType(resources.GetObject("txt_studentID.IconLeft"), System.Drawing.Image)
        Me.txt_studentID.Location = New System.Drawing.Point(344, 221)
        Me.txt_studentID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_studentID.Name = "txt_studentID"
        Me.txt_studentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_studentID.PlaceholderText = ""
        Me.txt_studentID.SelectedText = ""
        Me.txt_studentID.Size = New System.Drawing.Size(250, 28)
        Me.txt_studentID.TabIndex = 88
        Me.txt_studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Poppins", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(349, 207)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(53, 18)
        Me.Guna2HtmlLabel10.TabIndex = 87
        Me.Guna2HtmlLabel10.Text = "Student ID"
        '
        'btn_StudentLogin
        '
        Me.btn_StudentLogin.BorderRadius = 4
        Me.btn_StudentLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_StudentLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_StudentLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_StudentLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_StudentLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_StudentLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_StudentLogin.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_StudentLogin.ForeColor = System.Drawing.Color.White
        Me.btn_StudentLogin.Location = New System.Drawing.Point(344, 267)
        Me.btn_StudentLogin.Name = "btn_StudentLogin"
        Me.btn_StudentLogin.Size = New System.Drawing.Size(250, 28)
        Me.btn_StudentLogin.TabIndex = 91
        Me.btn_StudentLogin.Text = "Compute"
        '
        'label_info
        '
        Me.label_info.AutoSize = False
        Me.label_info.BackColor = System.Drawing.Color.Transparent
        Me.label_info.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.label_info.Location = New System.Drawing.Point(344, 171)
        Me.label_info.Name = "label_info"
        Me.label_info.Size = New System.Drawing.Size(250, 18)
        Me.label_info.TabIndex = 92
        Me.label_info.Text = "Enter Student ID"
        Me.label_info.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_StudentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 658)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_StudentMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_StudentMain"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_StudentLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_studentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label_info As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
