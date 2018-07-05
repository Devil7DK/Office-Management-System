Imports GlobalCode
Imports System.Data.SqlClient

Public Class frm_User
    Dim Mode As DialogMode
    Dim ID As Integer = -1
    Sub New(ByVal Mode As DialogMode, Optional ByVal ID As Integer = -1, Optional ByVal SelfEdit As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Mode = Mode
        Me.ID = ID
        If SelfEdit = True Then
            Panel_Permissions.Enabled = False
            txt_Name.ReadOnly = True
            cmb_UserType.Enabled = False
        End If
    End Sub
    Private Sub btn_Browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_Browse.Click
        If OFD_Image.ShowDialog = Windows.Forms.DialogResult.OK Then
            Photo.Image = Image.FromFile(OFD_Image.FileName)
        End If
    End Sub

    Private Sub btn_Permission_Add_Click(sender As System.Object, e As System.EventArgs) Handles btn_Permission_Add.Click
        Dim d As New frm_Permission(GlobalCode.DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            lst_Permissions.Items.Add(d.Permission)
        End If
    End Sub

    Private Sub btn_Permission_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Permission_Edit.Click
        If lst_Permissions.SelectedItems.Count = 1 Then
            Dim d As New frm_Permission(GlobalCode.DialogMode.Edit, DirectCast([Enum].Parse(GetType(GlobalCode.UserPermissions), lst_Permissions.SelectedItem), GlobalCode.UserPermissions))
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim i As Integer = lst_Permissions.SelectedIndex
                lst_Permissions.Items.RemoveAt(i)
                lst_Permissions.Items.Insert(i, d.Permission)
            End If
        End If
    End Sub

    Private Sub btn_Permission_Remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_Permission_Remove.Click
        Try
            lst_Permissions.Items.RemoveAt(lst_Permissions.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_User_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmb_UserType.Properties.Items.AddRange([Enum].GetValues(GetType(GlobalCode.UserType)))
        cmb_UserType.SelectedIndex = 0
        dgv_Credentials.DataSource = New System.ComponentModel.BindingList(Of Credential)
        If Mode = DialogMode.Edit AndAlso ID <> -1 Then
            Dim Usertype As String = ""
            Dim Permissions As New List(Of String)
            Dim Credentials As New System.ComponentModel.BindingList(Of Credential)
            GetUserByID(ConnectionString, ID, txt_Name.Text, Usertype, txt_Password.Text, txt_Address.Text, txt_Mobile.Text, txt_Email.Text, Permissions, Credentials, txt_Status.Text, Photo.Image)
            cmb_UserType.SelectedIndex = StringToEnum(Of UserType)(Usertype)
            For Each i As String In Permissions
                lst_Permissions.Items.Add(StringToEnum(Of UserPermissions)(i))
            Next
            dgv_Credentials.DataSource = Credentials
            txt_ConfirmPassword.Text = txt_Password.Text
        End If
    End Sub

    Private Sub btn_Credential_Add_Click(sender As System.Object, e As System.EventArgs) Handles btn_Credential_Add.Click
        Dim d As New frm_Credential(DialogMode.Add)
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Credential)).Add(d.Credential)
        End If
    End Sub

    Private Sub btn_Credential_Edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_Credential_Edit.Click
        If GridView1.SelectedRowsCount = 1 Then
            Dim row As Credential = GridView1.GetRow(GridView1.GetSelectedRows()(0))
            Dim d As New frm_Credential(DialogMode.Edit, row)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim bs = CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Credential))
                bs.Remove(row)
                bs.Add(d.Credential)
            End If
        End If
    End Sub

    Private Sub btn_Credential_Remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_Credential_Remove.Click
        If GridView1.SelectedRowsCount > 0 Then
            Dim cd As New List(Of Credential)
            For Each i As Integer In GridView1.GetSelectedRows
                cd.Add(GridView1.GetRow(i))
            Next
            For Each i As Credential In cd
                CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Credential)).Remove(i)
            Next
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Function GetPermissions() As List(Of String)
        Dim r As New List(Of String)
        For Each i As UserPermissions In lst_Permissions.Items
            r.Add(i.ToString)
        Next
        Return r
    End Function
    Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
        If txt_ConfirmPassword.Text = txt_Password.Text Then
            If Mode = DialogMode.Add Then
                NewUser(ConnectionString, Photo.Image, txt_Name.Text, cmb_UserType.SelectedItem.ToString(), txt_Password.Text, txt_Address.Text, txt_Mobile.Text, txt_Email.Text, GetPermissions(), txt_Status.Text, CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Credential)))
            ElseIf Mode = DialogMode.Edit Then
                UpdateUser(ConnectionString, ID, Photo.Image, txt_Name.Text, cmb_UserType.SelectedItem.ToString(), txt_Password.Text, txt_Address.Text, txt_Mobile.Text, txt_Email.Text, GetPermissions(), txt_Status.Text, CType(dgv_Credentials.DataSource, System.ComponentModel.BindingList(Of Credential)))
            End If
        End If
        MsgBox("User Successfully Added.", MsgBoxStyle.Information, "Done")
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class