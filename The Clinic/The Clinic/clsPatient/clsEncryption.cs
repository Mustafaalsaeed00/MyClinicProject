using System;
using System.Text;

namespace ClinicBusinessLayer
{
    public class clsEncryption
    {
        static byte[] EncryptionKey = {9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static string Encrypt(string TextToEncrypt)
        {

            string TextAfterEncryption = "";
            byte TextLength = (byte)TextToEncrypt.Length;
            byte[] TextToEncryptafterEncoded = Encoding.ASCII.GetBytes(TextToEncrypt);
            for(byte Counter = 0; Counter < TextLength; Counter++)
            {
                TextToEncryptafterEncoded[Counter] += EncryptionKey[Counter];
                char Char = (char)TextToEncryptafterEncoded[Counter];
                TextAfterEncryption = TextAfterEncryption.Insert(Counter, Char.ToString());

            }
            return TextAfterEncryption;
        }

        public static string Decrypt(string TextToEncrypt)
        {
            string TextAfterEncryption = "";
            byte TextLength = (byte)TextToEncrypt.Length;
            byte[] TextToEncryptafterEncoded = Encoding.ASCII.GetBytes(TextToEncrypt);
            for (byte Counter = 0; Counter < TextLength; Counter++)
            {
                TextToEncryptafterEncoded[Counter] -= EncryptionKey[Counter];
                char Char = (char)TextToEncryptafterEncoded[Counter];
                TextAfterEncryption = TextAfterEncryption.Insert(Counter, Char.ToString());

            }
            return TextAfterEncryption;
        }
    }
}
