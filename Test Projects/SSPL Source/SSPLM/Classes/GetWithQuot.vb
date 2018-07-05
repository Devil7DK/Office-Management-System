Public Class GetWithQuot
    Public Shared Function WithQuot(ByVal Text As String) As String
        Return (My.Settings.Quot & Text.Replace(My.Settings.Quot, "''") & My.Settings.Quot)
    End Function
End Class
