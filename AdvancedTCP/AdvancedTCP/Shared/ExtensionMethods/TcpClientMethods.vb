
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading.Tasks


Public Module TcpClientMethods
    <System.Runtime.CompilerServices.Extension()> _
    Public Function GetIP(ByVal client As TcpClient) As [String]
        Return DirectCast(client.Client.RemoteEndPoint, IPEndPoint).Address.ToString()
    End Function
End Module




'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
