Imports System.ComponentModel
<Designer(GetType(ControlDesigner))> _
Public Class QueryControl
    <Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property WorkingArea1() As Panel
        Get
            Return Me.Panel1
        End Get
    End Property
    <Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property WorkingArea2() As Panel
        Get
            Return Me.Panel2
        End Get
    End Property
End Class
