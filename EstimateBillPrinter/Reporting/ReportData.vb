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

Public Class ReportData

#Region "Properties/Variables"
    Property SerialNumber As String
    Property EstimateDate As Date
    Property Sender As Sender
    Property Receiver As Client
    Property Services As List(Of Service)
    Property Fees As Double
    Property HasGSTIN As Boolean
    Property FeesInWords As String
    Property PrintTaxDetails As Boolean
    Property GSTPercentage As Double
#End Region

#Region "Constructor"
    Sub New(ByVal SerialNumber As String, ByVal EstimateDate As Date, ByVal Sender As Sender, ByVal Receiver As Client, ByVal Services As List(Of Service), ByVal Fees As Double, ByVal HasGSTIN As Boolean, ByVal FeesInWords As String, ByVal PrintTaxDetails As Boolean, ByVal GSTPercentage As Double)
        Me.SerialNumber = SerialNumber
        Me.EstimateDate = EstimateDate
        Me.Sender = Sender
        Me.Receiver = Receiver
        Me.Services = Services
        Me.Fees = Fees
        Me.HasGSTIN = HasGSTIN
        Me.FeesInWords = FeesInWords
        Me.PrintTaxDetails = PrintTaxDetails
        Me.GSTPercentage = GSTPercentage
    End Sub
#End Region

End Class
