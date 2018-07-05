Public Class LogObject
    Inherits EventArgs
    Sub New(ByVal Message As String, ByVal OnDoing As String)
        Me.Time_ = Now
        Me.ErrorException_ = Nothing
        Me.LogType_ = LogTypes.Inf
        Me.Message_ = Message
        Me.OnDoing_ = OnDoing
    End Sub
    Sub New(ByVal ErrorData As Exception, ByVal OnDoing As String)
        Me.Time_ = Now
        Me.ErrorException_ = ErrorData
        Me.LogType_ = LogTypes.Err
        Me.Message_ = ""
        Me.OnDoing_ = OnDoing
    End Sub
    Dim OnDoing_ As String
    ReadOnly Property OnDoing As String
        Get
            Return OnDoing_
        End Get
    End Property
    Dim Time_ As Date
    ReadOnly Property Time As String
        Get
            Return Time_.ToString("dd/MM/yyyy hh:mm:ss tt")
        End Get
    End Property
    Dim Message_ As String
    ReadOnly Property Message As String
        Get
            Return Message_
        End Get
    End Property
    Dim LogType_ As LogTypes
    ReadOnly Property LogType As LogTypes
        Get
            Return LogType_
        End Get
    End Property
    Dim ErrorException_ As Exception
    ReadOnly Property ErrorException As Exception
        Get
            Return ErrorException_
        End Get
    End Property
End Class
Public Enum LogTypes
    Inf
    Err
End Enum
