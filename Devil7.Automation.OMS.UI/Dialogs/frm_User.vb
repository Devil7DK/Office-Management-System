﻿'=========================================================================='
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
Imports System.Data.SqlClient

Public Class frm_User

    Dim Mode As Enums.DialogMode
    Dim ID As Integer = -1

    Property User As Objects.User = Nothing

    Sub New(ByVal Mode As Enums.DialogMode, Optional ByVal ID As Integer = -1, Optional ByVal SelfEdit As Boolean = False)
        InitializeComponent()
        Me.Mode = Mode
        Me.ID = ID
        If SelfEdit = True Then
            Panel_Permissions.Enabled = False
            txt_Name.ReadOnly = True
            cmb_UserType.Enabled = False
        End If
    End Sub

    Private Sub btn_Browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_Browse.Click
        If OFD_Image.ShowDialog = Windows.Forms.DialogResult.OK Then
            Photo.Image = Image.FromFile(OFD_Image.FileName)
        End If
    End Sub

    Private Sub btn_Permission_Add_Click(sender As System.Object, e As System.EventArgs) Handles btn_Permission_Add.Click
        Dim d As New frm_Permission(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            lst_Permissions.Items.Add(d.Permission)
        End If
    End Sub

    Private Sub btn_Permission_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Permission_Edit.Click
        If lst_Permissions.SelectedItems.Count = 1 Then
            Dim d As New frm_Permission(Enums.DialogMode.Edit, DirectCast([Enum].Parse(GetType(Enums.UserPermissions), lst_Permissions.SelectedItem), Enums.UserPermissions))
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim i As Integer = lst_Permissions.SelectedIndex
                lst_Permissions.Items.RemoveAt(i)
                lst_Permissions.Items.Insert(i, d.Permission)
            End If
        End If
    End Sub

    Private Sub btn_Permission_Remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_Permission_Remove.Click
        Try
            lst_Permissions.Items.RemoveAt(lst_Permissions.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_User_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmb_UserType.Properties.Items.AddRange([Enum].GetValues(GetType(Enums.UserType)))
        cmb_UserType.SelectedIndex = 0
        dgv_Credentials.DataSource = New System.ComponentModel.BindingList(Of Objects.Credential)
        If Mode = Enums.DialogMode.Edit AndAlso ID <> -1 Then
            txt_Password.Enabled = False
            txt_ConfirmPassword.Enabled = False
            Dim User = Database.Users.GetUserByID(ID)
            txt_Name.Text = User.Username
            txt_Address.Text = User.Address
            txt_Mobile.Text = User.Mobile
            txt_Email.Text = User.Email
            txt_Status.Text = User.Status
            Photo.Image = User.Photo
            txt_Desktop.Text = User.Desktop
            txt_Home.Text = User.Home
            cmb_UserType.SelectedIndex = Enums.StringToEnum(Of Enums.UserType)(User.UserType)
            For Each i As String In User.Permissions
                lst_Permissions.Items.Add(Enums.StringToEnum(Of Enums.UserPermissions)(i))
            Next
            dgv_Credentials.DataSource = User.Credentials
            txt_ConfirmPassword.Text = txt_Password.Text
        End If
    End Sub

    Private Sub btn_Credential_Add_Click(sender As System.Object, e As System.EventArgs) Handles btn_Credential_Add.Click
        Dim d As New frm_Credential(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Objects.Credential)).Add(d.Credential)
        End If
    End Sub

    Private Sub btn_Credential_Edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_Credential_Edit.Click
        If GridView1.SelectedRowsCount = 1 Then
            Dim row As Objects.Credential = GridView1.GetRow(GridView1.GetSelectedRows()(0))
            Dim d As New frm_Credential(Enums.DialogMode.Edit, row)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim bs = CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Objects.Credential))
                bs.Remove(row)
                bs.Add(d.Credential)
            End If
        End If
    End Sub

    Private Sub btn_Credential_Remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_Credential_Remove.Click
        If GridView1.SelectedRowsCount > 0 Then
            Dim cd As New List(Of Objects.Credential)
            For Each i As Integer In GridView1.GetSelectedRows
                cd.Add(GridView1.GetRow(i))
            Next
            For Each i As Objects.Credential In cd
                CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Objects.Credential)).Remove(i)
            Next
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Function GetPermissions() As Specialized.StringCollection
        Dim r As New Specialized.StringCollection
        For Each i As Enums.UserPermissions In lst_Permissions.Items
            r.Add(i.ToString)
        Next
        Return r
    End Function

    Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
        If txt_ConfirmPassword.Text = txt_Password.Text Then
            If Mode = Enums.DialogMode.Add Then
                Dim Result = Database.Users.AddNew(txt_Name.Text, cmb_UserType.SelectedItem.ToString(), txt_Password.Text, txt_Address.Text, txt_Mobile.Text, txt_Email.Text, GetPermissions(), txt_Status.Text, Photo.Image, CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Objects.Credential)), txt_Desktop.Text, txt_Home.Text)
                If Result IsNot Nothing Then
                    Me.User = Result
                    MsgBox("User Successfully Added.", MsgBoxStyle.Information, "Done")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            ElseIf Mode = Enums.DialogMode.Edit Then
                Dim Result = Database.Users.Update(ID, txt_Name.Text, cmb_UserType.SelectedItem.ToString(), txt_Address.Text, txt_Mobile.Text, txt_Email.Text, GetPermissions(), txt_Status.Text, Photo.Image, CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Objects.Credential)), txt_Desktop.Text, txt_Home.Text)
                If Result Then
                    MsgBox("User Successfully Updated.", MsgBoxStyle.Information, "Done")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub txt_Home_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_Home.ButtonClick
        If txt_Home.Text <> "" Then FBD.SelectedPath = txt_Home.Text
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_Home.Text = FBD.SelectedPath
        End If
    End Sub

    Private Sub txt_Desktop_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_Desktop.ButtonClick
        If txt_Desktop.Text <> "" Then FBD.SelectedPath = txt_Desktop.Text
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_Desktop.Text = FBD.SelectedPath
        End If
    End Sub

End Class