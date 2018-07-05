<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApMainForm))
        Me.Notifier = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifierMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckDisks = New System.Windows.Forms.Timer(Me.components)
        Me.Backuper = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundUploader = New System.ComponentModel.BackgroundWorker()
        Me.EarnTheme1 = New SSPLAB.A.EarnTheme()
        Me.HuraControlBox1 = New SSPLAB.A.HuraControlBox()
        Me.AresioTabControl1 = New SSPLAB.A.AresioTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalProgress = New SSPLAB.AVProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CurrrentProgress = New SSPLAB.AVProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.btn_Setup = New SSPLAB.A.EarnButton()
        Me.btn_Stop = New SSPLAB.A.EarnButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UploadingLabel = New System.Windows.Forms.Label()
        Me.btn_Reload = New SSPLAB.A.AresioButton()
        Me.ChoosenFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MarqueeProgressbar = New System.Windows.Forms.ProgressBar()
        Me.TotalUploadProgress = New SSPLAB.AVProgressBar()
        Me.lst_GoogleDrive = New System.Windows.Forms.ListBox()
        Me.btn_StartDriveBackup = New SSPLAB.A.EarnButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_DriveStatus = New System.Windows.Forms.Label()
        Me.lbl_Net = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifierMenu.SuspendLayout()
        Me.EarnTheme1.SuspendLayout()
        Me.AresioTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Notifier
        '
        Me.Notifier.ContextMenuStrip = Me.NotifierMenu
        Me.Notifier.Icon = CType(resources.GetObject("Notifier.Icon"), System.Drawing.Icon)
        Me.Notifier.Text = "Sai Subramanian Pathology Laboratory - Auto Backup"
        Me.Notifier.Visible = True
        '
        'NotifierMenu
        '
        Me.NotifierMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NotifierMenu.Name = "NotifierMenu"
        Me.NotifierMenu.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CheckDisks
        '
        Me.CheckDisks.Enabled = True
        Me.CheckDisks.Interval = 1000
        '
        'Backuper
        '
        '
        'BackgroundUploader
        '
        '
        'EarnTheme1
        '
        Me.EarnTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.EarnTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnTheme1.Controls.Add(Me.HuraControlBox1)
        Me.EarnTheme1.Controls.Add(Me.AresioTabControl1)
        Me.EarnTheme1.Customization = "WU1L//////8="
        Me.EarnTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EarnTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EarnTheme1.Image = Nothing
        Me.EarnTheme1.Location = New System.Drawing.Point(0, 0)
        Me.EarnTheme1.Movable = True
        Me.EarnTheme1.Name = "EarnTheme1"
        Me.EarnTheme1.NoRounding = False
        Me.EarnTheme1.Sizable = True
        Me.EarnTheme1.Size = New System.Drawing.Size(420, 266)
        Me.EarnTheme1.SmartBounds = True
        Me.EarnTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.EarnTheme1.TabIndex = 0
        Me.EarnTheme1.Text = "EarnTheme1"
        Me.EarnTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.Transparent = False
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.HuraControlBox1.ColorScheme = SSPLAB.A.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(318, 3)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = True
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 2
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'AresioTabControl1
        '
        Me.AresioTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AresioTabControl1.Controls.Add(Me.TabPage1)
        Me.AresioTabControl1.Controls.Add(Me.TabPage2)
        Me.AresioTabControl1.ItemSize = New System.Drawing.Size(77, 31)
        Me.AresioTabControl1.Location = New System.Drawing.Point(10, 37)
        Me.AresioTabControl1.Name = "AresioTabControl1"
        Me.AresioTabControl1.SelectedIndex = 0
        Me.AresioTabControl1.Size = New System.Drawing.Size(400, 221)
        Me.AresioTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_Setup)
        Me.TabPage1.Controls.Add(Me.btn_Stop)
        Me.TabPage1.Location = New System.Drawing.Point(4, 35)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(392, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hard Disk"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalProgress)
        Me.GroupBox3.Location = New System.Drawing.Point(127, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(115, 129)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Progress"
        '
        'TotalProgress
        '
        Me.TotalProgress.Angle = 0
        Me.TotalProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalProgress.ForeColor = System.Drawing.Color.Black
        Me.TotalProgress.Location = New System.Drawing.Point(3, 19)
        Me.TotalProgress.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalProgress.Name = "TotalProgress"
        Me.TotalProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalProgress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalProgress.Size = New System.Drawing.Size(107, 107)
        Me.TotalProgress.Symbol = "%"
        Me.TotalProgress.TabIndex = 0
        Me.TotalProgress.Text = "AvProgressBar2"
        Me.TotalProgress.Thickness = 8
        Me.TotalProgress.Value = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CurrrentProgress)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 129)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Progress"
        '
        'CurrrentProgress
        '
        Me.CurrrentProgress.Angle = 0
        Me.CurrrentProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.CurrrentProgress.ForeColor = System.Drawing.Color.Black
        Me.CurrrentProgress.Location = New System.Drawing.Point(3, 19)
        Me.CurrrentProgress.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CurrrentProgress.Name = "CurrrentProgress"
        Me.CurrrentProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrrentProgress.Size = New System.Drawing.Size(107, 107)
        Me.CurrrentProgress.Symbol = "%"
        Me.CurrrentProgress.TabIndex = 0
        Me.CurrrentProgress.Text = "AvProgressBar1"
        Me.CurrrentProgress.Thickness = 8
        Me.CurrrentProgress.Value = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Status)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 43)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Status.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Status.Location = New System.Drawing.Point(3, 19)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Status.TabIndex = 3
        Me.lbl_Status.Text = "Ready"
        '
        'btn_Setup
        '
        Me.btn_Setup.Customization = "AMAA/wCAAP//////"
        Me.btn_Setup.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Setup.Image = Nothing
        Me.btn_Setup.Location = New System.Drawing.Point(248, 52)
        Me.btn_Setup.Name = "btn_Setup"
        Me.btn_Setup.NoRounding = False
        Me.btn_Setup.Size = New System.Drawing.Size(138, 82)
        Me.btn_Setup.TabIndex = 2
        Me.btn_Setup.Text = "Setup Backup Drive"
        Me.btn_Setup.Transparent = False
        '
        'btn_Stop
        '
        Me.btn_Stop.Customization = "AAD//wAAwP//////"
        Me.btn_Stop.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Stop.Image = Nothing
        Me.btn_Stop.Location = New System.Drawing.Point(248, 140)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.NoRounding = False
        Me.btn_Stop.Size = New System.Drawing.Size(138, 36)
        Me.btn_Stop.TabIndex = 2
        Me.btn_Stop.Text = "Stop Backup"
        Me.btn_Stop.Transparent = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.UploadingLabel)
        Me.TabPage2.Controls.Add(Me.btn_Reload)
        Me.TabPage2.Controls.Add(Me.ChoosenFiles)
        Me.TabPage2.Controls.Add(Me.MarqueeProgressbar)
        Me.TabPage2.Controls.Add(Me.TotalUploadProgress)
        Me.TabPage2.Controls.Add(Me.lst_GoogleDrive)
        Me.TabPage2.Controls.Add(Me.btn_StartDriveBackup)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lbl_DriveStatus)
        Me.TabPage2.Controls.Add(Me.lbl_Net)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 35)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(392, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Google Drive"
        '
        'UploadingLabel
        '
        Me.UploadingLabel.AutoSize = True
        Me.UploadingLabel.Location = New System.Drawing.Point(72, 161)
        Me.UploadingLabel.Name = "UploadingLabel"
        Me.UploadingLabel.Size = New System.Drawing.Size(139, 15)
        Me.UploadingLabel.TabIndex = 9
        Me.UploadingLabel.Text = "Uploading Please Wait..."
        '
        'btn_Reload
        '
        Me.btn_Reload.Location = New System.Drawing.Point(311, 29)
        Me.btn_Reload.Name = "btn_Reload"
        Me.btn_Reload.Size = New System.Drawing.Size(75, 23)
        Me.btn_Reload.TabIndex = 8
        Me.btn_Reload.Text = "Reload"
        '
        'ChoosenFiles
        '
        Me.ChoosenFiles.CheckBoxes = True
        Me.ChoosenFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ChoosenFiles.FullRowSelect = True
        Me.ChoosenFiles.GridLines = True
        Me.ChoosenFiles.Location = New System.Drawing.Point(129, 55)
        Me.ChoosenFiles.Name = "ChoosenFiles"
        Me.ChoosenFiles.Size = New System.Drawing.Size(257, 86)
        Me.ChoosenFiles.TabIndex = 7
        Me.ChoosenFiles.UseCompatibleStateImageBehavior = False
        Me.ChoosenFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 250
        '
        'MarqueeProgressbar
        '
        Me.MarqueeProgressbar.Location = New System.Drawing.Point(75, 147)
        Me.MarqueeProgressbar.Name = "MarqueeProgressbar"
        Me.MarqueeProgressbar.Size = New System.Drawing.Size(168, 10)
        Me.MarqueeProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.MarqueeProgressbar.TabIndex = 6
        '
        'TotalUploadProgress
        '
        Me.TotalUploadProgress.Angle = 0
        Me.TotalUploadProgress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalUploadProgress.ForeColor = System.Drawing.Color.Black
        Me.TotalUploadProgress.Location = New System.Drawing.Point(4, 120)
        Me.TotalUploadProgress.MainColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalUploadProgress.Name = "TotalUploadProgress"
        Me.TotalUploadProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalUploadProgress.Size = New System.Drawing.Size(65, 65)
        Me.TotalUploadProgress.Symbol = "%"
        Me.TotalUploadProgress.TabIndex = 5
        Me.TotalUploadProgress.Text = "AvProgressBar1"
        Me.TotalUploadProgress.Thickness = 5
        Me.TotalUploadProgress.Value = 0
        '
        'lst_GoogleDrive
        '
        Me.lst_GoogleDrive.FormattingEnabled = True
        Me.lst_GoogleDrive.HorizontalScrollbar = True
        Me.lst_GoogleDrive.ItemHeight = 15
        Me.lst_GoogleDrive.Location = New System.Drawing.Point(3, 55)
        Me.lst_GoogleDrive.Name = "lst_GoogleDrive"
        Me.lst_GoogleDrive.Size = New System.Drawing.Size(120, 64)
        Me.lst_GoogleDrive.TabIndex = 4
        '
        'btn_StartDriveBackup
        '
        Me.btn_StartDriveBackup.Customization = "R819/za1VP//////"
        Me.btn_StartDriveBackup.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_StartDriveBackup.Image = Nothing
        Me.btn_StartDriveBackup.Location = New System.Drawing.Point(249, 147)
        Me.btn_StartDriveBackup.Name = "btn_StartDriveBackup"
        Me.btn_StartDriveBackup.NoRounding = False
        Me.btn_StartDriveBackup.Size = New System.Drawing.Size(137, 29)
        Me.btn_StartDriveBackup.TabIndex = 3
        Me.btn_StartDriveBackup.Text = "Start Backup"
        Me.btn_StartDriveBackup.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Uploader Status :"
        '
        'lbl_DriveStatus
        '
        Me.lbl_DriveStatus.AutoSize = True
        Me.lbl_DriveStatus.Location = New System.Drawing.Point(111, 37)
        Me.lbl_DriveStatus.Name = "lbl_DriveStatus"
        Me.lbl_DriveStatus.Size = New System.Drawing.Size(12, 15)
        Me.lbl_DriveStatus.TabIndex = 1
        Me.lbl_DriveStatus.Text = "-"
        '
        'lbl_Net
        '
        Me.lbl_Net.AutoSize = True
        Me.lbl_Net.Location = New System.Drawing.Point(111, 9)
        Me.lbl_Net.Name = "lbl_Net"
        Me.lbl_Net.Size = New System.Drawing.Size(12, 15)
        Me.lbl_Net.TabIndex = 1
        Me.lbl_Net.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Internet Status :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ApMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 266)
        Me.Controls.Add(Me.EarnTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ApMainForm"
        Me.Text = "Sai Subramanian Pathology Laboratory - Auto Backup"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NotifierMenu.ResumeLayout(False)
        Me.EarnTheme1.ResumeLayout(False)
        Me.AresioTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Notifier As NotifyIcon
    Friend WithEvents EarnTheme1 As A.EarnTheme
    Friend WithEvents AresioTabControl1 As A.AresioTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CurrrentProgress As AVProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents btn_Stop As A.EarnButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TotalProgress As AVProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Net As Label
    Friend WithEvents HuraControlBox1 As A.HuraControlBox
    Friend WithEvents CheckDisks As Timer
    Friend WithEvents Backuper As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Setup As A.EarnButton
    Friend WithEvents NotifierMenu As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundUploader As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_DriveStatus As Label
    Friend WithEvents btn_StartDriveBackup As A.EarnButton
    Friend WithEvents lst_GoogleDrive As ListBox
    Friend WithEvents MarqueeProgressbar As ProgressBar
    Friend WithEvents TotalUploadProgress As AVProgressBar
    Friend WithEvents ChoosenFiles As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btn_Reload As A.AresioButton
    Friend WithEvents UploadingLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
