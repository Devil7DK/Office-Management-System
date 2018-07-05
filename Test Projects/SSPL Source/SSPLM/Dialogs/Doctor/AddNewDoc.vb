Imports System.Data.OleDb

Public Class AddNewDoc
    Dim connectionstring As String = ""
    Sub New(ByVal ConnectionString As String)
        InitializeComponent()
        Me.connectionstring = ConnectionString
    End Sub

    Private Sub AddNewDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_Name.Focus()
    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If MsgBox("Are sure to add this entry ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Make Sure!") = MsgBoxResult.Yes Then
            Try
                Dim cnnoledb As New OleDbConnection(connectionstring)
                cnnoledb.Open()
                Dim cmdOledb As New OleDbCommand
                cmdOledb.Connection = cnnoledb
                cmdOledb.CommandText = String.Format("INSERT INTO DOC ([Doctor Name],[Street],[Area],[City],[PinCode],[Phone],[Hospital]) VALUES ({0},{1},{2},{3},{4},{5},{6})", GetWithQuot.WithQuot(txt_Name.Text), GetWithQuot.WithQuot(txt_Street.Text), GetWithQuot.WithQuot(txt_Area.Text), GetWithQuot.WithQuot(txt_City.Text), GetWithQuot.WithQuot(txt_Pincode.Text), GetWithQuot.WithQuot(txt_Phone.Text), GetWithQuot.WithQuot(txt_Hospital.Text))
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

    Private Sub txt_Area_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Area.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_City.Focus()
        End If
    End Sub

    Private Sub txt_City_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_City.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Pincode.Focus()
        End If
    End Sub

    Private Sub txt_Hospital_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Hospital.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            btn_Add_Click(sender, e)
        End If
    End Sub

    Private Sub txt_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Name.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Street.Focus()
        End If
    End Sub

    Private Sub txt_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Phone.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Hospital.Focus()
        End If
    End Sub

    Private Sub txt_Pincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Pincode.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Phone.Focus()
        End If
    End Sub

    Private Sub txt_Street_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Street.KeyPress
        If e.KeyChar = CChar(vbNewLine) Then
            txt_Area.Focus()
        End If
    End Sub
End Class