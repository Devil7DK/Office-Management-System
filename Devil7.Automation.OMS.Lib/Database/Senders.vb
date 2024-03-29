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
    Public Module Senders

#Region "Variables"
        Const TableName As String = "Senders"
#End Region

#Region "Subs"
        Function AddNew(ByVal Name As String, ByVal Education As String, ByVal Position As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PINCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal PhoneNo As String, ByVal MobileNo As String, ByVal Email As String, ByVal GSTIN As String, ByVal BillHeading As String, ByVal Logo As Drawing.Image, ByVal PrintLogo As Boolean, ByVal CloseConnection As Boolean) As Sender
            Dim R As New Sender

            Dim CommandString As String = String.Format("INSERT INTO {0} ([Name],[Education],[Position],[AddressLine1],[AddressLine2],[City],[PINCode],[State],[StateCode],[PhoneNo],[MobileNo],[Email],[GSTIN],[BillHeading],[Logo],[PrintLogo]) VALUES (@name,@education,@position,@addressline1,@addressline2,@city,@pincode,@state,@statecode,@phoneno,@mobileno,@email,@gstin,@BillHeading,@logo,@printlogo); SELECT SCOPE_IDENTITY();", TableName)
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
                AddParameter(Command, "@BillHeading", BillHeading)
                AddParameter(Command, "@printlogo", CInt(PrintLogo))

                Dim LogoParm As New SqlParameter("@logo", SqlDbType.Image)
                If Logo Is Nothing Then Logo = Utils.GenerateLogo(Name)
                Using MS As New IO.MemoryStream
                    Logo.Save(MS, Logo.RawFormat)
                    LogoParm.Value = MS.ToArray
                End Using
                Command.Parameters.Add(LogoParm)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Sender(ID, Name, Education, Position, AddressLine1, AddressLine2, City, PINCode, State, StateCode, PhoneNo, MobileNo, Email, GSTIN, BillHeading, Logo, PrintLogo)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting job.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Name As String, ByVal Education As String, ByVal Position As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PINCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal PhoneNo As String, ByVal MobileNo As String, ByVal Email As String, ByVal GSTIN As String, ByVal BillHeading As String, ByVal Logo As Drawing.Image, ByVal PrintLogo As Boolean, ByVal CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [Name]=@name,[Education]=@education,[Position]=@position,[AddressLine1]=@addressline1,[AddressLine2]=@addressline2,[City]=@city,[PINCode]=@pincode,[State]=@state,[StateCode]=@statecode,[PhoneNo]=@phoneno,[MobileNo]=@mobileno,[Email]=@email,[GSTIN]=@gstin,[BillHeading]=@BillHeading,[Logo]=@logo,[PrintLogo]=@printlogo WHERE [ID]=@id;", TableName)
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
                AddParameter(Command, "@BillHeading", BillHeading)
                AddParameter(Command, "@printlogo", If(PrintLogo, 1, 0))

                Dim LogoParm As New SqlParameter("@logo", SqlDbType.Image)
                If Logo Is Nothing Then Logo = Utils.GenerateLogo(Name)
                Using MS As New IO.MemoryStream
                    Logo.Save(MS, Logo.RawFormat)
                    LogoParm.Value = MS.ToArray
                End Using
                Command.Parameters.Add(LogoParm)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while updating job.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            Dim Name As String = Reader.Item("Name").ToString()
            Dim Education As String = Reader.Item("Education").ToString()
            Dim Position As String = Reader.Item("Position").ToString()
            Dim GSTIN As String = Reader.Item("GSTIN").ToString()
            Dim BillHeading As String = Reader.Item("BillHeading").ToString()
            Dim AddressLine1 As String = Reader.Item("AddressLine1").ToString()
            Dim AddressLine2 As String = Reader.Item("AddressLine2").ToString()
            Dim City As String = Reader.Item("City").ToString()
            Dim PINCode As String = Reader.Item("PINCode").ToString()
            Dim State As String = Reader.Item("State").ToString()
            Dim StateCode As Integer = Reader.Item("StateCode").ToString()
            Dim PhoneNo As String = Reader.Item("PhoneNo").ToString()
            Dim MobileNo As String = Reader.Item("MobileNo").ToString()
            Dim Email As String = Reader.Item("Email").ToString()
            Dim PrintLogo As Boolean = (CInt(Reader.Item("PrintLogo").ToString) = 1)
            Dim Logo As Drawing.Image = Nothing
            Dim LogoBytes = Reader.Item("Logo")
            If LogoBytes IsNot Nothing AndAlso TypeOf LogoBytes Is Byte() Then
                Using MS As New IO.MemoryStream(CType(LogoBytes, Byte()))
                    Logo = Drawing.Image.FromStream(MS)
                End Using
            End If
            Return New Sender(ID, Name, Education, Position, AddressLine1, AddressLine2, City, PINCode, State, StateCode, PhoneNo, MobileNo, Email, GSTIN, BillHeading, Logo, PrintLogo)
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