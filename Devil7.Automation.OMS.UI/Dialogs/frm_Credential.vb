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

Public Class frm_Credential

    Dim Mode As Enums.DialogMode = Enums.DialogMode.Add

    Sub New(ByVal Type As Enums.DialogMode, Optional ByRef Credential_ As Objects.Credential = Nothing)
        InitializeComponent()
        Me.Mode = Type
        Me.Credential = Credential_
    End Sub

    Property Credential As Objects.Credential

    Private Sub frm_Credential_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Mode = Enums.DialogMode.Edit AndAlso Credential IsNot Nothing Then
            txt_Name.Text = Credential.Name
            txt_Template.Text = Credential.Template
            txt_UserName.Text = Credential.Username
            txt_Password1.Text = Credential.Password
            txt_Password2.Text = Credential.Password2
            txt_Password3.Text = Credential.Password3
        End If
        txt_Name.Focus()
    End Sub

    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Me.Credential = New Objects.Credential(txt_Name.Text, txt_Template.Text, txt_UserName.Text, txt_Password1.Text, txt_Password2.Text, txt_Password3.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class