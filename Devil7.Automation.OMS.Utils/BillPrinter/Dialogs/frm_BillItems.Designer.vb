<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BillItems
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
        Me.gc_Templates = New DevExpress.XtraGrid.GridControl()
        Me.gv_Templates = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gc_Templates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Templates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_Templates
        '
        Me.gc_Templates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Templates.Location = New System.Drawing.Point(0, 0)
        Me.gc_Templates.MainView = Me.gv_Templates
        Me.gc_Templates.Name = "gc_Templates"
        Me.gc_Templates.Size = New System.Drawing.Size(553, 268)
        Me.gc_Templates.TabIndex = 0
        Me.gc_Templates.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Templates})
        '
        'gv_Templates
        '
        Me.gv_Templates.GridControl = Me.gc_Templates
        Me.gv_Templates.Name = "gv_Templates"
        Me.gv_Templates.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Templates.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Templates.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'frm_BillItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 268)
        Me.Controls.Add(Me.gc_Templates)
        Me.Name = "frm_BillItems"
        Me.Text = "frm_BillItems"
        CType(Me.gc_Templates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Templates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gc_Templates As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Templates As DevExpress.XtraGrid.Views.Grid.GridView
End Class
