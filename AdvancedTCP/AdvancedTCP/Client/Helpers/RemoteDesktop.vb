
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class RemoteDesktop
    Public Shared Function CaptureScreenToMemoryStream(ByVal quality As Integer) As MemoryStream
        Dim bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), bmp.Size)
        g.Dispose()


        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        Dim ici As ImageCodecInfo = Nothing

        For Each codec As ImageCodecInfo In codecs
            If codec.MimeType = "image/jpeg" Then
                ici = codec
            End If
        Next

        Dim ep = New EncoderParameters()
        ep.Param(0) = New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, CLng(quality))

        Dim ms As New MemoryStream()
        bmp.Save(ms, ici, ep)
        ms.Position = 0
        bmp.Dispose()

        Return ms
    End Function
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
