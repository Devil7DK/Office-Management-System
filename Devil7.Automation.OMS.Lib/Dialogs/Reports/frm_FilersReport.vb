'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraWizard

Namespace Dialogs
    Public Class frm_FilersReport

        Sub New(ByVal Clients As List(Of Objects.Client))
            InitializeComponent()
            Me.Clients = Clients
        End Sub

        Dim Jobs As New List(Of Objects.Job)
        Dim Clients As List(Of Objects.Client)

        Private Sub Loader_Details_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Details.DoWork
            Me.Invoke(Sub()
                          page_JobDetails.AllowCancel = False
                          page_JobDetails.AllowNext = False
                          ProgressPanel_JobDetails.Visible = True
                      End Sub)

            Dim Jobs As List(Of Objects.Job) = Database.Jobs.GetReportJobs(False)
            Jobs.Sort(New Comparers.CompareByID)
            Me.Jobs = Jobs
            Me.Invoke(Sub()
                          txt_Job.Properties.DataSource = Jobs
                          txt_Job.Properties.DisplayMember = "Name"
                          txt_Job.Properties.ValueMember = "ID"
                          If Jobs.Count > 0 Then txt_Job.EditValue = Jobs(0).ID
                      End Sub)

            Me.Invoke(Sub()
                          page_JobDetails.AllowCancel = True
                          page_JobDetails.AllowNext = True
                          ProgressPanel_JobDetails.Visible = False
                      End Sub)
        End Sub

        Private Sub frm_FilersReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Loader_Details.RunWorkerAsync()
        End Sub

        Private Sub txt_Job_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Job.EditValueChanged
            If Jobs IsNot Nothing AndAlso Jobs.Count > 0 Then
                Dim job As Objects.Job = Jobs.Find(Function(c) c.ID = txt_Job.EditValue)
                If job IsNot Nothing Then YearMonthEdit1.PeriodType = job.Type
            End If
        End Sub

        Private Sub frm_FilersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub MainWizard_NextClick(sender As Object, e As WizardCommandButtonClickEventArgs) Handles MainWizard.NextClick
            e.Handled = True
            If e.Page Is page_JobDetails Then
                MainWizard.SelectedPage = page_Generating
                Loader_GenerateReport.RunWorkerAsync()
            ElseIf e.Page Is page_Result Then
                MainWizard.SelectedPage = page_Export
            ElseIf e.Page Is page_Export Then
                Dim SupportedExtensions As String() = {"xlsx", "xls", "csv"}
                Dim Ext As String = IO.Path.GetExtension(txt_ExportPath.EditValue)
                If txt_ExportPath.EditValue <> "" AndAlso SupportedExtensions.Contains(Ext) Then
                    If Ext = "csv" Then
                        gc_Result.ExportToCsv(txt_ExportPath.EditValue)
                    ElseIf Ext = "xls" Then
                        gc_Result.ExportToXls(txt_ExportPath.EditValue)
                    Else
                        gc_Result.ExportToXlsx(txt_ExportPath.EditValue)
                    End If
                    MainWizard.SelectedPage = page_Finish
                Else
                    MsgBox("Export path is not valid.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End If
            End If
        End Sub

        Sub SetupColumns()
            Dim AvailableColumns As String() = {"PAN", "Name", "FatherName", "Mobile", "Email", "Status", "ID"}

            For Each i As DevExpress.XtraGrid.Columns.GridColumn In gv_Result.Columns
                If AvailableColumns.Contains(i.FieldName) Then
                    Me.Invoke(Sub()
                                  i.Visible = True
                              End Sub)
                Else
                    Me.Invoke(Sub()
                                  i.Visible = False
                              End Sub)
                End If
            Next
        End Sub

        Private Sub Loader_GenerateReport_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_GenerateReport.DoWork

            Me.Invoke(Sub() ProgressPanel_GeneratingReport.Description = "Filtering users list...")

            Dim Clients As New List(Of Objects.Client)
            Dim Result As New List(Of Objects.Client)

            For Each i As Objects.Client In Me.Clients
                If i.Jobs IsNot Nothing Then
                    If i.Jobs.Find(Function(c) c.Job.ID = txt_Job.EditValue) IsNot Nothing Then
                        Clients.Add(i)
                    End If
                End If
            Next

            For i As Integer = 0 To Clients.Count - 1
                Dim Index As Integer = i + 1
                Dim Client As Objects.Client = Clients(i)

                Me.Invoke(Sub() ProgressPanel_GeneratingReport.Description = String.Format("Processing Client {0} of {1} - {2}", Index, Clients.Count, Client.Name))

                Dim Count As Integer = Database.Workbook.GetWorkbookItemsCount(Client.ID, txt_Job.EditValue, YearMonthEdit1.Value.ToString, If(rgrp_PeriodType.EditValue = 0, Enums.PeriodType.Financial, Enums.PeriodType.Assessment))

                If rgrp_ReportType.EditValue = 0 Then
                    If Count > 0 Then Result.Add(Client)
                Else
                    If Count = 0 Then Result.Add(Client)
                End If
            Next

            Me.Invoke(Sub()
                          gc_Result.DataSource = Result
                          gc_Result.RefreshDataSource()
                          SetupColumns()
                          MainWizard.SelectedPage = page_Result
                      End Sub)
        End Sub

        Private Sub txt_ExportPath_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_ExportPath.ButtonClick
            Select Case rgrp_ExportType.EditValue
                Case 0
                    SaveFileDialog_Export.Filter = "Microsoft Excel Spreadsheet (*.xlsx)|*.xlsx"
                    SaveFileDialog_Export.DefaultExt = "xlsx"
                Case 1
                    SaveFileDialog_Export.Filter = "Microsoft Excel Spreadsheet (*.xls)|*.xls"
                    SaveFileDialog_Export.DefaultExt = "xls"
                Case 2
                    SaveFileDialog_Export.Filter = "Comma Separated Values File (*.csv)|*.csv"
                    SaveFileDialog_Export.DefaultExt = "csv"
            End Select
            If SaveFileDialog_Export.ShowDialog = DialogResult.OK Then
                txt_ExportPath.EditValue = SaveFileDialog_Export.FileName
            End If
        End Sub

        Private Sub MainWizard_FinishClick(sender As Object, e As CancelEventArgs) Handles MainWizard.FinishClick
            If cb_OpenExportedFile.Checked Then
                If My.Computer.FileSystem.FileExists(txt_ExportPath.EditValue) Then
                    Process.Start(txt_ExportPath.EditValue)
                End If
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub MainWizard_PrevClick(sender As Object, e As WizardCommandButtonClickEventArgs) Handles MainWizard.PrevClick
            e.Handled = True
            If e.Page Is page_Finish Then
                MainWizard.SelectedPage = page_Export
            ElseIf e.Page Is page_Export Then
                MainWizard.SelectedPage = page_Result
            ElseIf e.Page Is page_Result Then
                MainWizard.SelectedPage = page_JobDetails
            End If
        End Sub
    End Class
End Namespace