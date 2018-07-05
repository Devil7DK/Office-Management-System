
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class ResponseMessageBase
    Inherits MessageBase
    Public Property DeleteCallbackAfterInvoke() As Boolean
        Get
            Return m_DeleteCallbackAfterInvoke
        End Get
        Set(ByVal value As Boolean)
            m_DeleteCallbackAfterInvoke = Value
        End Set
    End Property
    Private m_DeleteCallbackAfterInvoke As Boolean

    Public Sub New(ByVal request As RequestMessageBase)
        DeleteCallbackAfterInvoke = True
        CallbackID = request.CallbackID
    End Sub
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
