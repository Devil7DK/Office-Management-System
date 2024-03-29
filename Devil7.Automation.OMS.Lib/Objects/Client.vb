﻿'=========================================================================='
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
    Public Class Client

        Dim ID_ As Integer = -1
        ReadOnly Property ID As Integer
            Get
                Return ID_
            End Get
        End Property

        Property Photo As Drawing.Image = Nothing
        Property PAN As String = ""
        Property Name As String = ""
        Property FatherName As String = ""
        Property TradeName As String
        Property Mobile As String = ""
        Property Phone As String = ""
        Property Email As String = ""
        Property AddressLine1 As String = ""
        Property AddressLine2 As String = ""
        Property City As String = ""
        Property PinCode As String = ""
        Property State As String = ""
        Property StateCode As Integer = 0
        Property DOB As Date
        Property AadharNo As String = ""
        Property GST As String = ""
        Property FileNo As String = ""
        Property Type As String = ""
        Property Description As String = ""
        Property TypeOfEngagement As String = ""
        Property Status As String = ""
        Property Partners As List(Of Partner)
        Property Jobs As List(Of JobUser)
        Property ResponsiblePerson As User

        Sub New(ByVal ID As Integer)
            Me.ID_ = ID
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal PAN As String, ByVal FatherName As String, ByVal TradeName As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal AadharNo As String, ByVal Description As String, ByVal TypeOfEngagement As String, ByVal Partners As List(Of Partner), ByVal Type As String, ByVal Jobs As List(Of JobUser), ByVal ResponsiblePerson As User, ByVal Status As String, ByVal Photo As Drawing.Image, ByVal GST As String, ByVal FileNo As String)
            Me.ID_ = ID
            Me.Name = Name
            Me.AadharNo = AadharNo
            Me.AddressLine1 = AddressLine1
            Me.AddressLine2 = AddressLine2
            Me.City = City
            Me.Description = Description
            Me.DOB = Date.Parse(DOB)
            Me.Email = Email
            Me.FatherName = FatherName
            Me.Jobs = Jobs
            Me.Mobile = Mobile
            Me.Phone = Phone
            Me.PAN = PAN
            Me.Partners = Partners
            Me.Photo = Photo
            Me.PinCode = PinCode
            Me.State = State
            Me.StateCode = StateCode
            Me.Status = Status
            Me.TradeName = TradeName
            Me.Type = Type
            Me.TypeOfEngagement = TypeOfEngagement
            Me.GST = GST
            Me.FileNo = FileNo
            Me.ResponsiblePerson = ResponsiblePerson
        End Sub

        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function

    End Class
End Namespace