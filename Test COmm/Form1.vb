Public Class Form1
    Dim d As String
    Sub CR()
        If Me.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf CR))
        Else
            ListBox1.Items.Add(d)
        End If
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TcpServerEx1.Start(8888)
    End Sub

    Private Sub TcpServerEx1_ClientConnected(sender As Object, e As GlobalCode.TCPClientEventArgs) Handles TcpServerEx1.ClientConnected
        d = "Client Connected : " & e.TCPClient.Client.RemoteEndPoint.ToString
        CR()
    End Sub

    Private Sub TcpServerEx1_CommunicationReceived(sender As Object, e As GlobalCode.CommunicatingObject) Handles TcpServerEx1.CommunicationReceived
        d = e.Data.ToString()
        CR()
    End Sub

    Private Sub TcpServerEx1_LogRaised(sender As Object, e As GlobalCode.LogObject) Handles TcpServerEx1.LogRaised
        Console.WriteLine(e.Message)
    End Sub
End Class
