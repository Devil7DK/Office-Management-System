<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ServerSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ServerSettings))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ServerName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_DatabaseName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_UserName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_ServerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DatabaseName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Server Name :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Database Name :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(39, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Username :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(41, 99)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Password :"
        '
        'txt_ServerName
        '
        Me.txt_ServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ServerName.EnterMoveNextControl = True
        Me.txt_ServerName.Location = New System.Drawing.Point(100, 12)
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.Size = New System.Drawing.Size(262, 20)
        Me.txt_ServerName.TabIndex = 0
        '
        'txt_DatabaseName
        '
        Me.txt_DatabaseName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DatabaseName.EnterMoveNextControl = True
        Me.txt_DatabaseName.Location = New System.Drawing.Point(100, 38)
        Me.txt_DatabaseName.Name = "txt_DatabaseName"
        Me.txt_DatabaseName.Size = New System.Drawing.Size(262, 20)
        Me.txt_DatabaseName.TabIndex = 2
        '
        'txt_UserName
        '
        Me.txt_UserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_UserName.EnterMoveNextControl = True
        Me.txt_UserName.Location = New System.Drawing.Point(100, 67)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(262, 20)
        Me.txt_UserName.TabIndex = 3
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Password.EnterMoveNextControl = True
        Me.txt_Password.Location = New System.Drawing.Point(100, 96)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(262, 20)
        Me.txt_Password.TabIndex = 4
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(287, 127)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 29)
        Me.btn_Save.TabIndex = 5
        Me.btn_Save.Text = "Save"
        '
        'frm_ServerSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 168)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_UserName)
        Me.Controls.Add(Me.txt_DatabaseName)
        Me.Controls.Add(Me.txt_ServerName)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ServerSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Server Settings"
        CType(Me.txt_ServerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DatabaseName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ServerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DatabaseName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_UserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
End Class
