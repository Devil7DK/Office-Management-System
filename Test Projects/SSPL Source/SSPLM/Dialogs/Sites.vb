Imports System.Data.OleDb

Public Class Sites
    Dim ConnectionString As String
    Sub New(ByVal DatabaseLocation As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
    End Sub
    Sub LoadAll()
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
    End Sub
    Private Sub Sites_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAll()

    End Sub

    Private Sub txt_SearchSites_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchSites.TextChanged
        Try
            SitesData.DataSource.RowFilter = String.Format("[Site Name] LIKE '%{0}%'", txt_SearchSites.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            If MsgBox("Are you sure you want to add a new site ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                Dim s As String = InputBox("Enter the site name:", "Add New").Trim
                If s <> "" Then
                    Dim cnnoledb As New OleDbConnection(ConnectionString)
                    cnnoledb.Open()
                    Dim cmdOledb As New OleDbCommand
                    cmdOledb.Connection = cnnoledb
                    cmdOledb.CommandText = String.Format("INSERT INTO SITE ([Site Name]) VALUES ({0})", GetWithQuot.WithQuot(s))
                    cmdOledb.CommandType = CommandType.Text
                    cmdOledb.ExecuteNonQuery()
                    cnnoledb.Close()
                    MsgBox("New Site Successfully Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done :-)")
                    LoadAll()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Try
            If SitesData.SelectedRows.Count = 1 Then
                Dim id As Integer = SitesData.SelectedRows(0).Cells(0).Value.ToString
                If MsgBox("Are you sure you want to edit the selected site ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
                    Dim s As String = InputBox("Enter the site name:", "Edit").Trim
                    If s <> "" Then
                        Dim cnnoledb As New OleDbConnection(ConnectionString)
                        cnnoledb.Open()
                        Dim cmdOledb As New OleDbCommand
                        cmdOledb.Connection = cnnoledb
                        cmdOledb.CommandText = String.Format("UPDATE SITE set [Site Name]={0} WHERE ID={1};", GetWithQuot.WithQuot(s), id)
                        cmdOledb.CommandType = CommandType.Text
                        cmdOledb.ExecuteNonQuery()
                        cnnoledb.Close()
                        MsgBox("Site Updated Successfully Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done :-)")
                        LoadAll()
                    End If
                End If
            Else
                MsgBox("Please select one item to edit.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Function GetIDs() As List(Of Integer)
        Dim l As New List(Of Integer)
        For Each i As DataGridViewRow In SitesData.SelectedRows
            l.Add(i.Cells(0).Value.ToString)
        Next
        Return l
    End Function
    Sub DeleteSite(ByVal ID As Integer)
        Try
            Dim cnnoledb As New OleDbConnection(ConnectionString)
            cnnoledb.Open()
            Dim cmddelete As New OleDbCommand
            cmddelete.CommandText = "DELETE FROM SITE WHERE ID =" & ID & ";"
            cmddelete.CommandType = CommandType.Text
            cmddelete.Connection = cnnoledb
            cmddelete.ExecuteNonQuery()
            cmddelete.Dispose()
            cnnoledb.Close()
            LoadAll()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        Dim i As List(Of Integer) = GetIDs()
        If i.Count > 0 Then
            If MsgBox("Once an item deleted you can't recover it. Are you sure to delete selected " & i.Count & " item(s)?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Make Sure...") = MsgBoxResult.Yes Then
                For Each id As Integer In i
                    DeleteSite(id)
                Next
                MsgBox(i.Count & " items successfully deleted.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            End If
        End If
    End Sub
End Class