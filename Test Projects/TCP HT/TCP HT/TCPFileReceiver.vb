Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading

Public Class TCPFileReceiver
    Event FileReceived As EventHandler(Of FileReceivedEventArg)
    Event FileReceiveFailed As EventHandler(Of FileReceiveFailedEventArg)
    Private Const BufferSize As Integer = 1024
    Dim Port_ As Integer
    Dim AcceptFile_ As Boolean = False
    Dim FileName As String = ""
    ReadOnly Property Port As Integer
        Get
            Return Port_
        End Get
    End Property
    Dim IPAddressess_ As New List(Of String)
    ReadOnly Property IPAddressess As String()
        Get
            Return IPAddressess_.ToArray
        End Get
    End Property
    Public T As Thread = Nothing
    Event StatusChanged As EventHandler(Of StatusEventArgs)
    Sub Status(ByVal Text As String)
        RaiseEvent StatusChanged(Me, New StatusEventArgs(Text))
    End Sub
    Sub AcceptFile(ByVal FileName As String)
        Me.AcceptFile_ = True
        Me.FileName = FileName
    End Sub
    Sub Start(ByVal Port As Integer)
        Status("Server is Running...")
        Me.Port_ = Port
        Dim Ts As New ThreadStart(AddressOf StartReceiving)
        T = New Thread(Ts)
        T.Start()
    End Sub
    Private Sub StartReceiving()
        ReceiveTCP(Port)
    End Sub
    Public Sub ReceiveTCP(portN As Integer)
        Dim Listener As TcpListener = Nothing
        Try
            Listener = New TcpListener(IPAddress.Any, portN)
            Listener.Start()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim RecData As Byte() = New Byte(BufferSize - 1) {}
        Dim RecBytes As Integer

        While True
            Dim client As TcpClient = Nothing
            Dim netstream As NetworkStream = Nothing
            Status("")
            Try
                If Listener.Pending() AndAlso AcceptFile_ Then
                    client = Listener.AcceptTcpClient()
                    netstream = client.GetStream()
                    Status("Connected to a Sender")
                    If Me.FileName <> String.Empty Then
                        Dim totalrecbytes As Integer = 0
                        Dim Fs As New FileStream(Me.FileName, FileMode.OpenOrCreate, FileAccess.Write)
                        While (InlineAssignHelper(RecBytes, netstream.Read(RecData, 0, RecData.Length))) > 0
                            Fs.Write(RecData, 0, RecBytes)
                            totalrecbytes += RecBytes
                        End While
                        Fs.Close()
                    End If
                    netstream.Close()
                    client.Close()
                    RaiseEvent FileReceived(Me, New FileReceivedEventArg(Me.FileName))
                    AcceptFile_ = False
                End If
            Catch ex As Exception
                RaiseEvent FileReceiveFailed(Me, New FileReceiveFailedEventArg(Me.FileName, ex))
            End Try
        End While
    End Sub

    Sub StopServer()
        T.Abort()
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
