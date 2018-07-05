

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
    Event SentSuccessful As EventHandler(Of EventArgs)
    Event SentFailed As EventHandler(Of EventArgs)
    Event StatusChanged As EventHandler(Of StatusEventArgs)
    Sub Status(ByVal Text As String)
        RaiseEvent StatusChanged(Me, New StatusEventArgs(Text))
    End Sub
    Property ProgressIndicator As ProgressBar
    Delegate Sub SetValueVoidDelegate([value] As Integer)
    Private Sub SetValue(ByVal [value] As Integer)
        If Me.ProgressIndicator.InvokeRequired Then
            Dim d As New SetValueVoidDelegate(AddressOf SetValue)
            Me.ProgressIndicator.FindForm.Invoke(d, New Object() {[value]})
        Else
            Me.ProgressIndicator.Value = If([value] > Me.ProgressIndicator.Maximum, Me.ProgressIndicator.Maximum, If([value] < Me.ProgressIndicator.Minimum, Me.ProgressIndicator.Minimum, [value]))
        End If
    End Sub
    Delegate Sub SetVisibleVoidDelegate([value] As Integer)
    Private Sub SetVisible(ByVal [value] As Integer)
        If Me.ProgressIndicator.InvokeRequired Then
            Dim d As New SetVisibleVoidDelegate(AddressOf SetVisible)
            Me.ProgressIndicator.FindForm.Invoke(d, New Object() {[value]})
        Else
            Me.ProgressIndicator.Visible = [value]
        End If
    End Sub
    Delegate Sub SetMinimumVoidDelegate([value] As Integer)
    Private Sub SetMin(ByVal [value] As Integer)
        If Me.ProgressIndicator.InvokeRequired Then
            Dim d As New SetMinimumVoidDelegate(AddressOf SetMin)
            Me.ProgressIndicator.FindForm.Invoke(d, New Object() {[value]})
        Else
            Me.ProgressIndicator.Minimum = [value]
        End If
    End Sub
    Sub PerformStep()
        Me.ProgressIndicator.FindForm.Invoke(Sub()
                                                 Me.ProgressIndicator.PerformStep()
                                             End Sub)
    End Sub
    Function GetValue()
        Return Me.ProgressIndicator.Value
    End Function
    Function GetMin()
        Return Me.ProgressIndicator.Minimum
    End Function
    Function GetMax()
        Return Me.ProgressIndicator.Maximum
    End Function
    Delegate Sub SetMaximumVoidDelegate([value] As Integer)
    Private Sub SetMax(ByVal [value] As Integer)
        If Me.ProgressIndicator.InvokeRequired Then
            Dim d As New SetMaximumVoidDelegate(AddressOf SetMax)
            Me.ProgressIndicator.FindForm.Invoke(d, New Object() {[value]})
        Else
            Me.ProgressIndicator.Maximum = [value]
        End If
    End Sub
    Delegate Sub SetStepVoidDelegate([value] As Integer)
    Private Sub SetStep(ByVal [value] As Integer)
        If Me.ProgressIndicator.InvokeRequired Then
            Dim d As New SetStepVoidDelegate(AddressOf SetStep)
            Me.ProgressIndicator.FindForm.Invoke(d, New Object() {[value]})
        Else
            Me.ProgressIndicator.Step = [value]
        End If
    End Sub
    Sub Load()
        Try
            SetVisible(True)
            SetMin(1)
            SetValue(1)
            SetStep(1)
        Catch ex As Exception

        End Try
    End Sub
    Sub Send(ByVal Filename As String, ByVal IP As String, ByVal Port As Integer)
        If My.Computer.FileSystem.FileExists(Filename) Then
            SendTCP(Filename, IP, Port)
        Else
            Status("File not found. Send Failed")
            RaiseEvent SentFailed(Me, New EventArgs)
        End If
    End Sub
    Public Sub SendTCP(M As String, IPA As String, PortN As Int32)
        Dim SendingBuffer As Byte() = Nothing
        Dim client As TcpClient = Nothing
        Dim err_ As Boolean = False
        Status("")
        Dim netstream As NetworkStream = Nothing
        Try
            client = New TcpClient(IPA, PortN)
            Status("Connected to the Server..." & vbLf)
            netstream = client.GetStream()
            Dim Fs As New FileStream(M, FileMode.Open, FileAccess.Read)
            Dim NoOfPackets As Integer = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)))
            SetMax(NoOfPackets)
            Status("Packets:" & NoOfPackets)
            Dim TotalLength As Integer = CInt(Fs.Length), CurrentPacketLength As Integer, counter As Integer = 0
            Dim CL As Integer = 0
            SetMax(TotalLength)
            For i As Integer = 0 To NoOfPackets - 1

                Status(((i / (NoOfPackets - 1)) * 100).ToString("000.00") & "%")
                If TotalLength > BufferSize Then
                    CurrentPacketLength = BufferSize
                    TotalLength = TotalLength - CurrentPacketLength
                Else
                    CurrentPacketLength = TotalLength
                End If
                CL += CurrentPacketLength
                SendingBuffer = New Byte(CurrentPacketLength - 1) {}
                Fs.Read(SendingBuffer, 0, CurrentPacketLength)
                netstream.Write(SendingBuffer, 0, CInt(SendingBuffer.Length))
                If CL <= GetMax() Then
                    SetValue(CL)
                End If
            Next
            Status("Sent " & Fs.Length.ToString() & " bytes to the server")
            Try
                Fs.Close()
            Catch ex As Exception

            End Try
        Catch ex As Exception
            err_ = True
        End Try
        If err_ = True Then
            RaiseEvent SentFailed(Me, New EventArgs)
        Else
            Try
                netstream.Close()
                client.Close()
                RaiseEvent SentSuccessful(Me, New EventArgs)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


End Class
