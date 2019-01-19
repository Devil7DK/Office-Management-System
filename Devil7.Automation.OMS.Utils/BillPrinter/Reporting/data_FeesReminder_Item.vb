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
'=========================================================================='

Public Class data_FeesReminder_Item

#Region "Properties/Fields"
    Property [Date] As String
    Property Detail As String
    Property Dr As Double
    Property Cr As Double
#End Region

#Region "Constructor"
    Sub New(ByVal [Date] As String, ByVal Detail As String, ByVal Dr As Double, ByVal Cr As Double)
        Me.Date = [Date]
        Me.Detail = Detail
        Me.Dr = Dr
        Me.Cr = Cr
    End Sub
#End Region

End Class
