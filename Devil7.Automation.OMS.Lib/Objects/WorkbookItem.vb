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
    Public Class WorkbookItem

        Sub New(ByVal ID As Integer, ByVal AssignedToUser As User, ByVal Job As Job, ByVal Client As ClientMinimal,
             ByVal DueDate As Date, ByVal AddedOn As Date, ByVal CompletedOn As Date,
             ByVal UpdatedOn As Date, ByVal Description As String, ByVal Remarks As String,
             ByVal TargetDate As Date, ByVal PriorityOfWork As Enums.Priority, ByVal Status As Enums.WorkStatus, ByVal CurrentStep As String, ByVal Owner As User, ByVal History As String, ByVal BillingStatus As Enums.BillingStatus, ByVal AssementDetail As YearMonth, ByVal FinancialDetail As YearMonth)
            Me.ID = ID
            Me.AssignedTo = AssignedToUser
            Me.Job = Job
            Me.Client = Client
            Me.DueDate = DueDate
            Me.AddedOn = AddedOn
            Me.CompletedOn = CompletedOn
            Me.UpdatedOn = UpdatedOn
            Me.Description = Description
            Me.Remarks = Remarks
            Me.TargetDate = TargetDate
            Me.PriorityOfWork = PriorityOfWork
            Me.Status = Status
            Me.CurrentStep = CurrentStep
            Me.Owner = Owner
            Me.History = New List(Of String)(History.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
            Me.BillingStatus = BillingStatus
            Me.AssementDetail = AssementDetail
            Me.FinancialDetail = FinancialDetail
        End Sub

        Property ID As Integer
        Property History As List(Of String)
        Property Owner As User
        Property AssignedTo As User
        Property Job As Job
        Property Client As ClientMinimal
        Property AssementDetail As YearMonth
        Property FinancialDetail As YearMonth
        Property Status As Enums.WorkStatus
        Property CurrentStep As String
        Property DueDate As Date
        Property AddedOn As Date
        Property CompletedOn As Date
        Property UpdatedOn As Date
        Property Description As String
        Property Remarks As String
        Property TargetDate As Date
        Property PriorityOfWork As Enums.Priority
        Property Folder As String
        Property BillingStatus As Enums.BillingStatus

        Sub AddHistory(ByVal Text As String)
            If Text <> "" Then
                History.Add(Text)
            End If
        End Sub

        Function GetHistory()
            Dim r As String = ""
            For Each i As String In History
                r &= i & vbNewLine
            Next
            Return r.Trim
        End Function

    End Class
End Namespace
