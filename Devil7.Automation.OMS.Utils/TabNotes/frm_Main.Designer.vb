<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits DevExpress.XtraBars.TabForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.btn_More = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_More = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_ViewArchived = New DevExpress.XtraBars.BarButtonItem()
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Loader = New System.ComponentModel.BackgroundWorker()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Menu_Tray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menu_Show = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_More, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_Tray.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_More, Me.btn_ViewArchived})
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Manager = Me.TabFormDefaultManager1
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.ShowTabCloseButtons = False
        Me.TabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.[True]
        Me.TabFormControl1.Size = New System.Drawing.Size(324, 27)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 0
        Me.TabFormControl1.TabLeftItemLinks.Add(Me.btn_More)
        Me.TabFormControl1.TabStop = False
        '
        'btn_More
        '
        Me.btn_More.ActAsDropDown = True
        Me.btn_More.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_More.Caption = "More"
        Me.btn_More.DropDownControl = Me.Menu_More
        Me.btn_More.Id = 2
        Me.btn_More.ImageOptions.SvgImage = CType(resources.GetObject("btn_More.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_More.Name = "btn_More"
        '
        'Menu_More
        '
        Me.Menu_More.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_ViewArchived)})
        Me.Menu_More.Manager = Me.TabFormDefaultManager1
        Me.Menu_More.Name = "Menu_More"
        '
        'btn_ViewArchived
        '
        Me.btn_ViewArchived.Caption = "View Archived Items"
        Me.btn_ViewArchived.Id = 3
        Me.btn_ViewArchived.ImageOptions.SvgImage = CType(resources.GetObject("btn_ViewArchived.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_ViewArchived.Name = "btn_ViewArchived"
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.AllowQuickCustomization = False
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.DockingEnabled = False
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_More, Me.btn_ViewArchived})
        Me.TabFormDefaultManager1.MaxItemId = 8
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 27)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(324, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 295)
        Me.barDockControlBottom.Manager = Nothing
        Me.barDockControlBottom.Size = New System.Drawing.Size(324, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 27)
        Me.barDockControlLeft.Manager = Nothing
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 268)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(324, 27)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 268)
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.BarAnimationElementThickness = 2
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel.Location = New System.Drawing.Point(0, 27)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(324, 268)
        Me.ProgressPanel.TabIndex = 4
        Me.ProgressPanel.Visible = False
        '
        'Loader
        '
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.Menu_Tray
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Devil7 - Tab Notes"
        Me.TrayIcon.Visible = True
        '
        'Menu_Tray
        '
        Me.Menu_Tray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Show, Me.menu_Exit})
        Me.Menu_Tray.Name = "Menu_Tray"
        Me.Menu_Tray.Size = New System.Drawing.Size(104, 48)
        '
        'menu_Show
        '
        Me.menu_Show.Image = CType(resources.GetObject("menu_Show.Image"), System.Drawing.Image)
        Me.menu_Show.Name = "menu_Show"
        Me.menu_Show.Size = New System.Drawing.Size(103, 22)
        Me.menu_Show.Text = "Show"
        '
        'menu_Exit
        '
        Me.menu_Exit.Image = CType(resources.GetObject("menu_Exit.Image"), System.Drawing.Image)
        Me.menu_Exit.Name = "menu_Exit"
        Me.menu_Exit.Size = New System.Drawing.Size(103, 22)
        Me.menu_Exit.Text = "Exit"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 295)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.TabFormControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frm_Main"
        Me.TabFormControl = Me.TabFormControl1
        Me.Text = "Devil7 - Tab Notes"
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_More, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_Tray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabFormControl1 As DevExpress.XtraBars.TabFormControl
    Friend WithEvents TabFormDefaultManager1 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_More As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_ViewArchived As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_More As DevExpress.XtraBars.PopupMenu
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents Menu_Tray As ContextMenuStrip
    Friend WithEvents menu_Show As ToolStripMenuItem
    Friend WithEvents menu_Exit As ToolStripMenuItem
End Class
