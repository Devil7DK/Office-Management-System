Imports System.Data.OleDb

Public Class Statements
    Dim ConnectionString As String
    Dim connOledb As OleDbConnection
    Dim total As Integer = 0
    Sub New(ByVal DatabaseLocation As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
        connOledb = New OleDbConnection(ConnectionString)
    End Sub
    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click
        lv_Statement.Items.Clear()
        connOledb.Open()
        total = 0
        Dim constring As String = String.Format("SELECT * FROM PatientDetails WHERE [{0}] LIKE '%{1}%'", txt_listby.Text, txt_Filter.Text)
        'Try
        Dim table As New DataTable()
        Using da = New OleDbDataAdapter(constring, connOledb)
            da.Fill(table)
        End Using
        For Each it As DataRow In table.Rows
            Dim ReportNumber, PatientName, Age, Doctorname As String
            Dim ReceivedDate As Date = Date.Parse(it.Item("Received Date").ToString)
            ReportNumber = it.Item("Report Number").ToString.Replace("-", "/").Trim
            PatientName = it.Item("Full Name").ToString
            Age = it.Item("Age").ToString
            Doctorname = it.Item("Doctor Name").ToString
            If ReceivedDate.CompareTo(Date.Parse(txt_DateFrom.Text)) >= 0 AndAlso ReceivedDate.CompareTo(Date.Parse(txt_DateTo.Text)) <= 0 Then
                Dim li As ListViewItem = lv_Statement.Items.Add(ReportNumber)
                li.SubItems.Add(PatientName)
                li.SubItems.Add(Age)
                li.SubItems.Add(Doctorname)
            End If
        Next
        'Catch ex As Exception

        'End Try
        connOledb.Close()
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Dim pd As New PrintDialog
        If pd.ShowDialog = DialogResult.OK Then
            Dim p As New D7Statement.Statement(lv_Statement, txt_Title.Text & vbNewLine & txt_Subtitle.Text, My.Resources.SSPLStatementHeader)
            p.PrinterSettings = pd.PrinterSettings
            p.Print()
        End If
    End Sub

    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        Dim p As New D7Statement.Statement(lv_Statement, txt_Title.Text & vbNewLine & txt_Subtitle.Text, My.Resources.SSPLStatementHeader)
        p.PrintPreview()
    End Sub

    Private Sub txt_listby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_listby.SelectedIndexChanged
        If txt_listby.SelectedIndex = 0 Then
            txt_Filter.Items.Clear()
            connOledb.Open()
            total = 0
            Dim constring As String = "SELECT * FROM DIAG"
            'Try
            Dim table As New DataTable()
            Using da = New OleDbDataAdapter(constring, connOledb)
                da.Fill(table)
            End Using
            For Each it As DataRow In table.Rows
                txt_Filter.Items.Add(it.Item("Diagnostics Name").ToString)

            Next
            'Catch ex As Exception

            'End Try
            connOledb.Close()
        ElseIf txt_listby.SelectedIndex = 1 Then
            txt_Filter.Items.Clear()
            connOledb.Open()
            total = 0
            Dim constring As String = "SELECT * FROM TEST"
            'Try
            Dim table As New DataTable()
            Using da = New OleDbDataAdapter(constring, connOledb)
                da.Fill(table)
            End Using
            For Each it As DataRow In table.Rows
                txt_Filter.Items.Add(it.Item("Test Name").ToString)

            Next
            'Catch ex As Exception

            'End Try
            connOledb.Close()
        ElseIf txt_listby.SelectedIndex = 2 Then
            txt_Filter.Items.Clear()
            connOledb.Open()
            total = 0
            Dim constring As String = "SELECT * FROM SITE"
            'Try
            Dim table As New DataTable()
            Using da = New OleDbDataAdapter(constring, connOledb)
                da.Fill(table)
            End Using
            For Each it As DataRow In table.Rows
                txt_Filter.Items.Add(it.Item("Site Name").ToString)
            Next
            'Catch ex As Exception

            'End Try
            connOledb.Close()
        End If
    End Sub

    Private Sub Statements_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_listby.SelectedIndex = 0
    End Sub
End Class