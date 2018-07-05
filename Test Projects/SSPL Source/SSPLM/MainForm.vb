Imports System.Collections.Specialized
Imports System.Data.OleDb
Imports System.Threading
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Public Class MainForm
    Dim Databaseloc As String
    Dim constr As String
    Dim connOledb As OleDbConnection
    Dim cmdOledb As New OleDbCommand
    Dim Data As DataView
    Sub SetDataValues(ByVal Filename As String)
        Databaseloc = Filename
        Me.Text = "Sai Subramanian Pathology Laboratory Report Manager - " & System.IO.Path.GetFileNameWithoutExtension(Filename)
        HuraForm1.Text = Me.Text
        constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Databaseloc
        connOledb = New OleDbConnection(constr)
    End Sub
    Sub LoadAll()
        Dim cnnOLEDB As New OleDbConnection(constr)
        Const constring As String = "SELECT * FROM PatientDetails"
        Try
            Dim table = New DataTable()
            cnnOLEDB.Open()
            Using da = New OleDbDataAdapter(constring, cnnOLEDB)
                da.Fill(table)
                Data = New DataView(table)
                AllData.DataSource = New DataView(table)
                FilteredData.DataSource = New DataView(table)
                UNCSearchData.DataSource = New DataView(table)
                lbl_totalreports_Filtered.Text = Data.Count
                lbl_UNCTotal.Text = Data.Count
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Function GetFilterText() As String
        'Filters
        Dim Filters As New StringCollection
        If cb_ReportNumber.Checked Then
            Filters.Add(String.Format("[Report Number] LIKE '%{0}%'", tb_ReportNumber.Text))
        End If
        If cb_Name.Checked Then
            Filters.Add(String.Format("[Full Name] LIKE '%{0}%'", tb_Name.Text))
        End If
        If cb_Age.Checked Then
            Filters.Add(String.Format("[Age] LIKE '%{0}%'", tb_Age.Text))
        End If
        If cb_Gender.Checked Then
            Filters.Add(String.Format("[Gender] LIKE '%{0}%'", tb_Gender.Text))
        End If
        If cb_Test.Checked Then
            Filters.Add(String.Format("[Test] LIKE '%{0}%'", tb_Test.Text))
        End If
        If cb_Site.Checked Then
            Filters.Add(String.Format("[Site] LIKE '%{0}%'", tb_Site.Text))
        End If
        If cb_Address.Checked Then
            Filters.Add(String.Format("([Address Line 1] LIKE '%{0}%' OR [Address Line 2] LIKE '%{0}%' OR [City] LIKE '%{0}%' OR [State] LIKE '%{0}%' OR [Mobile] LIKE '%{0}%' OR [E Mail] LIKE '%{0}%')", tb_Address.Text))
        End If
        If cb_HospitalNumber.Checked Then
            Filters.Add(String.Format("[Hospital Number] LIKE '%{0}%'", tb_HospitalNumber.Text))
        End If
        If cb_PreviousRecord.Checked Then
            Filters.Add(String.Format("[Previous Report Number] LIKE '%{0}%'", tb_PreviousRecord.Text))
        End If
        If cb_Notes.Checked Then
            Filters.Add(String.Format("[Notes] LIKE '%{0}%'", tb_Notes.Text))
        End If
        If cb_DoctorName.Checked Then
            Filters.Add(String.Format("[Doctor Name] LIKE '%{0}%'", tb_DoctorName.Text))
        End If
        If cb_DoctorAddress.Checked Then
            Filters.Add(String.Format("[Doctor Address] LIKE '%{0}%'", tb_DoctorAddress.Text))
        End If
        If cb_Diagnostics.Checked Then
            Filters.Add(String.Format("[Diagnostics] LIKE '%{0}%'", tb_Diagnostics.Text))
        End If
        If cb_Date.Checked Then
            Filters.Add(String.Format("([Received Date] >= '{0}' and [Received Date] <= '{1}' OR [Reported Date] >= '{0}' and [Reported Date] <= '{1}')", tb_DateFrom.Text, tb_DateTo.Text))
        End If
        '
        '
        '
        Dim FilterText As String = ""
        Dim FilterType_ As String = If(FilterType.SelectedIndex = 0, " AND ", " OR ")
        If Not Filters.Count = 0 Then
            For i As Integer = 0 To Filters.Count - 1
                Dim currentfilter As String = Filters(i)
                If i = 0 Then
                    FilterText = currentfilter
                ElseIf i > 0
                    FilterText &= FilterType_ & currentfilter
                End If
            Next
            Return FilterText
        End If
        Return ("")
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Filename = "" Then
            If SelectFileForView.ShowDialog = DialogResult.OK Then
                My.Settings.Filename = SelectFileForView.Filename
                SetDataValues(My.Settings.Filename)
            Else
                End
            End If
        Else
            SetDataValues(My.Settings.Filename)
        End If
        LoadAll()
        FilterType.SelectedIndex = 0
        Dim p As New System.Drawing.Printing.PaperSize("Cover", 294, 456)
        Test_PrintCover.DefaultPageSettings.PaperSize = p
        Try
            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Settings") = False Then
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Settings")
            End If
            Dim file As String = Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath
            System.IO.File.Copy(file, Application.StartupPath & "\Settings\settings.xml", True)
        Catch ex As Exception

        End Try
    End Sub
    Function ExpandToBound(ByVal image As XSize, ByVal boundingBox As XSize) As XSize
        Dim widthScale As Double = 0
        Dim heightScale As Double = 0
        If (image.Width <> 0) Then widthScale = boundingBox.Width / image.Width
        If (image.Height <> 0) Then heightScale = boundingBox.Height / image.Height
        Dim Scale As Double = Math.Min(widthScale, heightScale)
        Dim result As New XSize((image.Width * Scale), (image.Height * Scale))
        Return result
    End Function

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If tb_Search.Text.ToLower.StartsWith("id=") Then
            Try
                Dim s As String() = Split(tb_Search.Text, "=", 2)
                UNCSearchData.DataSource.RowFilter = String.Format("[ID]={0}", CInt(s(1)))
            Catch ex As Exception

            End Try
        Else
            Try
                UNCSearchData.DataSource.RowFilter = String.Format("[Report Number] LIKE '%{0}%' OR [Full Name] LIKE '%{0}%' OR [Age] LIKE '%{0}%' OR [Gender] LIKE '%{0}%' OR [Test] LIKE '%{0}%' OR [Site] LIKE '%{0}%' OR [Address Line 1] LIKE '%{0}%' OR [Address Line 2] LIKE '%{0}%' OR [City] LIKE '%{0}%' OR [State] LIKE '%{0}%' OR [Mobile] LIKE '%{0}%' OR [E Mail] LIKE '%{0}%' OR [Hospital Number] LIKE '%{0}%' OR [Previous Report Number] Like '%{0}%' OR [Received Date] LIKE '%{0}%' OR [Reported Date] LIKE '%{0}%' OR [Notes] LIKE '%{0}%' OR [Doctor Name] LIKE '%{0}%' OR [Doctor Address] LIKE '%{0}%' OR [Diagnostics] LIKE '%{0}%'", tb_Search.Text)
            Catch ex As Exception
                Try
                    UNCSearchData.DataSource.RowFilter = String.Format("[Report Number] LIKE '%{0}%' OR [Full Name] LIKE '%{0}%' OR [Age] LIKE '%{0}%' OR [Gender] LIKE '%{0}%' OR [Test] LIKE '%{0}%' OR [Site] LIKE '%{0}%' OR [Address Line 1] LIKE '%{0}%' OR [Address Line 2] LIKE '%{0}%' OR [City] LIKE '%{0}%' OR [State] LIKE '%{0}%' OR [Mobile] LIKE '%{0}%' OR [E Mail] LIKE '%{0}%' OR [Hospital Number] LIKE '%{0}%' OR [Previous Report Number] Like '%{0}%' OR [Notes] LIKE '%{0}%' OR [Doctor Name] LIKE '%{0}%' OR [Doctor Address] LIKE '%{0}%' OR [Diagnostics] LIKE '%{0}%'", tb_Search.Text)
                Catch ex1 As Exception

                End Try
            End Try
        End If
        Try
            lbl_UNC_current.Text = CType(UNCSearchData.DataSource, DataView).Count
        Catch ex As Exception

        End Try
    End Sub

