Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.Drawing.Design
Imports System, System.IO, System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Reflection
Imports System.Windows.Forms.TabControl
Imports System.ComponentModel.Design

Namespace TheEmpire
    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

    Public Class TheEmpireThemeContainer
        Inherits ContainerControl

        Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            BackColor = Color.FromArgb(50, 50, 50)
            ForeColor = Color.White
            Dock = DockStyle.Fill
        End Sub
        Dim EmpirePurple As Color = Color.FromArgb(55, 173, 242)

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            e.Graphics.Clear(Color.FromArgb(200, 200, 200))

            Dim LGB As New LinearGradientBrush(New Rectangle(0, 0, Width, 37), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
            e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            'LGB = New LinearGradientBrush(New Rectangle(0, 41, Width, 4), Color.FromArgb(80, Color.Black), Color.Transparent, 90.0F)
            'e.Graphics.FillRectangle(LGB, LGB.Rectangle)

            e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(13, 31, e.Graphics.MeasureString(Text, New Font("Segoe UI", 11)).Width + 6, 4))
            e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(0, 35, Width, 2))

            e.Graphics.DrawString(Text, New Font("Segoe UI", 11), Brushes.Black, New Point(15, 9))
            e.Graphics.DrawString(Text, New Font("Segoe UI", 11), Brushes.White, New Point(15, 8))

            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class TheEmpireStatusStrip
        Inherits ContainerControl

        Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Dock = DockStyle.Bottom
            Height = 27
        End Sub

        Dim EmpirePurple As Color = Color.FromArgb(55, 173, 242)

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.Clear(BackColor)

            Dim LGB As New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(25, 25, 25), Color.FromArgb(36, 36, 36), 90.0F)
            e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(0, Height - 2, Width, 2))

            e.Graphics.DrawString(Text, New Font("Segoe UI", 9), Brushes.White, New Point(6, 4))
            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class TheEmpireStatusLabel
        Inherits Label

        Sub New()
            ForeColor = Color.White
            BackColor = Color.Transparent
            Font = New Font("Segoe UI", 9)
        End Sub

    End Class


    Public Class TheEmpireHeaderButton
        Inherits Control

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Mouse states"
        Private State As MouseStates
        Enum MouseStates
            None = 0
            Over = 1
            Down = 2
        End Enum

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            State = MouseStates.Over
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            State = MouseStates.None
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            State = MouseStates.Down
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            State = MouseStates.Over
            Invalidate()
            If e.Button = Windows.Forms.MouseButtons.Left Then MyBase.OnClick(Nothing) 'This fixes some fucked up lag you get...
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnClick(e As EventArgs) 'Do nothing here or it fires twice
        End Sub
#End Region

        Dim EmpirePurple As Color = Color.FromArgb(55, 173, 242)

        Sub New()
            Size = New Size(75, 37)
            Text = "Button"
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
            Font = New Font("Segoe UI", 9)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            e.Graphics.Clear(BackColor)

            Dim LGB As New LinearGradientBrush(New Rectangle(0, 0, Width, 37), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
            e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            LGB = New LinearGradientBrush(New Rectangle(0, 37, Width, 8), Color.FromArgb(80, Color.Black), Color.Transparent, 90.0F)
            e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(0, 35, Width, 2))

            LGB = New LinearGradientBrush(New Rectangle(1, 5, 1, 30), Color.FromArgb(180, EmpirePurple), Color.Transparent, -90.0F)
            e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            e.Graphics.FillRectangle(LGB, New Rectangle(Width - 2, 5, 1, 30))

            LGB = New LinearGradientBrush(New Rectangle(0, 5, 1, 30), Color.FromArgb(180, Color.Black), Color.Transparent, -90.0F)
            e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            e.Graphics.FillRectangle(LGB, New Rectangle(Width - 1, 5, 1, 30))

            Select Case State
                Case MouseStates.Over
                    LGB = New LinearGradientBrush(New Rectangle(2, 15, Width - 5, 20), Color.Transparent, Color.FromArgb(15, Color.White), 90.0F)
                    e.Graphics.FillRectangle(LGB, LGB.Rectangle)
                Case MouseStates.Down
                    LGB = New LinearGradientBrush(New Rectangle(2, 13, Width - 5, 22), Color.Transparent, Color.FromArgb(7, Color.White), 90.0F)
                    e.Graphics.FillRectangle(LGB, LGB.Rectangle)
            End Select

            e.Graphics.DrawString(Text, Font, Brushes.White, New Rectangle(3, 9, Width - 7, Height - 14), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})

            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class TheEmpireButton
        Inherits Control

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Mouse states"
        Private State As MouseStates
        Enum MouseStates
            None = 0
            Over = 1
            Down = 2
        End Enum

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            State = MouseStates.Over
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            State = MouseStates.None
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            State = MouseStates.Down
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            State = MouseStates.Over
            Invalidate()
            If e.Button = Windows.Forms.MouseButtons.Left Then MyBase.OnClick(Nothing) 'This fixes some fucked up lag you get...
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnClick(ByVal e As EventArgs) 'Do nothing here or it fires twice
        End Sub
#End Region

#Region "Properties"

        Enum ImageAlignments
            Left = 0
            Center = 1
            Right = 2
        End Enum

        Dim _ImageAlignment As ImageAlignments = ImageAlignments.Left
        Property ImageAlignment As ImageAlignments
            Get
                Return _ImageAlignment
            End Get
            Set(ByVal value As ImageAlignments)
                _ImageAlignment = value
                Invalidate()
            End Set
        End Property

        Dim _Image As Image
        Property Image As Image
            Get
                Return _Image
            End Get
            Set(ByVal value As Image)
                _Image = value
                Invalidate()
            End Set
        End Property

#End Region

        Sub New()
            Size = New Size(120, 31)
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
            BackColor = Color.Transparent
            Font = New Font("Segoe UI", 9)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality

            Dim LGB As Brush

            Select Case State
                Case MouseStates.None
                    LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
                Case MouseStates.Over
                    LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(42, 42, 42), Color.FromArgb(25, 25, 25), 90.0F)
                Case Else
                    LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(18, 18, 18), 90.0F)
            End Select
            If Not Enabled Then
                LGB = New SolidBrush(Color.FromArgb(55, 55, 55))
            End If
            e.Graphics.FillPath(LGB, CreateRound(0, 0, Width - 1, Height - 1, 6))

            If IsNothing(_Image) Then
                e.Graphics.DrawString(Text, Font, Brushes.White, New Rectangle(3, 2, Width - 7, Height - 5), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
            Else
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                Select Case _ImageAlignment
                    Case ImageAlignments.Left
                        Dim ImageRect As New Rectangle(9, 6, Height - 13, Height - 13)
                        e.Graphics.DrawImage(_Image, ImageRect)
                        e.Graphics.DrawString(Text, Font, Brushes.White, New Rectangle(ImageRect.X + ImageRect.Width + 6, 2, Width - ImageRect.Width - 22, Height - 5), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
                    Case ImageAlignments.Center
                        Dim ImageRect As New Rectangle(((Width - 1) / 2) - (Height - 13) / 2, 6, Height - 13, Height - 13)
                        e.Graphics.DrawImage(_Image, ImageRect)
                    Case ImageAlignments.Right
                        Dim ImageRect As New Rectangle(Width - Height + 3, 6, Height - 13, Height - 13)
                        e.Graphics.DrawImage(_Image, ImageRect)
                        e.Graphics.DrawString(Text, Font, Brushes.White, New Rectangle(3, 2, Width - ImageRect.Width - 22, Height - 5), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
                End Select
            End If

            MyBase.OnPaint(e)
        End Sub

        Public Sub PerformClick()
            MyBase.OnClick(Nothing)
        End Sub

    End Class

    <DefaultEvent("CheckedChanged")> _
    Public Class TheEmpireCheckbox
        Inherits Control

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Mouse states"
        Private State As MouseStates
        Private X As Integer
        Enum MouseStates
            None = 0
            Over = 1
            Down = 2
        End Enum

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            State = MouseStates.Over
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            State = MouseStates.None
            X = -1
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            State = MouseStates.Down
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            X = e.X
            Invalidate()
            MyBase.OnMouseMove(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            State = MouseStates.Over
            Invalidate()
            If e.Button = Windows.Forms.MouseButtons.Left Then
                MyBase.OnClick(Nothing)
                _Checked = Not _Checked
                Invalidate()
            End If

            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnClick(ByVal e As EventArgs) 'Do nothing here or it fires twice
        End Sub
#End Region

#Region "Properties"

        Event CheckedChanged(ByVal sender As Object)

        Private _Checked As Boolean
        Property Checked As Boolean
            Get
                Return _Checked
            End Get
            Set(ByVal value As Boolean)
                _Checked = value
                RaiseEvent CheckedChanged(Me)
                Invalidate()
            End Set
        End Property

        Enum SliderLocations
            Left = 0
            Right = 1
        End Enum

        Private _SliderLocation As SliderLocations = SliderLocations.Right
        Property SliderLocation As SliderLocations
            Get
                Return _SliderLocation
            End Get
            Set(ByVal value As SliderLocations)
                _SliderLocation = value
                Invalidate()
            End Set
        End Property

#End Region

        Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
            Font = New Font("Segoe UI", 9)
            ForeColor = Color.Black
            BackColor = Color.Transparent
            Size = New Size(150, 21)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality

            Dim LGB As Brush

            If X >= 0 And X < 17 Then
                Select Case State
                    Case MouseStates.None
                        LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
                    Case MouseStates.Over
                        LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(48, 48, 48), Color.FromArgb(25, 25, 25), 90.0F)
                    Case Else
                        LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(10, 10, 10), 90.0F)
                End Select
            Else
                LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
            End If
            e.Graphics.FillPath(LGB, CreateRound(1, 2, 15, 15, 7))

            If _Checked Then
                e.Graphics.DrawString("a", New Font("Marlett", 13), Brushes.White, New Point(-2, 1))
            End If

            e.Graphics.DrawString(Text, Font, New SolidBrush(ForeColor), New Rectangle(20, 0, Width - 21, Height - 1), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
            MyBase.OnPaint(e)
        End Sub
    End Class

    <DefaultEvent("CheckedChanged")> _
    Public Class TheEmpireRadioButton
        Inherits Control

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Properties"

        Event CheckedChanged(ByVal sender As Object)

        Private _Checked As Boolean
        Property Checked As Boolean
            Get
                Return _Checked
            End Get
            Set(ByVal value As Boolean)
                _Checked = value
                RaiseEvent CheckedChanged(Me)
                Invalidate()
            End Set
        End Property

#End Region

#Region "Mouse states"
        Private State As MouseStates
        Private X As Integer
        Enum MouseStates
            None = 0
            Over = 1
            Down = 2
        End Enum

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            State = MouseStates.Over
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            State = MouseStates.None
            X = -1
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            State = MouseStates.Down
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            X = e.X
            Invalidate()
            MyBase.OnMouseMove(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            State = MouseStates.Over
            Invalidate()
            For Each C As Control In Parent.Controls
                If TypeOf (C) Is TheEmpireRadioButton Then
                    DirectCast(C, TheEmpireRadioButton).Checked = False
                End If
            Next
            _Checked = True
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnClick(ByVal e As EventArgs) 'Do nothing here or the Click event fires twice
        End Sub
#End Region

        Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
            Font = New Font("Segoe UI", 9)
            ForeColor = Color.Black
            BackColor = Color.Transparent
            Size = New Size(150, 21)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality

            Dim LGB As LinearGradientBrush

            If X >= 0 And X < 17 Then
                Select Case State
                    Case MouseStates.None
                        LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
                    Case MouseStates.Over
                        LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(48, 48, 48), Color.FromArgb(25, 25, 25), 90.0F)
                    Case Else
                        LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(10, 10, 10), 90.0F)
                End Select
            Else
                LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
            End If
            e.Graphics.FillEllipse(LGB, New Rectangle(1, 2, 15, 15))

            If _Checked Then
                LGB = New LinearGradientBrush(New Rectangle(5, 6, 7, 7), Color.White, Color.Gainsboro, 90.0F)
                e.Graphics.FillEllipse(LGB, LGB.Rectangle)
            End If

            e.Graphics.DrawString(Text, Font, New SolidBrush(ForeColor), New Rectangle(20, 0, Width - 21, Height - 1), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class TheEmpireGroupBox
        Inherits ContainerControl

        Sub New()
            Font = New Font("Segoe UI", 9)
            ForeColor = Color.Black
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
            BackColor = Color.Transparent
        End Sub

        Dim EmpirePurple As Color = Color.FromArgb(55, 173, 242)

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(13, 19, e.Graphics.MeasureString(Text, New Font("Segoe UI", 10)).Width + 2, 4))
            e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(0, 23, Width, 2))

            e.Graphics.DrawString(Text, New Font("Segoe UI", 10), Brushes.Black, New Point(16, 0))

            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class TheEmpireDropdownButton
        Inherits ComboBox

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Mouse states"
        Private State As MouseStates
        Enum MouseStates
            None = 0
            Over = 1
            Down = 2
        End Enum

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            State = MouseStates.Over
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            State = MouseStates.None
            Invalidate()
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            State = MouseStates.Down
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            State = MouseStates.Over
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Public Shadows Event Click(ByVal Sender As Object, ByVal ItemIndex As Integer)
#End Region

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
            DoubleBuffered = True
            ForeColor = Color.White
            DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            ItemHeight = 23
            Size = New Size(144, 30)
            Font = New Font("Segoe UI", 9)
            ForeColor = Color.White
            BackColor = Color.FromArgb(200, 200, 200)
            DropDownStyle = ComboBoxStyle.DropDownList
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.Clear(BackColor)
            e.Graphics.TextContrast = 0.1
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality

            Dim LGB As Brush
            Select Case State
                Case MouseStates.None
                    LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
                Case MouseStates.Over
                    LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(42, 42, 42), Color.FromArgb(25, 25, 25), 90.0F)
                Case Else
                    LGB = New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(18, 18, 18), 90.0F)
            End Select
            If Not Enabled Then
                LGB = New SolidBrush(Color.FromArgb(55, 55, 55))
            End If

            e.Graphics.FillPath(LGB, CreateRound(0, 0, Width - 1, Height - 1, 6))

            Dim TextToDraw As String = SelectedItem
            If String.IsNullOrEmpty(TextToDraw) Then TextToDraw = "..."
            e.Graphics.DrawString(TextToDraw, Font, New SolidBrush(ForeColor), New Rectangle(0, 0, Width - 10, Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})

            Dim P() As Point = {New Point(Width - 18, 12), New Point(Width - 10, 12), New Point(Width - 14, 17)}
            e.Graphics.FillPolygon(Brushes.White, P)
        End Sub

        Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
            If e.Index < 0 Then Exit Sub
            Dim rect As New Rectangle()
            rect.X = e.Bounds.X
            rect.Y = e.Bounds.Y
            rect.Width = e.Bounds.Width - 1
            rect.Height = e.Bounds.Height - 1

            e.DrawBackground()
            If e.State > 0 Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(70, 70, 70)), e.Bounds)
                e.Graphics.DrawString(Me.Items(e.Index).ToString(), New Font(Font.FontFamily, 8), Brushes.White, e.Bounds, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
            Else
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(36, 36, 36)), e.Bounds)
                e.Graphics.DrawString(Me.Items(e.Index).ToString(), New Font(Font.FontFamily, 8), Brushes.White, e.Bounds, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter})
            End If
            e.Graphics.DrawLine(New Pen(Color.FromArgb(55, Color.Black)), New Point(e.Bounds.X, e.Bounds.Y + e.Bounds.Height - 1), New Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height - 1))
            MyBase.OnDrawItem(e)
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            Invalidate()
            MyBase.OnTextChanged(e)
        End Sub

    End Class

    Public Class TheEmpireListbox
        Inherits ListBox

#Region "CreateRound"

        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function

#End Region

        Sub New()
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            DoubleBuffered = True
            BorderStyle = Windows.Forms.BorderStyle.None
            DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            ItemHeight = 24
            ForeColor = Color.Black
            BackColor = Color.FromArgb(200, 200, 200)
            IntegralHeight = False
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = 15 Then
                Dim G As Graphics = CreateGraphics()
                G.SmoothingMode = SmoothingMode.AntiAlias
                G.DrawPath(New Pen(Color.FromArgb(100, 100, 100)), CreateRound(0, 0, Width - 1, Height - 1, 7))
            End If
            MyBase.WndProc(m)
        End Sub

        Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
            CreateGraphics.DrawPath(New Pen(Color.FromArgb(100, 100, 100)), CreateRound(0, 0, Width - 1, Height - 1, 7))

            If e.Index < 0 Or Items.Count < 1 Then Exit Sub
            Dim ItemRectangle As Rectangle = New Rectangle(e.Bounds.X + 3, e.Bounds.Y + 1, e.Bounds.Width - 7, e.Bounds.Height - 2)


            e.Graphics.FillRectangle(New SolidBrush(BackColor), ItemRectangle)
            e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
            If e.State > 0 Then
                Dim LGB As New LinearGradientBrush(ItemRectangle, Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                e.Graphics.FillPath(LGB, CreateRound(ItemRectangle, 4))
                e.Graphics.SmoothingMode = SmoothingMode.None

                e.Graphics.DrawString(Items(e.Index).ToString(), Font, Brushes.White, 7, e.Bounds.Y + 4)
            Else
                e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
                e.Graphics.DrawString(Items(e.Index).ToString(), Font, Brushes.Black, 7, e.Bounds.Y + 4)
            End If

            MyBase.OnDrawItem(e)

            CreateGraphics.DrawPath(New Pen(Color.FromArgb(100, 100, 100)), CreateRound(0, 0, Width - 1, Height - 1, 7))
        End Sub
    End Class

    <DefaultEvent("TextChanged")> _
    Public Class TheEmpireTextBox
        Inherits Control

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Properties"
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
                        Base.Height = Height - 7
                        Base.Location = New Point(3, 3)
                    Else
                        Height = Base.Height + 7
                        Base.Location = New Point(6, 3)
                    End If
                End If
            End Set
        End Property
        Overrides Property Text As String
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
        Overrides Property Font As Font
            Get
                Return MyBase.Font
            End Get
            Set(ByVal value As Font)
                MyBase.Font = value
                If Base IsNot Nothing Then
                    Base.Font = value
                    Base.Location = New Point(6, 3)
                    Base.Width = Width - 12

                    If Not _Multiline Then
                        Height = Base.Height + 7
                    End If
                End If
            End Set
        End Property

        Property SelectionStart As Integer
            Get
                Return Base.SelectionStart
            End Get
            Set(ByVal value As Integer)
                Base.SelectionStart = value
                Invalidate()
            End Set
        End Property

        Property SelectionLength As Integer
            Get
                Return Base.SelectionLength
            End Get
            Set(ByVal value As Integer)
                Base.SelectionLength = value
                Invalidate()
            End Set
        End Property

        ReadOnly Property TextLength As Integer
            Get
                Return Base.TextLength
            End Get
        End Property

        Public Sub ScrollToCaret()
            Base.ScrollToCaret()
        End Sub

        Public Sub Clear()
            Base.Text = String.Empty
        End Sub

#End Region

#Region "Mouse events"

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

#End Region

        Protected Overrides Sub InitLayout()
            If Not Controls.Contains(Base) Then
                Controls.Add(Base)
            End If
            MyBase.InitLayout()
        End Sub

        Friend WithEvents Base As TextBox
        Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Font = New Font("Segoe UI", 9)

            Base = New TextBox

            Base.Font = Font
            Base.Text = Text
            Base.ForeColor = Color.Black
            Base.BackColor = Color.White
            Base.MaxLength = _MaxLength
            Base.Multiline = _Multiline
            Base.ReadOnly = _ReadOnly
            Base.UseSystemPasswordChar = _UseSystemPasswordChar
            Base.BorderStyle = BorderStyle.None
            Base.Location = New Point(6, 3)
            Base.Width = Width - 12

            If _Multiline Then
                Base.Height = Height - 7
            Else
                Height = Base.Height + 7
            End If

            AddHandler Base.TextChanged, AddressOf OnBaseTextChanged
            AddHandler Base.KeyDown, AddressOf OnBaseKeyDown
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.Clear(BackColor)
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality
            e.Graphics.FillPath(New SolidBrush(Color.White), CreateRound(0, 0, Width - 1, Height - 1, 6))
            e.Graphics.DrawPath(New Pen(Color.FromArgb(100, 100, 100)), CreateRound(0, 0, Width - 1, Height - 1, 6))

            MyBase.OnPaint(e)
        End Sub

        Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
            Text = Base.Text
            Base.BringToFront()
            If Text.Length = 0 Then
                Base.Focus()
                Base.SelectionStart = 0
                Base.SelectionLength = 0
                Base.Select()
            End If
        End Sub

        Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
            If e.Control AndAlso e.KeyCode = Keys.A Then
                Base.SelectAll()
                e.SuppressKeyPress = True
            End If
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            Base.Location = New Point(6, 3)
            Base.Width = Width - 12

            If _Multiline Then
                Base.Height = Height - 7
                Base.Location = New Point(3, 3)
            Else
                Base.Location = New Point(6, 3)
            End If
            MyBase.OnResize(e)
        End Sub
        Dim _NextControl As Control
        Property NextControl As Control
            Get
                Return _NextControl
            End Get
            Set(value As Control)
                Me._NextControl = value
                Try
                    If TypeOf _NextControl Is TheEmpireTextBox Then
                        CType(_NextControl, TheEmpireTextBox).PreviousControl = Me
                    ElseIf TypeOf _NextControl Is TheEmpireMaskedTextBox Then
                        CType(_NextControl, TheEmpireMaskedTextBox).PreviousControl = Me
                    End If
                Catch ex As Exception

                End Try
            End Set
        End Property
        Property PreviousControl As Control
        Private Sub TheEmpireTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Base.KeyDown
            If Me.Multiline = True Then
                If e.Control = True Then
                    If e.KeyCode = Keys.Enter Then
                        If e.Shift = True Then
                            Try
                                Me.PreviousControl.Focus()
                                e.SuppressKeyPress = True
                            Catch ex As Exception

                            End Try
                        Else
                            Try
                                Me.NextControl.Focus()
                                e.SuppressKeyPress = True
                            Catch ex As Exception

                            End Try
                        End If

                    End If
                End If
            Else
                If e.KeyCode = Keys.Enter Then
                    If e.Shift = True Then
                        Try
                            Me.PreviousControl.Focus()
                            e.SuppressKeyPress = True
                        Catch ex As Exception

                        End Try
                    Else
                        Try
                            Me.NextControl.Focus()
                            e.SuppressKeyPress = True
                        Catch ex As Exception

                        End Try
                    End If

                End If
            End If
        End Sub


        Private Sub TheEmpireTextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Base.Focus()
        End Sub
    End Class

    <DefaultEvent("TextChanged")>
    Public Class TheEmpireMaskedTextBox
        Inherits Control

#Region "CreateRound"
        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
#End Region

#Region "Properties"
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
                        Base.Height = Height - 7
                        Base.Location = New Point(3, 3)
                    Else
                        Height = Base.Height + 7
                        Base.Location = New Point(6, 3)
                    End If
                End If
            End Set
        End Property
        Overrides Property Text As String
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
        Property Mask As String
            Get
                Return Base.Mask
            End Get
            Set(ByVal value As String)
                If Base IsNot Nothing Then
                    Base.Mask = value
                End If
            End Set
        End Property
        Overrides Property Font As Font
            Get
                Return MyBase.Font
            End Get
            Set(ByVal value As Font)
                MyBase.Font = value
                If Base IsNot Nothing Then
                    Base.Font = value
                    Base.Location = New Point(6, 3)
                    Base.Width = Width - 12

                    If Not _Multiline Then
                        Height = Base.Height + 7
                    End If
                End If
            End Set
        End Property

        Property SelectionStart As Integer
            Get
                Return Base.SelectionStart
            End Get
            Set(ByVal value As Integer)
                Base.SelectionStart = value
                Invalidate()
            End Set
        End Property

        Property SelectionLength As Integer
            Get
                Return Base.SelectionLength
            End Get
            Set(ByVal value As Integer)
                Base.SelectionLength = value
                Invalidate()
            End Set
        End Property

        ReadOnly Property TextLength As Integer
            Get
                Return Base.TextLength
            End Get
        End Property

        Public Sub ScrollToCaret()
            Base.ScrollToCaret()
        End Sub

        Public Sub Clear()
            Base.Text = String.Empty
        End Sub

#End Region

#Region "Mouse events"

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            Invalidate()
            MyBase.OnMouseDown(e)
        End Sub

#End Region

        Protected Overrides Sub InitLayout()
            If Not Controls.Contains(Base) Then
                Controls.Add(Base)
            End If
            MyBase.InitLayout()
        End Sub

        Private WithEvents Base As MaskedTextBox
        Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Font = New Font("Segoe UI", 9)

            Base = New MaskedTextBox

            Base.Font = Font
            Base.Text = Text
            Base.ForeColor = Color.Black
            Base.BackColor = Color.White
            Base.MaxLength = _MaxLength
            Base.Multiline = _Multiline
            Base.ReadOnly = _ReadOnly
            Base.UseSystemPasswordChar = _UseSystemPasswordChar
            Base.BorderStyle = BorderStyle.None
            Base.Location = New Point(6, 3)
            Base.Width = Width - 12

            If _Multiline Then
                Base.Height = Height - 7
            Else
                Height = Base.Height + 7
            End If

            AddHandler Base.TextChanged, AddressOf OnBaseTextChanged
            AddHandler Base.KeyDown, AddressOf OnBaseKeyDown
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.Clear(BackColor)
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality
            e.Graphics.FillPath(New SolidBrush(Color.White), CreateRound(0, 0, Width - 1, Height - 1, 6))
            e.Graphics.DrawPath(New Pen(Color.FromArgb(100, 100, 100)), CreateRound(0, 0, Width - 1, Height - 1, 6))

            MyBase.OnPaint(e)
        End Sub

        Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
            Text = Base.Text
            Base.BringToFront()
            If Text.Length = 0 Then
                Base.Focus()
                Base.SelectionStart = 0
                Base.SelectionLength = 0
                Base.Select()
            End If
        End Sub

        Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
            If e.Control AndAlso e.KeyCode = Keys.A Then
                Base.SelectAll()
                e.SuppressKeyPress = True
            End If
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            Base.Location = New Point(6, 3)
            Base.Width = Width - 12

            If _Multiline Then
                Base.Height = Height - 7
                Base.Location = New Point(3, 3)
            Else
                Base.Location = New Point(6, 3)
            End If
            MyBase.OnResize(e)
        End Sub
        Dim _NextControl As Control
        Property NextControl As Control
            Get
                Return _NextControl
            End Get
            Set(value As Control)
                Me._NextControl = value
                Try
                    If TypeOf _NextControl Is TheEmpireTextBox Then
                        CType(_NextControl, TheEmpireTextBox).PreviousControl = Me
                    ElseIf TypeOf _NextControl Is TheEmpireMaskedTextBox Then
                        CType(_NextControl, TheEmpireMaskedTextBox).PreviousControl = Me
                    End If
                Catch ex As Exception

                End Try
            End Set
        End Property
        Property PreviousControl As Control
        Private Sub TheEmpireMaskedTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Base.KeyDown
            If Me.Multiline = True Then
                If e.Control = True Then
                    If e.KeyCode = Keys.Enter Then
                        If e.Shift = True Then
                            Try
                                Me.PreviousControl.Focus()
                                e.SuppressKeyPress = True
                            Catch ex As Exception

                            End Try
                        Else
                            Try
                                Me.NextControl.Focus()
                                e.SuppressKeyPress = True
                            Catch ex As Exception

                            End Try
                        End If

                    End If
                End If
            Else
                If e.KeyCode = Keys.Enter Then
                    If e.Shift = True Then
                        Try
                            Me.PreviousControl.Focus()
                            e.SuppressKeyPress = True
                        Catch ex As Exception

                        End Try
                    Else
                        Try
                            Me.NextControl.Focus()
                            e.SuppressKeyPress = True
                        Catch ex As Exception

                        End Try
                    End If

                End If
            End If
        End Sub
        Private Sub TheEmpireMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Base.Focus()
        End Sub
    End Class
    Public Class TheEmpireTabcontrol
        Inherits TabControl

#Region "Declarations, functions"
        Dim _IndexOver As Integer = -1
        Dim X, Y As Integer
        Dim EmpirePurple As Color = Color.FromArgb(55, 173, 242)
#End Region

#Region "Initialization"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
            DoubleBuffered = True
            SizeMode = TabSizeMode.Fixed
            ItemSize = New Size(37, 120)
        End Sub

        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()
            Alignment = TabAlignment.Left
        End Sub
#End Region

#Region "Mouse Events"

        Dim _OldIndexOver As Integer = 0
        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            X = e.Location.X
            Y = e.Location.Y
            If e.X > ItemSize.Height Then
                _IndexOver = -1
            Else
                Y = (Y - (Y Mod ItemSize.Width)) / ItemSize.Width
                _IndexOver = Y
            End If

            If _IndexOver <> _OldIndexOver Then
                Invalidate()
            End If

            _OldIndexOver = _IndexOver
            MyBase.OnMouseMove(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            _IndexOver = -1
            Invalidate()
            MyBase.OnMouseLeave(e)
        End Sub
#End Region

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.Clear(Color.FromArgb(36, 36, 36))
            e.Graphics.FillRectangle(New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(42, 42, 42), Color.FromArgb(25, 25, 25), 90.0F), New Rectangle(0, 0, Width, Height))

            e.Graphics.FillRectangle(Brushes.Gainsboro, New Rectangle(ItemSize.Height, 0, Width - ItemSize.Height, Height))
            Dim LinearGB As New LinearGradientBrush(New Rectangle(ItemSize.Height, 0, Width - ItemSize.Height, 4), Color.FromArgb(90, Color.Black), Color.Transparent, 90.0F)
            e.Graphics.FillRectangle(LinearGB, LinearGB.Rectangle)
            e.Graphics.DrawLine(Pens.Black, New Point(ItemSize.Height, 0), New Point(ItemSize.Height, Height))

            Try : For Each T As TabPage In TabPages
                    T.BackColor = Color.White
                Next : Catch : End Try


            For i = 0 To TabCount - 1
                Dim x2 As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), New Size(GetTabRect(i).Width, GetTabRect(i).Height))
                Dim textrectangle As New Rectangle(x2.Location.X + 34, x2.Location.Y, x2.Width - 34, x2.Height)

                If i = SelectedIndex Then
                    Dim LGB As New LinearGradientBrush(x2, Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90.0F)
                    e.Graphics.FillRectangle(LGB, LGB.Rectangle)
                    'e.Graphics.FillRectangle(New SolidBrush(EmpirePurple), New Rectangle(x2.Location, New Size(6, x2.Height)))

                    e.Graphics.DrawRectangle(New Pen(Color.FromArgb(51, 51, 51)), x2)
                    e.Graphics.DrawLine(New Pen(Color.FromArgb(17, 17, 17)), New Point(x2.Location.X + 1, x2.Location.Y + x2.Height - 1), New Point(x2.Location.X + x2.Width, x2.Location.Y + x2.Height - 1))

                    e.Graphics.DrawString(TabPages(i).Text, Font, Brushes.Gainsboro, textrectangle, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                Else
                    e.Graphics.DrawString(TabPages(i).Text, Font, Brushes.Gray, textrectangle, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                    e.Graphics.DrawRectangle(New Pen(Color.FromArgb(51, 51, 51)), x2)
                    e.Graphics.DrawLine(New Pen(Color.FromArgb(17, 17, 17)), New Point(x2.Location.X + 1, x2.Location.Y + x2.Height - 1), New Point(x2.Location.X + x2.Width, x2.Location.Y + x2.Height - 1))
                End If

                If i = _IndexOver Then e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(3, Color.White)), x2)
            Next
        End Sub


    End Class

End Namespace

Module DrawHelpers

#Region "Functions"

    Dim Height As Integer
    Dim Width As Integer

    Public Function RoundRectangle(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim P As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
        P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        Return P
    End Function

    Public Function RoundRect(x!, y!, w!, h!, Optional r! = 0.3, Optional TL As Boolean = True, Optional TR As Boolean = True, Optional BR As Boolean = True, Optional BL As Boolean = True) As GraphicsPath
        Dim d! = Math.Min(w, h) * r, xw = x + w, yh = y + h
        RoundRect = New GraphicsPath

        With RoundRect
            If TL Then .AddArc(x, y, d, d, 180, 90) Else .AddLine(x, y, x, y)
            If TR Then .AddArc(xw - d, y, d, d, 270, 90) Else .AddLine(xw, y, xw, y)
            If BR Then .AddArc(xw - d, yh - d, d, d, 0, 90) Else .AddLine(xw, yh, xw, yh)
            If BL Then .AddArc(x, yh - d, d, d, 90, 90) Else .AddLine(x, yh, x, yh)

            .CloseFigure()
        End With
    End Function

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

#End Region

End Module

<DefaultEvent("TextChanged")>
Public Class LogInUserTextBox
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "TextBox Properties"

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 35

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

#End Region

#Region "Colour Properties"

    <Category("Colours")>
    Public Property BackgroundColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        TB = New Windows.Forms.TextBox
        TB.Height = 190
        TB.Font = New Font("Segoe UI", 10)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(42, 42, 42)
        TB.ForeColor = Color.FromArgb(255, 255, 255)
        TB.MaxLength = _MaxLength
        TB.Multiline = False
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35
        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP As GraphicsPath
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            TB.BackColor = Color.FromArgb(42, 42, 42)
            TB.ForeColor = Color.FromArgb(255, 255, 255)
            GP = RoundRectangle(Base, 6)
            .FillPath(New SolidBrush(Color.FromArgb(42, 42, 42)), GP)
            .DrawPath(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), GP)
            .FillPie(New SolidBrush(FindForm.BackColor), New Rectangle(Width - 25, Height - 23, Height + 25, Height + 25), 180, 90)
            .DrawPie(New Pen(Color.FromArgb(35, 35, 35), 2), New Rectangle(Width - 25, Height - 23, Height + 25, Height + 25), 180, 90)
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub



