<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddFiles
    Inherits XtraFormTemp

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
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.QueryControl3 = New OMSFileBox.QueryControl()
        Me.cmb_Works = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.QueryControl2 = New OMSFileBox.QueryControl()
        Me.cmb_Job = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QueryControl1 = New OMSFileBox.QueryControl()
        Me.cmb_Clients = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.np_Sent = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.prog_current = New System.Windows.Forms.ProgressBar()
        Me.prog_total = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lbl_Status_FileTrans = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.btn_Send = New DevExpress.XtraEditors.SimpleButton()
        Me.QueryControl4 = New OMSFileBox.QueryControl()
        Me.cmb_Users = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        Me.QueryControl3.WorkingArea1.SuspendLayout()
        Me.QueryControl3.WorkingArea2.SuspendLayout()
        Me.QueryControl3.SuspendLayout()
        CType(Me.cmb_Works.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        Me.QueryControl2.WorkingArea1.SuspendLayout()
        Me.QueryControl2.WorkingArea2.SuspendLayout()
        Me.QueryControl2.SuspendLayout()
        CType(Me.cmb_Job.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QueryControl1.WorkingArea1.SuspendLayout()
        Me.QueryControl1.WorkingArea2.SuspendLayout()
        Me.QueryControl1.SuspendLayout()
        CType(Me.cmb_Clients.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.np_Sent.SuspendLayout()
        CType(Me.prog_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QueryControl4.WorkingArea1.SuspendLayout()
        Me.QueryControl4.WorkingArea2.SuspendLayout()
        Me.QueryControl4.SuspendLayout()
        CType(Me.cmb_Users.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Controls.Add(Me.np_Sent)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage4)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.np_Sent, Me.TabNavigationPage4})
        Me.TabPane1.RegularSize = New System.Drawing.Size(393, 273)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage2
        Me.TabPane1.Size = New System.Drawing.Size(393, 273)
        Me.TabPane1.TabIndex = 3
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Assign to Work"
        Me.TabNavigationPage1.Controls.Add(Me.QueryControl3)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(375, 228)
        '
        'QueryControl3
        '
        Me.QueryControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.QueryControl3.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl3.Name = "QueryControl3"
        Me.QueryControl3.Size = New System.Drawing.Size(375, 21)
        Me.QueryControl3.TabIndex = 3
        '
        'QueryControl3.WorkingArea1
        '
        Me.QueryControl3.WorkingArea1.Controls.Add(Me.cmb_Works)
        Me.QueryControl3.WorkingArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryControl3.WorkingArea1.Location = New System.Drawing.Point(112, 0)
        Me.QueryControl3.WorkingArea1.Name = "WorkingArea1"
        Me.QueryControl3.WorkingArea1.Size = New System.Drawing.Size(263, 21)
        Me.QueryControl3.WorkingArea1.TabIndex = 0
        '
        'QueryControl3.WorkingArea2
        '
        Me.QueryControl3.WorkingArea2.Controls.Add(Me.Label3)
        Me.QueryControl3.WorkingArea2.Dock = System.Windows.Forms.DockStyle.Left
        Me.QueryControl3.WorkingArea2.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl3.WorkingArea2.Name = "WorkingArea2"
        Me.QueryControl3.WorkingArea2.Size = New System.Drawing.Size(101, 21)
        Me.QueryControl3.WorkingArea2.TabIndex = 2
        '
        'cmb_Works
        '
        Me.cmb_Works.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Works.Location = New System.Drawing.Point(0, 0)
        Me.cmb_Works.Name = "cmb_Works"
        Me.cmb_Works.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Works.Properties.DisplayMember = "ID"
        Me.cmb_Works.Properties.PopupWidth = 600
        Me.cmb_Works.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmb_Works.Properties.ValueMember = "ID"
        Me.cmb_Works.Size = New System.Drawing.Size(263, 20)
        Me.cmb_Works.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Works"
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Client & Job"
        Me.TabNavigationPage2.Controls.Add(Me.QueryControl2)
        Me.TabNavigationPage2.Controls.Add(Me.QueryControl1)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(375, 228)
        '
        'QueryControl2
        '
        Me.QueryControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.QueryControl2.Location = New System.Drawing.Point(0, 22)
        Me.QueryControl2.Name = "QueryControl2"
        Me.QueryControl2.Size = New System.Drawing.Size(375, 22)
        Me.QueryControl2.TabIndex = 2
        '
        'QueryControl2.WorkingArea1
        '
        Me.QueryControl2.WorkingArea1.Controls.Add(Me.cmb_Job)
        Me.QueryControl2.WorkingArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryControl2.WorkingArea1.Location = New System.Drawing.Point(111, 0)
        Me.QueryControl2.WorkingArea1.Name = "WorkingArea1"
        Me.QueryControl2.WorkingArea1.Size = New System.Drawing.Size(264, 22)
        Me.QueryControl2.WorkingArea1.TabIndex = 0
        '
        'QueryControl2.WorkingArea2
        '
        Me.QueryControl2.WorkingArea2.Controls.Add(Me.Label2)
        Me.QueryControl2.WorkingArea2.Dock = System.Windows.Forms.DockStyle.Left
        Me.QueryControl2.WorkingArea2.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl2.WorkingArea2.Name = "WorkingArea2"
        Me.QueryControl2.WorkingArea2.Size = New System.Drawing.Size(100, 22)
        Me.QueryControl2.WorkingArea2.TabIndex = 2
        '
        'cmb_Job
        '
        Me.cmb_Job.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Job.Location = New System.Drawing.Point(0, 0)
        Me.cmb_Job.Name = "cmb_Job"
        Me.cmb_Job.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Job.Properties.PopupWidth = 600
        Me.cmb_Job.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmb_Job.Size = New System.Drawing.Size(264, 20)
        Me.cmb_Job.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Job"
        '
        'QueryControl1
        '
        Me.QueryControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.QueryControl1.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl1.Name = "QueryControl1"
        Me.QueryControl1.Size = New System.Drawing.Size(375, 22)
        Me.QueryControl1.TabIndex = 1
        '
        'QueryControl1.WorkingArea1
        '
        Me.QueryControl1.WorkingArea1.Controls.Add(Me.cmb_Clients)
        Me.QueryControl1.WorkingArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryControl1.WorkingArea1.Location = New System.Drawing.Point(111, 0)
        Me.QueryControl1.WorkingArea1.Name = "WorkingArea1"
        Me.QueryControl1.WorkingArea1.Size = New System.Drawing.Size(264, 22)
        Me.QueryControl1.WorkingArea1.TabIndex = 0
        '
        'QueryControl1.WorkingArea2
        '
        Me.QueryControl1.WorkingArea2.Controls.Add(Me.Label1)
        Me.QueryControl1.WorkingArea2.Dock = System.Windows.Forms.DockStyle.Left
        Me.QueryControl1.WorkingArea2.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl1.WorkingArea2.Name = "WorkingArea2"
        Me.QueryControl1.WorkingArea2.Size = New System.Drawing.Size(100, 22)
        Me.QueryControl1.WorkingArea2.TabIndex = 2
        '
        'cmb_Clients
        '
        Me.cmb_Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Clients.Location = New System.Drawing.Point(0, 0)
        Me.cmb_Clients.Name = "cmb_Clients"
        Me.cmb_Clients.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Clients.Properties.PopupWidth = 600
        Me.cmb_Clients.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmb_Clients.Size = New System.Drawing.Size(264, 20)
        Me.cmb_Clients.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client"
        '
        'np_Sent
        '
        Me.np_Sent.Caption = "Sent"
        Me.np_Sent.Controls.Add(Me.SimpleButton1)
        Me.np_Sent.Controls.Add(Me.prog_current)
        Me.np_Sent.Controls.Add(Me.prog_total)
        Me.np_Sent.Controls.Add(Me.lbl_Status_FileTrans)
        Me.np_Sent.Controls.Add(Me.LabelControl1)
        Me.np_Sent.Controls.Add(Me.ListBoxControl1)
        Me.np_Sent.Controls.Add(Me.btn_Send)
        Me.np_Sent.Controls.Add(Me.QueryControl4)
        Me.np_Sent.Name = "np_Sent"
        Me.np_Sent.Size = New System.Drawing.Size(375, 228)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(126, 21)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'prog_current
        '
        Me.prog_current.Location = New System.Drawing.Point(6, 53)
        Me.prog_current.Name = "prog_current"
        Me.prog_current.Size = New System.Drawing.Size(364, 10)
        Me.prog_current.TabIndex = 10
        '
        'prog_total
        '
        Me.prog_total.Location = New System.Drawing.Point(6, 69)
        Me.prog_total.Name = "prog_total"
        Me.prog_total.Size = New System.Drawing.Size(364, 10)
        Me.prog_total.TabIndex = 9
        '
        'lbl_Status_FileTrans
        '
        Me.lbl_Status_FileTrans.Location = New System.Drawing.Point(47, 31)
        Me.lbl_Status_FileTrans.Name = "lbl_Status_FileTrans"
        Me.lbl_Status_FileTrans.Size = New System.Drawing.Size(4, 13)
        Me.lbl_Status_FileTrans.TabIndex = 8
        Me.lbl_Status_FileTrans.Text = "-"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Status :"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxControl1.Location = New System.Drawing.Point(0, 85)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(375, 143)
        Me.ListBoxControl1.TabIndex = 6
        '
        'btn_Send
        '
        Me.btn_Send.Location = New System.Drawing.Point(292, 26)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(75, 23)
        Me.btn_Send.TabIndex = 5
        Me.btn_Send.Text = "Sent"
        '
        'QueryControl4
        '
        Me.QueryControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.QueryControl4.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl4.Name = "QueryControl4"
        Me.QueryControl4.Size = New System.Drawing.Size(375, 21)
        Me.QueryControl4.TabIndex = 4
        '
        'QueryControl4.WorkingArea1
        '
        Me.QueryControl4.WorkingArea1.Controls.Add(Me.cmb_Users)
        Me.QueryControl4.WorkingArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryControl4.WorkingArea1.Location = New System.Drawing.Point(112, 0)
        Me.QueryControl4.WorkingArea1.Name = "WorkingArea1"
        Me.QueryControl4.WorkingArea1.Size = New System.Drawing.Size(263, 21)
        Me.QueryControl4.WorkingArea1.TabIndex = 0
        '
        'QueryControl4.WorkingArea2
        '
        Me.QueryControl4.WorkingArea2.Controls.Add(Me.Label4)
        Me.QueryControl4.WorkingArea2.Dock = System.Windows.Forms.DockStyle.Left
        Me.QueryControl4.WorkingArea2.Location = New System.Drawing.Point(0, 0)
        Me.QueryControl4.WorkingArea2.Name = "WorkingArea2"
        Me.QueryControl4.WorkingArea2.Size = New System.Drawing.Size(101, 21)
        Me.QueryControl4.WorkingArea2.TabIndex = 2
        '
        'cmb_Users
        '
        Me.cmb_Users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_Users.EditValue = "<Null>"
        Me.cmb_Users.Location = New System.Drawing.Point(0, 0)
        Me.cmb_Users.Name = "cmb_Users"
        Me.cmb_Users.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Users.Properties.DisplayMember = "ID"
        Me.cmb_Users.Properties.PopupWidth = 600
        Me.cmb_Users.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmb_Users.Properties.ValueMember = "ID"
        Me.cmb_Users.Size = New System.Drawing.Size(263, 20)
        Me.cmb_Users.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Users"
        '
        'TabNavigationPage4
        '
        Me.TabNavigationPage4.Caption = "Custom"
        Me.TabNavigationPage4.Name = "TabNavigationPage4"
        Me.TabNavigationPage4.Size = New System.Drawing.Size(375, 228)
        '
        'frm_AddFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 273)
        Me.Controls.Add(Me.TabPane1)
        Me.Name = "frm_AddFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Files"
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.QueryControl3.WorkingArea1.ResumeLayout(False)
        Me.QueryControl3.WorkingArea2.ResumeLayout(False)
        Me.QueryControl3.WorkingArea2.PerformLayout()
        Me.QueryControl3.ResumeLayout(False)
        Me.QueryControl3.PerformLayout()
        CType(Me.cmb_Works.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        Me.QueryControl2.WorkingArea1.ResumeLayout(False)
        Me.QueryControl2.WorkingArea2.ResumeLayout(False)
        Me.QueryControl2.WorkingArea2.PerformLayout()
        Me.QueryControl2.ResumeLayout(False)
        Me.QueryControl2.PerformLayout()
        CType(Me.cmb_Job.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QueryControl1.WorkingArea1.ResumeLayout(False)
        Me.QueryControl1.WorkingArea2.ResumeLayout(False)
        Me.QueryControl1.WorkingArea2.PerformLayout()
        Me.QueryControl1.ResumeLayout(False)
        Me.QueryControl1.PerformLayout()
        CType(Me.cmb_Clients.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.np_Sent.ResumeLayout(False)
        Me.np_Sent.PerformLayout()
        CType(Me.prog_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QueryControl4.WorkingArea1.ResumeLayout(False)
        Me.QueryControl4.WorkingArea2.ResumeLayout(False)
        Me.QueryControl4.WorkingArea2.PerformLayout()
        Me.QueryControl4.ResumeLayout(False)
        Me.QueryControl4.PerformLayout()
        CType(Me.cmb_Users.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents np_Sent As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents QueryControl3 As OMSFileBox.QueryControl
    Friend WithEvents cmb_Works As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents QueryControl2 As OMSFileBox.QueryControl
    Friend WithEvents cmb_Job As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QueryControl1 As OMSFileBox.QueryControl
    Friend WithEvents cmb_Clients As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QueryControl4 As OMSFileBox.QueryControl
    Friend WithEvents cmb_Users As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btn_Send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Status_FileTrans As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents prog_total As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents prog_current As System.Windows.Forms.ProgressBar
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
