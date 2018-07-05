
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ClientValidatingEventArgs
    Public Property Receiver() As Receiver
        Get
            Return m_Receiver
        End Get
        Set(ByVal value As Receiver)
            m_Receiver = value
        End Set
    End Property
    Private m_Receiver As Receiver
    Public Property Request() As ValidationRequest
        Get
            Return m_Request
        End Get
        Set(ByVal value As ValidationRequest)
            m_Request = value
        End Set
    End Property
    Private m_Request As ValidationRequest
    Private ConfirmAction As Action
    Private RefuseAction As Action

    Public Sub New(ByVal confirmAction__1 As Action, ByVal refuseAction__2 As Action)
        ConfirmAction = confirmAction__1
        RefuseAction = refuseAction__2
    End Sub

    Public Sub Confirm()
        ConfirmAction()
    End Sub

    Public Sub Refuse()
        RefuseAction()
    End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
