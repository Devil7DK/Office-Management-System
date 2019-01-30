<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ExInputBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ExInputBox))
        Me.lbl_Prompt = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Value = New DevExpress.XtraEditors.TextEdit()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Prompt
        '
        Me.lbl_Prompt.Location = New System.Drawing.Point(12, 11)
        Me.lbl_Prompt.Name = "lbl_Prompt"
        Me.lbl_Prompt.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Prompt.TabIndex = 0
        Me.lbl_Prompt.Text = "Enter Text"
        '
        'txt_Value
        '
        Me.txt_Value.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Value.Location = New System.Drawing.Point(12, 30)
        Me.txt_Value.Name = "txt_Value"
        Me.txt_Value.Size = New System.Drawing.Size(346, 20)
        Me.txt_Value.TabIndex = 1
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.Location = New System.Drawing.Point(283, 56)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "OK"
        '
        'frm_ExInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 86)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_Value)
        Me.Controls.Add(Me.lbl_Prompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ExInputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Text"
        CType(Me.txt_Value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Prompt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Value As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
End Class
