using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.forumDetailsTableAdapter.Fill(this.finalDataSetfd.ForumDetails);

        }
    }
}
