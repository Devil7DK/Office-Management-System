Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Job_Lite
        Inherits Devil7.Automation.OMS.Lib.XtraFormTemp

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Job_Lite))
            Me.Panel_Main = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cmb_Name = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Panel_Control = New System.Windows.Forms.Panel()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
            Me.Panel_Main.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.cmb_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_Control.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel_Main
            '
            Me.Panel_Main.Controls.Add(Me.TableLayoutPanel1)
            Me.Panel_Main.Controls.Add(Me.Panel_Control)
            Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
            Me.Panel_Main.Name = "Panel_Main"
            Me.Panel_Main.Size = New System.Drawing.Size(344, 61)
            Me.Panel_Main.TabIndex = 0
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.cmb_Name, 2, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(344, 27)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Location = New System.Drawing.Point(3, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(94, 28)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Select Job"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label6.Location = New System.Drawing.Point(103, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(9, 28)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = ":"
            '
            'cmb_Name
            '
            Me.cmb_Name.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cmb_Name.Location = New System.Drawing.Point(118, 3)
            Me.cmb_Name.Name = "cmb_Name"
            Me.cmb_Name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmb_Name.Size = New System.Drawing.Size(223, 20)
            Me.cmb_Name.TabIndex = 1
            '
            'Panel_Control
            '
            Me.Panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel_Control.Controls.Add(Me.btn_Cancel)
            Me.Panel_Control.Controls.Add(Me.btn_Done)
            Me.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel_Control.Location = New System.Drawing.Point(0, 29)
            Me.Panel_Control.Name = "Panel_Control"
            Me.Panel_Control.Size = New System.Drawing.Size(344, 32)
            Me.Panel_Control.TabIndex = 0
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_Cancel.Appearance.Options.UseFont = True
            Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_Cancel.Location = New System.Drawing.Point(197, 3)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
            Me.btn_Cancel.TabIndex = 2
            Me.btn_Cancel.TabStop = False
            Me.btn_Cancel.Text = "Cancel"
            '
            'btn_Done
            '
            Me.btn_Done.Appearance.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.btn_Done.Appearance.Options.UseFont = True
            Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_Done.Location = New System.Drawing.Point(268, 3)
            Me.btn_Done.Name = "btn_Done"
            Me.btn_Done.Size = New System.Drawing.Size(65, 24)
            Me.btn_Done.TabIndex = 1
            Me.btn_Done.TabStop = False
            Me.btn_Done.Text = "Done"
            '
            'frm_Job_Lite
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(344, 61)
            Me.Controls.Add(Me.Panel_Main)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_Job_Lite"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Job"
            Me.Panel_Main.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.cmb_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_Control.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel_Main As System.Windows.Forms.Panel
        Friend WithEvents Panel_Control As System.Windows.Forms.Panel
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmb_Name As DevExpress.XtraEditors.ComboBoxEdit
    End Class
End Namespace