<Serializable()> _
Public Class CommunicatingObject
    Inherits System.EventArgs
    Dim Data_ As Object
    Dim ID_ As String = ""
    Dim Name_ As String = ""
    Dim Time_ As String
    Dim MessageTo_ As String
    Dim CommunicatingType_ As Integer
    Sub New(ByVal ID As String, ByVal Name As String, ByVal MessageTo As String, ByVal CommunicatingType As CommunicationType, ByVal Data As Object)
        Me.ID_ = ID
        Me.Name_ = Name
        Me.Time_ = Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Me.CommunicatingType_ = CommunicatingType
        Me.Data_ = Data
        Me.MessageTo_ = MessageTo
    End Sub
    ReadOnly Property Name As String
        Get
            Return Name_
        End Get
    End Property
    ReadOnly Property ID As String
        Get
            Return Me.ID_
        End Get
    End Property
    ReadOnly Property Data As Object
        Get
            Return Me.Data_
        End Get
    End Property
    ReadOnly Property Time As String
        Get
            Return Time_
        End Get
    End Property
    ReadOnly Property CommunicatingType As Integer
        Get
            Return Me.CommunicatingType_
        End Get
    End Property
    ReadOnly Property MessageTo As String
        Get
            Return MessageTo_
        End Get
    End Property
    Public Overrides Function ToString() As String
        Dim R As String = "ID:" & ID_ & vbNewLine & "Name:" & Name_ & vbNewLine & "Time:" & Time_ & vbNewLine & "MessageTo:" & MessageTo_ & vbNewLine & "CommType:" & CommunicatingType_.ToString & vbNewLine & "DataType:" & Data_.GetType.ToString
        Return R
    End Function
End Class
