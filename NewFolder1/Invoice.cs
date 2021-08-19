using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSeti.Invoices' table. You can move, or remove it, as needed.
            invoicesTableAdapter.Fill(finalDataSeti.Invoices);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            int customerId = (int)row.Cells[2].Value;
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
                else if (customerId.ToString() == "")
                {
                    MessageBox.Show("Customer Id is required");
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
                            Customer customer = context.Customers.SingleOrDefault(c => c.Id == customerId);
                            if (customer == null)
                            {
                                MessageBox.Show("Customer could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                Models.Invoice invoice = new Models.Invoice { Id = id, CreatedAt = createdAt, customer = customer };
                                context.Invoices.Update(invoice);
                            }
                            else
                            {
                                Models.Invoice invoice = new Models.Invoice { customer = customer };
                                context.Invoices.Add(invoice);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Invoice_Load(sender, e);
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
    }
}
