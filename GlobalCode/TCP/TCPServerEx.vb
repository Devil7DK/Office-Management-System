Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Public Class TCPServerEx
    Event CommunicationReceived As EventHandler(Of CommunicatingObject)
    Event ClientConnected As EventHandler(Of TCPClientEventArgs)
    Event LogRaised As EventHandler(Of LogObject)
    Event ClientDisconnected As EventHandler(Of TCPClientEventArgs)
    Dim ClientList As New List(Of TcpClient)
    Private Sub RaiseLog(ByVal Message As String, ByVal OnDoing As String)
        RaiseEvent LogRaised(Me, New LogObject(Message, OnDoing))
    End Sub
    Private Sub RaiseLog(ByVal ErrorData As Exception, ByVal OnDoing As String)
        RaiseEvent LogRaised(Me, New LogObject(ErrorData, OnDoing))
    End Sub
    Function GetIPAddresses() As System.Net.IPAddress()
        Try
            Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
            Dim LocalIPString As String = ""
            For Each i As Net.IPAddress In localIP
                If i.ToString.Split(".").Count = 4 Then
                    LocalIPString &= i.ToString() & ";"
                End If
            Next
            Return localIP
            RaiseLog(LocalIPString, "TCPServer.GetIPAddresses")
        Catch ex As Exception
            RaiseLog(ex, "TCPServer.GetIPAddressess")
        End Try
        Return Nothing
    End Function
    Dim port As Integer
    Sub Start(ByVal Port As Integer)
        Me.port = Port
        Dim listenThread As New Thread(New ThreadStart(AddressOf ListenForClients))
        listenThread.Start()
    End Sub
    Private Function RNGCharacterMask() As String
        Dim maxSize As Integer = 8
        Dim minSize As Integer = 5
        Dim chars As Char() = New Char(61) {}
        Dim a As String
        a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        chars = a.ToCharArray()
        Dim size As Integer = maxSize
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New System.Security.Cryptography.RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        size = maxSize
        data = New Byte(size - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New System.Text.StringBuilder(size)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length - 1)))
        Next
        Return result.ToString()
    End Function
    Dim serverSocket As System.Net.Sockets.TcpListener
    Private Sub ListenForClients()
        Try
            RaiseLog("Server Started at port : " & Me.port, "TCPServer.Listen")
            serverSocket = New TcpListener(Me.port)
            serverSocket.Start()
            While True  'blocks until a client has connected to the server
                Dim client As TcpClient = Me.serverSocket.AcceptTcpClient()
                RaiseLog("Client Connected with endpoint :" & client.Client.RemoteEndPoint.ToString, "TCPServer.Listen")
                RaiseEvent ClientConnected(Me, New TCPClientEventArgs(client))
                Dim clientThread As New Thread(New ParameterizedThreadStart(AddressOf HandleClientComm))
                ClientList.Add(client)
                clientThread.Start(client)
            End While
        Catch ex As Exception
            RaiseLog(ex, "TCPServer.Listen")
        End Try
    End Sub
    Private Sub Broadcast(ByVal bytes As [Byte]())
        RaiseLog("Data Broadcast : " & bytes.Length, "TCPServer.Broadcast")
        Try
            For Each Client As TcpClient In ClientList
                If Client.Connected Then
                    Dim broadcastStream As NetworkStream = Client.GetStream()
                    broadcastStream.Write(bytes, 0, bytes.Length)
                    broadcastStream.Flush()
                End If
            Next
        Catch ex As Exception
            RaiseLog(ex, "TCPServer.Broadcast")
        End Try
    End Sub
    Public Sub Broadcast(ByVal Comm As CommunicatingObject)
        Dim bytes As Byte() = ObjectToByteArray(Comm)
        RaiseLog("Data Broadcast : " & bytes.Length, "TCPServer.Broadcast")
        Try
            For Each Client As TcpClient In ClientList
                If Client.Connected Then
                    Dim broadcastStream As NetworkStream = Client.GetStream()
                    broadcastStream.Write(bytes, 0, bytes.Length)
                    broadcastStream.Flush()
                End If
            Next
        Catch ex As Exception
            RaiseLog(ex, "TCPServer.Broadcast")
        End Try
    End Sub
    Private Sub HandleClientComm(ByVal client As TcpClient)
        Try
            Dim clientStream As NetworkStream = client.GetStream()
            Dim message As Byte() = New Byte(4095) {}
            Dim bytesRead As Integer
            While True
                bytesRead = 0
                bytesRead = clientStream.Read(message, 0, 4096) 'blocks until a client sends a message
                If bytesRead = 0 Then
                    RaiseEvent ClientDisconnected(Me, New TCPClientEventArgs(client))
                    Exit While 'the client has disconnected from the server
                End If
                Broadcast(message)
                Dim co As CommunicatingObject = ByteArrayToObject(message)
                Dim ct As CommunicationType = co.CommunicatingType
                RaiseEvent CommunicationReceived(Me, co)
                RaiseLog("Data Received : " & ct.ToString, "TCPServer.HandleClient")
            End While
            client.Close()
        Catch ex As Exception
            RaiseLog(ex, "TCPServer.HandleClient")
        End Try
    End Sub
End Class
