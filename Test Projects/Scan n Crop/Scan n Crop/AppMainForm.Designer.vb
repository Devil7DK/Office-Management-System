<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppMainForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ScannedImage1 = New Scan_n_Crop.ScannedImage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me._Twain32 = New Saraff.Twain.Twain32(Me.components)
        Me.Browse_JPEG_Output = New System.Windows.Forms.FolderBrowserDialog()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_ShowDefaultUI = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.dataSourcesToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_Resolutions = New Scan_n_Crop.ToolStripNumberControl()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.pixelTypesToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Scan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_LoadPDF = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_A4Ratio = New Scan_n_Crop.ToolStripNumberControl()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_SavePDF = New System.Windows.Forms.ToolStripButton()
        Me.btn_SaveAsJpeg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_CompressImage = New System.Windows.Forms.ToolStripButton()
        Me.btn_AutoSave = New System.Windows.Forms.ToolStripButton()
        Me.btn_OpenFolder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btn_AddNewPage = New System.Windows.Forms.ToolStripButton()
        Me.btn_MoveLeft = New System.Windows.Forms.ToolStripButton()
        Me.btn_MoveRight = New System.Windows.Forms.ToolStripButton()
        Me.btn_RemoveCurrentPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_AutoPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Print = New System.Windows.Forms.ToolStripButton()
        Me.btn_PrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.SavePDF = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Browse_LoadPDF = New System.Windows.Forms.OpenFileDialog()
        Me.Browse_Images = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ScannedImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 132)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scanned Pages"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ScannedImage1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(819, 113)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ScannedImage1
        '
        Me.ScannedImage1.AllowDrop = True
        Me.ScannedImage1.Image = CType(resources.GetObject("ScannedImage1.Image"), System.Drawing.Image)
        Me.ScannedImage1.Location = New System.Drawing.Point(3, 3)
        Me.ScannedImage1.Name = "ScannedImage1"
        Me.ScannedImage1.Size = New System.Drawing.Size(140, 99)
        Me.ScannedImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ScannedImage1.TabIndex = 0
        Me.ScannedImage1.TabStop = False
        Me.ScannedImage1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 169)
        Me.TabControl1.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(825, 188)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pages for Output"
        '
        '_Twain32
        '
        Me._Twain32.AppProductName = "Saraff.Twain.NET"
        Me._Twain32.Country = Saraff.Twain.TwCountry.INDIA
        Me._Twain32.IsTwain2Enable = True
        Me._Twain32.Language = Saraff.Twain.TwLanguage.ENGLISH_UK
        Me._Twain32.Parent = Me
        Me._Twain32.ShowUI = False
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(875, 135)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ShowDefaultUI, Me.ToolStripSeparator4, Me.ToolStripLabel3, Me.dataSourcesToolStripComboBox, Me.ToolStripSeparator5, Me.ToolStripLabel4, Me.cmb_Resolutions, Me.ToolStripSeparator6, Me.ToolStripLabel5, Me.pixelTypesToolStripDropDownButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btn_ShowDefaultUI
        '
        Me.btn_ShowDefaultUI.CheckOnClick = True
        Me.btn_ShowDefaultUI.Image = Global.Scan_n_Crop.My.Resources.Resources.Monitor_02_WF
        Me.btn_ShowDefaultUI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ShowDefaultUI.Name = "btn_ShowDefaultUI"
        Me.btn_ShowDefaultUI.Size = New System.Drawing.Size(147, 22)
        Me.btn_ShowDefaultUI.Text = "Show Default Scanner UI"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel3.Text = "Source :"
        '
        'dataSourcesToolStripComboBox
        '
        Me.dataSourcesToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dataSourcesToolStripComboBox.Name = "dataSourcesToolStripComboBox"
        Me.dataSourcesToolStripComboBox.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripLabel4.Text = "Resolution :"
        '
        'cmb_Resolutions
        '
        Me.cmb_Resolutions.Name = "cmb_Resolutions"
        Me.cmb_Resolutions.Size = New System.Drawing.Size(45, 22)
        Me.cmb_Resolutions.Text = "0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel5.Text = "Color :"
        '
        'pixelTypesToolStripDropDownButton
        '
        Me.pixelTypesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.pixelTypesToolStripDropDownButton.Image = CType(resources.GetObject("pixelTypesToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.pixelTypesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pixelTypesToolStripDropDownButton.Name = "pixelTypesToolStripDropDownButton"
        Me.pixelTypesToolStripDropDownButton.Size = New System.Drawing.Size(40, 22)
        Me.pixelTypesToolStripDropDownButton.Text = "RGB"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Scan, Me.ToolStripSeparator1, Me.btn_LoadPDF, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.txt_A4Ratio, Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.btn_SavePDF, Me.btn_SaveAsJpeg, Me.ToolStripSeparator8, Me.btn_CompressImage, Me.btn_AutoSave, Me.btn_OpenFolder})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Scan
        '
        Me.btn_Scan.Image = Global.Scan_n_Crop.My.Resources.Resources.Document_Add_01
        Me.btn_Scan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Scan.Name = "btn_Scan"
        Me.btn_Scan.Size = New System.Drawing.Size(101, 22)
        Me.btn_Scan.Text = "Scan New Page"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_LoadPDF
        '
        Me.btn_LoadPDF.Image = Global.Scan_n_Crop.My.Resources.Resources.Images
        Me.btn_LoadPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_LoadPDF.Name = "btn_LoadPDF"
        Me.btn_LoadPDF.Size = New System.Drawing.Size(74, 22)
        Me.btn_LoadPDF.Text = "Load Files"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel1.Text = "A4 Ratio :"
        '
        'txt_A4Ratio
        '
        Me.txt_A4Ratio.Name = "txt_A4Ratio"
        Me.txt_A4Ratio.Size = New System.Drawing.Size(45, 22)
        Me.txt_A4Ratio.Text = "1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(18, 22)
        Me.ToolStripLabel2.Text = "%"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_SavePDF
        '
        Me.btn_SavePDF.Image = Global.Scan_n_Crop.My.Resources.Resources.PDF_Export
        Me.btn_SavePDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_SavePDF.Name = "btn_SavePDF"
        Me.btn_SavePDF.Size = New System.Drawing.Size(88, 22)
        Me.btn_SavePDF.Text = "Save As PDF"
        '
        'btn_SaveAsJpeg
        '
        Me.btn_SaveAsJpeg.Image = Global.Scan_n_Crop.My.Resources.Resources.Save_02_WF
        Me.btn_SaveAsJpeg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_SaveAsJpeg.Name = "btn_SaveAsJpeg"
        Me.btn_SaveAsJpeg.Size = New System.Drawing.Size(93, 22)
        Me.btn_SaveAsJpeg.Text = "Save As JPEG"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btn_CompressImage
        '
        Me.btn_CompressImage.Checked = True
        Me.btn_CompressImage.CheckOnClick = True
        Me.btn_CompressImage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_CompressImage.Image = Global.Scan_n_Crop.My.Resources.Resources.Zip_file_03_WF
        Me.btn_CompressImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_CompressImage.Name = "btn_CompressImage"
        Me.btn_CompressImage.Size = New System.Drawing.Size(107, 22)
        Me.btn_CompressImage.Text = "Compress Image"
        '
        'btn_AutoSave
        '
        Me.btn_AutoSave.Checked = True
        Me.btn_AutoSave.CheckOnClick = True
        Me.btn_AutoSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_AutoSave.Image = Global.Scan_n_Crop.My.Resources.Resources.Folder_WF
        Me.btn_AutoSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_AutoSave.Name = "btn_AutoSave"
        Me.btn_AutoSave.Size = New System.Drawing.Size(107, 22)
        Me.btn_AutoSave.Text = "Auto Select Path"
        '
        'btn_OpenFolder
        '
        Me.btn_OpenFolder.Image = Global.Scan_n_Crop.My.Resources.Resources.Open_Folder_WF
        Me.btn_OpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_OpenFolder.Name = "btn_OpenFolder"
        Me.btn_OpenFolder.Size = New System.Drawing.Size(86, 22)
        Me.btn_OpenFolder.Text = "Open Folder"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_AddNewPage, Me.btn_MoveLeft, Me.btn_MoveRight, Me.btn_RemoveCurrentPage, Me.ToolStripSeparator7, Me.btn_AutoPage, Me.ToolStripSeparator9, Me.btn_Print, Me.btn_PrintPreview})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 50)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip3.TabIndex = 7
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btn_AddNewPage
        '
        Me.btn_AddNewPage.Image = Global.Scan_n_Crop.My.Resources.Resources.add_page
        Me.btn_AddNewPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_AddNewPage.Name = "btn_AddNewPage"
        Me.btn_AddNewPage.Size = New System.Drawing.Size(97, 22)
        Me.btn_AddNewPage.Text = "Add New Page"
        '
        'btn_MoveLeft
        '
        Me.btn_MoveLeft.Image = Global.Scan_n_Crop.My.Resources.Resources.browser
        Me.btn_MoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_MoveLeft.Name = "btn_MoveLeft"
        Me.btn_MoveLeft.Size = New System.Drawing.Size(75, 22)
        Me.btn_MoveLeft.Text = "Move Left"
        '
        'btn_MoveRight
        '
        Me.btn_MoveRight.Image = Global.Scan_n_Crop.My.Resources.Resources.browser___Copy
        Me.btn_MoveRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_MoveRight.Name = "btn_MoveRight"
        Me.btn_MoveRight.Size = New System.Drawing.Size(81, 22)
        Me.btn_MoveRight.Text = "Move Right"
        '
        'btn_RemoveCurrentPage
        '
        Me.btn_RemoveCurrentPage.Image = Global.Scan_n_Crop.My.Resources.Resources.Print_02_WF
        Me.btn_RemoveCurrentPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_RemoveCurrentPage.Name = "btn_RemoveCurrentPage"
        Me.btn_RemoveCurrentPage.Size = New System.Drawing.Size(93, 22)
        Me.btn_RemoveCurrentPage.Text = "Remove Page"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btn_AutoPage
        '
        Me.btn_AutoPage.Checked = True
        Me.btn_AutoPage.CheckOnClick = True
        Me.btn_AutoPage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_AutoPage.Image = Global.Scan_n_Crop.My.Resources.Resources.Clipboard_Next_Down
        Me.btn_AutoPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_AutoPage.Name = "btn_AutoPage"
        Me.btn_AutoPage.Size = New System.Drawing.Size(159, 22)
        Me.btn_AutoPage.Text = "Auto Page Scanned Images"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btn_Print
        '
        Me.btn_Print.Image = Global.Scan_n_Crop.My.Resources.Resources.Print_02_WF
        Me.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(49, 22)
        Me.btn_Print.Text = "Print"
        '
        'btn_PrintPreview
        '
        Me.btn_PrintPreview.Image = Global.Scan_n_Crop.My.Resources.Resources.Print
        Me.btn_PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_PrintPreview.Name = "btn_PrintPreview"
        Me.btn_PrintPreview.Size = New System.Drawing.Size(90, 22)
        Me.btn_PrintPreview.Text = "Print Preview"
        '
        'SavePDF
        '
        Me.SavePDF.DefaultExt = "pdf"
        Me.SavePDF.FileName = "Untitled.pdf"
        Me.SavePDF.Filter = "Portable Document Files (*.pdf)|*.pdf"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Scanner Print"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Browse_LoadPDF
        '
        Me.Browse_LoadPDF.DefaultExt = "pdf"
        Me.Browse_LoadPDF.FileName = "*.pdf"
        Me.Browse_LoadPDF.Filter = "Portable Document Files (*.pdf)|*.pdf"
        '
        'Browse_Images
        '
        Me.Browse_Images.Filter = "All Supported Image Files|*.bmp;*.jpeg;*.jpg;*.tiff;*.png;*.gif"
        Me.Browse_Images.Multiselect = True
        '
        'AppMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 395)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(833, 422)
        Me.Name = "AppMainForm"
        Me.Text = "Devil7 Scan-n-Crop"
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ScannedImage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ScannedImage1 As Scan_n_Crop.ScannedImage
    Friend WithEvents _Twain32 As Saraff.Twain.Twain32
    Friend WithEvents Browse_JPEG_Output As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Scan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_LoadPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txt_A4Ratio As ToolStripNumberControl
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_SavePDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_SaveAsJpeg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ShowDefaultUI As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dataSourcesToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmb_Resolutions As Scan_n_Crop.ToolStripNumberControl
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents pixelTypesToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_AddNewPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_RemoveCurrentPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_AutoPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents SavePDF As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_CompressImage As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_Print As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_PrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents Browse_LoadPDF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Browse_Images As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_MoveLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_MoveRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_AutoSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_OpenFolder As System.Windows.Forms.ToolStripButton

End Class
