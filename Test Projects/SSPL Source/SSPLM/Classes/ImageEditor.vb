Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms

Public Class ImageEditor
    'in this article we make a imaage editing tool with the help of Vb.net. In this image editing tool we include resizing image, cropping image,brightness in images,rotation and other various common
    'image editing functionalities.first we learn that how to implement these functionalities in image one by one than in last when all things will have been covered than we will make user control with these operations.
    'so first we need to learn that how to show an image in windows form? for this we can take a picturebox control, picturebox cpontrol able to load an image file format like bmp,gpeg,gif,tiff file also.
    ' so let start with our first step.
    '1. start a new windows application and add one splitcontainer,picturebox, menustrip,toolstrip on windows form.

    ' Arrange controls on the form like this.

    ' now we need to open image on the form so we use open filedialog class for selecting image file'
    ' so use openfiledialog on OpenToolStripMenuItem_Click event
    ' 
    Dim xpos As Integer
    Dim ypos As Integer
    Dim firstx As Integer
    Dim firsty As Integer
    Dim secx As Integer
    Dim secy As Integer
    Public bm As Bitmap
    Public graph As Graphics
    Dim paint1 As Boolean

    Dim pencolor As New Pen(Color.Black, 1)
    Dim drawellipse As Boolean
    Dim drawrectangle As Boolean
    Dim drawText As Boolean
    Dim drawImage As Boolean
    Dim spray As Boolean
    Dim spraystart As Boolean
    Dim brushcolor As New SolidBrush(Color.Black)
    'draw polygon / triangle
    Dim drawtriangle As Boolean
    Dim remhits As Integer = 0
    Dim firstclick As Point
    Dim secondclick As Point
    Dim thirdclick As Point
    'labelA properties
    Dim labelA As New Label
    'new image properties
    Dim newimage As Bitmap
    Dim newimagedraw As Boolean
    Dim padx As Integer
    Dim pady As Integer

    'remember image size 
    Dim imagex As Integer
    Dim imagey As Integer


    'draw clear ellipse
    Dim drawclearellipse As Boolean
    'draw clear rectangle
    Dim drawclearrectangle As Boolean
    'draw filled triangle
    Dim drawfilledtriangle As Boolean
    Dim remhits1 As Integer = 0
    Dim firstclick1 As Point
    Dim secondclick1 As Point
    Dim thirdclick1 As Point

    Public Img As Image
    Public defimg As Image
    Private OriginalImageSize As Size
    Private ModifiedImageSize As Size
    ' Declare Img as object of Image class. Image class is the member of System.Drawing namespace, it is abstrat base class that
    'provides functionality for raster images(bitmaps) and vector images(Metafile) descended classes.
    Public Sub LoadImage()
        'we set the picturebox size according to image, we can get image width and height with the help of Image.Width and Image.height properties.
        Dim imgWidth As Integer = Img.Width
        Dim imghieght As Integer = Img.Height
        PictureBox1.Width = imgWidth
        PictureBox1.Height = imghieght
        PictureBox1.Image = Img
        PictureBoxLocation()
        OriginalImageSize = New Size(imgWidth, imghieght)

        SetResizeInfo()
    End Sub
    'Suppose that your picturebox or image size is smaller than background panel than image will show in the corner of the panel in upperside and this is not professional look of tool so we set the picturebox or image location on panel.
    'after doing this image will always show in center of panel
    Public Sub PictureBoxLocation()
        Dim _x As Integer = 0
        Dim _y As Integer = 0
        If Pic_Panel.Width > PictureBox1.Width Then
            _x = (Pic_Panel.Width - PictureBox1.Width) \ 2
        End If
        If Pic_Panel.Height > PictureBox1.Height Then
            _y = (Pic_Panel.Height - PictureBox1.Height) \ 2
        End If
        PictureBox1.Location = New Point(_x, _y)
    End Sub

    Private Sub SplitContainer1_Panel1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBoxLocation()
    End Sub
    Private Sub PopulateFontCombo()
        cmbFonts.Items.Clear()
        Dim family As FontFamily
        For Each family In FontFamily.Families
            If family.IsStyleAvailable(FontStyle.Bold) = False Then Exit For
            cmbfonts.Items.Add(family.Name)
        Next family
        Try
            cmbfonts.SelectedIndex += 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateFontCombo()
        btn_crop.Enabled = False
        textStyle = FontStyle.Regular
    End Sub


    Private Sub SetResizeInfo()
        lbloriginalSize.Text = OriginalImageSize.ToString
        lblModifiedSize.Text = ModifiedImageSize.ToString()
    End Sub




    Private Sub TrackBarBrightness_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarBrightness.Scroll
        GroupBox8.Text = "Brightness (" & TrackBarBrightness.Value & ")"


        Dim value As Double = TrackBarBrightness.Value * 0.01F
        Dim colorMatrixElements As Single()() = { _
          New Single() {1, 0, 0, 0, 0}, _
          New Single() {0, 1, 0, 0, 0}, _
          New Single() {0, 0, 1, 0, 0}, _
          New Single() {0, 0, 0, 1, 0}, _
          New Single() {value, value, value, 0, 1}}
        Dim colorMatrix As New Imaging.ColorMatrix(colorMatrixElements)
        Dim imageAttributes As New ImageAttributes()


        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)


        Dim _img As Image = Img
        Dim _g As Graphics
        Dim bm_dest As New Bitmap(CInt(_img.Width), CInt(_img.Height))
        _g = Graphics.FromImage(bm_dest)


        _g.DrawImage(_img, New Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes)
        PictureBox1.Image = bm_dest
        chimg()


    End Sub

