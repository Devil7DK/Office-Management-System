<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Crop
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_cropped = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_original = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_Bottom = New System.Windows.Forms.NumericUpDown()
        Me.txt_Top = New System.Windows.Forms.NumericUpDown()
        Me.txt_Right = New System.Windows.Forms.NumericUpDown()
        Me.txt_Left = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_ImageContainer = New System.Windows.Forms.Panel()
        Me.PB_Image = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ImageContainer.SuspendLayout()
        CType(Me.PB_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_cropped)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl_original)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txt_Bottom)
        Me.Panel1.Controls.Add(Me.txt_Top)
        Me.Panel1.Controls.Add(Me.txt_Right)
        Me.Panel1.Controls.Add(Me.txt_Left)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(224, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 323)
        Me.Panel1.TabIndex = 0
        '
        'lbl_cropped
        '
        Me.lbl_cropped.AutoSize = True
        Me.lbl_cropped.Location = New System.Drawing.Point(119, 154)
        Me.lbl_cropped.Name = "lbl_cropped"
        Me.lbl_cropped.Size = New System.Drawing.Size(10, 13)
        Me.lbl_cropped.TabIndex = 12
        Me.lbl_cropped.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Cropped Image Size :"
        '
        'lbl_original
        '
        Me.lbl_original.AutoSize = True
        Me.lbl_original.Location = New System.Drawing.Point(119, 127)
        Me.lbl_original.Name = "lbl_original"
        Me.lbl_original.Size = New System.Drawing.Size(10, 13)
        Me.lbl_original.TabIndex = 10
        Me.lbl_original.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Original Image Size :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 142)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txt_Bottom
        '
        Me.txt_Bottom.Location = New System.Drawing.Point(55, 93)
        Me.txt_Bottom.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_Bottom.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.txt_Bottom.Name = "txt_Bottom"
        Me.txt_Bottom.Size = New System.Drawing.Size(195, 20)
        Me.txt_Bottom.TabIndex = 7
        '
        'txt_Top
        '
        Me.txt_Top.Location = New System.Drawing.Point(55, 64)
        Me.txt_Top.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_Top.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.txt_Top.Name = "txt_Top"
        Me.txt_Top.Size = New System.Drawing.Size(195, 20)
        Me.txt_Top.TabIndex = 6
        '
        'txt_Right
        '
        Me.txt_Right.Location = New System.Drawing.Point(55, 35)
        Me.txt_Right.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_Right.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.txt_Right.Name = "txt_Right"
        Me.txt_Right.Size = New System.Drawing.Size(195, 20)
        Me.txt_Right.TabIndex = 5
        '
        'txt_Left
        '
        Me.txt_Left.Location = New System.Drawing.Point(55, 6)
        Me.txt_Left.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_Left.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.txt_Left.Name = "txt_Left"
        Me.txt_Left.Size = New System.Drawing.Size(195, 20)
        Me.txt_Left.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bottom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Top :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Right :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Left :"
        '
        'Panel_ImageContainer
        '
        Me.Panel_ImageContainer.Controls.Add(Me.PB_Image)
        Me.Panel_ImageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ImageContainer.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ImageContainer.Name = "Panel_ImageContainer"
        Me.Panel_ImageContainer.Size = New System.Drawing.Size(224, 323)
        Me.Panel_ImageContainer.TabIndex = 1
        '
        'PB_Image
        '
        Me.PB_Image.BackColor = System.Drawing.SystemColors.ControlText
        Me.PB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_Image.Location = New System.Drawing.Point(3, 9)
        Me.PB_Image.Name = "PB_Image"
        Me.PB_Image.Size = New System.Drawing.Size(100, 50)
        Me.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Image.TabIndex = 0
        Me.PB_Image.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btn_Cancel)
        Me.Panel3.Controls.Add(Me.btn_OK)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 323)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 34)
        Me.Panel3.TabIndex = 2
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(321, 5)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(402, 5)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'frm_Crop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 357)
        Me.Controls.Add(Me.Panel_ImageContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frm_Crop"
        Me.Text = "Crop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ImageContainer.ResumeLayout(False)
        CType(Me.PB_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_ImageContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Left As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_Bottom As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_Top As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_Right As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Image As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_original As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_cropped As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
End Class
