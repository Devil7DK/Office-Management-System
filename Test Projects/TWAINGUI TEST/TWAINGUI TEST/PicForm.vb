
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports GdiPlusLib
Imports TwainLib
Namespace TwainGui

	Public Class PicForm
		Inherits System.Windows.Forms.Form
		Private components As System.ComponentModel.Container = Nothing
		Private menuItemClose As System.Windows.Forms.MenuItem
		Private menuItemInfo As System.Windows.Forms.MenuItem
		Private menuMainFilePic As System.Windows.Forms.MenuItem
		Private menuItemSaveAs As System.Windows.Forms.MenuItem
		Private picformMenu As System.Windows.Forms.MainMenu
		Private menuItemSepPic As System.Windows.Forms.MenuItem

		Public Sub New(dibhandp As IntPtr)
			InitializeComponent()

			SetStyle(ControlStyles.DoubleBuffer, False)
			SetStyle(ControlStyles.AllPaintingInWmPaint, True)
			SetStyle(ControlStyles.Opaque, True)
			SetStyle(ControlStyles.ResizeRedraw, True)
			SetStyle(ControlStyles.UserPaint, True)

			bmprect = New Rectangle(0, 0, 0, 0)
			dibhand = dibhandp
            bmpptr = GlobalCode.GlobalLock(dibhand)
			pixptr = GetPixelInfo(bmpptr)

			Me.AutoScrollMinSize = New System.Drawing.Size(bmprect.Width, bmprect.Height)
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing Then
				If dibhand <> IntPtr.Zero Then
                    GlobalCode.GlobalFree(dibhand)
					dibhand = IntPtr.Zero
				End If

				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If

			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.menuItemSepPic = New System.Windows.Forms.MenuItem()
			Me.menuItemSaveAs = New System.Windows.Forms.MenuItem()
			Me.menuItemInfo = New System.Windows.Forms.MenuItem()
			Me.menuItemClose = New System.Windows.Forms.MenuItem()
			Me.picformMenu = New System.Windows.Forms.MainMenu()
			Me.menuMainFilePic = New System.Windows.Forms.MenuItem()
			' 
			' menuItemSepPic
			' 
			Me.menuItemSepPic.Index = 3
			Me.menuItemSepPic.MergeOrder = 4
			Me.menuItemSepPic.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.menuItemSepPic.Text = "-"
			' 
			' menuItemSaveAs
			' 
			Me.menuItemSaveAs.Index = 1
			Me.menuItemSaveAs.MergeOrder = 2
			Me.menuItemSaveAs.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.menuItemSaveAs.Text = "&Save As..."
            AddHandler Me.menuItemSaveAs.Click, New System.EventHandler(AddressOf Me.menuItemSaveAs_Click)
			' 
			' menuItemInfo
			' 
			Me.menuItemInfo.Index = 0
			Me.menuItemInfo.MergeOrder = 1
			Me.menuItemInfo.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.menuItemInfo.Text = "&Info..."
            AddHandler Me.menuItemInfo.Click, New System.EventHandler(AddressOf Me.menuItemInfo_Click)
			' 
			' menuItemClose
			' 
			Me.menuItemClose.Index = 2
			Me.menuItemClose.MergeOrder = 3
			Me.menuItemClose.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.menuItemClose.Text = "&Close"
            AddHandler Me.menuItemClose.Click, New System.EventHandler(AddressOf Me.menuItemClose_Click)
			' 
			' picformMenu
			' 
			Me.picformMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuMainFilePic})
			' 
			' menuMainFilePic
			' 
			Me.menuMainFilePic.Index = 0
			Me.menuMainFilePic.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemInfo, Me.menuItemSaveAs, Me.menuItemClose, Me.menuItemSepPic})
			Me.menuMainFilePic.MergeType = System.Windows.Forms.MenuMerge.MergeItems
			Me.menuMainFilePic.Text = "&File"
			' 
			' PicForm
			' 
			Me.AutoScale = False
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.AutoScroll = True
			Me.AutoScrollMinSize = New System.Drawing.Size(256, 256)
			Me.BackColor = System.Drawing.Color.Black
			Me.ClientSize = New System.Drawing.Size(464, 221)
			Me.Menu = Me.picformMenu
			Me.MinimumSize = New System.Drawing.Size(80, 80)
			Me.Name = "PicForm"
			Me.Opacity = 0
			Me.ShowInTaskbar = False
			Me.Text = "PicForm"

		End Sub
		#End Region

		Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
			Dim cltrect As Rectangle = ClientRectangle
			Dim clprect As Rectangle = e.ClipRectangle
			Dim scrol As Point = AutoScrollPosition

			Dim realrect As Rectangle = clprect
			realrect.X -= scrol.X
			realrect.Y -= scrol.Y

			Dim brbg As New SolidBrush(Color.Black)
			If realrect.Right > bmprect.Width Then
				Dim bgri As Rectangle = clprect
				Dim ovri As Integer = bmprect.Width - realrect.X
				If ovri > 0 Then
					bgri.X += ovri
					bgri.Width -= ovri
				End If
				e.Graphics.FillRectangle(brbg, bgri)
			End If

			If realrect.Bottom > bmprect.Height Then
				Dim bgbo As Rectangle = clprect
				Dim ovbo As Integer = bmprect.Height - realrect.Y
				If ovbo > 0 Then
					bgbo.Y += ovbo
					bgbo.Height -= ovbo
				End If
				e.Graphics.FillRectangle(brbg, bgbo)
			End If

			realrect.Intersect(bmprect)
			If Not realrect.IsEmpty Then
				Dim bot As Integer = bmprect.Height - realrect.Bottom
				Dim hdc As IntPtr = e.Graphics.GetHdc()
                GlobalCode.SetDIBitsToDevice(hdc, clprect.X, clprect.Y, realrect.Width, realrect.Height, realrect.X, _
     bot, 0, bmprect.Height, pixptr, bmpptr, 0)
				e.Graphics.ReleaseHdc(hdc)
			End If
		End Sub

		Protected Overrides Sub OnPaintBackground(e As System.Windows.Forms.PaintEventArgs)
		End Sub

		Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
			Me.Menu.MenuItems.Clear()
			MyBase.OnClosing(e)
		End Sub



		Private Sub menuItemClose_Click(sender As Object, e As System.EventArgs)
			Close()
		End Sub

		Private Sub menuItemInfo_Click(sender As Object, e As System.EventArgs)
			Dim iform As New InfoForm(bmi)
			iform.ShowDialog(Me)
		End Sub

		Private Sub menuItemSaveAs_Click(sender As Object, e As System.EventArgs)
			Gdip.SaveDIBAs(Me.Text, bmpptr, pixptr)
		End Sub


		Protected Function GetPixelInfo(bmpptr As IntPtr) As IntPtr
			bmi = New BITMAPINFOHEADER()
			Marshal.PtrToStructure(bmpptr, bmi)

			bmprect.X = InlineAssignHelper(bmprect.Y, 0)
			bmprect.Width = bmi.biWidth
			bmprect.Height = bmi.biHeight

			If bmi.biSizeImage = 0 Then
				bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) And Not 31) >> 3) * bmi.biHeight
			End If

			Dim p As Integer = bmi.biClrUsed
			If (p = 0) AndAlso (bmi.biBitCount <= 8) Then
				p = 1 << bmi.biBitCount
			End If
			p = (p * 4) + bmi.biSize + CInt(bmpptr)
            Return CType(p, IntPtr)
		End Function

		Private bmi As BITMAPINFOHEADER
		Private bmprect As Rectangle
		Private dibhand As IntPtr
		Private bmpptr As IntPtr
		Private pixptr As IntPtr

		
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function



	End Class
	' class PicForm

	<StructLayout(LayoutKind.Sequential, Pack := 2)> _
	Friend Class BITMAPINFOHEADER
		Public biSize As Integer
		Public biWidth As Integer
		Public biHeight As Integer
		Public biPlanes As Short
		Public biBitCount As Short
		Public biCompression As Integer
		Public biSizeImage As Integer
		Public biXPelsPerMeter As Integer
		Public biYPelsPerMeter As Integer
		Public biClrUsed As Integer
		Public biClrImportant As Integer
	End Class

End Namespace
' namespace TwainGui

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
