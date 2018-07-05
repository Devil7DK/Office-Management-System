Public Class CompareByID
    Implements IComparer(Of Object)
    Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.Generic.IComparer(Of Object).Compare
        Return x.ID.CompareTo(y.ID)
    End Function
End Class
