<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Receivers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Receivers))
        Me.gc_Receivers = New DevExpress.XtraGrid.GridControl()
        Me.gv_Receivers = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gc_Receivers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Receivers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_Receivers
        '
        Me.gc_Receivers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Receivers.Location = New System.Drawing.Point(0, 0)
        Me.gc_Receivers.MainView = Me.gv_Receivers
        Me.gc_Receivers.Name = "gc_Receivers"
        Me.gc_Receivers.Size = New System.Drawing.Size(446, 268)
        Me.gc_Receivers.TabIndex = 0
        Me.gc_Receivers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Receivers})
        '
        'gv_Receivers
        '
        Me.gv_Receivers.GridControl = Me.gc_Receivers
        Me.gv_Receivers.Name = "gv_Receivers"
        Me.gv_Receivers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Receivers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Receivers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'frm_Receivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 268)
        Me.Controls.Add(Me.gc_Receivers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Receivers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receivers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gc_Receivers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Receivers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gc_Receivers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Receivers As DevExpress.XtraGrid.Views.Grid.GridView
End Class
