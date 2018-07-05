Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Namespace A
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
    Class EarnTheme
        Inherits ThemeContainer154

        Sub New()
            TransparencyKey = Color.Fuchsia
            BackColor = Color.FromArgb(240, 240, 240)
            Font = New Font("Segoe UI", 9, FontStyle.Bold)
            SetColor("Border", Color.FromArgb(75, 77, 89))
            SetColor("Text", Color.White)
        End Sub
        Dim Border As Color
        Dim TextBrush As Brush
        Protected Overrides Sub ColorHook()
            Border = GetColor("Border")
            TextBrush = GetBrush("Text")
        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(Border)
            G.FillRectangle(New SolidBrush(Color.FromArgb(242, 242, 242)), New Rectangle(6, 36, Width - 13, Height - 43))
            G.DrawString(FindForm.Text, Font, TextBrush, New Point(8, 10))
            DrawCorners(Color.Fuchsia)
        End Sub
    End Class
    Class EarnButton
        Inherits ThemeControl154

        Dim ButtonColor, c1, c2 As Color
        Dim TextColor As Brush
        Dim Border As Pen

        Sub New()
            SetColor("c1", Color.FromArgb(125, 205, 71))
            SetColor("c2", Color.FromArgb(84, 181, 54))
            SetColor("Text", Color.White)
        End Sub

        Protected Overrides Sub ColorHook()
            c1 = GetColor("c1")
            c2 = GetColor("c2")
            TextColor = GetBrush("Text")
        End Sub

        Protected Overrides Sub PaintHook()
            Dim P1 As Pen = Pens.Green
            G.Clear(c1)
            Select Case State
                Case MouseState.None
                    DrawGradient(c1, c2, 0, 0, Width, Height, 90)
                    DrawText(TextColor, HorizontalAlignment.Center, 0, 0)
                    DrawCorners(Color.FromArgb(240, 240, 240))
                Case MouseState.Over
                    DrawGradient(c2, c1, 0, 0, Width, Height, 90)
                    DrawText(TextColor, HorizontalAlignment.Center, 0, 0)
                    DrawCorners(Color.FromArgb(240, 240, 240))
                Case MouseState.Down
                    DrawGradient(c2, c2, 0, 0, Width, Height, 90)
                    DrawText(TextColor, HorizontalAlignment.Center, 0, 0)
                    DrawCorners(Color.FromArgb(240, 240, 240))
            End Select
        End Sub
    End Class
    Class EarnGroupBox
        Inherits ThemeContainer154

        Sub New()
            ControlMode = True
            TransparencyKey = Color.Fuchsia

            SetColor("Bord", Color.FromArgb(75, 77, 89))
            SetColor("Border", Color.FromArgb(75, 77, 89))
            SetColor("Head", Color.FromArgb(75, 77, 89))
            SetColor("Text", Color.White)
        End Sub

        Dim BordColor As Pen
        Dim HeadColor As Brush
        Dim TextColor As Brush

        Protected Overrides Sub ColorHook()
            TextColor = GetBrush("Text")
            HeadColor = GetBrush("Head")
            BordColor = GetPen("Bord")

        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(Color.FromArgb(242, 242, 242))
            G.FillRectangle(HeadColor, New Rectangle(0, 0, Width - 1, 25))
            G.DrawRectangle(BordColor, New Rectangle(0, 0, Width - 1, Height - 1))
            G.DrawString(Text, Font, TextColor, New Point(7, 6))
            DrawCorners(Color.FromArgb(240, 240, 240))
        End Sub
    End Class

    <DefaultEvent("CheckedChanged")>
    Class EarnRadiobutton
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
                If C IsNot Me AndAlso TypeOf C Is EarnRadiobutton Then
                    DirectCast(C, EarnRadiobutton).Checked = False
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

        Dim TextColor As Brush
        Dim CircleColor As Pen
        Dim Outline As Pen
        Protected Overrides Sub ColorHook()
            TextColor = GetBrush("Text")
            CircleColor = GetPen("Circle")
            Outline = GetPen("Outline")
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
            MyBase.OnTextChanged(e)
            Dim textSize As Integer
            textSize = Me.CreateGraphics.MeasureString(Text, Font).Width
            Me.Width = 20 + textSize + 5
        End Sub

        Protected Overrides Sub PaintHook()
            Dim c1 As Color = Color.FromArgb(130, 208, 73)
            Dim c2 As Color = Color.FromArgb(79, 178, 52)
            G.Clear(Color.FromArgb(240, 240, 240))
            G.SmoothingMode = SmoothingMode.HighQuality
            If _Checked Then
                G.DrawEllipse(Outline, New Rectangle(3, 3, 12, 12))
                G.FillEllipse(New SolidBrush(Color.FromArgb(79, 178, 52)), New Rectangle(6, 6, 6, 6))
            Else
                G.DrawEllipse(Outline, New Rectangle(3, 3, 12, 12))
            End If
            G.DrawString(Text, Font, TextColor, New Point(22, 2))
        End Sub

        Public Sub New()
            SetColor("Text", Color.FromArgb(75, 77, 89))
            SetColor("Circle", Color.FromArgb(214, 214, 214))
            SetColor("Outline", Color.FromArgb(75, 77, 89))
        End Sub
    End Class
    Class EarnTextBox
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


            SetColor("Text", Color.FromArgb(75, 77, 89))
            SetColor("Backcolor", BackColor)
            SetColor("Border", 75, 77, 89)
        End Sub

        Private BG As Color
        Private P1 As Pen

        Protected Overrides Sub ColorHook()
            BG = GetColor("Backcolor")

            P1 = GetPen("Border")

            Base.ForeColor = GetColor("Text")
            Base.BackColor = GetColor("Backcolor")
        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(BG)
            DrawBorders(P1)
            DrawCorners(Color.FromArgb(240, 240, 240))
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
    Class EarnProgressBar
        Inherits ThemeControl154

        Dim G1, G2, G3, Glow, Edge1, Edge2 As Color
        Dim GlowPosition As Integer

        Private _Minimum As Integer
        Property Minimum() As Integer
            Get
                Return _Minimum
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    Throw New Exception("Property value is not valid.")
                End If

                _Minimum = value
                If value > _Value Then _Value = value
                If value > _Maximum Then _Maximum = value
                Invalidate()
            End Set
        End Property

        Private _Maximum As Integer = 100
        Property Maximum() As Integer
            Get
                Return _Maximum
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    Throw New Exception("Property value is not valid.")
                End If

                _Maximum = value
                If value < _Value Then _Value = value
                If value < _Minimum Then _Minimum = value
                Invalidate()
            End Set
        End Property

        Property Animated() As Boolean
            Get
                Return IsAnimated
            End Get
            Set(ByVal value As Boolean)
                IsAnimated = value
                Invalidate()
            End Set
        End Property

        Private _Value As Integer
        Property Value() As Integer
            Get
                Return _Value
            End Get
            Set(ByVal value As Integer)
                If value > _Maximum OrElse value < _Minimum Then
                    Throw New Exception("Property value is not valid.")
                End If

                _Value = value
                Invalidate()
            End Set
        End Property

        Private Sub Increment(ByVal amount As Integer)
            Value += amount
        End Sub

        Sub New()
            SetColor("Gradient 1", 240, 240, 240)
            SetColor("Gradient 2", 79, 178, 52)
            SetColor("Gradient 3", 130, 208, 73)
            SetColor("Glow", Color.Transparent)
            SetColor("Edge1", 75, 77, 89)
            SetColor("Edge2", 240, 240, 240)
            IsAnimated = True

        End Sub

        Protected Overrides Sub ColorHook()
            G1 = GetColor("Gradient 1")
            G2 = GetColor("Gradient 2")
            G3 = GetColor("Gradient 3")
            Glow = GetColor("Glow")
            Edge1 = GetColor("Edge1")
            Edge2 = GetColor("Edge2")
        End Sub

        Protected Overrides Sub OnAnimation()
            If GlowPosition = 0 Then
                GlowPosition = 7
            Else
                GlowPosition -= 1
            End If
        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(G1)
            Dim LGB As New LinearGradientBrush(New Rectangle(New Point(1, 1), New Size(Width - 2, Height - 2)), G2, G3, 90.0F)
            G.FillRectangle(LGB, New Rectangle(New Point(1, 1), New Size((Width / Maximum) * Value - 1, Height - 2)))
            G.FillRectangle(New SolidBrush(Glow), New Rectangle(New Point(1, 1), New Size((Width / Maximum) * Value - 1, (Height / 2) - 3)))

            G.RenderingOrigin = New Point(GlowPosition, 0)

            G.DrawLine(New Pen(Edge2), New Point((Width / Maximum) * Value - 1, 1), New Point((Width / Maximum) * Value - 1, Height + 1))
            G.DrawRectangle(New Pen(Edge2), New Rectangle(New Point(2, 2), New Size(Width - 4, Height - 4)))
            G.DrawRectangle(New Pen(Edge1), New Rectangle(New Point(1, 1), New Size(Width - 2, Height - 2)))
            DrawCorners(Color.FromArgb(240, 240, 240))
        End Sub

    End Class

    <DefaultEvent("CheckedChanged")>
    Class EarnCheckBox
        Inherits ThemeControl154

        Sub New()
            LockHeight = 14
            SetColor("Text", 75, 77, 89)
            SetColor("Gradient 1", 240, 240, 240)
            SetColor("Gradient 2", 240, 240, 240)
            SetColor("Glow", 240, 240, 240)
            SetColor("Edges", 127, 128, 136)
            SetColor("Backcolor", BackColor)
            SetColor("Check", 75, 77, 89)
            Width = 160
        End Sub

        Private X As Integer
        Private TextColor, G1, G2, Glow, Edge, BG, Tick As Color

        Protected Overrides Sub ColorHook()
            TextColor = GetColor("Text")
            G1 = GetColor("Gradient 1")
            G2 = GetColor("Gradient 2")
            Glow = GetColor("Glow")
            Edge = GetColor("Edges")
            BG = GetColor("Backcolor")
            Tick = GetColor("Check")
        End Sub

        Protected Overrides Sub OnMouseMove(e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseMove(e)
            X = e.Location.X
            Invalidate()
        End Sub

        Protected Overrides Sub PaintHook()
            G.Clear(BG)
            If _Checked Then
                Dim LGB As New LinearGradientBrush(New Rectangle(New Point(0, 0), New Size(12, 12)), G1, G2, 90.0F)
                G.FillRectangle(LGB, New Rectangle(New Point(0, 0), New Size(12, 12)))
                G.FillRectangle(New SolidBrush(Glow), New Rectangle(New Point(0, 0), New Size(12, 6)))
            Else
                Dim LGB As New LinearGradientBrush(New Rectangle(New Point(0, 0), New Size(12, 12)), G1, G2, 90.0F)
                G.FillRectangle(LGB, New Rectangle(New Point(0, 0), New Size(12, 12)))
                G.FillRectangle(New SolidBrush(Glow), New Rectangle(New Point(0, 0), New Size(12, 6)))
            End If

            G.DrawRectangle(New Pen(Edge), New Rectangle(New Point(0, 0), New Size(12, 12)))

            If _Checked Then G.DrawString("a", New Font("Marlett", 11), Brushes.Green, New Point(-3, -1))
            DrawText(New SolidBrush(Tick), HorizontalAlignment.Left, 19, -1)
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
                    BackColor = Color.FromArgb(75, 77, 89)
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
            BackColor = Color.FromArgb(75, 77, 89)
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
                If X > 33 AndAlso X < 65 Then
                    ButtonState = ButtonHover.Minimize
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
                        G.FillRectangle(New SolidBrush(_AccentColor), New Rectangle(34, 0, 30, Height))
                    End If
                Case ButtonHover.Close
                    G.FillRectangle(New SolidBrush(_AccentColor_Close), New Rectangle(65, 0, 35, Height))
            End Select

            Dim ButtonFont As New Font("Marlett", 9.75F)
            'Close
            G.DrawString("r", ButtonFont, New SolidBrush(Color.FromArgb(150, 150, 150)), New Point(Width - 16, 7), New StringFormat With {.Alignment = StringAlignment.Center})
            'Minimize
            G.DrawString("0", ButtonFont, New SolidBrush(Color.FromArgb(150, 150, 150)), New Point(51, 7), New StringFormat With {.Alignment = StringAlignment.Center})
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

    Module DesignFunctions
        Function ToBrush(ByVal A As Integer, ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Brush
            Return ToBrush(Color.FromArgb(A, R, G, B))
        End Function
        Function ToBrush(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Brush
            Return ToBrush(Color.FromArgb(R, G, B))
        End Function
        Function ToBrush(ByVal A As Integer, ByVal C As Color) As Brush
            Return ToBrush(Color.FromArgb(A, C))
        End Function
        Function ToBrush(ByVal Pen As Pen) As Brush
            Return ToBrush(Pen.Color)
        End Function
        Function ToBrush(ByVal Color As Color) As Brush
            Return New SolidBrush(Color)
        End Function
        Function ToPen(ByVal A As Integer, ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Pen
            Return ToPen(Color.FromArgb(A, R, G, B))
        End Function
        Function ToPen(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Pen
            Return ToPen(Color.FromArgb(R, G, B))
        End Function
        Function ToPen(ByVal A As Integer, ByVal C As Color) As Pen
            Return ToPen(Color.FromArgb(A, C))
        End Function
        Function ToPen(ByVal Color As Color) As Pen
            Return ToPen(New SolidBrush(Color))
        End Function
        Function ToPen(ByVal Brush As SolidBrush) As Pen
            Return New Pen(Brush)
        End Function

        Class CornerStyle
            Public TopLeft As Boolean
            Public TopRight As Boolean
            Public BottomLeft As Boolean
            Public BottomRight As Boolean
        End Class

        Public Function AdvRect(ByVal Rectangle As Rectangle, ByVal CornerStyle As CornerStyle, ByVal Curve As Integer) As GraphicsPath
            AdvRect = New GraphicsPath()
            Dim ArcRectangleWidth As Integer = Curve * 2

            If CornerStyle.TopLeft Then
                AdvRect.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            Else
                AdvRect.AddLine(Rectangle.X, Rectangle.Y, Rectangle.X + ArcRectangleWidth, Rectangle.Y)
            End If

            If CornerStyle.TopRight Then
                AdvRect.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            Else
                AdvRect.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth)
            End If

            If CornerStyle.BottomRight Then
                AdvRect.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
            Else
                AdvRect.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width - ArcRectangleWidth, Rectangle.Y + Rectangle.Height)
            End If

            If CornerStyle.BottomLeft Then
                AdvRect.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
            Else
                AdvRect.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y + Rectangle.Height - ArcRectangleWidth)
            End If

            AdvRect.CloseAllFigures()

            Return AdvRect
        End Function

        Public Function RoundRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
            RoundRect = New GraphicsPath()
            Dim ArcRectangleWidth As Integer = Curve * 2
            RoundRect.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            RoundRect.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            RoundRect.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
            RoundRect.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
            RoundRect.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, ArcRectangleWidth + Rectangle.Y))
            RoundRect.CloseAllFigures()
            Return RoundRect
        End Function

        Public Function RoundRect(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer, ByVal Curve As Integer) As GraphicsPath
            Return RoundRect(New Rectangle(X, Y, Width, Height), Curve)
        End Function

        Class PillStyle
            Public Left As Boolean
            Public Right As Boolean
        End Class

        Public Function Pill(ByVal Rectangle As Rectangle, ByVal PillStyle As PillStyle) As GraphicsPath
            Pill = New GraphicsPath()

            If PillStyle.Left Then
                Pill.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Height), -270, 180)
            Else
                Pill.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y)
            End If

            If PillStyle.Right Then
                Pill.AddArc(New Rectangle(Rectangle.X + Rectangle.Width - Rectangle.Height, Rectangle.Y, Rectangle.Height, Rectangle.Height), -90, 180)
            Else
                Pill.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height)
            End If

            Pill.CloseAllFigures()

            Return Pill
        End Function

        Public Function Pill(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer, ByVal PillStyle As PillStyle)
            Return Pill(New Rectangle(X, Y, Width, Height), PillStyle)
        End Function

    End Module
    Class AresioButton
        Inherits Control

        Enum MouseState
            None
            Over
            Down
        End Enum

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.ResizeRedraw Or
            ControlStyles.UserPaint Or
            ControlStyles.DoubleBuffer, True)
        End Sub

        Private State As MouseState = 0

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.HighQuality

            'Background
            G.FillPath(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(250, 200, 70), Color.FromArgb(250, 160, 40)),
                       RoundRect(0, 0, Width - 1, Height - 1, 4))

            G.DrawPath(ToPen(50, Color.White), RoundRect(0, 1, Width - 1, Height - 2, 4))
            G.DrawPath(ToPen(150, 100, 70), RoundRect(0, 0, Width - 1, Height - 1, 4))
            Select Case Enabled
                Case True
                    Select Case State
                        Case MouseState.Over
                            G.FillPath(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(50, Color.White), Color.Transparent),
               RoundRect(0, 0, Width - 1, Height - 1, 4))
                        Case MouseState.Down
                            G.FillPath(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(50, Color.Black), Color.Transparent),
                       RoundRect(0, 0, Width - 1, Height - 1, 4))
                    End Select

                    G.DrawString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular), ToBrush(100, Color.White), New Point(CInt((Width / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), CInt((Height / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1))
                    G.DrawString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular), ToBrush(200, Color.Black), New Point(CInt((Width / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), CInt((Height / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))))
                Case False
                    G.DrawString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.White, New Point(CInt((Width / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)) + 1, CInt((Height / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1))
                    G.DrawString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.Gray, New Point(CInt((Width / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), CInt((Height / 2) - (G.MeasureString(Text, New Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))))
            End Select
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
            MyBase.OnMouseEnter(e) : State = MouseState.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
            MyBase.OnMouseLeave(e) : State = MouseState.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e) : State = MouseState.Down : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseUp(e) : State = MouseState.Over : Invalidate()
        End Sub
    End Class
    Class AresioTrackBar
        Inherits Control

#Region "Properties"
        Dim _Maximum As Integer = 10
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
        Dim _Value As Integer = 0
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
#End Region

        Sub New()
            Me.SetStyle(ControlStyles.DoubleBuffer Or
                        ControlStyles.AllPaintingInWmPaint Or
                        ControlStyles.ResizeRedraw Or
                        ControlStyles.UserPaint Or
                        ControlStyles.Selectable Or
                        ControlStyles.SupportsTransparentBackColor, True)
        End Sub

        Dim CaptureM As Boolean = False
        Dim Bar As Rectangle = New Rectangle(0, 10, Width - 1, Height - 21)
        Dim Track As Size = New Size(20, 20)

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            Dim G As Graphics = e.Graphics
            Bar = New Rectangle(10, 10, Width - 21, Height - 21)
            G.Clear(Parent.FindForm.BackColor)
            G.SmoothingMode = SmoothingMode.AntiAlias

            'Background
            Dim BackLinear As LinearGradientBrush = New LinearGradientBrush(New Point(0, CInt((Height / 2) - 4)), New Point(0, CInt((Height / 2) + 4)), Color.FromArgb(50, Color.Black), Color.Transparent)
            G.FillPath(BackLinear, RoundRect(0, CInt((Height / 2) - 4), Width - 1, 8, 3))
            G.DrawPath(ToPen(50, Color.Black), RoundRect(0, CInt((Height / 2) - 4), Width - 1, 8, 3))
            BackLinear.Dispose()


            'Fill
            G.FillPath(New LinearGradientBrush(New Point(1, CInt((Height / 2) - 4)), New Point(1, CInt((Height / 2) + 4)), Color.FromArgb(250, 200, 70), Color.FromArgb(250, 160, 40)), RoundRect(1, CInt((Height / 2) - 4), CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2), 8, 3))
            G.DrawPath(ToPen(100, Color.White), RoundRect(2, CInt((Height / 2) - 2), CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2), 4, 3))
            G.SetClip(RoundRect(1, CInt((Height / 2) - 4), CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2), 8, 3))
            For i = 0 To CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2) Step 10
                G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(20, Color.Black)), 4), New Point(i, CInt((Height / 2) - 10)), New Point(i - 10, CInt((Height / 2) + 10)))
            Next
            G.SetClip(New Rectangle(0, 0, Width, Height))

            'Button
            G.FillEllipse(Brushes.White, Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            G.DrawEllipse(ToPen(50, Color.Black), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            G.FillEllipse(New LinearGradientBrush(New Point(0, Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2)), New Point(0, Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2) + Track.Height), Color.FromArgb(200, Color.Black), Color.FromArgb(100, Color.Black)), New Rectangle(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2) + 6, Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2) + 6, Track.Width - 12, Track.Height - 12))

        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
            Me.BackColor = Color.Transparent

            MyBase.OnHandleCreated(e)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseDown(e)
            Dim mp = New Rectangle(New Point(e.Location.X, e.Location.Y), New Size(1, 1))
            Dim Bar As Rectangle = New Rectangle(10, 10, Width - 21, Height - 21)
            If New Rectangle(New Point(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), 0), New Size(Track.Width, Height)).IntersectsWith(mp) Then
                CaptureM = True
            End If
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseUp(e)
            CaptureM = False
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
            MyBase.OnMouseMove(e)
            If CaptureM Then
                Dim mp As Point = New Point(e.X, e.Y)
                Dim Bar As Rectangle = New Rectangle(10, 10, Width - 21, Height - 21)
                Value = CInt(Maximum * ((mp.X - Bar.X) / Bar.Width))
            End If
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
            MyBase.OnMouseLeave(e) : CaptureM = False
        End Sub

    End Class
    Class AresioTabControl
        Inherits TabControl

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.ResizeRedraw Or
            ControlStyles.UserPaint Or
            ControlStyles.DoubleBuffer, True)
        End Sub
        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()
            SizeMode = TabSizeMode.Normal
            ItemSize = New Size(77, 31)
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim G As Graphics = e.Graphics
            Dim ItemBounds As Rectangle
            Dim TextBrush As New SolidBrush(Color.Empty)
            Dim SOFF As Integer = 0
            G.Clear(Color.FromArgb(236, 237, 239))

            For TabItemIndex As Integer = 0 To Me.TabCount - 1
                ItemBounds = Me.GetTabRect(TabItemIndex)

                If Not TabItemIndex = SelectedIndex Then
                    SOFF = 2

                    G.FillPath(ToBrush(10, Color.Black), RoundRect(New Rectangle(New Point(ItemBounds.X, ItemBounds.Y + SOFF), New Size(ItemBounds.Width, ItemBounds.Height)), 2))
                    G.DrawPath(ToPen(90, Color.Black), RoundRect(New Rectangle(New Point(ItemBounds.X, ItemBounds.Y + SOFF), New Size(ItemBounds.Width, ItemBounds.Height)), 2))

                    Dim sf As New StringFormat
                    sf.LineAlignment = StringAlignment.Center
                    sf.Alignment = StringAlignment.Center
                    TextBrush.Color = Color.FromArgb(80, 80, 80)
                    Try
                        G.DrawString(TabPages(TabItemIndex).Text, New Font(Font.Name, Font.Size - 1), TextBrush, New Rectangle(GetTabRect(TabItemIndex).Location, GetTabRect(TabItemIndex).Size), sf)
                        TabPages(TabItemIndex).BackColor = Color.FromArgb(236, 237, 239)
                    Catch : End Try

                End If
            Next

            G.FillPath(ToBrush(236, 237, 239), RoundRect(0, ItemSize.Height - 1, Width - 1, Height - ItemSize.Height - 1, 2))
            G.DrawPath(ToPen(150, 151, 153), RoundRect(0, ItemSize.Height - 1, Width - 1, Height - ItemSize.Height - 1, 2))

            For TabItemIndex As Integer = 0 To Me.TabCount - 1
                ItemBounds = Me.GetTabRect(TabItemIndex)

                If TabItemIndex = SelectedIndex Then

                    G.FillPath(ToBrush(236, 237, 239), RoundRect(New Rectangle(New Point(ItemBounds.X - 2, ItemBounds.Y), New Size(ItemBounds.Width + 3, ItemBounds.Height - 2)), 2))
                    G.DrawPath(ToPen(150, 151, 153), RoundRect(New Rectangle(New Point(ItemBounds.X - 2, ItemBounds.Y), New Size(ItemBounds.Width + 2, ItemBounds.Height - 2)), 2))

                    G.FillRectangle(ToBrush(236, 237, 239), New Rectangle(New Point(ItemBounds.X - 1, ItemBounds.Y + 1), New Size(ItemBounds.Width + 1, ItemBounds.Height)))
                    SOFF = 0

                    Dim sf As New StringFormat
                    sf.LineAlignment = StringAlignment.Center
                    sf.Alignment = StringAlignment.Center
                    TextBrush.Color = Color.FromArgb(80, 80, 80)
                    Try
                        G.DrawString(TabPages(TabItemIndex).Text, Font, TextBrush, New Rectangle(GetTabRect(TabItemIndex).Location + New Point(0, SOFF), GetTabRect(TabItemIndex).Size), sf)
                        TabPages(TabItemIndex).BackColor = Color.FromArgb(236, 237, 239)
                    Catch : End Try

                End If
            Next
        End Sub

    End Class

    Class AresioProgressBar
        Inherits Control

