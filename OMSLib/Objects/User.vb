Public Class User
    Dim img As Drawing.Image
    Sub New(ByVal ID As Integer)
        Me.ID = ID
    End Sub
    Sub New(ByVal ID As String, ByVal Username As String, ByVal Password As String, ByVal Desktop As String, ByVal Home As String, Optional ByVal UserType As String = "", Optional ByVal Address As String = "", Optional ByVal Mobile As String = "", Optional ByVal Email As String = "", Optional ByVal Permissions As String() = Nothing, Optional ByVal Status As String = "", Optional ByVal Photo As Image = Nothing, Optional ByVal Credentials As System.ComponentModel.BindingList(Of Credential) = Nothing)
        Me.ID = ID
        Me.Username = Username
        Me.Password = Password
        Me.UserType = UserType
        Me.Address = Address
        Me.Mobile = Mobile
        Me.Email = Email
        Me.Desktop = Desktop
        Me.Home = Home
        Me.Permissions = New Specialized.StringCollection
        If Permissions IsNot Nothing Then
            Me.Permissions.AddRange(Permissions)
        End If
        Me.Status = Status
        Me.img = Photo
        If Credentials Is Nothing Then
            Me.Credentials = New System.ComponentModel.BindingList(Of Credential)
        Else
            Me.Credentials = Credentials
        End If
    End Sub
    Property ID As Integer = -1
    Property Username As String = ""
    Property UserType As String = ""
    Property Password As String = ""
    Property Address As String = ""
    Property Mobile As String = ""
    Property Email As String = ""
    Property Permissions As New Specialized.StringCollection
    Property Status As String = ""
    Property Desktop As String = ""
    Property Home As String = ""
    Property Photo As Drawing.Image
        Get
            If img Is Nothing Then
                Return My.Resources.User_Default
            Else
                Return img
            End If
        End Get
        Set(ByVal value As Drawing.Image)
            img = value
        End Set
    End Property
    Property Credentials As System.ComponentModel.BindingList(Of Credential)
    Public Overrides Function ToString() As String
        Return Username.ToString()
    End Function
End Class
