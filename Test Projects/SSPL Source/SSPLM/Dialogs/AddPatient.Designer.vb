<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPatient
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPatient))
        Me.HuraForm1 = New SSPLM.HuraForm()
        Me.HuraControlBox1 = New SSPLM.HuraControlBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_OK = New SSPLM.HuraButton()
        Me.btn_Cancel = New SSPLM.HuraButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportImage4 = New SSPLM.ReportImage()
        Me.ReportImage3 = New SSPLM.ReportImage()
        Me.ReportImage1 = New SSPLM.ReportImage()
        Me.ReportImage2 = New SSPLM.ReportImage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DiagnosticsData = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_SearchDiagnostics = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SitesData = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_SearchSites = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DoctorData = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_SearchDoctor = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btn_AddDoc = New SSPLM.HuraButton()
        Me.btn_EditDoc = New SSPLM.HuraButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cb_DoctorID = New SSPLM.HuraComboBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txt_Test = New SSPLM.HuraComboBox()
        Me.txt_Age = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ls_Diagnostics = New System.Windows.Forms.ListBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btn_RemoveDisgnostics = New SSPLM.HuraButton()
        Me.btn_AddDiagnostics = New SSPLM.HuraButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ls_Site = New System.Windows.Forms.ListBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btn_RemoveSite = New SSPLM.HuraButton()
        Me.btn_AddSite = New SSPLM.HuraButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_State = New SSPLM.HuraComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_ReportedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_ReceivedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_SurName = New SSPLM.HuraComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Gender = New SSPLM.HuraComboBox()
        Me.txt_PatientName = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_HospitalNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_AddressLine1 = New System.Windows.Forms.TextBox()
        Me.txt_Mobile = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_AddressLine2 = New System.Windows.Forms.TextBox()
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_PreviousReportNumber = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txt_ReportNumber = New System.Windows.Forms.MaskedTextBox()
        Me.ExtendReportNumber = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Notes = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_Report = New System.Windows.Forms.TextBox()
        Me.HuraForm1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DiagnosticsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SitesData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DoctorData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = SSPLM.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.Panel2)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(762, 444)
        Me.HuraForm1.TabIndex = 34
        Me.HuraForm1.Text = "Add New"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.AccentColorClose = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = SSPLM.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(660, 2)
        Me.HuraControlBox1.Maximize = True
        Me.HuraControlBox1.Minimize = True
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 34
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(4, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 408)
        Me.Panel2.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_OK)
        Me.Panel5.Controls.Add(Me.btn_Cancel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 1695)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(738, 27)
        Me.Panel5.TabIndex = 0
        '
        'btn_OK
        '
        Me.btn_OK.AccessibleName = "OK"
        Me.btn_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_OK.BaseColour = System.Drawing.Color.White
        Me.btn_OK.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_OK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_OK.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_OK.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OK.Location = New System.Drawing.Point(610, 0)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_OK.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_OK.Size = New System.Drawing.Size(64, 27)
        Me.btn_OK.TabIndex = 19
        Me.btn_OK.Text = "OK"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleName = "Cancel"
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Cancel.BaseColour = System.Drawing.Color.White
        Me.btn_Cancel.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Cancel.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_Cancel.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel.Location = New System.Drawing.Point(674, 0)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Cancel.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Cancel.Size = New System.Drawing.Size(64, 27)
        Me.btn_Cancel.TabIndex = 22
        Me.btn_Cancel.TabStop = False
        Me.btn_Cancel.Text = "Cancel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportImage4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReportImage3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReportImage1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReportImage2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 1009)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(738, 686)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'ReportImage4
        '
        Me.ReportImage4.BackColor = System.Drawing.Color.White
        Me.ReportImage4.CaptionText = "Image 3"
        Me.ReportImage4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportImage4.Location = New System.Drawing.Point(3, 347)
        Me.ReportImage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportImage4.Name = "ReportImage4"
        Me.ReportImage4.SelectedImage = Nothing
        Me.ReportImage4.SelectedImageValidity = False
        Me.ReportImage4.SelectedName = ""
        Me.ReportImage4.Size = New System.Drawing.Size(363, 335)
        Me.ReportImage4.TabIndex = 25
        Me.ReportImage4.TabStop = False
        '
        'ReportImage3
        '
        Me.ReportImage3.BackColor = System.Drawing.Color.White
        Me.ReportImage3.CaptionText = "Image 4"
        Me.ReportImage3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportImage3.Location = New System.Drawing.Point(372, 347)
        Me.ReportImage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportImage3.Name = "ReportImage3"
        Me.ReportImage3.SelectedImage = Nothing
        Me.ReportImage3.SelectedImageValidity = False
        Me.ReportImage3.SelectedName = ""
        Me.ReportImage3.Size = New System.Drawing.Size(363, 335)
        Me.ReportImage3.TabIndex = 25
        Me.ReportImage3.TabStop = False
        '
        'ReportImage1
        '
        Me.ReportImage1.BackColor = System.Drawing.Color.White
        Me.ReportImage1.CaptionText = "Image 1"
        Me.ReportImage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportImage1.Location = New System.Drawing.Point(3, 4)
        Me.ReportImage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportImage1.Name = "ReportImage1"
        Me.ReportImage1.SelectedImage = Nothing
        Me.ReportImage1.SelectedImageValidity = False
        Me.ReportImage1.SelectedName = ""
        Me.ReportImage1.Size = New System.Drawing.Size(363, 335)
        Me.ReportImage1.TabIndex = 25
        Me.ReportImage1.TabStop = False
        '
        'ReportImage2
        '
        Me.ReportImage2.BackColor = System.Drawing.Color.White
        Me.ReportImage2.CaptionText = "Image 2"
        Me.ReportImage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportImage2.Location = New System.Drawing.Point(372, 4)
        Me.ReportImage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportImage2.Name = "ReportImage2"
        Me.ReportImage2.SelectedImage = Nothing
        Me.ReportImage2.SelectedImageValidity = False
        Me.ReportImage2.SelectedName = ""
        Me.ReportImage2.Size = New System.Drawing.Size(363, 335)
        Me.ReportImage2.TabIndex = 25
        Me.ReportImage2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel6.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel6.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(738, 1009)
        Me.Panel6.TabIndex = 38
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(507, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(231, 817)
        Me.TableLayoutPanel3.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DiagnosticsData)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 549)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 265)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Diagnostics"
        '
        'DiagnosticsData
        '
        Me.DiagnosticsData.AllowUserToAddRows = False
        Me.DiagnosticsData.AllowUserToDeleteRows = False
        Me.DiagnosticsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DiagnosticsData.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiagnosticsData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DiagnosticsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiagnosticsData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiagnosticsData.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.DiagnosticsData.Location = New System.Drawing.Point(3, 50)
        Me.DiagnosticsData.MultiSelect = False
        Me.DiagnosticsData.Name = "DiagnosticsData"
        Me.DiagnosticsData.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiagnosticsData.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DiagnosticsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DiagnosticsData.Size = New System.Drawing.Size(219, 212)
        Me.DiagnosticsData.StandardTab = True
        Me.DiagnosticsData.TabIndex = 7
        Me.DiagnosticsData.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_SearchDiagnostics)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(219, 30)
        Me.Panel4.TabIndex = 1
        '
        'txt_SearchDiagnostics
        '
        Me.txt_SearchDiagnostics.BackColor = System.Drawing.Color.White
        Me.txt_SearchDiagnostics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SearchDiagnostics.Location = New System.Drawing.Point(56, 0)
        Me.txt_SearchDiagnostics.Name = "txt_SearchDiagnostics"
        Me.txt_SearchDiagnostics.Size = New System.Drawing.Size(161, 24)
        Me.txt_SearchDiagnostics.TabIndex = 1
        Me.txt_SearchDiagnostics.TabStop = False
        '
        'Label25
        '
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 28)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Search :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SitesData)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 263)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sites"
        '
        'SitesData
        '
        Me.SitesData.AllowUserToAddRows = False
        Me.SitesData.AllowUserToDeleteRows = False
        Me.SitesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SitesData.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SitesData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SitesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SitesData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SitesData.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.SitesData.Location = New System.Drawing.Point(3, 50)
        Me.SitesData.MultiSelect = False
        Me.SitesData.Name = "SitesData"
        Me.SitesData.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SitesData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.SitesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SitesData.Size = New System.Drawing.Size(219, 210)
        Me.SitesData.StandardTab = True
        Me.SitesData.TabIndex = 6
        Me.SitesData.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_SearchSites)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(219, 30)
        Me.Panel3.TabIndex = 1
        '
        'txt_SearchSites
        '
        Me.txt_SearchSites.BackColor = System.Drawing.Color.White
        Me.txt_SearchSites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SearchSites.Location = New System.Drawing.Point(56, 0)
        Me.txt_SearchSites.Name = "txt_SearchSites"
        Me.txt_SearchSites.Size = New System.Drawing.Size(161, 24)
        Me.txt_SearchSites.TabIndex = 1
        Me.txt_SearchSites.TabStop = False
        '
        'Label24
        '
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label24.Location = New System.Drawing.Point(0, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 28)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Search :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DoctorData)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel13)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 271)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor"
        '
        'DoctorData
        '
        Me.DoctorData.AllowUserToAddRows = False
        Me.DoctorData.AllowUserToDeleteRows = False
        Me.DoctorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DoctorData.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DoctorData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DoctorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DoctorData.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.DoctorData.Location = New System.Drawing.Point(3, 50)
        Me.DoctorData.MultiSelect = False
        Me.DoctorData.Name = "DoctorData"
        Me.DoctorData.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DoctorData.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DoctorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DoctorData.Size = New System.Drawing.Size(219, 187)
        Me.DoctorData.StandardTab = True
        Me.DoctorData.TabIndex = 14
        Me.DoctorData.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_SearchDoctor)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 30)
        Me.Panel1.TabIndex = 1
        '
        'txt_SearchDoctor
        '
        Me.txt_SearchDoctor.BackColor = System.Drawing.Color.White
        Me.txt_SearchDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SearchDoctor.Location = New System.Drawing.Point(56, 0)
        Me.txt_SearchDoctor.Name = "txt_SearchDoctor"
        Me.txt_SearchDoctor.Size = New System.Drawing.Size(161, 24)
        Me.txt_SearchDoctor.TabIndex = 1
        Me.txt_SearchDoctor.TabStop = False
        '
        'Label23
        '
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label23.Location = New System.Drawing.Point(0, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 28)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Search :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.btn_AddDoc)
        Me.Panel13.Controls.Add(Me.btn_EditDoc)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(3, 237)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(219, 31)
        Me.Panel13.TabIndex = 16
        '
        'btn_AddDoc
        '
        Me.btn_AddDoc.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddDoc.BaseColour = System.Drawing.Color.White
        Me.btn_AddDoc.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_AddDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_AddDoc.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_AddDoc.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddDoc.Location = New System.Drawing.Point(102, 0)
        Me.btn_AddDoc.Name = "btn_AddDoc"
        Me.btn_AddDoc.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_AddDoc.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddDoc.Size = New System.Drawing.Size(59, 31)
        Me.btn_AddDoc.TabIndex = 0
        Me.btn_AddDoc.Text = "Add New"
        '
        'btn_EditDoc
        '
        Me.btn_EditDoc.BackColor = System.Drawing.Color.Transparent
        Me.btn_EditDoc.BaseColour = System.Drawing.Color.White
        Me.btn_EditDoc.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_EditDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_EditDoc.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_EditDoc.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_EditDoc.Location = New System.Drawing.Point(161, 0)
        Me.btn_EditDoc.Name = "btn_EditDoc"
        Me.btn_EditDoc.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_EditDoc.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_EditDoc.Size = New System.Drawing.Size(58, 31)
        Me.btn_EditDoc.TabIndex = 0
        Me.btn_EditDoc.Text = "Edit"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel12, 1, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel11, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Age, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel9, 1, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel7, 1, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 0, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_State, 1, 11)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 0, 17)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_ReportedDate, 1, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 0, 16)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_ReceivedDate, 1, 17)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 0, 15)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_SurName, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 0, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Gender, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_PatientName, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Email, 1, 13)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_HospitalNumber, 1, 15)
        Me.TableLayoutPanel4.Controls.Add(Me.Label14, 0, 13)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_AddressLine1, 1, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Mobile, 1, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 0, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_AddressLine2, 1, 9)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_City, 1, 10)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 0, 11)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 0, 10)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_PreviousReportNumber, 1, 16)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel14, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 19
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(507, 817)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(30, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 31)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Report Number :"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.cb_DoctorID)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(143, 662)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(361, 25)
        Me.Panel12.TabIndex = 43
        '
        'cb_DoctorID
        '
        Me.cb_DoctorID.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cb_DoctorID.BackColor = System.Drawing.Color.White
        Me.cb_DoctorID.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.cb_DoctorID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_DoctorID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_DoctorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_DoctorID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_DoctorID.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cb_DoctorID.ForeColor = System.Drawing.Color.White
        Me.cb_DoctorID.FormattingEnabled = True
        Me.cb_DoctorID.Location = New System.Drawing.Point(0, 0)
        Me.cb_DoctorID.Name = "cb_DoctorID"
        Me.cb_DoctorID.Size = New System.Drawing.Size(361, 25)
        Me.cb_DoctorID.TabIndex = 12
        Me.cb_DoctorID.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.txt_Test)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(143, 158)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(361, 25)
        Me.Panel11.TabIndex = 43
        '
        'txt_Test
        '
        Me.txt_Test.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txt_Test.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Test.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.txt_Test.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Test.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_Test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_Test.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txt_Test.ForeColor = System.Drawing.Color.White
        Me.txt_Test.FormattingEnabled = True
        Me.txt_Test.Location = New System.Drawing.Point(0, 0)
        Me.txt_Test.Name = "txt_Test"
        Me.txt_Test.Size = New System.Drawing.Size(361, 25)
        Me.txt_Test.TabIndex = 5
        '
        'txt_Age
        '
        Me.txt_Age.BackColor = System.Drawing.Color.White
        Me.txt_Age.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Age.Location = New System.Drawing.Point(143, 96)
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.Size = New System.Drawing.Size(361, 24)
        Me.txt_Age.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.ls_Diagnostics)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(143, 326)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(361, 144)
        Me.Panel9.TabIndex = 39
        '
        'ls_Diagnostics
        '
        Me.ls_Diagnostics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ls_Diagnostics.FormattingEnabled = True
        Me.ls_Diagnostics.HorizontalScrollbar = True
        Me.ls_Diagnostics.ItemHeight = 17
        Me.ls_Diagnostics.Location = New System.Drawing.Point(0, 0)
        Me.ls_Diagnostics.Name = "ls_Diagnostics"
        Me.ls_Diagnostics.Size = New System.Drawing.Size(328, 144)
        Me.ls_Diagnostics.TabIndex = 35
        Me.ls_Diagnostics.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btn_RemoveDisgnostics)
        Me.Panel10.Controls.Add(Me.btn_AddDiagnostics)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(328, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(33, 144)
        Me.Panel10.TabIndex = 0
        '
        'btn_RemoveDisgnostics
        '
        Me.btn_RemoveDisgnostics.BackColor = System.Drawing.Color.Transparent
        Me.btn_RemoveDisgnostics.BaseColour = System.Drawing.Color.White
        Me.btn_RemoveDisgnostics.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_RemoveDisgnostics.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RemoveDisgnostics.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_RemoveDisgnostics.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveDisgnostics.Location = New System.Drawing.Point(0, 33)
        Me.btn_RemoveDisgnostics.Name = "btn_RemoveDisgnostics"
        Me.btn_RemoveDisgnostics.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_RemoveDisgnostics.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveDisgnostics.Size = New System.Drawing.Size(33, 33)
        Me.btn_RemoveDisgnostics.TabIndex = 34
        Me.btn_RemoveDisgnostics.TabStop = False
        Me.btn_RemoveDisgnostics.Text = "-"
        '
        'btn_AddDiagnostics
        '
        Me.btn_AddDiagnostics.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddDiagnostics.BaseColour = System.Drawing.Color.White
        Me.btn_AddDiagnostics.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_AddDiagnostics.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_AddDiagnostics.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_AddDiagnostics.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddDiagnostics.Location = New System.Drawing.Point(0, 0)
        Me.btn_AddDiagnostics.Name = "btn_AddDiagnostics"
        Me.btn_AddDiagnostics.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_AddDiagnostics.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddDiagnostics.Size = New System.Drawing.Size(33, 33)
        Me.btn_AddDiagnostics.TabIndex = 34
        Me.btn_AddDiagnostics.TabStop = False
        Me.btn_AddDiagnostics.Text = "+"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ls_Site)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(143, 189)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(361, 131)
        Me.Panel7.TabIndex = 39
        '
        'ls_Site
        '
        Me.ls_Site.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ls_Site.FormattingEnabled = True
        Me.ls_Site.HorizontalScrollbar = True
        Me.ls_Site.ItemHeight = 17
        Me.ls_Site.Location = New System.Drawing.Point(0, 0)
        Me.ls_Site.Name = "ls_Site"
        Me.ls_Site.Size = New System.Drawing.Size(328, 131)
        Me.ls_Site.TabIndex = 35
        Me.ls_Site.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btn_RemoveSite)
        Me.Panel8.Controls.Add(Me.btn_AddSite)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(328, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(33, 131)
        Me.Panel8.TabIndex = 0
        '
        'btn_RemoveSite
        '
        Me.btn_RemoveSite.BackColor = System.Drawing.Color.Transparent
        Me.btn_RemoveSite.BaseColour = System.Drawing.Color.White
        Me.btn_RemoveSite.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_RemoveSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RemoveSite.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_RemoveSite.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveSite.Location = New System.Drawing.Point(0, 33)
        Me.btn_RemoveSite.Name = "btn_RemoveSite"
        Me.btn_RemoveSite.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_RemoveSite.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_RemoveSite.Size = New System.Drawing.Size(33, 33)
        Me.btn_RemoveSite.TabIndex = 34
        Me.btn_RemoveSite.TabStop = False
        Me.btn_RemoveSite.Text = "-"
        '
        'btn_AddSite
        '
        Me.btn_AddSite.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddSite.BaseColour = System.Drawing.Color.White
        Me.btn_AddSite.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_AddSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_AddSite.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_AddSite.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddSite.Location = New System.Drawing.Point(0, 0)
        Me.btn_AddSite.Name = "btn_AddSite"
        Me.btn_AddSite.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_AddSite.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddSite.Size = New System.Drawing.Size(33, 33)
        Me.btn_AddSite.TabIndex = 34
        Me.btn_AddSite.TabStop = False
        Me.btn_AddSite.Text = "+"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label19.Location = New System.Drawing.Point(36, 783)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 34)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Reported Date :"
        '
        'txt_State
        '
        Me.txt_State.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txt_State.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_State.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.txt_State.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_State.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txt_State.ForeColor = System.Drawing.Color.White
        Me.txt_State.FormattingEnabled = True
        Me.txt_State.Items.AddRange(New Object() {"Andaman and Nicobar Islands", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chandigarh", "Chhattisgarh", "Dadra and Nagar Haveli", "Daman and Diu", "Delhi", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Lakshadweep", "Madhya Pradesh", "Maharashtra", "Manipurß", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Puducherry", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"})
        Me.txt_State.Location = New System.Drawing.Point(143, 569)
        Me.txt_State.Name = "txt_State"
        Me.txt_State.Size = New System.Drawing.Size(361, 25)
        Me.txt_State.Sorted = True
        Me.txt_State.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label18.Location = New System.Drawing.Point(39, 752)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 31)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Received Date :"
        '
        'txt_ReportedDate
        '
        Me.txt_ReportedDate.CustomFormat = "dd/MM/yyyy"
        Me.txt_ReportedDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ReportedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_ReportedDate.Location = New System.Drawing.Point(143, 786)
        Me.txt_ReportedDate.Name = "txt_ReportedDate"
        Me.txt_ReportedDate.Size = New System.Drawing.Size(361, 24)
        Me.txt_ReportedDate.TabIndex = 16
        Me.txt_ReportedDate.Value = New Date(2016, 6, 2, 20, 11, 37, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label17.Location = New System.Drawing.Point(32, 721)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 31)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Previous Report Number :"
        '
        'txt_ReceivedDate
        '
        Me.txt_ReceivedDate.CustomFormat = "dd/MM/yyyy"
        Me.txt_ReceivedDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_ReceivedDate.Location = New System.Drawing.Point(143, 755)
        Me.txt_ReceivedDate.Name = "txt_ReceivedDate"
        Me.txt_ReceivedDate.Size = New System.Drawing.Size(361, 24)
        Me.txt_ReceivedDate.TabIndex = 15
        Me.txt_ReceivedDate.Value = New Date(2016, 6, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(64, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sur Name :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label16.Location = New System.Drawing.Point(22, 690)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 31)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Hospital Number :"
        '
        'txt_SurName
        '
        Me.txt_SurName.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txt_SurName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_SurName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_SurName.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.txt_SurName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SurName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_SurName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_SurName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txt_SurName.ForeColor = System.Drawing.Color.White
        Me.txt_SurName.FormattingEnabled = True
        Me.txt_SurName.Items.AddRange(New Object() {"MS.", "MISS.", "MRS.", "MR.", "MAST.", "BABY.", "B/O.", "FR.", "DR.", "SR.", "BR.", "CAPT.", "PET.", "MOTHER."})
        Me.txt_SurName.Location = New System.Drawing.Point(143, 34)
        Me.txt_SurName.Name = "txt_SurName"
        Me.txt_SurName.Size = New System.Drawing.Size(361, 25)
        Me.txt_SurName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(64, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Full Name :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Location = New System.Drawing.Point(66, 659)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 31)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Doctor ID :"
        '
        'txt_Gender
        '
        Me.txt_Gender.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txt_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_Gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Gender.ColorScheme = SSPLM.HuraComboBox.ColorSchemes.Dark
        Me.txt_Gender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_Gender.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txt_Gender.ForeColor = System.Drawing.Color.White
        Me.txt_Gender.FormattingEnabled = True
        Me.txt_Gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.txt_Gender.Location = New System.Drawing.Point(143, 127)
        Me.txt_Gender.Name = "txt_Gender"
        Me.txt_Gender.Size = New System.Drawing.Size(361, 25)
        Me.txt_Gender.TabIndex = 4
        '
        'txt_PatientName
        '
        Me.txt_PatientName.BackColor = System.Drawing.Color.White
        Me.txt_PatientName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PatientName.Location = New System.Drawing.Point(143, 65)
        Me.txt_PatientName.Name = "txt_PatientName"
        Me.txt_PatientName.Size = New System.Drawing.Size(361, 24)
        Me.txt_PatientName.TabIndex = 2
        '
        'txt_Email
        '
        Me.txt_Email.BackColor = System.Drawing.Color.White
        Me.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Email.Location = New System.Drawing.Point(143, 631)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(361, 24)
        Me.txt_Email.TabIndex = 11
        '
        'txt_HospitalNumber
        '
        Me.txt_HospitalNumber.BackColor = System.Drawing.Color.White
        Me.txt_HospitalNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_HospitalNumber.Location = New System.Drawing.Point(143, 693)
        Me.txt_HospitalNumber.Name = "txt_HospitalNumber"
        Me.txt_HospitalNumber.Size = New System.Drawing.Size(361, 24)
        Me.txt_HospitalNumber.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label14.Location = New System.Drawing.Point(86, 628)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 31)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "E Mail :"
        '
        'txt_AddressLine1
        '
        Me.txt_AddressLine1.BackColor = System.Drawing.Color.White
        Me.txt_AddressLine1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AddressLine1.Location = New System.Drawing.Point(143, 476)
        Me.txt_AddressLine1.Name = "txt_AddressLine1"
        Me.txt_AddressLine1.Size = New System.Drawing.Size(361, 24)
        Me.txt_AddressLine1.TabIndex = 6
        '
        'txt_Mobile
        '
        Me.txt_Mobile.BackColor = System.Drawing.Color.White
        Me.txt_Mobile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Mobile.Location = New System.Drawing.Point(143, 600)
        Me.txt_Mobile.Name = "txt_Mobile"
        Me.txt_Mobile.Size = New System.Drawing.Size(361, 24)
        Me.txt_Mobile.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Location = New System.Drawing.Point(81, 597)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 31)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Mobile :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(99, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Age :"
        '
        'txt_AddressLine2
        '
        Me.txt_AddressLine2.BackColor = System.Drawing.Color.White
        Me.txt_AddressLine2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AddressLine2.Location = New System.Drawing.Point(143, 507)
        Me.txt_AddressLine2.Name = "txt_AddressLine2"
        Me.txt_AddressLine2.Size = New System.Drawing.Size(361, 24)
        Me.txt_AddressLine2.TabIndex = 7
        '
        'txt_City
        '
        Me.txt_City.BackColor = System.Drawing.Color.White
        Me.txt_City.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_City.Location = New System.Drawing.Point(143, 538)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(361, 24)
        Me.txt_City.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label12.Location = New System.Drawing.Point(93, 566)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 31)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "State :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(79, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Location = New System.Drawing.Point(99, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Test :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Location = New System.Drawing.Point(101, 535)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 31)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "City :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Location = New System.Drawing.Point(101, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 137)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Site :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Location = New System.Drawing.Point(55, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 150)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Diagnostics :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label10.Location = New System.Drawing.Point(36, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 31)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Address Line 2 :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Location = New System.Drawing.Point(36, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Address Line 1 :"
        '
        'txt_PreviousReportNumber
        '
        Me.txt_PreviousReportNumber.BackColor = System.Drawing.Color.White
        Me.txt_PreviousReportNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PreviousReportNumber.Location = New System.Drawing.Point(143, 724)
        Me.txt_PreviousReportNumber.Name = "txt_PreviousReportNumber"
        Me.txt_PreviousReportNumber.Size = New System.Drawing.Size(361, 24)
        Me.txt_PreviousReportNumber.TabIndex = 14
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.txt_ReportNumber)
        Me.Panel14.Controls.Add(Me.ExtendReportNumber)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(143, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(361, 25)
        Me.Panel14.TabIndex = 45
        '
        'txt_ReportNumber
        '
        Me.txt_ReportNumber.AccessibleName = "Report Number"
        Me.txt_ReportNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txt_ReportNumber.BeepOnError = True
        Me.txt_ReportNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ReportNumber.Location = New System.Drawing.Point(0, 0)
        Me.txt_ReportNumber.Mask = "aa-9999-9999"
        Me.txt_ReportNumber.Name = "txt_ReportNumber"
        Me.txt_ReportNumber.Size = New System.Drawing.Size(295, 24)
        Me.txt_ReportNumber.TabIndex = 1
        '
        'ExtendReportNumber
        '
        Me.ExtendReportNumber.AutoSize = True
        Me.ExtendReportNumber.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExtendReportNumber.Location = New System.Drawing.Point(295, 0)
        Me.ExtendReportNumber.Name = "ExtendReportNumber"
        Me.ExtendReportNumber.Size = New System.Drawing.Size(66, 25)
        Me.ExtendReportNumber.TabIndex = 2
        Me.ExtendReportNumber.TabStop = False
        Me.ExtendReportNumber.Text = "Extend"
        Me.ExtendReportNumber.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Notes, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Report, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 817)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(738, 192)
        Me.TableLayoutPanel2.TabIndex = 0
        Me.TableLayoutPanel2.TabStop = True
        '
        'txt_Notes
        '
        Me.txt_Notes.BackColor = System.Drawing.Color.White
        Me.txt_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Notes.Location = New System.Drawing.Point(143, 152)
        Me.txt_Notes.Multiline = True
        Me.txt_Notes.Name = "txt_Notes"
        Me.txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Notes.Size = New System.Drawing.Size(592, 37)
        Me.txt_Notes.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label20.Location = New System.Drawing.Point(82, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 149)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Report :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label21.Location = New System.Drawing.Point(87, 149)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 43)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Notes :"
        '
        'txt_Report
        '
        Me.txt_Report.AccessibleName = "Report"
        Me.txt_Report.BackColor = System.Drawing.Color.White
        Me.txt_Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Report.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Report.Location = New System.Drawing.Point(143, 3)
        Me.txt_Report.Multiline = True
        Me.txt_Report.Name = "txt_Report"
        Me.txt_Report.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Report.Size = New System.Drawing.Size(592, 143)
        Me.txt_Report.TabIndex = 17
        '
        'AddPatient
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 444)
        Me.Controls.Add(Me.HuraForm1)
        Me.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPatient"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Patient Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HuraForm1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DiagnosticsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SitesData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DoctorData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ReportImage1 As ReportImage
    Friend WithEvents ReportImage2 As ReportImage
    Friend WithEvents ReportImage3 As ReportImage
    Friend WithEvents ReportImage4 As ReportImage
    Friend WithEvents btn_OK As HuraButton
    Friend WithEvents btn_Cancel As HuraButton
    Friend WithEvents txt_SurName As HuraComboBox
    Friend WithEvents txt_Gender As HuraComboBox
    Friend WithEvents txt_State As HuraComboBox
    Friend WithEvents txt_PatientName As TextBox
    Friend WithEvents txt_Age As TextBox
    Friend WithEvents txt_AddressLine1 As TextBox
    Friend WithEvents txt_AddressLine2 As TextBox
    Friend WithEvents txt_City As TextBox
    Friend WithEvents txt_Mobile As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_HospitalNumber As TextBox
    Friend WithEvents txt_PreviousReportNumber As TextBox
    Friend WithEvents txt_Report As TextBox
    Friend WithEvents txt_Notes As TextBox
    Friend WithEvents txt_ReceivedDate As DateTimePicker
    Friend WithEvents txt_ReportedDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_SearchDoctor As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents DoctorData As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_RemoveDisgnostics As HuraButton
    Friend WithEvents btn_RemoveSite As HuraButton
    Friend WithEvents btn_AddDiagnostics As HuraButton
    Friend WithEvents btn_AddSite As HuraButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DiagnosticsData As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_SearchDiagnostics As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SitesData As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_SearchSites As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ls_Site As ListBox
    Friend WithEvents ls_Diagnostics As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txt_Test As HuraComboBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents cb_DoctorID As HuraComboBox
    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btn_AddDoc As HuraButton
    Friend WithEvents btn_EditDoc As HuraButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txt_ReportNumber As MaskedTextBox
    Friend WithEvents ExtendReportNumber As CheckBox
End Class
