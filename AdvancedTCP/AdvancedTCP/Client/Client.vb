
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Public Class Client
    Private receivingThread As Thread
    Private sendingThread As Thread
    Private callBacks As List(Of ResponseCallbackObject)

#Region "Properties"

    ''' <summary>
    ''' The TcpClient that is encapsulated by this client instance.
    ''' </summary>
    Public Property TcpClient() As TcpClient
        Get
            Return m_TcpClient
        End Get
        Set(ByVal value As TcpClient)
            m_TcpClient = value
        End Set
    End Property
    Private m_TcpClient As TcpClient
    ''' <summary>
    ''' The ip/domain address of the remote server.
    ''' </summary>
    Public Property Address() As [String]
        Get
            Return m_Address
        End Get
        Private Set(ByVal value As [String])
            m_Address = value
        End Set
    End Property
    Private m_Address As [String]
    ''' <summary>
    ''' The Port that is used to connect to the remote server.
    ''' </summary>
    Public Property Port() As Integer
        Get
            Return m_Port
        End Get
        Private Set(ByVal value As Integer)
            m_Port = value
        End Set
    End Property
    Private m_Port As Integer
    ''' <summary>
    ''' The status of the client.
    ''' </summary>
    Public Property Status() As StatusEnum
        Get
            Return m_Status
        End Get
        Private Set(ByVal value As StatusEnum)
            m_Status = value
        End Set
    End Property
    Private m_Status As StatusEnum
    ''' <summary>
    ''' List containing all messages that is waiting to be delivered to the remote client/server
    ''' </summary>
    Public Property MessageQueue() As List(Of MessageBase)
        Get
            Return m_MessageQueue
        End Get
        Private Set(ByVal value As List(Of MessageBase))
            m_MessageQueue = value
        End Set
    End Property
    Private m_MessageQueue As List(Of MessageBase)

#End Region

#Region "Events"

    ''' <summary>
    ''' Raises when a new session is requested by a remote client.
    ''' </summary>
    Public Event SessionRequest As Delegates.SessionRequestDelegate
    ''' <summary>
    ''' Raises when a new text message was received by the remote session client.
    ''' </summary>
    Public Event TextMessageReceived As Action(Of Client, [String])
    ''' <summary>
    ''' Raises when a new file upload request was received by the remote session client.
    ''' </summary>
    Public Event FileUploadRequest As Delegates.FileUploadRequestDelegate
    ''' <summary>
    ''' Raises when a progress was made when a remote session client is uploading a file to this client instance.
    ''' </summary>
    Public Event FileUploadProgress As Action(Of Client, FileUploadProgressEventArguments)
    ''' <summary>
    ''' Raises when the client was disconnected;
    ''' </summary>
    Public Event ClientDisconnected As Action(Of Client)
    ''' <summary>
    ''' Raises when the remote session client was disconnected;
    ''' </summary>
    Public Event SessionClientDisconnected As Action(Of Client)
    ''' <summary>
    ''' Raises when a new unhandled message is received.
    ''' </summary>
    Public Event GenericRequestReceived As Action(Of Client, GenericRequest)
    ''' <summary>
    ''' Raises when the current session was ended by the remote client.
    ''' </summary>
    Public Event SessionEndedByTheRemoteClient As Action(Of Client)
#End Region

#Region "Constructors"

    ''' <summary>
    ''' Inisializes a new Client instance.
    ''' </summary>
    Public Sub New()
        callBacks = New List(Of ResponseCallbackObject)()
        MessageQueue = New List(Of MessageBase)()
        Status = StatusEnum.Disconnected
    End Sub

#End Region

