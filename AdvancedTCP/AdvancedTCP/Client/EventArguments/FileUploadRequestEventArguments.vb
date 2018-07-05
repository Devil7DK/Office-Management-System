
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class FileUploadRequestEventArguments
    Public Property Request() As FileUploadRequest
        Get
            Return m_Request
        End Get
        Set(ByVal value As FileUploadRequest)
            m_Request = Value
        End Set
    End Property
    Private m_Request As FileUploadRequest
    Private ConfirmAction As Action
    Private RefuseAction As Action

    Public Sub New(ByVal confirmAction__1 As Action, ByVal refuseAction__2 As Action)
        ConfirmAction = confirmAction__1
        RefuseAction = refuseAction__2
    End Sub

    Public Sub Confirm(ByVal fileName As [String])
        Request.DestinationFilePath = fileName
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
