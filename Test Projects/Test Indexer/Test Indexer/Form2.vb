Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As Date = Now
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each i As String In My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*")
                ListBox1.Items.Add(i)
            Next
        End If
        Dim f As Date = Now
        MsgBox(s.ToString("hh:mm:ss") & vbNewLine & f.ToString("hh:mm:ss") & vbNewLine & f.Subtract(s).Minutes)
    End Sub
End Class