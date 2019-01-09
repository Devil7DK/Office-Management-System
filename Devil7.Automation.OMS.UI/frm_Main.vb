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

Imports DevExpress.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid
Imports Devil7.Automation.OMS.Lib

Public Class frm_Main

    Dim User As Objects.User

    Dim Users As List(Of Objects.User)
    Dim Clients As List(Of Objects.Client)
    Dim Jobs As List(Of Objects.Job)
    Dim ClientsMinimal As List(Of Objects.ClientMinimal)

    Dim RAMUsed As ULong
    Dim Loaded As Boolean = False

    Dim LoginInstance As frm_Login

    Sub New(User As Objects.User, LoginInstance As frm_Login)
        InitializeComponent()
        Me.User = User
        Me.LoginInstance = LoginInstance
    End Sub

#Region "Functions"
    Sub HideOptions()
        rpg_Clients.Visible = False
        rpg_Jobs.Visible = False
        rpg_Users.Visible = False
        rpg_Workbook.Visible = False
        rpg_Billing.Visible = False
        rpg_Home.Visible = False
        rpg_AutoForwards.Visible = False
        rpg_Transferred.Visible = False
        rpg_Pending.Visible = False
        grp_btn_Clients_View.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        cmb_HomeView.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        cmb_WorkbookView.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        cmb_BillingView.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        cmb_PendingView.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        cmb_ClientsSort.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        switch_PreviewPane.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        If gc_Clients.MainView Is gv_Clients Then
            cmb_ClientsSort.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            cmb_ClientsSort.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
        If gc_Clients.DataSource Is Nothing Then
            If Not Loader_Clients.IsBusy Then Loader_Clients.RunWorkerAsync()
        End If
    End Sub

    Sub WorkbookPageLoad()
        rpg_Workbook.Visible = True
        cmb_WorkbookView.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_WorkBook.DataSource Is Nothing Then
            If Not Loader_Workbook.IsBusy Then Loader_Workbook.RunWorkerAsync()
        End If
    End Sub

    Sub HomePageLoad()
        rpg_Home.Visible = True
        cmb_HomeView.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        switch_PreviewPane.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_Home.DataSource Is Nothing Then
            If Not Loader_Home.IsBusy Then Loader_Home.RunWorkerAsync()
        End If
    End Sub

    Sub AutoForwardsPageLoad()
        rpg_AutoForwards.Visible = True
        switch_PreviewPane.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_AutoForwards.DataSource Is Nothing Then
            If Not Loader_AutoForwards.IsBusy Then Loader_AutoForwards.RunWorkerAsync()
        End If
    End Sub

    Sub TransferredPageLoad()
        rpg_Transferred.Visible = True
        switch_PreviewPane.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_Transferred.DataSource Is Nothing Then
            If Not Loader_Transferred.IsBusy Then Loader_Transferred.RunWorkerAsync()
        End If
    End Sub

    Sub UtilitiesPageLoad()
        If Panel_Utilities.Groups.Count = 0 Then
            If Not Loader_Utilities.IsBusy Then Loader_Utilities.RunWorkerAsync()
        End If
    End Sub

    Sub BillingPageLoad()
        rpg_Billing.Visible = True
        cmb_BillingView.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_Billing.DataSource Is Nothing Then
            If Not Loader_Billing.IsBusy Then Loader_Billing.RunWorkerAsync()
        End If
    End Sub

    Sub PendingPageLoad()
        rpg_Pending.Visible = True
        cmb_PendingView.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If gc_Pending.DataSource Is Nothing Then
            If Not Loader_Pending.IsBusy Then Loader_Pending.RunWorkerAsync()
        End If
    End Sub
