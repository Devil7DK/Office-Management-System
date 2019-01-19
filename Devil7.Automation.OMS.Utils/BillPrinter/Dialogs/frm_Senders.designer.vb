<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Senders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Senders))
        Me.GridControl_Senders = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Senders = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.MainMenu = New DevExpress.XtraBars.Bar()
        Me.btn_Refresh = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_Add = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.StatusBar = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ProgressPanel_Loading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        CType(Me.GridControl_Senders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Senders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl_Senders
        '
        Me.GridControl_Senders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_Senders.Location = New System.Drawing.Point(0, 58)
        Me.GridControl_Senders.MainView = Me.GridView_Senders
        Me.GridControl_Senders.Name = "GridControl_Senders"
        Me.GridControl_Senders.Size = New System.Drawing.Size(514, 270)
        Me.GridControl_Senders.TabIndex = 0
        Me.GridControl_Senders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Senders})
        '
        'GridView_Senders
        '
        Me.GridView_Senders.GridControl = Me.GridControl_Senders
        Me.GridView_Senders.Name = "GridView_Senders"
        Me.GridView_Senders.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView_Senders.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView_Senders.OptionsBehavior.Editable = False
        Me.GridView_Senders.OptionsSelection.MultiSelect = True
        Me.GridView_Senders.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.MainMenu, Me.StatusBar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Add, Me.btn_Refresh, Me.btn_Edit, Me.btn_Remove})
        Me.BarManager1.MainMenu = Me.MainMenu
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.StatusBar
        '
        'MainMenu
        '
        Me.MainMenu.BarName = "Main menu"
        Me.MainMenu.DockCol = 0
        Me.MainMenu.DockRow = 0
        Me.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Refresh), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Add, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Edit), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Remove)})
        Me.MainMenu.OptionsBar.AllowQuickCustomization = False
        Me.MainMenu.OptionsBar.DrawDragBorder = False
        Me.MainMenu.OptionsBar.MultiLine = True
        Me.MainMenu.OptionsBar.UseWholeRow = True
        Me.MainMenu.Text = "Main menu"
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
        Me.btn_Add.Id = 0
        Me.btn_Add.ImageOptions.SvgImage = CType(resources.GetObject("btn_Add.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Add.Name = "btn_Add"
        '
        'btn_Edit
        '
        Me.btn_Edit.Caption = "Edit"
        Me.btn_Edit.Id = 2
        Me.btn_Edit.ImageOptions.SvgImage = CType(resources.GetObject("btn_Edit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Edit.Name = "btn_Edit"
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 3
        Me.btn_Remove.ImageOptions.SvgImage = CType(resources.GetObject("btn_Remove.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Remove.Name = "btn_Remove"
        '
        'StatusBar
        '
        Me.StatusBar.BarName = "Status bar"
        Me.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.StatusBar.DockCol = 0
        Me.StatusBar.DockRow = 0
        Me.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.StatusBar.OptionsBar.AllowQuickCustomization = False
        Me.StatusBar.OptionsBar.DrawDragBorder = False
        Me.StatusBar.OptionsBar.UseWholeRow = True
        Me.StatusBar.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(514, 58)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 328)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(514, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 58)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 270)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(514, 58)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 270)
        '
        'ProgressPanel_Loading
        '
        Me.ProgressPanel_Loading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Loading.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Loading.BarAnimationElementThickness = 2
        Me.ProgressPanel_Loading.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Loading.Description = "Loading Senders List from Server..."
        Me.ProgressPanel_Loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Loading.Location = New System.Drawing.Point(0, 58)
        Me.ProgressPanel_Loading.Name = "ProgressPanel_Loading"
        Me.ProgressPanel_Loading.Size = New System.Drawing.Size(514, 270)
        Me.ProgressPanel_Loading.TabIndex = 6
        '
        'Worker
        '
        '
        'frm_Senders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 351)
        Me.Controls.Add(Me.ProgressPanel_Loading)
        Me.Controls.Add(Me.GridControl_Senders)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_Senders"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Senders"
        CType(Me.GridControl_Senders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Senders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl_Senders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Senders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents MainMenu As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents btn_Add As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents StatusBar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Edit As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents ProgressPanel_Loading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
End Class
