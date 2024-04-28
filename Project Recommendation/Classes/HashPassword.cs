using System.Security.Cryptography;
using System.Text;

namespace DB_993.Classes
{
    /// <summary>
    /// Класс предоставляет функциональность для создания и хранения хешированных паролей с использованием соли.
    /// </summary>
    public class HashPassword
    {
        string? Password { get; set; }
        public HashPassword() { }
        public HashPassword(string password)
        {
            Password = password;
        }
        static byte[] GenerateSalt()
        {
            const int SaltLength = 64;
            byte[] salt = new byte[SaltLength];

            var rngRand = new RNGCryptoServiceProvider();
            rngRand.GetBytes(salt);

            return salt;
        }
        static byte[] GenerateSha256Hash(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[salt.Length + passwordBytes.Length];

            using var hash = new SHA256CryptoServiceProvider();

            return hash.ComputeHash(saltedPassword);
        }

        /// <summary>
        /// Получает хешированный пароль в виде строки, используя методы генерации соли и хеширования.
        /// </summary>
        /// <param name="password"> Пароль, который нужно хешировать.</param>
        /// <returns> Хешированный пароль в формате Base64.</returns>
        public string GetPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] md5Hash = GenerateSha256Hash(password, salt);
            return Convert.ToBase64String(md5Hash);
        }
    }
}
