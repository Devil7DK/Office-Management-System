Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_DigitalKeysAlert
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DigitalKeysAlert))
            Me.gc_DigitalKeys = New DevExpress.XtraGrid.GridControl()
            Me.gv_DigitalKeys = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.lbl_Message = New DevExpress.XtraEditors.LabelControl()
            CType(Me.gc_DigitalKeys, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gv_DigitalKeys, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gc_DigitalKeys
            '
            Me.gc_DigitalKeys.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gc_DigitalKeys.Location = New System.Drawing.Point(0, 38)
            Me.gc_DigitalKeys.MainView = Me.gv_DigitalKeys
            Me.gc_DigitalKeys.Name = "gc_DigitalKeys"
            Me.gc_DigitalKeys.Size = New System.Drawing.Size(472, 304)
            Me.gc_DigitalKeys.TabIndex = 0
            Me.gc_DigitalKeys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_DigitalKeys})
            '
            'gv_DigitalKeys
            '
            Me.gv_DigitalKeys.GridControl = Me.gc_DigitalKeys
            Me.gv_DigitalKeys.Name = "gv_DigitalKeys"
            '
            'lbl_Message
            '
            Me.lbl_Message.Appearance.Options.UseTextOptions = True
            Me.lbl_Message.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lbl_Message.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbl_Message.Dock = System.Windows.Forms.DockStyle.Top
            Me.lbl_Message.Location = New System.Drawing.Point(0, 0)
            Me.lbl_Message.Name = "lbl_Message"
            Me.lbl_Message.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.lbl_Message.Size = New System.Drawing.Size(472, 38)
            Me.lbl_Message.TabIndex = 1
            Me.lbl_Message.Text = "The following digtal keys must be renewed! Kindly take action regarding these dig" &
    "ital keys && update the status"
            '
            'frm_DigitalKeysAlert
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(472, 342)
            Me.Controls.Add(Me.gc_DigitalKeys)
            Me.Controls.Add(Me.lbl_Message)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimizeBox = False
            Me.Name = "frm_DigitalKeysAlert"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Digital Keys"
            CType(Me.gc_DigitalKeys, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gv_DigitalKeys, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents gc_DigitalKeys As DevExpress.XtraGrid.GridControl
        Friend WithEvents gv_DigitalKeys As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents lbl_Message As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace