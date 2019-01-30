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

Namespace Objects
    Public Class Note

#Region "Variables/Fields"
        ReadOnly Property ID As Integer

        Dim Title_ As String
        Property Title As String
            Get
                Return Title_
            End Get
            Set(value As String)
                Title_ = value
                RaiseEvent TitleChanged(Me, value)
            End Set
        End Property

        Dim Saved_ As Boolean
        <Browsable(False)>
        Property Saved As Boolean
            Get
                Return Saved_
            End Get
            Set(value As Boolean)
                Saved_ = value
                RaiseEvent SavedStatusChanged(Me, value)
            End Set
        End Property

        <DisplayName("Date Added")>
        Property DateAdded As Date

        <DisplayName("Date Last Modified")>
        Property DateEdited As Date

        Dim Content_ As String
        Property Content As String
            Get
                Return Content_
            End Get
            Set(value As String)
                Saved = False
                Content_ = value
            End Set
        End Property
#End Region

#Region "Custom Events"
        Public Event SavedStatusChanged(ByVal sender As Object, ByVal Saved As Boolean)
        Public Event TitleChanged(ByVal sender As Object, ByVal Title As String)
#End Region

#Region "Constructor"
        Sub New(ByVal ID As Integer, ByVal Title As String, ByVal Content As String, ByVal DateAdded As Date, ByVal DateEdited As Date)
            Me.ID = ID
            Me.Title = Title
            Me.Content = Content
            Me.DateAdded = DateAdded
            Me.DateEdited = DateEdited
            Me.Saved = True
        End Sub
#End Region

#Region "Subs"
        Public Sub Save(ByVal User As User)
            If ID > 0 Then
                Saved = Database.Notes.SaveContent(ID, Content)
            End If
        End Sub

        Public Sub UpdateTitle(ByVal Title As String)
            If ID > 0 Then
                If Database.Notes.Update(ID, Title) Then
                    Me.Title = Title
                End If
            End If
        End Sub
#End Region

    End Class
End Namespace