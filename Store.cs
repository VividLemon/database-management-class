using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Close();
            // Store opens up a view of different products.
            // Products have a view button which shows various info
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.finalDataSet.Products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnViewProductGo_Click(Final.Models.Product product)
        {
            MessageBox.Show("value");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO insert some dummy data
        }
    }
}
