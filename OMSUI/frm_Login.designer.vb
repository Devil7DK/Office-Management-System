<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.UserPictureFrame = New Devil7.Automation.OMS.[Lib].PictureFrame()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Users = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_Login = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ServerSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordShowButton1 = New Devil7.Automation.OMS.[Lib].PasswordShowButton()
        Me.HuraAlertBox1 = New Devil7.Automation.OMS.[Lib].AlertBox()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.cmb_Users.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPictureFrame
        '
        Me.UserPictureFrame.BackColor = System.Drawing.Color.Transparent
        Me.UserPictureFrame.Image = Nothing
        Me.UserPictureFrame.Location = New System.Drawing.Point(121, 2)
        Me.UserPictureFrame.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserPictureFrame.Name = "UserPictureFrame"
        Me.UserPictureFrame.Size = New System.Drawing.Size(80, 80)
        Me.UserPictureFrame.TabIndex = 1
        Me.UserPictureFrame.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 81)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Username :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 107)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password :"
        '
        'cmb_Users
        '
        Me.cmb_Users.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Users.Location = New System.Drawing.Point(73, 78)
        Me.cmb_Users.Name = "cmb_Users"
        Me.cmb_Users.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Users.Properties.Sorted = True
        Me.cmb_Users.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Users.Size = New System.Drawing.Size(256, 20)
        Me.cmb_Users.TabIndex = 4
        '
        'btn_Login
        '
        Me.btn_Login.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Login.Location = New System.Drawing.Point(254, 135)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(75, 23)
        Me.btn_Login.TabIndex = 6
        Me.btn_Login.Text = "Login"
        '
        'btn_ServerSettings
        '
        Me.btn_ServerSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ServerSettings.Location = New System.Drawing.Point(12, 135)
        Me.btn_ServerSettings.Name = "btn_ServerSettings"
        Me.btn_ServerSettings.Size = New System.Drawing.Size(92, 23)
        Me.btn_ServerSettings.TabIndex = 7
        Me.btn_ServerSettings.Text = "Server Settings"
        '
        'AlertControl1
        '
        Me.AlertControl1.ShowPinButton = False
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Password.Location = New System.Drawing.Point(73, 104)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(213, 20)
        Me.txt_Password.TabIndex = 5
        '
        'PasswordShowButton1
        '
        Me.PasswordShowButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordShowButton1.BackColor = System.Drawing.Color.Transparent
        Me.PasswordShowButton1.Location = New System.Drawing.Point(292, 104)
        Me.PasswordShowButton1.Name = "PasswordShowButton1"
        Me.PasswordShowButton1.PasswordChar = ""
        Me.PasswordShowButton1.PasswordTextBox = Nothing
        Me.PasswordShowButton1.Size = New System.Drawing.Size(37, 21)
        Me.PasswordShowButton1.TabIndex = 9
        Me.PasswordShowButton1.TabStop = False
        Me.PasswordShowButton1.UseSystemPasswordChar = True
        '
        'HuraAlertBox1
        '
        Me.HuraAlertBox1.AlertStyle = Devil7.Automation.OMS.[Lib].AlertBox.Style.Warning
        Me.HuraAlertBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraAlertBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.HuraAlertBox1.Location = New System.Drawing.Point(110, 135)
        Me.HuraAlertBox1.Name = "HuraAlertBox1"
        Me.HuraAlertBox1.Size = New System.Drawing.Size(138, 23)
        Me.HuraAlertBox1.TabIndex = 10
        Me.HuraAlertBox1.Text = "Wrong Password"
        Me.HuraAlertBox1.Visible = False
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 170)
        Me.Controls.Add(Me.HuraAlertBox1)
        Me.Controls.Add(Me.PasswordShowButton1)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.btn_ServerSettings)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.cmb_Users)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.UserPictureFrame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.cmb_Users.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserPictureFrame As Devil7.Automation.OMS.Lib.PictureFrame
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Users As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_Login As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ServerSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordShowButton1 As Devil7.Automation.OMS.Lib.PasswordShowButton
    Friend WithEvents HuraAlertBox1 As Devil7.Automation.OMS.Lib.AlertBox
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
