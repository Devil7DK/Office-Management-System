Public Class FileReceivedEventArg
    Inherits EventArgs
    Property Filename As String
    Sub New(ByVal Filename As String)
        Me.Filename = Filename
    End Sub
End Class
