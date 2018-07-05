
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


<Serializable()> _
Public Class EndSessionResponse
    Inherits ResponseMessageBase
    Public Sub New(ByVal request As EndSessionRequest)

        MyBase.New(request)
    End Sub
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
