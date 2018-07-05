Public Class WorkbookItem

    Sub New(ByVal ID As Integer, ByVal AssignedToUser As User, ByVal Job As Job, ByVal Client As Client, _
             ByVal DueDate As Date, ByVal AddedOn As Date, ByVal CompletedOn As Date, _
             ByVal UpdatedOn As Date, ByVal Description As String, ByVal Remarks As String, _
             ByVal TargetDate As Date, ByVal PriorityOfWork As Priority, ByVal Status As WorkStatus, ByVal CurrentStep As String, ByVal Owner As User, ByVal History As String)
        Me.ID_ = ID
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
        Me.History_.AddRange(History.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
    End Sub
    Dim ID_ As Integer = -1
    ReadOnly Property ID As Integer
        Get
            Return ID_
        End Get
    End Property
    Dim History_ As New List(Of String)
    ReadOnly Property History As List(Of String)
        Get
            Return History_
        End Get
    End Property
    Property Owner As User
    Property AssignedTo As User
    Property Job As Job
    Property Client As Client
    Property CurrentStep As String
    Property DueDate As Date
    Property AddedOn As Date
    Property CompletedOn As Date
    Property UpdatedOn As Date
    Property Description As String
    Property Remarks As String
    Property TargetDate As Date
    Property PriorityOfWork As Priority
    Property Status As WorkStatus
    Property Folder As String
    Property AssementDetail As String
    Property FinancialDetail As String
    Sub AddHistory(ByVal Text As String)
        If Text <> "" Then
            History_.Add(Text)
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
