
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class ValidationRequest
    Inherits RequestMessageBase
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
