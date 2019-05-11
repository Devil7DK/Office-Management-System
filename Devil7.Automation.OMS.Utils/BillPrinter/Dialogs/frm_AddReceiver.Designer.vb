<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AddReceiver
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AddReceiver))
        Me.txt_PAN = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TradeName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Mobile = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Phone = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EMail = New DevExpress.XtraEditors.TextEdit()
        Me.txt_AddressLine1 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_AddressLine2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_City = New DevExpress.XtraEditors.TextEdit()
        Me.txt_PINCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_GSTIN = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_PAN = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_TradeName = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Mobile = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Phone = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_EMail = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AddressLine1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AddressLine2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_City = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_PINCode = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_State = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_GSTIN = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_State = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txt_PAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TradeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Mobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Phone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AddressLine1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AddressLine2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_City.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PINCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GSTIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_State.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_PAN
        '
        Me.txt_PAN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PAN.EnterMoveNextControl = True
        Me.txt_PAN.Location = New System.Drawing.Point(95, 12)
        Me.txt_PAN.Name = "txt_PAN"
        Me.txt_PAN.Properties.Mask.BeepOnError = True
        Me.txt_PAN.Properties.Mask.EditMask = "[A-Z]{3}[ABCFGHLJPTK][A-Z][0-9]{4}[A-Z]"
        Me.txt_PAN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txt_PAN.Size = New System.Drawing.Size(303, 20)
        Me.txt_PAN.TabIndex = 1
        '
        'txt_Name
        '
        Me.txt_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Name.EnterMoveNextControl = True
        Me.txt_Name.Location = New System.Drawing.Point(95, 38)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(303, 20)
        Me.txt_Name.TabIndex = 2
        '
        'txt_TradeName
        '
        Me.txt_TradeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TradeName.EnterMoveNextControl = True
        Me.txt_TradeName.Location = New System.Drawing.Point(95, 64)
        Me.txt_TradeName.Name = "txt_TradeName"
        Me.txt_TradeName.Size = New System.Drawing.Size(303, 20)
        Me.txt_TradeName.TabIndex = 3
        '
        'txt_Mobile
        '
        Me.txt_Mobile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mobile.EnterMoveNextControl = True
        Me.txt_Mobile.Location = New System.Drawing.Point(95, 90)
        Me.txt_Mobile.Name = "txt_Mobile"
        Me.txt_Mobile.Size = New System.Drawing.Size(303, 20)
        Me.txt_Mobile.TabIndex = 4
        '
        'txt_Phone
        '
        Me.txt_Phone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Phone.EnterMoveNextControl = True
        Me.txt_Phone.Location = New System.Drawing.Point(95, 116)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(303, 20)
        Me.txt_Phone.TabIndex = 5
        '
        'txt_EMail
        '
        Me.txt_EMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EMail.EnterMoveNextControl = True
        Me.txt_EMail.Location = New System.Drawing.Point(95, 142)
        Me.txt_EMail.Name = "txt_EMail"
        Me.txt_EMail.Size = New System.Drawing.Size(303, 20)
        Me.txt_EMail.TabIndex = 6
        '
        'txt_AddressLine1
        '
        Me.txt_AddressLine1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_AddressLine1.EnterMoveNextControl = True
        Me.txt_AddressLine1.Location = New System.Drawing.Point(95, 168)
        Me.txt_AddressLine1.Name = "txt_AddressLine1"
        Me.txt_AddressLine1.Size = New System.Drawing.Size(303, 20)
        Me.txt_AddressLine1.TabIndex = 7
        '
        'txt_AddressLine2
        '
        Me.txt_AddressLine2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_AddressLine2.EnterMoveNextControl = True
        Me.txt_AddressLine2.Location = New System.Drawing.Point(95, 194)
        Me.txt_AddressLine2.Name = "txt_AddressLine2"
        Me.txt_AddressLine2.Size = New System.Drawing.Size(303, 20)
        Me.txt_AddressLine2.TabIndex = 8
        '
        'txt_City
        '
        Me.txt_City.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_City.EnterMoveNextControl = True
        Me.txt_City.Location = New System.Drawing.Point(95, 220)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(303, 20)
        Me.txt_City.TabIndex = 9
        '
        'txt_PINCode
        '
        Me.txt_PINCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PINCode.EnterMoveNextControl = True
        Me.txt_PINCode.Location = New System.Drawing.Point(95, 246)
        Me.txt_PINCode.Name = "txt_PINCode"
        Me.txt_PINCode.Size = New System.Drawing.Size(303, 20)
        Me.txt_PINCode.TabIndex = 10
        '
        'txt_GSTIN
        '
        Me.txt_GSTIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_GSTIN.EnterMoveNextControl = True
        Me.txt_GSTIN.Location = New System.Drawing.Point(95, 298)
        Me.txt_GSTIN.Name = "txt_GSTIN"
        Me.txt_GSTIN.Properties.Mask.EditMask = "[0-9]{2}[A-Z]{3}[ABCFGHLJPTK][A-Z][0-9]{4}[A-Z][0-9]{1}[Z]{1}[A-Z0-9]{1}"
        Me.txt_GSTIN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txt_GSTIN.Size = New System.Drawing.Size(303, 20)
        Me.txt_GSTIN.TabIndex = 17
        '
        'lbl_PAN
        '
        Me.lbl_PAN.Location = New System.Drawing.Point(62, 15)
        Me.lbl_PAN.Name = "lbl_PAN"
        Me.lbl_PAN.Size = New System.Drawing.Size(27, 13)
        Me.lbl_PAN.TabIndex = 18
        Me.lbl_PAN.Text = "PAN :"
        '
        'lbl_Name
        '
        Me.lbl_Name.Location = New System.Drawing.Point(55, 41)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Name.TabIndex = 19
        Me.lbl_Name.Text = "Name :"
        '
        'lbl_TradeName
        '
        Me.lbl_TradeName.Location = New System.Drawing.Point(27, 67)
        Me.lbl_TradeName.Name = "lbl_TradeName"
        Me.lbl_TradeName.Size = New System.Drawing.Size(62, 13)
        Me.lbl_TradeName.TabIndex = 20
        Me.lbl_TradeName.Text = "Trade Name :"
        '
        'lbl_Mobile
        '
        Me.lbl_Mobile.Location = New System.Drawing.Point(52, 93)
        Me.lbl_Mobile.Name = "lbl_Mobile"
        Me.lbl_Mobile.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Mobile.TabIndex = 21
        Me.lbl_Mobile.Text = "Mobile :"
        '
        'lbl_Phone
        '
        Me.lbl_Phone.Location = New System.Drawing.Point(52, 119)
        Me.lbl_Phone.Name = "lbl_Phone"
        Me.lbl_Phone.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Phone.TabIndex = 22
        Me.lbl_Phone.Text = "Phone :"
        '
        'lbl_EMail
        '
        Me.lbl_EMail.Location = New System.Drawing.Point(54, 145)
        Me.lbl_EMail.Name = "lbl_EMail"
        Me.lbl_EMail.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EMail.TabIndex = 23
        Me.lbl_EMail.Text = "E-Mail :"
        '
        'lbl_AddressLine1
        '
        Me.lbl_AddressLine1.Location = New System.Drawing.Point(12, 171)
        Me.lbl_AddressLine1.Name = "lbl_AddressLine1"
        Me.lbl_AddressLine1.Size = New System.Drawing.Size(77, 13)
        Me.lbl_AddressLine1.TabIndex = 24
        Me.lbl_AddressLine1.Text = "Address Line 1 :"
        '
        'lbl_AddressLine2
        '
        Me.lbl_AddressLine2.Location = New System.Drawing.Point(12, 197)
        Me.lbl_AddressLine2.Name = "lbl_AddressLine2"
        Me.lbl_AddressLine2.Size = New System.Drawing.Size(77, 13)
        Me.lbl_AddressLine2.TabIndex = 25
        Me.lbl_AddressLine2.Text = "Address Line 2 :"
        '
        'lbl_City
        '
        Me.lbl_City.Location = New System.Drawing.Point(63, 223)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(26, 13)
        Me.lbl_City.TabIndex = 26
        Me.lbl_City.Text = "City :"
        '
        'lbl_PINCode
        '
        Me.lbl_PINCode.Location = New System.Drawing.Point(37, 249)
        Me.lbl_PINCode.Name = "lbl_PINCode"
        Me.lbl_PINCode.Size = New System.Drawing.Size(52, 13)
        Me.lbl_PINCode.TabIndex = 27
        Me.lbl_PINCode.Text = "PIN Code :"
        '
        'lbl_State
        '
        Me.lbl_State.Location = New System.Drawing.Point(56, 275)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(33, 13)
        Me.lbl_State.TabIndex = 28
        Me.lbl_State.Text = "State :"
        '
        'lbl_GSTIN
        '
        Me.lbl_GSTIN.Location = New System.Drawing.Point(52, 301)
        Me.lbl_GSTIN.Name = "lbl_GSTIN"
        Me.lbl_GSTIN.Size = New System.Drawing.Size(37, 13)
        Me.lbl_GSTIN.TabIndex = 29
        Me.lbl_GSTIN.Text = "GSTIN :"
        '
        'btn_Add
        '
        Me.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Add.Location = New System.Drawing.Point(323, 330)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add.TabIndex = 18
        Me.btn_Add.Text = "Add"
        '
        'txt_State
        '
        Me.txt_State.EnterMoveNextControl = True
        Me.txt_State.Location = New System.Drawing.Point(95, 272)
        Me.txt_State.Name = "txt_State"
        Me.txt_State.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_State.Properties.Items.AddRange(New Object() {"Jammu & Kashmir", "Himachal Pradesh", "Punjab", "Chandigarh", "Uttarakhand", "Haryana", "Delhi", "Rajasthan", "Uttar Pradesh", "Bihar", "Sikkim", "Arunachal Pradesh", "Nagaland", "Manipur", "Mizoram", "Tripura", "Meghalaya", "Assam", "West Bengal", "Jharkhand", "Orissa", "Chhattisgarh", "Madhya Pradesh", "Gujarat", "Daman & Diu", "Dadra & Nagar Haveli", "Maharashtra", "Andhra Pradesh", "Karnataka", "Goa", "Lakshadweep", "Kerala", "Tamil Nadu", "Puducherry", "Andaman & Nicobar Islands", "Telengana", "Andrapradesh(New)"})
        Me.txt_State.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_State.Size = New System.Drawing.Size(303, 20)
        Me.txt_State.TabIndex = 11
        '
        'frm_AddReceiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 365)
        Me.Controls.Add(Me.txt_State)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.lbl_GSTIN)
        Me.Controls.Add(Me.lbl_State)
        Me.Controls.Add(Me.lbl_PINCode)
        Me.Controls.Add(Me.lbl_City)
        Me.Controls.Add(Me.lbl_AddressLine2)
        Me.Controls.Add(Me.lbl_AddressLine1)
        Me.Controls.Add(Me.lbl_EMail)
        Me.Controls.Add(Me.lbl_Phone)
        Me.Controls.Add(Me.lbl_Mobile)
        Me.Controls.Add(Me.lbl_TradeName)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.lbl_PAN)
        Me.Controls.Add(Me.txt_GSTIN)
        Me.Controls.Add(Me.txt_PINCode)
        Me.Controls.Add(Me.txt_City)
        Me.Controls.Add(Me.txt_AddressLine2)
        Me.Controls.Add(Me.txt_AddressLine1)
        Me.Controls.Add(Me.txt_EMail)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Mobile)
        Me.Controls.Add(Me.txt_TradeName)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.txt_PAN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AddReceiver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Receiver"
        CType(Me.txt_PAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TradeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Mobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Phone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AddressLine1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AddressLine2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_City.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PINCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GSTIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_State.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_PAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TradeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Mobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Phone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_AddressLine1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_AddressLine2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_City As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_PINCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_GSTIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_PAN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TradeName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Mobile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Phone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_EMail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AddressLine1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AddressLine2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_City As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_PINCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_State As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_GSTIN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_State As DevExpress.XtraEditors.ComboBoxEdit
End Class
