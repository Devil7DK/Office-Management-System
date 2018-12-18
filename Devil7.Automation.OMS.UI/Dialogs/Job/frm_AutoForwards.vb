Imports Devil7.Automation.OMS.Lib.Objects

Public Class frm_AutoForwards

#Region "Properties"
    Property AutoForward As AutoForward
#End Region

#Region "Subs"
    Sub New(ByVal Steps As List(Of String), ByVal Users As List(Of User))
        InitializeComponent()
        cmb_Steps.Properties.Items.AddRange(Steps.ToArray)
        cmb_Users.Properties.Items.AddRange(Users.ToArray)
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Me.AutoForward = New AutoForward(cmb_Steps.SelectedItem, cmb_Users.SelectedItem.ID)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

End Class