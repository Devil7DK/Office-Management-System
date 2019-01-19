Imports System.Drawing.Printing

Public Class report_Bill

#Region "Constructor"
    Sub New(ByVal ReportData As data_Bill)
        InitializeComponent()
        Me.BindingSource1.DataSource = ReportData
        Me.DataMember = "Services"
    End Sub
#End Region

#Region "Events"
    Private Sub report_EstimateBill_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim TI As data_Bill = BindingSource1.DataSource

        If TI.HasGSTIN Then
            table_Notes.Visible = True
            If Not TI.PrintTaxDetails Then PageFooter.Visible = False
        Else
            PageFooter.Visible = False
            table_Notes.Visible = False
        End If

        If TI.Sender IsNot Nothing AndAlso TI.Sender.PrintLogo Then
            pic_Logo.Visible = True
        Else
            pic_Logo.Visible = False
        End If
    End Sub
#End Region

End Class