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
'                                                                          '
'=========================================================================='

Imports Devil7.Automation.OMS.Lib

Public Class frm_Main

    Dim User As Objects.User

    Dim Users As List(Of Objects.User)
    Dim Clients As List(Of Objects.Client)
    Dim Jobs As List(Of Objects.Job)

    Dim Loaded As Boolean = False

    Sub New(User As Objects.User)
        InitializeComponent()
        Me.User = User
    End Sub

#Region "Functions"
    Sub HideOptions()
        rpg_Clients.Visible = False
        rpg_Jobs.Visible = False
        rpg_Users.Visible = False
        rpg_Workbook.Visible = False
        rpg_Home.Visible = False
        grp_btn_Clients_View.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Sub UsersPageLoad()
        rpg_Users.Visible = True
        If gc_Users.DataSource Is Nothing Then
            If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
        End If
    End Sub

    Sub JobsPageLoad()
        rpg_Jobs.Visible = True
        If gc_Jobs.DataSource Is Nothing Then
            If Not Loader_Jobs.IsBusy Then Loader_Jobs.RunWorkerAsync()
        End If
    End Sub

    Sub ClientsPageLoad()
        rpg_Clients.Visible = True
        grp_btn_Clients_View.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_Clients.DataSource Is Nothing Then
            If Not Loader_Clients.IsBusy Then Loader_Clients.RunWorkerAsync()
        End If
    End Sub

    Sub WorkbookPageLoad()
        rpg_Workbook.Visible = True
        If gc_WorkBook.DataSource Is Nothing Then
            If Not Loader_Workbook.IsBusy Then Loader_Workbook.RunWorkerAsync()
        End If
    End Sub

    Sub HomePageLoad()
        rpg_Home.Visible = True
        If gc_Home.DataSource Is Nothing Then
            If Not Loader_Home.IsBusy Then Loader_Home.RunWorkerAsync()
        End If
    End Sub
