using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGDCAProject.InventoryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void SidebarItems_Click(object sender, EventArgs e)
        {
            LoadForm(new Items());
        }

        private void SidebarCategories_Click(object sender, EventArgs e)
        {
            LoadForm(new Categories());
        }

        private void SidebarCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new Customers());
        }

        private void SidebarBilling_Click(object sender, EventArgs e)
        {
            LoadForm(new Billing());
        }

        private void SidebarDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SidebarItemsPic_Click(object sender, EventArgs e)
        {
            LoadForm(new Items());
        }

        private void SidebarCategoriesPic_Click(object sender, EventArgs e)
        {
            LoadForm(new Categories());
        }

        private void SidebarCustomerPic_Click(object sender, EventArgs e)
        {
            LoadForm(new Customers());
        }

        private void SidebarBillingPic_Click(object sender, EventArgs e)
        {
            LoadForm(new Billing());
        }

        private void SidebarDashboardPic_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void LogoutPicture_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void LogoLabel_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }
    }
}