#Region " Properties "

        Private _minimum As Integer
        Public Property Minimum() As Integer
            Get
                Return _minimum
            End Get
            Set(ByVal value As Integer)
                _minimum = value

                If value > _maximum Then _maximum = value
                If value > _value Then _value = value

                Invalidate()
            End Set
        End Property

        Private _maximum As Integer
        Public Property Maximum() As Integer
            Get
                Return _maximum
            End Get
            Set(ByVal value As Integer)
                _maximum = value

                If value < _minimum Then _minimum = value
                If value < _value Then _value = value

                Invalidate()
            End Set
        End Property

        Event ValueChanged()
        Private _value As Integer
        Public Property Value() As Integer
            Get
                Return _value
            End Get
            Set(ByVal value As Integer)
                If value < _minimum Then
                    _value = _minimum
                ElseIf value > _maximum Then
                    _value = _maximum
                Else
                    _value = value
                End If

                Invalidate()
                RaiseEvent ValueChanged()
            End Set
        End Property

#End Region

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.ResizeRedraw Or
                    ControlStyles.UserPaint Or
                    ControlStyles.DoubleBuffer, True)
            _maximum = 100
            _minimum = 0
            _value = 0
        End Sub


        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            Dim G As Graphics = e.Graphics
            G.Clear(Parent.FindForm.BackColor)
            G.SmoothingMode = SmoothingMode.AntiAlias

            'Background
            Dim BackLinear As LinearGradientBrush = New LinearGradientBrush(New Point(0, CInt((Height / 2) - 4)), New Point(0, CInt((Height / 2) + 4)), Color.FromArgb(50, Color.Black), Color.Transparent)
            G.FillPath(BackLinear, RoundRect(0, CInt((Height / 2) - 4), Width - 1, 8, 3))
            G.DrawPath(ToPen(50, Color.Black), RoundRect(0, CInt((Height / 2) - 4), Width - 1, 8, 3))
            BackLinear.Dispose()

            'Fill
            If _value > 0 Then
                G.FillPath(New LinearGradientBrush(New Point(1, CInt((Height / 2) - 4)), New Point(1, CInt((Height / 2) + 4)), Color.FromArgb(250, 200, 70), Color.FromArgb(250, 160, 40)), RoundRect(1, CInt((Height / 2) - 4), CInt((Width - 2) * (Value / Maximum)), 8, 3))
                G.DrawPath(ToPen(100, Color.White), RoundRect(2, CInt((Height / 2) - 2), CInt((Width - 4) * (Value / Maximum)), 4, 3))
            End If
        End Sub
    End Class

    Class AresioRadioButton
        Inherits Control

        Event CheckedChanged()
        Private _checked As Boolean
        Public Property Checked() As Boolean
            Get
                Return _checked
            End Get
            Set(ByVal value As Boolean)
                _checked = value

                Invalidate()
                RaiseEvent CheckedChanged()
            End Set
        End Property

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.ResizeRedraw Or
                    ControlStyles.UserPaint Or
                    ControlStyles.DoubleBuffer, True)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            Dim G As Graphics = e.Graphics

            G.SmoothingMode = SmoothingMode.AntiAlias

            Dim MLG As LinearGradientBrush = New LinearGradientBrush(New Point(Height / 2, 0), New Point(Height / 2, Height), Color.FromArgb(50, Color.Black), Color.Transparent)

            G.FillEllipse(MLG, New Rectangle(0, 0, Height - 1, Height - 1))
            G.DrawEllipse(ToPen(50, Color.Black), New Rectangle(0, 0, Height - 1, Height - 1))

            G.DrawString(Text, Font, Brushes.Black, New Rectangle(Height + 5, 0, Width - Height + 4, Height), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})

            If _checked Then
                Dim MLG2 As LinearGradientBrush = New LinearGradientBrush(New Point(Height / 2, 3), New Point(Height / 2, Height - 6), Color.FromArgb(200, Color.White), Color.FromArgb(10, Color.White))
                G.FillEllipse(MLG2, New Rectangle(3, 3, Height - 7, Height - 7))
                G.DrawEllipse(ToPen(50, Color.Black), New Rectangle(3, 3, Height - 7, Height - 7))
            End If
        End Sub

        Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
            MyBase.OnClick(e)

            If Not Checked Then Checked = True

            For Each ctl As Control In Parent.Controls
                If TypeOf ctl Is AresioRadioButton Then
                    If ctl.Handle = Me.Handle Then Continue For
                    If ctl.Enabled Then DirectCast(ctl, AresioRadioButton).Checked = False
                End If
            Next
        End Sub
    End Class
