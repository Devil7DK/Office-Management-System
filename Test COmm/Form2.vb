Public Class Form2
    Dim d As String = ""
    Sub CR()
        If Me.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf CR))
        Else
            ListBox1.Items.Add(D)
        End If
    End Sub
    Private Sub TcpClientEx1_CommunicationReceived(sender As Object, e As GlobalCode.CommunicatingObject) Handles TcpClientEx1.CommunicationReceived
        d = e.Data.ToString
        CR()
    End Sub

    Private Sub TcpClientEx1_LogRaised(sender As Object, e As GlobalCode.LogObject) Handles TcpClientEx1.LogRaised
        Console.WriteLine(e.Message)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TcpClientEx1.Connect("127.0.0.1", 8888)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TcpClientEx1.Send(New GlobalCode.CommunicatingObject("00", "TEstclient", "All", GlobalCode.CommunicationType.Message, TextBox1.Text))
    End Sub
End Class