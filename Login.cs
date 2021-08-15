using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Models;
using System.Security.Cryptography;

namespace Final
{
    
    public partial class Login : Form
    {
        private Boolean validate()
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
            this.Owner.Show();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                using (var context = new DatabaseContext())
                {
                
                    User user = User.VerifyLogin(txtUsername.Text, txtPassword.Text);
                    if(user != null)
                    {
                        MessageBox.Show("Logged in");
                        Environment.SetEnvironmentVariable("Name", user.username);
                        this.Owner.Show();
                        this.Close();
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
                using (var context = new DatabaseContext())
                {
                    string hashedPassword = User.HashPassword(txtPassword.Text);
                    User user = new User { username = txtUsername.Text, password = hashedPassword, };
                    context.Users.Add(user);
                    context.SaveChanges();
                    // TODO handle errors
                    MessageBox.Show("Saved");
                }
            }
        }
    }
}
