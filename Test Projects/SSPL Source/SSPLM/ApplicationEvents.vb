Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            MainForm.BringToFront()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            Dim messagere As MsgBoxResult = MsgBox("Oops! Sorry for your inconvenience. An unhandled exception was occured. If you send the error report i can fix it. Do you want to Sent Error Report?" & vbNewLine & vbNewLine & "[Yes] - Sent error report and then close" & vbNewLine & "[No] - Don't sent error report just close the application" & vbNewLine & "[Cancel] - Don't Close the application.", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Sorry :-(")
            If messagere = MsgBoxResult.Yes Then
                Dim dia As New UnhandledException()
                Try
                    dia.AddDetail("ExceptionSource", e.Exception.Source)
                Catch ex As Exception

                End Try
                Try
                    dia.AddDetail("ExceptionStackTrace", e.Exception.StackTrace)
                Catch ex As Exception

                End Try
                Try
                    dia.AddDetail("ExceptionMessage", e.Exception.Message)
                Catch ex As Exception

                End Try
                Try
                    dia.AddDetail("InnerExceptionSource", e.Exception.InnerException.Source)
                Catch ex As Exception

                End Try
                Try
                    dia.AddDetail("InnerExceptionStackTrace", e.Exception.InnerException.StackTrace)
                Catch ex As Exception

                End Try
                Try
                    dia.AddDetail("InnerExceptionMessage", e.Exception.InnerException.Message)
                Catch ex As Exception

                End Try
                dia.ShowDialog()
                End
            ElseIf messagere = DialogResult.No
                End
            Else
                e.ExitApplication = False
            End If
        End Sub
    End Class
End Namespace
