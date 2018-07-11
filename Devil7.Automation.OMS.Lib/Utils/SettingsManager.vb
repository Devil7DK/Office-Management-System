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

Namespace Utils
    Public Module SettingsManager

        Dim ConfigFile As String = IO.Path.Combine(Windows.Forms.Application.StartupPath, "Settings.config")

        Dim Settings_ As SettingsContainer

        Function GetSettings() As SettingsContainer
            If Settings_ Is Nothing Then
                LoadSettings()
            End If
            Return Settings_
        End Function

        Sub LoadSettings()
            Settings_ = FromFile(Of SettingsContainer)(ConfigFile)
            If Settings_ Is Nothing Then
                Settings_ = New SettingsContainer
            End If
        End Sub

        Sub SaveSettings()
            If Settings_ Is Nothing Then
                LoadSettings()
            End If
            ToFile(Of SettingsContainer)(Settings_, ConfigFile)
        End Sub

        Class SettingsContainer
            Property Skin As String = ""
            Property ServerName As String = ""
            Property DatabaseName As String = ""
            Property UserName As String = ""
            Property Password As String = ""
            Property Pooling As Boolean = False
        End Class

    End Module
End Namespace