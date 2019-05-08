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
    Public Class BillItemTemplate

#Region "Variables"
        Dim ID_ As Integer = -1
#End Region

#Region "Properties/Fields"
        ReadOnly Property ID As Integer
            Get
                Return ID_
            End Get
        End Property

        Property Group As String
        Property Name As String
        Property Template As String
        Property Type As Enums.BillItemType
#End Region

#Region "Constructors"
        Sub New()
            Me.ID_ = -1
            Me.Group = ""
            Me.Name = ""
            Me.Template = ""
            Me.Type = Enums.BillItemType.NoDate
        End Sub

        Sub New(ByVal ID As Integer, ByVal Group As String, ByVal Name As String, ByVal Template As String, ByVal Type As Enums.BillItemType)
            Me.ID_ = ID
            Me.Group = Group
            Me.Name = Name
            Me.Template = Template
            Me.Type = Type
        End Sub
#End Region

#Region "Subs"
        Sub ForceSetID(ByVal ID As Integer)
            Me.ID_ = ID
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
#End Region

    End Class
End Namespace