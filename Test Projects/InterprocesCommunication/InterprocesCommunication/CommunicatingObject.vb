Public Class CommunicatingObject
    Dim Data_ As String = ""
    Dim SessionID_ As String = ""
    Sub New(ByVal SessionID As String)
        Me.SessionID_ = SessionID
    End Sub
    ReadOnly Property SessionID As String
        Get
            Return Me.SessionID_
        End Get
    End Property
    ReadOnly Property Data As String
        Get
            Return Me.Data_
        End Get
    End Property
End Class
