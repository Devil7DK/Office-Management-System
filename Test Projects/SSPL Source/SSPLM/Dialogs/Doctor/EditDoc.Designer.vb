<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditDoc))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Edit = New SSPLM.HuraButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Hospital = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Pincode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Area = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Street = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.HuraForm1 = New SSPLM.HuraForm()
        Me.HuraControlBox1 = New SSPLM.HuraControlBox()
        Me.Panel1.SuspendLayout()
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_Edit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_Hospital)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_Phone)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Pincode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_City)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_Area)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_Street)
        Me.Panel1.Controls.Add(Me.txt_Name)
        Me.Panel1.Location = New System.Drawing.Point(3, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 291)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Doctor Name :"
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit.BaseColour = System.Drawing.Color.White
        Me.btn_Edit.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Edit.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Edit.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(276, 254)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Edit.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Size = New System.Drawing.Size(72, 28)
        Me.btn_Edit.TabIndex = 22
        Me.btn_Edit.Text = "Add"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Street :"
        '
        'txt_Hospital
        '
        Me.txt_Hospital.BackColor = System.Drawing.Color.White
        Me.txt_Hospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Hospital.Location = New System.Drawing.Point(109, 222)
        Me.txt_Hospital.Name = "txt_Hospital"
        Me.txt_Hospital.Size = New System.Drawing.Size(239, 24)
        Me.txt_Hospital.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Area :"
        '
        'txt_Phone
        '
        Me.txt_Phone.BackColor = System.Drawing.Color.White
        Me.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Phone.Location = New System.Drawing.Point(109, 187)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(239, 24)
        Me.txt_Phone.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "City :"
        '
        'txt_Pincode
        '
        Me.txt_Pincode.BackColor = System.Drawing.Color.White
        Me.txt_Pincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pincode.Location = New System.Drawing.Point(109, 152)
        Me.txt_Pincode.Name = "txt_Pincode"
        Me.txt_Pincode.Size = New System.Drawing.Size(239, 24)
        Me.txt_Pincode.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pincode :"
        '
        'txt_City
        '
        Me.txt_City.BackColor = System.Drawing.Color.White
        Me.txt_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_City.Location = New System.Drawing.Point(109, 117)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(239, 24)
        Me.txt_City.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phone :"
        '
        'txt_Area
        '
        Me.txt_Area.BackColor = System.Drawing.Color.White
        Me.txt_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Area.Location = New System.Drawing.Point(109, 82)
        Me.txt_Area.Name = "txt_Area"
        Me.txt_Area.Size = New System.Drawing.Size(239, 24)
        Me.txt_Area.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Hospital :"
        '
        'txt_Street
        '
        Me.txt_Street.BackColor = System.Drawing.Color.White
        Me.txt_Street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Street.Location = New System.Drawing.Point(109, 47)
        Me.txt_Street.Name = "txt_Street"
        Me.txt_Street.Size = New System.Drawing.Size(239, 24)
        Me.txt_Street.TabIndex = 16
        '
        'txt_Name
        '
        Me.txt_Name.BackColor = System.Drawing.Color.White
        Me.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Name.Location = New System.Drawing.Point(109, 12)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(239, 24)
        Me.txt_Name.TabIndex = 15
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLM.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.Panel1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(363, 325)
        Me.HuraForm1.TabIndex = 9
        Me.HuraForm1.Text = "Edit Doctor"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLM.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(261, 2)
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 9
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'EditDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 325)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(363, 325)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(363, 325)
        Me.Name = "EditDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Doctor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.HuraForm1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Edit As HuraButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Hospital As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Pincode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_City As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Area As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Street As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents HuraControlBox1 As HuraControlBox
End Class
