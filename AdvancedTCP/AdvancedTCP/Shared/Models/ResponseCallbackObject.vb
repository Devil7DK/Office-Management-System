
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ResponseCallbackObject
    Public Property CallBack() As [Delegate]
        Get
            Return m_CallBack
        End Get
        Set(ByVal value As [Delegate])
            m_CallBack = value
        End Set
    End Property
    Private m_CallBack As [Delegate]
    Public Property ID() As Guid
        Get
            Return m_ID
        End Get
        Set(ByVal value As Guid)
            m_ID = value
        End Set
    End Property
    Private m_ID As Guid
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