#End Region

End Class

<DefaultEvent("TextChanged")>
Public Class LogInPassTextBox
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox
    Private _BaseColour As Color = Color.FromArgb(255, 255, 255)
    Private _TextColour As Color = Color.FromArgb(50, 50, 50)
    Private _BorderColour As Color = Color.FromArgb(180, 187, 205)
#End Region

#Region "TextBox Properties"

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 35

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub
#End Region

#Region "Colour Properties"

    <Category("Colours")>
    Public Property BackgroundColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        TB = New Windows.Forms.TextBox
        TB.Height = 190
        TB.Font = New Font("Segoe UI", 10)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(42, 42, 42)
        TB.ForeColor = Color.FromArgb(255, 255, 255)
        TB.MaxLength = _MaxLength
        TB.Multiline = False
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35
        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP As GraphicsPath
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            TB.BackColor = Color.FromArgb(42, 42, 42)
            TB.ForeColor = Color.FromArgb(255, 255, 255)
            GP = RoundRectangle(Base, 6)
            .FillPath(New SolidBrush(Color.FromArgb(42, 42, 42)), GP)
            .DrawPath(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), GP)
            .FillPie(New SolidBrush(FindForm.BackColor), New Rectangle(Width - 25, Height - 60, Height + 25, Height + 25), 90, 90)
            .DrawPie(New Pen(Color.FromArgb(35, 35, 35), 2), New Rectangle(Width - 25, Height - 60, Height + 25, Height + 25), 90, 90)

        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInLogButton
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private _ArcColour As Color = Color.FromArgb(43, 43, 43)
    Private _ArrowColour As Color = Color.FromArgb(235, 233, 234)
    Private _ArrowBorderColour As Color = Color.FromArgb(170, 170, 170)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _HoverColour As Color = Color.FromArgb(0, 130, 169)
    Private _PressedColour As Color = Color.FromArgb(0, 145, 184)
    Private _NormalColour As Color = Color.FromArgb(0, 160, 199)
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Colour Properties"
    <Category("Colours")>
    Public Property ArcColour As Color
        Get
            Return _ArcColour
        End Get
        Set(value As Color)
            _ArcColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property ArrowBorderColour As Color
        Get
            Return _ArrowBorderColour
        End Get
        Set(value As Color)
            _ArrowBorderColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property HoverColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property PressedColour As Color
        Get
            Return _PressedColour
        End Get
        Set(value As Color)
            _PressedColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property NormalColour As Color
        Get
            Return _NormalColour
        End Get
        Set(value As Color)
            _NormalColour = value
        End Set
    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Size = New Size(50, 50)
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(50, 50)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Height, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP, GP1 As New GraphicsPath
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Dim P() As Point = {New Point(18, 22), New Point(28, 22), New Point(28, 18), New Point(34, 25), New Point(28, 32), New Point(28, 28), New Point(18, 28)}
            Select Case State
                Case MouseState.None
                    .FillEllipse(New SolidBrush(Color.FromArgb(56, 56, 56)), New Rectangle(CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3))
                    .DrawArc(New Pen(New SolidBrush(_ArcColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360)
                    .DrawEllipse(New Pen(_BorderColour), New Rectangle(1, 1, Height - 3, Height - 3))
                    .FillEllipse(New SolidBrush(_NormalColour), New Rectangle(CInt(3 / 2) + 3, CInt(3 / 2) + 3, Height - 11, Height - 11))
                    .FillPolygon(New SolidBrush(_ArrowColour), P)
                    .DrawPolygon(New Pen(_ArrowBorderColour), P)
                Case MouseState.Over
                    .DrawArc(New Pen(New SolidBrush(_ArcColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360)
                    .DrawEllipse(New Pen(_BorderColour), New Rectangle(1, 1, Height - 3, Height - 3))
                    .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(6, 6, Height - 13, Height - 13))
                    .FillPolygon(New SolidBrush(_ArrowColour), P)
                    .DrawPolygon(New Pen(_ArrowBorderColour), P)
                Case MouseState.Down
                    .DrawArc(New Pen(New SolidBrush(_ArcColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360)
                    .DrawEllipse(New Pen(_BorderColour), New Rectangle(1, 1, Height - 3, Height - 3))
                    .FillEllipse(New SolidBrush(_PressedColour), New Rectangle(6, 6, Height - 13, Height - 13))
                    .FillPolygon(New SolidBrush(_ArrowColour), P)
                    .DrawPolygon(New Pen(_ArrowBorderColour), P)
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("CheckedChanged")>
Public Class LogInCheckBox
    Inherits Control

#Region "Declarations"
    Private _Checked As Boolean
    Private State As MouseState = MouseState.None
    Private _CheckedColour As Color = Color.FromArgb(173, 173, 174)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BackColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
#End Region

#Region "Colour & Other Properties"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property CheckedColour As Color
        Get
            Return _CheckedColour
        End Get
        Set(value As Color)
            _CheckedColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 22
    End Sub
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                   ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Cursor = Cursors.Hand
        Size = New Size(100, 22)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, 20, 20)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_BackColour), Base)
            .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
            Select Case State
                Case MouseState.Over
                    .FillRectangle(New SolidBrush(Color.FromArgb(50, 49, 51)), Base)
                    .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
            End Select
            If Checked Then
                Dim P() As Point = {New Point(4, 11), New Point(6, 8), New Point(9, 12), New Point(15, 3), New Point(17, 6), New Point(9, 16)}
                .FillPolygon(New SolidBrush(_CheckedColour), P)
            End If
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 1, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInNormalTextBox
    Inherits Control

#Region "Declarations"
    Private State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _Style As Styles = Styles.NotRounded
    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private _MaxLength As Integer = 32767
    Private _ReadOnly As Boolean
    Private _UseSystemPasswordChar As Boolean
    Private _Multiline As Boolean
#End Region

#Region "TextBox Properties"


    Public Sub SelectAll()
        TB.Focus()
        TB.SelectAll()
    End Sub

    Enum Styles
        Rounded
        NotRounded
    End Enum

    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property

    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property

    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property

    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 6

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub

    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub

    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 10

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

    Public Property Style As Styles
        Get
            Return _Style
        End Get
        Set(value As Styles)
            _Style = value
        End Set
    End Property

#End Region

#Region "Colour Properties"

    <Category("Colours")>
    Public Property BackgroundColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : TB.Focus() : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        TB = New Windows.Forms.TextBox
        TB.Height = 190
        TB.Font = New Font("Segoe UI", 10)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(42, 42, 42)
        TB.ForeColor = Color.FromArgb(255, 255, 255)
        TB.MaxLength = _MaxLength
        TB.Multiline = False
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 35
        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP As GraphicsPath
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            TB.BackColor = Color.FromArgb(42, 42, 42)
            TB.ForeColor = Color.FromArgb(255, 255, 255)
            Select Case _Style
                Case Styles.Rounded
                    GP = RoundRectangle(Base, 6)
                    .FillPath(New SolidBrush(Color.FromArgb(42, 42, 42)), GP)
                    .DrawPath(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), GP)
                Case Styles.NotRounded
                    .FillRectangle(New SolidBrush(Color.FromArgb(42, 42, 42)), New Rectangle(0, 0, Width - 1, Height - 1))
                    .DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(35, 35, 35)), 2), New Rectangle(0, 0, Width, Height))
            End Select

        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub



#End Region

End Class

Public Class LogInRadialProgressBar
    Inherits Control

#Region "Declarations"
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _ProgressColour As Color = Color.FromArgb(0, 160, 199)
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _StartingAngle As Integer = 110
    Private _RotationAngle As Integer = 255
    Private _Font As Font = New Font("Segoe UI", 20)
#End Region

#Region "Properties"

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get

        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property StartingAngle As Integer
        Get
            Return _StartingAngle
        End Get
        Set(value As Integer)
            _StartingAngle = value
        End Set
    End Property

    <Category("Control")>
    Public Property RotationAngle As Integer
        Get
            Return _RotationAngle
        End Get
        Set(value As Integer)
            _RotationAngle = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(78, 78)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Select Case _Value
                Case 0
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawString(_Value, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case _Maximum
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawArc(New Pen(New SolidBrush(_ProgressColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawString(_Value, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case Else
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawArc(New Pen(New SolidBrush(_ProgressColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, CInt((_RotationAngle / _Maximum) * _Value))
                    .DrawString(_Value, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

<DefaultEvent("CheckedChanged")>
Public Class LogInRadioButton
    Inherits Control

#Region "Declarations"
    Private _Checked As Boolean
    Private State As MouseState = MouseState.None
    Private _HoverColour As Color = Color.FromArgb(50, 49, 51)
    Private _CheckedColour As Color = Color.FromArgb(173, 173, 174)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BackColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
#End Region

#Region "Colour & Other Properties"

    <Category("Colours")>
    Public Property HighlightColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property CheckedColour As Color
        Get
            Return _CheckedColour
        End Get
        Set(value As Color)
            _CheckedColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnClick(e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub
    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is LogInRadioButton Then
                DirectCast(C, LogInRadioButton).Checked = False
                Invalidate()
            End If
        Next
    End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        InvalidateControls()
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 22
    End Sub
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                   ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Cursor = Cursors.Hand
        Size = New Size(100, 22)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(1, 1, Height - 2, Height - 2)
        Dim Circle As New Rectangle(6, 6, Height - 12, Height - 12)
        Dim SecondBorder As New Rectangle(4, 3, 14, 14)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.Transparent)
            .FillEllipse(New SolidBrush(_BackColour), Base)
            .DrawEllipse(New Pen(_BorderColour, 2), Base)
            If Checked Then
                Select Case State
                    Case MouseState.Over
                        .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(2, 2, Height - 4, Height - 4))
                End Select
                .FillEllipse(New SolidBrush(_CheckedColour), Circle)
            Else
                Select Case State
                    Case MouseState.Over
                        .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(2, 2, Height - 4, Height - 4))
                End Select
            End If
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 3, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInLabel
    Inherits Label

#Region "Declaration"
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
#End Region

#Region "Property & Event"

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font("Segoe UI", 9)
        ForeColor = _FontColour
        BackColor = Color.Transparent
        Text = Text
    End Sub

#End Region

End Class

Public Class LogInButtonWithProgress
    Inherits Control

#Region "Declarations"
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _Font As New Font("Segoe UI", 9)
    Private _ProgressColour As Color = Color.FromArgb(0, 191, 255)
    Private _BorderColour As Color = Color.FromArgb(25, 25, 25)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _MainColour As Color = Color.FromArgb(42, 42, 42)
    Private _HoverColour As Color = Color.FromArgb(52, 52, 52)
    Private _PressedColour As Color = Color.FromArgb(47, 47, 47)
    Private State As New MouseState
#End Region

#Region "Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _MainColour
        End Get
        Set(value As Color)
            _MainColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HoverColour As Color
        Get
            Return _HoverColour
        End Get
        Set(value As Color)
            _HoverColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property PressedColour As Color
        Get
            Return _PressedColour
        End Get
        Set(value As Color)
            _PressedColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get
        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
              ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
              ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(75, 30)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim GP, GP1 As New GraphicsPath
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Select Case State
                Case MouseState.None
                    .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 0, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height - 4))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case MouseState.Over
                    .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(0, 0, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 5))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case MouseState.Down
                    .FillRectangle(New SolidBrush(_PressedColour), New Rectangle(0, 0, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 5))
                    .DrawString(Text, _Font, Brushes.White, New Point(Width / 2, Height / 2 - 2), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End Select
            Select Case _Value
                Case 0
                Case _Maximum
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, Height - 4, Width, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                Case Else
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, Height - 4, Width / _Maximum * _Value, Height - 4))
                    .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInGroupBox
    Inherits ContainerControl

#Region "Declarations"
    Private _MainColour As Color = Color.FromArgb(47, 47, 47)
    Private _HeaderColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HeaderColour As Color
        Get
            Return _HeaderColour
        End Get
        Set(value As Color)
            _HeaderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property MainColour As Color
        Get
            Return _MainColour
        End Get
        Set(value As Color)
            _MainColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(160, 110)
        Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim Circle As New Rectangle(8, 8, 10, 10)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 28, Width, Height))
            .FillRectangle(New SolidBrush(_HeaderColour), New Rectangle(0, 0, .MeasureString(Text, Font).Width + 7, 28))
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Point(5, 5))
            Dim P() As Point = {New Point(0, 0), New Point(.MeasureString(Text, Font).Width + 7, 0), New Point(.MeasureString(Text, Font).Width + 7, 28), _
                                New Point(Width - 1, 28), New Point(Width - 1, Height - 1), New Point(1, Height - 1), New Point(1, 1)}
            .DrawLines(New Pen(_BorderColour), P)
            .DrawLine(New Pen(_BorderColour, 2), New Point(0, 28), New Point(.MeasureString(Text, Font).Width + 7, 28))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInSeperator
    Inherits Control

#Region "Declarations"
    Private _SeperatorColour As Color = Color.FromArgb(35, 35, 35)
    Private _Alignment As Style = Style.Horizontal
    Private _Thickness As Single = 1
#End Region

#Region "Properties"

    Enum Style
        Horizontal
        Verticle
    End Enum

    <Category("Control")>
    Public Property Thickness As Single
        Get
            Return _Thickness
        End Get
        Set(value As Single)
            _Thickness = value
        End Set
    End Property

    <Category("Control")>
    Public Property Alignment As Style
        Get
            Return _Alignment
        End Get
        Set(value As Style)
            _Alignment = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SeperatorColour As Color
        Get
            Return _SeperatorColour
        End Get
        Set(value As Color)
            _SeperatorColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Size = New Size(20, 20)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            Select Case _Alignment
                Case Style.Horizontal
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(0, Height / 2), New Point(Width, Height / 2))
                Case Style.Verticle
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(Width / 2, 0), New Point(Width / 2, Height))
            End Select
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class

Public Class LogInNumeric
    Inherits Control

#Region "Variables"

    Private State As MouseState = MouseState.None
    Private MouseXLoc, MouseYLoc As Integer
    Private _Value As Long
    Private _Minimum As Long = 0
    Private _Maximum As Long = 9999999
    Private BoolValue As Boolean
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _ButtonColour As Color = Color.FromArgb(47, 47, 47)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _SecondBorderColour As Color = Color.FromArgb(0, 191, 255)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)

#End Region

