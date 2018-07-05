<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_Value = New System.Windows.Forms.TextBox()
        Me.btn_Encrypt = New System.Windows.Forms.Button()
        Me.btn_Decrypt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Value
        '
        Me.txt_Value.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Value.Location = New System.Drawing.Point(12, 12)
        Me.txt_Value.Multiline = True
        Me.txt_Value.Name = "txt_Value"
        Me.txt_Value.Size = New System.Drawing.Size(361, 88)
        Me.txt_Value.TabIndex = 0
        '
        'btn_Encrypt
        '
        Me.btn_Encrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Encrypt.Location = New System.Drawing.Point(12, 106)
        Me.btn_Encrypt.Name = "btn_Encrypt"
        Me.btn_Encrypt.Size = New System.Drawing.Size(75, 23)
        Me.btn_Encrypt.TabIndex = 1
        Me.btn_Encrypt.Text = "Encrypt"
        Me.btn_Encrypt.UseVisualStyleBackColor = True
        '
        'btn_Decrypt
        '
        Me.btn_Decrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Decrypt.Location = New System.Drawing.Point(298, 106)
        Me.btn_Decrypt.Name = "btn_Decrypt"
        Me.btn_Decrypt.Size = New System.Drawing.Size(75, 23)
        Me.btn_Decrypt.TabIndex = 2
        Me.btn_Decrypt.Text = "Decrypt"
        Me.btn_Decrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 141)
        Me.Controls.Add(Me.btn_Decrypt)
        Me.Controls.Add(Me.btn_Encrypt)
        Me.Controls.Add(Me.txt_Value)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "TripleDES String Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Value As System.Windows.Forms.TextBox
    Friend WithEvents btn_Encrypt As System.Windows.Forms.Button
    Friend WithEvents btn_Decrypt As System.Windows.Forms.Button

End Class
