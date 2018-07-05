Imports Google.Apis.Drive.v2
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports System.Threading
Imports Google.Apis.Drive.v2.Data
Imports Microsoft.Win32

Public Class ApMainForm
    Dim Drive As String = ""
    Dim CurrentFileCopying As String = ""
    Dim GoogleDriveList, GoogleFileList As New List(Of String)
    Dim TotalFiletoUpload As Integer = 0
    Sub CheckNet()
        Dim c As New CheckInternet
        Dim i As InternetStatus = c.IsWebConnected()
        If i.Connected = True Then
            lbl_Net.Text = i.ConnectionType & " - Connected"
            btn_StartDriveBackup.Enabled = True
        Else
            btn_StartDriveBackup.Enabled = False
            lbl_Net.Text = i.ConnectionType & " - Disconnected"
        End If
    End Sub
    Private Sub ApMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Try
            Dim regStartUp As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regStartUp.CreateSubKey("SSPLAutoBackup")
            regStartUp.SetValue("SSPL Auto Backup", Application.ExecutablePath.ToString(), RegistryValueKind.String)
        Catch ex As Exception

        End Try
        CheckNet()
        ChoosenFiles.Items.Clear()
        For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchAllSubDirectories, "*.mdb")
            ChoosenFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(i)).Tag = i
        Next
    End Sub

    Private Sub CheckDisks_Tick(sender As Object, e As EventArgs) Handles CheckDisks.Tick
        For Each i As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim f As String = i.Name & "SSPLBACKUP.THIS"
            If My.Computer.FileSystem.FileExists(f) = True Then
                Try
                    Drive = i.Name
                    Backuper.RunWorkerAsync()
                Catch ex As Exception

                End Try
                CheckDisks.Stop()
            End If
        Next
    End Sub
    Sub Notify(ByVal Title As String, ByVal Message As String, ByVal IconType As ToolTipIcon)
        Notifier.ShowBalloonTip(5000, Title, Message, IconType)
    End Sub
    Protected Function GetMD5(ByVal Filename As String) As String
        Try
            Dim f As New IO.FileStream(Filename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, &H2000)
            f = New IO.FileStream(Filename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, &H2000)
            Dim md51 As New Security.Cryptography.MD5CryptoServiceProvider
            md51.ComputeHash(f)
            Dim hash As Byte() = md51.Hash
            Dim buff As New System.Text.StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Dispose()
            Return buff.ToString.ToUpper
        Catch ex As Exception
            Return ("")
        End Try
    End Function
    Dim total As Long
    Dim current As Long
    Dim FileList As New List(Of String)
    Dim DiskList As New List(Of String)
    Sub WC_ProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
        On Error Resume Next
        Dim fi As New IO.FileInfo(CurrentFileCopying)
        lbl_Status.Text = "Copying File " & IO.Path.GetFileNameWithoutExtension(FileList(0)) & ". Progress : " & e.ProgressPercentage & "%"
        CurrrentProgress.Value = e.ProgressPercentage
        TotalProgress.Value = Math.Round((((current + ((e.ProgressPercentage / 100) * fi.Length)) / total) * 100))
    End Sub
    Sub WC_Complete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim fi As New IO.FileInfo(CurrentFileCopying)
        CurrentFileCopying = ""
        If e.Error Is Nothing Then
            FileList.RemoveAt(0)
            If FileList.Count > 0 Then
                StartCopy()
            Else
                Notify("Done", "Backup Complete. All Files are Up-to-Date.", ToolTipIcon.Info)
            End If
        Else
            MsgBox(e.Error.ToString)
        End If
        current += fi.Length
    End Sub
    Function GetFilename(ByVal Filename As String) As String
        Dim r As String = ""
        If Filename.EndsWith(".mdb") Then
            r = Drive & "SSPLBackup\Database\" & IO.Path.GetFileNameWithoutExtension(Filename) & "_" & Today.ToString("dd/MM/yyyy").Replace("/", "-") & ".mdb"
        ElseIf Filename.EndsWith(".xml") Then
            r = Drive & "SSPLBackup\Settings\" & IO.Path.GetFileNameWithoutExtension(Filename) & "_" & Today.ToString("dd/MM/yyyy").Replace("/", "-") & ".xml"
        ElseIf Filename.EndsWith(".png") Then
            r = Drive & "SSPLBackup\def\" & IO.Path.GetFileName(Filename)
        Else
            r = Drive & "SSPLBackup\" & IO.Path.GetFileName(Filename)
        End If
        Return r
    End Function
    Dim WC As Net.WebClient
    Sub StartCopy()
        WC = New Net.WebClient
        Try
            AddHandler WC.DownloadProgressChanged, AddressOf WC_ProgressChanged
            AddHandler WC.DownloadFileCompleted, AddressOf WC_Complete
            Dim Filename As String = GetFilename(FileList(0).ToString)
            If My.Computer.FileSystem.FileExists(Filename) = True Then
                Try
                    Kill(Filename)
                Catch ex As Exception

                End Try
            End If
            WC.DownloadFileAsync(New Uri(FileList(0).ToString), Filename)
            CurrentFileCopying = Filename
        Catch ex As Exception
            FileList.RemoveAt(0)
            If FileList.Count > 0 Then
                StartCopy()
            Else
                Notify("Done", "Backup Complete. All Files are Up-to-Date.", ToolTipIcon.Info)
            End If
        End Try
    End Sub
    Private Sub Backuper_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Backuper.DoWork
        On Error Resume Next
        Notify("Information", "A New Drive was found. The backup will run.", ToolTipIcon.Info)
        lbl_Status.Text = "Found Drive : " & Drive
        If My.Computer.FileSystem.DirectoryExists(Drive & "SSPLBackup") = False Then
            My.Computer.FileSystem.CreateDirectory(Drive & "SSPLBackup")
        End If
        If My.Computer.FileSystem.DirectoryExists(Drive & "SSPLBackup\Database") = False Then
            My.Computer.FileSystem.CreateDirectory(Drive & "SSPLBackup\Database")
        End If
        If My.Computer.FileSystem.DirectoryExists(Drive & "SSPLBackup\Settings") = False Then
            My.Computer.FileSystem.CreateDirectory(Drive & "SSPLBackup\Settings")
        End If
        If My.Computer.FileSystem.DirectoryExists(Drive & "SSPLBackup\def") = False Then
            My.Computer.FileSystem.CreateDirectory(Drive & "SSPLBackup\def")
        End If
        For Each i As String In My.Computer.FileSystem.GetFiles(Drive & "SSPLBackup\Database", FileIO.SearchOption.SearchTopLevelOnly, "*.mdb")
            lbl_Status.Text = "Reading Files In Disk :" & IO.Path.GetFileNameWithoutExtension(i)
            DiskList.Add(GetMD5(i))
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Drive & "SSPLBackup\Settings", FileIO.SearchOption.SearchTopLevelOnly, "*.xml")
            lbl_Status.Text = "Reading Files In Disk :" & IO.Path.GetFileNameWithoutExtension(i)
            DiskList.Add(GetMD5(i))
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Drive & "SSPLBackup\def", FileIO.SearchOption.SearchTopLevelOnly, "*.png")
            lbl_Status.Text = "Reading Files In Disk :" & IO.Path.GetFileNameWithoutExtension(i)
            DiskList.Add(GetMD5(i))
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Drive & "SSPLBackup", FileIO.SearchOption.SearchTopLevelOnly, "*")
            lbl_Status.Text = "Reading Files In Disk :" & IO.Path.GetFileNameWithoutExtension(i)
            DiskList.Add(GetMD5(i))
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchAllSubDirectories, "*")
            lbl_Status.Text = "Reading Files In Data :" & IO.Path.GetFileNameWithoutExtension(i)
            Dim filemd5 As String = GetMD5(i)
            If DiskList.Contains(filemd5) = False Then
                FileList.Add(i)
            End If
        Next
        For Each i As String In FileList
            Dim fi As New IO.FileInfo(i)
            total += fi.Length
        Next
        If Not FileList.Count = 0 Then
            StartCopy()
        End If
    End Sub

    Private Sub ApMainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        Else
            If CurrentFileCopying <> "" Or WC.IsBusy Then
                WC.CancelAsync()
                Try
                    Kill(CurrentFileCopying)
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub btn_Setup_Click(sender As Object, e As EventArgs) Handles btn_Setup.Click
        Dim a As New SetupBackup
        a.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If CurrentFileCopying <> "" Or WC.IsBusy Then
            If MsgBox("A backup was running. Do you wan't to close the appliation?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure") = MsgBoxResult.Yes Then
                WC.CancelAsync()
                Try
                    Kill(CurrentFileCopying)
                Catch ex As Exception

                End Try
            End If
        Else
            End
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.Focus()
    End Sub

    Private Sub StopBackupToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Stop_Click(sender As Object, e As EventArgs) Handles btn_Stop.Click
        If CurrentFileCopying <> "" Or WC.IsBusy Then
            WC.CancelAsync()
            Try
                Kill(CurrentFileCopying)
            Catch ex As Exception

            End Try
        End If
        lbl_Status.Text = "Process canceled by the user."
    End Sub

    Private Service As DriveService = New DriveService
    Private Sub CreateService()
        Dim ClientId = "954901835857-2os0cfagq5hf0fr76770stdd7nn9de1v.apps.googleusercontent.com"
        Dim ClientSecret = "eCyqZOB1ZAEOWWucU8d_qQkd"
        Dim MyUserCredential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = ClientId, .ClientSecret = ClientSecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
        Service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = MyUserCredential, .ApplicationName = "SSPL Auto Backup"})
    End Sub
    Dim FilesUploaded As Integer
    Private Sub BackgroundUploader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundUploader.DoWork
        On Error Resume Next
        Notify("Information", "Google Drive Update has been started.", ToolTipIcon.Info)
        Dim Request = Service.Files.List()
        Request.Q = "mimeType != 'application/vnd.google-apps.folder' and trashed = false"
        Request.MaxResults = 2
        lst_GoogleDrive.Items.Add("Files Requested From Google Drive.")
        Dim Results = Request.Execute
        For Each Result In Results.Items
            lst_GoogleDrive.Items.Add("Files : " & Result.Title.ToString & " MD5 : " & Result.Md5Checksum.ToString.ToUpper)
            GoogleDriveList.Add(Result.Md5Checksum.ToString.ToUpper)
        Next
        For Each li As ListViewItem In ChoosenFiles.CheckedItems
            Dim i As String = li.Tag.ToString
            lbl_DriveStatus.Text = "Reading Files In Data :" & IO.Path.GetFileNameWithoutExtension(i)
            Dim filemd5 As String = GetMD5(i)
            If GoogleDriveList.Contains(filemd5) = False Then
                GoogleFileList.Add(i)
            End If
        Next
        If Not GoogleFileList.Count = 0 Then
            TotalFiletoUpload = GoogleFileList.Count
            FilesUploaded = 0
            StartUpload()
        End If
    End Sub
    Private Sub UploadFile(FilePath As String)
        Try
            'Not needed from a Console app:
            'Me.Cursor = Cursors.WaitCursor
            lbl_DriveStatus.Text = "Uploading File : " & (New IO.FileInfo(FilePath).Name)
            lst_GoogleDrive.Items.Add("File Upload Started : " & (New IO.FileInfo(FilePath).Name))
            If Service.ApplicationName <> "SSPL Auto Bacukp" Then CreateService()

            Dim TheFile As New File()
            TheFile.Title = IO.Path.GetFileName(FilePath) & " " & Now.Day & "-" & Now.Month & "-" & Now.Year
            TheFile.Description = "File Backup " & Now
            TheFile.MimeType = "application/x-msaccess"

            Dim ByteArray As Byte() = System.IO.File.ReadAllBytes(FilePath)
            Dim Stream As New System.IO.MemoryStream(ByteArray)

            Dim UploadRequest As FilesResource.InsertMediaUpload = Service.Files.Insert(TheFile, Stream, TheFile.MimeType)

            '' You were mmissing the Upload part!
            UploadRequest.Upload()
            Dim file As File = UploadRequest.ResponseBody


            ' Not needed from a Console app:
            'Me.Cursor = Cursors.Default

            lst_GoogleDrive.Items.Add("File Upload Finished : " & (New IO.FileInfo(FilePath).Name))
        Catch ex As Exception
            lst_GoogleDrive.Items.Add("File Upload Failed : " & (New IO.FileInfo(FilePath).Name) & ":" & ex.Message)
        End Try
        GoogleFileList.RemoveAt(0)
        FilesUploaded += 1
        If GoogleFileList.Count > 0 Then
            StartUpload()
        End If
    End Sub

    Private Sub btn_StartDriveBackup_Click(sender As Object, e As EventArgs) Handles btn_StartDriveBackup.Click
        BackgroundUploader.RunWorkerAsync()
    End Sub

    Sub StartUpload()
        Try
            TotalUploadProgress.Value = (FilesUploaded / TotalFiletoUpload * 100)
        Catch ex As Exception

        End Try
        UploadFile(GoogleFileList(0))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BackgroundUploader.IsBusy = True Then
            btn_Reload.Enabled = False
            btn_StartDriveBackup.Enabled = False
            UploadingLabel.Visible = True
            MarqueeProgressbar.Visible = True
            TotalUploadProgress.Visible = True
            ChoosenFiles.Enabled = False
        Else
            btn_Reload.Enabled = True
            btn_StartDriveBackup.Enabled = True
            UploadingLabel.Visible = False
            MarqueeProgressbar.Visible = False
            TotalUploadProgress.Visible = False
            ChoosenFiles.Enabled = True
        End If
    End Sub

    Private Sub btn_Reload_Click(sender As Object, e As EventArgs) Handles btn_Reload.Click
        ChoosenFiles.Items.Clear()
        For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchAllSubDirectories, "*.mdb")
            ChoosenFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(i)).Tag = i
        Next
    End Sub

