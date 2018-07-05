Public Class StatusEventArgs
    Inherits EventArgs
    Property StatusText As String
    Sub New(ByVal StatusText As String)
        Me.StatusText = StatusText
    End Sub
End Class
