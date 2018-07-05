Imports System.Data.OleDb

Public Class RecordHistory
    Dim PatientID As Integer
    Dim ConnectionString As String
    Dim cnnOLEDB As New OleDb.OleDbConnection
    Sub New(ByVal ID As Integer, ByVal DatabaseLocation As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PatientID = ID
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseLocation
        cnnOLEDB.ConnectionString = ConnectionString
    End Sub

    Private Sub RecordHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        cnnOLEDB.Open()
        Dim cmdOLEDB As New OleDb.OleDbCommand
        cmdOLEDB.Connection = cnnOLEDB
        cmdOLEDB.CommandText = "SELECT * FROM PATIENT WHERE ID=" & CInt(PatientID)
        cmdOLEDB.CommandType = CommandType.Text
        Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
        If rdrOLEDB.Read = True Then
            Dim rn As String = rdrOLEDB.Item("Report Number").ToString
            Me.Text = "Record History of " & rn
            'Do While rdrOLEDB.Read
            Dim History As New TextBox
            History.Text = If(IsDBNull(rdrOLEDB.Item("History")) = True, "", rdrOLEDB.Item("History"))
            For Each i As String In History.Lines
                ListBox1.Items.Add(i)
            Next
            rdrOLEDB.Close()
        Else
            MsgBox("Record not found")
            rdrOLEDB.Close()
            Me.Close()
        End If
    End Sub
End Class