Public Class ReportImage
    Property CaptionText As String
        Get
            Return GroupBox1.Text
        End Get
        Set(value As String)
            GroupBox1.Text = value
        End Set
    End Property
    Property SelectedImage As Image
        Get
            Return pic_.Image
        End Get
        Set(value As Image)
            pic_.Image = value
        End Set
    End Property
    Property SelectedName As String
        Get
            Return txt_ImageName.Text
        End Get
        Set(value As String)
            txt_ImageName.Text = value
        End Set
    End Property
    Property SelectedImageValidity As Boolean
        Get
            Return cb_Valid.Checked
        End Get
        Set(value As Boolean)
            cb_Valid.Checked = value
        End Set
    End Property
    Private Sub btn_Capture_Click(sender As Object, e As EventArgs) Handles btn_Capture.Click
        Dim id As New Capture_Image

        If id.ShowDialog = DialogResult.OK Then
            Me.pic_.Image = id.SelectedImage
            Me.SelectedImageValidity = True
        End If
    End Sub

    Private Sub btn_SelectFromFile_Click(sender As Object, e As EventArgs) Handles btn_SelectFromFile.Click
        If SelectFromFile.ShowDialog = DialogResult.OK Then
            Try
                Dim i As Image = Image.FromFile(SelectFromFile.FileName)
                pic_.Image = i
                Me.SelectedImageValidity = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If pic_.Image IsNot Nothing Then
            Dim IE As New EditImage(pic_.Image)
            If IE.ShowDialog = DialogResult.OK Then
                pic_.Image = IE.EditedImage
                Me.SelectedImageValidity = True
            End If
        End If
    End Sub
End Class
