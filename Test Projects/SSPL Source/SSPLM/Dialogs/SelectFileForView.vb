Public Class SelectFileForView
    Property Filename As String
    Private Sub SelectFileForView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lv_Files.Items.Clear()
            For Each i As String In My.Computer.FileSystem.GetFiles(Application.StartupPath, FileIO.SearchOption.SearchAllSubDirectories, "*.mdb")
                Dim li As ListViewItem = lv_Files.Items.Add(IO.Path.GetFileNameWithoutExtension(i))
                li.SubItems.Add(i)
                li.ImageIndex = 0
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If lv_Files.SelectedItems.Count = 1 Then
            Filename = lv_Files.SelectedItems(0).SubItems(1).Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub lv_Files_DoubleClick(sender As Object, e As EventArgs) Handles lv_Files.DoubleClick
        If lv_Files.SelectedItems.Count = 1 Then
            Filename = lv_Files.SelectedItems(0).SubItems(1).Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class