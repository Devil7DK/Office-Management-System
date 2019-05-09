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

Public Class frm_Bill

#Region "Variabls"
    Dim ID As Integer = 0
    Dim Mode As Enums.DialogMode
    Dim ReceiversList As New List(Of Receiver)
    Dim SendersList As New List(Of Sender)
    Dim UsersList As New List(Of User)
    Dim JobsList As New List(Of Job)
#End Region

#Region "Properties"
    Property Item As Bill
    Property Templates As New List(Of Objects.BillItemTemplate)
    Property ReceiversEdited As Boolean = False
#End Region

#Region "Constructors"
    Sub New(ByVal Mode As Enums.DialogMode, ByVal TemplatesList As List(Of Objects.BillItemTemplate), ByVal ReceiversList As List(Of Receiver), ByVal SendersList As List(Of Sender), ByVal JobsList As List(Of Job), ByVal UsersList As List(Of User), Optional ByVal Item As Bill = Nothing, Optional ByVal Serial As String = "")
        InitializeComponent()

        Me.Mode = Mode
        Me.Item = Item
        If Serial <> "" Then
            Me.txt_SerialNumber.Text = Serial
        End If
        Me.SendersList = SendersList
        Me.UsersList = UsersList
        Me.JobsList = JobsList
        Me.Templates = TemplatesList
        Me.ReceiversList = ReceiversList
        If Item IsNot Nothing Then
            ID = Item.ID
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControl_Services.DataSource = New List(Of Service)
        If Templates.Count > 0 Then
            select_BillItem.Templates = Templates
            select_BillItem.RefreshTemplates()
        End If

        If ReceiversList.Count > 0 Then
            txt_Receiver.Properties.DataSource = ReceiversList
        End If
        If SendersList.Count > 0 Then
            cmb_Sender.Properties.Items.AddRange(SendersList.ToArray)
        End If
        If Mode = Enums.DialogMode.Edit Then
            Me.txt_SerialNumber.Text = Item.SerialNo
            Me.txt_Date.EditValue = Item.Date
            Try
                Dim index As Integer = -1
                For ind As Integer = 0 To cmb_Sender.Properties.Items.Count - 1
                    Dim i = cmb_Sender.Properties.Items(ind)
                    If i.Name = Item.Sender.Name Then
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
                txt_Receiver.EditValue = Item.Receiver.RID
            Catch ex As Exception

            End Try
            GridControl_Services.DataSource = Item.Services
            GridControl_Services.RefreshDataSource()
        Else
            Me.txt_Date.EditValue = Today
        End If
        Try
            If txt_Receiver.EditValue = Nothing Then
                txt_Receiver.EditValue = ReceiversList(0).RID
            End If
        Catch ex As Exception
        End Try
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
            If select_BillItem.BillItem.Trim <> "" Then
                Dim ser As New Service(select_BillItem.BillItem, txt_Fees.Value)
                Dim s = CType(GridControl_Services.DataSource, List(Of Service))
                s.Add(ser)
                GridControl_Services.RefreshDataSource()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click
        If Me.Mode = Enums.DialogMode.Add Then
            Me.Item = Database.Bills.AddNew(txt_SerialNumber.Text, txt_Date.EditValue, cmb_Sender.SelectedItem, ReceiversList.Find(Function(c) c.RID = txt_Receiver.EditValue), GridView_Services.DataSource, True)
            If Me.Item IsNot Nothing Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            Dim Result As Boolean = Database.Bills.Update(ID, txt_SerialNumber.Text, txt_Date.EditValue, cmb_Sender.SelectedItem, ReceiversList.Find(Function(c) c.RID = txt_Receiver.EditValue), GridView_Services.DataSource, True)
            If Result Then
                Me.Item = New Bill(ID, txt_SerialNumber.Text, txt_Date.EditValue, cmb_Sender.SelectedItem, ReceiversList.Find(Function(c) c.RID = txt_Receiver.EditValue), GridView_Services.DataSource)
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
    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If GridView_Services.SelectedRowsCount > 0 Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If GridView_Services.SelectedRowsCount > 0 Then
            For Each i As Integer In GridView_Services.GetSelectedRows
                Dim r = GridView_Services.GetRow(i)
                GridControl_Services.DataSource.Remove(r)
            Next
            GridControl_Services.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Receiver_Add_Click(sender As Object, e As EventArgs) Handles btn_Receiver_Add.Click
        Dim ExistingPAN As New List(Of String)
        For Each i As Receiver In ReceiversList
            ExistingPAN.Add(i.PAN)
        Next

        Dim d As New frm_AddReceiver(ExistingPAN)
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If d.Receiver IsNot Nothing Then
                txt_Receiver.Properties.DataSource.Add(d.Receiver)
                txt_Receiver.EditValue = "R" & d.Receiver.RID
            End If
        End If
    End Sub

    Private Sub txt_Receiver_Popup(sender As Object, e As EventArgs) Handles txt_Receiver.Popup
        SetupReceiverColumns(txt_Receiver)
    End Sub
#End Region

End Class