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

Namespace Objects
    Public Class User

        Dim img As Drawing.Image

        Sub New(ByVal ID As Integer)
            Me.ID = ID
        End Sub

        Sub New(ByVal ID As String, ByVal Username As String, Optional ByVal UserType As Enums.UserType = Enums.UserType.User, Optional ByVal Address As String = "", Optional ByVal Mobile As String = "", Optional ByVal Email As String = "", Optional ByVal Permissions As Enums.UserPermissions = Nothing, Optional ByVal Status As String = "", Optional ByVal Photo As Drawing.Image = Nothing)
            Me.ID = ID
            Me.Username = Username
            Me.UserType = UserType
            Me.Address = Address
            Me.Mobile = Mobile
            Me.Email = Email
            Me.Permissions = Permissions
            Me.Status = Status
            Me.img = Photo
        End Sub

        Property ID As Integer = -1
        Property Username As String = ""
        Property UserType As Enums.UserType = Enums.UserType.User
        Property Address As String = ""
        Property Mobile As String = ""
        Property Email As String = ""
        Property Permissions As Enums.UserPermissions
        Property Status As String = ""

        Property Photo As Drawing.Image
            Get
                If img Is Nothing Then
                    Return Res.My.Resources.User_Default
                Else
                    Return img
                End If
            End Get
            Set(ByVal value As Drawing.Image)
                img = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return Username.ToString()
        End Function

    End Class
End Namespace