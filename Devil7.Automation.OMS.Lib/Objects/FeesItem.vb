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
    Public Class FeesItem

#Region "Properties/Fields"
        <DisplayName("Date")>
        Property Date_ As Date

        <DisplayName("Detail")>
        Property Name As String

        <DisplayName("Effect")>
        Property Effect As Enums.Effect

        <DisplayName("Is Date Applicable")>
        Property IsDateApplicable As Boolean
#End Region

#Region "Constructor"
        Sub New()
            Me.Date_ = Nothing
            Me.IsDateApplicable = False
            Me.Name = ""
            Me.Effect = Enums.Effect.Dr
        End Sub

        Sub New(ByVal Date_ As Date, ByVal IsDateApplicable As Boolean, ByVal Name As String, ByVal Effect As Enums.Effect)
            Me.Date_ = Date_
            Me.IsDateApplicable = IsDateApplicable
            Me.Name = Name
            Me.Effect = Effect
        End Sub
#End Region

    End Class
End Namespace