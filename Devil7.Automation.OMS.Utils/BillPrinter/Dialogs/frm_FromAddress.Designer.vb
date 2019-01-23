<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FromAddress
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FromAddress))
        Me.lbl_DisplayName = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_EMail = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DisplayName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EMail = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.txt_DisplayName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_DisplayName
        '
        Me.lbl_DisplayName.Location = New System.Drawing.Point(12, 15)
        Me.lbl_DisplayName.Name = "lbl_DisplayName"
        Me.lbl_DisplayName.Size = New System.Drawing.Size(71, 13)
        Me.lbl_DisplayName.TabIndex = 0
        Me.lbl_DisplayName.Text = "Display Name :"
        '
        'lbl_EMail
        '
        Me.lbl_EMail.Location = New System.Drawing.Point(48, 41)
        Me.lbl_EMail.Name = "lbl_EMail"
        Me.lbl_EMail.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EMail.TabIndex = 1
        Me.lbl_EMail.Text = "E-Mail :"
        '
        'txt_DisplayName
        '
        Me.txt_DisplayName.EnterMoveNextControl = True
        Me.ErrorProvider.SetIconAlignment(Me.txt_DisplayName, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_DisplayName.Location = New System.Drawing.Point(89, 12)
        Me.txt_DisplayName.Name = "txt_DisplayName"
        Me.txt_DisplayName.Size = New System.Drawing.Size(216, 20)
        Me.txt_DisplayName.TabIndex = 2
        '
        'txt_EMail
        '
        Me.txt_EMail.EnterMoveNextControl = True
        Me.ErrorProvider.SetIconAlignment(Me.txt_EMail, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_EMail.Location = New System.Drawing.Point(89, 38)
        Me.txt_EMail.Name = "txt_EMail"
        Me.txt_EMail.Size = New System.Drawing.Size(216, 20)
        Me.txt_EMail.TabIndex = 3
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.Location = New System.Drawing.Point(248, 69)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(57, 25)
        Me.btn_Done.TabIndex = 5
        Me.btn_Done.Text = "Done"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frm_FromAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 106)
        Me.Controls.Add(Me.btn_Done)
        Me.Controls.Add(Me.txt_EMail)
        Me.Controls.Add(Me.txt_DisplayName)
        Me.Controls.Add(Me.lbl_EMail)
        Me.Controls.Add(Me.lbl_DisplayName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FromAddress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Address"
        CType(Me.txt_DisplayName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_DisplayName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_EMail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_DisplayName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
