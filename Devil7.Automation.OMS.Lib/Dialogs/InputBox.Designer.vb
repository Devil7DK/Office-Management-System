<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputBox))
        Me.lbl_Prompt = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Input = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Input.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Prompt
        '
        Me.lbl_Prompt.Location = New System.Drawing.Point(12, 12)
        Me.lbl_Prompt.Name = "lbl_Prompt"
        Me.lbl_Prompt.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Prompt.TabIndex = 0
        Me.lbl_Prompt.Text = "Enter Text :"
        '
        'txt_Input
        '
        Me.txt_Input.Location = New System.Drawing.Point(12, 31)
        Me.txt_Input.Name = "txt_Input"
        Me.txt_Input.Size = New System.Drawing.Size(454, 20)
        Me.txt_Input.TabIndex = 1
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.Location = New System.Drawing.Point(391, 57)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(75, 23)
        Me.btn_Done.TabIndex = 2
        Me.btn_Done.Text = "Done"
        '
        'InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 87)
        Me.Controls.Add(Me.btn_Done)
        Me.Controls.Add(Me.txt_Input)
        Me.Controls.Add(Me.lbl_Prompt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBox"
        Me.Text = "Enter Text"
        CType(Me.txt_Input.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Prompt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Input As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
End Class
