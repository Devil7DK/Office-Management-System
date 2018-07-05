Public Class frm_Crop
    Dim CropRect As Rectangle
    Dim StartPoint As Point
    Dim isLeft As Boolean = False
    Dim img As Image = Nothing
    Sub Crop2()
        Dim RW As Double = (PB_Image.Image.Width - PB_Image.Width) / PB_Image.Width  ' Ratio change of width
        Dim RH As Double = (PB_Image.Image.Height - PB_Image.Height) / PB_Image.Height  ' Ratio change of height
        Dim Ctrl As New Rectangle(CropRect.X, CropRect.Y, CropRect.Width, CropRect.Height)
        Ctrl.Width += CInt(Ctrl.Width * RW)
        Ctrl.Height += CInt(Ctrl.Height * RH)
        Ctrl.X += CInt(Ctrl.X * RW)
        Ctrl.Y += CInt(Ctrl.Y * RH)
        Dim ci As New Bitmap(Ctrl.Width, Ctrl.Height)
        Dim g1 As Graphics = Graphics.FromImage(ci)
        g1.DrawImage(img, New Rectangle(0, 0, Ctrl.Width, Ctrl.Height), Ctrl, GraphicsUnit.Pixel)
        g1.Dispose()
        PictureBox1.Image = ci
    End Sub
    Dim isCoding As Boolean = False
    Sub SetValues(ByVal CrRect As Rectangle)
        Dim RW As Double = (PB_Image.Image.Width - PB_Image.Width) / PB_Image.Width  ' Ratio change of width
        Dim RH As Double = (PB_Image.Image.Height - PB_Image.Height) / PB_Image.Height  ' Ratio change of height
        Dim Ctrl As New Rectangle(CrRect.X, CrRect.Y, CrRect.Width, CrRect.Height)
        Ctrl.Width += CInt(Ctrl.Width * RW)
        Ctrl.Height += CInt(Ctrl.Height * RH)
        Ctrl.X += CInt(Ctrl.X * RW)
        Ctrl.Y += CInt(Ctrl.Y * RH)
        isCoding = True
        txt_Left.Value = Ctrl.X
        txt_Top.Value = Ctrl.Y
        txt_Right.Value = PB_Image.Image.Width - Ctrl.X - Ctrl.Width
        txt_Bottom.Value = PB_Image.Image.Height - Ctrl.Y - Ctrl.Height
        isCoding = False
        lbl_cropped.Text = New Size(PB_Image.Image.Width - txt_Right.Value - txt_Left.Value, PB_Image.Image.Height - txt_Top.Value - txt_Bottom.Value).ToString
    End Sub
    Sub Crop(Optional CrRect As Rectangle = Nothing)
        lbl_original.Text = img.Size.ToString
        If CrRect <> Nothing Then
            SetValues(CrRect)
        End If
        Dim rect As New Rectangle(txt_Left.Value, txt_Top.Value, PB_Image.Image.Width - txt_Right.Value - txt_Left.Value, PB_Image.Image.Height - txt_Top.Value - txt_Bottom.Value)
        Dim pbi As Image = img.Clone
        Dim g As Graphics = Graphics.FromImage(pbi)
        g.DrawRectangle(New Pen(Brushes.Black, 1) With {.DashStyle = Drawing2D.DashStyle.Dash}, rect)
        g.Dispose()
        PB_Image.Image = pbi
        Dim ci As New Bitmap(rect.Width, rect.Height)
        Dim g1 As Graphics = Graphics.FromImage(ci)
        g1.DrawImage(img, New Rectangle(0, 0, rect.Width, rect.Height), rect, GraphicsUnit.Pixel)
        g.Dispose()
        PictureBox1.Image = ci
        CroppedImage = ci
        PB_Image.Refresh()
    End Sub
    Property CroppedImage As Image
    Sub ResizeAndSetLocation(ByVal Control As PictureBox, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32)
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
        Control.Location = New Point(NewX, NewY)
        Control.Width = NewWidth
        Control.Height = NewHeight
    End Sub
    Sub New(ByVal Image As Image)
        InitializeComponent()
        Me.PB_Image.Image = Image
        Me.PB_Image.Size = Image.Size
        img = Image
        CroppedImage = Image
    End Sub
    Private Sub frm_Crop_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ResizeAndSetLocation(Me.PB_Image, Panel_ImageContainer.Width, Panel_ImageContainer.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_Crop_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Try
            ResizeAndSetLocation(Me.PB_Image, Panel_ImageContainer.Width, Panel_ImageContainer.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_Crop_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        Try
            ResizeAndSetLocation(Me.PB_Image, Panel_ImageContainer.Width, Panel_ImageContainer.Height)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txt_Crop_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_Left.ValueChanged, txt_Top.ValueChanged, txt_Right.ValueChanged, txt_Bottom.ValueChanged
        If isCoding = False Then
            Crop()
        End If
    End Sub

    Private Sub PB_Image_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PB_Image.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isLeft = True
            StartPoint = e.Location
        Else
            isLeft = False
        End If
    End Sub
    Function GetRectangle(ByVal Point1 As Point, ByVal Point2 As Point) As Rectangle
        If Point1.X = Point2.X Then
            If Point1.Y = Point2.Y Then
                Return New Rectangle(Point1, New Size(1, 1))
            ElseIf Point1.Y < Point2.Y Then
                Return New Rectangle(Point1, New Size(1, Point2.Y - Point1.Y))
            ElseIf Point1.Y > Point2.Y Then
                Return New Rectangle(Point2, New Size(1, Point1.Y - Point2.Y))
            End If
        ElseIf Point1.X < Point2.X Then
            If Point1.Y = Point2.Y Then
                Return New Rectangle(Point1, New Size(Point2.X - Point1.X, 1))
            ElseIf Point1.Y < Point2.Y Then
                Return New Rectangle(Point1, New Size(Point2.X - Point1.X, Point2.Y - Point1.Y))
            ElseIf Point1.Y > Point2.Y Then
                Return New Rectangle(New Point(Point1.X, Point2.Y), New Size(Point2.X - Point1.X, Point1.Y - Point2.Y))
            End If
        ElseIf Point1.X > Point2.X Then
            If Point1.Y = Point2.Y Then
                Return New Rectangle(Point2, New Size(Point1.X - Point2.X, 1))
            ElseIf Point1.Y < Point2.Y Then
                Return New Rectangle(New Point(Point2.X, Point1.Y), New Size(Point1.X - Point2.X, Point2.Y - Point1.Y))
            ElseIf Point1.Y > Point2.Y Then
                Return New Rectangle(Point2, New Size(Point1.X - Point2.X, Point1.Y - Point2.Y))
            End If
        End If
    End Function
    Private Sub PB_Image_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PB_Image.MouseMove
        If isLeft Then
            PB_Image.Refresh()
            CropRect = GetRectangle(StartPoint, e.Location) ' New Rectangle(StartPoint, New Size(e.Location.X - StartPoint.X, e.Location.Y - StartPoint.Y))
            PB_Image.CreateGraphics.DrawRectangle(New Pen(Brushes.Black, 1) With {.DashStyle = Drawing2D.DashStyle.Dash}, CropRect)
            Try
                SetValues(CropRect)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub PB_Image_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PB_Image.MouseUp
        If isLeft = True Then
            Try
                Crop(CropRect)
            Catch ex As Exception

            End Try
        End If
        isLeft = False
    End Sub

    
    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_OK_Click(sender As System.Object, e As System.EventArgs) Handles btn_OK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class