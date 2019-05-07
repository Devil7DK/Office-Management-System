Public Class data_Cover

#Region "Properties"
    Property Sender As [Lib].Objects.Sender
    Property Receiver As [Lib].Objects.Receiver
#End Region

#Region "Constructor"
    Sub New(ByVal Sender As [Lib].Objects.Sender, ByVal Receiver As [Lib].Objects.Receiver)
        Me.Sender = Sender
        Me.Receiver = Receiver
    End Sub
#End Region

End Class
