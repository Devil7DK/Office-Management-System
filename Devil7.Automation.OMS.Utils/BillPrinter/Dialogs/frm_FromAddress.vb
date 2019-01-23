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
'=========================================================================='

Public Class frm_FromAddress

#Region "Variables"
    Dim Mode As [Lib].Enums.DialogMode
#End Region

#Region "Properties"
    Property FromAddress As [Lib].Objects.ExMailAddress
#End Region

#Region "Constructor"
    Sub New(ByVal Mode As [Lib].Enums.DialogMode)
        InitializeComponent()
        Me.Mode = Mode
        If Mode = [Lib].Enums.DialogMode.Edit AndAlso FromAddress IsNot Nothing Then
            txt_DisplayName.Text = FromAddress.DisplayName
            txt_EMail.Text = FromAddress.EMailID
            Text = "Edit E-Mail Address"
        Else
            Text = "Add E-Mail Address"
        End If
    End Sub
#End Region

#Region "Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        ErrorProvider.ClearErrors()

        If txt_DisplayName.Text = "" Then
            ErrorProvider.SetError(txt_DisplayName, "Display Name Can't be Empty!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        If txt_EMail.Text = "" Then
            ErrorProvider.SetError(txt_EMail, "E-Mail ID Can't be Empty!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        If Not [Lib].Utils.IsValidEmailFormat(txt_EMail.Text) Then
            ErrorProvider.SetError(txt_DisplayName, "Invalid E-Mail ID!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        If Mode = [Lib].Enums.DialogMode.Edit AndAlso FromAddress IsNot Nothing Then
            FromAddress.DisplayName = txt_DisplayName.Text
            FromAddress.EMailID = txt_EMail.Text
        Else
            Me.FromAddress = New [Lib].Objects.ExMailAddress(txt_DisplayName.Text, txt_EMail.Text)
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
#End Region

End Class