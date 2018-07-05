Imports System.Security.Principal
Imports System.Collections.Specialized
Imports GlobalCode

Public Class frm_Drop
    Dim index As Integer = 0
    Dim ImageNames As String() = Split(My.Resources.ImageNames, vbNewLine)
    Dim isfiledroped As Boolean = False
    Dim index2 As Integer = 0
    Dim ImageNames2 As String() = Split(My.Resources.ImageNames2, vbNewLine)
    Dim frm_AddFileDialog As New frm_AddFiles(New StringCollection, New StringCollection, Me)
    Public UserData As GlobalCode.User = Nothing

    Private Sub frm_Drop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Location = Me.Location
    End Sub
    Private Sub frm_Drop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Microsoft.VisualBasic.Command Is "" Then
            MsgBox("This application can't be launched directly..!", MsgBoxStyle.Exclamation, "Warning")
            End
        Else
            Dim Path As String = My.Application.CommandLineArgs(0)
            Try
                Dim id As Integer = CInt(Path)
                Dim cs As String = My.Computer.FileSystem.ReadAllText(IO.Path.Combine(Application.StartupPath, "cs.str"))
                Dim r As User = LoadUserByID(cs, id)
                If r Is Nothing Then
                    MsgBox("Can't load user.", MsgBoxStyle.Exclamation, "Error")
                    End
                Else
                    UserData = r
                End If
            Catch ex As Exception
                MsgBox("Error Parsing Argument. " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
                End
            End Try
        End If
        Try
            If My.Settings.Location = New Point(0, 0) Then
                Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Me.Width, My.Computer.Screen.WorkingArea.Height - Me.Height)
            Else
                Me.Location = My.Settings.Location
            End If
        Catch ex As Exception

        End Try
        WinAPI.AttachFormToDesktop(Me)
        Me.SendToBack()
        Me.AllowDrop = True
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated Then
            Me.Text &= "(Administrator)"
        End If
        Try
            '
            TcpClientEx1.Connect(My.Settings.IP, My.Settings.Port)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAnimation.Tick
        On Error Resume Next
        If index > ImageNames.Count - 1 Then
            OpenAnimation.Stop()
        Else
            PictureBox1.Image = My.Resources.ResourceManager.GetObject(ImageNames(index))
            index += 1
        End If
    End Sub
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Private Sub CloseAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAnimation.Tick
        On Error Resume Next
        If index < 0 Then
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            End If
            CloseAnimation.Stop()
        Else
            PictureBox1.Image = My.Resources.ResourceManager.GetObject(ImageNames(index))
            index -= 1
        End If
    End Sub

    Dim DropedFiles As New StringCollection
    Dim DropedDirectories As New StringCollection
    Private Sub PictureBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            DropedFiles = New StringCollection
            DropedDirectories = New StringCollection
            For Each path In files
                Try
                    If My.Computer.FileSystem.FileExists(path) Then
                        DropedFiles.Add(path)
                    ElseIf My.Computer.FileSystem.DirectoryExists(path) Then
                        DropedDirectories.Add(path)
                    End If
                Catch ex As Exception

                End Try
            Next
            CloseAnimation.Stop()
            OpenAnimation.Stop()
            DropAnimation.Start()
        End If
    End Sub

    Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            isfiledroped = True
            index = 0
            CloseAnimation.Stop()
            DropAnimation.Stop()
            OpenAnimation.Start()
        End If
    End Sub

    Private Sub PictureBox1_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DragLeave
        If isfiledroped = True Then
            isfiledroped = False
            index = ImageNames.Count - 1
        End If
        OpenAnimation.Stop()
        DropAnimation.Stop()
        CloseAnimation.Start()
    End Sub

    Private Sub DropAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropAnimation.Tick
        On Error Resume Next
        If index2 > ImageNames2.Count - 1 Then
            index2 = 0
            index = ImageNames.Count - 1
            PictureBox1.Image = My.Resources.ResourceManager.GetObject(ImageNames(index))
            CloseAnimation.Start()
            Dim s As New Threading.Thread(New Threading.ThreadStart(AddressOf AddFiles))
            s.Start()
            DropAnimation.Stop()
        Else
            PictureBox1.Image = My.Resources.ResourceManager.GetObject(ImageNames2(index2))
            index2 += 1
        End If
    End Sub
    Sub AddFiles()
        If DropedFiles.Count > 0 Or DropedDirectories.Count > 0 Then
            frm_AddFileDialog = New frm_AddFiles(DropedFiles, DropedDirectories, Me)
            frm_AddFileDialog.ShowDialog()
        End If
    End Sub
    Dim drag As Boolean = False
    Dim mousex As Integer = 0
    Dim mousey As Integer = 0
    Private Sub frm_Drop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, PictureBox1.MouseDown
        'If e.Button = Left Then
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        'End If
    End Sub

    Private Sub frm_Drop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, PictureBox1.MouseMove
        If drag = True Then 'AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frm_Drop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, PictureBox1.MouseUp
        'If e.Button = Windows.Forms.MouseButtons.Left AndAlso drag = True Then
        drag = False
        'End If
    End Sub


    Private Sub RightBottonCornerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightBottonCornerToolStripMenuItem.Click
        Try
            Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Me.Width, My.Computer.Screen.WorkingArea.Height - Me.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RightLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightLeftToolStripMenuItem.Click
        Try
            Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Me.Width, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LeftBottomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftBottomToolStripMenuItem.Click
        Try
            Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LeftTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftTopToolStripMenuItem.Click
        Try
            Me.Location = New Point(1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If MsgBox("Are you sure do you wan't to close this application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Notification_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notification.MouseDoubleClick
        Me.Show()
    End Sub

    Function GetIP()
        Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
        Dim LocalIPString As String = ""
        For Each i As Net.IPAddress In localIP
            If i.ToString.Split(".").Count = 4 Then
                LocalIPString = i.ToString()
            End If
        Next
        Return LocalIPString
    End Function

    Private Sub TcpClientEx1_LogRaised(sender As Object, e As GlobalCode.LogObject) Handles TcpClientEx1.LogRaised
        If e.LogType = LogTypes.Err Then
            MsgBox(e.ErrorException.Message)
            MsgBox(e.ErrorException.StackTrace)
            MsgBox(e.ErrorException.Source)
        Else
            MsgBox(e.Message)
        End If
    End Sub
    Dim FileTotalSize As Integer
    Private Sub TcpClientEx1_CommunicationReceived(sender As Object, e As GlobalCode.CommunicatingObject) Handles TcpClientEx1.CommunicationReceived
        Try
            If e.MessageTo = UserData.Username Or e.MessageTo = "ALL" Then
                
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
