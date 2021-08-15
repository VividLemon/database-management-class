using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Final.Models
{
    class User : Model
    {
        public static User VerifyLogin(string username, string password)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                User user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == HashPassword(password));
                if (user != null)
                    return user;
                return null;
            }
        }
        public static string HashPassword(string input)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = Encoding.ASCII.GetBytes(input);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            int i;
            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            for (i = 0; i < tmpHash.Length; i++)
            {
                sOutput.Append(tmpHash[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
