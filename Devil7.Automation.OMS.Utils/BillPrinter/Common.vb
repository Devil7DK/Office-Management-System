Public Module Common

#Region "Public Subs"
    Public Sub SetupReceiverColumns(ByVal LookupEdit As DevExpress.XtraEditors.LookUpEdit)
        If LookupEdit IsNot Nothing Then
            Dim VisibleColumns As String() = {"PAN", "ClientName", "Name"}
            For Each Column As DevExpress.XtraEditors.Controls.LookUpColumnInfo In LookupEdit.Properties.Columns
                If VisibleColumns.Contains(Column.FieldName) Then
                    Column.Visible = True
                Else
                    Column.Visible = False
                End If
            Next
        End If
    End Sub
#End Region

End Module
