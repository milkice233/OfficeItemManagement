using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace OfficeItemManagement.Data.Model
{
    public enum ESex
    {
        Unspecified, M, F
    }
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string Username { get; set; }
        [NotMapped]
        private string _hashedPassword;
        public string Password
        {
            get => _hashedPassword;
            set
            {
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var pbkdf2 = new Rfc2898DeriveBytes(value, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                _hashedPassword = Convert.ToBase64String(hashBytes);
            }
        }

        public string Name { get; set; }
        public ESex Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
    }
}