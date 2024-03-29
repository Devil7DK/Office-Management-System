﻿Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Devil7.Automation.OMS.Lib

Public Class frm_DigitalKeys

#Region "Variables"
    Dim ProgressOverlayHandle As DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle
    Dim Edited As Boolean = False
    Dim Clients As List(Of Objects.Client)
    Dim User As Objects.User
#End Region

#Region "Properties"
    Property DigitalKeys As BindingList(Of Objects.DigitalKeyInfo)
        Get
            If gc_DigitalKeys.DataSource Is Nothing Then
                gc_DigitalKeys.DataSource = New BindingList(Of Objects.DigitalKeyInfo) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
            End If

            Return CType(gc_DigitalKeys.DataSource, BindingList(Of Objects.DigitalKeyInfo))
        End Get
        Set(value As BindingList(Of Objects.DigitalKeyInfo))
            Me.Invoke(Sub()
                          gc_DigitalKeys.DataSource = value
                          gc_DigitalKeys.RefreshDataSource()
                      End Sub)
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal User As Objects.User, ByVal Clients As List(Of Objects.Client))
        InitializeComponent()

        Me.Clients = Clients
        Me.User = User
    End Sub
#End Region

#Region "Subs"
    Sub ShowProgressOverlay()
        If InvokeRequired Then
            Invoke(Sub() ShowProgressOverlay())
        Else
            ProgressOverlayHandle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(Me)
        End If
    End Sub

    Sub CloseProgressOverlay()
        If InvokeRequired Then
            Invoke(Sub() CloseProgressOverlay())
        Else
            If ProgressOverlayHandle IsNot Nothing Then DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(ProgressOverlayHandle)
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Async Sub frm_DigitalKeys_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ShowProgressOverlay()
        Dim DigitalKeys As New BindingList(Of Objects.DigitalKeyInfo) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
        Try
            Await Threading.Tasks.Task.Run(Sub()
                                               DigitalKeys = New BindingList(Of Objects.DigitalKeyInfo)(Database.DigitalKeyInfos.GetAll(Clients, False))
                                           End Sub)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Unable to load DigitalKeys data!" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Invoke(Sub()
                       DialogResult = DialogResult.Cancel
                       Close()
                   End Sub)
        End Try
        Me.DigitalKeys = DigitalKeys
        CloseProgressOverlay()
    End Sub

    Private Sub frm_DigitalKeys_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Edited Then
            DialogResult = DialogResult.OK
        Else
            DialogResult = DialogResult.Cancel
        End If
    End Sub
#End Region

