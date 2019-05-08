Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BillItemSelect
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.panel_Layout = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_Group = New DevExpress.XtraEditors.LabelControl()
            Me.cmb_Group = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lbl_Item = New DevExpress.XtraEditors.LabelControl()
            Me.cmb_Item = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.select_Args = New Devil7.Automation.OMS.[Lib].Controls.BillItemArgs()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txt_Preview = New DevExpress.XtraEditors.MemoEdit()
            Me.panel_Layout.SuspendLayout()
            CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmb_Item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.txt_Preview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel_Layout
            '
            Me.panel_Layout.ColumnCount = 4
            Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
            Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
            Me.panel_Layout.Controls.Add(Me.lbl_Group, 0, 0)
            Me.panel_Layout.Controls.Add(Me.cmb_Group, 1, 0)
            Me.panel_Layout.Controls.Add(Me.lbl_Item, 2, 0)
            Me.panel_Layout.Controls.Add(Me.cmb_Item, 3, 0)
            Me.panel_Layout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_Layout.Location = New System.Drawing.Point(0, 0)
            Me.panel_Layout.Name = "panel_Layout"
            Me.panel_Layout.RowCount = 1
            Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.panel_Layout.Size = New System.Drawing.Size(385, 26)
            Me.panel_Layout.TabIndex = 0
            '
            'lbl_Group
            '
            Me.lbl_Group.Location = New System.Drawing.Point(3, 3)
            Me.lbl_Group.Name = "lbl_Group"
            Me.lbl_Group.Size = New System.Drawing.Size(36, 13)
            Me.lbl_Group.TabIndex = 0
            Me.lbl_Group.Text = "Group :"
            '
            'cmb_Group
            '
            Me.cmb_Group.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_Group.Location = New System.Drawing.Point(45, 3)
            Me.cmb_Group.Name = "cmb_Group"
            Me.cmb_Group.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Group.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Group.Size = New System.Drawing.Size(148, 20)
            Me.cmb_Group.TabIndex = 1
            '
            'lbl_Item
            '
            Me.lbl_Item.Location = New System.Drawing.Point(199, 3)
            Me.lbl_Item.Name = "lbl_Item"
            Me.lbl_Item.Size = New System.Drawing.Size(29, 13)
            Me.lbl_Item.TabIndex = 3
            Me.lbl_Item.Text = "Item :"
            '
            'cmb_Item
            '
            Me.cmb_Item.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_Item.Location = New System.Drawing.Point(234, 3)
            Me.cmb_Item.Name = "cmb_Item"
            Me.cmb_Item.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmb_Item.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Item.Size = New System.Drawing.Size(148, 20)
            Me.cmb_Item.TabIndex = 2
            '
            'select_Args
            '
            Me.select_Args.Dock = System.Windows.Forms.DockStyle.Right
            Me.select_Args.Location = New System.Drawing.Point(385, 0)
            Me.select_Args.MaximumSize = New System.Drawing.Size(9999, 26)
            Me.select_Args.MinimumSize = New System.Drawing.Size(0, 26)
            Me.select_Args.Name = "select_Args"
            Me.select_Args.ReadOnly = False
            Me.select_Args.Size = New System.Drawing.Size(196, 26)
            Me.select_Args.TabIndex = 3
            Me.select_Args.Type = Devil7.Automation.OMS.[Lib].Enums.BillItemType.Month
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.panel_Layout)
            Me.Panel1.Controls.Add(Me.select_Args)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(581, 26)
            Me.Panel1.TabIndex = 4
            '
            'txt_Preview
            '
            Me.txt_Preview.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Preview.Location = New System.Drawing.Point(0, 26)
            Me.txt_Preview.Name = "txt_Preview"
            Me.txt_Preview.Properties.ReadOnly = True
            Me.txt_Preview.Size = New System.Drawing.Size(581, 47)
            Me.txt_Preview.TabIndex = 5
            '
            'BillItemSelect
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.txt_Preview)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "BillItemSelect"
            Me.Size = New System.Drawing.Size(581, 73)
            Me.panel_Layout.ResumeLayout(False)
            Me.panel_Layout.PerformLayout()
            CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmb_Item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.txt_Preview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents panel_Layout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents lbl_Group As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cmb_Group As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents lbl_Item As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cmb_Item As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents select_Args As BillItemArgs
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txt_Preview As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace