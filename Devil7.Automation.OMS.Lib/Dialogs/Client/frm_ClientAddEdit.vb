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
'                                                                          '
'=========================================================================='

Imports Devil7.Automation.OMS.Lib.Objects
Imports System.Drawing
Imports System.Windows.Forms

Namespace Dialogs
    Public Class frm_ClientAddEdit

#Region "Variables"
        Dim Mode As Enums.DialogMode = Enums.DialogMode.Add
        Dim Jobs As List(Of Job)
        Dim Users As List(Of User)
        Dim ID As Integer = -1
#End Region

#Region "Properties"
        Property Client As Objects.Client = Nothing
#End Region

#Region "Constructor"
        Sub New(ByVal Mode As Enums.DialogMode, ByVal Jobs As List(Of Job), ByVal Users As List(Of User), Optional ByVal ID As Integer = -1)
            InitializeComponent()
            Me.Mode = Mode
            Me.Jobs = Jobs
            Me.Users = Users
            Me.ID = ID
        End Sub
#End Region

#Region "Form Events"
        Private Sub frm_ClientAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Mode = Enums.DialogMode.Edit AndAlso ID > -1 Then
                Dim img As New System.IO.MemoryStream
                pic_Photo.Image.Save(img, Imaging.ImageFormat.Jpeg)
                Dim Client As Objects.Client = Database.Clients.GetClientByID(ID, Jobs, Users)
                txt_PAN.Text = Client.PAN
                txt_ClientName.Text = Client.Name
                txt_FatherName.Text = Client.FatherName
                txt_Mobile.Text = Client.Mobile
                txt_Email.Text = Client.Email
                txt_DOB.Text = Client.DOB
                txt_AddressLine1.Text = Client.AddressLine1
                txt_AddressLine2.Text = Client.AddressLine2
                txt_District.Text = Client.District
                txt_Pincode.Text = Client.PinCode
                txt_State.SelectedItem = Client.State

                txt_Aadhar.Text = Client.AadharNo
                txt_Description.Text = Client.Description
                cmb_TypeOfEngagement.SelectedItem = Client.TypeOfEngagement
                txt_TIN.Text = Client.TIN
                txt_CIN.Text = Client.CIN
                lst_Partners.ListData = Client.Partners
                cmb_Type.SelectedItem = Client.Type
                lst_Credentials.ListData = Client.Credentials
                lst_Jobs.ListData = Client.Jobs
                txt_Status.Text = Client.Status
                pic_Photo.Image = Client.Photo
                txt_GSTNo.Text = Client.GST
                txt_FileNo.Text = Client.FileNo
            Else
                cmb_TypeOfEngagement.SelectedIndex = 0
                txt_State.SelectedIndex = 32

                lst_Credentials.ListData = New List(Of Credential)
                lst_Partners.ListData = New List(Of Partner)
                lst_Jobs.ListData = New List(Of JobUser)
            End If
            Utils.Misc.CenterControl(Panel_Photo_Control, Enums.CenterType.Both)
        End Sub
#End Region

#Region "Button Events"
#Region "Credential"
        Private Sub lst_Credentials_OnAdd(List As List(Of Credential)) Handles lst_Credentials.OnAdd
            Dim d As New frm_Credential(Enums.DialogMode.Add)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                List.Add(d.Credential)
                lst_Credentials.RefreshData()
            End If
        End Sub

        Private Sub lst_Credentials_OnEdit(Item As Credential) Handles lst_Credentials.OnEdit
            Dim d As New frm_Credential(Enums.DialogMode.Edit, Item)
            If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Item.Name = d.Credential.Name
                Item.Password = d.Credential.Password
                Item.Password2 = d.Credential.Password2
                Item.Password3 = d.Credential.Password3
                Item.Template = d.Credential.Template
                Item.Username = d.Credential.Username
            End If
            lst_Credentials.RefreshData()
        End Sub
#End Region
#Region "Other"
        Private Sub btn_BrowseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BrowseImage.Click
            If OFD_Image.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                pic_Photo.Image = Image.FromFile(OFD_Image.FileName)
            End If
        End Sub
