Imports GlobalCode
Public Class frm_Job_Lite
    Dim Mode As DialogMode = DialogMode.Add
    Sub New(ByVal Type As DialogMode, ByVal Jobs As System.ComponentModel.BindingList(Of Job), Optional ByRef Job_ As Job = Nothing)
        InitializeComponent()
        Me.Mode = Type
        Me.Job = Job_
        Try
            cmb_Name.Items.AddRange(Jobs.ToArray)
        Catch ex As Exception

        End Try
    End Sub
    Property Job As Job
    Private Sub frm_Job_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Mode = DialogMode.Edit AndAlso Job IsNot Nothing Then
            For Each i As Job In cmb_Name.Items
                If i.JID = Job.JID Then
                    cmb_Name.SelectedItem = i
                    Exit For
                End If
            Next
        End If
        cmb_Name.Focus()
    End Sub

    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Me.Job = cmb_Name.SelectedItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class