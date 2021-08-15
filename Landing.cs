﻿using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Landing : Form
    {
        private Form storeForm;
        private Form loginForm;
        private Form forumForm;
        private Form adminForm;
        public Landing()
        {
            InitializeComponent();
        }

        private void btnLoginGo_Click(object sender, EventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed)
                loginForm = new Login();
            Hide();
            loginForm.Show(this);
        }

        private void btnStoreGo_Click(object sender, EventArgs e)
        {
            if (storeForm == null || storeForm.IsDisposed)
                storeForm = new Store();
            Hide();
            storeForm.Show(this);
        }

        private void btnForumGo_Click(object sender, EventArgs e)
        {
            if (forumForm == null || forumForm.IsDisposed)
                forumForm = new Forum();
            Hide();
            forumForm.Show(this);
        }

        private void btnAdminGo_Click(object sender, EventArgs e)
        {
            if (adminForm == null || adminForm.IsDisposed)
                adminForm = new Admin();
            Hide();
            adminForm.Show(this);
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            if (Environment.GetEnvironmentVariable("Name") != null)
            {
                btnAdminGo.Visible = true;
            }
        }
    }
}
