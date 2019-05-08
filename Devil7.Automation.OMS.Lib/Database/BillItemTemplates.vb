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
    Public Module BillItemTemplates

#Region "Variables"
        Dim TableName As String = "BillItemTemplates"
#End Region

#Region "Update Functions"
        Sub AddNew(ByVal Item As BillItemTemplate)
            Dim R As Bill = Nothing

            Dim CommandString As String = String.Format("INSERT INTO {0} ([Group],[Name],[Template],[Type]) VALUES (@Group,@Name,@Template,@Type);SELECT SCOPE_IDENTITY();", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@Group", Item.Group.Trim)
                AddParameter(Command, "@Name", Item.Name.Trim)
                AddParameter(Command, "@Template", Item.Template.Trim)
                AddParameter(Command, "@Type", Item.Type)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    Item.ForceSetID(ID)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting bill item.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

        End Sub

        Function Update(ByVal Item As BillItemTemplate) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [Group]=@Group,[Name]=@Name,[Template]=@Template,[Type]=@Type WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", Item.ID)
                AddParameter(Command, "@Group", Item.Group.Trim)
                AddParameter(Command, "@Name", Item.Name.Trim)
                AddParameter(Command, "@Template", Item.Template.Trim)
                AddParameter(Command, "@Type", Item.Type)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while editing bill item.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function Remove(ByVal ID As Integer, ByVal CloseConnection As Boolean) As Boolean
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

            If CloseConnection And Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function
#End Region

#Region "Load Functions"
        Function Read(ByVal Reader As SqlDataReader) As BillItemTemplate
            Dim ID As Integer = Reader.Item("ID")
            Dim Group As String = Reader.Item("Group").ToString.Trim
            Dim Name As String = Reader.Item("Name").ToString.Trim
            Dim Template As String = Reader.Item("Template").ToString.Trim
            Dim Type As Enums.BillItemType = CInt(Reader.Item("Type").ToString.Trim)

            Return New BillItemTemplate(ID, Group, Name, Template, Type)
        End Function

        Function GetAll(ByVal CloseConnection As Boolean) As BindingList(Of BillItemTemplate)
            Dim R As New BindingList(Of BillItemTemplate) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}

            Dim CommandString As String = String.Format("SELECT * FROM {0};", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader))
                    End While
                End Using
            End Using

            If CloseConnection And Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function
#End Region

    End Module
End Namespace