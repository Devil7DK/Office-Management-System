Public Class JobComparer
    Implements IComparer(Of Job)
    Function Compare(ByVal x As GlobalCode.Job, ByVal y As GlobalCode.Job) As Integer Implements System.Collections.Generic.IComparer(Of Job).Compare
        Return x.JID.CompareTo(y.JID)
    End Function
End Class
