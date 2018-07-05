
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class Delegates
    Public Delegate Sub ClientValidatingDelegate(ByVal args As ClientValidatingEventArgs)
    Public Delegate Sub ClientBasicDelegate(ByVal receiver As Receiver)
    Public Delegate Sub SessionRequestDelegate(ByVal client As Client, ByVal args As SessionRequestEventArguments)
    Public Delegate Sub FileUploadRequestDelegate(ByVal client As Client, ByVal args As FileUploadRequestEventArguments)
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
