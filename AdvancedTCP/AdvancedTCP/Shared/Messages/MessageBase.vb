
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class MessageBase
    Public Property CallbackID() As Guid
        Get
            Return m_CallbackID
        End Get
        Set(ByVal value As Guid)
            m_CallbackID = Value
        End Set
    End Property
    Private m_CallbackID As Guid
    Public Property HasError() As Boolean
        Get
            Return m_HasError
        End Get
        Set(ByVal value As Boolean)
            m_HasError = Value
        End Set
    End Property
    Private m_HasError As Boolean
    Public Property Exception() As Exception
        Get
            Return m_Exception
        End Get
        Set(ByVal value As Exception)
            m_Exception = Value
        End Set
    End Property
    Private m_Exception As Exception

    Public Sub New()
        Exception = New Exception()
    End Sub
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
