Public Class UnhandledException
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        btn_Send.Enabled = False
        Dim problem As String = ""
        For Each i As ListViewItem In Details.Items
            problem &= i.Text & ":" & i.SubItems(1).Text & vbNewLine
        Next
        problem &= Txt_Details.Text.Trim
        Call sendEmail("dineshthangavel47@gmail.com", "Error SSPL", problem.Trim, My.Settings.Email, My.Settings.Password, My.Settings.SMTP, CInt(My.Settings.Port))
        btn_Send.Enabled = True
        Me.Close()
    End Sub

    Private Sub btn_Send_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Send.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Friend Sub AddDetail(ByVal Name_ As String, ByVal Detail As String)
        Details.Items.Add(Name_).SubItems.Add(Detail)
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        End
    End Sub
End Class