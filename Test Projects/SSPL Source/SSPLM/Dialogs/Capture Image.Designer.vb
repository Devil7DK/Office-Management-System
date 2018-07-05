<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capture_Image
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Capture_Image))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.picCapture = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.Panel()
        Me.cmb_devices = New SSPLM.HuraComboBox()
        Me.Button_Connect = New SSPLM.HuraButton()
        Me.Button_Save = New SSPLM.HuraButton()
        Me.btn_OK = New SSPLM.HuraButton()
        Me.ComboBox_FrameSize = New SSPLM.HuraComboBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 537)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(653, 511)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.picCapture)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(645, 485)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Camera"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'picCapture
        '
        Me.picCapture.BackColor = System.Drawing.Color.Black
        Me.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCapture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCapture.Location = New System.Drawing.Point(3, 3)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(639, 479)
        Me.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCapture.TabIndex = 1
        Me.picCapture.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(646, 490)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Captured"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 484)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_devices)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.Button_Save)
        Me.GroupBox1.Controls.Add(Me.btn_OK)
        Me.GroupBox1.Controls.Add(Me.ComboBox_FrameSize)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 511)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 26)
        Me.GroupBox1.TabIndex = 0
        '
        'cmb_devices
        '
        Me.cmb_devices.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmb_devices.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_devices.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.cmb_devices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_devices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_devices.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmb_devices.ForeColor = System.Drawing.Color.White
        Me.cmb_devices.FormattingEnabled = True
        Me.cmb_devices.Location = New System.Drawing.Point(116, 0)
        Me.cmb_devices.Name = "cmb_devices"
        Me.cmb_devices.Size = New System.Drawing.Size(341, 25)
        Me.cmb_devices.TabIndex = 0
        '
        'Button_Connect
        '
        Me.Button_Connect.BackColor = System.Drawing.Color.Transparent
        Me.Button_Connect.BaseColour = System.Drawing.Color.White
        Me.Button_Connect.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button_Connect.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_Connect.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Button_Connect.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Connect.Location = New System.Drawing.Point(457, 0)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button_Connect.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Connect.Size = New System.Drawing.Size(75, 26)
        Me.Button_Connect.TabIndex = 2
        Me.Button_Connect.Text = "Connect"
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.Transparent
        Me.Button_Save.BaseColour = System.Drawing.Color.White
        Me.Button_Save.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button_Save.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_Save.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Button_Save.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Save.Location = New System.Drawing.Point(532, 0)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button_Save.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Save.Size = New System.Drawing.Size(66, 26)
        Me.Button_Save.TabIndex = 1
        Me.Button_Save.Text = "Capture"
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.Color.Transparent
        Me.btn_OK.BaseColour = System.Drawing.Color.White
        Me.btn_OK.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_OK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_OK.Enabled = False
        Me.btn_OK.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_OK.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OK.Location = New System.Drawing.Point(598, 0)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_OK.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OK.Size = New System.Drawing.Size(55, 26)
        Me.btn_OK.TabIndex = 3
        Me.btn_OK.Text = "Ok"
        '
        'ComboBox_FrameSize
        '
        Me.ComboBox_FrameSize.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ComboBox_FrameSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox_FrameSize.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.ComboBox_FrameSize.Dock = System.Windows.Forms.DockStyle.Left
        Me.ComboBox_FrameSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_FrameSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FrameSize.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.ComboBox_FrameSize.ForeColor = System.Drawing.Color.White
        Me.ComboBox_FrameSize.FormattingEnabled = True
        Me.ComboBox_FrameSize.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox_FrameSize.Name = "ComboBox_FrameSize"
        Me.ComboBox_FrameSize.Size = New System.Drawing.Size(116, 25)
        Me.ComboBox_FrameSize.TabIndex = 4
        '
        'Capture_Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 537)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(343, 359)
        Me.Name = "Capture_Image"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture Image"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Panel
    Friend WithEvents Button_Connect As HuraButton
    Friend WithEvents Button_Save As HuraButton
    Friend WithEvents picCapture As PictureBox
    Friend WithEvents btn_OK As HuraButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmb_devices As HuraComboBox
    Friend WithEvents ComboBox_FrameSize As HuraComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
End Class
