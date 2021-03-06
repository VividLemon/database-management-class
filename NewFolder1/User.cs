using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetu.Users' table. You can move, or remove it, as needed.
            usersTableAdapter.Fill(finalDataSetu.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string name = row.Cells[2].Value.ToString();
            string password = row.Cells[3].Value.ToString();
            int customerId;
            bool custId = int.TryParse(row.Cells[4].Value.ToString(), out customerId);
            bool validate()
            {
                if (id.ToString() == "")
                {
                    MessageBox.Show("Id cell is empty. How?");
                    return false;
                }
                else if (row.Cells[1].Value.ToString() != "" && id < 0)
                {
                    MessageBox.Show("Created at is implemented by the database. It is a readonly field. How did you get here?");
                    return false;
                }
                else if (name == "")
                {
                    MessageBox.Show("Username is required");
                    return false;
                }
                else if (password == "")
                {
                    MessageBox.Show("password is required");
                    return false;
                }
                return true;
            }
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            Models.User user;
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                if (custId)
                                {
                                    Models.Customer customer = context.Customers.SingleOrDefault(c => c.Id == customerId);
                                    if (customer == null)
                                    {
                                        MessageBox.Show("Customer could not be found from database. Returning");
                                        Owner.Show();
                                        Close();
                                    }
                                    user = new Models.User { Id = id, CreatedAt = createdAt, Username = name, Password = Models.User.HashPassword(password), Customer = customer };
                                }
                                else
                                {
                                    user = new Models.User { Id = id, CreatedAt = createdAt, Username = name, Password = Models.User.HashPassword(password), Customer = null };
                                }
                                context.Users.Update(user);
                            }
                            else
                            {
                                if (custId)
                                {
                                    Customer customer = context.Customers.SingleOrDefault(c => c.Id == customerId);
                                    if (customer == null)
                                    {
                                        MessageBox.Show("Customer could not be found from database. Returning");
                                        Owner.Show();
                                        Close();
                                    }
                                    user = new Models.User { Username = name, Password = Models.User.HashPassword(password), Customer = customer };
                                }
                                else
                                {
                                    user = new Models.User { Username = name, Password = Models.User.HashPassword(password), Customer = null };
                                }
                                context.Users.Add(user);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                User_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Unexpected error. Returning\n\n{ex}");
                            Owner.Show();
                            Close();
                        }
                    }
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Cannot delete with no id");
            }
            else if (!int.TryParse(txtDelete.Text, out id))
            {
                MessageBox.Show("Value needs to be a number");
            }
            else
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    try
                    {
                        Models.User user = context.Users.Single(c => c.Id == id);
                        if (user != null)
                            context.Users.Remove(user);
                        int result = context.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show($"Successfully deleted {result} item");
                            User_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failure, not deleted");
                            User_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error occured. Try again\n\n{ex}");
                    }
                    finally
                    {
                        txtDelete.Text = "";
                    }
                }
            }

        }
    }
}
