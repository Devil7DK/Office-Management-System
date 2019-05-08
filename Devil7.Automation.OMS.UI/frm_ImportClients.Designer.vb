<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImportClients
    Inherits [Lib].XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ImportClients))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_ImportExcel = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_ExportClients = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_SkipExisting = New DevExpress.XtraBars.BarCheckItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gc_Clients = New DevExpress.XtraGrid.GridControl()
        Me.gv_Clients = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dlg_OpenExcel = New System.Windows.Forms.OpenFileDialog()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_ImportExcel, Me.btn_ExportClients, Me.btn_SkipExisting})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ImportExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ExportClients), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SkipExisting, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_ImportExcel
        '
        Me.btn_ImportExcel.Caption = "Import Excel"
        Me.btn_ImportExcel.Id = 1
        Me.btn_ImportExcel.ImageOptions.SvgImage = CType(resources.GetObject("btn_ImportExcel.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_ImportExcel.Name = "btn_ImportExcel"
        '
        'btn_ExportClients
        '
        Me.btn_ExportClients.Caption = "Export Clients"
        Me.btn_ExportClients.Id = 3
        Me.btn_ExportClients.ImageOptions.SvgImage = CType(resources.GetObject("btn_ExportClients.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_ExportClients.Name = "btn_ExportClients"
        '
        'btn_SkipExisting
        '
        Me.btn_SkipExisting.BindableChecked = True
        Me.btn_SkipExisting.Caption = "Skip Existing"
        Me.btn_SkipExisting.Checked = True
        Me.btn_SkipExisting.Id = 4
        Me.btn_SkipExisting.ImageOptions.SvgImage = CType(resources.GetObject("btn_SkipExisting.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SkipExisting.Name = "btn_SkipExisting"
        Me.btn_SkipExisting.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(675, 58)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 427)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(675, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 58)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 369)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(675, 58)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 369)
        '
        'gc_Clients
        '
        Me.gc_Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Clients.Location = New System.Drawing.Point(0, 58)
        Me.gc_Clients.MainView = Me.gv_Clients
        Me.gc_Clients.MenuManager = Me.BarManager1
        Me.gc_Clients.Name = "gc_Clients"
        Me.gc_Clients.Size = New System.Drawing.Size(675, 369)
        Me.gc_Clients.TabIndex = 4
        Me.gc_Clients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Clients})
        '
        'gv_Clients
        '
        Me.gv_Clients.GridControl = Me.gc_Clients
        Me.gv_Clients.Name = "gv_Clients"
        Me.gv_Clients.OptionsBehavior.Editable = False
        Me.gv_Clients.OptionsBehavior.ReadOnly = True
        '
        'dlg_OpenExcel
        '
        Me.dlg_OpenExcel.Filter = "Excel Workbooks|*.xls;*.xlsx"
        '
        'frm_ImportClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 450)
        Me.Controls.Add(Me.gc_Clients)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_ImportClients"
        Me.Text = "Import Clients"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gc_Clients As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Clients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_ImportExcel As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents btn_ExportClients As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents dlg_OpenExcel As OpenFileDialog
    Friend WithEvents btn_SkipExisting As DevExpress.XtraBars.BarCheckItem
End Class
