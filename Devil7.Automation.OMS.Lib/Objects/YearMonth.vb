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

Namespace Objects
    Public Class YearMonth

        Sub New()
            Me.Year = ""
            Me.Period = ""
        End Sub

        Sub New(ByVal Year As String, ByVal Period As String)
            Me.Year = Year
            Me.Period = Period
        End Sub

        Public Property Year As String
        Public Property Period As String

        Public Overrides Function ToString() As String
            If Year = "" Then Year = Utils.Periods.GetYears(0)
            If Period.Trim <> "" Then
                Return Year & " : " & Period
            Else
                Return Year
            End If
        End Function

        Public Shared Function Parse(ByVal Value As String) As YearMonth
            Dim R As New YearMonth

            If Value.Trim <> "" Then
                If Value.Contains(":") Then
                    Dim s As String() = Value.Split(":")
                    R.Year = s(0).Trim
                    R.Period = s(1).Trim
                Else
                    R.Year = Value.Trim
                    R.Period = ""
                End If
            End If

            Return R
        End Function

    End Class
End Namespace
