Imports System.Data.OleDb
Imports System.IO
Imports i00SpellCheck
Public Class EditPatient
    Dim ConnectionString As String = ""
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim DocTable As DataTable
    Dim PatientID As Integer = 0
    Dim chrn As String
    Dim History As String = ""
    Dim Watcher As New EditWatcher
    Dim Loaded As Boolean = False
    ReadOnly Property ChoosenReportNumber As String
        Get
            Return chrn
        End Get
    End Property
    Private Sub LoadDataSource()
        cnnOLEDB.Open()
        Try
            Const constring As String = "SELECT * FROM DoctorDetails"
            Dim table = New DataTable()
            Using da = New OleDbDataAdapter(constring, cnnOLEDB)
                da.Fill(table)
                DocTable = table.Clone
                DoctorData.DataSource = New DataView(table)
                DoctorData.Columns(0).Width = 50
                cb_DoctorID.DataSource = table
                cb_DoctorID.ValueMember = "ID"
                cb_DoctorID.DisplayMember = "Doctor Name"
            End Using
        Catch ex As Exception
            ' log message instead '
        End Try
        Try
            Const constring As String = "SELECT [Test Name] FROM TEST"
            Dim dt As New DataTable()
            Try
                Using sqlCon As OleDbConnection = New OleDbConnection(ConnectionString)
                    Using SqlDa As New OleDbDataAdapter(constring, sqlCon)
                        SqlDa.SelectCommand.CommandType = CommandType.Text
                        SqlDa.Fill(dt)
                    End Using
                End Using
                txt_Test.DataSource = dt
                txt_Test.DisplayMember = "Test Name"
                txt_Test.ValueMember = "Test Name"
            Catch generatedExceptionName As Exception

            End Try
        Catch ex As Exception
            ' log message instead '

        End Try
        Try
            Const constring As String = "SELECT * FROM SITE"
            Dim dt As New DataTable()
            Try
                Using sqlCon As OleDbConnection = New OleDbConnection(ConnectionString)
                    Using SqlDa As New OleDbDataAdapter(constring, sqlCon)
                        SqlDa.SelectCommand.CommandType = CommandType.Text
                        SqlDa.Fill(dt)
                    End Using
                End Using
                SitesData.DataSource = New DataView(dt)
                SitesData.Columns(0).Width = 50
            Catch generatedExceptionName As Exception

            End Try
        Catch ex As Exception
            ' log message instead '

        End Try
        Try
            Const constring As String = "SELECT * FROM DIAG"
            Dim dt As New DataTable()
            Try
                Using sqlCon As OleDbConnection = New OleDbConnection(ConnectionString)
                    Using SqlDa As New OleDbDataAdapter(constring, sqlCon)
                        SqlDa.SelectCommand.CommandType = CommandType.Text
                        SqlDa.Fill(dt)
                    End Using
                End Using
                DiagnosticsData.DataSource = New DataView(dt)
                DiagnosticsData.Columns(0).Width = 50
            Catch generatedExceptionName As Exception

            End Try
        Catch ex As Exception
            ' log message instead '

        End Try
        Try
            cmdOLEDB.Connection = cnnOLEDB
            cmdOLEDB.CommandText = "SELECT * FROM PATIENT WHERE ID=" & CInt(PatientID)
            cmdOLEDB.CommandType = CommandType.Text
            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
            If rdrOLEDB.Read = True Then
                'Do While rdrOLEDB.Read
                Dim rn As String = rdrOLEDB.Item("Report Number").ToString
                If rn.Length = 13 Then
                    ExtendReportNumber.Checked = True
                    txt_ReportNumber.Text = rn
                Else
                    ExtendReportNumber.Checked = False
                    txt_ReportNumber.Text = rn
                End If
                txt_SurName.Text = rdrOLEDB.Item("Sur Name").ToString
                txt_PatientName.Text = rdrOLEDB.Item("Patient Name").ToString
                txt_Age.Text = rdrOLEDB.Item("Age").ToString
                txt_Gender.Text = rdrOLEDB.Item("Gender").ToString
                txt_Test.SelectedIndex = txt_Test.FindStringExact(rdrOLEDB.Item("Test").ToString)
                Try
                    If Not rdrOLEDB.Item("Site").ToString.TrimStart("|") = "" Then
                        ls_Site.Items.AddRange(Split(rdrOLEDB.Item("Site").ToString.TrimStart("|"), "|"))
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                txt_AddressLine1.Text = rdrOLEDB.Item("Address Line 1").ToString
                txt_AddressLine2.Text = rdrOLEDB.Item("Address Line 2").ToString
                txt_City.Text = rdrOLEDB.Item("City").ToString
                txt_State.Text = rdrOLEDB.Item("State").ToString
                txt_Mobile.Text = rdrOLEDB.Item("Mobile").ToString
                txt_Email.Text = rdrOLEDB.Item("E Mail").ToString
                Try
                    If Not rdrOLEDB.Item("Diagnostics").ToString.TrimStart("|") = "" Then
                        ls_Diagnostics.Items.AddRange(Split(rdrOLEDB.Item("Diagnostics").ToString.TrimStart("|"), "|"))
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                Try
                    Dim DOCID As Integer = rdrOLEDB.Item("Doctor ID").ToString
                    cb_DoctorID.SelectedValue = DOCID
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                txt_HospitalNumber.Text = rdrOLEDB.Item("Hospital Number").ToString
                txt_PreviousReportNumber.Text = rdrOLEDB.Item("Previous Report Number").ToString
                txt_ReceivedDate.Text = rdrOLEDB.Item("Received Date").ToString
                txt_ReportedDate.Text = rdrOLEDB.Item("Reported Date").ToString
                txt_Report.Text = rdrOLEDB.Item("Report Result").ToString
                txt_Notes.Text = rdrOLEDB.Item("Notes").ToString
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 1 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 1")
                            ms.WriteByte(i)
                        Next
                        ReportImage1.SelectedImage = Image.FromStream(ms)
                        ReportImage1.SelectedName = namestr
                        ReportImage1.SelectedImageValidity = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 2 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 2")
                            ms.WriteByte(i)
                        Next
                        ReportImage2.SelectedImage = Image.FromStream(ms)
                        ReportImage2.SelectedName = namestr
                        ReportImage2.SelectedImageValidity = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 3 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 3")
                            ms.WriteByte(i)
                        Next
                        ReportImage3.SelectedImage = Image.FromStream(ms)
                        ReportImage3.SelectedName = namestr
                        ReportImage3.SelectedImageValidity = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 4 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 4")
                            ms.WriteByte(i)
                        Next
                        ReportImage4.SelectedImage = Image.FromStream(ms)
                        ReportImage4.SelectedName = namestr
                        ReportImage4.SelectedImageValidity = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
                History = rdrOLEDB.Item("History").ToString
                rdrOLEDB.Close()
                'Loop
            Else
                MsgBox("Record not found")
                rdrOLEDB.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
        cnnOLEDB.Close()
        Loaded = True
    End Sub
    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel2.EnableControlExtensions
        LoadDataSource()
        txt_ReportNumber.Focus()
    End Sub
    Sub New(ByVal DatabaseLocation As String, ByVal PatientID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.PatientID = PatientID
        ' Add any initialization after the InitializeComponent() call.
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
        cnnOLEDB.ConnectionString = ConnectionString
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchDoctor.TextChanged
        If txt_SearchDoctor.Text.ToLower.EndsWith("id=") Then
            Try
                Dim s As String() = Split(txt_SearchDoctor.Text, "=", 2)
                DoctorData.DataSource.RowFilter = String.Format("[ID]={0}", CInt(s(1)))
            Catch ex As Exception

            End Try
        Else
            Try
                DoctorData.DataSource.RowFilter = String.Format("[Doctor Details] LIKE '%{0}%' OR [Doctor Name] LIKE '%{0}%'", txt_SearchDoctor.Text) 'String.Format("[ID] LIKE '%{0}%' OR [Doctor Name] LIKE '%{0}%' OR [Street] LIKE '%{0}%' OR [Area] LIKE '%{0}%' OR [City] LIKE '%{0}%' OR [PinCode] LIKE '%{0}%' OR [Phone] LIKE '%{0}%' OR [Hospital] LIKE '%{0}%'", txt_Search.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Function CheckFields() As Object()
        If txt_ReportNumber.Text.Replace("-", "").Trim = "" Then
            Return {False, "Report Number Not Filled Properly"}
        End If
        If txt_Age.Text.Trim = "" Then
            Return {False, "Please check the Age"}
        End If
        If cb_DoctorID.SelectedIndex = -1 Then
            Return {False, "Please Select the doctor from the Doctor List"}
        End If
        If txt_Gender.Text.Trim = "" Then
            Return {False, "Please Select Gender"}
        End If
        If txt_PatientName.Text.Trim = "" Then
            Return {False, "Please Fill the Patient Name"}
        End If
        Return {True, ""}
    End Function
    Function GetSiteValue() As String
        Dim r As String = ""
        If ls_Site.Items.Count > 0 Then
            For i As Integer = 0 To ls_Site.Items.Count - 1
                If i = 0 Then
                    r = ls_Site.Items(0).ToString
                ElseIf i > 0 Then
                    r &= "|" & ls_Site.Items(i).ToString
                End If
            Next
        End If
        Return r
    End Function
    Function GetDiagnosticsValue() As String
        Dim r As String = ""
        If ls_Diagnostics.Items.Count > 0 Then
            For i As Integer = 0 To ls_Diagnostics.Items.Count - 1
                If i = 0 Then
                    r = ls_Diagnostics.Items(0).ToString
                ElseIf i > 0 Then
                    r &= "|" & ls_Diagnostics.Items(i).ToString
                End If
            Next
        End If
        Return r
    End Function
    Function GetDetails() As Object()
        Dim ro As New Object()
        Dim List_ As New List(Of Object)
        List_.Add(GetWithQuot.WithQuot(txt_ReportNumber.Text.ToUpper.Replace("-", "/")))
        List_.Add(GetWithQuot.WithQuot(txt_SurName.Text))
        List_.Add(GetWithQuot.WithQuot(txt_PatientName.Text))
        List_.Add(GetWithQuot.WithQuot(txt_Age.Text))
        List_.Add(GetWithQuot.WithQuot(txt_Gender.Text))
        List_.Add(GetWithQuot.WithQuot(txt_Test.SelectedValue))
        List_.Add(GetWithQuot.WithQuot(GetSiteValue))
        List_.Add(GetWithQuot.WithQuot(txt_AddressLine1.Text))
        List_.Add(GetWithQuot.WithQuot(txt_AddressLine2.Text))
        List_.Add(GetWithQuot.WithQuot(txt_City.Text))
        List_.Add(GetWithQuot.WithQuot(txt_State.Text))
        List_.Add(GetWithQuot.WithQuot(txt_Mobile.Text))
        List_.Add(GetWithQuot.WithQuot(txt_Email.Text))
        List_.Add(GetWithQuot.WithQuot(GetDiagnosticsValue))
        List_.Add(GetWithQuot.WithQuot(cb_DoctorID.SelectedValue))
        List_.Add(GetWithQuot.WithQuot(txt_HospitalNumber.Text))
        List_.Add(GetWithQuot.WithQuot(txt_PreviousReportNumber.Text))
        List_.Add(GetWithQuot.WithQuot(txt_ReceivedDate.Value))
        List_.Add(GetWithQuot.WithQuot(txt_ReportedDate.Value))
        List_.Add(GetWithQuot.WithQuot(txt_Report.Text))
        List_.Add(GetWithQuot.WithQuot(txt_Notes.Text))
        If ReportImage1.SelectedImageValidity = True Then
            List_.Add(GetWithQuot.WithQuot(ReportImage1.SelectedName))
        Else
            List_.Add(GetWithQuot.WithQuot(""))
        End If
        If ReportImage2.SelectedImageValidity = True Then
            List_.Add(GetWithQuot.WithQuot(ReportImage2.SelectedName))
        Else
            List_.Add(GetWithQuot.WithQuot(""))
        End If
        If ReportImage3.SelectedImageValidity = True Then
            List_.Add(GetWithQuot.WithQuot(ReportImage3.SelectedName))
        Else
            List_.Add(GetWithQuot.WithQuot(""))
        End If
        If ReportImage4.SelectedImageValidity = True Then
            List_.Add(GetWithQuot.WithQuot(ReportImage4.SelectedName))
        Else
            List_.Add(GetWithQuot.WithQuot(""))
        End If
        History &= vbNewLine & If(Watcher.GetHistory = "", "", Watcher.GetHistory.Trim & vbNewLine) & "Record Edited at : " & Now.ToLongDateString & " " & Now.ToLongTimeString
        List_.Add(GetWithQuot.WithQuot(History))
        Return List_.ToArray
    End Function
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Try
            cnnOLEDB.Open()
            Dim Checkup As Object() = CheckFields()
            If Checkup(0) = True Then
                Dim im1, im2, im3, im4, emptyimg As New MemoryStream()
                My.Resources.Empty.Save(emptyimg, Imaging.ImageFormat.Jpeg)
                If ReportImage1.SelectedImageValidity = True Then
                    ReportImage1.SelectedImage.Save(im1, Imaging.ImageFormat.Jpeg)
                End If
                If ReportImage2.SelectedImageValidity = True Then
                    ReportImage2.SelectedImage.Save(im2, Imaging.ImageFormat.Jpeg)
                End If
                If ReportImage3.SelectedImageValidity = True Then
                    ReportImage3.SelectedImage.Save(im3, Imaging.ImageFormat.Jpeg)
                End If
                If ReportImage4.SelectedImageValidity = True Then
                    ReportImage4.SelectedImage.Save(im4, Imaging.ImageFormat.Jpeg)
                End If
                Dim imdata1 As Byte() = im1.GetBuffer()
                Dim imdata2 As Byte() = im2.GetBuffer()
                Dim imdata3 As Byte() = im3.GetBuffer()
                Dim imdata4 As Byte() = im4.GetBuffer()
                Dim empty As Byte() = emptyimg.GetBuffer()
                cmdOLEDB.Connection = cnnOLEDB
                Dim Objects As Object() = GetDetails()
                cmdOLEDB.CommandText = String.Format("UPDATE PATIENT SET [Report Number]={0},[Sur Name]={1},[Patient Name]={2},[Age]={3},[Gender]={4},[Test]={5},[Site]={6},[Address Line 1]={7},[Address Line 2]={8},[City]={9},[State]={10},[Mobile]={11},[E Mail]={12},[Diagnostics]={13},[Doctor ID]={14},[Hospital Number]={15},[Previous Report Number]={16},[Received Date]={17},[Reported Date]={18},[Report Result]={19},[Notes]={20},[Image 1]=@image1,[Image 1 Name]={21},[Image 2]=@image2,[Image 2 Name]={22},[Image 3]=@image3,[Image 3 Name]={23},[Image 4]=@image4,[Image 4 Name]={24},[History]={25} WHERE [ID]=" & PatientID & ";", Objects)
                '
                cmdOLEDB.CommandType = CommandType.Text
                Dim p4 As New OleDbParameter("@image1", OleDb.OleDbType.Binary)
                Dim p3 As New OleDbParameter("@image2", OleDb.OleDbType.Binary)
                Dim p2 As New OleDbParameter("@image3", OleDb.OleDbType.Binary)
                Dim p1 As New OleDbParameter("@image4", OleDb.OleDbType.Binary)
                If ReportImage1.SelectedImageValidity = True Then
                    p4.Value = imdata1
                    cmdOLEDB.Parameters.Add(p4)
                Else
                    p4.Value = empty
                    cmdOLEDB.Parameters.Add(p4)
                End If
                If ReportImage1.SelectedImageValidity = True Then
                    p3.Value = imdata2
                    cmdOLEDB.Parameters.Add(p3)
                Else
                    p3.Value = empty
                    cmdOLEDB.Parameters.Add(p3)
                End If
                If ReportImage1.SelectedImageValidity = True Then
                    p2.Value = imdata3
                    cmdOLEDB.Parameters.Add(p2)
                Else
                    p2.Value = empty
                    cmdOLEDB.Parameters.Add(p2)
                End If
                If ReportImage1.SelectedImageValidity = True Then
                    p1.Value = imdata4
                    cmdOLEDB.Parameters.Add(p1)
                Else
                    p1.Value = empty
                    cmdOLEDB.Parameters.Add(p1)
                End If
                cmdOLEDB.ExecuteNonQuery()
                MsgBox("Patient Details Successfully Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done :-)")
                Me.chrn = txt_ReportNumber.Text
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox(Checkup(1), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error :-(")
            End If
            cnnOLEDB.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click

        Me.Close()
    End Sub

#Region "DoctorID"
    Private Sub DoctorData_DoubleClick(sender As Object, e As EventArgs) Handles DoctorData.DoubleClick
        Try
            cb_DoctorID.SelectedValue = CInt(DoctorData.Item(0, DoctorData.SelectedRows(0).Index).Value.ToString)
            Watcher.Doctor = True
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Sites"
    Private Sub btn_AddSite_Click(sender As Object, e As EventArgs) Handles btn_AddSite.Click
        If SitesData.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = SitesData.SelectedRows(0)
            ls_Site.Items.Add(row.Cells(1).Value.ToString)
            Watcher.Sites = True
        End If
    End Sub
    Private Sub SitesData_DoubleClick(sender As Object, e As EventArgs) Handles SitesData.DoubleClick
        If SitesData.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = SitesData.SelectedRows(0)
            ls_Site.Items.Add(row.Cells(1).Value.ToString)
            Watcher.Sites = True
        End If
    End Sub
    Private Sub btn_RemoveSite_Click(sender As Object, e As EventArgs) Handles btn_RemoveSite.Click
        Try
            If ls_Site.SelectedItems.Count > 0 Then
                Try
                    ls_Site.Items.Remove(ls_Site.SelectedItems(0))
                    Watcher.Sites = True
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_SearchSites_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchSites.TextChanged
        If txt_SearchSites.Text.ToLower.EndsWith("id=") Then
            Try
                Dim s As String() = Split(txt_SearchSites.Text, "=", 2)
                SitesData.DataSource.RowFilter = String.Format("[ID]={0}", CInt(s(1)))
            Catch ex As Exception

            End Try
        Else
            Try
                SitesData.DataSource.RowFilter = String.Format("[Site Name] LIKE '%{0}%'", txt_SearchSites.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

#End Region
#Region "Diagnostics"
    Private Sub btn_AddDiagnostics_Click(sender As Object, e As EventArgs) Handles btn_AddDiagnostics.Click
        If DiagnosticsData.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DiagnosticsData.SelectedRows(0)
            ls_Diagnostics.Items.Add(row.Cells(1).Value.ToString)
            Watcher.Diagnostics = True
        End If
    End Sub

    Private Sub btn_RemoveDisgnostics_Click(sender As Object, e As EventArgs) Handles btn_RemoveDisgnostics.Click
        If ls_Diagnostics.SelectedItems.Count > 0 Then
            Try
                ls_Diagnostics.Items.Remove(ls_Diagnostics.SelectedItems(0))
                Watcher.Diagnostics = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txt_SearchDiagnostics_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchDiagnostics.TextChanged
        If txt_SearchDiagnostics.Text.ToLower.EndsWith("id=") Then
            Try
                Dim s As String() = Split(txt_SearchDiagnostics.Text, "=", 2)
                DiagnosticsData.DataSource.RowFilter = String.Format("[ID]={0}", CInt(s(1)))
            Catch ex As Exception

            End Try
        Else
            Try
                DiagnosticsData.DataSource.RowFilter = String.Format("[Diagnostics Name] LIKE '%{0}%'", txt_SearchDiagnostics.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub DiagnosticsData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DiagnosticsData.MouseDoubleClick
        If DiagnosticsData.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DiagnosticsData.SelectedRows(0)
            ls_Diagnostics.Items.Add(row.Cells(1).Value.ToString)
            Watcher.Diagnostics = True
        End If
    End Sub

    Private Sub btn_AddDoc_Click(sender As Object, e As EventArgs) Handles btn_AddDoc.Click
        Dim d As New AddNewDoc(ConnectionString)
        If d.ShowDialog = DialogResult.OK Then
            Dim ho As Integer = 0
            Try
                cnnOLEDB.Open()
                ho = 1
            Catch ex As Exception

            End Try
            Try
                Const constring As String = "SELECT * FROM DoctorDetails"
                Dim table = New DataTable()
                Using da = New OleDbDataAdapter(constring, cnnOLEDB)
                    da.Fill(table)
                    DocTable = table.Clone
                    DoctorData.DataSource = New DataView(table)
                    DoctorData.Columns(0).Width = 50
                    cb_DoctorID.DataSource = table
                    cb_DoctorID.ValueMember = "ID"
                    cb_DoctorID.DisplayMember = "Doctor Name"
                End Using
            Catch ex As Exception
                ' log message instead '
            End Try
            If ho = 1 Then
                Try
                    cnnOLEDB.Close()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub btn_EditDoc_Click(sender As Object, e As EventArgs) Handles btn_EditDoc.Click
        If DoctorData.SelectedRows.Count = 1 Then
            Dim id As Integer = DoctorData.SelectedRows(0).Cells(0).Value.ToString
            Dim ed As New EditDoc(id, ConnectionString)
            If ed.ShowDialog = DialogResult.OK Then
                Dim ho As Integer = 0
                Try
                    cnnOLEDB.Open()
                    ho = 1
                Catch ex As Exception

                End Try
                Try
                    Const constring As String = "SELECT * FROM DoctorDetails"
                    Dim table = New DataTable()
                    Using da = New OleDbDataAdapter(constring, cnnOLEDB)
                        da.Fill(table)
                        DocTable = table.Clone
                        DoctorData.DataSource = New DataView(table)
                        DoctorData.Columns(0).Width = 50
                        cb_DoctorID.DataSource = table
                        cb_DoctorID.ValueMember = "ID"
                        cb_DoctorID.DisplayMember = "Doctor Name"
                    End Using
                Catch ex As Exception
                    ' log message instead '
                End Try
                If ho = 1 Then
                    Try
                        cnnOLEDB.Close()
                    Catch ex As Exception

                    End Try
                End If
            End If
        Else
            MsgBox("Please select one item to edit.")
        End If
    End Sub




#End Region
    Private Sub ExtendReportNumber_CheckedChanged(sender As Object, e As EventArgs) Handles ExtendReportNumber.CheckedChanged
        If ExtendReportNumber.Checked = True Then
            txt_ReportNumber.Mask = "aa-99999-9999"
        Else
            txt_ReportNumber.Mask = "aa-9999-9999"
        End If
    End Sub

    Private Sub txt_AddressLine1_TextChanged(sender As Object, e As EventArgs) Handles txt_AddressLine1.TextChanged
        If Loaded = True Then
            Watcher.AddressLine1 = True
        End If
    End Sub

    Private Sub txt_AddressLine2_TextChanged(sender As Object, e As EventArgs) Handles txt_AddressLine2.TextChanged
        If Loaded = True Then
            Watcher.AddressLine2 = True
        End If

    End Sub

    Private Sub txt_Age_TextChanged(sender As Object, e As EventArgs) Handles txt_Age.TextChanged
        If Loaded = True Then
            Watcher.Age = True
        End If

    End Sub

    Private Sub txt_City_TextChanged(sender As Object, e As EventArgs) Handles txt_City.TextChanged
        If Loaded = True Then
            Watcher.City = True
        End If
    End Sub

    Private Sub txt_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_Email.TextChanged
        If Loaded = True Then
            Watcher.Email = True
        End If

    End Sub

    Private Sub txt_Gender_TextChanged(sender As Object, e As EventArgs) Handles txt_Gender.TextChanged
        If Loaded = True Then
            Watcher.Gender = True
        End If
    End Sub

    Private Sub txt_HospitalNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_HospitalNumber.TextChanged
        If Loaded = True Then
            Watcher.HospitalNumber = True
        End If
    End Sub

    Private Sub txt_Mobile_TextChanged(sender As Object, e As EventArgs) Handles txt_Mobile.TextChanged
        If Loaded = True Then
            Watcher.Mobile = True
        End If
    End Sub

    Private Sub txt_Notes_TextChanged(sender As Object, e As EventArgs) Handles txt_Notes.TextChanged
        If Loaded = True Then
            Watcher.Notes = True
        End If
    End Sub

    Private Sub txt_PatientName_TextChanged(sender As Object, e As EventArgs) Handles txt_PatientName.TextChanged
        If Loaded = True Then
            Watcher.Fullname = True
        End If
    End Sub

    Private Sub txt_PreviousReportNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_PreviousReportNumber.TextChanged
        If Loaded = True Then
            Watcher.PreviousReport = True
        End If
    End Sub

    Private Sub txt_ReceivedDate_TextChanged(sender As Object, e As EventArgs) Handles txt_ReceivedDate.TextChanged
        If Loaded = True Then
            Watcher.ReceivedDate = True
        End If
    End Sub

    Private Sub txt_Report_TextChanged(sender As Object, e As EventArgs) Handles txt_Report.TextChanged
        If Loaded = True Then
            Watcher.Report = True
        End If
    End Sub

    Private Sub txt_ReportedDate_TextChanged(sender As Object, e As EventArgs) Handles txt_ReportedDate.TextChanged
        If Loaded = True Then
            Watcher.ReportedDate = True
        End If

    End Sub

    Private Sub txt_ReportNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_ReportNumber.TextChanged
        If Loaded = True Then
            Watcher.ReportNumber = True
        End If

    End Sub

    Private Sub txt_State_TextChanged(sender As Object, e As EventArgs) Handles txt_State.TextChanged
        If Loaded = True Then
            Watcher.State = True
        End If
    End Sub

    Private Sub txt_SurName_TextChanged(sender As Object, e As EventArgs) Handles txt_SurName.TextChanged
        If Loaded = True Then
            Watcher.Surname = True
        End If
    End Sub

    Private Sub txt_Test_TextChanged(sender As Object, e As EventArgs) Handles txt_Test.TextChanged
        If Loaded = True Then
            Watcher.Test = True
        End If
    End Sub

    Private Sub ReportImage1_Load(sender As Object, e As EventArgs) Handles ReportImage1.Load

    End Sub
End Class
