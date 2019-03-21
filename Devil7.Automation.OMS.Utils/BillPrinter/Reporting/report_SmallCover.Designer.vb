<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class report_SmallCover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_SmallCover))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.txt_To_Name = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.pic_Logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.txt_To_Address = New DevExpress.XtraReports.UI.XRRichText()
        CType(Me.txt_To_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_To_Address, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 20.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txt_To_Address, Me.txt_To_Name, Me.XrRichText1, Me.pic_Logo})
        Me.Detail.HeightF = 600.2424!
        Me.Detail.Name = "Detail"
        '
        'txt_To_Name
        '
        Me.txt_To_Name.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_To_Name.LocationFloat = New DevExpress.Utils.PointFloat(776.6375!, 276.3019!)
        Me.txt_To_Name.Name = "txt_To_Name"
        Me.txt_To_Name.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_To_Name.SerializableRtfString = resources.GetString("txt_To_Name.SerializableRtfString")
        Me.txt_To_Name.SizeF = New System.Drawing.SizeF(347.3625!, 32.82144!)
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(563.0001!, 500.2424!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(259.2262!, 100.0!)
        '
        'pic_Logo
        '
        Me.pic_Logo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Sender].[Logo]")})
        Me.pic_Logo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.pic_Logo.LocationFloat = New DevExpress.Utils.PointFloat(488.0001!, 500.2424!)
        Me.pic_Logo.Name = "pic_Logo"
        Me.pic_Logo.SizeF = New System.Drawing.SizeF(75.0!, 99.99997!)
        Me.pic_Logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(Devil7.Automation.OMS.Utils.BillPrinter.data_Cover)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'txt_To_Address
        '
        Me.txt_To_Address.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_To_Address.LocationFloat = New DevExpress.Utils.PointFloat(776.6375!, 309.1234!)
        Me.txt_To_Address.Name = "txt_To_Address"
        Me.txt_To_Address.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.txt_To_Address.SerializableRtfString = resources.GetString("txt_To_Address.SerializableRtfString")
        Me.txt_To_Address.SizeF = New System.Drawing.SizeF(347.3625!, 145.3958!)
        '
        'report_SmallCover
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1})
        Me.DataSource = Me.ObjectDataSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(18, 17, 20, 20)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "18.2"
        CType(Me.txt_To_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_To_Address, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents pic_Logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents txt_To_Name As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents txt_To_Address As DevExpress.XtraReports.UI.XRRichText
End Class
