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
    Sub New(User As Objects.User)
        InitializeComponent()
        Me.User = User
    End Sub

#Region "Functions"
    Sub UsersPageLoad()
        If gc_Users.DataSource Is Nothing Then
            If Not Loader_Users.IsBusy Then Loader_Users.RunWorkerAsync()
        End If
    End Sub
#End Region

    Private Sub MainPane_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles MainPane.SelectedPageChanged
        If MainPane.SelectedPage Is np_Users Then
            UsersPageLoad()
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
End Class