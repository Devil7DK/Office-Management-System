Imports System.Threading.Tasks
Imports DevExpress.XtraSplashScreen
Imports Devil7.Automation.OMS.Lib
Imports ExcelDataReader

Public Class frm_ImportClients

#Region "Variables"
    Dim Users As List(Of Objects.User)
    Dim ExistingClients As List(Of Objects.Client)
#End Region

#Region "Constructor"
    Sub New(ByVal Users As List(Of Objects.User), ByVal Clients As List(Of Objects.Client))
        InitializeComponent()
        Me.Users = Users
        Me.ExistingClients = Clients
    End Sub
#End Region

#Region "Excel Reader Functions"
    Function GetString(ByVal Reader As IExcelDataReader, ByVal Index As Integer) As String
        If Not Reader.IsDBNull(Index) Then
            Try
                Return Reader.GetValue(Index).ToString.Trim
            Catch ex As Exception

            End Try
        End If
        Return ""
    End Function

    Function GetDouble(ByVal Reader As IExcelDataReader, ByVal Index As Integer) As Double
        Dim R As Double = 0
        If Not Reader.IsDBNull(Index) Then
            Dim Val As String = GetString(Reader, Index)
            If Val <> "" Then Double.TryParse(Val, R)
        End If
        Return R
    End Function

    Function GetDate(ByVal Reader As IExcelDataReader, ByVal Index As Integer) As Date
        Dim R As Date = Nothing
        If Not Reader.IsDBNull(Index) Then
            Dim Val As String = GetString(Reader, Index)
            If Val <> "" Then Date.TryParse(Val, R)
        End If
        Return R
    End Function
#End Region

#Region "Progress Panel"
    Dim PanelHandle As IOverlaySplashScreenHandle

    Private Sub ShowProgressPanel()
        PanelHandle = SplashScreenManager.ShowOverlayForm(Me)
    End Sub

    Private Sub CloseProgressPanel()
        If PanelHandle IsNot Nothing Then SplashScreenManager.CloseOverlayForm(PanelHandle)
    End Sub
#End Region

