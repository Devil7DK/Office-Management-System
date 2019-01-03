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

Imports System.Xml.Serialization

Namespace Objects
    Public Class ClientMinimal

        <ComponentModel.Browsable(False)>
        Property ID As Integer
        Property Name As String = ""
        Property PAN As String = ""

        Sub New()
            Me.ID = 0
            Me.Name = ""
            Me.PAN = ""
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal PAN As String)
            Me.ID = ID
            Me.Name = Name
            Me.PAN = PAN
        End Sub

        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function

    End Class
End Namespace