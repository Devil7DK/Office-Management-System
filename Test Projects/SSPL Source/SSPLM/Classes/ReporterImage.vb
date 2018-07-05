Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Namespace D7
    Public Class ReporterImage
        Dim siglocation As String = IO.Path.Combine(Application.StartupPath, "signature.jpg")
        Dim imageName As String = ""
        Friend WithEvents PPC As New PreviewPrintController
        Sub New(ByVal ReportNumber As String, ByVal NameAndDetails As String, ByVal ReferedByDetails As String, ByVal ReceivedDate As String, ByVal ReportedDate As String, ByVal AgeAndSex As String, ByVal HospitalNumber As String, ByVal ReportResult As String, ByVal Image1 As ReportImageDetails, ByVal Image2 As ReportImageDetails, ByVal Image3 As ReportImageDetails, ByVal Image4 As ReportImageDetails)
            InitializeComponent()
            Try
                Dim li As ListViewItem = Details.Items.Add("No._")
                li.SubItems.Add(":_")
                li.SubItems.Add(ReportNumber)
                li.SubItems.Add("Date_")
                li.SubItems.Add(":_")
                li.SubItems.Add(ReportedDate)
            Catch ex As Exception

            End Try
            Try
                Dim li As ListViewItem = Details.Items.Add("Name_")
                li.SubItems.Add(":_")
                li.SubItems.Add(NameAndDetails)
                li.SubItems.Add("Age/Sex_")
                li.SubItems.Add(":_")
                li.SubItems.Add(AgeAndSex)

            Catch ex As Exception

            End Try
            Try
                Dim li As ListViewItem = Details.Items.Add("|")
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")

            Catch ex As Exception

            End Try
            Try
                Dim li As ListViewItem = Details.Items.Add("Referred by_")
                li.SubItems.Add(":_")
                li.SubItems.Add(ReferedByDetails)
                li.SubItems.Add("Hosp. No._")
                li.SubItems.Add(":_")
                li.SubItems.Add(HospitalNumber)

            Catch ex As Exception

            End Try
            Try
                Dim li As ListViewItem = Details.Items.Add("|")
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")

            Catch ex As Exception

            End Try
            Try
                Dim li As ListViewItem = Details.Items.Add("Received Date_")
                li.SubItems.Add(":_")
                li.SubItems.Add(ReceivedDate)
                li.SubItems.Add("")
                li.SubItems.Add("")
                li.SubItems.Add("")

            Catch ex As Exception

            End Try
            Printer.Result = ReportResult
            Printer.ReportImage1 = Image1
            Printer.ReportImage2 = Image2
            Printer.ReportImage3 = Image3
            Printer.ReportImage4 = Image4
        End Sub
        Property DetailsFont As Font
            Get
                Return Printer.CellFormat.Font
            End Get
            Set(value As Font)
                Printer.CellFormat.Font = value
            End Set
        End Property
        Property ResultFont As Font
            Get
                Return Printer.ResultFont
            End Get
            Set(value As Font)
                Printer.ResultFont = value
            End Set
        End Property
        Property DefaultPageSettings As Printing.PageSettings
            Get
                Return Printer.DefaultPageSettings
            End Get
            Set(value As Printing.PageSettings)
                Printer.DefaultPageSettings = value
            End Set
        End Property
        Property Footer As String
            Get
                Return Printer.footer
            End Get
            Set(value As String)
                Printer.footer = value
            End Set
        End Property
        Private Sub SI(ByValsender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            Dim ppi() As Printing.PreviewPageInfo = PPC.GetPreviewPageInfo()
            For x As Integer = 0 To ppi.Length - 1
                Dim r As New Random
                Dim h As Image = My.Resources.SSPL_Header
                Dim f As Image = My.Resources.SSPL_Footer
                Dim b As New Bitmap(ppi(x).Image.Width, ppi(x).Image.Height)
                Dim g As Graphics = Graphics.FromImage(b)
                Dim percentage As Integer = (ppi(x).Image.Width / h.Width) * 100
                g.Clear(Color.White)
                g.DrawImage(h, 0, 0, ppi(x).Image.Width, CType((h.Height * (percentage / 100)), Single))
                g.DrawImage(f, 0, CType(ppi(x).Image.Height - (f.Height * (percentage / 100)), Single), ppi(x).Image.Width, CType((f.Height * (percentage / 100)), Single))
                g.DrawImage(ppi(x).Image, 0, 0, ppi(x).Image.Width, ppi(x).Image.Height)
                If My.Computer.FileSystem.FileExists(siglocation) = True Then
                    Dim sig As Image = Image.FromFile(siglocation)
                    g.DrawImage(sig, My.Settings.SignatureX, My.Settings.SignatureY, My.Settings.SignatureWidth, My.Settings.SignatureHeight)
                End If
                b.Save(imageName & "\" & Me.DocumentName & "_" & x.ToString & ".jpg", Imaging.ImageFormat.Jpeg)
            Next
        End Sub
        Sub SaveImage(ByVal FolderName As String)
            imageName = FolderName
            Try
                My.Computer.FileSystem.CreateDirectory(FolderName)
            Catch ex As Exception

            End Try
            Printer.PrintController = PPC
            AddHandler Printer.EndPrint, AddressOf SI
            Printer.Print()
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
    End Class

End Namespace
