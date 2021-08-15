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
            // TODO: This line of code loads data into the 'finalDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.finalDataSet2.Products);
            // TODO: This line of code loads data into the 'finalDataSet1.Products' table. You can move, or remove it, as needed.
            productsTableAdapter1.Fill(finalDataSet1.Products);
            // TODO: This line of code loads data into the 'finalDataSet.Products' table. You can move, or remove it, as needed.
            productsTableAdapter.Fill(finalDataSet.Products);

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
