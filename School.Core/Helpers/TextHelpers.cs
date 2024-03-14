using System.Security.Cryptography;
using System.Text;

namespace School.Core.Helpers
{
    public static class TextHelpers
    {
        public static string HashPassword(this string input)
        {
            input = input is null ? " " : input;
            int Iterations = 10000;
            int keySize = 32;

            byte[] salt = Encoding.UTF8.GetBytes("998b7336aca9e8ba0d6987509b954cfd256a27076baa3e74549b33554b6d17c6");
            var deriveByte = new Rfc2898DeriveBytes(input, salt, Iterations, HashAlgorithmName.SHA256);

            byte[] hash = deriveByte.GetBytes(keySize);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