#Region "Methods"
    Public Sub Connect(ByVal address__1 As [String], ByVal port__2 As Integer)
        Address = address__1
        Port = port__2
        TcpClient = New TcpClient()
        TcpClient.Connect(Address, Port)
        Status = StatusEnum.Connected
        TcpClient.ReceiveBufferSize = 1024
        TcpClient.SendBufferSize = 1024

        receivingThread = New Thread(AddressOf ReceivingMethod)
        receivingThread.IsBackground = True
        receivingThread.Start()

        sendingThread = New Thread(AddressOf SendingMethod)
        sendingThread.IsBackground = True
        sendingThread.Start()
    End Sub

    ''' <summary>
    ''' Disconnect from the remote server.
    ''' </summary>
    Public Sub Disconnect()
        MessageQueue.Clear()
        callBacks.Clear()
        Try
            SendMessage(New DisconnectRequest())
        Catch
        End Try
        Thread.Sleep(1000)
        Status = StatusEnum.Disconnected
        TcpClient.Client.Disconnect(False)
        TcpClient.Close()
        OnClientDisconnected()
    End Sub

    ''' <summary>
    ''' Log in to the remote server.
    ''' </summary>
    ''' <param name="email">The email address that will be used to identify this client instance.</param>
    ''' <param name="callback">Will be invoked when a Validation Response was received from remote server.</param>
    Public Sub Login(ByVal email As [String], ByVal callback As Action(Of Client, ValidationResponse))
        'Create a new validation request message
        Dim request As New ValidationRequest()
        request.Email = email

        'Add a callback before we send the message
        AddCallback(callback, request)

        'Send the message (Add it to the message queue)
        SendMessage(request)
    End Sub

    ''' <summary>
    ''' Request session from a remote client.
    ''' </summary>
    ''' <param name="email">The remote client email address (Case sensitive).</param>
    ''' <param name="callback">Will be invoked when a Session Response was received from the remote client.</param>
    Public Sub RequestSession(ByVal email As [String], ByVal callback As Action(Of Client, SessionResponse))
        Dim request As New SessionRequest()
        request.Email = email
        AddCallback(callback, request)
        SendMessage(request)
    End Sub

    ''' <summary>
    ''' Ends the current session with the remote user.
    ''' </summary>
    ''' <param name="callback">Will be invoked when an EndSession response was received from the server.</param>
    Public Sub EndCurrentSession(ByVal callback As Action(Of Client, EndSessionResponse))
        Dim request As New EndSessionRequest()
        AddCallback(callback, request)
        SendMessage(request)
    End Sub

    ''' <summary>
    ''' Watch the remote client's desktop.
    ''' </summary>
    ''' <param name="callback">Will be invoked when a RemoteDesktop Response was received.</param>
    Public Sub RequestDesktop(ByVal callback As Action(Of Client, RemoteDesktopResponse))
        Dim request As New RemoteDesktopRequest()
        AddCallback(callback, request)
        SendMessage(request)
    End Sub

    ''' <summary>
    ''' Send a text message to the remote client.
    ''' </summary>
    ''' <param name="message"></param>
    Public Sub SendTextMessage(ByVal message As [String])
        Dim request As New TextMessageRequest()
        request.Message = message
        SendMessage(request)
    End Sub

    ''' <summary>
    ''' Upload a file to the remote client.
    ''' </summary>
    ''' <param name="fileName">The full file path to the file.</param>
    ''' <param name="callback">Will be invoked when a progress is made in uploading the file</param>
    Public Sub UploadFile(ByVal fileName As [String], ByVal callback As Action(Of Client, FileUploadResponse))
        Dim request As New FileUploadRequest()
        request.SourceFilePath = fileName
        request.FileName = System.IO.Path.GetFileName(fileName)
        request.TotalBytes = FileHelper.GetFileLength(fileName)
        AddCallback(callback, request)
        SendMessage(request)
    End Sub

    ''' <summary>
    ''' Send a message of type MessageBase to the remote client.
    ''' </summary>
    ''' <param name="message"></param>
    Public Sub SendMessage(ByVal message As MessageBase)
        MessageQueue.Add(message)
    End Sub

    ''' <summary>
    ''' Send a message of type GenericRequest to the remote session client.
    ''' </summary>
    ''' <typeparam name="T">Type of response callback delegate.</typeparam>
    ''' <param name="request">A message of type GenericRequest.</param>
    ''' <param name="callBack">Callback method for the response.</param>
    Public Sub SendGenericRequest(Of T)(ByVal request As GenericRequest, ByVal callBack As T)
        Dim guid__1 As Guid = Guid.NewGuid()
        request.CallbackID = guid__1
        Dim genericRequest As New GenericRequest(request)
        genericRequest.CallbackID = guid__1
        If callBack IsNot Nothing Then
            callBacks.Add(New ResponseCallbackObject() With { _
             .CallBack = TryCast(callBack, [Delegate]), _
             .ID = guid__1 _
            })
        End If
        SendMessage(genericRequest)
    End Sub

    ''' <summary>
    ''' Send a message of type GenericResponse to the remote session client.
    ''' </summary>
    ''' <param name="response">A message of type GenericResponse.</param>
    Public Sub SendGenericResponse(ByVal response As GenericResponse)
        Dim genericResponse As New GenericResponse(response)
        SendMessage(genericResponse)
    End Sub

