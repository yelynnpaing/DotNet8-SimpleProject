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
            label14 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            NewBtn = new Button();
            txtItemId = new MaskedTextBox();
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
            txtItem.Location = new Point(282, 48);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(216, 26);
            txtItem.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(300, 447);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 5;
            label9.Text = "Item List";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(517, 25);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 5;
            label10.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(757, 48);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 26);
            txtPrice.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(757, 25);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 5;
            label11.Text = "Price";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(995, 48);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(216, 26);
            txtStock.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(995, 25);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 5;
            label12.Text = "Stock";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(1230, 48);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(216, 26);
            txtManufacturer.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1230, 25);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 5;
            label13.Text = "Manufacturer";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(517, 48);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(215, 28);
            cboCategory.TabIndex = 6;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Location = new Point(757, 103);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(138, 41);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(592, 103);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 41);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(926, 103);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 41);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete Item";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // dgItemList
            // 
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemList.Location = new Point(302, 478);
            dgItemList.Name = "dgItemList";
            dgItemList.RowHeadersWidth = 51;
            dgItemList.Size = new Size(1288, 506);
            dgItemList.TabIndex = 8;
            dgItemList.Click += dgItemList_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(282, 25);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 9;
            label14.Text = "Item";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(NewBtn);
            groupBox1.Controls.Add(txtItemId);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(UpdateBtn);
            groupBox1.Controls.Add(DeleteBtn);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtItem);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtManufacturer);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(302, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1477, 162);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "Item ID";
            // 
            // NewBtn
            // 
            NewBtn.BackColor = Color.DodgerBlue;
            NewBtn.ForeColor = Color.White;
            NewBtn.Location = new Point(430, 103);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(138, 41);
            NewBtn.TabIndex = 8;
            NewBtn.Text = "New";
            NewBtn.UseVisualStyleBackColor = false;
            NewBtn.Click += NewBtn_Click;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(41, 50);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(216, 26);
            txtItemId.TabIndex = 11;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1054);
            Controls.Add(dgItemList);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Items";
            Text = "Items";
            WindowState = FormWindowState.Maximized;
            Load += Items_Load;
            ((System.ComponentModel.ISupportInitialize)dgItemList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button NewBtn;
        private Label label1;
        private MaskedTextBox txtItemId;
    }
}