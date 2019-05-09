<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
    Inherits [Lib].XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_FeesReminderMessage = New DevExpress.XtraEditors.LabelControl()
        Me.txt_FeesReminderMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.lbl_FeesReminderMessage_Note = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_PrintLegalName = New DevExpress.XtraEditors.LabelControl()
        Me.sw_PrintLegalName = New DevExpress.XtraEditors.ToggleSwitch()
        CType(Me.txt_FeesReminderMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_PrintLegalName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(231, 164)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        '
        'lbl_FeesReminderMessage
        '
        Me.lbl_FeesReminderMessage.Appearance.Options.UseTextOptions = True
        Me.lbl_FeesReminderMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_FeesReminderMessage.Location = New System.Drawing.Point(28, 14)
        Me.lbl_FeesReminderMessage.Name = "lbl_FeesReminderMessage"
        Me.lbl_FeesReminderMessage.Size = New System.Drawing.Size(71, 26)
        Me.lbl_FeesReminderMessage.TabIndex = 1
        Me.lbl_FeesReminderMessage.Text = "Fees Reminder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Message :"
        '
        'txt_FeesReminderMessage
        '
        Me.txt_FeesReminderMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FeesReminderMessage.Location = New System.Drawing.Point(113, 12)
        Me.txt_FeesReminderMessage.Name = "txt_FeesReminderMessage"
        Me.txt_FeesReminderMessage.Size = New System.Drawing.Size(193, 69)
        Me.txt_FeesReminderMessage.TabIndex = 2
        '
        'lbl_FeesReminderMessage_Note
        '
        Me.lbl_FeesReminderMessage_Note.Location = New System.Drawing.Point(113, 87)
        Me.lbl_FeesReminderMessage_Note.Name = "lbl_FeesReminderMessage_Note"
        Me.lbl_FeesReminderMessage_Note.Size = New System.Drawing.Size(122, 26)
        Me.lbl_FeesReminderMessage_Note.TabIndex = 3
        Me.lbl_FeesReminderMessage_Note.Text = "Note:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         [Total] - Total Value"
        '
        'lbl_PrintLegalName
        '
        Me.lbl_PrintLegalName.Location = New System.Drawing.Point(12, 133)
        Me.lbl_PrintLegalName.Name = "lbl_PrintLegalName"
        Me.lbl_PrintLegalName.Size = New System.Drawing.Size(87, 13)
        Me.lbl_PrintLegalName.TabIndex = 4
        Me.lbl_PrintLegalName.Text = "Print Legal Name :"
        '
        'sw_PrintLegalName
        '
        Me.sw_PrintLegalName.Location = New System.Drawing.Point(113, 128)
        Me.sw_PrintLegalName.Name = "sw_PrintLegalName"
        Me.sw_PrintLegalName.Properties.OffText = "Off"
        Me.sw_PrintLegalName.Properties.OnText = "On"
        Me.sw_PrintLegalName.Size = New System.Drawing.Size(95, 24)
        Me.sw_PrintLegalName.TabIndex = 5
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 199)
        Me.Controls.Add(Me.sw_PrintLegalName)
        Me.Controls.Add(Me.lbl_PrintLegalName)
        Me.Controls.Add(Me.lbl_FeesReminderMessage_Note)
        Me.Controls.Add(Me.txt_FeesReminderMessage)
        Me.Controls.Add(Me.lbl_FeesReminderMessage)
        Me.Controls.Add(Me.btn_Save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.txt_FeesReminderMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_PrintLegalName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_FeesReminderMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_FeesReminderMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbl_FeesReminderMessage_Note As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_PrintLegalName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sw_PrintLegalName As DevExpress.XtraEditors.ToggleSwitch
End Class
