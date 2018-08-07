<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_WorkBook
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
        Dim YearMonth1 As Devil7.Automation.OMS.[Lib].Objects.YearMonth = New Devil7.Automation.OMS.[Lib].Objects.YearMonth()
        Dim YearMonth2 As Devil7.Automation.OMS.[Lib].Objects.YearMonth = New Devil7.Automation.OMS.[Lib].Objects.YearMonth()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_WorkBook))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmb_CurrentlyAssignedTo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_User = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_Job = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_DueDate = New DevExpress.XtraEditors.DateEdit()
        Me.txt_TargetDate = New DevExpress.XtraEditors.DateEdit()
        Me.cmb_Priority = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Status = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmb_Steps = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Description = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Remarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_History = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_FinancialYearMonth = New Devil7.Automation.OMS.[Lib].Utils.YearMonthEdit()
        Me.txt_AssessmentYearMonth = New Devil7.Automation.OMS.[Lib].Utils.YearMonthEdit()
        Me.cmb_Client = New DevExpress.XtraEditors.LookUpEdit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.cmb_CurrentlyAssignedTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_User.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Job.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TargetDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TargetDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Priority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Steps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_History.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Client.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Cancel)
        Me.Panel1.Controls.Add(Me.btn_Done)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 31)
        Me.Panel1.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Cancel.Appearance.Options.UseFont = True
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Location = New System.Drawing.Point(349, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
        Me.btn_Cancel.TabIndex = 14
        Me.btn_Cancel.TabStop = False
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Done
        '
        Me.btn_Done.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Done.Appearance.Options.UseFont = True
        Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Done.Location = New System.Drawing.Point(420, 3)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(65, 24)
        Me.btn_Done.TabIndex = 13
        Me.btn_Done.TabStop = False
        Me.btn_Done.Text = "Done"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_CurrentlyAssignedTo, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl10, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl11, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl12, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl13, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl14, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl15, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl16, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl17, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl18, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl19, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl20, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_User, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Job, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_DueDate, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_TargetDate, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Priority, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl21, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl22, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl23, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl25, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Status, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Steps, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Description, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Remarks, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl24, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl26, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl27, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_History, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_FinancialYearMonth, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_AssessmentYearMonth, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Client, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 414)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cmb_CurrentlyAssignedTo
        '
        Me.cmb_CurrentlyAssignedTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_CurrentlyAssignedTo.Enabled = False
        Me.cmb_CurrentlyAssignedTo.Location = New System.Drawing.Point(136, 305)
        Me.cmb_CurrentlyAssignedTo.Name = "cmb_CurrentlyAssignedTo"
        Me.cmb_CurrentlyAssignedTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_CurrentlyAssignedTo.Size = New System.Drawing.Size(349, 20)
        Me.cmb_CurrentlyAssignedTo.TabIndex = 12
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Owner User"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Job"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(3, 53)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Client"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 78)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Due Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 103)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Target Date"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(3, 128)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Priority"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(3, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Financial Period"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(3, 178)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Assessment Period"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(3, 203)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Desciption"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(3, 228)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Remarks"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(128, 3)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = ":"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(128, 28)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = ":"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(128, 53)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl13.TabIndex = 10
        Me.LabelControl13.Text = ":"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(128, 78)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl14.TabIndex = 10
        Me.LabelControl14.Text = ":"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(128, 103)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl15.TabIndex = 10
        Me.LabelControl15.Text = ":"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(128, 128)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl16.TabIndex = 10
        Me.LabelControl16.Text = ":"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(128, 153)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl17.TabIndex = 10
        Me.LabelControl17.Text = ":"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(128, 178)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl18.TabIndex = 10
        Me.LabelControl18.Text = ":"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(128, 228)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl19.TabIndex = 10
        Me.LabelControl19.Text = ":"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(128, 203)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl20.TabIndex = 10
        Me.LabelControl20.Text = ":"
        '
        'cmb_User
        '
        Me.cmb_User.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_User.Location = New System.Drawing.Point(136, 3)
        Me.cmb_User.Name = "cmb_User"
        Me.cmb_User.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_User.Size = New System.Drawing.Size(349, 20)
        Me.cmb_User.TabIndex = 0
        '
        'cmb_Job
        '
        Me.cmb_Job.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Job.Location = New System.Drawing.Point(136, 28)
        Me.cmb_Job.Name = "cmb_Job"
        Me.cmb_Job.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Job.Size = New System.Drawing.Size(349, 20)
        Me.cmb_Job.TabIndex = 1
        '
        'txt_DueDate
        '
        Me.txt_DueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DueDate.EditValue = Nothing
        Me.txt_DueDate.Location = New System.Drawing.Point(136, 78)
        Me.txt_DueDate.Name = "txt_DueDate"
        Me.txt_DueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_DueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_DueDate.Size = New System.Drawing.Size(349, 20)
        Me.txt_DueDate.TabIndex = 3
        '
        'txt_TargetDate
        '
        Me.txt_TargetDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TargetDate.EditValue = Nothing
        Me.txt_TargetDate.Location = New System.Drawing.Point(136, 103)
        Me.txt_TargetDate.Name = "txt_TargetDate"
        Me.txt_TargetDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TargetDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TargetDate.Size = New System.Drawing.Size(349, 20)
        Me.txt_TargetDate.TabIndex = 4
        '
        'cmb_Priority
        '
        Me.cmb_Priority.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Priority.Location = New System.Drawing.Point(136, 128)
        Me.cmb_Priority.Name = "cmb_Priority"
        Me.cmb_Priority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Priority.Size = New System.Drawing.Size(349, 20)
        Me.cmb_Priority.TabIndex = 5
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(3, 253)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl21.TabIndex = 8
        Me.LabelControl21.Text = "Status"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(128, 253)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl22.TabIndex = 10
        Me.LabelControl22.Text = ":"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(3, 278)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl23.TabIndex = 8
        Me.LabelControl23.Text = "Current Step/Stage"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(128, 278)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl25.TabIndex = 10
        Me.LabelControl25.Text = ":"
        '
        'cmb_Status
        '
        Me.cmb_Status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Status.Location = New System.Drawing.Point(136, 253)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Status.Size = New System.Drawing.Size(349, 20)
        Me.cmb_Status.TabIndex = 10
        '
        'cmb_Steps
        '
        Me.cmb_Steps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Steps.Location = New System.Drawing.Point(136, 278)
        Me.cmb_Steps.Name = "cmb_Steps"
        Me.cmb_Steps.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Steps.Size = New System.Drawing.Size(349, 20)
        Me.cmb_Steps.TabIndex = 11
        '
        'txt_Description
        '
        Me.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Description.Location = New System.Drawing.Point(136, 203)
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(349, 20)
        Me.txt_Description.TabIndex = 8
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Remarks.Location = New System.Drawing.Point(136, 228)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(349, 20)
        Me.txt_Remarks.TabIndex = 9
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(3, 305)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl24.TabIndex = 23
        Me.LabelControl24.Text = "Currently Assigned to"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(128, 305)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl26.TabIndex = 10
        Me.LabelControl26.Text = ":"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(3, 328)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl27.TabIndex = 23
        Me.LabelControl27.Text = "History"
        '
        'txt_History
        '
        Me.txt_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_History.Location = New System.Drawing.Point(136, 328)
        Me.txt_History.Name = "txt_History"
        Me.txt_History.Properties.ReadOnly = True
        Me.txt_History.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_History.Size = New System.Drawing.Size(349, 83)
        Me.txt_History.TabIndex = 24
        '
        'txt_FinancialYearMonth
        '
        Me.txt_FinancialYearMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_FinancialYearMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_FinancialYearMonth.Location = New System.Drawing.Point(136, 153)
        Me.txt_FinancialYearMonth.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.txt_FinancialYearMonth.MinimumSize = New System.Drawing.Size(0, 21)
        Me.txt_FinancialYearMonth.Name = "txt_FinancialYearMonth"
        Me.txt_FinancialYearMonth.PeriodType = Devil7.Automation.OMS.[Lib].Enums.JobType.Once
        Me.txt_FinancialYearMonth.Size = New System.Drawing.Size(349, 21)
        Me.txt_FinancialYearMonth.TabIndex = 6
        YearMonth1.Period = "April"
        YearMonth1.Year = "2018-2019"
        Me.txt_FinancialYearMonth.Value = YearMonth1
        '
        'txt_AssessmentYearMonth
        '
        Me.txt_AssessmentYearMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_AssessmentYearMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AssessmentYearMonth.Location = New System.Drawing.Point(136, 178)
        Me.txt_AssessmentYearMonth.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.txt_AssessmentYearMonth.MinimumSize = New System.Drawing.Size(0, 21)
        Me.txt_AssessmentYearMonth.Name = "txt_AssessmentYearMonth"
        Me.txt_AssessmentYearMonth.PeriodType = Devil7.Automation.OMS.[Lib].Enums.JobType.Once
        Me.txt_AssessmentYearMonth.Size = New System.Drawing.Size(349, 21)
        Me.txt_AssessmentYearMonth.TabIndex = 7
        YearMonth2.Period = "April"
        YearMonth2.Year = "2018-2019"
        Me.txt_AssessmentYearMonth.Value = YearMonth2
        '
        'cmb_Client
        '
        Me.cmb_Client.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Client.Location = New System.Drawing.Point(136, 53)
        Me.cmb_Client.Name = "cmb_Client"
        Me.cmb_Client.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Client.Size = New System.Drawing.Size(349, 20)
        Me.cmb_Client.TabIndex = 2
        '
        'frm_WorkBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 445)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_WorkBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WorkBook"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.cmb_CurrentlyAssignedTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_User.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Job.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TargetDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TargetDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Priority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Steps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_History.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Client.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_User As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_Job As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_DueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_TargetDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmb_Priority As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Status As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_Steps As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Description As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmb_CurrentlyAssignedTo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_History As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_FinancialYearMonth As [Lib].Utils.YearMonthEdit
    Friend WithEvents txt_AssessmentYearMonth As [Lib].Utils.YearMonthEdit
    Friend WithEvents cmb_Client As DevExpress.XtraEditors.LookUpEdit
End Class
