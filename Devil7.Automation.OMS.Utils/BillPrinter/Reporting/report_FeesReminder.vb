Imports System.Drawing.Printing

Public Class report_FeesReminder

#Region "Constructor"
    Sub New(ByVal ReportData As data_FeesReminder, ByVal PrintNameInFooter As Boolean)
        InitializeComponent()
        Me.ReportDataSource.DataSource = ReportData
        Me.DataMember = "Items"

        If PrintNameInFooter Then
            text_ThankYou.Text += vbNewLine & "[Sender.Name]"
        End If
    End Sub
#End Region

#Region "Events"
    Private Sub report_FeesReminder_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim Data As data_FeesReminder = ReportDataSource.DataSource
        If Data.Items.Count = 1 AndAlso Data.Items(0).Detail = "Opening Balance" Then
            table_Header.Visible = False
            table_Content.Visible = False
            table_Footer.Visible = False

            text_ThankYou.LocationF = New PointF(text_ThankYou.LocationF.X, 0)
        End If
    End Sub
#End Region

End Class