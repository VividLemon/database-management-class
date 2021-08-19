using Final.Models;
using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnAddContentMigration_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BusinessType businessType1 = new BusinessType { Type = "TestType" };
                BusinessInformation business1 = new BusinessInformation { Longitute = 1, Latitude = 1, Type = businessType1 };
                BusinessIssue businessIssue1 = new BusinessIssue { Business = business1, Issue = "High steps, no ramp" };
                Employee employee = new Employee { Address = "f12", DateOfBirth = DateTime.Now, Name = "Issayah", PhoneNumber = "608", Salary = 55, State = "Wi", Zip = "50558" };
                Models.Forum forum1 = new Models.Forum { Name = "Forum 1" };
                Customer customer1 = new Customer { Name = "Not Issayah", PhoneNumber = "608", State = "Wi", Zip = "58383" };
                Invoice invoice1 = new Invoice { customer = customer1 };
                Product product1 = new Product { Description = "Access our city offers inspection services where we come and survey your business and give it an independent rating for accessability.", Name = "Inspection", Price = 5 };
                InvoiceDetail invoiceDetail = new InvoiceDetail { Invoice = invoice1, product = product1, QuantityPurchased = 2 };
                Vendor vendor1 = new Vendor { Name = "Issayahs house", PhoneNumber = "123", State = "Wi", Zip = "543", Address = "f133" };
                PurchaseOrder purchase1 = new PurchaseOrder { Vendor = vendor1, PurchaseDate = DateTime.Now, TotalPaid = 55 };
                PurchaseOrderDetail purchaseOrderDetail1 = new PurchaseOrderDetail { PurchaseOrder = purchase1, Product = product1, QuantityPurchased = 2 };
                User user = new User { Username = "Jane", Password = User.HashPassword("Doe") };
                User user1 = new User { Username = "Tom", Password = User.HashPassword("Jones"), Customer = customer1 };
                ForumDetail forumDetail1 = new ForumDetail { Forum = forum1, Content = "I love this app", User = user };
                using (DatabaseContext context = new DatabaseContext())
                {
                    try
                    {
                        context.BusinessTypes.RemoveRange(context.BusinessTypes);
                        context.BusinessInformations.RemoveRange(context.BusinessInformations);
                        context.BusinessIssues.RemoveRange(context.BusinessIssues);
                        context.Employees.RemoveRange(context.Employees);
                        context.Forums.RemoveRange(context.Forums);
                        context.Customers.RemoveRange(context.Customers);
                        context.ForumDetails.RemoveRange(context.ForumDetails);
                        context.Invoices.RemoveRange(context.Invoices);
                        context.Products.RemoveRange(context.Products);
                        context.InvoiceDetails.RemoveRange(context.InvoiceDetails);
                        context.Vendors.RemoveRange(context.Vendors);
                        context.PurchaseOrders.RemoveRange(context.PurchaseOrders);
                        context.PurchaseOrderDetails.RemoveRange(context.PurchaseOrderDetails);
                        context.Users.RemoveRange(context.Users);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                    try
                    {
                        context.BusinessTypes.Add(businessType1);
                        context.BusinessInformations.Add(business1);
                        context.BusinessIssues.Add(businessIssue1);
                        context.Employees.Add(employee);
                        context.Forums.Add(forum1);
                        context.Customers.Add(customer1);
                        context.ForumDetails.Add(forumDetail1);
                        context.Invoices.Add(invoice1);
                        context.Products.Add(product1);
                        context.InvoiceDetails.Add(invoiceDetail);
                        context.Vendors.Add(vendor1);
                        context.PurchaseOrders.Add(purchase1);
                        context.PurchaseOrderDetails.Add(purchaseOrderDetail1);
                        context.Users.Add(user);
                        context.Users.Add(user1);
                        context.SaveChanges();
                        MessageBox.Show("Success");
                        Admin_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet17.Vendors' table. You can move, or remove it, as needed.
            vendorsTableAdapter.Fill(finalDataSet17.Vendors);
            // TODO: This line of code loads data into the 'finalDataSet16.Users' table. You can move, or remove it, as needed.
            usersTableAdapter.Fill(finalDataSet16.Users);
            // TODO: This line of code loads data into the 'finalDataSet15.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(finalDataSet15.Products);
            // TODO: This line of code loads data into the 'finalDataSet14.PurchaseOrderDetails' table. You can move, or remove it, as needed.
            purchaseOrderDetailsTableAdapter.Fill(finalDataSet14.PurchaseOrderDetails);
            // TODO: This line of code loads data into the 'finalDataSet13.PurchaseOrders' table. You can move, or remove it, as needed.
            purchaseOrdersTableAdapter.Fill(finalDataSet13.PurchaseOrders);
            // TODO: This line of code loads data into the 'finalDataSet12.InvoiceDetails' table. You can move, or remove it, as needed.
            invoiceDetailsTableAdapter.Fill(finalDataSet12.InvoiceDetails);
            // TODO: This line of code loads data into the 'finalDataSet11.Invoices' table. You can move, or remove it, as needed.
            invoicesTableAdapter.Fill(finalDataSet11.Invoices);
            // TODO: This line of code loads data into the 'finalDataSet10.ForumDetails' table. You can move, or remove it, as needed.
            forumDetailsTableAdapter1.Fill(finalDataSet10.ForumDetails);
            // TODO: This line of code loads data into the 'finalDataSet9.ForumDetails' table. You can move, or remove it, as needed.
            forumDetailsTableAdapter.Fill(finalDataSet9.ForumDetails);
            // TODO: This line of code loads data into the 'finalDataSet8.Forums' table. You can move, or remove it, as needed.
            forumsTableAdapter.Fill(finalDataSet8.Forums);
            // TODO: This line of code loads data into the 'finalDataSet7.Employees' table. You can move, or remove it, as needed.
            employeesTableAdapter.Fill(finalDataSet7.Employees);
            // TODO: This line of code loads data into the 'finalDataSet6.Customers' table. You can move, or remove it, as needed.
            customersTableAdapter.Fill(finalDataSet6.Customers);
            // TODO: This line of code loads data into the 'finalDataSet5.BusinessIssues' table. You can move, or remove it, as needed.
            businessIssuesTableAdapter.Fill(finalDataSet5.BusinessIssues);
            // TODO: This line of code loads data into the 'finalDataSet4.BusinessTypes' table. You can move, or remove it, as needed.
            businessTypesTableAdapter.Fill(finalDataSet4.BusinessTypes);
            // TODO: This line of code loads data into the 'finalDataSet3.BusinessInformations' table. You can move, or remove it, as needed.
            businessInformationsTableAdapter.Fill(finalDataSet3.BusinessInformations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new NewFolder1.BusinessInformation();
            form.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.BusinessIssue();
            form.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.BusinessType();
            form.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.Customers();
            form.Show(this);
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.Employees();
            form.Show(this);
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.ForumA();
            form.Show(this);
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.ForumDetail();
            form.Show(this);
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.Invoice();
            form.Show(this);
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.InvoiceDetail();
            form.Show(this);
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.Product();
            form.Show(this);
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.PurchaseOrder();
            form.Show(this);
            Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.PurchaseOrderDetail();
            form.Show(this);
            Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.User();
            form.Show(this);
            Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form form = new NewFolder1.Vendor();
            form.Show(this);
            Hide();
        }
    }
}