#Region "Properties & Events"

    Public Property Value As Long
        Get
            Return _Value
        End Get
        Set(value As Long)
            If value <= _Maximum And value >= _Minimum Then _Value = value
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Long
        Get
            Return _Maximum
        End Get
        Set(value As Long)
            If value > _Minimum Then _Maximum = value
            If _Value > _Maximum Then _Value = _Maximum
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Long
        Get
            Return _Minimum
        End Get
        Set(value As Long)
            If value < _Maximum Then _Minimum = value
            If _Value < _Minimum Then _Value = Minimum
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        MouseXLoc = e.Location.X
        MouseYLoc = e.Location.Y
        Invalidate()
        If e.X < Width - 47 Then Cursor = Cursors.IBeam Else Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If MouseXLoc > Width - 47 AndAlso MouseXLoc < Width - 3 Then
            If MouseXLoc < Width - 23 Then
                If (Value + 1) <= _Maximum Then _Value += 1
            Else
                If (Value - 1) >= _Minimum Then _Value -= 1
            End If
        Else
            BoolValue = Not BoolValue
            Focus()
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Try
            If BoolValue Then _Value = CStr(CStr(_Value) & e.KeyChar.ToString())
            If _Value > _Maximum Then _Value = _Maximum
            Invalidate()
        Catch : End Try
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Back Then
            Value = 0
        End If
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 24
    End Sub

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ButtonColour As Color
        Get
            Return _ButtonColour
        End Get
        Set(value As Color)
            _ButtonColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SecondBorderColour As Color
        Get
            Return _SecondBorderColour
        End Get
        Set(value As Color)
            _SecondBorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
        ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
        ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        Dim CenterSF As New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center}
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_BaseColour), Base)
            .FillRectangle(New SolidBrush(_ButtonColour), New Rectangle(Width - 48, 0, 48, Height))
            .DrawRectangle(New Pen(_BorderColour, 2), Base)
            .DrawLine(New Pen(_SecondBorderColour), New Point(Width - 48, 1), New Point(Width - 48, Height - 2))
            .DrawLine(New Pen(_BorderColour), New Point(Width - 24, 1), New Point(Width - 24, Height - 2))
            .DrawLine(New Pen(_FontColour), New Point(Width - 36, 7), New Point(Width - 36, 17))
            .DrawLine(New Pen(_FontColour), New Point(Width - 31, 12), New Point(Width - 41, 12))
            .DrawLine(New Pen(_FontColour), New Point(Width - 17, 13), New Point(Width - 7, 13))
            .DrawString(Value, Font, New SolidBrush(_FontColour), New Rectangle(5, 1, Width, Height), New StringFormat() With {.LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInColourTable
    Inherits ProfessionalColorTable

#Region "Declarations"

    Private _BackColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _SelectedColour As Color = Color.FromArgb(47, 47, 47)

#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property SelectedColour As Color
        Get
            Return _SelectedColour
        End Get
        Set(value As Color)
            _SelectedColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BackColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property

    Public Overrides ReadOnly Property ButtonSelectedBorder() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property CheckBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property CheckPressedBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property CheckSelectedBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder() As Color
        Get
            Return _BorderColour
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder() As Color
        Get
            Return _BackColour
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected() As Color
        Get
            Return _SelectedColour
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark() As Color
        Get
            Return _BorderColour
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground() As Color
        Get
            Return _BackColour
        End Get
    End Property

#End Region

End Class

Public Class LogInListBox
    Inherits Control

#Region "Variables"

    Private WithEvents ListB As New ListBox
    Private _Items As String() = {""}
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _SelectedColour As Color = Color.FromArgb(55, 55, 55)
    Private _ListBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)

#End Region

#Region "Properties"

    <Category("Control")> _
    Public Property Items As String()
        Get
            Return _Items
        End Get
        Set(value As String())
            _Items = value
            ListB.Items.Clear()
            ListB.Items.AddRange(value)
            Invalidate()
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SelectedColour As Color
        Get
            Return _SelectedColour
        End Get
        Set(value As Color)
            _SelectedColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ListBaseColour As Color
        Get
            Return _ListBaseColour
        End Get
        Set(value As Color)
            _ListBaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Public ReadOnly Property SelectedItem() As String
        Get
            Return ListB.SelectedItem
        End Get
    End Property

    Public ReadOnly Property SelectedIndex() As Integer
        Get
            Return ListB.SelectedIndex
            If ListB.SelectedIndex < 0 Then Exit Property
        End Get
    End Property

    Public Sub Clear()
        ListB.Items.Clear()
    End Sub

    Public Sub ClearSelected()
        For i As Integer = (ListB.SelectedItems.Count - 1) To 0 Step -1
            ListB.Items.Remove(ListB.SelectedItems(i))
        Next
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(ListB) Then
            Controls.Add(ListB)
        End If
    End Sub

    Sub AddRange(ByVal items As Object())
        ListB.Items.Remove("")
        ListB.Items.AddRange(items)
    End Sub

    Sub AddItem(ByVal item As Object)
        ListB.Items.Remove("")
        ListB.Items.Add(item)
    End Sub

#End Region

#Region "Draw Control"

    Sub Drawitem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles ListB.DrawItem
        If e.Index < 0 Then Exit Sub
        e.DrawBackground()
        e.DrawFocusRectangle()
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .InterpolationMode = InterpolationMode.HighQualityBicubic
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            If InStr(e.State.ToString, "Selected,") > 0 Then
                .FillRectangle(New SolidBrush(_SelectedColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            Else
                .FillRectangle(New SolidBrush(_ListBaseColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 8), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            End If
            .Dispose()
        End With
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
            ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        ListB.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ListB.ScrollAlwaysVisible = False
        ListB.HorizontalScrollbar = False
        ListB.BorderStyle = BorderStyle.None
        ListB.BackColor = _BaseColour
        ListB.Location = New Point(3, 3)
        ListB.Font = New Font("Segoe UI", 8)
        ListB.ItemHeight = 20
        ListB.Items.Clear()
        ListB.IntegralHeight = False
        Size = New Size(130, 100)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BackColor)
            ListB.Size = New Size(Width - 6, Height - 5)
            .FillRectangle(New SolidBrush(_BaseColour), Base)
            .DrawRectangle(New Pen(_BorderColour, 3), New Rectangle(0, 0, Width, Height - 1))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTitledListBox
    Inherits Control

#Region "Variables"

    Private WithEvents ListB As New ListBox
    Private _Items As String() = {""}
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _SelectedColour As Color = Color.FromArgb(55, 55, 55)
    Private _ListBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TitleFont As New Font("Segeo UI", 10, FontStyle.Bold)

#End Region

#Region "Properties"

    <Category("Control")>
    Public Property TitleFont As Font
        Get
            Return _TitleFont
        End Get
        Set(value As Font)
            _TitleFont = value
        End Set
    End Property

    <Category("Control")> _
    Public Property Items As String()
        Get
            Return _Items
        End Get
        Set(value As String())
            _Items = value
            ListB.Items.Clear()
            ListB.Items.AddRange(value)
            Invalidate()
        End Set
    End Property

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SelectedColour As Color
        Get
            Return _SelectedColour
        End Get
        Set(value As Color)
            _SelectedColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ListBaseColour As Color
        Get
            Return _ListBaseColour
        End Get
        Set(value As Color)
            _ListBaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Public ReadOnly Property SelectedItem() As String
        Get
            Return ListB.SelectedItem
        End Get
    End Property

    Public ReadOnly Property SelectedIndex() As Integer
        Get
            Return ListB.SelectedIndex
            If ListB.SelectedIndex < 0 Then Exit Property
        End Get
    End Property

    Public Sub Clear()
        ListB.Items.Clear()
    End Sub

    Public Sub ClearSelected()
        For i As Integer = (ListB.SelectedItems.Count - 1) To 0 Step -1
            ListB.Items.Remove(ListB.SelectedItems(i))
        Next
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(ListB) Then
            Controls.Add(ListB)
        End If
    End Sub

    Sub AddRange(ByVal items As Object())
        ListB.Items.Remove("")
        ListB.Items.AddRange(items)
    End Sub

    Sub AddItem(ByVal item As Object)
        ListB.Items.Remove("")
        ListB.Items.Add(item)
    End Sub

#End Region

#Region "Draw Control"

    Sub Drawitem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles ListB.DrawItem
        If e.Index < 0 Then Exit Sub
        e.DrawBackground()
        e.DrawFocusRectangle()
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .InterpolationMode = InterpolationMode.HighQualityBicubic
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            If InStr(e.State.ToString, "Selected,") > 0 Then
                .FillRectangle(New SolidBrush(_SelectedColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            Else
                .FillRectangle(New SolidBrush(_ListBaseColour), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
                .DrawString(" " & ListB.Items(e.Index).ToString(), New Font("Segoe UI", 8), New SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2)
            End If
            .Dispose()
        End With
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
            ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        ListB.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ListB.ScrollAlwaysVisible = False
        ListB.HorizontalScrollbar = False
        ListB.BorderStyle = BorderStyle.None
        ListB.BackColor = BaseColour
        ListB.Location = New Point(3, 28)
        ListB.Font = New Font("Segoe UI", 8)
        ListB.ItemHeight = 20
        ListB.Items.Clear()
        ListB.IntegralHeight = False
        Size = New Size(130, 100)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BackColor)
            ListB.Size = New Size(Width - 6, Height - 30)
            .FillRectangle(New SolidBrush(BaseColour), Base)
            .DrawRectangle(New Pen((_BorderColour), 3), New Rectangle(0, 0, Width, Height - 1))
            .DrawLine(New Pen((_BorderColour), 2), New Point(0, 27), New Point(Width - 1, 27))
            .DrawString(Text, _TitleFont, New SolidBrush(_TextColour), New Rectangle(2, 5, Width - 5, 20), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInContextMenu
    Inherits ContextMenuStrip

#Region "Declarations"

    Private _FontColour As Color = Color.FromArgb(255, 255, 255)

#End Region

#Region "Properties"

    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        Renderer = New ToolStripProfessionalRenderer(New LogInColourTable())
        ShowCheckMargin = False
        ShowImageMargin = False
        ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        MyBase.OnPaint(e)
    End Sub

#End Region

End Class

Public Class LogInProgressBar
    Inherits Control

#Region "Declarations"
    Private _ProgressColour As Color = Color.FromArgb(0, 160, 199)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _FontColour As Color = Color.FromArgb(50, 50, 50)
    Private _SecondColour As Color = Color.FromArgb(0, 145, 184)
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _TwoColour As Boolean = True
#End Region

#Region "Properties"

    Public Property SecondColour As Color
        Get
            Return _SecondColour
        End Get
        Set(value As Color)
            _SecondColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property TwoColour As Boolean
        Get
            Return _TwoColour
        End Get
        Set(value As Boolean)
            _TwoColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get
        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Events"

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 25
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Height = 25
    End Sub

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B = New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Dim ProgVal As Integer = CInt(_Value / _Maximum * Width)
            Select Case Value
                Case 0
                    .FillRectangle(New SolidBrush(_BaseColour), Base)
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                    .DrawRectangle(New Pen(_BorderColour, 3), Base)
                Case _Maximum
                    .FillRectangle(New SolidBrush(_BaseColour), Base)
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                    If _TwoColour Then
                        .SetClip(New Rectangle(0, 0, Width * _Value / _Maximum - 1, Height - 1))
                        For i = 0 To (Width - 1) * _Maximum / _Value Step 25
                            .DrawLine(New Pen(New SolidBrush(_SecondColour), 7), New Point(i, 0), New Point(i - 10, Height))
                        Next
                        .ResetClip()
                    Else
                    End If
                    .DrawRectangle(New Pen(_BorderColour, 3), Base)
                Case Else
                    .FillRectangle(New SolidBrush(_BaseColour), Base)
                    .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                    If _TwoColour Then
                        .SetClip(New Rectangle(0, 0, Width * _Value / _Maximum - 1, Height - 1))
                        For i = 0 To (Width - 1) * _Maximum / _Value Step 25
                            .DrawLine(New Pen(New SolidBrush(_SecondColour), 7), New Point(i, 0), New Point(i - 10, Height))
                        Next
                        .ResetClip()
                    Else
                    End If
                    .DrawRectangle(New Pen(_BorderColour, 3), Base)
            End Select
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInRichTextBox
    Inherits Control

#Region "Declarations"
    Private WithEvents TB As New RichTextBox
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

#End Region

#Region "Events"

    Overrides Property Text As String
        Get
            Return TB.Text
        End Get
        Set(value As String)
            TB.Text = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnBackColorChanged(e)
        TB.BackColor = BackColor
        Invalidate()
    End Sub

    Protected Overrides Sub OnForeColorChanged(ByVal e As System.EventArgs)
        MyBase.OnForeColorChanged(e)
        TB.ForeColor = ForeColor
        Invalidate()
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
        MyBase.OnSizeChanged(e)
        TB.Size = New Size(Width - 10, Height - 11)
    End Sub

    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        MyBase.OnFontChanged(e)
        TB.Font = Font
    End Sub

    Sub TextChanges() Handles MyBase.TextChanged
        TB.Text = Text
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        With TB
            .Multiline = True
            .BackColor = _BaseColour
            .ForeColor = _TextColour
            .Text = String.Empty
            .BorderStyle = BorderStyle.None
            .Location = New Point(5, 5)
            .Font = New Font("Segeo UI", 9)
            .Size = New Size(Width - 10, Height - 10)
        End With
        Controls.Add(TB)
        Size = New Size(135, 35)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            .DrawRectangle(New Pen(_BorderColour, 2), ClientRectangle)
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInStatusBar
    Inherits Control

#Region "Variables"
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TextColour As Color = Color.White
    Private _RectColour As Color = Color.FromArgb(21, 117, 149)
    Private _ShowLine As Boolean = True
    Private _LinesToShow As LinesCount = LinesCount.One
    Private _Alignment As Alignments = Alignments.Left
    Private _ShowBorder As Boolean = True
#End Region

#Region "Properties"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    Enum LinesCount As Integer
        One = 1
        Two = 2
    End Enum

    Enum Alignments
        Left
        Center
        Right
    End Enum

    <Category("Control")>
    Public Property Alignment As Alignments
        Get
            Return _Alignment
        End Get
        Set(value As Alignments)
            _Alignment = value
        End Set
    End Property

    <Category("Control")>
    Public Property LinesToShow As LinesCount
        Get
            Return _LinesToShow
        End Get
        Set(value As LinesCount)
            _LinesToShow = value
        End Set
    End Property

    Public Property ShowBorder As Boolean
        Get
            Return _ShowBorder
        End Get
        Set(value As Boolean)
            _ShowBorder = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Dock = DockStyle.Bottom
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub

    <Category("Colours")> _
    Public Property RectangleColor As Color
        Get
            Return _RectColour
        End Get
        Set(value As Color)
            _RectColour = value
        End Set
    End Property

    Public Property ShowLine As Boolean
        Get
            Return _ShowLine
        End Get
        Set(value As Boolean)
            _ShowLine = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9)
        ForeColor = Color.White
        Size = New Size(Width, 20)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width, Height)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(BaseColour)
            .FillRectangle(New SolidBrush(BaseColour), Base)
            If _ShowLine = True Then
                Select Case _LinesToShow
                    Case LinesCount.One
                        If _Alignment = Alignments.Left Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(22, 2, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
                        ElseIf _Alignment = Alignments.Center Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width, Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        Else
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width - 5, Height), New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
                        End If
                        .FillRectangle(New SolidBrush(_RectColour), New Rectangle(5, 9, 14, 3))
                    Case LinesCount.Two
                        If _Alignment = Alignments.Left Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(22, 2, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
                        ElseIf _Alignment = Alignments.Center Then
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width, Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        Else
                            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(0, 0, Width - 22, Height), New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
                        End If
                        .FillRectangle(New SolidBrush(_RectColour), New Rectangle(5, 9, 14, 3))
                        .FillRectangle(New SolidBrush(_RectColour), New Rectangle(Width - 20, 9, 14, 3))
                End Select
            Else
                .DrawString(Text, Font, Brushes.White, New Rectangle(5, 2, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
            End If
            If _ShowBorder Then
                .DrawLine(New Pen(_BorderColour, 2), New Point(0, 0), New Point(Width, 0))
            Else
            End If
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInOnOffSwitch
    Inherits Control

#Region "Declarations"

    Private _Toggled As Toggles = Toggles.NotToggled
    Private MouseXLoc As Integer
    Private ToggleLocation As Integer = 0
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _NonToggledTextColour As Color = Color.FromArgb(155, 155, 155)
    Private _ToggledColour As Color = Color.FromArgb(23, 119, 151)

#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property NonToggledTextColourderColour As Color
        Get
            Return _NonToggledTextColour
        End Get
        Set(value As Color)
            _NonToggledTextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ToggledColour As Color
        Get
            Return _ToggledColour
        End Get
        Set(value As Color)
            _ToggledColour = value
        End Set
    End Property

    Enum Toggles
        Toggled
        NotToggled
    End Enum

    Event ToggledChanged()

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        MouseXLoc = e.Location.X
        Invalidate()
        If e.X < Width - 40 AndAlso e.X > 40 Then Cursor = Cursors.IBeam Else Cursor = Cursors.Arrow
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If MouseXLoc > Width - 39 Then
            _Toggled = Toggles.Toggled
            ToggledValue()
        ElseIf MouseXLoc < 39 Then
            _Toggled = Toggles.NotToggled
            ToggledValue()
        End If
        Invalidate()
    End Sub

    Public Property Toggled() As Toggles
        Get
            Return _Toggled
        End Get
        Set(ByVal value As Toggles)
            _Toggled = value
            Invalidate()
        End Set
    End Property

    Private Sub ToggledValue()
        If _Toggled Then
            If ToggleLocation < 100 Then
                ToggleLocation += 10
            End If
        Else
            If ToggleLocation > 0 Then
                ToggleLocation -= 10
            End If
        End If
        Invalidate()
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics
        G.Clear(Parent.FindForm.BackColor)
        G.SmoothingMode = SmoothingMode.AntiAlias
        G.FillRectangle(New SolidBrush(_BaseColour), New Rectangle(0, 0, 39, Height))
        G.FillRectangle(New SolidBrush(_BaseColour), New Rectangle(Width - 40, 0, Width, Height))
        G.FillRectangle(New SolidBrush(_BaseColour), New Rectangle(38, 9, Width - 40, 5))
        Dim P As Point() = {New Point(0, 0), New Point(39, 0), New Point(39, 9), New Point(Width - 40, 9), New Point(Width - 40, 0), _
                           New Point(Width - 2, 0), New Point(Width - 2, Height - 1), New Point(Width - 40, Height - 1), _
                            New Point(Width - 40, 14), New Point(39, 14), New Point(39, Height - 1), New Point(0, Height - 1), New Point()}
        G.DrawLines(New Pen(_BorderColour, 2), P)
        If _Toggled = Toggles.Toggled Then
            G.FillRectangle(New SolidBrush(_ToggledColour), New Rectangle(Width / 2, 10, Width / 2 - 38, 3))
            G.FillRectangle(New SolidBrush(_ToggledColour), New Rectangle(Width - 39, 2, 36, Height - 5))
        Else
        End If
        If _Toggled = Toggles.Toggled Then
            G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_TextColour), New Rectangle(2, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
            G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_NonToggledTextColour), New Rectangle(20 - 20 / 3 - 6, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
        ElseIf _Toggled = Toggles.NotToggled Then
            G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_TextColour), New Rectangle(20 - 20 / 3 - 6, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), New SolidBrush(_NonToggledTextColour), New Rectangle(2, -1, Width - 20 + 20 / 3, Height), New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
        End If
        G.DrawLine(New Pen(_BorderColour, 2), New Point(Width / 2, 0), New Point(Width / 2, Height))
    End Sub

#End Region

End Class

Public Class LogInComboBox
    Inherits ComboBox

#Region "Declarations"
    Private _StartIndex As Integer = 0
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _SqaureColour As Color = Color.FromArgb(47, 47, 47)
    Private _ArrowColour As Color = Color.FromArgb(30, 30, 30)
    Private _SqaureHoverColour As Color = Color.FromArgb(52, 52, 52)
    Private State As MouseState = MouseState.None
#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SqaureColour As Color
        Get
            Return _SqaureColour
        End Get
        Set(value As Color)
            _SqaureColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SqaureHoverColour As Color
        Get
            Return _SqaureHoverColour
        End Get
        Set(value As Color)
            _SqaureHoverColour = value
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    Public Property StartIndex As Integer
        Get
            Return _StartIndex
        End Get
        Set(ByVal value As Integer)
            _StartIndex = value
            Try
                MyBase.SelectedIndex = value
            Catch
            End Try
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.Invalidate()
        MyBase.OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As System.Windows.Forms.MouseEventArgs)
        MyBase.Invalidate()
        MyBase.OnMouseUp(e)
    End Sub

#End Region

#Region "Draw Control"

    Sub ReplaceItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim Rect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width + 1, e.Bounds.Height + 1)
        Try
            With e.Graphics
                If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                    .FillRectangle(New SolidBrush(_SqaureColour), Rect)
                    .DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, New SolidBrush(_FontColour), 1, e.Bounds.Top + 2)
                Else
                    .FillRectangle(New SolidBrush(_BaseColour), Rect)
                    .DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, New SolidBrush(_FontColour), 1, e.Bounds.Top + 2)
                End If
            End With
        Catch
        End Try
        e.DrawFocusRectangle()
        Me.Invalidate()

    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        DropDownStyle = ComboBoxStyle.DropDownList
        Me.Width = 163
        Font = New Font("Segoe UI", 10)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Try
                Dim Square As New Rectangle(Width - 25, 0, Width, Height)
                .FillRectangle(New SolidBrush(_BaseColour), New Rectangle(0, 0, Width - 25, Height))
                Select Case State
                    Case MouseState.None
                        .FillRectangle(New SolidBrush(_SqaureColour), Square)
                    Case MouseState.Over
                        .FillRectangle(New SolidBrush(_SqaureHoverColour), Square)
                End Select
                .DrawLine(New Pen(_LineColour, 2), New Point(Width - 26, 1), New Point(Width - 26, Height - 1))
                Try
                    .DrawString(Text, Font, New SolidBrush(_FontColour), New Rectangle(3, 0, Width - 20, Height), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                Catch : End Try
                .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                Dim P() As Point = {New Point(Width - 17, 11), New Point(Width - 13, 5), New Point(Width - 9, 11)}
                .FillPolygon(New SolidBrush(_BorderColour), P)
                .DrawPolygon(New Pen(_ArrowColour), P)
                Dim P1() As Point = {New Point(Width - 17, 15), New Point(Width - 13, 21), New Point(Width - 9, 15)}
                .FillPolygon(New SolidBrush(_BorderColour), P1)
                .DrawPolygon(New Pen(_ArrowColour), P1)
            Catch
            End Try
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTabControl
    Inherits TabControl

#Region "Declarations"

    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BackTabColour As Color = Color.FromArgb(54, 54, 54)
    Private _BaseColour As Color = Color.FromArgb(35, 35, 35)
    Private _ActiveColour As Color = Color.FromArgb(47, 47, 47)
    Private _BorderColour As Color = Color.FromArgb(30, 30, 30)
    Private _UpLineColour As Color = Color.FromArgb(0, 160, 199)
    Private _HorizLineColour As Color = Color.FromArgb(23, 119, 151)
    Private CenterSF As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

#End Region

#Region "Properties"

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property UpLineColour As Color
        Get
            Return _UpLineColour
        End Get
        Set(value As Color)
            _UpLineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property HorizontalLineColour As Color
        Get
            Return _HorizLineColour
        End Get
        Set(value As Color)
            _HorizLineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BackTabColour As Color
        Get
            Return _BackTabColour
        End Get
        Set(value As Color)
            _BackTabColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ActiveColour As Color
        Get
            Return _ActiveColour
        End Get
        Set(value As Color)
            _ActiveColour = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
        SizeMode = TabSizeMode.Normal
        ItemSize = New Size(240, 32)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .Clear(_BaseColour)
            Try : SelectedTab.BackColor = _BackTabColour : Catch : End Try
            Try : SelectedTab.BorderStyle = BorderStyle.FixedSingle : Catch : End Try
            .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
            For i = 0 To TabCount - 1
                Dim Base As New Rectangle(New Point(GetTabRect(i).Location.X, GetTabRect(i).Location.Y), New Size(GetTabRect(i).Width, GetTabRect(i).Height))
                Dim BaseSize As New Rectangle(Base.Location, New Size(Base.Width, Base.Height))
                If i = SelectedIndex Then
                    .FillRectangle(New SolidBrush(_BaseColour), BaseSize)
                    .FillRectangle(New SolidBrush(_ActiveColour), New Rectangle(Base.X + 1, Base.Y - 3, Base.Width, Base.Height + 5))
                    .DrawString(TabPages(i).Text, Font, New SolidBrush(_TextColour), New Rectangle(Base.X + 7, Base.Y, Base.Width - 3, Base.Height), CenterSF)
                    .DrawLine(New Pen(_HorizLineColour, 2), New Point(Base.X + 3, Base.Height / 2 + 2), New Point(Base.X + 9, Base.Height / 2 + 2))
                    .DrawLine(New Pen(_UpLineColour, 2), New Point(Base.X + 3, Base.Y - 3), New Point(Base.X + 3, Base.Height + 5))
                Else
                    .DrawString(TabPages(i).Text, Font, New SolidBrush(_TextColour), BaseSize, CenterSF)
                End If
            Next
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

Public Class LogInTrackBar
    Inherits Control

#Region "Declaration"
    Private _Maximum As Integer = 10
    Private _Value As Integer = 0
    Private CaptureMovement As Boolean = False
    Private Bar As Rectangle = New Rectangle(0, 10, Width - 21, Height - 21)
    Private Track As Size = New Size(25, 14)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BarBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _StripColour As Color = Color.FromArgb(42, 42, 42)
    Private _StripAmountColour As Color = Color.FromArgb(23, 119, 151)
#End Region

#Region "Properties"

    <Category("Colours")> _
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BarBaseColour As Color
        Get
            Return _BarBaseColour
        End Get
        Set(value As Color)
            _BarBaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property StripColour As Color
        Get
            Return _StripColour
        End Get
        Set(value As Color)
            _StripColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property StripAmountColour As Color
        Get
            Return _StripAmountColour
        End Get
        Set(value As Color)
            _StripAmountColour = value
        End Set
    End Property

    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then _Maximum = value
            If value < _Value Then _Value = value
            Invalidate()
        End Set
    End Property

    Event ValueChanged()

    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < 0
                    _Value = 0
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            Invalidate()
            RaiseEvent ValueChanged()
        End Set
    End Property

    Protected Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
        Me.BackColor = Color.Transparent
        MyBase.OnHandleCreated(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim MovementPoint = New Rectangle(New Point(e.Location.X, e.Location.Y), New Size(1, 1))
        Dim Bar As Rectangle = New Rectangle(10, 10, Width - 21, Height - 21)
        If New Rectangle(New Point(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2 - 1), 0), New Size(Track.Width, Height)).IntersectsWith(MovementPoint) Then
            CaptureMovement = True
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        CaptureMovement = False
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If CaptureMovement Then
            Dim MovementPoint As Point = New Point(e.X, e.Y)
            Dim Bar As Rectangle = New Rectangle(10, 10, Width - 21, Height - 21)
            Value = CInt(Maximum * ((MovementPoint.X - Bar.X) / Bar.Width))
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e) : CaptureMovement = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                    ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                    ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            Bar = New Rectangle(13, 11, Width - 27, Height - 21)
            .Clear(Parent.FindForm.BackColor)
            .SmoothingMode = SmoothingMode.AntiAlias
            .TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            .FillRectangle(New SolidBrush(_StripColour), New Rectangle(3, CInt((Height / 2) - 4), Width - 5, 8))
            .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(4, CInt((Height / 2) - 4), Width - 5, 8))
            .FillRectangle(New SolidBrush(_StripAmountColour), New Rectangle(4, CInt((Height / 2) - 4), CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2), 8))
            .FillRectangle(New SolidBrush(_BarBaseColour), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            .DrawRectangle(New Pen(_BorderColour, 2), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            .DrawString(_Value, New Font("Segoe UI", 6.5, FontStyle.Regular), New SolidBrush(_TextColour), New Rectangle(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width - 1, Track.Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("Scroll")>
Public Class LogInVerticalScrollBar
    Inherits Control

#Region "Declarations"

    Private ThumbMovement As Integer
    Private TSA As Rectangle
    Private BSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private ShowThumb As Boolean
    Private ThumbPressed As Boolean
    Private _ThumbSize As Integer = 24
    Private _Minimum As Integer = 0
    Private _Maximum As Integer = 100
    Private _Value As Integer = 0
    Private _SmallChange As Integer = 1
    Private _ButtonSize As Integer = 16
    Private _LargeChange As Integer = 10
    Private _ThumbBorder As Color = Color.FromArgb(35, 35, 35)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _ArrowColour As Color = Color.FromArgb(37, 37, 37)
    Private _BaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _ThumbColour As Color = Color.FromArgb(55, 55, 55)
    Private _ThumbSecondBorder As Color = Color.FromArgb(65, 65, 65)
    Private _FirstBorder As Color = Color.FromArgb(55, 55, 55)
    Private _SecondBorder As Color = Color.FromArgb(35, 35, 35)

#End Region

#Region "Properties & Events"

    <Category("Colours")> _
    Public Property ThumbBorder As Color
        Get
            Return _ThumbBorder
        End Get
        Set(value As Color)
            _ThumbBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbColour As Color
        Get
            Return _ThumbColour
        End Get
        Set(value As Color)
            _ThumbColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbSecondBorder As Color
        Get
            Return _ThumbSecondBorder
        End Get
        Set(value As Color)
            _ThumbSecondBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property FirstBorder As Color
        Get
            Return _FirstBorder
        End Get
        Set(value As Color)
            _FirstBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SecondBorder As Color
        Get
            Return _SecondBorder
        End Get
        Set(value As Color)
            _SecondBorder = value
        End Set
    End Property

    Event Scroll(ByVal sender As Object)

    Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value
            If value > _Value Then _Value = value
            If value > _Maximum Then _Maximum = value
            InvalidateLayout()
        End Set
    End Property

    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < _Value Then _Value = value
            If value < _Minimum Then _Minimum = value
        End Set
    End Property

    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < _Minimum
                    _Value = _Minimum
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            InvalidatePosition()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Is >
                    _SmallChange = value
            End Select
        End Set
    End Property

    Public Property LargeChange() As Integer
        Get
            Return _LargeChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Else
                    _LargeChange = value
            End Select
        End Set
    End Property

    Public Property ButtonSize As Integer
        Get
            Return _ButtonSize
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < 16
                    _ButtonSize = 16
                Case Else
                    _ButtonSize = value
            End Select
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        InvalidateLayout()
    End Sub

    Private Sub InvalidateLayout()
        TSA = New Rectangle(0, 1, Width, 0)
        Shaft = New Rectangle(0, TSA.Bottom - 1, Width, Height - 3)
        ShowThumb = ((_Maximum - _Minimum))
        If ShowThumb Then
            Thumb = New Rectangle(1, 0, Width - 3, _ThumbSize)
        End If
        RaiseEvent Scroll(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.Y = CInt(((_Value - _Minimum) / (_Maximum - _Minimum)) * (Shaft.Height - _ThumbSize) + 1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ShowThumb Then
            If TSA.Contains(e.Location) Then
                ThumbMovement = _Value - _SmallChange
            ElseIf BSA.Contains(e.Location) Then
                ThumbMovement = _Value + _SmallChange
            Else
                If Thumb.Contains(e.Location) Then
                    ThumbPressed = True
                    Return
                Else
                    If e.Y < Thumb.Y Then
                        ThumbMovement = _Value - _LargeChange
                    Else
                        ThumbMovement = _Value + _LargeChange
                    End If
                End If
            End If
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If ThumbPressed AndAlso ShowThumb Then
            Dim ThumbPosition As Integer = e.Y - TSA.Height - (_ThumbSize \ 2)
            Dim ThumbBounds As Integer = Shaft.Height - _ThumbSize
            ThumbMovement = CInt((ThumbPosition / ThumbBounds) * (_Maximum - _Minimum)) + _Minimum
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ThumbPressed = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                            ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                            ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(24, 50)
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Height, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            Dim P() As Point = {New Point(Width / 2, 5), New Point(Width / 4, 13), New Point(Width / 2 - 2, 13), New Point(Width / 2 - 2, Height - 13), _
                                New Point(Width / 4, Height - 13), New Point(Width / 2, Height - 5), New Point(Width - Width / 4 - 1, Height - 13), New Point(Width / 2 + 2, Height - 13), _
                                New Point(Width / 2 + 2, 13), New Point(Width - Width / 4 - 1, 13)}
            .FillPolygon(New SolidBrush(_ArrowColour), P)
            .FillRectangle(New SolidBrush(_ThumbColour), Thumb)
            .DrawRectangle(New Pen(_ThumbBorder), Thumb)
            .DrawRectangle(New Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2)
            .DrawLine(New Pen(_LineColour, 2), New Point(CInt(Thumb.Width / 2 + 1), Thumb.Y + 4), New Point(CInt(Thumb.Width / 2 + 1), Thumb.Bottom - 4))
            .DrawRectangle(New Pen(_FirstBorder), 0, 0, Width - 1, Height - 1)
            .DrawRectangle(New Pen(_SecondBorder), 1, 1, Width - 3, Height - 3)
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("Scroll")> _
Public Class LogInHorizontalScrollBar
    Inherits Control

#Region "Declarations"

    Private ThumbMovement As Integer
    Private LSA As Rectangle
    Private RSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private ShowThumb As Boolean
    Private ThumbPressed As Boolean
    Private _ThumbSize As Integer = 24
    Private _Minimum As Integer = 0
    Private _Maximum As Integer = 100
    Private _Value As Integer = 0
    Private _SmallChange As Integer = 1
    Private _ButtonSize As Integer = 16
    Private _LargeChange As Integer = 10
    Private _ThumbBorder As Color = Color.FromArgb(35, 35, 35)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _ArrowColour As Color = Color.FromArgb(37, 37, 37)
    Private _BaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _ThumbColour As Color = Color.FromArgb(55, 55, 55)
    Private _ThumbSecondBorder As Color = Color.FromArgb(65, 65, 65)
    Private _FirstBorder As Color = Color.FromArgb(55, 55, 55)
    Private _SecondBorder As Color = Color.FromArgb(35, 35, 35)
    Private ThumbDown As Boolean = False
#End Region

#Region "Properties & Events"

    <Category("Colours")> _
    Public Property ThumbBorder As Color
        Get
            Return _ThumbBorder
        End Get
        Set(value As Color)
            _ThumbBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbColour As Color
        Get
            Return _ThumbColour
        End Get
        Set(value As Color)
            _ThumbColour = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property ThumbSecondBorder As Color
        Get
            Return _ThumbSecondBorder
        End Get
        Set(value As Color)
            _ThumbSecondBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property FirstBorder As Color
        Get
            Return _FirstBorder
        End Get
        Set(value As Color)
            _FirstBorder = value
        End Set
    End Property

    <Category("Colours")> _
    Public Property SecondBorder As Color
        Get
            Return _SecondBorder
        End Get
        Set(value As Color)
            _SecondBorder = value
        End Set
    End Property

    Event Scroll(ByVal sender As Object)

    Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value
            If value > _Value Then _Value = value
            If value > _Maximum Then _Maximum = value
            InvalidateLayout()
        End Set
    End Property

    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < _Value Then _Value = value
            If value < _Minimum Then _Minimum = value
        End Set
    End Property

    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < _Minimum
                    _Value = _Minimum
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            InvalidatePosition()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Is >
                    _SmallChange = value
            End Select
        End Set
    End Property

    Public Property LargeChange() As Integer
        Get
            Return _LargeChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Else
                    _LargeChange = value
            End Select
        End Set
    End Property

    Public Property ButtonSize As Integer
        Get
            Return _ButtonSize
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < 16
                    _ButtonSize = 16
                Case Else
                    _ButtonSize = value
            End Select
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        InvalidateLayout()
    End Sub

    Private Sub InvalidateLayout()
        LSA = New Rectangle(0, 1, 0, Height)
        Shaft = New Rectangle(LSA.Right + 1, 0, Width - 3, Height)
        ShowThumb = ((_Maximum - _Minimum))
        Thumb = New Rectangle(0, 1, _ThumbSize, Height - 3)
        RaiseEvent Scroll(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.X = CInt(((_Value - _Minimum) / (_Maximum - _Minimum)) * (Shaft.Width - _ThumbSize) + 1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ShowThumb Then
            If LSA.Contains(e.Location) Then
                ThumbMovement = _Value - _SmallChange
            ElseIf RSA.Contains(e.Location) Then
                ThumbMovement = _Value + _SmallChange
            Else
                If Thumb.Contains(e.Location) Then
                    ThumbDown = True
                    Return
                Else
                    If e.X < Thumb.X Then
                        ThumbMovement = _Value - _LargeChange
                    Else
                        ThumbMovement = _Value + _LargeChange
                    End If
                End If
            End If
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If ThumbDown AndAlso ShowThumb Then
            Dim ThumbPosition As Integer = e.X - LSA.Width - (_ThumbSize \ 2)
            Dim ThumbBounds As Integer = Shaft.Width - _ThumbSize

            ThumbMovement = CInt((ThumbPosition / ThumbBounds) * (_Maximum - _Minimum)) + _Minimum

            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ThumbDown = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                           ControlStyles.UserPaint Or ControlStyles.Selectable Or _
                           ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Height = 18
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Width)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.FromArgb(47, 47, 47))
            Dim P() As Point = {New Point(5, Height / 2), New Point(13, Height / 4), New Point(13, Height / 2 - 2), New Point(Width - 13, Height / 2 - 2), _
                    New Point(Width - 13, Height / 4), New Point(Width - 5, Height / 2), New Point(Width - 13, Height - Height / 4 - 1), New Point(Width - 13, Height / 2 + 2), _
                               New Point(13, Height / 2 + 2), New Point(13, Height - Height / 4 - 1)}
            .FillPolygon(New SolidBrush(_ArrowColour), P)
            .FillRectangle(New SolidBrush(_ThumbColour), Thumb)
            .DrawRectangle(New Pen(_ThumbBorder), Thumb)
            .DrawRectangle(New Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2)
            .DrawLine(New Pen((_LineColour), 2), New Point(Thumb.X + 4, (CInt(Thumb.Height / 2 + 1))), New Point(Thumb.Right - 4, (CInt(Thumb.Height / 2 + 1))))
            .DrawRectangle(New Pen(_FirstBorder), 0, 0, Width - 1, Height - 1)
            .DrawRectangle(New Pen(_SecondBorder), 1, 1, Width - 3, Height - 3)
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

#Region "Themebase"
'------------------
'Creator: aeonhack
'Site: elitevs.net
'Created: 08/02/2011
'Changed: 12/06/2011
'Version: 1.5.4
'------------------

MustInherit Class ThemeContainer154
    Inherits ContainerControl

#Region " Initialization "

    Protected G As Graphics, B As Bitmap

    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)

        _ImageSize = Size.Empty
        Font = New Font("Verdana", 8S)

        MeasureBitmap = New Bitmap(1, 1)
        MeasureGraphics = Graphics.FromImage(MeasureBitmap)

        DrawRadialPath = New GraphicsPath

        InvalidateCustimization()
    End Sub

    Protected NotOverridable Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        If DoneCreation Then InitializeMessages()

        InvalidateCustimization()
        ColorHook()

        If Not _LockWidth = 0 Then Width = _LockWidth
        If Not _LockHeight = 0 Then Height = _LockHeight
        If Not _ControlMode Then MyBase.Dock = DockStyle.Fill

        Transparent = _Transparent
        If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

        MyBase.OnHandleCreated(e)
    End Sub

    Private DoneCreation As Boolean
    Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
        MyBase.OnParentChanged(e)

        If Parent Is Nothing Then Return
        _IsParentForm = TypeOf Parent Is Form

        If Not _ControlMode Then
            InitializeMessages()

            If _IsParentForm Then
                ParentForm.FormBorderStyle = _BorderStyle
                ParentForm.TransparencyKey = _TransparencyKey

                If Not DesignMode Then
                    AddHandler ParentForm.Shown, AddressOf FormShown
                End If
            End If

            Parent.BackColor = BackColor
        End If

        OnCreation()
        DoneCreation = True
        InvalidateTimer()
    End Sub

#End Region

    Private Sub DoAnimation(ByVal i As Boolean)
        OnAnimation()
        If i Then Invalidate()
    End Sub

    Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Width = 0 OrElse Height = 0 Then Return

        If _Transparent AndAlso _ControlMode Then
            PaintHook()
            e.Graphics.DrawImage(B, 0, 0)
        Else
            G = e.Graphics
            PaintHook()
        End If
    End Sub

    Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
        RemoveAnimationCallback(AddressOf DoAnimation)
        MyBase.OnHandleDestroyed(e)
    End Sub

    Private HasShown As Boolean
    Private Sub FormShown(ByVal sender As Object, ByVal e As EventArgs)
        If _ControlMode OrElse HasShown Then Return

        If _StartPosition = FormStartPosition.CenterParent OrElse _StartPosition = FormStartPosition.CenterScreen Then
            Dim SB As Rectangle = Screen.PrimaryScreen.Bounds
            Dim CB As Rectangle = ParentForm.Bounds
            ParentForm.Location = New Point(SB.Width \ 2 - CB.Width \ 2, SB.Height \ 2 - CB.Width \ 2)
        End If

        HasShown = True
    End Sub


#Region " Size Handling "

    Private Frame As Rectangle
    Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If _Movable AndAlso Not _ControlMode Then
            Frame = New Rectangle(7, 7, Width - 14, _Header - 7)
        End If

        InvalidateBitmap()
        Invalidate()

        MyBase.OnSizeChanged(e)
    End Sub

    Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
        If Not _LockWidth = 0 Then width = _LockWidth
        If Not _LockHeight = 0 Then height = _LockHeight
        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

#End Region

#Region " State Handling "

    Protected State As MouseState
    Private Sub SetState(ByVal current As MouseState)
        State = current
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized) Then
            If _Sizable AndAlso Not _ControlMode Then InvalidateMouse()
        End If

        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        If Enabled Then SetState(MouseState.None) Else SetState(MouseState.Block)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        SetState(MouseState.Over)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        SetState(MouseState.Over)
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        SetState(MouseState.None)

        If GetChildAtPoint(PointToClient(MousePosition)) IsNot Nothing Then
            If _Sizable AndAlso Not _ControlMode Then
                Cursor = Cursors.Default
                Previous = 0
            End If
        End If

        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)

        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized OrElse _ControlMode) Then
            If _Movable AndAlso Frame.Contains(e.Location) Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(0))
            ElseIf _Sizable AndAlso Not Previous = 0 Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(Previous))
            End If
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Private WM_LMBUTTONDOWN As Boolean
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If WM_LMBUTTONDOWN AndAlso m.Msg = 513 Then
            WM_LMBUTTONDOWN = False

            SetState(MouseState.Over)
            If Not _SmartBounds Then Return

            If IsParentMdi Then
                CorrectBounds(New Rectangle(Point.Empty, Parent.Parent.Size))
            Else
                CorrectBounds(Screen.FromControl(Parent).WorkingArea)
            End If
        End If
    End Sub

    Private GetIndexPoint As Point
    Private B1, B2, B3, B4 As Boolean
    Private Function GetIndex() As Integer
        GetIndexPoint = PointToClient(MousePosition)
        B1 = GetIndexPoint.X < 7
        B2 = GetIndexPoint.X > Width - 7
        B3 = GetIndexPoint.Y < 7
        B4 = GetIndexPoint.Y > Height - 7

        If B1 AndAlso B3 Then Return 4
        If B1 AndAlso B4 Then Return 7
        If B2 AndAlso B3 Then Return 5
        If B2 AndAlso B4 Then Return 8
        If B1 Then Return 1
        If B2 Then Return 2
        If B3 Then Return 3
        If B4 Then Return 6
        Return 0
    End Function

    Private Current, Previous As Integer
    Private Sub InvalidateMouse()
        Current = GetIndex()
        If Current = Previous Then Return

        Previous = Current
        Select Case Previous
            Case 0
                Cursor = Cursors.Default
            Case 1, 2
                Cursor = Cursors.SizeWE
            Case 3, 6
                Cursor = Cursors.SizeNS
            Case 4, 8
                Cursor = Cursors.SizeNWSE
            Case 5, 7
                Cursor = Cursors.SizeNESW
        End Select
    End Sub

    Private Messages(8) As Message
    Private Sub InitializeMessages()
        Messages(0) = Message.Create(Parent.Handle, 161, New IntPtr(2), IntPtr.Zero)
        For I As Integer = 1 To 8
            Messages(I) = Message.Create(Parent.Handle, 161, New IntPtr(I + 9), IntPtr.Zero)
        Next
    End Sub

    Private Sub CorrectBounds(ByVal bounds As Rectangle)
        If Parent.Width > bounds.Width Then Parent.Width = bounds.Width
        If Parent.Height > bounds.Height Then Parent.Height = bounds.Height

        Dim X As Integer = Parent.Location.X
        Dim Y As Integer = Parent.Location.Y

        If X < bounds.X Then X = bounds.X
        If Y < bounds.Y Then Y = bounds.Y

        Dim Width As Integer = bounds.X + bounds.Width
        Dim Height As Integer = bounds.Y + bounds.Height

        If X + Parent.Width > Width Then X = Width - Parent.Width
        If Y + Parent.Height > Height Then Y = Height - Parent.Height

        Parent.Location = New Point(X, Y)
    End Sub

#End Region


#Region " Base Properties "

    Overrides Property Dock As DockStyle
        Get
            Return MyBase.Dock
        End Get
        Set(ByVal value As DockStyle)
            If Not _ControlMode Then Return
            MyBase.Dock = value
        End Set
    End Property

    Private _BackColor As Boolean
    <Category("Misc")> _
    Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            If value = MyBase.BackColor Then Return

            If Not IsHandleCreated AndAlso _ControlMode AndAlso value = Color.Transparent Then
                _BackColor = True
                Return
            End If

            MyBase.BackColor = value
            If Parent IsNot Nothing Then
                If Not _ControlMode Then Parent.BackColor = value
                ColorHook()
            End If
        End Set
    End Property

    Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(ByVal value As Size)
            MyBase.MinimumSize = value
            If Parent IsNot Nothing Then Parent.MinimumSize = value
        End Set
    End Property

    Overrides Property MaximumSize As Size
        Get
            Return MyBase.MaximumSize
        End Get
        Set(ByVal value As Size)
            MyBase.MaximumSize = value
            If Parent IsNot Nothing Then Parent.MaximumSize = value
        End Set
    End Property

    Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            Invalidate()
        End Set
    End Property

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property ForeColor() As Color
        Get
            Return Color.Empty
        End Get
        Set(ByVal value As Color)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImage() As Image
        Get
            Return Nothing
        End Get
        Set(ByVal value As Image)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImageLayout() As ImageLayout
        Get
            Return ImageLayout.None
        End Get
        Set(ByVal value As ImageLayout)
        End Set
    End Property

#End Region

#Region " Public Properties "

    Private _SmartBounds As Boolean = True
    Property SmartBounds() As Boolean
        Get
            Return _SmartBounds
        End Get
        Set(ByVal value As Boolean)
            _SmartBounds = value
        End Set
    End Property

    Private _Movable As Boolean = True
    Property Movable() As Boolean
        Get
            Return _Movable
        End Get
        Set(ByVal value As Boolean)
            _Movable = value
        End Set
    End Property

    Private _Sizable As Boolean = True
    Property Sizable() As Boolean
        Get
            Return _Sizable
        End Get
        Set(ByVal value As Boolean)
            _Sizable = value
        End Set
    End Property

    Private _TransparencyKey As Color
    Property TransparencyKey() As Color
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.TransparencyKey Else Return _TransparencyKey
        End Get
        Set(ByVal value As Color)
            If value = _TransparencyKey Then Return
            _TransparencyKey = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.TransparencyKey = value
                ColorHook()
            End If
        End Set
    End Property

    Private _BorderStyle As FormBorderStyle
    Property BorderStyle() As FormBorderStyle
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.FormBorderStyle Else Return _BorderStyle
        End Get
        Set(ByVal value As FormBorderStyle)
            _BorderStyle = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.FormBorderStyle = value

                If Not value = FormBorderStyle.None Then
                    Movable = False
                    Sizable = False
                End If
            End If
        End Set
    End Property

    Private _StartPosition As FormStartPosition
    Property StartPosition As FormStartPosition
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.StartPosition Else Return _StartPosition
        End Get
        Set(ByVal value As FormStartPosition)
            _StartPosition = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.StartPosition = value
            End If
        End Set
    End Property

    Private _NoRounding As Boolean
    Property NoRounding() As Boolean
        Get
            Return _NoRounding
        End Get
        Set(ByVal v As Boolean)
            _NoRounding = v
            Invalidate()
        End Set
    End Property

    Private _Image As Image
    Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            If value Is Nothing Then _ImageSize = Size.Empty Else _ImageSize = value.Size

            _Image = value
            Invalidate()
        End Set
    End Property

    Private Items As New Dictionary(Of String, Color)
    Property Colors() As Bloom()
        Get
            Dim T As New List(Of Bloom)
            Dim E As Dictionary(Of String, Color).Enumerator = Items.GetEnumerator

            While E.MoveNext
                T.Add(New Bloom(E.Current.Key, E.Current.Value))
            End While

            Return T.ToArray
        End Get
        Set(ByVal value As Bloom())
            For Each B As Bloom In value
                If Items.ContainsKey(B.Name) Then Items(B.Name) = B.Value
            Next

            InvalidateCustimization()
            ColorHook()
            Invalidate()
        End Set
    End Property

    Private _Customization As String
    Property Customization() As String
        Get
            Return _Customization
        End Get
        Set(ByVal value As String)
            If value = _Customization Then Return

            Dim Data As Byte()
            Dim Items As Bloom() = Colors

            Try
                Data = Convert.FromBase64String(value)
                For I As Integer = 0 To Items.Length - 1
                    Items(I).Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4))
                Next
            Catch
                Return
            End Try

            _Customization = value

            Colors = Items
            ColorHook()
            Invalidate()
        End Set
    End Property

    Private _Transparent As Boolean
    Property Transparent() As Boolean
        Get
            Return _Transparent
        End Get
        Set(ByVal value As Boolean)
            _Transparent = value
            If Not (IsHandleCreated OrElse _ControlMode) Then Return

            If Not value AndAlso Not BackColor.A = 255 Then
                Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
            End If

            SetStyle(ControlStyles.Opaque, Not value)
            SetStyle(ControlStyles.SupportsTransparentBackColor, value)

            InvalidateBitmap()
            Invalidate()
        End Set
    End Property

