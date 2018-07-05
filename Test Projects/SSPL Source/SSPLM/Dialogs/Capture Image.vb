Public Class Capture_Image
    Friend SelectedImage As Bitmap



    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private WithEvents cam As New DSCamCapture
    Dim MyPicturesFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cam.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_devices.Items.AddRange(cam.GetCaptureDevices)
        If cmb_devices.Items.Count > 0 Then cmb_devices.SelectedIndex = 0

        For Each sz As String In [Enum].GetNames(GetType(DSCamCapture.FrameSizes))
            ComboBox_FrameSize.Items.Add(sz.Replace("s", ""))
        Next
        If ComboBox_FrameSize.Items.Count > 2 Then ComboBox_FrameSize.SelectedIndex = 2

        Button_Connect.Enabled = (cmb_devices.Items.Count > 0)
        Button_Save.Enabled = False
    End Sub

    Private Sub cmb_devices_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_devices.DropDown
        cmb_devices.Items.Clear()
        cmb_devices.Items.AddRange(cam.GetCaptureDevices)
        Button_Connect.Enabled = (cmb_devices.Items.Count > 0)
        If cmb_devices.SelectedIndex = -1 And cmb_devices.Items.Count > 0 Then cmb_devices.SelectedIndex = 0
    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        If Not cam.IsConnected Then
            Dim si As Integer = ComboBox_FrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(cmb_devices.SelectedIndex, 15, picCapture.ClientSize, SelectedSize, picCapture.Handle) Then
                cam.Start()
                Button_Connect.Text = "Disconnect"
            End If
        Else
            cam.Dispose()
            Button_Connect.Text = "Connect"
        End If
        Button_Save.Enabled = cam.IsConnected
        cmb_devices.Enabled = Not cam.IsConnected
        ComboBox_FrameSize.Enabled = Not cam.IsConnected
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        If Not IO.Directory.Exists(MyPicturesFolder) Then IO.Directory.CreateDirectory(MyPicturesFolder)
        Dim fName As String = Now.ToString.Replace("/", "-").Replace(":", "-").Replace(" ", "_") & ".jpg"
        Dim SaveAs As String = IO.Path.Combine(MyPicturesFolder, fName)
        cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub PictureBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCapture.SizeChanged
        cam.ResizeWindow(0, 0, picCapture.ClientSize.Width, picCapture.ClientSize.Height)
    End Sub

    Private Sub cam_FrameSaved(ByVal capImage As System.Drawing.Bitmap, ByVal imgPath As String) Handles cam.FrameSaved
        SelectedImage = New Bitmap(capImage)
        PictureBox1.Image = SelectedImage
        TabControl1.SelectedIndex = 1
        btn_OK.Enabled = True
        MsgBox("Saved As - " & IO.Path.GetFileName(imgPath), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
    End Sub
End Class