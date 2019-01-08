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
    Public Class frm_ClientJobsReport

        Sub New(ByVal Clients As List(Of Objects.Client))
            InitializeComponent()
            Me.Clients = Clients
        End Sub

        Dim Clients As List(Of Objects.Client)

        Sub SetupClientColumns()
            Dim Columns As String() = {"Name", "PAN"}
            Dim GridViews As DevExpress.XtraGrid.Views.Grid.GridView() = {gv_Clients_All, gv_Clients_Selected}
            For Each i As DevExpress.XtraGrid.Views.Grid.GridView In GridViews
                For Each c As DevExpress.XtraGrid.Columns.GridColumn In i.Columns
                    If Columns.Contains(c.FieldName) Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If
                Next
            Next
        End Sub

        Private Sub Loader_Details_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Details.DoWork
            Me.Invoke(Sub()
                          page_Clients.AllowCancel = False
                          page_Clients.AllowNext = False
                      End Sub)

            Me.Invoke(Sub()
                      End Sub)

            Me.Invoke(Sub()
                          page_Clients.AllowCancel = True
                          page_Clients.AllowNext = True
                      End Sub)
        End Sub

        Private Sub frm_FilersReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Loader_Details.RunWorkerAsync()
        End Sub

        Private Sub frm_FilersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            gc_Clients_All.DataSource = Me.Clients
            gc_Clients_Selected.DataSource = New List(Of Objects.Client)
            SetupClientColumns()
        End Sub

        Private Sub MainWizard_NextClick(sender As Object, e As WizardCommandButtonClickEventArgs) Handles MainWizard.NextClick
            e.Handled = True
            If e.Page Is page_Clients Then
                MainWizard.SelectedPage = page_Generating
                Loader_GenerateReport.RunWorkerAsync()
            ElseIf e.Page Is page_Result Then
                MainWizard.SelectedPage = page_Export
            ElseIf e.Page Is page_Export Then
                Dim SupportedExtensions As String() = {".xlsx", ".xls", ".csv"}
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
            Dim AvailableColumns As String() = {"ID", "Job", "Client", "CurrentStep", "AddedOn", "CompletedOn", "Description", "Remarks", "Status", "AssessmentDetail", "FinancialDetail", "BillingStatus"}

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
                MainWizard.SelectedPage = page_Clients
            End If
        End Sub

        Private Sub btn_SelectClient_Click(sender As Object, e As EventArgs) Handles btn_SelectClient.Click
            If gv_Clients_All.SelectedRowsCount > 0 Then
                Dim Selected As List(Of Objects.Client) = CType(gv_Clients_Selected.DataSource, List(Of Objects.Client))
                For Each i As Integer In gv_Clients_All.GetSelectedRows
                    Dim Item As Objects.Client = gv_Clients_All.GetRow(i)
                    If Not Selected.Contains(Item) Then
                        Selected.Add(Item)
                    End If
                Next
                gc_Clients_Selected.RefreshDataSource()
            End If
        End Sub

        Private Sub btn_UnselectClient_Click(sender As Object, e As EventArgs) Handles btn_UnselectClient.Click
            If gv_Clients_Selected.SelectedRowsCount > 0 Then
                Dim toRemove As New List(Of Objects.Client)
                For Each i As Integer In gv_Clients_Selected.GetSelectedRows
                    toRemove.Add(gv_Clients_Selected.GetRow(i))
                Next
                For Each i As Objects.Client In toRemove
                    CType(gv_Clients_Selected.DataSource, List(Of Objects.Client)).Remove(i)
                Next
                gc_Clients_Selected.RefreshDataSource()
            End If
        End Sub

        Private Sub Loader_GenerateReport_DoWork(sender As Object, e As DoWorkEventArgs) Handles Loader_GenerateReport.DoWork
            Me.Invoke(Sub() ProgressPanel_GeneratingReport.Description = "Filtering list...")


            Dim SelectedClients As List(Of Objects.Client) = gc_Clients_Selected.DataSource
            Dim SelectedClientIDs As New List(Of Integer)
            For Each i As Objects.Client In SelectedClients
                SelectedClientIDs.Add(i.ID)
            Next

            Dim Result As List(Of Objects.WorkbookItem) = Database.Workbook.GetForClientsBetweenDates(True, SelectedClientIDs, txt_From.DateTime, txt_To.DateTime)

            Me.Invoke(Sub()
                          gc_Result.DataSource = Result
                          gc_Result.RefreshDataSource()
                          SetupColumns()
                          MainWizard.SelectedPage = page_Result
                      End Sub)
        End Sub

    End Class
End Namespace