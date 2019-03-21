Imports System.Drawing.Printing

Public Class report_BigCover

#Region "Constructor"
    Sub New(ByVal ReportData As data_Cover)
        InitializeComponent()
        Me.ObjectDataSource1.DataSource = ReportData
    End Sub
#End Region

#Region "Events"
    Private Sub report_EstimateBill_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim TI As data_Cover = ObjectDataSource1.DataSource

        txt_To_Address.Text = ""
        If TI.Receiver.AddressLine1.Trim <> "" Then txt_To_Address.Text &= "     [Receiver.AddressLine1]" & vbNewLine
        If TI.Receiver.AddressLine2.Trim <> "" Then txt_To_Address.Text &= "     [Receiver.AddressLine2]" & vbNewLine
        If TI.Receiver.PinCode.Trim <> "" Then
            txt_To_Address.Text &= "     [Receiver.District] - [Receiver.PinCode]" & vbNewLine & vbNewLine
        Else
            txt_To_Address.Text &= "     [Receiver.District]" & vbNewLine & vbNewLine
        End If
        If TI.Receiver.Mobile <> "" Then txt_To_Address.Text &= "     Mobile: [Receiver.Mobile]" & vbNewLine
        If TI.Receiver.Phone <> "" Then txt_To_Address.Text &= "     Phone: [Receiver.Phone]" & vbNewLine
    End Sub
#End Region

End Class