Imports DevExpress.XtraBars
Imports Devil7.Automation.OMS.Lib

Public Class frm_Main

#Region "Variables"
    Dim User As Objects.User
    Dim LoginInstance As frm_Login
#End Region

#Region "Constructor"
    Sub New(ByVal User As Objects.User, ByVal LoginInstance As frm_Login)
        InitializeComponent()

        Me.User = User
        Me.LoginInstance = LoginInstance
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoginInstance.BeginInvoke(Sub() LoginInstance.Close())
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_ViewArchived_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_ViewArchived.ItemClick
        Dim D As New frm_Archived(User)
        If D.ShowDialog = DialogResult.OK Then
            If Not Loader.IsBusy Then Loader.RunWorkerAsync()
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub TabFormControl1_PageCreated(sender As Object, e As PageCreatedEventArgs) Handles TabFormControl1.PageCreated
        If e.Page.ContentContainer.Controls.Count < 1 Then
            Me.Invoke(Sub() e.Page.ContentContainer.Controls.Add(New ExEditor(User, "Untitled", e.Page, TabFormControl1) With {.Dock = DockStyle.Fill}))
        End If
    End Sub

    Private Sub Loader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader.DoWork
        Me.Invoke(Sub()
                      TabFormControl1.Pages.Clear()
                      TabFormControl1.ShowAddPageButton = False
                      ProgressPanel.Visible = True
                  End Sub)

        Dim Notes As List(Of Objects.Note) = Database.Notes.GetAll(User, False)
        For Each Note As Objects.Note In Notes
            Me.Invoke(Sub()
                          TabFormControl1.AddNewPage()
                          Dim Page As TabFormPage = TabFormControl1.Pages(TabFormControl1.Pages.Count - 1)

                          Dim Editor As ExEditor = Nothing
                          For Each i As Control In Page.ContentContainer.Controls
                              If TypeOf i Is ExEditor Then
                                  Editor = CType(i, ExEditor)
                                  Exit For
                              End If
                          Next
                          If Editor Is Nothing Then
                              Editor = New ExEditor(Note, Page, TabFormControl1) With {.Dock = DockStyle.Fill}
                              Page.ContentContainer.Controls.Add(Editor)
                          Else
                              Editor.Note = Note
                              Editor.RefreshData
                          End If
                      End Sub)
        Next

        Me.Invoke(Sub()
                      TabFormControl1.ShowAddPageButton = True
                      ProgressPanel.Visible = False
                  End Sub)
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not Loader.IsBusy Then Loader.RunWorkerAsync()
    End Sub
#End Region

End Class
