using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Forum : Form
    {
        public static int value = 0;
        private ForumPosts forumPosts;
        public Forum()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void Forum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet18.Forums' table. You can move, or remove it, as needed.
            forumsTableAdapter.Fill(finalDataSet18.Forums);
            // Forum has a nav at the top. The content below gets loaded with the content
            // Content could be same variable, but on tab switch, it empties it then repopulates. 
            // If nothing found, visibility = false, display nothing found.
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                value = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (value > 0)
                {
                    if (forumPosts == null || forumPosts.IsDisposed)
                        forumPosts = new ForumPosts();
                    Hide();
                    forumPosts.Show(this);
                }
                else
                {
                    MessageBox.Show("Unexpected error. Incorrect Id value...");
                }
            }
        }
    }
}
