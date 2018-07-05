
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class SessionResponse
    Inherits ResponseMessageBase
    Public Sub New(ByVal request As RequestMessageBase)

        MyBase.New(request)
    End Sub

    Public Property IsConfirmed() As Boolean
        Get
            Return m_IsConfirmed
        End Get
        Set(ByVal value As Boolean)
            m_IsConfirmed = Value
        End Set
    End Property
    Private m_IsConfirmed As Boolean
    Public Property Email() As [String]
        Get
            Return m_Email
        End Get
        Set(ByVal value As [String])
            m_Email = Value
        End Set
    End Property
    Private m_Email As [String]
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
