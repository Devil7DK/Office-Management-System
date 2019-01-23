'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports Devil7.Automation.OMS.Lib
Imports Devil7.Automation.OMS.Lib.Objects

Public Class frm_FromAddresses

#Region "Subs"
    Function Details() As List(Of ExMailAddress)
        Return CType(gc_Addresses.DataSource, List(Of ExMailAddress))
    End Function
#End Region

#Region "Form Events"
    Private Sub frm_FromAddresses_Load(ByVal ExMailAddress As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Not Worker.IsBusy Then Worker.RunWorkerAsync()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Refresh_ItemClick(ByVal ExMailAddress As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not Worker.IsBusy Then Worker.RunWorkerAsync()
    End Sub

    Private Sub btn_Add_ItemClick(ByVal ExMailAddress As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        Dim d As New frm_FromAddress(Enums.DialogMode.Add)
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Details.Add(d.FromAddress)
            gc_Addresses.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(ByVal ExMailAddress As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Edit.ItemClick
        If gv_Addresses.SelectedRowsCount = 1 Then
            Dim d As New frm_FromAddress(Enums.DialogMode.Edit)
            d.FromAddress = gv_Addresses.GetRow(gv_Addresses.GetSelectedRows(0))
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                gc_Addresses.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(ByVal ExMailAddress As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
        Try
            If gv_Addresses.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_Addresses.GetSelectedRows
                    Dim r As ExMailAddress = gv_Addresses.GetRow(i)
                    Details.Remove(r)
                Next
                gc_Addresses.RefreshDataSource()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Worker_DoWork(ByVal ExMailAddress As Object, ByVal e As ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel_Loading.Visible = True
                      btn_Refresh.Enabled = False
                      btn_Add.Enabled = False
                      btn_Edit.Enabled = False
                      btn_Remove.Enabled = False
                  End Sub)
        Dim List As List(Of ExMailAddress) = Database.EMailAddresses.Load(True)
        Me.Invoke(Sub()
                      gc_Addresses.DataSource = List
                  End Sub)
        Me.Invoke(Sub()
                      ProgressPanel_Loading.Visible = False
                      btn_Refresh.Enabled = True
                      btn_Add.Enabled = True
                      btn_Edit.Enabled = True
                      btn_Remove.Enabled = True
                  End Sub)
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Database.EMailAddresses.Save(gc_Addresses.DataSource, True) > 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Saved E-Mail Addresses.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Unable to Save E-Mail Addresses!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

End Class