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
    Public Class ExMailAddress

#Region "Properties/Fields"
        <DisplayName("Display Name")>
        Property DisplayName As String

        <DisplayName("E-Mail ID")>
        Property EMailID As String
#End Region

#Region "Functions"
        Public Shared Function ExportToString(ByVal Addresses As List(Of ExMailAddress)) As String
            Dim R As String = ""

            For Each i As ExMailAddress In Addresses
                R &= i.DisplayName & ";" & i.EMailID & vbNewLine
            Next

            Return R.Trim
        End Function

        Public Shared Function FromString(ByVal Data As String) As List(Of ExMailAddress)
            Dim R As New List(Of ExMailAddress)

            For Each line As String In Data.Split(vbNewLine)
                If line.Contains(";") AndAlso line.Split(";").Count = 2 Then
                    Dim DisplayName As String = line.Split(";")(0)
                    Dim Email As String = line.Split(";")(1)
                    R.Add(New ExMailAddress(DisplayName, Email))
                End If
            Next

            Return R
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("{0} ({1})", Me.DisplayName, Me.EMailID)
        End Function
#End Region

#Region "Constructor"
        Sub New(ByVal DisplayName As String, ByVal EMailID As String)
            Me.DisplayName = DisplayName
            Me.EMailID = EMailID
        End Sub
#End Region

    End Class
End Namespace