Namespace D7
    Partial Class Reporter
        Inherits System.ComponentModel.Component

        <System.Diagnostics.DebuggerNonUserCode()> _
        Public Sub New(ByVal container As System.ComponentModel.IContainer)
            MyClass.New()

            'Required for Windows.Forms Class Composition Designer support
            If (container IsNot Nothing) Then
                container.Add(Me)
            End If

        End Sub

        <System.Diagnostics.DebuggerNonUserCode()> _
        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

        End Sub

        'Component overrides dispose to clean up the component list.
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

        'Required by the Component Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Details = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Printer = New SSPLM.D7.ReportPrinter()
            '
            'Details
            '
            Me.Details.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
            Me.Details.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Details.Location = New System.Drawing.Point(2, 128)
            Me.Details.Name = "Details"
            Me.Details.Size = New System.Drawing.Size(736, 97)
            Me.Details.TabIndex = 5
            Me.Details.UseCompatibleStateImageBehavior = False
            Me.Details.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Width = 110
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Width = 16
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Width = 370
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Width = 78
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Width = 15
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Width = 144
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
            Me.Printer.IsShrinkToFit = True
            Me.Printer.ListFont = New System.Drawing.Font("Times New Roman", 11.0!)
            Me.Printer.ListGridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Printer.ListView = Me.Details
            Me.Printer.ReportImage1 = Nothing
            Me.Printer.ReportImage2 = Nothing
            Me.Printer.ReportImage3 = Nothing
            Me.Printer.ReportImage4 = Nothing
            Me.Printer.Result = Nothing
            Me.Printer.ResultFont = New System.Drawing.Font("Times New Roman", 11.0!)

        End Sub
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Private WithEvents Details As System.Windows.Forms.ListView
        Friend WithEvents Printer As ReportPrinter
    End Class
End Namespace