#Region "Functions"
    Async Function LoadClients(ByVal FileName As String) As Task
        Invoke(Sub()
                   btn_ImportExcel.Enabled = False
                   ShowProgressPanel()
               End Sub)
        Await Task.Run(Function()
                           Try
                               Dim R As New List(Of Objects.Client)
                               Using stream As IO.FileStream = IO.File.Open(FileName, IO.FileMode.Open, IO.FileAccess.Read)
                                   Using reader = ExcelReaderFactory.CreateReader(stream)
                                       Dim Index As Integer = -1
                                       While reader.Read()
                                           If reader.CodeName = "Clients" AndAlso Not reader.IsDBNull(0) Then
                                               Index += 1
                                               If Index > 0 Then
                                                   Dim PAN As String = GetString(reader, 0).Replace(" ", "")
                                                   If PAN <> "" Then
                                                       Dim Name As String = GetString(reader, 1)
                                                       Dim FileNo As String = GetString(reader, 2)
                                                       Dim FatherName As String = GetString(reader, 3)
                                                       Dim Mobile As String = GetString(reader, 4)
                                                       Dim EMail As String = GetString(reader, 5)
                                                       Dim DOB As Date = GetDate(reader, 6)
                                                       Dim AddressLine1 As String = GetString(reader, 7)
                                                       Dim AddressLine2 As String = GetString(reader, 8)
                                                       Dim District As String = GetString(reader, 9)
                                                       Dim PINCode As String = GetString(reader, 10)
                                                       Dim State As String = GetString(reader, 11)
                                                       Dim StateCode As Integer = GetDouble(reader, 12)
                                                       Dim AadharNo As String = GetString(reader, 13)
                                                       Dim RPersonName As String = GetString(reader, 14)
                                                       Dim GSTIN As String = GetString(reader, 15)

                                                       Dim RPerson As Objects.User = Users.Find(Function(c) c.Username.ToUpper = RPersonName.ToUpper)
                                                       If RPerson Is Nothing And Users.Count > 0 Then
                                                           RPerson = Users(0)
                                                       End If
                                                       If StateCode = 0 Then StateCode = 33

                                                       Dim ID As Integer = -1
                                                       Dim Phone As String = ""
                                                       Dim Description As String = ""
                                                       Dim TypeOfEngagement As String = "N/A"
                                                       Dim Partners As New List(Of Objects.Partner)
                                                       Dim Type As String = "Individual"
                                                       Dim Jobs As New List(Of Objects.JobUser)
                                                       Dim Status As String = "Active"
                                                       Dim Photo As Image = Res.My.Resources.Client_Default
                                                       Dim ExistingClient As Objects.Client = ExistingClients.Find(Function(c) c.PAN.ToUpper = PAN.ToUpper)
                                                       If ExistingClient IsNot Nothing Then
                                                           ID = ExistingClient.ID
                                                           Phone = ExistingClient.Phone
                                                           Description = ExistingClient.Description
                                                           TypeOfEngagement = ExistingClient.TypeOfEngagement
                                                           Partners = ExistingClient.Partners
                                                           Type = ExistingClient.Type
                                                           Jobs = ExistingClient.Jobs
                                                           Status = ExistingClient.Status
                                                           Photo = ExistingClient.Photo
                                                       End If
                                                       R.Add(New Objects.Client(ID, Name, PAN, FatherName, Mobile, Phone, EMail, DOB, AddressLine1, AddressLine2, District, PINCode, State, StateCode, AadharNo, Description, TypeOfEngagement, Partners, Type, Jobs, RPerson, Status, Photo, GSTIN, FileNo))
                                                   End If
                                               End If
                                           End If
                                       End While
                                   End Using
                               End Using
                               Me.Invoke(Sub()
                                             gc_Clients.DataSource = R
                                             gc_Clients.RefreshDataSource()
                                         End Sub)
                           Catch ex As Exception
                               MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
                               Return False
                           End Try
                           Return True
                       End Function)
        Invoke(Sub()
                   btn_ImportExcel.Enabled = True
                   CloseProgressPanel()
               End Sub)
    End Function

    Private Async Function ExportClients() As Task
        Invoke(Sub()
                   btn_ExportClients.Enabled = False
                   ShowProgressPanel()
               End Sub)
        Await Task.Run(Sub()
                           For Each Client As Objects.Client In gc_Clients.DataSource
                               If Client.ID = -1 Then
                                   Dim NewClient As Objects.Client = Database.Clients.AddNew(Client.Photo, Client.PAN, Client.Name, Client.FatherName, Client.Mobile, Client.Phone, Client.Email,
                                                       Client.DOB, Client.AddressLine1, Client.AddressLine2, Client.City, Client.PinCode, Client.State, Client.StateCode, Client.AadharNo, Client.Description,
                                                       Client.TypeOfEngagement, Client.Partners, Client.Type, Client.Jobs, Client.Status, Client.GST, Client.FileNo, Client.ResponsiblePerson)
                                   If NewClient IsNot Nothing Then
                                       Client = NewClient
                                   End If
                               Else
                                   If Not btn_SkipExisting.Checked Then
                                       Database.Clients.Update(Client.ID, Client.Photo, Client.PAN, Client.Name, Client.FatherName, Client.Mobile, Client.Phone, Client.Email,
                                                           Client.DOB, Client.AddressLine1, Client.AddressLine2, Client.City, Client.PinCode, Client.State, Client.StateCode, Client.AadharNo, Client.Description,
                                                           Client.TypeOfEngagement, Client.Partners, Client.Type, Client.Jobs, Client.Status, Client.GST, Client.FileNo, Client.ResponsiblePerson)
                                   End If
                               End If
                           Next
                       End Sub)
        Invoke(Sub()
                   gc_Clients.RefreshDataSource()
                   btn_ExportClients.Enabled = True
                   CloseProgressPanel()
               End Sub)
    End Function
#End Region

#Region "Button Events"
    Private Async Sub btn_ImportExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ImportExcel.ItemClick
        If dlg_OpenExcel.ShowDialog = DialogResult.OK Then
            Await LoadClients(dlg_OpenExcel.FileName)
        End If
    End Sub

    Private Async Sub btn_ExportClients_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ExportClients.ItemClick
        If gc_Clients.DataSource IsNot Nothing AndAlso gc_Clients.DataSource.Count > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure to export all of these clients to the database...? This process cannot be reversed!", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Await ExportClients()
            End If
        End If
    End Sub
#End Region

End Class