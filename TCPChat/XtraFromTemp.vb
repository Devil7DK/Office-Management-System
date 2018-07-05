Public Class XtraFormTemp
    Inherits DevExpress.XtraEditors.XtraForm
    Protected Overrides Function GetAllowSkin() As Boolean
        Return True
    End Function
    Private Sub XtraFormTemp_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
End Class