using System;  
using System.IO;  
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Gestionnaire.manager
{

    class AESManager
    {
        public static void t(XmlDocument xmlDoc)
        {
            Console.WriteLine("Enter text that needs to be encrypted..");
            string data = Console.ReadLine();
            EncryptAesManaged(data, "test");
            Console.ReadLine();
        }

        public static void EncryptAesManaged(XmlDocument xmlDoc, string password)
        {
            byte[] encrypted = {0};
            byte[] salt = GenerateRandomSalt();

            //convert password string to byte arrray
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            try
            {
                Console.WriteLine("Try to encrypt !" + xmlDoc.OuterXml);
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;
                    var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    // Encrypt string    
                    encrypted = Encrypt(xmlDoc, aes.Key, aes.IV);
                    // Print encrypted string    
                    Console.WriteLine("Encrypted data: "+ System.Text.Encoding.UTF8.GetString(encrypted));
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
            try
            {
                Console.WriteLine("Try to decrypt !");
                //using (AesManaged aes = new AesManaged())
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;
                    var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    
                    // Decrypt the bytes to a string.    
                    string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
                    // Print decrypted string. It should be same as raw data    
                    Console.WriteLine("Decrypted data: "+decrypted);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error during decryption :" + exp.Message);
            }

        }

        static byte[] Encrypt(XmlDocument xmlDoc, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            //using (AesManaged aes = new AesManaged())
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(xmlDoc.InnerXml);
                        encrypted = ms.ToArray();
                    }
                }
            }

            // Return encrypted data    
            return encrypted;
        }
        public static void EncryptAesManaged(string raw, string password)
        {
            byte[] encrypted = {0};
            byte[] salt = GenerateRandomSalt();

            //convert password string to byte arrray
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            try
            {
                Console.WriteLine("Try to encrypt !" + raw);
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;
                    var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    // Encrypt string    
                    encrypted = Encrypt(raw, aes.Key, aes.IV);
                    // Print encrypted string    
                    Console.WriteLine("Encrypted data: "+ System.Text.Encoding.UTF8.GetString(encrypted));
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
            try
            {
                Console.WriteLine("Try to decrypt !");
                //using (AesManaged aes = new AesManaged())
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;
                    var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    
                    // Decrypt the bytes to a string.    
                    string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
                    // Print decrypted string. It should be same as raw data    
                    Console.WriteLine("Decrypted data: "+decrypted);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error during decryption :" + exp.Message);
            }

            Console.ReadKey();
        }

        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            //using (AesManaged aes = new AesManaged())
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }

            // Return encrypted data    
            return encrypted;
        }

        static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            //using (AesManaged aes = new AesManaged())
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }

            return plaintext;
        }

        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }
        
        //Get an XML Document then encrypt it with AES Encryption in a file 
        public static void EncryptXmlDocumentToFile(XmlDocument xmlDoc, string filePath, string password)
        {
            //http://stackoverflow.com/questions/27645527/aes-encryption-on-large-files

            //generate random salt
            byte[] salt = GenerateRandomSalt();

            //create output file name
            FileStream fsCrypt = new FileStream(filePath, File.Exists(filePath) ? FileMode.Truncate : FileMode.Create);

            //convert password string to byte arrray
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            //Set Rijndael symmetric encryption algorithm
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            //http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
            //"What it does is repeatedly hash the user password along with the salt." High iteration counts.
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            //AES.Mode = CipherMode.CFB;

            // write salt to the begining of the output file, so in this case can be random every time
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            MemoryStream memoryStream = new MemoryStream();
            xmlDoc.Save(memoryStream);
            memoryStream.Flush();
            memoryStream.Position = 0;
            
            Console.WriteLine("Save into memoryStream : " + memoryStream.Length);
            
            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;
            int total = 0;
            try
            {
                Console.WriteLine("Avant de lire");
                while ((read = memoryStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    total += read;
                    cs.Write(buffer, 0, read);
                }
                Console.WriteLine("Après de lire  = " + total);
                // Close up
                memoryStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }
        
        //Decrypt a file into a XML Document
        public static XmlDocument DecryptFileToXmlDocument(string filePath, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(filePath, FileMode.Open);
            var position = fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            
            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Flush();
            memoryStream.Position = 0;
            XmlDocument xmlDocument = new XmlDocument();

            int read;
            byte[] buffer = new byte[1048576];
            int total = 0;
            try
            {
                cs.Read(buffer, 0, 3);
                Console.WriteLine("Il y a "+fsCrypt.Length+" a lire");
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    total += read;
                    memoryStream.Write(buffer, 0, read);
                }
                Console.WriteLine("Lecture de = "+total);
                Console.WriteLine("Save into memoryStream : " + memoryStream.Length);
                Console.WriteLine("Data in MemoryStream :" + Encoding.Default.GetString(memoryStream.ToArray()));
                xmlDocument.LoadXml(Encoding.Default.GetString(memoryStream.ToArray()));
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Error: " + ex.Message + " linenumber : "+ ex.LineNumber +" lineposition : " + ex.LinePosition);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                memoryStream.Close();
                fsCrypt.Close();
            }

            return xmlDocument;
        }
    }
}