<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statements))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lv_Statement = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_Filter = New System.Windows.Forms.ComboBox()
        Me.btn_Go = New SSPLMS.HuraButton()
        Me.txt_listby = New SSPLMS.HuraComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Print = New SSPLMS.HuraButton()
        Me.btn_Preview = New SSPLMS.HuraButton()
        Me.txt_Subtitle = New System.Windows.Forms.TextBox()
        Me.txt_Title = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_DateTo = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_DateFrom = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HuraForm1 = New SSPLMS.HuraForm()
        Me.HuraControlBox1 = New SSPLMS.HuraControlBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lv_Statement)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(3, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 474)
        Me.Panel1.TabIndex = 1
        '
        'lv_Statement
        '
        Me.lv_Statement.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_Statement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Statement.FullRowSelect = True
        Me.lv_Statement.Location = New System.Drawing.Point(0, 46)
        Me.lv_Statement.Name = "lv_Statement"
        Me.lv_Statement.Size = New System.Drawing.Size(682, 326)
        Me.lv_Statement.TabIndex = 2
        Me.lv_Statement.UseCompatibleStateImageBehavior = False
        Me.lv_Statement.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Report No."
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Patient Name"
        Me.ColumnHeader2.Width = 297
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Age"
        Me.ColumnHeader3.Width = 53
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Doctor Name"
        Me.ColumnHeader4.Width = 263
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_Filter)
        Me.Panel2.Controls.Add(Me.btn_Go)
        Me.Panel2.Controls.Add(Me.txt_listby)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 26)
        Me.Panel2.TabIndex = 0
        '
        'txt_Filter
        '
        Me.txt_Filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_Filter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_Filter.FormattingEnabled = True
        Me.txt_Filter.Location = New System.Drawing.Point(249, 0)
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(358, 21)
        Me.txt_Filter.TabIndex = 4
        '
        'btn_Go
        '
        Me.btn_Go.BackColor = System.Drawing.Color.Transparent
        Me.btn_Go.BaseColour = System.Drawing.Color.White
        Me.btn_Go.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Go.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Go.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Go.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Go.Location = New System.Drawing.Point(607, 0)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Go.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Go.Size = New System.Drawing.Size(75, 26)
        Me.btn_Go.TabIndex = 3
        Me.btn_Go.Text = "Go"
        '
        'txt_listby
        '
        Me.txt_listby.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txt_listby.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_listby.ColorScheme = SSPLMS.HuraComboBox.ColorSchemes.Dark
        Me.txt_listby.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_listby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_listby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_listby.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txt_listby.ForeColor = System.Drawing.Color.White
        Me.txt_listby.FormattingEnabled = True
        Me.txt_listby.Items.AddRange(New Object() {"Diagnostics", "Test", "Site"})
        Me.txt_listby.Location = New System.Drawing.Point(60, 0)
        Me.txt_listby.Name = "txt_listby"
        Me.txt_listby.Size = New System.Drawing.Size(189, 25)
        Me.txt_listby.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List by :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btn_Print)
        Me.Panel3.Controls.Add(Me.btn_Preview)
        Me.Panel3.Controls.Add(Me.txt_Subtitle)
        Me.Panel3.Controls.Add(Me.txt_Title)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 372)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(682, 102)
        Me.Panel3.TabIndex = 3
        '
        'btn_Print
        '
        Me.btn_Print.BackColor = System.Drawing.Color.Transparent
        Me.btn_Print.BaseColour = System.Drawing.Color.White
        Me.btn_Print.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Print.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Print.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Print.Location = New System.Drawing.Point(516, 65)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Print.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Print.Size = New System.Drawing.Size(75, 30)
        Me.btn_Print.TabIndex = 3
        Me.btn_Print.Text = "Print"
        '
        'btn_Preview
        '
        Me.btn_Preview.BackColor = System.Drawing.Color.Transparent
        Me.btn_Preview.BaseColour = System.Drawing.Color.White
        Me.btn_Preview.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Preview.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Preview.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Preview.Location = New System.Drawing.Point(597, 65)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Preview.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Preview.Size = New System.Drawing.Size(75, 30)
        Me.btn_Preview.TabIndex = 3
        Me.btn_Preview.Text = "Preview"
        '
        'txt_Subtitle
        '
        Me.txt_Subtitle.Location = New System.Drawing.Point(87, 35)
        Me.txt_Subtitle.Name = "txt_Subtitle"
        Me.txt_Subtitle.Size = New System.Drawing.Size(585, 20)
        Me.txt_Subtitle.TabIndex = 2
        '
        'txt_Title
        '
        Me.txt_Title.Location = New System.Drawing.Point(87, 5)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(585, 20)
        Me.txt_Title.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Subtitle :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_DateTo)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txt_DateFrom)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(682, 20)
        Me.Panel4.TabIndex = 4
        '
        'txt_DateTo
        '
        Me.txt_DateTo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_DateTo.Location = New System.Drawing.Point(330, 0)
        Me.txt_DateTo.Mask = "00/00/0000"
        Me.txt_DateTo.Name = "txt_DateTo"
        Me.txt_DateTo.Size = New System.Drawing.Size(277, 20)
        Me.txt_DateTo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Location = New System.Drawing.Point(249, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "To "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DateFrom
        '
        Me.txt_DateFrom.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_DateFrom.Location = New System.Drawing.Point(101, 0)
        Me.txt_DateFrom.Mask = "00/00/0000"
        Me.txt_DateFrom.Name = "txt_DateFrom"
        Me.txt_DateFrom.Size = New System.Drawing.Size(148, 20)
        Me.txt_DateFrom.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(60, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "From "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLMS.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(688, 507)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Generate Statement"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLMS.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(587, 2)
        Me.HuraControlBox1.Maximize = False
        Me.HuraControlBox1.Minimize = False
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 0
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Statements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Statements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Statement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.HuraForm1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_listby As HuraComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lv_Statement As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btn_Go As HuraButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_Subtitle As TextBox
    Friend WithEvents txt_Title As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Print As HuraButton
    Friend WithEvents btn_Preview As HuraButton
    Friend WithEvents txt_Filter As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_DateTo As MaskedTextBox
    Friend WithEvents txt_DateFrom As MaskedTextBox
End Class
