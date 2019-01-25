Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ExList(Of T)
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar2 = New DevExpress.XtraBars.Bar()
            Me.btn_Add = New DevExpress.XtraBars.BarLargeButtonItem()
            Me.btn_Edit = New DevExpress.XtraBars.BarLargeButtonItem()
            Me.btn_Remove = New DevExpress.XtraBars.BarLargeButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.gc_List = New DevExpress.XtraGrid.GridControl()
            Me.gv_List = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gc_List, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_List, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BarManager1
            '
            Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
            Me.BarManager1.DockControls.Add(Me.barDockControlTop)
            Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager1.DockControls.Add(Me.barDockControlRight)
            Me.BarManager1.Form = Me
            Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Add, Me.btn_Edit, Me.btn_Remove})
            Me.BarManager1.MainMenu = Me.Bar2
            Me.BarManager1.MaxItemId = 13
            '
            'Bar2
            '
            Me.Bar2.BarName = "Main menu"
            Me.Bar2.DockCol = 0
            Me.Bar2.DockRow = 0
            Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Right
            Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Add), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Edit), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Remove)})
            Me.Bar2.OptionsBar.AllowQuickCustomization = False
            Me.Bar2.OptionsBar.DisableCustomization = True
            Me.Bar2.OptionsBar.DrawDragBorder = False
            Me.Bar2.OptionsBar.MultiLine = True
            Me.Bar2.OptionsBar.RotateWhenVertical = False
            Me.Bar2.OptionsBar.UseWholeRow = True
            Me.Bar2.Text = "Main menu"
            '
            'btn_Add
            '
            Me.btn_Add.Caption = "Add"
            Me.btn_Add.Id = 9
            Me.btn_Add.ImageOptions.SvgImage = Global.Devil7.Automation.OMS.[Lib].My.Resources.Resources.add_3
            Me.btn_Add.Name = "btn_Add"
            Me.btn_Add.ShowCaptionOnBar = False
            '
            'btn_Edit
            '
            Me.btn_Edit.Caption = "Edit"
            Me.btn_Edit.Id = 10
            Me.btn_Edit.ImageOptions.SvgImage = Global.Devil7.Automation.OMS.[Lib].My.Resources.Resources.edit_1
            Me.btn_Edit.Name = "btn_Edit"
            Me.btn_Edit.ShowCaptionOnBar = False
            '
            'btn_Remove
            '
            Me.btn_Remove.Caption = "Remove"
            Me.btn_Remove.Id = 12
            Me.btn_Remove.ImageOptions.SvgImage = Global.Devil7.Automation.OMS.[Lib].My.Resources.Resources.close
            Me.btn_Remove.Name = "btn_Remove"
            Me.btn_Remove.ShowCaptionOnBar = False
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(403, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 215)
            Me.barDockControlBottom.Manager = Me.BarManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(403, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.BarManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 215)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(353, 0)
            Me.barDockControlRight.Manager = Me.BarManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(50, 215)
            '
            'gc_List
            '
            Me.gc_List.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_List.Location = New System.Drawing.Point(0, 0)
            Me.gc_List.MainView = Me.gv_List
            Me.gc_List.MenuManager = Me.BarManager1
            Me.gc_List.Name = "gc_List"
            Me.gc_List.Size = New System.Drawing.Size(353, 215)
            Me.gc_List.TabIndex = 4
            Me.gc_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_List})
            '
            'gv_List
            '
            Me.gv_List.GridControl = Me.gc_List
            Me.gv_List.Name = "gv_List"
            Me.gv_List.OptionsBehavior.Editable = False
            Me.gv_List.OptionsBehavior.ReadOnly = True
            Me.gv_List.OptionsSelection.MultiSelect = True
            Me.gv_List.OptionsView.ShowGroupPanel = False
            '
            'ExList
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gc_List)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ExList"
            Me.Size = New System.Drawing.Size(403, 215)
            CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gc_List, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_List, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents gc_List As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_List As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents btn_Add As DevExpress.XtraBars.BarLargeButtonItem
        Friend WithEvents btn_Edit As DevExpress.XtraBars.BarLargeButtonItem
        Friend WithEvents btn_Remove As DevExpress.XtraBars.BarLargeButtonItem
    End Class
End Namespace