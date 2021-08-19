using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class InvoiceDetail : Form
    {
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetid.InvoiceDetails' table. You can move, or remove it, as needed.
            invoiceDetailsTableAdapter.Fill(finalDataSetid.InvoiceDetails);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            int invoiceId = (int)row.Cells[2].Value;
            int productId = (int)row.Cells[3].Value;
            int quantity = (int)row.Cells[4].Value;
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
                else if (invoiceId.ToString() == "")
                {
                    MessageBox.Show("InvoiceId is required");
                    return false;
                }
                else if (productId.ToString() == "")
                {
                    MessageBox.Show("ProductId is required");
                    return false;
                }
                else if (quantity.ToString() == "")
                {
                    MessageBox.Show("Quantity is required");
                    return false;
                }
                else if (!int.TryParse(quantity.ToString(), out _))
                {
                    MessageBox.Show("Quantity must be a number");
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
                            Models.Invoice invoice = context.Invoices.SingleOrDefault(i => i.Id == invoiceId);
                            Models.Product product = context.Products.SingleOrDefault(p => p.Id == productId);
                            if (invoice == null)
                            {
                                MessageBox.Show("Invoice could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            else if (product == null)
                            {
                                MessageBox.Show("Product could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                Models.InvoiceDetail invoiceDetail = new Models.InvoiceDetail { Id = id, CreatedAt = createdAt, Invoice = invoice, product = product, QuantityPurchased = quantity };
                                context.InvoiceDetails.Update(invoiceDetail);
                            }
                            else
                            {
                                Models.InvoiceDetail invoiceDetail = new Models.InvoiceDetail { Invoice = invoice, product = product, QuantityPurchased = quantity };
                                context.InvoiceDetails.Add(invoiceDetail);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                InvoiceDetail_Load(sender, e);
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
