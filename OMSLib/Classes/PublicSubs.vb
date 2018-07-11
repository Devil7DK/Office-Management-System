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

    Sub ShowError(ByVal Message As String, ByVal Exception As Exception)
        MsgBox(Message & vbNewLine & vbNewLine & vbNewLine & _
                "Additional Information:" & vbNewLine & vbNewLine & _
                Exception.Message & vbNewLine & vbNewLine & Exception.StackTrace, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
    End Sub

    Dim random_ As New Random
    Function GetOppositeColor(ByVal Color2Get As Color) As Color
        Return GetOppositeColor(Color2Get.R, Color2Get.G, Color2Get.B)
    End Function

    Function GetOppositeColor(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As Color
        If (r + g + b) > 480 Then
            Return Color.Black
        Else
            Return Color.White
        End If
    End Function

    Private Sub ItemClickSub(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        Try
            Process.Start(e.Item.Tag)
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadUtilities(ByVal TileContainer As DevExpress.XtraEditors.TileControl)
        On Error Resume Next
        Dim defaultgroup As New DevExpress.XtraEditors.TileGroup() With {.Text = "Default"}
        For Each i As String In My.Computer.FileSystem.GetFiles(Windows.Forms.Application.StartupPath & "\Utilities", FileIO.SearchOption.SearchTopLevelOnly, "*.exe")
            If IO.Path.GetFileName(i).EndsWith("vshot.exe") = False Then
                Dim it As New DevExpress.XtraEditors.TileItem() With {.Image = Icon.ExtractAssociatedIcon(i).ToBitmap, .Text = IO.Path.GetFileNameWithoutExtension(i), .Tag = i}
                it.AppearanceItem.Normal.BackColor = Color.FromArgb(random_.Next(0, 257), random_.Next(0, 257), random_.Next(0, 257))
                it.AppearanceItem.Normal.ForeColor = (GetOppositeColor(it.AppearanceItem.Normal.BackColor))
                it.ItemSize = random_.Next(2, 4)
                AddHandler it.ItemClick, AddressOf ItemClickSub
                defaultgroup.Items.Add(it)
            End If
        Next
        TileContainer.Groups.Add(defaultgroup)
        For Each f As String In My.Computer.FileSystem.GetDirectories(Windows.Forms.Application.StartupPath & "\Utilities", FileIO.SearchOption.SearchAllSubDirectories, "*")
            Dim g As New DevExpress.XtraEditors.TileGroup
            g.Text = IO.Path.GetDirectoryName(f)
            For Each i As String In My.Computer.FileSystem.GetFiles(f, FileIO.SearchOption.SearchTopLevelOnly, "*.exe")
                If IO.Path.GetFileName(i).EndsWith("vshot.exe") = False Then
                    Dim it As New DevExpress.XtraEditors.TileItem() With {.Image = Icon.ExtractAssociatedIcon(i).ToBitmap, .Text = IO.Path.GetFileNameWithoutExtension(i), .Tag = i}
                    it.AppearanceItem.Normal.BackColor = Color.FromArgb(random_.Next(0, 257), random_.Next(0, 257), random_.Next(0, 257))
                    it.AppearanceItem.Normal.ForeColor = (GetOppositeColor(it.AppearanceItem.Normal.BackColor))
                    it.ItemSize = random_.Next(2, 4)
                    AddHandler it.ItemClick, AddressOf ItemClickSub
                    g.Items.Add(it)
                End If
            Next
            TileContainer.Groups.Add(g)
        Next
    End Sub

End Module
