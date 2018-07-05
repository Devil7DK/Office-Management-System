<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartNewDb
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
        Me.HuraForm1 = New SSPLM.HuraForm()
        Me.txt_status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_CreateNewYear = New SSPLM.HuraButton()
        Me.txt_Year = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraControlBox1 = New SSPLM.HuraControlBox()
        Me.Worker_Compact = New System.ComponentModel.BackgroundWorker()
        Me.HuraForm1.SuspendLayout()
        CType(Me.txt_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLM.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.txt_status)
        Me.HuraForm1.Controls.Add(Me.Label2)
        Me.HuraForm1.Controls.Add(Me.btn_CreateNewYear)
        Me.HuraForm1.Controls.Add(Me.txt_Year)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(312, 161)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Start New Year"
        '
        'txt_status
        '
        Me.txt_status.AutoSize = True
        Me.txt_status.Location = New System.Drawing.Point(115, 85)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(44, 17)
        Me.txt_status.TabIndex = 6
        Me.txt_status.Text = "Ready"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Status :"
        '
        'btn_CreateNewYear
        '
        Me.btn_CreateNewYear.BackColor = System.Drawing.Color.Transparent
        Me.btn_CreateNewYear.BaseColour = System.Drawing.Color.White
        Me.btn_CreateNewYear.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_CreateNewYear.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_CreateNewYear.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_CreateNewYear.Location = New System.Drawing.Point(209, 128)
        Me.btn_CreateNewYear.Name = "btn_CreateNewYear"
        Me.btn_CreateNewYear.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_CreateNewYear.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_CreateNewYear.Size = New System.Drawing.Size(100, 30)
        Me.btn_CreateNewYear.TabIndex = 4
        Me.btn_CreateNewYear.Text = "Create New Year"
        '
        'txt_Year
        '
        Me.txt_Year.Location = New System.Drawing.Point(118, 45)
        Me.txt_Year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txt_Year.Minimum = New Decimal(New Integer() {1999, 0, 0, 0})
        Me.txt_Year.Name = "txt_Year"
        Me.txt_Year.Size = New System.Drawing.Size(168, 24)
        Me.txt_Year.TabIndex = 3
        Me.txt_Year.Value = New Decimal(New Integer() {1999, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select the Year :"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLM.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(209, 2)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = False
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 0
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Worker_Compact
        '
        '
        'StartNewDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 161)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartNewDb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartNewDb"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        CType(Me.txt_Year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents btn_CreateNewYear As HuraButton
    Friend WithEvents txt_Year As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_status As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Worker_Compact As System.ComponentModel.BackgroundWorker
End Class
