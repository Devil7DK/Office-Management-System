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

Imports System.Security.Principal
Imports DevExpress.XtraEditors
Imports Devil7.Automation.OMS.Lib.Database
Imports Devil7.Automation.OMS.Lib.Objects

Public Class frm_Login

#Region "Properties"
    Property User As User
#End Region

#Region "Functions"
    Private Function IsAdmin() As Boolean
        Return (New WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator)
    End Function
#End Region


#Region "Form Events"
    Private Sub frm_Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        XtraMessageBox.SmartTextWrap = True
        Devil7.Automation.OMS.Lib.Utils.SettingsManager.LoadSettings()
        If IsAdmin() Then
            btn_ServerSettings.Enabled = True
        Else
            btn_ServerSettings.Enabled = False
        End If
        Try
            Dim Users_ As String() = Users.GetUsernames
            txt_Username.Properties.Items.AddRange(Users_)
            If Users_.Count >= My.Settings.LastUserIndex Then txt_Username.SelectedIndex = My.Settings.LastUserIndex
        Catch ex As Exception
            XtraMessageBox.Show("Error on loading usernames." & vbNewLine & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_ServerSettings_Click(sender As System.Object, e As System.EventArgs) Handles btn_ServerSettings.Click
        Dim D As New [Lib].Dialogs.frm_ServerSettings
        D.ShowDialog()
    End Sub

    Private Sub btn_Login_Click(sender As System.Object, e As System.EventArgs) Handles btn_Login.Click
        If txt_Username.SelectedIndex >= 0 AndAlso txt_Password.Text.Trim <> "" Then
            If Not LoginWorker.IsBusy Then LoginWorker.RunWorkerAsync()
            My.Settings.LastUserIndex = txt_Username.SelectedIndex
            My.Settings.Save()
        End If
    End Sub
#End Region


#Region "Other Events"
    Private Sub LoginWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoginWorker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel.Visible = True
                  End Sub)
        Dim User As User = Users.Login(txt_Username.SelectedItem.ToString, txt_Password.Text)
        If User IsNot Nothing Then
            Me.User = User
            Me.DialogResult = DialogResult.OK
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
#End Region

End Class