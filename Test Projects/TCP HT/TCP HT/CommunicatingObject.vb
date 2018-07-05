<Serializable()> _
Public Class CommunicatingObject
    Inherits EventArgs
    Property Filename As String
    Property Data As Byte()
    Sub New(Filename As String, Data As Byte())
        Me.Filename = Filename
        Me.Data = Data
    End Sub
End Class
