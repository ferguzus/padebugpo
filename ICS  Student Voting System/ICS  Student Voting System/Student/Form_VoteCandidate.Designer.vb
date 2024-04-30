<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_VoteCandidate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_VoteCandidate))
        Me.label_info = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pic_close = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FlowLayoutSecretary = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutTreasurer = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutVicePresident = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPresident = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_info
        '
        Me.label_info.AutoSize = False
        Me.label_info.BackColor = System.Drawing.Color.Transparent
        Me.label_info.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.label_info.Location = New System.Drawing.Point(39, 12)
        Me.label_info.Name = "label_info"
        Me.label_info.Size = New System.Drawing.Size(155, 18)
        Me.label_info.TabIndex = 93
        Me.label_info.Text = "CANDIDATES LIST"
        Me.label_info.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_close
        '
        Me.pic_close.BackColor = System.Drawing.Color.Transparent
        Me.pic_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_close.FillColor = System.Drawing.Color.Transparent
        Me.pic_close.Image = CType(resources.GetObject("pic_close.Image"), System.Drawing.Image)
        Me.pic_close.ImageRotate = 0!
        Me.pic_close.Location = New System.Drawing.Point(874, 12)
        Me.pic_close.Name = "pic_close"
        Me.pic_close.Size = New System.Drawing.Size(23, 24)
        Me.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_close.TabIndex = 94
        Me.pic_close.TabStop = False
        Me.pic_close.UseTransparentBackground = True
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(141, 48)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(91, 18)
        Me.Guna2HtmlLabel1.TabIndex = 99
        Me.Guna2HtmlLabel1.Text = "President"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(141, 214)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(91, 18)
        Me.Guna2HtmlLabel2.TabIndex = 100
        Me.Guna2HtmlLabel2.Text = "Vice President"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(141, 382)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(91, 18)
        Me.Guna2HtmlLabel3.TabIndex = 101
        Me.Guna2HtmlLabel3.Text = "Secretary"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(141, 549)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(91, 18)
        Me.Guna2HtmlLabel4.TabIndex = 102
        Me.Guna2HtmlLabel4.Text = "Treasurer"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutSecretary
        '
        Me.FlowLayoutSecretary.BackColor = System.Drawing.Color.Gray
        Me.FlowLayoutSecretary.Location = New System.Drawing.Point(141, 406)
        Me.FlowLayoutSecretary.Name = "FlowLayoutSecretary"
        Me.FlowLayoutSecretary.Size = New System.Drawing.Size(830, 127)
        Me.FlowLayoutSecretary.TabIndex = 97
        '
        'FlowLayoutTreasurer
        '
        Me.FlowLayoutTreasurer.BackColor = System.Drawing.Color.DimGray
        Me.FlowLayoutTreasurer.Location = New System.Drawing.Point(141, 574)
        Me.FlowLayoutTreasurer.Name = "FlowLayoutTreasurer"
        Me.FlowLayoutTreasurer.Size = New System.Drawing.Size(830, 127)
        Me.FlowLayoutTreasurer.TabIndex = 97
        '
        'FlowLayoutVicePresident
        '
        Me.FlowLayoutVicePresident.BackColor = System.Drawing.Color.Gray
        Me.FlowLayoutVicePresident.Location = New System.Drawing.Point(141, 238)
        Me.FlowLayoutVicePresident.Name = "FlowLayoutVicePresident"
        Me.FlowLayoutVicePresident.Size = New System.Drawing.Size(830, 127)
        Me.FlowLayoutVicePresident.TabIndex = 96
        '
        'FlowLayoutPresident
        '
        Me.FlowLayoutPresident.BackColor = System.Drawing.Color.Gray
        Me.FlowLayoutPresident.Location = New System.Drawing.Point(141, 72)
        Me.FlowLayoutPresident.Name = "FlowLayoutPresident"
        Me.FlowLayoutPresident.Size = New System.Drawing.Size(830, 127)
        Me.FlowLayoutPresident.TabIndex = 97
        '
        'Form_VoteCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1041, 790)
        Me.Controls.Add(Me.FlowLayoutPresident)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.FlowLayoutTreasurer)
        Me.Controls.Add(Me.FlowLayoutSecretary)
        Me.Controls.Add(Me.FlowLayoutVicePresident)
        Me.Controls.Add(Me.pic_close)
        Me.Controls.Add(Me.label_info)
        Me.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_VoteCandidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_VoteCandidate"
        CType(Me.pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents label_info As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pic_close As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FlowLayoutSecretary As FlowLayoutPanel
    Friend WithEvents FlowLayoutTreasurer As FlowLayoutPanel
    Friend WithEvents FlowLayoutVicePresident As FlowLayoutPanel
    Friend WithEvents FlowLayoutPresident As FlowLayoutPanel
End Class
