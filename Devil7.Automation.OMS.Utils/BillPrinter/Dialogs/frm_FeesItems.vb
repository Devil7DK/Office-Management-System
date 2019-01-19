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

Public Class frm_FeesItems

#Region "Form Events"
    Private Sub frm_FeesItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Worker.IsBusy Then Worker.RunWorkerAsync()
    End Sub
#End Region

#Region "Other Events"
    Private Sub gv_FeesItems_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv_FeesItems.KeyUp
        If e.KeyCode = Keys.Delete Then
            If gv_FeesItems.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_FeesItems.GetSelectedRows
                    Dim row = gv_FeesItems.GetRow(i)
                    CType(gc_FeesItems.DataSource, List(Of String)).Remove(row)
                Next
                gc_FeesItems.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel_Loading.Visible = True
                      btn_Save.Enabled = False
                      btn_Refresh.Enabled = False
                  End Sub)
        Dim List As List(Of String) = Database.FeesItems.Load(False)
        Me.Invoke(Sub()
                      gc_FeesItems.DataSource = List
                  End Sub)
        Me.Invoke(Sub()
                      ProgressPanel_Loading.Visible = False
                      btn_Save.Enabled = True
                      btn_Refresh.Enabled = True
                  End Sub)
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Save_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        Try
            Database.FeesItems.Save(gc_FeesItems.DataSource, True)
            MsgBox("Successfully Saved Items", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            DialogResult = DialogResult.OK
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Refresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not Worker.IsBusy Then Worker.RunWorkerAsync()
    End Sub
#End Region

End Class