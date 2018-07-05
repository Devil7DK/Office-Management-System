Imports GlobalCode
Imports System.Data.SqlClient

Public Class frm_ClientAddEdit
    Dim Jobs As System.ComponentModel.BindingList(Of Job)
    Dim Mode As DialogMode = DialogMode.Add
    Dim ID As Integer = -1
    Sub New(ByVal Mode As DialogMode, ByRef Jobs As System.ComponentModel.BindingList(Of Job), Optional ByVal ID As Integer = -1)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Mode = Mode
        Me.ID = ID
        Me.Jobs = Jobs
    End Sub

    Private Sub Panel_Photo_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Photo.SizeChanged
        CenterControl(Panel_Photo_Control, CenterType.Both)
    End Sub

    Private Sub frm_ClientAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Mode = DialogMode.Edit AndAlso ID > -1 Then
            Dim img As New System.IO.MemoryStream
            pic_Photo.Image.Save(img, Imaging.ImageFormat.Jpeg)
            GetClientByID(ConnectionString, ID, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem, txt_TIN.Text, txt_CIN.Text, gv_PartnersDirectors.DataSource, cmb_Type.SelectedItem, gv_Credentials.DataSource, gv_Jobs.DataSource, txt_Status.Text, pic_Photo.Image)
        Else
            Me.gv_Credentials.DataSource = New System.ComponentModel.BindingList(Of Credential)
            Me.gv_PartnersDirectors.DataSource = New System.ComponentModel.BindingList(Of Partner)
            Me.gv_Jobs.DataSource = New System.ComponentModel.BindingList(Of Job)
        End If
        CenterControl(Panel_Photo_Control, CenterType.Both)
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
        If Mode = DialogMode.Add Then
            Try
                AddNewClient(ConnectionString, pic_Photo.Image, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem.ToString, txt_TIN.Text, txt_CIN.Text, gv_PartnersDirectors.DataSource, cmb_Type.SelectedItem.ToString, gv_Credentials.DataSource, gv_Jobs.DataSource, txt_Status.Text)
                MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        ElseIf Mode = DialogMode.Edit Then
            Try
                EditClient(ConnectionString, ID, pic_Photo.Image, txt_PAN.Text, txt_ClientName.Text, txt_FatherName.Text, txt_Mobile.Text, txt_Email.Text, txt_DOB.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_District.Text, txt_Pincode.Text, txt_Aadhar.Text, txt_Description.Text, cmb_TypeOfEngagement.SelectedItem.ToString, txt_TIN.Text, txt_CIN.Text, gv_PartnersDirectors.DataSource, cmb_Type.SelectedItem.ToString, gv_Credentials.DataSource, gv_Jobs.DataSource, txt_Status.Text)
                MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_Client_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Add.Click
        Dim d As New frm_Partner(DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            gv_PartnersDirectors.DataSource = New System.ComponentModel.BindingList(Of Partner)
            CType(gv_PartnersDirectors.DataSource, System.ComponentModel.BindingList(Of Partner)).Add(d.Partner)
        End If
    End Sub

    Private Sub btn_Client_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Edit.Click
        If GridView1.SelectedRowsCount = 1 Then
            Dim row As Integer = (GridView1.GetSelectedRows()(0))
            Dim obj As Partner = TryCast(GridView1.GetRow(row), Partner)
            If obj Is Nothing Then
                Exit Sub
            End If
            Dim d As New frm_Partner(DialogMode.Edit, obj)
            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                obj.Name = d.Partner.Name
                obj.PAN = d.Partner.PAN
                obj.DOB = d.Partner.DOB
                obj.Address = d.Partner.Address
            End If
        End If
    End Sub

    Private Sub btn_Client_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Client_Remove.Click
        If GridView1.SelectedRowsCount > 0 Then
            For Each inte As Integer In GridView1.GetSelectedRows
                Dim obj As Partner = TryCast(GridView1.GetRow(inte), Partner)
                CType(gv_PartnersDirectors.DataSource, System.ComponentModel.BindingList(Of Partner)).Remove(obj)
            Next
        End If
    End Sub

    Private Sub btn_Jobs_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Add.Click
        Dim d As New frm_Job_Lite(DialogMode.Add, Jobs)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            gv_Jobs.DataSource = New System.ComponentModel.BindingList(Of Job)
            CType(gv_Jobs.DataSource, System.ComponentModel.BindingList(Of Job)).Add(d.Job)
        End If
    End Sub

    Private Sub btn_Jobs_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Edit.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim row As Integer = (GridView2.GetSelectedRows()(0))
            Dim obj As Job = TryCast(GridView2.GetRow(row), Job)
            If obj Is Nothing Then
                Exit Sub
            End If
            Dim d As New frm_Job_Lite(DialogMode.Edit, Jobs, obj)
            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                obj.ID = d.Job.ID
                obj.JID = d.Job.JID
                obj.Name = d.Job.Name
                obj.Group = d.Job.Group
                obj.Steps = d.Job.Steps
                obj.SubGroup = d.Job.SubGroup
                obj.Templates = d.Job.Templates
                obj.Type = d.Job.Type
            End If
        End If
    End Sub

    Private Sub btn_Jobs_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobs_Remove.Click
        If GridView2.SelectedRowsCount > 0 Then
            For Each i As Integer In GridView2.GetSelectedRows
                Dim row As Integer = (i)
                Dim obj As Job = TryCast(GridView2.GetRow(row), Job)
                CType(gv_Jobs.DataSource, System.ComponentModel.BindingList(Of Job)).Remove(obj)
            Next
        End If
    End Sub

    Private Sub btn_Credential_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Credential_Add.Click
        Dim d As New frm_Credential(DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            gv_Credentials.DataSource = New System.ComponentModel.BindingList(Of Credential)
            gv_Credentials.DataSource.Add(d.Credential)
        End If
    End Sub

    Private Sub btn_Credential_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Credential_Edit.Click
        If GridView3.SelectedRowsCount = 1 Then
            Dim row As Integer = (GridView3.GetSelectedRows()(0))
            Dim obj As Credential = TryCast(GridView3.GetRow(row), Credential)
            If obj Is Nothing Then
                Exit Sub
            End If
            Dim d As New frm_Credential(DialogMode.Edit, obj)
            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                obj.Name = d.Credential.Name
                obj.Password = d.Credential.Password
                obj.Password2 = d.Credential.Password2
                obj.Password3 = d.Credential.Password3
                obj.Template = d.Credential.Template
                obj.Username = d.Credential.Username
            End If
        End If
    End Sub

    Private Sub btn_Credential_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Credential_Remove.Click
        If GridView3.SelectedRowsCount > 0 Then
            For Each i As Integer In GridView3.GetSelectedRows
                Dim row As Integer = (i)
                Dim obj As Credential = TryCast(GridView3.GetRow(row), Credential)
                CType(gv_Credentials.DataSource, System.ComponentModel.BindingList(Of Credential)).Remove(obj)
            Next
        End If
    End Sub
End Class