
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class FileUploadProgressEventArguments
    Public Property DestinationPath() As [String]
        Get
            Return m_DestinationPath
        End Get
        Set(ByVal value As [String])
            m_DestinationPath = value
        End Set
    End Property
    Private m_DestinationPath As [String]
    Public Property FileName() As [String]
        Get
            Return m_FileName
        End Get
        Set(ByVal value As [String])
            m_FileName = value
        End Set
    End Property
    Private m_FileName As [String]
    Public Property CurrentPosition() As Integer
        Get
            Return m_CurrentPosition
        End Get
        Set(ByVal value As Integer)
            m_CurrentPosition = value
        End Set
    End Property
    Private m_CurrentPosition As Integer
    Public Property TotalBytes() As Long
        Get
            Return m_TotalBytes
        End Get
        Set(ByVal value As Long)
            m_TotalBytes = value
        End Set
    End Property
    Private m_TotalBytes As Long
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
