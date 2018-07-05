Imports System.Drawing.Drawing2D

Public Class wDOMElement
    Inherits PictureBox
    Public selected As Boolean = False
    Private mdown As Boolean = False
    Private moffset As Point = Nothing

    Private nubs As New List(Of PictureBox)
    Private Sub wDOMElement_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        configureFirstSelection()
    End Sub

    Private Sub wDOMElement_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        unselectME()
    End Sub

    Private Sub wDesignEditor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If mdown Then Return
        mdown = True
        moffset = MousePosition - Location
        selectME()
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
        updateDraw()
        updateBorder()
        For Each v As PictureBox In nubs
            v.Show()
        Next
    End Sub

    Sub unselectME()
        selected = False
        updateBorder()
        updateDraw()
        For Each v As PictureBox In nubs
            v.Hide()
        Next
        Me.Refresh()
    End Sub

    Private Sub updateBorder()
        Using gfx As Graphics = Graphics.FromHwnd(Me.Handle)
            gfx.Clear(BackColor)
            If selected Then
                Dim blackPen As New Pen(Brushes.Black)
                blackPen.DashStyle = DashStyle.Dot
                gfx.DrawRectangle(blackPen, 4, 4, Width - 9, Height - 9)
            End If
        End Using
    End Sub

    Private Sub updateDraw()
        'Needs to be overriden
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
                                           updateDraw()
                                           updateBorder()
                                       End If
                                   End Sub
        AddHandler nPB.MouseUp, Sub()
                                    md = False
                                    moveClock.Stop()
                                End Sub
        nubs.Add(nPB)
    End Sub

    Private Sub wDesignEditor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If mdown Then
            Location = MousePosition - moffset
        End If
    End Sub

    Private Sub wDesignEditor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        mdown = False
    End Sub

End Class