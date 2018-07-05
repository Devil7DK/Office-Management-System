Imports System, System.IO, System.Collections.Generic
Imports System.Drawing, System.Drawing.Drawing2D
Imports System.ComponentModel, System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Public Class Theme
    Inherits ThemeContainer154
    Sub New()
        BackColor = Color.FromArgb(53, 157, 181)

        SetColor("content", Color.White)

        SetColor("textc", Color.Black)
        Font = New Font("Segoe UI", 15)

        SetColor("circlec", Color.White)
        SetColor("circlef", Color.White)
    End Sub

    Dim content As Color
    Dim circlec As Pen
    Dim circlef As Color
    Dim textc As Brush
    Protected Overrides Sub ColorHook()
        content = GetColor("content")
        circlec = GetPen("circlec")
        circlef = GetColor("circlef")
        textc = GetBrush("textc")
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BackColor)

        G.FillRectangle(New SolidBrush(content), New Rectangle(1, 1, Width - 2, Height - 24))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(0, 50, 7, 50))


        ' G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 7, 3, 3))
        G.FillEllipse(New SolidBrush(circlef), New Rectangle(Width - 7, Height - 7, 3, 3))

        'G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 7, 3, 3))
        G.FillEllipse(New SolidBrush(circlef), New Rectangle(Width - 13, Height - 7, 3, 3))

        '  G.DrawEllipse(circlec, New Rectangle(Width - 19, Height - 7, 3, 3))
        G.FillEllipse(New SolidBrush(circlef), New Rectangle(Width - 19, Height - 7, 3, 3))

        '  G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 13, 3, 3))
        G.FillEllipse(New SolidBrush(circlef), New Rectangle(Width - 7, Height - 13, 3, 3))

        ' G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 19, 3, 3))
        G.FillEllipse(New SolidBrush(circlef), New Rectangle(Width - 7, Height - 19, 3, 3))

        '  G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 13, 3, 3))
        G.FillEllipse(New SolidBrush(circlef), New Rectangle(Width - 13, Height - 13, 3, 3))


        G.DrawIcon(FindForm.Icon, New Rectangle(10, 5, 23, 23))
        DrawText(textc, HorizontalAlignment.Left, 44, 2)
        G.DrawString("|", Font, textc, New Point(37, -3))

    End Sub
End Class
Public Class Bouton
    Inherits ThemeControl154
    Sub New()
        Height = 45
        Width = 120
        SetColor("buttonc", Color.FromArgb(53, 157, 181))
        SetColor("textc", Color.White)
        Font = New Font("Segoe UI", 12)
    End Sub

    Dim buttonc As Color
    Dim textc As Brush
    Protected Overrides Sub ColorHook()
        buttonc = GetColor("buttonc")
        textc = GetBrush("textc")
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(buttonc)

        Select Case State
            Case MouseState.None
                DrawText(textc, HorizontalAlignment.Center, 0, 0)
            Case MouseState.Over
                G.Clear(Color.FromArgb(49, 144, 166))
                DrawText(textc, HorizontalAlignment.Center, 0, 0)
            Case MouseState.Down
                G.Clear(Color.FromArgb(34, 100, 115))
                DrawText(textc, HorizontalAlignment.Center, 0, 0)
        End Select
    End Sub
End Class
#Region "Fermer"
'Public Class Fermer
'    Inherits ThemeControl154

'    Sub New()
'        LockHeight = 20
'        LockWidth = 20
'        SetColor("buttonc", Color.White)
'        SetColor("textc", Color.Black)
'        Font = New Font("Segoe UI", 12)
'    End Sub

'    Dim buttonc As Color
'    Dim textc As Brush
'    Protected Overrides Sub ColorHook()
'        buttonc = GetColor("buttonc")
'        textc = GetBrush("textc")
'    End Sub

'    Protected Overrides Sub PaintHook()
'        G.Clear(buttonc)

'        Select Case State
'            Case MouseState.None
'                G.DrawString("r", New Font("Marlett", 10), New SolidBrush(Color.Black), New Point(2, 2))

