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

Imports System.Xml

Namespace Objects
    Public Class JobUser

#Region "Properties/Fields"
        ReadOnly Property Job As Job
        ReadOnly Property User As User
#End Region

#Region "Constructors"
        Sub New(ByVal Job As Job, ByVal User As User)
            Me.Job = Job
            Me.User = User
        End Sub
#End Region

#Region "Shared Functions"
        Public Shared Function ToXml(ByVal List As List(Of JobUser)) As String
            Dim R As String = ""

            Dim Settings As New XmlWriterSettings()
            Settings.Indent = True
            Settings.Encoding = Text.Encoding.ASCII

            Using Stream As New IO.MemoryStream
                Using Writer As XmlWriter = XmlWriter.Create(Stream, Settings)
                    Writer.WriteStartDocument()
                    Writer.WriteStartElement("JobUserList") ' Root.
                    For Each JobUser As JobUser In List
                        Writer.WriteStartElement("JobUser")
                        Writer.WriteAttributeString("JobID", JobUser.Job.ID)
                        Writer.WriteAttributeString("UserID", JobUser.User.ID)
                        Writer.WriteEndElement()
                    Next
                    Writer.WriteEndElement()
                    Writer.WriteEndDocument()
                End Using

                R = Text.Encoding.ASCII.GetString(Stream.ToArray)
            End Using

            Return R
        End Function

        Public Shared Function FromXML(ByVal XML As String, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As List(Of JobUser)
            On Error Resume Next
            Dim R As New List(Of JobUser)

            Using Stream As New IO.MemoryStream(Text.Encoding.ASCII.GetBytes(XML))
                Using Reader As XmlReader = XmlReader.Create(Stream)
                    While Reader.Read
                        If Reader.Name = "JobUser" Then
                            Dim JobID As Integer = Reader.Item("JobID")
                            Dim UserID As Integer = Reader.Item("UserID")
                            Dim Job As Job = Jobs.Find(Function(c) c.ID = JobID)
                            Dim User As User = Users.Find(Function(c) c.ID = UserID)

                            If Job IsNot Nothing AndAlso User IsNot Nothing Then
                                R.Add(New JobUser(Job, User))
                            End If
                        End If
                    End While
                End Using
            End Using

            Return R
        End Function
#End Region

    End Class
End Namespace