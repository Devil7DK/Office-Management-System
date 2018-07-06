Imports System.Xml.Serialization

Public Class Settings
    Shared Property ConfigFile As String = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "ServerSettings.config")
    Property DatabaseName As String
    Property ServerName As String
    Property Password As String
    Property UserName As String
    Property Port As String
    Property Pooling As String
    Shared Function Load() As Settings
        Dim serializer As New XmlSerializer(GetType(Settings))
        Dim deserialized As New Settings
        Try
            Using file = System.IO.File.OpenRead(ConfigFile)
                deserialized = DirectCast(serializer.Deserialize(file), Settings)
            End Using
        Catch ex As Exception

        End Try
        Return deserialized
    End Function
    Sub Save()
        Dim serializer As New XmlSerializer(GetType(Settings))
        Dim ms As New IO.MemoryStream
        serializer.Serialize(ms, Me)
        My.Computer.FileSystem.WriteAllBytes(ConfigFile, ms.ToArray, False)
    End Sub
End Class
