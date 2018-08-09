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

Namespace Objects
    Public Class Job

        Sub New()
            Me.ID_ = 0
            Me.Name = ""
            Me.Group = ""
            Me.SubGroup = ""
            Me.Type = Enums.JobType.Once
            Me.Steps = New List(Of String)
            Me.Templates = New List(Of String)
            Me.FollowUps = New List(Of Job)
        End Sub

        Sub New(ByVal ID As String, ByVal Name As String, ByVal Group As String, ByVal SubGroup As String, ByVal Type As Enums.JobType, ByVal Steps As List(Of String), ByVal Templates As List(Of String), ByVal FollowUps As List(Of Job))
            Me.ID_ = ID
            Me.Name = Name
            Me.Group = Group
            Me.SubGroup = SubGroup
            Me.Type = Type
            Me.Steps = Steps
            Me.Templates = Templates
            Me.FollowUps = FollowUps
        End Sub

        Dim ID_ As Integer = -1
        Property ID As Integer
            Get
                Return ID_
            End Get
            Set(value As Integer)
                ID_ = value
            End Set
        End Property

        Property Name As String
        Property Group As String
        Property SubGroup As String
        Property Type As Enums.JobType
        Property Steps As List(Of String)
        Property Templates As List(Of String)
        Property FollowUps As List(Of Job)

        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function

    End Class
End Namespace