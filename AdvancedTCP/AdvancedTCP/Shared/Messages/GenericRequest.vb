
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class GenericRequest
    Inherits RequestMessageBase
    Friend Property InnerMessage() As MemoryStream
        Get
            Return m_InnerMessage
        End Get
        Set(ByVal value As MemoryStream)
            m_InnerMessage = Value
        End Set
    End Property
    Private m_InnerMessage As MemoryStream

    Public Sub New()
        InnerMessage = New MemoryStream()
    End Sub

    Public Sub New(ByVal request As RequestMessageBase)
        Me.New()
        Dim f As New BinaryFormatter()
        f.Serialize(InnerMessage, request)
        InnerMessage.Position = 0
    End Sub

    Public Function ExtractInnerMessage() As GenericRequest
        Dim f As New BinaryFormatter()
        f.Binder = New AllowAllAssemblyVersionsDeserializationBinder()
        Return TryCast(f.Deserialize(InnerMessage), GenericRequest)
    End Function
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
