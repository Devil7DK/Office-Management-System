﻿Imports Devil7.Automation.OMS.Lib.Utils

Namespace Dialogs
    Public Class frm_ServerSettings
        Dim Settings As SettingsContainer
        Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
            Try
                Settings.ServerName = txt_ServerName.Text
                Settings.DatabaseName = txt_DatabaseName.Text
                Settings.UserName = txt_UserName.Text
                Settings.Password = Encryption.EncryptString(txt_Password.Text)
                Settings.Pooling = sw_Pooling.IsOn
                SettingsManager.SaveSettings()
                SettingsManager.LoadSettings()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MsgBox("Successfully saved Server Settings. Restart application to apply the changes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.Close()
            Catch ex As Exception
                MsgBox("Error on saving settings. Try running as administrator" & vbNewLine & vbNewLine & "Additional Information:" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End Try
        End Sub

        Private Sub frm_ServerSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Settings = SettingsManager.GetSettings
            On Error Resume Next
            txt_ServerName.Text = Settings.ServerName
            txt_DatabaseName.Text = Settings.DatabaseName
            txt_UserName.Text = Settings.UserName
            txt_Password.Text = Encryption.DecryptString(Settings.Password)
            sw_Pooling.IsOn = Settings.Pooling
        End Sub
    End Class
End Namespace