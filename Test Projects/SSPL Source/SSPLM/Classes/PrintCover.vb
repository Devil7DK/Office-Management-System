Imports System.Data.OleDb

Public Class PrintCover
    Inherits ComponentModel.Component
    Dim ConnectionString As String = ""
    Dim ps As Printing.PrinterSettings
    Dim ReportNumber As String = ""
    Dim PatienName As String = ""
    Dim DoctorName As String
    Dim Address As String = ""
    Friend WithEvents CoverPrinter As Printing.PrintDocument
    Friend WithEvents PrintPreviewDia As PrintPreviewDialog
    Dim PATID As String
    Sub New(ByVal PATID As String, ByVal ConnectionString As String, ByVal PrinterSet As Printing.PrinterSettings)
        InitializeComponent()
        Me.ConnectionString = ConnectionString
        Me.PATID = PATID
        ps = PrinterSet
        LoadDataSource()
    End Sub
    Sub New(ByVal PATID As String, ByVal ConnectionString As String)
        InitializeComponent()
        Me.ConnectionString = ConnectionString
        Me.PATID = PATID
        LoadDataSource()
    End Sub
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintCover))
        Me.CoverPrinter = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDia = New System.Windows.Forms.PrintPreviewDialog()
        '
        'CoverPrinter
        '
        Me.CoverPrinter.DocumentName = "Cover"
        '
        'PrintPreviewDia
        '
        Me.PrintPreviewDia.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDia.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDia.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDia.Enabled = True
        Me.PrintPreviewDia.Icon = CType(resources.GetObject("PrintPreviewDia.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDia.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDia.ShowIcon = False
        Me.PrintPreviewDia.Visible = False

    End Sub

    Sub GetDoctorDetails(ByVal DocID As Integer)
        Dim doccon As New OleDbConnection(ConnectionString)
        Dim cmddoc As New OleDbCommand
        doccon.Open()
        cmddoc.Connection = doccon
        cmddoc.CommandText = "SELECT * FROM DOC WHERE ID=" & CInt(DocID)
        cmddoc.CommandType = CommandType.Text
        Dim rdrOLEDB As OleDbDataReader = cmddoc.ExecuteReader
        If rdrOLEDB.Read = True Then
            Dim street, area, City, pincode, hospital As String
            DoctorName = rdrOLEDB.Item("Doctor Name").ToString.Trim
            hospital = rdrOLEDB.Item("Hospital").ToString.Trim
            street = rdrOLEDB.Item("Street").ToString.Trim
            area = rdrOLEDB.Item("Area").ToString.Trim
            City = rdrOLEDB.Item("City").ToString.Trim
            pincode = rdrOLEDB.Item("PinCode").ToString.Trim
            If Not DoctorName = "" Then
                Address = DoctorName
            End If
            If Not hospital = "" Then
                If Address = "" Then
                    Address = hospital
                Else
                    Address &= vbNewLine & hospital
                End If
            End If
            If Not street = "" Then
                If Address = "" Then
                    Address = street
                Else
                    Address &= vbNewLine & street
                End If
            End If
            If Not area = "" Then
                If Address = "" Then
                    Address = area
                Else
                    Address &= vbNewLine & area
                End If
            End If
            If Not City = "" Then
                If Address = "" Then
                    Address = City & " " & pincode
                Else
                    Address &= vbNewLine & City & " - " & pincode
                End If
            End If
            rdrOLEDB.Close()
        Else
            rdrOLEDB.Close()
        End If
        doccon.Close()
    End Sub
    Private Sub LoadDataSource()
        Dim cnnoledb As New OleDbConnection(ConnectionString)
        cnnoledb.Open()
        Dim cmdoledb As New OleDbCommand
        Try
            cmdOLEDB.Connection = cnnoledb
            cmdoledb.CommandText = "SELECT * FROM PATIENT WHERE ID=" & PATID
            cmdoledb.CommandType = CommandType.Text
            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
            If rdrOLEDB.Read = True Then
                'Do While rdrOLEDB.Read
                ReportNumber = rdrOLEDB.Item("Report Number").ToString.Replace("-", "/").ToUpper.Trim
                PatienName = rdrOLEDB.Item("Sur Name").ToString & " " & rdrOLEDB.Item("Patient Name").ToString
                Dim DOCID As Integer = rdrOLEDB.Item("Doctor ID").ToString
                GetDoctorDetails(DOCID)
                rdrOLEDB.Close()
                'Loop
            Else
                rdrOLEDB.Close()
            End If
        Catch ex As Exception
            ' log message instead '
        End Try
        cnnoledb.Close()
    End Sub
    Private Sub CoverPrinter_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles CoverPrinter.PrintPage
        Dim rp_x As Single = My.Settings.CoverReportNoPoint.X
        Dim rp_y As Single = My.Settings.CoverReportNoPoint.Y
        Dim ap_x As Single = My.Settings.CoverAddressPoint.X
        Dim ap_y As Single = My.Settings.CoverAddressPoint.Y
        Dim txt_Height As Single = e.Graphics.MeasureString(ReportNumber, My.Settings.CoverFont).Height
        e.Graphics.DrawString(ReportNumber, My.Settings.CoverFont, Brushes.Black, New Point(rp_x, rp_y))
        rp_y += txt_Height
        e.Graphics.DrawString(PatienName, My.Settings.CoverFont, Brushes.Black, New Point(rp_x, rp_y))
        e.Graphics.DrawString("To :", My.Settings.CoverFont, Brushes.Black, New Point(ap_x, ap_y))
        Dim tow As Single = e.Graphics.MeasureString("To :", My.Settings.CoverFont).Width
        ap_x += tow
        ap_y += (txt_Height * 2)
        e.Graphics.DrawString(Address, My.Settings.CoverFont, Brushes.Black, New Point(ap_x, ap_y))
    End Sub
    Sub Print()
        CoverPrinter.PrinterSettings = ps
        CoverPrinter.DocumentName = "Cover - " & PatienName
        CoverPrinter.Print()
    End Sub
    Sub PrintPreview()
        CoverPrinter.DocumentName = "Cover - " & PatienName
        PrintPreviewDia.Document = CoverPrinter
        PrintPreviewDia.ShowDialog()
    End Sub
End Class
