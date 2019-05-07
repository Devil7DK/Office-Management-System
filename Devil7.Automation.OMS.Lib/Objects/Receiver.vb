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
    Public Class Receiver

#Region "Properties"
        ReadOnly Property RID As String = ""

        Property PAN As String = ""
        Property Name As String = ""
        Property Mobile As String = ""
        Property Phone As String = ""
        Property Email As String = ""
        Property AddressLine1 As String = ""
        Property AddressLine2 As String = ""
        Property City As String = ""
        Property PinCode As String = ""
        Property State As String = ""
        Property StateCode As Integer = 0
        Property GST As String = ""
#End Region

#Region "Constructor"
        Sub New(ByVal RID As String)
            Me.RID = RID
        End Sub

        Sub New(ByVal RID As String, ByVal Name As String, ByVal PAN As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal GST As String)
            Me.RID = RID
            Me.Name = Name
            Me.AddressLine1 = AddressLine1
            Me.AddressLine2 = AddressLine2
            Me.City = City
            Me.Email = Email
            Me.Mobile = Mobile
            Me.Phone = Phone
            Me.PAN = PAN
            Me.PinCode = PinCode
            Me.State = State
            Me.StateCode = StateCode
            Me.GST = GST
        End Sub
#End Region

#Region "Subs"
        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function
#End Region

    End Class
End Namespace