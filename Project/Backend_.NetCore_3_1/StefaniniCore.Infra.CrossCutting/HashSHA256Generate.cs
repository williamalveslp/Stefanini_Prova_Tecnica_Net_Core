using System;
using System.Security.Cryptography;
using System.Text;

namespace StefaniniCore.Infra.CrossCutting
{
    /// <summary>
    /// Funcionalities related to Hash.
    /// </summary>
    public static class HashSha256Generate
    {
        /// <summary>
        /// Compare the source text if has the same hash to compared.
        /// The example displays the following output:
        //  The SHA256 hash of "Hello World!" is: "7f83b1657ff1fc53b92dc18148a1d65dfc2d4b1fa3d677284addd200126d9069".
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool HasSameHash(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, text);
                bool hasSameHash = VerifyHash(sha256Hash, text, hash);

                return hasSameHash;
            }
        }

        /// <summary>
        /// Generate the Hash as SHA256.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Generate(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, text);
                return hash;
            }
        }

        #region .: PRIVATE METHODS :.
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
        #endregion
    }
}
