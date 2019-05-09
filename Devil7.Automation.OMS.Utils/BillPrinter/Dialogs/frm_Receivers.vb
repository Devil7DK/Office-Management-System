Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports Devil7.Automation.OMS.Lib

Public Class frm_Receivers

#Region "Variables"
    Dim ProgressOverlayHandle As DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle
    Dim Edited As Boolean = False
#End Region

#Region "Properties"
    Property Receivers As BindingList(Of Objects.Receiver)
        Get
            If gc_Receivers.DataSource Is Nothing Then
                gc_Receivers.DataSource = New BindingList(Of Objects.Receiver) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
            End If

            Return CType(gc_Receivers.DataSource, BindingList(Of Objects.Receiver))
        End Get
        Set(value As BindingList(Of Objects.Receiver))
            Me.Invoke(Sub()
                          gc_Receivers.DataSource = value
                          gc_Receivers.RefreshDataSource()
                      End Sub)
        End Set
    End Property
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
    Private Async Sub frm_Receivers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ShowProgressOverlay()
        Dim Receivers As New BindingList(Of Objects.Receiver) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
        Try
            Await Threading.Tasks.Task.Run(Sub()
                                               Receivers = New BindingList(Of Objects.Receiver)(Database.Receivers.GetReceivers(False))
                                           End Sub)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Unable to load receivers data!" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Invoke(Sub()
                       DialogResult = DialogResult.Cancel
                       Close()
                   End Sub)
        End Try
        Me.Receivers = Receivers
        CloseProgressOverlay()
    End Sub
#End Region

#Region "Grid Events"
    Private Async Sub gv_Receivers_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gv_Receivers.RowUpdated
        ShowProgressOverlay()
        Await Threading.Tasks.Task.Run(Sub()
                                           Dim Row As Objects.Receiver = CType(e.Row, Objects.Receiver)
                                           If e.RowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
                                               Database.Receivers.AddNew(Row)
                                               Edited = True
                                               Invoke(Sub() gc_Receivers.RefreshDataSource())
                                           Else
                                               Database.Receivers.Update(Row)
                                               Edited = True
                                               Invoke(Sub() gc_Receivers.RefreshDataSource())
                                           End If
                                       End Sub)
        CloseProgressOverlay()
    End Sub

    Private Async Sub gv_Receivers_KeyDown(sender As Object, e As KeyEventArgs) Handles gv_Receivers.KeyDown
        ShowProgressOverlay()
        Await Threading.Tasks.Task.Run(Sub()
                                           If e.KeyCode = Keys.Delete AndAlso gv_Receivers.SelectedRowsCount > 0 Then
                                               For Each i As Integer In gv_Receivers.GetSelectedRows
                                                   Dim Item As Objects.Receiver = CType(gv_Receivers.GetRow(i), Objects.Receiver)
                                                   Database.Receivers.Remove(CInt(Item.RID))
                                                   Invoke(Sub() Receivers.Remove(Item))
                                                   Edited = True
                                               Next
                                               Invoke(Sub() gc_Receivers.RefreshDataSource())
                                           End If
                                       End Sub)
        CloseProgressOverlay()
    End Sub

    Private Sub frm_Receivers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Edited Then
            DialogResult = DialogResult.OK
        Else
            DialogResult = DialogResult.Cancel
        End If
    End Sub
#End Region

End Class