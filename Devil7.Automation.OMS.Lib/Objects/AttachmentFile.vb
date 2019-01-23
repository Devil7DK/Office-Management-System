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
    Public Class AttachmentFile

#Region "Properties/Fields"
        <DisplayName("File Name")>
        ReadOnly Property FileName As String
            Get
                Return IO.Path.GetFileNameWithoutExtension(FilePath)
            End Get
        End Property

        <DisplayName("File Path")>
        ReadOnly Property FilePath As String
#End Region

#Region "Constructor"
        Sub New(ByVal FilePath As String)
            Me.FilePath = FilePath
        End Sub
#End Region

    End Class
End Namespace