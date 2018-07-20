<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Partner
    Inherits Devil7.Automation.OMS.Lib.XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Partner))
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_PAN = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Date = New DevExpress.XtraEditors.DateEdit()
        Me.txt_Address = New DevExpress.XtraEditors.TextEdit()
        Me.Panel_Control = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel_Main.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_PAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_Main.Size = New System.Drawing.Size(344, 143)
        Me.Panel_Main.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PAN, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Name, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Date, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Address, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(344, 111)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txt_PAN
        '
        Me.txt_PAN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PAN.Location = New System.Drawing.Point(118, 3)
        Me.txt_PAN.Name = "txt_PAN"
        Me.txt_PAN.Properties.Mask.EditMask = "[A-Z]{3}[ABCFGHLJPTK][A-Z][0-9]{4}[A-Z]"
        Me.txt_PAN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txt_PAN.Size = New System.Drawing.Size(223, 20)
        Me.txt_PAN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAN"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DOB"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(103, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(103, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(103, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(103, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'txt_Name
        '
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.Location = New System.Drawing.Point(118, 30)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(223, 20)
        Me.txt_Name.TabIndex = 1
        '
        'txt_Date
        '
        Me.txt_Date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Date.EditValue = New Date(2018, 7, 20, 0, 0, 0, 0)
        Me.txt_Date.Location = New System.Drawing.Point(118, 58)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Size = New System.Drawing.Size(223, 20)
        Me.txt_Date.TabIndex = 2
        '
        'txt_Address
        '
        Me.txt_Address.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Address.Location = New System.Drawing.Point(118, 86)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(223, 20)
        Me.txt_Address.TabIndex = 3
        '
        'Panel_Control
        '
        Me.Panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Control.Controls.Add(Me.btn_Cancel)
        Me.Panel_Control.Controls.Add(Me.btn_Done)
        Me.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Control.Location = New System.Drawing.Point(0, 111)
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
        'frm_Partner
        '
        Me.ClientSize = New System.Drawing.Size(344, 143)
        Me.Controls.Add(Me.Panel_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Partner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Partner"
        Me.Panel_Main.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_PAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_Control As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_PAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_Address As DevExpress.XtraEditors.TextEdit
End Class
