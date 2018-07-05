
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class TextMessageRequest
    Inherits RequestMessageBase
    Public Property Message() As [String]
        Get
            Return m_Message
        End Get
        Set(ByVal value As [String])
            m_Message = Value
        End Set
    End Property
    Private m_Message As [String]
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
