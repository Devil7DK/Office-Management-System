﻿Public Class frm_Cover

#Region "Variables"
    Dim Receivers As List(Of [Lib].Objects.ClientMinimal)
#End Region

#Region "Properties"
    Property Sender As [Lib].Objects.Sender
        Get
            Return txt_Sender.SelectedItem
        End Get
        Set(value As [Lib].Objects.Sender)
            txt_Sender.SelectedItem = value
        End Set
    End Property

    Property Receiver As [Lib].Objects.ClientMinimal
        Get
            Return Receivers.Find(Function(c) c.ID = txt_Receiver.EditValue)
        End Get
        Set(value As [Lib].Objects.ClientMinimal)
            txt_Receiver.EditValue = value.ID
        End Set
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Senders As List(Of [Lib].Objects.Sender), ByVal Receivers As List(Of [Lib].Objects.ClientMinimal))
        InitializeComponent()

        Me.Receivers = Receivers

        txt_Sender.Properties.Items.AddRange(Senders.ToArray)
        txt_Receiver.Properties.DataSource = Receivers

        If Senders.Count > 0 Then txt_Sender.SelectedItem = Senders(0)
        If Receivers.Count > 0 Then txt_Receiver.EditValue = Receivers(0).ID
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If txt_Sender.SelectedItem IsNot Nothing AndAlso txt_Receiver.EditValue > 0 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
#End Region

End Class