'            Case MouseState.Over
'                G.DrawString("r", New Font("Marlett", 10), New SolidBrush(Color.Red), New Point(2, 2))
'            Case MouseState.Down
'                G.DrawString("r", New Font("Marlett", 10), New SolidBrush(Color.DarkRed), New Point(2, 2))
'        End Select
'    End Sub
'End Class
#End Region
#Region "Minimizer"
'Public Class Minimizer
'    Inherits ThemeControl154

'    Sub New()
'        LockHeight = 20
'        LockWidth = 20
'        SetColor("buttonc", Color.White)
'        SetColor("textc", Color.Black)
'        Font = New Font("Segoe UI", 12)
'    End Sub

'    Dim buttonc As Color
'    Dim textc As Brush
'    Protected Overrides Sub ColorHook()
'        buttonc = GetColor("buttonc")
'        textc = GetBrush("textc")
'    End Sub

'    Protected Overrides Sub PaintHook()
'        G.Clear(buttonc)

'        Select Case State
'            Case MouseState.None
'                G.DrawString("0", New Font("Marlett", 10), New SolidBrush(Color.Black), New Point(2, 2))

'            Case MouseState.Over
'                G.DrawString("0", New Font("Marlett", 10), New SolidBrush(Color.Green), New Point(2, 2))
'            Case MouseState.Down
'                G.DrawString("0", New Font("Marlett", 10), New SolidBrush(Color.DarkGreen), New Point(2, 2))
'        End Select
'    End Sub
'End Class
#End Region
<DefaultEvent("CheckedChanged")> _
Public Class Check
    Inherits ThemeControl154

    Sub New()
        LockHeight = 20
        Width = 120
        SetColor("Text", Color.Black)
        SetColor("Backcolor", Color.White)
        Font = New Font("Segoe UI", 12)

    End Sub

    Private X As Integer
    Private TextColor, BG As Color

    Protected Overrides Sub ColorHook()
        TextColor = GetColor("Text")
        BG = GetColor("Backcolor")
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Invalidate()
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BG)
        If _Checked Then
            G.FillRectangle(New SolidBrush(Color.Black), New Rectangle(0, 0, 20, 20))
            G.FillRectangle(New SolidBrush(Color.White), New Rectangle(1, 1, 20 - 2, 20 - 2))
        Else
            G.FillRectangle(New SolidBrush(Color.Black), New Rectangle(0, 0, 20, 20))
            G.FillRectangle(New SolidBrush(Color.White), New Rectangle(1, 1, 20 - 2, 20 - 2))
        End If

        If State = MouseState.Over And X < 15 Then
            G.FillRectangle(New SolidBrush(Color.Black), New Rectangle(0, 0, 20, 20))
            G.FillRectangle(New SolidBrush(Color.White), New Rectangle(1, 1, 20 - 2, 20 - 2))
        ElseIf State = MouseState.Down And X < 15 Then
            G.FillRectangle(New SolidBrush(Color.Black), New Rectangle(0, 0, 20, 20))
            G.FillRectangle(New SolidBrush(Color.White), New Rectangle(1, 1, 20 - 2, 20 - 2))
        End If

        If _Checked Then G.DrawString("a", New Font("Marlett", 20), New SolidBrush(Color.FromArgb(53, 157, 181)), New Point(-7, -5))
        DrawText(New SolidBrush(TextColor), HorizontalAlignment.Left, 25, 0)
    End Sub

    Private _Checked As Boolean
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnMouseDown(e)
    End Sub

    Event CheckedChanged(ByVal sender As Object)

