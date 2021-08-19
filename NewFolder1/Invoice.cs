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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSeti.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.finalDataSeti.Invoices);

        }
    }
}
