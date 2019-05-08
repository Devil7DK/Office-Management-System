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

Namespace Controls
    Public Class BillItemArgs

#Region "Variables"
        Dim Type_ As Enums.BillItemType = Enums.BillItemType.NoDate
        Dim ReadOnly_ As Boolean = False
#End Region

#Region "Properties"
        Property [ReadOnly] As Boolean
            Get
                Return ReadOnly_
            End Get
            Set(value As Boolean)
                ReadOnly_ = value
                txt_From.ReadOnly = value
                txt_To.ReadOnly = value
                txt_SingleItem.ReadOnly = value
            End Set
        End Property

        Property Type As Enums.BillItemType
            Get
                Return Type_
            End Get
            Set(value As Enums.BillItemType)
                Type_ = value
                Select Case value
                    Case Enums.BillItemType.NoDate
                        Me.Visible = False
                    Case Enums.BillItemType.Date
                        Me.Visible = True
                        Me.panel_Single.Visible = True
                        Me.panel_Double.Visible = False

                        Me.lbl_SingleItem.Text = "Date"
                        Me.txt_SingleItem.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                        Me.txt_SingleItem.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                        Me.txt_SingleItem.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.Default
                    Case Enums.BillItemType.TwoDate
                        Me.Visible = True
                        Me.panel_Single.Visible = False
                        Me.panel_Double.Visible = True

                        Me.txt_From.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                        Me.txt_From.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                        Me.txt_From.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.Default

                        Me.txt_To.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                        Me.txt_To.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                        Me.txt_To.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.Default
                    Case Enums.BillItemType.Month
                        Me.Visible = True
                        Me.panel_Single.Visible = True
                        Me.panel_Double.Visible = False

                        Me.lbl_SingleItem.Text = "Date"
                        Me.txt_SingleItem.Properties.DisplayFormat.FormatString = "MMMMM yyyy"
                        Me.txt_SingleItem.Properties.DisplayFormat.FormatString = "MMMMM yyyy"
                        Me.txt_SingleItem.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView + DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView
                    Case Enums.BillItemType.TwoMonths
                        Me.Visible = True
                        Me.panel_Single.Visible = False
                        Me.panel_Double.Visible = True

                        Me.txt_From.Properties.DisplayFormat.FormatString = "MMMMM yyyy"
                        Me.txt_From.Properties.DisplayFormat.FormatString = "MMMMM yyyy"
                        Me.txt_From.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView + DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView

                        Me.txt_To.Properties.DisplayFormat.FormatString = "MMMMM yyyy"
                        Me.txt_To.Properties.DisplayFormat.FormatString = "MMMMM yyyy"
                        Me.txt_To.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView + DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView
                    Case Enums.BillItemType.Year
                        Me.Visible = True
                        Me.panel_Single.Visible = True
                        Me.panel_Double.Visible = False

                        Me.lbl_SingleItem.Text = "Date"
                        Me.txt_SingleItem.Properties.DisplayFormat.FormatString = "yyyy"
                        Me.txt_SingleItem.Properties.DisplayFormat.FormatString = "yyyy"
                        Me.txt_SingleItem.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView + DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView
                    Case Enums.BillItemType.TwoYear
                        Me.Visible = True
                        Me.panel_Single.Visible = False
                        Me.panel_Double.Visible = True

                        Me.txt_From.Properties.DisplayFormat.FormatString = "yyyy"
                        Me.txt_From.Properties.DisplayFormat.FormatString = "yyyy"
                        Me.txt_From.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView + DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView

                        Me.txt_To.Properties.DisplayFormat.FormatString = "yyyy"
                        Me.txt_To.Properties.DisplayFormat.FormatString = "yyyy"
                        Me.txt_To.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView + DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView
                End Select
            End Set
        End Property

        ReadOnly Property Value As String()
            Get
                Dim Values As New List(Of String)
                Dim MaxCount As Integer = 5

                Select Case Type_
                    Case Enums.BillItemType.Date, Enums.BillItemType.Month, Enums.BillItemType.Year
                        Values.Add(txt_SingleItem.Text)
                    Case Enums.BillItemType.TwoDate, Enums.BillItemType.TwoMonths, Enums.BillItemType.TwoYear
                        Values.Add(txt_From.Text)
                        Values.Add(txt_To.Text)
                End Select

                For i As Integer = 1 To MaxCount - Values.Count
                    Values.Add("")
                Next

                Return Values.ToArray
            End Get
        End Property
#End Region

#Region "Events"
        Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        Private Sub RaiseValueChanged(sender As Object, e As EventArgs) Handles txt_SingleItem.TextChanged, txt_To.TextChanged, txt_From.TextChanged, txt_SingleItem.LostFocus, txt_To.LostFocus, txt_From.LostFocus
            RaiseEvent ValueChanged(Me, New EventArgs)
        End Sub

        Private Sub BillItemArgs_Load(sender As Object, e As EventArgs) Handles Me.Load
            txt_SingleItem.DateTime = Today

            txt_From.DateTime = Today
            txt_To.DateTime = Today.AddMonths(1)
        End Sub
#End Region

    End Class
End Namespace