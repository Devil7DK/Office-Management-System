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

        Function GetOppositeColor(ByVal Color2Get As Drawing.Color) As Drawing.Color
            Return GetOppositeColor(Color2Get.R, Color2Get.G, Color2Get.B)
        End Function

        Function GetOppositeColor(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As Drawing.Color
            If (r + g + b) > 480 Then
                Return Drawing.Color.Black
            Else
                Return Drawing.Color.White
            End If
        End Function

        Function LoadUtilities() As List(Of DevExpress.XtraEditors.TileGroup)
            On Error Resume Next

            Dim R As New List(Of DevExpress.XtraEditors.TileGroup)

            Dim random_ As New Random
            Dim defaultgroup As New DevExpress.XtraEditors.TileGroup() With {.Text = "Default"}
            For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Utilities", FileIO.SearchOption.SearchTopLevelOnly, "*.exe")
                If IO.Path.GetFileName(i).EndsWith("vshot.exe") = False Then
                    Dim it As New DevExpress.XtraEditors.TileItem() With {.Image = Drawing.Icon.ExtractAssociatedIcon(i).ToBitmap, .Text = IO.Path.GetFileNameWithoutExtension(i), .Tag = i}
                    it.AppearanceItem.Normal.BackColor = Drawing.Color.FromArgb(random_.Next(0, 257), random_.Next(0, 257), random_.Next(0, 257))
                    it.AppearanceItem.Normal.ForeColor = (GetOppositeColor(it.AppearanceItem.Normal.BackColor))
                    it.ItemSize = random_.Next(2, 4)
                    AddHandler it.ItemClick, Sub()
                                                 Process.Start(it.Tag)
                                             End Sub
                    defaultgroup.Items.Add(it)
                End If
            Next
            R.Add(defaultgroup)
            For Each f As String In My.Computer.FileSystem.GetDirectories(Application.StartupPath & "\Utilities", FileIO.SearchOption.SearchAllSubDirectories, "*")
                Dim g As New DevExpress.XtraEditors.TileGroup
                g.Text = IO.Path.GetDirectoryName(f)
                For Each i As String In My.Computer.FileSystem.GetFiles(f, FileIO.SearchOption.SearchTopLevelOnly, "*.exe")
                    If IO.Path.GetFileName(i).EndsWith("vshot.exe") = False Then
                        Dim it As New DevExpress.XtraEditors.TileItem() With {.Image = Drawing.Icon.ExtractAssociatedIcon(i).ToBitmap, .Text = IO.Path.GetFileNameWithoutExtension(i), .Tag = i}
                        it.AppearanceItem.Normal.BackColor = Drawing.Color.FromArgb(random_.Next(0, 257), random_.Next(0, 257), random_.Next(0, 257))
                        it.AppearanceItem.Normal.ForeColor = (GetOppositeColor(it.AppearanceItem.Normal.BackColor))
                        it.ItemSize = random_.Next(2, 4)
                        AddHandler it.ItemClick, Sub()
                                                     Process.Start(it.Tag)
                                                 End Sub
                        g.Items.Add(it)
                    End If
                Next
                R.Add(g)
            Next

            Return R
        End Function

    End Module
End Namespace