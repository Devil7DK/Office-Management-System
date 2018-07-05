Imports System.Data.OleDb
Imports System.IO

Public Class SingleReportL2
    Dim ConnectionString As String = ""
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim ps As Printing.PrinterSettings
    Dim DocTable As DataTable
    Dim PatientID As Integer = 0
    Dim ReportNumber, FullName, Age, Sex, Address, DoctorName, DoctorAddress, HospitalNumber, ReceivedDate, ReportedDate, Report As String
    Dim Image1, Image2, Image3, Image4 As New D7.ReportImageDetails
    Sub New(ByVal PatientID As Integer, ByVal DatabaseLocation As String, ByVal Printer As Printing.PrinterSettings)
        ' This call is required by the designer.
        Me.PatientID = PatientID
        ' Add any initialization after the InitializeComponent() call.
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
        cnnOLEDB.ConnectionString = ConnectionString
        LoadDataSource()
        ps = Printer
    End Sub
    Sub New(ByVal PatientID As Integer, ByVal DatabaseLocation As String)
        ' This call is required by the designer.
        Me.PatientID = PatientID
        ' Add any initialization after the InitializeComponent() call.
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
        cnnOLEDB.ConnectionString = ConnectionString
        LoadDataSource()
    End Sub
    Function PraseDate(ByVal Str As String) As String
        Return Date.Parse(Str).ToString("dd/MM/yyyy")
    End Function
    Private Sub LoadDataSource()
        cnnOLEDB.Open()
        Try
            cmdOLEDB.Connection = cnnOLEDB
            cmdOLEDB.CommandText = "SELECT * FROM PATIENT WHERE ID=" & PatientID
            cmdOLEDB.CommandType = CommandType.Text
            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
            If rdrOLEDB.Read = True Then
                'Do While rdrOLEDB.Read
                ReportNumber = rdrOLEDB.Item("Report Number").ToString.Replace("-", "/").ToUpper.Trim
                FullName = rdrOLEDB.Item("Sur Name").ToString & " " & rdrOLEDB.Item("Patient Name").ToString
                Age = rdrOLEDB.Item("Age").ToString
                Sex = rdrOLEDB.Item("Gender").ToString
                Address = If(rdrOLEDB.Item("Address Line 1").ToString.Trim = "", "", rdrOLEDB.Item("Address Line 1").ToString.Trim & ", ") & If(rdrOLEDB.Item("Address Line 2").ToString.Trim = "", "", rdrOLEDB.Item("Address Line 2").ToString.Trim & ", ") & rdrOLEDB.Item("City").ToString.Trim
                Dim DOCID As Integer = rdrOLEDB.Item("Doctor ID").ToString
                GetDoctorDetails(DOCID)
                HospitalNumber = rdrOLEDB.Item("Hospital Number").ToString
                ReceivedDate = PraseDate(rdrOLEDB.Item("Received Date").ToString).Replace("-", "/")
                ReportedDate = PraseDate(rdrOLEDB.Item("Reported Date").ToString).Replace("-", "/")
                Report = rdrOLEDB.Item("Report Result").ToString
                rdrOLEDB.Close()
                'Loop
            Else
                MsgBox("Record not found")
                rdrOLEDB.Close()
            End If
        Catch ex As Exception
            ' log message instead '
        End Try
        cnnOLEDB.Close()
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
            Dim Hospital, City As String
            DoctorName = rdrOLEDB.Item("Doctor Name").ToString.Trim
            Hospital = rdrOLEDB.Item("Hospital").ToString.Trim
            City = rdrOLEDB.Item("City").ToString.Trim
            If Not Hospital = "" Then
                DoctorAddress = Hospital
            End If
            If Not City = "" Then
                If DoctorAddress = "" Then
                    DoctorAddress = City
                Else
                    DoctorAddress &= vbNewLine & City
                End If
            End If
            rdrOLEDB.Close()
        Else
            MsgBox("Doc Record not found")
            rdrOLEDB.Close()
        End If
        doccon.Close()
    End Sub
    Sub Print()
        Dim P As New ReporterL2(ReportNumber, FullName, Address.Replace(",,", ","), DoctorName, DoctorAddress, ReceivedDate, ReportedDate, Sex, Age, HospitalNumber, Report)
        If ps IsNot Nothing Then
            P.PrinterSettings = ps
        End If
        P.DefaultPageSettings.Margins.Top = My.Settings.ReportTop
        P.DefaultPageSettings.Margins.Bottom = My.Settings.ReportBottom
        P.DefaultPageSettings.Margins.Left = My.Settings.ReportLeft
        P.DefaultPageSettings.Margins.Right = My.Settings.ReportRight
        P.DetailsFont = My.Settings.DetailsFont
        P.ResultFont = My.Settings.ResultFont
        P.DocumentName = "Report - " & FullName
        P.Print()
    End Sub
    Sub PrintPreview()
        Dim P As New ReporterL2(ReportNumber, FullName, Address.Replace(",,", ","), DoctorName, DoctorAddress, ReceivedDate, ReportedDate, Sex, Age, HospitalNumber, Report)
        P.DefaultPageSettings.Margins.Top = My.Settings.ReportTop
        P.DefaultPageSettings.Margins.Bottom = My.Settings.ReportBottom
        P.DefaultPageSettings.Margins.Left = My.Settings.ReportLeft
        P.DefaultPageSettings.Margins.Right = My.Settings.ReportRight
        P.DetailsFont = My.Settings.DetailsFont
        P.ResultFont = My.Settings.ResultFont
        P.DocumentName = "Report - " & FullName
        P.PrintPreview()
    End Sub
End Class
