using System;
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
            Owner.Show();
            Close();
            // Store opens up a view of different products.
            // Products have a view button which shows various info
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.Products' table. You can move, or remove it, as needed.
            productsTableAdapter1.Fill(finalDataSet1.Products);
            // TODO: This line of code loads data into the 'finalDataSet.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(finalDataSet.Products);

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
            MessageBox.Show(productGridView.ToString());
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