#End Region

#Region " Private Properties "

    Private _ImageSize As Size
    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Private _IsParentForm As Boolean
    Protected ReadOnly Property IsParentForm As Boolean
        Get
            Return _IsParentForm
        End Get
    End Property

    Protected ReadOnly Property IsParentMdi As Boolean
        Get
            If Parent Is Nothing Then Return False
            Return Parent.Parent IsNot Nothing
        End Get
    End Property

    Private _LockWidth As Integer
    Protected Property LockWidth() As Integer
        Get
            Return _LockWidth
        End Get
        Set(ByVal value As Integer)
            _LockWidth = value
            If Not LockWidth = 0 AndAlso IsHandleCreated Then Width = LockWidth
        End Set
    End Property

    Private _LockHeight As Integer
    Protected Property LockHeight() As Integer
        Get
            Return _LockHeight
        End Get
        Set(ByVal value As Integer)
            _LockHeight = value
            If Not LockHeight = 0 AndAlso IsHandleCreated Then Height = LockHeight
        End Set
    End Property

    Private _Header As Integer = 24
    Protected Property Header() As Integer
        Get
            Return _Header
        End Get
        Set(ByVal v As Integer)
            _Header = v

            If Not _ControlMode Then
                Frame = New Rectangle(7, 7, Width - 14, v - 7)
                Invalidate()
            End If
        End Set
    End Property

    Private _ControlMode As Boolean
    Protected Property ControlMode() As Boolean
        Get
            Return _ControlMode
        End Get
        Set(ByVal v As Boolean)
            _ControlMode = v

            Transparent = _Transparent
            If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

            InvalidateBitmap()
            Invalidate()
        End Set
    End Property

    Private _IsAnimated As Boolean
    Protected Property IsAnimated() As Boolean
        Get
            Return _IsAnimated
        End Get
        Set(ByVal value As Boolean)
            _IsAnimated = value
            InvalidateTimer()
        End Set
    End Property

#End Region


#Region " Property Helpers "

    Protected Function GetPen(ByVal name As String) As Pen
        Return New Pen(Items(name))
    End Function
    Protected Function GetPen(ByVal name As String, ByVal width As Single) As Pen
        Return New Pen(Items(name), width)
    End Function

    Protected Function GetBrush(ByVal name As String) As SolidBrush
        Return New SolidBrush(Items(name))
    End Function

    Protected Function GetColor(ByVal name As String) As Color
        Return Items(name)
    End Function

    Protected Sub SetColor(ByVal name As String, ByVal value As Color)
        If Items.ContainsKey(name) Then Items(name) = value Else Items.Add(name, value)
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(a, r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal value As Color)
        SetColor(name, Color.FromArgb(a, value))
    End Sub

    Private Sub InvalidateBitmap()
        If _Transparent AndAlso _ControlMode Then
            If Width = 0 OrElse Height = 0 Then Return
            B = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
            G = Graphics.FromImage(B)
        Else
            G = Nothing
            B = Nothing
        End If
    End Sub

    Private Sub InvalidateCustimization()
        Dim M As New MemoryStream(Items.Count * 4)

        For Each B As Bloom In Colors
            M.Write(BitConverter.GetBytes(B.Value.ToArgb), 0, 4)
        Next

        M.Close()
        _Customization = Convert.ToBase64String(M.ToArray)
    End Sub

    Private Sub InvalidateTimer()
        If DesignMode OrElse Not DoneCreation Then Return

        If _IsAnimated Then
            AddAnimationCallback(AddressOf DoAnimation)
        Else
            RemoveAnimationCallback(AddressOf DoAnimation)
        End If
    End Sub

#End Region


#Region " User Hooks "

    Protected MustOverride Sub ColorHook()
    Protected MustOverride Sub PaintHook()

    Protected Overridable Sub OnCreation()
    End Sub

    Protected Overridable Sub OnAnimation()
    End Sub

#End Region


#Region " Offset "

    Private OffsetReturnRectangle As Rectangle
    Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
        OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2))
        Return OffsetReturnRectangle
    End Function

    Private OffsetReturnSize As Size
    Protected Function Offset(ByVal s As Size, ByVal amount As Integer) As Size
        OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
        Return OffsetReturnSize
    End Function

    Private OffsetReturnPoint As Point
    Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
        OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
        Return OffsetReturnPoint
    End Function

#End Region

#Region " Center "

    Private CenterReturn As Point

    Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X + c.X, (p.Height \ 2 - c.Height \ 2) + p.Y + c.Y)
        Return CenterReturn
    End Function
    Protected Function Center(ByVal p As Rectangle, ByVal c As Size) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X, (p.Height \ 2 - c.Height \ 2) + p.Y)
        Return CenterReturn
    End Function

    Protected Function Center(ByVal child As Rectangle) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal child As Size) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As Point
        Return Center(Width, Height, childWidth, childHeight)
    End Function

    Protected Function Center(ByVal p As Size, ByVal c As Size) As Point
        Return Center(p.Width, p.Height, c.Width, c.Height)
    End Function

    Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
        CenterReturn = New Point(pWidth \ 2 - cWidth \ 2, pHeight \ 2 - cHeight \ 2)
        Return CenterReturn
    End Function

#End Region

#Region " Measure "

    Private MeasureBitmap As Bitmap
    Private MeasureGraphics As Graphics

    Protected Function Measure() As Size
        SyncLock MeasureGraphics
            Return MeasureGraphics.MeasureString(Text, Font, Width).ToSize
        End SyncLock
    End Function
    Protected Function Measure(ByVal text As String) As Size
        SyncLock MeasureGraphics
            Return MeasureGraphics.MeasureString(text, Font, Width).ToSize
        End SyncLock
    End Function

#End Region


#Region " DrawPixel "

    Private DrawPixelBrush As SolidBrush

    Protected Sub DrawPixel(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer)
        If _Transparent Then
            B.SetPixel(x, y, c1)
        Else
            DrawPixelBrush = New SolidBrush(c1)
            G.FillRectangle(DrawPixelBrush, x, y, 1, 1)
        End If
    End Sub

#End Region

#Region " DrawCorners "

    Private DrawCornersBrush As SolidBrush

    Protected Sub DrawCorners(ByVal c1 As Color, ByVal offset As Integer)
        DrawCorners(c1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle, ByVal offset As Integer)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawCorners(ByVal c1 As Color)
        DrawCorners(c1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        If _NoRounding Then Return

        If _Transparent Then
            B.SetPixel(x, y, c1)
            B.SetPixel(x + (width - 1), y, c1)
            B.SetPixel(x, y + (height - 1), c1)
            B.SetPixel(x + (width - 1), y + (height - 1), c1)
        Else
            DrawCornersBrush = New SolidBrush(c1)
            G.FillRectangle(DrawCornersBrush, x, y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
        End If
    End Sub

#End Region

#Region " DrawBorders "

    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal offset As Integer)
        DrawBorders(p1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle, ByVal offset As Integer)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawBorders(ByVal p1 As Pen)
        DrawBorders(p1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        G.DrawRectangle(p1, x, y, width - 1, height - 1)
    End Sub

#End Region

#Region " DrawText "

    Private DrawTextPoint As Point
    Private DrawTextSize As Size

    Protected Sub DrawText(ByVal b1 As Brush, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawText(b1, Text, a, x, y)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal text As String, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If text.Length = 0 Then Return

        DrawTextSize = Measure(text)
        DrawTextPoint = New Point(Width \ 2 - DrawTextSize.Width \ 2, Header \ 2 - DrawTextSize.Height \ 2)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Center
                G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Right
                G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y)
        End Select
    End Sub

    Protected Sub DrawText(ByVal b1 As Brush, ByVal p1 As Point)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, p1)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal x As Integer, ByVal y As Integer)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, x, y)
    End Sub

#End Region

#Region " DrawImage "

    Private DrawImagePoint As Point

    Protected Sub DrawImage(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, a, x, y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        DrawImagePoint = New Point(Width \ 2 - image.Width \ 2, Header \ 2 - image.Height \ 2)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Center
                G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Right
                G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height)
        End Select
    End Sub

    Protected Sub DrawImage(ByVal p1 As Point)
        DrawImage(_Image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, x, y)
    End Sub

    Protected Sub DrawImage(ByVal image As Image, ByVal p1 As Point)
        DrawImage(image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        G.DrawImage(image, x, y, image.Width, image.Height)
    End Sub

#End Region

#Region " DrawGradient "

    Private DrawGradientBrush As LinearGradientBrush
    Private DrawGradientRectangle As Rectangle

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub


    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub

#End Region

#Region " DrawRadial "

    Private DrawRadialPath As GraphicsPath
    Private DrawRadialBrush1 As PathGradientBrush
    Private DrawRadialBrush2 As LinearGradientBrush
    Private DrawRadialRectangle As Rectangle

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, width \ 2, height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal center As Point)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, cx, cy)
    End Sub

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawRadial(blend, r, r.Width \ 2, r.Height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal center As Point)
        DrawRadial(blend, r, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialPath.Reset()
        DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)

        DrawRadialBrush1 = New PathGradientBrush(DrawRadialPath)
        DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
        DrawRadialBrush1.InterpolationColors = blend

        If G.SmoothingMode = SmoothingMode.AntiAlias Then
            G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
        Else
            G.FillEllipse(DrawRadialBrush1, r)
        End If
    End Sub


    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawGradientRectangle)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
        G.FillEllipse(DrawGradientBrush, r)
    End Sub

#End Region

#Region " CreateRound "

    Private CreateRoundPath As GraphicsPath
    Private CreateRoundRectangle As Rectangle

    Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
        CreateRoundRectangle = New Rectangle(x, y, width, height)
        Return CreateRound(CreateRoundRectangle, slope)
    End Function

    Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
        CreateRoundPath = New GraphicsPath(FillMode.Winding)
        CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
        CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

#End Region

End Class

MustInherit Class ThemeControl154
    Inherits Control


#Region " Initialization "

    Protected G As Graphics, B As Bitmap

    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)

        _ImageSize = Size.Empty
        Font = New Font("Verdana", 8S)

        MeasureBitmap = New Bitmap(1, 1)
        MeasureGraphics = Graphics.FromImage(MeasureBitmap)

        DrawRadialPath = New GraphicsPath

        InvalidateCustimization() 'Remove?
    End Sub

    Protected NotOverridable Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        InvalidateCustimization()
        ColorHook()

        If Not _LockWidth = 0 Then Width = _LockWidth
        If Not _LockHeight = 0 Then Height = _LockHeight

        Transparent = _Transparent
        If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

        MyBase.OnHandleCreated(e)
    End Sub

    Private DoneCreation As Boolean
    Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
        If Parent IsNot Nothing Then
            OnCreation()
            DoneCreation = True
            InvalidateTimer()
        End If

        MyBase.OnParentChanged(e)
    End Sub

#End Region

    Private Sub DoAnimation(ByVal i As Boolean)
        OnAnimation()
        If i Then Invalidate()
    End Sub

    Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Width = 0 OrElse Height = 0 Then Return

        If _Transparent Then
            PaintHook()
            e.Graphics.DrawImage(B, 0, 0)
        Else
            G = e.Graphics
            PaintHook()
        End If
    End Sub

    Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
        RemoveAnimationCallback(AddressOf DoAnimation)
        MyBase.OnHandleDestroyed(e)
    End Sub

#Region " Size Handling "

    Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If _Transparent Then
            InvalidateBitmap()
        End If

        Invalidate()
        MyBase.OnSizeChanged(e)
    End Sub

    Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
        If Not _LockWidth = 0 Then width = _LockWidth
        If Not _LockHeight = 0 Then height = _LockHeight
        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

#End Region

#Region " State Handling "

    Private InPosition As Boolean
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        InPosition = True
        SetState(MouseState.Over)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        If InPosition Then SetState(MouseState.Over)
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        InPosition = False
        SetState(MouseState.None)
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        If Enabled Then SetState(MouseState.None) Else SetState(MouseState.Block)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected State As MouseState
    Private Sub SetState(ByVal current As MouseState)
        State = current
        Invalidate()
    End Sub

#End Region


#Region " Base Properties "

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property ForeColor() As Color
        Get
            Return Color.Empty
        End Get
        Set(ByVal value As Color)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImage() As Image
        Get
            Return Nothing
        End Get
        Set(ByVal value As Image)
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Overrides Property BackgroundImageLayout() As ImageLayout
        Get
            Return ImageLayout.None
        End Get
        Set(ByVal value As ImageLayout)
        End Set
    End Property

    Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property
    Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            Invalidate()
        End Set
    End Property

    Private _BackColor As Boolean
    <Category("Misc")> _
    Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            If Not IsHandleCreated AndAlso value = Color.Transparent Then
                _BackColor = True
                Return
            End If

            MyBase.BackColor = value
            If Parent IsNot Nothing Then ColorHook()
        End Set
    End Property

#End Region

#Region " Public Properties "

    Private _NoRounding As Boolean
    Property NoRounding() As Boolean
        Get
            Return _NoRounding
        End Get
        Set(ByVal v As Boolean)
            _NoRounding = v
            Invalidate()
        End Set
    End Property

    Private _Image As Image
    Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            If value Is Nothing Then
                _ImageSize = Size.Empty
            Else
                _ImageSize = value.Size
            End If

            _Image = value
            Invalidate()
        End Set
    End Property

    Private _Transparent As Boolean
    Property Transparent() As Boolean
        Get
            Return _Transparent
        End Get
        Set(ByVal value As Boolean)
            _Transparent = value
            If Not IsHandleCreated Then Return

            If Not value AndAlso Not BackColor.A = 255 Then
                Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
            End If

            SetStyle(ControlStyles.Opaque, Not value)
            SetStyle(ControlStyles.SupportsTransparentBackColor, value)

            If value Then InvalidateBitmap() Else B = Nothing
            Invalidate()
        End Set
    End Property

    Private Items As New Dictionary(Of String, Color)
    Property Colors() As Bloom()
        Get
            Dim T As New List(Of Bloom)
            Dim E As Dictionary(Of String, Color).Enumerator = Items.GetEnumerator

            While E.MoveNext
                T.Add(New Bloom(E.Current.Key, E.Current.Value))
            End While

            Return T.ToArray
        End Get
        Set(ByVal value As Bloom())
            For Each B As Bloom In value
                If Items.ContainsKey(B.Name) Then Items(B.Name) = B.Value
            Next

            InvalidateCustimization()
            ColorHook()
            Invalidate()
        End Set
    End Property

    Private _Customization As String
    Property Customization() As String
        Get
            Return _Customization
        End Get
        Set(ByVal value As String)
            If value = _Customization Then Return

            Dim Data As Byte()
            Dim Items As Bloom() = Colors

            Try
                Data = Convert.FromBase64String(value)
                For I As Integer = 0 To Items.Length - 1
                    Items(I).Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4))
                Next
            Catch
                Return
            End Try

            _Customization = value

            Colors = Items
            ColorHook()
            Invalidate()
        End Set
    End Property

#End Region

#Region " Private Properties "

    Private _ImageSize As Size
    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Private _LockWidth As Integer
    Protected Property LockWidth() As Integer
        Get
            Return _LockWidth
        End Get
        Set(ByVal value As Integer)
            _LockWidth = value
            If Not LockWidth = 0 AndAlso IsHandleCreated Then Width = LockWidth
        End Set
    End Property

    Private _LockHeight As Integer
    Protected Property LockHeight() As Integer
        Get
            Return _LockHeight
        End Get
        Set(ByVal value As Integer)
            _LockHeight = value
            If Not LockHeight = 0 AndAlso IsHandleCreated Then Height = LockHeight
        End Set
    End Property

    Private _IsAnimated As Boolean
    Protected Property IsAnimated() As Boolean
        Get
            Return _IsAnimated
        End Get
        Set(ByVal value As Boolean)
            _IsAnimated = value
            InvalidateTimer()
        End Set
    End Property

#End Region


#Region " Property Helpers "

    Protected Function GetPen(ByVal name As String) As Pen
        Return New Pen(Items(name))
    End Function
    Protected Function GetPen(ByVal name As String, ByVal width As Single) As Pen
        Return New Pen(Items(name), width)
    End Function

    Protected Function GetBrush(ByVal name As String) As SolidBrush
        Return New SolidBrush(Items(name))
    End Function

    Protected Function GetColor(ByVal name As String) As Color
        Return Items(name)
    End Function

    Protected Sub SetColor(ByVal name As String, ByVal value As Color)
        If Items.ContainsKey(name) Then Items(name) = value Else Items.Add(name, value)
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        SetColor(name, Color.FromArgb(a, r, g, b))
    End Sub
    Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal value As Color)
        SetColor(name, Color.FromArgb(a, value))
    End Sub

    Private Sub InvalidateBitmap()
        If Width = 0 OrElse Height = 0 Then Return
        B = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
        G = Graphics.FromImage(B)
    End Sub

    Private Sub InvalidateCustimization()
        Dim M As New MemoryStream(Items.Count * 4)

        For Each B As Bloom In Colors
            M.Write(BitConverter.GetBytes(B.Value.ToArgb), 0, 4)
        Next

        M.Close()
        _Customization = Convert.ToBase64String(M.ToArray)
    End Sub

    Private Sub InvalidateTimer()
        If DesignMode OrElse Not DoneCreation Then Return

        If _IsAnimated Then
            AddAnimationCallback(AddressOf DoAnimation)
        Else
            RemoveAnimationCallback(AddressOf DoAnimation)
        End If
    End Sub
#End Region


#Region " User Hooks "

    Protected MustOverride Sub ColorHook()
    Protected MustOverride Sub PaintHook()

    Protected Overridable Sub OnCreation()
    End Sub

    Protected Overridable Sub OnAnimation()
    End Sub

#End Region


#Region " Offset "

    Private OffsetReturnRectangle As Rectangle
    Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
        OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2))
        Return OffsetReturnRectangle
    End Function

    Private OffsetReturnSize As Size
    Protected Function Offset(ByVal s As Size, ByVal amount As Integer) As Size
        OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
        Return OffsetReturnSize
    End Function

    Private OffsetReturnPoint As Point
    Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
        OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
        Return OffsetReturnPoint
    End Function

#End Region

#Region " Center "

    Private CenterReturn As Point

    Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X + c.X, (p.Height \ 2 - c.Height \ 2) + p.Y + c.Y)
        Return CenterReturn
    End Function
    Protected Function Center(ByVal p As Rectangle, ByVal c As Size) As Point
        CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X, (p.Height \ 2 - c.Height \ 2) + p.Y)
        Return CenterReturn
    End Function

    Protected Function Center(ByVal child As Rectangle) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal child As Size) As Point
        Return Center(Width, Height, child.Width, child.Height)
    End Function
    Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As Point
        Return Center(Width, Height, childWidth, childHeight)
    End Function

    Protected Function Center(ByVal p As Size, ByVal c As Size) As Point
        Return Center(p.Width, p.Height, c.Width, c.Height)
    End Function

    Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
        CenterReturn = New Point(pWidth \ 2 - cWidth \ 2, pHeight \ 2 - cHeight \ 2)
        Return CenterReturn
    End Function

#End Region

#Region " Measure "

    Private MeasureBitmap As Bitmap
    Private MeasureGraphics As Graphics 'TODO: Potential issues during multi-threading.

    Protected Function Measure() As Size
        Return MeasureGraphics.MeasureString(Text, Font, Width).ToSize
    End Function
    Protected Function Measure(ByVal text As String) As Size
        Return MeasureGraphics.MeasureString(text, Font, Width).ToSize
    End Function

#End Region


#Region " DrawPixel "

    Private DrawPixelBrush As SolidBrush

    Protected Sub DrawPixel(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer)
        If _Transparent Then
            B.SetPixel(x, y, c1)
        Else
            DrawPixelBrush = New SolidBrush(c1)
            G.FillRectangle(DrawPixelBrush, x, y, 1, 1)
        End If
    End Sub

#End Region

#Region " DrawCorners "

    Private DrawCornersBrush As SolidBrush

    Protected Sub DrawCorners(ByVal c1 As Color, ByVal offset As Integer)
        DrawCorners(c1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle, ByVal offset As Integer)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawCorners(ByVal c1 As Color)
        DrawCorners(c1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle)
        DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
    End Sub
    Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        If _NoRounding Then Return

        If _Transparent Then
            B.SetPixel(x, y, c1)
            B.SetPixel(x + (width - 1), y, c1)
            B.SetPixel(x, y + (height - 1), c1)
            B.SetPixel(x + (width - 1), y + (height - 1), c1)
        Else
            DrawCornersBrush = New SolidBrush(c1)
            G.FillRectangle(DrawCornersBrush, x, y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1)
            G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1)
            G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
        End If
    End Sub

#End Region

#Region " DrawBorders "

    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal offset As Integer)
        DrawBorders(p1, 0, 0, Width, Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle, ByVal offset As Integer)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
        DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
    End Sub

    Protected Sub DrawBorders(ByVal p1 As Pen)
        DrawBorders(p1, 0, 0, Width, Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle)
        DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
    End Sub
    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        G.DrawRectangle(p1, x, y, width - 1, height - 1)
    End Sub

#End Region

#Region " DrawText "

    Private DrawTextPoint As Point
    Private DrawTextSize As Size

    Protected Sub DrawText(ByVal b1 As Brush, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawText(b1, Text, a, x, y)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal text As String, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If text.Length = 0 Then Return

        DrawTextSize = Measure(text)
        DrawTextPoint = Center(DrawTextSize)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Center
                G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y)
            Case HorizontalAlignment.Right
                G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y)
        End Select
    End Sub

    Protected Sub DrawText(ByVal b1 As Brush, ByVal p1 As Point)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, p1)
    End Sub
    Protected Sub DrawText(ByVal b1 As Brush, ByVal x As Integer, ByVal y As Integer)
        If Text.Length = 0 Then Return
        G.DrawString(Text, Font, b1, x, y)
    End Sub

#End Region

#Region " DrawImage "

    Private DrawImagePoint As Point

    Protected Sub DrawImage(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, a, x, y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        DrawImagePoint = Center(image.Size)

        Select Case a
            Case HorizontalAlignment.Left
                G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Center
                G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height)
            Case HorizontalAlignment.Right
                G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height)
        End Select
    End Sub

    Protected Sub DrawImage(ByVal p1 As Point)
        DrawImage(_Image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal x As Integer, ByVal y As Integer)
        DrawImage(_Image, x, y)
    End Sub

    Protected Sub DrawImage(ByVal image As Image, ByVal p1 As Point)
        DrawImage(image, p1.X, p1.Y)
    End Sub
    Protected Sub DrawImage(ByVal image As Image, ByVal x As Integer, ByVal y As Integer)
        If image Is Nothing Then Return
        G.DrawImage(image, x, y, image.Width, image.Height)
    End Sub

#End Region

#Region " DrawGradient "

    Private DrawGradientBrush As LinearGradientBrush
    Private DrawGradientRectangle As Rectangle

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(blend, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
        DrawGradientBrush.InterpolationColors = blend
        G.FillRectangle(DrawGradientBrush, r)
    End Sub


    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawGradientRectangle = New Rectangle(x, y, width, height)
        DrawGradient(c1, c2, DrawGradientRectangle, angle)
    End Sub

    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub
    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
        G.FillRectangle(DrawGradientBrush, r)
    End Sub

#End Region

#Region " DrawRadial "

    Private DrawRadialPath As GraphicsPath
    Private DrawRadialBrush1 As PathGradientBrush
    Private DrawRadialBrush2 As LinearGradientBrush
    Private DrawRadialRectangle As Rectangle

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, width \ 2, height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal center As Point)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(blend, DrawRadialRectangle, cx, cy)
    End Sub

    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle)
        DrawRadial(blend, r, r.Width \ 2, r.Height \ 2)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal center As Point)
        DrawRadial(blend, r, center.X, center.Y)
    End Sub
    Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal cx As Integer, ByVal cy As Integer)
        DrawRadialPath.Reset()
        DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)

        DrawRadialBrush1 = New PathGradientBrush(DrawRadialPath)
        DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
        DrawRadialBrush1.InterpolationColors = blend

        If G.SmoothingMode = SmoothingMode.AntiAlias Then
            G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
        Else
            G.FillEllipse(DrawRadialBrush1, r)
        End If
    End Sub


    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawRadialRectangle)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        DrawRadialRectangle = New Rectangle(x, y, width, height)
        DrawRadial(c1, c2, DrawRadialRectangle, angle)
    End Sub

    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
        G.FillEllipse(DrawRadialBrush2, r)
    End Sub
    Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
        DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
        G.FillEllipse(DrawRadialBrush2, r)
    End Sub

#End Region

#Region " CreateRound "

    Private CreateRoundPath As GraphicsPath
    Private CreateRoundRectangle As Rectangle

    Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
        CreateRoundRectangle = New Rectangle(x, y, width, height)
        Return CreateRound(CreateRoundRectangle, slope)
    End Function

    Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
        CreateRoundPath = New GraphicsPath(FillMode.Winding)
        CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
        CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
        CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

#End Region

End Class

Module ThemeShare

#Region " Animation "

    Private Frames As Integer
    Private Invalidate As Boolean
    Public ThemeTimer As New PrecisionTimer

    Private Const FPS As Integer = 50 '1000 / 50 = 20 FPS
    Private Const Rate As Integer = 10

    Public Delegate Sub AnimationDelegate(ByVal invalidate As Boolean)

    Private Callbacks As New List(Of AnimationDelegate)

    Private Sub HandleCallbacks(ByVal state As IntPtr, ByVal reserve As Boolean)
        Invalidate = (Frames >= FPS)
        If Invalidate Then Frames = 0

        SyncLock Callbacks
            For I As Integer = 0 To Callbacks.Count - 1
                Callbacks(I).Invoke(Invalidate)
            Next
        End SyncLock

        Frames += Rate
    End Sub

    Private Sub InvalidateThemeTimer()
        If Callbacks.Count = 0 Then
            ThemeTimer.Delete()
        Else
            ThemeTimer.Create(0, Rate, AddressOf HandleCallbacks)
        End If
    End Sub

    Sub AddAnimationCallback(ByVal callback As AnimationDelegate)
        SyncLock Callbacks
            If Callbacks.Contains(callback) Then Return

            Callbacks.Add(callback)
            InvalidateThemeTimer()
        End SyncLock
    End Sub

    Sub RemoveAnimationCallback(ByVal callback As AnimationDelegate)
        SyncLock Callbacks
            If Not Callbacks.Contains(callback) Then Return

            Callbacks.Remove(callback)
            InvalidateThemeTimer()
        End SyncLock
    End Sub

#End Region

End Module

Enum MouseState As Byte
    None = 0
    Over = 1
    Down = 2
    Block = 3
End Enum

Structure Bloom

    Public _Name As String
    ReadOnly Property Name() As String
        Get
            Return _Name
        End Get
    End Property

    Private _Value As Color
    Property Value() As Color
        Get
            Return _Value
        End Get
        Set(ByVal value As Color)
            _Value = value
        End Set
    End Property

    Property ValueHex() As String
        Get
            Return String.Concat("#", _
            _Value.R.ToString("X2", Nothing), _
            _Value.G.ToString("X2", Nothing), _
            _Value.B.ToString("X2", Nothing))
        End Get
        Set(ByVal value As String)
            Try
                _Value = ColorTranslator.FromHtml(value)
            Catch
                Return
            End Try
        End Set
    End Property


    Sub New(ByVal name As String, ByVal value As Color)
        _Name = name
        _Value = value
    End Sub
End Structure

'------------------
'Creator: aeonhack
'Site: **********
'Created: 11/30/2011
'Changed: 11/30/2011
'Version: 1.0.0
'------------------
Class PrecisionTimer
    Implements IDisposable

    Private _Enabled As Boolean
    ReadOnly Property Enabled() As Boolean
        Get
            Return _Enabled
        End Get
    End Property

    Private Handle As IntPtr
    Private TimerCallback As TimerDelegate

    <DllImport("kernel32.dll", EntryPoint:="CreateTimerQueueTimer")> _
    Private Shared Function CreateTimerQueueTimer( _
    ByRef handle As IntPtr, _
    ByVal queue As IntPtr, _
    ByVal callback As TimerDelegate, _
    ByVal state As IntPtr, _
    ByVal dueTime As UInteger, _
    ByVal period As UInteger, _
    ByVal flags As UInteger) As Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="DeleteTimerQueueTimer")> _
    Private Shared Function DeleteTimerQueueTimer( _
    ByVal queue As IntPtr, _
    ByVal handle As IntPtr, _
    ByVal callback As IntPtr) As Boolean
    End Function

    Delegate Sub TimerDelegate(ByVal r1 As IntPtr, ByVal r2 As Boolean)

    Sub Create(ByVal dueTime As UInteger, ByVal period As UInteger, ByVal callback As TimerDelegate)
        If _Enabled Then Return

        TimerCallback = callback
        Dim Success As Boolean = CreateTimerQueueTimer(Handle, IntPtr.Zero, TimerCallback, IntPtr.Zero, dueTime, period, 0)

        If Not Success Then ThrowNewException("CreateTimerQueueTimer")
        _Enabled = Success
    End Sub

    Sub Delete()
        If Not _Enabled Then Return
        Dim Success As Boolean = DeleteTimerQueueTimer(IntPtr.Zero, Handle, IntPtr.Zero)

        If Not Success AndAlso Not Marshal.GetLastWin32Error = 997 Then
            ThrowNewException("DeleteTimerQueueTimer")
        End If

        _Enabled = Not Success
    End Sub

    Private Sub ThrowNewException(ByVal name As String)
        Throw New Exception(String.Format("{0} failed. Win32Error: {1}", name, Marshal.GetLastWin32Error))
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Delete()
    End Sub
End Class
#End Region


