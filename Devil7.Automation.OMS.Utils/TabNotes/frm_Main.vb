Public Class frm_Main
    Private Sub TabFormControl1_OuterFormCreating(sender As Object, e As DevExpress.XtraBars.OuterFormCreatingEventArgs) Handles TabFormControl1.OuterFormCreating
        Dim form As New frm_Main
        form.TabFormControl.Pages.Clear()
        e.Form = form
    End Sub
End Class
