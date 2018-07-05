Imports GlobalCode

Module ObjectConverter
    Function ObjectToByteArray(ByVal obj As CommunicatingObject) As Byte()
        If obj Is Nothing Then
            Return Nothing
        End If
        Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim ms As New IO.MemoryStream()
        bf.Serialize(ms, obj)
        Return ms.ToArray()
    End Function
    Function ByteArrayToObject(ByVal arrBytes As Byte()) As CommunicatingObject
        Dim memStream As New IO.MemoryStream()
        Dim binForm As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        memStream.Write(arrBytes, 0, arrBytes.Length)
        memStream.Seek(0, IO.SeekOrigin.Begin)
        Dim obj As CommunicatingObject = DirectCast(binForm.Deserialize(memStream), CommunicatingObject)
        Return obj
    End Function
End Module