Class EvolveControlBox
    Inherits ThemeControl154
    Private _Min As Boolean = True
    Private _Max As Boolean = True
    Private X As Integer

    Protected Overrides Sub ColorHook()
    End Sub

    Public Property MinButton As Boolean
        Get
            Return _Min
        End Get
        Set(value As Boolean)
            _Min = value
            Dim tempwidth As Integer = 40
            If _Min Then tempwidth += 25
            If _Max Then tempwidth += 25
            Me.Width = tempwidth + 1
            Me.Height = 16
            Invalidate()
        End Set
    End Property

    Public Property MaxButton As Boolean
        Get
            Return _Max
        End Get
        Set(value As Boolean)
            _Max = value
            Dim tempwidth As Integer = 40
            If _Min Then tempwidth += 25
            If _Max Then tempwidth += 25
            Me.Width = tempwidth + 1
            Me.Height = 16
            Invalidate()
        End Set
    End Property

    Sub New()
        Size = New Size(92, 16)
        Location = New Point(50, 2)
    End Sub

    Protected Overrides Sub OnMouseMove(e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As System.EventArgs)
        MyBase.OnClick(e)
        If _Min And _Max Then
            If X > 0 And X < 25 Then
                FindForm.WindowState = FormWindowState.Minimized
            ElseIf X > 25 And X < 50 Then
                If FindForm.WindowState = FormWindowState.Maximized Then FindForm.WindowState = FormWindowState.Normal Else FindForm.WindowState = FormWindowState.Maximized
            ElseIf X > 50 And X < 90 Then
                FindForm.Close()
            End If
        ElseIf _Min Then
            If X > 0 And X < 25 Then
                FindForm.WindowState = FormWindowState.Minimized
            ElseIf X > 25 And X < 65 Then
                FindForm.Close()
            End If
        ElseIf _Max Then
            If X > 0 And X < 25 Then
                If FindForm.WindowState = FormWindowState.Maximized Then FindForm.WindowState = FormWindowState.Normal Else FindForm.WindowState = FormWindowState.Maximized
            ElseIf X > 25 And X < 65 Then
                FindForm.Close()
            End If
        Else
            If X > 0 And X < 40 Then
                FindForm.Close()
            End If
        End If
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(47, 47, 47))
        Dim cblend As ColorBlend = New ColorBlend(2)
        cblend.Colors(0) = Color.FromArgb(66, 66, 66)
        cblend.Colors(1) = Color.FromArgb(50, 50, 50)
        cblend.Positions(0) = 0
        cblend.Positions(1) = 1
        DrawGradient(cblend, New Rectangle(New Point(0, 0), New Size(Me.Width, Me.Height)))

        If _Min And _Max Then
            If State = MouseState.Over Then
                If X > 0 And X < 25 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(1, 0), New Size(25, 15)))
                End If
                If X > 25 And X < 50 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(25, 0), New Size(25, 15)))
                End If
                If X > 50 And X < 90 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(50, 0), New Size(40, 15)))
                End If
            End If
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(0, 0), New Point(0, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(1, 15), New Point(89, 15))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(25, 0), New Point(25, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(50, 0), New Point(50, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(90, 0), New Point(90, 14))
            DrawPixel(Color.FromArgb(104, 104, 104), 1, 14)
            DrawPixel(Color.FromArgb(104, 104, 104), 89, 14)
            G.DrawString("r", New Font("Marlett", 8), Brushes.White, New Point(63, 2))
            If FindForm.WindowState = FormWindowState.Normal Then
                G.DrawString("1", New Font("Marlett", 8), Brushes.White, New Point(32, 2))
            Else
                G.DrawString("2", New Font("Marlett", 8), Brushes.White, New Point(32, 2))
            End If
            G.DrawString("0", New Font("Marlett", 8), Brushes.White, New Point(6, 2))
        ElseIf _Min Then
            If State = MouseState.Over Then
                If X > 0 And X < 25 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(1, 0), New Size(25, 15)))
                End If
                If X > 25 And X < 65 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(25, 0), New Size(40, 15)))
                End If
            End If
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(0, 0), New Point(0, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(25, 0), New Point(25, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(65, 0), New Point(65, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(1, 15), New Point(64, 15))
            DrawPixel(Color.FromArgb(104, 104, 104), 1, 14)
            DrawPixel(Color.FromArgb(104, 104, 104), 64, 14)
            G.DrawString("0", New Font("Marlett", 8), Brushes.White, New Point(6, 2))
            G.DrawString("r", New Font("Marlett", 8), Brushes.White, New Point(38, 2))
        ElseIf _Max Then
            If State = MouseState.Over Then
                If X > 0 And X < 25 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(1, 0), New Size(25, 15)))
                End If
                If X > 25 And X < 65 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(25, 0), New Size(40, 15)))
                End If
            End If
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(0, 0), New Point(0, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(25, 0), New Point(25, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(65, 0), New Point(65, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(1, 15), New Point(64, 15))
            DrawPixel(Color.FromArgb(104, 104, 104), 1, 14)
            DrawPixel(Color.FromArgb(104, 104, 104), 64, 14)
            If FindForm.WindowState = FormWindowState.Normal Then
                G.DrawString("1", New Font("Marlett", 8), Brushes.White, New Point(6, 2))
            Else
                G.DrawString("2", New Font("Marlett", 8), Brushes.White, New Point(6, 2))
            End If
            G.DrawString("r", New Font("Marlett", 8), Brushes.White, New Point(38, 2))
        Else
            If State = MouseState.Over Then
                If X > 0 And X < 40 Then
                    cblend = New ColorBlend(2)
                    cblend.Colors(0) = Color.FromArgb(80, 80, 80)
                    cblend.Colors(1) = Color.FromArgb(60, 60, 60)
                    cblend.Positions(0) = 0
                    cblend.Positions(1) = 1
                    DrawGradient(cblend, New Rectangle(New Point(1, 0), New Size(40, 15)))
                End If
            End If
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(0, 0), New Point(0, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(40, 0), New Point(40, 14))
            G.DrawLine(New Pen(Color.FromArgb(104, 104, 104)), New Point(1, 15), New Point(39, 15))
            DrawPixel(Color.FromArgb(104, 104, 104), 1, 14)
            DrawPixel(Color.FromArgb(104, 104, 104), 39, 14)
            G.DrawString("r", New Font("Marlett", 8), Brushes.White, New Point(13, 2))
        End If
    End Sub
End Class

Namespace Bonfire
    Module Drawing

        Public Function RoundRect(ByVal rect As Rectangle, ByVal slope As Integer) As GraphicsPath
            Dim gp As GraphicsPath = New GraphicsPath()
            Dim arcWidth As Integer = slope * 2
            gp.AddArc(New Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90)
            gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90)
            gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 0, 90)
            gp.AddArc(New Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90)
            gp.CloseAllFigures()
            Return gp
        End Function

    End Module

    Class BonfireButton
        Inherits Control

        Enum Style
            Blue
            Dark
            Light
            Red
            Green
        End Enum

        Private _style As Style
        Public Property ButtonStyle As Style
            Get
                Return _style
            End Get
            Set(ByVal value As Style)
                _style = value
                Invalidate()
            End Set
        End Property

        Private _image As Image
        Public Property Image As Image
            Get
                Return _image
            End Get
            Set(ByVal value As Image)
                _image = value
                Invalidate()
            End Set
        End Property

        Private _rounded As Boolean
        Public Property RoundedCorners As Boolean
            Get
                Return _rounded
            End Get
            Set(ByVal value As Boolean)
                _rounded = value
                Invalidate()
            End Set
        End Property

        Enum State
            None
            Over
            Down
        End Enum

        Private MouseState As State

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
            MouseState = State.None
            Size = New Size(65, 26)
            Font = New Font("Verdana", 8)
            Cursor = Cursors.Hand
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)

            Dim G As Graphics = e.Graphics

            G.Clear(Parent.BackColor)
            G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            Dim slope As Integer = 3

            Dim shadowRect As New Rectangle(0, 0, Width - 1, Height - 1)
            Dim shadowPath As GraphicsPath = RoundRect(shadowRect, slope)
            Dim mainRect As New Rectangle(0, 0, Width - 2, Height - 2)
            Select Case ButtonStyle
                Case Style.Blue
                    If _rounded Then
                        G.FillPath(New SolidBrush(Color.FromArgb(20, 135, 195)), shadowPath)
                        G.FillPath(New SolidBrush(Color.FromArgb(20, 160, 230)), RoundRect(mainRect, slope))
                    Else
                        G.FillRectangle(New SolidBrush(Color.FromArgb(20, 135, 195)), shadowRect)
                        G.FillRectangle(New SolidBrush(Color.FromArgb(20, 160, 230)), mainRect)
                    End If
                Case Style.Dark
                    If _rounded Then
                        G.FillPath(New SolidBrush(Color.FromArgb(45, 45, 45)), shadowPath)
                        G.FillPath(New SolidBrush(Color.FromArgb(75, 75, 75)), RoundRect(mainRect, slope))
                    Else
                        G.FillRectangle(New SolidBrush(Color.FromArgb(45, 45, 45)), shadowRect)
                        G.FillRectangle(New SolidBrush(Color.FromArgb(75, 75, 75)), mainRect)
                    End If
                Case Style.Light
                    If _rounded Then
                        G.FillPath(New SolidBrush(Color.FromArgb(145, 145, 145)), shadowPath)
                        G.FillPath(New SolidBrush(Color.FromArgb(170, 170, 170)), RoundRect(mainRect, slope))
                    Else
                        G.FillRectangle(New SolidBrush(Color.FromArgb(145, 145, 145)), shadowRect)
                        G.FillRectangle(New SolidBrush(Color.FromArgb(170, 170, 170)), mainRect)
                    End If
                Case Style.Red
                    If _rounded Then
                        G.FillPath(New SolidBrush(Color.Red), shadowPath)
                        G.FillPath(New SolidBrush(Color.FromArgb(255, 128, 128)), RoundRect(mainRect, slope))
                    Else
                        G.FillRectangle(New SolidBrush(Color.Red), shadowRect)
                        G.FillRectangle(New SolidBrush(Color.FromArgb(255, 128, 128)), mainRect)
                    End If
                Case Style.Green
                    If _rounded Then
                        G.FillPath(New SolidBrush(Color.FromArgb(0, 185, 0)), shadowPath)
                        G.FillPath(New SolidBrush(Color.FromArgb(0, 192, 0)), RoundRect(mainRect, slope))
                    Else
                        G.FillRectangle(New SolidBrush(Color.FromArgb(0, 185, 0)), shadowRect)
                        G.FillRectangle(New SolidBrush(Color.FromArgb(0, 192, 0)), mainRect)
                    End If
            End Select

            If _image Is Nothing Then
                Dim textX As Integer = ((Me.Width - 1) / 2) - (G.MeasureString(Text, Font).Width / 2)
                Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
                G.DrawString(Text, Font, Brushes.White, textX, textY)
            Else
                Dim textSize As Size = New Size(G.MeasureString(Text, Font).Width, G.MeasureString(Text, Font).Height)
                Dim imageWidth As Integer = Me.Height - 19, imageHeight As Integer = Me.Height - 19
                Dim imageX As Integer = ((Me.Width - 1) / 2) - ((imageWidth + 4 + textSize.Width) / 2)
                Dim imageY As Integer = ((Me.Height - 1) / 2) - (imageHeight / 2)
                G.DrawImage(_image, imageX, imageY, imageWidth, imageHeight)
                G.DrawString(Text, Font, Brushes.White, New Point(imageX + imageWidth + 4, ((Me.Height - 1) / 2) - textSize.Height / 2))
            End If

            If MouseState = State.Over Then
                G.FillPath(New SolidBrush(Color.FromArgb(25, Color.White)), shadowPath)
            ElseIf MouseState = State.Down Then
                G.FillPath(New SolidBrush(Color.FromArgb(40, Color.White)), shadowPath)
            End If

        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
            MyBase.OnMouseEnter(e)
            MouseState = State.Over
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
            MyBase.OnMouseLeave(e)
            MouseState = State.None
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseUp(e)
            MouseState = State.Over
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e)
            MouseState = State.Down
            Invalidate()
        End Sub
    End Class

    Class BonfireTabControl
        Inherits TabControl

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or
                 ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
            ItemSize = New Size(0, 30)
            Font = New Font("Verdana", 8)
        End Sub

        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()
            Alignment = TabAlignment.Top
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

            Dim G As Graphics = e.Graphics

            Dim borderPen As New Pen(Color.FromArgb(225, 225, 225))

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim fillRect As New Rectangle(2, ItemSize.Height + 2, Width - 6, Height - ItemSize.Height - 3)
            G.FillRectangle(Brushes.White, fillRect)
            G.DrawRectangle(borderPen, fillRect)

            Dim FontColor As New Color

            For i = 0 To TabCount - 1

                Dim mainRect As Rectangle = GetTabRect(i)

                If i = SelectedIndex Then

                    G.FillRectangle(New SolidBrush(Color.White), mainRect)
                    G.DrawRectangle(borderPen, mainRect)
                    G.DrawLine(New Pen(Color.FromArgb(20, 160, 230)), New Point(mainRect.X + 1, mainRect.Y), New Point(mainRect.X + mainRect.Width - 1, mainRect.Y))
                    G.DrawLine(Pens.White, New Point(mainRect.X + 1, mainRect.Y + mainRect.Height), New Point(mainRect.X + mainRect.Width - 1, mainRect.Y + mainRect.Height))
                    FontColor = Color.FromArgb(20, 160, 230)

                Else

                    G.FillRectangle(New SolidBrush(Color.FromArgb(245, 245, 245)), mainRect)
                    G.DrawRectangle(borderPen, mainRect)
                    FontColor = Color.FromArgb(160, 160, 160)

                End If

                Dim titleX As Integer = (mainRect.Location.X + mainRect.Width / 2) - (G.MeasureString(TabPages(i).Text, Font).Width / 2)
                Dim titleY As Integer = (mainRect.Location.Y + mainRect.Height / 2) - (G.MeasureString(TabPages(i).Text, Font).Height / 2)
                G.DrawString(TabPages(i).Text, Font, New SolidBrush(FontColor), New Point(titleX, titleY))

                Try : TabPages(i).BackColor = Color.White : Catch : End Try

            Next

        End Sub

    End Class

    Class BonfireGroupBox
        Inherits ContainerControl

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
            BackColor = Color.FromArgb(250, 250, 250)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)

            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(250, 250, 250)), mainRect)
            G.DrawRectangle(New Pen(Color.FromArgb(225, 225, 225)), mainRect)

        End Sub

    End Class

    Class BonfireLabelHeader
        Inherits Label

        Sub New()
            Font = New Font("Verdana", 10, FontStyle.Bold)
        End Sub

    End Class

    Class BonfireLabel
        Inherits Label

        Sub New()
            Font = New Font("Verdana", 8)
            ForeColor = Color.FromArgb(135, 135, 135)
        End Sub

    End Class

    Class BonfireProgressBar
        Inherits Control

        Private _Maximum As Integer = 100
        Public Property Maximum As Integer
            Get
                Return _Maximum
            End Get
            Set(ByVal v As Integer)
                If v < 1 Then v = 1
                If v < _Value Then _Value = v
                _Maximum = v
                Invalidate()
            End Set
        End Property

        Private _Value As Integer
        Public Property Value As Integer
            Get
                Return _Value
            End Get
            Set(ByVal v As Integer)
                If v > _Maximum Then v = Maximum
                _Value = v
                Invalidate()
            End Set
        End Property

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
            Size = New Size(100, 40)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)

            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(240, 240, 240)), mainRect)
            G.DrawLine(New Pen(Color.FromArgb(230, 230, 230)), New Point(mainRect.X, mainRect.Height), New Point(mainRect.Width, mainRect.Height))

            Dim barRect As New Rectangle(0, 0, CInt(((Width / _Maximum) * _Value) - 1), Height - 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(20, 160, 230)), barRect)
            If _Value > 1 Then G.DrawLine(New Pen(Color.FromArgb(20, 140, 200)), New Point(barRect.X, barRect.Height), New Point(barRect.Width, barRect.Height))

            Dim textX As Integer = 12
            Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
            Dim percent As Single = (_Value / _Maximum) * 100
            Dim txt As String = Text & " " & CStr(percent) & "%"
            G.DrawString(txt, Font, Brushes.White, New Point(textX, textY))

        End Sub

    End Class

    Class BonfireAlertBox
        Inherits Control

        Private exitLocation As Point
        Private overExit As Boolean

        Enum Style
            _Error
            _Success
            _Warning
            _Notice
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
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
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
                Case Style._Error
                    borderColor = Color.FromArgb(250, 195, 195)
                    innerColor = Color.FromArgb(255, 235, 235)
                    textColor = Color.FromArgb(220, 90, 90)
                Case Style._Notice
                    borderColor = Color.FromArgb(180, 215, 230)
                    innerColor = Color.FromArgb(235, 245, 255)
                    textColor = Color.FromArgb(80, 145, 180)
                Case Style._Success
                    borderColor = Color.FromArgb(180, 220, 130)
                    innerColor = Color.FromArgb(235, 245, 225)
                    textColor = Color.FromArgb(95, 145, 45)
                Case Style._Warning
                    borderColor = Color.FromArgb(220, 215, 140)
                    innerColor = Color.FromArgb(250, 250, 220)
                    textColor = Color.FromArgb(145, 135, 110)
            End Select

            Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
            G.FillRectangle(New SolidBrush(innerColor), mainRect)
            G.DrawRectangle(New Pen(borderColor), mainRect)

            Dim styleText As String = Nothing
            Select Case _alertStyle
                Case Style._Error
                    styleText = "Error!"
                Case Style._Notice
                    styleText = "Notice!"
                Case Style._Success
                    styleText = "Success!"
                Case Style._Warning
                    styleText = "Warning!"
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

    Class BonfireCombo
        Inherits ComboBox

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor, True)
            Font = New Font("Verdana", 8)
        End Sub

        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()

            DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            DropDownStyle = ComboBoxStyle.DropDownList
            DoubleBuffered = True
            ItemHeight = 20

        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)

            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
            G.FillRectangle(Brushes.White, mainRect)
            G.DrawRectangle(New Pen(Color.FromArgb(225, 225, 225)), mainRect)

            Dim triangle As Point() = New Point() {New Point(Width - 14, 16), New Point(Width - 18, 10), New Point(Width - 10, 10)}
            G.FillPolygon(Brushes.DarkGray, triangle)
            G.DrawLine(New Pen(Color.FromArgb(225, 225, 225)), New Point(Width - 27, 0), New Point(Width - 27, Height - 1))

            Try
                If Items.Count > 0 Then
                    If Not SelectedIndex = -1 Then
                        Dim textX As Integer = 6
                        Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Items(SelectedIndex), Font).Height / 2) + 1
                        G.DrawString(Items(SelectedIndex), Font, Brushes.Gray, New Point(textX, textY))
                    Else
                        Dim textX As Integer = 6
                        Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Items(0), Font).Height / 2) + 1
                        G.DrawString(Items(0), Font, Brushes.Gray, New Point(textX, textY))
                    End If
                End If
            Catch : End Try

        End Sub

        Sub replaceItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
            e.DrawBackground()

            Dim G As Graphics = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality

            Dim rect As New Rectangle(e.Bounds.X - 1, e.Bounds.Y - 1, e.Bounds.Width + 1, e.Bounds.Height + 1)

            Try
                If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(20, 160, 230)), rect)
                    G.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, Brushes.White, New Rectangle(e.Bounds.X + 6, e.Bounds.Y + 3, e.Bounds.Width, e.Bounds.Height))
                    G.DrawRectangle(New Pen(Color.FromArgb(20, 160, 230)), rect)
                Else
                    G.FillRectangle(Brushes.White, rect)
                    G.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, Brushes.DarkGray, New Rectangle(e.Bounds.X + 6, e.Bounds.Y + 3, e.Bounds.Width, e.Bounds.Height))
                    G.DrawRectangle(New Pen(Color.FromArgb(20, 160, 230)), rect)
                End If

            Catch : End Try

        End Sub

        Protected Overrides Sub OnSelectedItemChanged(ByVal e As System.EventArgs)
            MyBase.OnSelectedItemChanged(e)
            Invalidate()
        End Sub

    End Class

    <DefaultEvent("CheckedChanged")> Class BonfireCheckbox
        Inherits Control

        Event CheckedChanged(ByVal sender As Object)

        Private _checked As Boolean
        Public Property Checked() As Boolean
            Get
                Return _checked
            End Get
            Set(ByVal value As Boolean)
                _checked = value
                Invalidate()
            End Set
        End Property

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
            Size = New Size(140, 20)
            Font = New Font("Verdana", 8)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim box As New Rectangle(0, 0, Height, Height - 1)
            G.FillRectangle(Brushes.White, box)
            G.DrawRectangle(New Pen(Color.FromArgb(225, 225, 225)), box)

            Dim markPen As New Pen(Color.FromArgb(150, 155, 160))
            Dim lightMarkPen As New Pen(Color.FromArgb(170, 175, 180))
            If _checked Then G.DrawString("a", New Font("Marlett", 14), Brushes.Gray, New Point(0, 0))

            Dim textY As Integer = (Height / 2) - (G.MeasureString(Text, Font).Height / 2)
            G.DrawString(Text, Font, Brushes.Gray, New Point(24, textY))

        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e)

            If _checked Then
                _checked = False
            Else
                _checked = True
            End If

            RaiseEvent CheckedChanged(Me)
            Invalidate()

        End Sub

    End Class

    <DefaultEvent("CheckedChanged")> Class BonfireRadioButton
        Inherits Control

        Event CheckedChanged(ByVal sender As Object)

        Private _checked As Boolean
        Public Property Checked() As Boolean
            Get
                Return _checked
            End Get
            Set(ByVal value As Boolean)
                _checked = value
                Invalidate()
            End Set
        End Property

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
            Size = New Size(140, 20)
            Font = New Font("Verdana", 8)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim box As New Rectangle(0, 0, Height - 1, Height - 1)
            G.FillEllipse(Brushes.White, box)
            G.DrawEllipse(New Pen(Color.FromArgb(225, 225, 225)), box)

            If _checked Then
                Dim innerMark As New Rectangle(6, 6, Height - 13, Height - 13)
                G.FillEllipse(New SolidBrush(Color.FromArgb(20, 160, 230)), innerMark)
            End If

            Dim textY As Integer = (Height / 2) - (G.MeasureString(Text, Font).Height / 2)
            G.DrawString(Text, Font, Brushes.Gray, New Point(24, textY))

        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e)

            For Each C As Control In Parent.Controls
                If C IsNot Me AndAlso TypeOf C Is BonfireRadioButton Then
                    DirectCast(C, BonfireRadioButton).Checked = False
                End If
            Next

            If _checked Then
                _checked = False
            Else
                _checked = True
            End If

            RaiseEvent CheckedChanged(Me)
            Invalidate()

        End Sub

    End Class



End Namespace


Namespace Dialog
    '[INFO]
    'ThemeBase Creator: Aeonhack
    'Site: *********
    '[DATE]
    'Created: 08/02/2011
    'Changed: 12/06/2011
    '[VERSION]
    'ThemeBase Version: 1.5.4
    '
    '[INFO]
    'Theme Creator: Novi
    'Theme Name: CarbonOrainsTheme
    '[DATE]
    'Created: 7/14/2013
    'Changed: 7/26/2013
    'Released: 7/27/2013
    '[VERSION]
    'Version: 1.1
    '[CREDITS]
    'Thanks to Mavamaarten for the tut =))
    'Thanks to Aeonhack for the important ThemeBase154
    '--------[/CREDITS]------------
#Region "THEMEBASE"
    MustInherit Class ThemeContainer154
        Inherits ContainerControl

#Region " Initialization "

        Protected G As Graphics, B As Bitmap

        Sub New()
            SetStyle(DirectCast(139270, ControlStyles), True)

            _ImageSize = Size.Empty
            Font = New Font("Verdana", 8S)

            MeasureBitmap = New Bitmap(1, 1)
            MeasureGraphics = Graphics.FromImage(MeasureBitmap)

            DrawRadialPath = New GraphicsPath

            InvalidateCustimization()
        End Sub

        Protected NotOverridable Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            If DoneCreation Then InitializeMessages()

            InvalidateCustimization()
            ColorHook()

            If Not _LockWidth = 0 Then Width = _LockWidth
            If Not _LockHeight = 0 Then Height = _LockHeight
            If Not _ControlMode Then MyBase.Dock = DockStyle.Fill

            Transparent = _Transparent
            If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

            MyBase.OnHandleCreated(e)
        End Sub

        Private DoneCreation As Boolean
        Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
            MyBase.OnParentChanged(e)

            If Parent Is Nothing Then Return
            _IsParentForm = TypeOf Parent Is Form

            If Not _ControlMode Then
                InitializeMessages()

                If _IsParentForm Then
                    ParentForm.FormBorderStyle = _BorderStyle
                    ParentForm.TransparencyKey = _TransparencyKey

                    If Not DesignMode Then
                        AddHandler ParentForm.Shown, AddressOf FormShown
                    End If
                End If

                Parent.BackColor = BackColor
            End If

            OnCreation()
            DoneCreation = True
            InvalidateTimer()
        End Sub

#End Region

        Private Sub DoAnimation(ByVal i As Boolean)
            OnAnimation()
            If i Then Invalidate()
        End Sub

        Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            If Width = 0 OrElse Height = 0 Then Return

            If _Transparent AndAlso _ControlMode Then
                PaintHook()
                e.Graphics.DrawImage(B, 0, 0)
            Else
                G = e.Graphics
                PaintHook()
            End If
        End Sub

        Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
            RemoveAnimationCallback(AddressOf DoAnimation)
            MyBase.OnHandleDestroyed(e)
        End Sub

        Private HasShown As Boolean
        Private Sub FormShown(ByVal sender As Object, ByVal e As EventArgs)
            If _ControlMode OrElse HasShown Then Return

            If _StartPosition = FormStartPosition.CenterParent OrElse _StartPosition = FormStartPosition.CenterScreen Then
                Dim SB As Rectangle = Screen.PrimaryScreen.Bounds
                Dim CB As Rectangle = ParentForm.Bounds
                ParentForm.Location = New Point(SB.Width \ 2 - CB.Width \ 2, SB.Height \ 2 - CB.Width \ 2)
            End If

            HasShown = True
        End Sub


#Region " Size Handling "

        Private Frame As Rectangle
        Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            If _Movable AndAlso Not _ControlMode Then
                Frame = New Rectangle(7, 7, Width - 14, _Header - 7)
            End If

            InvalidateBitmap()
            Invalidate()

            MyBase.OnSizeChanged(e)
        End Sub

        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
            If Not _LockWidth = 0 Then width = _LockWidth
            If Not _LockHeight = 0 Then height = _LockHeight
            MyBase.SetBoundsCore(x, y, width, height, specified)
        End Sub

#End Region

#Region " State Handling "

        Protected State As MouseState
        Private Sub SetState(ByVal current As MouseState)
            State = current
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized) Then
                If _Sizable AndAlso Not _ControlMode Then InvalidateMouse()
            End If

            MyBase.OnMouseMove(e)
        End Sub

        Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
            If Enabled Then SetState(MouseState.None) Else SetState(MouseState.Block)
            MyBase.OnEnabledChanged(e)
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            SetState(MouseState.Over)
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            SetState(MouseState.Over)
            MyBase.OnMouseUp(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            SetState(MouseState.None)

            If GetChildAtPoint(PointToClient(MousePosition)) IsNot Nothing Then
                If _Sizable AndAlso Not _ControlMode Then
                    Cursor = Cursors.Default
                    Previous = 0
                End If
            End If

            MyBase.OnMouseLeave(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)

            If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized OrElse _ControlMode) Then
                If _Movable AndAlso Frame.Contains(e.Location) Then
                    Capture = False
                    WM_LMBUTTONDOWN = True
                    DefWndProc(Messages(0))
                ElseIf _Sizable AndAlso Not Previous = 0 Then
                    Capture = False
                    WM_LMBUTTONDOWN = True
                    DefWndProc(Messages(Previous))
                End If
            End If

            MyBase.OnMouseDown(e)
        End Sub

        Private WM_LMBUTTONDOWN As Boolean
        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)

            If WM_LMBUTTONDOWN AndAlso m.Msg = 513 Then
                WM_LMBUTTONDOWN = False

                SetState(MouseState.Over)
                If Not _SmartBounds Then Return

                If IsParentMdi Then
                    CorrectBounds(New Rectangle(Point.Empty, Parent.Parent.Size))
                Else
                    CorrectBounds(Screen.FromControl(Parent).WorkingArea)
                End If
            End If
        End Sub

        Private GetIndexPoint As Point
        Private B1, B2, B3, B4 As Boolean
        Private Function GetIndex() As Integer
            GetIndexPoint = PointToClient(MousePosition)
            B1 = GetIndexPoint.X < 7
            B2 = GetIndexPoint.X > Width - 7
            B3 = GetIndexPoint.Y < 7
            B4 = GetIndexPoint.Y > Height - 7

            If B1 AndAlso B3 Then Return 4
            If B1 AndAlso B4 Then Return 7
            If B2 AndAlso B3 Then Return 5
            If B2 AndAlso B4 Then Return 8
            If B1 Then Return 1
            If B2 Then Return 2
            If B3 Then Return 3
            If B4 Then Return 6
            Return 0
        End Function

        Private Current, Previous As Integer
        Private Sub InvalidateMouse()
            Current = GetIndex()
            If Current = Previous Then Return

            Previous = Current
            Select Case Previous
                Case 0
                    Cursor = Cursors.Default
                Case 1, 2
                    Cursor = Cursors.SizeWE
                Case 3, 6
                    Cursor = Cursors.SizeNS
                Case 4, 8
                    Cursor = Cursors.SizeNWSE
                Case 5, 7
                    Cursor = Cursors.SizeNESW
            End Select
        End Sub

        Private Messages(8) As Message
        Private Sub InitializeMessages()
            Messages(0) = Message.Create(Parent.Handle, 161, New IntPtr(2), IntPtr.Zero)
            For I As Integer = 1 To 8
                Messages(I) = Message.Create(Parent.Handle, 161, New IntPtr(I + 9), IntPtr.Zero)
            Next
        End Sub

        Private Sub CorrectBounds(ByVal bounds As Rectangle)
            If Parent.Width > bounds.Width Then Parent.Width = bounds.Width
            If Parent.Height > bounds.Height Then Parent.Height = bounds.Height

            Dim X As Integer = Parent.Location.X
            Dim Y As Integer = Parent.Location.Y

            If X < bounds.X Then X = bounds.X
            If Y < bounds.Y Then Y = bounds.Y

            Dim Width As Integer = bounds.X + bounds.Width
            Dim Height As Integer = bounds.Y + bounds.Height

            If X + Parent.Width > Width Then X = Width - Parent.Width
            If Y + Parent.Height > Height Then Y = Height - Parent.Height

            Parent.Location = New Point(X, Y)
        End Sub

#End Region


#Region " Base Properties "

        Overrides Property Dock() As DockStyle
            Get
                Return MyBase.Dock
            End Get
            Set(ByVal value As DockStyle)
                If Not _ControlMode Then Return
                MyBase.Dock = value
            End Set
        End Property

        Private _BackColor As Boolean
        <Category("Misc")>
        Overrides Property BackColor() As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(ByVal value As Color)
                If value = MyBase.BackColor Then Return

                If Not IsHandleCreated AndAlso _ControlMode AndAlso value = Color.Transparent Then
                    _BackColor = True
                    Return
                End If

                MyBase.BackColor = value
                If Parent IsNot Nothing Then
                    If Not _ControlMode Then Parent.BackColor = value
                    ColorHook()
                End If
            End Set
        End Property

        Overrides Property MinimumSize() As Size
            Get
                Return MyBase.MinimumSize
            End Get
            Set(ByVal value As Size)
                MyBase.MinimumSize = value
                If Parent IsNot Nothing Then Parent.MinimumSize = value
            End Set
        End Property

        Overrides Property MaximumSize() As Size
            Get
                Return MyBase.MaximumSize
            End Get
            Set(ByVal value As Size)
                MyBase.MaximumSize = value
                If Parent IsNot Nothing Then Parent.MaximumSize = value
            End Set
        End Property

        Overrides Property Text() As String
            Get
                Return MyBase.Text
            End Get
            Set(ByVal value As String)
                MyBase.Text = value
                Invalidate()
            End Set
        End Property

        Overrides Property Font() As Font
            Get
                Return MyBase.Font
            End Get
            Set(ByVal value As Font)
                MyBase.Font = value
                Invalidate()
            End Set
        End Property

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Overrides Property ForeColor() As Color
            Get
                Return Color.Empty
            End Get
            Set(ByVal value As Color)
            End Set
        End Property
        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Overrides Property BackgroundImage() As Image
            Get
                Return Nothing
            End Get
            Set(ByVal value As Image)
            End Set
        End Property
        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Overrides Property BackgroundImageLayout() As ImageLayout
            Get
                Return ImageLayout.None
            End Get
            Set(ByVal value As ImageLayout)
            End Set
        End Property

#End Region

#Region " Public Properties "

        Private _SmartBounds As Boolean = True
        Property SmartBounds() As Boolean
            Get
                Return _SmartBounds
            End Get
            Set(ByVal value As Boolean)
                _SmartBounds = value
            End Set
        End Property

        Private _Movable As Boolean = True
        Property Movable() As Boolean
            Get
                Return _Movable
            End Get
            Set(ByVal value As Boolean)
                _Movable = value
            End Set
        End Property

        Private _Sizable As Boolean = True
        Property Sizable() As Boolean
            Get
                Return _Sizable
            End Get
            Set(ByVal value As Boolean)
                _Sizable = value
            End Set
        End Property

        Private _TransparencyKey As Color
        Property TransparencyKey() As Color
            Get
                If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.TransparencyKey Else Return _TransparencyKey
            End Get
            Set(ByVal value As Color)
                If value = _TransparencyKey Then Return
                _TransparencyKey = value

                If _IsParentForm AndAlso Not _ControlMode Then
                    ParentForm.TransparencyKey = value
                    ColorHook()
                End If
            End Set
        End Property

        Private _BorderStyle As FormBorderStyle
        Property BorderStyle() As FormBorderStyle
            Get
                If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.FormBorderStyle Else Return _BorderStyle
            End Get
            Set(ByVal value As FormBorderStyle)
                _BorderStyle = value

                If _IsParentForm AndAlso Not _ControlMode Then
                    ParentForm.FormBorderStyle = value

                    If Not value = FormBorderStyle.None Then
                        Movable = False
                        Sizable = False
                    End If
                End If
            End Set
        End Property

        Private _StartPosition As FormStartPosition
        Property StartPosition() As FormStartPosition
            Get
                If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.StartPosition Else Return _StartPosition
            End Get
            Set(ByVal value As FormStartPosition)
                _StartPosition = value

                If _IsParentForm AndAlso Not _ControlMode Then
                    ParentForm.StartPosition = value
                End If
            End Set
        End Property

        Private _NoRounding As Boolean
        Property NoRounding() As Boolean
            Get
                Return _NoRounding
            End Get
            Set(ByVal v As Boolean)
                _NoRounding = v
                Invalidate()
            End Set
        End Property

        Private _Image As Image
        Property Image() As Image
            Get
                Return _Image
            End Get
            Set(ByVal value As Image)
                If value Is Nothing Then _ImageSize = Size.Empty Else _ImageSize = value.Size

                _Image = value
                Invalidate()
            End Set
        End Property

        Private Items As New Dictionary(Of String, Color)
        Property Colors() As Bloom()
            Get
                Dim T As New List(Of Bloom)
                Dim E As Dictionary(Of String, Color).Enumerator = Items.GetEnumerator

                While E.MoveNext
                    T.Add(New Bloom(E.Current.Key, E.Current.Value))
                End While

                Return T.ToArray
            End Get
            Set(ByVal value As Bloom())
                For Each B As Bloom In value
                    If Items.ContainsKey(B.Name) Then Items(B.Name) = B.Value
                Next

                InvalidateCustimization()
                ColorHook()
                Invalidate()
            End Set
        End Property

        Private _Customization As String
        Property Customization() As String
            Get
                Return _Customization
            End Get
            Set(ByVal value As String)
                If value = _Customization Then Return

                Dim Data As Byte()
                Dim Items As Bloom() = Colors

                Try
                    Data = Convert.FromBase64String(value)
                    For I As Integer = 0 To Items.Length - 1
                        Items(I).Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4))
                    Next
                Catch
                    Return
                End Try

                _Customization = value

                Colors = Items
                ColorHook()
                Invalidate()
            End Set
        End Property

        Private _Transparent As Boolean
        Property Transparent() As Boolean
            Get
                Return _Transparent
            End Get
            Set(ByVal value As Boolean)
                _Transparent = value
                If Not (IsHandleCreated OrElse _ControlMode) Then Return

                If Not value AndAlso Not BackColor.A = 255 Then
                    Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
                End If

                SetStyle(ControlStyles.Opaque, Not value)
                SetStyle(ControlStyles.SupportsTransparentBackColor, value)

                InvalidateBitmap()
                Invalidate()
            End Set
        End Property