#End Region

#Region "Threads Methods"

    Private Sub SendingMethod(ByVal obj As Object)
        While Status <> StatusEnum.Disconnected
            If MessageQueue.Count > 0 Then
                Dim m As MessageBase = MessageQueue(0)

                Dim f As New BinaryFormatter()
                Try
                    f.Serialize(TcpClient.GetStream(), m)
                Catch
                    Disconnect()
                End Try

                MessageQueue.Remove(m)
            End If

            Thread.Sleep(30)
        End While
    End Sub

    Private Sub ReceivingMethod(ByVal obj As Object)
        While Status <> StatusEnum.Disconnected
            If TcpClient.Available > 0 Then
                'try
                '{
                Dim f As New BinaryFormatter()
                f.Binder = New AllowAllAssemblyVersionsDeserializationBinder()
                Dim msg As MessageBase = TryCast(f.Deserialize(TcpClient.GetStream()), MessageBase)
                '}
                'catch (Exception e)
                '{
                '    Exception ex = new Exception("Unknown message recieved. Could not deserialize the stream.", e);
                '    OnClientError(this, ex);
                '    Debug.WriteLine(ex.Message);
                '}
                OnMessageReceived(msg)
            End If

            Thread.Sleep(30)
        End While
    End Sub

#End Region

#Region "Message Handlers"

    Protected Overridable Sub OnMessageReceived(ByVal msg As MessageBase)
        Dim type As Type = msg.[GetType]()

        If TypeOf msg Is ResponseMessageBase Then
            If type = GetType(GenericResponse) Then
                msg = TryCast(msg, GenericResponse).ExtractInnerMessage()
            End If

            InvokeMessageCallback(msg, TryCast(msg, ResponseMessageBase).DeleteCallbackAfterInvoke)

            If type = GetType(RemoteDesktopResponse) Then
                RemoteDesktopResponseHandler(TryCast(msg, RemoteDesktopResponse))
            ElseIf type = GetType(FileUploadResponse) Then
                FileUploadResponseHandler(TryCast(msg, FileUploadResponse))
            End If
        Else
            If type = GetType(SessionRequest) Then
                SessionRequestHandler(TryCast(msg, SessionRequest))
            ElseIf type = GetType(EndSessionRequest) Then
                OnSessionEndedByTheRemoteClient()
            ElseIf type = GetType(RemoteDesktopRequest) Then
                RemoteDesktopRequestHandler(TryCast(msg, RemoteDesktopRequest))
            ElseIf type = GetType(TextMessageRequest) Then
                TextMessageRequestHandler(TryCast(msg, TextMessageRequest))
            ElseIf type = GetType(FileUploadRequest) Then
                FileUploadRequestHandler(TryCast(msg, FileUploadRequest))
            ElseIf type = GetType(DisconnectRequest) Then
                OnSessionClientDisconnected()
            ElseIf type = GetType(GenericRequest) Then
                OnGenericRequestReceived(TryCast(msg, GenericRequest))
            End If
        End If
    End Sub

    Private Sub RemoteDesktopResponseHandler(ByVal response As RemoteDesktopResponse)
        If Not response.Cancel Then
            Dim request As New RemoteDesktopRequest()
            request.CallbackID = response.CallbackID
            SendMessage(request)
        Else
            callBacks.RemoveAll(Function(x) x.ID = response.CallbackID)
        End If
    End Sub

    Private Sub FileUploadResponseHandler(ByVal response As FileUploadResponse)
        Dim request As New FileUploadRequest(response)

        If Not response.HasError Then
            If request.CurrentPosition < request.TotalBytes Then
                request.BytesToWrite = FileHelper.SampleBytesFromFile(request.SourceFilePath, request.CurrentPosition, request.BufferSize)
                request.CurrentPosition += request.BufferSize
                SendMessage(request)
            End If

        Else
        End If
    End Sub

    Private Sub FileUploadRequestHandler(ByVal request As FileUploadRequest)
        Dim response As New FileUploadResponse(request)

        If request.CurrentPosition = 0 Then
            Dim args As New FileUploadRequestEventArguments(Function()
                                                                'Confirm File Upload
                                                                response.DestinationFilePath = request.DestinationFilePath
                                                                SendMessage(response)

                                                            End Function, Function()
                                                                              'Refuse File Upload
                                                                              response.HasError = True
                                                                              response.Exception = New Exception("The file upload request was refused by the user!")
                                                                              SendMessage(response)

                                                                          End Function)

            args.Request = request
            OnFileUploadRequest(args)
        Else
            FileHelper.AppendAllBytes(request.DestinationFilePath, request.BytesToWrite)
            SendMessage(response)
            OnUploadFileProgress(New FileUploadProgressEventArguments() With { _
             .CurrentPosition = request.CurrentPosition, _
             .FileName = request.FileName, _
             .TotalBytes = request.TotalBytes, _
             .DestinationPath = request.DestinationFilePath _
            })
        End If
    End Sub

    Private Sub TextMessageRequestHandler(ByVal request As TextMessageRequest)
        OnTextMessageReceived(request.Message)
    End Sub

    Private Sub RemoteDesktopRequestHandler(ByVal request As RemoteDesktopRequest)
        Dim response As New RemoteDesktopResponse(request)
        Try
            response.FrameBytes = RemoteDesktop.CaptureScreenToMemoryStream(request.Quality)
        Catch e As Exception
            response.HasError = True
            response.Exception = e
        End Try

        SendMessage(response)
    End Sub

    Private Sub SessionRequestHandler(ByVal request As SessionRequest)
        Dim response As New SessionResponse(request)

        Dim args As New SessionRequestEventArguments(Function()
                                                         'Confirm Session
                                                         response.IsConfirmed = True
                                                         response.Email = request.Email
                                                         SendMessage(response)

                                                     End Function, Function()
                                                                       'Refuse Session
                                                                       response.IsConfirmed = False
                                                                       response.Email = request.Email
                                                                       SendMessage(response)

                                                                   End Function)

        args.Request = request
        OnSessionRequest(args)
    End Sub

