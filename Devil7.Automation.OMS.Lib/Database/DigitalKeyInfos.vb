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

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Devil7.Automation.OMS.Lib.Objects

Namespace Database
    Public Module DigitalKeyInfos

#Region "Variables"
        Dim TableName As String = "DigitalKeys"
#End Region

#Region "Update Functions"
        Sub AddNew(ByVal Item As DigitalKeyInfo)
            Dim CommandString As String = String.Format("INSERT INTO {0} ([Client],[ValidFrom],[ValidTo],[Status],[Remarks]) VALUES(@Client,@ValidFrom,@ValidTo,@Status,@Remarks);SELECT SCOPE_IDENTITY();", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@Client", Item.Client.ID)
                AddParameter(Command, "@ValidFrom", Item.ValidFrom)
                AddParameter(Command, "@ValidTo", Item.ValidTo)
                AddParameter(Command, "@Status", CInt(Item.Status))
                AddParameter(Command, "@Remarks", Item.Remarks)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    Item.ForceSetID(ID)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting client.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using
        End Sub

        Function Update(ByVal Item As DigitalKeyInfo) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [Client]=@Client,[ValidFrom]=@ValidFrom,[ValidTo]=@ValidTo,[Status]=@Status,[Remarks]=@Remarks WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", Item.ID)
                AddParameter(Command, "@Client", Item.Client.ID)
                AddParameter(Command, "@ValidFrom", Item.ValidFrom)
                AddParameter(Command, "@ValidTo", Item.ValidTo)
                AddParameter(Command, "@Status", CInt(Item.Status))
                AddParameter(Command, "@Remarks", Item.Remarks)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while editing client.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

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
#End Region

#Region "Load Functions"
        Private Function Read(ByVal Reader As SqlDataReader, ByVal Clients As List(Of Client))
            Dim ID As Integer = CInt(Reader.Item("ID"))
            Dim ClientID As Integer = -1
            Integer.TryParse(Reader.Item("Client").ToString, ClientID)
            Dim Client As Client = Clients.Find(Function(c) c.ID = ClientID)
            Dim ValidFrom As Date = Nothing
            Dim ValidTo As Date = Nothing
            Date.TryParse(Reader.Item("ValidFrom"), ValidFrom)
            Date.TryParse(Reader.Item("ValidTo"), ValidTo)
            Dim Status As Enums.DigitalKeyStatus = CInt(Reader.Item("Status").ToString)
            Dim Remarks As String = Reader.Item("Remarks").ToString
            Return New DigitalKeyInfo(ID, Client, ValidFrom, ValidTo, Status, Remarks)
        End Function

        Function GetAll(ByVal Clients As List(Of Client), ByVal CloseConnection As Boolean) As List(Of DigitalKeyInfo)
            Dim R As New List(Of DigitalKeyInfo)

            Dim CommandString As String = String.Format("SELECT * FROM {0}", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State = ConnectionState.Closed Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader, Clients))
                    End While
                End Using
            End Using

            If CloseConnection AndAlso Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function
#End Region

    End Module
End Namespace