End Class
<DefaultEvent("CheckedChanged")> _
Public Class Radio
    Inherits ThemeControl154

    Sub New()

        LockHeight = 20
        SetColor("Text", Color.Black)
        SetColor("Backcolor", Color.White)
        Font = New Font("Segoe UI", 12)
        Width = 120
    End Sub

    Private X As Integer
    Private TextColor, BG As Color

    Protected Overrides Sub ColorHook()
        TextColor = GetColor("Text")
        BG = GetColor("Backcolor")
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Invalidate()
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BG)
        G.SmoothingMode = SmoothingMode.HighQuality
        If _Checked Then
            G.DrawEllipse(New Pen(Color.Black), New Rectangle(New Point(0, 0), New Size(20, 20)))
            G.FillEllipse(New SolidBrush(Color.FromArgb(53, 157, 181)), New Rectangle(New Point(3, 3), New Size(14, 14)))
        Else
            G.DrawEllipse(New Pen(Color.Black), New Rectangle(New Point(0, 0), New Size(20, 20)))
            'G.FillEllipse(New SolidBrush(Color.FromArgb(53, 157, 181)), New Rectangle(New Point(3, 3), New Size(14, 14)))
            DrawText(New SolidBrush(TextColor), HorizontalAlignment.Left, 22, 0)
        End If



        If _Checked Then DrawText(New SolidBrush(TextColor), HorizontalAlignment.Left, 22, 0)
    End Sub

    Private _Field As Integer = 21
    Property Field() As Integer
        Get
            Return _Field
        End Get
        Set(ByVal value As Integer)
            If value < 4 Then Return
            _Field = value
            LockHeight = value
            Invalidate()
        End Set
    End Property

    Private _Checked As Boolean
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnMouseDown(e)
    End Sub

    Event CheckedChanged(ByVal sender As Object)

    Protected Overrides Sub OnCreation()
        InvalidateControls()
    End Sub

    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return

        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is Radio Then
                DirectCast(C, Radio).Checked = False
            End If
        Next
    End Sub

End Class
Public Class Group
    Inherits ThemeContainer154
    Sub New()

        ControlMode = True

        SetColor("background", Color.FromArgb(53, 157, 181))
        SetColor("inside", Color.White)
        SetColor("txt", Color.White)
    End Sub

    Dim bg As Color
    Dim inside As Color
    Dim txt As Brush
    Protected Overrides Sub ColorHook()
        bg = GetColor("background")
        inside = GetColor("inside")
        txt = GetBrush("txt")
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(bg)
        G.FillRectangle(New SolidBrush(inside), New Rectangle(1, 25, Width - 2, Height - 26))
        DrawText(txt, HorizontalAlignment.Left, 2, 0)
    End Sub
End Class
<DefaultEvent("TextChanged")> _
Public Class Text
    Inherits ThemeControl154

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If Base IsNot Nothing Then
                Base.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If Base IsNot Nothing Then
                Base.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If Base IsNot Nothing Then
                Base.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If Base IsNot Nothing Then
                Base.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If Base IsNot Nothing Then
                Base.Multiline = value

                If value Then
                    LockHeight = 0
                    Base.Height = Height - 11
                Else
                    LockHeight = Base.Height + 11
                End If
            End If
        End Set
    End Property
    Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If Base IsNot Nothing Then
                Base.Text = value
            End If
        End Set
    End Property
    Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If Base IsNot Nothing Then
                Base.Font = value
                Base.Location = New Point(3, 5)
                Base.Width = Width - 6

                If Not _Multiline Then
                    LockHeight = Base.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreation()
        If Not Controls.Contains(Base) Then
            Controls.Add(Base)
        End If
    End Sub

    Private Base As TextBox
    Sub New()
        Base = New TextBox

        Base.Font = Font
        Base.Text = Text
        Base.MaxLength = _MaxLength
        Base.Multiline = _Multiline
        Base.ReadOnly = _ReadOnly
        Base.UseSystemPasswordChar = _UseSystemPasswordChar

        Base.BorderStyle = BorderStyle.None

        Base.Location = New Point(4, 4)
        Base.Width = Width - 10

        If _Multiline Then
            Base.Height = Height - 11
        Else
            LockHeight = Base.Height + 11
        End If

        AddHandler Base.TextChanged, AddressOf OnBaseTextChanged
        AddHandler Base.KeyDown, AddressOf OnBaseKeyDown


        SetColor("Text", Color.Black)
        SetColor("bg", Color.White)
        SetColor("Border", Color.FromArgb(53, 157, 181))
    End Sub

    Private BG As Color
    Private P1 As Pen

    Protected Overrides Sub ColorHook()
        BG = GetColor("bg")

        P1 = GetPen("Border")

        Base.ForeColor = GetColor("Text")
        Base.BackColor = GetColor("bg")
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BG)
        DrawBorders(P1)
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = Base.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            Base.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        Base.Location = New Point(4, 5)
        Base.Width = Width - 8

        If _Multiline Then
            Base.Height = Height - 5
        End If


        MyBase.OnResize(e)
    End Sub

