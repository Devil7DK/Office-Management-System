﻿Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_ClientAddEdit
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientAddEdit))
            Me.OFD_Image = New System.Windows.Forms.OpenFileDialog()
            Me.Panel_Main = New System.Windows.Forms.Panel()
            Me.Panel_Details = New System.Windows.Forms.Panel()
            Me.Panel_Controls_Layout = New System.Windows.Forms.TableLayoutPanel()
            Me.gc_Jobs = New DevExpress.XtraGrid.GridControl()
            Me.gv_Jobs = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.txt_Pincode = New DevExpress.XtraEditors.TextEdit()
            Me.Label9 = New DevExpress.XtraEditors.LabelControl()
            Me.Label8 = New DevExpress.XtraEditors.LabelControl()
            Me.Label7 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_FatherName = New DevExpress.XtraEditors.TextEdit()
            Me.Label4 = New DevExpress.XtraEditors.LabelControl()
            Me.Label1 = New DevExpress.XtraEditors.LabelControl()
            Me.Label2 = New DevExpress.XtraEditors.LabelControl()
            Me.Label3 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_PAN = New DevExpress.XtraEditors.TextEdit()
            Me.txt_ClientName = New DevExpress.XtraEditors.TextEdit()
            Me.cmb_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Label11 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_AddressLine1 = New DevExpress.XtraEditors.TextEdit()
            Me.Label10 = New DevExpress.XtraEditors.LabelControl()
            Me.Label12 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_AddressLine2 = New DevExpress.XtraEditors.TextEdit()
            Me.Label14 = New DevExpress.XtraEditors.LabelControl()
            Me.Label13 = New DevExpress.XtraEditors.LabelControl()
            Me.Label15 = New DevExpress.XtraEditors.LabelControl()
            Me.Label16 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_City = New DevExpress.XtraEditors.TextEdit()
            Me.Label17 = New DevExpress.XtraEditors.LabelControl()
            Me.Label18 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Mobile = New DevExpress.XtraEditors.TextEdit()
            Me.Label19 = New DevExpress.XtraEditors.LabelControl()
            Me.Label20 = New DevExpress.XtraEditors.LabelControl()
            Me.Label21 = New DevExpress.XtraEditors.LabelControl()
            Me.Label22 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Email = New DevExpress.XtraEditors.TextEdit()
            Me.Label23 = New DevExpress.XtraEditors.LabelControl()
            Me.Label24 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Aadhar = New DevExpress.XtraEditors.TextEdit()
            Me.Label25 = New DevExpress.XtraEditors.LabelControl()
            Me.Label26 = New DevExpress.XtraEditors.LabelControl()
            Me.Label29 = New DevExpress.XtraEditors.LabelControl()
            Me.Label30 = New DevExpress.XtraEditors.LabelControl()
            Me.cmb_TypeOfEngagement = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Label31 = New DevExpress.XtraEditors.LabelControl()
            Me.Label32 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Description = New DevExpress.XtraEditors.TextEdit()
            Me.Label33 = New DevExpress.XtraEditors.LabelControl()
            Me.Label34 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Status = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Label35 = New DevExpress.XtraEditors.LabelControl()
            Me.Label36 = New DevExpress.XtraEditors.LabelControl()
            Me.Label38 = New DevExpress.XtraEditors.LabelControl()
            Me.Label39 = New DevExpress.XtraEditors.LabelControl()
            Me.Label6 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_DOB = New DevExpress.XtraEditors.DateEdit()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_GSTNo = New DevExpress.XtraEditors.TextEdit()
            Me.txt_FileNo = New DevExpress.XtraEditors.TextEdit()
            Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_State = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.txt_StateCode = New DevExpress.XtraEditors.TextEdit()
            Me.txt_Phone = New DevExpress.XtraEditors.TextEdit()
            Me.gc_Partners = New DevExpress.XtraGrid.GridControl()
            Me.gv_Partners = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.txt_ResponsiblePerson = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Panel_Photo = New System.Windows.Forms.Panel()
            Me.Panel_Photo_Control = New System.Windows.Forms.Panel()
            Me.pic_Photo = New System.Windows.Forms.PictureBox()
            Me.btn_BrowseImage = New DevExpress.XtraEditors.SimpleButton()
            Me.Panel_Control = New System.Windows.Forms.Panel()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_TradeName = New DevExpress.XtraEditors.TextEdit()
            Me.Panel_Main.SuspendLayout()
            Me.Panel_Details.SuspendLayout()
            Me.Panel_Controls_Layout.SuspendLayout()
            CType(Me.gc_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Pincode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_FatherName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_PAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_ClientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_AddressLine1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_AddressLine2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_City.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Mobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Aadhar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_TypeOfEngagement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_DOB.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_DOB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_GSTNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_FileNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_State.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_StateCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Phone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gc_Partners, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_Partners, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_ResponsiblePerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_Photo.SuspendLayout()
            Me.Panel_Photo_Control.SuspendLayout()
            CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_Control.SuspendLayout()
            CType(Me.txt_TradeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'OFD_Image
            '
            Me.OFD_Image.Filter = "All Supported Image Files|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            Me.OFD_Image.FilterIndex = 0
            Me.OFD_Image.Title = "Select Image"
            '
            'Panel_Main
            '
            Me.Panel_Main.Controls.Add(Me.Panel_Details)
            Me.Panel_Main.Controls.Add(Me.Panel_Control)
            Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
            Me.Panel_Main.Name = "Panel_Main"
            Me.Panel_Main.Size = New System.Drawing.Size(658, 445)
            Me.Panel_Main.TabIndex = 0
            '
            'Panel_Details
            '
            Me.Panel_Details.AutoScroll = True
            Me.Panel_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel_Details.Controls.Add(Me.Panel_Controls_Layout)
            Me.Panel_Details.Controls.Add(Me.Panel_Photo)
            Me.Panel_Details.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_Details.Location = New System.Drawing.Point(0, 0)
            Me.Panel_Details.Name = "Panel_Details"
            Me.Panel_Details.Size = New System.Drawing.Size(658, 412)
            Me.Panel_Details.TabIndex = 1
            '
            'Panel_Controls_Layout
            '
            Me.Panel_Controls_Layout.ColumnCount = 3
            Me.Panel_Controls_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.Panel_Controls_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.Panel_Controls_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.Panel_Controls_Layout.Controls.Add(Me.gc_Jobs, 2, 23)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Pincode, 2, 9)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label9, 0, 5)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label8, 0, 4)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label7, 1, 4)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_FatherName, 2, 2)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label4, 0, 1)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label1, 1, 0)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label2, 1, 1)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label3, 0, 0)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_PAN, 2, 0)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_ClientName, 2, 1)
            Me.Panel_Controls_Layout.Controls.Add(Me.cmb_Type, 2, 4)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label11, 0, 6)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_AddressLine1, 2, 6)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label10, 1, 6)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label12, 1, 5)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_AddressLine2, 2, 7)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label14, 1, 7)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label13, 0, 7)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label15, 0, 8)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label16, 1, 8)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_City, 2, 8)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label17, 0, 9)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label18, 1, 9)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Mobile, 2, 12)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label19, 1, 12)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label20, 0, 12)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label21, 0, 14)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label22, 1, 14)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Email, 2, 14)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label23, 0, 15)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label24, 1, 15)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Aadhar, 2, 15)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label25, 0, 16)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label26, 1, 16)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label29, 0, 19)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label30, 1, 19)
            Me.Panel_Controls_Layout.Controls.Add(Me.cmb_TypeOfEngagement, 2, 19)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label31, 0, 20)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label32, 1, 20)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Description, 2, 20)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label33, 0, 21)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label34, 1, 21)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Status, 2, 21)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label35, 0, 22)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label36, 0, 23)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label38, 1, 22)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label39, 1, 23)
            Me.Panel_Controls_Layout.Controls.Add(Me.Label6, 0, 2)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl1, 1, 2)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_DOB, 2, 5)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl2, 0, 17)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl3, 0, 18)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl4, 1, 17)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl5, 1, 18)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_GSTNo, 2, 17)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_FileNo, 2, 18)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl6, 0, 10)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl7, 0, 11)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl8, 0, 13)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl9, 1, 10)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl10, 1, 11)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl11, 1, 13)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_State, 2, 10)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_StateCode, 2, 11)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_Phone, 2, 13)
            Me.Panel_Controls_Layout.Controls.Add(Me.gc_Partners, 2, 22)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_ResponsiblePerson, 2, 16)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl12, 0, 3)
            Me.Panel_Controls_Layout.Controls.Add(Me.LabelControl13, 1, 3)
            Me.Panel_Controls_Layout.Controls.Add(Me.txt_TradeName, 2, 3)
            Me.Panel_Controls_Layout.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel_Controls_Layout.Location = New System.Drawing.Point(0, 175)
            Me.Panel_Controls_Layout.Name = "Panel_Controls_Layout"
            Me.Panel_Controls_Layout.RowCount = 24
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.Panel_Controls_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.Panel_Controls_Layout.Size = New System.Drawing.Size(639, 813)
            Me.Panel_Controls_Layout.TabIndex = 0
            '
            'gc_Jobs
            '
            Me.gc_Jobs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_Jobs.Location = New System.Drawing.Point(203, 695)
            Me.gc_Jobs.MainView = Me.gv_Jobs
            Me.gc_Jobs.Name = "gc_Jobs"
            Me.gc_Jobs.Size = New System.Drawing.Size(433, 115)
            Me.gc_Jobs.TabIndex = 81
            Me.gc_Jobs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Jobs})
            '
            'gv_Jobs
            '
            Me.gv_Jobs.GridControl = Me.gc_Jobs
            Me.gv_Jobs.Name = "gv_Jobs"
            Me.gv_Jobs.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gv_Jobs.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gv_Jobs.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.gv_Jobs.OptionsView.ShowGroupPanel = False
            '
            'txt_Pincode
            '
            Me.txt_Pincode.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Pincode.EnterMoveNextControl = True
            Me.txt_Pincode.Location = New System.Drawing.Point(203, 237)
            Me.txt_Pincode.Name = "txt_Pincode"
            Me.txt_Pincode.Size = New System.Drawing.Size(433, 20)
            Me.txt_Pincode.TabIndex = 8
            '
            'Label9
            '
            Me.Label9.Appearance.Options.UseTextOptions = True
            Me.Label9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label9.Location = New System.Drawing.Point(3, 133)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(184, 20)
            Me.Label9.TabIndex = 21
            Me.Label9.Text = "Date Of Birth/Incorporation/Formation"
            '
            'Label8
            '
            Me.Label8.Appearance.Options.UseTextOptions = True
            Me.Label8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label8.Location = New System.Drawing.Point(3, 107)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(184, 20)
            Me.Label8.TabIndex = 14
            Me.Label8.Text = "Type"
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label7.Location = New System.Drawing.Point(193, 107)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(4, 20)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = ":"
            '
            'txt_FatherName
            '
            Me.txt_FatherName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_FatherName.EnterMoveNextControl = True
            Me.txt_FatherName.Location = New System.Drawing.Point(203, 55)
            Me.txt_FatherName.Name = "txt_FatherName"
            Me.txt_FatherName.Size = New System.Drawing.Size(433, 20)
            Me.txt_FatherName.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.Appearance.Options.UseTextOptions = True
            Me.Label4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label4.Location = New System.Drawing.Point(3, 29)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(184, 20)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Client Name"
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Location = New System.Drawing.Point(193, 3)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(4, 20)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = ":"
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(193, 29)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(4, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = ":"
            '
            'Label3
            '
            Me.Label3.Appearance.Options.UseTextOptions = True
            Me.Label3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Location = New System.Drawing.Point(3, 3)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(184, 20)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "PAN"
            '
            'txt_PAN
            '
            Me.txt_PAN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_PAN.EnterMoveNextControl = True
            Me.txt_PAN.Location = New System.Drawing.Point(203, 3)
            Me.txt_PAN.Name = "txt_PAN"
            Me.txt_PAN.Properties.Mask.BeepOnError = True
            Me.txt_PAN.Properties.Mask.EditMask = "[A-Z]{3}[ABCFGHLJPTK][A-Z][0-9]{4}[A-Z]"
            Me.txt_PAN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.txt_PAN.Size = New System.Drawing.Size(433, 20)
            Me.txt_PAN.TabIndex = 0
            '
            'txt_ClientName
            '
            Me.txt_ClientName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_ClientName.EnterMoveNextControl = True
            Me.txt_ClientName.Location = New System.Drawing.Point(203, 29)
            Me.txt_ClientName.Name = "txt_ClientName"
            Me.txt_ClientName.Size = New System.Drawing.Size(433, 20)
            Me.txt_ClientName.TabIndex = 1
            '
            'cmb_Type
            '
            Me.cmb_Type.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_Type.EnterMoveNextControl = True
            Me.cmb_Type.Location = New System.Drawing.Point(203, 107)
            Me.cmb_Type.Name = "cmb_Type"
            Me.cmb_Type.Properties.Items.AddRange(New Object() {"Association of Persons (AOP)", "Body of Individuals (BOI)", "Company", "Firm", "Government", "HUF (Hindu Undivided Family)", "Local Authority", "Artificial Juridical Person", "Individual", "AOP (Trust)", "Krish (Trust Krish)"})
            Me.cmb_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Type.Size = New System.Drawing.Size(433, 20)
            Me.cmb_Type.TabIndex = 3
            '
            'Label11
            '
            Me.Label11.Appearance.Options.UseTextOptions = True
            Me.Label11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label11.Location = New System.Drawing.Point(3, 159)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(184, 20)
            Me.Label11.TabIndex = 22
            Me.Label11.Text = "Address Line 1"
            '
            'txt_AddressLine1
            '
            Me.txt_AddressLine1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_AddressLine1.EnterMoveNextControl = True
            Me.txt_AddressLine1.Location = New System.Drawing.Point(203, 159)
            Me.txt_AddressLine1.Name = "txt_AddressLine1"
            Me.txt_AddressLine1.Size = New System.Drawing.Size(433, 20)
            Me.txt_AddressLine1.TabIndex = 5
            '
            'Label10
            '
            Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label10.Location = New System.Drawing.Point(193, 159)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(4, 20)
            Me.Label10.TabIndex = 20
            Me.Label10.Text = ":"
            '
            'Label12
            '
            Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label12.Location = New System.Drawing.Point(193, 133)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(4, 20)
            Me.Label12.TabIndex = 20
            Me.Label12.Text = ":"
            '
            'txt_AddressLine2
            '
            Me.txt_AddressLine2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_AddressLine2.EnterMoveNextControl = True
            Me.txt_AddressLine2.Location = New System.Drawing.Point(203, 185)
            Me.txt_AddressLine2.Name = "txt_AddressLine2"
            Me.txt_AddressLine2.Size = New System.Drawing.Size(433, 20)
            Me.txt_AddressLine2.TabIndex = 6
            '
            'Label14
            '
            Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label14.Location = New System.Drawing.Point(193, 185)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(4, 20)
            Me.Label14.TabIndex = 24
            Me.Label14.Text = ":"
            '
            'Label13
            '
            Me.Label13.Appearance.Options.UseTextOptions = True
            Me.Label13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label13.Location = New System.Drawing.Point(3, 185)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(184, 20)
            Me.Label13.TabIndex = 25
            Me.Label13.Text = "Address Line 2"
            '
            'Label15
            '
            Me.Label15.Appearance.Options.UseTextOptions = True
            Me.Label15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label15.Location = New System.Drawing.Point(3, 211)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(184, 20)
            Me.Label15.TabIndex = 27
            Me.Label15.Text = "City"
            '
            'Label16
            '
            Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label16.Location = New System.Drawing.Point(193, 211)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(4, 20)
            Me.Label16.TabIndex = 28
            Me.Label16.Text = ":"
            '
            'txt_City
            '
            Me.txt_City.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_City.EnterMoveNextControl = True
            Me.txt_City.Location = New System.Drawing.Point(203, 211)
            Me.txt_City.Name = "txt_City"
            Me.txt_City.Size = New System.Drawing.Size(433, 20)
            Me.txt_City.TabIndex = 7
            '
            'Label17
            '
            Me.Label17.Appearance.Options.UseTextOptions = True
            Me.Label17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label17.Location = New System.Drawing.Point(3, 237)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(184, 20)
            Me.Label17.TabIndex = 30
            Me.Label17.Text = "PIN Code"
            '
            'Label18
            '
            Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label18.Location = New System.Drawing.Point(193, 237)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(4, 20)
            Me.Label18.TabIndex = 31
            Me.Label18.Text = ":"
            '
            'txt_Mobile
            '
            Me.txt_Mobile.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Mobile.EnterMoveNextControl = True
            Me.txt_Mobile.Location = New System.Drawing.Point(203, 315)
            Me.txt_Mobile.Name = "txt_Mobile"
            Me.txt_Mobile.Size = New System.Drawing.Size(433, 20)
            Me.txt_Mobile.TabIndex = 10
            '
            'Label19
            '
            Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label19.Location = New System.Drawing.Point(193, 315)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(4, 20)
            Me.Label19.TabIndex = 34
            Me.Label19.Text = ":"
            '
            'Label20
            '
            Me.Label20.Appearance.Options.UseTextOptions = True
            Me.Label20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label20.Location = New System.Drawing.Point(3, 315)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(184, 20)
            Me.Label20.TabIndex = 35
            Me.Label20.Text = "Mobile Number(s)"
            '
            'Label21
            '
            Me.Label21.Appearance.Options.UseTextOptions = True
            Me.Label21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label21.Location = New System.Drawing.Point(3, 367)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(184, 20)
            Me.Label21.TabIndex = 36
            Me.Label21.Text = "Email"
            '
            'Label22
            '
            Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label22.Location = New System.Drawing.Point(193, 367)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(4, 20)
            Me.Label22.TabIndex = 37
            Me.Label22.Text = ":"
            '
            'txt_Email
            '
            Me.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Email.EnterMoveNextControl = True
            Me.txt_Email.Location = New System.Drawing.Point(203, 367)
            Me.txt_Email.Name = "txt_Email"
            Me.txt_Email.Size = New System.Drawing.Size(433, 20)
            Me.txt_Email.TabIndex = 12
            '
            'Label23
            '
            Me.Label23.Appearance.Options.UseTextOptions = True
            Me.Label23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label23.Location = New System.Drawing.Point(3, 393)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(184, 20)
            Me.Label23.TabIndex = 39
            Me.Label23.Text = "Aadhar Number"
            '
            'Label24
            '
            Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label24.Location = New System.Drawing.Point(193, 393)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(4, 20)
            Me.Label24.TabIndex = 40
            Me.Label24.Text = ":"
            '
            'txt_Aadhar
            '
            Me.txt_Aadhar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Aadhar.EnterMoveNextControl = True
            Me.txt_Aadhar.Location = New System.Drawing.Point(203, 393)
            Me.txt_Aadhar.Name = "txt_Aadhar"
            Me.txt_Aadhar.Properties.Mask.BeepOnError = True
            Me.txt_Aadhar.Properties.Mask.EditMask = "000000000000"
            Me.txt_Aadhar.Size = New System.Drawing.Size(433, 20)
            Me.txt_Aadhar.TabIndex = 13
            '
            'Label25
            '
            Me.Label25.Appearance.Options.UseTextOptions = True
            Me.Label25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label25.Location = New System.Drawing.Point(3, 419)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(184, 20)
            Me.Label25.TabIndex = 42
            Me.Label25.Text = "Responsible Person"
            '
            'Label26
            '
            Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label26.Location = New System.Drawing.Point(193, 419)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(4, 20)
            Me.Label26.TabIndex = 43
            Me.Label26.Text = ":"
            '
            'Label29
            '
            Me.Label29.Appearance.Options.UseTextOptions = True
            Me.Label29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label29.Location = New System.Drawing.Point(3, 497)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(184, 20)
            Me.Label29.TabIndex = 48
            Me.Label29.Text = "Type Of Engagement"
            '
            'Label30
            '
            Me.Label30.Location = New System.Drawing.Point(193, 497)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(4, 13)
            Me.Label30.TabIndex = 49
            Me.Label30.Text = ":"
            '
            'cmb_TypeOfEngagement
            '
            Me.cmb_TypeOfEngagement.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_TypeOfEngagement.EnterMoveNextControl = True
            Me.cmb_TypeOfEngagement.Location = New System.Drawing.Point(203, 497)
            Me.cmb_TypeOfEngagement.Name = "cmb_TypeOfEngagement"
            Me.cmb_TypeOfEngagement.Properties.Items.AddRange(New Object() {"N/A"})
            Me.cmb_TypeOfEngagement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_TypeOfEngagement.Size = New System.Drawing.Size(433, 20)
            Me.cmb_TypeOfEngagement.TabIndex = 18
            '
            'Label31
            '
            Me.Label31.Appearance.Options.UseTextOptions = True
            Me.Label31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label31.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label31.Location = New System.Drawing.Point(3, 523)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(184, 20)
            Me.Label31.TabIndex = 51
            Me.Label31.Text = "Description"
            '
            'Label32
            '
            Me.Label32.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label32.Location = New System.Drawing.Point(193, 523)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(4, 20)
            Me.Label32.TabIndex = 52
            Me.Label32.Text = ":"
            '
            'txt_Description
            '
            Me.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Description.EnterMoveNextControl = True
            Me.txt_Description.Location = New System.Drawing.Point(203, 523)
            Me.txt_Description.Name = "txt_Description"
            Me.txt_Description.Size = New System.Drawing.Size(433, 20)
            Me.txt_Description.TabIndex = 19
            '
            'Label33
            '
            Me.Label33.Appearance.Options.UseTextOptions = True
            Me.Label33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label33.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label33.Location = New System.Drawing.Point(3, 549)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(184, 20)
            Me.Label33.TabIndex = 54
            Me.Label33.Text = "Status"
            '
            'Label34
            '
            Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label34.Location = New System.Drawing.Point(193, 549)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(4, 20)
            Me.Label34.TabIndex = 55
            Me.Label34.Text = ":"
            '
            'txt_Status
            '
            Me.txt_Status.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Status.EnterMoveNextControl = True
            Me.txt_Status.Location = New System.Drawing.Point(203, 549)
            Me.txt_Status.Name = "txt_Status"
            Me.txt_Status.Size = New System.Drawing.Size(433, 20)
            Me.txt_Status.TabIndex = 20
            '
            'Label35
            '
            Me.Label35.Appearance.Options.UseTextOptions = True
            Me.Label35.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label35.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.Label35.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label35.Location = New System.Drawing.Point(3, 575)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(184, 114)
            Me.Label35.TabIndex = 57
            Me.Label35.Text = "Partners/Directors"
            '
            'Label36
            '
            Me.Label36.Appearance.Options.UseTextOptions = True
            Me.Label36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.Label36.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label36.Location = New System.Drawing.Point(3, 695)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(184, 115)
            Me.Label36.TabIndex = 58
            Me.Label36.Text = "Jobs"
            '
            'Label38
            '
            Me.Label38.Appearance.Options.UseTextOptions = True
            Me.Label38.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.Label38.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label38.Location = New System.Drawing.Point(193, 575)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(4, 114)
            Me.Label38.TabIndex = 60
            Me.Label38.Text = ":"
            '
            'Label39
            '
            Me.Label39.Appearance.Options.UseTextOptions = True
            Me.Label39.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.Label39.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label39.Location = New System.Drawing.Point(193, 695)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(4, 115)
            Me.Label39.TabIndex = 61
            Me.Label39.Text = ":"
            '
            'Label6
            '
            Me.Label6.Appearance.Options.UseTextOptions = True
            Me.Label6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label6.Location = New System.Drawing.Point(3, 55)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(184, 20)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Father/Husband Name"
            '
            'LabelControl1
            '
            Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl1.Location = New System.Drawing.Point(193, 55)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(4, 20)
            Me.LabelControl1.TabIndex = 1
            Me.LabelControl1.Text = ":"
            '
            'txt_DOB
            '
            Me.txt_DOB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_DOB.EditValue = Nothing
            Me.txt_DOB.EnterMoveNextControl = True
            Me.txt_DOB.Location = New System.Drawing.Point(203, 133)
            Me.txt_DOB.Name = "txt_DOB"
            Me.txt_DOB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_DOB.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_DOB.Size = New System.Drawing.Size(433, 20)
            Me.txt_DOB.TabIndex = 4
            '
            'LabelControl2
            '
            Me.LabelControl2.Appearance.Options.UseTextOptions = True
            Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl2.Location = New System.Drawing.Point(3, 445)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(184, 20)
            Me.LabelControl2.TabIndex = 66
            Me.LabelControl2.Text = "GST Registration Number"
            '
            'LabelControl3
            '
            Me.LabelControl3.Appearance.Options.UseTextOptions = True
            Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl3.Location = New System.Drawing.Point(3, 471)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(184, 20)
            Me.LabelControl3.TabIndex = 67
            Me.LabelControl3.Text = "Associated File Number"
            '
            'LabelControl4
            '
            Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl4.Location = New System.Drawing.Point(193, 445)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(4, 20)
            Me.LabelControl4.TabIndex = 68
            Me.LabelControl4.Text = ":"
            '
            'LabelControl5
            '
            Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl5.Location = New System.Drawing.Point(193, 471)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Size = New System.Drawing.Size(4, 20)
            Me.LabelControl5.TabIndex = 69
            Me.LabelControl5.Text = ":"
            '
            'txt_GSTNo
            '
            Me.txt_GSTNo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_GSTNo.Location = New System.Drawing.Point(203, 445)
            Me.txt_GSTNo.Name = "txt_GSTNo"
            Me.txt_GSTNo.Properties.Mask.EditMask = "[0-9]{2}[A-Z]{3}[ABCFGHLJPTK][A-Z][0-9]{4}[A-Z][0-9]{1}[Z]{1}[A-Z0-9]{1}"
            Me.txt_GSTNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.txt_GSTNo.Size = New System.Drawing.Size(433, 20)
            Me.txt_GSTNo.TabIndex = 16
            '
            'txt_FileNo
            '
            Me.txt_FileNo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_FileNo.Location = New System.Drawing.Point(203, 471)
            Me.txt_FileNo.Name = "txt_FileNo"
            Me.txt_FileNo.Size = New System.Drawing.Size(433, 20)
            Me.txt_FileNo.TabIndex = 17
            '
            'LabelControl6
            '
            Me.LabelControl6.Appearance.Options.UseTextOptions = True
            Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl6.Location = New System.Drawing.Point(3, 263)
            Me.LabelControl6.Name = "LabelControl6"
            Me.LabelControl6.Size = New System.Drawing.Size(184, 20)
            Me.LabelControl6.TabIndex = 72
            Me.LabelControl6.Text = "State"
            '
            'LabelControl7
            '
            Me.LabelControl7.Appearance.Options.UseTextOptions = True
            Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl7.Location = New System.Drawing.Point(3, 289)
            Me.LabelControl7.Name = "LabelControl7"
            Me.LabelControl7.Size = New System.Drawing.Size(184, 20)
            Me.LabelControl7.TabIndex = 73
            Me.LabelControl7.Text = "State Code"
            '
            'LabelControl8
            '
            Me.LabelControl8.Appearance.Options.UseTextOptions = True
            Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl8.Location = New System.Drawing.Point(3, 341)
            Me.LabelControl8.Name = "LabelControl8"
            Me.LabelControl8.Size = New System.Drawing.Size(184, 20)
            Me.LabelControl8.TabIndex = 74
            Me.LabelControl8.Text = "Phone"
            '
            'LabelControl9
            '
            Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl9.Location = New System.Drawing.Point(193, 263)
            Me.LabelControl9.Name = "LabelControl9"
            Me.LabelControl9.Size = New System.Drawing.Size(4, 20)
            Me.LabelControl9.TabIndex = 75
            Me.LabelControl9.Text = ":"
            '
            'LabelControl10
            '
            Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl10.Location = New System.Drawing.Point(193, 289)
            Me.LabelControl10.Name = "LabelControl10"
            Me.LabelControl10.Size = New System.Drawing.Size(4, 20)
            Me.LabelControl10.TabIndex = 76
            Me.LabelControl10.Text = ":"
            '
            'LabelControl11
            '
            Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LabelControl11.Location = New System.Drawing.Point(193, 341)
            Me.LabelControl11.Name = "LabelControl11"
            Me.LabelControl11.Size = New System.Drawing.Size(4, 20)
            Me.LabelControl11.TabIndex = 77
            Me.LabelControl11.Text = ":"
            '
            'txt_State
            '
            Me.txt_State.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_State.Location = New System.Drawing.Point(203, 263)
            Me.txt_State.Name = "txt_State"
            Me.txt_State.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_State.Properties.Items.AddRange(New Object() {"Jammu & Kashmir", "Himachal Pradesh", "Punjab", "Chandigarh", "Uttarakhand", "Haryana", "Delhi", "Rajasthan", "Uttar Pradesh", "Bihar", "Sikkim", "Arunachal Pradesh", "Nagaland", "Manipur", "Mizoram", "Tripura", "Meghalaya", "Assam", "West Bengal", "Jharkhand", "Orissa", "Chhattisgarh", "Madhya Pradesh", "Gujarat", "Daman & Diu", "Dadra & Nagar Haveli", "Maharashtra", "Andhra Pradesh", "Karnataka", "Goa", "Lakshadweep", "Kerala", "Tamil Nadu", "Puducherry", "Andaman & Nicobar Islands", "Telengana", "Andrapradesh(New)"})
            Me.txt_State.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.txt_State.Size = New System.Drawing.Size(433, 20)
            Me.txt_State.TabIndex = 9
            '
            'txt_StateCode
            '
            Me.txt_StateCode.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_StateCode.Location = New System.Drawing.Point(203, 289)
            Me.txt_StateCode.Name = "txt_StateCode"
            Me.txt_StateCode.Properties.ReadOnly = True
            Me.txt_StateCode.Size = New System.Drawing.Size(433, 20)
            Me.txt_StateCode.TabIndex = 79
            '
            'txt_Phone
            '
            Me.txt_Phone.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Phone.Location = New System.Drawing.Point(203, 341)
            Me.txt_Phone.Name = "txt_Phone"
            Me.txt_Phone.Size = New System.Drawing.Size(433, 20)
            Me.txt_Phone.TabIndex = 11
            '
            'gc_Partners
            '
            Me.gc_Partners.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_Partners.Location = New System.Drawing.Point(203, 575)
            Me.gc_Partners.MainView = Me.gv_Partners
            Me.gc_Partners.Name = "gc_Partners"
            Me.gc_Partners.Size = New System.Drawing.Size(433, 114)
            Me.gc_Partners.TabIndex = 80
            Me.gc_Partners.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Partners})
            '
            'gv_Partners
            '
            Me.gv_Partners.GridControl = Me.gc_Partners
            Me.gv_Partners.Name = "gv_Partners"
            Me.gv_Partners.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gv_Partners.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gv_Partners.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.gv_Partners.OptionsView.ShowGroupPanel = False
            '
            'txt_ResponsiblePerson
            '
            Me.txt_ResponsiblePerson.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_ResponsiblePerson.Location = New System.Drawing.Point(203, 419)
            Me.txt_ResponsiblePerson.Name = "txt_ResponsiblePerson"
            Me.txt_ResponsiblePerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_ResponsiblePerson.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.txt_ResponsiblePerson.Size = New System.Drawing.Size(433, 20)
            Me.txt_ResponsiblePerson.TabIndex = 82
            '
            'Panel_Photo
            '
            Me.Panel_Photo.Controls.Add(Me.Panel_Photo_Control)
            Me.Panel_Photo.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel_Photo.Location = New System.Drawing.Point(0, 0)
            Me.Panel_Photo.Name = "Panel_Photo"
            Me.Panel_Photo.Size = New System.Drawing.Size(639, 175)
            Me.Panel_Photo.TabIndex = 1
            '
            'Panel_Photo_Control
            '
            Me.Panel_Photo_Control.Controls.Add(Me.pic_Photo)
            Me.Panel_Photo_Control.Controls.Add(Me.btn_BrowseImage)
            Me.Panel_Photo_Control.Location = New System.Drawing.Point(252, 3)
            Me.Panel_Photo_Control.Name = "Panel_Photo_Control"
            Me.Panel_Photo_Control.Size = New System.Drawing.Size(134, 169)
            Me.Panel_Photo_Control.TabIndex = 1
            '
            'pic_Photo
            '
            Me.pic_Photo.BackColor = System.Drawing.Color.Black
            Me.pic_Photo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pic_Photo.Image = CType(resources.GetObject("pic_Photo.Image"), System.Drawing.Image)
            Me.pic_Photo.Location = New System.Drawing.Point(0, 0)
            Me.pic_Photo.Name = "pic_Photo"
            Me.pic_Photo.Size = New System.Drawing.Size(134, 142)
            Me.pic_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pic_Photo.TabIndex = 0
            Me.pic_Photo.TabStop = False
            '
            'btn_BrowseImage
            '
            Me.btn_BrowseImage.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_BrowseImage.Appearance.Options.UseFont = True
            Me.btn_BrowseImage.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_BrowseImage.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btn_BrowseImage.Location = New System.Drawing.Point(0, 142)
            Me.btn_BrowseImage.Name = "btn_BrowseImage"
            Me.btn_BrowseImage.Size = New System.Drawing.Size(134, 27)
            Me.btn_BrowseImage.TabIndex = 1
            Me.btn_BrowseImage.TabStop = False
            Me.btn_BrowseImage.Text = "Browse"
            '
            'Panel_Control
            '
            Me.Panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel_Control.Controls.Add(Me.btn_Cancel)
            Me.Panel_Control.Controls.Add(Me.btn_Done)
            Me.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel_Control.Location = New System.Drawing.Point(0, 412)
            Me.Panel_Control.Name = "Panel_Control"
            Me.Panel_Control.Size = New System.Drawing.Size(658, 33)
            Me.Panel_Control.TabIndex = 0
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btn_Cancel.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_Cancel.Appearance.Options.UseFont = True
            Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_Cancel.Location = New System.Drawing.Point(508, 4)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
            Me.btn_Cancel.TabIndex = 30
            Me.btn_Cancel.TabStop = False
            Me.btn_Cancel.Text = "Cancel"
            '
            'btn_Done
            '
            Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btn_Done.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_Done.Appearance.Options.UseFont = True
            Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_Done.Location = New System.Drawing.Point(579, 4)
            Me.btn_Done.Name = "btn_Done"
            Me.btn_Done.Size = New System.Drawing.Size(65, 24)
            Me.btn_Done.TabIndex = 29
            Me.btn_Done.TabStop = False
            Me.btn_Done.Text = "Done"
            '
            'LabelControl12
            '
            Me.LabelControl12.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl12.Location = New System.Drawing.Point(84, 81)
            Me.LabelControl12.Name = "LabelControl12"
            Me.LabelControl12.Size = New System.Drawing.Size(103, 13)
            Me.LabelControl12.TabIndex = 83
            Me.LabelControl12.Text = "Trade/Business Name"
            '
            'LabelControl13
            '
            Me.LabelControl13.Location = New System.Drawing.Point(193, 81)
            Me.LabelControl13.Name = "LabelControl13"
            Me.LabelControl13.Size = New System.Drawing.Size(4, 13)
            Me.LabelControl13.TabIndex = 84
            Me.LabelControl13.Text = ":"
            '
            'txt_TradeName
            '
            Me.txt_TradeName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_TradeName.EnterMoveNextControl = True
            Me.txt_TradeName.Location = New System.Drawing.Point(203, 81)
            Me.txt_TradeName.Name = "txt_TradeName"
            Me.txt_TradeName.Size = New System.Drawing.Size(433, 20)
            Me.txt_TradeName.TabIndex = 2
            '
            'frm_ClientAddEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(658, 445)
            Me.Controls.Add(Me.Panel_Main)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimizeBox = False
            Me.Name = "frm_ClientAddEdit"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Client"
            Me.Panel_Main.ResumeLayout(False)
            Me.Panel_Details.ResumeLayout(False)
            Me.Panel_Controls_Layout.ResumeLayout(False)
            Me.Panel_Controls_Layout.PerformLayout()
            CType(Me.gc_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Pincode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_FatherName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_PAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_ClientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_AddressLine1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_AddressLine2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_City.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Mobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Aadhar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_TypeOfEngagement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_DOB.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_DOB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_GSTNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_FileNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_State.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_StateCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Phone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gc_Partners, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_Partners, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_ResponsiblePerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_Photo.ResumeLayout(False)
            Me.Panel_Photo_Control.ResumeLayout(False)
            CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_Control.ResumeLayout(False)
            CType(Me.txt_TradeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel_Main As System.Windows.Forms.Panel
        Friend WithEvents Panel_Details As System.Windows.Forms.Panel
        Friend WithEvents Panel_Controls_Layout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel_Photo As System.Windows.Forms.Panel
        Friend WithEvents pic_Photo As System.Windows.Forms.PictureBox
        Friend WithEvents Panel_Control As System.Windows.Forms.Panel
        Friend WithEvents Panel_Photo_Control As System.Windows.Forms.Panel
        Friend WithEvents btn_BrowseImage As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_FatherName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_PAN As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_ClientName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents cmb_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_AddressLine1 As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_AddressLine2 As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Pincode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_City As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label17 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label18 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Mobile As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label19 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label20 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label21 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label22 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Email As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label23 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label24 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Aadhar As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label29 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label30 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cmb_TypeOfEngagement As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Label31 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label32 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Description As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label33 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label34 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Status As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Label35 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label36 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label38 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label39 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents OFD_Image As System.Windows.Forms.OpenFileDialog
        Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_DOB As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_GSTNo As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_FileNo As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_State As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents txt_StateCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txt_Phone As DevExpress.XtraEditors.TextEdit
        Friend WithEvents gc_Jobs As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_Jobs As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents gc_Partners As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_Partners As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents Label25 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Label26 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_ResponsiblePerson As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_TradeName As DevExpress.XtraEditors.TextEdit
    End Class
End Namespace