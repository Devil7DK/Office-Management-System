Imports System.Threading.Tasks
Imports DevExpress.XtraSplashScreen
Imports Devil7.Automation.OMS.Lib
Imports ExcelDataReader

Public Class frm_ImportClients

#Region "Variables"
    Dim Users As List(Of Objects.User)
#End Region

#Region "Constructor"
    Sub New(ByVal Users As List(Of Objects.User))
        InitializeComponent()
        Me.Users = Users
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

                                                       R.Add(New Objects.Client(-1, Name, PAN, FatherName, Mobile, "", EMail, DOB, AddressLine1, AddressLine2, District, PINCode, State, StateCode, AadharNo, "", "N/A", New List(Of Objects.Partner), "Individual", New List(Of Objects.JobUser), RPerson, "Active", Res.My.Resources.Client_Default, GSTIN, FileNo))
                                                   End If
                                               End If
                                           End If
                                       End While
                                   End Using
                               End Using
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
#End Region

#Region "Button Events"
    Private Async Sub btn_ImportExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_ImportExcel.ItemClick
        If dlg_OpenExcel.ShowDialog = DialogResult.OK Then
            Await LoadClients(dlg_OpenExcel.FileName)
        End If
    End Sub
#End Region

End Class