#End Region

#Region " Private Properties "

        Private _ImageSize As Size
        Protected ReadOnly Property ImageSize() As Size
            Get
                Return _ImageSize
            End Get
        End Property

        Private _IsParentForm As Boolean
        Protected ReadOnly Property IsParentForm() As Boolean
            Get
                Return _IsParentForm
            End Get
        End Property

        Protected ReadOnly Property IsParentMdi() As Boolean
            Get
                If Parent Is Nothing Then Return False
                Return Parent.Parent IsNot Nothing
            End Get
        End Property

        Private _LockWidth As Integer
        Protected Property LockWidth() As Integer
            Get
                Return _LockWidth
            End Get
            Set(ByVal value As Integer)
                _LockWidth = value
                If Not LockWidth = 0 AndAlso IsHandleCreated Then Width = LockWidth
            End Set
        End Property

        Private _LockHeight As Integer
        Protected Property LockHeight() As Integer
            Get
                Return _LockHeight
            End Get
            Set(ByVal value As Integer)
                _LockHeight = value
                If Not LockHeight = 0 AndAlso IsHandleCreated Then Height = LockHeight
            End Set
        End Property

        Private _Header As Integer = 24
        Protected Property Header() As Integer
            Get
                Return _Header
            End Get
            Set(ByVal v As Integer)
                _Header = v

                If Not _ControlMode Then
                    Frame = New Rectangle(7, 7, Width - 14, v - 7)
                    Invalidate()
                End If
            End Set
        End Property

        Private _ControlMode As Boolean
        Protected Property ControlMode() As Boolean
            Get
                Return _ControlMode
            End Get
            Set(ByVal v As Boolean)
                _ControlMode = v

                Transparent = _Transparent
                If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

                InvalidateBitmap()
                Invalidate()
            End Set
        End Property

        Private _IsAnimated As Boolean
        Protected Property IsAnimated() As Boolean
            Get
                Return _IsAnimated
            End Get
            Set(ByVal value As Boolean)
                _IsAnimated = value
                InvalidateTimer()
            End Set
        End Property

#End Region


#Region " Property Helpers "

        Protected Function GetPen(ByVal name As String) As Pen
            Return New Pen(Items(name))
        End Function
        Protected Function GetPen(ByVal name As String, ByVal width As Single) As Pen
            Return New Pen(Items(name), width)
        End Function

        Protected Function GetBrush(ByVal name As String) As SolidBrush
            Return New SolidBrush(Items(name))
        End Function

        Protected Function GetColor(ByVal name As String) As Color
            Return Items(name)
        End Function

        Protected Sub SetColor(ByVal name As String, ByVal value As Color)
            If Items.ContainsKey(name) Then Items(name) = value Else Items.Add(name, value)
        End Sub
        Protected Sub SetColor(ByVal name As String, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
            SetColor(name, Color.FromArgb(r, g, b))
        End Sub
        Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
            SetColor(name, Color.FromArgb(a, r, g, b))
        End Sub
        Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal value As Color)
            SetColor(name, Color.FromArgb(a, value))
        End Sub

        Private Sub InvalidateBitmap()
            If _Transparent AndAlso _ControlMode Then
                If Width = 0 OrElse Height = 0 Then Return
                B = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
                G = Graphics.FromImage(B)
            Else
                G = Nothing
                B = Nothing
            End If
        End Sub

        Private Sub InvalidateCustimization()
            Dim M As New MemoryStream(Items.Count * 4)

            For Each B As Bloom In Colors
                M.Write(BitConverter.GetBytes(B.Value.ToArgb), 0, 4)
            Next

            M.Close()
            _Customization = Convert.ToBase64String(M.ToArray)
        End Sub

        Private Sub InvalidateTimer()
            If DesignMode OrElse Not DoneCreation Then Return

            If _IsAnimated Then
                AddAnimationCallback(AddressOf DoAnimation)
            Else
                RemoveAnimationCallback(AddressOf DoAnimation)
            End If
        End Sub

#End Region


#Region " User Hooks "

        Protected MustOverride Sub ColorHook()
        Protected MustOverride Sub PaintHook()

        Protected Overridable Sub OnCreation()
        End Sub

        Protected Overridable Sub OnAnimation()
        End Sub

#End Region


#Region " Offset "

        Private OffsetReturnRectangle As Rectangle
        Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
            OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2))
            Return OffsetReturnRectangle
        End Function

        Private OffsetReturnSize As Size
        Protected Function Offset(ByVal s As Size, ByVal amount As Integer) As Size
            OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
            Return OffsetReturnSize
        End Function

        Private OffsetReturnPoint As Point
        Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
            OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
            Return OffsetReturnPoint
        End Function

#End Region

#Region " Center "

        Private CenterReturn As Point

        Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
            CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X + c.X, (p.Height \ 2 - c.Height \ 2) + p.Y + c.Y)
            Return CenterReturn
        End Function
        Protected Function Center(ByVal p As Rectangle, ByVal c As Size) As Point
            CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X, (p.Height \ 2 - c.Height \ 2) + p.Y)
            Return CenterReturn
        End Function

        Protected Function Center(ByVal child As Rectangle) As Point
            Return Center(Width, Height, child.Width, child.Height)
        End Function
        Protected Function Center(ByVal child As Size) As Point
            Return Center(Width, Height, child.Width, child.Height)
        End Function
        Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As Point
            Return Center(Width, Height, childWidth, childHeight)
        End Function

        Protected Function Center(ByVal p As Size, ByVal c As Size) As Point
            Return Center(p.Width, p.Height, c.Width, c.Height)
        End Function

        Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
            CenterReturn = New Point(pWidth \ 2 - cWidth \ 2, pHeight \ 2 - cHeight \ 2)
            Return CenterReturn
        End Function

#End Region

#Region " Measure "

        Private MeasureBitmap As Bitmap
        Private MeasureGraphics As Graphics

        Protected Function Measure() As Size
            SyncLock MeasureGraphics
                Return MeasureGraphics.MeasureString(Text, Font, Width).ToSize
            End SyncLock
        End Function
        Protected Function Measure(ByVal text As String) As Size
            SyncLock MeasureGraphics
                Return MeasureGraphics.MeasureString(text, Font, Width).ToSize
            End SyncLock
        End Function

#End Region


#Region " DrawPixel "

        Private DrawPixelBrush As SolidBrush

        Protected Sub DrawPixel(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer)
            If _Transparent Then
                B.SetPixel(x, y, c1)
            Else
                DrawPixelBrush = New SolidBrush(c1)
                G.FillRectangle(DrawPixelBrush, x, y, 1, 1)
            End If
        End Sub

#End Region

#Region " DrawCorners "

        Private DrawCornersBrush As SolidBrush

        Protected Sub DrawCorners(ByVal c1 As Color, ByVal offset As Integer)
            DrawCorners(c1, 0, 0, Width, Height, offset)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle, ByVal offset As Integer)
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
            DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
        End Sub

        Protected Sub DrawCorners(ByVal c1 As Color)
            DrawCorners(c1, 0, 0, Width, Height)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle)
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            If _NoRounding Then Return

            If _Transparent Then
                B.SetPixel(x, y, c1)
                B.SetPixel(x + (width - 1), y, c1)
                B.SetPixel(x, y + (height - 1), c1)
                B.SetPixel(x + (width - 1), y + (height - 1), c1)
            Else
                DrawCornersBrush = New SolidBrush(c1)
                G.FillRectangle(DrawCornersBrush, x, y, 1, 1)
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1)
                G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1)
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
            End If
        End Sub

#End Region

#Region " DrawBorders "

        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal offset As Integer)
            DrawBorders(p1, 0, 0, Width, Height, offset)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle, ByVal offset As Integer)
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
        End Sub

        Protected Sub DrawBorders(ByVal p1 As Pen)
            DrawBorders(p1, 0, 0, Width, Height)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle)
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            G.DrawRectangle(p1, x, y, width - 1, height - 1)
        End Sub

#End Region

#Region " DrawText "

        Private DrawTextPoint As Point
        Private DrawTextSize As Size

        Protected Sub DrawText(ByVal b1 As Brush, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            DrawText(b1, Text, a, x, y)
        End Sub
        Protected Sub DrawText(ByVal b1 As Brush, ByVal text As String, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            If text.Length = 0 Then Return

            DrawTextSize = Measure(text)
            DrawTextPoint = New Point(Width \ 2 - DrawTextSize.Width \ 2, Header \ 2 - DrawTextSize.Height \ 2)

            Select Case a
                Case HorizontalAlignment.Left
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y)
                Case HorizontalAlignment.Center
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y)
                Case HorizontalAlignment.Right
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y)
            End Select
        End Sub

        Protected Sub DrawText(ByVal b1 As Brush, ByVal p1 As Point)
            If Text.Length = 0 Then Return
            G.DrawString(Text, Font, b1, p1)
        End Sub
        Protected Sub DrawText(ByVal b1 As Brush, ByVal x As Integer, ByVal y As Integer)
            If Text.Length = 0 Then Return
            G.DrawString(Text, Font, b1, x, y)
        End Sub

#End Region

#Region " DrawImage "

        Private DrawImagePoint As Point

        Protected Sub DrawImage(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            DrawImage(_Image, a, x, y)
        End Sub
        Protected Sub DrawImage(ByVal image As Image, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            If image Is Nothing Then Return
            DrawImagePoint = New Point(Width \ 2 - image.Width \ 2, Header \ 2 - image.Height \ 2)

            Select Case a
                Case HorizontalAlignment.Left
                    G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height)
                Case HorizontalAlignment.Center
                    G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height)
                Case HorizontalAlignment.Right
                    G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height)
            End Select
        End Sub

        Protected Sub DrawImage(ByVal p1 As Point)
            DrawImage(_Image, p1.X, p1.Y)
        End Sub
        Protected Sub DrawImage(ByVal x As Integer, ByVal y As Integer)
            DrawImage(_Image, x, y)
        End Sub

        Protected Sub DrawImage(ByVal image As Image, ByVal p1 As Point)
            DrawImage(image, p1.X, p1.Y)
        End Sub
        Protected Sub DrawImage(ByVal image As Image, ByVal x As Integer, ByVal y As Integer)
            If image Is Nothing Then Return
            G.DrawImage(image, x, y, image.Width, image.Height)
        End Sub

#End Region

#Region " DrawGradient "

        Private DrawGradientBrush As LinearGradientBrush
        Private DrawGradientRectangle As Rectangle

        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(blend, DrawGradientRectangle)
        End Sub
        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(blend, DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle)
            DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
            DrawGradientBrush.InterpolationColors = blend
            G.FillRectangle(DrawGradientBrush, r)
        End Sub
        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal angle As Single)
            DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
            DrawGradientBrush.InterpolationColors = blend
            G.FillRectangle(DrawGradientBrush, r)
        End Sub


        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(c1, c2, DrawGradientRectangle)
        End Sub
        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(c1, c2, DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
            DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
            G.FillRectangle(DrawGradientBrush, r)
        End Sub
        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
            DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
            G.FillRectangle(DrawGradientBrush, r)
        End Sub

#End Region

#Region " DrawRadial "

        Private DrawRadialPath As GraphicsPath
        Private DrawRadialBrush1 As PathGradientBrush
        Private DrawRadialBrush2 As LinearGradientBrush
        Private DrawRadialRectangle As Rectangle

        Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(blend, DrawRadialRectangle, width \ 2, height \ 2)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal center As Point)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(blend, DrawRadialRectangle, center.X, center.Y)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal cx As Integer, ByVal cy As Integer)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(blend, DrawRadialRectangle, cx, cy)
        End Sub

        Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle)
            DrawRadial(blend, r, r.Width \ 2, r.Height \ 2)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal center As Point)
            DrawRadial(blend, r, center.X, center.Y)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal cx As Integer, ByVal cy As Integer)
            DrawRadialPath.Reset()
            DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)

            DrawRadialBrush1 = New PathGradientBrush(DrawRadialPath)
            DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
            DrawRadialBrush1.InterpolationColors = blend

            If G.SmoothingMode = SmoothingMode.AntiAlias Then
                G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
            Else
                G.FillEllipse(DrawRadialBrush1, r)
            End If
        End Sub


        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(c1, c2, DrawGradientRectangle)
        End Sub
        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(c1, c2, DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
            DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
            G.FillRectangle(DrawGradientBrush, r)
        End Sub
        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
            DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
            G.FillEllipse(DrawGradientBrush, r)
        End Sub

#End Region

#Region " CreateRound "

        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function

#End Region

    End Class

    MustInherit Class ThemeControl154
        Inherits Control


#Region " Initialization "

        Protected G As Graphics, B As Bitmap

        Sub New()
            SetStyle(DirectCast(139270, ControlStyles), True)

            _ImageSize = Size.Empty
            Font = New Font("Verdana", 8S)

            MeasureBitmap = New Bitmap(1, 1)
            MeasureGraphics = Graphics.FromImage(MeasureBitmap)

            DrawRadialPath = New GraphicsPath

            InvalidateCustimization() 'Remove?
        End Sub

        Protected NotOverridable Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            InvalidateCustimization()
            ColorHook()

            If Not _LockWidth = 0 Then Width = _LockWidth
            If Not _LockHeight = 0 Then Height = _LockHeight

            Transparent = _Transparent
            If _Transparent AndAlso _BackColor Then BackColor = Color.Transparent

            MyBase.OnHandleCreated(e)
        End Sub

        Private DoneCreation As Boolean
        Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
            If Parent IsNot Nothing Then
                OnCreation()
                DoneCreation = True
                InvalidateTimer()
            End If

            MyBase.OnParentChanged(e)
        End Sub

#End Region

        Private Sub DoAnimation(ByVal i As Boolean)
            OnAnimation()
            If i Then Invalidate()
        End Sub

        Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            If Width = 0 OrElse Height = 0 Then Return

            If _Transparent Then
                PaintHook()
                e.Graphics.DrawImage(B, 0, 0)
            Else
                G = e.Graphics
                PaintHook()
            End If
        End Sub

        Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
            RemoveAnimationCallback(AddressOf DoAnimation)
            MyBase.OnHandleDestroyed(e)
        End Sub

#Region " Size Handling "

        Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            If _Transparent Then
                InvalidateBitmap()
            End If

            Invalidate()
            MyBase.OnSizeChanged(e)
        End Sub

        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
            If Not _LockWidth = 0 Then width = _LockWidth
            If Not _LockHeight = 0 Then height = _LockHeight
            MyBase.SetBoundsCore(x, y, width, height, specified)
        End Sub

#End Region

#Region " State Handling "

        Private InPosition As Boolean
        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            InPosition = True
            SetState(MouseState.Over)
            MyBase.OnMouseEnter(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            If InPosition Then SetState(MouseState.Over)
            MyBase.OnMouseUp(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            InPosition = False
            SetState(MouseState.None)
            MyBase.OnMouseLeave(e)
        End Sub

        Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
            If Enabled Then SetState(MouseState.None) Else SetState(MouseState.Block)
            MyBase.OnEnabledChanged(e)
        End Sub

        Protected State As MouseState
        Private Sub SetState(ByVal current As MouseState)
            State = current
            Invalidate()
        End Sub

#End Region


#Region " Base Properties "

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Overrides Property ForeColor() As Color
            Get
                Return Color.Empty
            End Get
            Set(ByVal value As Color)
            End Set
        End Property
        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Overrides Property BackgroundImage() As Image
            Get
                Return Nothing
            End Get
            Set(ByVal value As Image)
            End Set
        End Property
        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Overrides Property BackgroundImageLayout() As ImageLayout
            Get
                Return ImageLayout.None
            End Get
            Set(ByVal value As ImageLayout)
            End Set
        End Property

        Overrides Property Text() As String
            Get
                Return MyBase.Text
            End Get
            Set(ByVal value As String)
                MyBase.Text = value
                Invalidate()
            End Set
        End Property
        Overrides Property Font() As Font
            Get
                Return MyBase.Font
            End Get
            Set(ByVal value As Font)
                MyBase.Font = value
                Invalidate()
            End Set
        End Property

        Private _BackColor As Boolean
        <Category("Misc")>
        Overrides Property BackColor() As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(ByVal value As Color)
                If Not IsHandleCreated AndAlso value = Color.Transparent Then
                    _BackColor = True
                    Return
                End If

                MyBase.BackColor = value
                If Parent IsNot Nothing Then ColorHook()
            End Set
        End Property

#End Region

#Region " Public Properties "

        Private _NoRounding As Boolean
        Property NoRounding() As Boolean
            Get
                Return _NoRounding
            End Get
            Set(ByVal v As Boolean)
                _NoRounding = v
                Invalidate()
            End Set
        End Property

        Private _Image As Image
        Property Image() As Image
            Get
                Return _Image
            End Get
            Set(ByVal value As Image)
                If value Is Nothing Then
                    _ImageSize = Size.Empty
                Else
                    _ImageSize = value.Size
                End If

                _Image = value
                Invalidate()
            End Set
        End Property

        Private _Transparent As Boolean
        Property Transparent() As Boolean
            Get
                Return _Transparent
            End Get
            Set(ByVal value As Boolean)
                _Transparent = value
                If Not IsHandleCreated Then Return

                If Not value AndAlso Not BackColor.A = 255 Then
                    Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
                End If

                SetStyle(ControlStyles.Opaque, Not value)
                SetStyle(ControlStyles.SupportsTransparentBackColor, value)

                If value Then InvalidateBitmap() Else B = Nothing
                Invalidate()
            End Set
        End Property

        Private Items As New Dictionary(Of String, Color)
        Property Colors() As Bloom()
            Get
                Dim T As New List(Of Bloom)
                Dim E As Dictionary(Of String, Color).Enumerator = Items.GetEnumerator

                While E.MoveNext
                    T.Add(New Bloom(E.Current.Key, E.Current.Value))
                End While

                Return T.ToArray
            End Get
            Set(ByVal value As Bloom())
                For Each B As Bloom In value
                    If Items.ContainsKey(B.Name) Then Items(B.Name) = B.Value
                Next

                InvalidateCustimization()
                ColorHook()
                Invalidate()
            End Set
        End Property

        Private _Customization As String
        Property Customization() As String
            Get
                Return _Customization
            End Get
            Set(ByVal value As String)
                If value = _Customization Then Return

                Dim Data As Byte()
                Dim Items As Bloom() = Colors

                Try
                    Data = Convert.FromBase64String(value)
                    For I As Integer = 0 To Items.Length - 1
                        Items(I).Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4))
                    Next
                Catch
                    Return
                End Try

                _Customization = value

                Colors = Items
                ColorHook()
                Invalidate()
            End Set
        End Property

#End Region

#Region " Private Properties "

        Private _ImageSize As Size
        Protected ReadOnly Property ImageSize() As Size
            Get
                Return _ImageSize
            End Get
        End Property

        Private _LockWidth As Integer
        Protected Property LockWidth() As Integer
            Get
                Return _LockWidth
            End Get
            Set(ByVal value As Integer)
                _LockWidth = value
                If Not LockWidth = 0 AndAlso IsHandleCreated Then Width = LockWidth
            End Set
        End Property

        Private _LockHeight As Integer
        Protected Property LockHeight() As Integer
            Get
                Return _LockHeight
            End Get
            Set(ByVal value As Integer)
                _LockHeight = value
                If Not LockHeight = 0 AndAlso IsHandleCreated Then Height = LockHeight
            End Set
        End Property

        Private _IsAnimated As Boolean
        Protected Property IsAnimated() As Boolean
            Get
                Return _IsAnimated
            End Get
            Set(ByVal value As Boolean)
                _IsAnimated = value
                InvalidateTimer()
            End Set
        End Property

#End Region


#Region " Property Helpers "

        Protected Function GetPen(ByVal name As String) As Pen
            Return New Pen(Items(name))
        End Function
        Protected Function GetPen(ByVal name As String, ByVal width As Single) As Pen
            Return New Pen(Items(name), width)
        End Function

        Protected Function GetBrush(ByVal name As String) As SolidBrush
            Return New SolidBrush(Items(name))
        End Function

        Protected Function GetColor(ByVal name As String) As Color
            Return Items(name)
        End Function

        Protected Sub SetColor(ByVal name As String, ByVal value As Color)
            If Items.ContainsKey(name) Then Items(name) = value Else Items.Add(name, value)
        End Sub
        Protected Sub SetColor(ByVal name As String, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
            SetColor(name, Color.FromArgb(r, g, b))
        End Sub
        Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
            SetColor(name, Color.FromArgb(a, r, g, b))
        End Sub
        Protected Sub SetColor(ByVal name As String, ByVal a As Byte, ByVal value As Color)
            SetColor(name, Color.FromArgb(a, value))
        End Sub

        Private Sub InvalidateBitmap()
            If Width = 0 OrElse Height = 0 Then Return
            B = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
            G = Graphics.FromImage(B)
        End Sub

        Private Sub InvalidateCustimization()
            Dim M As New MemoryStream(Items.Count * 4)

            For Each B As Bloom In Colors
                M.Write(BitConverter.GetBytes(B.Value.ToArgb), 0, 4)
            Next

            M.Close()
            _Customization = Convert.ToBase64String(M.ToArray)
        End Sub

        Private Sub InvalidateTimer()
            If DesignMode OrElse Not DoneCreation Then Return

            If _IsAnimated Then
                AddAnimationCallback(AddressOf DoAnimation)
            Else
                RemoveAnimationCallback(AddressOf DoAnimation)
            End If
        End Sub
#End Region


#Region " User Hooks "

        Protected MustOverride Sub ColorHook()
        Protected MustOverride Sub PaintHook()

        Protected Overridable Sub OnCreation()
        End Sub

        Protected Overridable Sub OnAnimation()
        End Sub

#End Region


#Region " Offset "

        Private OffsetReturnRectangle As Rectangle
        Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
            OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2))
            Return OffsetReturnRectangle
        End Function

        Private OffsetReturnSize As Size
        Protected Function Offset(ByVal s As Size, ByVal amount As Integer) As Size
            OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
            Return OffsetReturnSize
        End Function

        Private OffsetReturnPoint As Point
        Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
            OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
            Return OffsetReturnPoint
        End Function

#End Region

#Region " Center "

        Private CenterReturn As Point

        Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
            CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X + c.X, (p.Height \ 2 - c.Height \ 2) + p.Y + c.Y)
            Return CenterReturn
        End Function
        Protected Function Center(ByVal p As Rectangle, ByVal c As Size) As Point
            CenterReturn = New Point((p.Width \ 2 - c.Width \ 2) + p.X, (p.Height \ 2 - c.Height \ 2) + p.Y)
            Return CenterReturn
        End Function

        Protected Function Center(ByVal child As Rectangle) As Point
            Return Center(Width, Height, child.Width, child.Height)
        End Function
        Protected Function Center(ByVal child As Size) As Point
            Return Center(Width, Height, child.Width, child.Height)
        End Function
        Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As Point
            Return Center(Width, Height, childWidth, childHeight)
        End Function

        Protected Function Center(ByVal p As Size, ByVal c As Size) As Point
            Return Center(p.Width, p.Height, c.Width, c.Height)
        End Function

        Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
            CenterReturn = New Point(pWidth \ 2 - cWidth \ 2, pHeight \ 2 - cHeight \ 2)
            Return CenterReturn
        End Function

#End Region

#Region " Measure "

        Private MeasureBitmap As Bitmap
        Private MeasureGraphics As Graphics 'TODO: Potential issues during multi-threading.

        Protected Function Measure() As Size
            Return MeasureGraphics.MeasureString(Text, Font, Width).ToSize
        End Function
        Protected Function Measure(ByVal text As String) As Size
            Return MeasureGraphics.MeasureString(text, Font, Width).ToSize
        End Function

#End Region


#Region " DrawPixel "

        Private DrawPixelBrush As SolidBrush

        Protected Sub DrawPixel(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer)
            If _Transparent Then
                B.SetPixel(x, y, c1)
            Else
                DrawPixelBrush = New SolidBrush(c1)
                G.FillRectangle(DrawPixelBrush, x, y, 1, 1)
            End If
        End Sub

#End Region

#Region " DrawCorners "

        Private DrawCornersBrush As SolidBrush

        Protected Sub DrawCorners(ByVal c1 As Color, ByVal offset As Integer)
            DrawCorners(c1, 0, 0, Width, Height, offset)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle, ByVal offset As Integer)
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
            DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
        End Sub

        Protected Sub DrawCorners(ByVal c1 As Color)
            DrawCorners(c1, 0, 0, Width, Height)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal r1 As Rectangle)
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
        End Sub
        Protected Sub DrawCorners(ByVal c1 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            If _NoRounding Then Return

            If _Transparent Then
                B.SetPixel(x, y, c1)
                B.SetPixel(x + (width - 1), y, c1)
                B.SetPixel(x, y + (height - 1), c1)
                B.SetPixel(x + (width - 1), y + (height - 1), c1)
            Else
                DrawCornersBrush = New SolidBrush(c1)
                G.FillRectangle(DrawCornersBrush, x, y, 1, 1)
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1)
                G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1)
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
            End If
        End Sub

#End Region

#Region " DrawBorders "

        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal offset As Integer)
            DrawBorders(p1, 0, 0, Width, Height, offset)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle, ByVal offset As Integer)
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal offset As Integer)
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2))
        End Sub

        Protected Sub DrawBorders(ByVal p1 As Pen)
            DrawBorders(p1, 0, 0, Width, Height)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal r As Rectangle)
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
        End Sub
        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            G.DrawRectangle(p1, x, y, width - 1, height - 1)
        End Sub

#End Region

#Region " DrawText "

        Private DrawTextPoint As Point
        Private DrawTextSize As Size

        Protected Sub DrawText(ByVal b1 As Brush, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            DrawText(b1, Text, a, x, y)
        End Sub
        Protected Sub DrawText(ByVal b1 As Brush, ByVal text As String, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            If text.Length = 0 Then Return

            DrawTextSize = Measure(text)
            DrawTextPoint = Center(DrawTextSize)

            Select Case a
                Case HorizontalAlignment.Left
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y)
                Case HorizontalAlignment.Center
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y)
                Case HorizontalAlignment.Right
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y)
            End Select
        End Sub

        Protected Sub DrawText(ByVal b1 As Brush, ByVal p1 As Point)
            If Text.Length = 0 Then Return
            G.DrawString(Text, Font, b1, p1)
        End Sub
        Protected Sub DrawText(ByVal b1 As Brush, ByVal x As Integer, ByVal y As Integer)
            If Text.Length = 0 Then Return
            G.DrawString(Text, Font, b1, x, y)
        End Sub

#End Region

#Region " DrawImage "

        Private DrawImagePoint As Point

        Protected Sub DrawImage(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            DrawImage(_Image, a, x, y)
        End Sub
        Protected Sub DrawImage(ByVal image As Image, ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
            If image Is Nothing Then Return
            DrawImagePoint = Center(image.Size)

            Select Case a
                Case HorizontalAlignment.Left
                    G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height)
                Case HorizontalAlignment.Center
                    G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height)
                Case HorizontalAlignment.Right
                    G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height)
            End Select
        End Sub

        Protected Sub DrawImage(ByVal p1 As Point)
            DrawImage(_Image, p1.X, p1.Y)
        End Sub
        Protected Sub DrawImage(ByVal x As Integer, ByVal y As Integer)
            DrawImage(_Image, x, y)
        End Sub

        Protected Sub DrawImage(ByVal image As Image, ByVal p1 As Point)
            DrawImage(image, p1.X, p1.Y)
        End Sub
        Protected Sub DrawImage(ByVal image As Image, ByVal x As Integer, ByVal y As Integer)
            If image Is Nothing Then Return
            G.DrawImage(image, x, y, image.Width, image.Height)
        End Sub

#End Region

#Region " DrawGradient "

        Private DrawGradientBrush As LinearGradientBrush
        Private DrawGradientRectangle As Rectangle

        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(blend, DrawGradientRectangle)
        End Sub
        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(blend, DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle)
            DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
            DrawGradientBrush.InterpolationColors = blend
            G.FillRectangle(DrawGradientBrush, r)
        End Sub
        Protected Sub DrawGradient(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal angle As Single)
            DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
            DrawGradientBrush.InterpolationColors = blend
            G.FillRectangle(DrawGradientBrush, r)
        End Sub


        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(c1, c2, DrawGradientRectangle)
        End Sub
        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            DrawGradientRectangle = New Rectangle(x, y, width, height)
            DrawGradient(c1, c2, DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
            DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
            G.FillRectangle(DrawGradientBrush, r)
        End Sub
        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
            DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
            G.FillRectangle(DrawGradientBrush, r)
        End Sub

#End Region

#Region " DrawRadial "

        Private DrawRadialPath As GraphicsPath
        Private DrawRadialBrush1 As PathGradientBrush
        Private DrawRadialBrush2 As LinearGradientBrush
        Private DrawRadialRectangle As Rectangle

        Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(blend, DrawRadialRectangle, width \ 2, height \ 2)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal center As Point)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(blend, DrawRadialRectangle, center.X, center.Y)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal cx As Integer, ByVal cy As Integer)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(blend, DrawRadialRectangle, cx, cy)
        End Sub

        Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle)
            DrawRadial(blend, r, r.Width \ 2, r.Height \ 2)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal center As Point)
            DrawRadial(blend, r, center.X, center.Y)
        End Sub
        Sub DrawRadial(ByVal blend As ColorBlend, ByVal r As Rectangle, ByVal cx As Integer, ByVal cy As Integer)
            DrawRadialPath.Reset()
            DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)

            DrawRadialBrush1 = New PathGradientBrush(DrawRadialPath)
            DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
            DrawRadialBrush1.InterpolationColors = blend

            If G.SmoothingMode = SmoothingMode.AntiAlias Then
                G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
            Else
                G.FillEllipse(DrawRadialBrush1, r)
            End If
        End Sub


        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(c1, c2, DrawRadialRectangle)
        End Sub
        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            DrawRadialRectangle = New Rectangle(x, y, width, height)
            DrawRadial(c1, c2, DrawRadialRectangle, angle)
        End Sub

        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle)
            DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
            G.FillEllipse(DrawRadialBrush2, r)
        End Sub
        Protected Sub DrawRadial(ByVal c1 As Color, ByVal c2 As Color, ByVal r As Rectangle, ByVal angle As Single)
            DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
            G.FillEllipse(DrawRadialBrush2, r)
        End Sub

#End Region

#Region " CreateRound "

        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function

#End Region

    End Class

    Module ThemeShare

#Region " Animation "

        Private Frames As Integer
        Private Invalidate As Boolean
        Public ThemeTimer As New PrecisionTimer

        Public FPS As Integer = 20 '1000 / 50 = 20 FPS
        Public Rate As Integer = 50

        Public Delegate Sub AnimationDelegate(ByVal invalidate As Boolean)

        Private Callbacks As New List(Of AnimationDelegate)

        Private Sub HandleCallbacks(ByVal state As IntPtr, ByVal reserve As Boolean)
            Invalidate = (Frames >= FPS)
            If Invalidate Then Frames = 0

            SyncLock Callbacks
                For I As Integer = 0 To Callbacks.Count - 1
                    Callbacks(I).Invoke(Invalidate)
                Next
            End SyncLock

            Frames += Rate
        End Sub

        Private Sub InvalidateThemeTimer()
            If Callbacks.Count = 0 Then
                ThemeTimer.Delete()
            Else
                ThemeTimer.Create(0, Rate, AddressOf HandleCallbacks)
            End If
        End Sub

        Sub AddAnimationCallback(ByVal callback As AnimationDelegate)
            SyncLock Callbacks
                If Callbacks.Contains(callback) Then Return

                Callbacks.Add(callback)
                InvalidateThemeTimer()
            End SyncLock
        End Sub

        Sub RemoveAnimationCallback(ByVal callback As AnimationDelegate)
            SyncLock Callbacks
                If Not Callbacks.Contains(callback) Then Return

                Callbacks.Remove(callback)
                InvalidateThemeTimer()
            End SyncLock
        End Sub

