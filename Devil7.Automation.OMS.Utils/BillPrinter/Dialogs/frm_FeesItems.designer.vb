<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_FeesItems
    Inherits [Lib].XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FeesItems))
        Me.gc_FeesItems = New DevExpress.XtraGrid.GridControl()
        Me.gv_FeesItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.MainMenu = New DevExpress.XtraBars.Bar()
        Me.btn_Refresh = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.StatusBar = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ProgressPanel_Loading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        CType(Me.gc_FeesItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_FeesItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_FeesItems
        '
        Me.gc_FeesItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_FeesItems.Location = New System.Drawing.Point(0, 22)
        Me.gc_FeesItems.MainView = Me.gv_FeesItems
        Me.gc_FeesItems.Name = "gc_FeesItems"
        Me.gc_FeesItems.Size = New System.Drawing.Size(491, 256)
        Me.gc_FeesItems.TabIndex = 0
        Me.gc_FeesItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_FeesItems})
        '
        'gv_FeesItems
        '
        Me.gv_FeesItems.GridControl = Me.gc_FeesItems
        Me.gv_FeesItems.Name = "gv_FeesItems"
        Me.gv_FeesItems.OptionsBehavior.Editable = False
        Me.gv_FeesItems.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.MainMenu, Me.StatusBar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Refresh})
        Me.BarManager1.MainMenu = Me.MainMenu
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.StatusBar
        '
        'MainMenu
        '
        Me.MainMenu.BarName = "Main menu"
        Me.MainMenu.DockCol = 0
        Me.MainMenu.DockRow = 0
        Me.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Refresh), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save, True)})
        Me.MainMenu.OptionsBar.AllowQuickCustomization = False
        Me.MainMenu.OptionsBar.DrawDragBorder = False
        Me.MainMenu.OptionsBar.MultiLine = True
        Me.MainMenu.OptionsBar.UseWholeRow = True
        Me.MainMenu.Text = "Main menu"
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Caption = "Refresh"
        Me.btn_Refresh.Id = 2
        Me.btn_Refresh.Name = "btn_Refresh"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 0
        Me.btn_Save.Name = "btn_Save"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(491, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 278)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(491, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 256)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(491, 22)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 256)
        '
        'ProgressPanel_Loading
        '
        Me.ProgressPanel_Loading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Loading.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Loading.BarAnimationElementThickness = 2
        Me.ProgressPanel_Loading.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Loading.Description = "Loading Senders List from Server..."
        Me.ProgressPanel_Loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Loading.Location = New System.Drawing.Point(0, 22)
        Me.ProgressPanel_Loading.Name = "ProgressPanel_Loading"
        Me.ProgressPanel_Loading.Size = New System.Drawing.Size(491, 256)
        Me.ProgressPanel_Loading.TabIndex = 7
        '
        'Worker
        '
        '
        'frm_FeesItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 301)
        Me.Controls.Add(Me.ProgressPanel_Loading)
        Me.Controls.Add(Me.gc_FeesItems)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_FeesItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fees Items"
        CType(Me.gc_FeesItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_FeesItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gc_FeesItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_FeesItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents MainMenu As DevExpress.XtraBars.Bar
    Friend WithEvents StatusBar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents ProgressPanel_Loading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarLargeButtonItem
End Class
