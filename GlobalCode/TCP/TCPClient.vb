Public Class TCPClientEventArgs
    Inherits EventArgs
    Sub New(ByVal TCPClient As System.Net.Sockets.TcpClient)
        Me.TCPClient = TCPClient
    End Sub
    Property TCPClient As System.Net.Sockets.TcpClient
End Class
