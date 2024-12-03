namespace PGDCAProject.InventoryManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox2 = new PictureBox();
            SidebarItems = new Label();
            CategoriesPanel = new Panel();
            pictureBox1 = new PictureBox();
            SidebarCategories = new Label();
            label8 = new Label();
            ItemsPanel = new Panel();
            pictureBox4 = new PictureBox();
            HeaderPanel = new Panel();
            CloseBtn = new Button();
            panel9 = new Panel();
            label7 = new Label();
            SidebarPanel = new Panel();
            panel3 = new Panel();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            DashboardPanel = new Panel();
            pictureBox6 = new PictureBox();
            SidebarDashboard = new Label();
            BillingPanel = new Panel();
            pictureBox5 = new PictureBox();
            SidebarBilling = new Label();
            CustomerPanel = new Panel();
            SidebarCustomer = new Label();
            MainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            CategoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            HeaderPanel.SuspendLayout();
            panel9.SuspendLayout();
            SidebarPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            BillingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            CustomerPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // SidebarItems
            // 
            SidebarItems.AutoSize = true;
            SidebarItems.Font = new Font("Microsoft Sans Serif", 10F);
            SidebarItems.Location = new Point(42, 16);
            SidebarItems.Name = "SidebarItems";
            SidebarItems.Size = new Size(59, 20);
            SidebarItems.TabIndex = 0;
            SidebarItems.Text = "ITEMS";
            SidebarItems.Click += SidebarItems_Click;
            // 
            // CategoriesPanel
            // 
            CategoriesPanel.Controls.Add(pictureBox1);
            CategoriesPanel.Controls.Add(SidebarCategories);
            CategoriesPanel.Location = new Point(32, 246);
            CategoriesPanel.Name = "CategoriesPanel";
            CategoriesPanel.Size = new Size(201, 43);
            CategoriesPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // SidebarCategories
            // 
            SidebarCategories.AutoSize = true;
            SidebarCategories.Font = new Font("Microsoft Sans Serif", 10F);
            SidebarCategories.Location = new Point(42, 12);
            SidebarCategories.Name = "SidebarCategories";
            SidebarCategories.Size = new Size(117, 20);
            SidebarCategories.TabIndex = 0;
            SidebarCategories.Text = "CATEGORIES";
            SidebarCategories.Click += SidebarCategories_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 22F);
            label8.Location = new Point(693, 344);
            label8.Name = "label8";
            label8.Size = new Size(212, 42);
            label8.TabIndex = 26;
            label8.Text = "Dashboard ";
            // 
            // ItemsPanel
            // 
            ItemsPanel.Controls.Add(pictureBox2);
            ItemsPanel.Controls.Add(SidebarItems);
            ItemsPanel.Location = new Point(32, 183);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(201, 46);
            ItemsPanel.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = SystemColors.ScrollBar;
            HeaderPanel.Controls.Add(CloseBtn);
            HeaderPanel.Controls.Add(panel9);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(276, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1656, 90);
            HeaderPanel.TabIndex = 25;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Red;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(1588, 27);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(48, 35);
            CloseBtn.TabIndex = 5;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label7);
            panel9.Location = new Point(0, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(520, 84);
            panel9.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.Location = new Point(20, 29);
            label7.Name = "label7";
            label7.Size = new Size(482, 24);
            label7.TabIndex = 0;
            label7.Text = "ELECTRONICS INVENTORY MANAGEMENT SYSTEM\r\n";
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(192, 192, 255);
            SidebarPanel.Controls.Add(panel3);
            SidebarPanel.Controls.Add(panel7);
            SidebarPanel.Controls.Add(DashboardPanel);
            SidebarPanel.Controls.Add(BillingPanel);
            SidebarPanel.Controls.Add(CustomerPanel);
            SidebarPanel.Controls.Add(ItemsPanel);
            SidebarPanel.Controls.Add(CategoriesPanel);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(276, 1049);
            SidebarPanel.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(35, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 162);
            panel3.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label12.Location = new Point(34, 90);
            label12.Name = "label12";
            label12.Size = new Size(141, 26);
            label12.TabIndex = 6;
            label12.Text = "EIM System";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(32, 1003);
            panel7.Name = "panel7";
            panel7.Size = new Size(185, 39);
            panel7.TabIndex = 11;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(40, 9);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 0;
            label6.Text = "LOGOUT";
            // 
            // DashboardPanel
            // 
            DashboardPanel.Controls.Add(pictureBox6);
            DashboardPanel.Controls.Add(SidebarDashboard);
            DashboardPanel.Location = new Point(32, 435);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(201, 44);
            DashboardPanel.TabIndex = 7;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // SidebarDashboard
            // 
            SidebarDashboard.AutoSize = true;
            SidebarDashboard.Font = new Font("Microsoft Sans Serif", 10F);
            SidebarDashboard.Location = new Point(43, 13);
            SidebarDashboard.Name = "SidebarDashboard";
            SidebarDashboard.Size = new Size(118, 20);
            SidebarDashboard.TabIndex = 0;
            SidebarDashboard.Text = "DASHBOARD";
            SidebarDashboard.Click += SidebarDashboard_Click;
            // 
            // BillingPanel
            // 
            BillingPanel.Controls.Add(pictureBox5);
            BillingPanel.Controls.Add(SidebarBilling);
            BillingPanel.Location = new Point(32, 372);
            BillingPanel.Name = "BillingPanel";
            BillingPanel.Size = new Size(201, 46);
            BillingPanel.TabIndex = 8;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // SidebarBilling
            // 
            SidebarBilling.AutoSize = true;
            SidebarBilling.Font = new Font("Microsoft Sans Serif", 10F);
            SidebarBilling.Location = new Point(43, 13);
            SidebarBilling.Name = "SidebarBilling";
            SidebarBilling.Size = new Size(74, 20);
            SidebarBilling.TabIndex = 0;
            SidebarBilling.Text = "BILLING";
            SidebarBilling.Click += SidebarBilling_Click;
            // 
            // CustomerPanel
            // 
            CustomerPanel.Controls.Add(pictureBox4);
            CustomerPanel.Controls.Add(SidebarCustomer);
            CustomerPanel.Location = new Point(32, 307);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(201, 46);
            CustomerPanel.TabIndex = 9;
            // 
            // SidebarCustomer
            // 
            SidebarCustomer.AutoSize = true;
            SidebarCustomer.Font = new Font("Microsoft Sans Serif", 10F);
            SidebarCustomer.Location = new Point(43, 15);
            SidebarCustomer.Name = "SidebarCustomer";
            SidebarCustomer.Size = new Size(104, 20);
            SidebarCustomer.TabIndex = 0;
            SidebarCustomer.Text = "CUSTOMER";
            SidebarCustomer.Click += SidebarCustomer_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(label8);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1932, 1049);
            MainPanel.TabIndex = 27;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1932, 1049);
            Controls.Add(HeaderPanel);
            Controls.Add(SidebarPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            CategoriesPanel.ResumeLayout(false);
            CategoriesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            HeaderPanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            SidebarPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            BillingPanel.ResumeLayout(false);
            BillingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            CustomerPanel.ResumeLayout(false);
            CustomerPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Label SidebarItems;
        private Panel CategoriesPanel;
        private PictureBox pictureBox1;
        private Label SidebarCategories;
        private Label label8;
        private Panel ItemsPanel;
        private PictureBox pictureBox4;
        private Panel HeaderPanel;
        private Button CloseBtn;
        private Panel panel9;
        private Label label7;
        private Panel SidebarPanel;
        private Panel panel3;
        private Label label12;
        private PictureBox pictureBox3;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Label label6;
        private Panel DashboardPanel;
        private PictureBox pictureBox6;
        private Label SidebarDashboard;
        private Panel BillingPanel;
        private PictureBox pictureBox5;
        private Label SidebarBilling;
        private Panel CustomerPanel;
        private Label SidebarCustomer;
        private Panel MainPanel;
    }
}