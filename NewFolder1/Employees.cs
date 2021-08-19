using Final.Models;
using System;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSete.Employees' table. You can move, or remove it, as needed.
            employeesTableAdapter.Fill(finalDataSete.Employees);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
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
                                Employees_Load(sender, e);
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
