Imports GlobalCode
Public Class frm_Partner
    Dim Mode As DialogMode = DialogMode.Add
    Sub New(ByVal Type As DialogMode, Optional ByRef SourcePartner As Partner = Nothing)
        InitializeComponent()
        Me.Mode = Type
        Me.Partner = SourcePartner
    End Sub
    Property Partner As Partner
    Private Sub frm_Partner_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Mode = DialogMode.Edit AndAlso Partner IsNot Nothing Then
            txt_Name.Text = Partner.Name
            txt_Address.Text = Partner.Address
            txt_PAN.Text = Partner.PAN
            txt_Date.Value = Partner.DOB
        End If
        txt_PAN.Focus()
    End Sub

    Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
        Me.Partner = New Partner(txt_Name.Text, txt_Address.Text, txt_PAN.Text, txt_Date.Value.ToString("dd/MM/yyyy"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class