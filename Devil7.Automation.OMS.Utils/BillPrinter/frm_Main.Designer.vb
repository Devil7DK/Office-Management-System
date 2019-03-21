<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Sender = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Services = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Settings = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btn_Export_Excel = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FeesItems = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_PDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Others = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_ExportFormats = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Export_Word = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_HTML = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_MHTML = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_RTF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Image = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Mail_HTML = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_MailFormats = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Export_Mail_PDF_HTML = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Mail_PDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FromAddresses = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SmallCover = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BigCover = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Items = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Report = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Covers = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Export = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_Bills = New DevExpress.XtraGrid.GridControl()
        Me.gv_Bills = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Loader = New System.ComponentModel.BackgroundWorker()
        Me.btn_PrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.tc_Main = New DevExpress.XtraTab.XtraTabControl()
        Me.tab_Bills = New DevExpress.XtraTab.XtraTabPage()
        Me.tab_FeesReminders = New DevExpress.XtraTab.XtraTabPage()
        Me.gc_FeesReminders = New DevExpress.XtraGrid.GridControl()
        Me.gv_FeesReminders = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dlg_Save = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_ExportFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_MailFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Bills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Bills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tc_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Main.SuspendLayout()
        Me.tab_Bills.SuspendLayout()
        Me.tab_FeesReminders.SuspendLayout()
        CType(Me.gc_FeesReminders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_FeesReminders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Refresh, Me.btn_Add, Me.btn_Edit, Me.btn_Remove, Me.btn_Print, Me.btn_Sender, Me.btn_Services, Me.btn_Settings, Me.SkinRibbonGalleryBarItem1, Me.btn_Export_Excel, Me.btn_FeesItems, Me.btn_Export_PDF, Me.btn_Export_Others, Me.btn_Export_Word, Me.btn_Export_HTML, Me.btn_Export_RTF, Me.btn_Export_Image, Me.btn_Export_MHTML, Me.btn_Export_Mail_HTML, Me.btn_FromAddresses, Me.btn_Export_Mail_PDF_HTML, Me.btn_Export_Mail_PDF, Me.btn_SmallCover, Me.btn_BigCover})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 28
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1206, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Caption = "Refresh"
        Me.btn_Refresh.Id = 1
        Me.btn_Refresh.ImageOptions.SvgImage = CType(resources.GetObject("btn_Refresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Refresh.Name = "btn_Refresh"
        '
        'btn_Add
        '
        Me.btn_Add.Caption = "Add"
        Me.btn_Add.Id = 2
        Me.btn_Add.ImageOptions.SvgImage = CType(resources.GetObject("btn_Add.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Add.Name = "btn_Add"
        '
        'btn_Edit
        '
        Me.btn_Edit.Caption = "Edit"
        Me.btn_Edit.Id = 3
        Me.btn_Edit.ImageOptions.SvgImage = CType(resources.GetObject("btn_Edit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Edit.Name = "btn_Edit"
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 4
        Me.btn_Remove.ImageOptions.SvgImage = CType(resources.GetObject("btn_Remove.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Remove.Name = "btn_Remove"
        '
        'btn_Print
        '
        Me.btn_Print.Caption = "Print"
        Me.btn_Print.Id = 5
        Me.btn_Print.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print.Name = "btn_Print"
        '
        'btn_Sender
        '
        Me.btn_Sender.Caption = "Senders"
        Me.btn_Sender.Id = 9
        Me.btn_Sender.ImageOptions.SvgImage = CType(resources.GetObject("btn_Sender.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Sender.Name = "btn_Sender"
        '
        'btn_Services
        '
        Me.btn_Services.Caption = "Services"
        Me.btn_Services.Id = 10
        Me.btn_Services.ImageOptions.SvgImage = CType(resources.GetObject("btn_Services.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Services.Name = "btn_Services"
        '
        'btn_Settings
        '
        Me.btn_Settings.Caption = "Settings"
        Me.btn_Settings.Id = 11
        Me.btn_Settings.ImageOptions.SvgImage = CType(resources.GetObject("btn_Settings.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Settings.Name = "btn_Settings"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 12
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btn_Export_Excel
        '
        Me.btn_Export_Excel.Caption = "Excel"
        Me.btn_Export_Excel.Id = 13
        Me.btn_Export_Excel.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Excel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Excel.Name = "btn_Export_Excel"
        '
        'btn_FeesItems
        '
        Me.btn_FeesItems.Caption = "Fees Items"
        Me.btn_FeesItems.Id = 14
        Me.btn_FeesItems.ImageOptions.SvgImage = CType(resources.GetObject("btn_FeesItems.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_FeesItems.Name = "btn_FeesItems"
        '
        'btn_Export_PDF
        '
        Me.btn_Export_PDF.Caption = "Export to PDF"
        Me.btn_Export_PDF.Id = 15
        Me.btn_Export_PDF.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_PDF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_PDF.Name = "btn_Export_PDF"
        '
        'btn_Export_Others
        '
        Me.btn_Export_Others.ActAsDropDown = True
        Me.btn_Export_Others.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Export_Others.Caption = "Other Formats"
        Me.btn_Export_Others.DropDownControl = Me.Menu_ExportFormats
        Me.btn_Export_Others.Id = 16
        Me.btn_Export_Others.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Others.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Others.Name = "btn_Export_Others"
        '
        'Menu_ExportFormats
        '
        Me.Menu_ExportFormats.ItemLinks.Add(Me.btn_Export_Word)
        Me.Menu_ExportFormats.ItemLinks.Add(Me.btn_Export_HTML)
        Me.Menu_ExportFormats.ItemLinks.Add(Me.btn_Export_MHTML)
        Me.Menu_ExportFormats.ItemLinks.Add(Me.btn_Export_RTF)
        Me.Menu_ExportFormats.ItemLinks.Add(Me.btn_Export_Image)
        Me.Menu_ExportFormats.Name = "Menu_ExportFormats"
        Me.Menu_ExportFormats.Ribbon = Me.RibbonControl
        '
        'btn_Export_Word
        '
        Me.btn_Export_Word.Caption = "Word Document"
        Me.btn_Export_Word.Id = 17
        Me.btn_Export_Word.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Word.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Word.Name = "btn_Export_Word"
        '
        'btn_Export_HTML
        '
        Me.btn_Export_HTML.Caption = "HTML Webpage"
        Me.btn_Export_HTML.Id = 18
        Me.btn_Export_HTML.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_HTML.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_HTML.Name = "btn_Export_HTML"
        '
        'btn_Export_MHTML
        '
        Me.btn_Export_MHTML.Caption = "Microsoft HTML"
        Me.btn_Export_MHTML.Id = 21
        Me.btn_Export_MHTML.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_MHTML.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_MHTML.Name = "btn_Export_MHTML"
        '
        'btn_Export_RTF
        '
        Me.btn_Export_RTF.Caption = "Rich Text Format"
        Me.btn_Export_RTF.Id = 19
        Me.btn_Export_RTF.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_RTF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_RTF.Name = "btn_Export_RTF"
        '
        'btn_Export_Image
        '
        Me.btn_Export_Image.Caption = "JPEG Image"
        Me.btn_Export_Image.Id = 20
        Me.btn_Export_Image.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Image.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Image.Name = "btn_Export_Image"
        '
        'btn_Export_Mail_HTML
        '
        Me.btn_Export_Mail_HTML.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Export_Mail_HTML.Caption = "E-Mail"
        Me.btn_Export_Mail_HTML.DropDownControl = Me.Menu_MailFormats
        Me.btn_Export_Mail_HTML.Id = 22
        Me.btn_Export_Mail_HTML.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Mail_HTML.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Mail_HTML.Name = "btn_Export_Mail_HTML"
        '
        'Menu_MailFormats
        '
        Me.Menu_MailFormats.ItemLinks.Add(Me.btn_Export_Mail_PDF_HTML)
        Me.Menu_MailFormats.ItemLinks.Add(Me.btn_Export_Mail_PDF)
        Me.Menu_MailFormats.Name = "Menu_MailFormats"
        Me.Menu_MailFormats.Ribbon = Me.RibbonControl
        '
        'btn_Export_Mail_PDF_HTML
        '
        Me.btn_Export_Mail_PDF_HTML.Caption = "PDF && HTML Message"
        Me.btn_Export_Mail_PDF_HTML.Id = 24
        Me.btn_Export_Mail_PDF_HTML.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Mail_PDF_HTML.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Mail_PDF_HTML.Name = "btn_Export_Mail_PDF_HTML"
        '
        'btn_Export_Mail_PDF
        '
        Me.btn_Export_Mail_PDF.Caption = "PDF Only"
        Me.btn_Export_Mail_PDF.Id = 25
        Me.btn_Export_Mail_PDF.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Mail_PDF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Mail_PDF.Name = "btn_Export_Mail_PDF"
        '
        'btn_FromAddresses
        '
        Me.btn_FromAddresses.Caption = "From Addresses"
        Me.btn_FromAddresses.Id = 23
        Me.btn_FromAddresses.ImageOptions.SvgImage = CType(resources.GetObject("btn_FromAddresses.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_FromAddresses.Name = "btn_FromAddresses"
        '
        'btn_SmallCover
        '
        Me.btn_SmallCover.Caption = "Small"
        Me.btn_SmallCover.Id = 26
        Me.btn_SmallCover.ImageOptions.SvgImage = CType(resources.GetObject("btn_SmallCover.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SmallCover.Name = "btn_SmallCover"
        '
        'btn_BigCover
        '
        Me.btn_BigCover.Caption = "Long"
        Me.btn_BigCover.Id = 27
        Me.btn_BigCover.ImageOptions.SvgImage = CType(resources.GetObject("btn_BigCover.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_BigCover.Name = "btn_BigCover"
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Items, Me.rpg_Report, Me.rpg_Covers, Me.rpg_Export, Me.RibbonPageGroup2})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_Items
        '
        Me.rpg_Items.ItemLinks.Add(Me.btn_Refresh)
        Me.rpg_Items.ItemLinks.Add(Me.btn_Add, True)
        Me.rpg_Items.ItemLinks.Add(Me.btn_Edit)
        Me.rpg_Items.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_Items.Name = "rpg_Items"
        Me.rpg_Items.ShowCaptionButton = False
        Me.rpg_Items.Text = "Items"
        '
        'rpg_Report
        '
        Me.rpg_Report.ItemLinks.Add(Me.btn_Print)
        Me.rpg_Report.ItemLinks.Add(Me.btn_Export_Mail_HTML, True)
        Me.rpg_Report.Name = "rpg_Report"
        Me.rpg_Report.ShowCaptionButton = False
        Me.rpg_Report.Text = "Bill"
        '
        'rpg_Covers
        '
        Me.rpg_Covers.ItemLinks.Add(Me.btn_SmallCover)
        Me.rpg_Covers.ItemLinks.Add(Me.btn_BigCover)
        Me.rpg_Covers.Name = "rpg_Covers"
        Me.rpg_Covers.ShowCaptionButton = False
        Me.rpg_Covers.Text = "Covers"
        '
        'rpg_Export
        '
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_PDF)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_Others)
        Me.rpg_Export.Name = "rpg_Export"
        Me.rpg_Export.ShowCaptionButton = False
        Me.rpg_Export.Text = "Export"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_Sender)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_Services)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_FeesItems)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_FromAddresses)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_Settings, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Others"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1206, 31)
        '
        'gc_Bills
        '
        Me.gc_Bills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Bills.Location = New System.Drawing.Point(0, 0)
        Me.gc_Bills.MainView = Me.gv_Bills
        Me.gc_Bills.MenuManager = Me.RibbonControl
        Me.gc_Bills.Name = "gc_Bills"
        Me.gc_Bills.Size = New System.Drawing.Size(1200, 247)
        Me.gc_Bills.TabIndex = 2
        Me.gc_Bills.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Bills})
        '
        'gv_Bills
        '
        Me.gv_Bills.GridControl = Me.gc_Bills
        Me.gv_Bills.Name = "gv_Bills"
        Me.gv_Bills.OptionsBehavior.Editable = False
        Me.gv_Bills.OptionsBehavior.ReadOnly = True
        '
        'Loader
        '
        '
        'btn_PrintPreview
        '
        Me.btn_PrintPreview.Caption = "Preview"
        Me.btn_PrintPreview.Id = 6
        Me.btn_PrintPreview.ImageOptions.SvgImage = CType(resources.GetObject("btn_PrintPreview.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_PrintPreview.Name = "btn_PrintPreview"
        '
        'tc_Main
        '
        Me.tc_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_Main.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.tc_Main.Location = New System.Drawing.Point(0, 143)
        Me.tc_Main.Name = "tc_Main"
        Me.tc_Main.SelectedTabPage = Me.tab_Bills
        Me.tc_Main.Size = New System.Drawing.Size(1206, 275)
        Me.tc_Main.TabIndex = 9
        Me.tc_Main.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab_Bills, Me.tab_FeesReminders})
        '
        'tab_Bills
        '
        Me.tab_Bills.Controls.Add(Me.gc_Bills)
        Me.tab_Bills.Name = "tab_Bills"
        Me.tab_Bills.Size = New System.Drawing.Size(1200, 247)
        Me.tab_Bills.Text = "Bills"
        '
        'tab_FeesReminders
        '
        Me.tab_FeesReminders.Controls.Add(Me.gc_FeesReminders)
        Me.tab_FeesReminders.Name = "tab_FeesReminders"
        Me.tab_FeesReminders.Size = New System.Drawing.Size(1200, 247)
        Me.tab_FeesReminders.Text = "Fees Reminders"
        '
        'gc_FeesReminders
        '
        Me.gc_FeesReminders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_FeesReminders.Location = New System.Drawing.Point(0, 0)
        Me.gc_FeesReminders.MainView = Me.gv_FeesReminders
        Me.gc_FeesReminders.MenuManager = Me.RibbonControl
        Me.gc_FeesReminders.Name = "gc_FeesReminders"
        Me.gc_FeesReminders.Size = New System.Drawing.Size(1200, 247)
        Me.gc_FeesReminders.TabIndex = 3
        Me.gc_FeesReminders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_FeesReminders})
        '
        'gv_FeesReminders
        '
        Me.gv_FeesReminders.GridControl = Me.gc_FeesReminders
        Me.gv_FeesReminders.Name = "gv_FeesReminders"
        Me.gv_FeesReminders.OptionsBehavior.Editable = False
        Me.gv_FeesReminders.OptionsBehavior.ReadOnly = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 449)
        Me.Controls.Add(Me.tc_Main)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Devil7 - Bills & Fees Reminder Printer"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_ExportFormats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_MailFormats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Bills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Bills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tc_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Main.ResumeLayout(False)
        Me.tab_Bills.ResumeLayout(False)
        Me.tab_FeesReminders.ResumeLayout(False)
        CType(Me.gc_FeesReminders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_FeesReminders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Items As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents gc_Bills As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Bills As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpg_Report As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Sender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Services As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Settings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btn_Export_Excel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Loader As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_PrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tc_Main As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab_Bills As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab_FeesReminders As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc_FeesReminders As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_FeesReminders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_FeesItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_PDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_Save As SaveFileDialog
    Friend WithEvents btn_Export_Others As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_ExportFormats As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Export_Word As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_HTML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_RTF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Image As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_MHTML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Mail_HTML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Export As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_FromAddresses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Mail_PDF_HTML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Mail_PDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_MailFormats As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_SmallCover As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Covers As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_BigCover As DevExpress.XtraBars.BarButtonItem
End Class
