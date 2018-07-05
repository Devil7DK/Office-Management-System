Public Class Settings
    Dim siglocation As String = IO.Path.Combine(Application.StartupPath, "signature.jpg")
    Sub LoadReport()
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(siglocation) Then
            Dim bytes As Byte() = My.Computer.FileSystem.ReadAllBytes(siglocation)
            Dim s As New IO.MemoryStream
            For Each i As Byte In bytes
                s.WriteByte(i)
            Next
            pic_Sig.Image = Image.FromStream(s)
            lbl_RealSize.Text = "Selected Image's Original Size : " & pic_Sig.Image.Size.Width & " x " & pic_Sig.Image.Height
        Else
            lbl_RealSize.Text = "No Image Selected"
        End If
        txt_SignatureWidth.Value = My.Settings.SignatureWidth
        txt_SignatureHeight.Value = My.Settings.SignatureHeight
        txt_SignatureX.Value = My.Settings.SignatureX
        txt_SignatureY.Value = My.Settings.SignatureY
        txt_ReportBottom.Value = My.Settings.ReportBottom
        txt_ReportLeft.Value = My.Settings.ReportLeft
        txt_ReportRight.Value = My.Settings.ReportRight
        txt_ReportTop.Value = My.Settings.ReportTop
        IsImageSizeFixed.Checked = My.Settings.ImageFixedWidth
        imageHeight.Value = My.Settings.ImageHeight
        ImageWidth.Value = My.Settings.ImageWidth
        txt_Page_X.Value = My.Settings.pageNumberLoc.X
        txt_Page_Y.Value = My.Settings.pageNumberLoc.Y
        btn_PageNumberFont.Font = My.Settings.pageNumberFont
    End Sub
    Sub LoadEmail()
        txt_UserName.Text = My.Settings.Email
        txt_Password.Text = My.Settings.Password
        txt_Provider.Text = My.Settings.Provider
        txt_SMTP.Text = My.Settings.SMTP
        txt_Port.Text = My.Settings.Port
        txt_DisplayName.Text = My.Settings.DisplayName
    End Sub
    Sub LoadCover()
        Me.rb_x.Value = My.Settings.CoverReportNoPoint.X
        Me.rb_y.Value = My.Settings.CoverReportNoPoint.Y
        Me.ab_x.Value = My.Settings.CoverAddressPoint.X
        Me.ab_y.Value = My.Settings.CoverAddressPoint.Y
    End Sub
    Sub SaveReport()

        If pic_Sig.Image IsNot Nothing Then
            Dim p As Image = pic_Sig.Image.Clone
            pic_Sig.Image.Dispose()
            Try
                My.Computer.FileSystem.DeleteFile(siglocation)
                p.Save(siglocation, Imaging.ImageFormat.Jpeg)
            Catch ex As Exception

            End Try
        Else
            Try
                My.Computer.FileSystem.DeleteFile(siglocation)
            Catch ex As Exception

            End Try
        End If
        My.Settings.SignatureX = txt_SignatureX.Value
        My.Settings.SignatureY = txt_SignatureY.Value
        My.Settings.SignatureWidth = txt_SignatureWidth.Value
        My.Settings.SignatureHeight = txt_SignatureHeight.Value
        My.Settings.ReportBottom = txt_ReportBottom.Value
        My.Settings.ReportLeft = txt_ReportLeft.Value
        My.Settings.ReportRight = txt_ReportRight.Value
        My.Settings.ReportTop = txt_ReportTop.Value
        My.Settings.ImageFixedWidth = IsImageSizeFixed.Checked
        My.Settings.ImageHeight = imageHeight.Value
        My.Settings.ImageWidth = ImageWidth.Value
        My.Settings.pageNumberLoc = New Point(txt_Page_X.Value, txt_Page_Y.Value)
        My.Settings.pageNumberFont = btn_PageNumberFont.Font
    End Sub
    Sub SaveReportLP2()
        My.Settings.ReportNumLoc = New Point(ReportNumberLoc_X.Value, ReportNumberLoc_Y.Value)
        My.Settings.ReportDateLoc = New Point(ReportReportedDateLoc_X.Value, ReportReportedDateLoc_Y.Value)
        My.Settings.ReportNameLoc = New Point(ReportNameLoc_X.Value, ReportNameLoc_Y.Value)
        My.Settings.ReportAgeLoc = New Point(ReportAgeLoc_X.Value, ReportAgeLoc_Y.Value)
        My.Settings.ReportSexLoc = New Point(ReportSexLoc_X.Value, ReportSexLoc_Y.Value)
        My.Settings.ReportReferredLoc = New Point(ReportRefLoc_X.Value, ReportRefLoc_Y.Value)
        My.Settings.ReportHospitalLoc = New Point(ReportHospitalLoc_X.Value, ReportHospitalLoc_Y.Value)
        My.Settings.ReportReceivedDate = New Point(ReportReceivedDateLoc_X.Value, ReportReceivedDateLoc_Y.Value)
        My.Settings.ReportResultLoc = New Point(ReoprtResultLoc_X.Value, ReoprtResultLoc_Y.Value)
    End Sub
    Sub SaveEmail()
        My.Settings.Email = txt_UserName.Text
        My.Settings.Password = txt_Password.Text
        My.Settings.Provider = txt_Provider.Text
        My.Settings.SMTP = txt_SMTP.Text
        My.Settings.Port = txt_Port.Text
        My.Settings.DisplayName = txt_DisplayName.Text
    End Sub
    Sub SaveCover()
        My.Settings.CoverReportNoPoint = New Point(Me.rb_x.Value, Me.rb_y.Value)
        My.Settings.CoverAddressPoint = New Point(Me.ab_x.Value, Me.ab_y.Value)
    End Sub
    Sub SaveStatement()
        My.Settings.StatementFont = lbl_DetailsFont.Font
        My.Settings.StatementHeaderFont = lbl_HeaderFont.Font
        My.Settings.StatementImage = PrintHeaderOption.SelectedIndex
        My.Settings.StatementMarginTop = Statement_Top.Value
        My.Settings.StatementMarginBottom = Statement_Bottom.Value
        My.Settings.StatementMarginRight = Statement_Right.Value
        My.Settings.StatementMarginLeft = Statement_Left.Value
        My.Settings.StatementPageNumberY = StatementPageY.Value
    End Sub
    Sub LoadStatement()
        lbl_DetailsFont.Font = My.Settings.StatementFont
        lbl_HeaderFont.Font = My.Settings.StatementHeaderFont
        PrintHeaderOption.SelectedIndex = My.Settings.StatementImage
        Statement_Top.Value = My.Settings.StatementMarginTop
        Statement_Bottom.Value = My.Settings.StatementMarginBottom
        Statement_Right.Value = My.Settings.StatementMarginRight
        Statement_Left.Value = My.Settings.StatementMarginLeft
        StatementPageY.Value = My.Settings.StatementPageNumberY
    End Sub
    Sub LoadReportLP2()
        ReportNumberLoc_X.Value = My.Settings.ReportNumLoc.X
        ReportNumberLoc_Y.Value = My.Settings.ReportNumLoc.Y
        ReportReportedDateLoc_X.Value = My.Settings.ReportDateLoc.X
        ReportReportedDateLoc_Y.Value = My.Settings.ReportDateLoc.Y
        ReportNameLoc_X.Value = My.Settings.ReportNameLoc.X
        ReportNameLoc_Y.Value = My.Settings.ReportNameLoc.Y
        ReportAgeLoc_X.Value = My.Settings.ReportAgeLoc.X
        ReportAgeLoc_Y.Value = My.Settings.ReportAgeLoc.Y
        ReportSexLoc_X.Value = My.Settings.ReportSexLoc.X
        ReportSexLoc_Y.Value = My.Settings.ReportSexLoc.Y
        ReportRefLoc_X.Value = My.Settings.ReportReferredLoc.X
        ReportRefLoc_Y.Value = My.Settings.ReportReferredLoc.Y
        ReportHospitalLoc_X.Value = My.Settings.ReportHospitalLoc.X
        ReportHospitalLoc_Y.Value = My.Settings.ReportHospitalLoc.Y
        ReportReceivedDateLoc_X.Value = My.Settings.ReportReceivedDate.X
        ReportReceivedDateLoc_Y.Value = My.Settings.ReportReceivedDate.Y
        ReoprtResultLoc_X.Value = My.Settings.ReportResultLoc.X
        ReoprtResultLoc_Y.Value = My.Settings.ReportResultLoc.Y
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmail()
        LoadCover()
        LoadReport()
        LoadStatement()
        LoadReportLP2()
        txt_DefaultFile.Text = My.Settings.Filename
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SaveEmail()
        SaveCover()
        SaveStatement()
        SaveReport()
        SaveReportLP2()
        My.Settings.Filename = txt_DefaultFile.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub txt_Provider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Provider.SelectedIndexChanged
        If txt_Provider.Text = "Gmail" Then
            txt_SMTP.Text = "smtp.gmail.com"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "Outlook" Then
            txt_SMTP.Text = "smtp.live.com"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "Office365" Then
            txt_SMTP.Text = "smtp.office365.com"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "Yahoo Mail" Then
            txt_SMTP.Text = "smtp.mail.yahoo.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Yahoo Mail Plus" Then
            txt_SMTP.Text = "plus.smtp.mail.yahoo.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Yahoo UK" Then
            txt_SMTP.Text = "smtp.mail.yahoo.co.uk"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Yahoo Deutschland" Then
            txt_SMTP.Text = "smtp.mail.yahoo.co.uk"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Yahoo AU / NZ" Then
            txt_SMTP.Text = "smtp.mail.yahoo.com.au"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "O2" Then
            txt_SMTP.Text = "smtp.o2.ie"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "O2.uk" Then
            txt_SMTP.Text = "smtp.o2.co.uk"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "AOL" Then
            txt_SMTP.Text = "smtp.aol.com"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "AT&T" Then
            txt_SMTP.Text = "smtp.att.yahoo.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "NTL" Then
            txt_SMTP.Text = "smtp.ntlworld.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "BT Connect" Then
            txt_SMTP.Text = "pop3.btconnect.com"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "BT Openworld" Then
            txt_SMTP.Text = "mail.btopenworld.com"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "BT Internet" Then
            txt_SMTP.Text = "mail.btinternet.com"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "Orange" Then
            txt_SMTP.Text = "smtp.orange.net"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "Orange.uk" Then
            txt_SMTP.Text = "smtp.orange.co.uk"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "Wanadoo UK" Then
            txt_SMTP.Text = "smtp.wanadoo.co.uk"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "Hotmail" Then
            txt_SMTP.Text = "smtp.live.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "O2 Online Deutschland" Then
            txt_SMTP.Text = "mail.o2online.de"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "T-Online Deutschland" Then
            txt_SMTP.Text = "securesmtp.t-online.de"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "1&1 (1and1)" Then
            txt_SMTP.Text = "smtp.1and1.com"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "1&1 Deutschland" Then
            txt_SMTP.Text = "smtp.1und1.de"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "Comcast" Then
            txt_SMTP.Text = "smtp.comcast.net"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "Verizon" Then
            txt_SMTP.Text = "outgoing.verizon.net"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Verizon(Yahoo hosted)" Then
            txt_SMTP.Text = "outgoing.yahoo.verizon.net"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "zoho Mail" Then
            txt_SMTP.Text = "smtp.zoho.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Mail" Then
            txt_SMTP.Text = "smtp.mail.com"
            txt_Port.Text = "587"
        ElseIf txt_Provider.Text = "GMX" Then
            txt_SMTP.Text = "smtp.gmx.com"
            txt_Port.Text = "465"
        ElseIf txt_Provider.Text = "Rediffmail" Then
            txt_SMTP.Text = "smtp.rediffmail.com"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "Rediffmailpro" Then
            txt_SMTP.Text = "smtp.rediffmailpro.com"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "MSN" Then
            txt_SMTP.Text = "smtp.email.msn.com"
            txt_Port.Text = "25"
        ElseIf txt_Provider.Text = "Lycos" Then
            txt_SMTP.Text = "smtp.mail.lycos.com"
            txt_Port.Text = "25"
        End If
    End Sub

    Private Sub btn_BrowseSig_Click(sender As Object, e As EventArgs) Handles btn_BrowseSig.Click
        If SelectImage.ShowDialog = DialogResult.OK Then
            pic_Sig.Image = Image.FromFile(SelectImage.FileName)
            lbl_RealSize.Text = "Selected Image's Original Size : " & pic_Sig.Image.Size.Width & " x " & pic_Sig.Image.Height
            txt_SignatureHeight.Value = pic_Sig.Image.Height
            txt_SignatureWidth.Value = pic_Sig.Image.Width
            Size_Percentage.Value = 100
        End If
    End Sub

    Private Sub Size_Percentage_ValueChanged(sender As Object, e As EventArgs) Handles Size_Percentage.ValueChanged
        If pic_Sig.Image IsNot Nothing Then
            txt_SignatureHeight.Value = CInt(pic_Sig.Image.Height * Size_Percentage.Value / 100)
            txt_SignatureWidth.Value = CInt(pic_Sig.Image.Width * Size_Percentage.Value / 100)
        End If
    End Sub

    Private Sub btn_Removeimage_Click(sender As Object, e As EventArgs) Handles btn_Removeimage.Click
        pic_Sig.Image = Nothing
        Try
            My.Computer.FileSystem.DeleteFile(siglocation)
        Catch ex As Exception

        End Try
        lbl_RealSize.Text = "No Image Selected"
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        If SelectFileForView.ShowDialog = DialogResult.OK Then
            txt_DefaultFile.Text = SelectFileForView.Filename
        End If
    End Sub

    Private Sub btn_PageNumberFont_Click(sender As Object, e As EventArgs) Handles btn_PageNumberFont.Click
        Dim fa As New FontDialog
        fa.Font = btn_PageNumberFont.Font
        If fa.ShowDialog = DialogResult.OK Then
            btn_PageNumberFont.Font = fa.Font
        End If
    End Sub

    Private Sub btn_HeaderFont_Click(sender As Object, e As EventArgs) Handles btn_HeaderFont.Click
        Dim f As New FontDialog
        f.Font = lbl_HeaderFont.Font
        If f.ShowDialog = DialogResult.OK Then
            lbl_HeaderFont.Font = f.Font
        End If
    End Sub

    Private Sub btn_DetailsFont_Click(sender As Object, e As EventArgs) Handles btn_DetailsFont.Click
        Dim f As New FontDialog
        f.Font = lbl_DetailsFont.Font
        If f.ShowDialog = DialogResult.OK Then
            lbl_DetailsFont.Font = f.Font
        End If
    End Sub
End Class