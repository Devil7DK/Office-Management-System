Public Class AutoSizePanel
    Inherits Panel
    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height
    Sub ResizeAndSetLocation()
        Dim bmDest As New Drawing.Bitmap(Width, Height, Drawing.Imaging.PixelFormat.Format32bppArgb)
        For Each COntrol As ScannedImage In Me.Controls

            Dim nSourceAspectRatio = COntrol.Width / COntrol.Height
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
            COntrol.Location = New Point(NewX, NewY)
            COntrol.Width = NewWidth
            COntrol.Height = NewHeight
        Next
    End Sub
    ReadOnly Property InitialWidth As Integer
        Get
            Return IW
        End Get
    End Property
    ReadOnly Property InitialHeight As Integer
        Get
            Return IH
        End Get
    End Property
    Sub New(ByVal Width As Integer, ByVal Height As Integer)
        Me.Width = Width
        Me.Height = Height
        IW = Width
        IH = Height
        Me.AllowDrop = True
    End Sub

    Private Sub AutoSizePanel_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim c As Control = e.Data.GetData("Scan_n_Crop.ScannedImage")
        Me.Controls.Add(ControlFactory.CloneCtrl(c))
    End Sub

    Private Sub AutoSizePanel_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent("Scan_n_Crop.ScannedImage") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub AutoSizePanel_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub
End Class