End Namespace

Namespace BD
    Class BitdefenderForm : Inherits ContainerControl

#Region "Init"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            Dock = DockStyle.Fill
            BackColor = Color.Fuchsia
        End Sub
        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            If FindForm() IsNot Nothing Then
                FindForm.FormBorderStyle = FormBorderStyle.None : FindForm.TransparencyKey = BackColor
            End If

        End Sub

#Region "Property"

        Public Overrides Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                MyBase.Text = value
                Invalidate(New Rectangle(0, 0, Width, 70), False)
            End Set
        End Property



        Private _DisableMax As Boolean
        Public Property DisableControlboxMax As Boolean
            Get
                Return _DisableMax
            End Get
            Set(value As Boolean)
                _DisableMax = value
                Invalidate(False)
            End Set
        End Property

        Private _DisableMin As Boolean
        Public Property DisableControlboxMin As Boolean
            Get
                Return _DisableMin
            End Get
            Set(value As Boolean)
                _DisableMin = value
                Invalidate(False)
            End Set
        End Property

        Private _DisableClose As Boolean
        Public Property DisableControlboxClose As Boolean
            Get
                Return _DisableClose
            End Get
            Set(value As Boolean)
                _DisableClose = value
                Invalidate(False)
            End Set
        End Property
#End Region


