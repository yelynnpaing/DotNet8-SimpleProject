namespace PGDCAProject.InventoryManagementSystem
{
    partial class Billing
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
            label14 = new Label();
            dgItemList = new DataGridView();
            ItemId = new DataGridViewTextBoxColumn();
            IName = new DataGridViewTextBoxColumn();
            ICategory = new DataGridViewTextBoxColumn();
            IPrice = new DataGridViewTextBoxColumn();
            IStock = new DataGridViewTextBoxColumn();
            IManufacutrer = new DataGridViewTextBoxColumn();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            txtManufacturer = new MaskedTextBox();
            txtStock = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            txtItem = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label10 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgItemList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13F);
            label8.Location = new Point(303, 104);
            label8.Name = "label8";
            label8.Size = new Size(204, 26);
            label8.TabIndex = 16;
            label8.Text = "Billing Management";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(303, 201);
            label14.Name = "label14";
            label14.Size = new Size(39, 20);
            label14.TabIndex = 31;
            label14.Text = "Item";
            // 
            // dgItemList
            // 
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemList.Columns.AddRange(new DataGridViewColumn[] { ItemId, IName, ICategory, IPrice, IStock, IManufacutrer });
            dgItemList.Location = new Point(302, 372);
            dgItemList.Name = "dgItemList";
            dgItemList.RowHeadersWidth = 51;
            dgItemList.Size = new Size(1052, 282);
            dgItemList.TabIndex = 30;
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
            // ICategory
            // 
            ICategory.HeaderText = "ItemCategory";
            ICategory.MinimumWidth = 6;
            ICategory.Name = "ICategory";
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
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(446, 267);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 41);
            DeleteBtn.TabIndex = 27;
            DeleteBtn.Text = "Reset";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(302, 267);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 41);
            SaveBtn.TabIndex = 28;
            SaveBtn.Text = "Add to Bill";
            SaveBtn.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1015, 201);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 21;
            label13.Text = "Price";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(780, 201);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 22;
            label12.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(542, 201);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 23;
            label11.Text = "Customer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(302, 337);
            label9.Name = "label9";
            label9.Size = new Size(85, 28);
            label9.TabIndex = 25;
            label9.Text = "Item List";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(1015, 224);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(216, 27);
            txtManufacturer.TabIndex = 17;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(780, 224);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(216, 27);
            txtStock.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(542, 224);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 27);
            txtPrice.TabIndex = 19;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(303, 224);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(216, 27);
            txtItem.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, quantity, total });
            dataGridView1.Location = new Point(303, 725);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1052, 263);
            dataGridView1.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.HeaderText = "ItemId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ItemPrice";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(303, 684);
            label10.Name = "label10";
            label10.Size = new Size(93, 28);
            label10.TabIndex = 31;
            label10.Text = "Client Bill";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F);
            checkBox1.Location = new Point(303, 149);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 27);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Cash";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10F);
            checkBox2.Location = new Point(418, 149);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(75, 27);
            checkBox2.TabIndex = 34;
            checkBox2.Text = "Cards";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10F);
            checkBox3.Location = new Point(542, 149);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(93, 27);
            checkBox3.TabIndex = 35;
            checkBox3.Text = "EMoney";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1906, 1007);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(dgItemList);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(txtManufacturer);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtItem);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            Text = "Billing";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgItemList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label14;
        private DataGridView dgItemList;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private MaskedTextBox txtManufacturer;
        private MaskedTextBox txtStock;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtItem;
        private DataGridViewTextBoxColumn ItemId;
        private DataGridViewTextBoxColumn IName;
        private DataGridViewTextBoxColumn ICategory;
        private DataGridViewTextBoxColumn IPrice;
        private DataGridViewTextBoxColumn IStock;
        private DataGridViewTextBoxColumn IManufacutrer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private Label label10;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}