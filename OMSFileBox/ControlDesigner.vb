
' ******************************************************************
'
'	If this code works it was written by:
'		Henry Minute
'		MamSoft / Manniff Computers
'		© 2008 - 2009...
'
'	if not, I have no idea who wrote it.
'
' ******************************************************************

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms.Design

Public Class ControlDesigner
    Inherits ParentControlDesigner
    Public Overrides Sub Initialize(component As System.ComponentModel.IComponent)
        MyBase.Initialize(component)

        If TypeOf Me.Control Is QueryControl Then
            Me.EnableDesignMode(DirectCast(Me.Control, QueryControl).WorkingArea1, "WorkingArea1")
            Me.EnableDesignMode(DirectCast(Me.Control, QueryControl).WorkingArea2, "WorkingArea2")
        End If
    End Sub
End Class