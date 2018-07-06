Public Class Job
    Sub New(ByVal ID As String, ByVal JID As String, ByVal Name As String, ByVal Group As String, ByVal SubGroup As String, ByVal Type As JobType, ByVal Steps As List(Of String), ByVal Templates As List(Of String))
        Me.ID_ = ID
        Me.JID = JID
        Me.Name = Name
        Me.Group = Group
        Me.SubGroup = SubGroup
        Me.Type = Type
        Me.Steps = Steps
        Me.Templates = Templates
    End Sub
    Sub New(ByVal JID As String)
        Me.JID = JID
    End Sub
    Sub New(ByVal JID As String, ByVal ConnectionString As String)
        Me.JID = JID
        LoadJobByID(JID, Me.ID_, Me.Name, Me.Group, Me.Type, Me.SubGroup)
    End Sub
    Dim ID_ As Integer = -1
    Property ID As Integer
        Get
            Return ID_
        End Get
        Set(value As Integer)
            ID_ = value
        End Set
    End Property
    Property Name As String
    Property Group As String
    Property SubGroup As String
    Property Type As JobType
    Property Steps As List(Of String)
    Property Templates As List(Of String)
    Property JID As String
    Public Overrides Function ToString() As String
        Return Name.ToString()
    End Function
    Public Class Comparer
        Implements IComparer(Of Job)
        Function Compare(ByVal x As Job, ByVal y As Job) As Integer Implements System.Collections.Generic.IComparer(Of Job).Compare
            Return x.JID.CompareTo(y.JID)
        End Function
    End Class
End Class
