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

Namespace Enums
    <Flags()> _
    Public Enum UserPermissions
        Basic = 0
        CreateUser = 1
        EditUser = 2
        ViewUser = 4
        AddJob = 8
        EditJob = 16
        ViewJob = 32
        AddWork = 64
        EditWork = 128
        ViewWork = 256
        AddClient = 512
        EditClient = 1024
        ViewClient = 2048
    End Enum
End Namespace