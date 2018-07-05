<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditImage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_OK = New HuraButton()
        Me.ImageEditor1 = New ImageEditor()
        Me.HuraForm1 = New HuraForm()
        Me.HuraControlBox1 = New HuraControlBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.HuraForm1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_OK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 266)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 33)
        Me.Panel1.TabIndex = 1
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.Color.Transparent
        Me.btn_OK.BaseColour = System.Drawing.Color.White
        Me.btn_OK.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_OK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_OK.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_OK.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OK.Location = New System.Drawing.Point(654, 0)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_OK.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OK.Size = New System.Drawing.Size(75, 31)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "OK"
        '
        'ImageEditor1
        '
        Me.ImageEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageEditor1.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageEditor1.Location = New System.Drawing.Point(0, 0)
        Me.ImageEditor1.Name = "ImageEditor1"
        Me.ImageEditor1.Size = New System.Drawing.Size(731, 266)
        Me.ImageEditor1.TabIndex = 0
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.Panel2)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(737, 333)
        Me.HuraForm1.TabIndex = 2
        Me.HuraForm1.Text = "Edit Image"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(635, 2)
        Me.HuraControlBox1.Maximize = True
        Me.HuraControlBox1.Minimize = True
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 1
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ImageEditor1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(731, 299)
        Me.Panel2.TabIndex = 0
        '
        'EditImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 333)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "EditImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Image"
        Me.Panel1.ResumeLayout(False)
        Me.HuraForm1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageEditor1 As ImageEditor
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_OK As HuraButton
    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HuraControlBox1 As HuraControlBox
End Class
