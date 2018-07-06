Public Class Client
    Sub New(ByVal ID As Integer)
        Me.ID_ = ID
    End Sub
    Sub New(ByVal ID As Integer, ByVal Name As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal District As String, ByVal PinCode As String, ByVal AadharNo As String, ByVal Description As String, ByVal TypeOfEngagement As String, ByVal TIN As String, ByVal CIN As String, ByVal Partners As System.ComponentModel.BindingList(Of Partner), ByVal Type As String, ByVal Credentials As System.ComponentModel.BindingList(Of Credential), ByVal Jobs As System.ComponentModel.BindingList(Of Job), ByVal Status As String, ByVal Photo As Image)
        Me.ID_ = ID
        Me.Name = Name
        Me.AadharNo = AadharNo
        Me.AddressLine1 = AddressLine1
        Me.AddressLine2 = AddressLine2
        Me.CIN = CIN
        Me.Credentials = Credentials
        Me.Description = Description
        Me.District = District
        Me.DOB = Date.Parse(DOB)
        Me.Email = Email
        Me.FatherName = FatherName
        Me.Jobs = Jobs
        Me.Mobile = Mobile
        Me.PAN = PAN
        Me.Partners = Partners
        Me.Photo = Photo
        Me.PinCode = PinCode
        Me.Status = Status
        Me.TIN = TIN
        Me.Type = Type
        Me.TypeOfEngagement = TypeOfEngagement
    End Sub
    Dim ID_ As Integer = -1
    ReadOnly Property ID As Integer
        Get
            Return ID_
        End Get
    End Property
    Property PAN As String = ""
    Property Name As String = ""
    Property FatherName As String = ""
    Property Mobile As String = ""
    Property Email As String = ""
    Property DOB As Date
    Property AddressLine1 As String = ""
    Property AddressLine2 As String = ""
    Property District As String = ""
    Property PinCode As String = ""
    Property AadharNo As String = ""
    Property Description As String = ""
    Property TypeOfEngagement As String = ""
    Property TIN As String = ""
    Property CIN As String = ""
    Property Partners As System.ComponentModel.BindingList(Of Partner)
    Property Type As String = ""
    Property Credentials As System.ComponentModel.BindingList(Of Credential)
    Property Jobs As System.ComponentModel.BindingList(Of Job)
    Property Status As String = ""
    Property Photo As Drawing.Image = Nothing
    Public Overrides Function ToString() As String
        Return Name.ToString()
    End Function
End Class
