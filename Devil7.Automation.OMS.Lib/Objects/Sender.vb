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
Imports System.Xml.Serialization

Namespace Objects
    Public Class Sender

#Region "Properties/Fields"
        Property ID As Integer
        Property Name As String
        Property Education As String
        Property Position As String
        Property GSTIN As String

        <DisplayName("Heading for Bill")>
        Property BillHeading As String

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

        <XmlIgnore>
        Property Logo As Drawing.Image

        <Browsable(False)>
        Property PrintLogo As Boolean

        <XmlElement("LogoData"), Browsable(False)>
        Property LogoBytes As Byte()
            Get
                If Logo Is Nothing Then
                    Return Nothing
                Else
                    Using MS As New IO.MemoryStream()
                        Try
                            Logo.Save(MS, Logo.RawFormat)
                            Return MS.ToArray
                        Catch ex As Exception
                            Return (New List(Of Byte)).ToArray
                        End Try
                    End Using
                End If
            End Get
            Set(value As Byte())
                Using MS As New IO.MemoryStream(value)
                    Logo = Drawing.Image.FromStream(MS)
                End Using
            End Set
        End Property
#End Region

#Region "Subs"
        Public Overrides Function ToString() As String
            Return String.Format("{0} ({1})", Me.Name, If(Me.BillHeading.Contains("|"), Me.BillHeading.Split("|")(0), Me.BillHeading))
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
            Me.BillHeading = ""
            Me.Logo = Nothing
            Me.PrintLogo = False
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Education As String, ByVal Position As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PINCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal PhoneNo As String, ByVal MobileNo As String, ByVal Email As String, ByVal GSTIN As String, ByVal BillHeading As String, ByVal Logo As Drawing.Image, ByVal PrintLogo As Boolean)
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
            Me.BillHeading = BillHeading
            Me.Logo = Logo
            Me.PrintLogo = PrintLogo
        End Sub
#End Region

    End Class
End Namespace