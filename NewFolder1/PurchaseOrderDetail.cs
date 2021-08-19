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
    public partial class PurchaseOrderDetail : Form
    {
        public PurchaseOrderDetail()
        {
            InitializeComponent();
        }

        private void PurchaseOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetpod.PurchaseOrderDetails' table. You can move, or remove it, as needed.
            this.purchaseOrderDetailsTableAdapter.Fill(this.finalDataSetpod.PurchaseOrderDetails);

        }
    }
}
