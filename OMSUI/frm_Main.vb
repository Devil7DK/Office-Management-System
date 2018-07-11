Imports Devil7.Automation.OMS.Lib
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frm_Main
    Property UserData As User
    Dim Loaded As Boolean = False
    Function Jobs() As System.ComponentModel.BindingList(Of Job)
        Return dgv_Jobs.DataSource
    End Function
    Function Clients() As System.ComponentModel.BindingList(Of Client)
        Return dgv_Clients.DataSource
    End Function
    Function Users() As System.ComponentModel.BindingList(Of User)
        Return dgv_Users.DataSource
    End Function
    Function Works() As System.ComponentModel.BindingList(Of WorkbookItem)
        Return dgv_WorkBook.DataSource
    End Function
    Function Home() As System.ComponentModel.BindingList(Of WorkbookItem)
        Return dgv_Home.DataSource
    End Function
    Function LoadHome() As System.ComponentModel.BindingList(Of WorkbookItem)
        Dim bl As New System.ComponentModel.BindingList(Of WorkbookItem)
        For Each i As WorkbookItem In Works()
            If i.AssignedTo.ID = UserData.ID Then
                bl.Add(i)
            End If
        Next
        Return bl
    End Function
    Sub SetReadOnly(GV As DevExpress.XtraGrid.Views.Grid.GridView)
        AddHandler GV.ShowingEditor, AddressOf ReadOnly_ShowingEditor
    End Sub
    Sub ColumnResize(ByVal GV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal g As Graphics)
        GV.OptionsView.ColumnAutoWidth = False
        For Each i As DevExpress.XtraGrid.Columns.GridColumn In GV.Columns
            i.Width = g.MeasureString(i.GetTextCaption, GV.GridControl.Font).Width + 10
        Next
    End Sub
    Sub ReLoadJob()
        dgv_Jobs.DataSource = LoadJob()
    End Sub
    Sub ReLoadClients()
        Dim cr As New System.ComponentModel.BindingList(Of CredentialWithClient)
        dgv_Clients.DataSource = LoadClients(Jobs, cr)
        dgv_Credentials.DataSource = cr
    End Sub
    Sub ReLoadUsers()
        dgv_Users.DataSource = LoadUsers()
    End Sub
    Sub ReLoadWorks()
        dgv_WorkBook.DataSource = LoadWorks(Clients, Jobs, Users)
    End Sub
    Sub ReLoadHome()
        dgv_Home.DataSource = LoadHome()
    End Sub
    Private Sub frm_Main_GenUser_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Skin = Me.GetSkin.Name
        My.Settings.Save()
        End
    End Sub
    Sub LoadSettings()
        Me.txt_ServerName.Text = GetSettings.ServerName
        Me.txt_SQLServerPassword.Text = GetSettings.Password
        Me.txt_SQLServerUserID.Text = GetSettings.UserName
        Me.txt_DatabaseName.Text = GetSettings.DatabaseName
        Me.txt_DefaultStorage.Text = GetSettings.DefaultStorage
        Me.txt_Pooling.IsOn = GetSettings.Pooling
    End Sub
    Sub SaveSettings()
        GetSettings.ServerName = Me.txt_ServerName.Text
        GetSettings.Password = Me.txt_SQLServerPassword.Text
        GetSettings.UserName = Me.txt_SQLServerUserID.Text
        GetSettings.DatabaseName = Me.txt_DatabaseName.Text
        GetSettings.DefaultStorage = Me.txt_DefaultStorage.Text
        GetSettings.Pooling = Me.txt_Pooling.IsOn
        My.Settings.Save()
    End Sub
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Loaded = False
        SetVisiblePermissions()
        Main_Pane.SelectedPage = np_Home
        Try
            If My.Settings.Skin <> "" Then
                Me.DefaultLookAndFeel1.LookAndFeel.SkinName = My.Settings.Skin
            End If
        Catch ex As Exception

        End Try
        ReLoadJob()
        ReLoadClients()
        ReLoadUsers()
        ReLoadWorks()
        ReLoadHome()
        Dim g As Graphics = Me.CreateGraphics
        LoadUtilities(Panel_Utilities)
        ColumnResize(GridView_Job, g) : ColumnResize(GridView_Workbook, g) : ColumnResize(GridView_Home, g)
        GridView_Job.OptionsBehavior.ReadOnly = True
        GridView_Clients.OptionsBehavior.ReadOnly = True
        GridView_Workbook.OptionsBehavior.ReadOnly = True
        GridView_Credentials.OptionsBehavior.ReadOnly = True
        GridView_Home.OptionsBehavior.ReadOnly = True
        LoadSettings()
        Try
            GC.Collect()
        Catch ex As Exception

        End Try
        cb_Client_View.SelectedIndex = My.Settings.View_Client_Current
        SetClientView()
        Loaded = True
    End Sub
    Sub New(ByVal UserData As User)
        Me.UserData = UserData
        InitializeComponent()
    End Sub

    Private Sub btn_Client_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Add.ItemClick
        'Dim d As New frm_ClientAddEdit(DialogMode.Add, Jobs)
        'If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    ReLoadClients()
        'End If
    End Sub

    Private Sub btn_Jobs_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Add.ItemClick
        Dim group, subgroup As New List(Of String)
        For Each i As Job In Jobs()
            group.Add(i.Group)
            subgroup.Add(i.SubGroup)
        Next
        'Dim d As New frm_Job(DialogMode.Add, group.ToArray, subgroup.ToArray)
        'If d.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    ReLoadJob()
        'End If
    End Sub

    Private Sub Main_Pane_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles Main_Pane.SelectedPageChanged
        'rpc_Jobs.Visible = False
        'rpc_Clients.Visible = False
        'rpc_Workbook.Visible = False
        'rpc_User.Visible = False
        'rb_Home.Visible = False
        'If e.Page Is np_Clients Then
        '    If CheckHasPermission(UserPermissions.EditClient) Or CheckHasPermission(UserPermissions.AddClient) Then
        '        rpc_Jobs.Visible = False
        '        rpc_Clients.Visible = True
        '        rpc_Workbook.Visible = False
        '        rpc_User.Visible = False
        '    End If
        'ElseIf e.Page Is np_Jobs Then
        '    If CheckHasPermission(UserPermissions.EditJob) Or CheckHasPermission(UserPermissions.AddJob) Then
        '        rpc_Jobs.Visible = True
        '        rpc_Clients.Visible = False
        '        rpc_Workbook.Visible = False
        '        rpc_User.Visible = False
        '    End If
        'ElseIf e.Page Is np_Workbook Then
        '    If CheckHasPermission(UserPermissions.EditWork) Or CheckHasPermission(UserPermissions.AddWork) Then
        '        rpc_Jobs.Visible = False
        '        rpc_Clients.Visible = False
        '        rpc_Workbook.Visible = True
        '        rpc_User.Visible = False
        '    End If
        'ElseIf e.Page Is np_Users Then
        '    If CheckHasPermission(UserPermissions.EditUser) Or CheckHasPermission(UserPermissions.CreateUser) Then
        '        rp_User.Visible = True
        '        rb_Jobs.Visible = False
        '        rp_Clients.Visible = False
        '        rp_Workbook.Visible = False
        '    End If
        'ElseIf e.Page Is np_Home Then
        '    rb_Home.Visible = True
        'End If
    End Sub

    Private Sub ReadOnly_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs)
        e.Cancel = True
    End Sub
    Private Sub SetVisiblePermissions()
        'SetBooleanPermission(UserPermissions.AddClient, btn_Client_Add.Enabled)
        'SetBooleanPermission(UserPermissions.AddJob, btn_Jobs_Add.Enabled)
        'SetBooleanPermission(UserPermissions.AddWork, btn_Workbook_Add.Enabled)
        'SetBooleanPermission(UserPermissions.CreateUser, btn_User_Add.Enabled)
        'SetBooleanPermission(UserPermissions.EditClient, btn_Client_Edit.Enabled)
        'SetBooleanPermission(UserPermissions.EditJob, btn_Job_Edit.Enabled)
        'SetBooleanPermission(UserPermissions.EditUser, btn_User_Edit.Enabled)
        'SetBooleanPermission(UserPermissions.EditWork, btn_Workbook_Edit.Enabled)
        'SetBooleanPermission(UserPermissions.EditClient, btn_Client_Remove.Enabled)
        'SetBooleanPermission(UserPermissions.EditJob, btn_Job_Remove.Enabled)
        'SetBooleanPermission(UserPermissions.EditUser, btn_User_Remove.Enabled)
        'SetBooleanPermission(UserPermissions.EditWork, btn_Workbook_Remove.Enabled)
        'SetBooleanPermission(UserPermissions.ViewAllCredentials, np_Credentials.PageVisible)
        'SetBooleanPermission(UserPermissions.ViewClient, np_Clients.PageVisible)
        'SetBooleanPermission(UserPermissions.ViewJob, np_Jobs.PageVisible)
        'SetBooleanPermission(UserPermissions.ViewUser, np_Users.PageVisible)
        'SetBooleanPermission(UserPermissions.ViewWork, np_Workbook.PageVisible)
        'SetBooleanPermission(UserPermissions.System, np_Settings.PageVisible)
    End Sub
    'Private Sub SetBooleanPermission(ByVal PermissionToCheck As UserPermissions, ByRef Bool As Boolean)
    '    If UserData.UserType = UserType.Administrator.ToString Then
    '        Bool = True
    '    ElseIf UserData.Permissions.Contains(UserPermissions.System.ToString) Then
    '        Bool = True
    '    Else
    '        Bool = UserData.Permissions.Contains(PermissionToCheck.ToString)
    '    End If
    'End Sub
    'Private Function CheckHasPermission(ByVal PermissionToCheck As UserPermissions) As Boolean
    '    If UserData.UserType = UserType.Administrator.ToString Then
    '        Return True
    '    ElseIf UserData.Permissions.Contains(UserPermissions.System.ToString) Then
    '        Return True
    '    Else
    '        Return UserData.Permissions.Contains(PermissionToCheck.ToString)
    '    End If
    'End Function
    'Private Sub btn_Workbook_Add_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Workbook_Add.ItemClick
    '    Dim d As New frm_WorkBook(DialogMode.Add, UserData, Jobs, Clients, Users)
    '    If d.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        ReLoadWorks()
    '    End If
    'End Sub

    'Private Sub btn_Job_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Job_Edit.ItemClick
    '    If GridView_Job.SelectedRowsCount = 1 Then
    '        Dim row As Job = GridView_Job.GetRow(GridView_Job.GetSelectedRows()(0))
    '        Dim group, subgroup As New List(Of String)
    '        For Each i As Job In Jobs()
    '            If group.Contains(i.Group) = False AndAlso i.SubGroup.Trim <> "" Then group.Add(i.Group)
    '            If subgroup.Contains(i.SubGroup) = False AndAlso i.SubGroup.Trim <> "" Then subgroup.Add(i.SubGroup)
    '        Next
    '        Dim d As New frm_Job(DialogMode.Edit, group.ToArray, subgroup.ToArray, row.ID)
    '        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            ReLoadJob()
    '        End If
    '    End If
    'End Sub

    'Private Sub btn_Job_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Job_Remove.ItemClick
    '    If GridView_Job.SelectedRowsCount > 0 Then
    '        Dim conn As New SqlConnection(ConnectionString)
    '        conn.Open()
    '        Dim sr As Integer() = GridView_Job.GetSelectedRows
    '        For Each i As Integer In sr
    '            Dim row As Job = GridView_Job.GetRow(i)
    '            Dim comm As New SqlCommand("DELETE FROM Jobs WHERE [ID]=" & row.ID & ";", conn)
    '            comm.ExecuteNonQuery()
    '            CType(dgv_Jobs.DataSource, System.ComponentModel.BindingList(Of Job)).Remove(row)
    '        Next
    '        conn.Close()
    '        ReLoadJob()
    '    End If
    'End Sub

    'Private Sub btn_User_Add_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_User_Add.ItemClick
    '    Dim d As New frm_User(DialogMode.Add)
    '    If d.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        ReLoadUsers()
    '    End If
    'End Sub

    Private Sub txt_FileSearch_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_FileSearch.ButtonClick
    End Sub

    Private Sub txt_FileSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_FileSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
        End If
    End Sub
    Sub ProcessSearchResultFile(ByVal Filename As String)
        Dim Fn As String = Filename
        If My.Computer.FileSystem.FileExists(Fn) Then
            Dim n As New BindingList(Of String)
            Dim r As New IO.StreamReader(Fn)
            While r.Read
                n.Add(r.ReadLine)
            End While
            dgv_Search.DataSource = n
        End If
    End Sub


    Private Sub btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click
        If MsgBox("Are you sure? Do you want to save these settings?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure!?") = MsgBoxResult.Yes Then
            SaveSettings()
        End If
    End Sub

    Private Sub btn_Reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_Reset.Click
        LoadSettings()
    End Sub

    Private Sub btn_ResetToDefault_Click(sender As System.Object, e As System.EventArgs) Handles btn_ResetToDefault.Click
        If MsgBox("Are you sure all of this application's settings will be reset to their default values.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure!?") = MsgBoxResult.Yes Then
            My.Settings.Reset()
            LoadSettings()
        End If
    End Sub

    Private Sub btn_Client_Edit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Client_Edit.ItemClick
        If GridView_Clients.SelectedRowsCount = 1 Then
            Dim row As Client = GridView_Clients.GetRow(GridView_Clients.GetSelectedRows()(0))
            'Dim d As New frm_ClientAddEdit(DialogMode.Edit, Jobs, row.ID)
            'If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    ReLoadClients()
            'End If
        End If
    End Sub

    Private Sub btn_Client_Remove_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Client_Remove.ItemClick
        If GridView_Clients.SelectedRowsCount > 0 Then
            Dim conn As New SqlConnection(ConnectionString)
            conn.Open()
            Dim sr As Integer() = GridView_Clients.GetSelectedRows
            For Each i As Integer In sr
                Dim row As Client = GridView_Clients.GetRow(i)
                Dim comm As New SqlCommand("DELETE FROM Clients WHERE [ID]=" & row.ID & ";", conn)
                comm.ExecuteNonQuery()
                CType(dgv_Clients.DataSource, System.ComponentModel.BindingList(Of Client)).Remove(row)
            Next
            conn.Close()
            ReLoadClients()
        End If
    End Sub

    Private Sub btn_Workbook_Edit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Workbook_Edit.ItemClick
        If GridView_Workbook.SelectedRowsCount = 1 Then
            Dim row As WorkbookItem = GridView_Workbook.GetRow(GridView_Workbook.GetSelectedRows()(0))
            Dim d As New frm_WorkBook(DialogMode.Edit, UserData, Jobs, Clients, Users, row.ID)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                ReLoadWorks()
            End If
        End If
    End Sub

    Private Sub btn_Workbook_Remove_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Workbook_Remove.ItemClick
        If GridView_Workbook.SelectedRowsCount > 0 Then
            Dim conn As New SqlConnection(ConnectionString)
            conn.Open()
            Dim sr As Integer() = GridView_Workbook.GetSelectedRows
            For Each i As Integer In sr
                Dim row As WorkbookItem = GridView_Workbook.GetRow(i)
                Dim comm As New SqlCommand("DELETE FROM Workbook WHERE [ID]=" & row.ID & ";", conn)
                comm.ExecuteNonQuery()
                CType(dgv_WorkBook.DataSource, System.ComponentModel.BindingList(Of WorkbookItem)).Remove(row)
            Next
            conn.Close()
            ReLoadWorks()
        End If
    End Sub

    Private Sub btn_User_Edit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_User_Edit.ItemClick
        If TileView_Users.SelectedRowsCount = 1 Then
            Dim row As User = TileView_Users.GetRow(TileView_Users.GetSelectedRows()(0))
            Dim d As New frm_User(DialogMode.Edit, row.ID)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                ReLoadUsers()
            End If
        End If
    End Sub

    Private Sub btn_User_Remove_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_User_Remove.ItemClick
        If TileView_Users.SelectedRowsCount > 0 Then
            Dim conn As New SqlConnection(ConnectionString)
            conn.Open()
            Dim sr As Integer() = TileView_Users.GetSelectedRows
            For Each i As Integer In sr
                Dim row As User = TileView_Users.GetRow(i)
                Dim comm As New SqlCommand("DELETE FROM Users WHERE [ID]=" & row.ID & ";", conn)
                comm.ExecuteNonQuery()
                CType(dgv_Users.DataSource, System.ComponentModel.BindingList(Of User)).Remove(row)
            Next
            conn.Close()
            ReLoadWorks()
        End If
    End Sub

    Private Sub ContextMenu_Home_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenu_Home.Opening
        If GridView_Workbook.SelectedRowsCount <> 1 Then
            e.Cancel = True
        Else
            Dim row As WorkbookItem = GridView_Workbook.GetRow(GridView_Workbook.GetSelectedRows()(0))
            UpdateStatusToolStripMenuItem.DropDownItems.Clear()
            For Each i As String In [Enum].GetNames(GetType(WorkStatus))
                Dim b = UpdateStatusToolStripMenuItem.DropDownItems.Add(i)
                AddHandler b.Click, AddressOf UpdateStatus
            Next
            UpdateStepToolStripMenuItem.DropDownItems.Clear()
            For Each i As String In row.Job.Steps
                Dim b = UpdateStepToolStripMenuItem.DropDownItems.Add(i)
                AddHandler b.Click, AddressOf UpdateStep
            Next
            AssignToToolStripMenuItem.DropDownItems.Clear()
            For Each i As User In Users()
                Dim b = AssignToToolStripMenuItem.DropDownItems.Add(i.Username)
                AddHandler b.Click, AddressOf AssignTo
            Next
        End If
    End Sub
    Private Sub UpdateStatus(sender As System.Object, e As EventArgs)
        Try
            Dim s As WorkStatus = StringToEnum(Of WorkStatus)(sender.Text)
            If GridView_Workbook.SelectedRowsCount = 1 Then
                Dim row As WorkbookItem = GridView_Workbook.GetRow(GridView_Workbook.GetSelectedRows()(0))
                GlobalCode.UpdateStatus(ConnectionString, row.ID, s.ToString, (row.GetHistory & vbNewLine & "Status updated by " & UserData.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateStep(sender As System.Object, e As EventArgs)
        Try
            If GridView_Workbook.SelectedRowsCount = 1 Then
                Dim row As WorkbookItem = GridView_Workbook.GetRow(GridView_Workbook.GetSelectedRows()(0))
                GlobalCode.UpdateStep(ConnectionString, row.ID, sender.Text, (row.GetHistory & vbNewLine & "Step/Stage updated by " & UserData.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AssignTo(sender As System.Object, e As EventArgs)
        Try
            Dim user As User = UserData
            For Each i As User In Users()
                If i.Username = sender.Text Then
                    user = i
                End If
            Next
            If GridView_Workbook.SelectedRowsCount = 1 Then
                Dim row As WorkbookItem = GridView_Workbook.GetRow(GridView_Workbook.GetSelectedRows()(0))
                GlobalCode.AssignTo(ConnectionString, row.ID, user.ID, (row.GetHistory & vbNewLine & "Work transferred from " & row.AssignedTo.Username & " to " & user.Username & " by " & UserData.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_EditUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditUser.ItemClick
        Dim d As New frm_User(DialogMode.Edit, UserData.ID)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReLoadUsers()
        End If
    End Sub

    Private Sub Main_Pane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Main_Pane.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String = ""
        For Each i As DevExpress.XtraGrid.Columns.GridColumn In GridView_Clients.Columns
            s += i.FieldName & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\fields.txt", s, False)
    End Sub

    Private Sub cb_Client_View_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Client_View.SelectedIndexChanged
        If loaded Then
            If cb_Client_View.SelectedIndex = 2 Then
                Dim b As New frm_CustomView(My.Settings.View_Client_All, My.Settings.View_Client_Custom)
                If b.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Settings.View_Client_Custom = b.Columns
                    My.Settings.View_Client_Current = cb_Client_View.SelectedIndex
                    SetClientView()
                Else
                    cb_Client_View.SelectedIndex = My.Settings.View_Client_Current
                End If
            Else
                My.Settings.View_Client_Current = cb_Client_View.SelectedIndex
                SetClientView()
            End If
        End If
    End Sub
    Sub SetClientView()
        Dim sc As Specialized.StringCollection = My.Settings.View_Client_All
        If cb_Client_View.Text = "Basic" Then
            sc = My.Settings.View_Client_Basic
        ElseIf cb_Client_View.Text = "Custom" Then
            sc = My.Settings.View_Client_Custom
        ElseIf cb_Client_View.Text = "Advanced" Then
            sc = My.Settings.View_Client_All
        End If
        For Each i As DevExpress.XtraGrid.Columns.GridColumn In GridView_Clients.Columns
            i.Visible = False
        Next
        For ind As Integer = sc.Count - 1 To 0 Step -1
            For Each i As DevExpress.XtraGrid.Columns.GridColumn In GridView_Clients.Columns
                If sc(ind) = i.FieldName Then
                    i.Visible = True
                End If
            Next
        Next
    End Sub
End Class