
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Authentication
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks


Public Class Receiver
    Private receivingThread As Thread
    Private sendingThread As Thread

#Region "Properties"

    ''' <summary>
    ''' The receiver unique id.
    ''' </summary>
    Public Property ID() As Guid
        Get
            Return m_ID
        End Get
        Set(ByVal value As Guid)
            m_ID = Value
        End Set
    End Property
    Private m_ID As Guid
    ''' <summary>
    ''' The reference to the parent Server.
    ''' </summary>
    Public Property Server() As Server
        Get
            Return m_Server
        End Get
        Set(ByVal value As Server)
            m_Server = Value
        End Set
    End Property
    Private m_Server As Server
    ''' <summary>
    ''' The real TcpClient working in the background.
    ''' </summary>
    Public Property Client() As TcpClient
        Get
            Return m_Client
        End Get
        Set(ByVal value As TcpClient)
            m_Client = Value
        End Set
    End Property
    Private m_Client As TcpClient
    ''' <summary>
    ''' Contains a reference to the currently in session with this receiver instance is exists.
    ''' </summary>
    Public Property OtherSideReceiver() As Receiver
        Get
            Return m_OtherSideReceiver
        End Get
        Set(ByVal value As Receiver)
            m_OtherSideReceiver = Value
        End Set
    End Property
    Private m_OtherSideReceiver As Receiver
    ''' <summary>
    ''' The current status of the reciever instance.
    ''' </summary>
    Public Property Status() As StatusEnum
        Get
            Return m_Status
        End Get
        Set(ByVal value As StatusEnum)
            m_Status = Value
        End Set
    End Property
    Private m_Status As StatusEnum
    ''' <summary>
    ''' The message queue that contains all the messages to deliver to the remote client.
    ''' </summary>
    Public Property MessageQueue() As List(Of MessageBase)
        Get
            Return m_MessageQueue
        End Get
        Private Set(ByVal value As List(Of MessageBase))
            m_MessageQueue = Value
        End Set
    End Property
    Private m_MessageQueue As List(Of MessageBase)
    ''' <summary>
    ''' The Total bytes processed by this receiver instance.
    ''' </summary>
    Public Property TotalBytesUsage() As Long
        Get
            Return m_TotalBytesUsage
        End Get
        Set(ByVal value As Long)
            m_TotalBytesUsage = Value
        End Set
    End Property
    Private m_TotalBytesUsage As Long
    ''' <summary>
    ''' The Email address is used to authenticate the remote client.
    ''' </summary>
    Public Property Email() As [String]
        Get
            Return m_Email
        End Get
        Set(ByVal value As [String])
            m_Email = Value
        End Set
    End Property
    Private m_Email As [String]
    ''' <summary>
    ''' If true will produce and exception in some cases.
    ''' </summary>
    Public Property DebugMode() As Boolean
        Get
            Return m_DebugMode
        End Get
        Set(ByVal value As Boolean)
            m_DebugMode = Value
        End Set
    End Property
    Private m_DebugMode As Boolean

#End Region

#Region "Constructors"

    Public Sub New()
        ID = Guid.NewGuid()
        MessageQueue = New List(Of MessageBase)()
        Status = StatusEnum.Connected
    End Sub

    ''' <summary>
    ''' Initializes a new reciever instance
    ''' </summary>
    ''' <param name="client">The TcpClient to encapsulate that was obtained by the TcpListener.</param>
    ''' <param name="server">The reference to the parent server containing the receivers list.</param>
    Public Sub New(ByVal client__1 As TcpClient, ByVal server__2 As Server)
        Me.New()
        Server = server__2
        Client = client__1
        Client.ReceiveBufferSize = 1024
        Client.SendBufferSize = 1024
    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' Initializes the receiver and start transmitting data
    ''' </summary>
    Public Sub Start()
        receivingThread = New Thread(AddressOf ReceivingMethod)
        receivingThread.IsBackground = True
        receivingThread.Start()

        sendingThread = New Thread(AddressOf SendingMethod)
        sendingThread.IsBackground = True
        sendingThread.Start()
    End Sub

    ''' <summary>
    ''' Stops all data transmition and disconnectes the TcpClient
    ''' </summary>
    Private Sub Disconnect()
        If Status = StatusEnum.Disconnected Then
            Return
        End If

        If OtherSideReceiver IsNot Nothing Then
            OtherSideReceiver.OtherSideReceiver = Nothing
            OtherSideReceiver.Status = StatusEnum.Validated
            OtherSideReceiver = Nothing
        End If

        Status = StatusEnum.Disconnected
        Client.Client.Disconnect(False)
        Client.Close()
    End Sub

    ''' <summary>
    ''' Add the specified message to the message sender queue
    ''' </summary>
    ''' <param name="message">The message of type MessageBase that should be added to the queue</param>
    Public Sub SendMessage(ByVal message As MessageBase)
        MessageQueue.Add(message)
    End Sub

#End Region

