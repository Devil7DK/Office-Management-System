Imports System.Data.OleDb

Public Class EditDoc
    Dim connectionstring As String = ""
    Dim DocID As Integer = 0
    Sub New(ByVal ID As Integer, ByVal ConnectionString As String)
        InitializeComponent()
        Me.connectionstring = ConnectionString
        DocID = ID
    End Sub
    Private Sub LoadDataSource()
        Dim cnnoledb As New OleDbConnection(connectionstring)
        cnnoledb.Open()
        Dim cmdoledb As New OleDbCommand
        Try
            cmdOLEDB.Connection = cnnoledb
            cmdoledb.CommandText = "SELECT * FROM DOC WHERE ID=" & CInt(DocID) & ";"
            cmdoledb.CommandType = CommandType.Text
            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader
            If rdrOLEDB.Read = True Then
                'Do While rdrOLEDB.Read
                txt_Name.Text = rdrOLEDB.Item("Doctor Name").ToString
                txt_Street.Text = rdrOLEDB.Item("Street").ToString
                txt_Area.Text = rdrOLEDB.Item("Area").ToString
                txt_City.Text = rdrOLEDB.Item("City").ToString
                txt_Pincode.Text = rdrOLEDB.Item("PinCode").ToString
                txt_Phone.Text = rdrOLEDB.Item("Phone").ToString
                txt_Hospital.Text = rdrOLEDB.Item("Hospital").ToString
                rdrOLEDB.Close()
                'Loop
            Else
                MsgBox("Record not found")
                rdrOLEDB.Close()
            End If
        Catch ex As Exception
            ' log message instead '
        End Try
        cnnOLEDB.Close()
    End Sub
    Private Sub AddNewDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataSource()
        txt_Name.Focus()
    End Sub

    Private Sub txt_Area_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Area.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_City.Focus()
        End If
    End Sub

    Private Sub txt_City_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_City.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Pincode.Focus()
        End If
    End Sub

    Private Sub txt_Hospital_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Hospital.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            btn_Add_Click(sender, e)
        End If
    End Sub

    Private Sub txt_Name_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Name.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Street.Focus()
        End If
    End Sub

    Private Sub txt_Phone_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Phone.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Hospital.Focus()
        End If
    End Sub

    Private Sub txt_Pincode_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Pincode.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Phone.Focus()
        End If
    End Sub

    Private Sub txt_Street_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_Street.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Area.Focus()
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If MsgBox("Are sure to edit this entry ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Make Sure!") = MsgBoxResult.Yes Then
            Try
                Dim cnnoledb As New OleDbConnection(connectionstring)
                cnnoledb.Open()
                Dim cmdOledb As New OleDbCommand
                cmdOledb.Connection = cnnoledb
                cmdOledb.CommandText = String.Format("UPDATE DOC SET [Doctor Name]={0},[Street]={1},[Area]={2},[City]={3},[PinCode]={4},[Phone]={5},[Hospital]={6} WHERE ID={7};", GetWithQuot.WithQuot(txt_Name.Text), GetWithQuot.WithQuot(txt_Street.Text), GetWithQuot.WithQuot(txt_Area.Text), GetWithQuot.WithQuot(txt_City.Text), GetWithQuot.WithQuot(txt_Pincode.Text), GetWithQuot.WithQuot(txt_Phone.Text), GetWithQuot.WithQuot(txt_Hospital.Text), DocID)
                cmdOledb.CommandType = CommandType.Text
                cmdOledb.ExecuteNonQuery()
                cnnoledb.Close()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub
End Class