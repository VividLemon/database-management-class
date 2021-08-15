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
                ForumDetail forumDetail1 = new ForumDetail { Forum = forum1, Content = "I love this app", Customer = customer1 };
                Invoice invoice1 = new Invoice { customer = customer1 };
                Product product1 = new Product { Description = "Access our city offers inspection services where we come and survey your business and give it an independent rating for accessability.", Name = "Inspection", Price = 5 };
                InvoiceDetail invoiceDetail = new InvoiceDetail { Invoice = invoice1, product = product1, QuantityPurchased = 2 };
                Vendor vendor1 = new Vendor { Name = "Issayahs house", PhoneNumber = "123", State = "Wi", Zip = "543", Address = "f133" };
                PurchaseOrder purchase1 = new PurchaseOrder { Vendor = vendor1, PurchaseDate = DateTime.Now, TotalPaid = 55 };
                PurchaseOrderDetail purchaseOrderDetail1 = new PurchaseOrderDetail { PurchaseOrder = purchase1, Product = product1, QuantityPurchased = 2 };
                User user = new User { Username = "Jane", Password = User.HashPassword("Doe") };
                User user1 = new User { Username = "Tom", Password = User.HashPassword("Jones") };
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

        }
    }
}
