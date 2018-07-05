Public Class Form1

    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'FastObjectListView1.VirtualMode = False
    'BackgroundWorker1.RunWorkerAsync()
    'End Sub
    'Start the function running from the program code
    Private Sub myProj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FastObjectListView1.VirtualMode = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub LoadDirs(ByVal StartPath As String)
        On Error Resume Next
        Dim dir As New System.IO.DirectoryInfo(StartPath)
        Invoke(New MethodInvoker(Sub() FastObjectListView1.Items.Add(dir.Name)))
        Invoke(New MethodInvoker(Sub() Label3.Text = dir.Name))
        ' FastObjectListView1.Items.Add(dir.Name)
        'Print the current directory in our listbox
        For Each i As String In My.Computer.FileSystem.GetFiles(dir.FullName, FileIO.SearchOption.SearchTopLevelOnly, "*")
            Invoke(New MethodInvoker(Sub() Label3.Text = i))
            Invoke(New MethodInvoker(Sub() FastObjectListView1.Items.Add(i)))
        Next

        Dim dirs As IO.DirectoryInfo() = dir.GetDirectories()
        Dim d As IO.DirectoryInfo
        For Each d In dirs
            'Call the function for all of the subdirectories in the current directory
            LoadDirs(d.FullName)
        Next
    End Sub


    Sub IndexDir(ByVal Dir As String)
        For Each i As String In My.Computer.FileSystem.GetDirectories(Dir, FileIO.SearchOption.SearchTopLevelOnly, "*")
            Invoke(New MethodInvoker(Sub() Label3.Text = i))
            Invoke(New MethodInvoker(Sub() FastObjectListView1.Items.Add(i)))
            Try
                IndexDir(Dir)
            Catch ex As Exception

            End Try
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Dir, FileIO.SearchOption.SearchTopLevelOnly, "*")
            Invoke(New MethodInvoker(Sub() Label3.Text = i))
            Invoke(New MethodInvoker(Sub() FastObjectListView1.Items.Add(i)))
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Invoke(New MethodInvoker(Sub() Label1.Text = Now.ToString("hh:mm:ss")))
        LoadDirs("\\HP\Storage")
        Invoke(New MethodInvoker(Sub() FastObjectListView1.Visible = True))
        Invoke(New MethodInvoker(Sub() Label2.Text = Now.ToString("hh:mm:ss")))
    End Sub
End Class