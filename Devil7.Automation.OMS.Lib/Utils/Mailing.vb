'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports System.IO
Imports System.Net.Mail
Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports MimeKit

Namespace Utils
    Public Class Mailing

#Region "Variables"
        Private Shared Settings As SettingsContainer = SettingsManager.GetSettings
#End Region

#Region "Private Functions"
        Private Shared Function GetCredential(ByVal EMailID As String) As UserCredential
            Return GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = SecretKeys.GMail.ClientID, .ClientSecret = SecretKeys.GMail.ClientSecret}, {GmailService.Scope.MailGoogleCom}, EMailID, CancellationToken.None).Result
        End Function

        Private Shared Function GetService(ByVal EMailID As String) As GmailService
            Return New GmailService(New BaseClientService.Initializer() With {.HttpClientInitializer = GetCredential(EMailID), .ApplicationName = My.Application.Info.ProductName})
        End Function

        Private Shared Function Base64UrlEncode(input As String) As String
            Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input)).Replace("+"c, "-"c).Replace("/"c, "_"c).Replace("=", "")
        End Function

#End Region

#Region "Public Functions"
        Public Shared Function Send(ByVal FromAddress As Objects.ExMailAddress, ByVal ToAddress As String, ByVal Subject As String, ByVal Content As String, ByVal isContentHTML As Boolean, ByVal Attachments As List(Of Objects.AttachmentFile)) As Boolean
            Try
                Dim From As New MailAddress(FromAddress.EMailID, FromAddress.DisplayName)

                Dim Message As New MailMessage
                With Message
                    .Body = Content
                    .From = From
                    .IsBodyHtml = isContentHTML
                    .Priority = MailPriority.High
                    .Sender = From
                    .Subject = Subject

                    .ReplyToList.Add(From)
                    .To.Add(New MailAddress(ToAddress))

                    For Each file As Objects.AttachmentFile In Attachments
                        If My.Computer.FileSystem.FileExists(file.FilePath) Then
                            .Attachments.Add(New Attachment(file.FilePath))
                        End If
                    Next
                End With

                Dim MessageData As MimeMessage = MimeMessage.CreateFromMailMessage(Message)
                Dim Result As Message = GetService(FromAddress.EMailID).Users.Messages.Send(New Message With {.Raw = Base64UrlEncode(MessageData.ToString)}, "me").Execute
                Return True
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Unable to send E-Mail." & vbNewLine & vbNewLine & vbNewLine & ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
                Return False
            End Try
        End Function
#End Region

    End Class
End Namespace