#Region "Flag mouse"
        Dim mouseOffset As Point
        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            mouseOffset = New Point(-e.X, -e.Y)
        End Sub
        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)

            '#Zone " Move form "
            For x As Integer = 0 To Width - 1
                For y As Integer = 0 To 30
                    If e.Button = MouseButtons.Left AndAlso e.Location.Equals(New Point(x, y)) Then
                        Dim mousePos = Control.MousePosition
                        mousePos.Offset(mouseOffset.X, mouseOffset.Y)
                        FindForm.Location = mousePos
                    End If
                Next
            Next
            '#End Zone

            '#Zone " None mouse flag "
            MouseState = State.None
            Cursor = Cursors.Default
            '#End Zone

            '#Zone " minRect "
            Dim minRect As Rectangle = New Rectangle(Right - Padding - (controlSize.Width + 20), Padding, btnSize.Width, btnSize.Height)
            If minRect.Contains(e.Location) Then
                Cursor = Cursors.Hand
                MouseState = State.HoverMin
            End If
            '#End Zone

            '#Zone " maxRect "
            Dim maxRect As New Rectangle(minRect.X + 29, minRect.Y, btnSize.Width, btnSize.Height)
            If maxRect.Contains(e.Location) Then
                Cursor = Cursors.Hand
                MouseState = State.HoverMax
            End If
            '#End Zone

            '#Zone " closeRect "
            Dim closeRect As New Rectangle(maxRect.X + 29, minRect.Y, btnSize.Width, btnSize.Height)
            If closeRect.Contains(e.Location) Then
                Cursor = Cursors.Hand
                MouseState = State.HoverClose
            End If
            '#End Zone




        End Sub
        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            Dim min As Rectangle = New Rectangle(Right - Padding - (controlSize.Width + 20), Padding, btnSize.Width, btnSize.Height)
            Dim max As New Rectangle(min.X + 29, min.Y, btnSize.Width, btnSize.Height)
            Dim close As New Rectangle(max.X + 29, max.Y, btnSize.Width, btnSize.Height)

            If min.Contains(e.Location) AndAlso e.Button = MouseButtons.Left AndAlso Not DisableControlboxMin Then
                FindForm.WindowState = FormWindowState.Minimized
            End If

            If max.Contains(e.Location) AndAlso e.Button = MouseButtons.Left AndAlso Not DisableControlboxMax Then
                Select Case FindForm.WindowState
                    Case FormWindowState.Maximized
                        FindForm.WindowState = FormWindowState.Normal
                    Case FormWindowState.Normal
                        FindForm.WindowState = FormWindowState.Maximized
                End Select

            End If

            If close.Contains(e.Location) AndAlso e.Button = MouseButtons.Left AndAlso Not DisableControlboxClose Then
                FindForm.Close()
            End If

        End Sub

#Region "Draw mouse state"
        Private Enum State
            None
            HoverClose
            HoverMax
            HoverMin
        End Enum
        Private _MouseState As State
        Private Property MouseState As State
            Get
                Return _MouseState
            End Get
            Set(value As State)
                _MouseState = value
                Invalidate(False)
            End Set
        End Property
#End Region

#End Region 'Flag mouse


#End Region 'Init

#Region "Draw"

#Region "Init Draw Object"

#Region "Draw Object Declarations"
        Private G As Graphics
        Private Shadows Const Padding As Integer = 10
        '#Zone " Controlbox "
        Private btnSize As Size = New Size(27, 30)
        Private controlSize As Size = New Size(86, btnSize.Height)
        Private controlboxPath As GraphicsPath
        '#End Zone

        Private R1, R2, R4, R5, R6 As Rectangle
        Private GP1, GP2, GP3, GP4 As GraphicsPath
        Private P1, P2, P3, P4, P5, P6 As Pen
        Private B1 As SolidBrush
        Private LGB1, LGB2, LGB3, LGB4, LGB5, LGB6 As LinearGradientBrush
        Private C1, C2, C3, C4, C5, C6, C7, C8, C9, C10 As Color

        Private containerDisposable As New ContainerObjectDisposable

