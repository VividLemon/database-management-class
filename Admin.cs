using Final.Models;
using System;
using System.Linq;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            decimal longitude = (decimal)row.Cells[2].Value;
            decimal latitude = (decimal)row.Cells[3].Value;
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
                else if (longitude.ToString() == "")
                {
                    MessageBox.Show("Longitude is required");
                    return false;
                }
                else if (!decimal.TryParse(longitude.ToString(), out _))
                {
                    MessageBox.Show("Longitude must be a number");
                    return false;
                }
                else if (latitude.ToString() == "")
                {
                    MessageBox.Show("Latitude is required");
                    return false;
                }
                else if (!decimal.TryParse(latitude.ToString(), out _))
                {
                    MessageBox.Show("Latitude must be a number");
                    return false;
                }
                else if (row.Cells[4].Value.ToString() == "")
                {
                    MessageBox.Show("A type is required");
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
                        BusinessType type = context.BusinessTypes.SingleOrDefault(t => t.Id == (int)row.Cells[4].Value);
                        if (type == null)
                        {
                            MessageBox.Show("Business type could not be found from database. Returning");
                            Owner.Show();
                            Close();
                        }
                        try
                        {

                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                BusinessInformation businessInformation = new BusinessInformation() { Id = id, CreatedAt = createdAt, Latitude = latitude, Longitute = longitude, Type = type };
                                context.BusinessInformations.Update(businessInformation);
                            }
                            else
                            {
                                // create
                                BusinessInformation businessInformation = new BusinessInformation() { Latitude = latitude, Longitute = longitude, Type = type };
                                context.BusinessInformations.Add(businessInformation);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string type = row.Cells[2].Value.ToString();
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
                else if (type == "")
                {
                    MessageBox.Show("Type is required");
                    return false;
                }
                return true;
            }
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                BusinessType businessType = new BusinessType { Id = id, CreatedAt = createdAt, Type = type };
                                context.BusinessTypes.Update(businessType);
                            }
                            else
                            {
                                BusinessType businessType = new BusinessType { Type = type };
                                context.BusinessTypes.Add(businessType);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string issue = row.Cells[2].Value.ToString();
            int biId = (int)row.Cells[3].Value;
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
                else if (issue == "")
                {
                    MessageBox.Show("Issue is required. Sadly");
                    return false;
                }
                else if (biId.ToString() == "")
                {
                    MessageBox.Show("A business is required to apply an issue to it");
                    return false;
                }
                return true;
            }
            if (dataGridView3.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        BusinessInformation businessInformation = context.BusinessInformations.SingleOrDefault(bi => bi.Id == biId);
                        if (businessInformation == null)
                        {
                            MessageBox.Show("Business info could not be found from database. Returning");
                            Owner.Show();
                            Close();
                        }
                        try
                        {
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                BusinessIssue businessIssue = new BusinessIssue { Id = id, CreatedAt = createdAt, Issue = issue, Business = businessInformation };
                                context.BusinessIssues.Update(businessIssue);
                            }
                            else
                            {
                                BusinessIssue businessIssue = new BusinessIssue { Issue = issue, Business = businessInformation };
                                context.BusinessIssues.Add(businessIssue);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
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
                    MessageBox.Show("Phone Number is required");
                    return false;
                }
                return true;
            }
            if (dataGridView4.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                Customer customer = new Customer { Id = id, CreatedAt = createdAt, Name = name, Address = address, State = state, Zip = zip, PhoneNumber = phone };
                                context.Customers.Update(customer);
                            }
                            else
                            {
                                Customer customer = new Customer { Name = name, Address = address, State = state, Zip = zip, PhoneNumber = phone };
                                context.Customers.Add(customer);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView5.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string name = row.Cells[2].Value.ToString();
            DateTime dob = DateTime.Parse(row.Cells[3].Value.ToString());
            string phone = row.Cells[4].Value.ToString();
            string address = row.Cells[5].Value.ToString();
            string state = row.Cells[6].Value.ToString();
            string zip = row.Cells[7].Value.ToString();
            decimal salary = decimal.Parse(row.Cells[8].Value.ToString());
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
                else if (dob.ToShortDateString() == "")
                {
                    MessageBox.Show("Date of birth is required");
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
                else if (state == "")
                {
                    MessageBox.Show("State is required");
                    return false;
                }
                else if (zip == "")
                {
                    MessageBox.Show("Zip is required");
                    return false;
                }
                else if (phone == "")
                {
                    MessageBox.Show("Phone Number is required");
                    return false;
                }
                else if (salary.ToString() == "")
                {
                    MessageBox.Show("Salary is required");
                    return false;
                }
                else if (!decimal.TryParse(salary.ToString(), out _))
                {
                    MessageBox.Show("Salary must be a number");
                    return false;
                }
                return true;
            }
            if (dataGridView5.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                Employee employee = new Employee { Id = id, CreatedAt = createdAt, Name = name, DateOfBirth = dob, Address = address, State = state, Zip = zip, PhoneNumber = phone, Salary = salary };
                                context.Employees.Update(employee);
                            }
                            else
                            {
                                Employee employee = new Employee { Name = name, DateOfBirth = dob, Address = address, State = state, Zip = zip, PhoneNumber = phone, Salary = salary };
                                context.Employees.Add(employee);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView6.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string name = row.Cells[2].Value.ToString();
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
                return true;
            }
            if (dataGridView6.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                Models.Forum forum = new Models.Forum { Name = name, CreatedAt = createdAt };
                                context.Forums.Update(forum);
                            }
                            else
                            {
                                Models.Forum forum = new Models.Forum { Name = name };
                                context.Forums.Add(forum);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView7.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            string content = row.Cells[2].Value.ToString();
            int forumId = (int)row.Cells[3].Value;
            int userId = (int)row.Cells[4].Value;
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
                else if (content == "")
                {
                    MessageBox.Show("Name is required");
                    return false;
                }
                else if (forumId.ToString() == "")
                {
                    MessageBox.Show("ForumId is required");
                    return false;
                }
                else if (userId.ToString() == "")
                {
                    MessageBox.Show("UserId is required");
                    return false;
                }
                return true;
            }
            if (dataGridView7.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            Models.Forum forum = context.Forums.SingleOrDefault(f => f.Id == forumId);
                            User user = context.Users.SingleOrDefault(u => u.Id == userId);
                            if (forum == null)
                            {
                                MessageBox.Show("Forum could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            else if (user == null)
                            {
                                MessageBox.Show("User could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                ForumDetail forumDetail = new ForumDetail { Id = id, CreatedAt = createdAt, Content = content, Forum = forum, User = user };
                                context.ForumDetails.Update(forumDetail);
                            }
                            else
                            {
                                ForumDetail forumDetail = new ForumDetail { Content = content, Forum = forum, User = user };
                                context.ForumDetails.Add(forumDetail);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView8.Rows[e.RowIndex];
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
            if (dataGridView8.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                Invoice invoice = new Invoice { Id = id, CreatedAt = createdAt, customer = customer };
                                context.Invoices.Update(invoice);
                            }
                            else
                            {
                                Invoice invoice = new Invoice { customer = customer };
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
                                Admin_Load(sender, e);
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

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView9.Rows[e.RowIndex];
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
            if (dataGridView9.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            Invoice invoice = context.Invoices.SingleOrDefault(i => i.Id == invoiceId);
                            Product product = context.Products.SingleOrDefault(p => p.Id == productId);
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
                                InvoiceDetail invoiceDetail = new InvoiceDetail { Id = id, CreatedAt = createdAt, Invoice = invoice, product = product, QuantityPurchased = quantity };
                                context.InvoiceDetails.Update(invoiceDetail);
                            }
                            else
                            {
                                InvoiceDetail invoiceDetail = new InvoiceDetail { Invoice = invoice, product = product, QuantityPurchased = quantity };
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
                                Admin_Load(sender, e);
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

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView10.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            DateTime purchaseDate = DateTime.Parse(row.Cells[2].Value.ToString());
            decimal totalPaid = (decimal)row.Cells[3].Value;
            int vendorId = (int)row.Cells[4].Value;
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
                else if (purchaseDate.ToString() == "")
                {
                    MessageBox.Show("Purchase Date is required");
                    return false;
                }
                else if (!DateTime.TryParse(row.Cells[2].Value.ToString(), out _))
                {
                    MessageBox.Show("Purchase date must be a valid datetime");
                    return false;
                }
                else if (totalPaid.ToString() == "")
                {
                    MessageBox.Show("Total paid is required");
                    return false;
                }
                else if (!decimal.TryParse(totalPaid.ToString(), out _))
                {
                    MessageBox.Show("Total paid must be a number");
                    return false;
                }
                else if (vendorId.ToString() == "")
                {
                    MessageBox.Show("VendorId is required");
                    return false;
                }
                return true;
            }
            if (dataGridView10.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            Vendor vendor = context.Vendors.SingleOrDefault(v => v.Id == vendorId);
                            if (vendor == null)
                            {
                                MessageBox.Show("Vendor could not be found from database. Returning");
                                Owner.Show();
                                Close();
                            }
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                PurchaseOrder purchaseOrder = new PurchaseOrder { Id = id, CreatedAt = createdAt, PurchaseDate = purchaseDate, TotalPaid = totalPaid, Vendor = vendor };
                                context.PurchaseOrders.Update(purchaseOrder);
                            }
                            else
                            {
                                PurchaseOrder purchaseOrder = new PurchaseOrder { PurchaseDate = purchaseDate, TotalPaid = totalPaid, Vendor = vendor };
                                context.PurchaseOrders.Add(purchaseOrder);
                            }
                            int val = context.SaveChanges();
                            if (val < 1)
                            {
                                MessageBox.Show("Unexpected issue. Unable to make change. Try again");
                            }
                            else
                            {
                                MessageBox.Show($"Successfully changed {val} row");
                                Admin_Load(sender, e);
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

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView11.Rows[e.RowIndex];
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
            if (dataGridView11.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            Product product = context.Products.SingleOrDefault(p => p.Id == productId);
                            PurchaseOrder purchaseOrder = context.PurchaseOrders.SingleOrDefault(po => po.Id == purchaseOrderId);
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
                                PurchaseOrderDetail purchaseOrderDetail = new PurchaseOrderDetail { Id = id, CreatedAt = createdAt, Product = product, PurchaseOrder = purchaseOrder, QuantityPurchased = quantityPurchased };
                                context.PurchaseOrderDetails.Update(purchaseOrderDetail);
                            }
                            else
                            {
                                PurchaseOrderDetail purchaseOrderDetail = new PurchaseOrderDetail { Product = product, PurchaseOrder = purchaseOrder, QuantityPurchased = quantityPurchased };
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
                                Admin_Load(sender, e);
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

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView12.Rows[e.RowIndex];
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
            if (dataGridView12.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                Product product = new Product { Id = id, CreatedAt = createdAt, Name = name, Description = description, Price = price };
                                context.Products.Update(product);
                            }
                            else
                            {
                                Product product = new Product { Name = name, Description = description, Price = price };
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
                                Admin_Load(sender, e);
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

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView13.Rows[e.RowIndex];
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
            if (dataGridView13.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            User user;
                            if (id > 0)
                            {
                                DateTime createdAt = DateTime.Parse(row.Cells[1].Value.ToString());
                                if (custId)
                                {
                                    Customer customer = context.Customers.SingleOrDefault(c => c.Id == customerId);
                                    if (customer == null)
                                    {
                                        MessageBox.Show("Customer could not be found from database. Returning");
                                        Owner.Show();
                                        Close();
                                    }
                                    user = new User { Id = id, CreatedAt = createdAt, Username = name, Password = User.HashPassword(password), Customer = customer };
                                }
                                else
                                {
                                    user = new User { Id = id, CreatedAt = createdAt, Username = name, Password = User.HashPassword(password), Customer = null };
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
                                    user = new User { Username = name, Password = User.HashPassword(password), Customer = customer };
                                }
                                else
                                {
                                    user = new User { Username = name, Password = User.HashPassword(password), Customer = null };
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
                                Admin_Load(sender, e);
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

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView14.Rows[e.RowIndex];
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
            if (dataGridView14.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
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
                                Vendor vendor = new Vendor { Id = id, CreatedAt = createdAt, Name = name, Address = address, State = state, PhoneNumber = phone, Zip = zip };
                                context.Vendors.Update(vendor);
                            }
                            else
                            {
                                Vendor vendor = new Vendor { Name = name, Address = address, State = state, PhoneNumber = phone, Zip = zip };
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
                                Admin_Load(sender, e);
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
