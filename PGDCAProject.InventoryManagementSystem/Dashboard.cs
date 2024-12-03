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


        //private void ItemsPanel_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Items items = new Items();
        //    items.ShowDialog();
        //}

        //private void SidebarItems_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Items items = new Items();
        //    items.ShowDialog();
        //}

        //private void CategoriesPanel_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Categories categories = new Categories();
        //    categories.ShowDialog();
        //}

        //private void SidebarCategories_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Categories categories = new Categories();
        //    categories.ShowDialog();
        //}

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
    }
}