#End Region 'Draw Object Declarations

        Private Sub Init(e As PaintEventArgs)

            G = e.Graphics

            '#Zone " Rectangle "
            R1 = New Rectangle(Padding, Padding, Width - Padding * 2, Height - Padding * 2)
            R2 = New Rectangle(R1.X + 1, R1.Y + 1, R1.Width - 2, R1.Height - 2)
            R4 = New Rectangle(Padding, Padding, Width, 20)
            R5 = New Rectangle(Right - Padding - (controlSize.Width + 20), Padding, controlSize.Width, controlSize.Height)
            R6 = New Rectangle(R5.X + 1, R5.Y + 1, R5.Width - 2, R5.Height - 2)
            '#End Zone

            '#Zone " Graphic path "
            GP1 = RoundRect(R1, 18)
            GP2 = RoundRect(R2, 18)
            GP3 = ControlRect(R5, 9)
            GP4 = ControlRect(R6, 9)
            controlboxPath = New GraphicsPath
            containerDisposable.AddObjectRange({GP1, GP2, GP3, GP4, controlboxPath})
            '#End Zone

            '#Zone " Brush "
            B1 = New SolidBrush(Color.FromArgb(32, 32, 32))
            containerDisposable.AddObject(B1)
            '#End Zone

            '#Zone " Color "
            C1 = Color.FromArgb(81, 81, 81)
            C2 = Color.FromArgb(43, 43, 43)
            C3 = Color.FromArgb(21, 21, 21)
            C4 = Color.FromArgb(10, 10, 10)
            C5 = Color.FromArgb(167, 167, 167)
            C6 = Color.FromArgb(83, 83, 83)
            C7 = Color.FromArgb(41, 41, 41)
            C8 = Color.FromArgb(33, 33, 33)
            C9 = Color.FromArgb(41, 41, 41)
            C10 = Color.FromArgb(77, 77, 77)
            '#End Zone

            '#Zone " Linear Gradient Brush "
            LGB1 = New LinearGradientBrush(R4, C1, C2, LinearGradientMode.Vertical)
            LGB2 = New LinearGradientBrush(R5, C6, C7, LinearGradientMode.Vertical)
            LGB3 = New LinearGradientBrush(R5, C8, C7, LinearGradientMode.Vertical)
            LGB4 = New LinearGradientBrush(New Point(R5.Left + 27, R5.Top + 2), New Point(R5.Left + 27, R5.Bottom - 2), C3, C4)
            LGB5 = New LinearGradientBrush(New Point(R5.Left + 28, R5.Top + 2), New Point(R5.Left + 28, R5.Bottom - 1), C5, C6)
            LGB6 = New LinearGradientBrush(R5, C9, C10, LinearGradientMode.Vertical)
            containerDisposable.AddObjectRange({LGB1, LGB2, LGB3, LGB4, LGB5, LGB6})

            '#End Zone

            '#Zone " Pen "
            P1 = New Pen(Color.FromArgb(33, 33, 33))
            P2 = New Pen(Color.FromArgb(240, 240, 240))
            P3 = New Pen(LGB3)
            P4 = New Pen(New SolidBrush(Color.FromArgb(83, 83, 83)))
            P5 = New Pen(LGB4)
            P6 = New Pen(LGB5)
            containerDisposable.AddObjectRange({P1, P2, P3, P4, P5, P6})
            '#End Zone


        End Sub

#End Region 'Init Draw Object



        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            ''#Zone " DebugMode "
#If DEBUG Then
            'Dim ST As New Stopwatch : ST.Start()
#End If

            '#End Zone

            Init(e)

            '#Zone " Draw background"
            G.FillPath(B1, GP1)
            '#End Zone

            '#Zone " Draw header "
            G.SetClip(GP2)
            G.FillRectangle(LGB1, R4)
            G.ResetClip()
            '#End Zone

            '#Zone " Draw title "
            G.DrawString(Text, New Font("Microsoft Sans Serif", 10, FontStyle.Regular), Brushes.White, 27, 22)
            '#End Zone

            '#Zone " Draw border "
            G.DrawPath(P1, GP1)
            G.DrawPath(P2, GP2)
            '#End Zone

            '#Zone " Mouse state "
            Select Case MouseState
                Case State.HoverClose
                    DrawControlBox_Close(G)
                Case State.HoverMax
                    DrawControlBox_Max(G)
                Case State.HoverMin
                    DrawControlBox_Min(G)
                Case State.None
                    DrawControlBox(G)
            End Select
            '#End Zone

            '#Zone " Dispose all draw object "
            containerDisposable.Dispose()
            '#End Zone

            '#Zone " DebugMode "
#If DEBUG Then
            'Debug.WriteLine(ST.Elapsed.ToString)