#End Region

    End Module

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

    Structure Bloom

        Public _Name As String
        ReadOnly Property Name() As String
            Get
                Return _Name
            End Get
        End Property

        Private _Value As Color
        Property Value() As Color
            Get
                Return _Value
            End Get
            Set(ByVal value As Color)
                _Value = value
            End Set
        End Property

        Property ValueHex() As String
            Get
                Return String.Concat("#",
                _Value.R.ToString("X2", Nothing),
                _Value.G.ToString("X2", Nothing),
                _Value.B.ToString("X2", Nothing))
            End Get
            Set(ByVal value As String)
                Try
                    _Value = ColorTranslator.FromHtml(value)
                Catch
                    Return
                End Try
            End Set
        End Property


        Sub New(ByVal name As String, ByVal value As Color)
            _Name = name
            _Value = value
        End Sub
    End Structure

    '------------------
    'Creator: aeonhack
    'Site: elitevs.net
    'Created: 11/30/2011
    'Changed: 11/30/2011
    'Version: 1.0.0
    '------------------
    Class PrecisionTimer
        Implements IDisposable

        Private _Enabled As Boolean
        ReadOnly Property Enabled() As Boolean
            Get
                Return _Enabled
            End Get
        End Property

        Private Handle As IntPtr
        Private TimerCallback As TimerDelegate

        <DllImport("kernel32.dll", EntryPoint:="CreateTimerQueueTimer")>
        Private Shared Function CreateTimerQueueTimer(
        ByRef handle As IntPtr,
        ByVal queue As IntPtr,
        ByVal callback As TimerDelegate,
        ByVal state As IntPtr,
        ByVal dueTime As UInteger,
        ByVal period As UInteger,
        ByVal flags As UInteger) As Boolean
        End Function

        <DllImport("kernel32.dll", EntryPoint:="DeleteTimerQueueTimer")>
        Private Shared Function DeleteTimerQueueTimer(
        ByVal queue As IntPtr,
        ByVal handle As IntPtr,
        ByVal callback As IntPtr) As Boolean
        End Function

        Delegate Sub TimerDelegate(ByVal r1 As IntPtr, ByVal r2 As Boolean)

        Sub Create(ByVal dueTime As UInteger, ByVal period As UInteger, ByVal callback As TimerDelegate)
            If _Enabled Then Return

            TimerCallback = callback
            Dim Success As Boolean = CreateTimerQueueTimer(Handle, IntPtr.Zero, TimerCallback, IntPtr.Zero, dueTime, period, 0)

            If Not Success Then ThrowNewException("CreateTimerQueueTimer")
            _Enabled = Success
        End Sub

        Sub Delete()
            If Not _Enabled Then Return
            Dim Success As Boolean = DeleteTimerQueueTimer(IntPtr.Zero, Handle, IntPtr.Zero)

            If Not Success AndAlso Not Marshal.GetLastWin32Error = 997 Then
                'ThrowNewException("DeleteTimerQueueTimer")
            End If

            _Enabled = Not Success
        End Sub

        Private Sub ThrowNewException(ByVal name As String)
            Throw New Exception(String.Format("{0} failed. Win32Error: {1}", name, Marshal.GetLastWin32Error))
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Delete()
        End Sub
    End Class
#End Region
    Class CarbonFiberTheme
        Inherits ThemeContainer154
#Region "Properties"
        Private _Icon As Icon
        Public Property Icon() As Icon
            Set(ByVal value As Icon)
                _Icon = value
            End Set
            Get
                Return _Icon
            End Get
        End Property
        Private _ShowIcon As Boolean
        Public Property ShowIcon() As Boolean
            Get
                Return _ShowIcon
            End Get
            Set(ByVal value As Boolean)
                _ShowIcon = value
                Invalidate()
            End Set
        End Property

        Sub New()
            BackColor = Color.FromArgb(22, 22, 22)
            TransparencyKey = Color.Fuchsia
            Font = New Font("Verdana", 8)
            Header = 30
        End Sub

        Protected Overrides Sub ColorHook()
            ' Color hook is just a waste of time haha !!
            '
            '
        End Sub
#End Region
#Region "Color of Control"
        Protected Overrides Sub PaintHook()
            'This G.Clear does not need ^^
            G.Clear(Color.FromArgb(31, 31, 31))

            '''''''''' Gradient the Body '''''''
            Dim GradientBG As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(22, 22, 22), -270S)
            G.FillRectangle(GradientBG, New Rectangle(0, 0, Width - 1, Height - 1))

            '''''''''' Draw Body '''''''
            Dim BodyHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
            G.FillRectangle(BodyHatch, New Rectangle(0, 0, Width - 1, Height - 1))
            ' G.FillRectangle(New SolidBrush(Color.FromArgb(32, 32, 32)), New Rectangle(10, 10, Width - 21, Height - 21))
            G.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(10, 32, Width - 21, Height - 43))
            G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(9, 31, Width - 19, Height - 41))


            '''''''''' Draw Header '''''''
            Dim Header As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, 30), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270S)
            G.FillRectangle(Header, New Rectangle(0, 0, Width - 1, 30))
            Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
            G.FillRectangle(HeaderHatch, New Rectangle(0, 0, Width - 1, 30))
            G.FillRectangle(New SolidBrush(Color.FromArgb(15, Color.White)), 0, 0, Width - 1, 15)

            '''''''''' Draw Header Seperator ''''''
            'G.DrawLine(New Pen(Color.FromArgb(18, 18, 18)), 0, 15, Width + 9000, 15) ' Please dont use 9000 above ^^
            G.DrawLine(New Pen(Color.FromArgb(42, 42, 42)), 0, 15, Width - 1, 15) ' Cuz it has a bug dont worry i will fix it =)

            '''''''''' Draw Header Border '''''''
            'DrawGradient(BlendColor, New Rectangle(0, 0, Width - 1, 32), 0.0F)
            G.FillRectangle(New SolidBrush(Color.FromArgb(22, 22, 22)), New Rectangle(11, 33, Width - 23, Height - 45))
            G.DrawRectangle(Pens.Black, New Rectangle(0, 0, Width - 1, Height - 1))
            G.DrawRectangle(New Pen(Color.FromArgb(49, 49, 49)), New Rectangle(1, 1, Width - 3, Height - 3))

            '''''''''' Reduce Corners '''''''


            '''''''''' Draw Icon and Text '''''''
            If _ShowIcon = False Then
                G.DrawString(Text, Font, New SolidBrush(Color.Black), New Point(8, 7)) ' Text Shadow
                G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(8, 8))
            Else
                G.DrawIcon(FindForm.Icon, New Rectangle(New Point(9, 7), New Size(16, 16)))
                G.DrawString(Text, Font, New SolidBrush(Color.Black), New Point(28, 7)) ' Text Shadow
                G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(28, 8))
            End If

        End Sub
#End Region
    End Class
    Class CarbonFiberLabel
        Inherits ThemeControl154
#Region "Properties"
        Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
            MyBase.OnTextChanged(e)
            Dim textSize, textSize1 As Integer
            textSize = Me.CreateGraphics.MeasureString(Text, Font).Width
            textSize1 = Me.CreateGraphics.MeasureString(Text, Font).Height

            Me.Width = 5 + textSize
            Me.Height = textSize1
        End Sub
        Sub New()
            Transparent = True
            BackColor = Color.Transparent
            Me.Size = New Point(50, 16)
            'MinimumSize = New Size(50, 16)
            'MaximumSize = New Size(600, 16)
        End Sub
        Protected Overrides Sub ColorHook()
            ' bleh bleh bleh waste of time !!
        End Sub
#End Region
#Region "Color Of Control"
        Protected Overrides Sub PaintHook()
            G.Clear(BackColor)

            G.DrawString(Text, Font, New SolidBrush(Color.Black), New Point(1, 0)) ' Text Shadow
            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(1, 1))
        End Sub
#End Region
    End Class
    Class CarbonFiberButton
        Inherits ThemeControl154
#Region "Properties"
        Sub New()
            Me.Size = New Point(142, 29)
        End Sub
        Protected Overrides Sub ColorHook()
            ' blah blah blah waste of time !!
        End Sub
#End Region
#Region "Color Of Control"
        Protected Overrides Sub PaintHook()

            G.Clear(Color.FromArgb(22, 22, 22))

            Dim Header As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(42, 42, 42), 270S)
            G.FillRectangle(Header, New Rectangle(0, 0, Width - 1, Height - 1))


            Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
            G.FillRectangle(HeaderHatch, New Rectangle(0, 0, Width - 1, Height - 1))

            Select Case State
                Case MouseState.Over
                    Dim Header1 As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(50, 50, 50), 270S)
                    G.FillRectangle(Header1, New Rectangle(0, 0, Width - 1, Height - 1))


                    Dim HeaderHatch1 As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch1, New Rectangle(0, 0, Width - 1, Height - 1))

                Case MouseState.Down
                    Dim Header1 As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35), 270S)
                    G.FillRectangle(Header1, New Rectangle(0, 0, Width - 1, Height - 1))


                    Dim HeaderHatch1 As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch1, New Rectangle(0, 0, Width - 1, Height - 1))
            End Select

            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(6, 6, 6)), New Rectangle(-1, -1, Width - 1, Height - 1), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), New Rectangle(0, 0, Width - 1, Height - 1), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})

            DrawBorders(Pens.Black)
            DrawBorders(New Pen(Color.FromArgb(32, 32, 32)), 1)

            DrawCorners(Color.FromArgb(22, 22, 22), 1)
            DrawCorners(Color.FromArgb(22, 22, 22))
        End Sub
#End Region
    End Class
    Class CarbonFiberListBox : Inherits ListBox
#Region "Properties"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                     ControlStyles.SupportsTransparentBackColor, True)
            BackColor = Color.Transparent
            DoubleBuffered = True
            DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            BackColor = Color.FromArgb(22, 22, 22)
            BorderStyle = Windows.Forms.BorderStyle.None
            ItemHeight = 15
        End Sub
        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
            MyBase.WndProc(m)
            If m.Msg = 15 Then CustomPaint()
        End Sub
        Sub CustomPaint() ' if you dont call this border will not show ^^
            CreateGraphics.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(1, 1, Width - 3, Height - 3))
            CreateGraphics.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(0, 0, Width - 1, Height - 1))
        End Sub
#End Region
#Region "Color of Control"
        Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
            Dim G As Graphics = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.FillRectangle(New SolidBrush(BackColor), New Rectangle(e.Bounds.X, e.Bounds.Y - 1, e.Bounds.Width, e.Bounds.Height + 3))

            If e.State.ToString().Contains("Selected,") Then
                Dim MainBody As New LinearGradientBrush(New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height), Color.FromArgb(25, 25, 25), Color.FromArgb(50, 50, 50), 270S)
                G.FillRectangle(MainBody, New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height))
                G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height))
                Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                G.FillRectangle(HeaderHatch, New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height))
                'G.FillRectangle(New SolidBrush(Color.FromArgb(5, Color.White)), New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height - 8))
            Else
                G.FillRectangle(New SolidBrush(BackColor), e.Bounds)
            End If

            Try
                ' put a space cuz the text will stick into the left
                G.DrawString(" " & Items(e.Index).ToString(), Font, New SolidBrush(Color.FromArgb(100, Color.Black)), e.Bounds.X, e.Bounds.Y)
                G.DrawString(" " & Items(e.Index).ToString(), Font, New SolidBrush(Color.FromArgb(255, 150, 0)), e.Bounds.X, e.Bounds.Y + 1)
            Catch : End Try
            G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(1, 1, Width - 3, Height - 3))
            G.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(0, 0, Width - 1, Height - 1))
            MyBase.OnDrawItem(e)
        End Sub
#End Region
    End Class
    Class CarbonFiberGroupBox
        Inherits ThemeContainer154
#Region "Properties"
        Sub New()
            ControlMode = True
            TransparencyKey = Color.Fuchsia
            Font = New Font("Verdana", 8)
            Me.Size = New Point(172, 105)
        End Sub

        Protected Overrides Sub ColorHook()
            ' another waste of time HAHA !!
        End Sub
#End Region
#Region "Color of Control"
        Protected Overrides Sub PaintHook()

            G.Clear(Color.FromArgb(22, 22, 22))

            '''''''''' Draw Header '''''''

            G.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(1, 1, Width - 3, Height - 3))

            Dim Header As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, 26), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270S)
            G.FillRectangle(Header, New Rectangle(0, 0, Width - 1, 26))

            Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
            G.FillRectangle(HeaderHatch, New Rectangle(0, 0, Width - 1, 26))
            G.FillRectangle(New SolidBrush(Color.FromArgb(13, Color.White)), 0, 0, Width - 1, 13)

            G.DrawLine(New Pen(Color.FromArgb(42, 42, 42)), 0, 13, Width - 1, 13) ' Cuz it has a bug dont worry i will fix it =)

            G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(0, 0, Width - 1, Height - 1))
            ' Draw Border
            'G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(0, 0, Width - 1, 27))
            'G.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(0, 0, Width - 1, Height - 1))


            G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(1, 1, Width - 3, 25))
            G.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(1, 1, Width - 3, 24))

            '''''''''' Draw Text and Shadw '''''''
            'G.DrawString(Text, Font, New SolidBrush(Color.Black), New Point(9, 7)) ' Text Shadow
            'G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(8, 6))

            DrawText(New SolidBrush(Color.Black), HorizontalAlignment.Center, 1, 1)
            DrawText(New SolidBrush(Color.FromArgb(255, 150, 0)), HorizontalAlignment.Center, 2, 2)

            'DrawCorners(Color.FromArgb(22, 22, 22), 1)
            'DrawCorners(Color.FromArgb(22, 22, 22))
        End Sub
#End Region

    End Class
    <DefaultEvent("CheckedChanged")>
    Class CarbonFiberCheckbox
#Region "Properties"
        Inherits ThemeControl154
        Private _Checked As Boolean
        Private X As Integer

        Event CheckedChanged(ByVal sender As Object)

        Public Property Checked() As Boolean
            Get
                Return _Checked
            End Get
            Set(ByVal V As Boolean)
                _Checked = V
                Invalidate()
                RaiseEvent CheckedChanged(Me)
            End Set
        End Property

        Protected Overrides Sub ColorHook()
            ' again another waste of time >.<
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
            MyBase.OnTextChanged(e)
            Dim textSize As Integer
            textSize = Me.CreateGraphics.MeasureString(Text, Font).Width
            Me.Width = 20 + textSize
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseMove(e)
            X = e.X
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e)
            If _Checked = True Then _Checked = False Else _Checked = True
        End Sub
#End Region
#Region "Color of Control"
        Protected Overrides Sub PaintHook()
            G.Clear(BackColor)
            G.SmoothingMode = SmoothingMode.HighQuality
            G.DrawRectangle(New Pen(Color.FromArgb(29, 29, 29)), 1, 1, 14, 13)

            If State = MouseState.Over Then
                G.DrawString("a", New Font("Marlett", 12), New SolidBrush(Color.FromArgb(13, Color.White)), New Point(-2, 0))
            End If

            If _Checked Then
                Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(50, Color.Black), Color.Transparent)
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), 2, 2, 12, 6) 'Gloss
                G.FillRectangle(HeaderHatch, New Rectangle(2, 2, 12, 12))
                G.DrawString("a", New Font("Marlett", 12), New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(-2, 0))
            Else
                ' Do Nothing ^^
            End If

            G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), 0, 0, 16, 15)
            G.DrawRectangle(New Pen(Color.FromArgb(6, 6, 6)), 2, 2, 12, 11)
            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(0, 0, 0)), 17, 0)
            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), 18, 1)
        End Sub

        Public Sub New()
            Me.Size = New Point(50, 16)
            MinimumSize = New Size(50, 16)
            MaximumSize = New Size(600, 16)
            BackColor = Color.Transparent
        End Sub
#End Region
    End Class
    Class CarbonFiberCustomBox
        Inherits ThemeContainer154
#Region "Properties"
        Sub New()
            ControlMode = True
            Size = New Size(150, 100)
            BackColor = Color.FromArgb(22, 22, 22)
        End Sub


        Protected Overrides Sub ColorHook()

        End Sub
#End Region
#Region "Color of Control"
        Protected Overrides Sub PaintHook()
            G.Clear(BackColor)
            G.FillRectangle(New SolidBrush(Color.FromArgb(22, 22, 22)), ClientRectangle)
            DrawBorders(New Pen(Color.FromArgb(6, 6, 6)), 1)
            DrawBorders(New Pen(Color.FromArgb(32, 32, 32)))
        End Sub
#End Region

    End Class
    Class CarbonFiberTabControl
        Inherits TabControl
#Region "Properties"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.ResizeRedraw Or
            ControlStyles.UserPaint Or
            ControlStyles.DoubleBuffer, True)
            DoubleBuffered = True

        End Sub
        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()
            Alignment = TabAlignment.Top
        End Sub
        Dim C1 As Color = Color.FromArgb(22, 22, 22) ' BackColor
        Dim C2 As Color = Color.FromArgb(6, 6, 6) ' ' OUter Black
        Dim C3 As Color = Color.FromArgb(32, 32, 32) ' ' Inner Border
#End Region
#Region "Color Of Control"
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim B As New Bitmap(Width, Height)
            Dim G As Graphics = Graphics.FromImage(B)
            Try : SelectedTab.BackColor = C1 : Catch : End Try
            G.Clear(Parent.BackColor)
            For i = 0 To TabCount - 1
                If Not i = SelectedIndex Then
                    Dim x2 As Rectangle = New Rectangle(GetTabRect(i).X - 1, GetTabRect(i).Y + 1, GetTabRect(i).Width + 2, GetTabRect(i).Height)
                    Dim G1 As New LinearGradientBrush(New Point(x2.X, x2.Y), New Point(x2.X, x2.Y + x2.Height), Color.FromArgb(22, 22, 22), Color.FromArgb(22, 22, 22))
                    G.FillRectangle(G1, x2) : G1.Dispose()
                    G.DrawRectangle(New Pen(C3), x2)
                    G.DrawRectangle(New Pen(C2), New Rectangle(x2.X + 1, x2.Y + 1, x2.Width - 2, x2.Height))
                    G.DrawString(TabPages(i).Text, Font, New SolidBrush(Color.FromArgb(250, 150, 0)), x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center}) '
                End If
            Next

            G.FillRectangle(New SolidBrush(C1), 0, ItemSize.Height, Width, Height)
            G.DrawRectangle(New Pen(C2), 0, ItemSize.Height, Width - 1, Height - ItemSize.Height - 1)
            G.DrawRectangle(New Pen(C3), 1, ItemSize.Height + 1, Width - 3, Height - ItemSize.Height - 3)
            If Not SelectedIndex = -1 Then
                Dim x1 As Rectangle = New Rectangle(GetTabRect(SelectedIndex).X - 2, GetTabRect(SelectedIndex).Y, GetTabRect(SelectedIndex).Width + 3, GetTabRect(SelectedIndex).Height)
                G.FillRectangle(New SolidBrush(C1), New Rectangle(x1.X + 2, x1.Y + 2, x1.Width - 2, x1.Height))
                G.DrawLine(New Pen(C2), New Point(x1.X, x1.Y + x1.Height - 2), New Point(x1.X, x1.Y))
                G.DrawLine(New Pen(C2), New Point(x1.X, x1.Y), New Point(x1.X + x1.Width, x1.Y))
                G.DrawLine(New Pen(C2), New Point(x1.X + x1.Width, x1.Y), New Point(x1.X + x1.Width, x1.Y + x1.Height - 2))

                G.DrawLine(New Pen(C3), New Point(x1.X + 1, x1.Y + x1.Height - 1), New Point(x1.X + 1, x1.Y + 1))
                G.DrawLine(New Pen(C3), New Point(x1.X + 1, x1.Y + 1), New Point(x1.X + x1.Width - 1, x1.Y + 1))
                G.DrawLine(New Pen(C3), New Point(x1.X + x1.Width - 1, x1.Y + 1), New Point(x1.X + x1.Width - 1, x1.Y + x1.Height - 1))

                G.DrawString(TabPages(SelectedIndex).Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), x1, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
            End If

            e.Graphics.DrawImage(B.Clone, 0, 0)
            G.Dispose() : B.Dispose()

        End Sub
#End Region
    End Class
    <DefaultEvent("CheckedChanged")>
    Class CarbonFiberRadioButton
#Region "Properties"
        Inherits ThemeControl154
        Private X As Integer
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

        Event CheckedChanged(ByVal sender As Object)

        Protected Overrides Sub OnCreation()
            InvalidateControls()
        End Sub

        Private Sub InvalidateControls()
            If Not IsHandleCreated OrElse Not _Checked Then Return

            For Each C As Control In Parent.Controls
                If C IsNot Me AndAlso TypeOf C Is CarbonFiberRadioButton Then
                    DirectCast(C, CarbonFiberRadioButton).Checked = False
                End If
            Next
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            If Not _Checked Then Checked = True
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseMove(e)
            X = e.X
            Invalidate()
        End Sub


        Protected Overrides Sub ColorHook()
            ' again and again another waste of time >.<
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
            MyBase.OnTextChanged(e)
            Dim textSize As Integer
            textSize = Me.CreateGraphics.MeasureString(Text, Font).Width
            Me.Width = 20 + textSize
        End Sub
#End Region
#Region "Color Of Control"
        Protected Overrides Sub PaintHook()
            G.Clear(Color.FromArgb(22, 22, 22))
            G.SmoothingMode = SmoothingMode.HighQuality

            If State = MouseState.Over Then
                G.FillEllipse(New SolidBrush(Color.FromArgb(29, 29, 29)), New Rectangle(3, 3, 10, 10))
                G.DrawEllipse(New Pen(Color.FromArgb(22, 22, 22)), 5, 5, 6, 6)
            End If

            If _Checked Then
                G.FillEllipse(New SolidBrush(Color.FromArgb(255, 150, 0)), 5, 5, 6, 6)
            Else
            End If

            G.DrawEllipse(New Pen(Color.FromArgb(6, 6, 6)), 0, 0, 16, 16)
            G.DrawEllipse(New Pen(Color.FromArgb(29, 29, 29)), 1, 1, 14, 14)
            G.DrawEllipse(New Pen(Color.FromArgb(6, 6, 6)), New Rectangle(2, 2, 12, 12))

            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(0, 0, 0)), 17, 0)
            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(255, 150, 0)), 18, 1)
        End Sub

        Public Sub New()
            Me.Size = New Point(50, 17)
            MinimumSize = New Size(50, 17)
            MaximumSize = New Size(600, 17)
        End Sub
#End Region
    End Class
    Class CarbonFiberControlButton
        Inherits ThemeControl154
#Region "Properties"
        Sub New()
            Me.Size = New Point(26, 20)
            Me.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        End Sub
        Private _StateMinimize As Boolean = False
        Public Property StateMinimize() As Boolean
            Get
                Return _StateMinimize
            End Get
            Set(ByVal v As Boolean)
                _StateMinimize = v
                Invalidate()
            End Set
        End Property

        Private _StateClose As Boolean = False
        Public Property StateClose() As Boolean
            Get
                Return _StateClose
            End Get
            Set(ByVal v As Boolean)
                _StateClose = v
                Invalidate()
            End Set
        End Property

        Private _StateMaximize As Boolean = False
        Public Property StateMaximize() As Boolean
            Get
                Return _StateMaximize
            End Get
            Set(ByVal v As Boolean)
                _StateMaximize = v
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
            MyBase.OnResize(e)
            Me.Size = New Point(26, 20)
        End Sub
        Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseClick(e)
            If _StateMinimize = True Then
                FindForm.WindowState = FormWindowState.Minimized ' true
                ' Else
                _StateClose = False ' false
                _StateMaximize = False
            End If
            If _StateClose = True Then
                FindForm.Close()
                'Else
                _StateMinimize = False
                _StateMaximize = False
            End If
            If _StateMaximize = True Then
                If FindForm.WindowState <> FormWindowState.Maximized Then FindForm.WindowState = FormWindowState.Maximized Else FindForm.WindowState = FormWindowState.Normal

                _StateClose = False ' false
                _StateMinimize = False
            End If
        End Sub

        Protected Overrides Sub ColorHook()

        End Sub
#End Region
#Region "Color Of Control"
        Protected Overrides Sub PaintHook()
            G.Clear(Color.FromArgb(22, 22, 22))
            G.SmoothingMode = SmoothingMode.HighQuality

            Dim Header As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(22, 22, 22), Color.FromArgb(35, 35, 35), 270S)
            G.FillRectangle(Header, New Rectangle(0, 0, Width - 1, Height - 1))

            Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
            G.FillRectangle(HeaderHatch, New Rectangle(0, 0, Width - 1, Height - 1))

            G.FillRectangle(New SolidBrush(Color.FromArgb(8, Color.White)), 0, 0, Width - 1, 10)
            G.DrawLine(New Pen(Color.FromArgb(33, 33, 33)), 0, 9, Width - 1, 10) ' Cuz it has a bug dont worry i will fix it =)

            Select Case State
                Case MouseState.Over
                    Dim Header1 As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270S)
                    G.FillRectangle(Header1, New Rectangle(0, 0, Width - 1, Height - 1))
                    Dim HeaderHatch1 As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch1, New Rectangle(0, 0, Width - 1, Height - 1))
                    G.FillRectangle(New SolidBrush(Color.FromArgb(10, Color.White)), 0, 0, Width - 1, 10)
                    G.DrawLine(New Pen(Color.FromArgb(38, 38, 38)), 0, 9, Width - 1, 10) ' Cuz it has a bug dont worry i will fix it =)
                Case MouseState.Down
                    Dim Header1 As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35), 270S)
                    G.FillRectangle(Header1, New Rectangle(0, 0, Width - 1, Height - 1))
                    Dim HeaderHatch1 As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch1, New Rectangle(0, 0, Width - 1, Height - 1))
                    G.FillRectangle(New SolidBrush(Color.FromArgb(8, Color.White)), 0, 0, Width - 1, 10)
                    G.DrawLine(New Pen(Color.FromArgb(35, 35, 35)), 0, 9, Width - 1, 10) ' Cuz it has a bug dont worry i will fix it =)

            End Select
            'Draw Text


            If _StateMinimize = True Then
                G.DrawString("0", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(6, 4))
                _StateClose = False ' false
                _StateMaximize = False
            End If
            If _StateClose = True Then
                G.DrawString("r", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(6, 4))
                _StateMinimize = False
                _StateMaximize = False
            End If

            If _StateMaximize = True Then
                If FindForm.WindowState <> FormWindowState.Maximized Then G.DrawString("1", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(6, 4)) Else G.DrawString("2", New Font("Marlett", 8), New SolidBrush(Color.FromArgb(255, 150, 0)), New Point(6, 4))
                _StateClose = False ' false
                _StateMinimize = False
            End If


            'Draw Gloss
            'Draw Border
            DrawBorders(Pens.Black)
            ' DrawBorders(New Pen(Color.FromArgb(32, 32, 32)))
        End Sub
#End Region
    End Class
    Class CarbonFiberSeparatorVertical
        Inherits ThemeControl154
#Region "Properties"
        Sub New()
            LockWidth = 10
        End Sub
        Protected Overrides Sub ColorHook()


        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(Color.FromArgb(22, 22, 22))

            G.FillRectangle(New SolidBrush(Color.FromArgb(6, 6, 6)), New Rectangle(4, 0, 1, Height - 1))
            G.FillRectangle(New SolidBrush(Color.FromArgb(32, 32, 32)), New Rectangle(5, 0, 1, Height - 1))
        End Sub
#End Region
    End Class
    Class CarbonFiberSeparatorHorizontal
        Inherits ThemeControl154
#Region "Properties"
        Sub New()
            LockHeight = 10
        End Sub
        Protected Overrides Sub ColorHook()


        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(Color.FromArgb(22, 22, 22))
            G.DrawLine(New Pen(Color.FromArgb(6, 6, 6)), 0, 4, Width - 1, 4)
            G.DrawLine(New Pen(Color.FromArgb(32, 32, 32)), 0, 5, Width - 1, 5)
        End Sub
#End Region
    End Class
    '------------------
    'ProgressBar Component By: Aeonhack
    'TextBox Component By: Mavamaarten
    '------------------
    'Credits by Aeonhack and Mavamaarten
    <DefaultEvent("TextChanged")>
    Class CarbonFiberTextBox
        Inherits ThemeControl154
#Region "Properties"
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

            Base.Location = New Point(5, 5)
            Base.Width = Width - 10

            Base.BackColor = Color.FromArgb(22, 22, 22)
            Base.ForeColor = Color.FromArgb(255, 150, 0)
            If _Multiline Then
                Base.Height = Height - 11
            Else
                LockHeight = Base.Height + 11
            End If

            AddHandler Base.TextChanged, AddressOf OnBaseTextChanged
            AddHandler Base.KeyDown, AddressOf OnBaseKeyDown
        End Sub

#End Region
#Region "Color of Control"
        Protected Overrides Sub ColorHook()

        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(Color.FromArgb(22, 22, 22))

            DrawBorders(New Pen(Color.FromArgb(6, 6, 6)))
            DrawBorders(New Pen(Color.FromArgb(32, 32, 32)), 1)

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
            Base.Location = New Point(5, 5)
            Base.Width = Width - 10

            If _Multiline Then
                Base.Height = Height - 11
            End If


            MyBase.OnResize(e)
        End Sub
#End Region
    End Class
    Class CarbonFiberProgressBar
        Inherits Control
#Region " Properties "
        Sub New()
            Size = New Point(419, 27)
        End Sub
        Private _Maximum As Double
        Public Property Maximum() As Double
            Get
                Return _Maximum
            End Get
            Set(ByVal v As Double)
                _Maximum = v
                Progress = _Current / v * 100
                Invalidate()
            End Set
        End Property


        Private _Current As Double
        Public Property Current() As Double
            Get
                Return _Current
            End Get
            Set(ByVal v As Double)
                _Current = v
                Progress = v / _Maximum * 100
                Invalidate()
            End Set
        End Property
        Private _Progress As Double
        Public Property Progress() As Double
            Get
                Return _Progress
            End Get
            Set(ByVal v As Double)
                If v < 0 Then v = 0 Else If v > 100 Then v = 100
                _Progress = v
                _Current = v * 0.01 * _Maximum
                Invalidate()
            End Set
        End Property

        Private _ShowPercentage As Boolean = True
        Public Property ShowPercentage() As Boolean
            Get
                Return _ShowPercentage
            End Get
            Set(ByVal v As Boolean)
                _ShowPercentage = v
                Invalidate()
            End Set
        End Property
#End Region
#Region "Color Of Control"
        Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Using B As New Bitmap(Width, Height)


                Using G = Graphics.FromImage(B)
                    G.Clear(Color.FromArgb(22, 22, 22))
                    Dim Glow As New LinearGradientBrush(New Rectangle(3, 3, Width - 7, Height - 7), Color.FromArgb(22, 22, 22), Color.FromArgb(27, 27, 27), -270S)
                    G.FillRectangle(Glow, New Rectangle(3, 3, Width - 7, Height - 7))
                    G.DrawRectangle(Pens.Black, New Rectangle(3, 3, Width - 7, Height - 7))



                    Dim W = CInt(_Progress * 0.01 * Width)

                    Dim R As New Rectangle(3, 3, W - 6, Height - 6)

                    Dim Header As New LinearGradientBrush(R, Color.FromArgb(25, 25, 25), Color.FromArgb(50, 50, 50), 270S)
                    G.FillRectangle(Header, R)
                    Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch, R)

                    If _ShowPercentage Then
                        G.DrawString(Convert.ToString(String.Concat(Progress, "%")), Font, New SolidBrush(Color.FromArgb(6, 6, 6)), New Rectangle(1, 2, Width - 1, Height - 1), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        G.DrawString(Convert.ToString(String.Concat(Progress, "%")), Font, New SolidBrush(Color.FromArgb(255, 150, 0)), New Rectangle(0, 1, Width - 1, Height - 1), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    End If

                    G.FillRectangle(New SolidBrush(Color.FromArgb(3, Color.White)), R.X, R.Y, R.Width, CInt(R.Height * 0.45))
                    G.DrawRectangle(New Pen(Color.FromArgb(32, 32, 32)), New Rectangle(4, 4, Width - 9, Height - 9))
                    G.DrawRectangle(New Pen(Color.FromArgb(10, 10, 10)), R.X, R.X, R.Width - 1, R.Height - 1)

                End Using
                e.Graphics.DrawImage(B, 0, 0)
            End Using
            MyBase.OnPaint(e)
        End Sub
#End Region
    End Class
End Namespace

Namespace Hura

#Region "Functions"

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

#End Region

    Module HuraModule

#Region " G"
        Friend G As Graphics, B As Bitmap
#End Region


        Sub New()
            TextBitmap = New Bitmap(1, 1)
            TextGraphics = Graphics.FromImage(TextBitmap)
        End Sub

        Private TextBitmap As Bitmap
        Private TextGraphics As Graphics

        Friend Function MeasureString(text As String, font As Font) As SizeF
            Return TextGraphics.MeasureString(text, font)
        End Function

        Friend Function MeasureString(text As String, font As Font, width As Integer) As SizeF
            Return TextGraphics.MeasureString(text, font, width, StringFormat.GenericTypographic)
        End Function

        Private CreateRoundPath As GraphicsPath
        Private CreateRoundRectangle As Rectangle

        Friend Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
            CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return CreateRound(CreateRoundRectangle, slope)
        End Function

        Friend Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
            CreateRoundPath = New GraphicsPath(FillMode.Winding)
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F)
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function

        Public Function RoundRectangle(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
            Dim P As GraphicsPath = New GraphicsPath()
            Dim ArcRectangleWidth As Integer = Curve * 2
            P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
            P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
            P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
            Return P
        End Function

    End Module



    Public Class HuraForm : Inherits ContainerControl
        Enum ColorSchemes
            Dark
        End Enum
        Event ColorSchemeChanged()
        Private _ColorScheme As ColorSchemes
        Public Property ColorScheme() As ColorSchemes
            Get
                Return _ColorScheme
            End Get
            Set(ByVal value As ColorSchemes)
                _ColorScheme = value
                RaiseEvent ColorSchemeChanged()
            End Set
        End Property
        Protected Sub OnColorSchemeChanged() Handles Me.ColorSchemeChanged
            Invalidate()
            Select Case ColorScheme
                Case ColorSchemes.Dark
                    BackColor = Color.FromArgb(255, 255, 255)
                    Font = New Font("Segoe UI", 9.5)
                    AccentColor = Color.FromArgb(255, 255, 255)
                    ForeColor = Color.Gray
            End Select
        End Sub
#Region " Properties "
        Private _AccentColor As Color
        Public Property AccentColor() As Color
            Get
                Return _AccentColor
            End Get
            Set(ByVal value As Color)
                _AccentColor = value
                OnAccentColorChanged()
            End Set
        End Property
#End Region
#Region " Constructor "
        Sub New()
            MyBase.New()
            DoubleBuffered = True
            Font = New Font("Segoe UI Semilight", 9.75F)
            'AccentColor = Color.FromArgb(150, 0, 150)
            AccentColor = Color.White
            ColorScheme = ColorSchemes.Dark
            ForeColor = Color.Gray
            BackColor = Color.FromArgb(255, 255, 255)
            MoveHeight = 32
        End Sub
#End Region
#Region " Events "
        Event AccentColorChanged()
#End Region
#Region " Overrides "
        Private MouseP As Point = New Point(0, 0)
        Private Cap As Boolean = False
        Private MoveHeight As Integer
        Private pos As Integer = 0
        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e)
            If e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width, MoveHeight).Contains(e.Location) Then
                Cap = True : MouseP = e.Location
            End If
        End Sub
        Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseMove(e)
            If Cap Then
                Parent.Location = MousePosition - MouseP
            End If
        End Sub
        Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseUp(e) : Cap = False
        End Sub
        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            Dock = DockStyle.Fill
            Parent.FindForm().FormBorderStyle = FormBorderStyle.None
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim B As Bitmap = New Bitmap(Width, Height)
            Dim G As Graphics = Graphics.FromImage(B)
            MyBase.OnPaint(e)

            Dim MainRect As New Rectangle(0, 0, Width - 1, Height - 1)

            G.Clear(BackColor)
            G.DrawLine(New Pen(Color.FromArgb(0, 173, 220), 3), New Point(0, 0), New Point(Width, 0))
            G.DrawRectangle(New Pen(Color.FromArgb(0, 173, 220)), MainRect)
            G.DrawString(Text, Font, New SolidBrush(ForeColor), New Rectangle(8, 6, Width - 1, Height - 1), StringFormat.GenericDefault)

            e.Graphics.DrawImage(B, New Point(0, 0))
            G.Dispose() : B.Dispose()
        End Sub
        Protected Sub OnAccentColorChanged() Handles Me.AccentColorChanged
            Invalidate()
        End Sub
        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            MyBase.OnTextChanged(e)
            Invalidate()
        End Sub
        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Invalidate()
        End Sub
