
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class RemoteDesktopResponse
    Inherits ResponseMessageBase
    Public Sub New(ByVal request As RequestMessageBase)
        MyBase.New(request)
        DeleteCallbackAfterInvoke = False
    End Sub

    Public Property FrameBytes() As MemoryStream
        Get
            Return m_FrameBytes
        End Get
        Set(ByVal value As MemoryStream)
            m_FrameBytes = Value
        End Set
    End Property
    Private m_FrameBytes As MemoryStream
    Public Property Cancel() As Boolean
        Get
            Return m_Cancel
        End Get
        Set(ByVal value As Boolean)
            m_Cancel = Value
        End Set
    End Property
    Private m_Cancel As Boolean
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
