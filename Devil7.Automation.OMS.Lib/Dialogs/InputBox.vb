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

Public Class InputBox

#Region "Properties"
    Property Result As String
#End Region

#Region "Constructor"
    Sub New(Optional Title As String = "Enter Text", Optional Prompt As String = "", Optional DefaultText As String = "")
        InitializeComponent()

        Text = Title
        lbl_Prompt.Text = Prompt
        txt_Input.Text = DefaultText
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        Result = txt_Input.Text
        DialogResult = System.Windows.Forms.DialogResult.OK
        Close()
    End Sub
#End Region

End Class