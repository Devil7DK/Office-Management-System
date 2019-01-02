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
    Public Class Service

#Region "Properties/Fields"
        <DisplayName("Service Name")>
        Property Name As String

        <DisplayName("Fees Amount")>
        Property Fees As Double
#End Region

#Region "Subs"
        Public Overrides Function ToString() As String
            Return Me.Name
        End Function
#End Region

#Region "Constructors"
        Sub New()
            Me.Name = ""
            Me.Fees = 0
        End Sub

        Sub New(ByVal Name As String, ByVal Fees As String)
            Me.Name = Name
            Me.Fees = Fees
        End Sub
#End Region

    End Class
End Namespace