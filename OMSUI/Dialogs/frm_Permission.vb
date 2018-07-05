Public Class frm_Permission
    Sub New(ByVal Mode As GlobalCode.DialogMode, Optional ByVal Permission As GlobalCode.UserPermissions = GlobalCode.UserPermissions.System)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Mode = Mode
        If Mode = GlobalCode.DialogMode.Edit Then
            Me.Permission = Permission
        End If
    End Sub
    Dim Mode As GlobalCode.DialogMode = GlobalCode.DialogMode.Add
    Private Sub frm_Permission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Permission.Properties.Items.AddRange([Enum].GetValues(GetType(GlobalCode.UserPermissions)))
        cmb_Permission.SelectedIndex = 0
        If Mode = GlobalCode.DialogMode.Edit Then
            cmb_Permission.SelectedItem = Permission
        End If
    End Sub
    Property Permission As GlobalCode.UserPermissions
    Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
        Permission = cmb_Permission.SelectedItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class