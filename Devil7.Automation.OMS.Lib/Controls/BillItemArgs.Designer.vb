Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BillItemArgs
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
            Me.panel_Single = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_SingleItem = New DevExpress.XtraEditors.LabelControl()
            Me.lbl_Splitter_1 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_SingleItem = New DevExpress.XtraEditors.DateEdit()
            Me.panel_Double = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_From = New DevExpress.XtraEditors.LabelControl()
            Me.lbl_Splitter_2 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_From = New DevExpress.XtraEditors.DateEdit()
            Me.lbl_To = New DevExpress.XtraEditors.LabelControl()
            Me.lbl_Splitter_3 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_To = New DevExpress.XtraEditors.DateEdit()
            Me.panel_Single.SuspendLayout()
            CType(Me.txt_SingleItem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_SingleItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel_Double.SuspendLayout()
            CType(Me.txt_From.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_To.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel_Single
            '
            Me.panel_Single.AutoSize = True
            Me.panel_Single.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.panel_Single.ColumnCount = 3
            Me.panel_Single.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Single.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Single.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.panel_Single.Controls.Add(Me.txt_SingleItem, 2, 0)
            Me.panel_Single.Controls.Add(Me.lbl_Splitter_1, 1, 0)
            Me.panel_Single.Controls.Add(Me.lbl_SingleItem, 0, 0)
            Me.panel_Single.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_Single.Location = New System.Drawing.Point(0, 0)
            Me.panel_Single.Name = "panel_Single"
            Me.panel_Single.RowCount = 1
            Me.panel_Single.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.panel_Single.Size = New System.Drawing.Size(343, 26)
            Me.panel_Single.TabIndex = 0
            '
            'lbl_SingleItem
            '
            Me.lbl_SingleItem.Location = New System.Drawing.Point(3, 3)
            Me.lbl_SingleItem.Name = "lbl_SingleItem"
            Me.lbl_SingleItem.Size = New System.Drawing.Size(23, 13)
            Me.lbl_SingleItem.TabIndex = 1
            Me.lbl_SingleItem.Text = "Date"
            '
            'lbl_Splitter_1
            '
            Me.lbl_Splitter_1.Location = New System.Drawing.Point(32, 3)
            Me.lbl_Splitter_1.Name = "lbl_Splitter_1"
            Me.lbl_Splitter_1.Size = New System.Drawing.Size(4, 13)
            Me.lbl_Splitter_1.TabIndex = 1
            Me.lbl_Splitter_1.Text = ":"
            '
            'txt_SingleItem
            '
            Me.txt_SingleItem.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_SingleItem.EditValue = Nothing
            Me.txt_SingleItem.Location = New System.Drawing.Point(42, 3)
            Me.txt_SingleItem.Name = "txt_SingleItem"
            Me.txt_SingleItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_SingleItem.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_SingleItem.Size = New System.Drawing.Size(298, 20)
            Me.txt_SingleItem.TabIndex = 1
            '
            'panel_Double
            '
            Me.panel_Double.AutoSize = True
            Me.panel_Double.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.panel_Double.ColumnCount = 6
            Me.panel_Double.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Double.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Double.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.panel_Double.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Double.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.panel_Double.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.panel_Double.Controls.Add(Me.lbl_To, 3, 0)
            Me.panel_Double.Controls.Add(Me.txt_From, 2, 0)
            Me.panel_Double.Controls.Add(Me.lbl_Splitter_2, 1, 0)
            Me.panel_Double.Controls.Add(Me.lbl_From, 0, 0)
            Me.panel_Double.Controls.Add(Me.lbl_Splitter_3, 4, 0)
            Me.panel_Double.Controls.Add(Me.txt_To, 5, 0)
            Me.panel_Double.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_Double.Location = New System.Drawing.Point(0, 0)
            Me.panel_Double.Name = "panel_Double"
            Me.panel_Double.RowCount = 1
            Me.panel_Double.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.panel_Double.Size = New System.Drawing.Size(343, 26)
            Me.panel_Double.TabIndex = 1
            '
            'lbl_From
            '
            Me.lbl_From.Location = New System.Drawing.Point(3, 3)
            Me.lbl_From.Name = "lbl_From"
            Me.lbl_From.Size = New System.Drawing.Size(24, 13)
            Me.lbl_From.TabIndex = 2
            Me.lbl_From.Text = "From"
            '
            'lbl_Splitter_2
            '
            Me.lbl_Splitter_2.Location = New System.Drawing.Point(33, 3)
            Me.lbl_Splitter_2.Name = "lbl_Splitter_2"
            Me.lbl_Splitter_2.Size = New System.Drawing.Size(4, 13)
            Me.lbl_Splitter_2.TabIndex = 2
            Me.lbl_Splitter_2.Text = ":"
            '
            'txt_From
            '
            Me.txt_From.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_From.EditValue = Nothing
            Me.txt_From.Location = New System.Drawing.Point(43, 3)
            Me.txt_From.Name = "txt_From"
            Me.txt_From.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_From.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_From.Size = New System.Drawing.Size(131, 20)
            Me.txt_From.TabIndex = 2
            '
            'lbl_To
            '
            Me.lbl_To.Location = New System.Drawing.Point(180, 3)
            Me.lbl_To.Name = "lbl_To"
            Me.lbl_To.Size = New System.Drawing.Size(12, 13)
            Me.lbl_To.TabIndex = 2
            Me.lbl_To.Text = "To"
            '
            'lbl_Splitter_3
            '
            Me.lbl_Splitter_3.Location = New System.Drawing.Point(198, 3)
            Me.lbl_Splitter_3.Name = "lbl_Splitter_3"
            Me.lbl_Splitter_3.Size = New System.Drawing.Size(4, 13)
            Me.lbl_Splitter_3.TabIndex = 3
            Me.lbl_Splitter_3.Text = ":"
            '
            'txt_To
            '
            Me.txt_To.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_To.EditValue = Nothing
            Me.txt_To.Location = New System.Drawing.Point(208, 3)
            Me.txt_To.Name = "txt_To"
            Me.txt_To.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_To.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_To.Size = New System.Drawing.Size(132, 20)
            Me.txt_To.TabIndex = 4
            '
            'BillItemArgs
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel_Double)
            Me.Controls.Add(Me.panel_Single)
            Me.MaximumSize = New System.Drawing.Size(9999, 26)
            Me.MinimumSize = New System.Drawing.Size(0, 26)
            Me.Name = "BillItemArgs"
            Me.Size = New System.Drawing.Size(343, 26)
            Me.panel_Single.ResumeLayout(False)
            Me.panel_Single.PerformLayout()
            CType(Me.txt_SingleItem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_SingleItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel_Double.ResumeLayout(False)
            Me.panel_Double.PerformLayout()
            CType(Me.txt_From.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_To.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents panel_Single As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents txt_SingleItem As DevExpress.XtraEditors.DateEdit
        Friend WithEvents lbl_Splitter_1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lbl_SingleItem As DevExpress.XtraEditors.LabelControl
        Friend WithEvents panel_Double As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents lbl_To As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_From As DevExpress.XtraEditors.DateEdit
        Friend WithEvents lbl_Splitter_2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lbl_From As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lbl_Splitter_3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_To As DevExpress.XtraEditors.DateEdit
    End Class
End Namespace