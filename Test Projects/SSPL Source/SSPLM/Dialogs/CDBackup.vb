Imports System.ComponentModel

Public Class CDBackup
    Private Sub CDBackup_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_Temp.Text = My.Computer.FileSystem.SpecialDirectories.Temp
        For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchAllSubDirectories, "*.mdb")
            Dim fi As New IO.FileInfo(i)
            Dim li As ListViewItem = lv_DataBase.Items.Add(IO.Path.GetFileNameWithoutExtension(i))
            li.SubItems.Add(fi.Length / 1024 / 1024)
            li.SubItems.Add(i)
        Next
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        BackgroundWorker1.RunWorkerAsync()
        btn_Next.Enabled = False
        GroupBox1.Enabled = False
        cb_Executables.Enabled = False
        cb_Settings.Enabled = False
        btn_BrowseTemp.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BackgroundWorker1.IsBusy Then
            If lbl_dot.Text = "." Then
                lbl_dot.Text = ".."
            ElseIf lbl_dot.Text = ".." Then
                lbl_dot.Text = "..."
            Else
                lbl_dot.Text = "."
            End If
        Else
            lbl_dot.Visible = False
        End If
    End Sub
    Dim burnfilelist As New List(Of String)
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim filecopylist As New List(Of String)
        Dim dir As String = IO.Path.Combine(txt_Temp.Text, "SSPLCD")
        lbl_Status.Text = "Creating list for database files"
        For Each i As ListViewItem In lv_DataBase.CheckedItems
            filecopylist.Add(i.SubItems(2).Text())
        Next
        lbl_Status.Text = "Creating list for executable files"
        If cb_Executables.Checked Then
            For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchTopLevelOnly, "*")
                filecopylist.Add(i)
            Next
        End If
        lbl_Status.Text = "Creating list for setting file"
        If cb_Settings.Checked Then
            filecopylist.Add(Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath)
        End If
        lbl_Status.Text = ""
        For i As Integer = 0 To filecopylist.Count - 1
            Dim file As String = filecopylist(i)
            Dim target As String = dir & "\" & IO.Path.GetFileName(file)
            lbl_Status.Text = "Copying file : " & IO.Path.GetFileName(file)
            My.Computer.FileSystem.CopyFile(file, target)
            prog_Total.Value = (i / (filecopylist.Count - 1)) * 100
            burnfilelist.Add(target)
        Next
    End Sub

    Private Sub btn_BrowseTemp_Click(sender As Object, e As EventArgs) Handles btn_BrowseTemp.Click
        FolderBrowserDialog1.SelectedPath = txt_Temp.Text
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txt_Temp.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error Is Nothing Then
            Dim b As New Burner(burnfilelist)
            b.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class