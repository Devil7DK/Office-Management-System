Imports Devil7.Automation.OMS.Lib

Public Class frm_ServerSettings
    Dim Settings As Settings
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            Settings.ServerName = Encryption.EncryptString(txt_ServerName.Text)
            Settings.DatabaseName = Encryption.EncryptString(txt_DatabaseName.Text)
            Settings.UserName = Encryption.EncryptString(txt_UserName.Text)
            Settings.Password = Encryption.EncryptString(txt_Password.Text)
            Settings.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            MsgBox("Successfully saved Server Settings. Restart application to apply the changes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error on saving settings. Try running as administrator" & vbNewLine & vbNewLine & "Additional Information:" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub frm_ServerSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Settings = Settings.Load
        On Error Resume Next
        txt_ServerName.Text = Encryption.DecryptString(Settings.ServerName)
        txt_DatabaseName.Text = Encryption.DecryptString(Settings.DatabaseName)
        txt_UserName.Text = Encryption.DecryptString(Settings.UserName)
        txt_Password.Text = Encryption.DecryptString(Settings.Password)
    End Sub
End Class