#End Region

    Private Sub MainPane_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles MainPane.SelectedPageChanged
        Utils.Misc.CleanRAM()
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
        ElseIf MainPane.SelectedPage Is np_AutoForwards Then
            AutoForwardsPageLoad()
        ElseIf MainPane.SelectedPage Is np_Transferred Then
            TransferredPageLoad()
        ElseIf MainPane.SelectedPage Is np_Utilities Then
            UtilitiesPageLoad()
        ElseIf MainPane.SelectedPage Is np_Billing Then
            BillingPageLoad()
        ElseIf MainPane.SelectedPage Is np_Pending Then
            PendingPageLoad()
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
            MsgBox("Error on loading Users: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      rpg_Users.Enabled = True
                      ProgressPanel_Users.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub btn_RefreshUsers_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshUsers.ItemClick
        If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
    End Sub

    Private Sub btn_AddUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AddUser.ItemClick
        Dim d As New Dialogs.frm_User(Enums.DialogMode.Add)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CType(gc_Users.DataSource, List(Of Objects.User)).Add(d.User)
        End If
    End Sub

    Private Sub btn_EditUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditUser.ItemClick
        If tv_Users.SelectedRowsCount = 1 Then
            Dim row As Objects.User = tv_Users.GetRow(tv_Users.GetSelectedRows()(0))

            If row.UserType >= User.UserType Then
                MsgBox("You cannot edit an user whose role is greater than or equal to you!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Else
                Dim d As New Dialogs.frm_User(Enums.DialogMode.Edit, row.ID, If(User.ID = row.ID, If(User.UserType = Enums.UserType.System, False, True), False))
                If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub btn_RemoveUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RemoveUser.ItemClick
        If tv_Users.SelectedRowsCount > 0 Then
            Dim sr As Integer() = tv_Users.GetSelectedRows
            For Each i As Integer In sr
                Dim row As Objects.User = tv_Users.GetRow(i)

                If row.UserType >= User.UserType Then
                    MsgBox("You cannot remove an user whose role is greater than or equal to you!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Else
                    If MsgBox("Are you sure? Do you want to remove selected user(s)..? " & vbNewLine & vbNewLine & "Note: This cannot be undone!", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure?") = MsgBoxResult.Yes Then
                        If Database.Users.Remove(row.ID) Then
                            CType(gc_Users.DataSource, List(Of Objects.User)).Remove(row)
                        End If
                    End If
                End If
            Next
            gc_Users.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_ResetPassword_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ResetPassword.ItemClick
        If tv_Users.SelectedRowsCount = 1 Then
            Dim row As Objects.User = tv_Users.GetRow(tv_Users.GetSelectedRows(0))
            If row.UserType >= User.UserType Then
                MsgBox("You cannot reset password of an user whose role is greater than or equal to you!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Else
                If MsgBox("Are you sure to reset password for selected user...?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure..?") = MsgBoxResult.Yes Then
                    Database.Users.ResetPassword(User.ID, True)
                End If
            End If
        End If
    End Sub

    Private Sub btn_EditProfile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditProfile.ItemClick
        Dim d As New Dialogs.frm_User(Enums.DialogMode.Edit, User.ID, True)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            User = Database.Users.GetUserByID(User.ID)
            If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_ChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ChangePassword.ItemClick
        Dim d As New Dialogs.frm_ChangePassword(User)
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

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Jobs.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If

        Try
            Dim Jobs As List(Of Objects.Job) = Database.Jobs.GetAll(True)
            Jobs.Sort(New Comparers.CompareByID)
            Me.Jobs = Jobs
            Me.Invoke(Sub()
                          gc_Jobs.DataSource = Jobs
                          gc_Jobs.RefreshDataSource()
                      End Sub)
        Catch ex As Exception
            MsgBox("Error on loading Jobs: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      rpg_Jobs.Enabled = True
                      ProgressPanel_Jobs.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
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
        Dim d As New Dialogs.frm_Job(Enums.DialogMode.Add, group.ToArray, subgroup.ToArray, Users)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
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
            Dim d As New Dialogs.frm_Job(Enums.DialogMode.Edit, group.ToArray, subgroup.ToArray, Users, row.ID)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
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
                          SortClients()
                      End Sub)
        Catch ex As Exception
            MsgBox("Error on loading Clients: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      rpg_Clients.Enabled = True
                      ProgressPanel_Clients.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
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
        Dim d As New Dialogs.frm_ClientAddEdit(Enums.DialogMode.Add)
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
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
            Dim d As New Dialogs.frm_ClientAddEdit(Enums.DialogMode.Edit, Selected.ID)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
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

        If ClientsMinimal Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Workbook.Description = "Loading Clients..."
                      End Sub)
            ClientsMinimal = Database.Clients.GetMinimal()
        End If

        Me.Invoke(Sub()
                      ProgressPanel_Workbook.Description = "Loading Workbook..."
                  End Sub)

        Try
            Dim Workbook As List(Of Objects.WorkbookItem) = Database.Workbook.GetIncomplete(True, Jobs, Users)
            Me.Invoke(Sub()
                          gc_WorkBook.DataSource = Workbook
                      End Sub)
            SetupWorkbookColumns()
        Catch ex As Exception
            MsgBox("Error on loading Workbook: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      rpg_Workbook.Enabled = True
                      ProgressPanel_Workbook.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub btn_RefreshWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshWork.ItemClick
        If Not Loader_Workbook.IsBusy Then Loader_Workbook.RunWorkerAsync()
    End Sub

    Private Sub btn_AddWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AddWork.ItemClick
        Dim d As New Dialogs.frm_WorkBook(Enums.DialogMode.Add, User, Jobs, ClientsMinimal, Users)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CType(gc_WorkBook.DataSource, List(Of Objects.WorkbookItem)).Add(d.WorkItemSelected)
            gc_WorkBook.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_EditWork_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EditWork.ItemClick
        If gv_WorkBook.SelectedRowsCount = 1 Then
            Dim row As Objects.WorkbookItem = gv_WorkBook.GetRow(gv_WorkBook.GetSelectedRows()(0))
            Dim d As New Dialogs.frm_WorkBook(Enums.DialogMode.Edit, User, Jobs, ClientsMinimal, Users, row.ID)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
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

    Sub SetupHomeColumns(ByVal GridView As Views.Grid.GridView)
        If InvokeRequired Then
            Invoke(Sub() SetupHomeColumns(GridView))
        Else
            Dim HiddenColumns As New List(Of String)({"ID", "CompletedOn", "Folder", "BillingStatus", "WorkType"})
            Dim AvailableColumns As New List(Of String)({"Job", "Client", "CurrentStep", "DueDate", "AddedOn", "UpdatedOn", "Description", "Remarks", "TargetDate", "PriorityOfWork", "Status", "AssessmentDetail", "FinancialDetail"})
            Dim MinimalColumns As New List(Of String)({"Job", "Client", "CurrentStep", "DueDate", "TargetDate", "PriorityOfWork", "Status", "AssessmentDetail"})

            If GridView Is gv_Home Then
                HiddenColumns.AddRange({"Owner", "AssignedTo"})
            ElseIf GridView Is gv_AutoForwards Then
                HiddenColumns.Add("AssignedTo")
                MinimalColumns.Add("Owner")
                AvailableColumns.Add("Owner")
            ElseIf GridView Is gv_AutoForwards Then
                HiddenColumns.Add("Owner")
                MinimalColumns.Add("AssignedTo")
                AvailableColumns.Add("AssignedTo")
            End If
            For Each i As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
                If HiddenColumns.Contains(i.FieldName) Then
                    i.Visible = False
                End If
            Next


            If cmb_HomeView.EditValue = "Minimal" Then
                For Each i As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
                    If AvailableColumns.Contains(i.FieldName) Then
                        If MinimalColumns.Contains(i.FieldName) Then
                            i.Visible = True
                        Else
                            i.Visible = False
                        End If
                    End If
                Next
            Else
                For Each i As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
                    If AvailableColumns.Contains(i.FieldName) Then
                        i.Visible = True
                    End If
                Next
            End If
        End If
    End Sub

    Sub SetupWorkbookColumns()
        If InvokeRequired Then
            Invoke(Sub() SetupWorkbookColumns())
        Else
            Dim MinimalColumns As String() = {"AssignedTo", "Job", "Client", "CurrentStep", "TargetDate", "PriorityOfWork", "Status", "AssessmentDetail"}
            Dim ModerateColumns As String() = {"Owner", "AssignedTo", "Job", "Client", "CurrentStep", "DueDate", "Description", "Remarks", "TargetDate", "PriorityOfWork", "Status", "AssessmentDetail", "FinancialDetail"}
            Dim AdvancedColumns As String() = {"Owner", "AssignedTo", "Job", "Client", "CurrentStep", "DueDate", "AddedOn", "UpdatedOn", "Description", "Remarks", "TargetDate", "PriorityOfWork", "Status", "AssessmentDetail", "FinancialDetail"}

            Dim AvailableColumns As String()
            If cmb_WorkbookView.EditValue = "Minimal" Then
                AvailableColumns = MinimalColumns
            ElseIf cmb_WorkbookView.EditValue = "Moderate" Then
                AvailableColumns = ModerateColumns
            Else
                AvailableColumns = AdvancedColumns
            End If

            For Each i As DevExpress.XtraGrid.Columns.GridColumn In gv_WorkBook.Columns
                If AvailableColumns.Contains(i.FieldName) Then
                    i.Visible = True
                Else
                    i.Visible = False
                End If
            Next
        End If
    End Sub

    Sub SetupBillingColumns()
        If InvokeRequired Then
            Invoke(Sub() SetupBillingColumns())
        Else
            Dim MinimalColumns As String() = {"AssignedTo", "Job", "Client", "CompletedOn", "Description", "Remarks", "AssessmentDetail"}
            Dim FullColumns As String() = {"Owner", "AssignedTo", "Job", "Client", "CurrentStep", "DueDate", "AddedOn", "CompletedOn", "Description", "Remarks", "TargetDate", "AssessmentDetail", "FinancialDetail", "BillingStatus"}

            Dim AvailableColumns As String()
            If cmb_BillingView.EditValue = "Minimal" Then
                AvailableColumns = MinimalColumns
            Else
                AvailableColumns = FullColumns
            End If

            For Each i As DevExpress.XtraGrid.Columns.GridColumn In gv_Billing.Columns
                If AvailableColumns.Contains(i.FieldName) Then
                    i.Visible = True
                Else
                    i.Visible = False
                End If
            Next
        End If
    End Sub

    Sub SetupPendingColumns()
        If InvokeRequired Then
            Invoke(Sub() SetupBillingColumns())
        Else
            Dim MinimalColumns As String() = {"AssignedTo", "Job", "Client", "CompletedOn", "Description", "Remarks", "AssessmentDetail"}
            Dim FullColumns As String() = {"Owner", "AssignedTo", "Job", "Client", "CurrentStep", "DueDate", "AddedOn", "CompletedOn", "Description", "Remarks", "TargetDate", "AssessmentDetail", "FinancialDetail", "BillingStatus"}

            Dim AvailableColumns As String()
            If cmb_PendingView.EditValue = "Minimal" Then
                AvailableColumns = MinimalColumns
            Else
                AvailableColumns = FullColumns
            End If

            For Each i As DevExpress.XtraGrid.Columns.GridColumn In gv_Pending.Columns
                If AvailableColumns.Contains(i.FieldName) Then
                    i.Visible = True
                Else
                    i.Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub Loader_Home_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Home.DoWork
        While Loaded = False
            Threading.Thread.Sleep(1000)
        End While
        Me.Invoke(Sub()
                      ProgressPanel_Home.Visible = True
                      rpg_Home.Enabled = False
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

        Me.Invoke(Sub()
                      ProgressPanel_Home.Description = "Loading Home..."
                  End Sub)
        Try
            Dim Home As List(Of Objects.WorkbookItem) = Database.Workbook.GetForUser(True, Jobs, Users, User.ID, {Enums.WorkType.Normal, Enums.WorkType.Followup, Enums.WorkType.Transfer}, False)
            Me.Invoke(Sub()
                          gc_Home.DataSource = Home
                      End Sub)
            SetupHomeColumns(gv_Home)
        Catch ex As Exception
            MsgBox("Error on loading Home: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      ProgressPanel_Home.Visible = False
                      rpg_Home.Enabled = True
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub frm_Main_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        LoginInstance.BeginInvoke(Sub() LoginInstance.Close())
        Loaded = True
        If User.UserType = Enums.UserType.System Then
            If MsgBox("WARNING: You are logged in as and 'System' User." &
                      " Playing/Testing with this account without proper knowledge " &
                      "can lead to worst consequences. Use this accound only if you" &
                      " know what you are doing. Do you want to exit this application..?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Critical Warning!") = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub UpdateStatus(sender As System.Object, e As EventArgs)
        Try
            Dim s As Enums.WorkStatus = sender.Tag.ToString.Split(":")(0)
            Dim cs As String = sender.Tag.ToString.Split(":")(1)
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.UpdateStatus(row, cs, s, (row.GetHistory & vbNewLine & "Status updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    row.Status = s
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

    Private Sub UpdatePriority(sender As System.Object, e As EventArgs)
        Try
            Dim s As Enums.Priority = sender.Tag
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.UpdatePriority(row.ID, s, (row.GetHistory & vbNewLine & "Priority updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    row.PriorityOfWork = s
                    MsgBox("Successfully updated priority of selected work.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Else
                    MsgBox("Unknown error on updating priority of selected work.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                End If
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on updating priority of selected work.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                  , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub UpdateStep(sender As System.Object, e As EventArgs)
        Try
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.UpdateStep(row.ID, sender.Caption, (row.GetHistory & vbNewLine & "Step/Stage updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    row.CurrentStep = sender.Caption
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

    Private Sub UpdateRemarks(sender As System.Object, e As EventArgs)
        Try
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))

                Dim i As New InputBox("Update Remarks", "Edit Remarks :", row.Remarks)
                If i.ShowDialog = DialogResult.OK Then
                    If Database.Workbook.UpdateRemarks(row.ID, i.Result, (row.GetHistory & vbNewLine & "Remarks updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                        row.Remarks = i.Result
                        MsgBox("Successfully updated remarks of selected work.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                    Else
                        MsgBox("Unknown error on updating remarks of selected work.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on updating remarks of selected work.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub AssignTo(sender As System.Object, e As EventArgs)
        Dim user As Objects.User = Me.User
        Try
            For Each i As Objects.User In Users
                If i.Username = sender.Caption Then
                    user = i
                End If
            Next
            If gv_Home.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows()(0))
                If Database.Workbook.AssignTo(row.ID, user.ID, (row.GetHistory & vbNewLine & "Work transferred from " & row.AssignedTo.Username & " to " & user.Username & " by " & Me.User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    MsgBox("Successfully assigned selected work to the user " & user.Username & ".", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                    If Not Loader_Home.IsBusy Then Loader_Home.RunWorkerAsync()
                Else
                    MsgBox("Unknown error on assigning selected work to the user " & user.Username & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                End If
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on assigning selected work to the user {1}.{0}{0}{0}Additional Information:{0}{2}{0}{0}{3}", vbNewLine, user.Username, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub frm_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Text = String.Format("{0} [{1}]", My.Application.Info.ProductName, User.Username)
        MainPane.SelectedPageIndex = 0
        cmb_HomeView.EditValue = My.Settings.ViewHome
        cmb_WorkbookView.EditValue = My.Settings.ViewWorkbook
        cmb_BillingView.EditValue = My.Settings.ViewBilling
        cmb_PendingView.EditValue = My.Settings.ViewPending
        cmb_ClientsSort.EditValue = My.Settings.SortClient
        ProcessPermissions()
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

    Private Sub Loader_Utilities_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Utilities.DoWork
        While Loaded = False
            Threading.Thread.Sleep(1000)
        End While
        Me.Invoke(Sub()
                      ProgressPanel_Utilites.Visible = True
                  End Sub)
        Try
            Dim Utilites As List(Of DevExpress.XtraEditors.TileGroup) = Utils.Misc.LoadUtilities
            Me.Invoke(Sub()
                          Panel_Utilities.Groups.Clear()
                          For Each i As DevExpress.XtraEditors.TileGroup In Utilites
                              Panel_Utilities.Groups.Add(i)
                          Next
                      End Sub)
        Catch ex As Exception
            MsgBox("Error on loading Utilities: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      ProgressPanel_Utilites.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub gv_Home_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gv_Home.PopupMenuShowing, gv_AutoForwards.PopupMenuShowing
        If e.HitInfo.InRow AndAlso Not Loader_Home.IsBusy Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim item As Objects.WorkbookItem = view.GetRow(e.HitInfo.RowHandle)
            view.FocusedRowHandle = e.HitInfo.RowHandle

            Dim UpdateStageMenu As New DevExpress.Utils.Menu.DXPopupMenu With {.Caption = "Update Steps/Stage"}
            Dim UpdateStatusMenu As New DevExpress.Utils.Menu.DXPopupMenu With {.Caption = "Update Status"}
            Dim UpdatePriorityMenu As New DevExpress.Utils.Menu.DXPopupMenu With {.Caption = "Update Priority"}
            Dim AssignToMenu As New DevExpress.Utils.Menu.DXPopupMenu With {.Caption = "Assign To", .BeginGroup = True}
            Dim UpdateRemarksMenu As New DevExpress.Utils.Menu.DXMenuItem("Update Remarks", AddressOf UpdateRemarks) With {.BeginGroup = True}

            For i As Integer = 0 To 3
                UpdateStatusMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem([Enum].GetName(GetType(Enums.WorkStatus), i), AddressOf UpdateStatus) With {.Tag = i & ":" & item.CurrentStep})
            Next
            For i As Integer = -2 To 2
                UpdatePriorityMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem([Enum].GetName(GetType(Enums.Priority), i), AddressOf UpdatePriority) With {.Tag = i})
            Next
            For Each i As String In item.Job.Steps
                UpdateStageMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem(i, AddressOf UpdateStep))
            Next
            For Each i As Objects.User In Users
                AssignToMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem(i.Username, AddressOf AssignTo))
            Next

            e.Menu.Items.Add(UpdateStatusMenu)
            e.Menu.Items.Add(UpdatePriorityMenu)
            e.Menu.Items.Add(UpdateStageMenu)
            e.Menu.Items.Add(AssignToMenu)
            e.Menu.Items.Add(UpdateRemarksMenu)
        End If
    End Sub

    Private Sub Loader_Billing_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Billing.DoWork
        Me.Invoke(Sub()
                      rpg_Billing.Enabled = False
                      ProgressPanel_Billing.Visible = True
                  End Sub)

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Billing.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If
        If Jobs Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Billing.Description = "Loading Jobs..."
                      End Sub)
            Loader_Jobs_DoWork(Me, Nothing)
        End If

        Me.Invoke(Sub()
                      ProgressPanel_Billing.Description = "Loading Billing..."
                  End Sub)
        Try
            Dim Billing As List(Of Objects.WorkbookItem) = Database.Workbook.GetCompleted(True, Jobs, Users)
            Me.Invoke(Sub()
                          gc_Billing.DataSource = Billing
                      End Sub)
            SetupBillingColumns()
        Catch ex As Exception
            MsgBox("Error on loading Billing: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      rpg_Billing.Enabled = True
                      ProgressPanel_Billing.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub btn_RefreshBilling_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshBilling.ItemClick
        If Not Loader_Billing.IsBusy Then Loader_Billing.RunWorkerAsync()
    End Sub

    Private Sub btn_MarkBilled_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MarkBilled.ItemClick
        Try
            If gv_Billing.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_Billing.GetSelectedRows
                    Dim row As Objects.WorkbookItem = gv_Billing.GetRow(i)
                    If Database.Workbook.UpdateBilledStatus(row.ID, Enums.BillingStatus.Billed, (row.GetHistory & vbNewLine & "Marked as 'Billed' by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                        MsgBox("Successfully marked selected items as 'Billed'.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                        gc_Billing.DataSource.Remove(row)
                    Else
                        MsgBox("Unknown error while marking item " & row.ID & " as billed.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                    End If
                Next
                gc_Billing.RefreshDataSource()
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on marking selected items as billed.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub RAMMonitor_Tick(sender As System.Object, e As System.EventArgs) Handles RAMMonitor.Tick
        RAMUsed = Process.GetCurrentProcess.WorkingSet64
        RAMUsage.EditValue = CInt((RAMUsed / My.Computer.Info.TotalPhysicalMemory) * 100)
        Dim TipItem As New DevExpress.Utils.SuperToolTipSetupArgs
        TipItem.Title.Text = "RAM Usage"
        TipItem.Title.ImageOptions.Image = Res.My.Resources.ram
        TipItem.Contents.Text = "Shows RAM used by this application." & vbNewLine & "Current RAM Usage : " & Utils.Misc.FormatSize(RAMUsed)
        RAMUsage.SuperTip.Setup(TipItem)
    End Sub

    Private Sub btn_FreeRAM_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FreeRAM.ItemClick
        Dim RAM_1 As ULong = Process.GetCurrentProcess.WorkingSet64
        Utils.Misc.CleanRAM()
        Dim RAM_2 As ULong = Process.GetCurrentProcess.WorkingSet64
        ToolTipManager.ShowHint(Utils.Misc.FormatSize(RAM_1 - RAM_2) & " RAM Freed", New Point(btn_FreeRAM.Links(0).ScreenBounds.X + (btn_FreeRAM.Links(0).ScreenBounds.Width / 2), btn_FreeRAM.Links(0).ScreenBounds.Y - (btn_FreeRAM.Links(0).ScreenBounds.Height / 2)))
    End Sub

    Sub ProcessPermissions()
        Select Case User.UserType
            Case Enums.UserType.Administrator
                np_Billing.PageVisible = False
            Case Enums.UserType.Auditor
                np_Billing.PageVisible = True
            Case Enums.UserType.User
                np_Billing.PageVisible = False
                If User.Permissions.HasFlag(Enums.UserPermissions.ViewPending) Then
                    np_Pending.PageVisible = True
                Else
                    np_Pending.PageVisible = False
                End If
                If User.Permissions.HasFlag(Enums.UserPermissions.ViewWork) Then
                    np_Workbook.PageVisible = True
                    btn_AddWork.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.AddWork)
                    btn_EditWork.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditWork)
                    btn_RemoveWork.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditWork)
                Else
                    np_Workbook.PageVisible = False
                End If
                If User.Permissions.HasFlag(Enums.UserPermissions.ViewUser) Then
                    np_Users.PageVisible = True
                    btn_AddUser.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.CreateUser)
                    btn_EditUser.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditUser)
                    btn_RemoveUser.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditUser)
                Else
                    np_Users.PageVisible = False
                End If
                If User.Permissions.HasFlag(Enums.UserPermissions.ViewJob) Then
                    np_Jobs.PageVisible = True
                    btn_NewJob.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.AddJob)
                    btn_EditJob.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditJob)
                    btn_RemoveJob.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditJob)
                Else
                    np_Jobs.PageVisible = False
                End If
                If User.Permissions.HasFlag(Enums.UserPermissions.ViewClient) Then
                    np_Clients.PageVisible = True
                    btn_AddClient.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.AddClient)
                    btn_EditClient.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditClient)
                    btn_RemoveClient.Visibility = Not User.Permissions.HasFlag(Enums.UserPermissions.EditClient)
                Else
                    np_Clients.PageVisible = False
                End If
        End Select
    End Sub

    Private Sub btn_GenerateReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_GenerateReport.ItemClick
        If Clients IsNot Nothing Then
            Dim d As New Dialogs.frm_FilersReport(Clients)
            d.ShowDialog()
        Else
            MsgBox("Clients list is not fetched yet. Load/Refresh clients list and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub cmb_HomeView_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_HomeView.EditValueChanged
        If Loaded Then
            SetupHomeColumns(gv_Home)
            My.Settings.ViewHome = cmb_HomeView.EditValue
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmb_WorkbookView_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_WorkbookView.EditValueChanged
        If Loaded Then
            SetupWorkbookColumns()
            My.Settings.ViewWorkbook = cmb_WorkbookView.EditValue
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmb_BillingView_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_BillingView.EditValueChanged
        If Loaded Then
            SetupBillingColumns()
            My.Settings.ViewBilling = cmb_BillingView.EditValue
            My.Settings.Save()
        End If
    End Sub

    Sub SortClients()
        Dim Clients As List(Of Objects.Client) = gc_Clients.DataSource
        If Clients IsNot Nothing Then
            Select Case cmb_ClientsSort.EditValue
                Case "FileNo"
                    Clients.Sort(New Comparers.CompareByFileNo)
                Case "ID"
                    Clients.Sort(New Comparers.CompareByID)
                Case "Name"
                    Clients.Sort(New Comparers.CompareByName)
                Case "PAN"
                    Clients.Sort(New Comparers.CompareByPAN)
            End Select
        End If
        gc_Clients.RefreshDataSource()
    End Sub

    Private Sub cmb_ClientsSort_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_ClientsSort.EditValueChanged
        If Loaded Then
            SortClients()
            My.Settings.SortClient = cmb_ClientsSort.EditValue
            My.Settings.Save()
        End If
    End Sub

    Private Sub gc_Clients_FocusedViewChanged(sender As Object, e As ViewFocusEventArgs) Handles gc_Clients.FocusedViewChanged
        If gc_Clients.MainView Is gv_Clients Then
            cmb_ClientsSort.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            cmb_ClientsSort.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub Loader_Pending_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Pending.DoWork
        Me.Invoke(Sub()
                      rpg_Pending.Enabled = False
                      ProgressPanel_Pending.Visible = True
                  End Sub)

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Pending.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If
        If Jobs Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Pending.Description = "Loading Jobs..."
                      End Sub)
            Loader_Jobs_DoWork(Me, Nothing)
        End If

        Me.Invoke(Sub()
                      ProgressPanel_Pending.Description = "Loading Pending Bills..."
                  End Sub)
        Try
            Dim Pending As List(Of Objects.WorkbookItem) = Database.Workbook.GetPending(True, Jobs, Users)
            Me.Invoke(Sub()
                          gc_Pending.DataSource = Pending
                      End Sub)
            SetupPendingColumns()
        Catch ex As Exception
            MsgBox("Error on loading Pending: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      rpg_Pending.Enabled = True
                      ProgressPanel_Pending.Visible = False
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub cmb_PendingView_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_PendingView.EditValueChanged
        If Loaded Then
            SetupPendingColumns()
            My.Settings.ViewPending = cmb_PendingView.EditValue
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_RefreshPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_RefreshPending.ItemClick
        If Not Loader_Pending.IsBusy Then Loader_Pending.RunWorkerAsync()
    End Sub

    Private Sub btn_MarkPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MarkPending.ItemClick
        Try
            If gv_Billing.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_Billing.GetSelectedRows
                    Dim row As Objects.WorkbookItem = gv_Billing.GetRow(i)
                    If Database.Workbook.UpdateBilledStatus(row.ID, Enums.BillingStatus.Pending, (row.GetHistory & vbNewLine & "Marked as 'Pending' by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                        MsgBox("Successfully marked selected items as 'Pending'.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                        gc_Billing.DataSource.Remove(row)
                    Else
                        MsgBox("Unknown error while marking item " & row.ID & " as pending.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                    End If
                Next
                gc_Billing.RefreshDataSource()
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on marking selected items as pending.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub btn_MarkBilled_2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MarkBilled_2.ItemClick
        Try
            If gv_Pending.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_Pending.GetSelectedRows
                    Dim row As Objects.WorkbookItem = gv_Pending.GetRow(i)
                    If Database.Workbook.UpdateBilledStatus(row.ID, Enums.BillingStatus.Billed, (row.GetHistory & vbNewLine & "Marked as 'Billed' by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                        MsgBox("Successfully marked selected items as 'Billed'.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                        gc_Pending.DataSource.Remove(row)
                    Else
                        MsgBox("Unknown error while marking item " & row.ID & " as billed.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                    End If
                Next
                gc_Pending.RefreshDataSource()
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on marking selected items as billed.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub btn_MarkNotPaid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MarkNotPaid.ItemClick
        Try
            If gv_Pending.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_Pending.GetSelectedRows
                    Dim row As Objects.WorkbookItem = gv_Pending.GetRow(i)
                    If Database.Workbook.UpdateBilledStatus(row.ID, Enums.BillingStatus.NotBilled, (row.GetHistory & vbNewLine & "Marked as 'Not Billed' by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                        MsgBox("Successfully marked selected items as 'Not Billed'.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                        gc_Pending.DataSource.Remove(row)
                    Else
                        MsgBox("Unknown error while marking item " & row.ID & " as not billed.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                    End If
                Next
                gc_Pending.RefreshDataSource()
            End If
        Catch ex As Exception
            MsgBox(String.Format("Error on marking selected items as not billed.{0}{0}{0}Additional Information:{0}{1}{0}{0}{2}", vbNewLine, ex.Message, ex.StackTrace) _
                   , MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
        End Try
    End Sub

    Private Sub btn_MarkIncomplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MarkIncomplete.ItemClick
        Try
            Dim s As Enums.WorkStatus = Enums.WorkStatus.OnGoing
            If gv_Billing.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Billing.GetRow(gv_Billing.GetSelectedRows()(0))
                If Database.Workbook.UpdateStatus(row, row.CurrentStep, s, (row.GetHistory & vbNewLine & "Status updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    row.Status = s
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

    Private Sub btn_MarkIncomplete_2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MarkIncomplete_2.ItemClick
        Try
            Dim s As Enums.WorkStatus = Enums.WorkStatus.OnGoing
            If gv_Pending.SelectedRowsCount = 1 Then
                Dim row As Objects.WorkbookItem = gv_Pending.GetRow(gv_Pending.GetSelectedRows()(0))
                If Database.Workbook.UpdateStatus(row, row.CurrentStep, s, (row.GetHistory & vbNewLine & "Status updated by " & User.Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim) Then
                    row.Status = s
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

    Private Sub gv_Home_DoubleClick(sender As Object, e As EventArgs) Handles gv_Home.DoubleClick, gv_AutoForwards.DoubleClick, gv_Transferred.DoubleClick
        Dim view As Views.Grid.GridView = CType(sender, Views.Grid.GridView)
        If view.SelectedRowsCount = 1 AndAlso Not switch_PreviewPane.Checked Then
            Dim f As New Dialogs.frm_DetailedWorkbookItem(MousePosition, view.GetRow(view.GetSelectedRows(0)))
            f.Show(Me)
        End If
    End Sub

    Private Sub btn_ClientJobsReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ClientJobsReport.ItemClick
        If Clients IsNot Nothing Then
            Dim d As New Dialogs.frm_ClientJobsReport(Clients)
            d.ShowDialog()
        Else
            MsgBox("Clients list is not fetched yet. Load/Refresh clients list and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub switch_PreviewPane_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles switch_PreviewPane.CheckedChanged
        If switch_PreviewPane.Checked Then
            container_Home.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            container_AutoForwards.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
            container_Transferred.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        Else
            container_Home.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            container_AutoForwards.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            container_Transferred.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        End If
    End Sub

    Private Sub gv_Home_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gv_Home.SelectionChanged
        If gv_Home.SelectedRowsCount = 1 Then
            Dim Row As Objects.WorkbookItem = gv_Home.GetRow(gv_Home.GetSelectedRows(0))
            WorkBookItem_Preview_Home.Item = Row
        End If
    End Sub

    Private Sub btn_AddWork_Self_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_AddWork_Self.ItemClick
        Dim d As New Dialogs.frm_WorkBook(Enums.DialogMode.Add, User, Jobs, ClientsMinimal, Users, SelfEdit:=True)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CType(gc_Home.DataSource, List(Of Objects.WorkbookItem)).Add(d.WorkItemSelected)
            gc_Home.RefreshDataSource()
        End If
    End Sub

    Private Sub Loader_AutoForwards_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_AutoForwards.DoWork
        While Loaded = False
            Threading.Thread.Sleep(1000)
        End While
        Me.Invoke(Sub()
                      ProgressPanel_AutoForwards.Visible = True
                      rpg_AutoForwards.Enabled = False
                  End Sub)

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_AutoForwards.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If
        If Jobs Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_AutoForwards.Description = "Loading Jobs..."
                      End Sub)
            Loader_Jobs_DoWork(Me, Nothing)
        End If

        Me.Invoke(Sub()
                      ProgressPanel_AutoForwards.Description = "Loading AutoForwards..."
                  End Sub)
        Try
            Dim AutoForwards As List(Of Objects.WorkbookItem) = Database.Workbook.GetForUser(True, Jobs, Users, User.ID, {Enums.WorkType.AutoForward}, False)
            Me.Invoke(Sub()
                          gc_AutoForwards.DataSource = AutoForwards
                      End Sub)
            SetupHomeColumns(gv_AutoForwards)
        Catch ex As Exception
            MsgBox("Error on loading AutoForwards: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      ProgressPanel_AutoForwards.Visible = False
                      rpg_AutoForwards.Enabled = True
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub gv_Transferred_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gv_Transferred.SelectionChanged
        If gv_Transferred.SelectedRowsCount = 1 Then
            Dim Row As Objects.WorkbookItem = gv_Transferred.GetRow(gv_Transferred.GetSelectedRows(0))
            WorkBookItem_Preview_Transferred.Item = Row
        End If
    End Sub

    Private Sub gv_AutoForwards_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gv_AutoForwards.SelectionChanged
        If gv_AutoForwards.SelectedRowsCount = 1 Then
            Dim Row As Objects.WorkbookItem = gv_AutoForwards.GetRow(gv_AutoForwards.GetSelectedRows(0))
            WorkBookItem_Preview_AutoForwards.Item = Row
        End If
    End Sub

    Private Sub Loader_Transferred_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader_Transferred.DoWork
        While Loaded = False
            Threading.Thread.Sleep(1000)
        End While
        Me.Invoke(Sub()
                      ProgressPanel_Transferred.Visible = True
                      rpg_Transferred.Enabled = False
                  End Sub)

        If Users Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Transferred.Description = "Loading Users..."
                      End Sub)
            Loader_Users_DoWork(Me, Nothing)
        End If
        If Jobs Is Nothing Then
            Me.Invoke(Sub()
                          ProgressPanel_Transferred.Description = "Loading Jobs..."
                      End Sub)
            Loader_Jobs_DoWork(Me, Nothing)
        End If

        Me.Invoke(Sub()
                      ProgressPanel_Transferred.Description = "Loading Transferred..."
                  End Sub)
        Try
            Dim Transferred As List(Of Objects.WorkbookItem) = Database.Workbook.GetForUser(True, Jobs, Users, User.ID, {Enums.WorkType.Transfer}, True)
            Me.Invoke(Sub()
                          gc_Transferred.DataSource = Transferred
                      End Sub)
            SetupHomeColumns(gv_Transferred)
        Catch ex As Exception
            MsgBox("Error on loading Transferred: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.Invoke(Sub()
                      ProgressPanel_Transferred.Visible = False
                      rpg_Transferred.Enabled = True
                  End Sub)
        Utils.Misc.CleanRAM()
    End Sub

    Private Sub btn_RefreshTransferred_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_RefreshTransferred.ItemClick
        If Not Loader_Transferred.IsBusy Then Loader_Transferred.RunWorkerAsync()
    End Sub

    Private Sub btn_RefreshAutoForwards_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_RefreshAutoForwards.ItemClick
        If Not Loader_AutoForwards.IsBusy Then Loader_AutoForwards.RunWorkerAsync()
    End Sub
End Class