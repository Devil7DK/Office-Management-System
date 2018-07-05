Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports Google.Apis.Gmail.v1.UsersResource
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Net.Mail
Public Class Email
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal Attachments As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each i As String In My.Computer.FileSystem.GetFiles(Attachments, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
            lst_Attachments.Items.Add(i)
        Next
        For Each i As String In My.Computer.FileSystem.GetFiles(Attachments, FileIO.SearchOption.SearchTopLevelOnly, "*.pdf")
            lst_Attachments.Items.Add(i)
        Next
    End Sub
    Sub AddtoSettings(ByVal EmailAddress As String)
        If My.Settings.EmailAddresses Is Nothing Then
            My.Settings.EmailAddresses = New Specialized.StringCollection
        End If
        If My.Settings.EmailAddresses.Contains(EmailAddress.ToLower) = False Then
            My.Settings.EmailAddresses.Add(EmailAddress)
        End If
    End Sub
    Sub GetToAddresses(ByRef mail As AE.Net.Mail.MailMessage)
        If txt_To.Text.Contains(";") Then
            Dim r As String = ""
            Dim s As String() = Split(txt_To.Text, ";")
            For Each i As String In s
                mail.To.Add(New MailAddress(i))
                AddtoSettings(i)
            Next
        Else
            mail.To.Add(New MailAddress(txt_To.Text))
            AddtoSettings(txt_To.Text)
        End If
        My.Settings.Save()
    End Sub
    Sub GetCCAddresses(ByRef mail As AE.Net.Mail.MailMessage)
        If Not txt_CC.Text.Trim = "" Then
            If txt_CC.Text.Contains(";") Then
                Dim r As String = ""
                Dim s As String() = Split(txt_CC.Text, ";")
                For Each i As String In s
                    mail.Cc.Add(New MailAddress(i))
                Next
            Else
                mail.Cc.Add(New MailAddress(txt_CC.Text))
            End If
        End If
    End Sub
    Sub GetBCCAddresses(ByRef mail As AE.Net.Mail.MailMessage)
        If Not txt_BCC.Text.Trim = "" Then
            If txt_BCC.Text.Contains(";") Then
                Dim r As String = ""
                Dim s As String() = Split(txt_BCC.Text, ";")
                For Each i As String In s
                    mail.Bcc.Add(New MailAddress(i))
                Next
            Else
                mail.Bcc.Add(New MailAddress(txt_BCC.Text))
            End If
        End If
    End Sub
    Sub GetToAddresses(ByRef mail As System.Net.Mail.MailMessage)
        If txt_To.Text.Contains(";") Then
            Dim r As String = ""
            Dim s As String() = Split(txt_To.Text, ";")
            For Each i As String In s
                mail.To.Add(i)
                AddtoSettings(i)
            Next
        Else
            mail.To.Add(txt_To.Text)
            AddtoSettings(txt_To.Text)
        End If
        My.Settings.Save()
    End Sub
    Sub GetCCAddresses(ByRef mail As System.Net.Mail.MailMessage)
        If Not txt_CC.Text.Trim = "" Then
            If txt_CC.Text.Contains(";") Then
                Dim r As String = ""
                Dim s As String() = Split(txt_CC.Text, ";")
                For Each i As String In s
                    mail.CC.Add(i)
                Next
            Else
                mail.CC.Add(txt_CC.Text)
            End If
        End If
    End Sub
    Sub GetBCCAddresses(ByRef mail As System.Net.Mail.MailMessage)
        If Not txt_BCC.Text.Trim = "" Then
            If txt_BCC.Text.Contains(";") Then
                Dim r As String = ""
                Dim s As String() = Split(txt_BCC.Text, ";")
                For Each i As String In s
                    mail.Bcc.Add(i)
                Next
            Else
                mail.Bcc.Add(txt_BCC.Text)
            End If
        End If
    End Sub
    Private Function GetMimeType(ByVal fileName As String) As String
        Dim mimeType As String = "application/unknown"
        Dim ext As String = Path.GetExtension(fileName).ToLower()
        Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext)
        If regKey IsNot Nothing AndAlso regKey.GetValue("Content Type") IsNot Nothing Then
            mimeType = regKey.GetValue("Content Type").ToString()
        End If
        Return mimeType
    End Function
    Sub GetAttachments(ByRef mail As AE.Net.Mail.MailMessage)
        If lst_Attachments.Items.Count > 0 Then
            For Each i As String In lst_Attachments.Items
                mail.Attachments.Add(New AE.Net.Mail.Attachment(My.Computer.FileSystem.ReadAllBytes(i), GetMimeType(i), IO.Path.GetFileNameWithoutExtension(i), True))
            Next
        End If
    End Sub
    Sub GetAttachments(ByRef mail As System.Net.Mail.MailMessage)
        If lst_Attachments.Items.Count > 0 Then
            For Each i As String In lst_Attachments.Items
                mail.Attachments.Add(New Attachment(i))
            Next
        End If
    End Sub
    Public Sub sendEmail()
        Try
            Dim SmtpServer As New System.Net.Mail.SmtpClient()
            Dim mail As New System.Net.Mail.MailMessage()
            SmtpServer.EnableSsl = True
            SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.Email, My.Settings.Password)
            SmtpServer.Port = My.Settings.Port
            SmtpServer.Host = My.Settings.SMTP
            mail = New System.Net.Mail.MailMessage()
            mail.From = New System.Net.Mail.MailAddress(My.Settings.Email, My.Settings.DisplayName)
            GetToAddresses(mail)
            GetCCAddresses(mail)
            GetBCCAddresses(mail)
            GetAttachments(mail)
            mail.Subject = txt_Subject.Text
            mail.Body = txt_Body.Text
            mail.DeliveryNotificationOptions = Net.Mail.DeliveryNotificationOptions.OnFailure
            SmtpServer.Send(mail)
            MsgBox("Mail Sent!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sent")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MailSenter.IsBusy = True Then
            If btn_Send.Text = "Sending" Then
                btn_Send.Text = "Sending."
            ElseIf btn_Send.Text = "Sending." Then
                btn_Send.Text = "Sending.."
            ElseIf btn_Send.Text = "Sending.." Then
                btn_Send.Text = "Sending..."
            Else
                btn_Send.Text = "Sending"
            End If
        Else
            If Not btn_Send.Text = "Send" Then
                btn_Send.Text = "Send"
            End If
        End If
    End Sub

    Private Sub MailSenter_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles MailSenter.DoWork
        If My.Settings.Email.ToLower.EndsWith("@gmail.com") Then
            SendIt()
        Else
            sendEmail()
        End If
        btn_Send.Enabled = True
    End Sub

    Private Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        MailSenter.RunWorkerAsync()
        btn_Send.Enabled = False
    End Sub

    Private Sub btn_AddAttachment_Click(sender As Object, e As EventArgs) Handles btn_AddAttachment.Click
        If AttachmentSelect.ShowDialog = DialogResult.OK Then
            lst_Attachments.Items.AddRange(AttachmentSelect.FileNames)
        End If
    End Sub
    Public Sub SendIt()
        Try
            Dim msg = New AE.Net.Mail.MailMessage() With {.Subject = txt_Subject.Text, .Body = txt_Body.Text, .From = New MailAddress(My.Settings.Email, My.Settings.DisplayName)}
            GetToAddresses(msg)
            GetCCAddresses(msg)
            GetBCCAddresses(msg)
            GetAttachments(msg)
            msg.ReplyTo.Add(msg.From)
            ' Bounces without this!!
            Dim msgStr = New StringWriter()
            msg.Save(msgStr)
            Dim ClientId = "954901835857-2os0cfagq5hf0fr76770stdd7nn9de1v.apps.googleusercontent.com"
            Dim ClientSecret = "eCyqZOB1ZAEOWWucU8d_qQkd"
            Dim credential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = ClientId, .ClientSecret = ClientSecret}, {GmailService.Scope.MailGoogleCom}, My.Settings.Email, CancellationToken.None).Result
            Dim service As New GmailService(New BaseClientService.Initializer() With {.HttpClientInitializer = credential, .ApplicationName = "SSPL Mail Service"})
            Dim result As Message = service.Users.Messages.Send(New Message() With {.Raw = Base64UrlEncode(msgStr.ToString())}, "me").Execute()
            MsgBox("Mail Sent!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sent")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Shared Function Base64UrlEncode(input As String) As String
        Dim inputBytes = System.Text.Encoding.UTF8.GetBytes(input)
        ' Special "url-safe" base64 encode.
        Return Convert.ToBase64String(inputBytes).Replace("+"c, "-"c).Replace("/"c, "_"c).Replace("=", "")
    End Function
    Private Sub btn_RemoveAttachment_Click(sender As Object, e As EventArgs) Handles btn_RemoveAttachment.Click
        For i As Integer = 0 To lst_Attachments.SelectedItems.Count - 1
            lst_Attachments.Items.Remove(lst_Attachments.SelectedItems(i))
        Next
    End Sub

    Private Sub lst_Attachments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Attachments.SelectedIndexChanged
        Try
            pic_Preview.Image = Image.FromFile(lst_Attachments.SelectedItem)
        Catch ex As Exception
            Try
                pic_Preview.Image = Icon.ExtractAssociatedIcon(lst_Attachments.SelectedItem).ToBitmap
            Catch ex1 As Exception

            End Try
        End Try
    End Sub

    Private Sub lst_Attachments_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_Attachments.MouseDoubleClick
        If lst_Attachments.SelectedItems.Count = 1 Then
            Process.Start(lst_Attachments.SelectedItem)
        End If
    End Sub

    Private Sub Email_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            For Each i As String In My.Settings.EmailAddresses
                txt_To.AutoCompleteCustomSource.Add(i)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class