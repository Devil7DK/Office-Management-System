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

Namespace Dialogs
    Public Class frm_DigitalKeysAlert

#Region "Consturctor"
        Sub New(ByVal DigitalKeys As List(Of Objects.DigitalKeyInfo))
            InitializeComponent()

            gc_DigitalKeys.DataSource = DigitalKeys
            Utils.Misc.MakeColumnsFilterable(gv_DigitalKeys)
            Utils.Misc.FitColumnsToContent(gv_DigitalKeys)
        End Sub
#End Region

#Region "Events"
        Private Sub gv_DigitalKeys_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gv_DigitalKeys.RowCellStyle
            If e.Column.FieldName = "DaysToExpire" Then
                If e.CellValue IsNot Nothing Then
                    Try
                        Dim Value As Integer = CInt(e.CellValue)
                        e.Appearance.BackColor = Utils.Misc.ColorLerp(Drawing.Color.FromArgb(255, 255, 160, 160), Drawing.Color.LightGreen, If(Value > 365, 1, (Value / 365)))
                    Catch ex As Exception

                    End Try
                End If
            ElseIf e.Column.FieldName = "Validity" Then
                If e.CellValue IsNot Nothing Then
                    Try
                        Dim Value As Enums.DigitalKeyValidity = CInt(e.CellValue)
                        Select Case Value
                            Case Enums.DigitalKeyValidity.Valid
                                e.Appearance.BackColor = Drawing.Color.LightGreen
                            Case Enums.DigitalKeyValidity.ExpiringSoon
                                e.Appearance.BackColor = Drawing.Color.LightYellow
                            Case Enums.DigitalKeyValidity.ExpiringToday
                                e.Appearance.BackColor = Drawing.Color.FromArgb(255, 255, 80, 80)
                            Case Enums.DigitalKeyValidity.Expired
                                e.Appearance.BackColor = Drawing.Color.FromArgb(255, 255, 160, 160)
                        End Select
                    Catch ex As Exception

                    End Try
                End If
            End If
        End Sub
#End Region

    End Class
End Namespace