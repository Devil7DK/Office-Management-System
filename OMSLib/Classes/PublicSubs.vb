Imports System.Drawing

Public Module PublicSubs
    Dim Settings_ As Settings
    Public Function GetSettings() As Settings
        If Settings_ Is Nothing Then
            Settings_ = Settings.Load
        End If
        Return Settings_
    End Function
    Public Function ImageFromBytes(ByVal Data As Byte()) As Image
        Dim ms As New IO.MemoryStream(Data)
        Return Image.FromStream(ms)
    End Function

    Public Sub AddParameter(ByVal cmd As SqlClient.SqlCommand, ByVal name As String, ByVal value As Object)
        Dim p As New SqlClient.SqlParameter(name, value)
        cmd.Parameters.Add(p)
    End Sub

    Function FixFileName(ByVal Path As String) As String
        Dim r As String = Path
        For Each c As Char In IO.Path.GetInvalidFileNameChars
            r = r.Replace(c, "_")
        Next
        r = r.Replace(" ", "_")
        Do Until r.Contains("__") = False
            r = r.Replace("__", "_")
        Loop
        r = r.Trim("_")
        Return r
    End Function

    Function GetFolder(ByVal DefaultStorage As String, ByVal Client As Client, ByVal Job As Job, ByVal AssessmentDetail As String, ByVal Year As String)
        Dim r As String = ""
        Dim Folder As String = DefaultStorage
        Select Case Job.Type
            Case JobType.Once
                Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), Now.ToString("yyyyMMddhhmm"))
            Case JobType.Monthly
                Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), FixFileName(AssessmentDetail))
            Case JobType.Yearly
                Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(AssessmentDetail))
            Case JobType.Quarterly
                Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), FixFileName(AssessmentDetail))
            Case JobType.HalfYerly
                Folder = IO.Path.Combine(DefaultStorage, FixFileName(Client.Name), FixFileName(Job.Group), FixFileName(Job.SubGroup), FixFileName(Year), FixFileName(AssessmentDetail))
        End Select
        Return FixFileName(r)
    End Function

End Module
