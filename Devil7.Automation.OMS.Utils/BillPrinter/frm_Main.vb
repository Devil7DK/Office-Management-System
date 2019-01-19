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
    Dim ReceiversList As New List(Of ClientMinimal)
    Dim SendersList As New List(Of Sender)
    Dim JobsList As New List(Of Job)
    Dim UsersList As New List(Of User)

    Dim ServicesList As New List(Of String)
    Dim FeesItemsList As New List(Of String)
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
        If tc_Main.SelectedTabPage Is tab_Bills Then
            Dim sa As String = "0000"
            Try
                Dim sno As Integer = 0
                Dim formatr As String = "0000"
                For Each i As Bill In gc_Bills.DataSource
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

            Dim d As New frm_Bill(Enums.DialogMode.Add, ServicesList, ReceiversList, SendersList, Serial:=sa)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                If d.ServicesEdited Then
                    Database.Services.Save(d.AllServices, True)
                End If
                Loader.RunWorkerAsync()
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            Dim d As New frm_FeesReminder(Enums.DialogMode.Add, FeesItemsList, ReceiversList, SendersList)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                If d.DetailsEdited Then
                    Database.FeesItems.Save(d.AllDetails, True)
                End If
                Loader.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Edit.ItemClick
        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                Dim r = CType(gv_Bills.GetRow(gv_Bills.GetSelectedRows(0)), Bill)
                Dim d As New frm_Bill(Enums.DialogMode.Edit, ServicesList, ReceiversList, SendersList, r)
                If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    If d.ServicesEdited Then
                        Database.Services.Save(d.AllServices, True)
                    End If
                End If
                Loader.RunWorkerAsync()
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                Dim r = CType(gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0)), FeesReminder)
                Dim d As New frm_FeesReminder(Enums.DialogMode.Edit, FeesItemsList, ReceiversList, SendersList, r)
                If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    If d.DetailsEdited Then
                        Database.FeesItems.Save(d.AllDetails, True)
                    End If
                End If
                Loader.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Remove.ItemClick
        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_Bills.GetSelectedRows
                    Dim r = CType(gv_Bills.GetRow(i), Bill)
                    If Database.Bills.Remove(r.ID, False) Then
                        CType(Me.gc_Bills.DataSource, List(Of Bill)).Remove(r)
                    Else
                        MsgBox("Error on deleting entries", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                        Exit For
                    End If
                Next
                gc_Bills.RefreshDataSource()
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_FeesReminders.GetSelectedRows
                    Dim r = CType(gv_FeesReminders.GetRow(i), FeesReminder)
                    If Database.FeesReminders.Remove(r.ID, False) Then
                        CType(Me.gc_FeesReminders.DataSource, List(Of FeesReminder)).Remove(r)
                    Else
                        MsgBox("Error on deleting entries", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                        Exit For
                    End If
                Next
                gc_FeesReminders.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_Refresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub



    Private Sub btn_Services_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Services.ItemClick
        Dim n As New frm_Services
        If n.ShowDialog() = DialogResult.OK Then If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print.ItemClick
        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                Dim ReportData As New data_Bill(Bill, Database.Clients.GetClientByID(Bill.Receiver.ID, JobsList, UsersList), My.Computer.Keyboard.CtrlKeyDown, 18)
                Dim Report As New report_Bill(ReportData)
                Dim Viewer As New frm_ReportViewer(Report)
                Viewer.ShowDialog()
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))

                Dim Items As New List(Of data_FeesReminder_Item)
                If FeesReminder.OpeningBalance > 0 Then Items.Add(New data_FeesReminder_Item(Nothing, "Opening Balance", FeesReminder.OpeningBalance, 0))
                For Each i As FeesItem In FeesReminder.Items
                    Dim Dr As Double = 0
                    Dim Cr As Double = 0
                    If i.Effect = Enums.Effect.Dr Then
                        Dr = i.Fees
                    Else
                        Cr = i.Fees
                    End If
                    Items.Add(New data_FeesReminder_Item(i.Date, i.Name, Dr, Cr))
                Next

                Dim ReportData As New data_FeesReminder(FeesReminder.Sender, Database.Clients.GetClientByID(FeesReminder.Receiver.ID, JobsList, UsersList), Items, FeesReminder.CustomText)
                Dim Report As New report_FeesReminder(ReportData, My.Computer.Keyboard.CtrlKeyDown)
                Dim Viewer As New frm_ReportViewer(Report)
                Viewer.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btn_FeesItems_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_FeesItems.ItemClick
        Dim n As New frm_FeesItems
        If n.ShowDialog() = DialogResult.OK Then If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub
#End Region

#Region "Other Events"
    Private Sub Loader_DoWork(sender As Object, e As DoWorkEventArgs) Handles Loader.DoWork
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

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Fees Items List...")
        Try
            FeesItemsList = Database.FeesItems.Load(False)
        Catch ex As Exception
            MsgBox("Unable to load fees items." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
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

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Bills List...")
        Dim EstimateBills As New List(Of Objects.Bill)
        Try
            EstimateBills = Database.Bills.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load bills." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Fees Reminders List...")
        Dim FeesReminders As New List(Of Objects.FeesReminder)
        Try
            FeesReminders = Database.FeesReminders.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load fees reminders." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Users List...")
        Try
            UsersList = Database.Users.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load users." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub() ProgressPanel_Bills.Description = "Loading Jobs List...")
        Try
            JobsList = Database.Jobs.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load jobs." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub()
                   gc_Bills.DataSource = EstimateBills
                   gc_FeesReminders.DataSource = FeesReminders
                   Ribbon.Enabled = True
                   ProgressPanel_Bills.Visible = False
               End Sub)
    End Sub
#End Region

End Class