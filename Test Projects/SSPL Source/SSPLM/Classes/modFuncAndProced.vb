Module modFuncAndProced
    Public Sub sendEmail(ByVal PstrRecip As String, ByVal PstrSubj As String, ByVal PstrMsg As String, _
                         ByVal PstrFromAdd As String, ByVal PstrPass As String, ByVal PstrSMTP_Host As String, _
                         ByVal PstrSMTP_Port As Integer)
        Try
            Dim SmtpServer As New System.Net.Mail.SmtpClient()
            Dim mail As New System.Net.Mail.MailMessage()

            SmtpServer.EnableSsl = True
            SmtpServer.Credentials = New  _
            Net.NetworkCredential(PstrFromAdd, PstrPass)
            SmtpServer.Port = PstrSMTP_Port
            SmtpServer.Host = PstrSMTP_Host
            mail = New System.Net.Mail.MailMessage()
            mail.From = New System.Net.Mail.MailAddress(PstrFromAdd, "Error SSPL")
            mail.To.Add(PstrRecip)
            mail.Subject = PstrSubj
            mail.Body = PstrMsg
            SmtpServer.Send(mail)
            MsgBox("Mail Sent!", MsgBoxStyle.Information, "Sent")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
