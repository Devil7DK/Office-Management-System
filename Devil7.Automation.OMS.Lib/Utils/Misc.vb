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

Imports System.Windows.Forms

Namespace Utils
    Public Module Misc

        Public Sub CenterControl(ByVal ControlToCenter As Control, ByVal Type As Enums.CenterType)
            Try
                Dim x As Single = ControlToCenter.Location.X
                Dim y As Single = ControlToCenter.Location.Y
                If Type = Enums.CenterType.Vertical Then
                    x = ControlToCenter.Location.X
                    y = (ControlToCenter.Parent.Height - ControlToCenter.Height) / 2
                ElseIf Type = Enums.CenterType.Horizondal Then
                    x = (ControlToCenter.Parent.Width - ControlToCenter.Width) / 2
                    y = ControlToCenter.Location.Y
                Else
                    x = (ControlToCenter.Parent.Width - ControlToCenter.Width) / 2
                    y = (ControlToCenter.Parent.Height - ControlToCenter.Height) / 2
                End If
                ControlToCenter.Location = New Drawing.Point(x, y)
            Catch ex As Exception

            End Try
        End Sub

    End Module
End Namespace