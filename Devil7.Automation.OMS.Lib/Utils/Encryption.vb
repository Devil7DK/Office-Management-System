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

Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Namespace Utils
    Public Module Encryption

        Private m_des As New TripleDESCryptoServiceProvider
        Private m_utf8 As New UTF8Encoding
        Private m_key() As Byte = System.Text.Encoding.ASCII.GetBytes("D3^!l$3^3nOficeMgmtSystm")
        Private m_iv() As Byte = {8, 7, 6, 5, 4, 3, 2, 1}

        Public Function EncryptBytes(ByVal input() As Byte) As Byte()
            Return Transform(input, m_des.CreateEncryptor(m_key, m_iv))
        End Function

        Public Function DecryptBytes(ByVal input() As Byte) As Byte()
            Try
                Return Transform(input, m_des.CreateDecryptor(m_key, m_iv))
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function EncryptString(ByVal text As String) As String
            Dim input() As Byte = m_utf8.GetBytes(text)
            Dim output() As Byte = Transform(input, _
                            m_des.CreateEncryptor(m_key, m_iv))
            Return Convert.ToBase64String(output)
        End Function

        Public Function DecryptString(ByVal text As String) As String
            Try
                Dim input() As Byte = Convert.FromBase64String(text)
                Dim output() As Byte = Transform(input, _
                                 m_des.CreateDecryptor(m_key, m_iv))
                Return m_utf8.GetString(output)
            Catch ex As Exception
                Return ""
            End Try
        End Function

        Private Function Transform(ByVal input() As Byte, _
            ByVal CryptoTransform As ICryptoTransform) As Byte()
            Dim result As Byte()
            Using memStream As MemoryStream = New MemoryStream
                Using cryptStream As CryptoStream = New  _
                    CryptoStream(memStream, CryptoTransform, _
                    CryptoStreamMode.Write)
                    cryptStream.Write(input, 0, input.Length)
                    cryptStream.FlushFinalBlock()
                    memStream.Position = 0
                    ReDim result(CType(memStream.Length - 1, System.Int32))
                    memStream.Read(result, 0, CType(result.Length, System.Int32))
                End Using
            End Using
            Return result
        End Function

    End Module
End Namespace