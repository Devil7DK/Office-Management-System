Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class Service1
    Dim ClientList As New List(Of TcpClient)
    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
            Dim LocalIPString As String = ""
            For Each i As Net.IPAddress In localIP
                If i.ToString.Split(".").Count = 4 Then
                    LocalIPString &= i.ToString() & vbNewLine
                End If
            Next
            My.Computer.FileSystem.WriteAllText("C:\IP.txt", LocalIPString, False)
        Catch ex As Exception

        End Try
        Dim listenThread As New Thread(New ThreadStart(AddressOf ListenForClients))
        listenThread.Start()
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
    End Sub

    Dim serverSocket As System.Net.Sockets.TcpListener

    Private Sub ListenForClients()
        serverSocket = New TcpListener(8888)
        serverSocket.Start()
        While True  'blocks until a client has connected to the server
            Dim client As TcpClient = Me.serverSocket.AcceptTcpClient()
            Dim clientThread As New Thread(New ParameterizedThreadStart(AddressOf HandleClientComm))
            ClientList.Add(client)
            clientThread.Start(client)
        End While
    End Sub
    Private Sub broadcast(ByVal bytes As [Byte]())
        For Each Client As TcpClient In ClientList
            If Client.Connected Then
                Dim broadcastStream As NetworkStream = Client.GetStream()
                broadcastStream.Write(bytes, 0, bytes.Length)
                broadcastStream.Flush()
            End If
        Next
    End Sub
    Private Sub HandleClientComm(ByVal client As TcpClient)
        Dim clientStream As NetworkStream = client.GetStream()
        Dim message As Byte() = New Byte(4095) {}
        Dim bytesRead As Integer
        While True
            bytesRead = 0
            bytesRead = clientStream.Read(message, 0, 4096) 'blocks until a client sends a message
            If bytesRead = 0 Then
                Exit While 'the client has disconnected from the server
            End If
            broadcast(message)
        End While
        client.Close()
    End Sub

End Class
