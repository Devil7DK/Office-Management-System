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
    Public Class WorkBookItem

#Region "Properties"
        Dim Item_ As Objects.WorkbookItem
        Property Item As Objects.WorkbookItem
            Get
                Return Item_
            End Get
            Set(value As Objects.WorkbookItem)
                Item_ = value
                LoadValues
            End Set
        End Property
#End Region

#Region "Subs"
        Private Sub LoadValues()
            If Item_ IsNot Nothing Then
                txt_User.Text = Item_.Owner.ToString
                txt_Job.Text = Item_.Job.ToString
                txt_Client.Text = Item_.Client.ToString
                txt_DueDate.DateTime = Item_.DueDate
                txt_TargetDate.DateTime = Item_.TargetDate
                txt_Priority.Text = Item_.PriorityOfWork
                txt_FinancialYearMonth.Value = Item_.FinancialDetail
                txt_AssessmentYearMonth.Value = Item_.AssementDetail
                txt_Description.Text = Item_.Description
                txt_Remarks.Text = Item_.Remarks
                txt_Status.Text = Item_.Status
                txt_Steps.Text = Item_.CurrentStep
                txt_CurrentlyAssignedTo.Text = Item_.AssignedTo.ToString
                Dim History As String = ""
                For Each i As String In Item_.History
                    History &= i & vbNewLine
                Next
                txt_History.Text = History.Trim
            End If
        End Sub
#End Region

    End Class
End Namespace