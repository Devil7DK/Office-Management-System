Public Module Main
    <STAThread()> _
    Sub Main()
        DevExpress.UserSkins.OfficeSkins.Register()
        '... 
        Application.Run(New frm_Login)
    End Sub
End Module
