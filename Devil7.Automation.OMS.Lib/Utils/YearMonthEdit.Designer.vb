Namespace Utils
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class YearMonthEdit
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmb_Year = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lbl_Period = New System.Windows.Forms.Label()
            Me.cmb_Period = New DevExpress.XtraEditors.ComboBoxEdit()
            CType(Me.cmb_Year.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_Period.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(36, 21)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Year :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cmb_Year
            '
            Me.cmb_Year.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_Year.Location = New System.Drawing.Point(36, 0)
            Me.cmb_Year.Name = "cmb_Year"
            Me.cmb_Year.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Year.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Year.Size = New System.Drawing.Size(88, 20)
            Me.cmb_Year.TabIndex = 0
            '
            'lbl_Period
            '
            Me.lbl_Period.Dock = System.Windows.Forms.DockStyle.Right
            Me.lbl_Period.Location = New System.Drawing.Point(124, 0)
            Me.lbl_Period.Name = "lbl_Period"
            Me.lbl_Period.Size = New System.Drawing.Size(54, 21)
            Me.lbl_Period.TabIndex = 0
            Me.lbl_Period.Text = "Quarter :"
            Me.lbl_Period.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cmb_Period
            '
            Me.cmb_Period.Dock = System.Windows.Forms.DockStyle.Right
            Me.cmb_Period.Location = New System.Drawing.Point(178, 0)
            Me.cmb_Period.Name = "cmb_Period"
            Me.cmb_Period.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Period.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Period.Size = New System.Drawing.Size(119, 20)
            Me.cmb_Period.TabIndex = 1
            '
            'YearMonthEdit
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(Me.cmb_Year)
            Me.Controls.Add(Me.lbl_Period)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cmb_Period)
            Me.MaximumSize = New System.Drawing.Size(1000, 21)
            Me.MinimumSize = New System.Drawing.Size(0, 21)
            Me.Name = "YearMonthEdit"
            Me.Size = New System.Drawing.Size(297, 21)
            CType(Me.cmb_Year.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_Period.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Label1 As Windows.Forms.Label
        Friend WithEvents cmb_Year As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents lbl_Period As Windows.Forms.Label
        Friend WithEvents cmb_Period As DevExpress.XtraEditors.ComboBoxEdit
    End Class
End Namespace