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

Imports Devil7.Automation.OMS.Lib.Objects

Public Class data_FeesReminder

#Region "Properties/Fields"
    Property Sender As Sender
    Property Receiver As Client
    Property Items As List(Of data_FeesReminder_Item)
    Property CustomText As String

    ReadOnly Property Text As String
        Get
            If CustomText <> "" Then
                Return CustomText.Replace("[Total]", Total.ToString("#,###"))
            Else
                Return My.Settings.FeesReminderDefaultText.Replace("[Total]", Total.ToString("#,###"))
            End If
        End Get
    End Property
    ReadOnly Property Total As Double
        Get
            Dim Total_ As Double = 0
            For Each i As data_FeesReminder_Item In Items
                Total_ += i.Dr
                Total_ -= i.Cr
            Next
            Return Total_
        End Get
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Sender As Sender, ByVal Receiver As Client, ByVal Items As List(Of data_FeesReminder_Item), ByVal CustomText As String)
        Me.Sender = Sender
        Me.Receiver = Receiver
        Me.Items = Items
        Me.CustomText = CustomText
    End Sub
#End Region


End Class
