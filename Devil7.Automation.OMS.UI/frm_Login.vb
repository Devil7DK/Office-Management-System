Imports System.Security.Principal
Imports Devil7.Automation.OMS.Lib.Database
Imports Devil7.Automation.OMS.Lib.Objects

Public Class frm_Login

    Function IsAdmin() As Boolean
        Return (New WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator)
    End Function

    Private Sub frm_Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If IsAdmin() Then
            btn_ServerSettings.Enabled = True
        Else
            btn_ServerSettings.Enabled = False
        End If
        Try
            Dim Users_ As String() = Users.GetUsernames
            txt_Username.Properties.Items.AddRange(Users_)
            If Users_.Count >= My.Settings.LastUserIndex Then txt_Username.SelectedIndex = My.Settings.LastUserIndex
        Catch ex As Exception
            MsgBox("Error on loading usernames.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_ServerSettings_Click(sender As System.Object, e As System.EventArgs) Handles btn_ServerSettings.Click
        Dim D As New frm_ServerSettings
        D.ShowDialog()
    End Sub

    Private Sub btn_Login_Click(sender As System.Object, e As System.EventArgs) Handles btn_Login.Click
        If txt_Username.SelectedIndex >= 0 AndAlso txt_Password.Text.Trim <> "" Then
            If Not LoginWorker.IsBusy Then LoginWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub LoginWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoginWorker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel.Visible = True
                  End Sub)
        Dim User As User = Users.Login(txt_Username.SelectedItem.ToString, txt_Password.Text)
        If User IsNot Nothing Then
            Me.Invoke(Sub()
                          Dim M As New frm_Main(User)
                          M.Show()
                          Me.Close()
                      End Sub)
        Else
            Me.Invoke(Sub()
                          ProgressPanel.Visible = False
                      End Sub)
        End If
    End Sub
End Class