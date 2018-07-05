Public Class TCPClientEx
    Event CommunicationReceived As EventHandler(Of CommunicatingObject)
    Event LogRaised As EventHandler(Of LogObject)
    Dim LocalIPString As String = ""
    Dim ctThread As Threading.Thread
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As Net.Sockets.NetworkStream
    Dim infiniteCounter As Integer
    ReadOnly Property TCPClient As Net.Sockets.TcpClient
        Get
            Return clientSocket
        End Get
    End Property
    Private Function RNGCharacterMask() As String
        Dim maxSize As Integer = 8
        Dim minSize As Integer = 5
        Dim chars As Char() = New Char(61) {}
        Dim a As String
        a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        chars = a.ToCharArray()
        Dim size As Integer = maxSize
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New Security.Cryptography.RNGCryptoServiceProvider()
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
    Private Sub ReceiveLoop()
        Try
            For Me.infiniteCounter = 1 To 2
                Me.infiniteCounter = 1
                Dim buffSize As Integer
                Dim inStream(10024) As Byte
                buffSize = clientSocket.ReceiveBufferSize
                serverStream.Read(inStream, 0, buffSize)
                Try
                    Dim RCO As CommunicatingObject = ByteArrayToObject(inStream)
                    RaiseEvent CommunicationReceived(Me, RCO)
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
            RaiseLog(ex, "TCPClient.ReceiveLoop")
        End Try
    End Sub
    Sub Send(ByVal CommObj As CommunicatingObject)
        Try
            If CommObj IsNot Nothing Then
                Dim outStream As Byte() = ObjectConverter.ObjectToByteArray(CommObj)
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()
                RaiseLog("Object Successfully Send", "TCPClient.Send")
            End If
        Catch ex As Exception
            RaiseLog(ex, "TCPClient.Send")
        End Try
    End Sub
    Private Sub RaiseLog(ByVal Message As String, ByVal OnDoing As String)
        RaiseEvent LogRaised(Me, New LogObject(Message, OnDoing))
    End Sub
    Private Sub RaiseLog(ByVal ErrorData As Exception, ByVal OnDoing As String)
        RaiseEvent LogRaised(Me, New LogObject(ErrorData, OnDoing))
    End Sub
    Sub Connect(ByVal IP As String, ByVal Port As Integer)
        Try
            clientSocket.Connect(IP, Port)
            serverStream = clientSocket.GetStream()
            RaiseLog("Connected to Server", "TCPClient.Connect")
            ctThread = New Threading.Thread(AddressOf ReceiveLoop)
            ctThread.Start()
        Catch ex As Exception
            RaiseLog(ex, "TCPClient.Connect")
        End Try
    End Sub
    Sub Disconnect()
        Dim t As New Threading.Thread(AddressOf DC)
        t.Start()
    End Sub
    Private Sub DC()
        Try
            ctThread.Abort()
        Catch ex As Exception

        End Try
        Try
            clientSocket.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TCPClientEx_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        On Error Resume Next
        ctThread.Abort()
        clientSocket.Close()
    End Sub
End Class
