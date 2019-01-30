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

Imports System.Security.Principal
Imports DevExpress.XtraEditors
Imports Devil7.Automation.OMS.Lib.Database
Imports Devil7.Automation.OMS.Lib.Objects
Imports Devil7.Automation.OMS.Lib.Utils

Public Class frm_Login

    Dim Users_ As String()

    Private Sub frm_Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        XtraMessageBox.SmartTextWrap = True
        Devil7.Automation.OMS.Lib.Utils.SettingsManager.LoadSettings()
        chk_Remember.Checked = My.Settings.AutoLogin
        Try
            Users_ = Users.GetUsernames
            txt_Username.Properties.Items.AddRange(Users_)
        Catch ex As Exception
            XtraMessageBox.Show("Error on loading usernames." & vbNewLine & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btn_Login_Click(sender As System.Object, e As System.EventArgs) Handles btn_Login.Click
        If txt_Username.SelectedIndex >= 0 AndAlso txt_Password.Text.Trim <> "" Then
            If Not LoginWorker.IsBusy Then LoginWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub LoginWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoginWorker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel.Visible = True
                  End Sub)
        Dim User As User = Users.Login(txt_Username.SelectedItem.ToString, txt_Password.Text)
        If User IsNot Nothing Then
            My.Settings.LastUserIndex = txt_Username.SelectedIndex
            My.Settings.Username = txt_Username.Text
            My.Settings.Password = Encryption.EncryptString(txt_Password.Text)
            My.Settings.Save()
            Try
                Dim T As New Threading.Tasks.Task(Sub()
                                                      Application.Run(New frm_Main(User, Me))
                                                  End Sub)
                T.Start()
            Catch ex As Exception

            End Try
        Else
            Me.Invoke(Sub()
                          ProgressPanel.Visible = False
                      End Sub)
        End If
    End Sub

    Private Sub txt_Password_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Login.PerformClick()
        End If
    End Sub

    Private Sub chk_Remember_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Remember.CheckedChanged
        My.Settings.AutoLogin = chk_Remember.Checked
        My.Settings.Save()
    End Sub

    Private Sub frm_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If My.Settings.AutoLogin Then
                txt_Username.SelectedIndex = Users_.ToList.FindIndex(Function(c) c = My.Settings.Username)
                txt_Password.Text = Encryption.DecryptString(My.Settings.Password)
                btn_Login.PerformClick()
            End If
        Catch ex As Exception

        End Try

        If txt_Username.Properties.Items.Count > 0 And txt_Username.SelectedIndex = -1 Then
            If My.Settings.LastUserIndex < txt_Username.Properties.Items.Count Then
                txt_Username.SelectedIndex = My.Settings.LastUserIndex
            Else
                txt_Username.SelectedIndex = 0
            End If
        End If
    End Sub
End Class