#Region "FilterEnable"
    Private Sub cb_ReportNumber_CheckedChanged(sender As Object) Handles cb_ReportNumber.CheckedChanged
        tb_ReportNumber.Enabled = cb_ReportNumber.Checked
    End Sub

    Private Sub cb_Name_CheckedChanged(sender As Object) Handles cb_Name.CheckedChanged
        tb_Name.Enabled = cb_Name.Checked
    End Sub

    Private Sub cb_Age_CheckedChanged(sender As Object) Handles cb_Age.CheckedChanged
        tb_Age.Enabled = cb_Age.Checked
    End Sub

    Private Sub cb_Gender_CheckedChanged(sender As Object) Handles cb_Gender.CheckedChanged
        tb_Gender.Enabled = cb_Gender.Checked
    End Sub

    Private Sub cb_DoctorName_CheckedChanged(sender As Object) Handles cb_DoctorName.CheckedChanged
        tb_DoctorName.Enabled = cb_DoctorName.Checked
    End Sub

    Private Sub cb_Test_CheckedChanged(sender As Object) Handles cb_Test.CheckedChanged
        tb_Test.Enabled = cb_Test.Checked
    End Sub

    Private Sub cb_Site_CheckedChanged(sender As Object) Handles cb_Site.CheckedChanged
        tb_Site.Enabled = cb_Site.Checked
    End Sub

    Private Sub cb_Address_CheckedChanged(sender As Object) Handles cb_Address.CheckedChanged
        tb_Address.Enabled = cb_Address.Checked
    End Sub

    Private Sub cb_PreviousRecord_CheckedChanged(sender As Object) Handles cb_PreviousRecord.CheckedChanged
        tb_PreviousRecord.Enabled = cb_PreviousRecord.Checked
    End Sub

    Private Sub cb_DoctorAddress_CheckedChanged(sender As Object) Handles cb_DoctorAddress.CheckedChanged
        tb_DoctorAddress.Enabled = cb_DoctorAddress.Checked
    End Sub

    Private Sub cb_Date_CheckedChanged(sender As Object) Handles cb_Date.CheckedChanged
        tb_DateFrom.Enabled = cb_Date.Checked
        tb_DateTo.Enabled = cb_Date.Checked
    End Sub

    Private Sub cb_Notes_CheckedChanged(sender As Object) Handles cb_Notes.CheckedChanged
        tb_Notes.Enabled = cb_Notes.Checked
    End Sub

    Private Sub cb_HospitalNumber_CheckedChanged(sender As Object) Handles cb_HospitalNumber.CheckedChanged
        tb_HospitalNumber.Enabled = cb_HospitalNumber.Checked
    End Sub

    Private Sub cb_Diagnostics_CheckedChanged(sender As Object) Handles cb_Diagnostics.CheckedChanged
        tb_Diagnostics.Enabled = cb_Diagnostics.Checked
    End Sub
