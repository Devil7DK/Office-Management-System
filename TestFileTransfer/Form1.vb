Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TcpClientEx1.Connect("127.0.0.1", 7788)
    End Sub

    Private Sub TcpClientEx1_CommunicationReceived(sender As Object, e As GlobalCode.CommunicatingObject) Handles TcpClientEx1.CommunicationReceived
        ListBox1.Items.Add("Received")
    End Sub
    Function GetIP()
        Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
        Dim LocalIPString As String = ""
        For Each i As Net.IPAddress In localIP
            If i.ToString.Split(".").Count = 4 Then
                LocalIPString = i.ToString()
            End If
        Next
        Return LocalIPString
    End Function

    Private Sub TcpClientEx1_LogRaised(sender As Object, e As GlobalCode.LogObject) Handles TcpClientEx1.LogRaised
        If e.LogType = GlobalCode.LogTypes.Inf Then
            ListBox1.Items.Add(e.Message)
        Else
            ListBox1.Items.Add(e.ErrorException.StackTrace & " " & e.ErrorException.Message)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Dim file2send As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file2send = OpenFileDialog1.FileName
            TcpClientEx1.Send(New GlobalCode.CommunicatingObject("", TextBox1.Text, InputBox("Enter Name"), GlobalCode.CommunicationType.FileSentDetails, IO.Path.GetFileName(file2send)))
        End If
    End Sub

    Private Sub TcpFileReceiver1_FileReceived(sender As Object, e As GlobalCode.FileReceivedEventArg) Handles TcpFileReceiver1.FileReceived
        TcpClientEx1.Send(New GlobalCode.CommunicatingObject("", TextBox1.Text, TcpFileReceiver1.Sender, GlobalCode.CommunicationType.FileReceived, "Done"))
    End Sub
End Class
