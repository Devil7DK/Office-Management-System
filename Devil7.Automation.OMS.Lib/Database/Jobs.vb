﻿'=========================================================================='
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
Imports Devil7.Automation.OMS.Lib.Objects
Imports Devil7.Automation.OMS.Lib.Utils

Namespace Database
    Public Module Jobs

        Function GetJID(ByVal Group As String, ByVal SubGroup As String, ByVal CloseConnection As Boolean) As String
            Dim R As String = ""
            Dim c As Integer = 0

            Dim SV As String = Group.ToString.Substring(0, 1) & SubGroup.ToString.Substring(0, 1)
            Dim CommandString As String = "SELECT * FROM Jobs WHERE [JID] LIKE '%" & SV & "%'"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using reader = Command.ExecuteReader
                    While reader.Read
                        c += 1
                    End While
                End Using
            End Using

            If CloseConnection Then Connection.Close()

            R = SV & CInt(c + 1).ToString("000")

            Return R
        End Function

        Function AddNew(ByVal Name As String, ByVal Group As String, ByVal Type As String, ByVal Steps As List(Of String), ByVal SubGroup As String, ByVal Templates As List(Of String), ByVal JobID As String, ByVal CloseConnection As Boolean) As Job
            Dim R As New Job

            Dim CommandString As String = "INSERT INTO Jobs ([JobName],[Group],[Type],[Steps],[SubGroup],[Templates],[JID]) VALUES (@jobname,@group,@type,@steps,@subgroup,@templates,@jid); SELECT SCOPE_IDENTITY();"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@jobname", Name)
                AddParameter(Command, "@group", Group)
                AddParameter(Command, "@type", Type)
                AddParameter(Command, "@steps", ObjectSerilizer.ToXML(Steps))
                AddParameter(Command, "@subgroup", SubGroup)
                AddParameter(Command, "@templates", ObjectSerilizer.ToXML(Templates))
                AddParameter(Command, "@jid", JobID)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Job(ID, JobID, Name, Group, SubGroup, Type, Steps, Templates)
                Else
                    MsgBox("Unknown error while inserting job.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Name As String, ByVal Group As String, ByVal Type As String, ByVal Steps As List(Of String), ByVal SubGroup As String, ByVal Templates As List(Of String), ByVal JobID As String, ByVal CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Jobs SET [JobName]=@jobname,[Group]=@group,[Type]=@type,[Steps]=@steps,[SubGroup]=@subgroup,[Templates]=@templates,[JID]=@jid WHERE [ID]=@id;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@id", ID)
                AddParameter(Command, "@jobname", Name)
                AddParameter(Command, "@group", Group)
                AddParameter(Command, "@type", Type)
                AddParameter(Command, "@steps", ObjectSerilizer.ToXML(Steps))
                AddParameter(Command, "@subgroup", SubGroup)
                AddParameter(Command, "@templates", ObjectSerilizer.ToXML(Templates))
                AddParameter(Command, "@jid", JobID)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    MsgBox("Unknown error while updating job.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function Remove(ByVal ID As Integer) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "DELETE FROM Jobs WHERE [ID]=@ID;"
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

            Return R
        End Function

        Function GetJobByID(ByVal ID As Integer, ByVal CloseConnection As Boolean) As Job
            Dim R As Job = Nothing

            Dim CommandString As String = "SELECT * FROM [Jobs] WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read() Then
                        Dim ID_ As Integer = CInt(Reader.Item("ID").ToString)
                        Dim Name As String = Reader.Item("JobName").ToString
                        Dim Group As String = Reader.Item("Group").ToString
                        Dim SubGroup As String = Reader.Item("SubGroup").ToString
                        Dim Type As Enums.JobType = DirectCast([Enum].Parse(GetType(Enums.JobType), Reader.Item("Type").ToString), Enums.JobType)
                        Dim Steps As List(Of String) = ObjectSerilizer.FromXML(Of List(Of String))(Reader.Item("Steps").ToString)
                        Dim Templates As List(Of String) = ObjectSerilizer.FromXML(Of List(Of String))(Reader.Item("Templates").ToString)
                        Dim JID As String = Reader.Item("JID").ToString
                        R = New Job(ID_, JID, Name, Group, SubGroup, Type, Steps, Templates)
                    End If
                End Using
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function GetAll(ByVal CloseConnection As Boolean) As IEnumerable(Of Job)
            Dim R As List(Of Job) = New List(Of Job)

            Dim CommandString As String = "SELECT * FROM [Jobs]"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read()
                        Dim ID_ As Integer = CInt(Reader.Item("ID").ToString)
                        Dim Name As String = Reader.Item("JobName").ToString
                        Dim Group As String = Reader.Item("Group").ToString
                        Dim SubGroup As String = Reader.Item("SubGroup").ToString
                        Dim Type As Enums.JobType = DirectCast([Enum].Parse(GetType(Enums.JobType), Reader.Item("Type").ToString), Enums.JobType)
                        Dim Steps As List(Of String) = ObjectSerilizer.FromXML(Of List(Of String))(Reader.Item("Steps").ToString)
                        Dim Templates As List(Of String) = ObjectSerilizer.FromXML(Of List(Of String))(Reader.Item("Templates").ToString)
                        Dim JID As String = Reader.Item("JID").ToString
                        R.Add(New Job(ID_, JID, Name, Group, SubGroup, Type, Steps, Templates))
                    End While
                End Using
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

    End Module
End Namespace