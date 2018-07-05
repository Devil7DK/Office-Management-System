Imports System.ComponentModel
Imports System.Data.OleDb

Public Class MonthlyState
    Dim ConnectionString As String
    Dim connOledb As OleDbConnection
    Dim total As Integer = 0
    Dim DatabaseLocation As String = ""
    Sub LoadData(ByVal DatabaseLocation As String)
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
        connOledb = New OleDbConnection(ConnectionString)
        Me.DatabaseLocation = DatabaseLocation
    End Sub
    Sub LoadAll()
        Try
            Const constring As String = "SELECT * FROM DOC"
            Dim dt As New DataTable()
            Try
                Using sqlCon As OleDbConnection = New OleDbConnection(ConnectionString)
                    Using SqlDa As New OleDbDataAdapter(constring, sqlCon)
                        SqlDa.SelectCommand.CommandType = CommandType.Text
                        SqlDa.Fill(dt)
                    End Using
                End Using
                Doctors.DataSource = New DataView(dt)
                Doctors.Columns(0).Width = 50
            Catch generatedExceptionName As Exception
                MsgBox(generatedExceptionName.Message)
            End Try
        Catch ex As Exception
            ' log message instead '
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MonthlyState_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.DefaultFile = "" Or My.Computer.FileSystem.FileExists(My.Settings.DefaultFile) = False Then
            Dim d As New SelectFileForView
            If d.ShowDialog = DialogResult.OK Then
                My.Settings.DefaultFile = d.Filename
                My.Settings.Save()
                LoadData(d.Filename)
                LoadAll()
            Else
                End
            End If
        Else
            LoadData(My.Settings.DefaultFile)
            LoadAll()
        End If
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        If txt_Search.Text.ToLower.EndsWith("id=") Then
            Try
                Dim s As String() = Split(txt_Search.Text, "=", 2)
                Doctors.DataSource.RowFilter = String.Format("[ID]='%{0}%';", CInt(s(1)))
            Catch ex As Exception

            End Try
        Else
            Try
                Doctors.DataSource.RowFilter = String.Format("[Doctor Name] LIKE '%{0}%' OR [Street] LIKE '%{0}%' OR [Area] LIKE '%{0}%' OR [City] LIKE '%{0}%' OR [PinCode] LIKE '%{0}%' OR [Phone] LIKE '%{0}%' OR [Hospital] LIKE '%{0}%' ", txt_Search.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        Try
            For Each i As ListViewItem In lv_SelectedDoctors.SelectedItems
                i.Remove()
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub AddData()
        lv_Statement.Items.Clear()
        lv_Statement.Groups.Clear()
        lst_process.Items.Add("Connection opened.")
        total = 0
        Const constring As String = "SELECT * FROM PATIENT"
        lst_process.Items.Add("Opening Database.CONSTR=" & constring)
        'Try
        Dim dt As New DataTable()
        Try
            Using sqlCon As OleDbConnection = New OleDbConnection(ConnectionString)
                Using SqlDa As New OleDbDataAdapter(constring, sqlCon)
                    SqlDa.SelectCommand.CommandType = CommandType.Text
                    SqlDa.Fill(dt)
                End Using
            End Using
        Catch generatedExceptionName As Exception

        End Try
        Dim Data As DataView
        Data = New DataView(dt)
        lst_process.Items.Add("DataGrid Filled. Count=" & Data.Count)
        For Each i As ListViewItem In lv_SelectedDoctors.Items
            Dim group As ListViewGroup = lv_Statement.Groups.Add(i.SubItems(0).Text, i.SubItems(1).Text)
            Dim docid As Integer = CInt(i.Text)
            Data.RowFilter = String.Format("[Doctor ID]={0} and [Received Date]>='{1}' and [Received Date]<='{2}'", docid, Date.Parse(tb_DateFrom.Text).ToString("dd-MM-yyyy"), Date.Parse(tb_DateTo.Text).ToString("dd-MM-yyyy"))
            lst_process.Items.Add("Items Filtered. Count=" & Data.Count)
            Dim Rows As DataRowCollection = Data.ToTable.Rows
            Progress.Maximum = Rows.Count
            For i1 As Integer = 0 To Rows.Count - 1
                Progress.Value = i1 + 1
                Dim it As DataRow = Rows(i1)
                Dim ReportNumber, ReceivedDate, PatientName, AgeSex As String
                ReportNumber = it.Item("Report Number").ToString.Replace("-", "/").Trim
                PatientName = it.Item("Sur Name").ToString & it.Item("Patient Name").ToString
                ReceivedDate = Date.Parse(it.Item("Received Date").ToString).ToString("dd/MM/yyy").Replace("-", "/")
                AgeSex = it.Item("Age").ToString & "/" & it.Item("Gender").ToString.Substring(0, 1).ToUpper
                Dim li As ListViewItem = lv_Statement.Items.Add(ReportNumber)
                li.SubItems.Add(ReceivedDate)
                li.SubItems.Add(PatientName)
                li.SubItems.Add(AgeSex)
                li.Group = group
            Next
            'Catch ex As Exception

            'End Try
            lst_process.Items.Add("Process Completed")
            txt_DoctorName.Text = (i.SubItems(1).Text)
        Next
    End Sub
    Private Sub btn_Next1_Click(sender As Object, e As EventArgs) Handles btn_Next1.Click
        btn_Next1.Enabled = False
        Data_Worker.RunWorkerAsync()
        Timer1.Start()
    End Sub

    Private Sub Doctors_DoubleClick(sender As Object, e As EventArgs) Handles Doctors.DoubleClick
        Try
            For Each i As DataGridViewRow In Doctors.SelectedRows
                lv_SelectedDoctors.Items.Add(i.Cells(0).Value.ToString).SubItems.Add(i.Cells(1).Value.ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Finish_Click(sender As Object, e As EventArgs) Handles btn_Finish.Click
        lv_SelectedDoctors.Items.Clear()
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub btn_PrintPreview_Click(sender As Object, e As EventArgs) Handles btn_PrintPreview.Click
        Dim p As New D7Statement.Statement(lv_Statement, txt_DoctorName.Text & vbNewLine & txt_Month.Text, My.Resources.SSPLStatementHeader)
        p.PrintPreview()
    End Sub

    Private Sub btn_Previous2_Click(sender As Object, e As EventArgs) Handles btn_Previous2.Click
        Try
            TabControl1.SelectedIndex -= 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel1.Click, btn_Cancel2.Click
        If Data_Worker.IsBusy Then
            Data_Worker.CancelAsync()
        End If
        Me.Close()
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Dim pd As New PrintDialog
        If pd.ShowDialog = DialogResult.OK Then
            Dim p As New D7Statement.Statement(lv_Statement, txt_DoctorName.Text & vbNewLine & txt_Month.Text, My.Resources.SSPLStatementHeader)
            p.PrinterSettings = pd.PrinterSettings
            p.Print()
        End If

    End Sub

    Private Sub Data_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Data_Worker.DoWork
        Try
            AddData()
            'TabControl1.SelectedTab = TabPage2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            btn_Next1.Enabled = True
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Data_Worker.IsBusy Then
            lbl_state.Visible = True
            If lbl_state.Text = "Loading Please Wait..." Then
                lbl_state.Text = "Loading Please Wait."
            ElseIf lbl_state.Text = "Loading Please Wait.." Then
                lbl_state.Text = "Loading Please Wait..."
            ElseIf lbl_state.Text = "Loading Please Wait." Then
                lbl_state.Text = "Loading Please Wait.."
            Else
                lbl_state.Text = "Loading Please Wait."
            End If
            If btn_Next1.Enabled = True Then
                btn_Next1.Enabled = False
            End If
        Else
            lbl_state.Visible = False
            If btn_Next1.Enabled = False Then
                btn_Next1.Enabled = True
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub Data_Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Data_Worker.RunWorkerCompleted
        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Try
            For Each i As DataGridViewRow In Doctors.SelectedRows
                lv_SelectedDoctors.Items.Add(i.Cells(0).Value.ToString).SubItems.Add(i.Cells(1).Value.ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Settings_Click(sender As Object, e As EventArgs) Handles btn_Settings.Click
        Settings.ShowDialog()
    End Sub

    Private Sub cb_ShowGroups_CheckedChanged(sender As Object) Handles cb_ShowGroups.CheckedChanged
        lv_Statement.ShowGroups = cb_ShowGroups.Checked
    End Sub

    Private Sub btn_OtherStatement_Click(sender As Object, e As EventArgs) Handles btn_OtherStatement.Click
        Dim n As New Statements(DatabaseLocation)
        n.Show()
        Me.Close()
    End Sub
End Class