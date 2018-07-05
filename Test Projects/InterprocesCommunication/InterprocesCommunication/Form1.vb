Imports System.Security.Cryptography
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Ipc
Imports InterprocesCommunication.Sharing

Public Class Form1
    Public SessionID As String = RNGCharacterMask()
    Dim ipcChServer As IpcChannel
    Dim ipcChClient As IpcChannel

    Private Function RNGCharacterMask() As String
        Dim maxSize As Integer = 8
        Dim minSize As Integer = 5
        Dim chars As Char() = New Char(61) {}
        Dim a As String
        a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        chars = a.ToCharArray()
        Dim size As Integer = maxSize
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
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
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        ipcChServer = New IpcChannel("Server:" & SessionID)
        ipcChClient = New IpcChannel(SessionID)
        ChannelServices.RegisterChannel(ipcChServer, False)
        RemotingConfiguration.RegisterWellKnownServiceType( _
        GetType(CommunicationService), "SreeniRemoteObj", _
        WellKnownObjectMode.Singleton)

        Label1.Text = SessionID
        Label2.Text = Now.ToString("dd-MM-yyyy hh:mm:ss tt")
        Dim r As New Random
        Panel1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256))
    End Sub
    Sub RefreshAll()
        Label2.Text = Now.ToString("dd-MM-yyyy hh:mm:ss tt")
        Dim r As New Random
        Panel1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'On Error Resume Next
        Dim co As New CommunicatingObject(SessionID)
        ChannelServices.RegisterChannel(ipcChClient, False)
        Dim obj As ICommunicationService = _
        DirectCast(Activator.GetObject(GetType(ICommunicationService), _
        "ipc://OMSLOCALSERVER/SreeniRemoteObj"), CommunicationService)
        obj.RefreshAll(co)
        ChannelServices.UnregisterChannel(ipcChClient)
    End Sub
End Class
Public Class CommunicationService
    Inherits MarshalByRefObject
    Implements ICommunicationService
    Public Sub RefreshAll(ByVal Value As CommunicatingObject) Implements ICommunicationService.RefreshAll
        If Form1.sessionID <> Value.SessionID Then
            Form1.RefreshAll()
        End If
    End Sub
End Class