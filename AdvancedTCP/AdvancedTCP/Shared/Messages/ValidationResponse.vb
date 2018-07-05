
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class ValidationResponse
    Inherits ResponseMessageBase
    Public Sub New(ByVal request As RequestMessageBase)

        MyBase.New(request)
    End Sub

    Public Property IsValid() As Boolean
        Get
            Return m_IsValid
        End Get
        Set(ByVal value As Boolean)
            m_IsValid = Value
        End Set
    End Property
    Private m_IsValid As Boolean
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
