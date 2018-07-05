
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading.Tasks
Imports AdvancedTCP.Delegates

Public Class Server
    ''' <summary>
    ''' The TcpListener that is encapsulated behind this Server instance.
    ''' </summary>
    Public Property Listener() As TcpListener
        Get
            Return m_Listener
        End Get
        Set(ByVal value As TcpListener)
            m_Listener = value
        End Set
    End Property
    Private m_Listener As TcpListener
    ''' <summary>
    ''' The Port that is used to listen to incoming connections.
    ''' </summary>
    Public Property Port() As Integer
        Get
            Return m_Port
        End Get
        Set(ByVal value As Integer)
            m_Port = value
        End Set
    End Property
    Private m_Port As Integer
    ''' <summary>
    ''' Returns true if the Server instance is running.
    ''' </summary>
    Public Property IsStarted() As Boolean
        Get
            Return m_IsStarted
        End Get
        Private Set(ByVal value As Boolean)
            m_IsStarted = value
        End Set
    End Property
    Private m_IsStarted As Boolean
    ''' <summary>
    ''' List of currently connected receivers.
    ''' </summary>
    Public Property Receivers() As List(Of Receiver)
        Get
            Return m_Receivers
        End Get
        Private Set(ByVal value As List(Of Receiver))
            m_Receivers = value
        End Set
    End Property
    Private m_Receivers As List(Of Receiver)

#Region "Events"
    ''' <summary>
    ''' Raises when a new client is waiting for validation.
    ''' </summary>
    Public Event ClientValidating As Delegates.ClientValidatingDelegate
    ''' <summary>
    ''' Raises when a new client is connected.
    ''' </summary>
    Public Event ClientConnected As Delegates.ClientBasicDelegate
    ''' <summary>
    ''' Raises when a new client is validated.
    ''' </summary>
    Public Event ClientValidated As ClientBasicDelegate
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Initializes a new Server instance.
    ''' </summary>
    ''' <param name="port">The port number that is used to listen for incoming connections.</param>
    Public Sub New(ByVal port__1 As Integer)
        Receivers = New List(Of Receiver)()
        Port = port__1
    End Sub
#End Region

#Region "Public Methods"

    ''' <summary>
    ''' Start Listening for incoming connections.
    ''' </summary>
    Public Sub Start()
        If Not IsStarted Then
            Listener = New TcpListener(System.Net.IPAddress.Any, Port)
            Listener.Start()
            IsStarted = True
            Debug.WriteLine("Server Started!")

            'Start Async pattern for accepting new connections
            WaitForConnection()
        End If
    End Sub
    ''' <summary>
    ''' Stop listening for incoming connections.
    ''' </summary>
    Public Sub [Stop]()
        If IsStarted Then
            Listener.[Stop]()
            IsStarted = False

            Debug.WriteLine("Server Stoped!")
        End If
    End Sub

#End Region

#Region "Incoming Connections Methods"

    Private Sub WaitForConnection()
        Listener.BeginAcceptTcpClient(New AsyncCallback(AddressOf ConnectionHandler), Nothing)
    End Sub

    Private Sub ConnectionHandler(ByVal ar As IAsyncResult)
        SyncLock Receivers
            Dim newClient As New Receiver(Listener.EndAcceptTcpClient(ar), Me)
            newClient.Start()
            Receivers.Add(newClient)
            OnClientConnected(newClient)
        End SyncLock

        Debug.WriteLine("New Client Connected")
        WaitForConnection()
    End Sub


#End Region

#Region "Virtuals"
    Public Overridable Sub OnClientValidating(ByVal args As ClientValidatingEventArgs)
        RaiseEvent ClientValidating(args)
    End Sub

    Public Overridable Sub OnClientConnected(ByVal receiver As Receiver)
        RaiseEvent ClientConnected(receiver)
    End Sub

    Public Overridable Sub OnClientValidated(ByVal receiver As Receiver)
        RaiseEvent ClientValidated(receiver)
    End Sub
#End Region
End Class
