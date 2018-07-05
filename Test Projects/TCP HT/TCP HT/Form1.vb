Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TcpFileReceiver1.Start(8888)
        TcpFileReceiver1.AcceptFile("C:\tc.txt")
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        TcpFileSender1.Load()
        TcpFileSender1.Send("c:\t.txt", "127.0.0.1", 8889)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim b() As Byte = My.Computer.FileSystem.ReadAllBytes("c:\t.txt")
        MsgBox(b.Length)
        Dim c As New CommunicatingObject("tc.txt", b)
        MsgBox(ObjectToByteArray(c).Length)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TcpServerEx1.Start(8891)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TcpClientEx1.Send(New CommunicatingObject(IO.Path.GetFileName(OpenFileDialog1.FileName), My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)))
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TcpClientEx1.Connect("127.0.0.1", 8891)
    End Sub
End Class
