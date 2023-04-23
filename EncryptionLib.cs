using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;



namespace EncryptionApp
{
    class EncryptionLib
    {
        public static byte[] Encrypt(string key , byte[] plain_text)
        {
            // Initializing the Initialization Vector
            string IV = "aaaaaaaabbbbbbbb"; 

            // Converting the key and the IV to Bytes
            byte[] ByteKey = Encoding.UTF8.GetBytes(key);
            byte[] ByteIV = Encoding.UTF8.GetBytes(IV);
            byte[] encrypted_file = null;
            try
            {
                // Using a code block to automate resource handling 
                using (MemoryStream ms = new MemoryStream())
                {
                    using (var aes = new RijndaelManaged())
                    {
                        // Setting AES Parameteres
                        aes.KeySize = 256;
                        aes.BlockSize = 128;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;
                        aes.Key = ByteKey;
                        aes.IV = ByteIV;

                        using (var crypt_stream = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            crypt_stream.Write(plain_text,0, plain_text.Length);
                            crypt_stream.FlushFinalBlock();

                        }
                    }
                    encrypted_file = ms.ToArray();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return encrypted_file;
        }

        public static byte[] Decrypt(string key, byte[] plain_text)
        {
            string IV = "aaaaaaaabbbbbbbb";

            byte[] ByteKey = Encoding.UTF8.GetBytes(key);
            byte[] ByteIV = Encoding.UTF8.GetBytes(IV);
            byte[] encrypted_file = null;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (var aes = new RijndaelManaged())
                    {
                        aes.KeySize = 256;
                        aes.BlockSize = 128;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;
                        aes.Key = ByteKey;
                        aes.IV = ByteIV;

                        using (var crypt_stream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            crypt_stream.Write(plain_text, 0, plain_text.Length);
                            crypt_stream.FlushFinalBlock();
                            crypt_stream.Close();


                        }
                    }
                    encrypted_file = ms.ToArray();

                }
            }
            catch (Exception)
            {
                // Check if the file is Encrypted ?? 
                if (Globals.firstTime == 0)
                {
                    MessageBox.Show("The File isn't Encrypted and It can't be Decrypted !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
                
            }
            return encrypted_file;
        }
    }
}
