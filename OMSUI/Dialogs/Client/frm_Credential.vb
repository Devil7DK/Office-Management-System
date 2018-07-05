Imports GlobalCode
Public Class frm_Credential
    Dim Mode As DialogMode = DialogMode.Add
    Sub New(ByVal Type As DialogMode, Optional ByRef Credential_ As Credential = Nothing)
        InitializeComponent()
        Me.Mode = Type
        Me.Credential = Credential_
    End Sub
    Property Credential As Credential
    Private Sub frm_Credential_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Mode = DialogMode.Edit AndAlso Credential IsNot Nothing Then
            txt_Name.Text = Credential.Name
            txt_Template.Text = Credential.Template
            txt_UserName.Text = Credential.Username
            txt_Password1.Text = Credential.Password
            txt_Password2.Text = Credential.Password2
            txt_Password3.Text = Credential.Password3
        End If
        txt_Name.Focus()
    End Sub

    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Me.Credential = New Credential(txt_Name.Text, txt_Template.Text, txt_UserName.Text, txt_Password1.Text, txt_Password2.Text, txt_Password3.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class