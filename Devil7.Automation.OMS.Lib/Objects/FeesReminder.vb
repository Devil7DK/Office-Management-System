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
        Property Receiver As Receiver
        Property OpeningBalance As Double
        Property Items As List(Of FeesItem)
        Property CustomText As String

        ReadOnly Property Total As Double
            Get
                Dim Total_ As Double = 0
                Total_ += OpeningBalance
                For Each i As FeesItem In Items
                    If i.Effect = Enums.Effect.Dr Then
                        Total_ += i.Fees
                    Else
                        Total_ -= i.Fees
                    End If
                Next
                Return Total_
            End Get
        End Property
#End Region

#Region "Constructor"
        Sub New(ByVal ID As Integer, ByVal Sender As Sender, ByVal Receiver As Receiver, ByVal OpeningBalance As Double, ByVal Items As List(Of FeesItem), ByVal CustomText As String)
            Me.ID = ID
            Me.Sender = Sender
            Me.Receiver = Receiver
            Me.OpeningBalance = OpeningBalance
            Me.Items = Items
            Me.CustomText = CustomText
        End Sub
#End Region

    End Class
End Namespace