﻿using System;
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
    public partial class BusinessIssue : Form
    {
        public BusinessIssue()
        {
            InitializeComponent();
        }

        private void BusinessIssue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSetbis.BusinessIssues' table. You can move, or remove it, as needed.
            this.businessIssuesTableAdapter.Fill(this.finalDataSetbis.BusinessIssues);

        }
    }
}
