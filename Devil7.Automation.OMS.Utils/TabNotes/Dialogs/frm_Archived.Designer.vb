<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Archived
    Inherits Devil7.Automation.OMS.Lib.XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Archived))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.MainBar = New DevExpress.XtraBars.Bar()
        Me.btn_UnArchive = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_ShowPreviewPane = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gc_Archived = New DevExpress.XtraGrid.GridControl()
        Me.gv_Archived = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Title = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_AddedDate = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_EditedDate = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Content = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Title = New DevExpress.XtraEditors.TextEdit()
        Me.txt_DateAdded = New DevExpress.XtraEditors.TextEdit()
        Me.txt_DateEdited = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Content = New DevExpress.XtraEditors.MemoEdit()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Loader = New System.ComponentModel.BackgroundWorker()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Archived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Archived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_Title.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DateEdited.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Content.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.MainBar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_UnArchive, Me.btn_Remove, Me.btn_ShowPreviewPane})
        Me.BarManager1.MainMenu = Me.MainBar
        Me.BarManager1.MaxItemId = 3
        '
        'MainBar
        '
        Me.MainBar.BarName = "Main menu"
        Me.MainBar.DockCol = 0
        Me.MainBar.DockRow = 0
        Me.MainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.MainBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_UnArchive), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Remove), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ShowPreviewPane, True)})
        Me.MainBar.OptionsBar.AllowQuickCustomization = False
        Me.MainBar.OptionsBar.DrawDragBorder = False
        Me.MainBar.OptionsBar.MultiLine = True
        Me.MainBar.OptionsBar.UseWholeRow = True
        Me.MainBar.Text = "Main menu"
        '
        'btn_UnArchive
        '
        Me.btn_UnArchive.Caption = "Mark as Not Archived"
        Me.btn_UnArchive.Id = 0
        Me.btn_UnArchive.ImageOptions.SvgImage = CType(resources.GetObject("btn_UnArchive.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_UnArchive.Name = "btn_UnArchive"
        Me.btn_UnArchive.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 1
        Me.btn_Remove.ImageOptions.SvgImage = CType(resources.GetObject("btn_Remove.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_ShowPreviewPane
        '
        Me.btn_ShowPreviewPane.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_ShowPreviewPane.Caption = "Show Preview Pane"
        Me.btn_ShowPreviewPane.Id = 2
        Me.btn_ShowPreviewPane.ImageOptions.SvgImage = CType(resources.GetObject("btn_ShowPreviewPane.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_ShowPreviewPane.Name = "btn_ShowPreviewPane"
        Me.btn_ShowPreviewPane.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(800, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 450)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(800, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 426)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(800, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 426)
        '
        'gc_Archived
        '
        Me.gc_Archived.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Archived.Location = New System.Drawing.Point(0, 0)
        Me.gc_Archived.MainView = Me.gv_Archived
        Me.gc_Archived.MenuManager = Me.BarManager1
        Me.gc_Archived.Name = "gc_Archived"
        Me.gc_Archived.Size = New System.Drawing.Size(800, 426)
        Me.gc_Archived.TabIndex = 4
        Me.gc_Archived.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Archived})
        '
        'gv_Archived
        '
        Me.gv_Archived.GridControl = Me.gc_Archived
        Me.gv_Archived.Name = "gv_Archived"
        Me.gv_Archived.OptionsBehavior.Editable = False
        Me.gv_Archived.OptionsBehavior.ReadOnly = True
        Me.gv_Archived.OptionsSelection.MultiSelect = True
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainer.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Panel1.Controls.Add(Me.gc_Archived)
        Me.SplitContainer.Panel1.Text = "Panel1"
        Me.SplitContainer.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer.Panel2.Text = "Panel2"
        Me.SplitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainer.Size = New System.Drawing.Size(800, 426)
        Me.SplitContainer.SplitterPosition = 263
        Me.SplitContainer.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Title, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter_1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_AddedDate, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter_2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_EditedDate, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter_3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Content, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Splitter_4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Title, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_DateAdded, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_DateEdited, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Content, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_Title
        '
        Me.lbl_Title.Appearance.Options.UseTextOptions = True
        Me.lbl_Title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Title.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(57, 20)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Title"
        '
        'lbl_Splitter_1
        '
        Me.lbl_Splitter_1.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_1.Location = New System.Drawing.Point(66, 3)
        Me.lbl_Splitter_1.Name = "lbl_Splitter_1"
        Me.lbl_Splitter_1.Size = New System.Drawing.Size(4, 20)
        Me.lbl_Splitter_1.TabIndex = 1
        Me.lbl_Splitter_1.Text = ":"
        '
        'lbl_AddedDate
        '
        Me.lbl_AddedDate.Appearance.Options.UseTextOptions = True
        Me.lbl_AddedDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_AddedDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_AddedDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_AddedDate.Location = New System.Drawing.Point(3, 29)
        Me.lbl_AddedDate.Name = "lbl_AddedDate"
        Me.lbl_AddedDate.Size = New System.Drawing.Size(57, 20)
        Me.lbl_AddedDate.TabIndex = 2
        Me.lbl_AddedDate.Text = "Date Added"
        '
        'lbl_Splitter_2
        '
        Me.lbl_Splitter_2.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_2.Location = New System.Drawing.Point(66, 29)
        Me.lbl_Splitter_2.Name = "lbl_Splitter_2"
        Me.lbl_Splitter_2.Size = New System.Drawing.Size(4, 20)
        Me.lbl_Splitter_2.TabIndex = 3
        Me.lbl_Splitter_2.Text = ":"
        '
        'lbl_EditedDate
        '
        Me.lbl_EditedDate.Appearance.Options.UseTextOptions = True
        Me.lbl_EditedDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_EditedDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_EditedDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_EditedDate.Location = New System.Drawing.Point(3, 55)
        Me.lbl_EditedDate.Name = "lbl_EditedDate"
        Me.lbl_EditedDate.Size = New System.Drawing.Size(57, 20)
        Me.lbl_EditedDate.TabIndex = 4
        Me.lbl_EditedDate.Text = "Date Edited"
        '
        'lbl_Splitter_3
        '
        Me.lbl_Splitter_3.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_3.Location = New System.Drawing.Point(66, 55)
        Me.lbl_Splitter_3.Name = "lbl_Splitter_3"
        Me.lbl_Splitter_3.Size = New System.Drawing.Size(4, 20)
        Me.lbl_Splitter_3.TabIndex = 5
        Me.lbl_Splitter_3.Text = ":"
        '
        'lbl_Content
        '
        Me.lbl_Content.Appearance.Options.UseTextOptions = True
        Me.lbl_Content.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Content.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Content.Location = New System.Drawing.Point(3, 81)
        Me.lbl_Content.Name = "lbl_Content"
        Me.lbl_Content.Size = New System.Drawing.Size(57, 1)
        Me.lbl_Content.TabIndex = 6
        Me.lbl_Content.Text = "Content"
        '
        'lbl_Splitter_4
        '
        Me.lbl_Splitter_4.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_4.Location = New System.Drawing.Point(66, 81)
        Me.lbl_Splitter_4.Name = "lbl_Splitter_4"
        Me.lbl_Splitter_4.Size = New System.Drawing.Size(4, 1)
        Me.lbl_Splitter_4.TabIndex = 7
        Me.lbl_Splitter_4.Text = ":"
        '
        'txt_Title
        '
        Me.txt_Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Title.Location = New System.Drawing.Point(76, 3)
        Me.txt_Title.MenuManager = Me.BarManager1
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(1, 20)
        Me.txt_Title.TabIndex = 8
        '
        'txt_DateAdded
        '
        Me.txt_DateAdded.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DateAdded.Location = New System.Drawing.Point(76, 29)
        Me.txt_DateAdded.MenuManager = Me.BarManager1
        Me.txt_DateAdded.Name = "txt_DateAdded"
        Me.txt_DateAdded.Size = New System.Drawing.Size(1, 20)
        Me.txt_DateAdded.TabIndex = 9
        '
        'txt_DateEdited
        '
        Me.txt_DateEdited.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DateEdited.Location = New System.Drawing.Point(76, 55)
        Me.txt_DateEdited.MenuManager = Me.BarManager1
        Me.txt_DateEdited.Name = "txt_DateEdited"
        Me.txt_DateEdited.Size = New System.Drawing.Size(1, 20)
        Me.txt_DateEdited.TabIndex = 10
        '
        'txt_Content
        '
        Me.txt_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Content.Location = New System.Drawing.Point(76, 81)
        Me.txt_Content.MenuManager = Me.BarManager1
        Me.txt_Content.Name = "txt_Content"
        Me.txt_Content.Size = New System.Drawing.Size(1, 1)
        Me.txt_Content.TabIndex = 11
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.BarAnimationElementThickness = 2
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel.Location = New System.Drawing.Point(0, 24)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(800, 426)
        Me.ProgressPanel.TabIndex = 7
        Me.ProgressPanel.Visible = False
        '
        'Loader
        '
        '
        'frm_Archived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Archived"
        Me.Text = "Archived Notes"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Archived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Archived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_Title.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DateEdited.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Content.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents MainBar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gc_Archived As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Archived As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_Title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AddedDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_EditedDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Content As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Title As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DateAdded As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DateEdited As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Content As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_UnArchive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_ShowPreviewPane As DevExpress.XtraBars.BarButtonItem
End Class
