Public Class PageTab
    Inherits TabPage
    Dim PB As AutoSizePanel
    Dim PageWidth_ As Integer
    ReadOnly Property PageWidth As Integer
        Get
            Return PageWidth_
        End Get
    End Property
    Dim PageHeight_ As Integer
    ReadOnly Property PageHeight As Integer
        Get
            Return PageHeight_
        End Get
    End Property
    ReadOnly Property PageContainer As AutoSizePanel
        Get
            Return PB
        End Get
    End Property
    Sub New(ByVal Width As Integer, ByVal Height As Integer)
        PB = New AutoSizePanel(Width, Height) With {.BorderStyle = Windows.Forms.BorderStyle.FixedSingle}
        Me.Controls.Add(PB)
        ResizeAndSetLocation(PB, Me.Width, Me.Height)
        Me.PageWidth_ = Width
        Me.PageHeight_ = Height
        Me.Text = "Page"
    End Sub
    Sub ResizeAndSetLocation(ByVal Control As AutoSizePanel, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32)
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = Control.InitialWidth / Control.InitialHeight
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If
        Control.Location = New Point(NewX, NewY)
        Control.Width = NewWidth
        Control.Height = NewHeight
        CurrentWidth_ = NewWidth
        CurrentHeight_ = NewHeight
    End Sub
    Dim CurrentWidth_ As Integer
    Dim CurrentHeight_ As Integer
    ReadOnly Property CurrentWidth As Integer
        Get
            Return CurrentWidth_
        End Get
    End Property
    ReadOnly Property CurrentHeight As Integer
        Get
            Return CurrentHeight_
        End Get
    End Property
    Sub SetPageName()
        If TypeOf Me.Parent Is TabControl Then
            Me.Text = "Page " & CType(Me.Parent, TabControl).TabPages.IndexOf(Me) + 1
        End If
    End Sub
    Private WithEvents ParentTC As TabControl

    Private Sub PageTab_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If TypeOf sender Is TabControl Then
            ParentTC = sender
        End If
        SetPageName()
    End Sub
    Private Sub PageTab_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.Width > 0 Then
            ResizeAndSetLocation(PB, Me.Width, Me.Height)
        End If
    End Sub
    Sub ResizeSetLocation()
        If Me.Width > 0 Then
            ResizeAndSetLocation(PB, Me.Width, Me.Height)
        End If
    End Sub
    Private Sub ParentTC_TabIndexChanged(sender As Object, e As System.EventArgs) Handles ParentTC.TabIndexChanged
        SetPageName()
    End Sub
End Class
