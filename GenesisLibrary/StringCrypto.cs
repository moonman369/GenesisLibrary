using System.Security.Cryptography;
using System.Text;

namespace GenesisLibrary
{
    public class StringCrypto
    {
        public static string GetSHA256(string seed)
        {
            byte[] hashValue = SHA256.HashData(Encoding.UTF8.GetBytes(seed));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashValue.Length; i++)
            {
                builder.Append(hashValue[i].ToString("x2"));
            }
            return builder.ToString();
        }

    }
}
