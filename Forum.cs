using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Forum : Form
    {
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
            // Forum has a nav at the top. The content below gets loaded with the content
            // Content could be same variable, but on tab switch, it empties it then repopulates. 
            // If nothing found, visibility = false, display nothing found.
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
