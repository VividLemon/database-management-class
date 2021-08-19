using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class PurchaseOrderDetail : Form
    {
        public PurchaseOrderDetail()
        {
            InitializeComponent();
        }

        private void PurchaseOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetpod.PurchaseOrderDetails' table. You can move, or remove it, as needed.
            purchaseOrderDetailsTableAdapter.Fill(finalDataSetpod.PurchaseOrderDetails);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            int productId = (int)row.Cells[2].Value;
            int quantityPurchased = (int)row.Cells[3].Value;
            int purchaseOrderId = (int)row.Cells[4].Value;
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
                else if (productId.ToString() == "")
                {
                    MessageBox.Show("ProductId is required");
                    return false;
                }
                else if (quantityPurchased.ToString() == "")
                {
                    MessageBox.Show("Quantity purchased is required");
                    return false;
                }
                else if (!int.TryParse(quantityPurchased.ToString(), out _))
                {
                    MessageBox.Show("Quantity purchased must be a number");
                    return false;
                }
                else if (purchaseOrderId.ToString() == "")
                {
                    MessageBox.Show("PurchaseOrderId is required");
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
                            Models.Product product = context.Products.SingleOrDefault(p => p.Id == productId);
                            Models.PurchaseOrder purchaseOrder = context.PurchaseOrders.SingleOrDefault(po => po.Id == purchaseOrderId);
                            if (product == null)
                            {
                                MessageBox.Show("Product could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            else if (purchaseOrder == null)
                            {
                                MessageBox.Show("Purchase order could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                Models.PurchaseOrderDetail purchaseOrderDetail = new Models.PurchaseOrderDetail { Id = id, CreatedAt = createdAt, Product = product, PurchaseOrder = purchaseOrder, QuantityPurchased = quantityPurchased };
                                context.PurchaseOrderDetails.Update(purchaseOrderDetail);
                            }
                            else
                            {
                                Models.PurchaseOrderDetail purchaseOrderDetail = new Models.PurchaseOrderDetail { Product = product, PurchaseOrder = purchaseOrder, QuantityPurchased = quantityPurchased };
                                context.PurchaseOrderDetails.Add(purchaseOrderDetail);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                PurchaseOrderDetail_Load(sender, e);
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
