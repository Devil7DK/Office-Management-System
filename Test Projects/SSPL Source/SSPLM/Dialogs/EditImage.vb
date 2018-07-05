Public Class EditImage
    Friend EditedImage As Image
    Sub New(ByVal Image2Edit As Image)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ImageEditor1.Img = Image2Edit
        ImageEditor1.defimg = Image2Edit
        ImageEditor1.LoadImage()
        ImageEditor1.bm = ImageEditor1.PictureBox1.Image
        ImageEditor1.graph = Graphics.FromImage(ImageEditor1.bm)
        ImageEditor1.PictureBoxLocation()
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        EditedImage = ImageEditor1.PictureBox1.Image
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class