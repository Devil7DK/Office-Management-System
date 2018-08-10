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
#Region "Lists"
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
#End Region

        Function GetMonthForHalf(ByVal Month As Integer) As Integer
            Dim Months(,) As Integer = {{4, 5, 6, 7, 8, 9}, {10, 11, 12, 1, 2, 3}}


            For i As Integer = 0 To 1
                For j As Integer = 0 To 5
                    If Months(i, j) = Month Then
                        Return Months(i, 0)
                    End If
                Next
            Next

            Return Months(0, 0)
        End Function

        Function GetMonthForHalf() As Integer
            Return GetMonthForHalf(Now.Month)
        End Function

        Function GetMonthForQuarter(ByVal Month As Integer) As Integer
            Dim Months(,) As Integer = {{4, 5, 6}, {7, 8, 9}, {10, 11, 12}, {1, 2, 3}}

            For i As Integer = 0 To 3
                For j As Integer = 0 To 2
                    If Months(i, j) = Month Then
                        Return Months(i, 0)
                    End If
                Next
            Next

            Return Months(0, 0)
        End Function

        Function GetMonthForQuarter() As Integer
            Return GetMonthForQuarter(Now.Month)
        End Function

        Function GetFinancialYearForMonth(ByVal Month As Integer, ByVal OnDate As Date) As Integer
            If Month >= 4 And Month <= 12 Then
                If OnDate.Month >= 4 And OnDate.Month <= 12 Then
                    Return OnDate.Year
                Else
                    Return OnDate.Year - 1
                End If
            Else
                If OnDate.Month >= 4 And OnDate.Month <= 12 Then
                    Return OnDate.Year + 1
                Else
                    Return OnDate.Year
                End If
            End If
        End Function

        Function GetFinancialYearForMonth(ByVal Month As Integer) As Integer
            Return GetFinancialYearForMonth(Month, Now)
        End Function

        Function GetLastDateOfLastFinancialYear(ByVal OnDate As Date) As Date
            Dim Year As Integer = OnDate.Year

            If OnDate.Month >= 4 And OnDate.Month <= 12 Then
                Year = OnDate.Year - 1
            Else
                Year = OnDate.Year - 2
            End If

            Return New Date(Year, 3, 31)
        End Function

        Function GetLastDate(ByVal FinancialPeriod As Objects.YearMonth, ByVal PeriodType As Enums.JobType) As Date
            Select Case PeriodType
                Case Enums.JobType.Once
                    Return Now
                Case Enums.JobType.Monthly
                    Dim Month As Integer = GetMonth(FinancialPeriod.Period)
                    Dim Year As Integer = CInt(FinancialPeriod.Year.Split("-")(0)) + (If(Month >= 4 And Month <= 12, 0, 1))
                    Return New Date(Year, Month, DateTime.DaysInMonth(Year, Month))
                Case Enums.JobType.Quarterly
                    Dim Month As Integer = GetMonth(FinancialPeriod.Period.Split("-")(1))
                    Dim Year As Integer = CInt(FinancialPeriod.Year.Split("-")(0)) + (If(Month >= 4 And Month <= 12, 0, 1))
                    Return New Date(Year, Month, DateTime.DaysInMonth(Year, Month))
                Case Enums.JobType.HalfYerly
                    Dim Month As Integer = GetMonth(FinancialPeriod.Period.Split("-")(1))
                    Dim Year As Integer = CInt(FinancialPeriod.Year.Split("-")(0)) + (If(Month >= 4 And Month <= 12, 0, 1))
                    Return New Date(Year, Month, DateTime.DaysInMonth(Year, Month))
                Case Enums.JobType.Yearly
                    Dim Year As Integer = FinancialPeriod.Year.Split("-")(1)
                    Return New Date(Year, 3, 31)
            End Select
            Return Now
        End Function

        Function GetMonth(ByVal MonthName As String) As Integer
            Return DateTime.ParseExact(MonthName, If(MonthName.Length <= 3, "MMM", "MMMM"), Globalization.CultureInfo.CurrentCulture).Month
        End Function

        Function GetDueDate(ByVal Increment As Integer, ByVal FinancialPeriod As Objects.YearMonth, ByVal PeriodType As Enums.JobType)
            Dim BaseDate As Date = GetLastDate(FinancialPeriod, PeriodType)
            Return BaseDate.AddDays(Increment)
        End Function

        Public Function GetNotifyDate(ByVal Increment As Integer, ByVal Type As Enums.JobType, ByVal OnDate As Date) As Date
            Dim BaseDate As Date = OnDate

            Select Case Type
                Case Enums.JobType.Monthly
                    Dim Month As Integer = If(OnDate.Month = 1, 12, OnDate.Month - 1)
                    Dim Year As Integer = GetFinancialYearForMonth(Month, OnDate)
                    BaseDate = New Date(Now.Year, Month, DateTime.DaysInMonth(Year, Month))
                Case Enums.JobType.Quarterly
                    Dim Month As Integer = Utils.Periods.GetMonthForQuarter() + 2
                    Dim Year As Integer = Utils.Periods.GetFinancialYearForMonth(Month)
                    BaseDate = New Date(Year, Month, DateTime.DaysInMonth(Year, Month))
                Case Enums.JobType.HalfYerly
                    Dim Month As Integer = Utils.Periods.GetMonthForHalf() + 5
                    Dim Year As Integer = Utils.Periods.GetFinancialYearForMonth(Month)
                    BaseDate = New Date(Year, Month, DateTime.DaysInMonth(Year, Month))
                Case Enums.JobType.Yearly
                    BaseDate = GetLastDateOfLastFinancialYear(Now)
            End Select

            Return BaseDate.AddDays(Increment)
        End Function

        Function FinancialPeriod2AssessmentPeriod(ByVal Period As Objects.YearMonth, ByVal PeriodType As Enums.JobType) As Objects.YearMonth
            Select Case PeriodType
                Case Enums.JobType.Yearly
                    Dim S As String() = Period.Year.Split("-")
                    Return New Objects.YearMonth((CInt(S(0)) + 1).ToString & "-" & (CInt(S(1)) + 1), "")
                Case Enums.JobType.HalfYerly
                    Dim Halves As List(Of String) = GetHalves()
                    Dim Index As Integer = Halves.IndexOf(Period.Period)
                    If Index = 0 Then
                        Return New Objects.YearMonth(Period.Year, Halves(1))
                    ElseIf Index = 1 Then
                        Dim S As String() = Period.Year.Split("-")
                        Return New Objects.YearMonth((CInt(S(0)) + 1).ToString & "-" & (CInt(S(1)) + 1), Halves(0))
                    End If
                Case Enums.JobType.Quarterly
                    Dim Quarters As List(Of String) = GetQuarters()
                    Dim Index As Integer = Quarters.IndexOf(Period.Period)
                    If Index >= 0 And Index <= 2 Then
                        Return New Objects.YearMonth(Period.Year, Quarters(Index + 1))
                    ElseIf Index = 3 Then
                        Dim S As String() = Period.Year.Split("-")
                        Return New Objects.YearMonth((CInt(S(0)) + 1).ToString & "-" & (CInt(S(1)) + 1), Quarters(0))
                    End If
                Case Enums.JobType.Monthly
                    Dim Months As List(Of String) = GetMonths()
                    Dim Index As Integer = Months.IndexOf(Period.Period)
                    If Index >= 0 And Index <= Months.Count - 2 Then
                        Return New Objects.YearMonth(Period.Year, Months(Index + 1))
                    ElseIf Index = Months.Count - 1 Then
                        Dim S As String() = Period.Year.Split("-")
                        Return New Objects.YearMonth((CInt(S(0)) + 1).ToString & "-" & (CInt(S(1)) + 1), Months(0))
                    End If
            End Select
            Return Period
        End Function

        Function AssessmentPeriod2FinancialPeriod(ByVal Period As Objects.YearMonth, ByVal PeriodType As Enums.JobType) As Objects.YearMonth
            Select Case PeriodType
                Case Enums.JobType.Yearly
                    Dim S As String() = Period.Year.Split("-")
                    Return New Objects.YearMonth((CInt(S(0)) - 1).ToString & "-" & (CInt(S(1)) - 1), "")
                Case Enums.JobType.HalfYerly
                    Dim Halves As List(Of String) = GetHalves()
                    Dim Index As Integer = Halves.IndexOf(Period.Period)
                    If Index = 0 Then
                        Dim S As String() = Period.Year.Split("-")
                        Return New Objects.YearMonth((CInt(S(0)) - 1).ToString & "-" & (CInt(S(1)) - 1), Halves(1))
                    ElseIf Index = 1 Then
                        Return New Objects.YearMonth(Period.Year, Halves(0))
                    End If
                Case Enums.JobType.Quarterly
                    Dim Quarters As List(Of String) = GetQuarters()
                    Dim Index As Integer = Quarters.IndexOf(Period.Period)
                    If Index >= 1 And Index <= 3 Then
                        Return New Objects.YearMonth(Period.Year, Quarters(Index - 1))
                    ElseIf Index = 0 Then
                        Dim S As String() = Period.Year.Split("-")
                        Return New Objects.YearMonth((CInt(S(0)) + 1).ToString & "-" & (CInt(S(1)) + 1), Quarters(3))
                    End If
                Case Enums.JobType.Monthly
                    Dim Months As List(Of String) = GetMonths()
                    Dim Index As Integer = Months.IndexOf(Period.Period)
                    If Index >= 1 And Index <= Months.Count - 1 Then
                        Return New Objects.YearMonth(Period.Year, Months(Index - 1))
                    ElseIf Index = 0 Then
                        Dim S As String() = Period.Year.Split("-")
                        Return New Objects.YearMonth((CInt(S(0)) - 1).ToString & "-" & (CInt(S(1)) - 1), Months(Months.Count - 1))
                    End If
            End Select
            Return Period
        End Function

    End Module
End Namespace