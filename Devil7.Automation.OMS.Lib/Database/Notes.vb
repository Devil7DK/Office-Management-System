'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Devil7.Automation.OMS.Lib.Objects

Namespace Database
    Public Module Notes

#Region "Variables"
        Dim TableName As String = "Notes"
#End Region

#Region "Public Functions"
        Function AddNew(ByVal Title As String, ByVal Content As String, ByVal User As User) As Note
            Dim R As Note = Nothing

            Dim CommandString As String = String.Format("INSERT INTO {0} ([User],[DateAdded],[DateEdited],[Title],[Content],[Archived]) VALUES (@User,@DateAdded,@DateEdited,@Title,@Content,@Archived);SELECT SCOPE_IDENTITY();", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Dim Now As Date = Date.Now
                AddParameter(Command, "@User", User.ID)
                AddParameter(Command, "@DateAdded", Now)
                AddParameter(Command, "@DateEdited", Now)
                AddParameter(Command, "@Title", Title)
                AddParameter(Command, "@Content", Content)
                AddParameter(Command, "@Archived", False)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Note(ID, Title, Content, Now, Now)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting note.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Public Function SaveContent(ByVal ID As Integer, ByVal Content As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [DateEdited]=@DateEdited,[Content]=@Content WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Dim Now As Date = Date.Now
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateEdited", Now)
                AddParameter(Command, "@Content", Content)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while saving note.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Title As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [DateEdited]=@DateEdited,[Title]=@Title WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Dim Now As Date = Date.Now
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateEdited", Now)
                AddParameter(Command, "@Title", Title)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while changing title of note.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Archived As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [DateEdited]=@DateEdited,[Archived]=@Archived WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Dim Now As Date = Date.Now
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateEdited", Now)
                AddParameter(Command, "@Archived", Archived)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while saving note.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function Remove(ByVal ID As Integer) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("DELETE FROM {0} WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function GetAll(ByVal User As User) As List(Of Note)
            Dim R As New List(Of Note)

            Dim CommandString As String = String.Format("SELECT * FROM {0} WHERE [User]=@User AND [Archived]=0;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@User", User.ID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader))
                    End While
                End Using
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function
#End Region

#Region "Private Functions"
        Private Function Read(ByVal Reader As SqlDataReader) As Note
            Dim ID As Integer = Reader.Item("ID")
            Dim DateAdded As Date = Reader.Item("DateAdded")
            Dim DateEdited As Date = Reader.Item("DateEdited")
            Dim Title As String = Reader.Item("Title").ToString
            Dim Content As String = Reader.Item("Content").ToString

            Return New Note(ID, Title, Content, DateAdded, DateEdited)
        End Function
#End Region

    End Module
End Namespace