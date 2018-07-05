Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Namespace BrightIdeasSoftware
    Public Class ListViewPrinter
        Inherits PrintDocument
        Public Sub New()
            Me._listview = Nothing
            Me._headerFormat = BlockFormat.Header()
            Me._listHeaderFormat = BlockFormat.ListHeader()
            Me._cellFormat = BlockFormat.DefaultCell()
            Me._groupHeaderFormat = BlockFormat.GroupHeader()
            Me._footerFormat = BlockFormat.footer()
        End Sub
        Public Sub New(ByVal lv As ListView)
            Me.New()
            Me._listview = lv
        End Sub
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
        <Category("Behaviour"), Description("Should this report use text only? If this is false, images on the primary column will be included."), DefaultValue(False)> _
        Public Property IsTextOnly() As Boolean
            Get
                Return _isTextOnly
            End Get
            Set(ByVal value As Boolean)
                _isTextOnly = value
            End Set
        End Property
        Private _isTextOnly As Boolean = False
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
        <Category("Behaviour"), Description("Should this report only include the selected rows in the listview?"), DefaultValue(False)> _
        Public Property IsPrintSelectionOnly() As Boolean
            Get
                Return _isPrintSelectionOnly
            End Get
            Set(ByVal value As Boolean)
                _isPrintSelectionOnly = value
            End Set
        End Property
        Private _isPrintSelectionOnly As Boolean = False
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
        <Category("Behaviour"), Description("Should column headings always be centered or should they follow the alignment on the control itself?"), DefaultValue(True)> _
        Public Property AlwaysCenterListHeader() As Boolean
            Get
                Return slwaysCenterListHeader
            End Get
            Set(ByVal value As Boolean)
                slwaysCenterListHeader = value
            End Set
        End Property
        Private slwaysCenterListHeader As Boolean = True
        <Category("Behaviour"), Description("Should listview headings be printed at the top of each page, or just at the top of the list?"), DefaultValue(True)> _
        Public Property isListHeaderOnEachPage() As Boolean
            Get
                Return _isListHeaderOnEachPage
            End Get
            Set(ByVal value As Boolean)
                _isListHeaderOnEachPage = value
            End Set
        End Property
        Private _isListHeaderOnEachPage As Boolean = False
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
        <Browsable(False)> _
        Public ReadOnly Property IsShowingGroups() As Boolean
            Get
                Return (Me._listview IsNot Nothing AndAlso Me._listview.ShowGroups AndAlso Not Me.IsPrintSelectionOnly AndAlso Me._listview.Groups.Count > 0)
            End Get
        End Property
        <Category("Appearance - Formatting"), Description("How will the page header be formatted? "), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Property HeaderFormat() As BlockFormat
            Get
                Return _headerFormat
            End Get
            Set(ByVal value As BlockFormat)
                _headerFormat = value
            End Set
        End Property
        Private _headerFormat As BlockFormat
        <Category("Appearance - Formatting"), Description("How will the header of the list be formatted? "), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Property ListHeaderFormat() As BlockFormat
            Get
                Return _listHeaderFormat
            End Get
            Set(ByVal value As BlockFormat)
                _listHeaderFormat = value
            End Set
        End Property
        Public _listHeaderFormat As BlockFormat
        <Category("Appearance - Formatting"), Description("How will the group headers be formatted?"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Property GroupHeaderFormat() As BlockFormat
            Get
                If _groupHeaderFormat Is Nothing Then
                    _groupHeaderFormat = BlockFormat.GroupHeader()
                End If
                Return _groupHeaderFormat
            End Get
            Set(ByVal value As BlockFormat)
                _groupHeaderFormat = value
            End Set
        End Property
        Public _groupHeaderFormat As BlockFormat
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
        <Category("Appearance"), Description("The string that will be written at the top of each page. Use '\t' characters to separate left, centre, and right parts of the header.")> _
        Public Property Header() As [String]
            Get
                Return _header
            End Get
            Set(ByVal value As [String])
                _header = value
                If Not [String].IsNullOrEmpty(_header) Then
                    _header = _header.Replace("\t", vbTab)
                End If
            End Set
        End Property
        Private _header As [String]
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
        <Category("Appearance - Watermark"), Description("The watermark will be printed translucently over the report itself?")> _
        Public Property Watermark() As [String]
            Get
                Return _watermark
            End Get
            Set(ByVal value As [String])
                _watermark = value
            End Set
        End Property
        Private _watermark As [String]
        <Category("Appearance - Watermark"), Description("What font should be used to print the watermark?")> _
        Public Property WatermarkFont() As Font
            Get
                Return _watermarkFont
            End Get
            Set(ByVal value As Font)
                _watermarkFont = value
            End Set
        End Property
        Private _watermarkFont As Font
        <Browsable(False)> _
        Public ReadOnly Property WatermarkFontOrDefault() As Font
            Get
                If Me._watermarkFont Is Nothing Then
                    Return New Font("Tahoma", 72)
                Else
                    Return Me._watermarkFont
                End If
            End Get
        End Property
        <Category("Appearance - Watermark"), Description("What color should be used for the watermark?"), DefaultValue(GetType(Color), "Empty")> _
        Public Property WatermarkColor() As Color
            Get
                Return _watermarkColor
            End Get
            Set(ByVal value As Color)
                _watermarkColor = value
            End Set
        End Property
        Private _watermarkColor As Color = Color.Empty
        <Browsable(False)> _
        Public ReadOnly Property WatermarkColorOrDefault() As Color
            Get
                If Me._watermarkColor = Color.Empty Then
                    Return Color.Gray
                Else
                    Return Me._watermarkColor
                End If
            End Get
        End Property
        <Category("Appearance - Watermark"), Description("How transparent should the watermark be? 0 is transparent, 100 is completely opaque."), DefaultValue(50)> _
        Public Property WatermarkTransparency() As Integer
            Get
                Return _watermarkTransparency
            End Get
            Set(ByVal value As Integer)
                _watermarkTransparency = Math.Max(0, Math.Min(value, 100))
            End Set
        End Property
        Private _watermarkTransparency As Integer = 50
        Protected Function GetRowCount(ByVal lv As ListView) As Integer
            If Me.IsPrintSelectionOnly Then
                Return lv.SelectedIndices.Count
            ElseIf lv.VirtualMode Then
                Return lv.VirtualListSize
            Else
                Return lv.Items.Count
            End If
        End Function
        Protected Function GetRow(ByVal lv As ListView, ByVal n As Integer) As ListViewItem
            If Me.IsPrintSelectionOnly Then
                If lv.VirtualMode Then
                    Return Me.GetVirtualItem(lv, lv.SelectedIndices(n))
                Else
                    Return lv.SelectedItems(n)
                End If
            End If
            If Not Me.IsShowingGroups Then
                If lv.VirtualMode Then
                    Return Me.GetVirtualItem(lv, n)
                Else
                    Return lv.Items(n)
                End If
            End If
            Dim i As Integer
            i = Me.groupStartPositions.Count - 1
            While i >= 0
                If n >= Me.groupStartPositions(i) Then
                    Exit While
                End If
                System.Math.Max(System.Threading.Interlocked.Decrement(i), i + 1)
            End While
            Dim indexInList As Integer = n - Me.groupStartPositions(i)
            Return lv.Groups(i).Items(indexInList)
        End Function
        Protected Overridable Function GetVirtualItem(ByVal lv As ListView, ByVal n As Integer) As ListViewItem
            Throw New ApplicationException("Virtual list items cannot be retrieved. Use an ObjectListView instead.")
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
        Public Sub PrintWithDialog()
            Dim dlg As New PrintDialog()
            dlg.Document = Me
            dlg.AllowSelection = Me._listview.SelectedIndices.Count > 0
            dlg.AllowSomePages = True
            If dlg.ShowDialog() = DialogResult.OK Then
                Me.IsPrintSelectionOnly = (dlg.PrinterSettings.PrintRange = PrintRange.Selection)
                If dlg.PrinterSettings.PrintRange = PrintRange.SomePages Then
                    Me._firstPage = dlg.PrinterSettings.FromPage
                    Me._lastPage = dlg.PrinterSettings.ToPage
                Else
                    Me._firstPage = 1
                    Me._lastPage = 999999
                End If
                Me.Print()
            End If
        End Sub
        Protected Overloads Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
            MyBase.OnBeginPrint(e)
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
            Dim itemCount As Integer = 0
            For Each lvg As ListViewGroup In Me._listview.Groups
                Me.groupStartPositions.Add(itemCount)
                itemCount += lvg.Items.Count
            Next
        End Sub
        Protected Function PrintOnePage(ByVal e As PrintPageEventArgs) As Boolean
            Me.CalculateBounds(e)
            Me.CalculatePrintParameters(Me._listview)
            Me.PrintHeaderFooter(e.Graphics)
            Me.ApplyScaling(e.Graphics)
            Dim continuePrinting As Boolean = Me.PrintList(e.Graphics, Me._listview)
            Me.PrintWatermark(e.Graphics)
            Return continuePrinting
        End Function
        Protected Sub CalculateBounds(ByVal e As PrintPageEventArgs)
            If Me.PrintController.IsPreview Then
                Me.pageBounds = e.MarginBounds
            Else
                Me.pageBounds = New RectangleF(e.MarginBounds.X - e.PageSettings.HardMarginX, e.MarginBounds.Y - e.PageSettings.HardMarginY, e.MarginBounds.Width, e.MarginBounds.Height)
            End If
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
        Protected Sub PrintWatermark(ByVal g As Graphics)
            If [String].IsNullOrEmpty(Me._watermark) Then
                Return
            End If
            Dim strFormat As New StringFormat()
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Alignment = StringAlignment.Center
            Dim watermarkRotation As Integer = -30
            g.ResetTransform()
            Dim m As New Matrix()
            m.RotateAt(watermarkRotation, New PointF(Me.pageBounds.X + Me.pageBounds.Width / 2, Me.pageBounds.Y + Me.pageBounds.Height / 2))
            g.Transform = m
            Dim alpha As Integer = (255.0F * Me._watermarkTransparency / 100.0F)
            Dim brush As Brush = New SolidBrush(Color.FromArgb(alpha, Me.WatermarkColorOrDefault))
            g.DrawString(Me._watermark, Me.WatermarkFontOrDefault, brush, Me.pageBounds, strFormat)
            g.ResetTransform()
        End Sub
        Protected Function PrintList(ByVal g As Graphics, ByVal lv As ListView) As Boolean
            Me.currentOrigin = Me.listBounds.Location
            If Me.rowIndex = 0 OrElse Me._isListHeaderOnEachPage Then
                Me.PrintListHeader(g, lv)
            End If
            Me.PrintRows(g, lv)
            Return (Me.rowIndex < Me.GetRowCount(lv) OrElse Me.indexRightColumn + 1 < Me.GetColumnCount())
        End Function
        Protected Sub PrintListHeader(ByVal g As Graphics, ByVal lv As ListView)
            Dim fmt As BlockFormat = Me._listHeaderFormat
            If fmt Is Nothing Then
                Return
            End If
            Dim height As Single = 0
            Dim i As Integer = 0
            While i < Me.GetColumnCount()
                Dim col As ColumnHeader = Me.GetColumn(i)
                height = Math.Max(height, fmt.CalculateHeight(g, col.Text, col.Width))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            Dim cell As New RectangleF(Me.currentOrigin.X, Me.currentOrigin.Y, 0, height)
            Dim i1 As Integer = Me.indexLeftColumn
            While i1 <= Me.indexRightColumn
                Dim col As ColumnHeader = Me.GetColumn(i1)
                cell.Width = col.Width
                fmt.Draw(g, cell, col.Text, (If(Me.AlwaysCenterListHeader, HorizontalAlignment.Center, col.TextAlign)))
                cell.Offset(cell.Width, 0)
                System.Math.Max(System.Threading.Interlocked.Increment(i1), i1 - 1)
            End While
            Me.currentOrigin.Y += cell.Height
        End Sub
        Protected Sub PrintRows(ByVal g As Graphics, ByVal lv As ListView)
            While Me.rowIndex < Me.GetRowCount(lv)
                Dim rowHeight As Single = Me.CalculateRowHeight(g, lv, Me.rowIndex)
                If Me.currentOrigin.Y + rowHeight > Me.listBounds.Bottom Then
                    Exit While
                End If
                If Me.IsShowingGroups Then
                    Dim groupIndex As Integer = Me.GetGroupAtPosition(Me.rowIndex)
                    If groupIndex <> -1 Then
                        Dim groupHeaderHeight As Single = Me._groupHeaderFormat.CalculateHeight(g)
                        If Me.currentOrigin.Y + groupHeaderHeight + rowHeight < Me.listBounds.Bottom Then
                            Me.PrintGroupHeader(g, lv, groupIndex)
                        Else
                            Me.currentOrigin.Y = Me.listBounds.Bottom
                            Exit While
                        End If
                    End If
                End If
                Me.PrintRow(g, lv, Me.rowIndex, rowHeight)
                System.Math.Max(System.Threading.Interlocked.Increment(Me.rowIndex), Me.rowIndex - 1)
            End While
        End Sub
        Protected Overridable Function CalculateRowHeight(ByVal g As Graphics, ByVal lv As ListView, ByVal n As Integer) As Single
            If Not Me._isTextOnly AndAlso lv.SmallImageList IsNot Nothing Then
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
                If Not Me._isTextOnly AndAlso column.Index = 0 AndAlso lv.SmallImageList IsNot Nothing AndAlso lvi.ImageIndex <> -1 Then
                    colWidth -= lv.SmallImageList.ImageSize.Width
                End If
                height = Math.Max(height, Me._cellFormat.CalculateHeight(g, Me.GetSubItem(lvi, i).Text, colWidth))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            Return height
        End Function
        Protected Sub PrintGroupHeader(ByVal g As Graphics, ByVal lv As ListView, ByVal groupIndex As Integer)
            Dim lvg As ListViewGroup = lv.Groups(groupIndex)
            Dim fmt As BlockFormat = Me._groupHeaderFormat
            Dim height As Single = fmt.CalculateHeight(g)
            Dim r As New RectangleF(Me.currentOrigin.X, Me.currentOrigin.Y, Me.listBounds.Width, height)
            If lvg.Header.EndsWith("_") = True Then
                fmt.Draw(g, r, lvg.Header, lvg.HeaderAlignment, True)
            Else
                fmt.Draw(g, r, lvg.Header, lvg.HeaderAlignment)
            End If
            Me.currentOrigin.Y += height
        End Sub
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
        End Sub
        Protected Overridable Sub PrintCell(ByVal g As Graphics, ByVal lv As ListView, ByVal lvi As ListViewItem, ByVal row As Integer, ByVal column As Integer, ByVal cell As RectangleF)
            Dim fmt As BlockFormat = Me._cellFormat
            Dim ch As ColumnHeader = Me.GetColumn(column)
            If Not Me._isTextOnly AndAlso ch.Index = 0 AndAlso lvi.ImageIndex <> -1 AndAlso lv.SmallImageList IsNot Nothing Then
                Const gapBetweenImageAndText As Integer = 3
                Dim textInsetCorrection As Single = lv.SmallImageList.ImageSize.Width + gapBetweenImageAndText
                fmt.SetTextInset(Sides.Left, fmt.GetTextInset(Sides.Left) + textInsetCorrection)
                Dim txt1 As String = ""
                Try
                    txt1 = Me.GetSubItem(lvi, column + 1).Text
                Catch ex As Exception

                End Try
                If txt1 = "|" Then
                    fmt.Draw(g, cell, Me.GetSubItem(lvi, column).Text, ch.TextAlign, True)
                Else
                    fmt.Draw(g, cell, Me.GetSubItem(lvi, column).Text, ch.TextAlign)
                End If
                fmt.SetTextInset(Sides.Left, fmt.GetTextInset(Sides.Left) - textInsetCorrection)
                Dim r As RectangleF = fmt.CalculatePaddedTextBox(cell)
                If lv.SmallImageList.ImageSize.Height < r.Height Then
                    r.Y += (r.Height - lv.SmallImageList.ImageSize.Height) / 2
                End If
                g.DrawImage(lv.SmallImageList.Images(lvi.ImageIndex), r.Location)
            Else
                Dim txt As String = Me.GetSubItem(lvi, column).Text
                Dim txt1 As String = ""
                Try
                    txt1 = Me.GetSubItem(lvi, column + 1).Text
                Catch ex As Exception

                End Try
                If txt1 = "|" Then
                    fmt.Draw(g, cell, txt, ch.TextAlign, True)
                Else
                    fmt.Draw(g, cell, txt, ch.TextAlign)
                End If
            End If
        End Sub
        Protected Sub PrintHeaderFooter(ByVal g As Graphics)
            If Not [String].IsNullOrEmpty(Me.Header) Then
                PrintPageHeader(g)
            End If
            If Not [String].IsNullOrEmpty(Me._footer) Then
                PrintPageFooter(g)
            End If
        End Sub
        Protected Sub PrintPageHeader(ByVal g As Graphics)
            Dim fmt As BlockFormat = Me._headerFormat
            If fmt Is Nothing Then
                Return
            End If
            Dim height As Single = fmt.CalculateHeight(g)
            Dim headerRect As New RectangleF(Me.listBounds.X, Me.listBounds.Y, Me.listBounds.Width, height)
            fmt.Draw(g, headerRect, Me.SplitAndFormat(Me.Header))
            Me.listBounds.Y += height
            Me.listBounds.Height -= height
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
        Private scaleFactor As Single
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
        Private _font As Font = New Font("Arial", 9)
        <Browsable(False)> _
        Public ReadOnly Property FontOrDefault() As Font
            Get
                If Me.Font Is Nothing Then
                    Return New Font("Ms Sans Serif", 12)
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
            height += Me.GetPadding(Sides.Top)
            height += Me.GetPadding(Sides.Bottom)
            height += Me.GetBorderWidth(Sides.Top)
            height += Me.GetBorderWidth(Sides.Bottom)
            height += Me.GetTextInset(Sides.Top)
            height += Me.GetTextInset(Sides.Bottom)
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
        Public Sub Draw(ByVal g As Graphics, ByVal r As RectangleF, ByVal s As [String], ByVal align As HorizontalAlignment, Optional CGF As Boolean = False)
            Select Case align
                Case HorizontalAlignment.Center
                    Me.Draw(g, r, Nothing, s, Nothing, CGF)
                    Exit Select
                Case HorizontalAlignment.Left
                    Me.Draw(g, r, s, Nothing, Nothing, CGF)
                    Exit Select
                Case HorizontalAlignment.Right
                    Me.Draw(g, r, Nothing, Nothing, s, CGF)
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub
        Public Sub Draw(ByVal g As Graphics, ByVal r As RectangleF, ByVal strings As [String](), Optional CGF As Boolean = False)
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
            Me.Draw(g, r, left, centre, right, CGF)
        End Sub
        Public Sub Draw(ByVal g As Graphics, ByVal r As RectangleF, ByVal left As [String], ByVal centre As [String], ByVal right As [String], Optional CGF As Boolean = False)
            Dim paddedRect As RectangleF = Me.CalculatePaddedBox(r)
            Dim paddedBorderedRect As RectangleF = Me.CalculateBorderedBox(paddedRect)
            Me.DrawBackground(g, paddedBorderedRect)
            Me.DrawText(g, paddedBorderedRect, left, centre, right, CGF)
            Me.DrawBorder(g, paddedRect)
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
        Private Sub DrawText(ByVal g As Graphics, ByVal r As RectangleF, ByVal left As String, ByVal centre As String, ByVal right As String, Optional CGF As Boolean = False)
            Dim textRect As RectangleF = Me.CalculateTextBox(r)
            Dim font As Font = Me.FontOrDefault
            Dim textBrush As Brush = Me.TextBrushOrDefault
            Dim fmt As New StringFormat()
            If Not Me._canWrap Then
                fmt.FormatFlags = StringFormatFlags.NoWrap
            End If
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            If Not [String].IsNullOrEmpty(left) Then
                fmt.Alignment = StringAlignment.Near
                If left = "|" Then
                Else
                    If CGF = True Then
                        If left.EndsWith("_") Then
                            g.DrawString(left.TrimEnd("_"), New Font(font, FontStyle.Underline + FontStyle.Bold), Brushes.DarkBlue, textRect, fmt)
                        Else
                            g.DrawString(left, New Font(font, FontStyle.Underline), Brushes.DarkBlue, textRect, fmt)
                        End If
                    Else
                        g.DrawString(left, font, textBrush, textRect, fmt)
                    End If
                End If
            End If
            If Not [String].IsNullOrEmpty(centre) Then
                fmt.Alignment = StringAlignment.Center
                If centre = "|" Then
                Else
                    If CGF = True Then
                        g.DrawString(centre, New Font(font, FontStyle.Underline), Brushes.DarkBlue, textRect, fmt)
                    Else
                        g.DrawString(centre, font, textBrush, textRect, fmt)
                    End If
                End If
            End If
            If Not [String].IsNullOrEmpty(right) Then
                fmt.Alignment = StringAlignment.Far
                If right = "|" Then
                Else
                    If CGF = True Then
                        g.DrawString(right, New Font(font, FontStyle.Underline), Brushes.DarkBlue, textRect, fmt)
                    Else
                        g.DrawString(right, font, textBrush, textRect, fmt)
                    End If
                End If
            End If
        End Sub
        Public Shared Function DefaultCell() As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = New Font("MS Sans Serif", 9)
            fmt.SetBorderPen(Sides.All, New Pen(Color.Blue, 0.5F))
            fmt.SetTextInset(Sides.All, 2)
            fmt._canWrap = True
            Return fmt
        End Function
        Public Shared Function Minimal() As BlockFormat
            Return BlockFormat.Minimal(New Font("Times New Roman", 12))
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
            Return BlockFormat.Box(New Font("Verdana", 24))
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
            Return BlockFormat.Header(New Font("Verdana", 24))
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
        Public Shared Function ListHeader() As BlockFormat
            Return BlockFormat.ListHeader(New Font("Verdana", 12))
        End Function
        Public Shared Function ListHeader(ByVal f As Font) As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = f
            fmt._TextBrush = Color.Black
            fmt._BackgroundBrush = Color.LightGray
            fmt.SetBorderPen(Sides.All, New Pen(Color.DarkGray, 1.5F))
            fmt.SetTextInset(Sides.All, 1.0F)
            fmt._canWrap = True
            Return fmt
        End Function
        Public Shared Function GroupHeader() As BlockFormat
            Return BlockFormat.GroupHeader(New Font("Verdana", 10, FontStyle.Bold))
        End Function
        Public Shared Function GroupHeader(ByVal f As Font) As BlockFormat
            Dim fmt As New BlockFormat()
            fmt.Font = f
            fmt._TextBrush = Color.Black
            fmt.SetPadding(Sides.Top, f.Height / 2)
            fmt.SetPadding(Sides.Bottom, f.Height / 2)
            fmt.SetBorder(Sides.Bottom, 3.0F, New LinearGradientBrush(New Point(1, 1), New Point(2, 2), Color.DarkBlue, Color.White))
            fmt.SetTextInset(Sides.All, 1.0F)
            Return fmt
        End Function
    End Class
End Namespace


'Converted By: G Smart Code Converter By Dinesh