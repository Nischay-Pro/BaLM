Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module SecurityKey


    Public Function Encrypt(ByVal plainText As String, ByVal passPhraseshit As String) As String

        Dim passPhrase As String = passPhraseshit
        Dim saltValue As String = "NischayProSalted"
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


        Dim password As New Rfc2898DeriveBytes(passPhrase, saltValueBytes)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
    Public Function Decrypt(ByVal cipherText As String, ByVal passPhraseshit As String) As String
        Dim passPhrase As String = passPhraseshit
        Dim saltValue As String = "NischayProSalted"
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)
        Dim password As New Rfc2898DeriveBytes(passPhrase, saltValueBytes)
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)
        Dim memoryStream As New MemoryStream(cipherTextBytes)
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
        Return plainText
    End Function

End Module
