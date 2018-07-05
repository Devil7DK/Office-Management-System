<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Partner
    Inherits System.Windows.Forms.Form

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
        Me.HuraForm1 = New GlobalCode.HuraForm()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_PAN = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Date = New System.Windows.Forms.DateTimePicker()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Panel_Control = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New GlobalCode.BonfireButton()
        Me.btn_Done = New GlobalCode.BonfireButton()
        Me.HuraForm1.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel_Control.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = GlobalCode.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.Panel_Main)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(344, 175)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Partner"
        '
        'Panel_Main
        '
        Me.Panel_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Main.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel_Main.Controls.Add(Me.Panel_Control)
        Me.Panel_Main.Location = New System.Drawing.Point(3, 27)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(338, 145)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 111)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txt_PAN
        '
        Me.txt_PAN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PAN.Location = New System.Drawing.Point(118, 3)
        Me.txt_PAN.Mask = "AAAAA0000A"
        Me.txt_PAN.Name = "txt_PAN"
        Me.txt_PAN.Size = New System.Drawing.Size(217, 24)
        Me.txt_PAN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DOB"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(103, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(103, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(103, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(103, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'txt_Name
        '
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.Location = New System.Drawing.Point(118, 30)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(217, 24)
        Me.txt_Name.TabIndex = 1
        '
        'txt_Date
        '
        Me.txt_Date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Date.Location = New System.Drawing.Point(118, 58)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Size = New System.Drawing.Size(217, 24)
        Me.txt_Date.TabIndex = 2
        '
        'txt_Address
        '
        Me.txt_Address.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Address.Location = New System.Drawing.Point(118, 86)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(217, 24)
        Me.txt_Address.TabIndex = 3
        '
        'Panel_Control
        '
        Me.Panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Control.Controls.Add(Me.btn_Cancel)
        Me.Panel_Control.Controls.Add(Me.btn_Done)
        Me.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Control.Location = New System.Drawing.Point(0, 113)
        Me.Panel_Control.Name = "Panel_Control"
        Me.Panel_Control.Size = New System.Drawing.Size(338, 32)
        Me.Panel_Control.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.ButtonStyle = GlobalCode.BonfireButton.Style.Blue
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Cancel.Image = Nothing
        Me.btn_Cancel.Location = New System.Drawing.Point(197, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.RoundedCorners = False
        Me.btn_Cancel.Size = New System.Drawing.Size(65, 24)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.TabStop = False
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Done
        '
        Me.btn_Done.ButtonStyle = GlobalCode.BonfireButton.Style.Green
        Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Done.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn_Done.Image = Nothing
        Me.btn_Done.Location = New System.Drawing.Point(268, 3)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.RoundedCorners = False
        Me.btn_Done.Size = New System.Drawing.Size(65, 24)
        Me.btn_Done.TabIndex = 1
        Me.btn_Done.TabStop = False
        Me.btn_Done.Text = "Done"
        '
        'frm_Partner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 175)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Partner"
        Me.Text = "Partner"
        Me.HuraForm1.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel_Control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As GlobalCode.HuraForm
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents Panel_Control As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As GlobalCode.BonfireButton
    Friend WithEvents btn_Done As GlobalCode.BonfireButton
    Friend WithEvents txt_PAN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
End Class
