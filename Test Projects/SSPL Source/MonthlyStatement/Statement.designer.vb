Namespace D7Statement
    Partial Class Statement
        Inherits System.ComponentModel.Component

        <System.Diagnostics.DebuggerNonUserCode()>
        Public Sub New(ByVal container As System.ComponentModel.IContainer)
            MyClass.New()

            'Required for Windows.Forms Class Composition Designer support
            If (container IsNot Nothing) Then
                container.Add(Me)
            End If

        End Sub

        <System.Diagnostics.DebuggerNonUserCode()>
        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

        End Sub

        'Component overrides dispose to clean up the component list.
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

        'Required by the Component Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Printer = New D7Statement.ListViewPrinter
            Me.lv_Statement = New System.Windows.Forms.ListView()
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            '
            'Printer
            '
            '
            '
            '
            Me.Printer.CellFormat.BackgroundColor = System.Drawing.Color.Empty
            Me.Printer.CellFormat.BottomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Printer.CellFormat.BottomBorderWidth = 0.5!
            Me.Printer.CellFormat.CanWrap = True
            Me.Printer.CellFormat.Font = New System.Drawing.Font("Times New Roman", 11.0!)
            Me.Printer.CellFormat.LeftBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Printer.CellFormat.LeftBorderWidth = 0.5!
            Me.Printer.CellFormat.MinimumTextHeight = 0!
            Me.Printer.CellFormat.RightBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Printer.CellFormat.RightBorderWidth = 0.5!
            Me.Printer.CellFormat.TextColor = System.Drawing.Color.Black
            Me.Printer.CellFormat.TopBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Printer.CellFormat.TopBorderWidth = 0.5!
            Me.Printer.DocumentName = "Report"
            Me.Printer.footer = Nothing
            '
            '
            '
            Me.Printer.FooterFormat.BackgroundColor = System.Drawing.Color.Empty
            Me.Printer.FooterFormat.BottomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.FooterFormat.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
            Me.Printer.FooterFormat.LeftBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.FooterFormat.MinimumTextHeight = 0!
            Me.Printer.FooterFormat.RightBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.FooterFormat.TextColor = System.Drawing.Color.Black
            Me.Printer.FooterFormat.TopBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.Printer.FooterFormat.TopBorderWidth = 0.5!
            Me.Printer.HeaderFont = New System.Drawing.Font("Times New Roman", 11.0!)
            Me.Printer.HeaderImage = Nothing
            Me.Printer.HeaderText = Nothing
            Me.Printer.ListFont = New System.Drawing.Font("Times New Roman", 11.0!)
            Me.Printer.ListGridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            '
            '
            Me.Printer.ListHeaderFormat.BackgroundColor = System.Drawing.Color.Empty
            Me.Printer.ListHeaderFormat.BottomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.ListHeaderFormat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
            Me.Printer.ListHeaderFormat.LeftBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.ListHeaderFormat.MinimumTextHeight = 0!
            Me.Printer.ListHeaderFormat.RightBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.ListHeaderFormat.TextColor = System.Drawing.Color.Empty
            Me.Printer.ListHeaderFormat.TopBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.ListView = Me.lv_Statement
            '
            'lv_Statement
            '
            Me.lv_Statement.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
            Me.lv_Statement.FullRowSelect = True
            Me.lv_Statement.Location = New System.Drawing.Point(6, 6)
            Me.lv_Statement.Name = "lv_Statement"
            Me.lv_Statement.Size = New System.Drawing.Size(624, 385)
            Me.lv_Statement.TabIndex = 3
            Me.lv_Statement.UseCompatibleStateImageBehavior = False
            Me.lv_Statement.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Report No."
            Me.ColumnHeader3.Width = 98
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Date"
            Me.ColumnHeader4.Width = 82
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Name"
            Me.ColumnHeader5.Width = 325
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "Gender"
            Me.ColumnHeader6.Width = 62
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "Test"
            Me.ColumnHeader7.Width = 146
            '

        End Sub
        Private WithEvents Printer As ListViewPrinter
        Friend WithEvents lv_Statement As ListView
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents ColumnHeader4 As ColumnHeader
        Friend WithEvents ColumnHeader5 As ColumnHeader
        Friend WithEvents ColumnHeader6 As ColumnHeader
        Friend WithEvents ColumnHeader7 As ColumnHeader
    End Class
End Namespace