#End If

            '#End Zone

        End Sub

        Private Sub DrawControlBox(ByVal G As Graphics)

            G.SmoothingMode = SmoothingMode.HighQuality

            G.FillPath(LGB2, GP3)
            G.DrawPath(P3, GP3)
            G.DrawPath(P4, GP4)
            '#Zone " If you want white line "
            G.DrawLine(P2, R5.Left, R5.Top + 1, R5.Right, R5.Top + 1)
            '#End Zone
            '#Zone " Fix     !important "
            G.DrawLine(P3, R5.Right, R5.Top, R5.Right, R5.Bottom - 4)
            G.DrawLine(P4, R6.Right, R6.Top + 1, R6.Right, R6.Bottom - 4)

            G.SmoothingMode = SmoothingMode.Default

            G.FillRectangle(P3.Brush, New Rectangle(R5.X, R5.Y + 1, 1, 1))
            G.FillRectangle(P3.Brush, New Rectangle(R5.Right, R5.Top + 1, 1, 1))
            '#End Zone
            '#Zone " First line "
            G.DrawLine(P5, R5.Left + 29, R5.Top + 2, R5.Left + 29, R5.Bottom - 2)
            G.DrawLine(P6, R5.Left + 30, R5.Top + 2, R5.Left + 30, R5.Bottom - 2)
            '#End Zone
            '#Zone " Second line "
            G.DrawLine(P5, R5.Left + 56, R5.Top + 2, R5.Left + 56, R5.Bottom - 2)
            G.DrawLine(P6, R5.Left + 57, R5.Top + 2, R5.Left + 57, R5.Bottom - 2)
            '#End Zone



            '#Zone " close string "
            controlboxPath.AddString("r", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width + 20) + 2, Padding + 8), Nothing)
            G.FillPath(Brushes.White, controlboxPath)
            G.DrawPath(Pens.Black, controlboxPath)
            '#End Zone

            '#Zone " max string "
            Select Case FindForm.WindowState
                Case FormWindowState.Maximized
                    controlboxPath.AddString("2", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 4, Padding + 8), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)

                Case FormWindowState.Normal
                    controlboxPath.AddString("1", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 2, Padding + 8), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)
            End Select
            '#End Zone

            '#Zone " min string "
            controlboxPath.AddString("0", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 3 + 20) + 2, Padding + 8), Nothing)
            G.DrawPath(Pens.Black, controlboxPath)
            G.FillPath(Brushes.White, controlboxPath)
            '#End Zone

        End Sub

        Private Sub DrawControlBox_Close(ByVal G As Graphics)
            G.SmoothingMode = SmoothingMode.HighQuality

            G.FillPath(LGB2, GP3)

            G.SetClip(New Rectangle(Right - Padding - (btnSize.Width + 23) + 1, Padding, btnSize.Width + 3, btnSize.Height))
            G.FillPath(LGB6, GP3)
            G.ResetClip()

            G.DrawPath(P3, GP3)
            G.DrawPath(P4, GP4)

            '#Zone " If you want white line "
            G.DrawLine(P2, R5.Left, R5.Top + 1, R5.Right, R5.Top + 1)
            '#End Zone

            '#Zone " Fix     !important "
            G.DrawLine(P3, R5.Right, R5.Top, R5.Right, R5.Bottom - 4)
            G.DrawLine(P4, R6.Right, R6.Top + 1, R6.Right, R6.Bottom - 4)

            G.SmoothingMode = SmoothingMode.Default

            G.FillRectangle(P3.Brush, New Rectangle(R5.X, R5.Y + 1, 1, 1))
            G.FillRectangle(P3.Brush, New Rectangle(R5.Right, R5.Top + 1, 1, 1))
            '#End Zone

            '#Zone " First line "
            G.DrawLine(P5, R5.Left + 29, R5.Top + 2, R5.Left + 29, R5.Bottom - 2)
            G.DrawLine(P6, R5.Left + 30, R5.Top + 2, R5.Left + 30, R5.Bottom - 2)
            '#End Zone

            '#Zone " Second line "
            G.DrawLine(P5, R5.Left + 56, R5.Top + 2, R5.Left + 56, R5.Bottom - 2)
            '#End Zone

            '#Zone " close string "
            controlboxPath.AddString("r", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width + 20) + 2, Padding + 10), Nothing)
            G.FillPath(Brushes.White, controlboxPath)
            G.DrawPath(Pens.Black, controlboxPath)
            '#End Zone

            '#Zone " max string "
            Select Case FindForm.WindowState
                Case FormWindowState.Maximized
                    controlboxPath.AddString("2", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 4, Padding + 8), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)

                Case FormWindowState.Normal
                    controlboxPath.AddString("1", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 2, Padding + 8), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)
            End Select
            '#End Zone

            '#Zone " min string "
            controlboxPath.AddString("0", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 3 + 20) + 2, Padding + 8), Nothing)
            G.DrawPath(Pens.Black, controlboxPath)
            G.FillPath(Brushes.White, controlboxPath)
            '#End Zone

        End Sub

        Private Sub DrawControlBox_Max(ByVal G As Graphics)
            G.SmoothingMode = SmoothingMode.HighQuality

            G.FillPath(LGB2, GP3)

            G.SetClip(New Rectangle(Right - Padding - (btnSize.Width * 2 + 23) + 1, Padding, btnSize.Width, btnSize.Height))
            G.FillPath(LGB6, GP3)
            G.ResetClip()

            G.DrawPath(P3, GP3)
            G.DrawPath(P4, GP4)

            '#Zone " If you want white line "
            G.DrawLine(P2, R5.Left, R5.Top + 1, R5.Right, R5.Top + 1)
            '#End Zone

            '#Zone " Fix     !important "
            G.DrawLine(P3, R5.Right, R5.Top, R5.Right, R5.Bottom - 4)
            G.DrawLine(P4, R6.Right, R6.Top + 1, R6.Right, R6.Bottom - 4)

            G.SmoothingMode = SmoothingMode.Default

            G.FillRectangle(P3.Brush, New Rectangle(R5.X, R5.Y + 1, 1, 1))
            G.FillRectangle(P3.Brush, New Rectangle(R5.Right, R5.Top + 1, 1, 1))
            '#End Zone

            '#Zone " First line "
            G.DrawLine(P5, R5.Left + 29, R5.Top + 2, R5.Left + 29, R5.Bottom - 2)
            '#End Zone

            '#Zone " Second line "
            G.DrawLine(P5, R5.Left + 56, R5.Top + 2, R5.Left + 56, R5.Bottom - 2)
            G.DrawLine(P6, R5.Left + 57, R5.Top + 2, R5.Left + 57, R5.Bottom - 2)
            '#End Zone

            '#Zone " close string "
            controlboxPath.AddString("r", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width + 20) + 2, Padding + 8), Nothing)
            G.FillPath(Brushes.White, controlboxPath)
            G.DrawPath(Pens.Black, controlboxPath)
            '#End Zone

            '#Zone " max string "
            Select Case FindForm.WindowState
                Case FormWindowState.Maximized
                    controlboxPath.AddString("2", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 4, Padding + 10), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)

                Case FormWindowState.Normal
                    controlboxPath.AddString("1", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 2, Padding + 10), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)
            End Select
            '#End Zone

            '#Zone " min string "
            controlboxPath.AddString("0", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 3 + 20) + 2, Padding + 8), Nothing)
            G.DrawPath(Pens.Black, controlboxPath)
            G.FillPath(Brushes.White, controlboxPath)
            '#End Zone
        End Sub

        Private Sub DrawControlBox_Min(ByVal G As Graphics)
            G.SmoothingMode = SmoothingMode.HighQuality

            G.FillPath(LGB2, GP3)

            G.SetClip(New Rectangle(Right - Padding - (controlSize.Width + 20) + 1, Padding, btnSize.Width + 3, btnSize.Height))
            G.FillPath(LGB6, GP3)
            G.ResetClip()

            G.DrawPath(P3, GP3)
            G.DrawPath(P4, GP4)

            '#Zone " If you want white line "
            G.DrawLine(P2, R5.Left, R5.Top + 1, R5.Right, R5.Top + 1)
            '#End Zone

            '#Zone " Fix     !important "
            G.DrawLine(P3, R5.Right, R5.Top, R5.Right, R5.Bottom - 4)
            G.DrawLine(P4, R6.Right, R6.Top + 1, R6.Right, R6.Bottom - 4)

            G.SmoothingMode = SmoothingMode.Default

            G.FillRectangle(P3.Brush, New Rectangle(R5.X, R5.Y + 1, 1, 1))
            G.FillRectangle(P3.Brush, New Rectangle(R5.Right, R5.Top + 1, 1, 1))
            '#End Zone

            '#Zone " First line "
            G.DrawLine(P5, R5.Left + 29, R5.Top + 2, R5.Left + 29, R5.Bottom - 2)
            G.DrawLine(P6, R5.Left + 30, R5.Top + 2, R5.Left + 30, R5.Bottom - 2)
            '#End Zone

            '#Zone " Second line "
            G.DrawLine(P5, R5.Left + 56, R5.Top + 2, R5.Left + 56, R5.Bottom - 2)
            G.DrawLine(P6, R5.Left + 57, R5.Top + 2, R5.Left + 57, R5.Bottom - 2)

            '#End Zone

            '#Zone " close string "
            controlboxPath.AddString("r", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width + 20) + 2, Padding + 8), Nothing)
            G.FillPath(Brushes.White, controlboxPath)
            G.DrawPath(Pens.Black, controlboxPath)
            '#End Zone

            '#Zone " max string "
            Select Case FindForm.WindowState
                Case FormWindowState.Maximized
                    controlboxPath.AddString("2", New FontFamily("Webdings"), FontStyle.Regular, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 4, Padding + 8), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)

                Case FormWindowState.Normal
                    controlboxPath.AddString("1", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 2 + 20) + 2, Padding + 8), Nothing)
                    G.DrawPath(Pens.Black, controlboxPath)
                    G.FillPath(Brushes.White, controlboxPath)
            End Select
            '#End Zone

            '#Zone " min string "
            controlboxPath.AddString("0", New FontFamily("Webdings"), FontStyle.Bold, 15, New Point(Right - Padding - (btnSize.Width * 3 + 20) + 2, Padding + 10), Nothing)
            G.DrawPath(Pens.Black, controlboxPath)
            G.FillPath(Brushes.White, controlboxPath)
            '#End Zone
        End Sub


        Private Function ControlRect(ByVal R As Rectangle, ByVal radius As Integer)
            Dim GP As New GraphicsPath
            GP.AddArc(R.Right - radius, R.Bottom - radius, radius, radius, 0, 90)
            GP.AddArc(R.X, R.Bottom - radius, radius, radius, 90, 90)
            GP.AddLine(R.Left, R.Top, R.Right, R.Top)
            Return GP
        End Function


#End Region 'Draw

    End Class

    Class BitdefenderSeparator : Inherits Control
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
            Width = 400
            Height = 3
            BackColor = Color.Transparent
        End Sub

#Region "Declarations"
        Private G As Graphics
        Private LGB1, LGB2 As LinearGradientBrush
        Private P1, P2 As Pen
        Private CB1, CB2 As ColorBlend
        Private C1, C2 As Color
        Private conObj As New ContainerObjectDisposable
#End Region 'Declarations
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            '#Zone " Declarations "
            Dim Colors1, Colors2 As New List(Of Color)

            C1 = Color.FromArgb(62, 62, 62)
            C2 = Color.FromArgb(1, 1, 1)

            G = e.Graphics

            LGB1 = New LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Nothing, Nothing)
            LGB2 = New LinearGradientBrush(New Point(0, 1), New Point(Width, 1), Nothing, Nothing)
            conObj.AddObjectRange({LGB1, LGB2})

            CB1 = New ColorBlend
            CB2 = New ColorBlend
            '#End Zone

            '#Zone " Colors first line "
            For i As Integer = 0 To 255 Step 51
                Colors1.Add(Color.FromArgb(i, C1))
            Next
            For i As Integer = 255 To 0 Step -51
                Colors1.Add(Color.FromArgb(i, C1))
            Next
            '#End Zone

            '#Zone " Colors Second line "
            For i As Integer = 0 To 255 Step 51
                Colors2.Add(Color.FromArgb(i, C2))
            Next
            For i As Integer = 255 To 0 Step -51
                Colors2.Add(Color.FromArgb(i, C2))
            Next
            '#End Zone

            '#Zone " colorblend first line  "
            CB1.Colors = Colors1.ToArray
            CB1.Positions = {0.0, 0.08, 0.16, 0.24, 0.32, 0.4, 0.48, 0.56, 0.64, 0.72, 0.8, 1.0}
            '#End Zone

            '#Zone " colorblend second line "
            CB2.Colors = Colors2.ToArray
            CB2.Positions = {0.0, 0.08, 0.16, 0.24, 0.32, 0.4, 0.48, 0.56, 0.64, 0.72, 0.8, 1.0}
            '#End Zone

            '#Zone " Pen "
            LGB1.InterpolationColors = CB1
            LGB2.InterpolationColors = CB2

            P1 = New Pen(LGB1)
            P2 = New Pen(LGB2)
            conObj.AddObjectRange({P1, P2})
            '#End Zone

            G.DrawLine(P1, 0, 0, Width, 0)
            G.DrawLine(P2, 0, 1, Width, 1)

            conObj.Dispose()
        End Sub
    End Class

    <DefaultEvent("ChangeChecked")>
    Class BitdefenderCheckbox : Inherits Control
