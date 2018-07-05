<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.HuraForm1 = New SSPLMS.HuraForm()
        Me.HuraControlBox1 = New SSPLMS.HuraControlBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New SSPLMS.HuraTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.HuraButton1 = New SSPLMS.HuraButton()
        Me.txt_DefaultFile = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.StatementPageY = New System.Windows.Forms.NumericUpDown()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Statement_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.Statement_Right = New System.Windows.Forms.NumericUpDown()
        Me.Statement_Top = New System.Windows.Forms.NumericUpDown()
        Me.Statement_Left = New System.Windows.Forms.NumericUpDown()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btn_DetailsFont = New SSPLMS.HuraButton()
        Me.btn_HeaderFont = New SSPLMS.HuraButton()
        Me.lbl_DetailsFont = New System.Windows.Forms.Label()
        Me.lbl_HeaderFont = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PrintHeaderOption = New SSPLMS.HuraComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Save = New SSPLMS.HuraButton()
        Me.HuraForm1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.StatementPageY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statement_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statement_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statement_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statement_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLMS.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.Panel2)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(455, 400)
        Me.HuraForm1.TabIndex = 4
        Me.HuraForm1.Text = "Settings"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLMS.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(353, 2)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = False
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 4
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(449, 365)
        Me.Panel2.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(449, 336)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.HuraButton1)
        Me.TabPage1.Controls.Add(Me.txt_DefaultFile)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(441, 298)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Default File"
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(366, 18)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(70, 24)
        Me.HuraButton1.TabIndex = 2
        Me.HuraButton1.Text = "...."
        '
        'txt_DefaultFile
        '
        Me.txt_DefaultFile.Location = New System.Drawing.Point(78, 18)
        Me.txt_DefaultFile.Name = "txt_DefaultFile"
        Me.txt_DefaultFile.Size = New System.Drawing.Size(282, 24)
        Me.txt_DefaultFile.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Filename :"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.StatementPageY)
        Me.TabPage5.Controls.Add(Me.Label46)
        Me.TabPage5.Controls.Add(Me.Statement_Bottom)
        Me.TabPage5.Controls.Add(Me.Statement_Right)
        Me.TabPage5.Controls.Add(Me.Statement_Top)
        Me.TabPage5.Controls.Add(Me.Statement_Left)
        Me.TabPage5.Controls.Add(Me.Label34)
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Controls.Add(Me.Label32)
        Me.TabPage5.Controls.Add(Me.Label31)
        Me.TabPage5.Controls.Add(Me.btn_DetailsFont)
        Me.TabPage5.Controls.Add(Me.btn_HeaderFont)
        Me.TabPage5.Controls.Add(Me.lbl_DetailsFont)
        Me.TabPage5.Controls.Add(Me.lbl_HeaderFont)
        Me.TabPage5.Controls.Add(Me.Label30)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.PrintHeaderOption)
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(441, 298)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Statement"
        '
        'StatementPageY
        '
        Me.StatementPageY.Location = New System.Drawing.Point(121, 235)
        Me.StatementPageY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.StatementPageY.Name = "StatementPageY"
        Me.StatementPageY.Size = New System.Drawing.Size(120, 24)
        Me.StatementPageY.TabIndex = 13
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(8, 237)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(107, 17)
        Me.Label46.TabIndex = 12
        Me.Label46.Text = "Page Number Y :"
        '
        'Statement_Bottom
        '
        Me.Statement_Bottom.Location = New System.Drawing.Point(322, 164)
        Me.Statement_Bottom.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Statement_Bottom.Name = "Statement_Bottom"
        Me.Statement_Bottom.Size = New System.Drawing.Size(112, 24)
        Me.Statement_Bottom.TabIndex = 11
        '
        'Statement_Right
        '
        Me.Statement_Right.Location = New System.Drawing.Point(322, 134)
        Me.Statement_Right.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Statement_Right.Name = "Statement_Right"
        Me.Statement_Right.Size = New System.Drawing.Size(112, 24)
        Me.Statement_Right.TabIndex = 11
        '
        'Statement_Top
        '
        Me.Statement_Top.Location = New System.Drawing.Point(143, 164)
        Me.Statement_Top.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Statement_Top.Name = "Statement_Top"
        Me.Statement_Top.Size = New System.Drawing.Size(110, 24)
        Me.Statement_Top.TabIndex = 11
        '
        'Statement_Left
        '
        Me.Statement_Left.Location = New System.Drawing.Point(143, 134)
        Me.Statement_Left.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Statement_Left.Name = "Statement_Left"
        Me.Statement_Left.Size = New System.Drawing.Size(110, 24)
        Me.Statement_Left.TabIndex = 11
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(259, 166)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 17)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Bottom :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(271, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 17)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Right :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(100, 166)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(37, 17)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Top :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(101, 136)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 17)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "Left :"
        '
        'btn_DetailsFont
        '
        Me.btn_DetailsFont.BackColor = System.Drawing.Color.Transparent
        Me.btn_DetailsFont.BaseColour = System.Drawing.Color.White
        Me.btn_DetailsFont.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_DetailsFont.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_DetailsFont.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_DetailsFont.Location = New System.Drawing.Point(363, 77)
        Me.btn_DetailsFont.Name = "btn_DetailsFont"
        Me.btn_DetailsFont.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_DetailsFont.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_DetailsFont.Size = New System.Drawing.Size(71, 34)
        Me.btn_DetailsFont.TabIndex = 6
        Me.btn_DetailsFont.Text = "..."
        '
        'btn_HeaderFont
        '
        Me.btn_HeaderFont.BackColor = System.Drawing.Color.Transparent
        Me.btn_HeaderFont.BaseColour = System.Drawing.Color.White
        Me.btn_HeaderFont.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_HeaderFont.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_HeaderFont.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_HeaderFont.Location = New System.Drawing.Point(363, 37)
        Me.btn_HeaderFont.Name = "btn_HeaderFont"
        Me.btn_HeaderFont.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_HeaderFont.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_HeaderFont.Size = New System.Drawing.Size(71, 34)
        Me.btn_HeaderFont.TabIndex = 6
        Me.btn_HeaderFont.Text = "..."
        '
        'lbl_DetailsFont
        '
        Me.lbl_DetailsFont.Location = New System.Drawing.Point(101, 77)
        Me.lbl_DetailsFont.Name = "lbl_DetailsFont"
        Me.lbl_DetailsFont.Size = New System.Drawing.Size(256, 34)
        Me.lbl_DetailsFont.TabIndex = 5
        Me.lbl_DetailsFont.Text = "Example"
        '
        'lbl_HeaderFont
        '
        Me.lbl_HeaderFont.Location = New System.Drawing.Point(101, 37)
        Me.lbl_HeaderFont.Name = "lbl_HeaderFont"
        Me.lbl_HeaderFont.Size = New System.Drawing.Size(256, 34)
        Me.lbl_HeaderFont.TabIndex = 5
        Me.lbl_HeaderFont.Text = "Example"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(32, 136)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 17)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Margins :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 77)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 17)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Details Font :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(87, 17)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Header Font :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(11, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 17)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Prin Header :"
        '
        'PrintHeaderOption
        '
        Me.PrintHeaderOption.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PrintHeaderOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintHeaderOption.ColorScheme = SSPLMS.HuraComboBox.ColorSchemes.Dark
        Me.PrintHeaderOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PrintHeaderOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrintHeaderOption.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.PrintHeaderOption.ForeColor = System.Drawing.Color.White
        Me.PrintHeaderOption.FormattingEnabled = True
        Me.PrintHeaderOption.Items.AddRange(New Object() {"First Page Only", "All Pages", "No Header Image"})
        Me.PrintHeaderOption.Location = New System.Drawing.Point(101, 6)
        Me.PrintHeaderOption.Name = "PrintHeaderOption"
        Me.PrintHeaderOption.Size = New System.Drawing.Size(334, 25)
        Me.PrintHeaderOption.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 29)
        Me.Panel1.TabIndex = 1
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.BaseColour = System.Drawing.Color.White
        Me.btn_Save.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Save.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Save.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Save.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Save.Location = New System.Drawing.Point(374, 0)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Save.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Save.Size = New System.Drawing.Size(75, 29)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 400)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(455, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(455, 329)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.HuraForm1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.StatementPageY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statement_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statement_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statement_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statement_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Save As HuraButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As HuraTabControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_DefaultFile As TextBox
    Friend WithEvents HuraButton1 As HuraButton
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Statement_Bottom As NumericUpDown
    Friend WithEvents Statement_Right As NumericUpDown
    Friend WithEvents Statement_Top As NumericUpDown
    Friend WithEvents Statement_Left As NumericUpDown
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents btn_DetailsFont As HuraButton
    Friend WithEvents btn_HeaderFont As HuraButton
    Friend WithEvents lbl_DetailsFont As Label
    Friend WithEvents lbl_HeaderFont As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents PrintHeaderOption As HuraComboBox
    Friend WithEvents StatementPageY As NumericUpDown
    Friend WithEvents Label46 As Label
End Class
