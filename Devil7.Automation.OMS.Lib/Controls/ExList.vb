Imports System.Windows.Forms

Namespace Controls
    Public Class ExList(Of T)

#Region "Custom Events"
        Public Event OnAdd(ByVal List As List(Of T))
        Public Event OnEdit(ByVal Item As T)
#End Region

#Region "Properties"
        Property ListData As List(Of T)
            Get
                Return gc_List.DataSource
            End Get
            Set(value As List(Of T))
                gc_List.DataSource = value
                gc_List.RefreshDataSource()
            End Set
        End Property
#End Region

#Region "Subs"
        Public Sub RefreshData()
            gc_List.RefreshDataSource()
        End Sub
#End Region

#Region "Button Events"
        Private Sub btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
            RaiseEvent OnAdd(gc_List.DataSource)
        End Sub

        Private Sub btn_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Edit.ItemClick
            If gv_List.SelectedRowsCount = 1 Then
                RaiseEvent OnEdit(gv_List.GetRow(gv_List.GetSelectedRows(0)))
            End If
        End Sub

        Private Sub btn_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
            If gv_List.SelectedRowsCount > 0 Then
                If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure..? Do you want to delete all selected items from the list..?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each i As Integer In gv_List.GetSelectedRows
                        gv_List.DataSource.Remove(gv_List.GetRow(i))
                    Next
                End If
            End If
        End Sub
#End Region

    End Class
End Namespace