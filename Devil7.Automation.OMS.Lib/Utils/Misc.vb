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

        Function FixFileName(ByVal Path As String) As String
            Dim r As String = Path
            For Each c As Char In IO.Path.GetInvalidFileNameChars
                r = r.Replace(c, "_")
            Next
            r = r.Replace(" ", "_")
            Do Until r.Contains("__") = False
                r = r.Replace("__", "_")
            Loop
            r = r.Trim("_")
            Return r
        End Function

        Function GetFolder(ByVal DefaultStorage As String, ByVal Client As Objects.Client, ByVal Job As Objects.Job, ByVal AssessmentDetail As String, ByVal Year As String)
            Dim r As String = ""
            Dim Folder As String = DefaultStorage
            Select Case Job.Type
                Case Enums.JobType.Once
                    Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), Now.ToString("yyyyMMddhhmm"))
                Case Enums.JobType.Monthly
                    Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), FixFileName(AssessmentDetail))
                Case Enums.JobType.Yearly
                    Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(AssessmentDetail))
                Case Enums.JobType.Quarterly
                    Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), FixFileName(AssessmentDetail))
                Case Enums.JobType.HalfYerly
                    Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), FixFileName(AssessmentDetail))
            End Select
            Return FixFileName(r)
        End Function

    End Module
End Namespace