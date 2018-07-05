<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDBackup))
        Me.HuraForm1 = New SSPLM.HuraForm()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_dot = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Next = New SSPLM.HuraButton()
        Me.prog_Total = New SSPLM.AVProgressBar()
        Me.btn_BrowseTemp = New SSPLM.HuraButton()
        Me.txt_Temp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Executables = New SSPLM.HuraCheckBox()
        Me.cb_Settings = New SSPLM.HuraCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lv_DataBase = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HuraControlBox1 = New SSPLM.HuraControlBox()
        Me.FileIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLM.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.Panel1)
        Me.HuraForm1.Controls.Add(Me.Label2)
        Me.HuraForm1.Controls.Add(Me.btn_Next)
        Me.HuraForm1.Controls.Add(Me.prog_Total)
        Me.HuraForm1.Controls.Add(Me.btn_BrowseTemp)
        Me.HuraForm1.Controls.Add(Me.txt_Temp)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.cb_Executables)
        Me.HuraForm1.Controls.Add(Me.cb_Settings)
        Me.HuraForm1.Controls.Add(Me.GroupBox1)
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(641, 338)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Backup Files To CD"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lbl_dot)
        Me.Panel1.Controls.Add(Me.lbl_Status)
        Me.Panel1.Location = New System.Drawing.Point(427, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 41)
        Me.Panel1.TabIndex = 11
        '
        'lbl_dot
        '
        Me.lbl_dot.AutoSize = True
        Me.lbl_dot.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_dot.Location = New System.Drawing.Point(13, 0)
        Me.lbl_dot.Name = "lbl_dot"
        Me.lbl_dot.Size = New System.Drawing.Size(0, 17)
        Me.lbl_dot.TabIndex = 11
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_Status.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Status.TabIndex = 10
        Me.lbl_Status.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Status :"
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.Transparent
        Me.btn_Next.BaseColour = System.Drawing.Color.White
        Me.btn_Next.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Next.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Next.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Next.Location = New System.Drawing.Point(554, 296)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Next.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Next.Size = New System.Drawing.Size(75, 30)
        Me.btn_Next.TabIndex = 8
        Me.btn_Next.Text = "Next"
        '
        'prog_Total
        '
        Me.prog_Total.Angle = 0
        Me.prog_Total.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prog_Total.Location = New System.Drawing.Point(451, 155)
        Me.prog_Total.Name = "prog_Total"
        Me.prog_Total.Size = New System.Drawing.Size(102, 102)
        Me.prog_Total.Symbol = "%"
        Me.prog_Total.TabIndex = 7
        Me.prog_Total.Text = "AvProgressBar1"
        Me.prog_Total.Thickness = 5
        Me.prog_Total.Value = 0
        '
        'btn_BrowseTemp
        '
        Me.btn_BrowseTemp.BackColor = System.Drawing.Color.Transparent
        Me.btn_BrowseTemp.BaseColour = System.Drawing.Color.White
        Me.btn_BrowseTemp.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_BrowseTemp.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_BrowseTemp.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_BrowseTemp.Location = New System.Drawing.Point(586, 128)
        Me.btn_BrowseTemp.Name = "btn_BrowseTemp"
        Me.btn_BrowseTemp.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_BrowseTemp.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_BrowseTemp.Size = New System.Drawing.Size(43, 24)
        Me.btn_BrowseTemp.TabIndex = 6
        Me.btn_BrowseTemp.Text = "..."
        '
        'txt_Temp
        '
        Me.txt_Temp.Location = New System.Drawing.Point(468, 128)
        Me.txt_Temp.Name = "txt_Temp"
        Me.txt_Temp.ReadOnly = True
        Me.txt_Temp.Size = New System.Drawing.Size(112, 24)
        Me.txt_Temp.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Temp Folder :"
        '
        'cb_Executables
        '
        Me.cb_Executables.BaseColour = System.Drawing.Color.White
        Me.cb_Executables.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Executables.Checked = True
        Me.cb_Executables.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cb_Executables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Executables.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cb_Executables.Location = New System.Drawing.Point(374, 71)
        Me.cb_Executables.Name = "cb_Executables"
        Me.cb_Executables.Size = New System.Drawing.Size(155, 22)
        Me.cb_Executables.TabIndex = 3
        Me.cb_Executables.Text = "Backup Executables"
        '
        'cb_Settings
        '
        Me.cb_Settings.BaseColour = System.Drawing.Color.White
        Me.cb_Settings.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Settings.Checked = True
        Me.cb_Settings.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cb_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Settings.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cb_Settings.Location = New System.Drawing.Point(374, 43)
        Me.cb_Settings.Name = "cb_Settings"
        Me.cb_Settings.Size = New System.Drawing.Size(134, 22)
        Me.cb_Settings.TabIndex = 3
        Me.cb_Settings.Text = "Backup Settings"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lv_DataBase)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 291)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Databases To Backup"
        '
        'lv_DataBase
        '
        Me.lv_DataBase.CheckBoxes = True
        Me.lv_DataBase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_DataBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_DataBase.FullRowSelect = True
        Me.lv_DataBase.GridLines = True
        Me.lv_DataBase.Location = New System.Drawing.Point(3, 20)
        Me.lv_DataBase.Name = "lv_DataBase"
        Me.lv_DataBase.Size = New System.Drawing.Size(350, 268)
        Me.lv_DataBase.TabIndex = 1
        Me.lv_DataBase.UseCompatibleStateImageBehavior = False
        Me.lv_DataBase.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        Me.ColumnHeader1.Width = 190
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size in MB"
        Me.ColumnHeader2.Width = 83
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Path"
        Me.ColumnHeader3.Width = 432
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLM.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(538, 2)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = False
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 0
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'FileIconList
        '
        Me.FileIconList.ImageStream = CType(resources.GetObject("FileIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FileIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.FileIconList.Images.SetKeyName(0, "ACCICONS_100.ico")
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CDBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 338)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CDBackup"
        Me.Text = "Backup Files to CD"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lv_DataBase As ListView
    Friend WithEvents FileIconList As ImageList
    Friend WithEvents btn_BrowseTemp As HuraButton
    Friend WithEvents txt_Temp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Executables As HuraCheckBox
    Friend WithEvents cb_Settings As HuraCheckBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btn_Next As HuraButton
    Friend WithEvents prog_Total As AVProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Status As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_dot As Label
    Friend WithEvents Timer1 As Timer
End Class
