<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupBackup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lv_Drives = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.EarnTheme1 = New SSPLAB.A.EarnTheme()
        Me.btn_Setup = New SSPLAB.A.EarnButton()
        Me.HuraControlBox1 = New SSPLAB.A.HuraControlBox()
        Me.GroupBox1.SuspendLayout()
        Me.EarnTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lv_Drives)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Drive to Setup Backup"
        '
        'lv_Drives
        '
        Me.lv_Drives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv_Drives.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Drives.FullRowSelect = True
        Me.lv_Drives.GridLines = True
        Me.lv_Drives.Location = New System.Drawing.Point(3, 19)
        Me.lv_Drives.Name = "lv_Drives"
        Me.lv_Drives.Size = New System.Drawing.Size(606, 149)
        Me.lv_Drives.SmallImageList = Me.ImageList1
        Me.lv_Drives.TabIndex = 0
        Me.lv_Drives.UseCompatibleStateImageBehavior = False
        Me.lv_Drives.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Disk Label"
        Me.ColumnHeader1.Width = 174
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Drive Type"
        Me.ColumnHeader3.Width = 86
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Size"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Free Size"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 99
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Available Free Size"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 117
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "32.ico")
        '
        'EarnTheme1
        '
        Me.EarnTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.EarnTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EarnTheme1.Controls.Add(Me.btn_Setup)
        Me.EarnTheme1.Controls.Add(Me.HuraControlBox1)
        Me.EarnTheme1.Controls.Add(Me.GroupBox1)
        Me.EarnTheme1.Customization = "WU1L//////8="
        Me.EarnTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EarnTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EarnTheme1.Image = Nothing
        Me.EarnTheme1.Location = New System.Drawing.Point(0, 0)
        Me.EarnTheme1.Movable = True
        Me.EarnTheme1.Name = "EarnTheme1"
        Me.EarnTheme1.NoRounding = False
        Me.EarnTheme1.Sizable = True
        Me.EarnTheme1.Size = New System.Drawing.Size(634, 261)
        Me.EarnTheme1.SmartBounds = True
        Me.EarnTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.EarnTheme1.TabIndex = 1
        Me.EarnTheme1.Text = "EarnTheme1"
        Me.EarnTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EarnTheme1.Transparent = False
        '
        'btn_Setup
        '
        Me.btn_Setup.Customization = "AMAA/wCAAP//////"
        Me.btn_Setup.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Setup.Image = Nothing
        Me.btn_Setup.Location = New System.Drawing.Point(481, 214)
        Me.btn_Setup.Name = "btn_Setup"
        Me.btn_Setup.NoRounding = False
        Me.btn_Setup.Size = New System.Drawing.Size(138, 31)
        Me.btn_Setup.TabIndex = 3
        Me.btn_Setup.Text = "Setup Backup Drive"
        Me.btn_Setup.Transparent = False
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.HuraControlBox1.ColorScheme = SSPLAB.A.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(534, 0)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = False
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 1
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'SetupBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 261)
        Me.Controls.Add(Me.EarnTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetupBackup"
        Me.Text = "SetupBackup"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GroupBox1.ResumeLayout(False)
        Me.EarnTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lv_Drives As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents EarnTheme1 As A.EarnTheme
    Friend WithEvents HuraControlBox1 As A.HuraControlBox
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btn_Setup As A.EarnButton
    Friend WithEvents ImageList1 As ImageList
End Class
