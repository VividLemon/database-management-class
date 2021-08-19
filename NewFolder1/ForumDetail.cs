using Final.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final.NewFolder1
{
    public partial class ForumDetail : Form
    {
        public ForumDetail()
        {
            InitializeComponent();
        }

        private void ForumDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetfd.ForumDetails' table. You can move, or remove it, as needed.
            forumDetailsTableAdapter.Fill(finalDataSetfd.ForumDetails);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
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
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && validate())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        try
                        {
                            Models.Forum forum = context.Forums.SingleOrDefault(f => f.Id == forumId);
                            Models.User user = context.Users.SingleOrDefault(u => u.Id == userId);
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
                                Models.ForumDetail forumDetail = new Models.ForumDetail { Id = id, CreatedAt = createdAt, Content = content, Forum = forum, User = user };
                                context.ForumDetails.Update(forumDetail);
                            }
                            else
                            {
                                Models.ForumDetail forumDetail = new Models.ForumDetail { Content = content, Forum = forum, User = user };
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
                                ForumDetail_Load(sender, e);
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
