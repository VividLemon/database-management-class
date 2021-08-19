using Final.Models;
using System;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class BusinessType : Form
    {
        public BusinessType()
        {
            InitializeComponent();
        }

        private void BusinessType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetbt.BusinessTypes' table. You can move, or remove it, as needed.
            businessTypesTableAdapter.Fill(finalDataSetbt.BusinessTypes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
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
                                Models.BusinessType businessType = new Models.BusinessType { Id = id, CreatedAt = createdAt, Type = type };
                                context.BusinessTypes.Update(businessType);
                            }
                            else
                            {
                                Models.BusinessType businessType = new Models.BusinessType { Type = type };
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
                                BusinessType_Load(sender, e);
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
