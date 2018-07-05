Public Class Settings

    Sub SaveStatement()
        My.Settings.StatementFont = lbl_DetailsFont.Font
        My.Settings.StatementHeaderFont = lbl_HeaderFont.Font
        My.Settings.StatementImage = PrintHeaderOption.SelectedIndex
        My.Settings.StatementMarginTop = Statement_Top.Value
        My.Settings.StatementMarginBottom = Statement_Bottom.Value
        My.Settings.StatementMarginRight = Statement_Right.Value
        My.Settings.StatementMarginLeft = Statement_Left.Value
        My.Settings.StatementPageNumberY = StatementPageY.Value
    End Sub
    Sub LoadStatement()
        lbl_DetailsFont.Font = My.Settings.StatementFont
        lbl_HeaderFont.Font = My.Settings.StatementHeaderFont
        PrintHeaderOption.SelectedIndex = My.Settings.StatementImage
        Statement_Top.Value = My.Settings.StatementMarginTop
        Statement_Bottom.Value = My.Settings.StatementMarginBottom
        Statement_Right.Value = My.Settings.StatementMarginRight
        Statement_Left.Value = My.Settings.StatementMarginLeft
        StatementPageY.Value = My.Settings.StatementPageNumberY
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatement()
        txt_DefaultFile.Text = My.Settings.DefaultFile
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SaveStatement()
        My.Settings.DefaultFile = txt_DefaultFile.Text
        My.Settings.Save()
        Me.Close()
    End Sub


    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        If SelectFileForView.ShowDialog = DialogResult.OK Then
            txt_DefaultFile.Text = SelectFileForView.Filename
        End If
    End Sub
    Private Sub btn_HeaderFont_Click(sender As Object, e As EventArgs) Handles btn_HeaderFont.Click
        Dim f As New FontDialog
        f.Font = lbl_HeaderFont.Font
        If f.ShowDialog = DialogResult.OK Then
            lbl_HeaderFont.Font = f.Font
        End If
    End Sub

    Private Sub btn_DetailsFont_Click(sender As Object, e As EventArgs) Handles btn_DetailsFont.Click
        Dim f As New FontDialog
        f.Font = lbl_DetailsFont.Font
        If f.ShowDialog = DialogResult.OK Then
            lbl_DetailsFont.Font = f.Font
        End If
    End Sub
End Class