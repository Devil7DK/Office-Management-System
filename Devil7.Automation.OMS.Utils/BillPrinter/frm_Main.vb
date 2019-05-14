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
Imports DevExpress.XtraTab
Imports Devil7.Automation.OMS.Lib
Imports Devil7.Automation.OMS.Lib.Objects
Imports System.ComponentModel

Public Class frm_Main

#Region "Variables"
    Dim ReceiversList As New List(Of Receiver)
    Dim SendersList As New List(Of Sender)
    Dim JobsList As New List(Of Job)
    Dim UsersList As New List(Of User)

    Dim TemplatesList As New List(Of Objects.BillItemTemplate)
    Dim FeesItemsList As New List(Of String)
    Dim FromAddressList As New List(Of ExMailAddress)

    Dim ProgressOverlayHandle As DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle
#End Region

#Region "Subs & Functions"
    Sub ShowProgressOverlay()
        ProgressOverlayHandle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(Me)
    End Sub

    Sub CloseProgressOverlay()
        If ProgressOverlayHandle IsNot Nothing Then DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(ProgressOverlayHandle)
    End Sub

    Private Function GetFeesReminderReport(ByVal FeesReminder As FeesReminder) As report_FeesReminder
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

        Dim ReportData As New data_FeesReminder(FeesReminder.Sender, FeesReminder.Receiver, Items, FeesReminder.CustomText)
        Return New report_FeesReminder(ReportData, My.Computer.Keyboard.CtrlKeyDown)
    End Function

    Private Function GetFeesReminderReportMail(ByVal FeesReminder As FeesReminder) As report_FeesReminder_Mail
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

        Dim ReportData As New data_FeesReminder(FeesReminder.Sender, FeesReminder.Receiver, Items, FeesReminder.CustomText)
        Return New report_FeesReminder_Mail(ReportData)
    End Function
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

            Dim d As New frm_Bill(Enums.DialogMode.Add, TemplatesList, ReceiversList, SendersList, JobsList, UsersList, Serial:=sa)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
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
                Dim d As New frm_Bill(Enums.DialogMode.Edit, TemplatesList, ReceiversList, SendersList, JobsList, UsersList, r)
                If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Loader.RunWorkerAsync()
                End If
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
        Dim n As New frm_BillItems
        If n.ShowDialog() = DialogResult.OK Then If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub

    Private Sub btn_FeesItems_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_FeesItems.ItemClick
        Dim n As New frm_FeesItems
        If n.ShowDialog() = DialogResult.OK Then If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub

    Private Sub btn_FromAddresses_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_FromAddresses.ItemClick
        Dim n As New frm_FromAddresses
        If n.ShowDialog() = DialogResult.OK Then If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub

