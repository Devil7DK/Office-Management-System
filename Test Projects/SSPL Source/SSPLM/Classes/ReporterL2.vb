Public Class ReporterL2
    Dim ReportNumber As String
    Dim PatientName As String
    Dim Age As String
    Dim Sex As String
    Dim ReferedBy As String
    Dim ReceivedDate As String
    Dim ReportedDate As String
    Dim HospitalNumber As String
    Dim ReportResult As String
    Dim PatientDetails As String
    Dim RefferedByAdd As String
    Sub New(ByVal ReportNumber As String, ByVal PatientName As String, ByVal PatientDetails As String, ByVal ReferedBy As String, ByVal ReferredByAdd As String, ByVal ReceivedDate As String, ByVal ReportedDate As String, ByVal Sex As String, ByVal Age As String, ByVal HospitalNumber As String, ByVal ReportResult As String)
        InitializeComponent()
        Me.ReportNumber = ReportNumber
        Me.ReceivedDate = ReceivedDate
        Me.ReportedDate = ReportedDate
        Me.PatientName = PatientName
        Me.Age = Age
        Me.Sex = Sex
        Me.ReferedBy = ReferedBy
        Me.RefferedByAdd = ReferredByAdd
        Me.HospitalNumber = HospitalNumber
        Me.ReportResult = ReportResult
        Me.Printer.DocumentName = "Report - " & PatientName
        Me.PatientDetails = PatientDetails
    End Sub
    Property DetailsFont As Font
    Property ResultFont As Font
    Property DefaultPageSettings As Printing.PageSettings
        Get
            Return Printer.DefaultPageSettings
        End Get
        Set(value As Printing.PageSettings)
            Printer.DefaultPageSettings = value
        End Set
    End Property
    Sub Print()
        Printer.Print()
    End Sub
    Sub PrintPreview()
        Dim p As New PrintPreviewDialog
        p.Document = Printer
        p.ShowDialog()
    End Sub
    Property DocumentName As String
        Get
            Return Printer.DocumentName
        End Get
        Set(value As String)
            Printer.DocumentName = value
        End Set
    End Property
    Property PrinterSettings As Printing.PrinterSettings
        Get
            Return Printer.PrinterSettings
        End Get
        Set(value As Printing.PrinterSettings)
            Printer.PrinterSettings = value
        End Set
    End Property

    Private Sub Printer_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Printer.PrintPage
        e.Graphics.DrawString(ReportNumber, New Font(DetailsFont, FontStyle.Bold), Brushes.Black, My.Settings.ReportNumLoc)
        e.Graphics.DrawString(ReportedDate, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, My.Settings.ReportDateLoc)
        e.Graphics.DrawString(PatientName, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, My.Settings.ReportNameLoc)
        Dim pd As Integer = e.Graphics.MeasureString(PatientName, New Font(DetailsFont, FontStyle.Regular)).Height
        e.Graphics.DrawString(PatientDetails, New Font(DetailsFont.FontFamily, DetailsFont.Size - 3, FontStyle.Regular), Brushes.Black, New Point(My.Settings.ReportNameLoc.X, My.Settings.ReportNameLoc.Y + pd))
        e.Graphics.DrawString(Age, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, My.Settings.ReportAgeLoc)
        e.Graphics.DrawString(Sex, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, My.Settings.ReportSexLoc)
        e.Graphics.DrawString(ReferedBy, New Font(DetailsFont, FontStyle.Bold), Brushes.Black, My.Settings.ReportReferredLoc)
        Dim rd As Integer = e.Graphics.MeasureString(ReferedBy, New Font(DetailsFont, FontStyle.Bold)).Height
        e.Graphics.DrawString(RefferedByAdd, New Font(DetailsFont.FontFamily, DetailsFont.Size, FontStyle.Regular), Brushes.Black, New Point(My.Settings.ReportReferredLoc.X, My.Settings.ReportReferredLoc.Y + rd))
        e.Graphics.DrawString(HospitalNumber, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, My.Settings.ReportHospitalLoc)
        e.Graphics.DrawString(ReceivedDate, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, My.Settings.ReportReceivedDate)
        Dim s As SizeF = e.Graphics.MeasureString(ReportResult, New Font(DetailsFont, FontStyle.Regular), e.MarginBounds.Width)
        Dim rect As New RectangleF(My.Settings.ReportResultLoc, s)
        e.Graphics.DrawString(ReportResult, New Font(DetailsFont, FontStyle.Regular), Brushes.Black, rect)
        e.HasMorePages = False
    End Sub
End Class
