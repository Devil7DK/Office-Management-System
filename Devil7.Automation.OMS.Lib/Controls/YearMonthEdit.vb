﻿'=========================================================================='
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

Namespace Controls
    Public Class YearMonthEdit

#Region "Variables"
        Dim PeriodType_ As Enums.JobType = Enums.JobType.Yearly
        Dim ReadOnly_ As Boolean = False
#End Region

#Region "Properties"
        Property [ReadOnly] As Boolean
            Get
                Return ReadOnly_
            End Get
            Set(value As Boolean)
                ReadOnly_ = value
                cmb_Period.ReadOnly = value
                cmb_Year.ReadOnly = value
            End Set
        End Property

        Property PeriodType As Enums.JobType
            Get
                Return PeriodType_
            End Get
            Set(value As Enums.JobType)
                PeriodType_ = value
                Select Case value
                    Case Enums.JobType.HalfYerly
                        cmb_Period.Properties.Items.Clear()
                        cmb_Period.Properties.Items.AddRange(Utils.Periods.GetHalves)
                        cmb_Period.SelectedIndex = 0
                        lbl_Period.Visible = True
                        lbl_Period.Text = "Half :"
                        cmb_Period.Visible = True
                    Case Enums.JobType.Quarterly
                        cmb_Period.Properties.Items.Clear()
                        cmb_Period.Properties.Items.AddRange(Utils.Periods.GetQuarters)
                        cmb_Period.SelectedIndex = 0
                        lbl_Period.Visible = True
                        lbl_Period.Text = "Quarter :"
                        cmb_Period.Visible = True
                    Case Enums.JobType.Monthly
                        cmb_Period.Properties.Items.Clear()
                        cmb_Period.Properties.Items.AddRange(Utils.Periods.GetMonths)
                        cmb_Period.SelectedIndex = 0
                        lbl_Period.Visible = True
                        lbl_Period.Text = "Month :"
                        cmb_Period.Visible = True
                    Case Else
                        lbl_Period.Visible = False
                        cmb_Period.Visible = False
                End Select
            End Set
        End Property

        Property Value As Objects.YearMonth
            Get
                Return New Objects.YearMonth(cmb_Year.SelectedItem, cmb_Period.SelectedItem)
            End Get
            Set(value As Objects.YearMonth)
                RaiseEvent OnValueChanged(Me, New EventArgs)
                cmb_Year.SelectedItem = value.Year
                cmb_Period.SelectedItem = value.Period
            End Set
        End Property
#End Region

#Region "Constructors"
        Sub New()
            InitializeComponent()

            cmb_Year.Properties.Items.AddRange(Utils.GetYears.ToArray)
            cmb_Period.Properties.Items.AddRange(Utils.GetMonths.ToArray)
            cmb_Year.SelectedIndex = 0
            cmb_Period.SelectedIndex = 0
        End Sub
#End Region

#Region "Events"
        Public Event OnValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Private Sub cmb_Year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Year.SelectedIndexChanged
            RaiseEvent OnValueChanged(Me, New EventArgs)
        End Sub

        Private Sub cmb_Period_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Period.SelectedIndexChanged
            RaiseEvent OnValueChanged(Me, New EventArgs)
        End Sub
#End Region
    End Class
End Namespace