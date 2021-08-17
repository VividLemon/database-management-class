using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Final.Models
{
    class User : Model
    {
        public static User VerifyLogin(string username, string password, bool prehashed = false)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                try
                {
                    string pass = password;
                    if (!prehashed)
                        pass = HashPassword(pass);
                    User user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == pass);
                    if (user != null)
                    {
                        if (user.CustomerId != null)
                        {
                            Customer customer = context.Customers.SingleOrDefault(c => c.Id == user.CustomerId);
                            if (customer != null)
                                user.Customer = customer;
                        }
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
        public static Customer GetCustomerByUser(User user)
        {
            if (user.CustomerId != null)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    try
                    {
                        Customer customer = context.Customers.Single(c => c.Id == user.CustomerId);
                        return customer;
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }
                }
            }
            else
            {
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
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Username { get; set; }

        public string Password { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
