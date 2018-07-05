Public Class PictureFrame
    Dim img As Image
    Property Image As Image
        Get
            Return img
        End Get
        Set(ByVal value As Image)
            img = value
            Me.Refresh()
        End Set
    End Property

    Private Sub PictureFrame_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim d As Double = Me.Width * (15.789473684210529 / 100)
        If Image Is Nothing Then
            e.Graphics.DrawImage(My.Resources.User_Default, New Rectangle(New Point(d, d), New Size(Me.Width - (d * 2), Me.Height - (d * 2))))
        Else
            e.Graphics.DrawImage(Image, New Rectangle(New Point(d, d), New Size(Me.Width - (d * 2), Me.Height - (d * 2))))
        End If
        e.Graphics.DrawImage(My.Resources.FyaPV, New Rectangle(0, 0, Me.Width, Me.Height))
    End Sub

    Private Sub PictureFrame_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Width = Me.Height
    End Sub
End Class
