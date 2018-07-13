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

Public Class frm_Permission

    Sub New(ByVal Mode As Enums.DialogMode, Optional ByVal Permission As Enums.UserPermissions = Enums.UserPermissions.System)
        InitializeComponent()
        Me.Mode = Mode
        If Mode = Enums.DialogMode.Edit Then
            Me.Permission = Permission
        End If
    End Sub

    Dim Mode As Enums.DialogMode = Enums.DialogMode.Add

    Private Sub frm_Permission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Permission.Properties.Items.AddRange([Enum].GetValues(GetType(Enums.UserPermissions)))
        cmb_Permission.SelectedIndex = 0
        If Mode = Enums.DialogMode.Edit Then
            cmb_Permission.SelectedItem = Permission
        End If
    End Sub

    Property Permission As Enums.UserPermissions

    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Permission = cmb_Permission.SelectedItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class