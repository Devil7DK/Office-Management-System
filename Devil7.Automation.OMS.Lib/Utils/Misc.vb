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

        Public Function ExInputBox(ByVal Title As String, ByVal Prompt As String, Optional ByVal DefaultValue As String = "") As String
            Dim D As New frm_ExInputBox(Title, Prompt, DefaultValue)
            If D.ShowDialog = DialogResult.OK Then
                Return D.Value
            Else
                Return ""
            End If
        End Function

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
            Dim R As New List(Of DevExpress.XtraEditors.TileGroup)

            Dim ParentExe As String = IO.Path.GetFileName(Application.ExecutablePath)
            Dim random_ As New Random
            Dim defaultgroup As New DevExpress.XtraEditors.TileGroup() With {.Text = "Default"}
            For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchTopLevelOnly, "*.exe")
                Dim Filename As String = IO.Path.GetFileName(i)
                If Not Filename.EndsWith("vshot.exe") AndAlso Filename <> ParentExe Then
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

            Return R
        End Function

        Dim DoubleBytes As Double
        Public Function FormatSize(ByVal Value As ULong) As String

            Try
                Select Case Value
                    Case Is >= 1099511627776
                        DoubleBytes = CDbl(Value / 1099511627776) 'TB
                        Return FormatNumber(DoubleBytes, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        DoubleBytes = CDbl(Value / 1073741824) 'GB
                        Return FormatNumber(DoubleBytes, 2) & " GB"
                    Case 1048576 To 1073741823
                        DoubleBytes = CDbl(Value / 1048576) 'MB
                        Return FormatNumber(DoubleBytes, 2) & " MB"
                    Case 1024 To 1048575
                        DoubleBytes = CDbl(Value / 1024) 'KB
                        Return FormatNumber(DoubleBytes, 2) & " KB"
                    Case 0 To 1023
                        DoubleBytes = Value ' bytes
                        Return FormatNumber(DoubleBytes, 2) & " bytes"
                    Case Else
                        Return ""
                End Select
            Catch
                Return Value
            End Try

        End Function

        Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
        Sub CleanRAM()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            End If
        End Sub

        Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
            'Let's make sure entered value is numeric
            If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

            Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
            nAmount = Replace(nAmount, tempDecValue, String.Empty)

            Try
                Dim intAmount As Long = nAmount
                If intAmount > 0 Then
                    nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)),
                  CLng(intAmount.ToString.Trim.Length / 3) + 1,
                   CLng(intAmount.ToString.Trim.Length / 3))
                    Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                    Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                    Dim Ones() As String =
                {"", "One", "Two", "Three",
                  "Four", "Five",
                  "Six", "Seven", "Eight", "Nine"}
                    Dim Teens() As String = {"",
                "Eleven", "Twelve", "Thirteen",
                  "Fourteen", "Fifteen",
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                    Dim Tens() As String = {"", "Ten",
                "Twenty", "Thirty",
                  "Forty", "Fifty", "Sixty",
                  "Seventy", "Eighty", "Ninety"}
                    Dim HMBT() As String = {"", "",
                "Thousand", "Million",
                  "Billion", "Trillion",
                  "Quadrillion", "Quintillion"}

                    intAmount = eAmount

                    Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                    Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                    Dim nOne As Integer = intAmount \ 1

                    If nHundred > 0 Then wAmount = wAmount &
                Ones(nHundred) & " Hundred and " 'This is for hundreds                
                    If nTen > 0 Then 'This is for tens and teens
                        If nTen = 1 And nOne > 0 Then 'This is for teens 
                            wAmount = wAmount & Teens(nOne) & " "
                        Else 'This is for tens, 10 to 90
                            wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                            If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                        End If
                    Else 'This is for ones, 1 to 9
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                    wAmount = wAmount & HMBT(nSet) & " "
                    wAmount = AmountInWords(CStr(CLng(nAmount) -
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                Else
                    If Val(nAmount) = 0 Then nAmount = nAmount &
                tempDecValue : tempDecValue = String.Empty
                    If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
                  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
                  wAmount.Trim & " Rupees And ", 1)) & " Paise"
                End If
            Catch ex As Exception
                MessageBox.Show("Error Encountered: " & ex.Message,
              "Convert Numbers To Words",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "!#ERROR_ENCOUNTERED"
            End Try

            'Trap null values

            'Display the result
            If wAmount.Trim.EndsWith(" and") Then
                wAmount = wAmount.Trim.TrimEnd(("and").ToCharArray)
            End If
            Return wAmount
        End Function

        Public Function IsValidEmailFormat(ByVal s As String) As Boolean
            Return Text.RegularExpressions.Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        End Function

        Public Function isValidPAN(ByVal PAN As String) As Boolean
            Dim RegEx_PAN As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("^([a-zA-Z]){5}([0-9]){4}([a-zA-Z]){1}?$")

            If PAN.Trim.Length = 10 Then
                If RegEx_PAN.IsMatch(PAN.Trim) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

    End Module
End Namespace