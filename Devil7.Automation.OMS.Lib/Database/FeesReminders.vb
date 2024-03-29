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
Imports System.Windows.Forms
Imports Devil7.Automation.OMS.Lib.Objects

Namespace Database
    Public Module FeesReminders

#Region "Variables"
        Dim TableName As String = "FeesReminders"
#End Region

#Region "Update Functions"
        Function AddNew(ByVal Sender As Sender, ByVal Receiver As Receiver, ByVal OpeningBalance As Double, ByVal Items As List(Of FeesItem), ByVal CustomText As String, ByVal CloseConnection As Boolean) As FeesReminder
            Dim R As FeesReminder = Nothing

            Dim CommandString As String = String.Format("INSERT INTO {0} ([Sender],[Receiver],[OpeningBalance],[Items],[CustomText]) VALUES (@Sender,@Receiver,@OpeningBalance,@Items,@CustomText);SELECT SCOPE_IDENTITY();", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@Sender", Utils.ToXML(Sender))
                AddParameter(Command, "@Receiver", Utils.ToXML(Receiver))
                AddParameter(Command, "@OpeningBalance", OpeningBalance)
                AddParameter(Command, "@Items", Utils.ToXML(Items))
                AddParameter(Command, "@CustomText", CustomText)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New FeesReminder(ID, Sender, Receiver, OpeningBalance, Items, CustomText)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting fees reminder item.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If CloseConnection And Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Sender As Sender, ByVal Receiver As Receiver, ByVal OpeningBalance As Double, ByVal Items As List(Of FeesItem), ByVal CustomText As String, ByVal CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [Sender]=@Sender,[Receiver]=@Receiver,[OpeningBalance]=@OpeningBalance,[Items]=@Items,[CustomText]=@CustomText WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@Sender", Utils.ToXML(Sender))
                AddParameter(Command, "@Receiver", Utils.ToXML(Receiver))
                AddParameter(Command, "@OpeningBalance", OpeningBalance)
                AddParameter(Command, "@Items", Utils.ToXML(Items))
                AddParameter(Command, "@CustomText", CustomText)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while editing fees reminder item.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If CloseConnection And Connection.State = ConnectionState.Open Then Connection.Close()

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
        Function Read(ByVal Reader As SqlDataReader) As FeesReminder
            Dim ID As Integer = Reader.Item("ID")
            Dim Sender As Sender = Utils.FromXML(Of Sender)(Reader.Item("Sender").ToString)
            Dim Receiver As Receiver = Utils.FromXML(Of Receiver)(Reader.Item("Receiver").ToString)
            Dim OpeningBalance As Double = Reader.Item("OpeningBalance")
            Dim Items As List(Of FeesItem) = Utils.FromXML(Of List(Of FeesItem))(Reader.Item("Items").ToString)
            Dim CustomText As String = Reader.Item("CustomText").ToString
            Return New FeesReminder(ID, Sender, Receiver, OpeningBalance, Items, CustomText)
        End Function

        Function GetAll(ByVal CloseConnection As Boolean) As List(Of FeesReminder)
            Dim R As New List(Of FeesReminder)

            Dim CommandString As String = String.Format("SELECT * FROM {0};", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        R.Add(Read(Reader))
                    End If
                End Using
            End Using

            If CloseConnection And Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function
#End Region

    End Module
End Namespace