#Region "Grid Events"
    Private Async Sub gv_DigitalKeys_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gv_DigitalKeys.RowUpdated
        Try
            Await Threading.Tasks.Task.Run(Sub()
                                               Dim Row As Objects.DigitalKeyInfo = CType(e.Row, Objects.DigitalKeyInfo)
                                               If e.RowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
                                                   ShowProgressOverlay()
                                                   Row.History.Add(String.Format("Digital Key info added by {0} at {1}", User.Username, Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
                                                   Database.DigitalKeyInfos.AddNew(Row)
                                                   Edited = True
                                               ElseIf Row.ID > 0 Then
                                                   ShowProgressOverlay()
                                                   Database.DigitalKeyInfos.Update(Row)
                                                   Edited = True
                                               Else
                                                   Exit Sub
                                               End If
                                           End Sub)
        Catch ex As Exception

        Finally
            CloseProgressOverlay()
            Invoke(Sub() gc_DigitalKeys.RefreshDataSource())
        End Try
    End Sub

    Private Async Sub gv_DigitalKeys_KeyDown(sender As Object, e As KeyEventArgs) Handles gv_DigitalKeys.KeyDown
        Await Threading.Tasks.Task.Run(Sub()
                                           If e.KeyCode = Keys.Delete AndAlso gv_DigitalKeys.SelectedRowsCount > 0 Then
                                               ShowProgressOverlay()
                                               For Each i As Integer In gv_DigitalKeys.GetSelectedRows
                                                   Dim Item As Objects.DigitalKeyInfo = CType(gv_DigitalKeys.GetRow(i), Objects.DigitalKeyInfo)
                                                   Database.DigitalKeyInfos.Remove(CInt(Item.ID))
                                                   Invoke(Sub() DigitalKeys.Remove(Item))
                                                   Edited = True
                                               Next
                                               Invoke(Sub() gc_DigitalKeys.RefreshDataSource())
                                               CloseProgressOverlay()
                                           End If
                                       End Sub)
    End Sub

    Private Sub gv_DigitalKeys_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles gv_DigitalKeys.CustomRowCellEdit
        If e.Column.FieldName = "Client" Then
            Dim Editor As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Editor.DataSource = Clients
            Editor.PopulateColumns()

            Dim VisibleColumns As String() = {"PAN", "ClientName", "Name", "TradeName"}
            For Each Column As DevExpress.XtraEditors.Controls.LookUpColumnInfo In Editor.Columns
                If VisibleColumns.Contains(Column.FieldName) Then
                    Column.Visible = True
                Else
                    Column.Visible = False
                End If
            Next
            e.RepositoryItem = Editor
        End If
    End Sub

    Private Sub gv_DigitalKeys_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gv_DigitalKeys.RowCellStyle
        If e.Column.FieldName = "DaysToExpire" Then
            If e.CellValue IsNot Nothing Then
                Try
                    Dim Value As Integer = CInt(e.CellValue)
                    e.Appearance.BackColor = Utils.Misc.ColorLerp(System.Drawing.Color.Red, System.Drawing.Color.LightGreen, If(Value > 365, 1, (Value / 365)))
                Catch ex As Exception

                End Try
            End If
        ElseIf e.Column.FieldName = "Validity" Then
            If e.CellValue IsNot Nothing Then
                Try
                    Dim Value As Enums.DigitalKeyValidity = CInt(e.CellValue)
                    Select Case Value
                        Case Enums.DigitalKeyValidity.Valid
                            e.Appearance.BackColor = System.Drawing.Color.LightGreen
                        Case Enums.DigitalKeyValidity.ExpiringSoon
                            e.Appearance.BackColor = System.Drawing.Color.LightYellow
                        Case Enums.DigitalKeyValidity.ExpiringToday
                            e.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 255, 81, 81)
                        Case Enums.DigitalKeyValidity.Expired
                            e.Appearance.BackColor = System.Drawing.Color.Red
                    End Select
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub gv_DigitalKeys_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gv_DigitalKeys.CellValueChanged
        If e.RowHandle <> DevExpress.XtraGrid.GridControl.NewItemRowHandle Then
            Dim Row As Objects.DigitalKeyInfo = gv_DigitalKeys.GetRow(e.RowHandle)
            If e.Column.FieldName = "Client" Or e.Column.FieldName = "ValidFrom" Or e.Column.FieldName = "ValidTo" Or e.Column.FieldName = "Remarks" Then
                Row.History.Insert(0, String.Format("'{0}' changed to '{1}' by {2} at {3}", e.Column.FieldName, e.Value.ToString, User.Username, Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            ElseIf e.Column.FieldName = "Status" Then
                Row.History.Insert(0, String.Format("'Status' changed to '{0}' by {1} at {2}", [Enum].GetName(GetType(Enums.DigitalKeyStatus), e.Value), User.Username, Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            ElseIf e.Column.FieldName = "Possession" Then
                Row.History.Insert(0, String.Format("'Possession' changed to '{0}' by {1} at {2}", [Enum].GetName(GetType(Enums.Possession), e.Value), User.Username, Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            End If
        Else
            If e.Column.FieldName = "ValidFrom" Then
                Dim Row As Objects.DigitalKeyInfo = gv_DigitalKeys.GetRow(e.RowHandle)
                If Row.ValidTo < Date.Parse("31-12-1999") Then
                    Row.ValidTo = Row.ValidFrom.AddYears(2)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub switch_Editable_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles switch_Editable.CheckedChanged
        gv_DigitalKeys.OptionsBehavior.Editable = switch_Editable.Checked
        gv_DigitalKeys.OptionsBehavior.ReadOnly = Not switch_Editable.Checked
    End Sub
#End Region

End Class