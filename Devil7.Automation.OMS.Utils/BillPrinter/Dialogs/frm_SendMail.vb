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
'=========================================================================='

Public Class frm_SendMail

#Region "Variables"
    Dim FromAddresses As New List(Of [Lib].Objects.ExMailAddress)
    Dim Margins As Integer()
#End Region

#Region "Constructor"
    Sub New(ByVal FromAddresses As List(Of [Lib].Objects.ExMailAddress))
        InitializeComponent()
        Me.FromAddresses = FromAddresses

        txt_From.Properties.Items.AddRange(FromAddresses.ToArray)
    End Sub

    Sub New(ByVal FromAddresses As List(Of [Lib].Objects.ExMailAddress), ByVal ToAddress As String, ByVal Subject As String, ByVal Content As String, ByVal isHTML As String, Optional ByVal Attachment As String = "")
        InitializeComponent()
        Me.FromAddresses = FromAddresses
        Me.Margins = Margins
        Dim Attachments As New List(Of [Lib].Objects.AttachmentFile)

        If Not String.IsNullOrEmpty(Attachment) AndAlso My.Computer.FileSystem.FileExists(Attachment) Then
            Attachments.Add(New [Lib].Objects.AttachmentFile(Attachment))
        End If

        txt_From.Properties.Items.AddRange(FromAddresses.ToArray)
        txt_To.Text = ToAddress
        txt_Subject.Text = Subject
        If isHTML Then
            tab_Body.SelectedTabPage = tp_HTML
            txt_Body_HTML.DocumentText = Content
        Else
            tab_Body.SelectedTabPage = tp_Text
            txt_Body_Plain.Text = Content
        End If
        Me.gc_Attachments.DataSource = Attachments
    End Sub

    Sub New(ByVal FromAddresses As List(Of [Lib].Objects.ExMailAddress), ByVal ToAddress As String, ByVal Subject As String, ByVal Attachments As List(Of String))
        InitializeComponent()
        Me.FromAddresses = FromAddresses
        Dim AttachmentFiles As New List(Of [Lib].Objects.AttachmentFile)

        txt_From.Properties.Items.AddRange(FromAddresses.ToArray)
        txt_To.Text = ToAddress
        txt_Subject.Text = Subject

        For Each File As String In Attachments
            If My.Computer.FileSystem.FileExists(File) Then
                AttachmentFiles.Add(New [Lib].Objects.AttachmentFile(File))
            End If
        Next
        Me.gc_Attachments.DataSource = AttachmentFiles
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_SendMail_Load(sender As Object, e As EventArgs) Handles Me.Load
        DevExpress.XtraEditors.BaseEdit.DefaultErrorImageOptions.Alignment = ErrorIconAlignment.MiddleRight

        If My.Settings.LastUsedMail <> "" Then
            txt_From.SelectedItem = FromAddresses.Find(Function(c) c.EMailID = My.Settings.LastUsedMail)
        End If
        If txt_From.SelectedIndex = -1 And txt_From.Properties.Items.Count > 0 Then txt_From.SelectedIndex = 0
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_SendMail_Click(sender As Object, e As EventArgs) Handles btn_SendMail.Click
        ErrorProvider.ClearErrors()

        If txt_From.SelectedItem Is Nothing Then
            ErrorProvider.SetError(txt_From, "Please Select E-Mail Address!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        If txt_To.Text = "" Then
            ErrorProvider.SetError(txt_To, "To Address Cannot be Empty!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        If Not [Lib].Utils.IsValidEmailFormat(txt_To.Text) Then
            ErrorProvider.SetError(txt_To, "Invalid E-Mail Address!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        Dim Content As String = If(tab_Body.SelectedTabPage Is tp_Text, txt_Body_Plain.Text, txt_Body_HTML.DocumentText)
        If [Lib].Utils.Mailing.Send(txt_From.SelectedItem, txt_To.Text, txt_Subject.Text, Content, tab_Body.SelectedTabPage Is tp_HTML, gc_Attachments.DataSource) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("E-Mail Successfully Sent", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Settings.LastUsedMail = CType(txt_From.SelectedItem, [Lib].Objects.ExMailAddress).EMailID
            My.Settings.Save()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
#End Region

End Class