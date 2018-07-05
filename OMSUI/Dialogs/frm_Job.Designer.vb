<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Job
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Job))
        Me.HuraForm1 = New GlobalCode.HuraForm()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.cmb_Group = New System.Windows.Forms.ComboBox()
        Me.cmb_SubGroup = New System.Windows.Forms.ComboBox()
        Me.cmb_Type = New System.Windows.Forms.ComboBox()
        Me.txt_Steps = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lst_Templates = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_Template_Remove = New GlobalCode.BonfireButton()
        Me.btn_Template_Add = New GlobalCode.BonfireButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New GlobalCode.BonfireButton()
        Me.btn_Done = New GlobalCode.BonfireButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HuraForm1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = GlobalCode.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.Panel1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(571, 439)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Job"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 406)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Name, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Group, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_SubGroup, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Type, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Steps, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(565, 371)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Group"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(103, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(9, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(103, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(9, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(103, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(103, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(103, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 117)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(103, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 134)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Sub Group"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 30)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 117)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Steps"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(3, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 134)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Templates"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_Name
        '
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.Location = New System.Drawing.Point(118, 3)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(444, 24)
        Me.txt_Name.TabIndex = 0
        '
        'cmb_Group
        '
        Me.cmb_Group.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.Location = New System.Drawing.Point(118, 33)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.Size = New System.Drawing.Size(444, 25)
        Me.cmb_Group.TabIndex = 1
        '
        'cmb_SubGroup
        '
        Me.cmb_SubGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_SubGroup.FormattingEnabled = True
        Me.cmb_SubGroup.Location = New System.Drawing.Point(118, 63)
        Me.cmb_SubGroup.Name = "cmb_SubGroup"
        Me.cmb_SubGroup.Size = New System.Drawing.Size(444, 25)
        Me.cmb_SubGroup.TabIndex = 2
        '
        'cmb_Type
        '
        Me.cmb_Type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Type.FormattingEnabled = True
        Me.cmb_Type.Items.AddRange(New Object() {"Yearly", "Half Yearly", "Quarter Yearly", "Monthly", "Weekly", "Once"})
        Me.cmb_Type.Location = New System.Drawing.Point(118, 93)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.Size = New System.Drawing.Size(444, 25)
        Me.cmb_Type.TabIndex = 3
        '
        'txt_Steps
        '
        Me.txt_Steps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Steps.Location = New System.Drawing.Point(118, 123)
        Me.txt_Steps.Multiline = True
        Me.txt_Steps.Name = "txt_Steps"
        Me.txt_Steps.Size = New System.Drawing.Size(444, 111)
        Me.txt_Steps.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lst_Templates)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(118, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 128)
        Me.Panel3.TabIndex = 17
        '
        'lst_Templates
        '
        Me.lst_Templates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Templates.FormattingEnabled = True
        Me.lst_Templates.HorizontalScrollbar = True
        Me.lst_Templates.ItemHeight = 17
        Me.lst_Templates.Location = New System.Drawing.Point(0, 0)
        Me.lst_Templates.Name = "lst_Templates"
        Me.lst_Templates.Size = New System.Drawing.Size(378, 128)
        Me.lst_Templates.TabIndex = 1
        Me.lst_Templates.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_Template_Remove)
        Me.Panel4.Controls.Add(Me.btn_Template_Add)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(378, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(66, 128)
        Me.Panel4.TabIndex = 0
        '
        'btn_Template_Remove
        '
        Me.btn_Template_Remove.ButtonStyle = GlobalCode.BonfireButton.Style.Grey
        Me.btn_Template_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Template_Remove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Template_Remove.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Template_Remove.Image = Nothing
        Me.btn_Template_Remove.Location = New System.Drawing.Point(0, 31)
        Me.btn_Template_Remove.Name = "btn_Template_Remove"
        Me.btn_Template_Remove.RoundedCorners = False
        Me.btn_Template_Remove.Size = New System.Drawing.Size(66, 32)
        Me.btn_Template_Remove.TabIndex = 1
        Me.btn_Template_Remove.TabStop = False
        Me.btn_Template_Remove.Text = "Remove"
        '
        'btn_Template_Add
        '
        Me.btn_Template_Add.ButtonStyle = GlobalCode.BonfireButton.Style.Dark
        Me.btn_Template_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Template_Add.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Template_Add.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Template_Add.Image = Nothing
        Me.btn_Template_Add.Location = New System.Drawing.Point(0, 0)
        Me.btn_Template_Add.Name = "btn_Template_Add"
        Me.btn_Template_Add.RoundedCorners = False
        Me.btn_Template_Add.Size = New System.Drawing.Size(66, 31)
        Me.btn_Template_Add.TabIndex = 0
        Me.btn_Template_Add.TabStop = False
        Me.btn_Template_Add.Text = "Add"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Done)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 373)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(565, 33)
        Me.Panel2.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.ButtonStyle = GlobalCode.BonfireButton.Style.Blue
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Cancel.Image = Nothing
        Me.btn_Cancel.Location = New System.Drawing.Point(424, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.RoundedCorners = False
        Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.TabStop = False
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.ButtonStyle = GlobalCode.BonfireButton.Style.Green
        Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Done.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Done.Image = Nothing
        Me.btn_Done.Location = New System.Drawing.Point(495, 3)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.RoundedCorners = False
        Me.btn_Done.Size = New System.Drawing.Size(65, 24)
        Me.btn_Done.TabIndex = 2
        Me.btn_Done.TabStop = False
        Me.btn_Done.Text = "Done"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Files|*"
        Me.OpenFileDialog1.FilterIndex = 0
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Select files to add to templates list"
        '
        'frm_Job
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 439)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Job"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job"
        Me.HuraForm1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As GlobalCode.HuraForm
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Group As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_SubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Type As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Steps As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lst_Templates As System.Windows.Forms.ListBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As GlobalCode.BonfireButton
    Friend WithEvents btn_Done As GlobalCode.BonfireButton
    Friend WithEvents btn_Template_Remove As GlobalCode.BonfireButton
    Friend WithEvents btn_Template_Add As GlobalCode.BonfireButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
