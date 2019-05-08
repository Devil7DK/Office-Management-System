Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports Devil7.Automation.OMS.Lib

Public Class frm_BillItems

#Region "Variables"
    Dim ProgressOverlayHandle As DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle
#End Region

#Region "Subs"
    Sub ShowProgressOverlay()
        ProgressOverlayHandle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(Me)
    End Sub

    Sub CloseProgressOverlay()
        If ProgressOverlayHandle IsNot Nothing Then DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(ProgressOverlayHandle)
    End Sub
#End Region

#Region "Form Events"
    Private Async Sub frm_BillItems_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ShowProgressOverlay()
        Dim Templates As New BindingList(Of Objects.BillItemTemplate) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
        Try
            Await Threading.Tasks.Task.Run(Sub()
                                               Templates = Database.BillItemTemplates.GetAll(True)
                                           End Sub)

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Unable to load bill item templates!" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        gc_Templates.DataSource = Templates
        gc_Templates.RefreshDataSource()
        CloseProgressOverlay()
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gv_Templates_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gv_Templates.RowUpdated
        Try
            ShowProgressOverlay()
            Dim Item As Objects.BillItemTemplate = CType(e.Row, Objects.BillItemTemplate)
            If Item IsNot Nothing Then
                If e.RowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
                    Database.BillItemTemplates.AddNew(Item)
                ElseIf Item.ID > 0 Then
                    Database.BillItemTemplates.Update(Item)
                End If
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Failed to update item!" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseProgressOverlay()
            gc_Templates.RefreshDataSource()
        End Try
    End Sub

    Private Sub gv_Templates_KeyDown(sender As Object, e As KeyEventArgs) Handles gv_Templates.KeyDown
        If e.KeyCode = Keys.Delete AndAlso gv_Templates.SelectedRowsCount > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure? Do you want to delete selected items..?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                For Each i As Integer In gv_Templates.GetSelectedRows
                    Dim Item As Objects.BillItemTemplate = CType(gv_Templates.GetRow(i), Objects.BillItemTemplate)
                    If Database.BillItemTemplates.Remove(Item.ID, False) Then
                        gc_Templates.DataSource.Remove(Item)
                    End If
                Next
                gc_Templates.RefreshDataSource()
            End If
        End If
    End Sub
#End Region
End Class