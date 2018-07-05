Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Namespace D7
    Public Class Reporter
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

        Sub Print()
            Printer.Print()
        End Sub
        Sub PrintPreview()
            Printer.PrintPreview()
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
    Public Class ReportImageDetails
        Inherits System.ComponentModel.Component
        Public Sub New()
            Me.ReportImage = Nothing
            Me.ReportImageName = ""
            Me.IsValid = False
        End Sub
        Property ReportImage As Image
        Property ReportImageName As String
        Property IsValid As Boolean
    End Class
    <ToolboxItem(False)> _
     Public Class ReportPrinter
        Inherits PrintDocument
#Region "SUB"
        Public Sub New()
            Me._listview = Nothing
            Me._cellFormat = BlockFormat.DefaultCell()
            Me._footerFormat = BlockFormat.footer()
        End Sub
        Public Sub New(ByVal lv As ListView)
            Me.New()
            Me._listview = lv
        End Sub
#End Region
#Region "Propertys"
        <Category("Behaviour"), Description("Which listview will be printed by this printer?")> _
        Public Property ListView() As ListView
            Get
                Return _listview
            End Get
            Set(ByVal value As ListView)
                _listview = value
            End Set
        End Property
        Private _listview As ListView

        <Category("Behaviour"), Description("Should this report be shrunk to fit into the width of a page?"), DefaultValue(False)> _
        Public Property IsShrinkToFit() As Boolean
            Get
                Return _isShrinkToFit
            End Get
            Set(ByVal value As Boolean)
                _isShrinkToFit = value
            End Set
        End Property
        Private _isShrinkToFit As Boolean = True
        <Category("Behaviour"), Description("Should this report use the column order as the user sees them? With this enabled, the report will match the order of column as the user has arranged them."), DefaultValue(True)> _
        Public Property UseColumnDisplayOrder() As Boolean
            Get
                Return _useColumnDisplayOrder
            End Get
            Set(ByVal value As Boolean)
                _useColumnDisplayOrder = value
            End Set
        End Property
        Private _useColumnDisplayOrder As Boolean = True
        <Category("Behaviour"), Description("Return the first page of the report that should be printed"), DefaultValue(0)> _
        Public Property FirstPage() As Integer
            Get
                Return _firstPage
            End Get
            Set(ByVal value As Integer)
                _firstPage = value
            End Set
        End Property
        Private _firstPage As Integer = 0
        <Category("Behaviour"), Description("Return the last page of the report that should be printed"), DefaultValue(9999)> _
        Public Property LastPage() As Integer
            Get
                Return _lastPage
            End Get
            Set(ByVal value As Integer)
                _lastPage = value
            End Set
        End Property
        Private _lastPage As Integer = 9999
        <Browsable(False)> _
        Public ReadOnly Property PageNumber() As Integer
            Get
                Return Me._pageNumber
            End Get
        End Property
        <Category("Appearance - Formatting"), Description("How will the list cells be formatted? "), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Property CellFormat() As BlockFormat
            Get
                If _cellFormat Is Nothing Then
                    _cellFormat = BlockFormat.DefaultCell()
                End If
                Return _cellFormat
            End Get
            Set(ByVal value As BlockFormat)
                _cellFormat = value
            End Set
        End Property
        Private _cellFormat As BlockFormat
        <Category("Appearance - Formatting"), Description("How will the page _footer be formatted?"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Property FooterFormat() As BlockFormat
            Get
                Return _footerFormat
            End Get
            Set(ByVal value As BlockFormat)
                _footerFormat = value
            End Set
        End Property
        Private _footerFormat As BlockFormat
        Public Property ResultFont As New Font("Times New Roman", 11)
        <Browsable(False)> _
        Public Property ListFont() As Font
            Get
                Return Me._cellFormat.Font
            End Get
            Set(ByVal value As Font)
                Me.CellFormat.Font = value
            End Set
        End Property
        <Browsable(False)> _
        Public Property ListGridPen() As Pen
            Get
                Return Me._cellFormat.GetBorderPen(Sides.Top)
            End Get
            Set(ByVal value As Pen)
                Me.CellFormat.SetBorderPen(Sides.All, value)
            End Set
        End Property
        <Browsable(False)> _
        Public Property ListGridColor() As Color
            Get
                Dim p As Pen = Me.ListGridPen
                If p Is Nothing Then
                    Return Color.Empty
                Else
                    Return p.Color
                End If
            End Get
            Set(ByVal value As Color)
                Me.ListGridPen = New Pen(value, 0.5F)
            End Set
        End Property
        <Category("Appearance"), Description("The string that will be written at the bottom of each page. Use '\t' characters to separate left, centre, and right parts of the _footer.")> _
        Public Property footer() As [String]
            Get
                Return _footer
            End Get
            Set(ByVal value As [String])
                _footer = value
                If Not [String].IsNullOrEmpty(_footer) Then
                    _footer = _footer.Replace("\t", vbTab)
                End If
            End Set
        End Property
        Private _footer As [String]
        <Category("Data")> _
        Public Property ReportImage1 As ReportImageDetails
        <Category("Data")> _
        Public Property ReportImage2 As ReportImageDetails
        <Category("Data")> _
        Public Property ReportImage3 As ReportImageDetails
        <Category("Data")> _
        Public Property ReportImage4 As ReportImageDetails
#End Region
        Protected Function GetRowCount(ByVal lv As ListView) As Integer
            Return lv.Items.Count
        End Function
        <Category("Data")> _
        Public Property Result As String
        Protected Function GetRow(ByVal lv As ListView, ByVal n As Integer) As ListViewItem
            Return lv.Items(n)
        End Function
        Protected Function GetSubItem(ByVal lvi As ListViewItem, ByVal i As Integer) As ListViewItem.ListViewSubItem
            If i < lvi.SubItems.Count Then
                Return lvi.SubItems(Me.GetColumn(i).Index)
            Else
                Return New ListViewItem.ListViewSubItem()
            End If
        End Function
        Protected Function GetColumnCount() As Integer
            Return Me.sortedColumns.Count
        End Function
        Protected Function GetColumn(ByVal i As Integer) As ColumnHeader
            Return Me.sortedColumns(i)
        End Function
        Protected Function GetGroupAtPosition(ByVal n As Integer) As Integer
            Return Me.groupStartPositions.IndexOf(n)
        End Function
        Public Sub PageSetup()
            Dim dlg As New PageSetupDialog()
            dlg.Document = Me
            dlg.EnableMetric = True
            dlg.ShowDialog()
        End Sub
        Public Sub PrintPreview()
            Dim dlg As New PrintPreviewDialog()
            dlg.UseAntiAlias = True
            dlg.Document = Me
            dlg.ShowDialog()
        End Sub
        Dim totalpages As Integer = 0

        Function GetTotalPages()
            If ReportImage1.IsValid = True Then
                Me.Image1Printed = False
            Else
                Me.Image1Printed = True
            End If
            If ReportImage2.IsValid = True Then
                Me.Image2Printed = False
            Else
                Me.Image2Printed = True
            End If
            If ReportImage3.IsValid = True Then
                Me.Image3Printed = False
            Else
                Me.Image3Printed = True
            End If
            If ReportImage4.IsValid = True Then
                Me.Image4Printed = False
            Else
                Me.Image4Printed = True
            End If
            Me.ResultPrinted = False
            Me.DetailsPrinted = False
            Me.rowIndex = -1
            Me.indexLeftColumn = -1
            Me.indexRightColumn = -1
            Me._pageNumber = 0
            Me.sortedColumns = New SortedList(Of Integer, ColumnHeader)()
            Me.groupStartPositions = New List(Of Integer)()
            Me.PreparePrint()

            Dim pages As Integer = 0
            Dim continuecalc = True
            Do While continuecalc = True
                Dim b As New Bitmap(10, 10)
                Dim g As Graphics = Graphics.FromImage(b)
                Me.CalculateBounds()
                Me.CalculatePrintParameters(Me._listview)
                Me.PrintHeaderFooter(g)
                Me.ApplyScaling(g)
                Me.currentOrigin = Me.listBounds.Location
                Me.DefaultCurrentX = currentOrigin.X
                If DetailsPrinted = False Then
                    Me.PrintList(g, Me._listview)
                    Me.DetailsPrinted = True
                End If
                Me.PrintResult(g)
                Me.PrintImage(g)
                pages += 1
                continuecalc = checkstatus()
            Loop
            Return pages
        End Function
        Sub CalculateTotalPages()
            If ReportImage1.IsValid = True Then
                Me.Image1Printed = False
            Else
                Me.Image1Printed = True
            End If
            If ReportImage2.IsValid = True Then
                Me.Image2Printed = False
            Else
                Me.Image2Printed = True
            End If
            If ReportImage3.IsValid = True Then
                Me.Image3Printed = False
            Else
                Me.Image3Printed = True
            End If
            If ReportImage4.IsValid = True Then
                Me.Image4Printed = False
            Else
                Me.Image4Printed = True
            End If
            Me.ResultPrinted = False
            Me.DetailsPrinted = False
            Me.rowIndex = -1
            Me.indexLeftColumn = -1
            Me.indexRightColumn = -1
            Me._pageNumber = 0
            Me.sortedColumns = New SortedList(Of Integer, ColumnHeader)()
            Me.groupStartPositions = New List(Of Integer)()
            Me.PreparePrint()

            totalpages = 0
            Dim continuecalc = True
            Do While continuecalc = True
                Dim b As New Bitmap(10, 10)
                Dim g As Graphics = Graphics.FromImage(b)
                Me.CalculateBounds()
                Me.CalculatePrintParameters(Me._listview)
                Me.PrintHeaderFooter(g)
                Me.ApplyScaling(g)
                Me.currentOrigin = Me.listBounds.Location
                Me.DefaultCurrentX = currentOrigin.X
                If DetailsPrinted = False Then
                    Me.PrintList(g, Me._listview)
                    Me.DetailsPrinted = True
                End If
                Me.PrintResult(g)
                Me.PrintImage(g)
                totalpages += 1
                continuecalc = checkstatus()
            Loop
        End Sub
        Protected Overloads Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
            Me.currentresult = Result.Replace("''", My.Settings.Quot)
            CalculateTotalPages()
            MyBase.OnBeginPrint(e)
            Me.currentresult = Result.Replace("''", My.Settings.Quot)
            If ReportImage1.IsValid = True Then
                Me.Image1Printed = False
            Else
                Me.Image1Printed = True
            End If
            If ReportImage2.IsValid = True Then
                Me.Image2Printed = False
            Else
                Me.Image2Printed = True
            End If
            If ReportImage3.IsValid = True Then
                Me.Image3Printed = False
            Else
                Me.Image3Printed = True
            End If
            If ReportImage4.IsValid = True Then
                Me.Image4Printed = False
            Else
                Me.Image4Printed = True
            End If
            Me.ResultPrinted = False
            Me.DetailsPrinted = False
            Me.rowIndex = -1
            Me.indexLeftColumn = -1
            Me.indexRightColumn = -1
            Me._pageNumber = 0
            Me.sortedColumns = New SortedList(Of Integer, ColumnHeader)()
            Me.groupStartPositions = New List(Of Integer)()
            Me.PreparePrint()
        End Sub
        Protected Overloads Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)
            If Me._listview Is Nothing OrElse Me._listview.View <> View.Details Then
                Return
            End If
            MyBase.OnPrintPage(e)
            System.Math.Max(System.Threading.Interlocked.Increment(Me._pageNumber), Me._pageNumber - 1)
            Dim pageToStop As Integer = Math.Min(Me._firstPage, Me._lastPage + 1)
            If Me._pageNumber < pageToStop Then
                e.HasMorePages = True
                While Me._pageNumber < pageToStop AndAlso e.HasMorePages
                    e.HasMorePages = Me.PrintOnePage(e)
                    System.Math.Max(System.Threading.Interlocked.Increment(Me._pageNumber), Me._pageNumber - 1)
                End While
                e.Graphics.Clear(Color.White)
                If Not e.HasMorePages Then
                    Return
                End If
            End If
            If Me._pageNumber <= Me._lastPage Then
                e.HasMorePages = Me.PrintOnePage(e)
                e.HasMorePages = e.HasMorePages AndAlso (Me._pageNumber < Me._lastPage)
            Else
                e.HasMorePages = False
            End If
        End Sub
        Protected Sub PreparePrint()
            If Me._listview Is Nothing Then
                Return
            End If
            For Each column As ColumnHeader In Me._listview.Columns
                If Me._useColumnDisplayOrder Then
                    Me.sortedColumns.Add(column.DisplayIndex, column)
                Else
                    Me.sortedColumns.Add(column.Index, column)
                End If
            Next
        End Sub

        Sub PrintPageNumber(ByVal g As Graphics)
            If My.Settings.pageNumberLoc.X <> 0 AndAlso My.Settings.pageNumberLoc.Y <> 0 Then
                Dim pgn As String = "Page " & Me.PageNumber & " of " & totalpages
                g.DrawString(pgn, My.Settings.pageNumberFont, Brushes.Black, My.Settings.pageNumberLoc)
            End If
        End Sub
        Protected Function PrintOnePage(ByVal e As PrintPageEventArgs) As Boolean
            Me.CalculateBounds()
            Me.CalculatePrintParameters(Me._listview)
            Me.PrintHeaderFooter(e.Graphics)
            Me.ApplyScaling(e.Graphics)
            Me.currentOrigin = Me.listBounds.Location
            Me.DefaultCurrentX = currentOrigin.X
            If DetailsPrinted = False Then
                Me.PrintList(e.Graphics, Me._listview)
                Me.DetailsPrinted = True
            End If
            Me.PrintResult(e.Graphics)
            Me.PrintImage(e.Graphics)
            Me.PrintPageNumber(e.Graphics)
            Dim continuePrinting As Boolean = checkstatus()
            Return continuePrinting
        End Function
        Function checkstatus() As Boolean
            Dim r As Boolean = False
            If Me.Image1Printed = False Then
                r = True
            End If
            If Me.Image2Printed = False Then
                r = True
            End If
            If Me.Image4Printed = False Then
                r = True
            End If
            If Me.Image3Printed = False Then
                r = True
            End If
            If Me.DetailsPrinted = False Then
                r = True
            End If
            If Me.ResultPrinted = False Then
                r = True
            End If
            Return r
        End Function
        Protected Sub CalculateBounds()
            Me.pageBounds = New RectangleF((Me.DefaultPageSettings.Bounds.X + Me.DefaultPageSettings.Margins.Left), (Me.DefaultPageSettings.Bounds.Y + Me.DefaultPageSettings.Margins.Top), (Me.DefaultPageSettings.Bounds.Width - (Me.DefaultPageSettings.Margins.Left + Me.DefaultPageSettings.Margins.Right)), (Me.DefaultPageSettings.Bounds.Height - (Me.DefaultPageSettings.Margins.Top + Me.DefaultPageSettings.Margins.Bottom)))
            Me.listBounds = Me.pageBounds
        End Sub
        Protected Sub CalculatePrintParameters(ByVal lv As ListView)
            If Me.rowIndex >= 0 AndAlso Me.rowIndex < Me.GetRowCount(lv) Then
                Return
            End If
            Me.rowIndex = 0
            If Me._isShrinkToFit Then
                Me.indexLeftColumn = 0
                Me.indexRightColumn = Me.GetColumnCount() - 1
                Dim totalWidth As Integer = 0
                Dim i As Integer = 0
                While i < Me.GetColumnCount()
                    totalWidth += Me.GetColumn(i).Width
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While
                Me.scaleFactor = Math.Min(Me.listBounds.Width / totalWidth, 1.0F)
            Else
                Me.scaleFactor = 1.0F
                Me.indexLeftColumn = System.Threading.Interlocked.Increment(Me.indexRightColumn)
                Dim width As Integer = 0
                Dim i As Integer = Me.indexLeftColumn
                Dim wid As Integer = (width + Me.GetColumn(i).Width)
                While i < Me.GetColumnCount() AndAlso (wid) < Me.listBounds.Width
                    Me.indexRightColumn = i
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While
            End If
        End Sub
        Protected Sub ApplyScaling(ByVal g As Graphics)
            If Me.scaleFactor >= 1.0F Then
                Return
            End If
            g.ScaleTransform(Me.scaleFactor, Me.scaleFactor)
            Dim inverse As Single = 1.0F / Me.scaleFactor
            Me.listBounds = New RectangleF(Me.listBounds.X * inverse, Me.listBounds.Y * inverse, Me.listBounds.Width * inverse, Me.listBounds.Height * inverse)
        End Sub

        Protected Function PrintList(ByVal g As Graphics, ByVal lv As ListView) As Boolean
            Me.PrintRows(g, lv)
            Return (Me.rowIndex < Me.GetRowCount(lv) OrElse Me.indexRightColumn + 1 < Me.GetColumnCount())
        End Function
        Protected Sub PrintRows(ByVal g As Graphics, ByVal lv As ListView)
            While Me.rowIndex < Me.GetRowCount(lv)
                Dim rowHeight As Single = Me.CalculateRowHeight(g, lv, Me.rowIndex)
                If Me.currentOrigin.Y + rowHeight > Me.listBounds.Height Then
                    Exit While
                End If
                Me.PrintRow(g, lv, Me.rowIndex, rowHeight)
                System.Math.Max(System.Threading.Interlocked.Increment(Me.rowIndex), Me.rowIndex - 1)
            End While
        End Sub
        Protected Overridable Function CalculateRowHeight(ByVal g As Graphics, ByVal lv As ListView, ByVal n As Integer) As Single
            If lv.SmallImageList IsNot Nothing Then
                Me._cellFormat.MinimumTextHeight = lv.SmallImageList.ImageSize.Height
            End If
            If Not Me._cellFormat.CanWrap Then
                Return Me._cellFormat.CalculateHeight(g)
            End If
            Dim height As Single = 0.0F
            Dim lvi As ListViewItem = Me.GetRow(lv, n)
            Dim i As Integer = 0
            While i < Me.GetColumnCount()
                Dim column As ColumnHeader = Me.GetColumn(i)
                Dim colWidth As Integer = column.Width
                If column.Index = 0 AndAlso lv.SmallImageList IsNot Nothing AndAlso lvi.ImageIndex <> -1 Then
                    colWidth -= lv.SmallImageList.ImageSize.Width
                End If
                height = Math.Max(height, Me._cellFormat.CalculateHeight(g, Me.GetSubItem(lvi, i).Text, colWidth))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            Return height
        End Function

        Protected Sub PrintRow(ByVal g As Graphics, ByVal lv As ListView, ByVal row As Integer, ByVal rowHeight As Single)
            Dim lvi As ListViewItem = Me.GetRow(lv, row)
            Dim cell As New RectangleF(Me.currentOrigin, New SizeF(0, rowHeight))
            Dim i As Integer = Me.indexLeftColumn
            While i <= Me.indexRightColumn
                Dim col As ColumnHeader = Me.GetColumn(i)
                cell.Width = col.Width
                Me.PrintCell(g, lv, lvi, row, i, cell)
                cell.Offset(cell.Width, 0)
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            Me.currentOrigin.Y += rowHeight
            Me.listBounds.Height -= rowHeight
        End Sub
        Protected Overridable Sub PrintCell(ByVal g As Graphics, ByVal lv As ListView, ByVal lvi As ListViewItem, ByVal row As Integer, ByVal column As Integer, ByVal cell As RectangleF)
            Dim fmt As BlockFormat = Me._cellFormat
            Dim ch As ColumnHeader = Me.GetColumn(column)
            Dim txt As String = Me.GetSubItem(lvi, column).Text
            fmt.Draw(g, cell, txt)
        End Sub
        Protected Sub PrintHeaderFooter(ByVal g As Graphics)
            If Not [String].IsNullOrEmpty(Me._footer) Then
                PrintPageFooter(g)
            End If
        End Sub
        Dim currentresult As String = ""
        Protected Sub PrintResult(ByVal g As Graphics)
            If ResultPrinted = False Then
                Dim numChars As Integer
                Dim numLines As Integer
                Dim stringForPage As String
                Dim strFormat As New StringFormat

                Dim rectDraw As New RectangleF(Me.currentOrigin.X, Me.currentOrigin.Y, Me.listBounds.Width, Me.listBounds.Height)
                'Determine maximum text ammount and spaces lines
                Dim sizeMeasure As New SizeF(Me.listBounds.Width, Me.listBounds.Height - ResultFont.GetHeight(g))

                'Break in between words
                strFormat.Trimming = StringTrimming.Word
                'Determines ammount of wordss and lines that can fit on a page
                g.MeasureString(currentresult, ResultFont, sizeMeasure, strFormat, numChars, numLines)

                stringForPage = currentresult.Substring(0, numChars)
                'Print strings to page
                g.DrawString(stringForPage, ResultFont, Brushes.Black, rectDraw, strFormat)
                Dim textsize As SizeF = g.MeasureString(stringForPage, ResultFont, Me.listBounds.Width)
                Dim height As Single = textsize.Height + 10
                'Determine whether or not there are more pages to print
                If numChars < currentresult.Length Then
                    'Remove printed text from string
                    currentresult = currentresult.Substring(numChars)
                    ResultPrinted = False
                Else
                    ResultPrinted = True
                End If
                Me.currentOrigin.Y += (height)
                Me.listBounds.Height -= (height)
            End If
        End Sub
        Dim lastY As Integer = 0
        Protected Sub PrintReportImage(ByVal ReportImg As ReportImageDetails, ByRef Printed As Boolean, ByVal g As Graphics)
            If Printed = False AndAlso ReportImg.IsValid = True AndAlso ReportImg.ReportImage IsNot Nothing Then
                Dim Givenheight As Single = If(My.Settings.ImageFixedWidth = True, My.Settings.ImageHeight, ReportImg.ReportImage.Height)
                Dim GivenWidth As Single = If(My.Settings.ImageFixedWidth = True, My.Settings.ImageWidth, ReportImg.ReportImage.Width)
                Dim Captionformat As New StringFormat()
                Captionformat.Alignment = StringAlignment.Center
                Dim CaptionSize As SizeF = g.MeasureString(ReportImg.ReportImageName, ListFont, GivenWidth, Captionformat)
                Dim EditedImage As New Bitmap(CInt(GivenWidth), CInt(Givenheight + CaptionSize.Height))
                Dim eg As Graphics = Graphics.FromImage(EditedImage)
                eg.Clear(Color.White)
                eg.DrawImage(ReportImg.ReportImage, 0, 0, GivenWidth, Givenheight)
                eg.DrawString(ReportImg.ReportImageName, ListFont, Brushes.Black, New Rectangle(0, Givenheight, EditedImage.Width, CaptionSize.Height), Captionformat)
                If Not Me.currentOrigin.X = DefaultCurrentX Then
                    If Me.currentOrigin.X + EditedImage.Width <= Me.listBounds.Width Then
                        If EditedImage.Height <= Me.listBounds.Height Then
                            Dim headerRect As New RectangleF(Me.listBounds.X, Me.listBounds.Y, Me.listBounds.Width, EditedImage.Height)
                            g.DrawImage(EditedImage, New Rectangle(Me.currentOrigin.X, Me.currentOrigin.Y, EditedImage.Width, EditedImage.Height))
                            Me.currentOrigin.X += EditedImage.Width
                            Me.currentOrigin.Y += EditedImage.Height
                            Printed = True
                        End If
                    Else
                        Me.currentOrigin.X = DefaultCurrentX
                        Me.currentOrigin.Y += lastY
                        If EditedImage.Height <= Me.listBounds.Height Then
                            Dim headerRect As New RectangleF(Me.listBounds.X, Me.listBounds.Y, Me.listBounds.Width, EditedImage.Height)
                            g.DrawImage(EditedImage, New Rectangle(Me.currentOrigin.X, Me.currentOrigin.Y, EditedImage.Width, EditedImage.Height))
                            Me.currentOrigin.X += EditedImage.Width + 10
                            Me.currentOrigin.Y += EditedImage.Height
                            Printed = True
                        End If
                    End If
                Else
                    If EditedImage.Height <= Me.listBounds.Height Then
                        Dim headerRect As New RectangleF(Me.listBounds.X, Me.listBounds.Y, Me.listBounds.Width, EditedImage.Height)
                        g.DrawImage(EditedImage, New Rectangle(Me.currentOrigin.X, Me.currentOrigin.Y, EditedImage.Width, EditedImage.Height))
                        Me.currentOrigin.X += EditedImage.Width + 10
                        lastY = EditedImage.Height
                        Printed = True
                    End If
                End If
            End If
        End Sub

        Protected Sub PrintImage(ByVal g As Graphics)
            PrintReportImage(ReportImage1, Image1Printed, g)
            PrintReportImage(ReportImage2, Image2Printed, g)
            PrintReportImage(ReportImage3, Image3Printed, g)
            PrintReportImage(ReportImage4, Image4Printed, g)
        End Sub
        Protected Sub PrintPageFooter(ByVal g As Graphics)
            Dim fmt As BlockFormat = Me._footerFormat
            If fmt Is Nothing Then
                Return
            End If
            Dim height As Single = fmt.CalculateHeight(g)
            Dim r As New RectangleF(Me.listBounds.X, Me.listBounds.Bottom - height, Me.listBounds.Width, height)
            fmt.Draw(g, r, Me.SplitAndFormat(Me._footer))
            Me.listBounds.Height -= height
        End Sub
        Private Function SplitAndFormat(ByVal text As [String]) As [String]()
            Dim s As [String] = [String].Format(text, Me._pageNumber, DateTime.Now)
            Return s.Split(New [Char]() {ControlChars.Tab}, 3)
        End Function
        Private rowIndex As Integer
        Private indexLeftColumn As Integer
        Private indexRightColumn As Integer
        Private _pageNumber As Integer
        Private sortedColumns As SortedList(Of Integer, ColumnHeader)
        Private groupStartPositions As List(Of Integer)
        Private pageBounds As RectangleF
        Private listBounds As RectangleF
        Private currentOrigin As PointF
        Private DefaultCurrentX As Single
        Private scaleFactor As Single
        Private Image1Printed As Boolean = False
        Private Image2Printed As Boolean = False
        Private Image3Printed As Boolean = False
        Private Image4Printed As Boolean = False
        Private ResultPrinted As Boolean = False
        Private DetailsPrinted As Boolean = False
    End Class
    Public Enum Sides
        Left = 0
        Top = 1
        Right = 2
        Bottom = 3
        All = 4
    End Enum
    <ToolboxItem(False)> _
    Public Class BlockFormat
        Inherits System.ComponentModel.Component
        Public Sub New()
        End Sub
        <Category("Appearance"), Description("What font should this block be drawn in?")> _
        Public Property Font() As Font
            Get
                Return _font
            End Get
            Set(ByVal value As Font)
                _font = value
            End Set
        End Property
        Private _font As Font = New Font("Times New Roman", 11)
        <Browsable(False)> _
        Public ReadOnly Property FontOrDefault() As Font
            Get
                If Me.Font Is Nothing Then
                    Return New Font("Times New Roman", 11)
                Else
                    Return Me.Font
                End If
            End Get
        End Property
        <Browsable(False)> _
        Public _TextBrush As Color = Nothing
        <Browsable(False)> _
        Public ReadOnly Property TextBrushOrDefault() As Brush
            Get
                If Me._TextBrush = Nothing Then
                    Return Brushes.Black
                Else
                    Return New SolidBrush(Me._TextBrush)
                End If
            End Get
        End Property
        <Category("Appearance"), Description("What color should text in this block be drawn in?"), DefaultValue(GetType(Color), "Empty")> _
        Public Property TextColor() As Color
            Get
                If Me._TextBrush = Nothing Then
                    Return Color.Empty
                Else
                    Return (Me._TextBrush)
                End If
            End Get
            Set(ByVal value As Color)
                If value.IsEmpty Then
                    Me._TextBrush = Nothing
                Else
                    Me._TextBrush = value
                End If
            End Set
        End Property
        <Browsable(False)> _
        Public _BackgroundBrush As Color = Nothing
        <Category("Appearance"), Description("What color should be used to paint the background of this block?"), DefaultValue(GetType(Color), "Empty")> _
        Public Property BackgroundColor() As Color
            Get
                If Me._BackgroundBrush = Nothing Then
                    Return Color.Empty
                Else
                    Return (Me._BackgroundBrush)
                End If
            End Get
            Set(ByVal value As Color)
                Me._BackgroundBrush = value
            End Set
        End Property
        <Category("Appearance"), Description("When laying out our header can the text be wrapped?"), DefaultValue(False)> _
        Public Property CanWrap() As Boolean
            Get
                Return _canWrap
            End Get
            Set(ByVal value As Boolean)
                _canWrap = value
            End Set
        End Property
        Private _canWrap As Boolean = False
        <Browsable(False)> _
        Public Property MinimumTextHeight() As Single
            Get
                Return _minimumTextHeight
            End Get
            Set(ByVal value As Single)
                _minimumTextHeight = value
            End Set
        End Property
        Private _minimumTextHeight As Single = 0
        <Category("Appearance"), Description("Width of the top border"), DefaultValue(0.0F)> _
        Public Property TopBorderWidth() As Single
            Get
                Return Me.GetBorderWidth(Sides.Top)
            End Get
            Set(ByVal value As Single)
                Me.SetBorder(Sides.Top, value, Me.GetBorderBrush(Sides.Top))
            End Set
        End Property
        <Category("Appearance"), Description("Width of the Left border"), DefaultValue(0.0F)> _
        Public Property LeftBorderWidth() As Single
            Get
                Return Me.GetBorderWidth(Sides.Left)
            End Get
            Set(ByVal value As Single)
                Me.SetBorder(Sides.Left, value, Me.GetBorderBrush(Sides.Left))
            End Set
        End Property
        <Category("Appearance"), Description("Width of the Bottom border"), DefaultValue(0.0F)> _
        Public Property BottomBorderWidth() As Single
            Get
                Return Me.GetBorderWidth(Sides.Bottom)
            End Get
            Set(ByVal value As Single)
                Me.SetBorder(Sides.Bottom, value, Me.GetBorderBrush(Sides.Bottom))
            End Set
        End Property
        <Category("Appearance"), Description("Width of the Right border"), DefaultValue(0.0F)> _
        Public Property RightBorderWidth() As Single
            Get
                Return Me.GetBorderWidth(Sides.Right)
            End Get
            Set(ByVal value As Single)
                Me.SetBorder(Sides.Right, value, Me.GetBorderBrush(Sides.Right))
            End Set
        End Property
        <Category("Appearance"), Description("Color of the top border"), DefaultValue(GetType(Color), "Empty")> _
        Public Property TopBorderColor() As Color
            Get
                Return Me.GetSolidBorderColor(Sides.Top)
            End Get
            Set(ByVal value As Color)
                Me.SetBorder(Sides.Top, Me.GetBorderWidth(Sides.Top), New SolidBrush(value))
            End Set
        End Property
        <Category("Appearance"), Description("Color of the Left border"), DefaultValue(GetType(Color), "Empty")> _
        Public Property LeftBorderColor() As Color
            Get
                Return Me.GetSolidBorderColor(Sides.Left)
            End Get
            Set(ByVal value As Color)
                Me.SetBorder(Sides.Left, Me.GetBorderWidth(Sides.Left), New SolidBrush(value))
            End Set
        End Property
        <Category("Appearance"), Description("Color of the Bottom border"), DefaultValue(GetType(Color), "Empty")> _
        Public Property BottomBorderColor() As Color
            Get
                Return Me.GetSolidBorderColor(Sides.Bottom)
            End Get
            Set(ByVal value As Color)
                Me.SetBorder(Sides.Bottom, Me.GetBorderWidth(Sides.Bottom), New SolidBrush(value))
            End Set
        End Property
        <Category("Appearance"), Description("Color of the Right border"), DefaultValue(GetType(Color), "Empty")> _
        Public Property RightBorderColor() As Color
            Get
                Return Me.GetSolidBorderColor(Sides.Right)
            End Get
            Set(ByVal value As Color)
                Me.SetBorder(Sides.Right, Me.GetBorderWidth(Sides.Right), New SolidBrush(value))
            End Set
        End Property
        Private Function GetSolidBorderColor(ByVal side As Sides) As Color
            Dim b As Brush = Me.GetBorderBrush(side)
            If b IsNot Nothing AndAlso TypeOf b Is SolidBrush Then
                Return (New Pen(b).Color)
            Else
                Return Color.Empty
            End If
        End Function
        Public Function GetPadding(ByVal side As Sides) As Single
            If Me.Padding.ContainsKey(side) Then
                Return Me.Padding(side)
            Else
                Return 0.0F
            End If
        End Function
        Public Sub SetPadding(ByVal side As Sides, ByVal value As Single)
            If side = Sides.All Then
                Me.Padding(Sides.Left) = value
                Me.Padding(Sides.Top) = value
                Me.Padding(Sides.Right) = value
                Me.Padding(Sides.Bottom) = value
            Else
                Me.Padding(side) = value
            End If
        End Sub
        Public Function GetBorderPen(ByVal side As Sides) As Pen
            If Me.BorderPens.ContainsKey(side) Then
                Return Me.BorderPens(side)
            Else
                Return Nothing
            End If
        End Function
        Public Function GetBorderWidth(ByVal side As Sides) As Single
            Dim p As Pen = Me.GetBorderPen(side)
            If p Is Nothing Then
                Return 0
            Else
                Return p.Width
            End If
        End Function
        Public Function GetBorderBrush(ByVal side As Sides) As Brush
            Dim p As Pen = Me.GetBorderPen(side)
            If p Is Nothing Then
                Return Nothing
            Else
                Return p.Brush
            End If
        End Function
        Public Sub SetBorder(ByVal side As Sides, ByVal width As Single, ByVal brush As Brush)
            Me.SetBorderPen(side, New Pen(brush, width))
        End Sub
        Public Sub SetBorderPen(ByVal side As Sides, ByVal p As Pen)
            If side = Sides.All Then
                Me.areSideBorderEqual = True
                Me.BorderPens(Sides.Left) = p
                Me.BorderPens(Sides.Top) = p
                Me.BorderPens(Sides.Right) = p
                Me.BorderPens(Sides.Bottom) = p
            Else
                Me.areSideBorderEqual = False
                Me.BorderPens(side) = p
            End If
        End Sub
        Private areSideBorderEqual As Boolean = False
        Public Function GetTextInset(ByVal side As Sides) As Single
            Return GetKeyOrDefault(Me.TextInsets, side, 0.0F)
        End Function
        Public Sub SetTextInset(ByVal side As Sides, ByVal value As Single)
            If side = Sides.All Then
                Me.TextInsets(Sides.Left) = value
                Me.TextInsets(Sides.Top) = value
                Me.TextInsets(Sides.Right) = value
                Me.TextInsets(Sides.Bottom) = value
            Else
                Me.TextInsets(side) = value
            End If
        End Sub
        Private Function GetKeyOrDefault(Of KeyT, ValueT)(ByVal map As Dictionary(Of KeyT, ValueT), ByVal key As KeyT, ByVal defaultValue As ValueT) As ValueT
            If map.ContainsKey(key) Then
                Return map(key)
            Else
                Return defaultValue
            End If
        End Function
        Private BorderPens As New Dictionary(Of Sides, Pen)()
        Private TextInsets As New Dictionary(Of Sides, Single)
        Private Padding As New Dictionary(Of Sides, Single)
        Public Function CalculateHeight(ByVal g As Graphics) As Single
            Return Me.CalculateHeight(g, "Wy", 9999999)
        End Function
        Public Function CalculateHeight(ByVal g As Graphics, ByVal s As [String], ByVal width As Integer) As Single
            width -= (Me.GetTextInset(Sides.Left) + Me.GetTextInset(Sides.Right) + 0.5F)
            Dim fmt As New StringFormat()
            fmt.Trimming = StringTrimming.EllipsisCharacter
            If Not Me._canWrap Then
                fmt.FormatFlags = StringFormatFlags.NoWrap
            End If
            Dim height As Single = g.MeasureString(s, Me.FontOrDefault, width, fmt).Height
            height = Math.Max(height, Me._minimumTextHeight)
            'height += Me.GetPadding(Sides.Top)
            'height += Me.GetPadding(Sides.Bottom)
            'height += Me.GetBorderWidth(Sides.Top)
            'height += Me.GetBorderWidth(Sides.Bottom)
            'height += Me.GetTextInset(Sides.Top)
            'height += Me.GetTextInset(Sides.Bottom)
            Return height
        End Function
        Private Function ApplyInsets(ByVal cell As RectangleF, ByVal left As Single, ByVal top As Single, ByVal right As Single, ByVal bottom As Single) As RectangleF
            Return New RectangleF(cell.X + left, cell.Y + top, cell.Width - (left + right), cell.Height - (top + bottom))
        End Function
        Public Function CalculatePaddedBox(ByVal cell As RectangleF) As RectangleF
            Return Me.ApplyInsets(cell, Me.GetPadding(Sides.Left), Me.GetPadding(Sides.Top), Me.GetPadding(Sides.Right), Me.GetPadding(Sides.Bottom))
        End Function
        Public Function CalculateBorderedBox(ByVal cell As RectangleF) As RectangleF
            Return Me.ApplyInsets(cell, Me.GetBorderWidth(Sides.Left), Me.GetBorderWidth(Sides.Top), Me.GetBorderWidth(Sides.Right), Me.GetBorderWidth(Sides.Bottom))
        End Function
        Public Function CalculateTextBox(ByVal cell As RectangleF) As RectangleF
            Return Me.ApplyInsets(cell, Me.GetTextInset(Sides.Left), Me.GetTextInset(Sides.Top), Me.GetTextInset(Sides.Right), Me.GetTextInset(Sides.Bottom))
        End Function
        Public Function CalculatePaddedTextBox(ByVal cell As RectangleF) As RectangleF
            Return Me.CalculateTextBox(Me.CalculateBorderedBox(Me.CalculatePaddedBox(cell)))
        End Function
        Public Sub Draw(ByVal g As Graphics, ByVal r As RectangleF, ByVal strings As [String]())
            Dim left As [String] = Nothing, centre As [String] = Nothing, right As [String] = Nothing
            If strings.Length >= 1 Then
                left = strings(0)
            End If
            If strings.Length >= 2 Then
                centre = strings(1)
            End If
            If strings.Length >= 3 Then
                right = strings(2)
            End If
            Me.Draw(g, r, left)
        End Sub
        Public Sub Draw(ByVal g As Graphics, ByVal r As RectangleF, ByVal left As [String])
            Dim paddedRect As RectangleF = Me.CalculatePaddedBox(r)
            Dim paddedBorderedRect As RectangleF = Me.CalculateBorderedBox(paddedRect)
            Me.DrawText(g, paddedBorderedRect, left.Replace("''", My.Settings.Quot))
        End Sub
        Private Sub DrawBackground(ByVal g As Graphics, ByVal r As RectangleF)
            If Me._BackgroundBrush <> Nothing Then
                Dim r2 As RectangleF = Me.ApplyInsets(r, Me.GetBorderWidth(Sides.Left) / -2, Me.GetBorderWidth(Sides.Top) / -2, Me.GetBorderWidth(Sides.Right) / -2, Me.GetBorderWidth(Sides.Bottom) / -2)
                Me.DrawFilledRectangle(g, New SolidBrush(Me._BackgroundBrush), r2)
            End If
        End Sub
        Private Sub DrawBorder(ByVal g As Graphics, ByVal r As RectangleF)
            If Me.areSideBorderEqual AndAlso Me.GetBorderPen(Sides.Top) IsNot Nothing Then
                Dim p As Pen = Me.GetBorderPen(Sides.Top)
                Me.DrawOneBorder(g, Sides.Top, r.X, r.Y, r.Width, r.Height, _
                 True)
            Else
                Me.DrawOneBorder(g, Sides.Top, r.X, r.Y, r.Right, r.Y, _
                 False)
                Me.DrawOneBorder(g, Sides.Bottom, r.X, r.Bottom, r.Right, r.Bottom, _
                 False)
                Me.DrawOneBorder(g, Sides.Left, r.X, r.Y, r.X, r.Bottom, _
                 False)
                Me.DrawOneBorder(g, Sides.Right, r.Right, r.Y, r.Right, r.Bottom, _
                 False)
            End If
        End Sub
        Private Sub DrawOneBorder(ByVal g As Graphics, ByVal side As Sides, ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single, _
         ByVal isRectangle As Boolean)
            Dim p As Pen = Me.GetBorderPen(side)
            If p Is Nothing Then
                Return
            End If
            If TypeOf p.Brush Is LinearGradientBrush Then
                Dim lgr As LinearGradientBrush = p.Brush
                Dim lgr2 As New LinearGradientBrush(New PointF(x1, y1), New PointF(x2, y2), lgr.LinearColors(0), lgr.LinearColors(1))
                lgr2.Blend = lgr.Blend
                lgr2.WrapMode = WrapMode.TileFlipXY
                p.Brush = lgr2
            End If
            If isRectangle Then
                g.DrawRectangle(p, x1, y1, x2, y2)
            Else
                g.DrawLine(p, x1, y1, x2, y2)
            End If
        End Sub
        Private Sub DrawFilledRectangle(ByVal g As Graphics, ByVal brush As Brush, ByVal r As RectangleF)
            If TypeOf brush Is LinearGradientBrush Then
                Dim lgr As LinearGradientBrush = brush
                Dim lgr2 As New LinearGradientBrush(r, lgr.LinearColors(0), lgr.LinearColors(1), 0.0F)
                lgr2.Blend = lgr.Blend
                lgr2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(lgr2, r)
            Else
                g.FillRectangle(brush, r)
            End If
        End Sub
        Private Sub DrawText(ByVal g As Graphics, ByVal r As RectangleF, ByVal left As String)
            Dim textRect As RectangleF = Me.CalculateTextBox(r)
            Dim font As Font = Me.FontOrDefault
            Dim textBrush As Brush = Me.TextBrushOrDefault
            Dim fmt As New StringFormat()
            If Not Me._canWrap Then
                fmt.FormatFlags = StringFormatFlags.NoWrap
            End If
            fmt.LineAlignment = StringAlignment.Near
            fmt.Trimming = StringTrimming.EllipsisCharacter
            If Not [String].IsNullOrEmpty(left) Then
                fmt.Alignment = StringAlignment.Near
                If left = "|" Then
                    g.DrawString(left.Trim, font, Brushes.White, textRect, fmt)
                Else

                    If left.EndsWith("_") Then
                        g.DrawString(left.TrimEnd("_").TrimStart(",").Trim, New Font(font, FontStyle.Bold), textBrush, textRect, fmt)
                    ElseIf left.EndsWith("#") Then
                        g.DrawString(left.TrimEnd("#").TrimStart(",").Trim, New Font(font.FontFamily, font.Size + 3, FontStyle.Bold), textBrush, textRect, fmt)
                    Else
                        If left.Contains("_") Then
                            Dim s As String() = Split(left, "_", 2)
                            Dim x As Single = textRect.X
                            Dim y As Single = textRect.Y
                            Dim width As Single = textRect.Width
                            Dim height As Single = textRect.Height
                            Dim th As Single = g.MeasureString(s(0), New Font(font, FontStyle.Bold), width).Height
                            g.DrawString(s(0).Trim.TrimStart(","), New Font(font, FontStyle.Bold), textBrush, textRect, fmt)
                            y += th
                            If s(1).Trim.TrimStart(",").EndsWith("`^") = True Then
                                g.DrawString(s(1).Trim.TrimStart(",").Replace("`^", "").TrimEnd(","), New Font(font.FontFamily, CType((font.Size - 3), Single), FontStyle.Regular), textBrush, New Rectangle(x, y, width, height), fmt)
                            Else
                                g.DrawString(s(1).Trim.TrimStart(",").TrimEnd(","), font, textBrush, New Rectangle(x, y, width, height), fmt)
                            End If
                        Else
                            g.DrawString(left, font, textBrush, textRect, fmt)
                        End If
                    End If
                End If
            End If
        End Sub
        Public Shared Function DefaultCell() As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = New Font("Times New Roman", 11)
            fmt.SetBorderPen(Sides.All, New Pen(Color.Blue, 0.5F))
            fmt.SetTextInset(Sides.All, 2)
            fmt._canWrap = True
            Return fmt
        End Function
        Public Shared Function Minimal() As BlockFormat
            Return BlockFormat.Minimal(New Font("Times New Roman", 11))
        End Function
        Public Shared Function Minimal(ByVal f As Font) As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = f
            fmt._TextBrush = Color.Black
            fmt.SetBorderPen(Sides.All, New Pen(Color.Gray, 0.5F))
            fmt.SetTextInset(Sides.All, 3.0F)
            Return fmt
        End Function
        Public Shared Function Box() As BlockFormat
            Return BlockFormat.Box(New Font("Times New Roman", 11))
        End Function
        Public Shared Function Box(ByVal f As Font) As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = f
            fmt._TextBrush = Color.Black
            fmt.SetBorderPen(Sides.All, New Pen(Color.Black, 0.5F))
            fmt._BackgroundBrush = Color.LightBlue
            fmt.SetTextInset(Sides.All, 3.0F)
            Return fmt
        End Function
        Public Shared Function Header() As BlockFormat
            Return BlockFormat.Header(New Font("Times New Roman", 11))
        End Function
        Public Shared Function Header(ByVal f As Font) As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = f
            fmt._TextBrush = Color.WhiteSmoke
            fmt._BackgroundBrush = Color.DarkBlue
            fmt.SetTextInset(Sides.All, 3.0F)
            fmt.SetPadding(Sides.Bottom, 10)
            Return fmt
        End Function
        Public Shared Function footer() As BlockFormat
            Return BlockFormat.footer(New Font("Verdana", 10, FontStyle.Italic))
        End Function
        Public Shared Function footer(ByVal f As Font) As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = f
            fmt._TextBrush = Color.Black
            fmt.SetPadding(Sides.Top, 10)
            fmt.SetBorderPen(Sides.Top, New Pen(Color.Gray, 0.5F))
            fmt.SetTextInset(Sides.All, 3.0F)
            Return fmt
        End Function
    End Class


End Namespace
