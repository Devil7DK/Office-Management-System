Public Class TCPClientEx
    Event CommunicationReceived As EventHandler(Of CommunicatingObject)
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
                serverStream = clientSocket.GetStream()
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
        End Try
    End Sub
    Dim BufferSize As Integer = 1024
    Private Function CutByteArray(ByVal arr As Byte(), ByVal ix As Integer, _
   ByVal len As Integer) As Byte()
        Dim arr2 As Byte() = New Byte(len - 1) {}
        Array.Copy(arr, ix, arr2, 0, len)
        Return arr2
    End Function
    Sub Send(ByVal CommObj As CommunicatingObject)
        'Try
        If CommObj IsNot Nothing Then
            Dim outStream As Byte() = ObjectConverter.ObjectToByteArray(CommObj)
            Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(outStream.Length) / Convert.ToDouble(BufferSize)))
            Dim TotalLength As Integer = CInt(outStream.Length), CurrentPacketLength As Integer, counter As Integer = 0
            Dim br As Integer = 0
            MsgBox(NoOfPackets)
            MsgBox(TotalLength)
            For i As Integer = 0 To NoOfPackets - 1
                Dim SendingBuffer As Byte()
                If TotalLength > BufferSize Then
                    CurrentPacketLength = BufferSize
                    TotalLength = TotalLength - CurrentPacketLength
                Else
                    CurrentPacketLength = TotalLength
                End If
                SendingBuffer = CutByteArray(outStream, br, CurrentPacketLength)
                br += CurrentPacketLength
                serverStream.Write(SendingBuffer, 0, CInt(SendingBuffer.Length))
            Next
        End If
        'Catch ex As Exception
        'End Try
    End Sub
    Sub Connect(ByVal IP As String, ByVal Port As Integer)
        Try
            clientSocket.Connect(IP, Port)
            ctThread = New Threading.Thread(AddressOf ReceiveLoop)
            ctThread.Start()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TCPClientEx_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        On Error Resume Next
        ctThread.Abort()
        clientSocket.Close()
    End Sub
End Class
