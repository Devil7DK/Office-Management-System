<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_FeesReminder
    Inherits [Lib].XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FeesReminder))
        Me.table_Details_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Sender = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Receiver = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Sender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_Body = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_OpeningBalance = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Body = New DevExpress.XtraEditors.TextEdit()
        Me.txt_OpeningBalance = New DevExpress.XtraEditors.SpinEdit()
        Me.cmb_Receiver = New DevExpress.XtraEditors.LookUpEdit()
        Me.group_Details = New DevExpress.XtraEditors.GroupControl()
        Me.gc_Details = New DevExpress.XtraGrid.GridControl()
        Me.menu_Details = New System.Windows.Forms.ContextMenuStrip()
        Me.menu_Item_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.gv_Details = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Date = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Details = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_Amount = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Fees = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_Detail = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Effect = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Effect = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.table_Details_List = New System.Windows.Forms.TableLayoutPanel()
        Me.panel_Details_Controls = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_Total = New DevExpress.XtraEditors.LabelControl()
        Me.panel_Footer = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Ok = New DevExpress.XtraEditors.SimpleButton()
        Me.table_Details_Main.SuspendLayout()
        CType(Me.cmb_Sender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Body.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OpeningBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Receiver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.group_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Details.SuspendLayout()
        CType(Me.gc_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_Details.SuspendLayout()
        CType(Me.gv_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.cmb_Details.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Fees.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Effect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_Details_Controls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Details_Controls.SuspendLayout()
        CType(Me.panel_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'table_Details_Main
        '
        Me.table_Details_Main.ColumnCount = 3
        Me.table_Details_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.table_Details_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.table_Details_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_Details_Main.Controls.Add(Me.lbl_Sender, 0, 0)
        Me.table_Details_Main.Controls.Add(Me.lbl_Receiver, 0, 1)
        Me.table_Details_Main.Controls.Add(Me.lbl_Splitter1, 1, 0)
        Me.table_Details_Main.Controls.Add(Me.lbl_Splitter2, 1, 1)
        Me.table_Details_Main.Controls.Add(Me.cmb_Sender, 2, 0)
        Me.table_Details_Main.Controls.Add(Me.lbl_Body, 0, 2)
        Me.table_Details_Main.Controls.Add(Me.lbl_Splitter3, 1, 2)
        Me.table_Details_Main.Controls.Add(Me.lbl_OpeningBalance, 0, 3)
        Me.table_Details_Main.Controls.Add(Me.lbl_Splitter4, 1, 3)
        Me.table_Details_Main.Controls.Add(Me.txt_Body, 2, 2)
        Me.table_Details_Main.Controls.Add(Me.txt_OpeningBalance, 2, 3)
        Me.table_Details_Main.Controls.Add(Me.cmb_Receiver, 2, 1)
        Me.table_Details_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.table_Details_Main.Location = New System.Drawing.Point(0, 0)
        Me.table_Details_Main.Name = "table_Details_Main"
        Me.table_Details_Main.RowCount = 4
        Me.table_Details_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Details_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Details_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Details_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_Details_Main.Size = New System.Drawing.Size(534, 107)
        Me.table_Details_Main.TabIndex = 0
        '
        'lbl_Sender
        '
        Me.lbl_Sender.Appearance.Options.UseTextOptions = True
        Me.lbl_Sender.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Sender.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Sender.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Sender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Sender.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Sender.Name = "lbl_Sender"
        Me.lbl_Sender.Size = New System.Drawing.Size(94, 21)
        Me.lbl_Sender.TabIndex = 0
        Me.lbl_Sender.Text = "Sender"
        '
        'lbl_Receiver
        '
        Me.lbl_Receiver.Appearance.Options.UseTextOptions = True
        Me.lbl_Receiver.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Receiver.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Receiver.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Receiver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Receiver.Location = New System.Drawing.Point(3, 30)
        Me.lbl_Receiver.Name = "lbl_Receiver"
        Me.lbl_Receiver.Size = New System.Drawing.Size(94, 21)
        Me.lbl_Receiver.TabIndex = 0
        Me.lbl_Receiver.Text = "Receiver"
        '
        'lbl_Splitter1
        '
        Me.lbl_Splitter1.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Splitter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter1.Location = New System.Drawing.Point(103, 3)
        Me.lbl_Splitter1.Name = "lbl_Splitter1"
        Me.lbl_Splitter1.Size = New System.Drawing.Size(4, 21)
        Me.lbl_Splitter1.TabIndex = 0
        Me.lbl_Splitter1.Text = ":"
        '
        'lbl_Splitter2
        '
        Me.lbl_Splitter2.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Splitter2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter2.Location = New System.Drawing.Point(103, 30)
        Me.lbl_Splitter2.Name = "lbl_Splitter2"
        Me.lbl_Splitter2.Size = New System.Drawing.Size(4, 21)
        Me.lbl_Splitter2.TabIndex = 0
        Me.lbl_Splitter2.Text = ":"
        '
        'cmb_Sender
        '
        Me.cmb_Sender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Sender.Location = New System.Drawing.Point(113, 3)
        Me.cmb_Sender.Name = "cmb_Sender"
        Me.cmb_Sender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Sender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Sender.Size = New System.Drawing.Size(418, 20)
        Me.cmb_Sender.TabIndex = 0
        '
        'lbl_Body
        '
        Me.lbl_Body.Appearance.Options.UseTextOptions = True
        Me.lbl_Body.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Body.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Body.Location = New System.Drawing.Point(3, 57)
        Me.lbl_Body.Name = "lbl_Body"
        Me.lbl_Body.Size = New System.Drawing.Size(94, 20)
        Me.lbl_Body.TabIndex = 2
        Me.lbl_Body.Text = "Body (Optional)"
        '
        'lbl_Splitter3
        '
        Me.lbl_Splitter3.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter3.Location = New System.Drawing.Point(103, 57)
        Me.lbl_Splitter3.Name = "lbl_Splitter3"
        Me.lbl_Splitter3.Size = New System.Drawing.Size(4, 20)
        Me.lbl_Splitter3.TabIndex = 3
        Me.lbl_Splitter3.Text = ":"
        '
        'lbl_OpeningBalance
        '
        Me.lbl_OpeningBalance.Appearance.Options.UseTextOptions = True
        Me.lbl_OpeningBalance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_OpeningBalance.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_OpeningBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_OpeningBalance.Location = New System.Drawing.Point(3, 83)
        Me.lbl_OpeningBalance.Name = "lbl_OpeningBalance"
        Me.lbl_OpeningBalance.Size = New System.Drawing.Size(94, 21)
        Me.lbl_OpeningBalance.TabIndex = 4
        Me.lbl_OpeningBalance.Text = "Opening Balance"
        '
        'lbl_Splitter4
        '
        Me.lbl_Splitter4.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter4.Location = New System.Drawing.Point(103, 83)
        Me.lbl_Splitter4.Name = "lbl_Splitter4"
        Me.lbl_Splitter4.Size = New System.Drawing.Size(4, 21)
        Me.lbl_Splitter4.TabIndex = 5
        Me.lbl_Splitter4.Text = ":"
        '
        'txt_Body
        '
        Me.txt_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Body.Location = New System.Drawing.Point(113, 57)
        Me.txt_Body.Name = "txt_Body"
        Me.txt_Body.Size = New System.Drawing.Size(418, 20)
        Me.txt_Body.TabIndex = 2
        '
        'txt_OpeningBalance
        '
        Me.txt_OpeningBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_OpeningBalance.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_OpeningBalance.Location = New System.Drawing.Point(113, 83)
        Me.txt_OpeningBalance.Name = "txt_OpeningBalance"
        Me.txt_OpeningBalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_OpeningBalance.Properties.MaxValue = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txt_OpeningBalance.Size = New System.Drawing.Size(418, 20)
        Me.txt_OpeningBalance.TabIndex = 3
        '
        'cmb_Receiver
        '
        Me.cmb_Receiver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Receiver.Location = New System.Drawing.Point(113, 30)
        Me.cmb_Receiver.Name = "cmb_Receiver"
        Me.cmb_Receiver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Receiver.Properties.DisplayMember = "Name"
        Me.cmb_Receiver.Properties.ValueMember = "RID"
        Me.cmb_Receiver.Size = New System.Drawing.Size(418, 20)
        Me.cmb_Receiver.TabIndex = 6
        '
        'group_Details
        '
        Me.group_Details.Controls.Add(Me.gc_Details)
        Me.group_Details.Controls.Add(Me.TableLayoutPanel1)
        Me.group_Details.Controls.Add(Me.table_Details_List)
        Me.group_Details.Controls.Add(Me.panel_Details_Controls)
        Me.group_Details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_Details.Location = New System.Drawing.Point(0, 107)
        Me.group_Details.Name = "group_Details"
        Me.group_Details.Size = New System.Drawing.Size(534, 244)
        Me.group_Details.TabIndex = 1
        Me.group_Details.Text = "Details (Items)"
        '
        'gc_Details
        '
        Me.gc_Details.ContextMenuStrip = Me.menu_Details
        Me.gc_Details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Details.Location = New System.Drawing.Point(2, 72)
        Me.gc_Details.MainView = Me.gv_Details
        Me.gc_Details.Name = "gc_Details"
        Me.gc_Details.Size = New System.Drawing.Size(530, 137)
        Me.gc_Details.TabIndex = 1
        Me.gc_Details.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Details})
        '
        'menu_Details
        '
        Me.menu_Details.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Item_Remove})
        Me.menu_Details.Name = "ContextMenuStrip1"
        Me.menu_Details.Size = New System.Drawing.Size(118, 26)
        '
        'menu_Item_Remove
        '
        Me.menu_Item_Remove.Name = "menu_Item_Remove"
        Me.menu_Item_Remove.Size = New System.Drawing.Size(117, 22)
        Me.menu_Item_Remove.Text = "Remove"
        '
        'gv_Details
        '
        Me.gv_Details.GridControl = Me.gc_Details
        Me.gv_Details.Name = "gv_Details"
        Me.gv_Details.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_Details.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_Details.OptionsView.ShowGroupPanel = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Add, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Date, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Details, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Amount, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Fees, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Detail, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter6, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter7, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Effect, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Effect, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Date, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(530, 52)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Add.Location = New System.Drawing.Point(481, 3)
        Me.btn_Add.Name = "btn_Add"
        Me.TableLayoutPanel1.SetRowSpan(Me.btn_Add, 2)
        Me.btn_Add.Size = New System.Drawing.Size(46, 46)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "Add"
        '
        'lbl_Date
        '
        Me.lbl_Date.Appearance.Options.UseTextOptions = True
        Me.lbl_Date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Date.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Date.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(39, 20)
        Me.lbl_Date.TabIndex = 0
        Me.lbl_Date.Text = "Date"
        '
        'cmb_Details
        '
        Me.cmb_Details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Details.Location = New System.Drawing.Point(222, 3)
        Me.cmb_Details.Name = "cmb_Details"
        Me.cmb_Details.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Details.Size = New System.Drawing.Size(253, 20)
        Me.cmb_Details.TabIndex = 4
        '
        'lbl_Amount
        '
        Me.lbl_Amount.Appearance.Options.UseTextOptions = True
        Me.lbl_Amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Amount.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Amount.Location = New System.Drawing.Point(168, 29)
        Me.lbl_Amount.Name = "lbl_Amount"
        Me.lbl_Amount.Size = New System.Drawing.Size(40, 20)
        Me.lbl_Amount.TabIndex = 1
        Me.lbl_Amount.Text = "Amount"
        '
        'txt_Fees
        '
        Me.txt_Fees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Fees.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Fees.Location = New System.Drawing.Point(222, 29)
        Me.txt_Fees.Name = "txt_Fees"
        Me.txt_Fees.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Fees.Properties.MaxValue = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txt_Fees.Size = New System.Drawing.Size(253, 20)
        Me.txt_Fees.TabIndex = 5
        '
        'lbl_Detail
        '
        Me.lbl_Detail.Appearance.Options.UseTextOptions = True
        Me.lbl_Detail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Detail.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Detail.Location = New System.Drawing.Point(168, 3)
        Me.lbl_Detail.Name = "lbl_Detail"
        Me.lbl_Detail.Size = New System.Drawing.Size(40, 20)
        Me.lbl_Detail.TabIndex = 1
        Me.lbl_Detail.Text = "Detail"
        '
        'lbl_Splitter6
        '
        Me.lbl_Splitter6.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter6.Location = New System.Drawing.Point(48, 29)
        Me.lbl_Splitter6.Name = "lbl_Splitter6"
        Me.lbl_Splitter6.Size = New System.Drawing.Size(3, 20)
        Me.lbl_Splitter6.TabIndex = 1
        Me.lbl_Splitter6.Text = ":"
        '
        'lbl_Splitter5
        '
        Me.lbl_Splitter5.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter5.Location = New System.Drawing.Point(48, 3)
        Me.lbl_Splitter5.Name = "lbl_Splitter5"
        Me.lbl_Splitter5.Size = New System.Drawing.Size(3, 20)
        Me.lbl_Splitter5.TabIndex = 1
        Me.lbl_Splitter5.Text = ":"
        '
        'lbl_Splitter7
        '
        Me.lbl_Splitter7.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter7.Location = New System.Drawing.Point(214, 3)
        Me.lbl_Splitter7.Name = "lbl_Splitter7"
        Me.lbl_Splitter7.Size = New System.Drawing.Size(2, 20)
        Me.lbl_Splitter7.TabIndex = 5
        Me.lbl_Splitter7.Text = ":"
        '
        'lbl_Effect
        '
        Me.lbl_Effect.Appearance.Options.UseTextOptions = True
        Me.lbl_Effect.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Effect.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Effect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Effect.Location = New System.Drawing.Point(3, 29)
        Me.lbl_Effect.Name = "lbl_Effect"
        Me.lbl_Effect.Size = New System.Drawing.Size(39, 20)
        Me.lbl_Effect.TabIndex = 4
        Me.lbl_Effect.Text = "Effect"
        '
        'cmb_Effect
        '
        Me.cmb_Effect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Effect.Location = New System.Drawing.Point(57, 29)
        Me.cmb_Effect.Name = "cmb_Effect"
        Me.cmb_Effect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Effect.Properties.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmb_Effect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Effect.Size = New System.Drawing.Size(105, 20)
        Me.cmb_Effect.TabIndex = 6
        '
        'txt_Date
        '
        Me.txt_Date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Date.EditValue = Nothing
        Me.txt_Date.Location = New System.Drawing.Point(57, 3)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txt_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_Date.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txt_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_Date.Size = New System.Drawing.Size(105, 20)
        Me.txt_Date.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(214, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(2, 20)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = ":"
        '
        'table_Details_List
        '
        Me.table_Details_List.AutoSize = True
        Me.table_Details_List.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.table_Details_List.ColumnCount = 7
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.table_Details_List.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.table_Details_List.Dock = System.Windows.Forms.DockStyle.Top
        Me.table_Details_List.Location = New System.Drawing.Point(2, 20)
        Me.table_Details_List.Name = "table_Details_List"
        Me.table_Details_List.RowCount = 2
        Me.table_Details_List.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_Details_List.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_Details_List.Size = New System.Drawing.Size(530, 0)
        Me.table_Details_List.TabIndex = 0
        '
        'panel_Details_Controls
        '
        Me.panel_Details_Controls.Controls.Add(Me.lbl_Total)
        Me.panel_Details_Controls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_Details_Controls.Location = New System.Drawing.Point(2, 209)
        Me.panel_Details_Controls.Name = "panel_Details_Controls"
        Me.panel_Details_Controls.Size = New System.Drawing.Size(530, 33)
        Me.panel_Details_Controls.TabIndex = 0
        '
        'lbl_Total
        '
        Me.lbl_Total.Location = New System.Drawing.Point(15, 10)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Total.TabIndex = 0
        Me.lbl_Total.Text = "Total :"
        Me.lbl_Total.ToolTip = "Total = Opening Balance + Total of Dr + Total of Cr"
        '
        'panel_Footer
        '
        Me.panel_Footer.Controls.Add(Me.btn_Cancel)
        Me.panel_Footer.Controls.Add(Me.btn_Ok)
        Me.panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_Footer.Location = New System.Drawing.Point(0, 351)
        Me.panel_Footer.Name = "panel_Footer"
        Me.panel_Footer.Size = New System.Drawing.Size(534, 33)
        Me.panel_Footer.TabIndex = 2
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Cancel.Location = New System.Drawing.Point(2, 2)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 29)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Ok
        '
        Me.btn_Ok.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Ok.Location = New System.Drawing.Point(457, 2)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(75, 29)
        Me.btn_Ok.TabIndex = 0
        Me.btn_Ok.Text = "Ok"
        '
        'frm_FeesReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 384)
        Me.Controls.Add(Me.group_Details)
        Me.Controls.Add(Me.panel_Footer)
        Me.Controls.Add(Me.table_Details_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_FeesReminder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Details"
        Me.table_Details_Main.ResumeLayout(False)
        Me.table_Details_Main.PerformLayout()
        CType(Me.cmb_Sender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Body.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OpeningBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Receiver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.group_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Details.ResumeLayout(False)
        Me.group_Details.PerformLayout()
        CType(Me.gc_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_Details.ResumeLayout(False)
        CType(Me.gv_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.cmb_Details.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Fees.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Effect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_Details_Controls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Details_Controls.ResumeLayout(False)
        Me.panel_Details_Controls.PerformLayout()
        CType(Me.panel_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Footer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents table_Details_Main As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_Sender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Receiver As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Sender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents group_Details As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_Details As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Details As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panel_Details_Controls As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_Footer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents table_Details_List As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Detail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Details As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Fees As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents menu_Details As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menu_Item_Remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_Body As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_OpeningBalance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Body As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_OpeningBalance As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_Effect As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Effect As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_Total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_Date As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Receiver As DevExpress.XtraEditors.LookUpEdit
End Class
