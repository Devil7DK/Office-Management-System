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
    Public Class DigitalKeyInfo

#Region "Variables"
        Dim ID_ As Integer
#End Region

#Region "Properties"
        ReadOnly Property ID As Integer
            Get
                Return ID_
            End Get
        End Property

        Property Client As Client

        <DisplayName("Company Name")>
        ReadOnly Property CompanyName As String
            Get
                If Client Is Nothing Then
                    Return ""
                Else
                    Return Client.TradeName
                End If
            End Get
        End Property

        <DisplayName("Valid From")>
        Property ValidFrom As Date

        <DisplayName("Valid To")>
        Property ValidTo As Date

        ReadOnly Property Mobile As String
            Get
                If Client Is Nothing Then
                    Return ""
                Else
                    Return Client.Mobile
                End If
            End Get
        End Property

        ReadOnly Property EMail As String
            Get
                If Client Is Nothing Then
                    Return ""
                Else
                    Return Client.Email
                End If
            End Get
        End Property

        ReadOnly Property Validity As Enums.DigitalKeyValidity
            Get
                If ValidFrom = Nothing Or ValidTo = Nothing Then
                    Return Enums.DigitalKeyValidity.NA
                ElseIf ValidFrom <> Nothing AndAlso ValidTo <> Nothing Then
                    Dim Days2Expiry As Integer = ValidTo.Subtract(Today).Days
                    If Days2Expiry < 0 Then
                        Return Enums.DigitalKeyValidity.Expired
                    ElseIf Days2Expiry = 0 Then
                        Return Enums.DigitalKeyValidity.ExpiringToday
                    ElseIf Days2Expiry <= Utils.GetSettings.DigitalAlertDays Then
                        Return Enums.DigitalKeyValidity.ExpiringSoon
                    Else
                        Return Enums.DigitalKeyValidity.Valid
                    End If
                Else
                    Return Enums.DigitalKeyValidity.Unknown
                End If
            End Get
        End Property

        <DisplayName("Days to Expire")>
        ReadOnly Property DaysToExpire As Integer
            Get
                If ValidTo = Nothing Then
                    Return 0
                Else
                    Return If(ValidTo.Subtract(Today).Days >= 0, ValidTo.Subtract(Today).Days, 0)
                End If
            End Get
        End Property

        Property Status As Enums.DigitalKeyStatus

        ReadOnly Property ResponsiblePerson As User
            Get
                If Client Is Nothing Then
                    Return Nothing
                Else
                    Return Client.ResponsiblePerson
                End If
            End Get
        End Property

        Property Remarks As String
#End Region

#Region "Constructor"
        Sub New()
            Me.ID_ = -1
            Me.Client = Nothing
            Me.ValidFrom = Nothing
            Me.ValidTo = Nothing
            Me.Status = Enums.DigitalKeyStatus.NA
            Me.Remarks = ""
        End Sub

        Sub New(ByVal ID As Integer, ByVal Client As Client, ByVal ValidFrom As Date, ByVal ValidTo As Date, ByVal Status As Enums.DigitalKeyStatus, ByVal Remarks As String)
            Me.ID_ = ID
            Me.Client = Client
            Me.ValidFrom = ValidFrom
            Me.ValidTo = ValidTo
            Me.Status = Status
            Me.Remarks = Remarks
        End Sub
#End Region

#Region "Subs"
        Sub ForceSetID(ByVal ID As Integer)
            Me.ID_ = ID
        End Sub
#End Region

    End Class
End Namespace