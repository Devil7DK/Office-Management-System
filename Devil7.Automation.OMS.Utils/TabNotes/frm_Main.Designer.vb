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
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Loader = New System.ComponentModel.BackgroundWorker()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Manager = Me.TabFormDefaultManager1
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.ShowTabCloseButtons = False
        Me.TabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.[True]
        Me.TabFormControl1.Size = New System.Drawing.Size(540, 27)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 0
        Me.TabFormControl1.TabStop = False
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.DockingEnabled = False
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 27)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(540, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 261)
        Me.barDockControlBottom.Manager = Nothing
        Me.barDockControlBottom.Size = New System.Drawing.Size(540, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 27)
        Me.barDockControlLeft.Manager = Nothing
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 234)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(540, 27)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 234)
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
        Me.ProgressPanel.Size = New System.Drawing.Size(540, 234)
        Me.ProgressPanel.TabIndex = 4
        Me.ProgressPanel.Visible = False
        '
        'Loader
        '
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 261)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.TabFormControl1)
        Me.Name = "frm_Main"
        Me.TabFormControl = Me.TabFormControl1
        Me.Text = "Devil7 - Tab Notes"
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