#Region "Init"
#Region "Event"
        Public Event ChangeChecked(ByVal sender As Object, ByVal check As Boolean)
        Private _Check As Boolean
        Public Property Checked As Boolean
            Get
                Return _Check
            End Get
            Set(value As Boolean)
                _Check = value
                Invalidate()

                RaiseEvent ChangeChecked(Me, value)
            End Set
        End Property

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e) : Checked = Not Checked
        End Sub

#End Region 'Event

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
            Width = 55
            Height = 25
            BackColor = Color.Transparent
            oldsize = New Size(55, 25)
        End Sub
#End Region 'Init

#Region "draw"

#Region "draw init object"

#Region "Declaration draw object"
        Private cn As ContainerObjectDisposable
        Private R1, R2, R3, R4, R5, R6 As Rectangle
        Private GP1, GP2, GP3, GP4, GP5, GP6 As GraphicsPath
        Private LGB1, LGB2, LGB3, LGB4 As LinearGradientBrush
        Private PGB1 As PathGradientBrush
        Private B1, B2, B3 As SolidBrush
        Private G As Graphics
        Private P1, P2 As Pen
        Dim CheckSize As Size
#End Region 'Declaration draw object
        Private Sub Init(e As PaintEventArgs)
            G = e.Graphics
            cn = New ContainerObjectDisposable
            R1 = New Rectangle(1, 1, Width - 2, Height - 2)
            R2 = New Rectangle(2, 2, Width - 4, Height - 4)

            GP1 = RoundRect(R1, 11) : cn.AddObject(GP1)
            GP2 = RoundRect(R2, 11) : cn.AddObject(GP2)

            B1 = New SolidBrush(Color.FromArgb(40, 40, 40)) : cn.AddObject(B1)
            If Checked Then
                B2 = New SolidBrush(Color.FromArgb(84, 135, 171))
                PGB1 = New PathGradientBrush(GP2) With {.CenterColor = Color.FromArgb(84, 135, 171), .SurroundColors = {Color.FromArgb(113, 176, 200)}, .FocusScales = New PointF(0.85, 0.65)}

            Else
                B2 = New SolidBrush(Color.FromArgb(29, 29, 29))
                PGB1 = New PathGradientBrush(GP2) With {.CenterColor = Color.FromArgb(29, 29, 29), .SurroundColors = {Color.FromArgb(39, 39, 39)}, .FocusScales = New PointF(0.85, 0.65)}
            End If
            cn.AddObjectRange({B2, PGB1})
            B3 = New SolidBrush(Color.FromArgb(107, 107, 107))
            cn.AddObject(B3)

            CheckSize = New Size(22, R2.Height)
            R3 = New Rectangle(Width - 2 - 22, 2, CheckSize.Width, CheckSize.Height)
            GP3 = RoundRect(R3, 11)
            R4 = New Rectangle(R3.X + 1, R3.Y + 1, R3.Width - 2, R3.Height - 2)
            GP4 = RoundRect(R4, 11)

            R5 = New Rectangle(0, 2, CheckSize.Width, CheckSize.Height)
            GP5 = RoundRect(R5, 11)
            R6 = New Rectangle(R5.X + 1, R5.Y + 1, R5.Width - 2, R5.Height - 2)
            GP6 = RoundRect(R6, 11)
            cn.AddObjectRange({GP3, GP4, GP5, GP6})
            If Hover Then
                LGB1 = New LinearGradientBrush(R3, Color.FromArgb(86, 86, 86), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical)
                LGB2 = New LinearGradientBrush(New Rectangle(R4.X - 1, R4.Y - 1, R4.Width + 2, R4.Height + 2), Color.FromArgb(147, 147, 147), Color.FromArgb(68, 68, 68), LinearGradientMode.Vertical)
                P1 = New Pen(LGB2)

                LGB3 = New LinearGradientBrush(R5, Color.FromArgb(86, 86, 86), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical)
                LGB4 = New LinearGradientBrush(New Rectangle(R6.X - 1, R6.Y - 1, R6.Width + 2, R6.Height + 2), Color.FromArgb(147, 147, 147), Color.FromArgb(68, 68, 68), LinearGradientMode.Vertical)
                P2 = New Pen(LGB4)

            Else
                LGB1 = New LinearGradientBrush(R3, Color.FromArgb(59, 59, 59), Color.FromArgb(29, 29, 29), LinearGradientMode.Vertical)
                LGB2 = New LinearGradientBrush(New Rectangle(R4.X - 1, R4.Y - 1, R4.Width + 2, R4.Height + 2), Color.FromArgb(101, 101, 101), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical)
                P1 = New Pen(LGB2)

                LGB3 = New LinearGradientBrush(R5, Color.FromArgb(59, 59, 59), Color.FromArgb(29, 29, 29), LinearGradientMode.Vertical)
                LGB4 = New LinearGradientBrush(New Rectangle(R6.X - 1, R6.Y - 1, R6.Width + 2, R6.Height + 2), Color.FromArgb(101, 101, 101), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical)
                P2 = New Pen(LGB4)

            End If
            cn.AddObjectRange({LGB1, LGB2, LGB3, LGB4, P1, P2})


        End Sub
#End Region 'draw init object

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Init(e)
            G.SmoothingMode = SmoothingMode.AntiAlias
            G.InterpolationMode = InterpolationMode.HighQualityBicubic
            G.FillPath(B1, GP1)

            If Checked Then

                G.FillPath(B2, GP2)
                G.FillPath(PGB1, GP2)
                G.DrawPath(Pens.Black, GP2)
                If Hover Then
                    G.FillPath(LGB1, GP3)
                    G.DrawPath(Pens.Black, GP3)
                    G.DrawPath(P1, GP4)
                    G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.Black, 7, 6)
                    G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.White, 7, 7)
                Else
                    G.FillPath(LGB1, GP3)
                    G.DrawPath(Pens.Black, GP3)
                    G.DrawPath(P1, GP4)
                    G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.Black, 7, 6)
                    G.DrawString("ON", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.White, 7, 7)
                End If
            Else
                G.FillPath(B1, GP1)
                G.FillPath(B2, GP2)
                G.FillPath(PGB1, GP2)
                G.DrawPath(Pens.Black, GP2)
                If Hover Then
                    G.FillPath(LGB3, GP5)
                    G.DrawPath(Pens.Black, GP5)
                    G.DrawPath(P2, GP6)
                    G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.Black, Width - 29, 6)
                    G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), B3, Width - 29, 7)
                Else
                    G.FillPath(LGB3, GP5)
                    G.DrawPath(Pens.Black, GP5)
                    G.DrawPath(P2, GP6)
                    G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.Black, Width - 29, 6)
                    G.DrawString("OFF", New Font("Microsoft Sans Serif", 7, FontStyle.Bold), B3, Width - 29, 7)
                End If

            End If
            cn.Dispose()
        End Sub
        Private _Hover As Boolean
        Private Property Hover As Boolean
            Get
                Return _Hover
            End Get
            Set(value As Boolean)
                _Hover = value
                Invalidate()
            End Set
        End Property
        Protected Overrides Sub onmouseenter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            Hover = True
        End Sub
        Protected Overrides Sub onmouseleave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            Hover = False
        End Sub
        Dim oldsize As Size

        Protected Overrides Sub onclientsizechanged(e As EventArgs)
            MyBase.OnClientSizeChanged(e)
            Me.Size = oldsize

        End Sub
#End Region 'draw

    End Class

    Class BitdefenderButton : Inherits Control

#Region "Init"
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
            Width = 100
            Height = 55
            BackColor = Color.Transparent
        End Sub


        Public Overrides Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                MyBase.Text = value
                Invalidate()
            End Set
        End Property

        Private _Down As Boolean
        Private Property Down As Boolean
            Get
                Return _Down
            End Get
            Set(value As Boolean)
                _Down = value
                Invalidate()
            End Set
        End Property
        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e) : Down = True
        End Sub
        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e) : Down = False
        End Sub

#Region "Mouse state"

        Private OpenT As Thread
        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            OpenT = New Thread(AddressOf EnterAnimation)
            If Not OpenT.IsAlive Then
                OpenT.IsBackground = True
                OpenT.Start()
            End If
        End Sub
        Private Sub EnterAnimation()
            Dim G As Graphics = Me.CreateGraphics()
            R2 = New Rectangle(5, 5, Width - 10, Height - 10)
            GP2 = RoundRect(R2, 11)
            G.SetClip(GP2)
            For fade As Integer = 0 To 5 Step 0.85
                Thread.Sleep(50)
                G.FillRectangle(New SolidBrush(Color.FromArgb(fade, Color.White)), ClientRectangle)
            Next
        End Sub


