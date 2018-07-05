Imports System.Data.SqlClient
Imports GlobalCode
Public Class frm_Login
    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PasswordShowButton1.PasswordTextBox = txt_Password
            Try
                My.Computer.FileSystem.WriteAllText(IO.Path.Combine(Application.StartupPath, "cs.str"), ConnectionString, False)
            Catch ex As Exception

            End Try
            Dim i As Integer = -1
            Dim Users As System.ComponentModel.BindingList(Of User) = LoadUsers(ConnectionString)
            For Each User As User In Users
                Dim d As Integer = cmb_Users.Properties.Items.Add(User)
                If My.Settings.LastLogin = User.Username Then
                    i = d
                End If
            Next
            If My.Settings.LastLogin = "" Then
                cmb_Users.SelectedIndex = 0
            Else
                If i > -1 Then
                    cmb_Users.SelectedIndex = i
                Else
                    cmb_Users.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub StartFileUI()
        Dim p As New ProcessStartInfo(IO.Path.Combine(Application.StartupPath, "Devil7 Office Management System FileBox.exe"), CType(cmb_Users.SelectedItem, User).ID)
        Process.Start(p)
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If CType(cmb_Users.SelectedItem, User).Password = EncryptString(txt_Password.Text) Then
            My.Settings.LastLogin = CType(cmb_Users.SelectedItem, User).Username
            Dim t As New Threading.Thread(AddressOf StartFileUI)
            t.Start()
            Dim f As New frm_Main_GenUser(CType(cmb_Users.SelectedItem, User))
            f.Show()
            Me.Close()
        Else
            HuraAlertBox1.Show()
        End If
    End Sub

    Private Sub cmb_Users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Users.SelectedIndexChanged
        Try
            UserPictureFrame.Image = CType(cmb_Users.SelectedItem, User).Photo
        Catch ex As Exception
        End Try
    End Sub


    Private Sub txt_Password_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Password.KeyUp
        If e.KeyData = Keys.Enter Then
            btn_Login_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        End
    End Sub
End Class