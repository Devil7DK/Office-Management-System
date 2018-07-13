<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Job
    Inherits Devil7.Automation.OMS.Lib.XtraFormTemp

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Steps = New DevExpress.XtraEditors.MemoEdit()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lst_Templates = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_Template_Remove = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Template_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.cmb_Type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_SubGroup = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_Group = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Steps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SubGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 408)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 456.0!))
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
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Steps, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Type, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_SubGroup, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Group, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(571, 371)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Group"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(103, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(9, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(103, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(9, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(103, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(103, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(103, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 132)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(103, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 128)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Sub Group"
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Type"
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 132)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Steps"
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(3, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 128)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Templates"
        '
        'txt_Name
        '
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.Location = New System.Drawing.Point(118, 3)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(450, 20)
        Me.txt_Name.TabIndex = 0
        '
        'txt_Steps
        '
        Me.txt_Steps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Steps.Location = New System.Drawing.Point(118, 102)
        Me.txt_Steps.Name = "txt_Steps"
        Me.txt_Steps.Size = New System.Drawing.Size(450, 132)
        Me.txt_Steps.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lst_Templates)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(118, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 128)
        Me.Panel3.TabIndex = 17
        '
        'lst_Templates
        '
        Me.lst_Templates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Templates.FormattingEnabled = True
        Me.lst_Templates.HorizontalScrollbar = True
        Me.lst_Templates.Location = New System.Drawing.Point(0, 0)
        Me.lst_Templates.Name = "lst_Templates"
        Me.lst_Templates.Size = New System.Drawing.Size(384, 128)
        Me.lst_Templates.TabIndex = 1
        Me.lst_Templates.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_Template_Remove)
        Me.Panel4.Controls.Add(Me.btn_Template_Add)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(384, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(66, 128)
        Me.Panel4.TabIndex = 0
        '
        'btn_Template_Remove
        '
        Me.btn_Template_Remove.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Template_Remove.Appearance.Options.UseFont = True
        Me.btn_Template_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Template_Remove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Template_Remove.Location = New System.Drawing.Point(0, 31)
        Me.btn_Template_Remove.Name = "btn_Template_Remove"
        Me.btn_Template_Remove.Size = New System.Drawing.Size(66, 32)
        Me.btn_Template_Remove.TabIndex = 1
        Me.btn_Template_Remove.TabStop = False
        Me.btn_Template_Remove.Text = "Remove"
        '
        'btn_Template_Add
        '
        Me.btn_Template_Add.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Template_Add.Appearance.Options.UseFont = True
        Me.btn_Template_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Template_Add.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Template_Add.Location = New System.Drawing.Point(0, 0)
        Me.btn_Template_Add.Name = "btn_Template_Add"
        Me.btn_Template_Add.Size = New System.Drawing.Size(66, 31)
        Me.btn_Template_Add.TabIndex = 0
        Me.btn_Template_Add.TabStop = False
        Me.btn_Template_Add.Text = "Add"
        '
        'cmb_Type
        '
        Me.cmb_Type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Type.Location = New System.Drawing.Point(118, 78)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Type.Properties.Items.AddRange(New Object() {"Once", "Monthly", "Quarterly", "Half Yearly", "Yearly"})
        Me.cmb_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Type.Size = New System.Drawing.Size(450, 20)
        Me.cmb_Type.TabIndex = 3
        '
        'cmb_SubGroup
        '
        Me.cmb_SubGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_SubGroup.Location = New System.Drawing.Point(118, 53)
        Me.cmb_SubGroup.Name = "cmb_SubGroup"
        Me.cmb_SubGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_SubGroup.Size = New System.Drawing.Size(450, 20)
        Me.cmb_SubGroup.TabIndex = 2
        '
        'cmb_Group
        '
        Me.cmb_Group.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Group.Location = New System.Drawing.Point(118, 28)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Group.Size = New System.Drawing.Size(450, 20)
        Me.cmb_Group.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Done)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 375)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 33)
        Me.Panel2.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Cancel.Appearance.Options.UseFont = True
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Location = New System.Drawing.Point(430, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.TabStop = False
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Done.Appearance.Options.UseFont = True
        Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Done.Location = New System.Drawing.Point(501, 3)
        Me.btn_Done.Name = "btn_Done"
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
        Me.ClientSize = New System.Drawing.Size(571, 408)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Job"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Steps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SubGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Steps As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lst_Templates As System.Windows.Forms.ListBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Template_Remove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Template_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmb_Type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_SubGroup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_Group As DevExpress.XtraEditors.ComboBoxEdit
End Class
