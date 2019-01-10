Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_JobUser
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_JobUser))
            Me.Panel_Main = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Panel_Control = New System.Windows.Forms.Panel()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.cmb_Job = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cmb_User = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Panel_Main.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.Panel_Control.SuspendLayout()
            CType(Me.cmb_Job.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_User.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel_Main
            '
            Me.Panel_Main.Controls.Add(Me.TableLayoutPanel1)
            Me.Panel_Main.Controls.Add(Me.Panel_Control)
            Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
            Me.Panel_Main.Name = "Panel_Main"
            Me.Panel_Main.Size = New System.Drawing.Size(344, 85)
            Me.Panel_Main.TabIndex = 0
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.cmb_Job, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.cmb_User, 2, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(344, 52)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'Panel_Control
            '
            Me.Panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel_Control.Controls.Add(Me.btn_Cancel)
            Me.Panel_Control.Controls.Add(Me.btn_Done)
            Me.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel_Control.Location = New System.Drawing.Point(0, 53)
            Me.Panel_Control.Name = "Panel_Control"
            Me.Panel_Control.Size = New System.Drawing.Size(344, 32)
            Me.Panel_Control.TabIndex = 0
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_Cancel.Appearance.Options.UseFont = True
            Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_Cancel.Location = New System.Drawing.Point(197, 3)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
            Me.btn_Cancel.TabIndex = 3
            Me.btn_Cancel.TabStop = False
            Me.btn_Cancel.Text = "Cancel"
            '
            'btn_Done
            '
            Me.btn_Done.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_Done.Appearance.Options.UseFont = True
            Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_Done.Location = New System.Drawing.Point(268, 3)
            Me.btn_Done.Name = "btn_Done"
            Me.btn_Done.Size = New System.Drawing.Size(65, 24)
            Me.btn_Done.TabIndex = 2
            Me.btn_Done.TabStop = False
            Me.btn_Done.Text = "Done"
            '
            'LabelControl1
            '
            Me.LabelControl1.Appearance.Options.UseTextOptions = True
            Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl1.Location = New System.Drawing.Point(3, 29)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(66, 20)
            Me.LabelControl1.TabIndex = 6
            Me.LabelControl1.Text = "User"
            '
            'LabelControl2
            '
            Me.LabelControl2.Appearance.Options.UseTextOptions = True
            Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl2.Location = New System.Drawing.Point(75, 29)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(2, 20)
            Me.LabelControl2.TabIndex = 7
            Me.LabelControl2.Text = ":"
            '
            'LabelControl3
            '
            Me.LabelControl3.Appearance.Options.UseTextOptions = True
            Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl3.Location = New System.Drawing.Point(3, 3)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(66, 20)
            Me.LabelControl3.TabIndex = 8
            Me.LabelControl3.Text = "Job"
            '
            'LabelControl4
            '
            Me.LabelControl4.Appearance.Options.UseTextOptions = True
            Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl4.Location = New System.Drawing.Point(75, 3)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(2, 20)
            Me.LabelControl4.TabIndex = 9
            Me.LabelControl4.Text = ":"
            '
            'cmb_Job
            '
            Me.cmb_Job.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_Job.Location = New System.Drawing.Point(83, 3)
            Me.cmb_Job.Name = "cmb_Job"
            Me.cmb_Job.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Job.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Job.Size = New System.Drawing.Size(258, 20)
            Me.cmb_Job.TabIndex = 0
            '
            'cmb_User
            '
            Me.cmb_User.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_User.Location = New System.Drawing.Point(83, 29)
            Me.cmb_User.Name = "cmb_User"
            Me.cmb_User.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_User.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_User.Size = New System.Drawing.Size(258, 20)
            Me.cmb_User.TabIndex = 1
            '
            'frm_Job_Lite
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(344, 85)
            Me.Controls.Add(Me.Panel_Main)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_Job_Lite"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Job"
            Me.Panel_Main.ResumeLayout(False)
            Me.Panel_Main.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.Panel_Control.ResumeLayout(False)
            CType(Me.cmb_Job.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_User.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel_Main As System.Windows.Forms.Panel
        Friend WithEvents Panel_Control As System.Windows.Forms.Panel
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cmb_Job As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents cmb_User As DevExpress.XtraEditors.ComboBoxEdit
    End Class
End Namespace