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
    Public Class Sender

#Region "Properties/Fields"
        Property ID As Integer
        Property Name As String
        Property Education As String
        Property Position As String
        Property GSTIN As String

        <DisplayName("Heading for Estimate Bill")>
        Property EstimateBillHeading As String

        <DisplayName("Address Line 1")>
        Property AddressLine1 As String

        <DisplayName("Address Line 2")>
        Property AddressLine2 As String

        Property City As String

        <DisplayName("PIN Code")>
        Property PINCode As String

        Property State As String

        <DisplayName("State Code")>
        Property StateCode As Integer

        <DisplayName("Phone Number")>
        Property PhoneNo As String

        <DisplayName("Mobile Number")>
        Property MobileNo As String

        <DisplayName("E-Mail ID")>
        Property Email As String
#End Region

#Region "Subs"
        Public Overrides Function ToString() As String
            Return Me.Name
        End Function
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.Name = ""
            Me.Education = ""
            Me.Position = ""
            Me.AddressLine1 = ""
            Me.AddressLine2 = ""
            Me.City = ""
            Me.PINCode = ""
            Me.State = ""
            Me.StateCode = 0
            Me.PhoneNo = ""
            Me.MobileNo = ""
            Me.Email = ""
            Me.GSTIN = ""
            Me.EstimateBillHeading = ""
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Education As String, ByVal Position As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PINCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal PhoneNo As String, ByVal MobileNo As String, ByVal Email As String, ByVal GSTIN As String, ByVal EstimateBillHeading As String)
            Me.ID = ID
            Me.Name = Name
            Me.Education = Education
            Me.Position = Position
            Me.AddressLine1 = AddressLine1
            Me.AddressLine2 = AddressLine2
            Me.City = City
            Me.PINCode = PINCode
            Me.State = State
            Me.StateCode = StateCode
            Me.PhoneNo = PhoneNo
            Me.MobileNo = MobileNo
            Me.Email = Email
            Me.GSTIN = GSTIN
            Me.EstimateBillHeading = EstimateBillHeading
        End Sub
#End Region

    End Class
End Namespace