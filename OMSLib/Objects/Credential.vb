Public Class Credential
    Sub New(ByVal Name As String, ByVal Template As String, ByVal Username As String, ByVal Password As String, ByVal Password2 As String, ByVal Password3 As String)
        Me.Name = Name
        Me.Template = Template
        Me.Username = Username
        Me.Password = Password
        Me.Password2 = Password2
        Me.Password3 = Password3
    End Sub
    Property Template As String
    Property Name As String
    Property Username As String
    Property Password As String
    Property Password2 As String
    Property Password3 As String
    Public Overrides Function ToString() As String
        Return Name.ToString()
    End Function
End Class
Public Class CredentialWithClient
    Sub New(ByVal Client As Client, ByVal Name As String, ByVal Template As String, ByVal Username As String, ByVal Password As String, ByVal Password2 As String, ByVal Password3 As String)
        Me.Name = Name
        Me.Template = Template
        Me.Username = Username
        Me.Password = Password
        Me.Password2 = Password2
        Me.Password3 = Password3
        Me.Client = Client
    End Sub
    Property Client As Client
    Property Template As String
    Property Name As String
    Property Username As String
    Property Password As String
    Property Password2 As String
    Property Password3 As String
    Public Overrides Function ToString() As String
        Return Name.ToString()
    End Function
End Class