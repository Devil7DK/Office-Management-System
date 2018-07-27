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
    Public Module Periods

        Function GetYears() As List(Of String)
            Dim R As New List(Of String)

            Dim CurrentYear As Integer = Now.ToString("yyyy")
            For i As Integer = -1 To 19
                If (CurrentYear - i) >= 1 Then
                    R.Add((CurrentYear - (i + 1)).ToString("00") & "-" & (CurrentYear - i).ToString("00"))
                Else
                    Exit For
                End If
            Next

            Return R
        End Function

        Function GetHalves() As List(Of String)
            Dim R As New List(Of String)

            Dim Halves As Integer() = {4, 9, 10, 3}

            For i As Integer = 0 To Halves.Count - 1 Step 2
                R.Add(DateAndTime.MonthName(Halves(i)).Substring(0, 3) & "-" & DateAndTime.MonthName(Halves(i + 1)).Substring(0, 3))
            Next

            Return R
        End Function

        Function GetQuarters() As List(Of String)
            Dim R As New List(Of String)

            Dim Quarters As Integer() = {4, 7, 10, 1}

            For Each i As Integer In Quarters
                R.Add(DateAndTime.MonthName(i).Substring(0, 3) & "-" & DateAndTime.MonthName(i + 2).Substring(0, 3))
            Next

            Return R
        End Function

        Function GetMonths() As List(Of String)
            Dim R As New List(Of String)

            Dim FinancialMonths As Integer() = {4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3}

            For Each i As Integer In FinancialMonths
                R.Add(DateAndTime.MonthName(i))
            Next

            Return R
        End Function

    End Module
End Namespace