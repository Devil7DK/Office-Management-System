Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_User
        Inherits Devil7.Automation.OMS.Lib.XtraFormTemp

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_User))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
            Me.Photo = New System.Windows.Forms.PictureBox()
            Me.btn_Browse = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
            Me.cmb_UserType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
            Me.txt_ConfirmPassword = New DevExpress.XtraEditors.TextEdit()
            Me.txt_Address = New DevExpress.XtraEditors.TextEdit()
            Me.txt_Mobile = New DevExpress.XtraEditors.TextEdit()
            Me.txt_Email = New DevExpress.XtraEditors.TextEdit()
            Me.txt_Status = New DevExpress.XtraEditors.TextEdit()
            Me.lst_Permissions = New DevExpress.XtraEditors.ListBoxControl()
            Me.btn_Permission_Add = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Permission_Remove = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Permission_Edit = New DevExpress.XtraEditors.SimpleButton()
            Me.OFD_Image = New System.Windows.Forms.OpenFileDialog()
            Me.Panel_Permissions = New System.Windows.Forms.Panel()
            Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
            Me.Panel1.SuspendLayout()
            CType(Me.Photo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_UserType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_ConfirmPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Mobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lst_Permissions, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_Permissions.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btn_Cancel)
            Me.Panel1.Controls.Add(Me.btn_Done)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 393)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(440, 37)
            Me.Panel1.TabIndex = 0
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Location = New System.Drawing.Point(3, 3)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(98, 29)
            Me.btn_Cancel.TabIndex = 1
            Me.btn_Cancel.TabStop = False
            Me.btn_Cancel.Text = "Cancel"
            '
            'btn_Done
            '
            Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btn_Done.Location = New System.Drawing.Point(360, 3)
            Me.btn_Done.Name = "btn_Done"
            Me.btn_Done.Size = New System.Drawing.Size(75, 29)
            Me.btn_Done.TabIndex = 0
            Me.btn_Done.TabStop = False
            Me.btn_Done.Text = "Done"
            '
            'Photo
            '
            Me.Photo.BackColor = System.Drawing.Color.Black
            Me.Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Photo.Image = CType(resources.GetObject("Photo.Image"), System.Drawing.Image)
            Me.Photo.Location = New System.Drawing.Point(12, 12)
            Me.Photo.Name = "Photo"
            Me.Photo.Size = New System.Drawing.Size(100, 138)
            Me.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.Photo.TabIndex = 1
            Me.Photo.TabStop = False
            '
            'btn_Browse
            '
            Me.btn_Browse.Location = New System.Drawing.Point(118, 12)
            Me.btn_Browse.Name = "btn_Browse"
            Me.btn_Browse.Size = New System.Drawing.Size(75, 23)
            Me.btn_Browse.TabIndex = 2
            Me.btn_Browse.TabStop = False
            Me.btn_Browse.Text = "Browse"
            '
            'LabelControl1
            '
            Me.LabelControl1.Location = New System.Drawing.Point(152, 44)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
            Me.LabelControl1.TabIndex = 3
            Me.LabelControl1.Text = "User Name :"
            '
            'LabelControl2
            '
            Me.LabelControl2.Location = New System.Drawing.Point(155, 73)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
            Me.LabelControl2.TabIndex = 3
            Me.LabelControl2.Text = "User Type :"
            '
            'LabelControl3
            '
            Me.LabelControl3.Location = New System.Drawing.Point(158, 104)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
            Me.LabelControl3.TabIndex = 4
            Me.LabelControl3.Text = "Password :"
            '
            'LabelControl4
            '
            Me.LabelControl4.Location = New System.Drawing.Point(118, 133)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(93, 13)
            Me.LabelControl4.TabIndex = 4
            Me.LabelControl4.Text = "Confirm Password :"
            '
            'LabelControl5
            '
            Me.LabelControl5.Location = New System.Drawing.Point(35, 162)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
            Me.LabelControl5.TabIndex = 5
            Me.LabelControl5.Text = "Address :"
            '
            'LabelControl6
            '
            Me.LabelControl6.Location = New System.Drawing.Point(44, 191)
            Me.LabelControl6.Name = "LabelControl6"
            Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
            Me.LabelControl6.TabIndex = 5
            Me.LabelControl6.Text = "Mobile :"
            '
            'LabelControl7
            '
            Me.LabelControl7.Location = New System.Drawing.Point(47, 220)
            Me.LabelControl7.Name = "LabelControl7"
            Me.LabelControl7.Size = New System.Drawing.Size(34, 13)
            Me.LabelControl7.TabIndex = 5
            Me.LabelControl7.Text = "E Mail :"
            '
            'LabelControl8
            '
            Me.LabelControl8.Location = New System.Drawing.Point(19, 249)
            Me.LabelControl8.Name = "LabelControl8"
            Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
            Me.LabelControl8.TabIndex = 6
            Me.LabelControl8.Text = "Permissions :"
            '
            'LabelControl9
            '
            Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl9.Location = New System.Drawing.Point(43, 370)
            Me.LabelControl9.Name = "LabelControl9"
            Me.LabelControl9.Size = New System.Drawing.Size(38, 13)
            Me.LabelControl9.TabIndex = 6
            Me.LabelControl9.Text = "Status :"
            '
            'txt_Name
            '
            Me.txt_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Name.Location = New System.Drawing.Point(217, 41)
            Me.txt_Name.Name = "txt_Name"
            Me.txt_Name.Size = New System.Drawing.Size(215, 20)
            Me.txt_Name.TabIndex = 0
            '
            'cmb_UserType
            '
            Me.cmb_UserType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmb_UserType.Location = New System.Drawing.Point(217, 70)
            Me.cmb_UserType.Name = "cmb_UserType"
            Me.cmb_UserType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_UserType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_UserType.Size = New System.Drawing.Size(215, 20)
            Me.cmb_UserType.TabIndex = 1
            '
            'txt_Password
            '
            Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Password.Location = New System.Drawing.Point(217, 101)
            Me.txt_Password.Name = "txt_Password"
            Me.txt_Password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txt_Password.Properties.UseSystemPasswordChar = True
            Me.txt_Password.Size = New System.Drawing.Size(215, 20)
            Me.txt_Password.TabIndex = 2
            '
            'txt_ConfirmPassword
            '
            Me.txt_ConfirmPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_ConfirmPassword.Location = New System.Drawing.Point(217, 130)
            Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
            Me.txt_ConfirmPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txt_ConfirmPassword.Properties.UseSystemPasswordChar = True
            Me.txt_ConfirmPassword.Size = New System.Drawing.Size(215, 20)
            Me.txt_ConfirmPassword.TabIndex = 3
            '
            'txt_Address
            '
            Me.txt_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Address.Location = New System.Drawing.Point(87, 159)
            Me.txt_Address.Name = "txt_Address"
            Me.txt_Address.Size = New System.Drawing.Size(345, 20)
            Me.txt_Address.TabIndex = 4
            '
            'txt_Mobile
            '
            Me.txt_Mobile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Mobile.Location = New System.Drawing.Point(87, 188)
            Me.txt_Mobile.Name = "txt_Mobile"
            Me.txt_Mobile.Size = New System.Drawing.Size(345, 20)
            Me.txt_Mobile.TabIndex = 5
            '
            'txt_Email
            '
            Me.txt_Email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Email.Location = New System.Drawing.Point(87, 217)
            Me.txt_Email.Name = "txt_Email"
            Me.txt_Email.Size = New System.Drawing.Size(345, 20)
            Me.txt_Email.TabIndex = 6
            '
            'txt_Status
            '
            Me.txt_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Status.Location = New System.Drawing.Point(87, 367)
            Me.txt_Status.Name = "txt_Status"
            Me.txt_Status.Size = New System.Drawing.Size(345, 20)
            Me.txt_Status.TabIndex = 9
            '
            'lst_Permissions
            '
            Me.lst_Permissions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lst_Permissions.Cursor = System.Windows.Forms.Cursors.Default
            Me.lst_Permissions.Location = New System.Drawing.Point(87, 249)
            Me.lst_Permissions.Name = "lst_Permissions"
            Me.lst_Permissions.Size = New System.Drawing.Size(300, 108)
            Me.lst_Permissions.TabIndex = 7
            '
            'btn_Permission_Add
            '
            Me.btn_Permission_Add.ImageOptions.Image = CType(resources.GetObject("btn_Permission_Add.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Permission_Add.Location = New System.Drawing.Point(4, 3)
            Me.btn_Permission_Add.Name = "btn_Permission_Add"
            Me.btn_Permission_Add.Size = New System.Drawing.Size(32, 32)
            Me.btn_Permission_Add.TabIndex = 17
            '
            'btn_Permission_Remove
            '
            Me.btn_Permission_Remove.ImageOptions.Image = CType(resources.GetObject("btn_Permission_Remove.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Permission_Remove.Location = New System.Drawing.Point(4, 79)
            Me.btn_Permission_Remove.Name = "btn_Permission_Remove"
            Me.btn_Permission_Remove.Size = New System.Drawing.Size(32, 32)
            Me.btn_Permission_Remove.TabIndex = 17
            '
            'btn_Permission_Edit
            '
            Me.btn_Permission_Edit.ImageOptions.Image = CType(resources.GetObject("btn_Permission_Edit.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Permission_Edit.Location = New System.Drawing.Point(4, 41)
            Me.btn_Permission_Edit.Name = "btn_Permission_Edit"
            Me.btn_Permission_Edit.Size = New System.Drawing.Size(32, 32)
            Me.btn_Permission_Edit.TabIndex = 17
            '
            'OFD_Image
            '
            Me.OFD_Image.Filter = "All Supported Image Files|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            Me.OFD_Image.FilterIndex = 0
            Me.OFD_Image.Title = "Select Image"
            '
            'Panel_Permissions
            '
            Me.Panel_Permissions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel_Permissions.Controls.Add(Me.btn_Permission_Edit)
            Me.Panel_Permissions.Controls.Add(Me.btn_Permission_Remove)
            Me.Panel_Permissions.Controls.Add(Me.btn_Permission_Add)
            Me.Panel_Permissions.Location = New System.Drawing.Point(393, 243)
            Me.Panel_Permissions.Name = "Panel_Permissions"
            Me.Panel_Permissions.Size = New System.Drawing.Size(39, 117)
            Me.Panel_Permissions.TabIndex = 21
            '
            'frm_User
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(440, 430)
            Me.Controls.Add(Me.Panel_Permissions)
            Me.Controls.Add(Me.lst_Permissions)
            Me.Controls.Add(Me.txt_Status)
            Me.Controls.Add(Me.txt_Email)
            Me.Controls.Add(Me.txt_Mobile)
            Me.Controls.Add(Me.txt_Address)
            Me.Controls.Add(Me.txt_ConfirmPassword)
            Me.Controls.Add(Me.txt_Password)
            Me.Controls.Add(Me.cmb_UserType)
            Me.Controls.Add(Me.txt_Name)
            Me.Controls.Add(Me.LabelControl9)
            Me.Controls.Add(Me.LabelControl8)
            Me.Controls.Add(Me.LabelControl7)
            Me.Controls.Add(Me.LabelControl6)
            Me.Controls.Add(Me.LabelControl5)
            Me.Controls.Add(Me.LabelControl4)
            Me.Controls.Add(Me.LabelControl3)
            Me.Controls.Add(Me.LabelControl2)
            Me.Controls.Add(Me.LabelControl1)
            Me.Controls.Add(Me.btn_Browse)
            Me.Controls.Add(Me.Photo)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_User"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "User"
            Me.Panel1.ResumeLayout(False)
            CType(Me.Photo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_UserType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_ConfirmPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Mobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lst_Permissions, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_Permissions.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Photo As System.Windows.Forms.PictureBox
        Friend WithEvents btn_Browse As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents cmb_UserType As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_ConfirmPassword As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_Address As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_Mobile As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_Email As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_Status As DevExpress.XtraEditors.TextEdit
        Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents lst_Permissions As DevExpress.XtraEditors.ListBoxControl
        Friend WithEvents btn_Permission_Add As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Permission_Remove As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Permission_Edit As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents OFD_Image As System.Windows.Forms.OpenFileDialog
        Friend WithEvents Panel_Permissions As System.Windows.Forms.Panel
        Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    End Class
End Namespace