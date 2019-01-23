<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SendMail
    Inherits [Lib].XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SendMail))
        Me.lbl_From = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_To = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Subject = New DevExpress.XtraEditors.LabelControl()
        Me.txt_From = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_To = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Subject = New DevExpress.XtraEditors.TextEdit()
        Me.grp_Body = New DevExpress.XtraEditors.GroupControl()
        Me.tab_Body = New DevExpress.XtraTab.XtraTabControl()
        Me.tp_Text = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_Body_Plain = New DevExpress.XtraEditors.MemoEdit()
        Me.tp_HTML = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_Body_HTML = New System.Windows.Forms.WebBrowser()
        Me.btn_SendMail = New DevExpress.XtraEditors.SimpleButton()
        Me.grp_Attachments = New DevExpress.XtraEditors.GroupControl()
        Me.gc_Attachments = New DevExpress.XtraGrid.GridControl()
        Me.gv_Attachments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Subject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Body, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Body.SuspendLayout()
        CType(Me.tab_Body, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Body.SuspendLayout()
        Me.tp_Text.SuspendLayout()
        CType(Me.txt_Body_Plain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_HTML.SuspendLayout()
        CType(Me.grp_Attachments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Attachments.SuspendLayout()
        CType(Me.gc_Attachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Attachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_From
        '
        Me.lbl_From.Location = New System.Drawing.Point(24, 15)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(31, 13)
        Me.lbl_From.TabIndex = 0
        Me.lbl_From.Text = "From :"
        '
        'lbl_To
        '
        Me.lbl_To.Location = New System.Drawing.Point(36, 41)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(19, 13)
        Me.lbl_To.TabIndex = 1
        Me.lbl_To.Text = "To :"
        '
        'lbl_Subject
        '
        Me.lbl_Subject.Location = New System.Drawing.Point(12, 71)
        Me.lbl_Subject.Name = "lbl_Subject"
        Me.lbl_Subject.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Subject.TabIndex = 2
        Me.lbl_Subject.Text = "Subject :"
        '
        'txt_From
        '
        Me.txt_From.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorProvider.SetIconAlignment(Me.txt_From, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_From.Location = New System.Drawing.Point(61, 12)
        Me.txt_From.Name = "txt_From"
        Me.txt_From.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_From.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_From.Size = New System.Drawing.Size(351, 20)
        Me.txt_From.TabIndex = 3
        '
        'txt_To
        '
        Me.txt_To.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorProvider.SetIconAlignment(Me.txt_To, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_To.Location = New System.Drawing.Point(61, 38)
        Me.txt_To.Name = "txt_To"
        Me.txt_To.Size = New System.Drawing.Size(351, 20)
        Me.txt_To.TabIndex = 4
        '
        'txt_Subject
        '
        Me.txt_Subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorProvider.SetIconAlignment(Me.txt_Subject, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txt_Subject.Location = New System.Drawing.Point(61, 64)
        Me.txt_Subject.Name = "txt_Subject"
        Me.txt_Subject.Size = New System.Drawing.Size(351, 20)
        Me.txt_Subject.TabIndex = 5
        '
        'grp_Body
        '
        Me.grp_Body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Body.Controls.Add(Me.tab_Body)
        Me.grp_Body.Location = New System.Drawing.Point(12, 90)
        Me.grp_Body.Name = "grp_Body"
        Me.grp_Body.Size = New System.Drawing.Size(400, 144)
        Me.grp_Body.TabIndex = 6
        Me.grp_Body.Text = "Body"
        '
        'tab_Body
        '
        Me.tab_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Body.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.tab_Body.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never
        Me.tab_Body.Location = New System.Drawing.Point(2, 20)
        Me.tab_Body.Name = "tab_Body"
        Me.tab_Body.SelectedTabPage = Me.tp_Text
        Me.tab_Body.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.tab_Body.Size = New System.Drawing.Size(396, 122)
        Me.tab_Body.TabIndex = 0
        Me.tab_Body.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp_Text, Me.tp_HTML})
        '
        'tp_Text
        '
        Me.tp_Text.Controls.Add(Me.txt_Body_Plain)
        Me.tp_Text.Name = "tp_Text"
        Me.tp_Text.Size = New System.Drawing.Size(390, 116)
        Me.tp_Text.Text = "Plain Text"
        '
        'txt_Body_Plain
        '
        Me.txt_Body_Plain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Body_Plain.Location = New System.Drawing.Point(0, 0)
        Me.txt_Body_Plain.Name = "txt_Body_Plain"
        Me.txt_Body_Plain.Size = New System.Drawing.Size(390, 116)
        Me.txt_Body_Plain.TabIndex = 0
        '
        'tp_HTML
        '
        Me.tp_HTML.Controls.Add(Me.txt_Body_HTML)
        Me.tp_HTML.Name = "tp_HTML"
        Me.tp_HTML.Size = New System.Drawing.Size(390, 94)
        Me.tp_HTML.Text = "HTML"
        '
        'txt_Body_HTML
        '
        Me.txt_Body_HTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Body_HTML.Location = New System.Drawing.Point(0, 0)
        Me.txt_Body_HTML.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txt_Body_HTML.Name = "txt_Body_HTML"
        Me.txt_Body_HTML.Size = New System.Drawing.Size(390, 94)
        Me.txt_Body_HTML.TabIndex = 0
        '
        'btn_SendMail
        '
        Me.btn_SendMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SendMail.ImageOptions.SvgImage = CType(resources.GetObject("btn_SendMail.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SendMail.Location = New System.Drawing.Point(320, 332)
        Me.btn_SendMail.Name = "btn_SendMail"
        Me.btn_SendMail.Size = New System.Drawing.Size(92, 38)
        Me.btn_SendMail.TabIndex = 8
        Me.btn_SendMail.Text = "Send"
        '
        'grp_Attachments
        '
        Me.grp_Attachments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Attachments.Controls.Add(Me.gc_Attachments)
        Me.grp_Attachments.Location = New System.Drawing.Point(12, 240)
        Me.grp_Attachments.Name = "grp_Attachments"
        Me.grp_Attachments.Size = New System.Drawing.Size(400, 86)
        Me.grp_Attachments.TabIndex = 10
        Me.grp_Attachments.Text = "Attachments"
        '
        'gc_Attachments
        '
        Me.gc_Attachments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Attachments.Location = New System.Drawing.Point(2, 20)
        Me.gc_Attachments.MainView = Me.gv_Attachments
        Me.gc_Attachments.Name = "gc_Attachments"
        Me.gc_Attachments.Size = New System.Drawing.Size(396, 64)
        Me.gc_Attachments.TabIndex = 0
        Me.gc_Attachments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Attachments})
        '
        'gv_Attachments
        '
        Me.gv_Attachments.GridControl = Me.gc_Attachments
        Me.gv_Attachments.Name = "gv_Attachments"
        Me.gv_Attachments.OptionsBehavior.Editable = False
        Me.gv_Attachments.OptionsBehavior.ReadOnly = True
        Me.gv_Attachments.OptionsView.ShowGroupPanel = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frm_SendMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 382)
        Me.Controls.Add(Me.grp_Attachments)
        Me.Controls.Add(Me.btn_SendMail)
        Me.Controls.Add(Me.grp_Body)
        Me.Controls.Add(Me.txt_Subject)
        Me.Controls.Add(Me.txt_To)
        Me.Controls.Add(Me.txt_From)
        Me.Controls.Add(Me.lbl_Subject)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.lbl_From)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_SendMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Send E-Mail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Subject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Body, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Body.ResumeLayout(False)
        CType(Me.tab_Body, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Body.ResumeLayout(False)
        Me.tp_Text.ResumeLayout(False)
        CType(Me.txt_Body_Plain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_HTML.ResumeLayout(False)
        CType(Me.grp_Attachments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Attachments.ResumeLayout(False)
        CType(Me.gc_Attachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Attachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_From As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_To As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Subject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_From As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_To As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Subject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grp_Body As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tab_Body As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp_Text As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tp_HTML As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_SendMail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Body_Plain As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents grp_Attachments As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_Attachments As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Attachments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_Body_HTML As WebBrowser
    Friend WithEvents ErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
