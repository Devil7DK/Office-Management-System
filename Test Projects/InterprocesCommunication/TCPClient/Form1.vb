Imports GlobalCode

Public Class Form1
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

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        ctThread.Abort()
        clientSocket.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
        For Each i As Net.IPAddress In localIP
            If i.ToString.Split(".").Count = 4 Then
                LocalIPString &= i.ToString() & "; "
            End If
        Next
        Me.Text &= " - " & LocalIPString
        RefreshAll()
        EnableAll()
    End Sub
    Sub RefreshAll()
        Dim r As New Random
        pnl_color.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256))
    End Sub
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As Net.Sockets.NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer



    Private Sub msg()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            txt_Console.Text &= Environment.NewLine + " >> " + readData
        End If
    End Sub
    Sub ExecuteCommand(ByVal Command As String)
        If Command = "Refresh" Then
            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf RefreshAll))
            Else
                RefreshAll()
            End If
        ElseIf Command = "Clear" Then
            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf ClearConsole))
            Else
                ClearConsole()
            End If
        End If
    End Sub

    Sub ClearConsole()
        txt_Console.Text = ""
    End Sub
    Private Sub getMessage()
        DisableAll()
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
                    readData = "" & RCO.Time & " " & RCO.Name & vbTab & ": " & RCO.Data
                    msg()
                    If RCO.Data <> "" Then
                        ExecuteCommand(RCO.Data)
                    End If
                Catch ex As Exception
                    Try
                        Dim returndata As String = _
          System.Text.Encoding.ASCII.GetString(inStream)
                        readData = "" & returndata
                        msg()
                    Catch ex1 As Exception
                        readData = ex1.Message
                        msg()
                    End Try
                End Try
            Next
        Catch ex As Exception
            EnableAll()
        End Try
    End Sub
    Sub EnableAll()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf EnableAll))
        Else
            txt_Console.Text = ""
            txt_Command.Enabled = False
            txt_Name.Enabled = True
            txt_ServerIP.Enabled = True
            btn_Connect.Enabled = True
            btn_Send.Enabled = False
        End If
    End Sub
    Sub DisableAll()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf DisableAll))
        Else
            txt_Command.Enabled = True
            txt_Name.Enabled = False
            txt_ServerIP.Enabled = False
            btn_Connect.Enabled = False
            btn_Send.Enabled = True
        End If
    End Sub
    Private Sub btn_Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Send.Click
        If txt_Command.Text.Trim <> "" Then
            Dim co As New CommunicatingObject(ID, txt_Name.Text, "All", CommunicationType.Message, txt_Command.Text.Trim)
            Dim outStream As Byte() = ObjectConverter.ObjectToByteArray(co)
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
        End If
    End Sub
    Dim ctThread As Threading.Thread
    Private Sub btn_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Connect.Click
        Try
            clientSocket.Connect(txt_ServerIP.Text, 8888)
            readData = "Conected to Server ..."
            msg()
            'Label1.Text = "Client Socket Program - Server Connected ..."
            serverStream = clientSocket.GetStream()
            Dim co As New CommunicatingObject(ID, txt_Name.Text, "ALL", CommunicationType.Message, "Client Connected.")
            Dim outStream As Byte() = ObjectToByteArray(co)
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
            ctThread = New Threading.Thread(AddressOf getMessage)
            ctThread.Start()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine & ex.Source)
        End Try
    End Sub

    Private Sub txt_ServerIP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ServerIP.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ServerIP.Enabled = True Then
                btn_Connect.PerformClick()
            End If
        End If
    End Sub

    Private Sub txt_Command_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Command.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_Command.Enabled = True Then
                btn_Send.PerformClick()
            End If
        End If
    End Sub


End Class
