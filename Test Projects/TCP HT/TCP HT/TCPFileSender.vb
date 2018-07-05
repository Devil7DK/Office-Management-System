

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class TCPFileSender
    Private Const BufferSize As Integer = 1024
    Event SentSuccessful As EventHandler(Of StatusEventArgs)
    Event SentFailed As EventHandler(Of StatusEventArgs)
    Event StatusChanged As EventHandler(Of StatusEventArgs)
    Sub Status(ByVal Text As String)
        RaiseEvent StatusChanged(Me, New StatusEventArgs(Text))
    End Sub
    Property ProgressIndicator As Control
    Sub Load()
        ProgressIndicator.Visible = True
        CType(ProgressIndicator, Object).Minimum = 1
        CType(ProgressIndicator, Object).Value = 1
        CType(ProgressIndicator, Object).[Step] = 1
    End Sub
    Sub Send(ByVal Filename As String, ByVal IP As String, ByVal Port As Integer)
        If My.Computer.FileSystem.FileExists(Filename) Then
            SendTCP(Filename, IP, Port)
        End If
    End Sub
    Private Function the_function_you_need(ByVal arr As Byte(), ByVal ix As Integer, _
    ByVal len As Integer) As Byte()
        Dim arr2 As Byte() = New Byte(len - 1) {}
        Array.Copy(arr, ix, arr2, 0, len)
        Return arr2
    End Function
    Public Sub SendTCP(M As String, IPA As String, PortN As Int32)
        Dim SendingBuffer As Byte() = Nothing
        Dim client As TcpClient = Nothing
        Status("")
        Dim netstream As NetworkStream = Nothing
        'Try
        client = New TcpClient(IPA, PortN)
        Status("Connected to the Server..." & vbLf)
        netstream = client.GetStream()
        Dim arra As Byte() = ObjectToByteArray(New CommunicatingObject("_" & IO.Path.GetFileName(M), My.Computer.FileSystem.ReadAllBytes(M)))
        Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(arra.Length) / Convert.ToDouble(BufferSize)))
        CType(ProgressIndicator, Object).Maximum = NoOfPackets
        Dim TotalLength As Integer = CInt(arra.Length), CurrentPacketLength As Integer, counter As Integer = 0
        Dim br As Integer = 0

        For i As Integer = 0 To NoOfPackets - 1
            If TotalLength > BufferSize Then
                CurrentPacketLength = BufferSize
                TotalLength = TotalLength - CurrentPacketLength
            Else
                CurrentPacketLength = TotalLength
            End If
            SendingBuffer = the_function_you_need(arra, br, CurrentPacketLength)
            br += CurrentPacketLength
            netstream.Write(SendingBuffer, 0, CInt(SendingBuffer.Length))
            If CType(ProgressIndicator, Object).Value >= CType(ProgressIndicator, Object).Maximum Then
                CType(ProgressIndicator, Object).Value = CType(ProgressIndicator, Object).Minimum
            End If
            CType(ProgressIndicator, Object).PerformStep()
        Next
        Status("Sent " & br.ToString() & " bytes to the server")
        'Catch ex As Exception
        'MsgBox(ex.Message)
        RaiseEvent SentFailed(Me, New EventArgs)
        '
        netstream.Close()
        client.Close()
        RaiseEvent SentSuccessful(Me, New EventArgs)
        'End Try
    End Sub


End Class
