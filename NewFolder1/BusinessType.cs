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
    public partial class BusinessType : Form
    {
        public BusinessType()
        {
            InitializeComponent();
        }

        private void BusinessType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetbt.BusinessTypes' table. You can move, or remove it, as needed.
            this.businessTypesTableAdapter.Fill(this.finalDataSetbt.BusinessTypes);

        }
    }
}
