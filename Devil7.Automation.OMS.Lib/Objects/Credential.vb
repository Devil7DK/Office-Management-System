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

Public Class Credential

    Sub New(ByVal Name As String, ByVal Template As String, ByVal Username As String, ByVal Password As String, ByVal Password2 As String, ByVal Password3 As String)
        Me.Name = Name
        Me.Template = Template
        Me.Username = Username
        Me.Password = Password
        Me.Password2 = Password2
        Me.Password3 = Password3
    End Sub

    Property Template As String
    Property Name As String
    Property Username As String
    Property Password As String
    Property Password2 As String
    Property Password3 As String

    Public Overrides Function ToString() As String
        Return Name.ToString()
    End Function

End Class