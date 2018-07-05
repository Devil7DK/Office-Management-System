Public Class PictureBoxEx
    Inherits PictureBox
   
    Private Sub PositionDragHandles()
        If Me.DragHandles IsNot Nothing AndAlso Me.DragHandleSize > 0 Then
            If Me.SelectionRegion.IsEmpty Then
                For Each handle As DragHandle In Me.DragHandles
                    handle.Bounds = Rectangle.Empty
                Next
            Else
                Dim left As Integer
                Dim top As Integer
                Dim right As Integer
                Dim bottom As Integer
                Dim halfWidth As Integer
                Dim halfHeight As Integer
                Dim halfDragHandleSize As Integer
                Dim viewport As Rectangle
                Dim offsetX As Integer
                Dim offsetY As Integer

                viewport = Me.GetImageViewPort()
                offsetX = viewport.Left + Me.Padding.Left + Me.AutoScrollPosition.X
                offsetY = viewport.Top + Me.Padding.Top + Me.AutoScrollPosition.Y
                halfDragHandleSize = Me.DragHandleSize / 2
                left = Convert.ToInt32((Me.SelectionRegion.Left * Me.ZoomFactor) + offsetX)
                top = Convert.ToInt32((Me.SelectionRegion.Top * Me.ZoomFactor) + offsetY)
                right = left + Convert.ToInt32(Me.SelectionRegion.Width * Me.ZoomFactor)
                bottom = top + Convert.ToInt32(Me.SelectionRegion.Height * Me.ZoomFactor)
                halfWidth = Convert.ToInt32(Me.SelectionRegion.Width * Me.ZoomFactor) / 2
                halfHeight = Convert.ToInt32(Me.SelectionRegion.Height * Me.ZoomFactor) / 2

                Me.DragHandles(DragHandleAnchor.TopLeft).Bounds = New Rectangle(left - Me.DragHandleSize, top - Me.DragHandleSize, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.TopCenter).Bounds = New Rectangle(left + halfWidth - halfDragHandleSize, top - Me.DragHandleSize, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.TopRight).Bounds = New Rectangle(right, top - Me.DragHandleSize, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.MiddleLeft).Bounds = New Rectangle(left - Me.DragHandleSize, top + halfHeight - halfDragHandleSize, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.MiddleRight).Bounds = New Rectangle(right, top + halfHeight - halfDragHandleSize, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.BottomLeft).Bounds = New Rectangle(left - Me.DragHandleSize, bottom, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.BottomCenter).Bounds = New Rectangle(left + halfWidth - halfDragHandleSize, bottom, Me.DragHandleSize, Me.DragHandleSize)
                Me.DragHandles(DragHandleAnchor.BottomRight).Bounds = New Rectangle(right, bottom, Me.DragHandleSize, Me.DragHandleSize)
            End If
        End If
    End Sub

    Private Sub PictureBoxEx_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Me.PositionDragHandles()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        If Me.Focused Then
            For Each handle As DragHandle In Me.DragHandles
                If handle.Visible Then
                    Me.DrawDragHandle(e.Graphics, handle)
                End If
            Next
        End If
    End Sub

    Protected Overridable Sub DrawDragHandle(graphics As Graphics, handle As DragHandle)
        Dim left As Integer
        Dim top As Integer
        Dim width As Integer
        Dim height As Integer
        Dim outerPen As Pen
        Dim innerBrush As Brush

        left = handle.Bounds.Left
        top = handle.Bounds.Top
        width = handle.Bounds.Width
        height = handle.Bounds.Height

        If handle.Enabled Then
            outerPen = SystemPens.WindowFrame
            innerBrush = SystemBrushes.Window
        Else
            outerPen = SystemPens.ControlDark
            innerBrush = SystemBrushes.Control
        End If

        graphics.FillRectangle(innerBrush, left + 1, top + 1, width - 2, height - 2)
        graphics.DrawLine(outerPen, left + 1, top, left + width - 2, top)
        graphics.DrawLine(outerPen, left, top + 1, left, top + height - 2)
        graphics.DrawLine(outerPen, left + 1, top + height - 1, left + width - 2, top + height - 1)
        graphics.DrawLine(outerPen, left + width - 1, top + 1, left + width - 1, top + height - 2)
    End Sub

End Class
