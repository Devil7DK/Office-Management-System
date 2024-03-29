﻿Imports System.Windows.Forms

Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_ClientJobsReport
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
            Me.MainWizard = New DevExpress.XtraWizard.WizardControl()
            Me.page_Clients = New DevExpress.XtraWizard.WizardPage()
            Me.btn_UnselectClient = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_SelectClient = New DevExpress.XtraEditors.SimpleButton()
            Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.gc_Clients_Selected = New DevExpress.XtraGrid.GridControl()
            Me.gv_Clients_Selected = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.gc_Clients_All = New DevExpress.XtraGrid.GridControl()
            Me.gv_Clients_All = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txt_To = New DevExpress.XtraEditors.DateEdit()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_From = New DevExpress.XtraEditors.DateEdit()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.page_Finish = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.cb_OpenExportedFile = New DevExpress.XtraEditors.CheckEdit()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.page_Generating = New DevExpress.XtraWizard.WizardPage()
            Me.ProgressPanel_GeneratingReport = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.page_Result = New DevExpress.XtraWizard.WizardPage()
            Me.gc_Result = New DevExpress.XtraGrid.GridControl()
            Me.page_Export = New DevExpress.XtraWizard.WizardPage()
            Me.txt_ExportPath = New DevExpress.XtraEditors.ButtonEdit()
            Me.rgrp_ExportType = New DevExpress.XtraEditors.RadioGroup()
            Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.Loader_Details = New System.ComponentModel.BackgroundWorker()
            Me.Loader_GenerateReport = New System.ComponentModel.BackgroundWorker()
            Me.SaveFileDialog_Export = New System.Windows.Forms.SaveFileDialog()
            Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPAN = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFatherName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMobile = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddressLine1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddressLine2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDistrict = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPinCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDOB = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAadharNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTIN = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCIN = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGST = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTypeOfEngagement = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gv_Result = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJob = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colClient = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.MainWizard, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MainWizard.SuspendLayout()
            Me.page_Clients.SuspendLayout()
            CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl2.SuspendLayout()
            CType(Me.gc_Clients_Selected, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_Clients_Selected, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.gc_Clients_All, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_Clients_All, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            CType(Me.txt_To.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_From.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.page_Finish.SuspendLayout()
            CType(Me.cb_OpenExportedFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.page_Generating.SuspendLayout()
            Me.page_Result.SuspendLayout()
            CType(Me.gc_Result, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.page_Export.SuspendLayout()
            CType(Me.txt_ExportPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rgrp_ExportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_Result, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MainWizard
            '
            Me.MainWizard.Controls.Add(Me.page_Clients)
            Me.MainWizard.Controls.Add(Me.page_Finish)
            Me.MainWizard.Controls.Add(Me.page_Generating)
            Me.MainWizard.Controls.Add(Me.page_Result)
            Me.MainWizard.Controls.Add(Me.page_Export)
            Me.MainWizard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainWizard.Location = New System.Drawing.Point(0, 0)
            Me.MainWizard.Name = "MainWizard"
            Me.MainWizard.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.page_Clients, Me.page_Generating, Me.page_Result, Me.page_Export, Me.page_Finish})
            Me.MainWizard.Size = New System.Drawing.Size(677, 432)
            Me.MainWizard.Text = ""
            Me.MainWizard.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
            '
            'page_Clients
            '
            Me.page_Clients.AllowFinish = False
            Me.page_Clients.Controls.Add(Me.btn_UnselectClient)
            Me.page_Clients.Controls.Add(Me.btn_SelectClient)
            Me.page_Clients.Controls.Add(Me.GroupControl2)
            Me.page_Clients.Controls.Add(Me.GroupControl1)
            Me.page_Clients.Controls.Add(Me.Panel2)
            Me.page_Clients.Name = "page_Clients"
            Me.page_Clients.Size = New System.Drawing.Size(617, 264)
            Me.page_Clients.Text = "Select Clients"
            '
            'btn_UnselectClient
            '
            Me.btn_UnselectClient.Location = New System.Drawing.Point(271, 125)
            Me.btn_UnselectClient.Name = "btn_UnselectClient"
            Me.btn_UnselectClient.Size = New System.Drawing.Size(75, 23)
            Me.btn_UnselectClient.TabIndex = 1
            Me.btn_UnselectClient.Text = "<-- Unselect"
            '
            'btn_SelectClient
            '
            Me.btn_SelectClient.Location = New System.Drawing.Point(271, 96)
            Me.btn_SelectClient.Name = "btn_SelectClient"
            Me.btn_SelectClient.Size = New System.Drawing.Size(75, 23)
            Me.btn_SelectClient.TabIndex = 1
            Me.btn_SelectClient.Text = "Select -->"
            '
            'GroupControl2
            '
            Me.GroupControl2.Controls.Add(Me.gc_Clients_Selected)
            Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupControl2.Location = New System.Drawing.Point(352, 0)
            Me.GroupControl2.Name = "GroupControl2"
            Me.GroupControl2.Size = New System.Drawing.Size(265, 230)
            Me.GroupControl2.TabIndex = 0
            Me.GroupControl2.Text = "Selected Clients"
            '
            'gc_Clients_Selected
            '
            Me.gc_Clients_Selected.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_Clients_Selected.Location = New System.Drawing.Point(2, 20)
            Me.gc_Clients_Selected.MainView = Me.gv_Clients_Selected
            Me.gc_Clients_Selected.Name = "gc_Clients_Selected"
            Me.gc_Clients_Selected.Size = New System.Drawing.Size(261, 208)
            Me.gc_Clients_Selected.TabIndex = 1
            Me.gc_Clients_Selected.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Clients_Selected})
            '
            'gv_Clients_Selected
            '
            Me.gv_Clients_Selected.GridControl = Me.gc_Clients_Selected
            Me.gv_Clients_Selected.Name = "gv_Clients_Selected"
            Me.gv_Clients_Selected.OptionsBehavior.Editable = False
            Me.gv_Clients_Selected.OptionsBehavior.ReadOnly = True
            Me.gv_Clients_Selected.OptionsSelection.MultiSelect = True
            '
            'GroupControl1
            '
            Me.GroupControl1.Controls.Add(Me.gc_Clients_All)
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(265, 230)
            Me.GroupControl1.TabIndex = 0
            Me.GroupControl1.Text = "All Clients"
            '
            'gc_Clients_All
            '
            Me.gc_Clients_All.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_Clients_All.Location = New System.Drawing.Point(2, 20)
            Me.gc_Clients_All.MainView = Me.gv_Clients_All
            Me.gc_Clients_All.Name = "gc_Clients_All"
            Me.gc_Clients_All.Size = New System.Drawing.Size(261, 208)
            Me.gc_Clients_All.TabIndex = 0
            Me.gc_Clients_All.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Clients_All})
            '
            'gv_Clients_All
            '
            Me.gv_Clients_All.GridControl = Me.gc_Clients_All
            Me.gv_Clients_All.Name = "gv_Clients_All"
            Me.gv_Clients_All.OptionsBehavior.Editable = False
            Me.gv_Clients_All.OptionsBehavior.ReadOnly = True
            Me.gv_Clients_All.OptionsSelection.MultiSelect = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.txt_To)
            Me.Panel2.Controls.Add(Me.LabelControl3)
            Me.Panel2.Controls.Add(Me.txt_From)
            Me.Panel2.Controls.Add(Me.LabelControl2)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 230)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(617, 34)
            Me.Panel2.TabIndex = 2
            '
            'txt_To
            '
            Me.txt_To.EditValue = Nothing
            Me.txt_To.Location = New System.Drawing.Point(381, 7)
            Me.txt_To.Name = "txt_To"
            Me.txt_To.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_To.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_To.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            Me.txt_To.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.txt_To.Properties.EditFormat.FormatString = "dd/MM/yyyy"
            Me.txt_To.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.txt_To.Properties.Mask.EditMask = "dd/MM/yyyy"
            Me.txt_To.Size = New System.Drawing.Size(234, 20)
            Me.txt_To.TabIndex = 3
            '
            'LabelControl3
            '
            Me.LabelControl3.Location = New System.Drawing.Point(365, 10)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(10, 13)
            Me.LabelControl3.TabIndex = 2
            Me.LabelControl3.Text = "to"
            '
            'txt_From
            '
            Me.txt_From.EditValue = Nothing
            Me.txt_From.Location = New System.Drawing.Point(122, 7)
            Me.txt_From.Name = "txt_From"
            Me.txt_From.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_From.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_From.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            Me.txt_From.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.txt_From.Properties.EditFormat.FormatString = "dd/MM/yyyy"
            Me.txt_From.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.txt_From.Properties.Mask.EditMask = "dd/MM/yyyy"
            Me.txt_From.Size = New System.Drawing.Size(237, 20)
            Me.txt_From.TabIndex = 1
            '
            'LabelControl2
            '
            Me.LabelControl2.Location = New System.Drawing.Point(20, 10)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(96, 13)
            Me.LabelControl2.TabIndex = 0
            Me.LabelControl2.Text = "Select Date Range :"
            '
            'page_Finish
            '
            Me.page_Finish.AllowBack = False
            Me.page_Finish.AllowCancel = False
            Me.page_Finish.AllowNext = False
            Me.page_Finish.Controls.Add(Me.cb_OpenExportedFile)
            Me.page_Finish.Controls.Add(Me.Label1)
            Me.page_Finish.Name = "page_Finish"
            Me.page_Finish.Size = New System.Drawing.Size(617, 264)
            Me.page_Finish.Text = "Export Successful"
            '
            'cb_OpenExportedFile
            '
            Me.cb_OpenExportedFile.Location = New System.Drawing.Point(103, 109)
            Me.cb_OpenExportedFile.Name = "cb_OpenExportedFile"
            Me.cb_OpenExportedFile.Properties.Caption = "Open Exported File"
            Me.cb_OpenExportedFile.Size = New System.Drawing.Size(141, 19)
            Me.cb_OpenExportedFile.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(100, 35)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(234, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Report Successfully Exported to Selected Path."
            '
            'page_Generating
            '
            Me.page_Generating.AllowBack = False
            Me.page_Generating.AllowCancel = False
            Me.page_Generating.AllowFinish = False
            Me.page_Generating.AllowNext = False
            Me.page_Generating.Controls.Add(Me.ProgressPanel_GeneratingReport)
            Me.page_Generating.Name = "page_Generating"
            Me.page_Generating.Size = New System.Drawing.Size(617, 264)
            Me.page_Generating.Text = "Generating Report"
            '
            'ProgressPanel_GeneratingReport
            '
            Me.ProgressPanel_GeneratingReport.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ProgressPanel_GeneratingReport.Appearance.Options.UseBackColor = True
            Me.ProgressPanel_GeneratingReport.BarAnimationElementThickness = 2
            Me.ProgressPanel_GeneratingReport.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ProgressPanel_GeneratingReport.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProgressPanel_GeneratingReport.Location = New System.Drawing.Point(0, 0)
            Me.ProgressPanel_GeneratingReport.Name = "ProgressPanel_GeneratingReport"
            Me.ProgressPanel_GeneratingReport.Size = New System.Drawing.Size(617, 264)
            Me.ProgressPanel_GeneratingReport.TabIndex = 0
            '
            'page_Result
            '
            Me.page_Result.Controls.Add(Me.gc_Result)
            Me.page_Result.Name = "page_Result"
            Me.page_Result.Size = New System.Drawing.Size(617, 264)
            Me.page_Result.Text = "Report"
            '
            'gc_Result
            '
            Me.gc_Result.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_Result.Location = New System.Drawing.Point(0, 0)
            Me.gc_Result.MainView = Me.gv_Result
            Me.gc_Result.Name = "gc_Result"
            Me.gc_Result.Size = New System.Drawing.Size(617, 264)
            Me.gc_Result.TabIndex = 0
            Me.gc_Result.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView1, Me.gv_Result})
            '
            'page_Export
            '
            Me.page_Export.Controls.Add(Me.txt_ExportPath)
            Me.page_Export.Controls.Add(Me.rgrp_ExportType)
            Me.page_Export.Controls.Add(Me.LabelControl6)
            Me.page_Export.Controls.Add(Me.LabelControl5)
            Me.page_Export.Name = "page_Export"
            Me.page_Export.Size = New System.Drawing.Size(617, 264)
            Me.page_Export.Text = "Export"
            '
            'txt_ExportPath
            '
            Me.txt_ExportPath.Location = New System.Drawing.Point(89, 142)
            Me.txt_ExportPath.Name = "txt_ExportPath"
            Me.txt_ExportPath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.txt_ExportPath.Size = New System.Drawing.Size(497, 20)
            Me.txt_ExportPath.TabIndex = 3
            '
            'rgrp_ExportType
            '
            Me.rgrp_ExportType.EditValue = 0
            Me.rgrp_ExportType.Location = New System.Drawing.Point(89, 22)
            Me.rgrp_ExportType.Name = "rgrp_ExportType"
            Me.rgrp_ExportType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgrp_ExportType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Microsoft Excel Spreadsheet 2007 & Later (XLSX)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Microsoft Excel Spreadsheet 2003 (XLS)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Comma Separated Values (CSV)")})
            Me.rgrp_ExportType.Size = New System.Drawing.Size(497, 96)
            Me.rgrp_ExportType.TabIndex = 2
            '
            'LabelControl6
            '
            Me.LabelControl6.Location = New System.Drawing.Point(54, 145)
            Me.LabelControl6.Name = "LabelControl6"
            Me.LabelControl6.Size = New System.Drawing.Size(29, 13)
            Me.LabelControl6.TabIndex = 1
            Me.LabelControl6.Text = "Path :"
            '
            'LabelControl5
            '
            Me.LabelControl5.Location = New System.Drawing.Point(52, 30)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Size = New System.Drawing.Size(31, 13)
            Me.LabelControl5.TabIndex = 0
            Me.LabelControl5.Text = "Type :"
            '
            'Loader_Details
            '
            '
            'Loader_GenerateReport
            '
            '
            'SaveFileDialog_Export
            '
            Me.SaveFileDialog_Export.Filter = "Microsoft Excel Spreadsheet (*.xlsx)|*.xlsx"
            '
            'CardView1
            '
            Me.CardView1.FocusedCardTopFieldIndex = 0
            Me.CardView1.GridControl = Me.gc_Result
            Me.CardView1.Name = "CardView1"
            '
            'colID1
            '
            Me.colID1.FieldName = "ID"
            Me.colID1.Name = "colID1"
            Me.colID1.OptionsColumn.ReadOnly = True
            '
            'colPhoto
            '
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            '
            'colPAN
            '
            Me.colPAN.FieldName = "PAN"
            Me.colPAN.Name = "colPAN"
            '
            'colName
            '
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            '
            'colFatherName
            '
            Me.colFatherName.FieldName = "FatherName"
            Me.colFatherName.Name = "colFatherName"
            '
            'colMobile
            '
            Me.colMobile.FieldName = "Mobile"
            Me.colMobile.Name = "colMobile"
            '
            'colEmail
            '
            Me.colEmail.FieldName = "Email"
            Me.colEmail.Name = "colEmail"
            '
            'colAddressLine1
            '
            Me.colAddressLine1.FieldName = "AddressLine1"
            Me.colAddressLine1.Name = "colAddressLine1"
            '
            'colAddressLine2
            '
            Me.colAddressLine2.FieldName = "AddressLine2"
            Me.colAddressLine2.Name = "colAddressLine2"
            '
            'colDistrict
            '
            Me.colDistrict.FieldName = "District"
            Me.colDistrict.Name = "colDistrict"
            '
            'colPinCode
            '
            Me.colPinCode.FieldName = "PinCode"
            Me.colPinCode.Name = "colPinCode"
            '
            'colDOB
            '
            Me.colDOB.FieldName = "DOB"
            Me.colDOB.Name = "colDOB"
            '
            'colAadharNo
            '
            Me.colAadharNo.FieldName = "AadharNo"
            Me.colAadharNo.Name = "colAadharNo"
            '
            'colTIN
            '
            Me.colTIN.FieldName = "TIN"
            Me.colTIN.Name = "colTIN"
            '
            'colCIN
            '
            Me.colCIN.FieldName = "CIN"
            Me.colCIN.Name = "colCIN"
            '
            'colGST
            '
            Me.colGST.FieldName = "GST"
            Me.colGST.Name = "colGST"
            '
            'colFileNo
            '
            Me.colFileNo.FieldName = "FileNo"
            Me.colFileNo.Name = "colFileNo"
            '
            'colType
            '
            Me.colType.FieldName = "Type"
            Me.colType.Name = "colType"
            '
            'colDescription1
            '
            Me.colDescription1.FieldName = "Description"
            Me.colDescription1.Name = "colDescription1"
            '
            'colTypeOfEngagement
            '
            Me.colTypeOfEngagement.FieldName = "TypeOfEngagement"
            Me.colTypeOfEngagement.Name = "colTypeOfEngagement"
            '
            'colStatus
            '
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            '
            'gv_Result
            '
            Me.gv_Result.GridControl = Me.gc_Result
            Me.gv_Result.Name = "gv_Result"
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colJob
            '
            Me.colJob.FieldName = "Job"
            Me.colJob.Name = "colJob"
            Me.colJob.Visible = True
            Me.colJob.VisibleIndex = 1
            '
            'colClient
            '
            Me.colClient.FieldName = "Client"
            Me.colClient.Name = "colClient"
            Me.colClient.Visible = True
            Me.colClient.VisibleIndex = 2
            '
            'frm_ClientJobsReport
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(677, 432)
            Me.Controls.Add(Me.MainWizard)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_ClientJobsReport"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Filers/Non-Filers Report"
            CType(Me.MainWizard, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MainWizard.ResumeLayout(False)
            Me.page_Clients.ResumeLayout(False)
            CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl2.ResumeLayout(False)
            CType(Me.gc_Clients_Selected, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_Clients_Selected, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            CType(Me.gc_Clients_All, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_Clients_All, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            CType(Me.txt_To.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_From.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.page_Finish.ResumeLayout(False)
            Me.page_Finish.PerformLayout()
            CType(Me.cb_OpenExportedFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.page_Generating.ResumeLayout(False)
            Me.page_Result.ResumeLayout(False)
            CType(Me.gc_Result, System.ComponentModel.ISupportInitialize).EndInit()
            Me.page_Export.ResumeLayout(False)
            Me.page_Export.PerformLayout()
            CType(Me.txt_ExportPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgrp_ExportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_Result, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainWizard As DevExpress.XtraWizard.WizardControl
        Friend WithEvents page_Clients As DevExpress.XtraWizard.WizardPage
        Friend WithEvents page_Finish As DevExpress.XtraWizard.CompletionWizardPage
        Friend WithEvents page_Generating As DevExpress.XtraWizard.WizardPage
        Friend WithEvents ProgressPanel_GeneratingReport As DevExpress.XtraWaitForm.ProgressPanel
        Friend WithEvents page_Result As DevExpress.XtraWizard.WizardPage
        Friend WithEvents gc_Result As DevExpress.XtraGrid.GridControl
        Friend WithEvents page_Export As DevExpress.XtraWizard.WizardPage
        Friend WithEvents txt_ExportPath As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents rgrp_ExportType As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cb_OpenExportedFile As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label1 As Label
        Friend WithEvents Loader_Details As System.ComponentModel.BackgroundWorker
        Friend WithEvents Loader_GenerateReport As System.ComponentModel.BackgroundWorker
        Friend WithEvents SaveFileDialog_Export As SaveFileDialog
        Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents gc_Clients_Selected As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_Clients_Selected As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents gc_Clients_All As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_Clients_All As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents btn_UnselectClient As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_SelectClient As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Panel2 As Panel
        Friend WithEvents txt_To As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_From As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents gv_Result As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
        Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPhoto As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPAN As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFatherName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMobile As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAddressLine1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAddressLine2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDistrict As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPinCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDOB As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAadharNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTIN As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCIN As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colGST As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTypeOfEngagement As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJob As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colClient As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace