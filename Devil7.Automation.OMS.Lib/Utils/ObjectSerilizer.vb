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

Imports System.Xml.Serialization

Namespace Utils
    Public Module ObjectSerilizer

        Function FromXML(Of T)(ByVal XML As String) As T
            Dim R As T = Nothing
            Dim XS As New XmlSerializer(GetType(T))
            Using MS As New IO.MemoryStream(Text.Encoding.ASCII.GetBytes(XML))
                Try
                    R = XS.Deserialize(MS)
                Catch ex As Exception

                End Try
            End Using
            Return R
        End Function

        Function ToXML(Of T)(ByVal Obj As T) As String
            Dim R As String = ""
            Dim XS As New XmlSerializer(GetType(T))
            Using MS As New IO.MemoryStream
                Try
                    XS.Serialize(MS, Obj)
                    R = Text.Encoding.ASCII.GetString(MS.ToArray)
                Catch ex As Exception

                End Try
            End Using
            Return R
        End Function

        Function FromFile(Of T)(ByVal FilePath As String) As T
            Dim R As T = Nothing
            If My.Computer.FileSystem.FileExists(FilePath) Then
                Try
                    Dim XS As New XmlSerializer(GetType(T))
                    Using FS As New IO.FileStream(FilePath, IO.FileMode.Open)
                        R = XS.Deserialize(FS)
                    End Using
                Catch ex As Exception

                End Try
            End If
            Return R
        End Function

        Sub ToFile(Of T)(ByVal Obj As T, ByVal FilePath As String)
            If Obj IsNot Nothing Then
                Dim XS As New XmlSerializer(GetType(T))
                Using FS As New IO.FileStream(FilePath, IO.FileMode.Create)
                    XS.Serialize(FS, Obj)
                End Using
            End If
        End Sub

    End Module
End Namespace