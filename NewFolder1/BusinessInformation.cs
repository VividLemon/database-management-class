using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class BusinessInformation : Form
    {
        public BusinessInformation()
        {
            InitializeComponent();
        }

        private void BusinessInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetbiii.BusinessInformations' table. You can move, or remove it, as needed.
            businessInformationsTableAdapter.Fill(finalDataSetbiii.BusinessInformations);

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
                        Models.BusinessType type = context.BusinessTypes.SingleOrDefault(t => t.Id == (int)row.Cells[4].Value);
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
                                Models.BusinessInformation businessInformation = new Models.BusinessInformation() { Id = id, CreatedAt = createdAt, Latitude = latitude, Longitute = longitude, Type = type };
                                context.BusinessInformations.Update(businessInformation);
                            }
                            else
                            {
                                // create
                                Models.BusinessInformation businessInformation = new Models.BusinessInformation() { Latitude = latitude, Longitute = longitude, Type = type };
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
                                BusinessInformation_Load(sender, e);
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Cannot delete with no id");
            }
            else if (!int.TryParse(txtDelete.Text, out id))
            {
                MessageBox.Show("Value needs to be a number");
            }
            else
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    try
                    {
                        Models.BusinessInformation businessInfo = context.BusinessInformations.Single(c => c.Id == id);
                        if (businessInfo != null)
                            context.BusinessInformations.Remove(businessInfo);
                        int result = context.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show($"Successfully deleted {result} item");
                            BusinessInformation_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failure, not deleted");
                            BusinessInformation_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error occured. Try again\n\n{ex}");
                    }
                    finally
                    {
                        txtDelete.Text = "";
                    }
                }
            }
        }
    }
}
