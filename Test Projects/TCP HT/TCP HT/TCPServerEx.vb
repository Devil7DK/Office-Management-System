Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Public Class TCPServerEx
    Event CommunicationReceived As EventHandler(Of CommunicatingObject)
    Dim ClientList As New List(Of TcpClient)
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
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Sub Start(ByVal Port As Integer)
        Dim listenThread As New Thread(New ParameterizedThreadStart(AddressOf ListenForClients))
        listenThread.Start(Port)
    End Sub
    Dim serverSocket As System.Net.Sockets.TcpListener
    Private Sub ListenForClients(ByVal Port As Integer)
        serverSocket = New TcpListener(Net.IPAddress.Any, Port)
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
    Sub Broadcast(ByVal Communication As CommunicatingObject)
        Dim bytes As [Byte]() = ObjectToByteArray(Communication)
        For Each Client As TcpClient In ClientList
            If Client.Connected Then
                Dim broadcastStream As NetworkStream = Client.GetStream()
                broadcastStream.Write(bytes, 0, bytes.Length)
                broadcastStream.Flush()
            End If
        Next
    End Sub
    Dim BufferSize As Integer = 1024
    Private Sub HandleClientComm(ByVal client As TcpClient)
        Dim clientStream As NetworkStream = client.GetStream()
        Dim RecData As Byte() = New Byte(BufferSize - 1) {}
        Dim RecBytes As Integer
        While client.Connected = True
            While client.Available <= 0

            End While
            Dim a As Integer = client.Available
            MsgBox("filereceview")
            RecBytes = 0
            RecData = New Byte(BufferSize - 1) {}
            Dim totalrecbytes As Integer = 0
            Dim ms As New IO.MemoryStream
            While 1 = 1
                Dim b As Byte = clientStream.ReadByte
                If b = -1 Then
                    Exit While
                End If
                ms.WriteByte(b)
            End While
            Dim c As CommunicatingObject = ByteArrayToObject(ms.ToArray)
            My.Computer.FileSystem.WriteAllBytes("c:\" & c.Filename, c.Data, False)
            ms.Close()
        End While
        client.Close()

    End Sub
    Sub dd()
        ' While InlineAssignHelper(RecBytes, client.GetStream.Read(RecData, totalrecbytes, RecData.Length)) > 0
        'MS.Write(RecData, 0, RecBytes)
        'totalrecbytes += RecBytes
        ' End While
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