#Region "Threads Methods"

    Private Sub SendingMethod()
        While Status <> StatusEnum.Disconnected
            If MessageQueue.Count > 0 Then
                Dim message = MessageQueue(0)

                Try
                    Dim f As New BinaryFormatter()
                    f.Serialize(Client.GetStream(), message)
                Catch
                    Disconnect()
                Finally
                    MessageQueue.Remove(message)
                End Try
            End If
            Thread.Sleep(30)
        End While
    End Sub

    Private Sub ReceivingMethod()
        While Status <> StatusEnum.Disconnected
            If Client.Available > 0 Then
                TotalBytesUsage += Client.Available

                Try
                    Dim f As New BinaryFormatter()
                    Dim msg As MessageBase = TryCast(f.Deserialize(Client.GetStream()), MessageBase)
                    OnMessageReceived(msg)
                Catch e As Exception
                    If DebugMode Then
                        Throw e
                    End If
                    Dim ex As New Exception("Unknown message recieved. Could not deserialize the stream.", e)
                    Debug.WriteLine(ex.Message)
                End Try
            End If

            Thread.Sleep(30)
        End While

    End Sub

#End Region

#Region "Message Handlers"

    Private Sub OnMessageReceived(ByVal msg As MessageBase)
        Dim type As Type = msg.[GetType]()

        If type = GetType(ValidationRequest) Then
            ValidationRequestHandler(TryCast(msg, ValidationRequest))
        ElseIf type = GetType(SessionRequest) Then
            SessionRequestHandler(TryCast(msg, SessionRequest))
        ElseIf type = GetType(SessionResponse) Then
            SessionResponseHandler(TryCast(msg, SessionResponse))
        ElseIf type = GetType(EndSessionRequest) Then
            EndSessionRequestHandler(TryCast(msg, EndSessionRequest))
        ElseIf type = GetType(DisconnectRequest) Then
            DisconnectRequestHandler(TryCast(msg, DisconnectRequest))
        ElseIf OtherSideReceiver IsNot Nothing Then
            OtherSideReceiver.SendMessage(msg)
        End If
    End Sub

    Private Sub EndSessionRequestHandler(ByVal request As EndSessionRequest)
        If OtherSideReceiver IsNot Nothing Then
            OtherSideReceiver.SendMessage(New EndSessionRequest())
            OtherSideReceiver.Status = StatusEnum.Validated
            OtherSideReceiver.OtherSideReceiver = Nothing

            Me.OtherSideReceiver = Nothing
            Me.Status = StatusEnum.Validated
            Me.SendMessage(New EndSessionResponse(request))
        End If
    End Sub

    Private Sub DisconnectRequestHandler(ByVal request As DisconnectRequest)
        If OtherSideReceiver IsNot Nothing Then
            OtherSideReceiver.SendMessage(New DisconnectRequest())
            OtherSideReceiver.Status = StatusEnum.Validated
        End If

        Disconnect()
    End Sub

    Private Sub SessionResponseHandler(ByVal response As SessionResponse)
        For Each receiver As Object In m_Server.Receivers.Where((Function(x) x <> Me))
            If receiver.Email = response.Email Then
                response.Email = Me.Email

                If response.IsConfirmed Then
                    receiver.OtherSideReceiver = Me
                    Me.OtherSideReceiver = receiver
                    Me.Status = StatusEnum.InSession
                    receiver.Status = StatusEnum.InSession
                Else
                    response.HasError = True
                    response.Exception = New Exception("The session request was refused by " + response.Email)
                End If

                receiver.SendMessage(response)
                Return
            End If
        Next
    End Sub

    Private Sub SessionRequestHandler(ByVal request As SessionRequest)
        Dim response As SessionResponse

        If Me.Status <> StatusEnum.Validated Then
            'Added after a code project user comment.
            response = New SessionResponse(request)
            response.IsConfirmed = False
            response.HasError = True
            response.Exception = New Exception("Could not request a new session. The current client is already in session, or is not loged in.")
            SendMessage(response)
            Return
        End If

        For Each receiver As Object In m_Server.Receivers.Where(Function(x) x <> Me)
            If receiver.Email = request.Email Then
                If receiver.Status = StatusEnum.Validated Then
                    request.Email = Me.Email
                    receiver.SendMessage(request)
                    Return
                End If
            End If
        Next

        response = New SessionResponse(request)
        response.IsConfirmed = False
        response.HasError = True
        response.Exception = New Exception(request.Email + " does not exists or not loged in or in session with another user.")
        SendMessage(response)
    End Sub

    Private Sub ValidationRequestHandler(ByVal request As ValidationRequest)
        Dim response As New ValidationResponse(request)

        Dim args As New ClientValidatingEventArgs(Function()
                                                      'Confirm Action
                                                      Status = StatusEnum.Validated
                                                      Email = request.Email
                                                      response.IsValid = True
                                                      SendMessage(response)
                                                      Server.OnClientValidated(Me)

                                                  End Function, Function()
                                                                    'Refuse Action
                                                                    response.IsValid = False
                                                                    response.HasError = True
                                                                    response.Exception = New AuthenticationException("Login failed for user " + request.Email)
                                                                    SendMessage(response)

                                                                End Function)

        args.Receiver = Me
        args.Request = request

        Server.OnClientValidating(args)
    End Sub

#End Region


End Class
