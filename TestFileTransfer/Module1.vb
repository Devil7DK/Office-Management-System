Imports GlobalCode
Imports System.Threading

Module Module1
    Dim WithEvents TCPServer As New TCPServerEx
    Sub Main()
        TCPServer.Start(7788)
        Dim t As New Threading.Thread(New ThreadStart(Sub()
                                                          Application.Run(New Form1)
                                                      End Sub))
        t.SetApartmentState(ApartmentState.STA)
        t.Start()
        Dim t1 As New Threading.Thread(New ThreadStart(Sub()
                                                           Application.Run(New Form1)
                                                       End Sub))
        t1.SetApartmentState(ApartmentState.STA)
        t1.Start()
        Dim t2 As New Threading.Thread(New ThreadStart(Sub()
                                                           Application.Run(New Form1)
                                                       End Sub))
        t2.SetApartmentState(ApartmentState.STA)
        t2.Start()
    End Sub

    Private Sub TCPServer_CommunicationReceived(sender As Object, e As GlobalCode.CommunicatingObject) Handles TCPServer.CommunicationReceived

    End Sub

    Private Sub TCPServer_LogRaised(sender As Object, e As GlobalCode.LogObject) Handles TCPServer.LogRaised
        If e.LogType = LogTypes.Err Then
            Console.WriteLine(e.ErrorException.Message)
        Else
            Console.WriteLine(e.Message)
        End If
    End Sub
End Module
