Public Class frm_Settings

#Region "Form Events"
    Private Sub frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_FeesReminderMessage.Text = My.Settings.FeesReminderDefaultText
        sw_PrintLegalName.IsOn = My.Settings.PrintLegalName
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        My.Settings.FeesReminderDefaultText = txt_FeesReminderMessage.Text
        My.Settings.PrintLegalName = sw_PrintLegalName.IsOn
        My.Settings.Save()

        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

End Class