#End Region

    Private Sub MainPane_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles MainPane.SelectedPageChanged
        HideOptions()
        If MainPane.SelectedPage Is np_Users Then
            UsersPageLoad()
        ElseIf MainPane.SelectedPage Is np_Jobs Then
            JobsPageLoad()
        ElseIf MainPane.SelectedPage Is np_Clients Then
            ClientsPageLoad()
        ElseIf MainPane.SelectedPage Is np_Workbook Then
            WorkbookPageLoad()
        ElseIf MainPane.SelectedPage Is np_Home Then
            HomePageLoad()
        End If
    End Sub

    Private Sub MainPane_StateChanged(sender As Object, e As DevExpress.XtraBars.Navigation.StateChangedEventArgs) Handles MainPane.StateChanged
        If MainPane.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed Then MainPane.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Regular
    End Sub

    Private Sub Loader_Users_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Users.DoWork
        Me.Invoke(Sub()
                      rpg_Users.Enabled = False
                      ProgressPanel_Users.Visible = True
                  End Sub)
        Try
            Dim Users As List(Of Objects.User) = Database.Users.GetAll(True)
            Me.Users = Users
            Me.Invoke(Sub()
                          gc_Users.DataSource = Users
                      End Sub)
        Catch ex As Exception

        End Try
        Me.Invoke(Sub()
                      rpg_Users.Enabled = True
                      ProgressPanel_Users.Visible = False
                  End Sub)
    End Sub

    Private Sub btn_RefreshUsers_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshUsers.ItemClick
        If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
    End Sub

    Private Sub btn_AddUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AddUser.ItemClick
        Dim d As New frm_User(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(gc_Users.DataSource, List(Of Objects.User)).Add(d.User)
        End If
    End Sub

    Private Sub btn_EditUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditUser.ItemClick
        If tv_Users.SelectedRowsCount = 1 Then
            Dim row As Objects.User = tv_Users.GetRow(tv_Users.GetSelectedRows()(0))
            Dim d As New frm_User(Enums.DialogMode.Edit, row.ID)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_RemoveUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RemoveUser.ItemClick
        If tv_Users.SelectedRowsCount > 0 Then
            Dim sr As Integer() = tv_Users.GetSelectedRows
            For Each i As Integer In sr
                Dim row As Objects.User = tv_Users.GetRow(i)
                If Database.Users.Remove(row.ID) Then
                    CType(gc_Users.DataSource, List(Of Objects.User)).Remove(row)
                End If
            Next
            gc_Users.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_ResetPassword_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ResetPassword.ItemClick
        If tv_Users.SelectedRowsCount = 1 Then
            If MsgBox("Are you sure to reset password for selected user...?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure..?") = MsgBoxResult.Yes Then
                Dim row As Objects.User = tv_Users.GetRow(tv_Users.GetSelectedRows(0))
                Database.Users.ResetPassword(User.ID, True)
            End If
        End If
    End Sub

    Private Sub btn_EditProfile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditProfile.ItemClick
        Dim d As New frm_User(Enums.DialogMode.Edit, User.ID)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            User = Database.Users.GetUserByID(User.ID)
            If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_ChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ChangePassword.ItemClick
        Dim d As New frm_ChangePassword(User)
        d.ShowDialog()
    End Sub

    Private Sub btn_Exit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Exit.ItemClick
        Me.Close()
    End Sub

    Private Sub Loader_Jobs_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Jobs.DoWork
        Me.Invoke(Sub()
                      rpg_Jobs.Enabled = False
                      ProgressPanel_Jobs.Visible = True
                  End Sub)
        Try
            Dim Jobs As List(Of Objects.Job) = Database.Jobs.GetAll(True)
            Me.Jobs = Jobs
            Me.Invoke(Sub()
                          gc_Jobs.DataSource = Jobs
                      End Sub)
        Catch ex As Exception

        End Try
        Me.Invoke(Sub()
                      rpg_Jobs.Enabled = True
                      ProgressPanel_Jobs.Visible = False
                  End Sub)
    End Sub

    Private Sub btn_RefreshJobs_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshJobs.ItemClick
        If Not Loader_Jobs.IsBusy Then Loader_Jobs.RunWorkerAsync()
    End Sub

    Private Sub btn_NewJob_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_NewJob.ItemClick
        Dim group, subgroup As New List(Of String)
        For Each i As Objects.Job In CType(gc_Jobs.DataSource, List(Of Objects.Job))
            If group.Contains(i.Group) = False AndAlso i.SubGroup.Trim <> "" Then group.Add(i.Group)
            If subgroup.Contains(i.SubGroup) = False AndAlso i.SubGroup.Trim <> "" Then subgroup.Add(i.SubGroup)
        Next
        Dim d As New frm_Job(Enums.DialogMode.Add, group.ToArray, subgroup.ToArray)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            If d.Job IsNot Nothing Then
                CType(gc_Jobs.DataSource, List(Of Objects.Job)).Add(d.Job)
                gc_Jobs.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_EditJob_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditJob.ItemClick
        If gv_Jobs.SelectedRowsCount = 1 Then
            Dim row As Objects.Job = gv_Jobs.GetRow(gv_Jobs.GetSelectedRows()(0))
            Dim group, subgroup As New List(Of String)
            For Each i As Objects.Job In CType(gc_Jobs.DataSource, List(Of Objects.Job))
                If group.Contains(i.Group) = False AndAlso i.SubGroup.Trim <> "" Then group.Add(i.Group)
                If subgroup.Contains(i.SubGroup) = False AndAlso i.SubGroup.Trim <> "" Then subgroup.Add(i.SubGroup)
            Next
            Dim d As New frm_Job(Enums.DialogMode.Edit, group.ToArray, subgroup.ToArray, row.ID)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not Loader_Jobs.IsBusy Then Loader_Jobs.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_RemoveJob_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RemoveJob.ItemClick
        If gv_Jobs.SelectedRowsCount > 0 Then
            Dim sr As Integer() = gv_Jobs.GetSelectedRows
            For Each i As Integer In sr
                Dim row As Objects.Job = gv_Jobs.GetRow(i)
                If Database.Jobs.Remove(row.ID) Then CType(gc_Jobs.DataSource, List(Of Objects.Job)).Remove(row)
            Next
            gc_Jobs.RefreshDataSource()
        End If
    End Sub

    Private Sub Loader_Clients_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Clients.DoWork
        Me.Invoke(Sub()
                      rpg_Clients.Enabled = False
                      ProgressPanel_Clients.Visible = True
                  End Sub)
        Try
            Dim Clients As List(Of Objects.Client) = Database.Clients.GetAll(True)
            Me.Clients = Clients
            Me.Invoke(Sub()
                          gc_Clients.DataSource = Clients
                      End Sub)
        Catch ex As Exception

        End Try
        Me.Invoke(Sub()
                      rpg_Clients.Enabled = True
                      ProgressPanel_Clients.Visible = False
                  End Sub)
    End Sub

    Private Sub btn_RefreshClients_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshClients.ItemClick
        If Not Loader_Clients.IsBusy Then Loader_Clients.RunWorkerAsync()
    End Sub

    Private Sub btn_Clients_DetailsView_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Clients_DetailsView.ItemClick
        If gc_Clients.MainView IsNot gv_Clients Then
            gc_Clients.MainView = gv_Clients
        End If
    End Sub

    Private Sub btn_Clients_CardView_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Clients_CardView.ItemClick
        If gc_Clients.MainView IsNot tv_Clients Then
            gc_Clients.MainView = tv_Clients
        End If
    End Sub

    Private Sub btn_AddClient_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AddClient.ItemClick
        Dim d As New frm_ClientAddEdit(Enums.DialogMode.Add)
        If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If d.Client IsNot Nothing Then
                CType(gc_Clients.DataSource, List(Of Objects.Client)).Add(d.Client)
                gc_Clients.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_EditClient_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditClient.ItemClick
        Dim Selected As Objects.Client = Nothing
        If gc_Clients.MainView Is gv_Clients AndAlso gv_Clients.SelectedRowsCount = 1 Then
            Selected = gv_Clients.GetRow(gv_Clients.GetSelectedRows(0))
        ElseIf gc_Clients.MainView Is tv_Clients AndAlso tv_Clients.SelectedRowsCount = 1 Then
            Selected = tv_Clients.GetRow(tv_Clients.GetSelectedRows(0))
        End If
        If Selected IsNot Nothing Then
            Dim d As New frm_ClientAddEdit(Enums.DialogMode.Edit, Selected.ID)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not Loader_Clients.IsBusy Then Loader_Clients.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_RemoveClient_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RemoveClient.ItemClick
        Dim Selected As List(Of Objects.Client) = Nothing
        If gc_Clients.MainView Is gv_Clients AndAlso gv_Clients.SelectedRowsCount > 0 Then
            Selected = New List(Of Objects.Client)
            For Each i As Integer In gv_Clients.GetSelectedRows
                Selected.Add(gv_Clients.GetRow(i))
            Next
        ElseIf gc_Clients.MainView Is tv_Clients AndAlso tv_Clients.SelectedRowsCount > 0 Then
            Selected = New List(Of Objects.Client)
            For Each i As Integer In tv_Clients.GetSelectedRows
                Selected.Add(tv_Clients.GetRow(i))
            Next
        End If
        If Selected IsNot Nothing Then
            If MsgBox("Are you sure...? do you want to delete all selected clients...?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
                For Each i As Objects.Client In Selected
                    Dim result As Boolean = Database.Clients.Remove(i.ID)
                    If result Then
                        CType(gc_Clients.DataSource, List(Of Objects.Client)).Remove(i)
                    Else
                        MsgBox("Error on deleting client with id " & i.ID, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                    End If
                Next
                gc_Clients.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub Loader_Workbook_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Workbook.DoWork
        Me.Invoke(Sub()
                      rpg_Workbook.Enabled = False
                      ProgressPanel_Workbook.Visible = True
                  End Sub)

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Workbook.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If
        If Jobs Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Workbook.Description = "Loading Jobs..."
                      End Sub)
            Loader_Jobs_DoWork(Me, Nothing)
        End If
        If Clients Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Workbook.Description = "Loading Clients..."
                      End Sub)
            Loader_Clients_DoWork(Me, Nothing)
        End If

        Me.Invoke(Sub()
                      ProgressPanel_Workbook.Description = "Loading Workbook..."
                  End Sub)
        Try
            Dim Workbook As List(Of Objects.WorkbookItem) = Database.Workbook.GetAll(True, Clients, Jobs, Users)
            Me.Invoke(Sub()
                          gc_WorkBook.DataSource = Workbook
                      End Sub)
        Catch ex As Exception

        End Try
        Me.Invoke(Sub()
                      rpg_Workbook.Enabled = True
                      ProgressPanel_Workbook.Visible = False
                  End Sub)
    End Sub

    Private Sub btn_RefreshWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshWork.ItemClick
        If Not Loader_Workbook.IsBusy Then Loader_Workbook.RunWorkerAsync()
    End Sub

    Private Sub btn_AddWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AddWork.ItemClick
        Dim d As New frm_WorkBook(Enums.DialogMode.Add, User, Jobs, Clients, Users)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(gc_WorkBook.DataSource, List(Of Objects.WorkbookItem)).Add(d.WorkItemSelected)
            gc_WorkBook.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_EditWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditWork.ItemClick
        If gv_WorkBook.SelectedRowsCount = 1 Then
            Dim row As Objects.WorkbookItem = gv_WorkBook.GetRow(gv_WorkBook.GetSelectedRows()(0))
            Dim d As New frm_WorkBook(Enums.DialogMode.Edit, User, Jobs, Clients, Users, row.ID)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not Loader_Workbook.IsBusy Then Loader_Workbook.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btn_RemoveWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RemoveWork.ItemClick
        If gv_WorkBook.SelectedRowsCount > 0 Then
            Dim sr As Integer() = gv_WorkBook.GetSelectedRows
            For Each i As Integer In sr
                Dim row As Objects.WorkbookItem = gv_WorkBook.GetRow(i)
                If Database.Workbook.Remove(row.ID) Then CType(gc_WorkBook.DataSource, List(Of Objects.WorkbookItem)).Remove(row)
            Next
            gc_WorkBook.RefreshDataSource()
        End If
    End Sub

    Private Sub Loader_Home_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Home.DoWork
        While Loaded = False
            Threading.Thread.Sleep(1000)
        End While
        Me.Invoke(Sub()
                      ProgressPanel_Home.Visible = True
                      rpg_Home.Enabled = False
                      ContextMenu_Home.Enabled = False
                  End Sub)

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Home.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If
        If Jobs Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Home.Description = "Loading Jobs..."
                      End Sub)
            Loader_Jobs_DoWork(Me, Nothing)
        End If
        If Clients Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Home.Description = "Loading Clients..."
                      End Sub)
            Loader_Clients_DoWork(Me, Nothing)
        End If

        Me.Invoke(Sub()
                      ProgressPanel_Home.Description = "Loading Home..."
                  End Sub)
        Try
            Dim Home As List(Of Objects.WorkbookItem) = Database.Workbook.GetAllForUser(True, Clients, Jobs, Users, User.ID)
            Me.Invoke(Sub()
                          gc_Home.DataSource = Home
                      End Sub)
        Catch ex As Exception

        End Try
        Me.Invoke(Sub()
                      ProgressPanel_Home.Visible = False
                      rpg_Home.Enabled = True
                      ContextMenu_Home.Enabled = True
                  End Sub)
    End Sub

    Private Sub frm_Main_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frm_Main_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Loaded = True
    End Sub

    Private Sub ContextMenu_Home_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenu_Home.Opening
        If gv_Home.SelectedRowsCount <> 1 Then
            e.Cancel = True
        Else
            Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
            UpdateStatusToolStripMenuItem.DropDownItems.Clear()
            For Each i As String In [Enum].GetNames(GetType(Enums.WorkStatus))
                Dim b = UpdateStatusToolStripMenuItem.DropDownItems.Add(i)
                AddHandler b.Click, AddressOf UpdateStatus
            Next
            UpdateStepToolStripMenuItem.DropDownItems.Clear()
            For Each i As String In row.Job.Steps
                Dim b = UpdateStepToolStripMenuItem.DropDownItems.Add(i)
                AddHandler b.Click, AddressOf UpdateStep
            Next
            AssignToToolStripMenuItem.DropDownItems.Clear()
            For Each i As Objects.User In Users
                Dim b = AssignToToolStripMenuItem.DropDownItems.Add(i.Username)
                AddHandler b.Click, AddressOf AssignTo
            Next
        End If
    End Sub

    Private Sub UpdateStatus(sender As System.Object, e As EventArgs)
        Try
            Dim s As Enums.WorkStatus = Enums.Functions.StringToEnum(Of Enums.WorkStatus)(sender.Text)
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.UpdateStatus(row.ID, s.ToString, (row.GetHistory & vbNewLine & "Status updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    MsgBox("Successfully updated status of selected work.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Else
                    MsgBox("Unknown error on updating status of selected work.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                End If
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on updating status of selected work.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub UpdateStep(sender As System.Object, e As EventArgs)
        Try
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.UpdateStep(row.ID, sender.Text, (row.GetHistory & vbNewLine & "Step/Stage updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    MsgBox("Successfully updated step of selected work.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Else
                    MsgBox("Unknown error on updating step of selected work.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                End If
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on updating step of selected work.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub AssignTo(sender As System.Object, e As EventArgs)
        Dim user As Objects.User = Me.User
        Try

            For Each i As Objects.User In Users
                If i.Username = sender.Text Then
                    User = i
                End If
            Next
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.AssignTo(row.ID, User.ID, (row.GetHistory & vbNewLine & "Work transferred from " & row.AssignedTo.Username & " to " & User.Username & " by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    MsgBox("Successfully assigned selected work to the user " & User.Username & ".", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Else
                    MsgBox("Unknown error on assigning selected work to the user " & User.Username & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                End If
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on assigning selected work to the user {1}.{0}{0}{0}Additional Information:{0}{2}{0}{0}{3}", vbNewLine, user.Username, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub frm_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MainPane.SelectedPageIndex = 0
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        For Each i As Form In Application.OpenForms
            If TypeOf i Is XtraFormTemp Then
                i.Close()
            End If
        Next
    End Sub

    Private Sub btn_RefreshHome_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshHome.ItemClick
        If Not Loader_Home.IsBusy Then Loader_Home.RunWorkerAsync()
    End Sub
End Class