#End Region 'Mouse state

#End Region 'Init


#Region "Draw"
#Region "Draw init Object"
        Private C1, C3, C4, C5, C6 As Color
        Private R1, R2, R3 As Rectangle
        Private GP1, GP2, GP3 As GraphicsPath
        Private B1, B2 As SolidBrush
        Private P1, P2 As Pen
        Private LGB1, LGB2 As LinearGradientBrush
        Private SF1 As StringFormat
        Private G As Graphics

        Private Sub Init(e As PaintEventArgs)
            G = e.Graphics
            R1 = New Rectangle(3, 3, Width - 6, Height - 6)
            R2 = New Rectangle(5, 5, Width - 10, Height - 10)
            R3 = New Rectangle(6, 6, Width - 12, Height - 12)

            GP1 = RoundRect(R1, 11)
            GP2 = RoundRect(R2, 11)
            GP3 = RoundRect(R3, 11)


            C1 = Color.FromArgb(100, 41, 41, 41)
            C3 = Color.FromArgb(101, 101, 101)
            C4 = Color.FromArgb(60, 60, 60)
            C5 = Color.FromArgb(28, 28, 28)
            C6 = Color.FromArgb(45, 45, 45)

            B1 = New SolidBrush(C1)
            B2 = Brushes.White
            LGB1 = New LinearGradientBrush(R2, C4, C5, LinearGradientMode.Vertical)
            LGB2 = New LinearGradientBrush(R3, C3, C6, LinearGradientMode.Vertical)

            P1 = New Pen(Brushes.Black)
            P2 = New Pen(LGB2)

            SF1 = New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.Character}


        End Sub
#End Region 'Draw init Object

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Init(e)
            G.SmoothingMode = SmoothingMode.HighQuality
            G.FillPath(B1, GP1)
            G.FillPath(LGB1, GP2)
            G.DrawPath(P1, GP2)
            G.DrawPath(P2, GP3)
            If Not Down Then
                G.DrawString(Text, Font, B2, R3, SF1)
            Else
                R3.X += 1 : R3.Y += 1
                G.DrawString(Text, Font, B2, R3, SF1)
            End If


        End Sub


#End Region 'Draw

    End Class

    Class BitdefenderGroupbox : Inherits ContainerControl
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
            Width = 100
            Height = 55
            BackColor = Color.Transparent
        End Sub

#Region "property"
        <Browsable(False)>
        Public Overloads Property Text As String

        Private _Title As String = "Title"
        Private _SubTitle As String = "Subtitle"

        Public Property Title As String
            Get
                Return _Title
            End Get
            Set(value As String)
                _Title = value
                Invalidate(False)
            End Set
        End Property
        Public Property Subtitle As String
            Get
                Return _SubTitle
            End Get
            Set(value As String)
                _SubTitle = value
                Invalidate(False)
            End Set
        End Property
#End Region 'property


        Private R1, R2 As Rectangle
        Private GP1, GP2 As GraphicsPath
        Private P1, P2 As Pen
        Private B1, B2 As SolidBrush
        Private SZ1, SZ2 As Size
        Private F1, F2 As Font
        Private S1, S2 As String
        Private G As Graphics
        Private Sub Init(e As PaintEventArgs)
            G = e.Graphics

            R1 = New Rectangle(3, 3, Width - 6, Height - 6)
            R2 = New Rectangle(4, 4, Width - 8, Height - 8)

            GP1 = RoundRect(R1, 11)
            GP2 = RoundRect(R2, 11)

            P1 = Pens.Black
            P2 = New Pen(New SolidBrush(Color.FromArgb(68, 68, 68)))

            B1 = New SolidBrush(Color.FromArgb(41, 41, 41))
            B2 = Brushes.White

            F1 = New Font("Verdana", 10, FontStyle.Bold)
            F2 = New Font("Verdana", 7, FontStyle.Regular)

            S1 = Title.ToUpper
            S2 = Subtitle

            SZ1 = G.MeasureString(S1, F1, Width).ToSize
            SZ2 = G.MeasureString(S2, F2, Width).ToSize

        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e) : Init(e)
            G.SmoothingMode = SmoothingMode.HighQuality
            G.FillPath(B1, GP1)

            G.DrawPath(P1, GP1)
            G.DrawPath(P2, GP2)

            G.DrawString(S1, F1, B2, CInt((Width - SZ1.Width) / 2), 20)
            G.DrawString(S2, F2, B2, CInt((Width - SZ2.Width) / 2), 32)

        End Sub
    End Class

    Class BitdefenderRadiobutton : Inherits Control
#Region "Init"
#Region "Event"
        Public Event ChangeChecked(ByVal sender As Object, ByVal check As Boolean)
        Private _Check As Boolean
        Public Property Checked As Boolean
            Get
                Return _Check
            End Get
            Set(value As Boolean)
                _Check = value
                Invalidate()

                RaiseEvent ChangeChecked(Me, value)
            End Set
        End Property

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e) : Checked = Not Checked
        End Sub

#End Region 'Event
        Private oldHeight As Integer
        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.UserPaint, True)
            Width = 100
            Height = 15
            BackColor = Color.Transparent
            oldHeight = 15
        End Sub

        Protected Overrides Sub OnClientSizeChanged(ByVal e As EventArgs)
            MyBase.OnClientSizeChanged(e) : Height = oldHeight
        End Sub

        Public Overrides Property Text() As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                MyBase.Text = value
                Invalidate()
            End Set
        End Property
#End Region 'Init



        Private R1, R2, R3 As Rectangle
        Private GP1, GP2, GP3 As GraphicsPath
        Private LGB1, LGB2 As LinearGradientBrush
        Private P1, P2 As Pen
        Private G As Graphics
        Private S1 As String
        Private F1 As Font
        Private Sub Init(e As PaintEventArgs)
            G = e.Graphics

            R1 = New Rectangle(0, 0, Height - 1, Height - 1)
            R2 = New Rectangle(R1.X + 1, R1.Y + 1, R1.Width - 2, R1.Height - 2)
            R3 = New Rectangle(R2.X + 1, R2.Y + 1, R2.Width - 2, R2.Height - 2)

            GP1 = New GraphicsPath : GP1.AddEllipse(R1)
            GP2 = New GraphicsPath : GP2.AddEllipse(R2)
            GP3 = New GraphicsPath : GP3.AddEllipse(R3)

            LGB1 = New LinearGradientBrush(R1, Color.FromArgb(29, 29, 29), Color.FromArgb(39, 39, 39), LinearGradientMode.Vertical)
            LGB2 = New LinearGradientBrush(R3, Color.FromArgb(84, 135, 171), Color.FromArgb(113, 176, 200), LinearGradientMode.Vertical)

            P1 = Pens.Black
            P2 = New Pen(New SolidBrush(Color.FromArgb(68, 68, 68)))

            S1 = Text

            F1 = New Font("Verdana", 8, FontStyle.Regular)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e) : Init(e)
            G.InterpolationMode = InterpolationMode.HighQualityBicubic
            G.SmoothingMode = SmoothingMode.AntiAlias
            If Checked Then
                G.FillPath(LGB2, GP3)
                G.DrawPath(P1, GP3)
                G.DrawPath(P2, GP2)
                G.DrawString(S1, F1, New SolidBrush(Color.FromArgb(106, 166, 193)), 18, 1)
            Else
                G.FillPath(LGB1, GP1)
                G.DrawPath(P1, GP1)
                G.DrawPath(P2, GP2)
                G.DrawString(S1, F1, New SolidBrush(Color.FromArgb(147, 147, 147)), 18, 1)
            End If

        End Sub
    End Class


    Class ContainerObjectDisposable : Implements IDisposable
        Private iList As New List(Of IDisposable)

        Public Sub AddObject(ByVal Obj As IDisposable)
            iList.Add(Obj)
        End Sub
        Public Sub AddObjectRange(ByVal Obj() As IDisposable)
            iList.AddRange(Obj)
        End Sub
#Region "IDisposable Support"
        Private disposedValue As Boolean
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    For Each ObjectDisposable As IDisposable In iList
                        ObjectDisposable.Dispose()
#If DEBUG Then
                        Debug.WriteLine("Dispose : " & ObjectDisposable.ToString)
#End If
                    Next
                End If

            End If
            iList.Clear()
            Me.disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

    Module Helper

        Friend Function RoundRect(ByVal R As Rectangle, radius As Integer) As GraphicsPath
            Dim GP As New GraphicsPath
            GP.AddArc(R.X, R.Y, radius, radius, 180, 90)
            GP.AddArc(R.Right - radius, R.Y, radius, radius, 270, 90)
            GP.AddArc(R.Right - radius, R.Bottom - radius, radius, radius, 0, 90)
            GP.AddArc(R.X, R.Bottom - radius, radius, radius, 90, 90)
            GP.CloseFigure()
            Return GP
        End Function

    End Module
End Namespace