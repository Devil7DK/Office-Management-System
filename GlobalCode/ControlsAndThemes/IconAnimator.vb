Imports System.ComponentModel

Public Class IconAnimator
    Property Enabled As Boolean
        Get
            Return Animation.Enabled
        End Get
        Set(ByVal value As Boolean)
            Animation.Enabled = value
        End Set
    End Property
    Property Interval As Integer
        Get
            Return Animation.Interval
        End Get
        Set(ByVal value As Integer)
            Animation.Interval = value
        End Set
    End Property
    Property NotifyIconControl As NotifyIcon
    Property AnimateFormIcon As Boolean
    Property AnimateNotifyIcon As Boolean
    Property Form As Form
    Dim icon_index As Integer = 0
    Private Sub Animation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Animation.Tick
        If Me.DesignMode = False Then
            If icon_index >= My.Settings.Icons.Count - 1 Then
                icon_index = 0
            Else
                If NotifyIconControl IsNot Nothing AndAlso AnimateNotifyIcon = True Then
                    NotifyIconControl.Icon = My.Resources.ResourceManager.GetObject(My.Settings.Icons(icon_index))
                End If
                If AnimateFormIcon = True Then
                    Form.Icon = My.Resources.ResourceManager.GetObject(My.Settings.Icons(icon_index))
                End If
                Try
                    GC.Collect()
                Catch ex As Exception

                End Try
                icon_index += 1
            End If
        End If
    End Sub
End Class
