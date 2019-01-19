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
    Dim ReceiversList As New List(Of ClientMinimal)
    Dim SendersList As New List(Of Sender)
#End Region

#Region "Properties"
    Property Item As Bill
    Property AllServices As New List(Of String)
    Property ServicesEdited As Boolean = False
    Property ReceiversEdited As Boolean = False
#End Region

#Region "Constructors"
    Sub New(ByVal Mode As Enums.DialogMode, ByVal ServicesList As List(Of String), ByVal ReceiversList As List(Of ClientMinimal), ByVal SendersList As List(Of Sender), Optional ByVal Item As Bill = Nothing, Optional ByVal Serial As String = "")
        InitializeComponent()

        Me.Mode = Mode
        Me.Item = Item
        If Serial <> "" Then
            Me.txt_SerialNumber.Text = Serial
        End If
        Me.SendersList = SendersList
        Me.AllServices = ServicesList
        Me.ReceiversList = ReceiversList
        If Item IsNot Nothing Then
            ID = Item.ID
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControl_Services.DataSource = New List(Of Service)
        If AllServices.Count > 0 Then
            cmb_Services.Properties.Items.AddRange(AllServices.ToArray)
            If My.Settings.LastUsedService <> "" Then
                Dim Index As Integer = cmb_Services.Properties.Items.IndexOf(My.Settings.LastUsedService)
                If Index > 0 Then
                    cmb_Services.SelectedIndex = Index
                Else
                    cmb_Services.SelectedIndex = 0
                End If
            Else
                cmb_Services.SelectedIndex = 0
            End If
        End If

        If ReceiversList.Count > 0 Then
            cmb_Receiver.Properties.Items.AddRange(ReceiversList.ToArray)
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
                Dim index As Integer = -1
                For ind As Integer = 0 To cmb_Receiver.Properties.Items.Count - 1
                    Dim i As ClientMinimal = cmb_Receiver.Properties.Items(ind)
                    If i.ID = Item.Receiver.ID Then
                        index = ind
                    End If
                Next
                If index >= 0 Then
                    cmb_Receiver.SelectedIndex = index
                Else
                    cmb_Receiver.Properties.Items.Add(New ClientMinimal(Item.Receiver.ID, Item.Receiver.Name, Item.Receiver.PAN))
                    cmb_Receiver.SelectedIndex = cmb_Receiver.Properties.Items.Count - 1
                End If
            Catch ex As Exception

            End Try
            GridControl_Services.DataSource = Item.Services
            GridControl_Services.RefreshDataSource()
        Else
            Me.txt_Date.EditValue = Today
        End If
        Try
            If cmb_Receiver.SelectedIndex = -1 Then
                cmb_Receiver.SelectedIndex = 0
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
            If cmb_Services.Text.Trim <> "" Then
                Dim ser As New Service(cmb_Services.Text, txt_Fees.Value)
                Dim s = CType(GridControl_Services.DataSource, List(Of Service))
                s.Add(ser)
                GridControl_Services.RefreshDataSource()
                If AllServices.Contains(ser.Name) = False Then
                    AllServices.Add(cmb_Services.Text)
                    cmb_Services.Properties.Items.Clear()
                    cmb_Services.Properties.Items.AddRange(AllServices.ToArray)
                    ServicesEdited = True
                End If
                My.Settings.LastUsedService = cmb_Services.Text
                My.Settings.Save()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click
        If Me.Mode = Enums.DialogMode.Add Then
            Me.Item = Database.Bills.AddNew(txt_SerialNumber.Text, txt_Date.EditValue, cmb_Sender.SelectedItem, cmb_Receiver.SelectedItem, GridView_Services.DataSource, True)
            If Me.Item IsNot Nothing Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            Dim Result As Boolean = Database.Bills.Update(ID, txt_SerialNumber.Text, txt_Date.EditValue, cmb_Sender.SelectedItem, cmb_Receiver.SelectedItem, GridView_Services.DataSource, True)
            If Result Then
                Me.Item = New Bill(ID, txt_SerialNumber.Text, txt_Date.EditValue, cmb_Sender.SelectedItem, cmb_Receiver.SelectedItem, GridView_Services.DataSource)
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
#End Region

End Class