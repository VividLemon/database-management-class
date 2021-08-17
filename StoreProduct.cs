using Final.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Final
{
    public partial class StoreProduct : Form
    {
        private int productId;
        private Form login;
        public StoreProduct()
        {
            InitializeComponent();
        }

        private void StoreProduct_Load(object sender, EventArgs e)
        {
            productId = Store.value;
            if (productId > 0)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    try
                    {
                        Product product = context.Products.SingleOrDefault(p => p.Id == productId);
                        if (product != null)
                        {
                            lblProductName.Text = product.Name.ToString();
                            txtDesc.Text = product.Description.ToString();
                            txtPrice.Text = product.Price.ToString("c", CultureInfo.CurrentCulture);
                        }
                        else
                        {
                            MessageBox.Show("No product at that id. Going back");
                            Owner.Show();
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected Error... Going back\n\n{ex}");
                        Owner.Show();
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No id was passed. Going back");
                Owner.Show();
                Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            int quantity;
            string username = Environment.GetEnvironmentVariable("Name");
            string password = Environment.GetEnvironmentVariable("Password");
            if (username == null || username == "" || password == null || password == "")
            {
                DialogResult result = MessageBox.Show("You must be logged in to make a purchase. Do you want to go to login?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (login == null || login.IsDisposed)
                        login = new Login();
                    login.Show(this);
                    Hide();
                }
            }
            else if (txtQuantity.Text == "" || !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity is required and must be a number");
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Value must be greater than 0");
            }
            else
            {
                try
                {
                    User user = User.VerifyLogin(username, password, true);
                    if (user == null)
                    {
                        MessageBox.Show("Your login credentials are expired. Try logging in again");
                    }
                    else
                    {
                        try
                        {
                            using (DatabaseContext context = new DatabaseContext())
                            {
                                try
                                {
                                    if (user.CustomerId > 0)
                                    {
                                        Invoice invoice = new Invoice { CustomerId = (int)user.CustomerId };
                                        context.Invoices.Add(invoice);
                                        InvoiceDetail invoiceDetail = new InvoiceDetail { Invoice = invoice, ProductId = productId, QuantityPurchased = quantity };
                                        context.InvoiceDetails.Add(invoiceDetail);
                                        context.SaveChanges();
                                        MessageBox.Show("Success! Items purchased");
                                    }
                                    else
                                    {
                                        MessageBox.Show("User does not have an associated customerId. Are you an admin?");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Unexpected error occured\n\n{ex}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Unexpected error occured\n\n{ex}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error occured\n\n{ex}");
                }
            }
        }
    }
}
