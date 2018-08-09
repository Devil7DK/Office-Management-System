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
Imports Devil7.Automation.OMS.Lib.Utils

Namespace Database
    Module Connection

        Dim connection_ As SqlConnection

        Function GetConnection() As SqlConnection
            If connection_ Is Nothing Then
                LoadConnection()
            End If
            Return connection_
        End Function

        Sub LoadConnection()
            connection_ = New SqlConnection(String.Format("Server={0};Database={1};User Id={2};Password={3};Application Name=Office Management System;Pooling={4};MultipleActiveResultSets=true;",
                                                          GetSettings.ServerName, GetSettings.DatabaseName, GetSettings.UserName, DecryptString(GetSettings.Password), GetSettings.Pooling))
        End Sub

    End Module
End Namespace
