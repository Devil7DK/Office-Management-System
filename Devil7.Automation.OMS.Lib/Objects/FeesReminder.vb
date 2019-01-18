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
    Public Class FeesReminder

#Region "Properties/Fields"
        Property ID As Integer
        Property Sender As Sender
        Property Receiver As ClientMinimal
        Property Items As List(Of FeesItem)
        Property CustomText As String
#End Region

#Region "Constructor"
        Sub New(ByVal ID As Integer, ByVal Sender As Sender, ByVal Receiver As ClientMinimal, ByVal Items As List(Of FeesItem), ByVal CustomText As String)
            Me.ID = ID
            Me.Sender = Sender
            Me.Receiver = Receiver
            Me.Items = Items
            Me.CustomText = CustomText
        End Sub
#End Region

    End Class
End Namespace