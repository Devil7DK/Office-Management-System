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
Imports Devil7.Automation.OMS.Lib.Objects

Namespace Database
    Public Module Senders

#Region "Variables"
        Const TableName As String = "Senders"
#End Region

#Region "Subs"
        Function AddNew(ByVal Name As String, ByVal Education As String, ByVal Position As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PINCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal PhoneNo As String, ByVal MobileNo As String, ByVal Email As String, ByVal GSTIN As String, ByVal EstimateBillHeading As String, ByVal CloseConnection As Boolean) As Sender
            Dim R As New Sender

            Dim CommandString As String = String.Format("INSERT INTO {0} ([Name],[Education],[Position],[AddressLine1],[AddressLine2],[City],[PINCode],[State],[StateCode],[PhoneNo],[MobileNo],[Email],[GSTIN],[EstimateBillHeading]) VALUES (@name,@education,@position,@addressline1,@addressline2,@city,@pincode,@state,@statecode,@phoneno,@mobileno,@email,@gstin,@estimatebillheading); SELECT SCOPE_IDENTITY();", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@name", Name)
                AddParameter(Command, "@education", Education)
                AddParameter(Command, "@position", Position)
                AddParameter(Command, "@addressline1", AddressLine1)
                AddParameter(Command, "@addressline2", AddressLine2)
                AddParameter(Command, "@city", City)
                AddParameter(Command, "@pincode", PINCode)
                AddParameter(Command, "@state", State)
                AddParameter(Command, "@statecode", StateCode)
                AddParameter(Command, "@phoneno", PhoneNo)
                AddParameter(Command, "@mobileno", MobileNo)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@gstin", GSTIN)
                AddParameter(Command, "@estimatebillheading", EstimateBillHeading)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Sender(ID, Name, Education, Position, AddressLine1, AddressLine2, City, PINCode, State, StateCode, PhoneNo, MobileNo, Email, GSTIN, EstimateBillHeading)
                Else
                    MsgBox("Unknown error while inserting job.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Name As String, ByVal Education As String, ByVal Position As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PINCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal PhoneNo As String, ByVal MobileNo As String, ByVal Email As String, ByVal GSTIN As String, ByVal EstimateBillHeading As String, ByVal CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [Name]=@name,[Education]=@education,[Position]=@position,[AddressLine1]=@addressline1,[AddressLine2]=@addressline2,[City]=@city,[PINCode]=@pincode,[State]=@state,[StateCode]=@statecode,[PhoneNo]=@phoneno,[MobileNo]=@mobileno,[Email]=@email,[GSTIN]=@gstin,[EstimateBillHeading]=@estimatebillheading WHERE [ID]=@id;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@id", ID)
                AddParameter(Command, "@name", Name)
                AddParameter(Command, "@education", Education)
                AddParameter(Command, "@position", Position)
                AddParameter(Command, "@addressline1", AddressLine1)
                AddParameter(Command, "@addressline2", AddressLine2)
                AddParameter(Command, "@city", City)
                AddParameter(Command, "@pincode", PINCode)
                AddParameter(Command, "@state", State)
                AddParameter(Command, "@statecode", StateCode)
                AddParameter(Command, "@phoneno", PhoneNo)
                AddParameter(Command, "@mobileno", MobileNo)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@gstin", GSTIN)
                AddParameter(Command, "@estimatebillheading", EstimateBillHeading)

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

            Return R
        End Function

        Private Function Read(ByVal Reader As SqlDataReader) As Sender
            Dim ID As Integer = Reader.Item("ID")
            Dim Name As String = Reader.item("Name").Tostring()
            Dim Education As String = Reader.item("Education").Tostring()
            Dim Position As String = Reader.item("Position").Tostring()
            Dim GSTIN As String = Reader.item("GSTIN").Tostring()
            Dim EstimateBillHeading As String = Reader.item("EstimateBillHeading").Tostring()
            Dim AddressLine1 As String = Reader.item("AddressLine1").Tostring()
            Dim AddressLine2 As String = Reader.item("AddressLine2").Tostring()
            Dim City As String = Reader.item("City").Tostring()
            Dim PINCode As String = Reader.item("PINCode").Tostring()
            Dim State As String = Reader.item("State").Tostring()
            Dim StateCode As Integer = Reader.item("StateCode").Tostring()
            Dim PhoneNo As String = Reader.item("PhoneNo").Tostring()
            Dim MobileNo As String = Reader.item("MobileNo").Tostring()
            Dim Email As String = Reader.item("Email").Tostring()
            Return New Sender(ID, Name, Education, Position, AddressLine1, AddressLine2, City, PINCode, State, StateCode, PhoneNo, MobileNo, Email, GSTIN, EstimateBillHeading)
        End Function

        Function GetSenderByID(ByVal ID As Integer, ByVal CloseConnection As Boolean) As Sender
            Dim R As Sender = Nothing

            Dim CommandString As String = String.Format("SELECT * FROM {0} WHERE [ID]=@ID;", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read() Then
                        R = Read(Reader)
                    End If
                End Using
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function GetAll(ByVal CloseConnection As Boolean) As IEnumerable(Of Sender)
            Dim R As List(Of Sender) = New List(Of Sender)

            Dim CommandString As String = String.Format("SELECT * FROM {0};", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read()
                        R.Add(Read(Reader))
                    End While
                End Using
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function
#End Region

    End Module
End Namespace