Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Devices

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            Try
                ApMainForm.CheckNet()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            ApMainForm.Show()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Try
                Dim err As String = "Message : " & e.Exception.Message & vbNewLine & "StackTrace : " & e.Exception.StackTrace & vbNewLine & "Source : " & e.Exception.Source
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Desktop & "\SSPLM")
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\SSPLM\AutoBackupErrorLog_" & Now.Year & "-" & Now.Month & "-" & Now.Day & "-" & Now.Hour & "-" & Now.Minute, err, True)
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace
