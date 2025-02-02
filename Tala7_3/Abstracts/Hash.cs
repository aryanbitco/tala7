using System.Security.Cryptography;
using System.Text;

namespace Tala7_3.Abstracts
{
    public static class Hash
    {
        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }

}
