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
'=========================================================================='

Imports DevExpress.XtraBars
Imports Devil7.Automation.OMS.Lib
Imports Devil7.Automation.OMS.Lib.Objects
Imports System.ComponentModel

Public Class frm_Main

#Region "Variables"
    Dim ServicesList As New List(Of String)
    Dim ReceiversList As New List(Of ClientMinimal)
    Dim SendersList As New List(Of Sender)
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Sender_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Sender.ItemClick
        frm_Senders.ShowDialog()
    End Sub

    Private Sub btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        Dim sa As String = "0000"
        Try
            Dim sno As Integer = 0
            Dim formatr As String = "0000"
            For Each i As EstimateBill In gc_EstimateBills.DataSource
                Try
                    If CInt(i.SerialNo) > sno Then
                        sno = CInt(i.SerialNo)
                        formatr = i.SerialNo
                        For ino As Integer = 1 To 9
                            formatr = formatr.Replace(ino, 0)
                        Next
                    End If
                Catch ex As Exception

                End Try
            Next
            If sno > 0 Then
                sa = CInt(sno + 1).ToString(formatr)
            End If
        Catch ex As Exception

        End Try

        Dim d As New frm_EstimateBill(Enums.DialogMode.Add, ServicesList, ReceiversList, SendersList, Serial:=sa)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If d.ServicesEdited Then
                Database.Services.Save(d.AllServices, True)
            End If
            Loader.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Edit.ItemClick
        If gv_EstimateBills.SelectedRowsCount = 1 Then
            Dim r = CType(gv_EstimateBills.GetRow(gv_EstimateBills.GetSelectedRows(0)), EstimateBill)
            Dim d As New frm_EstimateBill(Enums.DialogMode.Edit, ServicesList, ReceiversList, SendersList, r)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                If d.ServicesEdited Then
                    Database.Services.Save(d.AllServices, True)
                End If
            End If
            Loader.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Remove.ItemClick
        If gv_EstimateBills.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_EstimateBills.GetSelectedRows
                Dim r = CType(gv_EstimateBills.GetRow(i), EstimateBill)
                If Database.EstimateBills.Remove(r.ID, False) Then
                    CType(Me.gc_EstimateBills.DataSource, List(Of EstimateBill)).Remove(r)
                Else
                    MsgBox("Error on deleting entries", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                    Exit For
                End If
            Next
            gc_EstimateBills.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Refresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub
#End Region

#Region "Other Events"
    Private Sub Loader_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Loader.RunWorkerCompleted
        Invoke(Sub()
                   Ribbon.Enabled = False
                   ProgressPanel_Bills.Visible = True
                   ProgressPanel_Bills.Description = "Loading Services List..."
               End Sub)

        Try
            ServicesList = Database.Services.Load(False)
        Catch ex As Exception
            MsgBox("Unable to load services." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Senders List...")
        Try
            SendersList = Database.Senders.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load senders." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Receivers List...")
        Try
            ReceiversList = Database.Clients.GetMinimal
        Catch ex As Exception
            MsgBox("Unable to load receivers/clients." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Estimate Bills List...")
        Dim EstimateBills As New List(Of Objects.EstimateBill)
        Try
            EstimateBills = Database.EstimateBills.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load estimate bills." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub()
                   gc_EstimateBills.DataSource = EstimateBills
                   Ribbon.Enabled = True
                   ProgressPanel_Bills.Visible = False
               End Sub)
    End Sub

    Private Sub btn_Services_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Services.ItemClick
        Dim n As New frm_Services
        If n.ShowDialog() = DialogResult.OK Then If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print.ItemClick
        If gv_EstimateBills.SelectedRowsCount = 1 Then
            Dim EstimateBill As EstimateBill = gv_EstimateBills.GetRow(gv_EstimateBills.GetSelectedRows(0))
            Dim ReportData As New ReportData(EstimateBill, Database.Clients.GetClientByID(EstimateBill.Receiver.ID), My.Computer.Keyboard.CtrlKeyDown, 18)
            Dim Report As New report_EstimateBill(ReportData)
            Dim Viewer As New frm_ReportViewer(Report)
            Viewer.ShowDialog()
        End If
    End Sub
#End Region

End Class