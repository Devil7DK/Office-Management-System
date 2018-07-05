Imports Saraff.Twain
Imports PdfSharp.Drawing
Imports System.IO
Imports Inlite.ClearImageNet

Public Class AppMainForm
    Sub _OnEditPage(sender As Object, e As EditPageEventArgs)
        RepairPage(e.Editor)
    End Sub
    Sub RepairPage(editor As Inlite.ClearImageNet.ImageEditor)
        editor.ClearBackground(30)
        editor.AutoDeskew()
        editor.AutoRotate()
        editor.AutoCrop(10, 10, 10, 10)
        editor.ToBitonal()
        editor.BorderExtract(BorderExtractMode.deskewCrop)
        editor.RemovePunchHoles()
        editor.SmoothCharacters()
        editor.CleanNoise(3)
        editor.ReconstructLines(LineDirection.horzAndVert)
    End Sub
    Dim Loaded As Boolean = False
    Function ClearImage(ByVal Stream As Stream) As Stream
        Dim ie As New Inlite.ClearImageNet.ImageEditor
        Dim out As MemoryStream = ie.Edit(Stream, AddressOf _OnEditPage, ImageFileFormat.jpeg)
        Return out
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Loaded = False
        Try
            Me._Twain32.OpenDSM()

            'Fill list of data sorces
            Me.dataSourcesToolStripComboBox.Items.Clear()
            For i = 0 To Me._Twain32.SourcesCount - 1 Step 1
                Me.dataSourcesToolStripComboBox.Items.Add(Me._Twain32.GetSourceProductName(i))
            Next
            If Me._Twain32.SourcesCount > 0 Then
                Me.dataSourcesToolStripComboBox.SelectedIndex = 0 'Me._Twain32.SourceIndex
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            txt_A4Ratio.NumericUpDownControl.Value = My.Settings.A4Ratio
            If My.Settings.DefaultPath <> "" AndAlso My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultPath) Then
                btn_AutoSave.Checked = My.Settings.AutoSave
            Else
                btn_AutoSave.Checked = False
            End If
            dataSourcesToolStripComboBox.SelectedIndex = My.Settings.Source
            If My.Settings.ColorType <> "" Then
                For Each i As ToolStripItem In pixelTypesToolStripDropDownButton.DropDownItems
                    If i.Text = My.Settings.ColorType Then
                        Me.pixelTypesToolStripDropDownButton.Text = i.Text
                        Me.pixelTypesToolStripDropDownButton.Tag = i.Tag
                    End If
                Next
            End If
            cmb_Resolutions.NumericUpDownControl.Value = My.Settings.Resolution
            btn_ShowDefaultUI.Checked = My.Settings.ShowDefaultUI
            btn_AutoPage.Checked = My.Settings.AutoPage
            btn_AutoSave.Checked = My.Settings.AutoSave
        Catch ex As Exception

        End Try
        Loaded = True
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn_Scan_Click(sender As System.Object, e As System.EventArgs) Handles btn_Scan.Click
        Try

            '#region Examples of the capabilities

            'Brightness
            If (Me._Twain32.IsCapSupported(TwCap.Brightness) And TwQC.Set) <> 0 Then
                Me._Twain32.SetCap(TwCap.Brightness, 0.0F) 'Allowed Values: -1000.0F to +1000.0F; Default Value: 0.0F;
            End If

            'Contrast
            If (Me._Twain32.IsCapSupported(TwCap.Contrast) And TwQC.Set) <> 0 Then
                Me._Twain32.SetCap(TwCap.Contrast, 0.0F) 'Allowed Values: -1000.0F to +1000.0F; Default Value: 0.0F;
            End If

            '#endregion

            Me._Twain32.Acquire()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub AddScannedImage(ByVal Image As Image, Optional ByVal ConsiderAutopaging As Boolean = True)
        Dim s As New ScannedImage()
        Dim ms As New IO.MemoryStream
        Image.Save(ms, Imaging.ImageFormat.Jpeg)
        s.Image = Image.FromStream(ClearImage(ms))
        s.SizeMode = PictureBoxSizeMode.Zoom
        FlowLayoutPanel1.Controls.Add(s)
        If ConsiderAutopaging Then
            If btn_AutoPage.Checked Then
                If Image.Width > Image.Height Then
                    Dim p As New PageTab(CInt(3508 * (txt_A4Ratio.NumericUpDownControl.Value / 100)), CInt(2480 * (txt_A4Ratio.NumericUpDownControl.Value / 100)))
                    TabControl1.TabPages.Add(p)
                    TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1
                    p.PageContainer.Controls.Add(ControlFactory.CloneCtrl(s))
                    p.PageContainer.ResizeAndSetLocation()
                Else
                    Dim p As New PageTab(CInt(2480 * (txt_A4Ratio.NumericUpDownControl.Value / 100)), CInt(3508 * (txt_A4Ratio.NumericUpDownControl.Value / 100)))
                    TabControl1.TabPages.Add(p)
                    TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1
                    p.PageContainer.Controls.Add(ControlFactory.CloneCtrl(s))
                    p.PageContainer.ResizeAndSetLocation()
                End If
            End If
        End If
    End Sub


