Imports DevExpress.XtraBars
Imports Devil7.Automation.OMS.Lib

Public Class ExEditor

#Region "Variables"
    Dim Loaded As Boolean = False
    Dim TmpTitle As String
    Dim User As Objects.User

    Dim Mode As Enums.DialogMode = Enums.DialogMode.Add
    Dim TabPage As TabFormPage
    Dim TabControl As TabFormControl
#End Region

#Region "Properties/Fields"
    WithEvents Note_ As Objects.Note
    Property Note As Objects.Note
        Get
            Return Note_
        End Get
        Set(value As Objects.Note)
            Me.Note_ = value
            Me.RefreshData()
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Note As Objects.Note, ByVal TabPage As TabFormPage, ByVal TabControl As TabFormControl)
        InitializeComponent()

        Me.Note = New Objects.Note(Note.ID, Note.Title, Note.Content, Note.DateAdded, Note.DateEdited)
        Me.Mode = Enums.DialogMode.Edit
        Me.TabPage = TabPage
        Me.TabControl = TabControl

        RefreshData()
    End Sub

    Sub New(ByVal User As Objects.User, ByVal Title As String, ByVal TabPage As TabFormPage, ByVal TabControl As TabFormControl)
        InitializeComponent()

        Me.User = User
        Me.TmpTitle = Title
        Me.Mode = Enums.DialogMode.Add
        Me.TabPage = TabPage
        Me.TabControl = TabControl

        If TabPage IsNot Nothing Then TabPage.Text = TmpTitle
    End Sub
#End Region

#Region "Subs"
    Public Sub RefreshData()
        If Me.Note IsNot Nothing Then
            Loaded = False
            txt_Content.Text = Me.Note.Content
            Loaded = True

            If Me.TabPage IsNot Nothing Then
                Me.TabPage.Text = Me.Note.Title
            End If

            If Note.Saved Then
                txt_Status.Caption = "Saved"
            Else
                txt_Status.Caption = "Unsaved"
            End If

            Me.Mode = Enums.DialogMode.Edit
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Mode = Enums.DialogMode.Add Then
            Dim Note As Objects.Note = Database.Notes.AddNew(TmpTitle, txt_Content.Text, User)
            If Note IsNot Nothing Then
                Me.Note = Note
                Me.Mode = Enums.DialogMode.Edit
                DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Saved New Note.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Note.Save(User)
            DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Saved Changes to the Note.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Discard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Discard.ItemClick
        If Mode = Enums.DialogMode.Edit AndAlso Me.Note IsNot Nothing Then
            If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure..? Do you want to discard this Note...? This cannot be undone!", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Database.Notes.Remove(Me.Note.ID) Then
                    If TabControl IsNot Nothing AndAlso TabPage IsNot Nothing Then TabControl.Pages.Remove(TabPage)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Archive_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Archive.ItemClick
        If Mode = Enums.DialogMode.Edit AndAlso Me.Note IsNot Nothing Then
            If Database.Notes.Update(Me.Note.ID, True) Then
                If TabControl IsNot Nothing AndAlso TabPage IsNot Nothing Then TabControl.Pages.Remove(TabPage)
            End If
        End If
    End Sub

    Private Sub btn_EditTitle_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_EditTitle.ItemClick
        If Mode = Enums.DialogMode.Edit AndAlso Me.Note IsNot Nothing Then
            Dim Title As String = Utils.ExInputBox("Change Title", "Enter New Title for Note :", Me.Note.Title)
            If Not String.IsNullOrEmpty(Title) Then
                Me.Note.UpdateTitle(Title)
            End If
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub Note_SavedStatusChanged(sender As Object, Saved As Boolean) Handles Note_.SavedStatusChanged
        If Saved Then
            txt_Status.Caption = "Saved"
        Else
            txt_Status.Caption = "Unsaved"
        End If
    End Sub

    Private Sub Note_TitleChanged(sender As Object, Title As String) Handles Note_.TitleChanged
        If TabPage IsNot Nothing Then
            TabPage.Text = Title
        End If
    End Sub

    Private Sub txt_Content_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Content.EditValueChanged
        txt_Length.Caption = String.Format("Length : {0}", txt_Content.Text.Length)
        If Loaded Then
            If Me.Note IsNot Nothing Then Me.Note.Content = txt_Content.Text
        End If
    End Sub
#End Region

End Class
