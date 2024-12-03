namespace PGDCAProject.InventoryManagementSystem
{
    partial class Items
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
            label8 = new Label();
            txtItem = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            txtPrice = new MaskedTextBox();
            label11 = new Label();
            txtStock = new MaskedTextBox();
            label12 = new Label();
            txtManufacturer = new MaskedTextBox();
            label13 = new Label();
            cboCategory = new ComboBox();
            UpdateBtn = new Button();
            SaveBtn = new Button();
            DeleteBtn = new Button();
            dgItemList = new DataGridView();
            ItemId = new DataGridViewTextBoxColumn();
            IName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            IPrice = new DataGridViewTextBoxColumn();
            IStock = new DataGridViewTextBoxColumn();
            IManufacutrer = new DataGridViewTextBoxColumn();
            label14 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgItemList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(302, 158);
            label8.Name = "label8";
            label8.Size = new Size(179, 25);
            label8.TabIndex = 3;
            label8.Text = "Items Management";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(340, 243);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(216, 26);
            txtItem.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(300, 411);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 5;
            label9.Text = "Item List";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(575, 220);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 5;
            label10.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(815, 243);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 26);
            txtPrice.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(815, 220);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 5;
            label11.Text = "Price";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(1053, 243);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(216, 26);
            txtStock.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1053, 220);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 5;
            label12.Text = "Stock";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(1288, 243);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(216, 26);
            txtManufacturer.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1288, 220);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 5;
            label13.Text = "Manufacturer";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(575, 243);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(215, 28);
            cboCategory.TabIndex = 6;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Location = new Point(646, 97);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(138, 41);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(481, 97);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 41);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(815, 97);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 41);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete Item";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // dgItemList
            // 
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemList.Columns.AddRange(new DataGridViewColumn[] { ItemId, IName, Category, IPrice, IStock, IManufacutrer });
            dgItemList.Location = new Point(302, 442);
            dgItemList.Name = "dgItemList";
            dgItemList.RowHeadersWidth = 51;
            dgItemList.Size = new Size(1288, 539);
            dgItemList.TabIndex = 8;
            // 
            // ItemId
            // 
            ItemId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ItemId.HeaderText = "ItemId";
            ItemId.MinimumWidth = 6;
            ItemId.Name = "ItemId";
            ItemId.Width = 125;
            // 
            // IName
            // 
            IName.HeaderText = "ItemName";
            IName.MinimumWidth = 6;
            IName.Name = "IName";
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // IPrice
            // 
            IPrice.HeaderText = "ItemPrice";
            IPrice.MinimumWidth = 6;
            IPrice.Name = "IPrice";
            // 
            // IStock
            // 
            IStock.HeaderText = "ItemStock";
            IStock.MinimumWidth = 6;
            IStock.Name = "IStock";
            // 
            // IManufacutrer
            // 
            IManufacutrer.HeaderText = "ItemManufacutrer";
            IManufacutrer.MinimumWidth = 6;
            IManufacutrer.Name = "IManufacutrer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(340, 220);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 9;
            label14.Text = "Item";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(UpdateBtn);
            groupBox1.Controls.Add(DeleteBtn);
            groupBox1.Location = new Point(302, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1241, 162);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(319, 97);
            button1.Name = "button1";
            button1.Size = new Size(138, 41);
            button1.TabIndex = 8;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = false;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1054);
            Controls.Add(label14);
            Controls.Add(dgItemList);
            Controls.Add(cboCategory);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtManufacturer);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtItem);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Items";
            Text = "Items";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgItemList).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private MaskedTextBox txtItem;
        private Label label9;
        private Label label10;
        private MaskedTextBox txtPrice;
        private Label label11;
        private MaskedTextBox txtStock;
        private Label label12;
        private MaskedTextBox txtManufacturer;
        private Label label13;
        private ComboBox cboCategory;
        private Button UpdateBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private DataGridView dgItemList;
        private Label label14;
        private GroupBox groupBox1;
        private Button button1;
        private DataGridViewTextBoxColumn ItemId;
        private DataGridViewTextBoxColumn IName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn IPrice;
        private DataGridViewTextBoxColumn IStock;
        private DataGridViewTextBoxColumn IManufacutrer;
    }
}