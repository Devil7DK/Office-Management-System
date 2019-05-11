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
    Public Class ClientMinimalWithContact

#Region "Variables"
        Dim ID_ As Integer = -1
#End Region

#Region "Propeties"
        ReadOnly Property ID As Integer
            Get
                Return ID_
            End Get
        End Property

        Property Photo As Drawing.Image
        Property PAN As String = ""
        Property Name As String = ""
        Property Mobile As String = ""
        Property Phone As String = ""
        Property Email As String = ""
#End Region

#Region "Constructors"
        Sub New(ByVal ID As Integer)
            Me.ID_ = ID
        End Sub

        Sub New(ByVal ID As Integer, ByVal Photo As Drawing.Image, ByVal Name As String, ByVal PAN As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String)
            Me.ID_ = ID
            Me.Name = Name
            Me.Email = Email
            Me.Mobile = Mobile
            Me.Phone = Phone
            Me.PAN = PAN
            Me.Photo = Photo
        End Sub
#End Region

#Region "Subs"
        Public Overrides Function ToString() As String
            Return Name.ToString()
        End Function
#End Region

    End Class
End Namespace