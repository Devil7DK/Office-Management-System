<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DigitalKeys
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DigitalKeys))
        Me.gc_DigitalKeys = New DevExpress.XtraGrid.GridControl()
        Me.gv_DigitalKeys = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.o = New DevExpress.XtraBars.Bar()
        Me.switch_Editable = New DevExpress.XtraBars.BarToggleSwitchItem()
        CType(Me.gc_DigitalKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_DigitalKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_DigitalKeys
        '
        Me.gc_DigitalKeys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_DigitalKeys.Location = New System.Drawing.Point(0, 0)
        Me.gc_DigitalKeys.MainView = Me.gv_DigitalKeys
        Me.gc_DigitalKeys.Name = "gc_DigitalKeys"
        Me.gc_DigitalKeys.Size = New System.Drawing.Size(634, 353)
        Me.gc_DigitalKeys.TabIndex = 0
        Me.gc_DigitalKeys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_DigitalKeys})
        '
        'gv_DigitalKeys
        '
        Me.gv_DigitalKeys.GridControl = Me.gc_DigitalKeys
        Me.gv_DigitalKeys.Name = "gv_DigitalKeys"
        Me.gv_DigitalKeys.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_DigitalKeys.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_DigitalKeys.OptionsBehavior.Editable = False
        Me.gv_DigitalKeys.OptionsBehavior.ReadOnly = True
        Me.gv_DigitalKeys.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.o})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.switch_Editable})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.o
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(634, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 353)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(634, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 353)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(634, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 353)
        '
        'o
        '
        Me.o.BarName = "Status bar"
        Me.o.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.o.DockCol = 0
        Me.o.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.o.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switch_Editable)})
        Me.o.OptionsBar.AllowQuickCustomization = False
        Me.o.OptionsBar.DrawDragBorder = False
        Me.o.OptionsBar.UseWholeRow = True
        Me.o.Text = "Status bar"
        '
        'switch_Editable
        '
        Me.switch_Editable.Caption = "Editing"
        Me.switch_Editable.Id = 0
        Me.switch_Editable.Name = "switch_Editable"
        '
        'frm_DigitalKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 382)
        Me.Controls.Add(Me.gc_DigitalKeys)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_DigitalKeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Digital Keys Register"
        CType(Me.gc_DigitalKeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_DigitalKeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gc_DigitalKeys As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_DigitalKeys As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents o As DevExpress.XtraBars.Bar
    Friend WithEvents switch_Editable As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
