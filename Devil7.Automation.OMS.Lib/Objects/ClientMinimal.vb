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
    Public Class ClientMinimal

        Dim ID_ As Integer = -1
        ReadOnly Property ID As Integer
            Get
                Return ID_
            End Get
        End Property

        Property PAN As String = ""
        Property Name As String = ""

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal PAN As String)
            Me.ID_ = ID
            Me.Name = Name
            Me.PAN = PAN
        End Sub

        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function

    End Class
End Namespace