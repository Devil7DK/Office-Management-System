Imports System.Windows.Forms

Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Job
        Inherits Devil7.Automation.OMS.Lib.XtraFormTemp

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Job))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.gc_AutoForwards = New DevExpress.XtraGrid.GridControl()
            Me.gv_AutoForwards = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.btn_AutoForwards_Remove = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_AutoForwards_Add = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
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
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.gc_FollowUps = New DevExpress.XtraGrid.GridControl()
            Me.gv_FollowUps = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btn_FollowUps_Remove = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_FollowUps_Add = New DevExpress.XtraEditors.SimpleButton()
            Me.txt_NotifyInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.txt_DueInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_PrimaryPeriod = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Panel1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.Panel7.SuspendLayout()
            CType(Me.gc_AutoForwards, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_AutoForwards, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel8.SuspendLayout()
            CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Steps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            CType(Me.cmb_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_SubGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            CType(Me.gc_FollowUps, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_FollowUps, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel6.SuspendLayout()
            CType(Me.txt_NotifyInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_DueInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_PrimaryPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(571, 375)
            Me.Panel1.TabIndex = 0
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 456.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 2, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl8, 1, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 0, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 0, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 1, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 6)
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
            Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 2, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_NotifyInterval, 2, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_DueInterval, 2, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl6, 1, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_PrimaryPeriod, 2, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl10, 1, 7)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 11
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(554, 598)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.gc_AutoForwards)
            Me.Panel7.Controls.Add(Me.Panel8)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(118, 426)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(450, 94)
            Me.Panel7.TabIndex = 28
            '
            'gc_AutoForwards
            '
            Me.gc_AutoForwards.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_AutoForwards.Location = New System.Drawing.Point(0, 0)
            Me.gc_AutoForwards.MainView = Me.gv_AutoForwards
            Me.gc_AutoForwards.Name = "gc_AutoForwards"
            Me.gc_AutoForwards.Size = New System.Drawing.Size(384, 94)
            Me.gc_AutoForwards.TabIndex = 1
            Me.gc_AutoForwards.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_AutoForwards})
            '
            'gv_AutoForwards
            '
            Me.gv_AutoForwards.GridControl = Me.gc_AutoForwards
            Me.gv_AutoForwards.Name = "gv_AutoForwards"
            Me.gv_AutoForwards.OptionsBehavior.ReadOnly = True
            Me.gv_AutoForwards.OptionsView.ShowGroupPanel = False
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.btn_AutoForwards_Remove)
            Me.Panel8.Controls.Add(Me.btn_AutoForwards_Add)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel8.Location = New System.Drawing.Point(384, 0)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(66, 94)
            Me.Panel8.TabIndex = 0
            '
            'btn_AutoForwards_Remove
            '
            Me.btn_AutoForwards_Remove.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_AutoForwards_Remove.Appearance.Options.UseFont = True
            Me.btn_AutoForwards_Remove.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_AutoForwards_Remove.Dock = System.Windows.Forms.DockStyle.Top
            Me.btn_AutoForwards_Remove.Location = New System.Drawing.Point(0, 31)
            Me.btn_AutoForwards_Remove.Name = "btn_AutoForwards_Remove"
            Me.btn_AutoForwards_Remove.Size = New System.Drawing.Size(66, 32)
            Me.btn_AutoForwards_Remove.TabIndex = 3
            Me.btn_AutoForwards_Remove.TabStop = False
            Me.btn_AutoForwards_Remove.Text = "Remove"
            '
            'btn_AutoForwards_Add
            '
            Me.btn_AutoForwards_Add.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_AutoForwards_Add.Appearance.Options.UseFont = True
            Me.btn_AutoForwards_Add.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_AutoForwards_Add.Dock = System.Windows.Forms.DockStyle.Top
            Me.btn_AutoForwards_Add.Location = New System.Drawing.Point(0, 0)
            Me.btn_AutoForwards_Add.Name = "btn_AutoForwards_Add"
            Me.btn_AutoForwards_Add.Size = New System.Drawing.Size(66, 31)
            Me.btn_AutoForwards_Add.TabIndex = 2
            Me.btn_AutoForwards_Add.TabStop = False
            Me.btn_AutoForwards_Add.Text = "Add"
            '
            'LabelControl8
            '
            Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl8.Location = New System.Drawing.Point(109, 576)
            Me.LabelControl8.Name = "LabelControl8"
            Me.LabelControl8.Size = New System.Drawing.Size(3, 19)
            Me.LabelControl8.TabIndex = 24
            Me.LabelControl8.Text = ":"
            '
            'LabelControl7
            '
            Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl7.Location = New System.Drawing.Point(3, 576)
            Me.LabelControl7.Name = "LabelControl7"
            Me.LabelControl7.Size = New System.Drawing.Size(100, 19)
            Me.LabelControl7.TabIndex = 23
            Me.LabelControl7.Text = "Due Date Interval"
            '
            'LabelControl5
            '
            Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl5.Location = New System.Drawing.Point(3, 551)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Size = New System.Drawing.Size(100, 19)
            Me.LabelControl5.TabIndex = 22
            Me.LabelControl5.Text = "Due Date Interval"
            '
            'LabelControl4
            '
            Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl4.Location = New System.Drawing.Point(109, 526)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(3, 19)
            Me.LabelControl4.TabIndex = 21
            Me.LabelControl4.Text = ":"
            '
            'LabelControl3
            '
            Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl3.Location = New System.Drawing.Point(3, 526)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(100, 19)
            Me.LabelControl3.TabIndex = 20
            Me.LabelControl3.Text = "Notification Interval"
            '
            'LabelControl2
            '
            Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl2.Location = New System.Drawing.Point(109, 346)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(3, 74)
            Me.LabelControl2.TabIndex = 8
            Me.LabelControl2.Text = ":"
            '
            'LabelControl1
            '
            Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl1.Location = New System.Drawing.Point(3, 346)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(100, 74)
            Me.LabelControl1.TabIndex = 18
            Me.LabelControl1.Text = "Follow Up Jobs"
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Location = New System.Drawing.Point(3, 3)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 19)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Name"
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Location = New System.Drawing.Point(3, 28)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 19)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Group"
            '
            'Label3
            '
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Location = New System.Drawing.Point(109, 3)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(3, 19)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = ":"
            '
            'Label4
            '
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label4.Location = New System.Drawing.Point(109, 28)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(3, 19)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = ":"
            '
            'Label5
            '
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label5.Location = New System.Drawing.Point(109, 53)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(3, 19)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = ":"
            '
            'Label6
            '
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label6.Location = New System.Drawing.Point(109, 78)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(3, 19)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = ":"
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label7.Location = New System.Drawing.Point(109, 103)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(3, 132)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = ":"
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label8.Location = New System.Drawing.Point(109, 241)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(3, 99)
            Me.Label8.TabIndex = 7
            Me.Label8.Text = ":"
            '
            'Label9
            '
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label9.Location = New System.Drawing.Point(3, 53)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(100, 19)
            Me.Label9.TabIndex = 8
            Me.Label9.Text = "Sub Group"
            '
            'Label10
            '
            Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label10.Location = New System.Drawing.Point(3, 78)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(100, 19)
            Me.Label10.TabIndex = 9
            Me.Label10.Text = "Type"
            '
            'Label11
            '
            Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label11.Location = New System.Drawing.Point(3, 103)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(100, 132)
            Me.Label11.TabIndex = 10
            Me.Label11.Text = "Steps"
            '
            'Label12
            '
            Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label12.Location = New System.Drawing.Point(3, 241)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(100, 99)
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
            Me.txt_Steps.Location = New System.Drawing.Point(118, 103)
            Me.txt_Steps.Name = "txt_Steps"
            Me.txt_Steps.Size = New System.Drawing.Size(450, 132)
            Me.txt_Steps.TabIndex = 4
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.lst_Templates)
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(118, 241)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(450, 99)
            Me.Panel3.TabIndex = 17
            '
            'lst_Templates
            '
            Me.lst_Templates.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lst_Templates.FormattingEnabled = True
            Me.lst_Templates.HorizontalScrollbar = True
            Me.lst_Templates.Location = New System.Drawing.Point(0, 0)
            Me.lst_Templates.Name = "lst_Templates"
            Me.lst_Templates.Size = New System.Drawing.Size(384, 99)
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
            Me.Panel4.Size = New System.Drawing.Size(66, 99)
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
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.gc_FollowUps)
            Me.Panel5.Controls.Add(Me.Panel6)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(118, 346)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(450, 74)
            Me.Panel5.TabIndex = 19
            '
            'gc_FollowUps
            '
            Me.gc_FollowUps.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_FollowUps.Location = New System.Drawing.Point(0, 0)
            Me.gc_FollowUps.MainView = Me.gv_FollowUps
            Me.gc_FollowUps.Name = "gc_FollowUps"
            Me.gc_FollowUps.Size = New System.Drawing.Size(384, 74)
            Me.gc_FollowUps.TabIndex = 1
            Me.gc_FollowUps.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_FollowUps})
            '
            'gv_FollowUps
            '
            Me.gv_FollowUps.GridControl = Me.gc_FollowUps
            Me.gv_FollowUps.Name = "gv_FollowUps"
            Me.gv_FollowUps.OptionsBehavior.ReadOnly = True
            Me.gv_FollowUps.OptionsView.ShowGroupPanel = False
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btn_FollowUps_Remove)
            Me.Panel6.Controls.Add(Me.btn_FollowUps_Add)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(384, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(66, 74)
            Me.Panel6.TabIndex = 0
            '
            'btn_FollowUps_Remove
            '
            Me.btn_FollowUps_Remove.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_FollowUps_Remove.Appearance.Options.UseFont = True
            Me.btn_FollowUps_Remove.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_FollowUps_Remove.Dock = System.Windows.Forms.DockStyle.Top
            Me.btn_FollowUps_Remove.Location = New System.Drawing.Point(0, 31)
            Me.btn_FollowUps_Remove.Name = "btn_FollowUps_Remove"
            Me.btn_FollowUps_Remove.Size = New System.Drawing.Size(66, 32)
            Me.btn_FollowUps_Remove.TabIndex = 3
            Me.btn_FollowUps_Remove.TabStop = False
            Me.btn_FollowUps_Remove.Text = "Remove"
            '
            'btn_FollowUps_Add
            '
            Me.btn_FollowUps_Add.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_FollowUps_Add.Appearance.Options.UseFont = True
            Me.btn_FollowUps_Add.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_FollowUps_Add.Dock = System.Windows.Forms.DockStyle.Top
            Me.btn_FollowUps_Add.Location = New System.Drawing.Point(0, 0)
            Me.btn_FollowUps_Add.Name = "btn_FollowUps_Add"
            Me.btn_FollowUps_Add.Size = New System.Drawing.Size(66, 31)
            Me.btn_FollowUps_Add.TabIndex = 2
            Me.btn_FollowUps_Add.TabStop = False
            Me.btn_FollowUps_Add.Text = "Add"
            '
            'txt_NotifyInterval
            '
            Me.txt_NotifyInterval.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_NotifyInterval.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.txt_NotifyInterval.Location = New System.Drawing.Point(118, 526)
            Me.txt_NotifyInterval.Name = "txt_NotifyInterval"
            Me.txt_NotifyInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_NotifyInterval.Properties.MaxValue = New Decimal(New Integer() {364, 0, 0, 0})
            Me.txt_NotifyInterval.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.txt_NotifyInterval.Size = New System.Drawing.Size(450, 20)
            Me.txt_NotifyInterval.TabIndex = 7
            '
            'txt_DueInterval
            '
            Me.txt_DueInterval.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_DueInterval.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.txt_DueInterval.Location = New System.Drawing.Point(118, 551)
            Me.txt_DueInterval.Name = "txt_DueInterval"
            Me.txt_DueInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_DueInterval.Properties.MaxValue = New Decimal(New Integer() {364, 0, 0, 0})
            Me.txt_DueInterval.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.txt_DueInterval.Size = New System.Drawing.Size(450, 20)
            Me.txt_DueInterval.TabIndex = 24
            '
            'LabelControl6
            '
            Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl6.Location = New System.Drawing.Point(109, 551)
            Me.LabelControl6.Name = "LabelControl6"
            Me.LabelControl6.Size = New System.Drawing.Size(3, 19)
            Me.LabelControl6.TabIndex = 23
            Me.LabelControl6.Text = ":"
            '
            'txt_PrimaryPeriod
            '
            Me.txt_PrimaryPeriod.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_PrimaryPeriod.Location = New System.Drawing.Point(118, 576)
            Me.txt_PrimaryPeriod.Name = "txt_PrimaryPeriod"
            Me.txt_PrimaryPeriod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_PrimaryPeriod.Properties.Items.AddRange(New Object() {"Assessment Period", "Financial Period"})
            Me.txt_PrimaryPeriod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.txt_PrimaryPeriod.Size = New System.Drawing.Size(450, 20)
            Me.txt_PrimaryPeriod.TabIndex = 25
            '
            'LabelControl9
            '
            Me.LabelControl9.Appearance.Options.UseTextOptions = True
            Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl9.Location = New System.Drawing.Point(3, 426)
            Me.LabelControl9.Name = "LabelControl9"
            Me.LabelControl9.Size = New System.Drawing.Size(100, 94)
            Me.LabelControl9.TabIndex = 26
            Me.LabelControl9.Text = "Auto Forwards"
            '
            'LabelControl10
            '
            Me.LabelControl10.Appearance.Options.UseTextOptions = True
            Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl10.Location = New System.Drawing.Point(109, 426)
            Me.LabelControl10.Name = "LabelControl10"
            Me.LabelControl10.Size = New System.Drawing.Size(3, 94)
            Me.LabelControl10.TabIndex = 27
            Me.LabelControl10.Text = ":"
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
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frm_Job"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Job"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.Panel7.ResumeLayout(False)
            CType(Me.gc_AutoForwards, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_AutoForwards, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel8.ResumeLayout(False)
            CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Steps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            CType(Me.cmb_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_SubGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            CType(Me.gc_FollowUps, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_FollowUps, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel6.ResumeLayout(False)
            CType(Me.txt_NotifyInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_DueInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_PrimaryPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel5 As Panel
        Friend WithEvents gc_FollowUps As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_FollowUps As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents Panel6 As Panel
        Friend WithEvents btn_FollowUps_Remove As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_FollowUps_Add As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_NotifyInterval As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents txt_DueInterval As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_PrimaryPeriod As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Panel7 As Panel
        Friend WithEvents gc_AutoForwards As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_AutoForwards As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents Panel8 As Panel
        Friend WithEvents btn_AutoForwards_Remove As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_AutoForwards_Add As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace