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

Imports System.ComponentModel

Namespace Objects
    Public Class FeesItem

#Region "Properties/Fields"
        <DisplayName("Date")>
        Property [Date] As Date

        <DisplayName("Detail")>
        Property Name As String

        <DisplayName("Effect")>
        Property Effect As Enums.Effect

        <DisplayName("Fees")>
        Property Fees As Double
#End Region

#Region "Constructor"
        Sub New()
            Me.[Date] = Nothing
            Me.Name = ""
            Me.Effect = Enums.Effect.Dr
            Me.Fees = 0
        End Sub

        Sub New(ByVal [Date] As Date, ByVal Name As String, ByVal Effect As Enums.Effect, ByVal Fees As Double)
            Me.[Date] = [Date]
            Me.Name = Name
            Me.Effect = Effect
            Me.Fees = Fees
        End Sub
#End Region

    End Class
End Namespace