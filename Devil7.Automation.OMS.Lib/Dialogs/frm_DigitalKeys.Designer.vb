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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DigitalKeys))
        Me.gc_DigitalKeys = New DevExpress.XtraGrid.GridControl()
        Me.gv_DigitalKeys = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gc_DigitalKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_DigitalKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_DigitalKeys
        '
        Me.gc_DigitalKeys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_DigitalKeys.Location = New System.Drawing.Point(0, 0)
        Me.gc_DigitalKeys.MainView = Me.gv_DigitalKeys
        Me.gc_DigitalKeys.Name = "gc_DigitalKeys"
        Me.gc_DigitalKeys.Size = New System.Drawing.Size(634, 382)
        Me.gc_DigitalKeys.TabIndex = 0
        Me.gc_DigitalKeys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_DigitalKeys})
        '
        'gv_DigitalKeys
        '
        Me.gv_DigitalKeys.GridControl = Me.gc_DigitalKeys
        Me.gv_DigitalKeys.Name = "gv_DigitalKeys"
        Me.gv_DigitalKeys.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_DigitalKeys.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_DigitalKeys.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'frm_DigitalKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 382)
        Me.Controls.Add(Me.gc_DigitalKeys)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_DigitalKeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Digital Keys Register"
        CType(Me.gc_DigitalKeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_DigitalKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gc_DigitalKeys As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_DigitalKeys As DevExpress.XtraGrid.Views.Grid.GridView
End Class
