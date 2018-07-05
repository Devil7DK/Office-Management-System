<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.BackgroundWorker_Print = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_Word = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker_PDF = New System.ComponentModel.BackgroundWorker()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Filter = New System.Windows.Forms.TextBox()
        Me.txt_filterby = New System.Windows.Forms.ComboBox()
        Me.btn_RemoveFilter = New D7_44ABAC.Hura.HuraButton()
        Me.btn_AddSelected = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Remove_Checked = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Save = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Load = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Uncheck_Selected = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Check_Selected = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Uncheck_All = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Select_All = New D7_44ABAC.Hura.HuraButton()
        Me.cb_Recursive = New D7_44ABAC.Hura.HuraCheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_PDF = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Word = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Print = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Compact = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Delete = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Edit = New D7_44ABAC.Hura.HuraButton()
        Me.btn_AddNew = New D7_44ABAC.Hura.HuraButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSeletedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HuraForm1 = New D7_44ABAC.Hura.HuraForm()
        Me.HuraGroupBox1 = New D7_44ABAC.Hura.HuraGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AllData = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_count1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_count2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Partners = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_CompName = New System.Windows.Forms.TextBox()
        Me.txt_PAN = New System.Windows.Forms.TextBox()
        Me.txt_TypeOfConcern = New System.Windows.Forms.ComboBox()
        Me.txt_Add1 = New System.Windows.Forms.TextBox()
        Me.txt_Add2 = New System.Windows.Forms.TextBox()
        Me.txt_Add3 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_Done = New D7_44ABAC.Hura.HuraButton()
        Me.btn_Cancel = New D7_44ABAC.Hura.HuraButton()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.txt_PropName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cb_SaleOfGoods = New System.Windows.Forms.CheckBox()
        Me.cb_ProvisionofServices = New System.Windows.Forms.CheckBox()
        Me.cb_OtherIncome = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_OtherIncome = New System.Windows.Forms.TextBox()
        Me.txt_CertificateDate = New System.Windows.Forms.DateTimePicker()
        Me.HuraGroupBox2 = New D7_44ABAC.Hura.HuraGroupBox()
        Me.cb_Template = New D7_44ABAC.Hura.HuraComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraTabControl1 = New D7_44ABAC.Hura.HuraTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Progress = New D7_44ABAC.LogInRadialProgressBar()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_Settings = New System.Windows.Forms.TabPage()
        Me.btn_SaveSettings = New D7_44ABAC.Hura.HuraButton()
        Me.txt_YearEnding = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Title = New System.Windows.Forms.TextBox()
        Me.txt_Abstract = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_PDFPrinter = New System.Windows.Forms.TextBox()
        Me.txt_Financial = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Assessment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HuraControlBox1 = New D7_44ABAC.Hura.HuraControlBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.HuraForm1.SuspendLayout()
        Me.HuraGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.AllData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.HuraGroupBox2.SuspendLayout()
        Me.HuraTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.tb_Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker_Print
        '
        '
        'BackgroundWorker_Word
        '
        '
        'BackgroundWorker_PDF
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "ac44ab"
        Me.SaveFileDialog1.FileName = "*.ac44ab"
        Me.SaveFileDialog1.Filter = "AA44AB Files (*.ac44ab)|*.ac44ab"
        Me.SaveFileDialog1.FilterIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "ac44ab"
        Me.OpenFileDialog1.FileName = "*.ac44ab"
        Me.OpenFileDialog1.Filter = "AA44AB Files (*.ac44ab)|*.ac44ab"
        Me.OpenFileDialog1.FilterIndex = 0
        '
        'txt_Filter
        '
        Me.txt_Filter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Filter.Location = New System.Drawing.Point(390, 0)
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(60, 24)
        Me.txt_Filter.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txt_Filter, "Enter value to filter.")
        '
        'txt_filterby
        '
        Me.txt_filterby.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_filterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_filterby.FormattingEnabled = True
        Me.txt_filterby.Location = New System.Drawing.Point(191, 0)
        Me.txt_filterby.Name = "txt_filterby"
        Me.txt_filterby.Size = New System.Drawing.Size(121, 25)
        Me.txt_filterby.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt_filterby, "Select the column name to filter.")
        '
        'btn_RemoveFilter
        '
        Me.btn_RemoveFilter.BackColor = System.Drawing.Color.Transparent
        Me.btn_RemoveFilter.BaseColour = System.Drawing.Color.White
        Me.btn_RemoveFilter.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_RemoveFilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_RemoveFilter.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_RemoveFilter.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveFilter.Location = New System.Drawing.Point(450, 0)
        Me.btn_RemoveFilter.Name = "btn_RemoveFilter"
        Me.btn_RemoveFilter.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_RemoveFilter.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveFilter.Size = New System.Drawing.Size(88, 25)
        Me.btn_RemoveFilter.TabIndex = 5
        Me.btn_RemoveFilter.Text = "Remove Filter"
        Me.ToolTip1.SetToolTip(Me.btn_RemoveFilter, "Remove filter from data.")
        '
        'btn_AddSelected
        '
        Me.btn_AddSelected.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddSelected.BaseColour = System.Drawing.Color.White
        Me.btn_AddSelected.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_AddSelected.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_AddSelected.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_AddSelected.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddSelected.Location = New System.Drawing.Point(0, 0)
        Me.btn_AddSelected.Name = "btn_AddSelected"
        Me.btn_AddSelected.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_AddSelected.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddSelected.Size = New System.Drawing.Size(94, 25)
        Me.btn_AddSelected.TabIndex = 0
        Me.btn_AddSelected.Text = "Add Selected"
        Me.ToolTip1.SetToolTip(Me.btn_AddSelected, "Add selected items to list.")
        '
        'btn_Remove_Checked
        '
        Me.btn_Remove_Checked.BackColor = System.Drawing.Color.Transparent
        Me.btn_Remove_Checked.BaseColour = System.Drawing.Color.White
        Me.btn_Remove_Checked.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Remove_Checked.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Remove_Checked.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Remove_Checked.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Remove_Checked.Location = New System.Drawing.Point(315, 0)
        Me.btn_Remove_Checked.Name = "btn_Remove_Checked"
        Me.btn_Remove_Checked.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Remove_Checked.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Remove_Checked.Size = New System.Drawing.Size(104, 34)
        Me.btn_Remove_Checked.TabIndex = 6
        Me.btn_Remove_Checked.Text = "Remove Checked"
        Me.ToolTip1.SetToolTip(Me.btn_Remove_Checked, "Remove checked items from list.")
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.BaseColour = System.Drawing.Color.White
        Me.btn_Save.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Save.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Save.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Save.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Save.Location = New System.Drawing.Point(419, 0)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Save.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Save.Size = New System.Drawing.Size(57, 34)
        Me.btn_Save.TabIndex = 5
        Me.btn_Save.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btn_Save, "Save list to file.")
        '
        'btn_Load
        '
        Me.btn_Load.BackColor = System.Drawing.Color.Transparent
        Me.btn_Load.BaseColour = System.Drawing.Color.White
        Me.btn_Load.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Load.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Load.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Load.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Load.Location = New System.Drawing.Point(476, 0)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Load.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Load.Size = New System.Drawing.Size(62, 34)
        Me.btn_Load.TabIndex = 4
        Me.btn_Load.Text = "Load"
        Me.ToolTip1.SetToolTip(Me.btn_Load, "Open list from file.")
        '
        'btn_Uncheck_Selected
        '
        Me.btn_Uncheck_Selected.BackColor = System.Drawing.Color.Transparent
        Me.btn_Uncheck_Selected.BaseColour = System.Drawing.Color.White
        Me.btn_Uncheck_Selected.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Uncheck_Selected.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Uncheck_Selected.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Uncheck_Selected.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Uncheck_Selected.Location = New System.Drawing.Point(213, 0)
        Me.btn_Uncheck_Selected.Name = "btn_Uncheck_Selected"
        Me.btn_Uncheck_Selected.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Uncheck_Selected.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Uncheck_Selected.Size = New System.Drawing.Size(99, 34)
        Me.btn_Uncheck_Selected.TabIndex = 3
        Me.btn_Uncheck_Selected.Text = "Uncheck Selected"
        Me.ToolTip1.SetToolTip(Me.btn_Uncheck_Selected, "Only uncheck selected/highlighted items in list.")
        '
        'btn_Check_Selected
        '
        Me.btn_Check_Selected.BackColor = System.Drawing.Color.Transparent
        Me.btn_Check_Selected.BaseColour = System.Drawing.Color.White
        Me.btn_Check_Selected.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Check_Selected.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Check_Selected.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Check_Selected.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Check_Selected.Location = New System.Drawing.Point(126, 0)
        Me.btn_Check_Selected.Name = "btn_Check_Selected"
        Me.btn_Check_Selected.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Check_Selected.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Check_Selected.Size = New System.Drawing.Size(87, 34)
        Me.btn_Check_Selected.TabIndex = 2
        Me.btn_Check_Selected.Text = "Check Selected"
        Me.ToolTip1.SetToolTip(Me.btn_Check_Selected, "Only check selected/highlighted items in list.")
        '
        'btn_Uncheck_All
        '
        Me.btn_Uncheck_All.BackColor = System.Drawing.Color.Transparent
        Me.btn_Uncheck_All.BaseColour = System.Drawing.Color.White
        Me.btn_Uncheck_All.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Uncheck_All.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Uncheck_All.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Uncheck_All.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Uncheck_All.Location = New System.Drawing.Point(55, 0)
        Me.btn_Uncheck_All.Name = "btn_Uncheck_All"
        Me.btn_Uncheck_All.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Uncheck_All.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Uncheck_All.Size = New System.Drawing.Size(71, 34)
        Me.btn_Uncheck_All.TabIndex = 1
        Me.btn_Uncheck_All.Text = "Uncheck All"
        Me.ToolTip1.SetToolTip(Me.btn_Uncheck_All, "Uncheck all items.")
        '
        'btn_Select_All
        '
        Me.btn_Select_All.BackColor = System.Drawing.Color.Transparent
        Me.btn_Select_All.BaseColour = System.Drawing.Color.White
        Me.btn_Select_All.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Select_All.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Select_All.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Select_All.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Select_All.Location = New System.Drawing.Point(0, 0)
        Me.btn_Select_All.Name = "btn_Select_All"
        Me.btn_Select_All.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Select_All.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Select_All.Size = New System.Drawing.Size(55, 34)
        Me.btn_Select_All.TabIndex = 0
        Me.btn_Select_All.Text = "Check All"
        Me.ToolTip1.SetToolTip(Me.btn_Select_All, "Check all items.")
        '
        'cb_Recursive
        '
        Me.cb_Recursive.BaseColour = System.Drawing.Color.White
        Me.cb_Recursive.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Recursive.Checked = False
        Me.cb_Recursive.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cb_Recursive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Recursive.Dock = System.Windows.Forms.DockStyle.Left
        Me.cb_Recursive.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.cb_Recursive.Location = New System.Drawing.Point(0, 0)
        Me.cb_Recursive.Name = "cb_Recursive"
        Me.cb_Recursive.Size = New System.Drawing.Size(91, 22)
        Me.cb_Recursive.TabIndex = 11
        Me.cb_Recursive.Text = "Recursive"
        Me.ToolTip1.SetToolTip(Me.cb_Recursive, "Continusely add items.")
        Me.cb_Recursive.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(717, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.ProgressBar1, "Work in progress...... Please wait......")
        '
        'btn_PDF
        '
        Me.btn_PDF.BackColor = System.Drawing.Color.Transparent
        Me.btn_PDF.BaseColour = System.Drawing.Color.White
        Me.btn_PDF.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_PDF.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_PDF.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_PDF.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_PDF.Location = New System.Drawing.Point(588, 3)
        Me.btn_PDF.Name = "btn_PDF"
        Me.btn_PDF.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_PDF.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_PDF.Size = New System.Drawing.Size(107, 55)
        Me.btn_PDF.TabIndex = 8
        Me.btn_PDF.Text = "Generate PDF"
        Me.ToolTip1.SetToolTip(Me.btn_PDF, "Print checked items using PDF Printer specified by used in settings. (Alt+P)")
        '
        'btn_Word
        '
        Me.btn_Word.BackColor = System.Drawing.Color.Transparent
        Me.btn_Word.BaseColour = System.Drawing.Color.White
        Me.btn_Word.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Word.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Word.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Word.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Word.Location = New System.Drawing.Point(463, 3)
        Me.btn_Word.Name = "btn_Word"
        Me.btn_Word.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Word.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Word.Size = New System.Drawing.Size(125, 55)
        Me.btn_Word.TabIndex = 7
        Me.btn_Word.Text = "Generate Word File"
        Me.ToolTip1.SetToolTip(Me.btn_Word, "Generate MS Word file of checked items. (Ctrl+W)")
        '
        'btn_Print
        '
        Me.btn_Print.BackColor = System.Drawing.Color.Transparent
        Me.btn_Print.BaseColour = System.Drawing.Color.White
        Me.btn_Print.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Print.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Print.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Print.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Print.Location = New System.Drawing.Point(392, 3)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Print.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Print.Size = New System.Drawing.Size(71, 55)
        Me.btn_Print.TabIndex = 6
        Me.btn_Print.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.btn_Print, "Print checked items. (Ctrl+P)")
        '
        'btn_Compact
        '
        Me.btn_Compact.BackColor = System.Drawing.Color.Transparent
        Me.btn_Compact.BaseColour = System.Drawing.Color.White
        Me.btn_Compact.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Compact.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Compact.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Compact.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Compact.Location = New System.Drawing.Point(223, 3)
        Me.btn_Compact.Name = "btn_Compact"
        Me.btn_Compact.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Compact.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Compact.Size = New System.Drawing.Size(163, 55)
        Me.btn_Compact.TabIndex = 4
        Me.btn_Compact.Text = "Compact & Repair Database"
        Me.ToolTip1.SetToolTip(Me.btn_Compact, "Compact and repair database.")
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_Delete.BaseColour = System.Drawing.Color.White
        Me.btn_Delete.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Delete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Delete.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Delete.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Delete.Location = New System.Drawing.Point(145, 3)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Delete.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Delete.Size = New System.Drawing.Size(71, 55)
        Me.btn_Delete.TabIndex = 2
        Me.btn_Delete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.btn_Delete, "Delete selected item(s).")
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit.BaseColour = System.Drawing.Color.White
        Me.btn_Edit.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Edit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Edit.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Edit.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(74, 3)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Edit.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Size = New System.Drawing.Size(71, 55)
        Me.btn_Edit.TabIndex = 1
        Me.btn_Edit.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.btn_Edit, "Edit selected item. (Ctrl+E)")
        '
        'btn_AddNew
        '
        Me.btn_AddNew.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddNew.BaseColour = System.Drawing.Color.White
        Me.btn_AddNew.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_AddNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_AddNew.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_AddNew.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddNew.Location = New System.Drawing.Point(3, 3)
        Me.btn_AddNew.Name = "btn_AddNew"
        Me.btn_AddNew.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_AddNew.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddNew.Size = New System.Drawing.Size(71, 55)
        Me.btn_AddNew.TabIndex = 0
        Me.btn_AddNew.Text = "Add New"
        Me.ToolTip1.SetToolTip(Me.btn_AddNew, "Add new item. (Ctrl+N)")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSeletedItemsToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 54)
        '
        'AddSeletedItemsToolStripMenuItem
        '
        Me.AddSeletedItemsToolStripMenuItem.Name = "AddSeletedItemsToolStripMenuItem"
        Me.AddSeletedItemsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddSeletedItemsToolStripMenuItem.Text = "Add Seleted items"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = D7_44ABAC.Hura.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraGroupBox1)
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(902, 685)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "44AB - Appointment and Certificates"
        '
        'HuraGroupBox1
        '
        Me.HuraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraGroupBox1.BackColor = System.Drawing.Color.White
        Me.HuraGroupBox1.Controls.Add(Me.Panel1)
        Me.HuraGroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.HuraGroupBox1.Name = "HuraGroupBox1"
        Me.HuraGroupBox1.Size = New System.Drawing.Size(895, 655)
        Me.HuraGroupBox1.TabIndex = 1
        Me.HuraGroupBox1.Text = "HuraGroupBox1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.HuraGroupBox2)
        Me.Panel1.Controls.Add(Me.HuraTabControl1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 649)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Splitter1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(889, 525)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Splitter2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(544, 525)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.AllData)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.StatusStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(542, 366)
        Me.Panel4.TabIndex = 0
        '
        'AllData
        '
        Me.AllData.AllowUserToAddRows = False
        Me.AllData.AllowUserToDeleteRows = False
        Me.AllData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AllData.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AllData.ContextMenuStrip = Me.ContextMenuStrip1
        Me.AllData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllData.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.AllData.Location = New System.Drawing.Point(0, 27)
        Me.AllData.Name = "AllData"
        Me.AllData.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllData.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.AllData.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.AllData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AllData.Size = New System.Drawing.Size(540, 315)
        Me.AllData.TabIndex = 4
        Me.AllData.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txt_Filter)
        Me.Panel7.Controls.Add(Me.Label28)
        Me.Panel7.Controls.Add(Me.txt_filterby)
        Me.Panel7.Controls.Add(Me.Label27)
        Me.Panel7.Controls.Add(Me.btn_RemoveFilter)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.btn_AddSelected)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(540, 27)
        Me.Panel7.TabIndex = 5
        '
        'Label28
        '
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label28.Location = New System.Drawing.Point(312, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 25)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "with value :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label27.Location = New System.Drawing.Point(100, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 25)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Filter by field:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Controls.Add(Me.Label30)
        Me.Panel11.Controls.Add(Me.Label31)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(94, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(6, 25)
        Me.Panel11.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label29.Location = New System.Drawing.Point(4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(2, 25)
        Me.Label29.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label30.Location = New System.Drawing.Point(2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(2, 25)
        Me.Label30.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label31.Location = New System.Drawing.Point(0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(2, 25)
        Me.Label31.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_count1, Me.lbl_count2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 342)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_count1
        '
        Me.lbl_count1.Name = "lbl_count1"
        Me.lbl_count1.Size = New System.Drawing.Size(12, 17)
        Me.lbl_count1.Text = "-"
        '
        'lbl_count2
        '
        Me.lbl_count2.Name = "lbl_count2"
        Me.lbl_count2.Size = New System.Drawing.Size(12, 17)
        Me.lbl_count2.Text = "-"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 366)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(542, 5)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 371)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(542, 152)
        Me.Panel5.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(540, 114)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Proprietor Name"
        Me.ColumnHeader2.Width = 257
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Company Name"
        Me.ColumnHeader3.Width = 201
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btn_Remove_Checked)
        Me.Panel8.Controls.Add(Me.btn_Save)
        Me.Panel8.Controls.Add(Me.btn_Load)
        Me.Panel8.Controls.Add(Me.btn_Uncheck_Selected)
        Me.Panel8.Controls.Add(Me.btn_Check_Selected)
        Me.Panel8.Controls.Add(Me.btn_Uncheck_All)
        Me.Panel8.Controls.Add(Me.btn_Select_All)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 114)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(540, 36)
        Me.Panel8.TabIndex = 6
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(544, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 525)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Partners, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_ID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CompName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PAN, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_TypeOfConcern, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Add1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Add2, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Add3, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_status, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PropName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Date, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label24, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_OtherIncome, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CertificateDate, 1, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(549, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(340, 525)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_Partners
        '
        Me.txt_Partners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Partners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Partners.Location = New System.Drawing.Point(148, 293)
        Me.txt_Partners.Multiline = True
        Me.txt_Partners.Name = "txt_Partners"
        Me.txt_Partners.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Partners.Size = New System.Drawing.Size(189, 49)
        Me.txt_Partners.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 55)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Partners :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Propritor Name :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Company Name :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "PAN :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Type of Concern :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Address Line 1 :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 29)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Address Line 2 :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Address Line 3 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ID
        '
        Me.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ID.Location = New System.Drawing.Point(148, 3)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(189, 24)
        Me.txt_ID.TabIndex = 1
        Me.txt_ID.TabStop = False
        '
        'txt_CompName
        '
        Me.txt_CompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CompName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CompName.Location = New System.Drawing.Point(148, 61)
        Me.txt_CompName.Name = "txt_CompName"
        Me.txt_CompName.Size = New System.Drawing.Size(189, 24)
        Me.txt_CompName.TabIndex = 3
        '
        'txt_PAN
        '
        Me.txt_PAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PAN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PAN.Location = New System.Drawing.Point(148, 90)
        Me.txt_PAN.Name = "txt_PAN"
        Me.txt_PAN.Size = New System.Drawing.Size(189, 24)
        Me.txt_PAN.TabIndex = 4
        '
        'txt_TypeOfConcern
        '
        Me.txt_TypeOfConcern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TypeOfConcern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_TypeOfConcern.Items.AddRange(New Object() {"Proprietorship Firm", "Partnership Firm", "Private Limited Company"})
        Me.txt_TypeOfConcern.Location = New System.Drawing.Point(148, 119)
        Me.txt_TypeOfConcern.Name = "txt_TypeOfConcern"
        Me.txt_TypeOfConcern.Size = New System.Drawing.Size(189, 25)
        Me.txt_TypeOfConcern.TabIndex = 5
        '
        'txt_Add1
        '
        Me.txt_Add1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Add1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Add1.Location = New System.Drawing.Point(148, 148)
        Me.txt_Add1.Name = "txt_Add1"
        Me.txt_Add1.Size = New System.Drawing.Size(189, 24)
        Me.txt_Add1.TabIndex = 6
        '
        'txt_Add2
        '
        Me.txt_Add2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Add2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Add2.Location = New System.Drawing.Point(148, 177)
        Me.txt_Add2.Name = "txt_Add2"
        Me.txt_Add2.Size = New System.Drawing.Size(189, 24)
        Me.txt_Add2.TabIndex = 7
        '
        'txt_Add3
        '
        Me.txt_Add3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Add3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Add3.Location = New System.Drawing.Point(148, 206)
        Me.txt_Add3.Name = "txt_Add3"
        Me.txt_Add3.Size = New System.Drawing.Size(189, 24)
        Me.txt_Add3.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cb_Recursive)
        Me.Panel6.Controls.Add(Me.btn_Done)
        Me.Panel6.Controls.Add(Me.btn_Cancel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(148, 488)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(189, 34)
        Me.Panel6.TabIndex = 4
        '
        'btn_Done
        '
        Me.btn_Done.BackColor = System.Drawing.Color.Transparent
        Me.btn_Done.BaseColour = System.Drawing.Color.White
        Me.btn_Done.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Done.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Done.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Done.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Done.Location = New System.Drawing.Point(97, 0)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Done.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Done.Size = New System.Drawing.Size(44, 34)
        Me.btn_Done.TabIndex = 16
        Me.btn_Done.Text = "Done"
        Me.btn_Done.Visible = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.BaseColour = System.Drawing.Color.White
        Me.btn_Cancel.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Cancel.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Cancel.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel.Location = New System.Drawing.Point(141, 0)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Cancel.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel.Size = New System.Drawing.Size(48, 34)
        Me.btn_Cancel.TabIndex = 17
        Me.btn_Cancel.TabStop = False
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.Visible = False
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_status.Location = New System.Drawing.Point(3, 485)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(139, 40)
        Me.lbl_status.TabIndex = 10
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PropName
        '
        Me.txt_PropName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PropName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PropName.Location = New System.Drawing.Point(148, 32)
        Me.txt_PropName.Name = "txt_PropName"
        Me.txt_PropName.Size = New System.Drawing.Size(189, 24)
        Me.txt_PropName.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(3, 232)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 29)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Date :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Date
        '
        Me.txt_Date.CustomFormat = "dd-MM-yyyy"
        Me.txt_Date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Date.Location = New System.Drawing.Point(148, 235)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Size = New System.Drawing.Size(189, 24)
        Me.txt_Date.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Location = New System.Drawing.Point(3, 430)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 55)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Other Income :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.Location = New System.Drawing.Point(3, 345)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 85)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Revenue Recognition :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cb_SaleOfGoods)
        Me.FlowLayoutPanel1.Controls.Add(Me.cb_ProvisionofServices)
        Me.FlowLayoutPanel1.Controls.Add(Me.cb_OtherIncome)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(148, 348)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(189, 79)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'cb_SaleOfGoods
        '
        Me.cb_SaleOfGoods.AutoSize = True
        Me.cb_SaleOfGoods.Location = New System.Drawing.Point(3, 3)
        Me.cb_SaleOfGoods.Name = "cb_SaleOfGoods"
        Me.cb_SaleOfGoods.Size = New System.Drawing.Size(110, 21)
        Me.cb_SaleOfGoods.TabIndex = 12
        Me.cb_SaleOfGoods.Text = "Sale of Goods"
        Me.cb_SaleOfGoods.UseVisualStyleBackColor = True
        '
        'cb_ProvisionofServices
        '
        Me.cb_ProvisionofServices.AutoSize = True
        Me.cb_ProvisionofServices.Location = New System.Drawing.Point(3, 30)
        Me.cb_ProvisionofServices.Name = "cb_ProvisionofServices"
        Me.cb_ProvisionofServices.Size = New System.Drawing.Size(147, 21)
        Me.cb_ProvisionofServices.TabIndex = 13
        Me.cb_ProvisionofServices.Text = "Provision of Services"
        Me.cb_ProvisionofServices.UseVisualStyleBackColor = True
        '
        'cb_OtherIncome
        '
        Me.cb_OtherIncome.AutoSize = True
        Me.cb_OtherIncome.Location = New System.Drawing.Point(3, 57)
        Me.cb_OtherIncome.Name = "cb_OtherIncome"
        Me.cb_OtherIncome.Size = New System.Drawing.Size(106, 21)
        Me.cb_OtherIncome.TabIndex = 14
        Me.cb_OtherIncome.Text = "Other Income"
        Me.cb_OtherIncome.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Location = New System.Drawing.Point(3, 261)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(139, 29)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Certificate Date :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_OtherIncome
        '
        Me.txt_OtherIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_OtherIncome.Location = New System.Drawing.Point(148, 433)
        Me.txt_OtherIncome.Multiline = True
        Me.txt_OtherIncome.Name = "txt_OtherIncome"
        Me.txt_OtherIncome.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_OtherIncome.Size = New System.Drawing.Size(189, 49)
        Me.txt_OtherIncome.TabIndex = 15
        '
        'txt_CertificateDate
        '
        Me.txt_CertificateDate.CustomFormat = "dd-MM-yyyy"
        Me.txt_CertificateDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CertificateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_CertificateDate.Location = New System.Drawing.Point(148, 264)
        Me.txt_CertificateDate.Name = "txt_CertificateDate"
        Me.txt_CertificateDate.Size = New System.Drawing.Size(189, 24)
        Me.txt_CertificateDate.TabIndex = 10
        '
        'HuraGroupBox2
        '
        Me.HuraGroupBox2.BackColor = System.Drawing.Color.White
        Me.HuraGroupBox2.Controls.Add(Me.cb_Template)
        Me.HuraGroupBox2.Controls.Add(Me.Label1)
        Me.HuraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.HuraGroupBox2.Location = New System.Drawing.Point(0, 99)
        Me.HuraGroupBox2.Name = "HuraGroupBox2"
        Me.HuraGroupBox2.Size = New System.Drawing.Size(889, 25)
        Me.HuraGroupBox2.TabIndex = 2
        Me.HuraGroupBox2.Text = "HuraGroupBox2"
        '
        'cb_Template
        '
        Me.cb_Template.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_Template.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Template.ColorScheme = D7_44ABAC.Hura.HuraComboBox.ColorSchemes.Dark
        Me.cb_Template.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Template.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_Template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Template.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cb_Template.ForeColor = System.Drawing.Color.White
        Me.cb_Template.FormattingEnabled = True
        Me.cb_Template.Location = New System.Drawing.Point(70, 0)
        Me.cb_Template.Name = "cb_Template"
        Me.cb_Template.Size = New System.Drawing.Size(819, 25)
        Me.cb_Template.TabIndex = 1
        Me.cb_Template.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Template :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HuraTabControl1
        '
        Me.HuraTabControl1.Controls.Add(Me.TabPage1)
        Me.HuraTabControl1.Controls.Add(Me.tb_Settings)
        Me.HuraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.HuraTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.HuraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.HuraTabControl1.Name = "HuraTabControl1"
        Me.HuraTabControl1.SelectedIndex = 0
        Me.HuraTabControl1.Size = New System.Drawing.Size(889, 99)
        Me.HuraTabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.Progress)
        Me.TabPage1.Controls.Add(Me.btn_PDF)
        Me.TabPage1.Controls.Add(Me.btn_Word)
        Me.TabPage1.Controls.Add(Me.btn_Print)
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Controls.Add(Me.btn_Compact)
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.btn_Delete)
        Me.TabPage1.Controls.Add(Me.btn_Edit)
        Me.TabPage1.Controls.Add(Me.btn_AddNew)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(881, 61)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        '
        'Progress
        '
        Me.Progress.BackColor = System.Drawing.Color.Silver
        Me.Progress.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Progress.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Progress.Dock = System.Windows.Forms.DockStyle.Right
        Me.Progress.Location = New System.Drawing.Point(823, 3)
        Me.Progress.Maximum = 100
        Me.Progress.Name = "Progress"
        Me.Progress.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Progress.RotationAngle = 255
        Me.Progress.Size = New System.Drawing.Size(55, 55)
        Me.Progress.StartingAngle = 110
        Me.Progress.TabIndex = 9
        Me.Progress.Value = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label19)
        Me.Panel10.Controls.Add(Me.Label20)
        Me.Panel10.Controls.Add(Me.Label21)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(386, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(6, 55)
        Me.Panel10.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Location = New System.Drawing.Point(4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(2, 55)
        Me.Label19.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label20.Location = New System.Drawing.Point(2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(2, 55)
        Me.Label20.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(2, 55)
        Me.Label21.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label16)
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(216, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(7, 55)
        Me.Panel9.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Location = New System.Drawing.Point(4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(2, 55)
        Me.Label16.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.Location = New System.Drawing.Point(2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(2, 55)
        Me.Label15.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(2, 55)
        Me.Label17.TabIndex = 2
        '
        'tb_Settings
        '
        Me.tb_Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Settings.Controls.Add(Me.btn_SaveSettings)
        Me.tb_Settings.Controls.Add(Me.txt_YearEnding)
        Me.tb_Settings.Controls.Add(Me.Label14)
        Me.tb_Settings.Controls.Add(Me.txt_Title)
        Me.tb_Settings.Controls.Add(Me.txt_Abstract)
        Me.tb_Settings.Controls.Add(Me.Label12)
        Me.tb_Settings.Controls.Add(Me.Label13)
        Me.tb_Settings.Controls.Add(Me.txt_PDFPrinter)
        Me.tb_Settings.Controls.Add(Me.txt_Financial)
        Me.tb_Settings.Controls.Add(Me.Label26)
        Me.tb_Settings.Controls.Add(Me.Label25)
        Me.tb_Settings.Controls.Add(Me.txt_Assessment)
        Me.tb_Settings.Controls.Add(Me.Label11)
        Me.tb_Settings.Location = New System.Drawing.Point(4, 34)
        Me.tb_Settings.Name = "tb_Settings"
        Me.tb_Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_Settings.Size = New System.Drawing.Size(881, 61)
        Me.tb_Settings.TabIndex = 1
        Me.tb_Settings.Text = "Settings"
        '
        'btn_SaveSettings
        '
        Me.btn_SaveSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SaveSettings.BackColor = System.Drawing.Color.Transparent
        Me.btn_SaveSettings.BaseColour = System.Drawing.Color.White
        Me.btn_SaveSettings.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_SaveSettings.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_SaveSettings.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_SaveSettings.Location = New System.Drawing.Point(800, 25)
        Me.btn_SaveSettings.Name = "btn_SaveSettings"
        Me.btn_SaveSettings.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_SaveSettings.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_SaveSettings.Size = New System.Drawing.Size(75, 30)
        Me.btn_SaveSettings.TabIndex = 2
        Me.btn_SaveSettings.Text = "Save"
        '
        'txt_YearEnding
        '
        Me.txt_YearEnding.BackColor = System.Drawing.Color.White
        Me.txt_YearEnding.Location = New System.Drawing.Point(345, 33)
        Me.txt_YearEnding.Name = "txt_YearEnding"
        Me.txt_YearEnding.Size = New System.Drawing.Size(121, 24)
        Me.txt_YearEnding.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(255, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Year Ending :"
        '
        'txt_Title
        '
        Me.txt_Title.BackColor = System.Drawing.Color.White
        Me.txt_Title.Location = New System.Drawing.Point(124, 33)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(124, 24)
        Me.txt_Title.TabIndex = 1
        '
        'txt_Abstract
        '
        Me.txt_Abstract.BackColor = System.Drawing.Color.White
        Me.txt_Abstract.Location = New System.Drawing.Point(345, 3)
        Me.txt_Abstract.Name = "txt_Abstract"
        Me.txt_Abstract.Size = New System.Drawing.Size(121, 24)
        Me.txt_Abstract.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(79, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Title :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(276, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Abstract :"
        '
        'txt_PDFPrinter
        '
        Me.txt_PDFPrinter.BackColor = System.Drawing.Color.White
        Me.txt_PDFPrinter.Location = New System.Drawing.Point(572, 33)
        Me.txt_PDFPrinter.Name = "txt_PDFPrinter"
        Me.txt_PDFPrinter.Size = New System.Drawing.Size(124, 24)
        Me.txt_PDFPrinter.TabIndex = 1
        '
        'txt_Financial
        '
        Me.txt_Financial.BackColor = System.Drawing.Color.White
        Me.txt_Financial.Location = New System.Drawing.Point(572, 3)
        Me.txt_Financial.Name = "txt_Financial"
        Me.txt_Financial.Size = New System.Drawing.Size(124, 24)
        Me.txt_Financial.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(487, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 17)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "PDF Printer :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(473, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 17)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Financial Year :"
        '
        'txt_Assessment
        '
        Me.txt_Assessment.BackColor = System.Drawing.Color.White
        Me.txt_Assessment.Location = New System.Drawing.Point(124, 3)
        Me.txt_Assessment.Name = "txt_Assessment"
        Me.txt_Assessment.Size = New System.Drawing.Size(124, 24)
        Me.txt_Assessment.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Assessment Year :"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.ColorScheme = D7_44ABAC.Hura.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(800, 2)
        Me.HuraControlBox1.Maximize = True
        Me.HuraControlBox1.Minimize = True
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 0
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 685)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "44AB - Appointment and Certificates"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraGroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.AllData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.HuraGroupBox2.ResumeLayout(False)
        Me.HuraTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.tb_Settings.ResumeLayout(False)
        Me.tb_Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As D7_44ABAC.Hura.HuraForm
    Friend WithEvents HuraGroupBox1 As D7_44ABAC.Hura.HuraGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AllData As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_Partners As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_CompName As System.Windows.Forms.TextBox
    Friend WithEvents txt_PAN As System.Windows.Forms.TextBox
    Friend WithEvents txt_TypeOfConcern As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Add1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Add2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Add3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btn_Done As D7_44ABAC.Hura.HuraButton
    Friend WithEvents HuraGroupBox2 As D7_44ABAC.Hura.HuraGroupBox
    Friend WithEvents cb_Template As D7_44ABAC.Hura.HuraComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HuraTabControl1 As D7_44ABAC.Hura.HuraTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tb_Settings As System.Windows.Forms.TabPage
    Friend WithEvents HuraControlBox1 As D7_44ABAC.Hura.HuraControlBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Title As TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Assessment As TextBox
    Friend WithEvents txt_YearEnding As TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Abstract As TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_AddSelected As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Uncheck_Selected As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Check_Selected As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Uncheck_All As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Select_All As D7_44ABAC.Hura.HuraButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_count1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_SaveSettings As D7_44ABAC.Hura.HuraButton
    Friend WithEvents cb_Recursive As D7_44ABAC.Hura.HuraCheckBox
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents btn_AddNew As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Cancel As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Edit As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Delete As D7_44ABAC.Hura.HuraButton
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_Compact As D7_44ABAC.Hura.HuraButton
    Friend WithEvents txt_PropName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Print As D7_44ABAC.Hura.HuraButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btn_PDF As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Word As D7_44ABAC.Hura.HuraButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cb_SaleOfGoods As System.Windows.Forms.CheckBox
    Friend WithEvents cb_ProvisionofServices As System.Windows.Forms.CheckBox
    Friend WithEvents cb_OtherIncome As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_OtherIncome As System.Windows.Forms.TextBox
    Friend WithEvents txt_CertificateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Financial As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_PDFPrinter As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker_Print As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_Word As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_PDF As System.ComponentModel.BackgroundWorker
    Friend WithEvents Progress As D7_44ABAC.LogInRadialProgressBar
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_Filter As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_filterby As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbl_count2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_Save As D7_44ABAC.Hura.HuraButton
    Friend WithEvents btn_Load As D7_44ABAC.Hura.HuraButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_RemoveFilter As D7_44ABAC.Hura.HuraButton
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btn_Remove_Checked As D7_44ABAC.Hura.HuraButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddSeletedItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
