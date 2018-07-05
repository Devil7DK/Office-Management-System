Imports Word = Microsoft.Office.Interop.Word
Imports System.Data.OleDb

Public Class frm_Main
    Dim constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\ClientData.mdb"
    Dim conOLEDB As OleDbConnection
    Sub LoadData()
        Dim cnnOLEDB As New OleDbConnection(constr)
        conOLEDB = cnnOLEDB
        Const constring As String = "SELECT * FROM Data"
        Try
            Dim table = New DataTable()
            cnnOLEDB.Open()
            Using da = New OleDbDataAdapter(constring, cnnOLEDB)
                da.Fill(table)
                Dim Data As New DataView(table)
                txt_filterby.Items.Clear()
                For Each i As DataColumn In table.Columns
                    txt_filterby.Items.Add(i.ColumnName)
                Next
                AllData.DataSource = New DataView(table)
                lbl_count1.Text = "Total Items Count : " & Data.Count
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            cnnOLEDB.Close()
        Catch ex As Exception

        End Try
        Try
            txt_filterby.SelectedIndex = 1
        Catch ex As Exception

        End Try
        Try
            If btn_Cancel.Visible = True Then
                HuraTabControl1.Enabled = True
                DisableTextBoxes()
                lbl_status.Text = ""
                SetDetails()
                AllData.Focus()
                cb_Recursive.Visible = False
                btn_Done.Visible = False
                btn_Cancel.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub Replace(ByVal oDoc As Word.Document, ByVal Find As String, ByVal Replace As String, Optional SearchTextBoxes As Boolean = False)
        oDoc.Content.Find.Execute(FindText:=Find, ReplaceWith:=Replace, Replace:=Word.WdReplace.wdReplaceAll)
        Try
            If SearchTextBoxes = True Then
                For Each i As Word.Shape In oDoc.Shapes
                    i.TextFrame.TextRange.Text = i.TextFrame.TextRange.Text.Replace(Find, Replace).Trim
                Next
            End If
        Catch ex As Exception

        End Try
        For Each i As Word.Section In oDoc.Sections
            For Each i1 As Word.HeaderFooter In i.Headers
                For Each i2 As Word.Table In i1.Range.Tables
                    For Each i3 As Word.Row In i2.Rows
                        For Each i4 As Word.Cell In i3.Cells
                            If i4.Range.Text.Contains("<<") AndAlso i4.Range.Text.Contains(">>") Then
                                If i4.Range.Text.Contains(Find) Then
                                    i4.Range.Text = Replace.Trim
                                End If
                            End If
                        Next
                    Next
                Next
            Next
        Next
    End Sub
    Sub PrintDocument(ByVal Filename As String, ByVal isPDF As Boolean, ByVal FolderName As String, ByVal PropName As String)
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        oWord = CreateObject("Word.Application")
        oWord.Visible = False
        oWord.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone 'stop alerts 
        oDoc = oWord.Documents.Open(Filename, False, True, False)
        Threading.Thread.Sleep(5000)
        If isPDF = True Then
            oWord.ActivePrinter = My.Settings.PDFPrinter
            oDoc.PrintOut(True, , Word.WdPrintOutRange.wdPrintAllDocument, IO.Path.Combine(FolderName, "44AB - Appointment & Certificates - FY " & My.Settings.FinancialYear & " " & PropName & "_" & (New Random).Next(0, 1000) & ".pdf"), _
                                      , , Word.WdPrintOutItem.wdPrintDocumentContent, 1, "", Word.WdPrintOutPages.wdPrintAllPages, _
                                       False, True, , False, 0, 0, 0, 0) 'Print parameters 
        Else
            oDoc.PrintOut(False, , Word.WdPrintOutRange.wdPrintAllDocument, , _
                                     , , Word.WdPrintOutItem.wdPrintDocumentContent, 1, "", Word.WdPrintOutPages.wdPrintAllPages, _
                                      False, True, , False, 0, 0, 0, 0) 'Print parameters 
        End If
        oDoc.Close(SaveChanges:=False)
        oWord.Quit(SaveChanges:=False)
    End Sub
    Sub GenerateNew(ByVal PropName As String, ByVal CompName As String, ByVal PAN As String, ByVal TypeOfConcern As String, ByVal Add1 As String, ByVal Add2 As String, ByVal Add3 As String, ByVal Partners As String, ByVal StartingDate As Date, ByVal CertificateDate As Date, ByVal Salesofgoods As Boolean, ByVal ProvisionofServices As Boolean, ByVal OtherIncome As Boolean, ByVal OtherIncomeDetails As String, ByVal Opt As Options, ByVal FolderName As String)
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = False
        oWord.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone 'stop alerts 
        oDoc = oWord.Documents.Open(CType(cb_Template.SelectedItem, TemplateDetails).Filename, False, True, False)
        Replace(oDoc, "<<Financial Year>>", My.Settings.FinancialYear)
        Replace(oDoc, "<<Assessment>>", My.Settings.AssessmentYear, True)
        Replace(oDoc, "<<Proprietor Title>>", If(TypeOfConcern = "Proprietorship Firm", PropName, ""))
        Replace(oDoc, "<<Company>>", CompName)
        Replace(oDoc, "<<Address Short>>", Add1 & vbNewLine & Add2 & vbNewLine & Add3)
        Replace(oDoc, "<<Short Address>>", Add1 & vbNewLine & Add2 & vbNewLine & Add3, True)
        Replace(oDoc, "<<Long Address>>", If(TypeOfConcern = "Proprietorship Firm", PropName & "," & vbNewLine, "") & CompName & "," & vbNewLine & Add1 & vbNewLine & Add2 & vbNewLine & Add3)
        Replace(oDoc, "<<Title>>", My.Settings.Title)
        Replace(oDoc, "<<Abstract>>", My.Settings.Abstract)
        Replace(oDoc, "<<People Heading>>", If(TypeOfConcern = "Proprietorship Firm", "", If(TypeOfConcern = "Partnership Firm", "Partners:", If(TypeOfConcern = "Private Limited Company", "Directors:", ""))))
        Replace(oDoc, "<<Partners>>", Partners)
        Replace(oDoc, "<<C1>>", If(TypeOfConcern = "Proprietorship Firm", "I am", If(TypeOfConcern = "Partnership Firm", "We are", If(TypeOfConcern = "Private Limited Company", "We are", ""))))
        Replace(oDoc, "<<C2>>", If(TypeOfConcern = "Proprietorship Firm", "my", If(TypeOfConcern = "Partnership Firm", "our", If(TypeOfConcern = "Private Limited Company", "our", ""))))
        Replace(oDoc, "<<Person Title>>", If(TypeOfConcern = "Proprietorship Firm", "Proprietor", If(TypeOfConcern = "Partnership Firm", "Partner", If(TypeOfConcern = "Private Limited Company", "Director", ""))))
        Replace(oDoc, "<<Certificate Title>>", If(TypeOfConcern = "Proprietorship Firm", "proprietor", If(TypeOfConcern = "Partnership Firm", "partner", If(TypeOfConcern = "Private Limited Company", "director", ""))))
        Replace(oDoc, "<<Certificate Comp Type>>", If(TypeOfConcern = "Proprietorship Firm", "the Firm", If(TypeOfConcern = "Partnership Firm", "the Firm", If(TypeOfConcern = "Private Limited Company", "the Company", ""))))
        Replace(oDoc, "<<Certificate Comp Type2>>", If(TypeOfConcern = "Proprietorship Firm", "", If(TypeOfConcern = "Partnership Firm", My.Resources.Quot & "the Firm" & My.Resources.Quot, If(TypeOfConcern = "Private Limited Company", My.Resources.Quot & "the Company" & My.Resources.Quot, ""))))
        Replace(oDoc, "<<CLine1>>", If(TypeOfConcern = "Proprietorship Firm", "", If(TypeOfConcern = "Partnership Firm", "for and on behalf of the Firm, " & My.Resources.Quot, If(TypeOfConcern = "Private Limited Company", My.Resources.Quot & "for and on behalf of the Company, " & My.Resources.Quot, ""))))
        Replace(oDoc, "<<Assessee Name>>", If(TypeOfConcern = "Proprietorship Firm", PropName & vbNewLine & CompName, If(TypeOfConcern = "Partnership Firm", CompName, If(TypeOfConcern = "Private Limited Company", CompName, ""))), True)
        Replace(oDoc, "<<Year ending>>", My.Settings.YearEnding, True)
        Replace(oDoc, "<<Type of concern>>", TypeOfConcern, True)
        Replace(oDoc, "<<PAN>>", PAN, True)
        Replace(oDoc, "<<D1>>", StartingDate.ToString("dd-MM-yyyy"))
        Dim d2 As Date = StartingDate.AddDays((New Random).Next(3, 5))
        Replace(oDoc, "<<D2>>", If(d2.DayOfWeek = DayOfWeek.Sunday, d2.AddDays(1), d2).ToString("dd-MM-yyyy"))
        Dim d3 As Date = StartingDate.AddDays((New Random).Next(6, 8))
        Replace(oDoc, "<<D3>>", If(d3.DayOfWeek = DayOfWeek.Sunday, d3.AddDays(1), d3).ToString("dd-MM-yyyy"))
        Replace(oDoc, "<<DC>>", CertificateDate.ToString("dd-MM-yyyy"))
        Replace(oDoc, "<<Revenue Recognition>>", getRevenueDet(Salesofgoods, ProvisionofServices))
        Replace(oDoc, "<<Other Income Details>>", If(OtherIncome = True, vbNewLine & vbNewLine & OtherIncomeDetails, ""))
        If Opt = Options.Save Then
            oDoc.SaveAs(IO.Path.Combine(FolderName, "44AB - Appointment & Certificates - FY " & My.Settings.FinancialYear & " " & PropName & "_" & (New Random).Next(0, 1000) & ".docx"))
        ElseIf Opt = Options.Print Then
            oWord.Visible = True
            Dim fn As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp" & (New Random).Next(0, 10000) & ".docx")
            oDoc.SaveAs(fn)
            oDoc.Close()
            PrintDocument(fn, False, FolderName, PropName)
        ElseIf Opt = Options.PDF Then
            Dim fn As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp" & (New Random).Next(0, 10000) & ".docx")
            oDoc.SaveAs(fn)
            oDoc.Close()
            PrintDocument(fn, True, FolderName, PropName)
        End If
        Try
            oDoc.Close()
        Catch ex As Exception

        End Try
        oWord.Quit()
    End Sub
    Function getRevenueDet(ByVal SalesOfGoods As Boolean, ByVal ProvisonofSevices As Boolean) As String
        Dim r As String = ""
        Dim l As New List(Of String)
        If SalesOfGoods = True Then
            l.Add("sale of goods")
        End If
        If ProvisonofSevices = True Then
            l.Add("provision of services")
        End If
        If l.Count = 1 Then
            r = l(0)
        ElseIf l.Count = 2 Then
            r = l(0) & " & " & l(1)
        End If
        Return r & "."
    End Function

    Private Sub frm_Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.E Then
            btn_Edit_Click(Nothing, Nothing)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.N Then
            btn_AddNew_Click(Nothing, Nothing)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.P Then
            btn_Print_Click(Nothing, Nothing)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.W Then
            btn_Word_Click(Nothing, Nothing)
        ElseIf e.Alt = True AndAlso e.KeyCode = Keys.P Then
            btn_PDF_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadData()
        For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchAllSubDirectories, "*.docx")
            cb_Template.Items.Add(New TemplateDetails(i))
        Next
        txt_Assessment.Text = My.Settings.AssessmentYear
        txt_Abstract.Text = My.Settings.Abstract
        txt_Financial.Text = My.Settings.FinancialYear
        txt_PDFPrinter.Text = My.Settings.PDFPrinter
        txt_Title.Text = My.Settings.Title
        txt_YearEnding.Text = My.Settings.YearEnding
        DisableTextBoxes()
        cb_Template.SelectedIndex = 0
        Me.KeyPreview = True
    End Sub

    Function GetAllContentControls(ByVal wordDocument As Word.Document) As List(Of Word.ContentControl)
        If wordDocument Is Nothing Then
            Throw New ArgumentNullException("wordDocument")
        End If
        Dim ccList As New List(Of Word.ContentControl)
        Dim rangeStory As Word.Range
        For Each range As Word.Range In wordDocument.StoryRanges
            rangeStory = range
            Do
                Try
                    For Each cc As Word.ContentControl In rangeStory.ContentControls
                        ccList.Add(cc)
                    Next
                Catch ex As Exception

                End Try
                rangeStory = rangeStory.NextStoryRange
            Loop While (rangeStory IsNot Nothing)
        Next
        Return ccList
    End Function


    Private Sub btn_SaveSettings_Click(sender As System.Object, e As System.EventArgs) Handles btn_SaveSettings.Click
        My.Settings.Save()
    End Sub

    Private Sub txt_Assessment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Assessment.TextChanged
        My.Settings.AssessmentYear = txt_Assessment.Text
    End Sub
    Sub DisableTextBoxes()
        txt_CompName.ReadOnly = True
        txt_PropName.ReadOnly = True
        txt_PAN.ReadOnly = True
        txt_TypeOfConcern.Enabled = False
        txt_Add1.ReadOnly = True
        txt_Add2.ReadOnly = True
        txt_Add3.ReadOnly = True
        txt_Partners.ReadOnly = True
        txt_Date.Enabled = False
        txt_CertificateDate.Enabled = False
        cb_SaleOfGoods.Enabled = False
        cb_ProvisionofServices.Enabled = False
        cb_OtherIncome.Enabled = False
        txt_OtherIncome.ReadOnly = True
    End Sub
    Sub EnableTextBoxes()
        txt_CompName.ReadOnly = False
        txt_PropName.ReadOnly = False
        txt_PAN.ReadOnly = False
        txt_TypeOfConcern.Enabled = True
        txt_Add1.ReadOnly = False
        txt_Add2.ReadOnly = False
        txt_Add3.ReadOnly = False
        txt_Partners.ReadOnly = False
        txt_Date.Enabled = True
        txt_CertificateDate.Enabled = True
        cb_SaleOfGoods.Enabled = True
        cb_ProvisionofServices.Enabled = True
        cb_OtherIncome.Enabled = True
        txt_OtherIncome.ReadOnly = False
    End Sub
    Private Sub btn_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddNew.Click
        lbl_status.Text = "Status : Add New"
        HuraTabControl1.Enabled = False
        txt_ID.Text = "(New)"
        txt_CompName.Text = ""
        txt_PropName.Text = ""
        txt_PAN.Text = ""
        txt_TypeOfConcern.Text = ""
        txt_Add1.Text = ""
        txt_Add2.Text = ""
        txt_Add3.Text = ""
        txt_Partners.Text = ""
        cb_Recursive.Visible = True
        EnableTextBoxes()
        btn_Done.Visible = True
        btn_Cancel.Visible = True
        txt_PropName.Focus()
    End Sub


    Private Sub txt_Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CompName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PAN.Focus()
        End If
    End Sub

    Private Sub txt_PAN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PAN.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_TypeOfConcern.Focus()
        End If
    End Sub

    Private Sub txt_TypeOfConcern_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TypeOfConcern.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Add1.Focus()
        End If
    End Sub

    Private Sub txt_Add1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Add1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Add2.Focus()
        End If
    End Sub

    Private Sub txt_Add2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Add2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Add3.Focus()
        End If
    End Sub

    Private Sub txt_Add3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Add3.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Date.Focus()
        End If
    End Sub
    Dim isenter As Boolean = False
    Dim isenter2 As Boolean = False
    Private Sub txt_Partners_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Partners.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.Enter Then
            isenter = True
            cb_SaleOfGoods.Focus()
        End If
    End Sub
    Public Shared Function WithQuot(ByVal Text As String) As String
        Return (My.Resources.Quot & Text.Replace(My.Resources.Quot, "''") & My.Resources.Quot)
    End Function
    Function GetDetails() As Object()
        Dim ro As New Object()
        Dim List_ As New List(Of Object)
        List_.Add(WithQuot(txt_PropName.Text.Trim))
        List_.Add(WithQuot(txt_CompName.Text.Trim))
        List_.Add(WithQuot(txt_PAN.Text.Trim))
        List_.Add(WithQuot(txt_TypeOfConcern.Text.Trim))
        List_.Add(WithQuot(txt_Add1.Text.Trim))
        List_.Add(WithQuot(txt_Add2.Text.Trim))
        List_.Add(WithQuot(txt_Add3.Text.Trim))
        List_.Add(WithQuot(txt_Partners.Text.Trim))
        List_.Add(WithQuot(txt_Date.Text.Trim))
        List_.Add(WithQuot(txt_CertificateDate.Text.Trim))
        List_.Add(WithQuot(CInt(cb_SaleOfGoods.Checked)))
        List_.Add(WithQuot(CInt(cb_ProvisionofServices.Checked)))
        List_.Add(WithQuot(CInt(cb_OtherIncome.Checked)))
        List_.Add(WithQuot(txt_OtherIncome.Text.Trim))
        Return List_.ToArray
    End Function
    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Dim cmdOLEDB As New OleDbCommand
        If lbl_status.Text = "Status : Add New" Then
            Try
                Try
                    conOLEDB.Open()
                Catch ex As Exception

                End Try

                Dim Objects As Object() = GetDetails()
                cmdOLEDB.CommandText = String.Format("INSERT INTO Data ([PropName],[CompName],[PAN],[ConcernType],[Add1],[Add2],[Add3],[Partners],[LetterDate],[CertificateDate],[SOG],[POS],[OI],[OtherIncome]) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13});", Objects)
                cmdOLEDB.Connection = conOLEDB
                cmdOLEDB.ExecuteNonQuery()
                cmdOLEDB.Dispose()
                conOLEDB.Close()
                MsgBox("Details Successfully Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done :-)")
                LoadData()
                DisableTextBoxes()
                lbl_status.Text = ""
                HuraTabControl1.Enabled = True
                AllData.Focus()
                SetDetails()
                btn_Done.Visible = False
                btn_Cancel.Visible = False
                cb_Recursive.Visible = False
                If cb_Recursive.Checked Then
                    btn_AddNew_Click(Nothing, Nothing)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
            Try
                conOLEDB.Close()
            Catch ex As Exception

            End Try
        ElseIf lbl_status.Text = "Status : Edit" Then
            Try
                Try
                    conOLEDB.Open()
                Catch ex As Exception

                End Try
                Dim Objects As Object() = GetDetails()
                cmdOLEDB.CommandText = String.Format("UPDATE Data SET [PropName]={0},[CompName]={1},[PAN]={2},[ConcernType]={3},[Add1]={4},[Add2]={5},[Add3]={6},[Partners]={7},[LetterDate]={8},[CertificateDate]={9},[SOG]={10},[POS]={11},[OI]={12},[OtherIncome]={13} WHERE [ID]=" & CInt(txt_ID.Text) & ";", Objects)
                cmdOLEDB.Connection = conOLEDB
                cmdOLEDB.ExecuteNonQuery()
                cmdOLEDB.Dispose()
                conOLEDB.Close()
                MsgBox("Details Successfully Edited!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done :-)")
                LoadData()
                HuraTabControl1.Enabled = True
                DisableTextBoxes()
                lbl_status.Text = ""
                AllData.Focus()
                SetDetails()
                btn_Done.Visible = False
                btn_Cancel.Visible = False
                cb_Recursive.Visible = False
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
            Try
                conOLEDB.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub SetDetails(ByVal dat As DataGridViewRow)
        Try
            txt_ID.Text = dat.Cells(0).Value.ToString
            txt_CompName.Text = dat.Cells(2).Value.ToString
            txt_PropName.Text = dat.Cells(1).Value.ToString
            txt_PAN.Text = dat.Cells(3).Value.ToString
            txt_TypeOfConcern.Text = dat.Cells(4).Value.ToString
            txt_Add1.Text = dat.Cells(5).Value.ToString
            txt_Add2.Text = dat.Cells(6).Value.ToString
            txt_Add3.Text = dat.Cells(7).Value.ToString
            txt_Partners.Text = dat.Cells(8).Value.ToString
            txt_Date.Text = dat.Cells(9).Value.ToString
            txt_CertificateDate.Text = dat.Cells(10).Value.ToString
            cb_SaleOfGoods.Checked = CType(dat.Cells(11).Value.ToString, Boolean)
            cb_ProvisionofServices.Checked = CType(dat.Cells(12).Value.ToString, Boolean)
            cb_OtherIncome.Checked = CType(dat.Cells(13).Value.ToString, Boolean)
            txt_OtherIncome.Text = dat.Cells(14).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Sub SetDetails()
        Try
            Dim dat As DataGridViewRow = AllData.SelectedRows(0)
            txt_ID.Text = dat.Cells(0).Value.ToString
            txt_CompName.Text = dat.Cells(2).Value.ToString
            txt_PropName.Text = dat.Cells(1).Value.ToString
            txt_PAN.Text = dat.Cells(3).Value.ToString
            txt_TypeOfConcern.Text = dat.Cells(4).Value.ToString
            txt_Add1.Text = dat.Cells(5).Value.ToString
            txt_Add2.Text = dat.Cells(6).Value.ToString
            txt_Add3.Text = dat.Cells(7).Value.ToString
            txt_Partners.Text = dat.Cells(8).Value.ToString
            txt_Date.Text = dat.Cells(9).Value.ToString
            txt_CertificateDate.Text = dat.Cells(10).Value.ToString
            cb_SaleOfGoods.Checked = CType(dat.Cells(11).Value.ToString, Boolean)
            cb_ProvisionofServices.Checked = CType(dat.Cells(12).Value.ToString, Boolean)
            cb_OtherIncome.Checked = CType(dat.Cells(13).Value.ToString, Boolean)
            txt_OtherIncome.Text = dat.Cells(14).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_Partners_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Partners.KeyPress
        If isenter = True Then
            e.Handled = True
            isenter = False
        End If
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        HuraTabControl1.Enabled = True
        DisableTextBoxes()
        lbl_status.Text = ""
        SetDetails()
        AllData.Focus()
        cb_Recursive.Visible = False
        btn_Done.Visible = False
        btn_Cancel.Visible = False
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If AllData.SelectedRows.Count = 1 Then
            Dim dat As DataGridViewRow = AllData.SelectedRows(0)
            HuraTabControl1.Enabled = False
            cb_Recursive.Visible = False
            lbl_status.Text = "Status : Edit"
            SetDetails(dat)
            EnableTextBoxes()
            btn_Done.Visible = True
            btn_Cancel.Visible = True
            txt_PropName.Focus()
        End If
    End Sub
    Function GetIDs() As List(Of Integer)
        Dim l As New List(Of Integer)
        If AllData.SelectedRows.Count > 0 Then
            For Each i As DataGridViewRow In AllData.SelectedRows
                l.Add(i.Cells(0).Value.ToString)
            Next
        Else
            MsgBox("You must Select Atleast One Item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
        End If
        Return l
    End Function
    Sub DeleteDetail(ByVal ID As Integer)
        Try
            conOLEDB.Open()
            Dim cmddelete As New OleDbCommand
            cmddelete.CommandText = "DELETE FROM Data WHERE ID =" & ID & ";"
            cmddelete.CommandType = CommandType.Text
            cmddelete.Connection = conOLEDB
            cmddelete.ExecuteNonQuery()
            cmddelete.Dispose()
            conOLEDB.Close()
            LoadData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
        Try
            conOLEDB.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_Delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_Delete.Click
        Dim i As List(Of Integer) = GetIDs()
        If i.Count > 0 Then
            If MsgBox("Once an item deleted you can't recover it. Are you sure to delete selected " & i.Count & " item(s)?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Make Sure...") = MsgBoxResult.Yes Then
                For Each id As Integer In i
                    DeleteDetail(id)
                Next
                MsgBox(i.Count & " items successfully deleted.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            End If
        End If
    End Sub

    Private Sub btn_Compact_Click(sender As System.Object, e As System.EventArgs) Handles btn_Compact.Click
        Try
            If MsgBox("Compacting may take some time! Do you wan't to 'Compact & Repair' Database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
                Dim d As New DAO.DBEngine
                Try
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\temp.mdb")
                Catch ex As Exception

                End Try
                d.CompactDatabase(Application.StartupPath & "\ClientData.mdb", Application.StartupPath & "\temp.mdb")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ClientData.mdb")
                My.Computer.FileSystem.RenameFile(Application.StartupPath & "\temp.mdb", "ClientData.mdb")
                MsgBox("Database successfully compacted and repaired.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub txt_PropName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PropName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CompName.Focus()
        End If
    End Sub

    Private Sub txt_Date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Date.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CertificateDate.Focus()
        End If
    End Sub
    Enum Options
        Save
        Print
        PDF
    End Enum

    Private Sub txt_YearEnding_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_YearEnding.TextChanged
        My.Settings.YearEnding = txt_YearEnding.Text
    End Sub

    Private Sub txt_Abstract_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Abstract.TextChanged
        My.Settings.Abstract = txt_Abstract.Text
    End Sub

    Private Sub txt_Title_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Title.TextChanged
        My.Settings.Title = txt_Title.Text
    End Sub

    Private Sub txt_Financial_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Financial.TextChanged
        My.Settings.FinancialYear = txt_Financial.Text
    End Sub

    Private Sub txt_PDFPrinter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_PDFPrinter.TextChanged
        My.Settings.PDFPrinter = txt_PDFPrinter.Text
    End Sub

    Private Sub btn_AddSelected_Click(sender As System.Object, e As System.EventArgs) Handles btn_AddSelected.Click
        If AllData.SelectedRows.Count > 0 Then
            Dim l As New List(Of Integer)
            For Each i As ListViewItem In ListView1.Items
                Try
                    l.Add(CInt(i.Text))
                Catch ex As Exception

                End Try
            Next
            For Each i As DataGridViewRow In AllData.SelectedRows
                Try
                    If l.Contains(CInt(i.Cells(0).Value)) = False Then
                        Dim li As ListViewItem = ListView1.Items.Add(i.Cells(0).Value.ToString)
                        li.SubItems.Add(i.Cells(1).Value.ToString)
                        li.SubItems.Add(i.Cells(2).Value.ToString)
                    End If
                Catch ex As Exception

                End Try
            Next
        End If
    End Sub

    Private Sub BackgroundWorker_Print_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Print.DoWork
        Progress.Visible = True
        Dim max As Integer = ListView1.CheckedItems.Count
        For i As Integer = 0 To ListView1.CheckedItems.Count - 1
            Dim li As ListViewItem = ListView1.CheckedItems(i)
            Try
                conOLEDB.Open()
            Catch ex As Exception

            End Try
            Dim cmdOLEDB As New OleDbCommand
            Try
                cmdOLEDB.Connection = conOLEDB
                cmdOLEDB.CommandText = "SELECT * FROM Data WHERE ID=" & CInt(li.Text)
                cmdOLEDB.CommandType = CommandType.Text
                Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
                If rdrOLEDB.Read = True Then
                    'Do While rdrOLEDB.Read
                    Dim PropName, CompName, PAN, ConcernType, Add1, Add2, Add3, Partners, LetterDate, CertificateDate, OtherIncomeDetails As String
                    Dim SOG As Boolean = False
                    Dim POS As Boolean = False
                    Dim OI As Boolean = False
                    PropName = rdrOLEDB.Item("PropName").ToString
                    CompName = rdrOLEDB.Item("CompName").ToString
                    PAN = rdrOLEDB.Item("PAN").ToString
                    ConcernType = rdrOLEDB.Item("ConcernType").ToString
                    Add1 = rdrOLEDB.Item("Add1").ToString
                    Add2 = rdrOLEDB.Item("Add2").ToString
                    Add3 = rdrOLEDB.Item("Add3").ToString
                    Partners = rdrOLEDB.Item("Partners").ToString
                    LetterDate = rdrOLEDB.Item("LetterDate").ToString
                    CertificateDate = rdrOLEDB.Item("CertificateDate").ToString
                    SOG = CInt(rdrOLEDB.Item("SOG"))
                    POS = CInt(rdrOLEDB.Item("POS"))
                    OI = CInt(rdrOLEDB.Item("OI"))
                    OtherIncomeDetails = rdrOLEDB.Item("OtherIncome").ToString
                    GenerateNew(PropName, CompName, PAN, ConcernType, Add1, Add2, Add3, Partners, LetterDate, CertificateDate, SOG, POS, OI, OtherIncomeDetails, Options.Print, "")
                    rdrOLEDB.Close()
                    'Loop
                Else
                    rdrOLEDB.Close()
                    MsgBox("Record not found")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                conOLEDB.Close()
            Catch ex As Exception

            End Try
            Progress.Value = ((i + 1) / max) * 100
        Next
        Progress.Visible = False
        HuraTabControl1.Enabled = True
        MsgBox("Done.", MsgBoxStyle.Information, "Done.")
    End Sub

    Private Sub AllData_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles AllData.CellMouseDoubleClick
        btn_AddSelected_Click(Nothing, Nothing)
    End Sub


    Private Sub BackgroundWorker_Word_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Word.DoWork
        Progress.Visible = True
        Dim max As Integer = ListView1.CheckedItems.Count
        For i As Integer = 0 To ListView1.CheckedItems.Count - 1
            Dim li As ListViewItem = ListView1.CheckedItems(i)
            Try
                conOLEDB.Close()
            Catch ex As Exception

            End Try
            conOLEDB.Open()
            Dim cmdOLEDB As New OleDbCommand
            Try
                cmdOLEDB.Connection = conOLEDB
                cmdOLEDB.CommandText = "SELECT * FROM Data WHERE ID=" & CInt(li.Text)
                cmdOLEDB.CommandType = CommandType.Text
                Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
                If rdrOLEDB.Read = True Then
                    'Do While rdrOLEDB.Read
                    Dim PropName, CompName, PAN, ConcernType, Add1, Add2, Add3, Partners, LetterDate, CertificateDate, OtherIncomeDetails As String
                    Dim SOG As Boolean = False
                    Dim POS As Boolean = False
                    Dim OI As Boolean = False
                    PropName = rdrOLEDB.Item("PropName").ToString
                    CompName = rdrOLEDB.Item("CompName").ToString
                    PAN = rdrOLEDB.Item("PAN").ToString
                    ConcernType = rdrOLEDB.Item("ConcernType").ToString
                    Add1 = rdrOLEDB.Item("Add1").ToString
                    Add2 = rdrOLEDB.Item("Add2").ToString
                    Add3 = rdrOLEDB.Item("Add3").ToString
                    Partners = rdrOLEDB.Item("Partners").ToString
                    LetterDate = rdrOLEDB.Item("LetterDate").ToString
                    CertificateDate = rdrOLEDB.Item("CertificateDate").ToString
                    SOG = CInt(rdrOLEDB.Item("SOG"))
                    POS = CInt(rdrOLEDB.Item("POS"))
                    OI = CInt(rdrOLEDB.Item("OI"))
                    OtherIncomeDetails = rdrOLEDB.Item("OtherIncome").ToString
                    GenerateNew(PropName, CompName, PAN, ConcernType, Add1, Add2, Add3, Partners, LetterDate, CertificateDate, SOG, POS, OI, OtherIncomeDetails, Options.Save, FolderBrowserDialog1.SelectedPath)
                    rdrOLEDB.Close()
                    'Loop
                Else
                    rdrOLEDB.Close()
                    MsgBox("Record not found")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conOLEDB.Close()
            Progress.Value = ((i + 1) / max) * 100
        Next
        Progress.Visible = False
        HuraTabControl1.Enabled = True
        MsgBox("Done.", MsgBoxStyle.Information, "Done.")
    End Sub

    Private Sub BackgroundWorker_PDF_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_PDF.DoWork
        Progress.Visible = True
        Dim max As Integer = ListView1.CheckedItems.Count
        For i As Integer = 0 To ListView1.CheckedItems.Count - 1
            Dim li As ListViewItem = ListView1.CheckedItems(i)
            Try
                conOLEDB.Close()
            Catch ex As Exception

            End Try
            conOLEDB.Open()
            Dim cmdOLEDB As New OleDbCommand
            Try
                cmdOLEDB.Connection = conOLEDB
                cmdOLEDB.CommandText = "SELECT * FROM Data WHERE ID=" & CInt(li.Text)
                cmdOLEDB.CommandType = CommandType.Text
                Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
                If rdrOLEDB.Read = True Then
                    'Do While rdrOLEDB.Read
                    Dim PropName, CompName, PAN, ConcernType, Add1, Add2, Add3, Partners, LetterDate, CertificateDate, OtherIncomeDetails As String
                    Dim SOG As Boolean = False
                    Dim POS As Boolean = False
                    Dim OI As Boolean = False
                    PropName = rdrOLEDB.Item("PropName").ToString
                    CompName = rdrOLEDB.Item("CompName").ToString
                    PAN = rdrOLEDB.Item("PAN").ToString
                    ConcernType = rdrOLEDB.Item("ConcernType").ToString
                    Add1 = rdrOLEDB.Item("Add1").ToString
                    Add2 = rdrOLEDB.Item("Add2").ToString
                    Add3 = rdrOLEDB.Item("Add3").ToString
                    Partners = rdrOLEDB.Item("Partners").ToString
                    LetterDate = rdrOLEDB.Item("LetterDate").ToString
                    CertificateDate = rdrOLEDB.Item("CertificateDate").ToString
                    Try
                        SOG = If(IsDBNull(rdrOLEDB.Item("SOG")), 0, CInt(rdrOLEDB.Item("SOG")))
                    Catch ex As Exception

                    End Try
                    Try
                        POS = If(IsDBNull(rdrOLEDB.Item("POS")), 0, CInt(rdrOLEDB.Item("POS")))
                    Catch ex As Exception

                    End Try
                    Try
                        OI = If(IsDBNull(rdrOLEDB.Item("OI")), 0, CInt(rdrOLEDB.Item("OI")))
                    Catch ex As Exception

                    End Try
                    OtherIncomeDetails = rdrOLEDB.Item("OtherIncome").ToString
                    GenerateNew(PropName, CompName, PAN, ConcernType, Add1, Add2, Add3, Partners, LetterDate, CertificateDate, SOG, POS, OI, OtherIncomeDetails, Options.PDF, FolderBrowserDialog1.SelectedPath)
                    rdrOLEDB.Close()
                    'Loop
                Else
                    rdrOLEDB.Close()
                    MsgBox("Record not found")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                conOLEDB.Close()
            Catch ex As Exception

            End Try
            Progress.Value = ((i + 1) / max) * 100
        Next
        Progress.Visible = False
        HuraTabControl1.Enabled = True
        MsgBox("Done.", MsgBoxStyle.Information, "Done.")
    End Sub


    Private Sub btn_Print_Click(sender As System.Object, e As System.EventArgs) Handles btn_Print.Click
        If ListView1.CheckedItems.Count > 0 Then
            Progress.Value = 0
            BackgroundWorker_Print.RunWorkerAsync()
            HuraTabControl1.Enabled = False
        End If
    End Sub

    Private Sub btn_Word_Click(sender As System.Object, e As System.EventArgs) Handles btn_Word.Click
        If ListView1.CheckedItems.Count > 0 Then
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Progress.Value = 0
                BackgroundWorker_Word.RunWorkerAsync()
                HuraTabControl1.Enabled = False
            End If
        End If
    End Sub

    Private Sub btn_PDF_Click(sender As System.Object, e As System.EventArgs) Handles btn_PDF.Click
        If ListView1.CheckedItems.Count > 0 Then
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Progress.Value = 0
                BackgroundWorker_PDF.RunWorkerAsync()
                HuraTabControl1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If BackgroundWorker_PDF.IsBusy Or BackgroundWorker_Print.IsBusy Or BackgroundWorker_Word.IsBusy Then
            ProgressBar1.Visible = True
            Progress.Visible = True
        Else
            Progress.Visible = False
            ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub txt_Filter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_Filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                CType(AllData.DataSource, DataView).RowFilter = String.Format("[{0}] LIKE '%{1}%'", txt_filterby.Text, txt_Filter.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            lbl_count2.Text = "Filtered Items Count : " & AllData.RowCount
        End If
    End Sub

 
    Private Sub txt_Filter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Filter.TextChanged

    End Sub

    Private Sub btn_SelectAll_Click(sender As System.Object, e As System.EventArgs) Handles btn_Select_All.Click
        For Each i As ListViewItem In ListView1.Items
            i.Checked = True
        Next
    End Sub

  
    Private Sub btn_Uncheck_All_Click(sender As System.Object, e As System.EventArgs) Handles btn_Uncheck_All.Click
        For Each i As ListViewItem In ListView1.Items
            i.Checked = False
        Next
    End Sub

    Private Sub btn_Check_Selected_Click(sender As System.Object, e As System.EventArgs) Handles btn_Check_Selected.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            i.Checked = True
        Next
    End Sub

    Private Sub btn_Uncheck_Selected_Click(sender As System.Object, e As System.EventArgs) Handles btn_Uncheck_Selected.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            i.Checked = False
        Next
    End Sub

    Private Sub btn_Load_Click(sender As System.Object, e As System.EventArgs) Handles btn_Load.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim errMsg As String = ListViewContent.Load(ListView1, OpenFileDialog1.FileName, True, False, False)
            If errMsg <> String.Empty Then
                MessageBox.Show(errMsg, "Error during operation")
                Exit Sub
            Else
                MsgBox("List successfully loaded.", MsgBoxStyle.Information, "Done")
            End If
        End If
    End Sub

    Private Sub btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim errMsg As String = ListViewContent.Save(ListView1, SaveFileDialog1.FileName)
            If errMsg <> String.Empty Then
                MessageBox.Show(errMsg, "Error during operation")
                Exit Sub
            Else
                MsgBox("List successfully saved.", MsgBoxStyle.Information, "Done")
            End If
        End If
    End Sub

    Private Sub AllData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AllData.CellContentClick
        SetDetails()
    End Sub

    Private Sub AllData_SelectionChanged(sender As Object, e As System.EventArgs) Handles AllData.SelectionChanged
        SetDetails()
    End Sub


    Private Sub txt_CertificateDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_CertificateDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Partners.Focus()
        End If
    End Sub

    Private Sub txt_OtherIncome_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_OtherIncome.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.Enter Then
            isenter2 = True
            btn_Done.Focus()
            btn_Done_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txt_OtherIncome_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_OtherIncome.KeyPress
        If isenter2 = True Then
            e.Handled = True
            isenter2 = False
        End If
    End Sub

    Private Sub cb_SaleOfGoods_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cb_SaleOfGoods.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_ProvisionofServices.Focus()
        End If
    End Sub

    Private Sub cb_OtherIncome_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cb_OtherIncome.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_OtherIncome.Focus()
        End If
    End Sub

    Private Sub cb_ProvisionofServices_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cb_ProvisionofServices.KeyDown
        If e.KeyCode = Keys.Enter Then
            cb_OtherIncome.Focus()
        End If
    End Sub

    Private Sub btn_RemoveFilter_Click(sender As System.Object, e As System.EventArgs) Handles btn_RemoveFilter.Click
        Try
            CType(AllData.DataSource, DataView).RowFilter = ""
            lbl_count2.Text = "-"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Remove_Checked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove_Checked.Click
        For Each i As ListViewItem In ListView1.CheckedItems
            i.Remove()
        Next
    End Sub

    Private Sub AllData_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles AllData.CellPainting
        If e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Then
            If e.Value.ToString = "-1" Then
                Dim sf As New StringFormat
                e.Handled = True
                sf.LineAlignment = StringAlignment.Center
                sf.Alignment = StringAlignment.Center
                e.Graphics.DrawString("R", New Font("Wingdings 2", 11), Brushes.Green, e.CellBounds, sf)
            ElseIf e.Value.ToString = "0" Then
                Dim sf As New StringFormat
                e.Handled = True
                sf.LineAlignment = StringAlignment.Center
                sf.Alignment = StringAlignment.Center
                e.Graphics.DrawString("T", New Font("Wingdings 2", 11), Brushes.Red, e.CellBounds, sf)
            End If
        End If
    End Sub

    Private Sub cb_OtherIncome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_OtherIncome.CheckedChanged
        If cb_OtherIncome.Checked = True Then
            If txt_OtherIncome.Text = "" Then
                txt_OtherIncome.Text = "Interest income is recognized on a time proportion basis."
            End If
        End If
    End Sub

    Private Sub AllData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AllData.KeyDown
        If e.Control = False AndAlso e.Alt = False AndAlso e.Shift = False AndAlso e.KeyCode = Keys.Delete Then
            btn_Delete_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub AddSeletedItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSeletedItemsToolStripMenuItem.Click
        btn_AddSelected_Click(Nothing, Nothing)
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If AllData.SelectedRows.Count > 0 Then
            AddSeletedItemsToolStripMenuItem.Enabled = True
        Else
            AddSeletedItemsToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub
End Class
Class TemplateDetails
    Sub New(ByVal Filename As String)
        Me.Filename = Filename
        Me.Name = IO.Path.GetFileNameWithoutExtension(Filename)
    End Sub
    Property Name As String
    Property Filename As String
    Overrides Function ToString() As String
        Return Name
    End Function
End Class
