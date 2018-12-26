Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_AutoForwards
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AutoForwards))
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.cmb_Steps = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cmb_Users = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.cmb_Steps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_Users.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LabelControl1
            '
            Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
            Me.LabelControl1.TabIndex = 0
            Me.LabelControl1.Text = "Step :"
            '
            'LabelControl2
            '
            Me.LabelControl2.Location = New System.Drawing.Point(12, 42)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
            Me.LabelControl2.TabIndex = 1
            Me.LabelControl2.Text = "User :"
            '
            'cmb_Steps
            '
            Me.cmb_Steps.Location = New System.Drawing.Point(47, 12)
            Me.cmb_Steps.Name = "cmb_Steps"
            Me.cmb_Steps.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Steps.Size = New System.Drawing.Size(335, 20)
            Me.cmb_Steps.TabIndex = 2
            '
            'cmb_Users
            '
            Me.cmb_Users.Location = New System.Drawing.Point(47, 39)
            Me.cmb_Users.Name = "cmb_Users"
            Me.cmb_Users.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Users.Size = New System.Drawing.Size(335, 20)
            Me.cmb_Users.TabIndex = 3
            '
            'btn_OK
            '
            Me.btn_OK.Location = New System.Drawing.Point(307, 65)
            Me.btn_OK.Name = "btn_OK"
            Me.btn_OK.Size = New System.Drawing.Size(75, 23)
            Me.btn_OK.TabIndex = 4
            Me.btn_OK.Text = "Done"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Location = New System.Drawing.Point(226, 65)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
            Me.btn_Cancel.TabIndex = 5
            Me.btn_Cancel.Text = "Cancel"
            '
            'frm_AutoForwards
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(394, 95)
            Me.ControlBox = False
            Me.Controls.Add(Me.btn_Cancel)
            Me.Controls.Add(Me.btn_OK)
            Me.Controls.Add(Me.cmb_Users)
            Me.Controls.Add(Me.cmb_Steps)
            Me.Controls.Add(Me.LabelControl2)
            Me.Controls.Add(Me.LabelControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frm_AutoForwards"
            Me.Text = "Auto Forwards"
            CType(Me.cmb_Steps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_Users.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cmb_Steps As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents cmb_Users As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace