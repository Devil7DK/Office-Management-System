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
    Public Class EstimateBill

#Region "Properties/Fields"
        Property ID As Integer

        <DisplayName("Serial Number")>
        Property SerialNo As String

        <DisplayName("Estimate Date")>
        Property EstimateDate As Date

        Property Sender As Sender

        Property Receiver As ClientMinimal

        Property Services As List(Of Service)

        ReadOnly Property Fees As Double
            Get
                Dim Fees_ As Double = 0

                If Services IsNot Nothing Then
                    For Each Service As Service In Services
                        Fees_ += Service.Fees
                    Next
                End If

                Return Fees_
            End Get
        End Property

        <Browsable(False)>
        ReadOnly Property HasGSTIN As Boolean
            Get
                If Sender Is Nothing Then
                    Return False
                Else
                    Return Sender.GSTIN.Trim <> ""
                End If
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New(ByVal ID As Integer, ByVal SerialNo As String, ByVal EstimateDate As Date, ByVal Sender As Sender, ByVal Receiver As ClientMinimal, ByVal Services As List(Of Service))
            Me.ID = ID
            Me.SerialNo = SerialNo
            Me.EstimateDate = EstimateDate
            Me.Sender = Sender
            Me.Receiver = Receiver
            Me.Services = Services
        End Sub
#End Region

    End Class
End Namespace