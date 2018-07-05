Public Class Partner
    Sub New(ByVal Name As String, ByVal Address As String, ByVal PAN As String, ByVal DOB As String)
        Me.Name = Name
        Me.Address = Address
        Me.PAN = PAN
        Me.DOB = DOB
    End Sub
    Dim dob_ As Date
    Property Name As String
    Property Address As String
    Property PAN As String
    Property DOB As String
        Get
            Return dob_.ToString("dd/MM/yyyy")
        End Get
        Set(value As String)
            Try
                dob_ = Date.Parse(value)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End Try
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Name.ToString()
    End Function
End Class
