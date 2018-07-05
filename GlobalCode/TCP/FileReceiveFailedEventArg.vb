Public Class FileReceiveFailedEventArg
    Inherits EventArgs
    Property Filename As String
    Property ErrorData As Exception
    Sub New(ByVal Filename As String, ByVal ErrorException As Exception)
        Me.Filename = Filename
        Me.ErrorData = ErrorException
    End Sub
End Class
