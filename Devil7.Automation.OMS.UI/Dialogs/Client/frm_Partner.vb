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

Public Class frm_Partner

    Dim Mode As Enums.DialogMode = Enums.DialogMode.Add

    Sub New(ByVal Type As Enums.DialogMode, Optional ByRef SourcePartner As Objects.Partner = Nothing)
        InitializeComponent()
        Me.Mode = Type
        Me.Partner = SourcePartner
    End Sub

    Property Partner As Objects.Partner

    Private Sub frm_Partner_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Mode = Enums.DialogMode.Edit AndAlso Partner IsNot Nothing Then
            txt_Name.Text = Partner.Name
            txt_Address.Text = Partner.Address
            txt_PAN.Text = Partner.PAN
            txt_Date.DateTime = Partner.DOB
        End If
        txt_PAN.Focus()
    End Sub

    Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
        Me.Partner = New Objects.Partner(txt_Name.Text, txt_Address.Text, txt_PAN.Text, txt_Date.DateTime.ToString("dd/MM/yyyy"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class