<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FilersReport
    Inherits DevExpress.XtraEditors.XtraForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim YearMonth1 As Devil7.Automation.OMS.[Lib].Objects.YearMonth = New Devil7.Automation.OMS.[Lib].Objects.YearMonth()
        Me.MainWizard = New DevExpress.XtraWizard.WizardControl()
        Me.page_JobDetails = New DevExpress.XtraWizard.WizardPage()
        Me.ProgressPanel_JobDetails = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.YearMonthEdit1 = New Devil7.Automation.OMS.[Lib].Utils.YearMonthEdit()
        Me.txt_Job = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.rgrp_PeriodType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.rgrp_ReportType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.page_Finish = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.cb_OpenExportedFile = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.page_Generating = New DevExpress.XtraWizard.WizardPage()
        Me.ProgressPanel_GeneratingReport = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.page_Result = New DevExpress.XtraWizard.WizardPage()
        Me.gc_Result = New DevExpress.XtraGrid.GridControl()
        Me.gv_Result = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.page_Export = New DevExpress.XtraWizard.WizardPage()
        Me.txt_ExportPath = New DevExpress.XtraEditors.ButtonEdit()
        Me.rgrp_ExportType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Loader_Details = New System.ComponentModel.BackgroundWorker()
        Me.Loader_GenerateReport = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog_Export = New System.Windows.Forms.SaveFileDialog()
        CType(Me.MainWizard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainWizard.SuspendLayout()
        Me.page_JobDetails.SuspendLayout()
        CType(Me.txt_Job.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgrp_PeriodType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgrp_ReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page_Finish.SuspendLayout()
        CType(Me.cb_OpenExportedFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page_Generating.SuspendLayout()
        Me.page_Result.SuspendLayout()
        CType(Me.gc_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page_Export.SuspendLayout()
        CType(Me.txt_ExportPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgrp_ExportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWizard
        '
        Me.MainWizard.Controls.Add(Me.page_JobDetails)
        Me.MainWizard.Controls.Add(Me.page_Finish)
        Me.MainWizard.Controls.Add(Me.page_Generating)
        Me.MainWizard.Controls.Add(Me.page_Result)
        Me.MainWizard.Controls.Add(Me.page_Export)
        Me.MainWizard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainWizard.Location = New System.Drawing.Point(0, 0)
        Me.MainWizard.Name = "MainWizard"
        Me.MainWizard.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.page_JobDetails, Me.page_Generating, Me.page_Result, Me.page_Export, Me.page_Finish})
        Me.MainWizard.Size = New System.Drawing.Size(677, 432)
        Me.MainWizard.Text = ""
        Me.MainWizard.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
        '
        'page_JobDetails
        '
        Me.page_JobDetails.AllowFinish = False
        Me.page_JobDetails.Controls.Add(Me.ProgressPanel_JobDetails)
        Me.page_JobDetails.Controls.Add(Me.YearMonthEdit1)
        Me.page_JobDetails.Controls.Add(Me.txt_Job)
        Me.page_JobDetails.Controls.Add(Me.LabelControl4)
        Me.page_JobDetails.Controls.Add(Me.rgrp_PeriodType)
        Me.page_JobDetails.Controls.Add(Me.LabelControl3)
        Me.page_JobDetails.Controls.Add(Me.rgrp_ReportType)
        Me.page_JobDetails.Controls.Add(Me.LabelControl2)
        Me.page_JobDetails.Controls.Add(Me.LabelControl1)
        Me.page_JobDetails.Name = "page_JobDetails"
        Me.page_JobDetails.Size = New System.Drawing.Size(617, 264)
        Me.page_JobDetails.Text = "Job Details"
        '
        'ProgressPanel_JobDetails
        '
        Me.ProgressPanel_JobDetails.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_JobDetails.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_JobDetails.BarAnimationElementThickness = 2
        Me.ProgressPanel_JobDetails.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_JobDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_JobDetails.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_JobDetails.Name = "ProgressPanel_JobDetails"
        Me.ProgressPanel_JobDetails.Size = New System.Drawing.Size(617, 264)
        Me.ProgressPanel_JobDetails.TabIndex = 11
        '
        'YearMonthEdit1
        '
        Me.YearMonthEdit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.YearMonthEdit1.Location = New System.Drawing.Point(130, 160)
        Me.YearMonthEdit1.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.YearMonthEdit1.MinimumSize = New System.Drawing.Size(0, 21)
        Me.YearMonthEdit1.Name = "YearMonthEdit1"
        Me.YearMonthEdit1.PeriodType = Devil7.Automation.OMS.[Lib].Enums.JobType.Yearly
        Me.YearMonthEdit1.Size = New System.Drawing.Size(297, 21)
        Me.YearMonthEdit1.TabIndex = 12
        YearMonth1.Period = "April"
        YearMonth1.Year = "2018-2019"
        Me.YearMonthEdit1.Value = YearMonth1
        '
        'txt_Job
        '
        Me.txt_Job.Location = New System.Drawing.Point(130, 29)
        Me.txt_Job.Name = "txt_Job"
        Me.txt_Job.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Job.Size = New System.Drawing.Size(457, 20)
        Me.txt_Job.TabIndex = 11
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(87, 164)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Period :"
        '
        'rgrp_PeriodType
        '
        Me.rgrp_PeriodType.EditValue = 0
        Me.rgrp_PeriodType.Location = New System.Drawing.Point(130, 117)
        Me.rgrp_PeriodType.Name = "rgrp_PeriodType"
        Me.rgrp_PeriodType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgrp_PeriodType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Financial Year/Month"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Assessment Year/Month")})
        Me.rgrp_PeriodType.Size = New System.Drawing.Size(312, 20)
        Me.rgrp_PeriodType.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(60, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Period Type :"
        '
        'rgrp_ReportType
        '
        Me.rgrp_ReportType.EditValue = 0
        Me.rgrp_ReportType.Location = New System.Drawing.Point(130, 73)
        Me.rgrp_ReportType.Name = "rgrp_ReportType"
        Me.rgrp_ReportType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgrp_ReportType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Filers"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Non-Filers")})
        Me.rgrp_ReportType.Size = New System.Drawing.Size(312, 20)
        Me.rgrp_ReportType.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(57, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Report Type :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(100, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Job :"
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
        Me.gc_Result.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Result})
        '
        'gv_Result
        '
        Me.gv_Result.GridControl = Me.gc_Result
        Me.gv_Result.Name = "gv_Result"
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
        'frm_FilersReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 432)
        Me.Controls.Add(Me.MainWizard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FilersReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filers/Non-Filers Report"
        CType(Me.MainWizard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainWizard.ResumeLayout(False)
        Me.page_JobDetails.ResumeLayout(False)
        Me.page_JobDetails.PerformLayout()
        CType(Me.txt_Job.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgrp_PeriodType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgrp_ReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page_Finish.ResumeLayout(False)
        Me.page_Finish.PerformLayout()
        CType(Me.cb_OpenExportedFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page_Generating.ResumeLayout(False)
        Me.page_Result.ResumeLayout(False)
        CType(Me.gc_Result, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page_Export.ResumeLayout(False)
        Me.page_Export.PerformLayout()
        CType(Me.txt_ExportPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgrp_ExportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainWizard As DevExpress.XtraWizard.WizardControl
    Friend WithEvents page_JobDetails As DevExpress.XtraWizard.WizardPage
    Friend WithEvents page_Finish As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents rgrp_ReportType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgrp_PeriodType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents page_Generating As DevExpress.XtraWizard.WizardPage
    Friend WithEvents ProgressPanel_GeneratingReport As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents page_Result As DevExpress.XtraWizard.WizardPage
    Friend WithEvents gc_Result As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Result As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents page_Export As DevExpress.XtraWizard.WizardPage
    Friend WithEvents txt_ExportPath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents rgrp_ExportType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_OpenExportedFile As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressPanel_JobDetails As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader_Details As System.ComponentModel.BackgroundWorker
    Friend WithEvents txt_Job As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents YearMonthEdit1 As [Lib].Utils.YearMonthEdit
    Friend WithEvents Loader_GenerateReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog_Export As SaveFileDialog
End Class
