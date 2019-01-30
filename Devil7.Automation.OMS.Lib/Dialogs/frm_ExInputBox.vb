Imports System.Windows.Forms

Public Class frm_ExInputBox

#Region "Properties/Fields"
    ReadOnly Property Value As String
        Get
            Return txt_Value.Text
        End Get
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Title As String, ByVal Prompt As String, Optional ByVal DefaultValue As String = "")
        InitializeComponent()

        Me.Text = Title
        Me.lbl_Prompt.Text = Prompt

        If DefaultValue <> "" Then
            txt_Value.Text = DefaultValue
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txt_Value_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Value.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_OK.PerformClick()
        End If
    End Sub
#End Region

End Class