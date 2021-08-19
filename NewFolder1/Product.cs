using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetp.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(finalDataSetp.Products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string name = row.Cells[2].Value.ToString();
            string description = row.Cells[3].Value.ToString();
            double price = (double)row.Cells[4].Value;
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
                    MessageBox.Show("Name is required");
                    return false;
                }
                else if (description == "")
                {
                    MessageBox.Show("Description is required");
                    return false;
                }
                else if (price.ToString() == "")
                {
                    MessageBox.Show("Price is required");
                    return false;
                }
                else if (!double.TryParse(price.ToString(), out _))
                {
                    MessageBox.Show("Price must be a number");
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
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                Models.Product product = new Models.Product { Id = id, CreatedAt = createdAt, Name = name, Description = description, Price = price };
                                context.Products.Update(product);
                            }
                            else
                            {
                                Models.Product product = new Models.Product { Name = name, Description = description, Price = price };
                                context.Products.Add(product);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Product_Load(sender, e);
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
                        Models.Product product = context.Products.Single(c => c.Id == id);
                        if (product != null)
                            context.Products.Remove(product);
                        int result = context.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show($"Successfully deleted {result} item");
                            Product_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failure, not deleted");
                            Product_Load(sender, e);
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
