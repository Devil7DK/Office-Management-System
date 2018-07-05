Imports System.Net
Imports System.Net.NetworkInformation

Public Module PublicSubs
    Public Function BytesToString(ByVal data() As Byte) As String
        'Dim enc As New System.Text.UTF8Encoding()
        'BytesToString = enc.GetString(data)
        Return System.Text.UTF8Encoding.UTF8.GetString(data)
    End Function

    Public Function StrToByteArray(ByVal text As String) As Byte()
        'Dim encoding As New System.Text.UTF8Encoding()
        'StrToByteArray = encoding.GetBytes(text)
        Return System.Text.UTF8Encoding.UTF8.GetBytes(text)
    End Function
    Public Sub CenterControl(ByVal ControlToCenter As Control, ByVal Type As CenterType)
        Try
            Dim x As Single = ControlToCenter.Location.X
            Dim y As Single = ControlToCenter.Location.Y
            If Type = CenterType.Vertical Then
                x = ControlToCenter.Location.X
                y = (ControlToCenter.Parent.Height - ControlToCenter.Height) / 2
            ElseIf Type = CenterType.Horizondal Then
                x = (ControlToCenter.Parent.Width - ControlToCenter.Width) / 2
                y = ControlToCenter.Location.Y
            Else
                x = (ControlToCenter.Parent.Width - ControlToCenter.Width) / 2
                y = (ControlToCenter.Parent.Height - ControlToCenter.Height) / 2
            End If
            ControlToCenter.Location = New Point(x, y)
        Catch ex As Exception

        End Try
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
    Function StringToEnum(Of T)(ByVal String_ As String) As T
        Return DirectCast([Enum].Parse(GetType(T), String_), T)
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
    Public Sub AddParameter(ByVal cmd As SqlClient.SqlCommand, ByVal name As String, ByVal value As Object)
        Dim p As New SqlClient.SqlParameter(name, value)
        cmd.Parameters.Add(p)
    End Sub
    Public Function ListviewToCredentials(ByVal Items As ListView.ListViewItemCollection) As List(Of Credential)
        Dim r As New List(Of Credential)
        For Each i As ListViewItem In Items
            r.Add(New Credential(i.Text, i.SubItems(1).Text, i.SubItems(2).Text, i.SubItems(3).Text, i.SubItems(4).Text, i.SubItems(5).Text))
        Next
        Return r
    End Function
    Public Function ListviewToPartners(ByVal Items As ListView.ListViewItemCollection) As List(Of Partner)
        Dim r As New List(Of Partner)
        For Each i As ListViewItem In Items
            r.Add(New Partner(i.Text, i.SubItems(1).Text, i.SubItems(2).Text, i.SubItems(3).Text))
        Next
        Return r
    End Function
    Public Function ListviewToJID(ByVal Items As ListView.ListViewItemCollection) As List(Of String)
        Dim r As New List(Of String)
        For Each i As ListViewItem In Items
            r.Add(i.SubItems(1).Text)
        Next
        Return r
    End Function
    Public Sub CredentialsToListview(ByVal values As List(Of Credential), ByRef Items As ListView.ListViewItemCollection)
        For Each i As Credential In values
            Dim li As ListViewItem = Items.Add(i.Name)
            li.SubItems.Add(i.Template)
            li.SubItems.Add(i.Username)
            li.SubItems.Add(i.Password)
            li.SubItems.Add(i.Password2)
            li.SubItems.Add(i.Password3)
        Next
    End Sub
    Public Sub PartnersToListview(ByVal values As List(Of Partner), ByRef Items As ListView.ListViewItemCollection)
        For Each i As Partner In values
            Dim li As ListViewItem = Items.Add(i.Name)
            li.SubItems.Add(i.Address)
            li.SubItems.Add(i.PAN)
            li.SubItems.Add(i.DOB)
        Next
    End Sub
    Public Sub JIDToListview(ByVal Values As List(Of String), ByRef Items As ListView.ListViewItemCollection, ByVal Jobs As System.ComponentModel.BindingList(Of Job))
        Dim jc As New JobComparer
        For Each i As String In Values
            Dim j As Job = Jobs.SingleOrDefault(Function(x) x.JID = i)
            Items.Add(j.Name).SubItems.Add(j.JID)
        Next
    End Sub

    Public Sub TimedFilter(ByVal olv As BrightIdeasSoftware.ObjectListView, ByVal txt As String, ByVal matchKind As Integer)
        Dim filter As BrightIdeasSoftware.TextMatchFilter = Nothing
        If Not [String].IsNullOrEmpty(txt) Then
            Select Case matchKind
                Case 0
                    filter = BrightIdeasSoftware.TextMatchFilter.Contains(olv, txt)
                    Exit Select
                Case 1
                    filter = BrightIdeasSoftware.TextMatchFilter.Prefix(olv, txt)
                    Exit Select
                Case 2
                    filter = BrightIdeasSoftware.TextMatchFilter.Regex(olv, txt)
                    Exit Select
            End Select
        End If
        ' Text highlighting requires at least a default renderer
        If olv.DefaultRenderer Is Nothing Then
            olv.DefaultRenderer = New BrightIdeasSoftware.HighlightTextRenderer(filter)
        End If
        olv.AdditionalFilter = filter
    End Sub
    Public Function ImageFromBytes(ByVal Data As Byte()) As Image
        Dim ms As New IO.MemoryStream(Data)
        Return Image.FromStream(ms)
    End Function
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
    Dim random_ As New Random
    Sub LoadUtilities(ByVal TileContainer As DevExpress.XtraEditors.TileControl)
        On Error Resume Next
        Dim defaultgroup As New DevExpress.XtraEditors.TileGroup() With {.Text = "Default"}
        For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Utilities", FileIO.SearchOption.SearchTopLevelOnly, "*.exe")
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
        For Each f As String In My.Computer.FileSystem.GetDirectories(Application.StartupPath & "\Utilities", FileIO.SearchOption.SearchAllSubDirectories, "*")
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
    Private Sub ItemClickSub(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        Try
            Process.Start(e.Item.Tag)
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetIPAddresses() As IEnumerable(Of IPAddress)
        Dim ipAddresses As New List(Of IPAddress)()

        Dim enabledNetInterfaces As IEnumerable(Of NetworkInterface) = NetworkInterface.GetAllNetworkInterfaces().Where(Function(nic) nic.OperationalStatus = OperationalStatus.Up)
        For Each netInterface As NetworkInterface In enabledNetInterfaces
            Dim ipProps As IPInterfaceProperties = netInterface.GetIPProperties()
            For Each addr As UnicastIPAddressInformation In ipProps.UnicastAddresses
                If Not ipAddresses.Contains(addr.Address) Then
                    ipAddresses.Add(addr.Address)
                End If
            Next
        Next

        Return ipAddresses
    End Function
End Module
