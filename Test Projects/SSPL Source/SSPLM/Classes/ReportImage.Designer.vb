<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportImage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pic_ = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_ImageName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_Valid = New SSPLM.HuraCheckBox()
        Me.btn_Edit = New SSPLM.HuraButton()
        Me.btn_SelectFromFile = New SSPLM.HuraButton()
        Me.btn_Capture = New SSPLM.HuraButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SelectFromFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.pic_)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 313)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image 1"
        '
        'pic_
        '
        Me.pic_.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pic_.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_.Location = New System.Drawing.Point(3, 16)
        Me.pic_.Name = "pic_"
        Me.pic_.Size = New System.Drawing.Size(394, 249)
        Me.pic_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_.TabIndex = 1
        Me.pic_.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_Edit)
        Me.Panel1.Controls.Add(Me.btn_SelectFromFile)
        Me.Panel1.Controls.Add(Me.btn_Capture)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 45)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_ImageName)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(207, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 21)
        Me.Panel3.TabIndex = 4
        '
        'txt_ImageName
        '
        Me.txt_ImageName.BackColor = System.Drawing.Color.White
        Me.txt_ImageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ImageName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ImageName.Location = New System.Drawing.Point(45, 0)
        Me.txt_ImageName.Name = "txt_ImageName"
        Me.txt_ImageName.Size = New System.Drawing.Size(140, 20)
        Me.txt_ImageName.TabIndex = 1
        Me.txt_ImageName.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cb_Valid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(207, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 22)
        Me.Panel2.TabIndex = 3
        '
        'cb_Valid
        '
        Me.cb_Valid.BaseColour = System.Drawing.Color.White
        Me.cb_Valid.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Valid.Checked = False
        Me.cb_Valid.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cb_Valid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Valid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Valid.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cb_Valid.Location = New System.Drawing.Point(0, 0)
        Me.cb_Valid.Name = "cb_Valid"
        Me.cb_Valid.Size = New System.Drawing.Size(185, 22)
        Me.cb_Valid.TabIndex = 0
        Me.cb_Valid.TabStop = False
        Me.cb_Valid.Text = "Use this"
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit.BaseColour = System.Drawing.Color.White
        Me.btn_Edit.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Edit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Edit.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Edit.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(144, 0)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Edit.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Size = New System.Drawing.Size(63, 43)
        Me.btn_Edit.TabIndex = 2
        Me.btn_Edit.TabStop = False
        Me.btn_Edit.Text = "Edit Image"
        Me.ToolTip1.SetToolTip(Me.btn_Edit, "Edit Image")
        '
        'btn_SelectFromFile
        '
        Me.btn_SelectFromFile.BackColor = System.Drawing.Color.Transparent
        Me.btn_SelectFromFile.BaseColour = System.Drawing.Color.White
        Me.btn_SelectFromFile.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_SelectFromFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_SelectFromFile.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_SelectFromFile.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_SelectFromFile.Location = New System.Drawing.Point(78, 0)
        Me.btn_SelectFromFile.Name = "btn_SelectFromFile"
        Me.btn_SelectFromFile.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_SelectFromFile.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_SelectFromFile.Size = New System.Drawing.Size(66, 43)
        Me.btn_SelectFromFile.TabIndex = 1
        Me.btn_SelectFromFile.TabStop = False
        Me.btn_SelectFromFile.Text = "From File"
        Me.ToolTip1.SetToolTip(Me.btn_SelectFromFile, "Select From File")
        '
        'btn_Capture
        '
        Me.btn_Capture.BackColor = System.Drawing.Color.Transparent
        Me.btn_Capture.BaseColour = System.Drawing.Color.White
        Me.btn_Capture.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Capture.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Capture.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Capture.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Capture.Location = New System.Drawing.Point(0, 0)
        Me.btn_Capture.Name = "btn_Capture"
        Me.btn_Capture.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Capture.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Capture.Size = New System.Drawing.Size(78, 43)
        Me.btn_Capture.TabIndex = 0
        Me.btn_Capture.TabStop = False
        Me.btn_Capture.Text = "From Camera"
        Me.ToolTip1.SetToolTip(Me.btn_Capture, "Capture Image Using Camera")
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Information"
        '
        'SelectFromFile
        '
        Me.SelectFromFile.FileName = "*.*"
        Me.SelectFromFile.Filter = "All Image Files|*.bmp;*.gif;*.emf;*.exif;*.jpg;*.jpeg;*.png;*.tiff;*.wmf"
        Me.SelectFromFile.FilterIndex = 0
        Me.SelectFromFile.Title = "Select Image From File"
        '
        'ReportImage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReportImage"
        Me.Size = New System.Drawing.Size(400, 313)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Edit As HuraButton
    Friend WithEvents btn_SelectFromFile As HuraButton
    Friend WithEvents btn_Capture As HuraButton
    Friend WithEvents pic_ As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SelectFromFile As OpenFileDialog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_ImageName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cb_Valid As HuraCheckBox
End Class
