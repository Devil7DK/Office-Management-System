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

Imports System.Windows.Forms

Namespace Dialogs
    Public Class frm_ChangePassword

        Dim User As Objects.User

        Sub New(ByVal User As Objects.User)
            InitializeComponent()
            Me.User = User
        End Sub

        Private Sub btn_ChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles btn_ChangePassword.Click
            If txt_OldPassword.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Please enter old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txt_NewPassword.Text = "" Or txt_ConfirmNewPassword.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txt_NewPassword.Text <> txt_ConfirmNewPassword.Text Then
                DevExpress.XtraEditors.XtraMessageBox.Show("New password not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Database.Users.ChangePassword(User.Username, txt_OldPassword.Text, txt_NewPassword.Text, True) Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Password successfully changed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unable to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End Sub

    End Class
End Namespace