#End Region

    End Class

    Public Class HuraControlBox : Inherits Control
        Enum ColorSchemes
            Dark
        End Enum
        Event ColorSchemeChanged()
        Private _ColorScheme As ColorSchemes
        Public Property ColorScheme() As ColorSchemes
            Get
                Return _ColorScheme
            End Get
            Set(ByVal value As ColorSchemes)
                _ColorScheme = value
                RaiseEvent ColorSchemeChanged()
            End Set
        End Property
        Protected Sub OnColorSchemeChanged() Handles Me.ColorSchemeChanged
            Invalidate()
            Select Case ColorScheme
                Case ColorSchemes.Dark
                    ForeColor = Color.White
                    AccentColor = Color.FromArgb(0, 178, 255)
                    AccentColorClose = Color.FromArgb(255, 128, 128)
            End Select
        End Sub
        Private _AccentColor_Close As Color
        Public Property AccentColorClose() As Color
            Get
                Return _AccentColor_Close
            End Get
            Set(ByVal value As Color)
                _AccentColor_Close = value
                Invalidate()
            End Set
        End Property
        Private _AccentColor As Color
        Public Property AccentColor() As Color
            Get
                Return _AccentColor
            End Get
            Set(ByVal value As Color)
                _AccentColor = value
                Invalidate()
            End Set
        End Property
        Property Maximize As Boolean
        Property Minimize As Boolean
        Sub New()
            MyBase.New()
            DoubleBuffered = True
            SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            SetStyle(ControlStyles.UserPaint, True)
            SetStyle(ControlStyles.ResizeRedraw, True)
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            ForeColor = Color.FromArgb(50, 50, 50)
            AccentColor = Color.FromArgb(200, 200, 200)
            AccentColorClose = Color.FromArgb(255, 128, 128)
            ColorScheme = ColorSchemes.Dark
            Anchor = AnchorStyles.Top Or AnchorStyles.Right

        End Sub
        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Size = New Size(100, 25)
        End Sub
        Enum ButtonHover
            Minimize
            Maximize
            Close
            None
        End Enum
        Dim ButtonState As ButtonHover = ButtonHover.None
        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            Dim X As Integer = e.Location.X
            Dim Y As Integer = e.Location.Y
            If Y > 0 AndAlso Y < (Height - 2) Then
                If X > 0 AndAlso X < 34 Then
                    ButtonState = ButtonHover.Minimize
                ElseIf X > 33 AndAlso X < 65 Then
                    ButtonState = ButtonHover.Maximize
                ElseIf X > 64 AndAlso X < Width Then
                    ButtonState = ButtonHover.Close
                Else
                    ButtonState = ButtonHover.None
                End If
            Else
                ButtonState = ButtonHover.None
            End If
            Invalidate()
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim B As New Bitmap(Width, Height)
            Dim G As Graphics = Graphics.FromImage(B)

            MyBase.OnPaint(e)

            G.Clear(BackColor)
            Select Case ButtonState
                Case ButtonHover.None
                    G.Clear(BackColor)
                Case ButtonHover.Minimize
                    If Me.Minimize = True Then
                        G.FillRectangle(New SolidBrush(_AccentColor), New Rectangle(3, 0, 30, Height))
                    End If
                Case ButtonHover.Maximize
                    If Me.Maximize = True Then
                        G.FillRectangle(New SolidBrush(_AccentColor), New Rectangle(34, 0, 30, Height))
                    End If
                Case ButtonHover.Close
                    G.FillRectangle(New SolidBrush(_AccentColor_Close), New Rectangle(65, 0, 35, Height))
            End Select

            Dim ButtonFont As New Font("Marlett", 9.75F)
            'Close
            G.DrawString("r", ButtonFont, New SolidBrush(Color.FromArgb(150, 150, 150)), New Point(Width - 16, 7), New StringFormat With {.Alignment = StringAlignment.Center})
            'Maximize
            Select Case Parent.FindForm().WindowState
                Case FormWindowState.Maximized
                    G.DrawString("2", ButtonFont, New SolidBrush(Color.FromArgb(150, 150, 150)), New Point(51, 7), New StringFormat With {.Alignment = StringAlignment.Center})
                Case FormWindowState.Normal
                    G.DrawString("1", ButtonFont, New SolidBrush(Color.FromArgb(150, 150, 150)), New Point(51, 7), New StringFormat With {.Alignment = StringAlignment.Center})
            End Select
            'Minimize
            G.DrawString("0", ButtonFont, New SolidBrush(Color.FromArgb(150, 150, 150)), New Point(20, 7), New StringFormat With {.Alignment = StringAlignment.Center})


            e.Graphics.DrawImage(B, New Point(0, 0))
            G.Dispose() : B.Dispose()
        End Sub
        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            Select Case ButtonState
                Case ButtonHover.Close
                    Parent.FindForm().Close()
                Case ButtonHover.Minimize
                    If Me.Minimize = True Then
                        Parent.FindForm().WindowState = FormWindowState.Minimized
                    End If
                Case ButtonHover.Maximize
                    If Me.Maximize = True Then
                        If Parent.FindForm().WindowState = FormWindowState.Normal Then
                            Parent.FindForm().WindowState = FormWindowState.Maximized
                        Else
                            Parent.FindForm().WindowState = FormWindowState.Normal
                        End If
                    End If
            End Select
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            ButtonState = ButtonHover.None : Invalidate()
        End Sub
    End Class

    Public Class HuraButton
        Inherits Control

#Region "Declarations"
        Private ReadOnly _Font As New Font("Segoe UI", 9)
        Private _ProgressColour As Color = Color.FromArgb(0, 191, 255)

        Private _BorderColour As Color = Color.FromArgb(0, 170, 220)
        Private _FontColour As Color = Color.FromArgb(150, 150, 150)
        Private _MainColour As Color = Color.White
        Private _HoverColour As Color = Color.FromArgb(255, 255, 255)
        Private _PressedColour As Color = Color.FromArgb(245, 245, 245)
        Private State As New MouseState
#End Region

#Region "Mouse States"
        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Over : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

#End Region

#Region "Properties"

        <Category("Colours")>
        Public Property ProgressColour As Color
            Get
                Return _ProgressColour
            End Get
            Set(value As Color)
                _ProgressColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BorderColour As Color
            Get
                Return _BorderColour
            End Get
            Set(value As Color)
                _BorderColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property FontColour As Color
            Get
                Return _FontColour
            End Get
            Set(value As Color)
                _FontColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BaseColour As Color
            Get
                Return _MainColour
            End Get
            Set(value As Color)
                _MainColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property HoverColour As Color
            Get
                Return _HoverColour
            End Get
            Set(value As Color)
                _HoverColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property PressedColour As Color
            Get
                Return _PressedColour
            End Get
            Set(value As Color)
                _PressedColour = value
            End Set
        End Property

#End Region

#Region "Draw Control"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                  ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                  ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            Size = New Size(75, 30)
            BackColor = Color.Transparent
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim G = e.Graphics
            With G
                .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
                .SmoothingMode = SmoothingMode.HighQuality
                .PixelOffsetMode = PixelOffsetMode.HighQuality
                .InterpolationMode = CType(7, InterpolationMode)
                .Clear(BackColor)
                Select Case State
                    Case MouseState.None
                        .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 0, Width, Height))
                        .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                        .DrawString(Text, _Font, Brushes.Gray, New Point(CInt(Width / 2), CInt(Height / 2)), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    Case MouseState.Over
                        .FillRectangle(New SolidBrush(_HoverColour), New Rectangle(0, 0, Width, Height))
                        .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 2))
                        .DrawString(Text, _Font, Brushes.Gray, New Point(CInt(Width / 2), CInt(Height / 2)), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                    Case MouseState.Down
                        .FillRectangle(New SolidBrush(_PressedColour), New Rectangle(0, 0, Width, Height))
                        .DrawRectangle(New Pen(_BorderColour, 1), New Rectangle(1, 1, Width - 2, Height - 2))
                        .DrawString(Text, _Font, Brushes.Gray, New Point(CInt(Width / 2), CInt(Height / 2)), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                End Select
            End With
        End Sub

#End Region

    End Class

    Public Class HuraTextBox
        Inherits Control

#Region "Declarations"
        Private State As MouseState = MouseState.None
        Private WithEvents TB As Windows.Forms.TextBox
        Private _BaseColour As Color = Color.White
        Private _TextColour As Color = Color.FromArgb(150, 150, 150)
        Private _BorderColour As Color = Color.FromArgb(180, 180, 180)
        Private _Style As Styles = Styles.Normal
        Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
        Private _MaxLength As Integer = 32767
        Private _ReadOnly As Boolean
        Private _UseSystemPasswordChar As Boolean
        Private _Multiline As Boolean
#End Region

#Region "TextBox Properties"

        Enum Styles
            Normal
        End Enum

        <Category("Options")>
        Property TextAlign() As HorizontalAlignment
            Get
                Return _TextAlign
            End Get
            Set(ByVal value As HorizontalAlignment)
                _TextAlign = value
                If TB IsNot Nothing Then
                    TB.TextAlign = value
                End If
            End Set
        End Property

        <Category("Options")>
        Property MaxLength() As Integer
            Get
                Return _MaxLength
            End Get
            Set(ByVal value As Integer)
                _MaxLength = value
                If TB IsNot Nothing Then
                    TB.MaxLength = value
                End If
            End Set
        End Property

        <Category("Options")>
        Property [ReadOnly]() As Boolean
            Get
                Return _ReadOnly
            End Get
            Set(ByVal value As Boolean)
                _ReadOnly = value
                If TB IsNot Nothing Then
                    TB.ReadOnly = value
                End If
            End Set
        End Property

        <Category("Options")>
        Property UseSystemPasswordChar() As Boolean
            Get
                Return _UseSystemPasswordChar
            End Get
            Set(ByVal value As Boolean)
                _UseSystemPasswordChar = value
                If TB IsNot Nothing Then
                    TB.UseSystemPasswordChar = value
                End If
            End Set
        End Property

        <Category("Options")>
        Property Multiline() As Boolean
            Get
                Return _Multiline
            End Get
            Set(ByVal value As Boolean)
                _Multiline = value
                If TB IsNot Nothing Then
                    TB.Multiline = value

                    If value Then
                        TB.Height = Height - 11
                    Else
                        Height = TB.Height + 11
                    End If

                End If
            End Set
        End Property

        <Category("Options")>
        Overrides Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(ByVal value As String)
                MyBase.Text = value
                If TB IsNot Nothing Then
                    TB.Text = value
                End If
            End Set
        End Property

        <Category("Options")>
        Overrides Property Font As Font
            Get
                Return MyBase.Font
            End Get
            Set(ByVal value As Font)
                MyBase.Font = value
                If TB IsNot Nothing Then
                    TB.Font = value
                    TB.Location = New Point(3, 5)
                    TB.Width = Width - 6

                    If Not _Multiline Then
                        Height = TB.Height + 11
                    End If
                End If
            End Set
        End Property

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            If Not Controls.Contains(TB) Then
                Controls.Add(TB)
            End If
        End Sub

        Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
            Text = TB.Text
        End Sub

        Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
            If e.Control AndAlso e.KeyCode = Keys.A Then
                TB.SelectAll()
                e.SuppressKeyPress = True
            End If
            If e.Control AndAlso e.KeyCode = Keys.C Then
                TB.Copy()
                e.SuppressKeyPress = True
            End If
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            TB.Location = New Point(5, 5)
            TB.Width = Width - 10

            If _Multiline Then
                TB.Height = Height - 11
            Else
                Height = TB.Height + 11
            End If

            MyBase.OnResize(e)
        End Sub

        Public Property Style As Styles
            Get
                Return _Style
            End Get
            Set(value As Styles)
                _Style = value
            End Set
        End Property

        Public Sub SelectAll()
            TB.Focus()
            TB.SelectAll()
        End Sub


#End Region

#Region "Colour Properties"

        <Category("Colours")>
        Public Property BackgroundColour As Color
            Get
                Return _BaseColour
            End Get
            Set(value As Color)
                _BaseColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property TextColour As Color
            Get
                Return _TextColour
            End Get
            Set(value As Color)
                _TextColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BorderColour As Color
            Get
                Return _BorderColour
            End Get
            Set(value As Color)
                _BorderColour = value
            End Set
        End Property

#End Region

#Region "Mouse States"

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : TB.Focus() : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

#End Region

#Region "Draw Control"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                     ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                     ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            BackColor = Color.Transparent
            TB = New Windows.Forms.TextBox
            TB.Height = 190
            TB.Font = New Font("Segoe UI", 10)
            TB.Text = Text
            TB.BackColor = Color.FromArgb(255, 255, 255)
            TB.ForeColor = Color.FromArgb(150, 150, 150)
            TB.MaxLength = _MaxLength
            TB.Multiline = False
            TB.ReadOnly = _ReadOnly
            TB.UseSystemPasswordChar = _UseSystemPasswordChar
            TB.BorderStyle = BorderStyle.None
            TB.Location = New Point(5, 5)
            TB.Width = Width - 35
            AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
            AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
        End Sub


        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim g = e.Graphics
            Dim Base As New Rectangle(0, 0, Width, Height)
            With g
                .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
                .SmoothingMode = SmoothingMode.HighQuality
                .PixelOffsetMode = PixelOffsetMode.HighQuality
                .Clear(BackColor)
                TB.BackColor = Color.FromArgb(255, 255, 255)
                TB.ForeColor = Color.FromArgb(150, 150, 150)
                Select Case _Style
                    Case Styles.Normal
                        .FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), New Rectangle(0, 0, Width - 1, Height - 1))
                        .DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(180, 180, 180)), 2), New Rectangle(0, 0, Width, Height))
                End Select
                .InterpolationMode = CType(7, InterpolationMode)
            End With
        End Sub

#End Region

    End Class

    Class HuraGroupBox
        Inherits ContainerControl

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or _
                     ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
            BackColor = Color.White
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)

            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
            G.FillRectangle(New SolidBrush(Color.White), mainRect)
            G.DrawRectangle(New Pen(Color.FromArgb(180, 180, 180)), mainRect)
        End Sub
    End Class

    <DefaultEvent("CheckedChanged")>
    Public Class HuraRadioButton
        Inherits Control

#Region "Declarations"
        Private _Checked As Boolean
        Private State As MouseState = MouseState.None
        Private _HoverColour As Color = Color.FromArgb(240, 240, 240)
        Private _CheckedColour As Color = Color.FromArgb(0, 170, 220)
        Private _BorderColour As Color = Color.FromArgb(180, 180, 180)
        Private _BackColour As Color = Color.FromArgb(255, 255, 255)
        Private _TextColour As Color = Color.FromArgb(150, 150, 150)
#End Region

#Region "Colour & Other Properties"

        <Category("Colours")>
        Public Property HighlightColour As Color
            Get
                Return _HoverColour
            End Get
            Set(value As Color)
                _HoverColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BaseColour As Color
            Get
                Return _BackColour
            End Get
            Set(value As Color)
                _BackColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BorderColour As Color
            Get
                Return _BorderColour
            End Get
            Set(value As Color)
                _BorderColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CheckedColour As Color
            Get
                Return _CheckedColour
            End Get
            Set(value As Color)
                _CheckedColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property FontColour As Color
            Get
                Return _TextColour
            End Get
            Set(value As Color)
                _TextColour = value
            End Set
        End Property

        Event CheckedChanged(ByVal sender As Object)
        Property Checked() As Boolean
            Get
                Return _Checked
            End Get
            Set(value As Boolean)
                _Checked = value
                InvalidateControls()
                RaiseEvent CheckedChanged(Me)
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnClick(e As EventArgs)
            If Not _Checked Then Checked = True
            MyBase.OnClick(e)
        End Sub
        Private Sub InvalidateControls()
            If Not IsHandleCreated OrElse Not _Checked Then Return
            For Each C As Control In Parent.Controls
                If C IsNot Me AndAlso TypeOf C Is HuraRadioButton Then
                    DirectCast(C, HuraRadioButton).Checked = False
                    Invalidate()
                End If
            Next
        End Sub
        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            InvalidateControls()
        End Sub
        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            Height = 22
        End Sub
#End Region

#Region "Mouse States"

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Over : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

#End Region

#Region "Draw Control"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                       ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            Cursor = Cursors.Hand
            Size = New Size(100, 22)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim G = e.Graphics
            Dim Base As New Rectangle(1, 1, Height - 2, Height - 2)
            Dim Circle As New Rectangle(6, 6, Height - 12, Height - 12)
            With G
                .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
                .SmoothingMode = SmoothingMode.HighQuality
                .PixelOffsetMode = PixelOffsetMode.HighQuality
                .Clear(_BackColour)
                .FillEllipse(New SolidBrush(_BackColour), Base)
                .DrawEllipse(New Pen(_BorderColour, 2), Base)
                If Checked Then
                    Select Case State
                        Case MouseState.Over
                            .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(2, 2, Height - 4, Height - 4))
                    End Select
                    .FillEllipse(New SolidBrush(_CheckedColour), Circle)
                Else
                    Select Case State
                        Case MouseState.Over
                            .FillEllipse(New SolidBrush(_HoverColour), New Rectangle(2, 2, Height - 4, Height - 4))
                    End Select
                End If
                .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 3, Width, Height), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})
                .InterpolationMode = CType(7, InterpolationMode)
            End With
        End Sub
#End Region
    End Class

    <DefaultEvent("CheckedChanged")>
    Public Class HuraCheckBox
        Inherits Control

#Region "Declarations"
        Private _Checked As Boolean
        Private State As MouseState = MouseState.None
        Private _CheckedColour As Color = Color.FromArgb(0, 170, 220)
        Private _BorderColour As Color = Color.FromArgb(180, 180, 180)
        Private _BackColour As Color = Color.White
        Private _TextColour As Color = Color.FromArgb(150, 150, 150)
#End Region

#Region "Colour & Other Properties"

        <Category("Colours")>
        Public Property BaseColour As Color
            Get
                Return _BackColour
            End Get
            Set(value As Color)
                _BackColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BorderColour As Color
            Get
                Return _BorderColour
            End Get
            Set(value As Color)
                _BorderColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CheckedColour As Color
            Get
                Return _CheckedColour
            End Get
            Set(value As Color)
                _CheckedColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property FontColour As Color
            Get
                Return _TextColour
            End Get
            Set(value As Color)
                _TextColour = value
            End Set
        End Property

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            MyBase.OnTextChanged(e)
            Invalidate()
        End Sub

        Property Checked() As Boolean
            Get
                Return _Checked
            End Get
            Set(ByVal value As Boolean)
                _Checked = value
                Invalidate()
            End Set
        End Property

        Event CheckedChanged(ByVal sender As Object)
        Protected Overrides Sub OnClick(ByVal e As EventArgs)
            _Checked = Not _Checked
            RaiseEvent CheckedChanged(Me)
            MyBase.OnClick(e)
        End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            Height = 22
        End Sub
#End Region

#Region "Mouse States"

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Over : Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

#End Region

#Region "Draw Control"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                       ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            Cursor = Cursors.Hand
            Size = New Size(100, 22)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim g = e.Graphics
            Dim Base As New Rectangle(0, 0, 20, 20)
            With g
                .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
                .SmoothingMode = SmoothingMode.HighQuality
                .PixelOffsetMode = PixelOffsetMode.HighQuality
                .Clear(Color.FromArgb(255, 255, 255))
                .FillRectangle(New SolidBrush(_BackColour), Base)
                .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
                Select Case State
                    Case MouseState.Over
                        .FillRectangle(New SolidBrush(Color.FromArgb(240, 240, 240)), Base)
                        .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
                End Select
                If Checked Then
                    Dim P() As Point = {New Point(4, 11), New Point(6, 8), New Point(9, 12), New Point(15, 3), New Point(17, 6), New Point(9, 16)}
                    .FillPolygon(New SolidBrush(_CheckedColour), P)
                End If
                .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 1, Width, Height - 2), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
                .InterpolationMode = CType(7, InterpolationMode)
            End With
        End Sub
#End Region

    End Class

    Public Class HuraComboBox : Inherits ComboBox
#Region " Control Help - Properties & Flicker Control "
        Enum ColorSchemes
            Dark
        End Enum
        Private _ColorScheme As ColorSchemes
        Public Property ColorScheme() As ColorSchemes
            Get
                Return _ColorScheme
            End Get
            Set(ByVal value As ColorSchemes)
                _ColorScheme = value
                Invalidate()
            End Set
        End Property

        Private _AccentColor As Color
        Public Property AccentColor() As Color
            Get
                Return _AccentColor
            End Get
            Set(ByVal value As Color)
                _AccentColor = value
                Invalidate()
            End Set
        End Property

        Private _StartIndex As Integer = 0
        Private Property StartIndex As Integer
            Get
                Return _StartIndex
            End Get
            Set(ByVal value As Integer)
                _StartIndex = value
                Try
                    MyBase.SelectedIndex = value
                Catch
                End Try
                Invalidate()
            End Set
        End Property
        Sub ReplaceItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
            e.DrawBackground()
            Try
                If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                    e.Graphics.FillRectangle(New SolidBrush(_AccentColor), e.Bounds)
                Else
                    Select Case ColorScheme
                        Case ColorSchemes.Dark
                            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), e.Bounds)
                    End Select
                End If
                Select Case ColorScheme
                    Case ColorSchemes.Dark
                        e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, Brushes.Gray, e.Bounds)
                End Select
            Catch
            End Try
        End Sub
        Protected Sub DrawTriangle(ByVal Clr As Color, ByVal FirstPoint As Point, ByVal SecondPoint As Point, ByVal ThirdPoint As Point, ByVal G As Graphics)
            Dim points As New List(Of Point)()
            points.Add(FirstPoint)
            points.Add(SecondPoint)
            points.Add(ThirdPoint)
            G.FillPolygon(New SolidBrush(Clr), points.ToArray())
        End Sub

#End Region

        Sub New()
            MyBase.New()
            SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            SetStyle(ControlStyles.ResizeRedraw, True)
            SetStyle(ControlStyles.UserPaint, True)
            SetStyle(ControlStyles.DoubleBuffer, True)
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            BackColor = Color.FromArgb(255, 255, 255)
            Size = New Size(189, 24)
            ForeColor = Color.White
            AccentColor = Color.FromArgb(180, 180, 180)
            ColorScheme = ColorSchemes.Dark
            DropDownStyle = ComboBoxStyle.DropDownList
            Font = New Font("Segoe UI", 9.5)
            StartIndex = 0
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim B As New Bitmap(Width, Height)
            Dim G As Graphics = Graphics.FromImage(B)
            Dim Curve As Integer = 2


            G.SmoothingMode = SmoothingMode.HighQuality


            Select Case ColorScheme
                Case ColorSchemes.Dark
                    G.Clear(Color.FromArgb(255, 255, 255))
                    G.DrawLine(New Pen(Color.FromArgb(0, 170, 220), 2), New Point(Width - 18, 10), New Point(Width - 14, 14))
                    G.DrawLine(New Pen(Color.FromArgb(0, 170, 220), 2), New Point(Width - 14, 14), New Point(Width - 10, 10))
                    G.DrawLine(New Pen(Color.FromArgb(0, 170, 220)), New Point(Width - 14, 15), New Point(Width - 14, 14))

            End Select
            G.DrawRectangle(New Pen(Color.FromArgb(180, 180, 180)), New Rectangle(0, 0, Width - 1, Height - 1))


            Try
                Select Case ColorScheme
                    Case ColorSchemes.Dark
                        G.DrawString(Text, Font, Brushes.Gray, New Rectangle(7, 0, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                End Select
            Catch
            End Try

            e.Graphics.DrawImage(B.Clone(), 0, 0)
            G.Dispose() : B.Dispose()
        End Sub
    End Class

    Public Class HuraProgressBar
        Inherits Control

#Region "Declarations"
        Private _ProgressColour As Color = Color.FromArgb(0, 170, 220)
        Private _BorderColour As Color = Color.FromArgb(190, 190, 190)
        Private _BaseColour As Color = Color.FromArgb(255, 255, 255)
        Private _FontColour As Color = Color.FromArgb(50, 50, 50)
        Private _SecondColour As Color = Color.FromArgb(0, 170, 250)
        Private _Value As Integer = 0
        Private _Maximum As Integer = 100
        Private _TwoColour As Boolean = True
#End Region

#Region "Properties"

        Public Property SecondColour As Color
            Get
                Return _SecondColour
            End Get
            Set(value As Color)
                _SecondColour = value
            End Set
        End Property

        <Category("Control")>
        Public Property TwoColour As Boolean
            Get
                Return _TwoColour
            End Get
            Set(value As Boolean)
                _TwoColour = value
            End Set
        End Property

        <Category("Control")>
        Public Property Maximum() As Integer
            Get
                Return _Maximum
            End Get
            Set(V As Integer)
                Select Case V
                    Case Is < _Value
                        _Value = V
                End Select
                _Maximum = V
                Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property Value() As Integer
            Get
                Select Case _Value
                    Case 0
                        Return 0
                        Invalidate()
                    Case Else
                        Return _Value
                        Invalidate()
                End Select
            End Get
            Set(V As Integer)
                Select Case V
                    Case Is > _Maximum
                        V = _Maximum
                        Invalidate()
                End Select
                _Value = V
                Invalidate()
            End Set
        End Property

        <Category("Colours")>
        Public Property ProgressColour As Color
            Get
                Return _ProgressColour
            End Get
            Set(value As Color)
                _ProgressColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BaseColour As Color
            Get
                Return _BaseColour
            End Get
            Set(value As Color)
                _BaseColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BorderColour As Color
            Get
                Return _BorderColour
            End Get
            Set(value As Color)
                _BorderColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property FontColour As Color
            Get
                Return _FontColour
            End Get
            Set(value As Color)
                _FontColour = value
            End Set
        End Property

#End Region

#Region "Events"

        Public Sub Increment(ByVal Amount As Integer)
            Value += Amount
        End Sub

#End Region

#Region "Draw Control"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                     ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim G = e.Graphics
            Dim Base As New Rectangle(0, 0, Width, Height)
            With G
                .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
                .SmoothingMode = SmoothingMode.HighQuality
                .PixelOffsetMode = PixelOffsetMode.HighQuality
                .Clear(BackColor)
                Dim ProgVal As Integer = CInt(_Value / _Maximum * Width)
                Select Case Value
                    Case 0
                        .FillRectangle(New SolidBrush(_BaseColour), Base)
                        .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                        .DrawRectangle(New Pen(_BorderColour, 2), Base)
                    Case _Maximum
                        .FillRectangle(New SolidBrush(_BaseColour), Base)
                        .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                        If _TwoColour Then
                            For i = 0 To (Width - 1) * _Maximum / _Value Step 25
                                G.DrawLine(New Pen(New SolidBrush(_SecondColour), 7), New Point(CInt(i), 0), New Point(CInt(i - 15), Height))
                            Next
                            G.ResetClip()
                        Else
                        End If
                        .DrawRectangle(New Pen(_BorderColour, 2), Base)
                    Case Else
                        .FillRectangle(New SolidBrush(_BaseColour), Base)
                        .FillRectangle(New SolidBrush(_ProgressColour), New Rectangle(0, 0, ProgVal - 1, Height))
                        If _TwoColour Then
                            .SetClip(New Rectangle(0, 0, CInt(Width * _Value / _Maximum - 1), Height - 1))
                            For i = 0 To (Width - 1) * _Maximum / _Value Step 25
                                .DrawLine(New Pen(New SolidBrush(_SecondColour), 7), New Point(CInt(i), 0), New Point(CInt(i - 10), Height))
                            Next
                            .ResetClip()
                        Else
                        End If
                        .DrawRectangle(New Pen(_BorderColour, 2), Base)
                End Select
                .InterpolationMode = CType(7, InterpolationMode)
            End With
        End Sub

#End Region

    End Class

    Class HuraTabControl
        Inherits TabControl

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or _
                     ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
            ItemSize = New Size(0, 30)
            Font = New Font("Segoe UI", 9.5)
        End Sub

        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()
            Alignment = TabAlignment.Top
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

            Dim G As Graphics = e.Graphics

            Dim borderPen As New Pen(Color.FromArgb(255, 255, 255))

            G.SmoothingMode = SmoothingMode.HighQuality
            G.Clear(Parent.BackColor)

            Dim fillRect As New Rectangle(2, ItemSize.Height + 2, Width - 6, Height - ItemSize.Height - 3)

            G.DrawRectangle(borderPen, fillRect)

            Dim FontColor As New Color

            For i = 0 To TabCount - 1

                Dim mainRect As Rectangle = GetTabRect(i)

                If i = SelectedIndex Then

                    G.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), mainRect)
                    G.DrawRectangle(borderPen, mainRect)
                    G.DrawLine(New Pen(Color.FromArgb(0, 173, 220)), New Point(mainRect.X, mainRect.Y + 25), New Point(mainRect.X + mainRect.Width - 0, mainRect.Y + 25))

                    FontColor = Color.FromArgb(150, 150, 150)

                Else

                    G.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), mainRect)
                    G.DrawRectangle(borderPen, mainRect)
                    G.DrawLine(New Pen(Color.FromArgb(200, 200, 200)), New Point(mainRect.X, mainRect.Y + 25), New Point(mainRect.X + mainRect.Width - 0, mainRect.Y + 25))
                    FontColor = Color.FromArgb(180, 180, 180)

                End If

                Dim titleX As Integer = (mainRect.Location.X + mainRect.Width / 2) - (G.MeasureString(TabPages(i).Text, Font).Width / 2)
                Dim titleY As Integer = (mainRect.Location.Y + mainRect.Height / 2) - (G.MeasureString(TabPages(i).Text, Font).Height / 2)
                G.DrawString(TabPages(i).Text, Font, New SolidBrush(FontColor), New Point(titleX, titleY))

                Try : TabPages(i).BackColor = Color.FromArgb(255, 255, 255) : Catch : End Try

            Next

        End Sub

    End Class

    Class HuraAlertBox
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
End Namespace