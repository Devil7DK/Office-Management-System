Public Class DragHandle
    Public Sub New(anchor As DragHandleAnchor)
        Me.New()
        Me.Anchor = anchor
    End Sub

    Protected Sub New()
        Me.Enabled = True
        Me.Visible = True
    End Sub

    Public Property Anchor() As DragHandleAnchor
        Get
            Return m_Anchor
        End Get
        Protected Set(value As DragHandleAnchor)
            m_Anchor = value
        End Set
    End Property
    Private m_Anchor As DragHandleAnchor

    Public Property Bounds() As Rectangle
        Get
            Return m_Bounds
        End Get
        Set(value As Rectangle)
            m_Bounds = value
        End Set
    End Property
    Private m_Bounds As Rectangle

    Public Property Enabled() As Boolean
        Get
            Return m_Enabled
        End Get
        Set(value As Boolean)
            m_Enabled = value
        End Set
    End Property
    Private m_Enabled As Boolean

    Public Property Visible() As Boolean
        Get
            Return m_Visible
        End Get
        Set(value As Boolean)
            m_Visible = value
        End Set
    End Property
    Private m_Visible As Boolean
End Class