using Final.Models;
using System;
using System.Windows.Forms;

namespace Final
{
    public partial class ForumPosts : Form
    {
        private Login loginForm;
        private readonly Models.Forum forum;
        private bool isOpen = false;
        public ForumPosts()
        {
            InitializeComponent();
        }

        private void ForumPosts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(finalDataSet.Products);
            // TODO: This line of code loads data into the 'finalDataSet19.ForumDetails' table. You can move, or remove it, as needed.
            forumDetailsTableAdapter.FillBy(finalDataSet19.ForumDetails, Forum.value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            string username = Environment.GetEnvironmentVariable("Name");
            string password = Environment.GetEnvironmentVariable("Password");
            bool respondedNo = false;
            if (username == null || username == "" || password == null || password == "")
            {
                DialogResult result = MessageBox.Show("You must be logged in to make a post. Do you want to go to login?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (loginForm == null || loginForm.IsDisposed)
                        loginForm = new Login();
                    loginForm.Show(this);
                    Hide();
                }
                else if (result == DialogResult.No)
                {
                    respondedNo = true;
                }
            }
            if (!respondedNo)
            {
                if (isOpen)
                {
                    isOpen = false;
                    if (richTxtValue.Text == "")
                    {
                        MessageBox.Show("Can't add a forum post with no content!");
                    }
                    else
                    {
                        using (DatabaseContext context = new DatabaseContext())
                        {
                            try
                            {
                                User user = User.VerifyLogin(username, password, true);
                                ForumDetail forumDetail = new ForumDetail { Content = richTxtValue.Text, ForumId = Forum.value, UserId = user.Id };
                                context.ForumDetails.Add(forumDetail);
                                ForumPosts_Load(sender, e);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Unexpected error occurred. Returning\n\n{ex}");
                                Owner.Show();
                                Close();
                            }

                            context.SaveChanges();
                        }
                    }
                    dataGridView1.Visible = true;
                    lblContent.Visible = false;
                    richTxtValue.Visible = false;
                }
                else
                {
                    isOpen = true;
                    dataGridView1.Visible = false;
                    lblContent.Visible = true;
                    richTxtValue.Visible = true;
                }
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
