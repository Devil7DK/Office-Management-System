
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class RemoteDesktopRequest
    Inherits RequestMessageBase
    Public Property Quality() As Integer
        Get
            Return m_Quality
        End Get
        Set(ByVal value As Integer)
            m_Quality = Value
        End Set
    End Property
    Private m_Quality As Integer

    Public Sub New()
        Quality = 50
    End Sub
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
