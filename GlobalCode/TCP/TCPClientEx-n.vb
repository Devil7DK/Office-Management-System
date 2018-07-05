Public Class TCPClientEx
    Event CommunicationReceived As EventHandler(Of CommunicatingObject)
    Event LogRaised As EventHandler(Of LogObject)
    Dim LocalIPString As String = ""
    Dim ID As String = RNGCharacterMask()
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

    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As Net.Sockets.NetworkStream
    Dim infiniteCounter As Integer


    Private Sub getMessage()

        Try
            For infiniteCounter = 1 To 2
                infiniteCounter = 1
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
    Sub Send(ByVal Comm As CommunicatingObject)
        Dim outStream As Byte() = ObjectConverter.ObjectToByteArray(Comm)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
    End Sub
    Dim ctThread As Threading.Thread
    Property UserName As String
    Sub Connect(ByVal IP As String, ByVal Port As Integer, ByVal UserName As String)
        Try
            Me.UserName = UserName
            clientSocket.Connect(IP, Port)
            serverStream = clientSocket.GetStream()
            Dim co As New CommunicatingObject(ID, UserName, "SERVER", CommunicationType.Message, "Client Connected.")
            Dim outStream As Byte() = ObjectToByteArray(co)
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
            ctThread = New Threading.Thread(AddressOf getMessage)
            ctThread.Start()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source)
        End Try
    End Sub

  
    Private Sub TCPClientEx_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
       
    End Sub
End Class
