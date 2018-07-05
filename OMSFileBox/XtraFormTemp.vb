Public Class XtraFormTemp

    Inherits DevExpress.XtraEditors.XtraForm
    Protected Overrides Function GetAllowSkin() As Boolean
        Return True
    End Function
    Sub New()

    End Sub
    Private Sub XtraFormTemp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
End Class