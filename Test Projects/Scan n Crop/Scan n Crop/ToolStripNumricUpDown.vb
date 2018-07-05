Imports System.Windows.Forms.Design

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)> _
Public Class ToolStripNumberControl
    Inherits ToolStripControlHost
    Public Sub New()
        MyBase.New(New NumericUpDown())
    End Sub
    Protected Overrides Sub OnSubscribeControlEvents(control As Control)
        MyBase.OnSubscribeControlEvents(control)
        AddHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf OnValueChanged
    End Sub
    Protected Overrides Sub OnUnsubscribeControlEvents(control As Control)
        MyBase.OnUnsubscribeControlEvents(control)
        RemoveHandler DirectCast(control, NumericUpDown).ValueChanged, AddressOf OnValueChanged
    End Sub
    Public Event ValueChanged As EventHandler
    Public ReadOnly Property NumericUpDownControl() As NumericUpDown
        Get
            Return TryCast(Control, NumericUpDown)
        End Get
    End Property
    Public Sub OnValueChanged(sender As Object, e As EventArgs)
        RaiseEvent ValueChanged(Me, e)
    End Sub
End Class
