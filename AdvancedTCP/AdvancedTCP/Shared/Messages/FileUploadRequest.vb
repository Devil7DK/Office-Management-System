
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class FileUploadRequest
    Inherits RequestMessageBase
    Public Sub New()
        BufferSize = 1024
    End Sub

    Public Sub New(ByVal response As FileUploadResponse)
        Me.New()
        CallbackID = response.CallbackID
        FileName = response.FileName
        TotalBytes = response.TotalBytes
        CurrentPosition = response.CurrentPosition
        SourceFilePath = response.SourceFilePath
        DestinationFilePath = response.DestinationFilePath
    End Sub

    Public Property FileName() As [String]
        Get
            Return m_FileName
        End Get
        Set(ByVal value As [String])
            m_FileName = Value
        End Set
    End Property
    Private m_FileName As [String]
    Public Property TotalBytes() As Long
        Get
            Return m_TotalBytes
        End Get
        Set(ByVal value As Long)
            m_TotalBytes = Value
        End Set
    End Property
    Private m_TotalBytes As Long
    Public Property CurrentPosition() As Integer
        Get
            Return m_CurrentPosition
        End Get
        Set(ByVal value As Integer)
            m_CurrentPosition = Value
        End Set
    End Property
    Private m_CurrentPosition As Integer
    Public Property SourceFilePath() As [String]
        Get
            Return m_SourceFilePath
        End Get
        Set(ByVal value As [String])
            m_SourceFilePath = Value
        End Set
    End Property
    Private m_SourceFilePath As [String]
    Public Property DestinationFilePath() As [String]
        Get
            Return m_DestinationFilePath
        End Get
        Set(ByVal value As [String])
            m_DestinationFilePath = Value
        End Set
    End Property
    Private m_DestinationFilePath As [String]
    Public Property BytesToWrite() As [Byte]()
        Get
            Return m_BytesToWrite
        End Get
        Set(ByVal value As [Byte]())
            m_BytesToWrite = Value
        End Set
    End Property
    Private m_BytesToWrite As [Byte]()
    Public Property BufferSize() As Integer
        Get
            Return m_BufferSize
        End Get
        Set(ByVal value As Integer)
            m_BufferSize = Value
        End Set
    End Property
    Private m_BufferSize As Integer
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
