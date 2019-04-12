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

Imports System.Drawing
Imports System.Windows.Forms

Namespace Dialogs
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
            If OFD_Image.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Photo.Image = Image.FromFile(OFD_Image.FileName)
            End If
        End Sub

        Private Sub btn_Permission_Add_Click(sender As System.Object, e As System.EventArgs) Handles btn_Permission_Add.Click
            Dim d As New frm_Permission(Enums.DialogMode.Add)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                lst_Permissions.Items.Add(d.Permission)
            End If
        End Sub

        Private Sub btn_Permission_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Permission_Edit.Click
            If lst_Permissions.SelectedItems.Count = 1 Then
                Dim d As New frm_Permission(Enums.DialogMode.Edit, DirectCast([Enum].Parse(GetType(Enums.UserPermissions), lst_Permissions.SelectedItem), Enums.UserPermissions))
                If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
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
            For i As Integer = 0 To 2
                cmb_UserType.Properties.Items.Add([Enum].GetName(GetType(Enums.UserType), i))
            Next
            cmb_UserType.SelectedIndex = 0
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
                cmb_UserType.SelectedIndex = User.UserType
                For Each i As Enums.UserPermissions In [Enum].GetValues(GetType(Enums.UserPermissions))
                    If User.Permissions.HasFlag(i) Then
                        lst_Permissions.Items.Add(i)
                    End If
                Next
                txt_ConfirmPassword.Text = txt_Password.Text
            End If
        End Sub

        Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Function GetPermissions() As Enums.UserPermissions
            Dim Values As Enums.UserPermissions
            For Each i As Enums.UserPermissions In lst_Permissions.Items
                Values += i
            Next
            Return Values
        End Function

        Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
            If txt_ConfirmPassword.Text = txt_Password.Text Then
                If Mode = Enums.DialogMode.Add Then
                    Dim Result = Database.Users.AddNew(txt_Name.Text, cmb_UserType.SelectedIndex, txt_Password.Text, txt_Address.Text, txt_Mobile.Text, txt_Email.Text, GetPermissions(), txt_Status.Text, Photo.Image)
                    If Result IsNot Nothing Then
                        Me.User = Result
                        DevExpress.XtraEditors.XtraMessageBox.Show("User Successfully Added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                ElseIf Mode = Enums.DialogMode.Edit Then
                    Dim Result = Database.Users.Update(ID, txt_Name.Text, cmb_UserType.SelectedIndex.ToString(), txt_Address.Text, txt_Mobile.Text, txt_Email.Text, GetPermissions(), txt_Status.Text, Photo.Image)
                    If Result Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("User Successfully Updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End Sub

    End Class
End Namespace