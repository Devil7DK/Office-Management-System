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

Public Class frm_Main

    Dim User As Objects.User
    Sub New(User As Objects.User)
        InitializeComponent()
        Me.User = User
    End Sub

    Private Sub MainPane_StateChanged(sender As Object, e As DevExpress.XtraBars.Navigation.StateChangedEventArgs) Handles MainPane.StateChanged
        If MainPane.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed Then MainPane.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Regular
    End Sub

End Class