#Region "Twain32 events handlers"

    Private Sub _twain32_AcquireCompleted(sender As System.Object, e As System.EventArgs) Handles _Twain32.AcquireCompleted
        Try
            If Me._Twain32.ImageCount > 0 Then
                Me.AddScannedImage(Me._Twain32.GetImage(0))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
    Private Sub dataSourcesToolStripComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles dataSourcesToolStripComboBox.SelectedIndexChanged
        Try
            If Loaded = True Then
                Try
                    My.Settings.Source = dataSourcesToolStripComboBox.SelectedIndex
                    My.Settings.Save()
                Catch ex As Exception

                End Try
            End If
            Me._Twain32.CloseDataSource()
            Me._Twain32.SourceIndex = Me.dataSourcesToolStripComboBox.SelectedIndex
            Me._Twain32.OpenDataSource()

            'Get dpi
            'Me.resolutionToolStripDropDownButton.DropDownItems.Clear()
            Dim _resolutions = Me._Twain32.Capabilities.XResolution.Get()
            'For i = 0 To 20 Step 1 '_resolutions.Count - 1 Step 1
            'Me.resolutionToolStripDropDownButton.DropDownItems.Add(String.Format("{0:N0} dpi", _resolutions(i)), Nothing, AddressOf Me._ResolutionItemSelected).Tag = _resolutions(i)
            'Next
            Resolutions = _resolutions
            cmb_Resolutions.NumericUpDownControl.Minimum = CInt(_resolutions(0).ToString)
            cmb_Resolutions.NumericUpDownControl.Maximum = CInt(_resolutions(_resolutions.Count - 1))
            'Me._ResolutionItemSelected(Me.resolutionToolStripDropDownButton.DropDownItems(_resolutions.DefaultIndex), New EventArgs())
            Try
                Me.cmb_Resolutions.NumericUpDownControl.Value = My.Settings.Resolution
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me._ResolutionItemSelected(Nothing, New EventArgs())
            'End If

            'Get pixel types
            Me.pixelTypesToolStripDropDownButton.DropDownItems.Clear()
            Dim _pixelTypes = Me._Twain32.Capabilities.PixelType.Get()
            Dim LastItem As Object = Nothing
            For i = 0 To _pixelTypes.Count - 1 Step 1
                If My.Settings.ColorType <> "" Then
                    If _pixelTypes(i).ToString = My.Settings.ColorType Then
                        LastItem = _pixelTypes(i)
                    End If
                End If
                Me.pixelTypesToolStripDropDownButton.DropDownItems.Add(String.Format("{0}", _pixelTypes(i)), Nothing, AddressOf Me._PixelTypeItemSelected).Tag = _pixelTypes(i)
            Next
            Try
                If My.Settings.ColorType <> "" AndAlso LastItem IsNot Nothing Then
                    Me.pixelTypesToolStripDropDownButton.Text = My.Settings.ColorType
                    Me.pixelTypesToolStripDropDownButton.Tag = LastItem
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim Resolutions As Saraff.Twain.Twain32.Enumeration
    Private Sub _ResolutionItemSelected(sender As Object, e As EventArgs)
        Try
            'Dim _item As ToolStripItem = sender
            'Me.resolutionToolStripDropDownButton.Text = _item.Text
            'Me.resolutionToolStripDropDownButton.Tag = _item.Tag
            Dim i As Object = Resolutions(cmb_Resolutions.NumericUpDownControl.Value - cmb_Resolutions.NumericUpDownControl.Minimum)
            Me._Twain32.Capabilities.XResolution.Set(i)
            Me._Twain32.Capabilities.YResolution.Set(i)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ResolutionSelection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub _PixelTypeItemSelected(sender As Object, e As EventArgs)
        Try
            Dim _item As ToolStripItem = sender
            Me.pixelTypesToolStripDropDownButton.Text = _item.Text
            Me.pixelTypesToolStripDropDownButton.Tag = _item.Tag
            Me._Twain32.Capabilities.PixelType.Set(_item.Tag)
            Try
                If Loaded Then
                    My.Settings.ColorType = _item.Text
                    My.Settings.Save()
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_ShowDefaultUI_Click(sender As System.Object, e As System.EventArgs) Handles btn_ShowDefaultUI.Click
        _Twain32.ShowUI = btn_ShowDefaultUI.Checked
        If Loaded Then
            My.Settings.ShowDefaultUI = btn_ShowDefaultUI.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmb_Resolutions_ValueChanged(sender As Object, e As System.EventArgs) Handles cmb_Resolutions.ValueChanged
        Try
            'Dim _item As ToolStripItem = sender
            'Me.resolutionToolStripDropDownButton.Text = _item.Text
            'Me.resolutionToolStripDropDownButton.Tag = _item.Tag
            Dim i As Object = Resolutions(cmb_Resolutions.NumericUpDownControl.Value - cmb_Resolutions.NumericUpDownControl.Minimum)
            Me._Twain32.Capabilities.XResolution.Set(i)
            Me._Twain32.Capabilities.YResolution.Set(i)
            Try
                If Loaded Then
                    My.Settings.Resolution = cmb_Resolutions.NumericUpDownControl.Value
                    My.Settings.Save()
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ResolutionSelection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_SaveAsJpeg_Click(sender As System.Object, e As System.EventArgs) Handles btn_SaveAsJpeg.Click
        If btn_AutoSave.Checked Then
            Dim dir As String = IO.Path.Combine(My.Settings.DefaultPath, "img_" & Now.ToString("hhmmss_ddMMyyyy"))
            Try
                My.Computer.FileSystem.CreateDirectory(dir)
            Catch ex As Exception

            End Try
            For i As Integer = 0 To TabControl1.TabPages.Count - 1
                Dim tp As PageTab = TabControl1.TabPages(i)
                Dim b As New Bitmap(tp.PageWidth, tp.PageHeight)
                Dim g As Graphics = Graphics.FromImage(b)
                tp.PageContainer.Width = tp.PageWidth
                tp.PageContainer.Height = tp.PageHeight
                g.Clear(Color.White)
                For Each c As ScannedImage In tp.PageContainer.Controls
                    Dim rect As New Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height) 'Dim rect As New Rectangle(c.Location.X * (p / 100), c.Location.Y * (p / 100), c.Width * (p / 100), c.Height * (p / 100))
                    g.DrawImage(c.Image, rect)
                Next
                g.Dispose()
                tp.ResizeSetLocation()
                If btn_CompressImage.Checked Then
                    CompressImage(b).Save(IO.Path.Combine(dir, "img_" & i & ".jpeg"), Imaging.ImageFormat.Jpeg)
                Else
                    b.Save(IO.Path.Combine(dir, "img_" & i & ".jpeg"), Imaging.ImageFormat.Jpeg)
                End If
                b.Dispose()
            Next
            MsgBox("Successfully saved images.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done!")
            Process.Start(dir)
        Else
            If Browse_JPEG_Output.ShowDialog = Windows.Forms.DialogResult.OK Then
                For i As Integer = 0 To TabControl1.TabPages.Count - 1
                    Dim tp As PageTab = TabControl1.TabPages(i)
                    Dim b As New Bitmap(tp.PageWidth, tp.PageHeight)
                    Dim g As Graphics = Graphics.FromImage(b)
                    tp.PageContainer.Width = tp.PageWidth
                    tp.PageContainer.Height = tp.PageHeight
                    g.Clear(Color.White)
                    For Each c As ScannedImage In tp.PageContainer.Controls
                        Dim rect As New Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height) 'Dim rect As New Rectangle(c.Location.X * (p / 100), c.Location.Y * (p / 100), c.Width * (p / 100), c.Height * (p / 100))
                        g.DrawImage(c.Image, rect)
                    Next
                    g.Dispose()
                    tp.ResizeSetLocation()
                    If btn_CompressImage.Checked Then
                        CompressImage(b).Save(IO.Path.Combine(Browse_JPEG_Output.SelectedPath, "img_" & i & ".jpeg"), Imaging.ImageFormat.Jpeg)
                    Else
                        b.Save(IO.Path.Combine(Browse_JPEG_Output.SelectedPath, "img_" & i & ".jpeg"), Imaging.ImageFormat.Jpeg)
                    End If
                    b.Dispose()
                Next
                MsgBox("Successfully saved images.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done!")
                Process.Start(Browse_JPEG_Output.SelectedPath)
            End If
        End If
    End Sub
    Private Sub btn_AddNewPage_Click(sender As System.Object, e As System.EventArgs) Handles btn_AddNewPage.Click
        Dim p As New PageTab(CInt(2480 * (txt_A4Ratio.NumericUpDownControl.Value / 100)), CInt(3508 * (txt_A4Ratio.NumericUpDownControl.Value / 100)))
        TabControl1.TabPages.Add(p)
    End Sub

    Private Sub btn_RemoveCurrentPage_Click(sender As System.Object, e As System.EventArgs) Handles btn_RemoveCurrentPage.Click
        Try
            If TabControl1.SelectedIndex > -1 Then
                TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_SavePDF_Click(sender As System.Object, e As System.EventArgs) Handles btn_SavePDF.Click
        If btn_AutoSave.Checked Then
            Dim file As String = IO.Path.Combine(My.Settings.DefaultPath, "pdf_" & Now.ToString("hhmmss_ddMMyyyy") & ".pdf")
            Dim document As PdfSharp.Pdf.PdfDocument = New PdfSharp.Pdf.PdfDocument
            For i As Integer = 0 To TabControl1.TabPages.Count - 1
                Dim tp As PageTab = TabControl1.TabPages(i)
                Dim b As New Bitmap(tp.PageWidth, tp.PageHeight)
                Dim g As Graphics = Graphics.FromImage(b)
                tp.PageContainer.Width = tp.PageWidth
                tp.PageContainer.Height = tp.PageHeight
                g.Clear(Color.White)
                For Each c As ScannedImage In tp.PageContainer.Controls
                    Dim rect As New Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height) 'Dim rect As New Rectangle(c.Location.X * (p / 100), c.Location.Y * (p / 100), c.Width * (p / 100), c.Height * (p / 100))
                    g.DrawImage(c.Image, rect)
                Next
                g.Dispose()
                tp.ResizeSetLocation()
                Dim img As XImage = XImage.FromGdiPlusImage(If(btn_CompressImage.Checked = True, CompressImage(b), b))
                ' Create an empty page
                Dim page As PdfSharp.Pdf.PdfPage = document.AddPage
                ' Get an XGraphics object for drawing
                Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                If b.Width < b.Height Then
                    page.Orientation = PdfSharp.PageOrientation.Portrait
                Else
                    page.Orientation = PdfSharp.PageOrientation.Landscape
                End If
                Dim per As Double = (img.PointWidth / page.Width.Point)
                Dim height As Double = img.PointHeight * (per)
                gfx.DrawImage(img, New XRect(ExpandToBound(img.Size, New XSize(page.Width.Point, page.Height.Point))))
                ' Draw crossing lines
                b.Dispose()
            Next
            ' Save the document...
            document.Save(file)
            MsgBox("Successfully saved pdf file.", MsgBoxStyle.Information, "Done!")
            Process.Start(file)
        Else
            If SavePDF.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim document As PdfSharp.Pdf.PdfDocument = New PdfSharp.Pdf.PdfDocument
                For i As Integer = 0 To TabControl1.TabPages.Count - 1
                    Dim tp As PageTab = TabControl1.TabPages(i)
                    Dim b As New Bitmap(tp.PageWidth, tp.PageHeight)
                    Dim g As Graphics = Graphics.FromImage(b)
                    tp.PageContainer.Width = tp.PageWidth
                    tp.PageContainer.Height = tp.PageHeight
                    g.Clear(Color.White)
                    For Each c As ScannedImage In tp.PageContainer.Controls
                        Dim rect As New Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height) 'Dim rect As New Rectangle(c.Location.X * (p / 100), c.Location.Y * (p / 100), c.Width * (p / 100), c.Height * (p / 100))
                        g.DrawImage(c.Image, rect)
                    Next
                    g.Dispose()
                    tp.ResizeSetLocation()
                    Dim img As XImage = XImage.FromGdiPlusImage(If(btn_CompressImage.Checked = True, CompressImage(b), b))
                    ' Create an empty page
                    Dim page As PdfSharp.Pdf.PdfPage = document.AddPage
                    ' Get an XGraphics object for drawing
                    Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                    If b.Width < b.Height Then
                        page.Orientation = PdfSharp.PageOrientation.Portrait
                    Else
                        page.Orientation = PdfSharp.PageOrientation.Landscape
                    End If
                    Dim per As Double = (img.PointWidth / page.Width.Point)
                    Dim height As Double = img.PointHeight * (per)
                    gfx.DrawImage(img, New XRect(ExpandToBound(img.Size, New XSize(page.Width.Point, page.Height.Point))))
                    ' Draw crossing lines
                    b.Dispose()
                Next
                ' Save the document...
                document.Save(SavePDF.FileName)
                MsgBox("Successfully saved pdf file.", MsgBoxStyle.Information, "Done!")
                Process.Start(SavePDF.FileName)
            End If
        End If
    End Sub
    Function ExpandToBound(ByVal image As XSize, ByVal boundingBox As XSize) As XSize
        Dim widthScale As Double = 0
        Dim heightScale As Double = 0
        If (image.Width <> 0) Then widthScale = boundingBox.Width / image.Width
        If (image.Height <> 0) Then heightScale = boundingBox.Height / image.Height
        Dim Scale As Double = Math.Min(widthScale, heightScale)
        Dim result As New XSize((image.Width * Scale), (image.Height * Scale))
        Return result
    End Function
    Function ExpandToBound(ByVal image As Size, ByVal boundingBox As Size) As Size
        Dim widthScale As Double = 0
        Dim heightScale As Double = 0
        If (image.Width <> 0) Then widthScale = boundingBox.Width / image.Width
        If (image.Height <> 0) Then heightScale = boundingBox.Height / image.Height
        Dim Scale As Double = Math.Min(widthScale, heightScale)
        Dim result As New Size((image.Width * Scale), (image.Height * Scale))
        Return result
    End Function
    Function CompressImage(ByVal Source As Image) As Image
        Dim w, h As Integer
        If Source.Width > Source.Height Then
            h = 793
            w = 1123
        Else
            w = 793
            h = 1123
        End If
        Dim bm As Drawing.Bitmap = New System.Drawing.Bitmap(w, h)
        Dim g As System.Drawing.Graphics = Drawing.Graphics.FromImage(bm)
        g.DrawImage(Source, 0, 0, w, h)
        g.Dispose()
        Return bm
    End Function

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        For Each i As PageTab In TabControl1.TabPages
            i.SetPageName()
        Next
    End Sub
    Dim NumberOfPages, CurrentPage As Integer

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        NumberOfPages = TabControl1.TabPages.Count
        CurrentPage = 0
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim tp As PageTab = TabControl1.TabPages(CurrentPage)
        Dim b As New Bitmap(tp.PageWidth, tp.PageHeight)
        Dim g As Graphics = Graphics.FromImage(b)
        tp.PageContainer.Width = tp.PageWidth
        tp.PageContainer.Height = tp.PageHeight
        g.Clear(Color.White)
        For Each c As ScannedImage In tp.PageContainer.Controls
            Dim rect As New Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height) 'Dim rect As New Rectangle(c.Location.X * (p / 100), c.Location.Y * (p / 100), c.Width * (p / 100), c.Height * (p / 100))
            g.DrawImage(c.Image, rect)
        Next
        g.Dispose()
        tp.ResizeSetLocation()
        If b.Width < b.Height Then
            Dim si As Size = ExpandToBound(b.Size, New Size(e.PageBounds.Size.Width - 40, e.PageBounds.Size.Height - 40))
            Dim x As Integer = (e.PageBounds.Width - si.Width) / 2
            Dim y As Integer = (e.PageBounds.Height - si.Height) / 2
            e.Graphics.DrawImage(b, New Rectangle(New Point(x, y), si))
        Else
            Dim ri As Image = b.Clone
            ri.RotateFlip(RotateFlipType.Rotate90FlipXY)
            Dim si As Size = ExpandToBound(ri.Size, New Size(e.PageBounds.Size.Width - 40, e.PageBounds.Size.Height - 40))
            Dim x As Integer = (e.PageBounds.Width - si.Width) / 2
            Dim y As Integer = (e.PageBounds.Height - si.Height) / 2
            e.Graphics.DrawImage(ri, New Rectangle(New Point(x, y), si))
        End If
        b.Dispose()
        GC.Collect()
        CurrentPage += 1
        If CurrentPage = NumberOfPages Then
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btn_Print_Click(sender As System.Object, e As System.EventArgs) Handles btn_Print.Click
        If TabControl1.TabPages.Count > 0 Then
            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                For i As Integer = 1 To PrintDialog1.PrinterSettings.Copies
                    PrintDocument1.Print()
                Next
            End If
        End If
    End Sub

    Private Sub btn_PrintPreview_Click(sender As System.Object, e As System.EventArgs) Handles btn_PrintPreview.Click
        If TabControl1.TabPages.Count > 0 Then
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
    Private Sub btn_AutoPage_Click(sender As System.Object, e As System.EventArgs) Handles btn_AutoPage.Click
        If Loaded Then
            My.Settings.AutoPage = btn_AutoPage.Checked
            My.Settings.Save()
        End If
    End Sub


    Private Sub btn_LoadPDF_Click(sender As System.Object, e As System.EventArgs) Handles btn_LoadPDF.Click
        If Browse_Images.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each i As String In Browse_Images.FileNames
                AddScannedImage(Image.FromFile(i))
            Next
        End If
    End Sub

    Private Sub btn_MoveLeft_Click(sender As System.Object, e As System.EventArgs) Handles btn_MoveLeft.Click
        If TabControl1.SelectedIndex > 0 Then
            Dim tp As PageTab = TabControl1.TabPages(TabControl1.SelectedIndex)
            Dim i As Integer = TabControl1.SelectedIndex - 1
            TabControl1.TabPages.Remove(tp)
            TabControl1.TabPages.Insert(i, tp)
            For Each t As PageTab In TabControl1.TabPages
                t.SetPageName()
            Next
            TabControl1.SelectedIndex = i
        End If
    End Sub

    Private Sub btn_MoveRight_Click(sender As System.Object, e As System.EventArgs) Handles btn_MoveRight.Click
        If TabControl1.SelectedIndex < TabControl1.TabPages.Count - 1 Then
            Dim tp As PageTab = TabControl1.TabPages(TabControl1.SelectedIndex)
            Dim i As Integer = TabControl1.SelectedIndex + 1
            TabControl1.TabPages.Remove(tp)
            TabControl1.TabPages.Insert(i, tp)
            For Each t As PageTab In TabControl1.TabPages
                t.SetPageName()
            Next
            TabControl1.SelectedIndex = i
        End If
    End Sub


    Private Sub btn_AutoSave_Click(sender As System.Object, e As System.EventArgs) Handles btn_AutoSave.Click
        If Loaded Then
            If btn_AutoSave.Checked Then
                Dim d As New FolderBrowserDialog
                d.SelectedPath = My.Settings.DefaultPath
                If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Settings.DefaultPath = d.SelectedPath
                End If
                If My.Settings.DefaultPath <> "" AndAlso My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultPath) Then
                    btn_AutoSave.Checked = True
                Else
                    btn_AutoSave.Checked = False
                End If
            End If
            My.Settings.AutoSave = btn_AutoSave.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub txt_A4Ratio_ValueChanged(sender As Object, e As System.EventArgs) Handles txt_A4Ratio.ValueChanged
        If Loaded Then
            My.Settings.A4Ratio = txt_A4Ratio.NumericUpDownControl.Value
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_OpenFolder_Click(sender As Object, e As System.EventArgs) Handles btn_OpenFolder.Click
        Try
            If My.Settings.DefaultPath <> "" AndAlso My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultPath) Then
                Process.Start(My.Settings.DefaultPath)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
