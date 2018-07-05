Public Class ImageToolTip

    <Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="GetDesktopWindow")> _
    Public Shared Function GetDesktopWindow() As IntPtr
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp = MyBase.CreateParams
            ' Retrieve the normal parameters.
            cp.Style = &H40000000 Or &H4000000
            ' WS_CHILD | WS_CLIPSIBLINGS
            cp.ExStyle = cp.ExStyle And &H80000
            ' WS_EX_LAYERED
            cp.Parent = GetDesktopWindow()
            ' Make "GetDesktopWindow()" from your own namespace.
            Return cp
        End Get
    End Property
    Property PicImage As Image
    Private Sub ImageToolTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PicImage Is Nothing Then
            Me.Close()
        Else
            Me.Location = New Point(MousePosition.X + 2, MousePosition.Y + 2)
            If PicImage.Width < PicImage.Height Then
                Me.Size = New Size(372, 526)
            Else
                Me.Size = New Size(526, 372)
            End If
            Me.PictureBox1.Image = PicImage
        End If
    End Sub
End Class