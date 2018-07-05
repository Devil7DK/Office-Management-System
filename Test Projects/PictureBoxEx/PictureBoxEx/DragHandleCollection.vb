Friend Class DragHandleCollection
    Implements IEnumerable(Of DragHandle)

    Private ReadOnly _items As IDictionary(Of DragHandleAnchor, DragHandle)

    Public Sub New()
        _items = New Dictionary(Of DragHandleAnchor, DragHandle)()
        _items.Add(DragHandleAnchor.TopLeft, New DragHandle(DragHandleAnchor.TopLeft))
        _items.Add(DragHandleAnchor.TopCenter, New DragHandle(DragHandleAnchor.TopCenter))
        _items.Add(DragHandleAnchor.TopRight, New DragHandle(DragHandleAnchor.TopRight))
        _items.Add(DragHandleAnchor.MiddleLeft, New DragHandle(DragHandleAnchor.MiddleLeft))
        _items.Add(DragHandleAnchor.MiddleRight, New DragHandle(DragHandleAnchor.MiddleRight))
        _items.Add(DragHandleAnchor.BottomLeft, New DragHandle(DragHandleAnchor.BottomLeft))
        _items.Add(DragHandleAnchor.BottomCenter, New DragHandle(DragHandleAnchor.BottomCenter))
        _items.Add(DragHandleAnchor.BottomRight, New DragHandle(DragHandleAnchor.BottomRight))
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return _items.Count
        End Get
    End Property

    Default Public ReadOnly Property Item(index As DragHandleAnchor) As DragHandle
        Get
            Return _items(index)
        End Get
    End Property



    Public Function HitTest(point As Point) As DragHandleAnchor
        Dim result As DragHandleAnchor

        result = DragHandleAnchor.None

        For Each handle As DragHandle In Me
            If handle.Visible AndAlso handle.Bounds.Contains(point) Then
                result = handle.Anchor
                Exit For
            End If
        Next

        Return result
    End Function



    Public Function GetEnumerator1() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        Return _items.Values.GetEnumerator()
    End Function

    Public Function GetEnumerator() As System.Collections.Generic.IEnumerator(Of DragHandle) Implements System.Collections.Generic.IEnumerable(Of DragHandle).GetEnumerator
        Return _items.Values.GetEnumerator()
    End Function
End Class