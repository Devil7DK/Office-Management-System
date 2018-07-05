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
            Me.Printer = New SSPLM.D7Statement.ListViewPrinter()
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
            '
            '
            '
            Me.Printer.GroupHeaderFormat.BackgroundColor = System.Drawing.Color.Empty
            Me.Printer.GroupHeaderFormat.BottomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.GroupHeaderFormat.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
            Me.Printer.GroupHeaderFormat.LeftBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.GroupHeaderFormat.MinimumTextHeight = 0!
            Me.Printer.GroupHeaderFormat.RightBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.GroupHeaderFormat.TextColor = System.Drawing.Color.Empty
            Me.Printer.GroupHeaderFormat.TopBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.Header = Nothing
            Me.Printer.HeaderFont = New System.Drawing.Font("Times New Roman", 11.0!)
            '
            '
            '
            Me.Printer.HeaderFormat.BackgroundColor = System.Drawing.Color.Empty
            Me.Printer.HeaderFormat.BottomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.HeaderFormat.Font = New System.Drawing.Font("Verdana", 24.0!)
            Me.Printer.HeaderFormat.LeftBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.HeaderFormat.MinimumTextHeight = 0!
            Me.Printer.HeaderFormat.RightBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.HeaderFormat.TextColor = System.Drawing.Color.Empty
            Me.Printer.HeaderFormat.TopBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Printer.HeaderImage = Nothing
            Me.Printer.HeaderText = Nothing
            Me.Printer.isListHeaderOnEachPage = False
            Me.Printer.IsShrinkToFit = True
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
            Me.Printer.Watermark = Nothing
            Me.Printer.WatermarkColor = System.Drawing.Color.Empty
            Me.Printer.WatermarkFont = Nothing

        End Sub
        Private WithEvents Printer As ListViewPrinter
    End Class
End Namespace
