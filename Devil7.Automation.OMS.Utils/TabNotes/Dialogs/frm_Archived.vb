Imports DevExpress.Data
Imports DevExpress.XtraBars
Imports Devil7.Automation.OMS.Lib

Public Class frm_Archived

#Region "Variables"
    Dim User As Objects.User
#End Region

#Region "Constructor"
    Sub New(ByVal User As Objects.User)
        InitializeComponent()
        Me.User = User
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Archived_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_UnArchive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_UnArchive.ItemClick
        If gv_Archived.SelectedRowsCount > 0 Then
            Dim Items2Remove As New List(Of Objects.Note)
            For Each i As Integer In gv_Archived.GetSelectedRows
                Dim Note As Objects.Note = CType(gv_Archived.GetRow(i), Objects.Note)
                If Database.Notes.Update(Note.ID, False) Then
                    Items2Remove.Add(Note)
                End If
            Next
            For Each Note As Objects.Note In Items2Remove
                CType(gc_Archived.DataSource, List(Of Objects.Note)).Remove(Note)
            Next
            If Items2Remove.Count > 0 Then
                gc_Archived.RefreshDataSource()
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
        If gv_Archived.SelectedRowsCount > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure..? Do you want to removed selected notes...? This cannot be undone!", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Items2Remove As New List(Of Objects.Note)
                For Each i As Integer In gv_Archived.GetSelectedRows
                    Dim Note As Objects.Note = CType(gv_Archived.GetRow(i), Objects.Note)
                    If Database.Notes.Remove(Note.ID) Then
                        Items2Remove.Add(Note)
                    End If
                Next
                For Each Note As Objects.Note In Items2Remove
                    CType(gc_Archived.DataSource, List(Of Objects.Note)).Remove(Note)
                Next
                If Items2Remove.Count > 0 Then
                    gc_Archived.RefreshDataSource()
                End If
            End If
        End If
    End Sub

    Private Sub btn_ShowPreviewPane_DownChanged(sender As Object, e As ItemClickEventArgs) Handles btn_ShowPreviewPane.DownChanged
        If btn_ShowPreviewPane.Down Then
            SplitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        Else
            SplitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub Loader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader.DoWork
        Me.Invoke(Sub()
                      ProgressPanel.Visible = True
                      MainBar.Visible = False
                  End Sub)

        Dim ArchivedNotes As List(Of Objects.Note) = Database.Notes.GetAll(User, True)

        Me.Invoke(Sub()
                      gc_Archived.DataSource = ArchivedNotes
                      gc_Archived.RefreshDataSource()
                      ProgressPanel.Visible = False
                      MainBar.Visible = True
                  End Sub)
    End Sub

    Private Sub gv_Archived_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gv_Archived.SelectionChanged
        If gv_Archived.SelectedRowsCount > 0 Then
            Dim Note As Objects.Note = CType(gv_Archived.GetRow(gv_Archived.GetSelectedRows(gv_Archived.SelectedRowsCount - 1)), Objects.Note)

            txt_Title.Text = Note.Title
            txt_DateAdded.Text = Note.DateAdded.ToString("dd/MM/yyyy hh:mm")
            txt_DateEdited.Text = Note.DateEdited.ToString("dd/MM/yyyy hh:mm")
            txt_Content.Text = Note.Content
        End If
    End Sub
#End Region

End Class