using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class BusinessIssue : Form
    {
        public BusinessIssue()
        {
            InitializeComponent();
        }

        private void BusinessIssue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetbis.BusinessIssues' table. You can move, or remove it, as needed.
            businessIssuesTableAdapter.Fill(finalDataSetbis.BusinessIssues);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
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
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        Models.BusinessInformation businessInformation = context.BusinessInformations.SingleOrDefault(bi => bi.Id == biId);
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
                                Models.BusinessIssue businessIssue = new Models.BusinessIssue { Id = id, CreatedAt = createdAt, Issue = issue, Business = businessInformation };
                                context.BusinessIssues.Update(businessIssue);
                            }
                            else
                            {
                                Models.BusinessIssue businessIssue = new Models.BusinessIssue { Issue = issue, Business = businessInformation };
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
                                BusinessIssue_Load(sender, e);
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
