Module PublicVariables
    Public ConnectionString As String = String.Format("Server={0};Database={1};User Id={2};Password={3};Application Name=Office Management System;Pooling={4};", My.Settings.Server, My.Settings.Database, My.Settings.UserID, GlobalCode.DecryptString(My.Settings.Password), My.Settings.Pooling)
End Module
