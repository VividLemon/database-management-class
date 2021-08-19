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
    public partial class ForumA : Form
    {
        public ForumA()
        {
            InitializeComponent();
        }

        private void ForumA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetf.Forums' table. You can move, or remove it, as needed.
            this.forumsTableAdapter.Fill(this.finalDataSetf.Forums);

        }
    }
}
