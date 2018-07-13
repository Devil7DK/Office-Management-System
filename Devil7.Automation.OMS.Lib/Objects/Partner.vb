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
    Public Class Partner

        Sub New(ByVal Name As String, ByVal Address As String, ByVal PAN As String, ByVal DOB As String)
            Me.Name = Name
            Me.Address = Address
            Me.PAN = PAN
            Me.DOB = DOB
        End Sub

        Dim dob_ As Date
        Property Name As String
        Property Address As String
        Property PAN As String

        Property DOB As String
            Get
                Return dob_.ToString("dd/MM/yyyy")
            End Get
            Set(value As String)
                Try
                    dob_ = Date.Parse(value)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function

    End Class
End Namespace