End Class
Class CheckInternet
#Region "CheckInternet"
    'CheckInternet
    Private Declare Function InternetGetConnectedState Lib "wininet" (ByRef dwflags As Long, ByVal dwReserved As Long) As Long
    Private Const CONNECT_LAN As Long = &H2
    Private Const CONNECT_MODEM As Long = &H1
    Private Const CONNECT_PROXY As Long = &H4
    Private Const CONNECT_OFFLINE As Long = &H20
    Private Const CONNECT_CONFIGURED As Long = &H40
    Private Const CONNECT_RAS As Long = &H10
    Public Function IsWebConnected(Optional ByRef ConnType As String = "") As InternetStatus
        Dim Ir As New InternetStatus
        Dim dwflags As Long
        Dim WebTest As Boolean
        WebTest = InternetGetConnectedState(dwflags, 0&)
        Select Case WebTest
            Case dwflags And CONNECT_LAN : ConnType = "LAN"
                Ir.ConnectionType = ("LAN")
            Case dwflags And CONNECT_MODEM : ConnType = "Modem"
                Ir.ConnectionType = ("Modem")
            Case dwflags And CONNECT_PROXY : ConnType = "Proxy"
                Ir.ConnectionType = ("Proxy")
            Case dwflags And CONNECT_OFFLINE : ConnType = "Offline"
                Ir.ConnectionType = ("Offline")
            Case dwflags And CONNECT_CONFIGURED : ConnType = "Configured"
                Ir.ConnectionType = ("Configured")
            Case dwflags And CONNECT_RAS : ConnType = "Remote"
                Ir.ConnectionType = ("Remote")
        End Select
        Ir.Connected = WebTest
        IsWebConnected = Ir
    End Function
    '
    '
    '
#End Region
End Class
Class InternetStatus
    Property Connected As Boolean
    Property ConnectionType As String
End Class