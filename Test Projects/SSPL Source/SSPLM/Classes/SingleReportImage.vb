Imports System.Data.OleDb
Imports System.IO

Public Class SingleReportImage
    Dim ConnectionString As String = ""
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim DocTable As DataTable
    Dim PatientID As Integer = 0
    Dim ReportNumber, FullName, AgeSex, Address, DoctorName, DoctorAddress, HospitalNumber, ReceivedDate, ReportedDate, Report As String
    Dim Image1, Image2, Image3, Image4 As New D7.ReportImageDetails

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
                ReportNumber = rdrOLEDB.Item("Report Number").ToString.Replace("-", "/").ToUpper & "_"
                FullName = rdrOLEDB.Item("Sur Name").ToString & " " & rdrOLEDB.Item("Patient Name").ToString & "_"
                AgeSex = rdrOLEDB.Item("Age").ToString & "Y/" & rdrOLEDB.Item("Gender").ToString & "_"
                Address = rdrOLEDB.Item("Address Line 2").ToString.Trim & ", " & rdrOLEDB.Item("City").ToString.Trim & "`^"

                Dim DOCID As Integer = rdrOLEDB.Item("Doctor ID").ToString
                GetDoctorDetails(DOCID)
                HospitalNumber = rdrOLEDB.Item("Hospital Number").ToString & "_"
                ReceivedDate = PraseDate(rdrOLEDB.Item("Received Date").ToString).Replace("-", "/") & "_"
                ReportedDate = PraseDate(rdrOLEDB.Item("Reported Date").ToString).Replace("-", "/") & "_"
                Report = rdrOLEDB.Item("Report Result").ToString
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 1 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 1")
                            ms.WriteByte(i)
                        Next
                        Image1.ReportImage = Image.FromStream(ms)
                        Image1.ReportImageName = namestr
                        Image1.IsValid = True
                    End If
                Catch ex As Exception

                End Try
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 2 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 2")
                            ms.WriteByte(i)
                        Next
                        Image2.ReportImage = Image.FromStream(ms)
                        Image2.ReportImageName = namestr
                        Image2.IsValid = True
                    End If
                Catch ex As Exception

                End Try
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 3 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 3")
                            ms.WriteByte(i)
                        Next
                        Image3.ReportImage = Image.FromStream(ms)
                        Image3.ReportImageName = namestr
                        Image3.IsValid = True
                    End If
                Catch ex As Exception

                End Try
                Try
                    Dim namestr As String = rdrOLEDB.Item("Image 4 Name").ToString
                    If Not namestr = "" Then
                        Dim ms As New MemoryStream
                        For Each i As Byte In rdrOLEDB.Item("Image 4")
                            ms.WriteByte(i)
                        Next
                        Image4.ReportImage = Image.FromStream(ms)
                        Image4.ReportImageName = namestr
                        Image4.IsValid = True
                    End If
                Catch ex As Exception

                End Try
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
            DoctorName = rdrOLEDB.Item("Doctor Name").ToString.Trim & "_"
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
    Sub SaveImage(ByVal FolderName As String)
        Dim P As New D7.ReporterImage(ReportNumber, FullName & vbNewLine & Address, DoctorName & vbNewLine & DoctorAddress, ReceivedDate, ReportedDate, AgeSex, HospitalNumber, Report, Image1, Image2, Image3, Image4)
        P.DefaultPageSettings.Margins.Top = My.Settings.ReportTop
        P.DefaultPageSettings.Margins.Bottom = My.Settings.ReportBottom
        P.DefaultPageSettings.Margins.Left = My.Settings.ReportLeft
        P.DefaultPageSettings.Margins.Right = My.Settings.ReportRight

        P.DetailsFont = My.Settings.DetailsFont
        P.ResultFont = My.Settings.ResultFont
        P.DocumentName = "Report - " & FullName.Replace("/", "").Replace("\", "").Replace(":", "")
        P.SaveImage(FolderName)
    End Sub
End Class