#End Region
    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        Dim filter_ As String = GetFilterText()
        If Not filter_ = "" Then
            FilteredData.DataSource.RowFilter = filter_
            lbl_Filtered_Filtered.Text = CType(FilteredData.DataSource, DataView).Count
        End If
    End Sub

    Private Sub btn_PAT_Add_Click(sender As Object, e As EventArgs) Handles btn_PAT_Add.Click
        Dim add_dia As New AddPatient(Databaseloc)
        If add_dia.ShowDialog() = DialogResult.OK Then
            LoadAll()
        End If
    End Sub

    Private Sub btn_ResetFilter_Click(sender As Object, e As EventArgs) Handles btn_ResetFilter.Click
        Try
            FilteredData.DataSource.RowFilter = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_PAT_Edit_Click(sender As Object, e As EventArgs) Handles btn_PAT_Edit.Click
        Dim patid As Integer = GetPatientID()
        If Not patid = -1 Then
            Dim dia As New EditPatient(Databaseloc, patid)
            If dia.ShowDialog = DialogResult.OK Then
                LoadAll()
            End If
        End If
    End Sub
    Sub DeletePatientDetail(ByVal ID As Integer)
        Try
            connOledb.Open()
            Dim cmddelete As New OleDbCommand
            cmddelete.CommandText = "DELETE FROM PATIENT WHERE ID =" & ID & ";"
            cmddelete.CommandType = CommandType.Text
            cmddelete.Connection = connOledb
            cmddelete.ExecuteNonQuery()
            cmddelete.Dispose()
            connOledb.Close()
            LoadAll()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Function GetPatientID() As Integer
        Dim r As Integer = -1
        If RecordTabs.SelectedIndex = 0 Then
            If AllData.SelectedRows.Count = 1 Then
                Dim patid As Integer = AllData.SelectedRows(0).Cells(0).Value.ToString
                r = (patid)
            Else
                MsgBox("You must Select Atleast or Only One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf RecordTabs.SelectedIndex = 1 Then
            If FilteredData.SelectedRows.Count = 1 Then
                Dim patid As Integer = FilteredData.SelectedRows(0).Cells(0).Value.ToString
                r = (patid)
            Else
                MsgBox("You must Select Atleast or Only One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf RecordTabs.SelectedIndex = 2 Then
            If UNCSearchData.SelectedRows.Count = 1 Then
                Dim patid As Integer = UNCSearchData.SelectedRows(0).Cells(0).Value.ToString
                r = (patid)
            Else
                MsgBox("You must Select Atleast or Only One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        End If
        Return r
    End Function
    Function GetPatientIDs(ByVal Noth As String) As List(Of NameAndID)
        Dim l As New List(Of NameAndID)
        If RecordTabs.SelectedIndex = 0 Then
            If AllData.SelectedRows.Count > 0 Then
                For Each i As DataGridViewRow In AllData.SelectedRows
                    l.Add(New NameAndID(i.Cells(1).Value.ToString, i.Cells(0).Value))
                Next
            Else
                MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf RecordTabs.SelectedIndex = 1 Then
            If FilteredData.SelectedRows.Count > 0 Then
                For Each i As DataGridViewRow In FilteredData.SelectedRows
                    l.Add(New NameAndID(i.Cells(1).Value.ToString, i.Cells(0).Value))
                Next
            Else
                MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf RecordTabs.SelectedIndex = 2 Then
            If UNCSearchData.SelectedRows.Count > 0 Then
                For Each i As DataGridViewRow In UNCSearchData.SelectedRows
                    l.Add(New NameAndID(i.Cells(1).Value.ToString, i.Cells(0).Value))
                Next
            Else
                MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        End If
        Return l
    End Function
    Function GetPatientIDs() As List(Of Integer)
        Dim l As New List(Of Integer)
        If RecordTabs.SelectedIndex = 0 Then
            If AllData.SelectedRows.Count > 0 Then
                For Each i As DataGridViewRow In AllData.SelectedRows
                    l.Add(i.Cells(0).Value.ToString)
                Next
            Else
                MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf RecordTabs.SelectedIndex = 1 Then
            If FilteredData.SelectedRows.Count > 0 Then
                For Each i As DataGridViewRow In FilteredData.SelectedRows
                    l.Add(i.Cells(0).Value.ToString)
                Next
            Else
                MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf RecordTabs.SelectedIndex = 2 Then
            If UNCSearchData.SelectedRows.Count > 0 Then
                For Each i As DataGridViewRow In UNCSearchData.SelectedRows
                    l.Add(i.Cells(0).Value.ToString)
                Next
            Else
                MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            End If
        End If
        Return l
    End Function
    Private Sub btn_PAT_Remove_Click(sender As Object, e As EventArgs) Handles btn_PAT_Remove.Click
        Dim i As List(Of Integer) = GetPatientIDs()
        If i.Count > 0 Then
            If MsgBox("Once an item deleted you can't recover it. Are you sure to delete selected " & i.Count & " item(s)?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Make Sure...") = MsgBoxResult.Yes Then
                For Each id As Integer In i
                    DeletePatientDetail(id)
                Next
                MsgBox(i.Count & " items successfully deleted.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            End If
        End If
    End Sub

    Private Sub btn_PrintReport_Click(sender As Object, e As EventArgs) Handles btn_PrintReport.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count = 1 Then
            For Each patid As Integer In patids
                Dim pr As New SingleReport(patid, Databaseloc)
                pr.Print()
            Next
        ElseIf patids.Count > 1 Then
            If MsgBox("Do you want to print selected " & patids.Count & " records.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                For Each patid As Integer In patids
                    Dim pr As New SingleReport(patid, Databaseloc)
                    pr.Print()
                Next
            End If
        End If
    End Sub

    Private Sub btn_Sites_Edit_Click(sender As Object, e As EventArgs) Handles btn_Sites_Edit.Click
        Dim s As New Sites(Databaseloc)
        s.ShowDialog()
    End Sub

    Private Sub btn_DIAG_Edit_Click(sender As Object, e As EventArgs) Handles btn_DIAG_Edit.Click
        Dim d As New Diagnostics(Databaseloc)
        d.ShowDialog()
    End Sub

    Private Sub btn_ReportPreview_Click(sender As Object, e As EventArgs) Handles btn_ReportPreview.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count > 0 Then
            Dim pr As New SingleReport(patids(0), Databaseloc)
            pr.PrintPreview()
        End If
    End Sub


    Private Sub btn_CoverFont_Click(sender As Object, e As EventArgs) Handles btn_CoverFont.Click
        FontSettings.Font = My.Settings.CoverFont
        If FontSettings.ShowDialog = DialogResult.OK Then
            My.Settings.CoverFont = FontSettings.Font
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_DetailsFont_Click(sender As Object, e As EventArgs) Handles btn_DetailsFont.Click
        FontSettings.Font = My.Settings.DetailsFont
        If FontSettings.ShowDialog = DialogResult.OK Then
            My.Settings.DetailsFont = FontSettings.Font
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_ReportResultFont_Click(sender As Object, e As EventArgs) Handles btn_ReportResultFont.Click
        FontSettings.Font = My.Settings.ResultFont
        If FontSettings.ShowDialog = DialogResult.OK Then
            My.Settings.ResultFont = FontSettings.Font
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_ResetSettings_Click(sender As Object, e As EventArgs) Handles btn_ResetSettings.Click
        If MsgBox("Are you sure? do your want to reset all settings?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Make Sure!") = MsgBoxResult.Yes Then
            My.Settings.Reset()
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_DOC_Edit_Click(sender As Object, e As EventArgs) Handles btn_DOC_Edit.Click
        Dim doc As New Doctors(Databaseloc)
        doc.ShowDialog()
    End Sub

    Private Sub btn_PrintCover_Click(sender As Object, e As EventArgs) Handles btn_PrintCover.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count = 1 Then
            If CoverPrintDialog.ShowDialog = DialogResult.OK Then
                For Each patid As Integer In patids
                    Dim pr As New PrintCover(patid, constr, CoverPrintDialog.PrinterSettings)
                    pr.Print()
                Next
            End If
        ElseIf patids.Count > 1 Then
            If MsgBox("Do you want to print cover selected " & patids.Count & " records.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                If CoverPrintDialog.ShowDialog = DialogResult.OK Then
                    For Each patid As Integer In patids
                        Dim pr As New PrintCover(patid, constr, CoverPrintDialog.PrinterSettings)
                        pr.Print()
                    Next
                End If

            End If
        End If
    End Sub

    Private Sub btn_PreviewCover_Click(sender As Object, e As EventArgs) Handles btn_PreviewCover.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count > 0 Then
            Dim pr As New PrintCover(patids(0), constr)
            pr.PrintPreview()
        End If
    End Sub

    Private Sub btn_Settings_Click(sender As Object, e As EventArgs) Handles btn_Settings.Click
        Settings.ShowDialog()
        Try
            Dim file As String = Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath
            System.IO.File.Copy(file, Application.StartupPath & "\Settings\settings.xml", True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Mail_Click(sender As Object, e As EventArgs) Handles btn_Mail.Click
        Dim n As New Email
        n.ShowDialog()
    End Sub



    Private Sub btn_ToImage_Click(sender As Object, e As EventArgs) Handles btn_ToImage.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count = 1 Then
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                For Each patid As Integer In patids
                    Dim pr As New SingleReportImage(patid, Databaseloc)
                    pr.SaveImage(FolderBrowserDialog1.SelectedPath)
                Next
            End If
        ElseIf patids.Count > 1 Then
            If MsgBox("Do you want to print selected " & patids.Count & " records.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                    For Each patid As Integer In patids
                        Dim pr As New SingleReportImage(patid, Databaseloc)
                        pr.SaveImage(FolderBrowserDialog1.SelectedPath)
                    Next
                End If

            End If
        End If
    End Sub

    Private Sub btn_ReportMail_Click(sender As Object, e As EventArgs) Handles btn_ReportMail.Click
        Dim r As New Random
        Dim imagefolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\SSPL\img" & r.Next(1001, 9999)
        Try
            My.Computer.FileSystem.CreateDirectory(imagefolder)
        Catch ex As Exception

        End Try
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count = 1 Then
            For Each patid As Integer In patids
                Dim pr As New SingleReportImage(patid, Databaseloc)
                pr.SaveImage(imagefolder)
            Next

        ElseIf patids.Count > 1 Then
            For Each patid As Integer In patids
                Dim pr As New SingleReportImage(patid, Databaseloc)
                pr.SaveImage(imagefolder)
            Next
        End If
        Dim n As New Email(imagefolder)
        n.ShowDialog()
    End Sub

    Private Sub btn_StartNew_Click(sender As Object, e As EventArgs) Handles btn_StartNew.Click
        If MsgBox("Are you sure to start a new year?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Make Sure") = MsgBoxResult.Yes Then
            StartNewDb.ShowDialog()
        End If
    End Sub

    Private Sub btn_DuplicatePatient_Click(sender As Object, e As EventArgs) Handles btn_DuplicatePatient.Click
        Dim patid As Integer = GetPatientID()
        If Not patid = -1 Then
            Dim dia As New DuplicatePatient(Databaseloc, patid)
            If dia.ShowDialog = DialogResult.OK Then
                LoadAll()
            End If
        End If
    End Sub
    Private Sub btn_SelectYear_Click(sender As Object, e As EventArgs) Handles btn_SelectYear.Click
        If SelectFileForView.ShowDialog() = DialogResult.OK Then
            SetDataValues(SelectFileForView.Filename)
            LoadAll()
        End If
    End Sub

    Private Sub btn_ExportCD_Click(sender As Object, e As EventArgs) Handles btn_ExportCD.Click
        CDBackup.ShowDialog()
    End Sub

    Private Sub btn_ExportSettings_Click(sender As Object, e As EventArgs) Handles btn_ExportSettings.Click
        Dim file As String = Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath
        If SaveSettings.ShowDialog = DialogResult.OK Then
            System.IO.File.Copy(file, SaveSettings.FileName, True)
        End If
    End Sub

    Private Sub btn_ImportSettings_Click(sender As Object, e As EventArgs) Handles btn_ImportSettings.Click
        Dim file As String = Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath
        If OpenSettings.ShowDialog = DialogResult.OK Then
            If MsgBox("Are you sure to import settings from selected file?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                System.IO.File.Copy(OpenSettings.FileName, file, True)
            End If
        End If
    End Sub

    Private Sub btn_ExportFile_Click(sender As Object, e As EventArgs) Handles btn_ExportFile.Click
        Dim s As New SelectFileForView
        If s.ShowDialog = DialogResult.OK Then
            If SaveDBFileDialog.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(s.Filename, SaveDBFileDialog.FileName, True)
            End If
        End If
    End Sub

    Private Sub btn_ImportFile_Click(sender As Object, e As EventArgs) Handles btn_ImportFile.Click
        If OpenDBFileDialog.ShowDialog = DialogResult.OK Then
            Dim fi As New System.IO.FileInfo(OpenDBFileDialog.FileName)
            Dim targetfile As String = Application.StartupPath & "\Data\" & fi.Name
            If My.Computer.FileSystem.FileExists(targetfile) = True Then
                If MsgBox("Selected FileName Already exists in Databases Folder. Do you want to Overwrite the file?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CopyFile(OpenDBFileDialog.FileName, targetfile, True)
                End If
            Else
                My.Computer.FileSystem.CopyFile(OpenDBFileDialog.FileName, targetfile, False)
            End If
        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        End
    End Sub

    Private Sub btn_OtherStatement_Click(sender As Object, e As EventArgs) Handles btn_OtherStatement.Click
        Dim d As New Statements(Databaseloc)
        d.ShowDialog()
    End Sub

    Private Sub btn_PrintReport2_Click(sender As Object, e As EventArgs) Handles btn_PrintReport2.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count = 1 Then
            If ReportPrintDialog.ShowDialog = DialogResult.OK Then
                For Each patid As Integer In patids
                    Dim pr As New SingleReportL2(patid, Databaseloc, ReportPrintDialog.PrinterSettings)
                    pr.Print()
                Next
            End If
        ElseIf patids.Count > 1 Then
            If MsgBox("Do you want to print selected " & patids.Count & " records.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                If ReportPrintDialog.ShowDialog = DialogResult.OK Then
                    For Each patid As Integer In patids
                        Dim pr As New SingleReportL2(patid, Databaseloc, ReportPrintDialog.PrinterSettings)
                        pr.Print()
                    Next
                End If

            End If
        End If
    End Sub

    Private Sub btn_PreviewReportL2_Click(sender As Object, e As EventArgs) Handles btn_PreviewReportL2.Click
        Dim patids As List(Of Integer) = GetPatientIDs()
        If patids.Count > 0 Then
            Dim pr As New SingleReportL2(patids(0), Databaseloc)
            pr.PrintPreview()
        End If
    End Sub

    Private Sub btn_History_Click(sender As Object, e As EventArgs) Handles btn_History.Click
        Dim patid As Integer = GetPatientID()
        If Not patid = -1 Then
            Dim dia As New RecordHistory(patid, Databaseloc)
            dia.ShowDialog()
        End If
    End Sub

    Private Sub btn_ReportMailPdf_Click(sender As Object, e As EventArgs) Handles btn_ReportMailPdf.Click
        Dim r As New Random
        Dim pdffolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\SSPL\pdf" & r.Next(1001, 9999)
        Try
            My.Computer.FileSystem.CreateDirectory(pdffolder)
        Catch ex As Exception

        End Try
        Dim patids As List(Of NameAndID) = GetPatientIDs("")
        If patids.Count = 1 Then
            For Each patid As NameAndID In patids
                Dim imagefolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\SSPL\img" & r.Next(1001, 9999)
                Try
                    My.Computer.FileSystem.CreateDirectory(imagefolder)
                Catch ex As Exception

                End Try
                Dim pr As New SingleReportImage(patid.ID, Databaseloc)
                pr.SaveImage(imagefolder)
                Dim document As PdfDocument = New PdfDocument
                document.Info.Title = "Report"
                For Each i As String In My.Computer.FileSystem.GetFiles(imagefolder, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
                    Dim img As XImage = XImage.FromFile(i)
                    ' Create an empty page
                    Dim page As PdfPage = document.AddPage

                    ' Get an XGraphics object for drawing
                    Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                    Dim per As Double = (img.PointWidth / page.Width.Point)
                    Dim height As Double = img.PointHeight * (per)
                    gfx.DrawImage(img, New XRect(ExpandToBound(img.Size, New XSize(page.Width.Point, page.Height.Point))))
                    ' Draw crossing lines
                Next
                ' Save the document...
                Dim filename As String = pdffolder & "\Report_" & patid.Name & ".pdf"
                document.Save(filename)
            Next
        ElseIf patids.Count > 1 Then
            For Each patid As NameAndID In patids
                Dim imagefolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\SSPL\img" & r.Next(1001, 9999)
                Try
                    My.Computer.FileSystem.CreateDirectory(imagefolder)
                Catch ex As Exception

                End Try
                Dim pr As New SingleReportImage(patid.ID, Databaseloc)
                pr.SaveImage(imagefolder)
                Dim document As PdfDocument = New PdfDocument
                document.Info.Title = "Report"
                For Each i As String In My.Computer.FileSystem.GetFiles(imagefolder, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
                    Dim img As XImage = XImage.FromFile(i)
                    ' Create an empty page
                    Dim page As PdfPage = document.AddPage

                    ' Get an XGraphics object for drawing
                    Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                    Dim per As Double = (img.PointWidth / page.Width.Point)
                    Dim height As Double = img.PointHeight * (per)
                    gfx.DrawImage(img, New XRect(ExpandToBound(img.Size, New XSize(page.Width.Point, page.Height.Point))))
                    ' Draw crossing lines
                Next
                ' Save the document...
                Dim filename As String = pdffolder & "\Report_" & patid.Name & ".pdf"
                document.Save(filename)
            Next

        End If
        Dim n As New Email(pdffolder)
        n.ShowDialog()

        ' ...and start a viewer.
    End Sub
End Class
Public Class NameAndID
    Property Name As String
    Property ID As Integer
    Sub New(ByVal Name As String, ByVal ID As Integer)
        Me.Name = Name.Replace("/", "-").Replace("\", "-").Trim
        Me.ID = ID
    End Sub
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class