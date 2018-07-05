Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class Form1

    Private Sub btn_Encrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Encrypt.Click
        Try
            txt_Value.Text = EncryptString(txt_Value.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Decrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Decrypt.Click
        Try
            txt_Value.Text = DecryptString(txt_Value.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

Friend Class TripleDES
    ' define the triple des provider
    Private m_des As New TripleDESCryptoServiceProvider
    ' define the string handler
    Private m_utf8 As New UTF8Encoding
    ' define the local property arrays
    Private m_key() As Byte
    Private m_iv() As Byte
    Public Sub New(ByVal key() As Byte, ByVal iv() As Byte)
        Me.m_key = key
        Me.m_iv = iv
    End Sub
    Public Function Encrypt(ByVal input() As Byte) As Byte()
        Return Transform(input, m_des.CreateEncryptor(m_key, m_iv))
    End Function
    Public Function Decrypt(ByVal input() As Byte) As Byte()
        Return Transform(input, m_des.CreateDecryptor(m_key, m_iv))
    End Function
    Public Function Encrypt(ByVal text As String) As String
        Dim input() As Byte = m_utf8.GetBytes(text)
        Dim output() As Byte = Transform(input, _
                        m_des.CreateEncryptor(m_key, m_iv))
        Return Convert.ToBase64String(output)
    End Function
    Public Function Decrypt(ByVal text As String) As String
        Dim input() As Byte = Convert.FromBase64String(text)
        Dim output() As Byte = Transform(input, _
                         m_des.CreateDecryptor(m_key, m_iv))
        Return m_utf8.GetString(output)
    End Function
    Private Function Transform(ByVal input() As Byte, _
        ByVal CryptoTransform As ICryptoTransform) As Byte()
        ' create the necessary streams
        Dim memStream As MemoryStream = New MemoryStream
        Dim cryptStream As CryptoStream = New  _
            CryptoStream(memStream, CryptoTransform, _
            CryptoStreamMode.Write)
        ' transform the bytes as requested
        cryptStream.Write(input, 0, input.Length)
        cryptStream.FlushFinalBlock()
        ' Read the memory stream and convert it back into byte array
        memStream.Position = 0
        Dim result(CType(memStream.Length - 1, System.Int32)) As Byte
        memStream.Read(result, 0, CType(result.Length, System.Int32))
        ' close and release the streams
        memStream.Close()
        cryptStream.Close()
        ' hand back the encrypted buffer
        Return result
    End Function

End Class
Public Module Encryption
    Private ReadOnly key() As Byte = System.Text.Encoding.ASCII.GetBytes("D3^!l$3^3nOficeMgmtSystm")
    Private ReadOnly iv() As Byte = {8, 7, 6, 5, 4, 3, 2, 1}
    Public Function EncryptString(ByVal Value As String) As String
        Dim des As New TripleDES(key, iv)
        Return des.Encrypt(Value)
    End Function
    Public Function DecryptString(ByVal Value As String) As String
        Dim des As New TripleDES(key, iv)
        Return des.Decrypt(Value)
    End Function
End Module