using Final.Models;
using System;
using System.Windows.Forms;

namespace Final
{

    public partial class Login : Form
    {
        private bool validate()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("No username entered");
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("No password entered");
                return false;
            }
            return true;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                using (DatabaseContext context = new DatabaseContext())
                {

                    User user = User.VerifyLogin(txtUsername.Text, txtPassword.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Logged in");
                        Environment.SetEnvironmentVariable("Name", user.Username);
                        Owner.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No user found with those credentials. Try again");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    string hashedPassword = User.HashPassword(txtPassword.Text);
                    User user = new User { Username = txtUsername.Text, Password = hashedPassword, };
                    try
                    {
                        context.Users.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("Saved");
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {
                        MessageBox.Show($"Error when trying to add a user. Username is taken\n\n{ex}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected Error: {ex}");
                    }
                }
            }
        }
    }
}
