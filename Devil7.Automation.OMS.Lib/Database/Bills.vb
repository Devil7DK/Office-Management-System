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
    Public Module Bills

#Region "Variables"
        Dim TableName As String = "Bills"
#End Region

#Region "Update Functions"
        Function AddNew(ByVal SerialNo As String, ByVal [Date] As Date, ByVal Sender As Sender, ByVal Receiver As ClientMinimal, ByVal Services As List(Of Service), ByVal CloseConnection As Boolean) As Bill
            Dim R As Bill = Nothing

            Dim CommandString As String = String.Format("INSERT INTO {0} ([SerialNo],[Date],[Sender],[Receiver],[Services]) VALUES (@SerialNo,@Date,@Sender,@Receiver,@Services);SELECT SCOPE_IDENTITY();", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@SerialNo", SerialNo)
                AddParameter(Command, "@Date", [Date])
                AddParameter(Command, "@Sender", Utils.ToXML(Sender))
                AddParameter(Command, "@Receiver", Utils.ToXML(Receiver))
                AddParameter(Command, "@Services", Utils.ToXML(Services))

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Bill(ID, SerialNo, [Date], Sender, Receiver, Services)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting bill item.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If CloseConnection And Connection.State = ConnectionState.Open Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal SerialNo As String, ByVal [Date] As Date, ByVal Sender As Sender, ByVal Receiver As ClientMinimal, ByVal Services As List(Of Service), ByVal CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [SerialNo]=@SerialNo,[Date]=@Date,[Sender]=@Sender,[Receiver]=@Receiver,[Services]=@Services WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@SerialNo", SerialNo)
                AddParameter(Command, "@Date", [Date])
                AddParameter(Command, "@Sender", Utils.ToXML(Sender))
                AddParameter(Command, "@Receiver", Utils.ToXML(Receiver))
                AddParameter(Command, "@Services", Utils.ToXML(Services))

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while editing bill item.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        Function Read(ByVal Reader As SqlDataReader) As Bill
            Dim ID As Integer = Reader.Item("ID")
            Dim SerialNo As String = Reader.Item("SerialNo").ToString
            Dim [Date] As String = Reader.Item("Date")
            Dim Sender As Sender = Utils.FromXML(Of Sender)(Reader.Item("Sender").ToString)
            Dim Receiver As ClientMinimal = Utils.FromXML(Of ClientMinimal)(Reader.Item("Receiver").ToString)
            Dim Services As List(Of Service) = Utils.FromXML(Of List(Of Service))(Reader.Item("Services").ToString)
            Return New Bill(ID, SerialNo, [Date], Sender, Receiver, Services)
        End Function

        Function GetAll(ByVal CloseConnection As Boolean) As List(Of Bill)
            Dim R As New List(Of Bill)

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