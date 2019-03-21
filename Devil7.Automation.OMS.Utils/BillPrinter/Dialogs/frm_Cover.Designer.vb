<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cover
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
        Me.lbl_Sender = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Receiver = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Sender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Receiver = New DevExpress.XtraEditors.LookUpEdit()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Sender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Receiver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Sender
        '
        Me.lbl_Sender.Location = New System.Drawing.Point(20, 15)
        Me.lbl_Sender.Name = "lbl_Sender"
        Me.lbl_Sender.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Sender.TabIndex = 0
        Me.lbl_Sender.Text = "Sender :"
        '
        'lbl_Receiver
        '
        Me.lbl_Receiver.Location = New System.Drawing.Point(12, 41)
        Me.lbl_Receiver.Name = "lbl_Receiver"
        Me.lbl_Receiver.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Receiver.TabIndex = 1
        Me.lbl_Receiver.Text = "Receiver :"
        '
        'txt_Sender
        '
        Me.txt_Sender.Location = New System.Drawing.Point(67, 12)
        Me.txt_Sender.Name = "txt_Sender"
        Me.txt_Sender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Sender.Size = New System.Drawing.Size(316, 20)
        Me.txt_Sender.TabIndex = 2
        '
        'txt_Receiver
        '
        Me.txt_Receiver.Location = New System.Drawing.Point(67, 38)
        Me.txt_Receiver.Name = "txt_Receiver"
        Me.txt_Receiver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Receiver.Properties.DisplayMember = "Name"
        Me.txt_Receiver.Properties.ValueMember = "ID"
        Me.txt_Receiver.Size = New System.Drawing.Size(316, 20)
        Me.txt_Receiver.TabIndex = 3
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(308, 64)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 4
        Me.btn_OK.Text = "OK"
        '
        'frm_Cover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 94)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_Receiver)
        Me.Controls.Add(Me.txt_Sender)
        Me.Controls.Add(Me.lbl_Receiver)
        Me.Controls.Add(Me.lbl_Sender)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Cover"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Sender & Receiver"
        CType(Me.txt_Sender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Receiver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Sender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Receiver As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Sender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Receiver As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
End Class