#Region "Report Generation"
    Private Sub btn_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print.ItemClick
        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                Dim Report As New report_Bill(ReportData, False)
                Dim Viewer As New frm_ReportViewer(Report)
                Viewer.ShowDialog()
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                Dim Viewer As New frm_ReportViewer(Report)
                Viewer.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btn_Export_Mail_HTML_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_Mail_HTML.ItemClick
        Dim HTML As String = ""
        Dim ToAddress As String = ""
        Dim Subject As String = ""

        Dim HTMLOptions As New DevExpress.XtraPrinting.HtmlExportOptions
        HTMLOptions.EmbedImagesInHTML = True
        HTMLOptions.ExportMode = DevExpress.XtraPrinting.HtmlExportMode.SingleFile
        HTMLOptions.CharacterSet = "UTF-8"

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                Dim Report As New report_Bill(ReportData, True)

                Using MS As New IO.MemoryStream
                    Report.ExportToHtml(MS, HTMLOptions)
                    HTML = System.Text.Encoding.UTF8.GetString(MS.ToArray)
                End Using
                ToAddress = Bill.Receiver.Email
                Subject = Bill.Sender.BillHeading.Replace("|", " ")
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                Dim Report As report_FeesReminder_Mail = GetFeesReminderReportMail(FeesReminder)

                Using MS As New IO.MemoryStream
                    Report.ExportToHtml(MS, HTMLOptions)
                    HTML = System.Text.Encoding.UTF8.GetString(MS.ToArray)
                End Using
                ToAddress = FeesReminder.Receiver.Email
                Subject = "Fees Reminder"
            End If
        End If

        Dim D As New frm_SendMail(FromAddressList, ToAddress, Subject, HTML, True)
        D.ShowDialog()
    End Sub

    Private Sub btn_Export_Mail_PDF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_Mail_PDF.ItemClick
        Dim Content As String = "Kindly find the attached PDF in attachments below..."
        Dim ToAddress As String = ""
        Dim Subject As String = ""

        Dim FilePath As String = ""
        Dim TempDir As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "PDF_TEMP_" & Now.ToString("ddMMyyyy_hhmm"))
        If My.Computer.FileSystem.DirectoryExists(TempDir) Then My.Computer.FileSystem.DeleteDirectory(TempDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory(TempDir)

        Dim PDFOptions As New DevExpress.XtraPrinting.PdfExportOptions
        PDFOptions.ConvertImagesToJpeg = False
        PDFOptions.DocumentOptions.Application = My.Application.Info.Title

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                Dim Report As New report_Bill(ReportData, True)

                FilePath = IO.Path.Combine(TempDir, "Bill.pdf")
                PDFOptions.DocumentOptions.Author = Bill.Sender.Name
                PDFOptions.DocumentOptions.Subject = Bill.Sender.BillHeading.Replace("|", " ")
                PDFOptions.DocumentOptions.Title = Bill.Sender.BillHeading.Split("|")(0)
                Report.ExportToPdf(FilePath, PDFOptions)
                ToAddress = Bill.Receiver.Email
                Subject = Bill.Sender.BillHeading.Replace("|", " ")
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)

                FilePath = IO.Path.Combine(TempDir, "FeesReminder.pdf")
                PDFOptions.DocumentOptions.Author = FeesReminder.Sender.Name
                PDFOptions.DocumentOptions.Subject = FeesReminder.Sender.BillHeading.Replace("|", " ")
                PDFOptions.DocumentOptions.Title = FeesReminder.Sender.BillHeading.Split("|")(0)
                Report.ExportToPdf(FilePath, PDFOptions)
                ToAddress = FeesReminder.Receiver.Email
                Subject = "Fees Reminder"
            End If
        End If

        Dim D As New frm_SendMail(FromAddressList, ToAddress, Subject, Content, False, FilePath)
        D.ShowDialog()
    End Sub

    Private Sub btn_Export_Mail_PDF_HTML_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_Mail_PDF_HTML.ItemClick
        Dim HTML As String = ""
        Dim ToAddress As String = ""
        Dim Subject As String = ""

        Dim FilePath As String = ""
        Dim TempDir As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "PDF_TEMP_" & Now.ToString("ddMMyyyy_hhmmss"))
        If My.Computer.FileSystem.DirectoryExists(TempDir) Then My.Computer.FileSystem.DeleteDirectory(TempDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory(TempDir)

        Dim HTMLOptions As New DevExpress.XtraPrinting.HtmlExportOptions
        HTMLOptions.EmbedImagesInHTML = True
        HTMLOptions.ExportMode = DevExpress.XtraPrinting.HtmlExportMode.SingleFile
        HTMLOptions.CharacterSet = "UTF-8"

        Dim PDFOptions As New DevExpress.XtraPrinting.PdfExportOptions
        PDFOptions.ConvertImagesToJpeg = False
        PDFOptions.DocumentOptions.Application = My.Application.Info.Title

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                Dim Report As New report_Bill(ReportData, True)

                FilePath = IO.Path.Combine(TempDir, "Bill.pdf")
                PDFOptions.DocumentOptions.Author = Bill.Sender.Name
                PDFOptions.DocumentOptions.Subject = Bill.Sender.BillHeading.Replace("|", " ")
                PDFOptions.DocumentOptions.Title = Bill.Sender.BillHeading.Split("|")(0)
                Report.ExportToPdf(FilePath, PDFOptions)
                Using MS As New IO.MemoryStream
                    Report.ExportToHtml(MS, HTMLOptions)
                    HTML = System.Text.Encoding.UTF8.GetString(MS.ToArray)
                End Using
                ToAddress = Bill.Receiver.Email
                Subject = Bill.Sender.BillHeading.Replace("|", " ")
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                Dim Report_HTML As report_FeesReminder_Mail = GetFeesReminderReportMail(FeesReminder)
                Dim Report_PDF As report_FeesReminder = GetFeesReminderReport(FeesReminder)

                FilePath = IO.Path.Combine(TempDir, "FeesReminder.pdf")
                PDFOptions.DocumentOptions.Author = FeesReminder.Sender.Name
                PDFOptions.DocumentOptions.Subject = FeesReminder.Sender.BillHeading.Replace("|", " ")
                PDFOptions.DocumentOptions.Title = FeesReminder.Sender.BillHeading.Split("|")(0)
                Report_PDF.ExportToPdf(FilePath, PDFOptions)
                Using MS As New IO.MemoryStream
                    Report_HTML.ExportToHtml(MS, HTMLOptions)
                    HTML = System.Text.Encoding.UTF8.GetString(MS.ToArray)
                End Using
                ToAddress = FeesReminder.Receiver.Email
                Subject = "Fees Reminder"
            End If
        End If

        Dim D As New frm_SendMail(FromAddressList, ToAddress, Subject, HTML, True, FilePath)
        D.ShowDialog()
    End Sub

    Private Sub btn_Export_PDF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_PDF.ItemClick
        dlg_Save.DefaultExt = "pdf"
        dlg_Save.Filter = "Adobe Portable Document Format (*.pdf)|*.pdf"

        Dim PDFOptions As New DevExpress.XtraPrinting.PdfExportOptions
        PDFOptions.ConvertImagesToJpeg = False
        PDFOptions.DocumentOptions.Application = My.Application.Info.Title

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                    Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                    Dim Report As New report_Bill(ReportData, True)
                    PDFOptions.DocumentOptions.Author = Bill.Sender.Name
                    PDFOptions.DocumentOptions.Subject = Bill.Sender.BillHeading.Replace("|", " ")
                    PDFOptions.DocumentOptions.Title = Bill.Sender.BillHeading.Split("|")(0)
                    Report.ExportToPdf(dlg_Save.FileName, PDFOptions)
                End If
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                    Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                    PDFOptions.DocumentOptions.Author = FeesReminder.Sender.Name
                    PDFOptions.DocumentOptions.Subject = FeesReminder.Sender.BillHeading.Replace("|", " ")
                    PDFOptions.DocumentOptions.Title = FeesReminder.Sender.BillHeading.Split("|")(0)
                    Report.ExportToPdf(dlg_Save.FileName, PDFOptions)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Export_HTML_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_HTML.ItemClick
        dlg_Save.DefaultExt = "html"
        dlg_Save.Filter = "HyperText Markup Language Files (*.html)|*.html"

        Dim HTMLOptions As New DevExpress.XtraPrinting.HtmlExportOptions
        HTMLOptions.EmbedImagesInHTML = True
        HTMLOptions.ExportMode = DevExpress.XtraPrinting.HtmlExportMode.SingleFile

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                    Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                    Dim Report As New report_Bill(ReportData, True)
                    Report.ExportToHtml(dlg_Save.FileName, HTMLOptions)
                End If
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                    Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                    Report.ExportToHtml(dlg_Save.FileName, HTMLOptions)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Export_MHTML_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_MHTML.ItemClick
        dlg_Save.DefaultExt = "mht"
        dlg_Save.Filter = "Microsoft HTML Document (*.mht)|*.mht"

        Dim MHTOptions As New DevExpress.XtraPrinting.MhtExportOptions
        MHTOptions.ExportMode = DevExpress.XtraPrinting.HtmlExportMode.SingleFile

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                    Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                    Dim Report As New report_Bill(ReportData, True)
                    Report.ExportToMht(dlg_Save.FileName, MHTOptions)
                End If
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                    Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                    Report.ExportToMht(dlg_Save.FileName, MHTOptions)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Export_Image_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_Image.ItemClick
        dlg_Save.DefaultExt = "jpeg"
        dlg_Save.Filter = "JPEG Images (*.jpeg)|*.jpeg"

        Dim ImageOptions As New DevExpress.XtraPrinting.ImageExportOptions
        ImageOptions.ExportMode = DevExpress.XtraPrinting.ImageExportMode.DifferentFiles
        ImageOptions.Format = Imaging.ImageFormat.Jpeg

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                    Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                    Dim Report As New report_Bill(ReportData, True)
                    Report.ExportToImage(dlg_Save.FileName, ImageOptions)
                End If
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                    Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                    Report.ExportToImage(dlg_Save.FileName, ImageOptions)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Export_RTF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_RTF.ItemClick
        dlg_Save.DefaultExt = "rtf"
        dlg_Save.Filter = "Rich Text Format (*.rtf)|*.rtf"

        Dim RTFOptions As New DevExpress.XtraPrinting.RtfExportOptions
        RTFOptions.ExportMode = DevExpress.XtraPrinting.RtfExportMode.SingleFilePageByPage

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                    Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                    Dim Report As New report_Bill(ReportData, True)
                    Report.ExportToRtf(dlg_Save.FileName, RTFOptions)
                End If
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                    Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                    Report.ExportToRtf(dlg_Save.FileName, RTFOptions)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Export_Word_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_Word.ItemClick
        dlg_Save.DefaultExt = "docx"
        dlg_Save.Filter = "Microsoft Open Word Document (*.docx)|*.docx"

        Dim docxOptions As New DevExpress.XtraPrinting.DocxExportOptions
        docxOptions.ExportMode = DevExpress.XtraPrinting.DocxExportMode.SingleFilePageByPage

        If tc_Main.SelectedTabPage Is tab_Bills Then
            If gv_Bills.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim Bill As Bill = gv_Bills.GetRow(gv_Bills.GetSelectedRows(0))
                    Dim ReportData As New data_Bill(Bill, Bill.Receiver, My.Computer.Keyboard.CtrlKeyDown, 18)
                    Dim Report As New report_Bill(ReportData, True)
                    docxOptions.DocumentOptions.Author = Bill.Sender.Name
                    docxOptions.DocumentOptions.Subject = Bill.Sender.BillHeading.Replace("|", " ")
                    docxOptions.DocumentOptions.Title = Bill.Sender.BillHeading.Split("|")(0)
                    Report.ExportToDocx(dlg_Save.FileName, docxOptions)
                End If
            End If
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            If gv_FeesReminders.SelectedRowsCount = 1 Then
                If dlg_Save.ShowDialog = DialogResult.OK Then
                    Dim FeesReminder As FeesReminder = gv_FeesReminders.GetRow(gv_FeesReminders.GetSelectedRows(0))
                    Dim Report As report_FeesReminder = GetFeesReminderReport(FeesReminder)
                    docxOptions.DocumentOptions.Author = FeesReminder.Sender.Name
                    docxOptions.DocumentOptions.Subject = FeesReminder.Sender.BillHeading.Replace("|", " ")
                    docxOptions.DocumentOptions.Title = FeesReminder.Sender.BillHeading.Split("|")(0)
                    Report.ExportToDocx(dlg_Save.FileName, docxOptions)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Cover"
    Private Sub btn_SmallCover_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SmallCover.ItemClick
        Dim D As New frm_Cover(SendersList, ReceiversList)
        If D.ShowDialog = DialogResult.OK Then
            Dim Report As New report_SmallCover(New data_Cover(D.Sender, D.Receiver))
            Dim Viewer As New frm_ReportViewer(Report)
            Viewer.ShowDialog()
        End If
    End Sub

    Private Sub btn_BigCover_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_BigCover.ItemClick
        Dim D As New frm_Cover(SendersList, ReceiversList)
        If D.ShowDialog = DialogResult.OK Then
            Dim Report As New report_BigCover(New data_Cover(D.Sender, D.Receiver))
            Dim Viewer As New frm_ReportViewer(Report)
            Viewer.ShowDialog()
        End If
    End Sub
#End Region
#End Region

#Region "Other Events"
    Private Sub Loader_DoWork(sender As Object, e As DoWorkEventArgs) Handles Loader.DoWork
        Invoke(Sub()
                   Ribbon.Enabled = False
                   ShowProgressOverlay()
               End Sub)

        Try
            TemplatesList = Database.BillItemTemplates.GetAll(False).ToList
        Catch ex As Exception
            MsgBox("Unable to load fees item templates." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Try
            FeesItemsList = Database.FeesItems.Load(False)
        Catch ex As Exception
            MsgBox("Unable to load fees items." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Try
            FromAddressList = Database.EMailAddresses.Load(False)
        Catch ex As Exception
            MsgBox("Unable to load e-mail addresses." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Try
            SendersList = Database.Senders.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load senders." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Try
            ReceiversList = Database.Receivers.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load receivers/Receivers." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Dim EstimateBills As New List(Of Objects.Bill)
        Try
            EstimateBills = Database.Bills.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load bills." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Dim FeesReminders As New List(Of Objects.FeesReminder)
        Try
            FeesReminders = Database.FeesReminders.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load fees reminders." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Try
            UsersList = Database.Users.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load users." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Try
            JobsList = Database.Jobs.GetAll(False)
        Catch ex As Exception
            MsgBox("Unable to load jobs." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try

        Invoke(Sub()
                   gc_Bills.DataSource = EstimateBills
                   gc_FeesReminders.DataSource = FeesReminders
                   Ribbon.Enabled = True
                   CloseProgressOverlay()
               End Sub)
    End Sub

    Private Sub tc_Main_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles tc_Main.SelectedPageChanged
        If tc_Main.SelectedTabPage Is tab_Bills Then
            rpg_Report.Text = "Bill"
        ElseIf tc_Main.SelectedTabPage Is tab_FeesReminders Then
            rpg_Report.Text = "Fees Reminder"
        End If
    End Sub

    Private Sub btn_Settings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Settings.ItemClick
        Dim D As New frm_Settings
        D.ShowDialog()
    End Sub

    Private Sub btn_Receivers_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Receivers.ItemClick
        Dim D As New frm_Receivers
        If D.ShowDialog() = DialogResult.OK Then
            If Not Loader.IsBusy Then Loader.RunWorkerAsync()
        End If
    End Sub
#End Region

End Class