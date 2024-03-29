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
Imports Devil7.Automation.OMS.Lib.Utils

Namespace Database
    Public Module Users

        Function GetUsernames() As String()
            Dim R As New List(Of String)

            Dim CommandString As String = "SELECT [Username] FROM [Users];"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        If Reader.Item("Username").ToString.Trim <> "" Then R.Add(Reader.Item("Username").ToString.Trim)
                    End While
                End Using
            End Using

            Return R.ToArray
        End Function

        Function Login(ByVal Username As String, ByVal Password As String) As User
            Dim R As User = Nothing

            Dim CommandString As String = "SELECT * FROM [Users] WHERE [Username] = @Username AND [Password] = @Password;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@Username", Username)
                AddParameter(Command, "@Password", Encryption.EncryptString(Password))
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim ID As Integer = Reader.Item("ID")
                        Dim UserType As Enums.UserType = Reader.Item("UserType")
                        Dim Address As String = Reader.Item("Address").ToString
                        Dim Mobile As String = Reader.Item("Mobile").ToString
                        Dim Email As String = Reader.Item("Email").ToString
                        Dim Permissions As Enums.UserPermissions
                        If Reader.Item("Permissions").ToString <> "" Then
                            Permissions = [Enum].Parse(GetType(Enums.UserPermissions), Reader.Item("Permissions").ToString)
                        End If
                        Dim Status As String = Reader.Item("Status").ToString
                        Dim Photo As Drawing.Image = Res.My.Resources.User_Default
                        Try
                            Photo = Drawing.Image.FromStream(New IO.MemoryStream(CType(Reader.Item("Photo"), Byte())))
                        Catch ex As Exception

                        End Try
                        R = New User(ID, Username, UserType, Address, Mobile, Email, Permissions, Status, Photo)
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Username or Password.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            End Using

            Return R
        End Function

        Function ChangePassword(Username As String, OldPassword As String, NewPassword As String, CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE [Users] SET [Password]=@NewPassword WHERE [Username] = @Username AND [Password] = @OldPassword"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@Username", Username)
                AddParameter(Command, "@OldPassword", Encryption.EncryptString(OldPassword))
                AddParameter(Command, "@NewPassword", Encryption.EncryptString(NewPassword))
                Dim Count As Integer = Command.ExecuteNonQuery
                If Count = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Old Password Not Matching.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    R = False
                Else
                    R = True
                End If
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function ResetPassword(ID As String, CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE [Users] SET [Password]=@Password WHERE [ID] = @ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@Password", Encryption.EncryptString("123"))
                Dim Count As Integer = Command.ExecuteNonQuery
                If Count = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unable to reset password.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    R = False
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Successfully reseted password to 123.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R = True
                End If
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function AddNew(Username As String, UserType As Enums.UserType, Password As String, Address As String, Mobile As String, Email As String, Permissions As Enums.UserPermissions, Status As String, Photo As Drawing.Image) As User
            Dim R As User = Nothing

            Dim CommandString As String = "INSERT INTO [Users] ([Username],[UserType],[Password],[Address],[Mobile],[Email],[Permissions],[Status],[Photo]) VALUES (@username,@usertype,@password,@address,@mobile,@email,@permissions,@status,@photo);SELECT SCOPE_IDENTITY();"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Dim ms As New IO.MemoryStream
                Photo.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
                AddParameter(Command, "@username", Username)
                AddParameter(Command, "@usertype", UserType)
                AddParameter(Command, "@password", EncryptString(Password))
                AddParameter(Command, "@address", Address)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@permissions", Permissions.ToString)
                AddParameter(Command, "@status", Status)
                AddParameter(Command, "@photo", ms.ToArray)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New User(ID, Username, UserType, Address, Mobile, Email, Permissions, Status, Photo)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting user.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            Return R
        End Function

        Function Update(ByVal ID As Integer, Username As String, UserType As Enums.UserType, Address As String, Mobile As String, Email As String, Permissions As Enums.UserPermissions, Status As String, Photo As Drawing.Image) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Users SET [Username]=@username,[UserType]=@usertype,[Address]=@address,[Mobile]=@mobile,[Email]=@email,[Permissions]=@permissions,[Status]=@status,[Photo]=@photo WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Dim ms As New IO.MemoryStream
                Photo.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@username", Username)
                AddParameter(Command, "@usertype", UserType)
                AddParameter(Command, "@address", Address)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@permissions", Permissions.ToString)
                AddParameter(Command, "@status", Status)
                AddParameter(Command, "@photo", ms.ToArray)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while editing user.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            Return R
        End Function

        Function Remove(ByVal ID As Integer) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "DELETE FROM Users WHERE [ID]=@ID;"
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

        Function GetAll(CloseConnection As Boolean) As IEnumerable(Of User)
            Dim R As New List(Of User)

            Dim CommandString As String = "SELECT * FROM [Users]"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        Dim ID As Integer = Reader.Item("ID")
                        Dim Username As String = Reader.Item("Username").ToString
                        Dim UserType As Enums.UserType = Reader.Item("UserType")
                        Dim Address As String = Reader.Item("Address").ToString
                        Dim Mobile As String = Reader.Item("Mobile").ToString
                        Dim Email As String = Reader.Item("Email").ToString
                        Dim Permissions As Enums.UserPermissions
                        If Reader.Item("Permissions").ToString <> "" Then
                            Permissions = [Enum].Parse(GetType(Enums.UserPermissions), Reader.Item("Permissions").ToString)
                        End If
                        Dim Status As String = Reader.Item("Status").ToString
                        Dim Photo As Drawing.Image = Res.My.Resources.User_Default
                        Try
                            Photo = Drawing.Image.FromStream(New IO.MemoryStream(CType(Reader.Item("Photo"), Byte())))
                        Catch ex As Exception

                        End Try
                        R.Add(New User(ID, Username, UserType, Address, Mobile, Email, Permissions, Status, Photo))
                    End While
                End Using
            End Using

            If CloseConnection Then Connection.Close()

            Return R
        End Function

        Function GetUserByID(ByVal ID As Integer) As User
            Dim R As User = Nothing
            Dim CommandString As String = "SELECT * FROM Users WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        Dim Username As String = Reader.Item("Username").ToString
                        Dim UserType As Enums.UserType = Reader.Item("UserType")
                        Dim Address As String = Reader.Item("Address").ToString
                        Dim Mobile As String = Reader.Item("Mobile").ToString
                        Dim Email As String = Reader.Item("Email").ToString
                        Dim Permissions As Enums.UserPermissions
                        If Reader.Item("Permissions").ToString <> "" Then
                            Permissions = [Enum].Parse(GetType(Enums.UserPermissions), Reader.Item("Permissions").ToString)
                        End If
                        Dim Status As String = Reader.Item("Status").ToString
                        Dim Photo As Drawing.Image = Res.My.Resources.User_Default
                        Try
                            Photo = Drawing.Image.FromStream(New IO.MemoryStream(CType(Reader.Item("Photo"), Byte())))
                        Catch ex As Exception

                        End Try
                        R = New User(ID, Username, UserType, Address, Mobile, Email, Permissions, Status, Photo)
                    End If
                End Using
            End Using
            Return R
        End Function

    End Module
End Namespace