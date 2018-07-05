<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MailSenter = New System.ComponentModel.BackgroundWorker()
        Me.AttachmentSelect = New System.Windows.Forms.OpenFileDialog()
        Me.HuraForm1 = New SSPLM.HuraForm()
        Me.HuraControlBox1 = New SSPLM.HuraControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Send = New SSPLM.HuraButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lst_Attachments = New System.Windows.Forms.ListBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.pic_Preview = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_RemoveAttachment = New SSPLM.HuraButton()
        Me.btn_AddAttachment = New SSPLM.HuraButton()
        Me.txt_Body = New System.Windows.Forms.TextBox()
        Me.txt_Subject = New System.Windows.Forms.TextBox()
        Me.txt_BCC = New System.Windows.Forms.TextBox()
        Me.txt_CC = New System.Windows.Forms.TextBox()
        Me.txt_To = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraForm1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MailSenter
        '
        '
        'AttachmentSelect
        '
        Me.AttachmentSelect.FileName = "*.*"
        Me.AttachmentSelect.Filter = "All Files|*"
        Me.AttachmentSelect.FilterIndex = 0
        Me.AttachmentSelect.Multiselect = True
        Me.AttachmentSelect.Title = "Select File(s) to Attach"
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLM.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.Panel1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(530, 517)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Send Mail"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLM.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(427, 2)
        Me.HuraControlBox1.Maximize = True
        Me.HuraControlBox1.Minimize = True
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 1
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_Send)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txt_Body)
        Me.Panel1.Controls.Add(Me.txt_Subject)
        Me.Panel1.Controls.Add(Me.txt_BCC)
        Me.Panel1.Controls.Add(Me.txt_CC)
        Me.Panel1.Controls.Add(Me.txt_To)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 478)
        Me.Panel1.TabIndex = 0
        '
        'btn_Send
        '
        Me.btn_Send.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Send.BackColor = System.Drawing.Color.Transparent
        Me.btn_Send.BaseColour = System.Drawing.Color.White
        Me.btn_Send.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Send.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Send.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Send.Location = New System.Drawing.Point(424, 443)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Send.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Send.Size = New System.Drawing.Size(91, 30)
        Me.btn_Send.TabIndex = 7
        Me.btn_Send.Text = "Send"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lst_Attachments)
        Me.GroupBox1.Controls.Add(Me.Splitter1)
        Me.GroupBox1.Controls.Add(Me.pic_Preview)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 189)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attachments"
        '
        'lst_Attachments
        '
        Me.lst_Attachments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Attachments.ForeColor = System.Drawing.Color.Gray
        Me.lst_Attachments.FormattingEnabled = True
        Me.lst_Attachments.HorizontalScrollbar = True
        Me.lst_Attachments.ItemHeight = 17
        Me.lst_Attachments.Location = New System.Drawing.Point(244, 20)
        Me.lst_Attachments.Name = "lst_Attachments"
        Me.lst_Attachments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_Attachments.Size = New System.Drawing.Size(217, 166)
        Me.lst_Attachments.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(239, 20)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 166)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'pic_Preview
        '
        Me.pic_Preview.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_Preview.Location = New System.Drawing.Point(3, 20)
        Me.pic_Preview.Name = "pic_Preview"
        Me.pic_Preview.Size = New System.Drawing.Size(236, 166)
        Me.pic_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Preview.TabIndex = 2
        Me.pic_Preview.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_RemoveAttachment)
        Me.Panel2.Controls.Add(Me.btn_AddAttachment)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(461, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(39, 166)
        Me.Panel2.TabIndex = 1
        '
        'btn_RemoveAttachment
        '
        Me.btn_RemoveAttachment.BackColor = System.Drawing.Color.Transparent
        Me.btn_RemoveAttachment.BaseColour = System.Drawing.Color.White
        Me.btn_RemoveAttachment.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_RemoveAttachment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RemoveAttachment.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_RemoveAttachment.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveAttachment.Location = New System.Drawing.Point(0, 30)
        Me.btn_RemoveAttachment.Name = "btn_RemoveAttachment"
        Me.btn_RemoveAttachment.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_RemoveAttachment.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveAttachment.Size = New System.Drawing.Size(39, 30)
        Me.btn_RemoveAttachment.TabIndex = 1
        Me.btn_RemoveAttachment.Text = "-"
        '
        'btn_AddAttachment
        '
        Me.btn_AddAttachment.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddAttachment.BaseColour = System.Drawing.Color.White
        Me.btn_AddAttachment.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_AddAttachment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_AddAttachment.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_AddAttachment.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddAttachment.Location = New System.Drawing.Point(0, 0)
        Me.btn_AddAttachment.Name = "btn_AddAttachment"
        Me.btn_AddAttachment.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_AddAttachment.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddAttachment.Size = New System.Drawing.Size(39, 30)
        Me.btn_AddAttachment.TabIndex = 0
        Me.btn_AddAttachment.Text = "+"
        '
        'txt_Body
        '
        Me.txt_Body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Body.BackColor = System.Drawing.Color.White
        Me.txt_Body.Location = New System.Drawing.Point(72, 149)
        Me.txt_Body.Multiline = True
        Me.txt_Body.Name = "txt_Body"
        Me.txt_Body.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Body.Size = New System.Drawing.Size(443, 93)
        Me.txt_Body.TabIndex = 5
        '
        'txt_Subject
        '
        Me.txt_Subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Subject.BackColor = System.Drawing.Color.White
        Me.txt_Subject.Location = New System.Drawing.Point(72, 114)
        Me.txt_Subject.Name = "txt_Subject"
        Me.txt_Subject.Size = New System.Drawing.Size(443, 24)
        Me.txt_Subject.TabIndex = 5
        '
        'txt_BCC
        '
        Me.txt_BCC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BCC.BackColor = System.Drawing.Color.White
        Me.txt_BCC.Location = New System.Drawing.Point(72, 79)
        Me.txt_BCC.Name = "txt_BCC"
        Me.txt_BCC.Size = New System.Drawing.Size(443, 24)
        Me.txt_BCC.TabIndex = 5
        '
        'txt_CC
        '
        Me.txt_CC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CC.BackColor = System.Drawing.Color.White
        Me.txt_CC.Location = New System.Drawing.Point(72, 43)
        Me.txt_CC.Name = "txt_CC"
        Me.txt_CC.Size = New System.Drawing.Size(443, 24)
        Me.txt_CC.TabIndex = 5
        '
        'txt_To
        '
        Me.txt_To.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_To.BackColor = System.Drawing.Color.White
        Me.txt_To.Location = New System.Drawing.Point(72, 8)
        Me.txt_To.Name = "txt_To"
        Me.txt_To.Size = New System.Drawing.Size(443, 24)
        Me.txt_To.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Body :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subject :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BCC :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To :"
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 517)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email"
        Me.HuraForm1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Send As HuraButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lst_Attachments As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_RemoveAttachment As HuraButton
    Friend WithEvents btn_AddAttachment As HuraButton
    Friend WithEvents txt_Body As TextBox
    Friend WithEvents txt_Subject As TextBox
    Friend WithEvents txt_BCC As TextBox
    Friend WithEvents txt_CC As TextBox
    Friend WithEvents txt_To As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MailSenter As System.ComponentModel.BackgroundWorker
    Friend WithEvents AttachmentSelect As OpenFileDialog
    Friend WithEvents pic_Preview As PictureBox
    Friend WithEvents Splitter1 As Splitter
End Class
