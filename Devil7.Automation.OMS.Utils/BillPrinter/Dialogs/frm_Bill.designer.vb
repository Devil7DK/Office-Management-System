<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Bill))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Receiver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Sender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Date = New DevExpress.XtraEditors.DateEdit()
        Me.txt_SerialNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl_Services = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Services = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Services = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Fees = New DevExpress.XtraEditors.SpinEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Ok = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.cmb_Receiver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Sender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerialNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl_Services, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView_Services, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.cmb_Services.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Fees.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Receiver, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl8, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Sender, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Date, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_SerialNumber, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(534, 107)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl6.Location = New System.Drawing.Point(103, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(4, 21)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Serial Number"
        '
        'cmb_Receiver
        '
        Me.cmb_Receiver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Receiver.Location = New System.Drawing.Point(113, 84)
        Me.cmb_Receiver.Name = "cmb_Receiver"
        Me.cmb_Receiver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Receiver.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Receiver.Size = New System.Drawing.Size(418, 20)
        Me.cmb_Receiver.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl2.Location = New System.Drawing.Point(3, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl3.Location = New System.Drawing.Point(3, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Sender"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl4.Location = New System.Drawing.Point(3, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Receiver"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl7.Location = New System.Drawing.Point(103, 30)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(4, 21)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = ":"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl8.Location = New System.Drawing.Point(103, 57)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 21)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = ":"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl9.Location = New System.Drawing.Point(103, 84)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(4, 21)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = ":"
        '
        'cmb_Sender
        '
        Me.cmb_Sender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Sender.Location = New System.Drawing.Point(113, 57)
        Me.cmb_Sender.Name = "cmb_Sender"
        Me.cmb_Sender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Sender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Sender.Size = New System.Drawing.Size(418, 20)
        Me.cmb_Sender.TabIndex = 1
        '
        'txt_Date
        '
        Me.txt_Date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Date.EditValue = New Date(2017, 9, 5, 17, 0, 10, 383)
        Me.txt_Date.Location = New System.Drawing.Point(113, 30)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Size = New System.Drawing.Size(418, 20)
        Me.txt_Date.TabIndex = 2
        '
        'txt_SerialNumber
        '
        Me.txt_SerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SerialNumber.Location = New System.Drawing.Point(113, 3)
        Me.txt_SerialNumber.Name = "txt_SerialNumber"
        Me.txt_SerialNumber.Size = New System.Drawing.Size(418, 20)
        Me.txt_SerialNumber.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(46, 125)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = ":"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl_Services)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 107)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(534, 244)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Services"
        '
        'GridControl_Services
        '
        Me.GridControl_Services.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl_Services.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_Services.Location = New System.Drawing.Point(2, 75)
        Me.GridControl_Services.MainView = Me.GridView_Services
        Me.GridControl_Services.Name = "GridControl_Services"
        Me.GridControl_Services.Size = New System.Drawing.Size(530, 167)
        Me.GridControl_Services.TabIndex = 1
        Me.GridControl_Services.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Services})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'GridView_Services
        '
        Me.GridView_Services.GridControl = Me.GridControl_Services
        Me.GridView_Services.Name = "GridView_Services"
        Me.GridView_Services.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView_Services.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView_Services.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(530, 55)
        Me.PanelControl1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Add, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelControl10, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelControl11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelControl12, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelControl13, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmb_Services, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Fees, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(526, 51)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Add.Location = New System.Drawing.Point(479, 3)
        Me.btn_Add.Name = "btn_Add"
        Me.TableLayoutPanel2.SetRowSpan(Me.btn_Add, 2)
        Me.btn_Add.Size = New System.Drawing.Size(44, 45)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "Add"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl10.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl10.TabIndex = 1
        Me.LabelControl10.Text = "Service"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl11.Location = New System.Drawing.Point(3, 28)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(43, 20)
        Me.LabelControl11.TabIndex = 1
        Me.LabelControl11.Text = "Fees"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Options.UseTextOptions = True
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl12.Location = New System.Drawing.Point(52, 3)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(3, 19)
        Me.LabelControl12.TabIndex = 1
        Me.LabelControl12.Text = ":"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Options.UseTextOptions = True
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl13.Location = New System.Drawing.Point(52, 28)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl13.TabIndex = 1
        Me.LabelControl13.Text = ":"
        '
        'cmb_Services
        '
        Me.cmb_Services.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Services.Location = New System.Drawing.Point(61, 3)
        Me.cmb_Services.Name = "cmb_Services"
        Me.cmb_Services.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Services.Size = New System.Drawing.Size(412, 20)
        Me.cmb_Services.TabIndex = 2
        '
        'txt_Fees
        '
        Me.txt_Fees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Fees.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Fees.Location = New System.Drawing.Point(61, 28)
        Me.txt_Fees.Name = "txt_Fees"
        Me.txt_Fees.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Fees.Properties.MaxValue = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txt_Fees.Size = New System.Drawing.Size(412, 20)
        Me.txt_Fees.TabIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btn_Cancel)
        Me.PanelControl2.Controls.Add(Me.btn_Ok)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 351)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(534, 33)
        Me.PanelControl2.TabIndex = 2
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
        'frm_EstimateBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 384)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_EstimateBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.cmb_Receiver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Sender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerialNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl_Services, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView_Services, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.cmb_Services.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Fees.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Sender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Receiver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_SerialNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl_Services As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Services As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Services As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Fees As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
