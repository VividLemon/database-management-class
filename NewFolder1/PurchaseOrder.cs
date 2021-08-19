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
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetpo.PurchaseOrders' table. You can move, or remove it, as needed.
            this.purchaseOrdersTableAdapter.Fill(this.finalDataSetpo.PurchaseOrders);

        }
    }
}
