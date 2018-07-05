<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Burner
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
        Me.Burn_Worker = New System.ComponentModel.BackgroundWorker()
        Me.HuraForm1 = New SSPLM.HuraForm()
        Me.listBoxFiles = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_BurnStatus = New System.Windows.Forms.Label()
        Me.btn_Start = New SSPLM.HuraButton()
        Me.BurnProgress = New SSPLM.AVProgressBar()
        Me.check_Eject = New SSPLM.HuraCheckBox()
        Me.check_CloseMedia = New SSPLM.HuraCheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_MediaType = New System.Windows.Forms.Label()
        Me.lbl_MediaSize = New System.Windows.Forms.Label()
        Me.btn_DetectMedia = New SSPLM.HuraButton()
        Me.DiskSize = New SSPLM.AVProgressBar()
        Me.cb_Verification = New SSPLM.HuraComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Lable = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_SupportedMedia = New System.Windows.Forms.Label()
        Me.btn_Refresh = New SSPLM.HuraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Devices = New SSPLM.HuraComboBox()
        Me.HuraControlBox1 = New SSPLM.HuraControlBox()
        Me.HuraForm1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Burn_Worker
        '
        Me.Burn_Worker.WorkerReportsProgress = True
        Me.Burn_Worker.WorkerSupportsCancellation = True
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLM.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.listBoxFiles)
        Me.HuraForm1.Controls.Add(Me.GroupBox3)
        Me.HuraForm1.Controls.Add(Me.check_Eject)
        Me.HuraForm1.Controls.Add(Me.check_CloseMedia)
        Me.HuraForm1.Controls.Add(Me.GroupBox2)
        Me.HuraForm1.Controls.Add(Me.cb_Verification)
        Me.HuraForm1.Controls.Add(Me.Label3)
        Me.HuraForm1.Controls.Add(Me.txt_Lable)
        Me.HuraForm1.Controls.Add(Me.Label2)
        Me.HuraForm1.Controls.Add(Me.GroupBox1)
        Me.HuraForm1.Controls.Add(Me.btn_Refresh)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.cb_Devices)
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(630, 524)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "CD/DVD Burner"
        '
        'listBoxFiles
        '
        Me.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.listBoxFiles.FormattingEnabled = True
        Me.listBoxFiles.HorizontalScrollbar = True
        Me.listBoxFiles.ItemHeight = 24
        Me.listBoxFiles.Location = New System.Drawing.Point(15, 171)
        Me.listBoxFiles.Name = "listBoxFiles"
        Me.listBoxFiles.Size = New System.Drawing.Size(309, 340)
        Me.listBoxFiles.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lbl_BurnStatus)
        Me.GroupBox3.Controls.Add(Me.btn_Start)
        Me.GroupBox3.Controls.Add(Me.BurnProgress)
        Me.GroupBox3.Location = New System.Drawing.Point(330, 394)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 119)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Burning Process"
        '
        'lbl_BurnStatus
        '
        Me.lbl_BurnStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_BurnStatus.Location = New System.Drawing.Point(99, 20)
        Me.lbl_BurnStatus.Name = "lbl_BurnStatus"
        Me.lbl_BurnStatus.Size = New System.Drawing.Size(186, 60)
        Me.lbl_BurnStatus.TabIndex = 15
        Me.lbl_BurnStatus.Text = "Ready"
        Me.lbl_BurnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.Transparent
        Me.btn_Start.BaseColour = System.Drawing.Color.White
        Me.btn_Start.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Start.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Start.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Start.Location = New System.Drawing.Point(198, 83)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Start.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Start.Size = New System.Drawing.Size(84, 30)
        Me.btn_Start.TabIndex = 14
        Me.btn_Start.Text = "Start"
        '
        'BurnProgress
        '
        Me.BurnProgress.Angle = 0
        Me.BurnProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.BurnProgress.Font = New System.Drawing.Font("DigifaceWide", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BurnProgress.Location = New System.Drawing.Point(3, 20)
        Me.BurnProgress.Name = "BurnProgress"
        Me.BurnProgress.Size = New System.Drawing.Size(96, 96)
        Me.BurnProgress.Symbol = "%"
        Me.BurnProgress.TabIndex = 13
        Me.BurnProgress.Text = "AvProgressBar1"
        Me.BurnProgress.Thickness = 5
        Me.BurnProgress.Value = 0
        '
        'check_Eject
        '
        Me.check_Eject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_Eject.BaseColour = System.Drawing.Color.White
        Me.check_Eject.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.check_Eject.Checked = False
        Me.check_Eject.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.check_Eject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.check_Eject.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.check_Eject.Location = New System.Drawing.Point(474, 241)
        Me.check_Eject.Name = "check_Eject"
        Me.check_Eject.Size = New System.Drawing.Size(141, 22)
        Me.check_Eject.TabIndex = 14
        Me.check_Eject.Text = "Eject when finished"
        '
        'check_CloseMedia
        '
        Me.check_CloseMedia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.check_CloseMedia.BaseColour = System.Drawing.Color.White
        Me.check_CloseMedia.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.check_CloseMedia.Checked = False
        Me.check_CloseMedia.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.check_CloseMedia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.check_CloseMedia.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.check_CloseMedia.Location = New System.Drawing.Point(333, 241)
        Me.check_CloseMedia.Name = "check_CloseMedia"
        Me.check_CloseMedia.Size = New System.Drawing.Size(107, 22)
        Me.check_CloseMedia.TabIndex = 14
        Me.check_CloseMedia.Text = "Check Media"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_MediaType)
        Me.GroupBox2.Controls.Add(Me.lbl_MediaSize)
        Me.GroupBox2.Controls.Add(Me.btn_DetectMedia)
        Me.GroupBox2.Controls.Add(Me.DiskSize)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 119)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Media"
        '
        'lbl_MediaType
        '
        Me.lbl_MediaType.Location = New System.Drawing.Point(105, 20)
        Me.lbl_MediaType.Name = "lbl_MediaType"
        Me.lbl_MediaType.Size = New System.Drawing.Size(93, 47)
        Me.lbl_MediaType.TabIndex = 15
        Me.lbl_MediaType.Text = "-"
        '
        'lbl_MediaSize
        '
        Me.lbl_MediaSize.Location = New System.Drawing.Point(105, 70)
        Me.lbl_MediaSize.Name = "lbl_MediaSize"
        Me.lbl_MediaSize.Size = New System.Drawing.Size(177, 46)
        Me.lbl_MediaSize.TabIndex = 14
        Me.lbl_MediaSize.Text = "Size : 0 MB"
        '
        'btn_DetectMedia
        '
        Me.btn_DetectMedia.BackColor = System.Drawing.Color.Transparent
        Me.btn_DetectMedia.BaseColour = System.Drawing.Color.White
        Me.btn_DetectMedia.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_DetectMedia.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_DetectMedia.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_DetectMedia.Location = New System.Drawing.Point(205, 23)
        Me.btn_DetectMedia.Name = "btn_DetectMedia"
        Me.btn_DetectMedia.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_DetectMedia.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_DetectMedia.Size = New System.Drawing.Size(77, 30)
        Me.btn_DetectMedia.TabIndex = 13
        Me.btn_DetectMedia.Text = "Detect Media"
        '
        'DiskSize
        '
        Me.DiskSize.Angle = 0
        Me.DiskSize.Dock = System.Windows.Forms.DockStyle.Left
        Me.DiskSize.Font = New System.Drawing.Font("DigifaceWide", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiskSize.Location = New System.Drawing.Point(3, 20)
        Me.DiskSize.Name = "DiskSize"
        Me.DiskSize.Size = New System.Drawing.Size(96, 96)
        Me.DiskSize.Symbol = "%"
        Me.DiskSize.TabIndex = 12
        Me.DiskSize.Text = "AvProgressBar1"
        Me.DiskSize.Thickness = 5
        Me.DiskSize.Value = 0
        '
        'cb_Verification
        '
        Me.cb_Verification.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Verification.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Verification.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Verification.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.cb_Verification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_Verification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Verification.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cb_Verification.ForeColor = System.Drawing.Color.White
        Me.cb_Verification.FormattingEnabled = True
        Me.cb_Verification.Location = New System.Drawing.Point(433, 198)
        Me.cb_Verification.Name = "cb_Verification"
        Me.cb_Verification.Size = New System.Drawing.Size(185, 25)
        Me.cb_Verification.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Verification :"
        '
        'txt_Lable
        '
        Me.txt_Lable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Lable.Location = New System.Drawing.Point(433, 169)
        Me.txt_Lable.Name = "txt_Lable"
        Me.txt_Lable.Size = New System.Drawing.Size(185, 24)
        Me.txt_Lable.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Volume Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_SupportedMedia)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 87)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supported Media"
        '
        'txt_SupportedMedia
        '
        Me.txt_SupportedMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SupportedMedia.Location = New System.Drawing.Point(3, 20)
        Me.txt_SupportedMedia.Name = "txt_SupportedMedia"
        Me.txt_SupportedMedia.Size = New System.Drawing.Size(597, 64)
        Me.txt_SupportedMedia.TabIndex = 0
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_Refresh.BaseColour = System.Drawing.Color.White
        Me.btn_Refresh.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Refresh.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Refresh.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Refresh.Location = New System.Drawing.Point(552, 45)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Refresh.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Refresh.Size = New System.Drawing.Size(66, 25)
        Me.btn_Refresh.TabIndex = 4
        Me.btn_Refresh.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Device :"
        '
        'cb_Devices
        '
        Me.cb_Devices.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Devices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Devices.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Devices.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.cb_Devices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_Devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Devices.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cb_Devices.ForeColor = System.Drawing.Color.White
        Me.cb_Devices.FormattingEnabled = True
        Me.cb_Devices.Location = New System.Drawing.Point(71, 45)
        Me.cb_Devices.Name = "cb_Devices"
        Me.cb_Devices.Size = New System.Drawing.Size(477, 25)
        Me.cb_Devices.TabIndex = 2
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLM.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(528, 2)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = False
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 1
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Burner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 524)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Burner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Burner"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents btn_Refresh As HuraButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Devices As HuraComboBox
    Friend WithEvents txt_Lable As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_SupportedMedia As Label
    Friend WithEvents cb_Verification As HuraComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DiskSize As AVProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_MediaSize As Label
    Friend WithEvents btn_DetectMedia As HuraButton
    Friend WithEvents lbl_MediaType As Label
    Friend WithEvents check_Eject As HuraCheckBox
    Friend WithEvents check_CloseMedia As HuraCheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_BurnStatus As Label
    Friend WithEvents btn_Start As HuraButton
    Friend WithEvents BurnProgress As AVProgressBar
    Friend WithEvents Burn_Worker As System.ComponentModel.BackgroundWorker
    Private WithEvents listBoxFiles As ListBox
End Class
