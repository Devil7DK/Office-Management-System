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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_EstimateBills = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_EstimateBills = New DevExpress.XtraGrid.GridControl()
        Me.gv_EstimateBills = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgressPanel_Bills = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_PrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_PDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Word = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Sender = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Services = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Settings = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btn_Export_Excel = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_EstimateBills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_EstimateBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Refresh, Me.btn_Add, Me.btn_Edit, Me.btn_Remove, Me.btn_Print, Me.btn_PrintPreview, Me.btn_Export_PDF, Me.btn_Export_Word, Me.btn_Sender, Me.btn_Services, Me.btn_Settings, Me.SkinRibbonGalleryBarItem1, Me.btn_Export_Excel})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 14
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(692, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_EstimateBills, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup2})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_EstimateBills
        '
        Me.rpg_EstimateBills.ItemLinks.Add(Me.btn_Refresh)
        Me.rpg_EstimateBills.ItemLinks.Add(Me.btn_Add, True)
        Me.rpg_EstimateBills.ItemLinks.Add(Me.btn_Edit)
        Me.rpg_EstimateBills.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_EstimateBills.Name = "rpg_EstimateBills"
        Me.rpg_EstimateBills.ShowCaptionButton = False
        Me.rpg_EstimateBills.Text = "Estimate Bills"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_Print)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_PrintPreview)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Printing"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btn_Export_PDF)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btn_Export_Word)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btn_Export_Excel, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Export"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_Sender)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_Services)
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
        Me.RibbonStatusBar.Size = New System.Drawing.Size(692, 31)
        '
        'gc_EstimateBills
        '
        Me.gc_EstimateBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_EstimateBills.Location = New System.Drawing.Point(0, 143)
        Me.gc_EstimateBills.MainView = Me.gv_EstimateBills
        Me.gc_EstimateBills.MenuManager = Me.RibbonControl
        Me.gc_EstimateBills.Name = "gc_EstimateBills"
        Me.gc_EstimateBills.Size = New System.Drawing.Size(692, 275)
        Me.gc_EstimateBills.TabIndex = 2
        Me.gc_EstimateBills.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_EstimateBills})
        '
        'gv_EstimateBills
        '
        Me.gv_EstimateBills.GridControl = Me.gc_EstimateBills
        Me.gv_EstimateBills.Name = "gv_EstimateBills"
        '
        'ProgressPanel_Bills
        '
        Me.ProgressPanel_Bills.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Bills.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Bills.BarAnimationElementThickness = 2
        Me.ProgressPanel_Bills.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Bills.Description = "Fetching Data from Server..."
        Me.ProgressPanel_Bills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Bills.Location = New System.Drawing.Point(0, 143)
        Me.ProgressPanel_Bills.Name = "ProgressPanel_Bills"
        Me.ProgressPanel_Bills.Size = New System.Drawing.Size(692, 275)
        Me.ProgressPanel_Bills.TabIndex = 6
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
        'btn_PrintPreview
        '
        Me.btn_PrintPreview.Caption = "Preview"
        Me.btn_PrintPreview.Id = 6
        Me.btn_PrintPreview.ImageOptions.SvgImage = CType(resources.GetObject("btn_PrintPreview.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_PrintPreview.Name = "btn_PrintPreview"
        '
        'btn_Export_PDF
        '
        Me.btn_Export_PDF.Caption = "PDF"
        Me.btn_Export_PDF.Id = 7
        Me.btn_Export_PDF.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_PDF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_PDF.Name = "btn_Export_PDF"
        '
        'btn_Export_Word
        '
        Me.btn_Export_Word.Caption = "Word"
        Me.btn_Export_Word.Id = 8
        Me.btn_Export_Word.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Word.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Word.Name = "btn_Export_Word"
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
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 449)
        Me.Controls.Add(Me.ProgressPanel_Bills)
        Me.Controls.Add(Me.gc_EstimateBills)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Devil7 - Estimate Bill Printer"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_EstimateBills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_EstimateBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_EstimateBills As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents gc_EstimateBills As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_EstimateBills As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgressPanel_Bills As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_PrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_PDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Word As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Sender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Services As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Settings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btn_Export_Excel As DevExpress.XtraBars.BarButtonItem
End Class
