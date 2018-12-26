<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.lbl_Username = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_Password = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Username = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_ServerSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Login = New DevExpress.XtraEditors.SimpleButton()
        Me.pic_SidePanel = New System.Windows.Forms.PictureBox()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.LoginWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_SidePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Username
        '
        Me.lbl_Username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Username.Location = New System.Drawing.Point(169, 12)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username"
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Password.Location = New System.Drawing.Point(169, 82)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(272, 20)
        Me.txt_Password.TabIndex = 1
        '
        'lbl_Password
        '
        Me.lbl_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Password.Location = New System.Drawing.Point(169, 63)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Password.TabIndex = 0
        Me.lbl_Password.Text = "Password"
        '
        'txt_Username
        '
        Me.txt_Username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Username.EnterMoveNextControl = True
        Me.txt_Username.Location = New System.Drawing.Point(169, 31)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Username.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Username.Size = New System.Drawing.Size(272, 20)
        Me.txt_Username.TabIndex = 0
        '
        'btn_ServerSettings
        '
        Me.btn_ServerSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ServerSettings.ImageOptions.Image = Global.Devil7.Automation.OMS.Res.My.Resources.Resources.server_settings
        Me.btn_ServerSettings.Location = New System.Drawing.Point(169, 116)
        Me.btn_ServerSettings.Name = "btn_ServerSettings"
        Me.btn_ServerSettings.Size = New System.Drawing.Size(38, 38)
        Me.btn_ServerSettings.TabIndex = 0
        Me.btn_ServerSettings.TabStop = False
        '
        'btn_Login
        '
        Me.btn_Login.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Login.ImageOptions.Image = Global.Devil7.Automation.OMS.Res.My.Resources.Resources.login
        Me.btn_Login.Location = New System.Drawing.Point(357, 116)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(84, 38)
        Me.btn_Login.TabIndex = 2
        Me.btn_Login.Text = "Login"
        '
        'pic_SidePanel
        '
        Me.pic_SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_SidePanel.Image = Global.Devil7.Automation.OMS.Res.My.Resources.Resources.secure_screen
        Me.pic_SidePanel.Location = New System.Drawing.Point(0, 0)
        Me.pic_SidePanel.Name = "pic_SidePanel"
        Me.pic_SidePanel.Size = New System.Drawing.Size(153, 166)
        Me.pic_SidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_SidePanel.TabIndex = 0
        Me.pic_SidePanel.TabStop = False
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.BarAnimationElementThickness = 2
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Description = "Loggin In..."
        Me.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel.Location = New System.Drawing.Point(153, 0)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(300, 166)
        Me.ProgressPanel.TabIndex = 3
        Me.ProgressPanel.Visible = False
        Me.ProgressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring
        '
        'LoginWorker
        '
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 166)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.btn_ServerSettings)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.pic_SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_SidePanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_SidePanel As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_Password As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Username As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_Login As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ServerSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents LoginWorker As System.ComponentModel.BackgroundWorker
End Class
