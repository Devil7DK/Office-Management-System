
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class FileHelper
    Public Shared Function SampleBytesFromFile(ByVal filePath As [String], ByVal currentPosition As Integer, ByVal bufferSize As Integer) As Byte()
        Dim length As Integer = bufferSize
        Dim fs As New FileStream(filePath, FileMode.Open)
        fs.Position = currentPosition

        If currentPosition + length > fs.Length Then
            length = CInt(fs.Length - currentPosition)
        End If

        Dim b As Byte() = New Byte(length - 1) {}
        fs.Read(b, 0, length)
        fs.Dispose()
        Return b
    End Function

    Public Shared Function GetFileLength(ByVal filePath As [String]) As Long
        Dim info As New FileInfo(filePath)
        Return info.Length
    End Function

    Public Shared Sub AppendAllBytes(ByVal filePath As [String], ByVal bytes As Byte())
        Dim fs As New FileStream(filePath, FileMode.Append, FileAccess.Write)
        fs.Write(bytes, 0, bytes.Length)
        fs.Dispose()
    End Sub
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
