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

Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports Devil7.Automation.OMS.Lib
Imports Devil7.Automation.OMS.Lib.Objects

Public Class frm_FeesReminder

#Region "Variabls"
    Dim ID As Integer = 0
    Dim Mode As Enums.DialogMode
    Dim ReceiversList As New List(Of Receiver)
    Dim SendersList As New List(Of Sender)
#End Region

#Region "Properties"
    Property Item As FeesReminder
    Property AllDetails As New List(Of String)
    Property DetailsEdited As Boolean = False
    Property ReceiversEdited As Boolean = False
#End Region

#Region "Constructors"
    Sub New(ByVal Mode As Enums.DialogMode, ByVal DetailsList As List(Of String), ByVal ReceiversList As List(Of Receiver), ByVal SendersList As List(Of Sender), Optional ByVal Item As FeesReminder = Nothing)
        InitializeComponent()

        Me.Mode = Mode
        Me.Item = Item
        Me.SendersList = SendersList
        Me.AllDetails = DetailsList
        Me.ReceiversList = ReceiversList
        If Item IsNot Nothing Then
            ID = Item.ID
        End If
    End Sub
#End Region

#Region "Subs"
    Private Sub UpdateTotal()
        Dim TotalText As String = "Total : {0} + {1} - {2} = Rs.{3}/-"

        Dim Total As Double = 0
        Dim TotalDr As Double = 0
        Dim TotalCr As Double = 0
        Total += txt_OpeningBalance.Value
        For Each i As FeesItem In gv_Details.DataSource
            If i.Effect = Enums.Effect.Dr Then
                Total += i.Fees
                TotalDr += i.Fees
            Else
                Total -= i.Fees
                TotalCr += i.Fees
            End If
        Next

        lbl_Total.Text = String.Format(TotalText, txt_OpeningBalance.Value, TotalDr, TotalCr, Total)
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc_Details.DataSource = New List(Of FeesItem)
        If AllDetails.Count > 0 Then
            cmb_Details.Properties.Items.AddRange(AllDetails.ToArray)
            If My.Settings.LastUsedDetail <> "" Then
                Dim Index As Integer = cmb_Details.Properties.Items.IndexOf(My.Settings.LastUsedDetail)
                If Index > 0 Then
                    cmb_Details.SelectedIndex = Index
                Else
                    cmb_Details.SelectedIndex = 0
                End If
            Else
                cmb_Details.SelectedIndex = 0
            End If
        End If

        If ReceiversList.Count > 0 Then
            cmb_Receiver.Properties.DataSource = ReceiversList
            SetupReceiverColumns(cmb_Receiver)
        End If
        If SendersList.Count > 0 Then
            cmb_Sender.Properties.Items.AddRange(SendersList.ToArray)
        End If
        If Mode = Enums.DialogMode.Edit And Item IsNot Nothing Then
            Try
                Dim index As Integer = -1
                For ind As Integer = 0 To cmb_Sender.Properties.Items.Count - 1
                    Dim i = cmb_Sender.Properties.Items(ind)
                    If i.Name = Item.Sender.Name AndAlso i.BillHeading = Item.Sender.BillHeading Then
                        index = ind
                        Exit For
                    End If
                Next
                If index >= 0 Then
                    cmb_Sender.SelectedIndex = index
                Else
                    cmb_Sender.Properties.Items.Add(index)
                    cmb_Sender.SelectedIndex = cmb_Sender.Properties.Items.Count - 1
                End If
            Catch ex As Exception

            End Try
            Try
                cmb_Receiver.EditValue = Item.Receiver.RID
            Catch ex As Exception

            End Try
            txt_Body.Text = Item.CustomText
            txt_OpeningBalance.Value = Item.OpeningBalance
            gc_Details.DataSource = Item.Items
            gc_Details.RefreshDataSource()
        End If
        Try
            If cmb_Sender.SelectedIndex = -1 Then
                cmb_Sender.SelectedIndex = 0
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        Try
            If cmb_Details.Text.Trim <> "" Then
                If cmb_Effect.SelectedIndex = -1 Then cmb_Effect.SelectedIndex = 0
                Dim ser As New FeesItem(txt_Date.DateTime, cmb_Details.Text, cmb_Effect.SelectedIndex, txt_Fees.Value)
                Dim s = CType(gc_Details.DataSource, List(Of FeesItem))
                s.Add(ser)
                gc_Details.RefreshDataSource()
                If AllDetails.Contains(ser.Name) = False Then
                    AllDetails.Add(cmb_Details.Text)
                    cmb_Details.Properties.Items.Clear()
                    cmb_Details.Properties.Items.AddRange(AllDetails.ToArray)
                    DetailsEdited = True
                End If
                My.Settings.LastUsedDetail = cmb_Details.Text
                My.Settings.Save()
                UpdateTotal()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click
        If Me.Mode = Enums.DialogMode.Add Then
            Me.Item = Database.FeesReminders.AddNew(cmb_Sender.SelectedItem, ReceiversList.Find(Function(c) c.RID = cmb_Receiver.EditValue), txt_OpeningBalance.Value, gv_Details.DataSource, txt_Body.Text, True)
            If Me.Item IsNot Nothing Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            Dim Result As Boolean = Database.FeesReminders.Update(ID, cmb_Sender.SelectedItem, ReceiversList.Find(Function(c) c.RID = cmb_Receiver.EditValue), txt_OpeningBalance.Value, gv_Details.DataSource, txt_Body.Text, True)
            If Result Then
                Me.Item = New FeesReminder(ID, cmb_Sender.SelectedItem, ReceiversList.Find(Function(c) c.RID = cmb_Receiver.EditValue), txt_OpeningBalance.Value, gv_Details.DataSource, txt_Body.Text)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Unable to edit bill!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "Other Events"
    Private Sub menu_Details_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles menu_Details.Opening
        If gv_Details.SelectedRowsCount > 0 Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub menu_Item_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Item_Remove.Click
        If gv_Details.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_Details.GetSelectedRows
                Dim r = gv_Details.GetRow(i)
                gc_Details.DataSource.Remove(r)
            Next
            gc_Details.RefreshDataSource()
            UpdateTotal()
        End If
    End Sub

    Private Sub txt_OpeningBalance_EditValueChanged(sender As Object, e As EventArgs) Handles txt_OpeningBalance.EditValueChanged
        UpdateTotal()
    End Sub

    Private Sub gv_Details_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gv_Details.RowUpdated
        UpdateTotal()
    End Sub

    Private Sub gv_Details_RowDeleted(sender As Object, e As RowDeletedEventArgs) Handles gv_Details.RowDeleted
        UpdateTotal()
    End Sub
#End Region

End Class