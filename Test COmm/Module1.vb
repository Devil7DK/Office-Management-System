Imports System.Threading

Public Class Module1
    Public Shared Sub Main()
        Dim t As New Threading.Thread(New ThreadStart(Sub()
                                                          Application.Run(New Form1)
                                                      End Sub))
        t.Start()
        Dim t1 As New Threading.Thread(New ThreadStart(Sub()
                                                           Application.Run(New Form2)
                                                       End Sub))
        t1.Start()
        Dim t2 As New Threading.Thread(New ThreadStart(Sub()
                                                           Application.Run(New Form2)
                                                       End Sub))
        t2.Start()
    End Sub
End Class
