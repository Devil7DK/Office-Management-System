Imports System.Data.OleDb

Public Class StartNewDb
    Dim newdb As String = ""
    Dim tempdb As String = ""
    Private Sub btn_CreateNewYear_Click(sender As Object, e As EventArgs) Handles btn_CreateNewYear.Click
        Dim year As String = txt_Year.Value.ToString
        If Not year.Trim = "" Then
            newdb = Application.StartupPath & "\Data\Lab" & year & ".mdb"
            tempdb = My.Computer.FileSystem.SpecialDirectories.Temp & "\Lab" & year & ".mdb"
            txt_status.Text = "Checking is file already exists"
            If My.Computer.FileSystem.FileExists(newdb) = True Then
                MsgBox("Selected year already exists. Choose other year.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Else
                txt_status.Text = "Copying file to temp directory"
                My.Computer.FileSystem.CopyFile(My.Settings.Filename, tempdb, True)
                txt_status.Text = "Deleting Old Reports from New DB"
                Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & tempdb)
                con.Open()
                Dim cmd As New OleDbCommand("DELETE * FROM PATIENT", con)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                con.Close()
                Dim dao As New DAO.DBEngine
                dao.CompactDatabase(tempdb, newdb)
                My.Settings.Filename = newdb
                MainForm.SetDataValues(newdb)
                MainForm.LoadAll()
                My.Settings.Save()
                txt_status.Text = "Complete"
                MsgBox("New Database for the selected year successfully created.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub StartNewDb_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txt_Year.Value = Now.Year
        Catch ex As Exception

        End Try
    End Sub

End Class