Imports System.Net.Sockets
Imports System.Threading
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class MainService
    Public Declare Function Everything_SetSearchA Lib "Everything32.dll" (ByVal search As String) As UInt32
    Public Declare Function Everything_QueryA Lib "Everything32.dll" (ByVal bWait As Integer) As Integer
    Public Declare Function Everything_GetNumResults Lib "Everything32.dll" () As UInt32
    Public Declare Function Everything_GetResultFileNameA Lib "Everything32.dll" (ByVal index As UInt32) As String
    Public Declare Function Everything_GetLastError Lib "Everything32.dll" () As UInt32
    Public Declare Function Everything_GetResultFullPathNameA Lib "Everything32.dll" (ByVal index As UInt32, ByVal buf As String, ByVal size As UInt32) As UInt32

    Dim Port As Integer = 8888
    Sub INI_Process()
        Dim INI As New GlobalCode.INI
        Dim INIFile As String = IO.Path.Combine(Application.StartupPath, "Service.ini")
        If My.Computer.FileSystem.FileExists(INIFile) Then
            INI.Load(INIFile)
            Port = INI.GetKeyValue("SERVER", "Port")
        Else
            INI.AddSection("SERVER").AddKey("Port").SetValue("8888")
            Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
            Dim c As Integer = 0
            For Each i As Net.IPAddress In localIP
                If i.ToString.Split(".").Count = 4 Then
                    INI.AddSection("SERVER").AddKey("IP" & c).SetValue(i.ToString)
                End If
                c += 1
            Next
            INI.Save(INIFile)
        End If
    End Sub
    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            My.Computer.FileSystem.DeleteFile("c:\TCPServer.log.txt")
        Catch ex As Exception

        End Try
        INI_Process()
        Try
            Process.Start(IO.Path.Combine(Application.StartupPath, "Everything\Everything.exe"))
        Catch ex As Exception

        End Try
        TcpServerEx1.Start(Port)
    End Sub
    
    Protected Overrides Sub OnStop()

    End Sub
    Dim Random As New Random
    Sub Log(ByVal LogMs As GlobalCode.LogObject)
        Try
            If LogMs.LogType = GlobalCode.LogTypes.Inf Then
                My.Computer.FileSystem.WriteAllText("c:\TCPServer.log.txt", LogMs.Time & vbTab & LogMs.LogType.ToString & vbTab & LogMs.OnDoing & vbTab & LogMs.Message & vbNewLine, True)
            ElseIf LogMs.LogType = GlobalCode.LogTypes.Err Then
                My.Computer.FileSystem.WriteAllText("c:\TCPServer.log.txt", LogMs.Time & vbTab & LogMs.LogType.ToString & vbTab & LogMs.OnDoing & vbTab & "Ex.Message:" & LogMs.ErrorException.Message & "Source:" & LogMs.ErrorException.Source & "StackTrace:" & LogMs.ErrorException.StackTrace & vbNewLine, True)
            End If
        Catch ex1 As Exception

        End Try
    End Sub

    Private Sub TcpServerEx1_ClientConnected(sender As Object, e As GlobalCode.TCPClientEventArgs) Handles TcpServerEx1.ClientConnected
        Log(New GlobalCode.LogObject("Client Connected : " & e.TCPClient.Client.RemoteEndPoint.ToString, "TCPServer.ClientConnected"))
    End Sub

    Private Sub TcpServerEx1_CommunicationReceived(sender As Object, e As GlobalCode.CommunicatingObject) Handles TcpServerEx1.CommunicationReceived
       If e.CommunicatingType = GlobalCode.CommunicationType.Command Then
            Select Case e.Data.ToString
                Case "SHUTDOWN"
                    Process.Start("shutdown.exe", "-s -f -t 00")
                Case "RESTART"
                    Process.Start("shutdown.exe", "-r -f -t 00")
            End Select
        End If
    End Sub

    Private Sub TcpServerEx1_LogRaised(sender As Object, e As GlobalCode.LogObject) Handles TcpServerEx1.LogRaised
        Log(e)
    End Sub
End Class