#End Region

#Region "Callback Methods"

    Private Sub AddCallback(ByVal callBack As [Delegate], ByVal msg As MessageBase)
        If callBack IsNot Nothing Then
            Dim callbackID As Guid = Guid.NewGuid()
            Dim responseCallback As New ResponseCallbackObject() With { _
             .ID = callbackID, _
             .CallBack = callBack _
            }

            msg.CallbackID = callbackID
            callBacks.Add(responseCallback)
        End If
    End Sub

    Private Sub InvokeMessageCallback(ByVal msg As MessageBase, ByVal deleteCallback As Boolean)
        Dim callBackObject = callBacks.SingleOrDefault(Function(x) x.ID = msg.CallbackID)

        If callBackObject IsNot Nothing Then
            If deleteCallback Then
                callBacks.Remove(callBackObject)
            End If
            callBackObject.CallBack.DynamicInvoke(Me, msg)
        End If
    End Sub

#End Region

#Region "Virtuals"

    Protected Overridable Sub OnSessionRequest(ByVal args As SessionRequestEventArguments)
        RaiseEvent SessionRequest(Me, args)
    End Sub

    Protected Overridable Sub OnFileUploadRequest(ByVal args As FileUploadRequestEventArguments)
        RaiseEvent FileUploadRequest(Me, args)
    End Sub

    Protected Overridable Sub OnTextMessageReceived(ByVal txt As [String])
        RaiseEvent TextMessageReceived(Me, txt)
    End Sub

    Protected Overridable Sub OnUploadFileProgress(ByVal args As FileUploadProgressEventArguments)
        RaiseEvent FileUploadProgress(Me, args)
    End Sub

    Protected Overridable Sub OnClientDisconnected()
        RaiseEvent ClientDisconnected(Me)
    End Sub

    Protected Overridable Sub OnSessionClientDisconnected()
        RaiseEvent SessionClientDisconnected(Me)
    End Sub

    Protected Overridable Sub OnGenericRequestReceived(ByVal request As GenericRequest)
        RaiseEvent GenericRequestReceived(Me, request.ExtractInnerMessage())
    End Sub

    Protected Overridable Sub OnSessionEndedByTheRemoteClient()
        RaiseEvent SessionEndedByTheRemoteClient(Me)
    End Sub
#End Region
End Class
