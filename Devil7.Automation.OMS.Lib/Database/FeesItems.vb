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

Namespace Database
    Public Class FeesItems

#Region "Variables"
        Private Shared ReadOnly TableName = "MiscValues"
        Private Shared ReadOnly DataID = "FeesItems"
#End Region

#Region "Functions"
        Public Shared Function Save(ByVal FeesItems As List(Of String), ByVal CloseConnection As Boolean) As Integer
            Dim Connection As SqlConnection = GetConnection()
            Try
                If Connection.State = ConnectionState.Closed Then Connection.Open()
                Dim CommandString As String = String.Format("UPDATE {0} SET [Data] = @Data WHERE [DataID] = @DataID;", TableName)
                Using Command As New SqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@DataID", DataID)
                    Command.Parameters.AddWithValue("@Data", String.Join(vbNewLine, FeesItems))
                    Return Command.ExecuteNonQuery
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Error while saving fees items." & vbNewLine & vbNewLine & "Additional Information :" & vbNewLine & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                If CloseConnection AndAlso Connection.State = ConnectionState.Open Then Connection.Close()
            End Try
            Return 0
        End Function

        Public Shared Function Load(ByVal CloseConnection As Boolean) As List(Of String)
            Dim R As New List(Of String)
            Dim Connection As SqlConnection = GetConnection()
            Try
                If Connection.State = ConnectionState.Closed Then Connection.Open()
                Dim CommandString As String = String.Format("SELECT [Data] FROM {0} WHERE [DataID] = @DataID;", TableName)
                Using Command As New SqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@DataID", DataID)
                    Dim S As String = Command.ExecuteScalar
                    If S IsNot Nothing AndAlso S <> "" Then
                        R = New List(Of String)(S.Split(vbNewLine))
                    End If
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Error while loading fees items." & vbNewLine & vbNewLine & "Additional Information :" & vbNewLine & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            If CloseConnection AndAlso Connection.State = ConnectionState.Open Then Connection.Close()
            Return R
        End Function
#End Region

    End Class
End Namespace