<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChangePassword))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_OldPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txt_NewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ConfirmNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.btn_ChangePassword = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_OldPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ConfirmNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(57, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Old Password :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(52, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "New Password :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Confirm New Password :"
        '
        'txt_OldPassword
        '
        Me.txt_OldPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_OldPassword.EnterMoveNextControl = True
        Me.txt_OldPassword.Location = New System.Drawing.Point(135, 12)
        Me.txt_OldPassword.Name = "txt_OldPassword"
        Me.txt_OldPassword.Properties.UseSystemPasswordChar = True
        Me.txt_OldPassword.Size = New System.Drawing.Size(265, 20)
        Me.txt_OldPassword.TabIndex = 0
        '
        'txt_NewPassword
        '
        Me.txt_NewPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_NewPassword.EnterMoveNextControl = True
        Me.txt_NewPassword.Location = New System.Drawing.Point(135, 38)
        Me.txt_NewPassword.Name = "txt_NewPassword"
        Me.txt_NewPassword.Properties.UseSystemPasswordChar = True
        Me.txt_NewPassword.Size = New System.Drawing.Size(265, 20)
        Me.txt_NewPassword.TabIndex = 1
        '
        'txt_ConfirmNewPassword
        '
        Me.txt_ConfirmNewPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ConfirmNewPassword.EnterMoveNextControl = True
        Me.txt_ConfirmNewPassword.Location = New System.Drawing.Point(135, 64)
        Me.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword"
        Me.txt_ConfirmNewPassword.Properties.UseSystemPasswordChar = True
        Me.txt_ConfirmNewPassword.Size = New System.Drawing.Size(265, 20)
        Me.txt_ConfirmNewPassword.TabIndex = 2
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ChangePassword.Location = New System.Drawing.Point(325, 90)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(75, 23)
        Me.btn_ChangePassword.TabIndex = 3
        Me.btn_ChangePassword.Text = "Change"
        '
        'frm_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 123)
        Me.Controls.Add(Me.btn_ChangePassword)
        Me.Controls.Add(Me.txt_ConfirmNewPassword)
        Me.Controls.Add(Me.txt_NewPassword)
        Me.Controls.Add(Me.txt_OldPassword)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        CType(Me.txt_OldPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ConfirmNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_OldPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_NewPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ConfirmNewPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_ChangePassword As DevExpress.XtraEditors.SimpleButton
End Class
