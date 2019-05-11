<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BirthdayBabys
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition4 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition7 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition8 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition9 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition10 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BirthdayBabys))
        Me.colPhoto = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPAN = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMobile = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gc_BirthdayBabys = New DevExpress.XtraGrid.GridControl()
        Me.tv_BirthdayBabys = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.pic_Birthday_Con = New DevExpress.XtraEditors.PictureEdit()
        Me.lbl_Message = New DevExpress.XtraEditors.LabelControl()
        Me.pic_Birthday_Cake = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.gc_BirthdayBabys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tv_BirthdayBabys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Birthday_Con.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Birthday_Cake.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colPhoto
        '
        Me.colPhoto.FieldName = "Photo"
        Me.colPhoto.Name = "colPhoto"
        Me.colPhoto.Visible = True
        Me.colPhoto.VisibleIndex = 1
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 3
        '
        'colPAN
        '
        Me.colPAN.FieldName = "PAN"
        Me.colPAN.Name = "colPAN"
        Me.colPAN.Visible = True
        Me.colPAN.VisibleIndex = 2
        '
        'colMobile
        '
        Me.colMobile.FieldName = "Mobile"
        Me.colMobile.Name = "colMobile"
        Me.colMobile.Visible = True
        Me.colMobile.VisibleIndex = 4
        '
        'colPhone
        '
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 5
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 6
        '
        'gc_BirthdayBabys
        '
        Me.gc_BirthdayBabys.Location = New System.Drawing.Point(12, 56)
        Me.gc_BirthdayBabys.MainView = Me.tv_BirthdayBabys
        Me.gc_BirthdayBabys.Name = "gc_BirthdayBabys"
        Me.gc_BirthdayBabys.Size = New System.Drawing.Size(486, 200)
        Me.gc_BirthdayBabys.TabIndex = 0
        Me.gc_BirthdayBabys.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tv_BirthdayBabys})
        '
        'tv_BirthdayBabys
        '
        Me.tv_BirthdayBabys.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colPhoto, Me.colPAN, Me.colName, Me.colMobile, Me.colPhone, Me.colEmail})
        Me.tv_BirthdayBabys.GridControl = Me.gc_BirthdayBabys
        Me.tv_BirthdayBabys.Name = "tv_BirthdayBabys"
        Me.tv_BirthdayBabys.OptionsTiles.ItemSize = New System.Drawing.Size(300, 120)
        Me.tv_BirthdayBabys.OptionsTiles.RowCount = 0
        TableColumnDefinition3.Length.Value = 104.0R
        TableColumnDefinition4.Length.Value = 172.0R
        Me.tv_BirthdayBabys.TileColumns.Add(TableColumnDefinition3)
        Me.tv_BirthdayBabys.TileColumns.Add(TableColumnDefinition4)
        Me.tv_BirthdayBabys.TileRows.Add(TableRowDefinition6)
        Me.tv_BirthdayBabys.TileRows.Add(TableRowDefinition7)
        Me.tv_BirthdayBabys.TileRows.Add(TableRowDefinition8)
        Me.tv_BirthdayBabys.TileRows.Add(TableRowDefinition9)
        Me.tv_BirthdayBabys.TileRows.Add(TableRowDefinition10)
        TableSpan2.RowSpan = 5
        Me.tv_BirthdayBabys.TileSpans.Add(TableSpan2)
        TileViewItemElement7.Column = Me.colPhoto
        TileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement7.Text = "colPhoto"
        TileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement8.Appearance.Normal.Options.UseFont = True
        TileViewItemElement8.Column = Me.colName
        TileViewItemElement8.ColumnIndex = 1
        TileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement8.Text = "colName"
        TileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement8.TextLocation = New System.Drawing.Point(5, 0)
        TileViewItemElement9.Column = Me.colPAN
        TileViewItemElement9.ColumnIndex = 1
        TileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement9.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement9.RowIndex = 1
        TileViewItemElement9.Text = "colPAN"
        TileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement9.TextLocation = New System.Drawing.Point(5, 0)
        TileViewItemElement10.Column = Me.colMobile
        TileViewItemElement10.ColumnIndex = 1
        TileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement10.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement10.RowIndex = 2
        TileViewItemElement10.Text = "colMobile"
        TileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement10.TextLocation = New System.Drawing.Point(5, 0)
        TileViewItemElement11.Column = Me.colPhone
        TileViewItemElement11.ColumnIndex = 1
        TileViewItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement11.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement11.RowIndex = 3
        TileViewItemElement11.Text = "colPhone"
        TileViewItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement11.TextLocation = New System.Drawing.Point(5, 0)
        TileViewItemElement12.Column = Me.colEmail
        TileViewItemElement12.ColumnIndex = 1
        TileViewItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement12.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement12.RowIndex = 4
        TileViewItemElement12.Text = "colEmail"
        TileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement12.TextLocation = New System.Drawing.Point(5, 0)
        Me.tv_BirthdayBabys.TileTemplate.Add(TileViewItemElement7)
        Me.tv_BirthdayBabys.TileTemplate.Add(TileViewItemElement8)
        Me.tv_BirthdayBabys.TileTemplate.Add(TileViewItemElement9)
        Me.tv_BirthdayBabys.TileTemplate.Add(TileViewItemElement10)
        Me.tv_BirthdayBabys.TileTemplate.Add(TileViewItemElement11)
        Me.tv_BirthdayBabys.TileTemplate.Add(TileViewItemElement12)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'pic_Birthday_Con
        '
        Me.pic_Birthday_Con.EditValue = CType(resources.GetObject("pic_Birthday_Con.EditValue"), Object)
        Me.pic_Birthday_Con.Location = New System.Drawing.Point(12, 0)
        Me.pic_Birthday_Con.Name = "pic_Birthday_Con"
        Me.pic_Birthday_Con.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.[False]
        Me.pic_Birthday_Con.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pic_Birthday_Con.Properties.Appearance.Options.UseBackColor = True
        Me.pic_Birthday_Con.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pic_Birthday_Con.Properties.ReadOnly = True
        Me.pic_Birthday_Con.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pic_Birthday_Con.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pic_Birthday_Con.Size = New System.Drawing.Size(57, 50)
        Me.pic_Birthday_Con.TabIndex = 1
        '
        'lbl_Message
        '
        Me.lbl_Message.Location = New System.Drawing.Point(75, 32)
        Me.lbl_Message.Name = "lbl_Message"
        Me.lbl_Message.Size = New System.Drawing.Size(360, 13)
        Me.lbl_Message.TabIndex = 2
        Me.lbl_Message.Text = "The following clients have their birthdays today! Don't forget to wish them!"
        '
        'pic_Birthday_Cake
        '
        Me.pic_Birthday_Cake.EditValue = CType(resources.GetObject("pic_Birthday_Cake.EditValue"), Object)
        Me.pic_Birthday_Cake.Location = New System.Drawing.Point(441, 0)
        Me.pic_Birthday_Cake.Name = "pic_Birthday_Cake"
        Me.pic_Birthday_Cake.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.[False]
        Me.pic_Birthday_Cake.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pic_Birthday_Cake.Properties.Appearance.Options.UseBackColor = True
        Me.pic_Birthday_Cake.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pic_Birthday_Cake.Properties.ReadOnly = True
        Me.pic_Birthday_Cake.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pic_Birthday_Cake.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pic_Birthday_Cake.Size = New System.Drawing.Size(57, 50)
        Me.pic_Birthday_Cake.TabIndex = 3
        '
        'frm_BirthDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 268)
        Me.Controls.Add(Me.pic_Birthday_Cake)
        Me.Controls.Add(Me.lbl_Message)
        Me.Controls.Add(Me.pic_Birthday_Con)
        Me.Controls.Add(Me.gc_BirthdayBabys)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_BirthDays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Birthday Babys"
        CType(Me.gc_BirthdayBabys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tv_BirthdayBabys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Birthday_Con.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Birthday_Cake.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gc_BirthdayBabys As DevExpress.XtraGrid.GridControl
    Friend WithEvents tv_BirthdayBabys As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPhoto As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPAN As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMobile As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents pic_Birthday_Con As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbl_Message As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pic_Birthday_Cake As DevExpress.XtraEditors.PictureEdit
End Class
