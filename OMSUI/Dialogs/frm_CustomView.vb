Public Class frm_CustomView
    Sub New(ByVal AllColumns As Specialized.StringCollection, ByVal CheckedColumns As Specialized.StringCollection)
        InitializeComponent()
        For Each i As String In AllColumns
            Dim index As Integer = lst_Columns.Items.Add(i)
            If CheckedColumns.Contains(i) Then
                lst_Columns.Items(index).CheckState = CheckState.Checked
            End If
        Next
    End Sub
    ReadOnly Property Columns As Specialized.StringCollection
        Get
            Dim r As New Specialized.StringCollection
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In lst_Columns.Items
                If i.CheckState = CheckState.Checked Then
                    r.Add(i.Value)
                End If
            Next
            Return r
        End Get
    End Property

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Sub SetSelectAllState()
        If lst_Columns.CheckedItems.Count = 0 Then
            cb_SelectAll.CheckState = CheckState.Unchecked
        ElseIf lst_Columns.CheckedItems.Count = lst_Columns.Items.Count Then
            cb_SelectAll.CheckState = CheckState.Checked
        Else
            cb_SelectAll.CheckState = CheckState.Indeterminate
        End If
    End Sub
    Private Sub lst_Columns_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles lst_Columns.ItemCheck
        SetSelectAllState()
    End Sub

    Private Sub cb_SelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_SelectAll.CheckedChanged
        If cb_SelectAll.CheckState = CheckState.Checked Then
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In lst_Columns.Items
                i.CheckState = CheckState.Checked
            Next
        ElseIf cb_SelectAll.CheckState = CheckState.Unchecked Then
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In lst_Columns.Items
                i.CheckState = CheckState.Unchecked
            Next
        End If
    End Sub
End Class