End Class
Public Class Controls
    Inherits ThemeControl154
    Private X As Integer
    Dim BG As Color
    Dim Edge As Pen
    Dim Icons As Color
    Dim glow As SolidBrush

    Dim a, b, c As Integer

    Protected Overrides Sub ColorHook()
        Icons = GetColor("Icons")
        BG = GetColor("Background")
    End Sub

    Sub New()
        IsAnimated = True
        SetColor("Icons", Color.Black)
        SetColor("Background", Color.White)
        Me.Size = New Size(84, 18)
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.X
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        MyBase.OnClick(e)
        If X <= 22 Then
            FindForm.WindowState = FormWindowState.Minimized
        ElseIf X > 22 And X <= 46 Then
            If FindForm.WindowState = FormWindowState.Maximized Then FindForm.WindowState = FormWindowState.Normal Else FindForm.WindowState = FormWindowState.Maximized
        Else
            FindForm.Close()
        End If
    End Sub

    Protected Overrides Sub OnAnimation()
        MyBase.OnAnimation()
        Select Case State
            Case MouseState.Over
                If a < 24 And X <= 22 Then
                    a += 4
                    If b > 0 Then
                        b -= 4
                    End If
                    If c > 0 Then
                        c -= 4
                    End If
                    If b < 0 Then b = 0
                    If c < 0 Then c = 0
                    Invalidate()
                    Application.DoEvents()
                End If

                If b < 24 And X > 22 And X <= 46 Then
                    b += 4
                    If a > 0 Then
                        a -= 4
                    End If
                    If a < 0 Then a = 0
                    If c > 0 Then
                        c -= 4
                    End If
                    If c < 0 Then c = 0
                    Invalidate()
                    Application.DoEvents()
                End If

                If c < 32 And X > 46 Then
                    c += 4
                    If a > 0 Then
                        a -= 4
                    End If
                    If b > 0 Then
                        b -= 4
                    End If
                    If a < 0 Then a = 0
                    If b < 0 Then b = 0
                    Invalidate()
                    Application.DoEvents()
                End If

            Case MouseState.None
                If a > 0 Then
                    a -= 4
                End If
                If b > 0 Then
                    b -= 4
                End If
                If c > 0 Then
                    c -= 4
                End If
                If a < 0 Then a = 0
                If b < 0 Then b = 0
                If c < 0 Then c = 0
                Invalidate()
                Application.DoEvents()
        End Select
    End Sub

    Protected Overrides Sub PaintHook()
        'Draw outer edge
        G.Clear(BG)

        'Mouse states
        Dim SB1 As New SolidBrush(Color.FromArgb(a, Color.FromArgb(53, 157, 181)))
        Dim SB1_ As New SolidBrush(Color.FromArgb(b, Color.FromArgb(53, 157, 181)))
        Dim SB2 As New SolidBrush(Color.FromArgb(c, Color.Red))
        Dim SB3 As New SolidBrush(Color.FromArgb(20, Color.Black))
        Select Case State
            Case MouseState.Down
                If X <= 22 Then
                    a = 0
                    G.FillRectangle(SB3, New Rectangle(0, 0, 21, 17))
                ElseIf X > 22 And X <= 46 Then
                    b = 0
                    G.FillRectangle(SB3, New Rectangle(23, 0, 22, 17))
                Else
                    c = 0
                    G.FillRectangle(SB3, New Rectangle(47, 0, 36, 17))
                End If
            Case Else
                If X <= 22 Then
                    G.FillRectangle(SB1, New Rectangle(0, 0, 21, 17))
                ElseIf X > 22 And X <= 46 Then
                    G.FillRectangle(SB1_, New Rectangle(23, 0, 22, 17))
                Else
                    G.FillRectangle(SB2, New Rectangle(47, 0, 36, 17))
                End If
        End Select

        'Draw icons
        G.DrawString("0", New Font("Marlett", 8.25), GetBrush("Icons"), New Point(5, 4))
        If FindForm.WindowState <> FormWindowState.Maximized Then G.DrawString("1", New Font("Marlett", 8), GetBrush("Icons"), New Point(28, 4)) Else G.DrawString("2", New Font("Marlett", 8.25), GetBrush("Icons"), New Point(28, 4))
        G.DrawString("r", New Font("Marlett", 10), GetBrush("Icons"), New Point(56, 3))


    End Sub
End Class
