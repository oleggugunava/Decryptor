using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTL.Encryption;

namespace Decryptor
{
    internal static class EncryptionHelper
    {
        public static string Decrypt(string encryptedText, string encryptionKeyName)
        {
            var keyFile = string.Format("c:\\private\\{0}.key", encryptionKeyName);
            return Crypto.Decrypt(encryptedText, File.ReadAllText(keyFile));
        }
    }
}
