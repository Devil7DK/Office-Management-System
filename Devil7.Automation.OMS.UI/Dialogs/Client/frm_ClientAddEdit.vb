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
'                                                                          '
'=========================================================================='

Imports Devil7.Automation.OMS.Lib
Imports System.Data.SqlClient

Public Class frm_ClientAddEdit
    Dim Mode As Enums.DialogMode = Enums.DialogMode.Add
    Dim ID As Integer = -1
    Property Client As Objects.Client = Nothing

    Sub New(ByVal Mode As Enums.DialogMode, Optional ByVal ID As Integer = -1)
        InitializeComponent()
        Me.Mode = Mode
        Me.ID = ID
    End Sub

    Private Sub Panel_Photo_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Photo.SizeChanged
        Utils.Misc.CenterControl(Panel_Photo_Control, Enums.CenterType.Both)
    End Sub

    Private Sub frm_ClientAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Mode = Enums.DialogMode.Edit AndAlso ID > -1 Then
            Dim img As New System.IO.MemoryStream
            pic_Photo.Image.Save(img, Imaging.ImageFormat.Jpeg)
            Dim Client As Objects.Client = Database.Clients.GetClientByID(ID)
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
            txt_Aadhar.Text = Client.AadharNo
            txt_Description.Text = Client.Description
            cmb_TypeOfEngagement.SelectedItem = Client.TypeOfEngagement
            txt_TIN.Text = Client.TIN
            txt_CIN.Text = Client.CIN
            gv_PartnersDirectors.DataSource = Client.Partners
            cmb_Type.SelectedItem = Client.Type
            gv_Credentials.DataSource = Client.Credentials
            gv_Jobs.DataSource = Client.Jobs
            txt_Status.Text = Client.Status
            pic_Photo.Image = Client.Photo
            txt_GSTNo.Text = Client.GST
            txt_FileNo.Text = Client.FileNo
        Else
            Me.gv_Credentials.DataSource = New System.ComponentModel.BindingList(Of Objects.Credential)
            Me.gv_PartnersDirectors.DataSource = New System.ComponentModel.BindingList(Of Objects.Partner)
            Me.gv_Jobs.DataSource = New List(Of Objects.Job)
        End If
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

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btn_BrowseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BrowseImage.Click
        If OFD_Image.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic_Photo.Image = Image.FromFile(OFD_Image.FileName)
        End If
    End Sub
    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        If Mode = Enums.DialogMode.Add Then
            Try
                Dim item As Objects.Client = Database.Clients.AddNew(pic_Photo.Image, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem.ToString, txt_TIN.Text, txt_CIN.Text, gv_PartnersDirectors.DataSource, cmb_Type.SelectedItem.ToString, gv_Credentials.DataSource, gv_Jobs.DataSource, txt_Status.Text, txt_GSTNo.Text, txt_FileNo.Text)
                If item IsNot Nothing Then
                    Me.Client = item
                    MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Unknown error.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        ElseIf Mode = Enums.DialogMode.Edit Then
            Try
                Dim result As Boolean = Database.Clients.Update(ID, pic_Photo.Image, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem.ToString, txt_TIN.Text, txt_CIN.Text, gv_PartnersDirectors.DataSource, cmb_Type.SelectedItem.ToString, gv_Credentials.DataSource, gv_Jobs.DataSource, txt_Status.Text, txt_GSTNo.Text, txt_FileNo.Text)
                If result Then
                    MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Unknown error.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_Client_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Add.Click
        Dim d As New frm_Partner(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            If gv_PartnersDirectors.DataSource Is Nothing Then gv_PartnersDirectors.DataSource = New System.ComponentModel.BindingList(Of Objects.Partner)
            CType(gv_PartnersDirectors.DataSource, System.ComponentModel.BindingList(Of Objects.Partner)).Add(d.Partner)
            gv_PartnersDirectors.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Client_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Edit.Click
        If GridView1.SelectedRowsCount = 1 Then
            Dim row As Integer = (GridView1.GetSelectedRows()(0))
            Dim obj As Objects.Partner = TryCast(GridView1.GetRow(row), Objects.Partner)
            If obj Is Nothing Then
                Exit Sub
            End If
            Dim d As New frm_Partner(Enums.DialogMode.Edit, obj)
            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                obj.Name = d.Partner.Name
                obj.PAN = d.Partner.PAN
                obj.DOB = d.Partner.DOB
                obj.Address = d.Partner.Address
            End If
            gv_PartnersDirectors.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Client_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Remove.Click
        If GridView1.SelectedRowsCount > 0 Then
            For Each inte As Integer In GridView1.GetSelectedRows
                Dim obj As Objects.Partner = TryCast(GridView1.GetRow(inte), Objects.Partner)
                CType(gv_PartnersDirectors.DataSource, System.ComponentModel.BindingList(Of Objects.Partner)).Remove(obj)
                gv_PartnersDirectors.RefreshDataSource()
            Next
        End If
    End Sub

    Private Sub btn_Jobs_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Add.Click
        Dim d As New frm_Job_Lite(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            If gv_Jobs.DataSource Is Nothing Then gv_Jobs.DataSource = New List(Of Objects.Job)
            CType(gv_Jobs.DataSource, List(Of Objects.Job)).Add(d.Job)
            gv_Jobs.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Jobs_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Edit.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim row As Integer = (GridView2.GetSelectedRows()(0))
            Dim obj As Objects.Job = TryCast(GridView2.GetRow(row), Objects.Job)
            If obj Is Nothing Then
                Exit Sub
            End If
            Dim d As New frm_Job_Lite(Enums.DialogMode.Edit, obj)
            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                obj.ID = d.Job.ID
                obj.Name = d.Job.Name
                obj.Group = d.Job.Group
                obj.Steps = d.Job.Steps
                obj.SubGroup = d.Job.SubGroup
                obj.Templates = d.Job.Templates
                obj.Type = d.Job.Type
            End If
            gv_Jobs.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Jobs_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Remove.Click
        If GridView2.SelectedRowsCount > 0 Then
            For Each i As Integer In GridView2.GetSelectedRows
                Dim row As Integer = (i)
                Dim obj As Objects.Job = TryCast(GridView2.GetRow(row), Objects.Job)
                CType(gv_Jobs.DataSource, List(Of Objects.Job)).Remove(obj)
            Next
            gv_Jobs.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Credential_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Credential_Add.Click
        Dim d As New frm_Credential(Enums.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            If gv_Credentials.DataSource Is Nothing Then gv_Credentials.DataSource = New System.ComponentModel.BindingList(Of Objects.Credential)
            gv_Credentials.DataSource.Add(d.Credential)
            gv_Credentials.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Credential_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Credential_Edit.Click
        If GridView3.SelectedRowsCount = 1 Then
            Dim row As Integer = (GridView3.GetSelectedRows()(0))
            Dim obj As Objects.Credential = TryCast(GridView3.GetRow(row), Objects.Credential)
            If obj Is Nothing Then
                Exit Sub
            End If
            Dim d As New frm_Credential(Enums.DialogMode.Edit, obj)
            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                obj.Name = d.Credential.Name
                obj.Password = d.Credential.Password
                obj.Password2 = d.Credential.Password2
                obj.Password3 = d.Credential.Password3
                obj.Template = d.Credential.Template
                obj.Username = d.Credential.Username
            End If
            gv_Credentials.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Credential_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Credential_Remove.Click
        If GridView3.SelectedRowsCount > 0 Then
            For Each i As Integer In GridView3.GetSelectedRows
                Dim row As Integer = (i)
                Dim obj As Objects.Credential = TryCast(GridView3.GetRow(row), Objects.Credential)
                CType(gv_Credentials.DataSource, System.ComponentModel.BindingList(Of Objects.Credential)).Remove(obj)
            Next
            gv_Credentials.RefreshDataSource()
        End If
    End Sub
End Class