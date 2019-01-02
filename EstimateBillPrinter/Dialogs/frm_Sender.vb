﻿'=========================================================================='
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

Public Class frm_Sender

#Region "Variables"
    Dim Mode As Enums.DialogMode
    Dim ID As Integer = 0

    Property Item As Sender
#End Region

#Region "Constructors"
    Sub New(ByVal Mode As Enums.DialogMode, Optional ByVal Item As Sender = Nothing)
        InitializeComponent()

        Me.Mode = Mode
        Me.Item = Item
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        If mode = Enums.DialogMode.Add Then
            Me.Item = Database.Senders.AddNew(txt_Name.Text, txt_Education.Text, txt_Position.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_City.Text, txt_PINCode.Text, txt_State.Text, txt_StateCode.Text, txt_PhoneNumber.Text, txt_MobileNumber.Text, txt_EMail.Text, txt_GSTIN.Text, txt_EstimateBillHeading.Text, False)
            If Me.Item IsNot Nothing Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            Dim Result As Boolean = Database.Senders.Update(ID, txt_Name.Text, txt_Education.Text, txt_Position.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_City.Text, txt_PINCode.Text, txt_State.Text, txt_StateCode.Text, txt_PhoneNumber.Text, txt_MobileNumber.Text, txt_EMail.Text, txt_GSTIN.Text, txt_EstimateBillHeading.Text, False)
            If Result Then
                Me.Item = New Sender(ID, txt_Name.Text, txt_Education.Text, txt_Position.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_City.Text, txt_PINCode.Text, txt_State.Text, txt_StateCode.Text, txt_PhoneNumber.Text, txt_MobileNumber.Text, txt_EMail.Text, txt_GSTIN.Text, txt_EstimateBillHeading.Text)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Unable to edit sender!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Sender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.mode = Enums.DialogMode.Edit Then
                ID = Item.ID
                txt_Name.Text = Item.Name
                txt_Education.Text = Item.Education
                txt_Position.Text = Item.Position
                txt_AddressLine1.Text = Item.AddressLine1
                txt_AddressLine2.Text = Item.AddressLine2
                txt_City.Text = Item.City
                txt_PINCode.Text = Item.PINCode
                txt_State.Text = Item.State
                txt_StateCode.Text = Item.StateCode
                txt_PhoneNumber.Text = Item.PhoneNo
                txt_MobileNumber.Text = Item.MobileNo
                txt_EMail.Text = Item.Email
                txt_GSTIN.Text = Item.GSTIN
                txt_EstimateBillHeading.Text = Item.EstimateBillHeading
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

End Class