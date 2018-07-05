Imports System.Drawing.Drawing2D

Public Class AVProgressBar
    Inherits Control

    Private Value_ As Integer = 50
    Private _Thickness As Integer = 5
    Private _Angle As Integer = 0
    Private _Symbol As String = "%"
    Private _MC, _PC As Color
    Property Value As Integer
        Get
            Return Value_
        End Get
        Set(value As Integer)
            Value_ = value
            Draw()
        End Set
    End Property
    Property MainColor As Color
        Get
            Return _MC
        End Get
        Set(value As Color)
            _MC = value
            Draw()
        End Set
    End Property
    Property ProgressColor As Color
        Get
            Return _PC
        End Get
        Set(value As Color)
            _PC = value
            Draw()
        End Set
    End Property
    Sub Draw()
        Me.Width = Me.Height
        Using B1 As New Bitmap(Width, Height)

            Using G As Graphics = Graphics.FromImage(B1)
                G.SmoothingMode = SmoothingMode.AntiAlias


                G.Clear(BackColor)


                'Using LGB As New LinearGradientBrush(ClientRectangle, Color.FromArgb(217, 217, 217), Color.FromArgb(217, 217, 217), LinearGradientMode.Vertical)
                'Using P1 As New Pen(LGB, Thickness + 3)
                'G.DrawArc(P1, CInt(Thickness / 2) + 2, CInt(Thickness / 2) + 2, Width - Thickness - 4, Height - Thickness - 4, -90, 360)
                'End Using
                'End Using
                Using LGB As New LinearGradientBrush(ClientRectangle, MainColor, MainColor, LinearGradientMode.Vertical)
                    Using P1 As New Pen(LGB, Thickness + 3)
                        G.DrawArc(P1, CInt(Thickness / 2) + 9, CInt(Thickness / 2) + 9, Width - Thickness - 18, Height - Thickness - 18, -90, 360)
                    End Using
                End Using

                Using LGB As New LinearGradientBrush(ClientRectangle, ProgressColor, ProgressColor, LinearGradientMode.Vertical)
                    Using P1 As New Pen(LGB, Thickness - 2)
                        Dim i As Integer = 360 / 100 * Value_
                        G.DrawArc(P1, CInt(Thickness / 2) + 9, CInt(Thickness / 2) + 9, Width - Thickness - 18, Height - Thickness - 18, -90, i)
                    End Using
                End Using


                G.DrawString(Value_ & _Symbol, Me.Font, New SolidBrush(Me.ForeColor), New Point(Me.Width / 2 - G.MeasureString(Value_ & _Symbol, Me.Font).Width / 2 + 1, Me.Height / 2 - G.MeasureString(Value_ & "%", Me.Font).Height / 2 + 1))
            End Using
            Me.CreateGraphics.DrawImage(B1, 0, 0)
        End Using
    End Sub
    Sub New()
        Size = New Size(65, 65)
        MainColor = Color.FromArgb(0, 166, 208)
        ProgressColor = Color.FromArgb(255, 255, 255)
        Me.ForeColor = Color.Black
        Invalidate()
    End Sub

    Public Property Angle() As Integer
        Get
            Return _Angle
        End Get
        Set(ByVal v As Integer)
            _Angle = v : Invalidate()
        End Set
    End Property

    Public Property Symbol() As String
        Get
            Return _Symbol
        End Get
        Set(ByVal v As String)
            _Symbol = v : Invalidate()
        End Set
    End Property

    Public Property Thickness() As Integer
        Get
            Return _Thickness
        End Get
        Set(ByVal v As Integer)
            _Thickness = v : Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaintBackground(ByVal p As PaintEventArgs)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Me.Width = Me.Height
        Using B1 As New Bitmap(Width, Height)

            Using G As Graphics = Graphics.FromImage(B1)
                G.SmoothingMode = SmoothingMode.AntiAlias


                G.Clear(BackColor)


                'Using LGB As New LinearGradientBrush(ClientRectangle, Color.FromArgb(217, 217, 217), Color.FromArgb(217, 217, 217), LinearGradientMode.Vertical)
                'Using P1 As New Pen(LGB, Thickness + 3)
                'G.DrawArc(P1, CInt(Thickness / 2) + 2, CInt(Thickness / 2) + 2, Width - Thickness - 4, Height - Thickness - 4, -90, 360)
                'End Using
                'End Using
                Using LGB As New LinearGradientBrush(ClientRectangle, MainColor, MainColor, LinearGradientMode.Vertical)
                    Using P1 As New Pen(LGB, Thickness + 3)
                        G.DrawArc(P1, CInt(Thickness / 2) + 9, CInt(Thickness / 2) + 9, Width - Thickness - 18, Height - Thickness - 18, -90, 360)
                    End Using
                End Using

                Using LGB As New LinearGradientBrush(ClientRectangle, ProgressColor, ProgressColor, LinearGradientMode.Vertical)
                    Using P1 As New Pen(LGB, Thickness - 2)
                        Dim i As Integer = 360 / 100 * Value_
                        G.DrawArc(P1, CInt(Thickness / 2) + 9, CInt(Thickness / 2) + 9, Width - Thickness - 18, Height - Thickness - 18, -90, i)
                    End Using
                End Using


                G.DrawString(Value_ & _Symbol, Me.Font, New SolidBrush(Me.ForeColor), New Point(Me.Width / 2 - G.MeasureString(Value_ & _Symbol, Me.Font).Width / 2 + 1, Me.Height / 2 - G.MeasureString(Value_ & "%", Me.Font).Height / 2 + 1))
            End Using
            e.Graphics.DrawImage(B1, 0, 0)
        End Using
    End Sub
End Class



