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

Public Class frm_Senders

#Region "Subs"
    Function Details() As List(Of Sender)
        Return CType(GridControl_Senders.DataSource, List(Of Sender))
    End Function
#End Region

#Region "Form Events"
    Private Sub frm_Senders_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Not Worker.IsBusy Then Worker.RunWorkerAsync()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Refresh_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not Worker.IsBusy Then Worker.RunWorkerAsync()
    End Sub

    Private Sub btn_Add_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        Dim d As New frm_Sender(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            Details.Add(d.Item)
            GridControl_Senders.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Edit.ItemClick
        If GridView_Senders.SelectedRowsCount = 1 Then
            Dim r = GridView_Senders.GetRow(GridView_Senders.GetSelectedRows(0))
            Dim index As Integer = Details.IndexOf(r)
            Dim n As New frm_Sender(Enums.DialogMode.Edit, r)
            If n.ShowDialog = Windows.Forms.DialogResult.OK Then
                Details.Remove(r)
                Details.Insert(index, n.Item)
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
        Try
            If GridView_Senders.SelectedRowsCount > 0 Then
                For Each i As Integer In GridView_Senders.GetSelectedRows
                    Dim r As Sender = GridView_Senders.GetRow(i)
                    If Database.Senders.Remove(r.ID) > 0 Then
                        Details.Remove(r)
                    Else
                        MsgBox("Error in deleting sender.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                    End If
                Next
                GridControl_Senders.RefreshDataSource()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel_Loading.Visible = True
                      btn_Refresh.Enabled = False
                      btn_Add.Enabled = False
                      btn_Edit.Enabled = False
                      btn_Remove.Enabled = False
                  End Sub)
        Dim List As List(Of Sender) = Database.Senders.GetAll(False)
        Me.Invoke(Sub()
                      GridControl_Senders.DataSource = List
                  End Sub)
        Me.Invoke(Sub()
                      ProgressPanel_Loading.Visible = False
                      btn_Refresh.Enabled = True
                      btn_Add.Enabled = True
                      btn_Edit.Enabled = True
                      btn_Remove.Enabled = True
                  End Sub)
    End Sub
#End Region

End Class