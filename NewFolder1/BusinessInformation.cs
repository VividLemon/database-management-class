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
    public partial class BusinessInformation : Form
    {
        public BusinessInformation()
        {
            InitializeComponent();
        }

        private void BusinessInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetbiii.BusinessInformations' table. You can move, or remove it, as needed.
            this.businessInformationsTableAdapter.Fill(this.finalDataSetbiii.BusinessInformations);

        }
    }
}
