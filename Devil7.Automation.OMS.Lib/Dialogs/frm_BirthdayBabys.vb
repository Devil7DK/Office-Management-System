Public Class frm_BirthdayBabys

#Region "Constructor"
    Sub New(ByVal BirthdayBabys As List(Of Objects.ClientMinimalWithContact))
        InitializeComponent()

        gc_BirthdayBabys.DataSource = BirthdayBabys
        gc_BirthdayBabys.RefreshDataSource()
    End Sub
#End Region

End Class