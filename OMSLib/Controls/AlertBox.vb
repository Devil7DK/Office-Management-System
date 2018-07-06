Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class AlertBox
    Inherits Control

    Private exitLocation As Point
    Private overExit As Boolean

    Enum Style
        Simple
        Success
        Notice
        Warning
        Informations
    End Enum

    Private _alertStyle As Style
    Public Property AlertStyle As Style
        Get
            Return _alertStyle
        End Get
        Set(ByVal value As Style)
            _alertStyle = value
            Invalidate()
        End Set
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        Font = New Font("Verdana", 8)
        Size = New Size(200, 40)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim borderColor, innerColor, textColor As Color
        Select Case _alertStyle
            Case Style.Simple
                borderColor = Color.FromArgb(0, 170, 220)
                innerColor = Color.White
                textColor = Color.FromArgb(150, 150, 150)
            Case Style.Success
                borderColor = Color.FromArgb(105, 130, 124)
                innerColor = Color.FromArgb(60, 105, 79)
                textColor = Color.FromArgb(110, 150, 129)
            Case Style.Notice
                borderColor = Color.FromArgb(115, 136, 139)
                innerColor = Color.FromArgb(110, 131, 134)
                textColor = Color.FromArgb(97, 185, 186)
            Case Style.Warning
                borderColor = Color.FromArgb(155, 126, 126)
                innerColor = Color.FromArgb(150, 121, 121)
                textColor = Color.FromArgb(254, 142, 122)
            Case Style.Informations
                borderColor = Color.FromArgb(165, 165, 116)
                innerColor = Color.FromArgb(160, 160, 111)
                textColor = Color.FromArgb(254, 224, 122)
        End Select

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        G.FillRectangle(New SolidBrush(innerColor), mainRect)
        G.DrawRectangle(New Pen(borderColor), mainRect)

        Dim styleText As String = Nothing

        Select Case _alertStyle

        End Select

        Dim styleFont As New Font(Font.FontFamily, Font.Size, FontStyle.Bold)
        Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
        G.DrawString(styleText, styleFont, New SolidBrush(textColor), New Point(10, textY))
        G.DrawString(Text, Font, New SolidBrush(textColor), New Point(10 + G.MeasureString(styleText, styleFont).Width + 4, textY))

        Dim exitFont As New Font("Marlett", 6)
        Dim exitY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString("r", exitFont).Height / 2) + 1
        exitLocation = New Point(Width - 26, exitY - 3)
        G.DrawString("r", exitFont, New SolidBrush(textColor), New Point(Width - 23, exitY))

    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If e.X >= Width - 26 AndAlso e.X <= Width - 12 AndAlso e.Y > exitLocation.Y AndAlso e.Y < exitLocation.Y + 12 Then
            If Cursor <> Cursors.Hand Then Cursor = Cursors.Hand
            overExit = True
        Else
            If Cursor <> Cursors.Arrow Then Cursor = Cursors.Arrow
            overExit = False
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If overExit Then Me.Visible = False
    End Sub
End Class