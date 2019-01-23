<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_FeesReminder_Mail
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_FeesReminder_Mail))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.table_Content = New DevExpress.XtraReports.UI.XRTable()
        Me.row_Content = New DevExpress.XtraReports.UI.XRTableRow()
        Me.cell_Serial = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_Date = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_AmountDr = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_AmountCr = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.text_Body = New DevExpress.XtraReports.UI.XRRichText()
        Me.table_Header = New DevExpress.XtraReports.UI.XRTable()
        Me.row_Header = New DevExpress.XtraReports.UI.XRTableRow()
        Me.cell_Serial_Head = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_Date_Head = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_Details_Head = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_AmountDr_Head = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_AmountCr_Head = New DevExpress.XtraReports.UI.XRTableCell()
        Me.table_Footer = New DevExpress.XtraReports.UI.XRTable()
        Me.row_Footer = New DevExpress.XtraReports.UI.XRTableRow()
        Me.cell_Balance_Head = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_Total = New DevExpress.XtraReports.UI.XRTableCell()
        Me.cell_Total_Dummy = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.text_ThankYou = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        CType(Me.table_Content, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text_Body, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table_Content})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        '
        'table_Content
        '
        Me.table_Content.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.table_Content.LocationFloat = New DevExpress.Utils.PointFloat(51.04169!, 0!)
        Me.table_Content.Name = "table_Content"
        Me.table_Content.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.row_Content})
        Me.table_Content.SizeF = New System.Drawing.SizeF(670.0001!, 25.0!)
        Me.table_Content.StylePriority.UseBorders = False
        Me.table_Content.StylePriority.UseTextAlignment = False
        Me.table_Content.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'row_Content
        '
        Me.row_Content.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.cell_Serial, Me.cell_Date, Me.cell_Details, Me.cell_AmountDr, Me.cell_AmountCr})
        Me.row_Content.Name = "row_Content"
        Me.row_Content.Weight = 11.5R
        '
        'cell_Serial
        '
        Me.cell_Serial.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]+1")})
        Me.cell_Serial.Multiline = True
        Me.cell_Serial.Name = "cell_Serial"
        Me.cell_Serial.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Serial.StylePriority.UseTextAlignment = False
        Me.cell_Serial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.cell_Serial.Weight = 0.15705128596379211R
        '
        'cell_Date
        '
        Me.cell_Date.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items].[Date]")})
        Me.cell_Date.Multiline = True
        Me.cell_Date.Name = "cell_Date"
        Me.cell_Date.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.cell_Date.StylePriority.UseTextAlignment = False
        Me.cell_Date.Text = "cell_Date"
        Me.cell_Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.cell_Date.Weight = 0.27371789785531858R
        '
        'cell_Details
        '
        Me.cell_Details.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items].[Detail]")})
        Me.cell_Details.Multiline = True
        Me.cell_Details.Name = "cell_Details"
        Me.cell_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.cell_Details.Text = "cell_Details"
        Me.cell_Details.Weight = 1.0153853588782813R
        '
        'cell_AmountDr
        '
        Me.cell_AmountDr.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items].[Dr]")})
        Me.cell_AmountDr.Multiline = True
        Me.cell_AmountDr.Name = "cell_AmountDr"
        Me.cell_AmountDr.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.cell_AmountDr.StylePriority.UseTextAlignment = False
        Me.cell_AmountDr.Text = "cell_AmountDr"
        Me.cell_AmountDr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.cell_AmountDr.Weight = 0.30769211358512538R
        '
        'cell_AmountCr
        '
        Me.cell_AmountCr.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items].[Cr]")})
        Me.cell_AmountCr.Multiline = True
        Me.cell_AmountCr.Name = "cell_AmountCr"
        Me.cell_AmountCr.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.cell_AmountCr.StylePriority.UseTextAlignment = False
        Me.cell_AmountCr.Text = "cell_AmountCr"
        Me.cell_AmountCr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.cell_AmountCr.Weight = 0.3076920869566655R
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.text_Body, Me.table_Header})
        Me.ReportHeader.HeightF = 142.7083!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'text_Body
        '
        Me.text_Body.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_Body.LocationFloat = New DevExpress.Utils.PointFloat(51.04192!, 0!)
        Me.text_Body.Name = "text_Body"
        Me.text_Body.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.text_Body.SerializableRtfString = resources.GetString("text_Body.SerializableRtfString")
        Me.text_Body.SizeF = New System.Drawing.SizeF(670.0002!, 102.3749!)
        '
        'table_Header
        '
        Me.table_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.table_Header.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.table_Header.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.table_Header.BorderWidth = 2.0!
        Me.table_Header.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table_Header.ForeColor = System.Drawing.Color.White
        Me.table_Header.LocationFloat = New DevExpress.Utils.PointFloat(51.04192!, 117.7084!)
        Me.table_Header.Name = "table_Header"
        Me.table_Header.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.row_Header})
        Me.table_Header.SizeF = New System.Drawing.SizeF(670.0002!, 25.0!)
        Me.table_Header.StylePriority.UseBackColor = False
        Me.table_Header.StylePriority.UseBorderColor = False
        Me.table_Header.StylePriority.UseBorders = False
        Me.table_Header.StylePriority.UseBorderWidth = False
        Me.table_Header.StylePriority.UseFont = False
        Me.table_Header.StylePriority.UseForeColor = False
        '
        'row_Header
        '
        Me.row_Header.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.cell_Serial_Head, Me.cell_Date_Head, Me.cell_Details_Head, Me.cell_AmountDr_Head, Me.cell_AmountCr_Head})
        Me.row_Header.Name = "row_Header"
        Me.row_Header.StylePriority.UseTextAlignment = False
        Me.row_Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.row_Header.Weight = 1.0R
        '
        'cell_Serial_Head
        '
        Me.cell_Serial_Head.Multiline = True
        Me.cell_Serial_Head.Name = "cell_Serial_Head"
        Me.cell_Serial_Head.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Serial_Head.StylePriority.UseTextAlignment = False
        Me.cell_Serial_Head.Text = "#"
        Me.cell_Serial_Head.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.cell_Serial_Head.Weight = 0.33309484375450704R
        '
        'cell_Date_Head
        '
        Me.cell_Date_Head.Multiline = True
        Me.cell_Date_Head.Name = "cell_Date_Head"
        Me.cell_Date_Head.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Date_Head.Text = "Date"
        Me.cell_Date_Head.Weight = 0.58053686602522692R
        '
        'cell_Details_Head
        '
        Me.cell_Details_Head.Multiline = True
        Me.cell_Details_Head.Name = "cell_Details_Head"
        Me.cell_Details_Head.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Details_Head.Text = "Details"
        Me.cell_Details_Head.Weight = 2.1535615440822515R
        '
        'cell_AmountDr_Head
        '
        Me.cell_AmountDr_Head.Multiline = True
        Me.cell_AmountDr_Head.Name = "cell_AmountDr_Head"
        Me.cell_AmountDr_Head.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_AmountDr_Head.StylePriority.UseTextAlignment = False
        Me.cell_AmountDr_Head.Text = "Amount"
        Me.cell_AmountDr_Head.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.cell_AmountDr_Head.Weight = 0.65259398936668911R
        '
        'cell_AmountCr_Head
        '
        Me.cell_AmountCr_Head.Multiline = True
        Me.cell_AmountCr_Head.Name = "cell_AmountCr_Head"
        Me.cell_AmountCr_Head.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_AmountCr_Head.StylePriority.UseTextAlignment = False
        Me.cell_AmountCr_Head.Text = "Amount"
        Me.cell_AmountCr_Head.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.cell_AmountCr_Head.Weight = 0.652594059213755R
        '
        'table_Footer
        '
        Me.table_Footer.LocationFloat = New DevExpress.Utils.PointFloat(51.04192!, 0!)
        Me.table_Footer.Name = "table_Footer"
        Me.table_Footer.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.row_Footer})
        Me.table_Footer.SizeF = New System.Drawing.SizeF(670.0!, 25.0!)
        '
        'row_Footer
        '
        Me.row_Footer.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.cell_Balance_Head, Me.cell_Total, Me.cell_Total_Dummy})
        Me.row_Footer.Name = "row_Footer"
        Me.row_Footer.Weight = 1.0R
        '
        'cell_Balance_Head
        '
        Me.cell_Balance_Head.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cell_Balance_Head.Multiline = True
        Me.cell_Balance_Head.Name = "cell_Balance_Head"
        Me.cell_Balance_Head.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Balance_Head.StylePriority.UseFont = False
        Me.cell_Balance_Head.StylePriority.UseTextAlignment = False
        Me.cell_Balance_Head.Text = "Balance"
        Me.cell_Balance_Head.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.cell_Balance_Head.Weight = 4.7000025558471688R
        '
        'cell_Total
        '
        Me.cell_Total.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
        Me.cell_Total.Multiline = True
        Me.cell_Total.Name = "cell_Total"
        Me.cell_Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Total.StylePriority.UseTextAlignment = False
        Me.cell_Total.Text = "cell_Total"
        Me.cell_Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.cell_Total.Weight = 0.99999935150146513R
        '
        'cell_Total_Dummy
        '
        Me.cell_Total_Dummy.Multiline = True
        Me.cell_Total_Dummy.Name = "cell_Total_Dummy"
        Me.cell_Total_Dummy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cell_Total_Dummy.StylePriority.UseTextAlignment = False
        Me.cell_Total_Dummy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.cell_Total_Dummy.Weight = 0.999998092651367R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.text_ThankYou, Me.table_Footer})
        Me.ReportFooter.HeightF = 149.5417!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'text_ThankYou
        '
        Me.text_ThankYou.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 75.79168!)
        Me.text_ThankYou.Multiline = True
        Me.text_ThankYou.Name = "text_ThankYou"
        Me.text_ThankYou.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.text_ThankYou.SizeF = New System.Drawing.SizeF(164.5833!, 73.74998!)
        Me.text_ThankYou.Text = "Thanking  You." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yours  sincerely," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[Sender.Name]"
        '
        'ReportDataSource
        '
        Me.ReportDataSource.DataSource = GetType(Devil7.Automation.OMS.Utils.BillPrinter.data_FeesReminder)
        Me.ReportDataSource.Name = "ReportDataSource"
        '
        'report_FeesReminder_Mail
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ReportDataSource})
        Me.DataSource = Me.ReportDataSource
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(40, 40, 20, 100)
        Me.Version = "18.2"
        CType(Me.table_Content, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text_Body, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents table_Header As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents row_Header As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents cell_Serial_Head As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_Date_Head As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_Details_Head As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_AmountDr_Head As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_AmountCr_Head As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table_Content As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents row_Content As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents cell_Serial As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_Date As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_AmountDr As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_AmountCr As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table_Footer As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents row_Footer As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents cell_Balance_Head As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_Total As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents cell_Total_Dummy As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents text_ThankYou As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents text_Body As DevExpress.XtraReports.UI.XRRichText
End Class
