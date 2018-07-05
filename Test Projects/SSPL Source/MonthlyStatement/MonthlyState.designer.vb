<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthlyState
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlyState))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lst_process = New System.Windows.Forms.ListBox()
        Me.btn_OtherStatement = New SSPLMS.HuraButton()
        Me.btn_Settings = New SSPLMS.HuraButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Doctors = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.btn_Add = New SSPLMS.HuraButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_DateTo = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_DateFrom = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lv_SelectedDoctors = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cb_ShowGroups = New SSPLMS.HuraCheckBox()
        Me.btn_Remove = New SSPLMS.HuraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.lbl_state = New System.Windows.Forms.Label()
        Me.btn_Cancel1 = New SSPLMS.HuraButton()
        Me.btn_Previous1 = New SSPLMS.HuraButton()
        Me.btn_Next1 = New SSPLMS.HuraButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lv_Statement = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Print = New SSPLMS.HuraButton()
        Me.txt_Month = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_DoctorName = New System.Windows.Forms.TextBox()
        Me.btn_PrintPreview = New SSPLMS.HuraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_Cancel2 = New SSPLMS.HuraButton()
        Me.btn_Previous2 = New SSPLMS.HuraButton()
        Me.btn_Finish = New SSPLMS.HuraButton()
        Me.Data_Worker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Doctors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 572)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lst_process)
        Me.Panel5.Controls.Add(Me.btn_OtherStatement)
        Me.Panel5.Controls.Add(Me.btn_Settings)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 528)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(653, 44)
        Me.Panel5.TabIndex = 2
        '
        'lst_process
        '
        Me.lst_process.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_process.FormattingEnabled = True
        Me.lst_process.HorizontalScrollbar = True
        Me.lst_process.Location = New System.Drawing.Point(0, 0)
        Me.lst_process.Name = "lst_process"
        Me.lst_process.Size = New System.Drawing.Size(497, 44)
        Me.lst_process.TabIndex = 2
        '
        'btn_OtherStatement
        '
        Me.btn_OtherStatement.BackColor = System.Drawing.Color.Transparent
        Me.btn_OtherStatement.BaseColour = System.Drawing.Color.White
        Me.btn_OtherStatement.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_OtherStatement.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_OtherStatement.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_OtherStatement.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OtherStatement.Location = New System.Drawing.Point(497, 0)
        Me.btn_OtherStatement.Name = "btn_OtherStatement"
        Me.btn_OtherStatement.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_OtherStatement.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OtherStatement.Size = New System.Drawing.Size(99, 44)
        Me.btn_OtherStatement.TabIndex = 4
        Me.btn_OtherStatement.Text = "Other Statement"
        '
        'btn_Settings
        '
        Me.btn_Settings.BackColor = System.Drawing.Color.Transparent
        Me.btn_Settings.BaseColour = System.Drawing.Color.White
        Me.btn_Settings.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Settings.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Settings.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Settings.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Settings.Location = New System.Drawing.Point(596, 0)
        Me.btn_Settings.Name = "btn_Settings"
        Me.btn_Settings.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Settings.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Settings.Size = New System.Drawing.Size(57, 44)
        Me.btn_Settings.TabIndex = 3
        Me.btn_Settings.Text = "Settings"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, -20)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(653, 549)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(645, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Doctor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Doctors)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 327)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search && Add Doctors"
        '
        'Doctors
        '
        Me.Doctors.AllowUserToAddRows = False
        Me.Doctors.AllowUserToDeleteRows = False
        Me.Doctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Doctors.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Doctors.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Doctors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Doctors.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.Doctors.Location = New System.Drawing.Point(3, 38)
        Me.Doctors.Name = "Doctors"
        Me.Doctors.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Doctors.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Doctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Doctors.Size = New System.Drawing.Size(633, 286)
        Me.Doctors.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txt_Search)
        Me.Panel6.Controls.Add(Me.btn_Add)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(633, 22)
        Me.Panel6.TabIndex = 2
        '
        'txt_Search
        '
        Me.txt_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Search.Location = New System.Drawing.Point(0, 0)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(558, 20)
        Me.txt_Search.TabIndex = 0
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add.BaseColour = System.Drawing.Color.White
        Me.btn_Add.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Add.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Add.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Add.Location = New System.Drawing.Point(558, 0)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Add.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Add.Size = New System.Drawing.Size(75, 22)
        Me.btn_Add.TabIndex = 1
        Me.btn_Add.Text = "Add"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_DateTo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tb_DateFrom)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 48)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Range"
        '
        'tb_DateTo
        '
        Me.tb_DateTo.Dock = System.Windows.Forms.DockStyle.Left
        Me.tb_DateTo.Location = New System.Drawing.Point(361, 16)
        Me.tb_DateTo.Mask = "00/00/0000"
        Me.tb_DateTo.Name = "tb_DateTo"
        Me.tb_DateTo.Size = New System.Drawing.Size(231, 20)
        Me.tb_DateTo.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(278, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "To :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_DateFrom
        '
        Me.tb_DateFrom.Dock = System.Windows.Forms.DockStyle.Left
        Me.tb_DateFrom.Location = New System.Drawing.Point(78, 16)
        Me.tb_DateFrom.Mask = "00/00/0000"
        Me.tb_DateFrom.Name = "tb_DateFrom"
        Me.tb_DateFrom.Size = New System.Drawing.Size(200, 20)
        Me.tb_DateFrom.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lv_SelectedDoctors, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 378)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(639, 100)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lv_SelectedDoctors
        '
        Me.lv_SelectedDoctors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lv_SelectedDoctors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_SelectedDoctors.FullRowSelect = True
        Me.lv_SelectedDoctors.GridLines = True
        Me.lv_SelectedDoctors.Location = New System.Drawing.Point(3, 3)
        Me.lv_SelectedDoctors.Name = "lv_SelectedDoctors"
        Me.lv_SelectedDoctors.Size = New System.Drawing.Size(533, 94)
        Me.lv_SelectedDoctors.TabIndex = 1
        Me.lv_SelectedDoctors.UseCompatibleStateImageBehavior = False
        Me.lv_SelectedDoctors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Doctor Name"
        Me.ColumnHeader2.Width = 444
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cb_ShowGroups)
        Me.Panel3.Controls.Add(Me.btn_Remove)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(542, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(94, 94)
        Me.Panel3.TabIndex = 0
        '
        'cb_ShowGroups
        '
        Me.cb_ShowGroups.BaseColour = System.Drawing.Color.White
        Me.cb_ShowGroups.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_ShowGroups.Checked = True
        Me.cb_ShowGroups.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cb_ShowGroups.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_ShowGroups.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_ShowGroups.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cb_ShowGroups.Location = New System.Drawing.Point(0, 30)
        Me.cb_ShowGroups.Name = "cb_ShowGroups"
        Me.cb_ShowGroups.Size = New System.Drawing.Size(94, 22)
        Me.cb_ShowGroups.TabIndex = 1
        Me.cb_ShowGroups.Text = "Group Items"
        '
        'btn_Remove
        '
        Me.btn_Remove.BackColor = System.Drawing.Color.Transparent
        Me.btn_Remove.BaseColour = System.Drawing.Color.White
        Me.btn_Remove.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Remove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Remove.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Remove.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Remove.Location = New System.Drawing.Point(0, 0)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Remove.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Remove.Size = New System.Drawing.Size(94, 30)
        Me.btn_Remove.TabIndex = 0
        Me.btn_Remove.Text = "Remove"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Progress)
        Me.Panel2.Controls.Add(Me.lbl_state)
        Me.Panel2.Controls.Add(Me.btn_Cancel1)
        Me.Panel2.Controls.Add(Me.btn_Previous1)
        Me.Panel2.Controls.Add(Me.btn_Next1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 478)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 42)
        Me.Panel2.TabIndex = 1
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.Location = New System.Drawing.Point(93, 25)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(362, 10)
        Me.Progress.TabIndex = 2
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.Location = New System.Drawing.Point(206, 5)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(105, 13)
        Me.lbl_state.TabIndex = 1
        Me.lbl_state.Text = "Loading Please Wait"
        '
        'btn_Cancel1
        '
        Me.btn_Cancel1.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel1.BaseColour = System.Drawing.Color.White
        Me.btn_Cancel1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Cancel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Cancel1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel1.Location = New System.Drawing.Point(3, 5)
        Me.btn_Cancel1.Name = "btn_Cancel1"
        Me.btn_Cancel1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Cancel1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel1.Size = New System.Drawing.Size(84, 30)
        Me.btn_Cancel1.TabIndex = 0
        Me.btn_Cancel1.Text = "Cancel"
        '
        'btn_Previous1
        '
        Me.btn_Previous1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Previous1.BackColor = System.Drawing.Color.Transparent
        Me.btn_Previous1.BaseColour = System.Drawing.Color.White
        Me.btn_Previous1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Previous1.Enabled = False
        Me.btn_Previous1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Previous1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Previous1.Location = New System.Drawing.Point(468, 5)
        Me.btn_Previous1.Name = "btn_Previous1"
        Me.btn_Previous1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Previous1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Previous1.Size = New System.Drawing.Size(84, 30)
        Me.btn_Previous1.TabIndex = 0
        Me.btn_Previous1.Text = "Previous"
        '
        'btn_Next1
        '
        Me.btn_Next1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Next1.BackColor = System.Drawing.Color.Transparent
        Me.btn_Next1.BaseColour = System.Drawing.Color.White
        Me.btn_Next1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Next1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Next1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Next1.Location = New System.Drawing.Point(558, 5)
        Me.btn_Next1.Name = "btn_Next1"
        Me.btn_Next1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Next1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Next1.Size = New System.Drawing.Size(75, 30)
        Me.btn_Next1.TabIndex = 0
        Me.btn_Next1.Text = "Next"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lv_Statement)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(645, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Statement"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lv_Statement
        '
        Me.lv_Statement.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv_Statement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Statement.FullRowSelect = True
        Me.lv_Statement.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_Statement.Location = New System.Drawing.Point(3, 3)
        Me.lv_Statement.MultiSelect = False
        Me.lv_Statement.Name = "lv_Statement"
        Me.lv_Statement.Size = New System.Drawing.Size(639, 423)
        Me.lv_Statement.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_Statement.TabIndex = 3
        Me.lv_Statement.UseCompatibleStateImageBehavior = False
        Me.lv_Statement.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Report No."
        Me.ColumnHeader3.Width = 107
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 350
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Age/Sex"
        Me.ColumnHeader6.Width = 100
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Print, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Month, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_DoctorName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_PrintPreview, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 426)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(639, 52)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'btn_Print
        '
        Me.btn_Print.BackColor = System.Drawing.Color.Transparent
        Me.btn_Print.BaseColour = System.Drawing.Color.White
        Me.btn_Print.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Print.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Print.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Print.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Print.Location = New System.Drawing.Point(547, 3)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Print.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Print.Size = New System.Drawing.Size(89, 20)
        Me.btn_Print.TabIndex = 7
        Me.btn_Print.Text = "Print"
        '
        'txt_Month
        '
        Me.txt_Month.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Month.Location = New System.Drawing.Point(98, 29)
        Me.txt_Month.Name = "txt_Month"
        Me.txt_Month.Size = New System.Drawing.Size(443, 20)
        Me.txt_Month.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(49, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Month :"
        '
        'txt_DoctorName
        '
        Me.txt_DoctorName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DoctorName.Location = New System.Drawing.Point(98, 3)
        Me.txt_DoctorName.Name = "txt_DoctorName"
        Me.txt_DoctorName.Size = New System.Drawing.Size(443, 20)
        Me.txt_DoctorName.TabIndex = 4
        '
        'btn_PrintPreview
        '
        Me.btn_PrintPreview.BackColor = System.Drawing.Color.Transparent
        Me.btn_PrintPreview.BaseColour = System.Drawing.Color.White
        Me.btn_PrintPreview.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_PrintPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PrintPreview.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_PrintPreview.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_PrintPreview.Location = New System.Drawing.Point(547, 29)
        Me.btn_PrintPreview.Name = "btn_PrintPreview"
        Me.btn_PrintPreview.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_PrintPreview.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_PrintPreview.Size = New System.Drawing.Size(89, 20)
        Me.btn_PrintPreview.TabIndex = 7
        Me.btn_PrintPreview.Text = "Print Preview"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(16, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Doctor Name :"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_Cancel2)
        Me.Panel4.Controls.Add(Me.btn_Previous2)
        Me.Panel4.Controls.Add(Me.btn_Finish)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 478)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(639, 42)
        Me.Panel4.TabIndex = 2
        '
        'btn_Cancel2
        '
        Me.btn_Cancel2.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel2.BaseColour = System.Drawing.Color.White
        Me.btn_Cancel2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Cancel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Cancel2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel2.Location = New System.Drawing.Point(3, 5)
        Me.btn_Cancel2.Name = "btn_Cancel2"
        Me.btn_Cancel2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Cancel2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel2.Size = New System.Drawing.Size(84, 30)
        Me.btn_Cancel2.TabIndex = 1
        Me.btn_Cancel2.Text = "Cancel"
        '
        'btn_Previous2
        '
        Me.btn_Previous2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Previous2.BackColor = System.Drawing.Color.Transparent
        Me.btn_Previous2.BaseColour = System.Drawing.Color.White
        Me.btn_Previous2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Previous2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Previous2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Previous2.Location = New System.Drawing.Point(461, 5)
        Me.btn_Previous2.Name = "btn_Previous2"
        Me.btn_Previous2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Previous2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Previous2.Size = New System.Drawing.Size(84, 30)
        Me.btn_Previous2.TabIndex = 1
        Me.btn_Previous2.Text = "Previous"
        '
        'btn_Finish
        '
        Me.btn_Finish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Finish.BackColor = System.Drawing.Color.Transparent
        Me.btn_Finish.BaseColour = System.Drawing.Color.White
        Me.btn_Finish.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Finish.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Finish.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Finish.Location = New System.Drawing.Point(551, 5)
        Me.btn_Finish.Name = "btn_Finish"
        Me.btn_Finish.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Finish.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Finish.Size = New System.Drawing.Size(75, 30)
        Me.btn_Finish.TabIndex = 0
        Me.btn_Finish.Text = "Reset"
        '
        'Data_Worker
        '
        '
        'Timer1
        '
        '
        'MonthlyState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 572)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MonthlyState"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonthlyState"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Doctors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Doctors As DataGridView
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lv_SelectedDoctors As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Remove As HuraButton
    Friend WithEvents btn_Next1 As HuraButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_Finish As HuraButton
    Friend WithEvents lv_Statement As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Month As TextBox
    Friend WithEvents txt_DoctorName As TextBox
    Friend WithEvents btn_PrintPreview As HuraButton
    Friend WithEvents btn_Print As HuraButton
    Friend WithEvents btn_Cancel1 As HuraButton
    Friend WithEvents btn_Previous1 As HuraButton
    Friend WithEvents btn_Cancel2 As HuraButton
    Friend WithEvents btn_Previous2 As HuraButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_DateTo As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_DateFrom As MaskedTextBox
    Friend WithEvents Data_Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_state As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lst_process As ListBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_Add As HuraButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_Settings As HuraButton
    Friend WithEvents cb_ShowGroups As HuraCheckBox
    Friend WithEvents btn_OtherStatement As HuraButton
End Class
