<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FileAccept
    Inherits XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FileAccept))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_From = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_File = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Accept = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Decline = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmb_AlwaysTrust = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.cmb_AlwaysTrust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(30, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "From :"
        '
        'lbl_From
        '
        Me.lbl_From.Location = New System.Drawing.Point(67, 12)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(4, 13)
        Me.lbl_From.TabIndex = 1
        Me.lbl_From.Text = "-"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Filename :"
        '
        'lbl_File
        '
        Me.lbl_File.Location = New System.Drawing.Point(67, 35)
        Me.lbl_File.Name = "lbl_File"
        Me.lbl_File.Size = New System.Drawing.Size(4, 13)
        Me.lbl_File.TabIndex = 4
        Me.lbl_File.Text = "-"
        '
        'btn_Accept
        '
        Me.btn_Accept.Location = New System.Drawing.Point(12, 74)
        Me.btn_Accept.Name = "btn_Accept"
        Me.btn_Accept.Size = New System.Drawing.Size(75, 23)
        Me.btn_Accept.TabIndex = 5
        Me.btn_Accept.Text = "Accept"
        '
        'btn_Decline
        '
        Me.btn_Decline.Location = New System.Drawing.Point(205, 74)
        Me.btn_Decline.Name = "btn_Decline"
        Me.btn_Decline.Size = New System.Drawing.Size(75, 23)
        Me.btn_Decline.TabIndex = 6
        Me.btn_Decline.Text = "Decline"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'cmb_AlwaysTrust
        '
        Me.cmb_AlwaysTrust.Location = New System.Drawing.Point(93, 76)
        Me.cmb_AlwaysTrust.Name = "cmb_AlwaysTrust"
        Me.cmb_AlwaysTrust.Properties.Caption = "Always Trust"
        Me.cmb_AlwaysTrust.Size = New System.Drawing.Size(90, 19)
        Me.cmb_AlwaysTrust.TabIndex = 7
        '
        'frm_FileAccept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_AlwaysTrust)
        Me.Controls.Add(Me.btn_Decline)
        Me.Controls.Add(Me.btn_Accept)
        Me.Controls.Add(Me.lbl_File)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lbl_From)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_FileAccept"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Incoming File"
        Me.TopMost = True
        CType(Me.cmb_AlwaysTrust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_From As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_File As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Accept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Decline As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmb_AlwaysTrust As DevExpress.XtraEditors.CheckEdit
End Class
