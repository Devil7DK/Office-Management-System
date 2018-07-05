Public Class frm_FileAccept
    Sub New(ByVal Filename As String, ByVal From_ As String)
        InitializeComponent()
        lbl_File.Text = Filename
        lbl_From.Text = From_
    End Sub
    Property FileResponse As FileResponse = FileResponse.Declined
    Private Sub btn_Accept_Click(sender As System.Object, e As System.EventArgs) Handles btn_Accept.Click
        If cmb_AlwaysTrust.Checked Then
            My.Settings.Trusted.add(lbl_From.Text)
        End If
        Me.FileResponse = FileResponse.Accepted
        Me.Close()
    End Sub
    Private Sub btn_Decline_Click(sender As System.Object, e As System.EventArgs) Handles btn_Decline.Click
        Me.FileResponse = FileResponse.Declined
        Me.Close()
    End Sub

    Private Sub frm_FileAccept_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        x = My.Computer.Screen.Bounds.Width - Me.Width
        y = My.Computer.Screen.Bounds.Height
        Min_Y = My.Computer.Screen.WorkingArea.Height - Me.Height
        Timer1.Start()
    End Sub
    Dim x As Integer
    Dim y As Integer
    Dim Min_Y As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If y < Min_Y Then
            Me.Location = New Point(x, Min_Y)
            Timer1.Stop()
        Else
            Me.Location = New Point(x, y)
            y -= 15
        End If
    End Sub
End Class
Public Enum FileResponse
    Declined
    Accepted
End Enum