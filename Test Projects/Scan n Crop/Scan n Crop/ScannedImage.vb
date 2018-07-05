Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Math
Public Class ScannedImage
    Inherits PictureBox
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Dim Tooltip As New ImageToolTip
    Public selected As Boolean = False
    Private mdown As Boolean = False
    Private moffset As Point = Nothing
    Dim isFirst As Boolean = True
    Private nubs As New List(Of PictureBox)
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btn_Remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_RotateClockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_RotateCounterClockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_EditImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_BringToFront As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_SentToBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_AddToScanned As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Crop As System.Windows.Forms.ToolStripMenuItem
    Dim CropMode As Boolean = False
    Private Sub wDOMElement_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If isFirst Then
            configureFirstSelection()
            isFirst = False
        Else
            selectME()
        End If
    End Sub

    Private Sub wDOMElement_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        unselectME()
    End Sub

    Protected Overrides Sub OnLeave(ByVal e As EventArgs)
        MyBase.OnLeave(e)
        unselectME()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If Me.Enabled AndAlso Not Me.Focused Then
            Me.Focus()
        End If
        MyBase.OnMouseDown(e)
    End Sub
    Private Sub selectME()
        selected = True
        updateBorder()
        For Each v As PictureBox In nubs
            v.Show()
        Next
    End Sub

    Sub unselectME()
        selected = False
        updateBorder()
        For Each v As PictureBox In nubs
            v.Hide()
        Next
        Me.Refresh()
    End Sub

    Private Sub updateBorder()
        Using gfx As Graphics = Graphics.FromHwnd(Me.Handle)
            If selected Then
                Dim blackPen As New Pen(Brushes.Black)
                blackPen.DashStyle = DashStyle.Dot
                gfx.DrawRectangle(blackPen, 4, 4, Width - 9, Height - 9)
            End If
        End Using
    End Sub

    Private Sub configureFirstSelection()
        Using gfx As Graphics = Graphics.FromHwnd(Me.Handle)
            Dim blackPen As New Pen(Brushes.Black)
            blackPen.DashStyle = DashStyle.Dot
            gfx.DrawRectangle(blackPen, 4, 4, Width - 9, Height - 9)
            Dim b As New Bitmap(9, 9)
            Dim g As Graphics = Graphics.FromImage(b)
            g.DrawEllipse(New Pen(Brushes.DeepSkyBlue, 1.5), 1, 1, 7, 7)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.FillEllipse(New SolidBrush(Color.White), 1, 1, 7, 7)
            g.Dispose()
            'Top Handle
            placeHandle(b, CInt(Width / 2 - 3), CInt(0), New Point(0, 1), New Point(0, -1), Cursors.SizeNS, AnchorStyles.Top)
            'Bottom Handle
            placeHandle(b, CInt(Width / 2 - 3), CInt(Height - 7), New Point(0, 0), New Point(0, 1), Cursors.SizeNS, AnchorStyles.Bottom)
            'Left Handle
            placeHandle(b, CInt(0), CInt(Height / 2 - 3), New Point(1, 0), New Point(-1, 0), Cursors.SizeWE, AnchorStyles.Left)
            'Right Handle
            placeHandle(b, CInt(Width - 7), CInt(Height / 2 - 3), New Point(0, 0), New Point(1, 0), Cursors.SizeWE, AnchorStyles.Right)
            'Top Left Handle
            placeHandle(b, CInt(0), CInt(0), New Point(1, 1), New Point(-1, -1), Cursors.SizeNWSE, AnchorStyles.Top + AnchorStyles.Left)
            'Top Right Handle
            placeHandle(b, CInt(Width - 7), CInt(0), New Point(0, 1), New Point(1, -1), Cursors.SizeNESW, AnchorStyles.Top + AnchorStyles.Right)
            'Bottom Left Handle
            placeHandle(b, CInt(0), CInt(Height - 7), New Point(1, 0), New Point(-1, 1), Cursors.SizeNESW, AnchorStyles.Bottom + AnchorStyles.Left)
            'Bottom Right Handle
            placeHandle(b, CInt(Width - 7), CInt(Height - 7), New Point(0, 0), New Point(1, 1), Cursors.SizeNWSE, AnchorStyles.Bottom + AnchorStyles.Right)
        End Using
    End Sub

    Private Sub placeHandle(ByVal pic As Image, ByVal x As Integer, ByVal y As Integer, ByVal mov As Point, ByVal siz As Point, ByVal cur As Cursor, ByVal ancr As AnchorStyles)
        Dim nPB As New PictureBox
        nPB.SizeMode = PictureBoxSizeMode.AutoSize
        nPB.Image = pic
        nPB.Location = New Point(x, y)
        nPB.Cursor = cur
        nPB.Visible = False
        nPB.Anchor = ancr
        nPB.Parent = Me
        Dim md As Boolean = False
        Dim lpos As Point = Nothing
        Dim moveClock As New Timer
        moveClock.Interval = 1
        moveClock.Enabled = False
        AddHandler nPB.MouseDown, Sub()
                                      md = True
                                      lpos = MousePosition
                                      moveClock.Start()
                                  End Sub

        AddHandler moveClock.Tick, Sub()
                                       If md Then
                                           Dim nX As Integer = (MousePosition.X - lpos.X) * mov.X
                                           Dim nY As Integer = (MousePosition.Y - lpos.Y) * mov.Y
                                           Dim nWidth As Integer = (MousePosition.X - lpos.X) * siz.X
                                           Dim nHeight As Integer = (MousePosition.Y - lpos.Y) * siz.Y
                                           Left += nX
                                           Top += nY
                                           Width += nWidth
                                           Height += nHeight
                                           lpos = MousePosition
                                           updateBorder()
                                       End If
                                   End Sub
        AddHandler nPB.MouseUp, Sub()
                                    md = False
                                    ResizeAndSetLocation(Me, Me.Width, Me.Height)
                                    moveClock.Stop()
                                End Sub
        nubs.Add(nPB)
    End Sub


    Private Sub wDesignEditor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        mdown = False
    End Sub
    Shadows Property Image As System.Drawing.Image
        Get
            Return (MyBase.Image)
        End Get
        Set(ByVal value As System.Drawing.Image)
            MyBase.Image = value
            SetSize()
            ResizeAndSetLocation(Me, Me.Width, Me.Height)
        End Set
    End Property

    Private Sub ScannedImage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If TypeOf Me.Parent Is AutoSizePanel Then
            If mdown Then Return
            mdown = True
            moffset = MousePosition - Location
            selectME()
        Else
            Dim objDragDropEff As DragDropEffects = DoDragDrop(Me, DragDropEffects.Copy)
        End If
    End Sub

    Private Sub ScannedImage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        Timer1.Stop()
        Timer2.Stop()
        Sec = 0
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub ScannedImage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If mdown Then
            Location = MousePosition - moffset
        Else
            Sec = 0
            Tooltip.Location = MousePosition
        End If
    End Sub
    Private Sub ScannedImage_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        SetSize()
    End Sub
    Sub SetSize()
        If Not TypeOf Me.Parent Is AutoSizePanel Then
            If Me.Image IsNot Nothing Then
                If Me.Image.Width < Me.Image.Height Then
                    Me.Size = New Size(99, 140)
                Else
                    Me.Size = New Size(140, 99)
                End If
            End If
        End If
    End Sub
    Sub ResizeAndSetLocation(ByVal Control As ScannedImage, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32)
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = Control.Image.Width / Control.Image.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If
        Control.Width = NewWidth
        Control.Height = NewHeight
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_RotateClockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_RotateCounterClockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_EditImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_BringToFront = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_SentToBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_AddToScanned = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Crop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_RotateClockwise, Me.btn_RotateCounterClockwise, Me.ToolStripSeparator1, Me.btn_Crop, Me.btn_EditImage, Me.ToolStripSeparator2, Me.btn_BringToFront, Me.btn_SentToBack, Me.ToolStripSeparator3, Me.btn_Remove, Me.ToolStripSeparator4, Me.btn_AddToScanned})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(199, 204)
        '
        'btn_RotateClockwise
        '
        Me.btn_RotateClockwise.Name = "btn_RotateClockwise"
        Me.btn_RotateClockwise.Size = New System.Drawing.Size(198, 22)
        Me.btn_RotateClockwise.Text = "Rotate Clockwise"
        '
        'btn_RotateCounterClockwise
        '
        Me.btn_RotateCounterClockwise.Name = "btn_RotateCounterClockwise"
        Me.btn_RotateCounterClockwise.Size = New System.Drawing.Size(198, 22)
        Me.btn_RotateCounterClockwise.Text = "Rotate Counter Clockwise"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'btn_EditImage
        '
        Me.btn_EditImage.Name = "btn_EditImage"
        Me.btn_EditImage.Size = New System.Drawing.Size(198, 22)
        Me.btn_EditImage.Text = "Edit Image"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'btn_BringToFront
        '
        Me.btn_BringToFront.Name = "btn_BringToFront"
        Me.btn_BringToFront.Size = New System.Drawing.Size(198, 22)
        Me.btn_BringToFront.Text = "Bring To Front"
        '
        'btn_SentToBack
        '
        Me.btn_SentToBack.Name = "btn_SentToBack"
        Me.btn_SentToBack.Size = New System.Drawing.Size(198, 22)
        Me.btn_SentToBack.Text = "Sent To Back"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(195, 6)
        '
        'btn_Remove
        '
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(198, 22)
        Me.btn_Remove.Text = "Remove"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(195, 6)
        '
        'btn_AddToScanned
        '
        Me.btn_AddToScanned.Name = "btn_AddToScanned"
        Me.btn_AddToScanned.Size = New System.Drawing.Size(198, 22)
        Me.btn_AddToScanned.Text = "Add to Scanned Images"
        '
        'btn_Crop
        '
        Me.btn_Crop.Name = "btn_Crop"
        Me.btn_Crop.Size = New System.Drawing.Size(198, 22)
        Me.btn_Crop.Text = "Crop"
        '
        'ScannedImage
        '
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Dim Sec As Integer = 0
    Sub New()
        InitializeComponent()
        Me.AllowDrop = True
    End Sub
    Sub New(ByVal Image As Image)
        InitializeComponent()
        Me.AllowDrop = True
        Me.Image = Image
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Sec < 2 Then
            Sec += 1
        End If
        If Sec = 2 Then
            Try
                Tooltip.PicImage = Me.Image
                Tooltip.Show()
                Sec = 0
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Dim rect As New Rectangle(Me.PointToScreen(Point.Empty), Me.Size)
            If rect.Contains(MousePosition) = False Then
                Tooltip.Hide()
                Timer1.Stop()
                Timer2.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        
    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As System.EventArgs) Handles btn_Remove.Click
        Me.Parent.Controls.Remove(Me)
        Me.Dispose()
    End Sub
    Function RotateImage(ByVal SourceImage As Image, ByVal Angle As Integer) As Image
        Dim bm_in As New Bitmap(SourceImage)
        Dim wid As Single = bm_in.Width

        Dim hgt As Single = bm_in.Height
        Dim corners As Point() = {New Point(0, 0), New Point(wid, 0), New Point(0, hgt), New Point(wid, hgt)}
        Dim cx As Single = wid / 2
        Dim cy As Single = hgt / 2
        Dim i As Long
        For i = 0 To 3
            corners(i).X -= cx
            corners(i).Y -= cy
        Next i
        Dim theta As Single = Single.Parse(Angle) * PI / 180.0

        Dim sin_theta As Single = Sin(theta)

        Dim cos_theta As Single = Cos(theta)

        Dim X As Single

        Dim Y As Single

        For i = 0 To 3

            X = corners(i).X

            Y = corners(i).Y

            corners(i).X = X * cos_theta + Y * sin_theta

            corners(i).Y = -X * sin_theta + Y * cos_theta

        Next i

        Dim xmin As Single = corners(0).X

        Dim ymin As Single = corners(0).Y

        For i = 1 To 3

            If xmin > corners(i).X Then xmin = corners(i).X

            If ymin > corners(i).Y Then ymin = corners(i).Y

        Next i

        For i = 0 To 3

            corners(i).X -= xmin

            corners(i).Y -= ymin

        Next i

        Dim bm_out As New Bitmap(CInt(-2 * xmin), CInt(-2 * ymin))

        Dim gr_out As Graphics = Graphics.FromImage(bm_out)

        ReDim Preserve corners(2)

        gr_out.DrawImage(bm_in, corners)

        Return bm_out
    End Function
    Private Sub btn_RotateClockwise_Click(sender As Object, e As System.EventArgs) Handles btn_RotateClockwise.Click
        Dim h As Integer = Me.Height
        Dim w As Integer = Me.Width
        Me.Image.RotateFlip(RotateFlipType.Rotate270FlipXY)
        unselectME()
        Me.Width = w
        Me.Height = h
        selectME()
    End Sub

    Private Sub btn_RotateCounterClockwise_Click(sender As Object, e As System.EventArgs) Handles btn_RotateCounterClockwise.Click
        Dim h As Integer = Me.Height
        Dim w As Integer = Me.Width
        Me.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
        unselectME()
        Me.Width = w
        Me.Height = h
        selectME()
    End Sub

    Private Sub btn_EditImage_Click(sender As Object, e As System.EventArgs) Handles btn_EditImage.Click
        Dim d As New EditImage(Me.Image)
        If d.ShowDialog = DialogResult.OK Then
            Me.Image = d.EditedImage
        End If
    End Sub

    Private Sub btn_BringToFront_Click(sender As Object, e As System.EventArgs) Handles btn_BringToFront.Click
        Me.BringToFront()
    End Sub

    Private Sub btn_SentToBack_Click(sender As Object, e As System.EventArgs) Handles btn_SentToBack.Click
        Me.SendToBack()
    End Sub

    Private Sub btn_AddToScanned_Click(sender As Object, e As System.EventArgs) Handles btn_AddToScanned.Click
        AppMainForm.AddScannedImage(Me.Image.Clone, False)
    End Sub

    Private Sub btn_Crop_Click(sender As Object, e As System.EventArgs) Handles btn_Crop.Click
        Dim d As New frm_Crop(Me.Image.Clone)
        If d.ShowDialog = DialogResult.OK Then
            Me.Image = d.CroppedImage
        End If
    End Sub
End Class
