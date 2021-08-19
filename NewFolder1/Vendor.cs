using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string name = row.Cells[2].Value.ToString();
            string address = row.Cells[3].Value.ToString();
            string state = row.Cells[4].Value.ToString();
            string zip = row.Cells[5].Value.ToString();
            string phone = row.Cells[6].Value.ToString();
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
                else if (address == "")
                {
                    MessageBox.Show("Address is required");
                    return false;
                }
                else if (state == "")
                {
                    MessageBox.Show("State is required");
                    return false;
                }
                else if (state.Length != 2)
                {
                    MessageBox.Show("The length of state should be 2 characters. Use the state code");
                    return false;
                }
                else if (zip == "")
                {
                    MessageBox.Show("Zip is required");
                    return false;
                }
                else if (phone == "")
                {
                    MessageBox.Show("Phone is required");
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
                                Models.Vendor vendor = new Models.Vendor { Id = id, CreatedAt = createdAt, Name = name, Address = address, State = state, PhoneNumber = phone, Zip = zip };
                                context.Vendors.Update(vendor);
                            }
                            else
                            {
                                Models.Vendor vendor = new Models.Vendor { Name = name, Address = address, State = state, PhoneNumber = phone, Zip = zip };
                                context.Vendors.Add(vendor);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Vendor_Load(sender, e);
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

        private void Vendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetv.Vendors' table. You can move, or remove it, as needed.
            vendorsTableAdapter.Fill(finalDataSetv.Vendors);

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
                        Models.Vendor vendor = context.Vendors.Single(c => c.Id == id);
                        if (vendor != null)
                            context.Vendors.Remove(vendor);
                        int result = context.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show($"Successfully deleted {result} item");
                            Vendor_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failure, not deleted");
                            Vendor_Load(sender, e);
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
