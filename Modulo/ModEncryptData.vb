Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module ModEncryptDecrypt
    ' Chave e IV para AES (devem ser mantidos em segredo)
    Private ReadOnly AESKey As String = "b14ca5898a4e4133bbce2ea2315a1916" ' Chave AES
    Private ReadOnly IV As String = "1234567890123456" ' Vetor de inicialização para AES

    ' Função para criptografar uma string usando AES
    Public Function EncryptStringAES(ByVal plainText As String) As String
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(AESKey)
        Dim ivBytes As Byte() = Encoding.UTF8.GetBytes(IV)

        Using aes As Aes = Aes.Create()
            aes.Key = keyBytes
            aes.IV = ivBytes

            Dim encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)

            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        swEncrypt.Write(plainText)
                    End Using
                End Using
                Return Convert.ToBase64String(msEncrypt.ToArray())
            End Using
        End Using
    End Function

    ' Função para descriptografar usando AES
    Private Function DecryptStringAES(ByVal encryptedText As String) As String
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(AESKey)
        Dim ivBytes As Byte() = Encoding.UTF8.GetBytes(IV)

        Using aes As Aes = Aes.Create()
            aes.Key = keyBytes
            aes.IV = ivBytes

            Dim decryptor As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)

            Using msDecrypt As New MemoryStream(Convert.FromBase64String(encryptedText))
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New StreamReader(csDecrypt)
                        Return srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
    End Function

    Sub Main()
        Dim data As String = "31/12/2024" ' Data original
        Dim encryptedData As String = EncryptStringAES(data)
        Console.WriteLine("Data criptografada: " & encryptedData)

        ' Descriptografando a data
        Dim decryptedData As String = DecryptStringAES(encryptedData)
        Console.WriteLine("Data descriptografada: " & decryptedData)
    End Sub
End Module