#Region "Croping Image"
    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Public cropPen As Pen
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.DashDot

    Dim Makeselection As Boolean = False

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If TabControl1.SelectedIndex = 4 Then
            Dim TextStartLocation As Point = e.Location
            If CreateText Then
                Cursor = Cursors.IBeam
            End If
        Else
            Cursor = Cursors.Default
            If Makeselection Then
                Try

                    If e.Button = Windows.Forms.MouseButtons.Left Then
                        Cursor = Cursors.Cross
                        cropX = e.X
                        cropY = e.Y

                        cropPen = New Pen(Color.Black, 1)
                        cropPen.DashStyle = DashStyle.DashDotDot


                    End If
                    PictureBox1.Refresh()
                Catch ex As Exception
                End Try
            End If
        End If


        'firstx = xpos.ToString
        'firsty = ypos.ToString
        firstx = e.X
        firsty = e.Y
        'test
        If spray = True Then
            spraystart = True
        End If


        'test triangle
        If drawtriangle = True Then

            If remhits = 0 Then
                firstclick = New Point(e.X, e.Y)
                ' MsgBox(firstclick.X.ToString & "x | y" & firstclick.Y.ToString)
            End If

            If remhits = 1 Then
                secondclick = New Point(e.X, e.Y)
                ' MsgBox(secondclick.X.ToString & "x | y" & secondclick.Y.ToString)
            End If
            If remhits = 2 Then
                thirdclick = New Point(e.X, e.Y)
                ' MsgBox(thirdclick.X.ToString & "x | y" & thirdclick.Y.ToString)

                Dim pts() As Point = { _
                                 firstclick, _
                                secondclick, _
                                thirdclick}

                If newimagedraw = True Then
                    'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                    Dim graph1 As Graphics = Graphics.FromImage(newimage)
                    graph1.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    graph1.DrawPolygon(pencolor, pts)
                    PictureBox1.Image = newimage

                Else
                    graph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    graph.DrawPolygon(pencolor, pts)
                    PictureBox1.Image = bm

                End If




                ' drawtriangle = False
                remhits = -1


            End If
            remhits = remhits + 1
        End If

        'draw filled triangle

        If drawfilledtriangle = True Then

            If remhits1 = 0 Then
                firstclick1 = New Point(e.X, e.Y)
                ' MsgBox(firstclick.X.ToString & "x | y" & firstclick.Y.ToString)
            End If

            If remhits1 = 1 Then
                secondclick1 = New Point(e.X, e.Y)
                ' MsgBox(secondclick.X.ToString & "x | y" & secondclick.Y.ToString)
            End If
            If remhits1 = 2 Then
                thirdclick1 = New Point(e.X, e.Y)
                ' MsgBox(thirdclick.X.ToString & "x | y" & thirdclick.Y.ToString)

                Dim pts1() As Point = { _
                                 firstclick1, _
                                secondclick1, _
                                thirdclick1}
                If newimagedraw = True Then
                    'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                    Dim graph1 As Graphics = Graphics.FromImage(newimage)
                    graph1.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                    graph1.DrawPolygon(pencolor, pts1)
                    graph1.FillPolygon(brushcolor, pts1)
                    PictureBox1.Image = newimage

                Else
                    graph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                    graph.DrawPolygon(pencolor, pts1)
                    graph.FillPolygon(brushcolor, pts1)

                    PictureBox1.Image = bm

                End If



                ' drawtriangle = False
                remhits1 = -1


            End If
            remhits1 = remhits1 + 1
        End If


    End Sub
    Dim picx As Integer
    Dim picy As Integer
    Dim font2 As Font
    Dim textStyle As New FontStyle
    Private Sub PictureBox1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If Makeselection Then
            Cursor = Cursors.Default
        End If

        secx = e.X
        secy = e.Y


        If paint1 = True Then



            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)




                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawLine(pencolor, firstx, firsty, secx, secy)
                PictureBox1.Image = newimage




            Else
                graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                PictureBox1.Image = bm
            End If



        End If
        '-------------------------------------------


        If drawellipse = True Then

            Dim g As Graphics = PictureBox1.CreateGraphics


            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawEllipse(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                graph1.FillEllipse(brushcolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = newimage

            Else

                graph.DrawEllipse(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                graph.FillEllipse(brushcolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = bm
            End If

        End If
        If drawrectangle = True Then

            Dim g As Graphics = PictureBox1.CreateGraphics



            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawRectangle(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                graph1.FillRectangle(brushcolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = newimage

            Else

                graph.DrawRectangle(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                graph.FillRectangle(brushcolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = bm
            End If
        End If
        If drawText = True Then


            Dim g As Graphics = PictureBox1.CreateGraphics
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        End If
        If drawImage = True Then


            Dim g As Graphics = PictureBox1.CreateGraphics
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        End If
        If drawclearellipse = True Then



            Dim g As Graphics = PictureBox1.CreateGraphics

            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawEllipse(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = newimage

            Else

                graph.DrawEllipse(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = bm
            End If



        End If

        If drawclearrectangle = True Then


            Dim g As Graphics = PictureBox1.CreateGraphics

            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawRectangle(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = newimage

            Else

                graph.DrawRectangle(pencolor, firstx, firsty, secx - firstx, secy - firsty)
                PictureBox1.Image = bm
            End If


        End If
        If drawText = True Then


            Dim g As Graphics = PictureBox1.CreateGraphics
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'font 
            font2 = New Font(cmbfonts.Text, NumericUpDown1.Value, textStyle)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)

                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawString(TextBox1.Text, font2, brushcolor, firstx, firsty)
                PictureBox1.Image = newimage

            Else

                graph.DrawString(TextBox1.Text, font2, brushcolor, firstx, firsty)
                PictureBox1.Image = bm
            End If
            drawText = False
        End If
        If drawImage = True Then


            Dim g As Graphics = PictureBox1.CreateGraphics
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If newimagedraw = True Then
                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                Dim img1 As Image = GetArrow()
                '
                Dim percentage As Integer = 0
                percentage = NumericUpDown3.Value
                Dim originasi As Size = GetArrow().Size
                Dim msi As Size = New Size((originasi.Width * percentage) \ 100, (originasi.Height * percentage) \ 100)
                '
                Dim ima As Image = Nothing
                Try
                    Dim bm_source As New Bitmap(img1) ' Make a bitmap for the result.
                    Dim bm_dest As New Bitmap(CInt(msi.Width), CInt(msi.Height))
                    ' Make a Graphics object for the result Bitmap.
                    Dim gr_dest As Graphics = Graphics.FromImage(bm_dest) ' Copy the source image into the destination bitmap.
                    gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1) ' Display the result.
                    ima = bm_dest
                Catch ex As Exception

                End Try
                Dim p As Point = GetPoint(firstx, firsty)
                graph1.DrawImage(ima, p)
                PictureBox1.Image = newimage
            Else
                Dim img1 As Image = GetArrow()
                '
                Dim percentage As Integer = 0
                percentage = NumericUpDown3.Value
                Dim originasi As Size = GetArrow().Size
                Dim msi As Size = New Size((originasi.Width * percentage) \ 100, (originasi.Height * percentage) \ 100)
                '
                Dim ima As Image = Nothing
                Try
                    Dim bm_source As New Bitmap(img1) ' Make a bitmap for the result.
                    Dim bm_dest As New Bitmap(CInt(msi.Width), CInt(msi.Height))
                    ' Make a Graphics object for the result Bitmap.
                    Dim gr_dest As Graphics = Graphics.FromImage(bm_dest) ' Copy the source image into the destination bitmap.
                    gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1) ' Display the result.
                    ima = bm_dest
                Catch ex As Exception

                End Try
                Dim p As Point = GetPoint(firstx, firsty)
                graph.DrawImage(ima, p)
                PictureBox1.Image = bm
            End If
            drawImage = False
        End If
        spraystart = False
    End Sub
    Function GetArrow() As Image
        Dim img1 As Image = Nothing
        If RadioButton1.Checked Then
            If ComboBox1.SelectedIndex = 0 Then
                img1 = My.Resources.Rightarrow
            ElseIf ComboBox1.SelectedIndex = 1 Then
                img1 = My.Resources.Leftarrow
            ElseIf ComboBox1.SelectedIndex = 2 Then
                img1 = My.Resources.Uparrow
            ElseIf ComboBox1.SelectedIndex = 3 Then
                img1 = My.Resources.Downarrow
            End If
        ElseIf RadioButton2.Checked Then
            If ComboBox1.SelectedIndex = 0 Then
                img1 = My.Resources.Rightarrow_W
            ElseIf ComboBox1.SelectedIndex = 1 Then
                img1 = My.Resources.Leftarrow_W
            ElseIf ComboBox1.SelectedIndex = 2 Then
                img1 = My.Resources.Uparrow_W
            ElseIf ComboBox1.SelectedIndex = 3 Then
                img1 = My.Resources.Downarrow_W
            End If
        End If
        Return img1
    End Function
    Function GetPoint(ByVal x As Single, ByVal y As Single) As Point
        Dim p As New Point(x, y)
        Dim percentage As Integer = 0
        percentage = NumericUpDown3.Value
        Dim originasi As Size = GetArrow().Size
        Dim msi As Size = New Size((originasi.Width * percentage) \ 100, (originasi.Height * percentage) \ 100)
        Dim hi As Integer = msi.Height
        Dim wi As Integer = msi.Width
        If ComboBox1.SelectedIndex = 0 Then
            p = New Point(x - wi, y - (hi / 2))
        ElseIf ComboBox1.SelectedIndex = 1 Then
            p = New Point(x, y - (hi / 2))
        ElseIf ComboBox1.SelectedIndex = 2 Then
            p = New Point(x - (wi / 2), y)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            p = New Point(x - (wi / 2), y - hi)
        End If
        Return p
    End Function
    Private Sub PictureBox1_MouseMove1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If TabControl1.SelectedIndex = 4 Then
            Dim TextStartLocation As Point = e.Location
            If CreateText Then
                Cursor = Cursors.IBeam
            End If
        Else
            Cursor = Cursors.Default
            If Makeselection Then
                Try

                    If PictureBox1.Image Is Nothing Then Exit Sub

                    If e.Button = Windows.Forms.MouseButtons.Left Then

                        PictureBox1.Refresh()
                        cropWidth = e.X - cropX
                        cropHeight = e.Y - cropY
                        PictureBox1.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
                    End If


                Catch ex As Exception

                    If Err.Number = 5 Then Exit Sub
                End Try
            End If
        End If


        xpos = e.X
        ypos = e.Y

        picx = e.X
        picy = e.Y


        'spray
        If spray = True And spraystart = True Then


            Dim g As Graphics = PictureBox1.CreateGraphics
            If newimagedraw = True Then
                'graph.DrawLine(pencolor, firstx, firsty, secx, secy)
                Dim graph1 As Graphics = Graphics.FromImage(newimage)
                graph1.DrawEllipse(pencolor, e.X, e.Y, 10, 10)
                graph1.FillEllipse(brushcolor, e.X, e.Y, 10, 10)
                PictureBox1.Image = newimage
            Else
                graph.DrawEllipse(pencolor, e.X, e.Y, 10, 10)
                graph.FillEllipse(brushcolor, e.X, e.Y, 10, 10)
                PictureBox1.Image = bm

            End If



        End If

        'resize picturebox6
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If spray = False AndAlso paint1 = False AndAlso drawText = False AndAlso drawImage = False AndAlso drawrectangle = False AndAlso drawclearrectangle = False AndAlso drawellipse = False AndAlso drawtriangle = False AndAlso drawfilledtriangle = False AndAlso drawclearellipse = False AndAlso Makeselection = False Then
            Dim lHwnd As Int32
            lHwnd = PictureBox1.Handle
            If lHwnd = 0 Then Exit Sub
            ReleaseCapture()
            SendMessage(lHwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If
    End Sub
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const HTCAPTION = 2

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
                 (ByVal hwnd As Integer, ByVal wMsg As Integer, _
                  ByVal wParam As Integer, ByVal lParam As String) As Integer
    Public Declare Sub ReleaseCapture Lib "user32" ()
    Sub chimg()
        bm = PictureBox1.Image
        graph = Graphics.FromImage(bm)
    End Sub



#End Region





    Dim CreateText As Boolean = False

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If CreateText Then
            Dim txt As New TextBox
            Dim _e As MouseEventArgs = e
            Dim x As Integer = _e.X
            Dim y As Integer = _e.Y
            txt.Location = New Point(x, y)
            txt.Size = New Size(25, 400)
            PictureBox1.Controls.Add(txt)
        End If
    End Sub

    Private Sub btnCreateText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateText = True
        setallfalse()
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub

#Region "----------Rotation---------------"
    Private Sub btnRotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateLeft.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        chimg()
        PictureBox1.Refresh()
    End Sub

    Private Sub btnRotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateRight.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        chimg()
        PictureBox1.Refresh()
    End Sub

    Private Sub btnRotateHorizantal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateHorizantal.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        chimg()
        PictureBox1.Refresh()
    End Sub

    Private Sub btnRotatevertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotatevertical.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        chimg()
        PictureBox1.Refresh()
    End Sub
#End Region





    Private Sub Pen_width_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pen_width.ValueChanged
        pencolor.Width = Pen_width.Value
    End Sub
    Sub fixonnewimage()
        'cannot draw on new image because of picturebox stretch
        'fix for that
        If newimagedraw = True Then
            If PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage Then
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal
                PictureBox1.Image = newimage
            End If
            'test
            If PictureBox1.SizeMode = PictureBoxSizeMode.Normal Then
                PictureBox1.Width = imagex
                PictureBox1.Height = imagey
                'PictureBox1.Image = newimage
            End If
        End If

    End Sub
    Private Sub btn_Brush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Brush.Click

        spray = True

        paint1 = False
        drawText = False
        drawImage = False
        drawrectangle = False
        drawclearrectangle = False
        drawellipse = False
        drawtriangle = False
        drawfilledtriangle = False
        drawclearellipse = False




        'current tool
        lbl_tool.Text = "Brush"

        'fix drawing on new image
        fixonnewimage()
    End Sub
    Sub setallfalse()
        spray = False
        paint1 = False
        drawText = False
        drawImage = False
        drawrectangle = False
        drawclearrectangle = False
        drawellipse = False
        drawtriangle = False
        drawfilledtriangle = False
        drawclearellipse = False
        lbl_tool.Text = "-"
    End Sub
    Private Sub btn_Line_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line.Click

        paint1 = True

        drawImage = False
        spray = False
        drawText = False
        drawrectangle = False
        drawclearrectangle = False
        drawellipse = False
        drawtriangle = False
        drawfilledtriangle = False
        drawclearellipse = False

        'current tool
        lbl_Tool.Text = "Pen/Line"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub btn_TRI_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TRI_f.Click
        MsgBox("You have to select the triangle points on the form." + vbNewLine + "You can also choose the color and width of pen.", MsgBoxStyle.Information)

        drawfilledtriangle = True

        drawImage = False
        paint1 = False
        drawText = False
        drawrectangle = False
        drawclearrectangle = False
        drawellipse = False
        drawtriangle = False
        spray = False
        drawclearellipse = False

        'current tool
        lbl_Tool.Text = "Draw Triangle, with fill"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub btn_REC_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_REC_f.Click
        drawrectangle = True

        drawImage = False
        paint1 = False
        drawText = False
        spray = False
        drawclearrectangle = False
        drawellipse = False
        drawtriangle = False
        drawfilledtriangle = False
        drawclearellipse = False

        'current tool
        lbl_Tool.Text = "Draw Rectangle, with fill"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub btn_TRI_uf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TRI_uf.Click
        'show instructions
        MsgBox("You have to select the triangle points on the form." + vbNewLine + "You can also choose the color and width of pen.", MsgBoxStyle.Information)


        drawtriangle = True

        drawImage = False
        paint1 = False
        drawText = False
        drawrectangle = False
        drawclearrectangle = False
        drawellipse = False
        spray = False
        drawfilledtriangle = False
        drawclearellipse = False

        'current tool
        lbl_Tool.Text = "Draw Triangle, no fill"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub btn_REC_uf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_REC_uf.Click
        drawclearrectangle = True
        drawImage = False
        paint1 = False
        drawText = False
        drawrectangle = False
        spray = False
        drawellipse = False
        drawtriangle = False
        drawfilledtriangle = False
        drawclearellipse = False

        'current tool
        lbl_Tool.Text = "Draw Rectangle, no fill"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub btn_ELP_f_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ELP_f.Click

        drawellipse = True

        drawImage = False
        paint1 = False
        drawText = False
        drawrectangle = False
        drawclearrectangle = False
        spray = False
        drawtriangle = False
        drawfilledtriangle = False
        drawclearellipse = False

        'current tool
        lbl_Tool.Text = "Draw Ellipse"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub btn_ELP_uf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ELP_uf.Click
        drawclearellipse = True

        drawImage = False
        paint1 = False
        drawText = False
        drawrectangle = False
        drawclearrectangle = False
        drawellipse = False
        drawtriangle = False
        drawfilledtriangle = False
        spray = False


        'current tool
        lbl_Tool.Text = "Draw Ellipse, no fill"

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub GsGlassButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GsGlassButton9.Click
        Dim i As Image = defimg.Clone
        PictureBox1.Image = defimg
        Dim imgWidth As Integer = defimg.Width
        Dim imghieght As Integer = defimg.Height
        PictureBox1.Width = imgWidth
        PictureBox1.Height = imghieght
        PictureBoxLocation()
        OriginalImageSize = New Size(imgWidth, imghieght)
        SetResizeInfo()
        chimg()
        defimg = i.Clone
    End Sub



    Private Sub GsGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GsGlassButton1.Click
        lbl_tool.Text = "Draw Text"

        If TextBox1.Text.Length > 0 Then
            drawText = True
            paint1 = False
            spray = False
            drawrectangle = False
            drawclearrectangle = False
            drawellipse = False
            drawtriangle = False
            drawfilledtriangle = False
            drawclearellipse = False
        Else
            MsgBox("Please write the text to be drawn first." + vbNewLine + "After press this button" + vbNewLine + "and click where you want the text to appear.", MsgBoxStyle.Information)

        End If

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            textStyle += FontStyle.Bold
        Else
            textStyle -= FontStyle.Bold
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            textStyle += FontStyle.Italic
        Else
            textStyle -= FontStyle.Italic
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            textStyle += FontStyle.Underline
        Else
            textStyle -= FontStyle.Underline
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            textStyle += FontStyle.Strikeout
        Else
            textStyle -= FontStyle.Strikeout
        End If
    End Sub


    Private Sub btn_Changecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Changecolor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pencolor.Color = ColorDialog1.Color
            brushcolor = New SolidBrush(ColorDialog1.Color)
            'current color
            pic_color.BackColor = ColorDialog1.Color
        End If
    End Sub
    Sub ChangeImg()
        Dim bm_source As New Bitmap(bm) ' Make a bitmap for the result.
        Dim bm_dest As New Bitmap(CInt(ModifiedImageSize.Width), CInt(ModifiedImageSize.Height))
        ' Make a Graphics object for the result Bitmap.
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest) ' Copy the source image into the destination bitmap.
        gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1) ' Display the result.
        Img = bm_dest
        chimg()
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim bm_source As New Bitmap(bm) ' Make a bitmap for the result.
            Dim bm_dest As New Bitmap(CInt(ModifiedImageSize.Width), CInt(ModifiedImageSize.Height))
            ' Make a Graphics object for the result Bitmap.
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest) ' Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1) ' Display the result.
            PictureBox1.Image = bm_dest
            PictureBox1.Width = bm_dest.Width
            PictureBox1.Height = bm_dest.Height
            PictureBoxLocation()
            ChangeImg()
            chimg()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmakeselection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmakeselection.Click
        setallfalse()
        Makeselection = True
        btn_crop.Enabled = True
    End Sub

    Private Sub btn_crop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crop.Click
        Try
            Cursor = Cursors.Default
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If
                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                'First we define a rectangle with the help of already calculated points
                Dim OriginalImage As Bitmap = New Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height)
                'Original image
                Dim _img As New Bitmap(cropWidth, cropHeight) ' for cropinf image
                Dim g As Graphics = Graphics.FromImage(_img) ' create graphics
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                'set image attributes
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel)

                PictureBox1.Image = _img
                PictureBox1.Width = _img.Width
                PictureBox1.Height = _img.Height
                PictureBoxLocation()
                chimg()
                btn_crop.Enabled = False
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
        Makeselection = False
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        Dim percentage As Integer = 0
        Try
            percentage = Convert.ToInt32(NumericUpDown2.Value)
            ModifiedImageSize = New Size((OriginalImageSize.Width * percentage) \ 100, (OriginalImageSize.Height * percentage) \ 100)
            SetResizeInfo()
        Catch ex As Exception
            MessageBox.Show("Invalid Percentage")
            Exit Sub
        End Try
    End Sub

    Private Sub GsGlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GsGlassButton2.Click
        lbl_tool.Text = "Draw Arrow"

        If ComboBox1.SelectedIndex > -1 Then
            drawText = False
            drawImage = True
            paint1 = False
            spray = False
            drawrectangle = False
            drawclearrectangle = False
            drawellipse = False
            drawtriangle = False
            drawfilledtriangle = False
            drawclearellipse = False
        Else
            MsgBox("Please select the arrow to be drawn first." + vbNewLine + "After press this button" + vbNewLine + "and click where you want the Arrow to appear.", MsgBoxStyle.Information)

        End If

        'fix drawing on new image
        fixonnewimage()
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        Try
            Dim percentage As Integer = 0
            percentage = NumericUpDown3.Value
            Dim originasi As Size = GetArrow().Size
            Dim msi As Size = New Size((originasi.Width * percentage) \ 100, (originasi.Height * percentage) \ 100)
            ArrowMo.Text = msi.ToString
            ArrowOri.Text = originasi.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GsGlassButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GsGlassButton3.Click
        setallfalse()
    End Sub

    Private Sub ImageEditor_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.PictureBoxLocation()
    End Sub
End Class