#End Region
#Region "Partner"
        Private Sub lst_Partners_OnAdd(List As List(Of Partner)) Handles lst_Partners.OnAdd
            Dim d As New frm_Partner(Enums.DialogMode.Add)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                List.Add(d.Partner)
                lst_Partners.RefreshData()
            End If
        End Sub

        Private Sub lst_Partners_OnEdit(Item As Partner) Handles lst_Partners.OnEdit
            Dim d As New frm_Partner(Enums.DialogMode.Edit, Item)
            If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Item.Name = d.Partner.Name
                Item.PAN = d.Partner.PAN
                Item.DOB = d.Partner.DOB
                Item.Address = d.Partner.Address
            End If
            lst_Partners.RefreshData()
        End Sub
#End Region
#Region "Jobs"
        Private Sub lst_Jobs_OnAdd(List As List(Of JobUser)) Handles lst_Jobs.OnAdd
            Dim d As New frm_JobUser(Enums.DialogMode.Add, Jobs, Users)
            If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                List.Add(d.JobUser)
                lst_Jobs.RefreshData()
            End If
        End Sub

        Private Sub lst_Jobs_OnEdit(Item As JobUser) Handles lst_Jobs.OnEdit
            Dim d As New frm_JobUser(Enums.DialogMode.Edit, Jobs, Users, Item)
            If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Item.Job = d.JobUser.Job
                Item.User = d.JobUser.User
                lst_Jobs.RefreshData()
            End If
        End Sub
#End Region
#Region "Dialog"
        Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
            If Mode = Enums.DialogMode.Add Then
                Try
                    Dim item As Objects.Client = Database.Clients.AddNew(pic_Photo.Image, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Phone.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_State.SelectedItem, txt_State.SelectedIndex, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem.ToString, txt_TIN.Text, txt_CIN.Text, lst_Partners.ListData, cmb_Type.SelectedItem.ToString, lst_Credentials.ListData, lst_Jobs.ListData, txt_Status.Text, txt_GSTNo.Text, txt_FileNo.Text)
                    If item IsNot Nothing Then
                        Me.Client = item
                        DevExpress.XtraEditors.XtraMessageBox.Show("Process Completed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf Mode = Enums.DialogMode.Edit Then
                Try
                    Dim result As Boolean = Database.Clients.Update(ID, pic_Photo.Image, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Phone.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_State.SelectedItem, txt_State.SelectedIndex, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem, txt_TIN.Text, txt_CIN.Text, lst_Partners.ListData, cmb_Type.SelectedItem, lst_Credentials.ListData, lst_Jobs.ListData, txt_Status.Text, txt_GSTNo.Text, txt_FileNo.Text)
                    If result Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("Process Completed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
#End Region
#End Region

#Region "Other Events"
        Private Sub Panel_Photo_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Photo.SizeChanged
            Utils.Misc.CenterControl(Panel_Photo_Control, Enums.CenterType.Both)
        End Sub

        Private Sub txt_PAN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PAN.TextChanged
            Try
                txt_PAN.Text = txt_PAN.Text.ToUpper
                Dim c As String = txt_PAN.Text.ToString.Substring(4, 1)
                If c = "A" Then
                    cmb_Type.SelectedIndex = 0
                ElseIf c = "B" Then
                    cmb_Type.SelectedIndex = 1
                ElseIf c = "C" Then
                    cmb_Type.SelectedIndex = 2
                ElseIf c = "F" Then
                    cmb_Type.SelectedIndex = 3
                ElseIf c = "G" Then
                    cmb_Type.SelectedIndex = 4
                ElseIf c = "H" Then
                    cmb_Type.SelectedIndex = 5
                ElseIf c = "L" Then
                    cmb_Type.SelectedIndex = 6
                ElseIf c = "J" Then
                    cmb_Type.SelectedIndex = 7
                ElseIf c = "P" Then
                    cmb_Type.SelectedIndex = 8
                ElseIf c = "T" Then
                    cmb_Type.SelectedIndex = 9
                ElseIf c = "K" Then
                    cmb_Type.SelectedIndex = 10
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txt_State_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_State.SelectedIndexChanged
            txt_StateCode.Text = txt_State.SelectedIndex + 1
        End Sub
#End Region
    End Class
End Namespace